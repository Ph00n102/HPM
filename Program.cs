using HPM.Components;
using HPM.Data;
using Microsoft.EntityFrameworkCore;
using HPM.Service;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddBlazorBootstrap();
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();
// builder.Services.AddTransient<IJobRequestService>();
builder.Services.AddTransient<JobRequestService>();



var HpmConnectionString = builder.Configuration.GetConnectionString("Hpm");
builder.Services.AddDbContext<HpmContext>(options =>options.UseSqlServer(HpmConnectionString));

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
