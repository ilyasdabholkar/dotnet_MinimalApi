using DataAccess.Data;
using DataAccess.DbAccess;
using MinimalApi;

var builder = WebApplication.CreateBuilder(args);

builder.Services.RegisterServices();

var app = builder.Build();

app.RegisterMiddlewares();

app.ConfigureApi();

app.Run();
