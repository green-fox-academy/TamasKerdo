using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using TripChat.Entities;
using Microsoft.EntityFrameworkCore;
using TripChat.Repositories;
using TripChat.Services;
using TripChat.ViewModels;

namespace TripChat
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();

            services.AddScoped<UserContext>();

            services.AddScoped<TripViewModel>();
            services.AddScoped<HomeViewModel>();            

            services.AddScoped<TripRepository>();
            services.AddScoped<LoginRepository>();
            services.AddScoped<HomeRepository>();

            services.AddScoped<TripService>();
            services.AddScoped<LoginService>();
            services.AddScoped<HomeService>();
            services.AddEntityFrameworkSqlServer().AddDbContext<UserContext>(options => options.UseSqlServer(@"Data Source=(localdb)\ProjectsV13;Initial Catalog=TripChat;Integrated Security=True;Connect Timeout=30;"));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseMvc();
        }
    }
}
