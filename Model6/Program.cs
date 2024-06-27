using Microsoft.EntityFrameworkCore;
using Model6.Data;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();
//builder.Services.AddControllers().AddJsonOptions(o=>o.JsonSerializerOptions.PropertyNamingPolicy=null);
//builder.Services.AddControllers(o=>o.RespectBrowserAcceptHeader=true).AddXmlSerializerFormatters();

builder.Services.AddDbContext<TodoContext>( options => 
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("default"));
});

var app = builder.Build();
app.MapControllers();
app.Run();
