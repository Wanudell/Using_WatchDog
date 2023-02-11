namespace Helper.cs.BaseHelpers;

public static class WatchDogAppConfiguration
{
    public static WebApplication WatchDogAppSettings(this WebApplication app, IConfiguration config)
    {
        var userName = config.GetValue<string>("WatchDog:UserName");
        var password = config.GetValue<string>("WatchDog:Password");

        app.UseWatchDog(opt =>
        {
            opt.WatchPageUsername = userName;
            opt.WatchPagePassword = password;
            opt.Blacklist = "";
        });

        return app;
    }
}