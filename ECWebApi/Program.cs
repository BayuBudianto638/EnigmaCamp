using EnigmaCore.Interface;
using EnigmaData.Database;
using EnigmaService.DefaultService;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Create DBContext Service
var connectionString = builder.Configuration.GetConnectionString("DBConnection");
builder.Services.AddDbContext<SchoolContext>(option => option.UseSqlServer(connectionString));

// Create DI Service
builder.Services.AddTransient<IStudent, StudentService>();

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

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.MapControllers();

app.Run();
