using Microsoft.EntityFrameworkCore;
using ShoeFactory.Infraestructure;
using ShoeFactory.Persistence;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddDbContext<ShoeFactoryDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("ShoeFactoryDb"));
});

builder.Services.AddControllers();

builder.Services
    .AddRepositories()
    .AddServices();

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

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
