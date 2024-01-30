using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using TestApiForPostgreAndGraphQL;
using TestApiForPostgreAndGraphQL.Interface_s;
using TestApiForPostgreAndGraphQL.Query;
using TestApiForPostgreAndGraphQL.Schemas;
using TestApiForPostgreAndGraphQL.Service;
using TestApiForPostgreAndGraphQL.Types;
using GraphQL;
using GraphQL.Types;
using TestApiForPostgreAndGraphQL.Mutations;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<ApplicationDb>(options => options.UseNpgsql("User ID=postgres;Password=1234;Host=localhost;Port=5432;Database=NewFuckingDb;"));
builder.Services.AddTransient<IPersonRepository, PersonRepository>();

builder.Services.AddTransient<PersonType>();
builder.Services.AddTransient<PersonsQuery>();
builder.Services.AddTransient<PersonMutation>();


builder.Services.AddGraphQLServer()
    .AddQueryType<PersonsQuery>()
    .AddProjections()
    .AddMutationConventions()
    .RegisterService<PersonRepository>()
    .AddMutationType<PersonMutation>();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();


}
app.MapGraphQL("/graphql");
app.UseRouting();
app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();
app.Run();
