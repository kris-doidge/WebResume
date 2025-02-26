using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using WebResume.Data;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddHttpClient();

builder.Services.AddRazorPages();

// Add services to the container.
builder.Services.AddControllersWithViews(); // Add MVC support
builder.Services.AddSingleton<IExperienceData, ExperienceData>();
builder.Services.AddSingleton<IGitReposData, GitReposData>();
builder.Services.AddSingleton<ITechnologyData, TechnologyData>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}
else
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseRouting();
// app.UseAuthorization();
app.MapRazorPages();
app.UseCors();
app.UseHttpsRedirection();
app.UseStaticFiles();


app.Run();
