using Degree.DAL.Context;
using Degree.DAL.Domain;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using TaskList.Domain.Repositories;
using TaskList.Domain.UnitOfWorks;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddEntityFrameworkNpgsql()
            .AddDbContext<DbContext, MyDbContext>(optionsAction => optionsAction.UseNpgsql("Server=localhost;Port=5432;Database=SocialNetworkStats;Username=postgres;Password=postgres;Persist Security Info=True"));
builder.Services.AddIdentity<User, IdentityRole>().AddEntityFrameworkStores<MyDbContext>();
builder.Services.AddMvc();
builder.Services.AddScoped(typeof(SqlRepository<,>));
builder.Services.AddScoped(typeof(SqlUnitOfWork<,>));

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
