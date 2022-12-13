using CommunityToolkit.Maui;
using Microsoft.Extensions.Logging;
using Spotlight.ViewModels;
using Spotlight.Views;
using Spotlight.Persistence;
using Spotlight.Core.Configuration;
using Microsoft.EntityFrameworkCore;
using Spotlight.Persistence.UnitOfWork;
using Spotlight.Persistence.Repositories;

namespace Spotlight;

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
                fonts.AddFont("Font-Awesome-6-Regular.otf", "FontAwesome");
                fonts.AddFont("Material-Design.ttf", "MaterialDesign");
            });

#if DEBUG
        builder.Logging.AddDebug();
#endif

        // DI Store
        builder.Services.AddScoped(typeof(IUnitOfWork), typeof(UnitOfWork));
        builder.Services.AddScoped(typeof(IRepository<>), typeof(Repository<>));

        builder.Services.AddDbContext<SpotlightContext>(
            options => options.UseSqlite(@$"Data Source={Path.Combine(FileSystem.Current.AppDataDirectory, 
                AppConfig.DatabaseFilename)}"));

        builder.Services.AddSingleton<AppShell>();
        builder.Services.AddSingleton<ShellViewModel>();

        builder.Services.AddSingleton<Shows>();
        builder.Services.AddSingleton<ShowsViewModel>();

        var app = builder.Build();

        MigrateDatabase(app);

        return app;
	}

    private static void MigrateDatabase(MauiApp app)
    {
        using var serviceScope = app.Services.CreateScope();
        using var context = serviceScope.ServiceProvider.GetService<SpotlightContext>();

        context.Database.Migrate();
    }
}
