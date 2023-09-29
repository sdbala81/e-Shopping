using eShopping.Orders.DataAccess;
using eShopping.Orders.ExternalApiHttpClients;
using eShopping.Orders.UseCases;
using eShopping.Orders.WebApi;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

var services = builder.Services;

services.AddControllers();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
services.AddEndpointsApiExplorer();
services.AddSwaggerGen();

services.AddWebApiServices();
services.AddUseCaseServices();
services.AddDataAccessServices();
services.AddHttpClientServices();

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
