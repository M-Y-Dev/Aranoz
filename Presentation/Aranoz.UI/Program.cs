using Aranoz.UI.Models;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddHttpClient();

builder.Services.AddControllersWithViews();

builder.Services.Configure<ApiBaseUrl>(builder.Configuration.GetSection("ApiSettingBaseUrl")); // ApiBaseUrl sýnýfý ile appsetting.json da ki base url birleþtirdik.

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
      name: "areas",
      pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}"
    );
});
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
