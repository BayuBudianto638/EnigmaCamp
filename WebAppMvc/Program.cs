using Microsoft.Data.SqlClient;
using System.Data;
using WebAppCore.Interface;
using WebAppService.DefaultService;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
string dbConnectionString = builder.Configuration.GetConnectionString("SqlConnection");
builder.Services.AddTransient<IDbConnection>((sp) => new SqlConnection(dbConnectionString));
builder.Services.AddTransient<ICompanyAppService, CompanyAppService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
