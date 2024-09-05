using Microsoft.EntityFrameworkCore;
using shearwell_test.Components;
using shearwell_test.DataAccess;
using shearwell_test.Services;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<UnitOfWork>();
builder.Services.AddScoped<GroupService>();
builder.Services.AddScoped<AnimalService>();
builder.Services.AddScoped<AnimalGroupRelService>();
// Add services to the container.
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
