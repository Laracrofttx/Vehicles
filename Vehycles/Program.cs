using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Vehycle.Data.Models;
using Vehycles.Data;

namespace Vehycles
{
	public class Program
	{
		public static void Main(string[] args)
		{
			WebApplicationBuilder builder = WebApplication.CreateBuilder(args);

			// Add services to the container.
			string connectionString = builder.Configuration.GetConnectionString("DefaultConnection")
				?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");


			builder.Services.AddDbContext<VehyclePlatformDbContext>(options =>
				options.UseSqlServer(connectionString));
			

			builder.Services.AddDatabaseDeveloperPageExceptionFilter();

			builder.Services.AddDefaultIdentity<ApplicationUser>(options =>
			{
				options.SignIn.RequireConfirmedAccount =
				builder.Configuration.GetValue<bool>("Identity:SignIn:RequireConfirmedAccount");

				options.Password.RequireLowercase =
				builder.Configuration.GetValue<bool>("Identity:Password:RequireLowercase");

				options.Password.RequireUppercase =
				builder.Configuration.GetValue<bool>("Identity:Password:RequireUppercase");

				options.Password.RequireNonAlphanumeric =
				builder.Configuration.GetValue<bool>("Identity:Password:RequireNonAlphanumeric");

				options.Password.RequiredLength =
				builder.Configuration.GetValue<int>("Identity:Password:RequiredLength");
			})
			.AddRoles<IdentityRole<Guid>>()
			.AddEntityFrameworkStores<VehyclePlatformDbContext>();


            builder.Services.ConfigureApplicationCookie(cfg =>
			{
				cfg.LoginPath = "/User/Login";
				cfg.AccessDeniedPath = "/Home/Error/401";
			});

			builder.Services.AddControllersWithViews();

			WebApplication app = builder.Build();

			// Configure the HTTP request pipeline.
			if (app.Environment.IsDevelopment())
			{
				app.UseMigrationsEndPoint();
				app.UseDeveloperExceptionPage();
			}
			else
			{
				app.UseExceptionHandler("/Home/Error");
				// The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
				app.UseHsts();
			}

			app.UseHttpsRedirection();
			app.UseStaticFiles();

			app.UseRouting();

			app.UseAuthentication();
			app.UseAuthorization();

			app.UseEndpoints(config =>
			{



			});

			app.MapDefaultControllerRoute();
				
			app.MapRazorPages();

			app.Run();
		}
	}
}
