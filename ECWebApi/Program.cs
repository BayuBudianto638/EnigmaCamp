using AutoMapper;
using ECWebApi.ConfigProfile;
using ECWebApi.Model;
using EnigmaCore.Interface;
using EnigmaData.Database;
using EnigmaService.DefaultService;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Create DBContext Service
var connectionString = builder.Configuration.GetConnectionString("DBConnection");
builder.Services.AddDbContext<SchoolContext>(option => option.UseSqlServer(connectionString));

var config = new AutoMapper.MapperConfiguration(cfg =>
{
    cfg.AddProfile(new ConfigurationProfile());
});
var mapper = config.CreateMapper();

// Create DI Service
builder.Services.AddSingleton(mapper);
builder.Services.AddTransient<IStudent, StudentService>();

builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

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

app.MapControllers();

app.Run();
