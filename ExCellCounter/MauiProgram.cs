using CommunityToolkit.Maui;
using ExCellCounter.Shared.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace ExCellCounter
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .UseMauiCommunityToolkit()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

#if DEBUG
    		builder.Logging.AddDebug();
#endif

            RegisterDependencies(builder.Services, new Services.DependencyRegistrant());
            RegisterDependencies(builder.Services, new Presentation.DependencyRegistrant());

            return builder.Build();
        }

        private static void RegisterDependencies(IServiceCollection services, IDependenyRegistrant dependenyRegistrant)
        {
            dependenyRegistrant.Register(services);
        }
    }
}
