using GameDoc.Model;
using GameDoc.Services;
using GameDoc.ViewModel;
using Microsoft.Maui.Controls;
using System.Collections.ObjectModel;

namespace GameDoc
{
    public partial class MainPage : ContentPage
    {
        
        public GameListViewModel ViewModel { get; set; }
        
        public MainPage(GameListViewModel gameListViewModel)
        {

            InitializeComponent();
            ViewModel = gameListViewModel;
            BindingContext = ViewModel;
            propertylist.SelectedItem = "Name";
            // LoadList();

        }

        private async void listView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            ListView lv = (ListView)sender;
            await Shell.Current.GoToAsync($"gamedetails", new Dictionary<string, Object>
        {
            {
                "GameObj",lv.SelectedItem
            }
        });

        }

        private void Sort_Clicked(object sender, EventArgs e)
        {
            ViewModel.IsLoading = true;
            string order = rba.IsChecked?rba.Value.ToString(): rbd.Value.ToString();
            ViewModel.SortGames(order, propertylist.SelectedItem.ToString());
            ViewModel.IsLoading = false;
        }

        private void AscendingSort_Clicked(object sender, EventArgs e)
        {
            ViewModel.IsLoading = true;
            string order = rba.Value.ToString();
            ViewModel.SortGames(order, propertylist.SelectedItem.ToString());
            ViewModel.IsLoading = false;
        }

        private void DescendingSort_Clicked(object sender, EventArgs e)
        {
            ViewModel.IsLoading = true;
            string order = rbd.Value.ToString();
            ViewModel.SortGames(order, propertylist.SelectedItem.ToString());
            ViewModel.IsLoading = false;
        }

        /*protected async override void OnAppearing()
        {
            base.OnAppearing();
            var gameslist = await GameServices.GetTasksAsync();
            foreach (var item in gameslist)
            {
                Games.Add(item);
            }
            Console.WriteLine(Games[0].Name);
            IsLoading = false;
        }*/

        /*protected async void LoadList()
        {
            var gameslist = await GameServices.GetTasksAsync();
            foreach (var item in gameslist)
            {
                Games.Add(item);
            }
            Console.WriteLine(Games[0].Name);
        }*/




    }

}
