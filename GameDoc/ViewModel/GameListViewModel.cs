using GameDoc.Model;
using GameDoc.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace GameDoc.ViewModel
{
    public class GameListViewModel : INotifyPropertyChanged, INotifyCollectionChanged
    {
        int count = 0;
        private bool _isLoading = true;

        public bool IsLoading
        {
            get { return _isLoading; }
            set
            {
                if (_isLoading != value)
                {
                    _isLoading = value;
                    OnPropertyChanged(nameof(IsLoading));
                    OnPropertyChanged(nameof(IsNotLoading));
                }
            }
        }

        public bool IsNotLoading => !IsLoading;
        public ObservableCollection<Game> Games
        {
            get; private set;
        }

        public GameService GameServices { get; private set; }

        public event PropertyChangedEventHandler? PropertyChanged;
        public event NotifyCollectionChangedEventHandler? CollectionChanged;

        public List<PropertyInfo> Properties { get; set; }

        

        protected void OnPropertyChanged(string propertyName)
        {

            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

        }

        public GameListViewModel(GameService gameServices)
        {
            GameServices = gameServices;
            Games = [];
            var _ = new Game();
            Properties = _.GetType().GetProperties().ToList();
            GetGamesList();
        }

        protected async void GetGamesList()
        {
            var gameslist = await GameServices.GetTasksAsync();
            foreach (var item in gameslist)
            {
                Games.Add(item);
            }
            Console.WriteLine(Games[0].Name);
            IsLoading = false;
            SortGamesName("ascending");
        }

        public void SortGamesName(string order)
        {
            List<Game> sorted;
            if (order == "ascending") sorted = Games.OrderBy(obj => obj.Name).ToList();
            else sorted = Games.OrderByDescending(obj => obj.Name).ToList();
            Games.Clear();
            foreach(Game game in sorted)
            {
                Games.Add(game);
            }
            
        }

        public void SortGamesRating(string order)

        {
            List<Game> sorted;
            if(order == "ascending") sorted = Games.OrderBy(obj => obj.Rating).ToList();
            else sorted = Games.OrderByDescending(obj => obj.Rating).ToList();
            Games.Clear();
            foreach (Game game in sorted)
            {
                Games.Add(game);
            }

        }

        public void SortGames(string order, string property)
        {
            if(property == "Name") SortGamesName(order);
            else if (property == "Rating") SortGamesRating(order);
        }
    }
}
