var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
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

app.UseRouting();

app.UseAuthorization();

app.UseEndpoints(endpoints => 
{
    endpoints.MapControllerRoute(
      name: "Bootstrap",
      pattern: "{area:exists}/{controller=BootstrapHulk}/{action=ModelPopup}/{id?}");


    endpoints.MapControllerRoute(
      name: "CSharp",
      pattern: "{area:exists}/{controller=CSharpIronMan}/{action=ReturnWithClass}/{id?}");

    endpoints.MapControllerRoute(
     name: "html",
     pattern: "{area:exists}/{controller=HtmlWonderWoman}/{action=BillDemo}/{id?}");

    endpoints.MapControllerRoute(
     name: "jquery",
     pattern: "{area:exists}/{controller=JqueryVission}/{action=JqueryWithCookies}/{id?}");

    endpoints.MapControllerRoute(
     name: "essix",
     pattern: "{area:exists}/{controller=JavascriptElder}/{action=PracticeA}/{id?}");

    endpoints.MapControllerRoute(
     name: "DevExpress",
     pattern: "{area:exists}/{controller=DevExpressA}/{action=DataGrid}/{id?}");


    endpoints.MapControllerRoute(
        name: "default",
        pattern: "{controller=Welcome}/{action=Index}/{id?}");
});


app.Run();
