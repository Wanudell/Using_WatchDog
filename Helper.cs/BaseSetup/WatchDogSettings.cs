namespace Helper.cs.BaseHelpers;

public static class WatchDogConfigurations
{
    public static IServiceCollection WatchDogSettings(this IServiceCollection services, IConfiguration config)
    {
        var settings = config.GetConnectionString("WatchDogDb");
        services.AddWatchDogServices(opt =>
        {
            opt.IsAutoClear = false;
            //İhtiyaç olursa temizleme işlemini otomatik yapmak için.
            //opt.ClearTimeSchedule = WatchDogAutoClearScheduleEnum.Monthly;
            opt.SetExternalDbConnString = settings; //PATLAYACAK
            opt.SqlDriverOption = WatchDogSqlDriverEnum.MSSQL;
        });

        return services;
    }
}