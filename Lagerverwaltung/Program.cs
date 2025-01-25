using Lagerverwaltung.Components;
using Lagerverwaltung.Models;
using Lagerverwaltung.Data;
using Microsoft.EntityFrameworkCore;
using Lagerverwaltung.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// DbContext mit Connection String hinzufügen
builder.Services.AddDbContext<LagerDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("LagerverwaltungDb")));

builder.Services.AddSingleton<BenutzerService>();

builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

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

app.Run();
