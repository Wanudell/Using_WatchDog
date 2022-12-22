https://localhost:7149/swagger/index.html adresinden execute ettiðimizde
https://localhost:7149/watchdog adresinde login iþlemini yapmadan görüntüleme saðlayamýyoruz

WatchDog.NET paketini NuGet üzerinden projemize kuruyoruz

/*
Program.cs dosyamýza:
//Service kýsmý için aþaðýdaki kodlarý yazýyoruz; otomatik temizleme ve Veritabaný baðlantýsý için yazýyoruz
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
//appsettings.json dosyamýzda veritabaný baðlantýsý için ConnectionStrings ekliyoruz, ismini ve yerel SQL bilgilerimizi giriyoruz(ya da kullanmak istediðimiz veritabaný bilgileri)
"ConnectionStrings": {
    "SampleDbConnection":"Server=DESKTOP-0VT0IBJ\\MSSQLSERVER1; Database=SampleLogDbApp; Trusted_Connection= True;"
*/

/*
//Get metodumuzun içerisinde hata mesajý kontrolü için (istersek post,put metotlarýnda da kullanabiliriz) return iþleminden önce aþaðýdaki kod bloðunu yazabiliriz(_logger.LogInformation yerine WatchLogger.Log kullanmalýyýz):
    //_logger.LogInformation(message:"Bu sadece bir günlük kaydý");
    WatchLogger.Log(message: "Bu sadece bir günlük kaydý");
    //throw new Exception(message:"Her þey yolunda, WatchDog paketini test ediyorum");
*/