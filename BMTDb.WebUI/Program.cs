using BMTDb.Data.Abstract;
using BMTDb.Data.Concrete.EFCore;
using BMTDb.Service.Abstract;
using BMTDb.Service.Concrete;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();     //MVC

builder.Services.AddScoped<IMovieRepository, EfCoreMovieRepository>();      //Calls concrete version
builder.Services.AddScoped<IMovieService, MovieManager>();

builder.Services.AddScoped<IGenreRepository, EfCoreGenreRepository>();
builder.Services.AddScoped<IGenreService, GenreManager>();

builder.Services.AddScoped<IStudioRepository,EFCoreStudioRepository>();
builder.Services.AddScoped<IStudioService, StudioManager>();

builder.Services.AddScoped<IPersonRepository,EFCorePersonRepository>();
builder.Services.AddScoped<IPersonService, PersonManager>();

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

//localhost/admin/dashboard
app.MapControllerRoute(
    name: "AdminDashboard",
    pattern: "admin/dashboard",
    defaults: new { controller = "Admin", action = "AdminDashboard" });

//localhost/search
app.MapControllerRoute(
    name: "Search",
    pattern: "search",
    defaults: new { controller = "Movie", action = "Search" });

app.MapControllerRoute(
    name: "MovieStudio",
    pattern: "Movie/{studio?}",
    defaults: new { controller = "Movie", action = "Index" });

app.MapControllerRoute(
    name: "Movies",
    pattern: "Movies/{genre?}",
    defaults: new { controller = "Movie", action = "Index" });

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
