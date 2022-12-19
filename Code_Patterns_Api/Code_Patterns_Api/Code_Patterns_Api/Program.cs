using Code_Patterns_Api.Data;
using Code_Patterns_Api.Factories;
using Code_Patterns_Api.Factory;
using Code_Patterns_Api.Handlers;
using Code_Patterns_Api.Interfaces;
using Microsoft.EntityFrameworkCore;



var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<DataContext>(x => x.UseSqlServer(builder.Configuration.GetConnectionString("Sql")));
builder.Services.AddSingleton<IProductFactory,ProductFactory>();
builder.Services.AddSingleton<ICategoryFactory,CategoryFactory>();
builder.Services.AddScoped<IProductHandler,ProductHandler>();
builder.Services.AddScoped<ICategoryHandler, CategoryHandler>();
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseCors(x => x.AllowAnyHeader().AllowAnyOrigin().AllowAnyMethod());
app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
