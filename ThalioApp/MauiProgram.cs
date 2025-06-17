﻿using Microsoft.Extensions.Logging;
using Microsoft.Maui.Handlers;

namespace Thalio
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
                    fonts.AddFont("fa-solid-900.ttf", "FASolid");
                });

#if DEBUG
    		builder.Logging.AddDebug();
#endif
          
            // Remove underline on Android Entry
#if ANDROID
        EntryHandler.Mapper.AppendToMapping("NoUnderline", (handler, view) =>
        {
            handler.PlatformView.Background = null;
        });
#endif
            return builder.Build();
        }
    }
}
