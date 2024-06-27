using Microsoft.EntityFrameworkCore;
using Model6.Data;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSwaggerGen();

//µù¥U CORS
builder.Services.AddCors(options => {
    options.AddPolicy("default", b => { 
        b.AllowAnyOrigin ().AllowAnyMethod ().AllowAnyHeader ();
    });
});

builder.Services.AddControllers();
//builder.Services.AddControllers().AddJsonOptions(o=>o.JsonSerializerOptions.PropertyNamingPolicy=null);
//builder.Services.AddControllers(o=>o.RespectBrowserAcceptHeader=true).AddXmlSerializerFormatters();

builder.Services.AddDbContext<TodoContext>( options => 
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("default"));
});

//==================================================================
var app = builder.Build();
if (app.Environment.IsDevelopment())
{ 
    app.UseSwagger();
    app.UseSwaggerUI();
}
//³]©w CORS
app.UseCors();
app.MapControllers();
app.Run();
