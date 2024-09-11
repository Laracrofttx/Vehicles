namespace Vehycles
{
    using Vehycles.Data;
    using Vehycle.Data.Models;
    using Vehycles.Services;
    using Vehycles.Services.Interfaces;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.EntityFrameworkCore;
    public class Program
    {
        public static void Main(string[] args)
        {
            WebApplicationBuilder builder = WebApplication.CreateBuilder(args);
            builder.Services.AddControllers();
            builder.Services.AddEndpointsApiExplorer();
            // Add services to the container.
            string connectionString = builder.Configuration.GetConnectionString("DefaultConnection")
                ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");

            builder.Services.AddDbContext<VehyclePlatformDbContext>(options =>
                options.UseSqlServer(connectionString));

            builder.Services.AddDatabaseDeveloperPageExceptionFilter();

            builder.Services.AddIdentity<ApplicationUser, ApplicationRole>(options =>
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
            .AddEntityFrameworkStores<VehyclePlatformDbContext>()
            .AddDefaultTokenProviders()
            .AddRoles<ApplicationRole>();

            builder.Services.AddScoped<IVehycleService, VehycleService>();
            builder.Services.AddScoped<ICategoryService, CategoryService>();
            builder.Services.AddScoped<ISearchService, SearchService>();
            builder.Services.AddScoped<IPhotoService, PhotoService>();
            builder.Services.AddScoped<IUserService, UserService>();
            builder.Services.AddScoped<IAdService, AdService>();

            builder.Services.AddResponseCaching();
            builder.Services.ConfigureApplicationCookie(cfg =>
            {
                cfg.LoginPath = "/User/Login";
                cfg.AccessDeniedPath = "/Home/Error/401";
            });

            builder.Services.AddControllersWithViews();
            builder.Services.AddMvc();

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
                app.UseHsts();
            }

			app.UseHttpsRedirection();
			app.UseStaticFiles();

			app.UseRouting();
			app.UseResponseCaching();

			app.UseAuthentication();
			app.UseAuthorization();

            app.MapDefaultControllerRoute();
            app.MapRazorPages();

			app.Run();
		}
    }
}
