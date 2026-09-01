// Group leader name : Kabelo Nhlapho
// Group Student nrs : 219005935; 224042163; 224037409; 220048471; 223068452; 224136508; 224069913; 219005935
// Assignment nr     : SOD226C Practical Assessment 1 · 2026
// Purpose           : The purpose of this program is to configure application services,
//                     set up the HTTP request middleware pipeline, and start the web application.

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
} // end if

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
