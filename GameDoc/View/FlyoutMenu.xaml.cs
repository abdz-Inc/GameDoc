using GameDoc.ViewModel;

namespace GameDoc.View;

public partial class FlyoutMenu : ContentPage
{
	public FlyoutMenu(FlyoutMenuViewModel flyoutMenuViewModel)
	{
		InitializeComponent();
        BindingContext = flyoutMenuViewModel;
	}

    private void RadioButton_CheckedChanged(object sender, CheckedChangedEventArgs e)
    {

    }

    private void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
    {

    }
}