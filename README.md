# WebAPI_Using_WatchDog
WebAPI Project using WatchDog Nuget Package

https://localhost:7149/swagger/index.html adresinden execute ettiğimizde
https://localhost:7149/watchdog adresinde login işlemini yapmadan görüntüleme sağlayamıyoruz

WatchDog.NET paketini NuGet üzerinden projemize kuruyoruz

/*
Program.cs dosyamıza:
//Service kısmı için aşağıdaki kodları yazıyoruz; otomatik temizleme ve Veritabanı bağlantısı için yazıyoruz
builder.Services.AddWatchDogServices(opt =>
{    
    opt.IsAutoClear = false; 
    opt.SetExternalDbConnString = builder.Configuration.GetConnectionString(name: "SampleDbConnection");
    opt.SqlDriverOption = WatchDogSqlDriverEnum.MSSQL;
});

//Inject into the middleware bölümü
app.UseWatchDogExceptionLogger();

//Login bilgileri
app.UseWatchDog(opt =>
{
    opt.WatchPageUsername = "admin";
    opt.WatchPagePassword = "12345678";
});
*/

/*
//appsettings.json dosyamızda veritabanı bağlantısı için ConnectionStrings ekliyoruz, ismini ve yerel SQL bilgilerimizi giriyoruz(ya da kullanmak istediğimiz veritabanı bilgileri)
"ConnectionStrings": {
    "SampleDbConnection":"Server=DESKTOP-0VT0IBJ\\MSSQLSERVER1; Database=SampleLogDbApp; Trusted_Connection= True;"
*/

/*
//Get metodumuzun içerisinde hata mesajı kontrolü için (istersek post,put metotlarında da kullanabiliriz) return işleminden önce aşağıdaki kod bloğunu yazabiliriz(_logger.LogInformation yerine WatchLogger.Log kullanmalıyız):
    //_logger.LogInformation(message:"Bu sadece bir günlük kaydı");
    WatchLogger.Log(message: "Bu sadece bir günlük kaydı");
    //throw new Exception(message:"Her şey yolunda, WatchDog paketini test ediyorum");
*/
