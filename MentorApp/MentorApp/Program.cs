using MentorApp;

var builder = WebApplication.CreateBuilder(args);
var config = builder.Configuration;
// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.Registration(config);

var app = builder.Build();
app.UseSession();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
}
app.UseStaticFiles();
app.UseAuthentication();
app.UseAuthorization();
app.UseRouting();

app.UseAuthorization();
app.MapControllerRoute(
    name:"Areas",
    pattern:"{area:exists}/{controller=dashbord}/{action=index}/{id?}"
    );
app.MapDefaultControllerRoute();
app.MapRazorPages();

app.Run();

