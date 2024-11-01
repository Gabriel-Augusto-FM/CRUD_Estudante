using CRUD_Estudante;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

InicializadorBD.Inicializar();

var app = builder.Build(); //colocar sempre antes do build

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
