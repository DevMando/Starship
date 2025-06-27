using StarshipWebApp.Components;
using Radzen;
using MudBlazor.Services;
using StarshipWebApp.Data;
using Microsoft.EntityFrameworkCore;
using StarshipWebApp.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

// Add Blazor UI Component libraries.
builder.Services.AddRadzenComponents();
builder.Services.AddMudServices();

// DbContexts
builder.Services.AddDbContext<StarWarsContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// API Services.
builder.Services.AddHttpClient<SwapiService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

// Seed the database if necessary.
using (var scope = app.Services.CreateScope())
{
    var dbContext = scope.ServiceProvider.GetRequiredService<StarWarsContext>();
    var swapiService = scope.ServiceProvider.GetRequiredService<SwapiService>();
    
    await dbContext.Database.MigrateAsync();
    await DbSeeder.SeedStarshipsAsync(dbContext, swapiService);
}

app.Run();
