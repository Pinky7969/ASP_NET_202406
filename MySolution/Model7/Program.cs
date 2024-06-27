using Microsoft.EntityFrameworkCore;
using Model7.Models;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAll", builder => builder.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader());
    //options.AddPolicy("Test", builder => builder.WithOrigins("http://localhost:50260").AllowAnyMethod().AllowAnyHeader());
});


builder.Services.AddDbContext<MyDatabaseContext>(o => o.UseSqlite(builder.Configuration.GetConnectionString("Default")));

//==============================================================
var app = builder.Build();
if (app.Environment.IsDevelopment())
{ 
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseCors("AllowAll");
//app.UseCors("Test");

app.MapGet("/", () => "Hello World!");
app.MapGet("/Product", () => new Product(1, "Keyboard", 20.0m));
app.MapGet("/400", () => Results.BadRequest());

app.MapGet("/TodoItems", async (MyDatabaseContext context) => await context.TodoItems.ToListAsync());
app.MapGet("/TodoItems/{id}", async (MyDatabaseContext context, int id) => {
    var item = await context.TodoItems.FindAsync(id);
    if (item == null)
    { 
        return Results.NotFound();
    }
    return Results.Ok(item);
});

app.MapPost("/TodoItems", async (MyDatabaseContext context, TodoItem item) => { 
    context.TodoItems.Add(item);
    await context.SaveChangesAsync();
    return Results.Created($"/todoitems/{item.Id}", item);
});

app.MapPut("TodoItems/{id}", async (MyDatabaseContext db, int id, TodoItem item)
    =>
{
    if (id != item.Id)
    {
        return Results.BadRequest();
    }
    db.Entry(item).State = EntityState.Modified;
    try
    {
        await db.SaveChangesAsync();
    }
    catch (DbUpdateConcurrencyException)
    {
        //if (!await db.TodoItems.AnyAsync(e => e.Id == id))
        if( !await db.TodoItems.AnyAsync(i=>i.Id == id) )
        {
            return Results.NotFound();
        }
        else
        {
            throw;
        }
    }
    return Results.NoContent();
});

app.MapDelete("TodoItems/{id}", async(MyDatabaseContext context, int id) => 
{ 
    var item = await context.TodoItems.FindAsync(id);
    if (item == null)
    {
        return Results.NotFound();
    }
    context.TodoItems.Remove(item);
    await context.SaveChangesAsync();

    return Results.NoContent();
});

app.Run();
public record Product(int id, string name, decimal price);