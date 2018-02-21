using JWTAuthorization.Entities;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Identity;

namespace JWTAuthorization
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();

            services.AddScoped<GroceryListContext>();
            services.AddDbContext<GroceryListContext>(opt => opt.UseInMemoryDatabase());
            services.AddDbContext<UserDbContext>(opt => opt.UseInMemoryDatabase());

            services.AddIdentity<IdentityUser, IdentityRole>()
                    .AddEntityFrameworkStores<UserDbContext>();

            
            services.Configure<JWTSettings>(Configuration.GetSection("JWTSettings"));
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();               
            }
            app.UseMvc();
            app.UseStaticFiles();
            app.UseAuthentication();
        }
    }
}
