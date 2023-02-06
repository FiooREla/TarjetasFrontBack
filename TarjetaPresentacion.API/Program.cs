using TarjetaPresentacion.API.Extensions;
using TarjetaPresentacion.Context;
using TarjetaPresentacion.Repositories;
using TarjetaPresentacion.Repositories.Implementacion;
using TarjetaPresentacion.Repositories.Interface;
using TarjetaPresentacion.Repositories.Mock;
using TarjetaPresentacion.Services;
using TarjetaPresentacion.UOW;
using TarjetaPresentacion.UOW.Interface;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddSingleton((serviceProvider) => {

    return builder.Configuration.GetSection("Principal").Get<PrincipalConnection>();
});
builder.Services.AddScoped<IPrincipalContext, PrincipalContext>();
builder.Services.ConfigureCors();
builder.Services.ConfigureUtils();

builder.Services.AddScoped<IPrincipalUOW, PrincipalUOW>();
builder.Services.AddTransient<ITrabajadorRepository, TrabajadorRepository>();
builder.Services.AddTransient<ITrabajadorService, TrabajadorService>();




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

app.UseHttpsRedirection();
app.UseCors("CorsPolicy");
app.UseAuthorization();

app.MapControllers();

app.Run();
