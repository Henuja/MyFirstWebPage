using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using API.GraphQL;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddDbContextFactory<OMAcontext>(options =>
{
    options.UseInMemoryDatabase("InMemoryDB");

});

// graph Ql
builder.Services
    .AddGraphQLServer()
    .AddQueryType<Query>()
    .AddFiltering();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle

var app = builder.Build();

// Configure the HTTP request pipeline.
app.MapGraphQL();

app.Run();
