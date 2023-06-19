using DataAccessLayer.Context;
using BusinessLayer.Container;
using Microsoft.AspNetCore.Identity;
using EntityLayer.Entities;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.Authorization;
using Traversal.Models;
using FluentValidation;
using DTOLayer.DTOs.AnnouncementDTOs;
using BusinessLayer.ValidationRules;
using Traversal.CQRS.Handlers.DesHandler;
using MediatR;

var builder = WebApplication.CreateBuilder(args);


// Add services to the container.
builder.Services.AddDbContext<TraversalContext>();

builder.Services.AddAutoMapper(typeof(Program));

builder.Services.AddScoped<GetAllDesQueryHandler>();
builder.Services.AddScoped<GetDesByIDQueryHandler>();
builder.Services.AddScoped<CreateDesCommandHandler>();
builder.Services.AddScoped<RemoveDesCommandHandler>();
builder.Services.AddScoped<UpdateDesCommandHandler>();

builder.Services.AddMediatR(typeof(Program));

builder.Services.AddLogging(x =>
{

    x.ClearProviders();
    x.SetMinimumLevel(LogLevel.Debug);
    x.AddDebug();

});
//builder.Services.AddTransient<IValidator<AnnouncementAddDto>, AnnouncementValidator>();
//builder.Services.AddTransient<IValidator<AnnouncementUpdateDto>, AnnouncementValidator>();

builder.Services.AddIdentity<AppUser, AppRole>().AddEntityFrameworkStores<TraversalContext>().AddErrorDescriber<CustomIdentityVali>().AddTokenProvider<DataProtectorTokenProvider<AppUser>>(TokenOptions.DefaultProvider).AddEntityFrameworkStores<TraversalContext>();
builder.Services.AddControllersWithViews();

builder.Services.AddHttpClient();
//--------------------------------------------admin kısıtlama----------------------------------------------------------------

//builder.Services.AddMvc(config =>
//{
//    var policy = new AuthorizationPolicyBuilder()
//    .RequireAuthenticatedUser()
//    .Build();
//    config.Filters.Add(new AuthorizeFilter(policy));

//}

//);
//builder.Services.AddMvc();

//builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
//    .AddCookie(x =>
//    {

//        x.LoginPath = "/Login/Index";
//    }



//    );


//--------------------------------------------admin kısıtlama----------------------------------------------------------------

builder.Services.ContainerDependencies();




builder.Services.AddControllersWithViews();

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
app.UseAuthentication();
app.UseRouting();
app.UseStatusCodePagesWithReExecute("/ErrorPage/Errorr404"/*, "?code{}"*/);
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Index}/{action=Index}/{id?}");





app.MapControllerRoute(
    name: "Areas",
    pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}");


app.Run();