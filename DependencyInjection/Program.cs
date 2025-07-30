using DependencyInjection.Managers;
using DependencyInjection.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddScoped<ITeacher, Teacher>();
builder.Services.AddScoped<IClassroom, Classroom>();

// Add services to the container.

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

app.UseAuthorization();

app.MapControllers();

app.Run();
