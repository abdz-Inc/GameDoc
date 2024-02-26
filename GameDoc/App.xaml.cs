using GameDoc.View;
using GameDoc.ViewModel;

namespace GameDoc
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new AppShell();

            Routing.RegisterRoute("gamedetails", typeof(GameDetails));
        }
    }
}
