using GameDoc.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDoc.ViewModel
{
    public class GameDetailsViewModel : INotifyPropertyChanged
    {
        Game game;
        public Game GameObj
        {
            get => game; set
            {
                game = value;
                OnPropertyChanged(nameof(game));
            }
        }

        public GameDetailsViewModel()
        {
        }

        public event PropertyChangedEventHandler? PropertyChanged;
        protected void OnPropertyChanged(string propertyName)
        {

            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

        }
    }
}
