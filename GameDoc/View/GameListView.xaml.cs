using GameDoc.Model;
using GameDoc.ViewModel;

namespace GameDoc.View;

public partial class GameListView : ContentPage
{
    public GameListViewModel ViewModel { get; set; }
    public GameListView(GameListViewModel gameListViewModel)
    {

        InitializeComponent();
        ViewModel = gameListViewModel;
        BindingContext = ViewModel;
        // LoadList();

    }

    private void SortButton_Clicked(object sender, EventArgs e)
    {
        //sortOptionsPopup.IsVisible = true;
    }

    private void AscendingButton_Clicked(object sender, EventArgs e)
    {

    }

    private void DescendingButton_Clicked(object sender, EventArgs e)
    {

    }

    private void SortNameButton_Clicked(object sender, EventArgs e)
    {

    }

    private void SortDateButton_Clicked(object sender, EventArgs e)
    {

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