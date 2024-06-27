using Model5.Models;
using Model5.Services;
using NLog.Web;

var builder = WebApplication.CreateBuilder(args);

//https://github.com/NLog/NLog/wiki/Getting-started-with-ASP.NET-Core-6
builder.Host.UseNLog(new NLogAspNetCoreOptions() { RemoveLoggerFactoryFilter = false });

//builder.Services.AddControllers();
builder.Services.AddControllersWithViews();
//builder.Services.AddTransient<IMySerivce, MyService>();
//builder.Services.AddScoped<IMySerivce, MyService>();
builder.Services.AddSingleton<IMySerivce, MyService>();

//builder.Services.Configure<WebsiteProfileOptions>(options => 
//{
//    options.ThemeColor = " Green";
//    options.FontSize = "24px";
//});

builder.Configuration.AddInMemoryCollection(new Dictionary<string, string?>
{
    ["ThemeColor"] = "orange",
    ["FontSize"] = "10px"
});
builder.Configuration.AddJsonFile("profile.json", true, true);
builder.Configuration.AddXmlFile("profile.xml", true, true);
builder.Configuration.AddIniFile("profile.ini", true, true);
builder.Services.Configure<WebsiteProfileOptions>(builder.Configuration.GetSection("SectionA:SectionB"));
Console.WriteLine("=============================");
foreach (var item in (builder.Configuration as IConfigurationRoot).Providers)
{ 
    Console.WriteLine(item);
}
Console.WriteLine("=============================");

//builder.Logging.AddFilter((category, level) => category == "MyLog");
//builder.Logging.AddFilter((category, level) => category == "MyLog" && level >= LogLevel.Warning);

//=================================================
var app = builder.Build();

app.Environment.EnvironmentName = Environments.Production;

if (!app.Environment.IsDevelopment()) {
    app.UseExceptionHandler("/api/error");
}

//app.MapControllers();
app.MapDefaultControllerRoute();

app.Run();
