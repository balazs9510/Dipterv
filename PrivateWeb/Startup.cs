using DAL;
using DAL.Entities;
using DAL.SeedServices;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace PrivateWeb
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });


            services.AddIdentity<User, IdentityRole>()
             // services.AddDefaultIdentity<IdentityUser>()
             .AddEntityFrameworkStores<BookingSystemDbContext>()
             .AddDefaultTokenProviders();


            var connection = @"Server=(localdb)\mssqllocaldb;Database=BookingSystem;Trusted_Connection=True;ConnectRetryCount=0";

            services.AddDbContext<BookingSystemDbContext>
                (options => options.UseSqlServer(connection))
                .AddTransient<ISeedService, SeedService>()
                .AddTransient<IImageSeedService, ImageSeedService>();

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);


        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }

            app.UseStaticFiles();
            app.UseCookiePolicy();
            app.UseAuthentication();

            app.UseMvcWithDefaultRoute();
        }
    }
}
