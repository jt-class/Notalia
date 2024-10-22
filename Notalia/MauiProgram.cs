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

