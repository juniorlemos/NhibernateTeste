using NhibernateTeste.Extension;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.


var coonStr = "Data Source=LAPTOP-LHL01L2S;Initial Catalog = Produto; Integrated Security = SSPI;";


builder.Services.AddControllersWithViews();

builder.Services.AddNHibernate(coonStr);



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
