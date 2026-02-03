using ContactFormApp.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();

// Configure DbContext with SQL Server
builder.Services.AddDbContext<ContactFormContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseHsts(); // Default HSTS value is 30 days
}

app.UseHttpsRedirection();
app.UseStaticFiles();  // Serve wwwroot static files like CSS, JS, images

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
