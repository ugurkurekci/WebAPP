using PersonalWebAPPMvc.Business;
using PersonalWebAPPMvc.Models.Repository;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddMyServices();
builder.Services.RegisterRepositories();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

//app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();

app.UseAuthorization();

//app.MapControllerRoute(
//    name: "default",
//    pattern: "{controller=Home}/{action=Index}/{id?}");
app.UseEndpoints(endpoints => //Core 3.1 ile beraber artik yönlendiremeler bu sekilde yapiliyor..
{
    endpoints.MapAreaControllerRoute(

        name: "Admin",
        areaName: "Admin",
        pattern: "Admin/{controller=Home}/{action=Index}/{id?}" //Admin areas sayfa yönlendirmesi.
        );

    endpoints.MapDefaultControllerRoute(); //Home Controller Index sayfasi


});

app.Run();
