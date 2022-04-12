using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Music_School_DB.Data;
using Music_School_DB.Domain.Party;
using Music_School_DB.Infra;
using Music_School_DB.Infra.Party;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

builder.Services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(connectionString));

builder.Services.AddDbContext<MSDb>(options => options.UseSqlServer(connectionString));

builder.Services.AddDatabaseDeveloperPageExceptionFilter();

builder.Services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
    .AddEntityFrameworkStores<ApplicationDbContext>();
builder.Services.AddRazorPages();

builder.Services.AddTransient<IInstructorsRepo, InstructorsRepo>();
builder.Services.AddTransient<IStudentRepo, StudentRepo>();

builder.Services.AddDbContext<Music_School_DBContext>(options =>

    options.UseSqlServer(builder.Configuration.GetConnectionString("Music_School_DBContext")));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseMigrationsEndPoint();
}
else
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

app.MapRazorPages();

app.Run();
