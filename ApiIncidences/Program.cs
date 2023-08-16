using ApiIncidences.Extensions;
using Microsoft.EntityFrameworkCore;
using Persistence;


var builder = Microsoft.AspNetCore.Builder.WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.ConfigureCors();

//Inject DB Context
builder.Services.AddDbContext<ApiIncidencesContext>(Options =>
{
    string connectionString = builder.Configuration.GetConnectionString("ConexMysql");
    Options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
}
);





var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors("CorsPolicy");

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
