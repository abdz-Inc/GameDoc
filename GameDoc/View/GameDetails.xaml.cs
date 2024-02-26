using GameDoc.Model;
using GameDoc.ViewModel;
using System.ComponentModel;

namespace GameDoc.View;

[QueryProperty("GameObj", "GameObj")]
public partial class GameDetails : ContentPage
{
	Game gameObj = new Game();
	public Game GameObj
	{
		get => gameObj;
		set
		{
			gameObj = value;
			OnPropertyChanged(nameof(GameObj));
        }
	}
	public GameDetails()
	{
		InitializeComponent();
		BindingContext = this;
	}
}