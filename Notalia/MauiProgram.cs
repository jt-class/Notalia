using Microsoft.Extensions.Logging;
namespace Notalia
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
                    fonts.AddFont("Eleganta.ttf", "Eleganta");
                    fonts.AddFont("Delicate-Caligraphy.ttf", "Delicate");
                    fonts.AddFont("Judson-Regular.ttf", "Judson");
                    fonts.AddFont("Judson-Bold.ttf", "JudsonBold");
                    fonts.AddFont("Judson-Italic.ttf", "JudsonItalic");
                    fonts.AddFont("Kapakana.ttf", "Kapakana");
                });
            #if ANDROID
                builder.ConfigureMauiHandlers(handlers =>
                {
                    handlers.AddHandler<Entry, CustomEntryHandler>();
                });
            #endif

            return builder.Build();
        }
    }
}

