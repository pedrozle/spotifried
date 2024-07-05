using Microsoft.EntityFrameworkCore;
using Spotifried.Data;
using Spotifried.Helpers;
using Spotifried.Helpers.Interfaces;
using Spotifried.Repository;
using Spotifried.Repository.Interfaces;
using dotenv.net;
using Spotifried.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddEntityFrameworkSqlServer().AddDbContext<DatabaseContext>(o => o.UseSqlServer(builder.Configuration.GetConnectionString("DataBase")));
builder.Services.AddScoped<IMusicRepository, MusicRepository>();
builder.Services.AddScoped<IUserRepository, UserRepository>();
builder.Services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
builder.Services.AddHttpClient<SpotifyService>();

builder.Services.AddScoped<ISessao, Session>();
builder.Services.AddSession(o =>
{
    o.Cookie.Name = "Spotifried.Session";
    o.Cookie.HttpOnly = true;
    o.Cookie.IsEssential = true;
});

DotEnv.Load();

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

app.UseSession();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Login}/{action=Index}/{id?}");

app.Run();
