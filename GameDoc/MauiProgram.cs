using GameDoc.Services;
using GameDoc.View;
using GameDoc.ViewModel;
using Microsoft.Extensions.Logging;

namespace GameDoc
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

            builder.Services.AddSingleton<RestService>();
            builder.Services.AddSingleton<GameService>();
            builder.Services.AddSingleton<GameListViewModel>();
            builder.Services.AddSingleton<FlyoutMenuViewModel>();
            builder.Services.AddSingleton<GameDetailsViewModel>();
            builder.Services.AddSingleton<FlyoutMenu>();
            builder.Services.AddSingleton<GameListView>();
            builder.Services.AddSingleton<GameDetails>();
            builder.Services.AddSingleton<MainPage>();
            
#if DEBUG
            builder.Logging.AddDebug();
#endif
           
            return builder.Build();
        }
    }
}
