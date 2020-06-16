using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Authorization;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MyMoviesMVC.Interfaces;
using MyMoviesMVC.Models;
using MyMoviesMVC.Repositories;
using MyMoviesMVC.Services;
using System;

namespace MyMoviesMVC
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
            services.Configure<CookiePolicyOptions>(options =>
            {
                options.CheckConsentNeeded = context => false;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });

            services.AddIdentity<User, UserRole>(options =>
            {
                options.User.RequireUniqueEmail = true;
                options.Password.RequireDigit = Convert.ToBoolean(Configuration["IdentityPassword:RequireDigit"]);
                options.Password.RequiredLength = Convert.ToInt32(Configuration["IdentityPassword:RequiredLength"]);
                options.Password.RequireUppercase = Convert.ToBoolean(Configuration["IdentityPassword:RequireUppercase"]);
                options.Password.RequireLowercase = Convert.ToBoolean(Configuration["IdentityPassword:RequireLowercase"]);
                options.Password.RequireNonAlphanumeric = Convert.ToBoolean(Configuration["IdentityPassword:RequireNonAlphanumeric"]);
            }).AddEntityFrameworkStores<mymoviesmvcContext>();

            services.ConfigureApplicationCookie(options => options.LoginPath = "/login");

            services.AddDbContext<mymoviesmvcContext>(options =>
            {
                options.UseSqlServer(Configuration.GetConnectionString("MyMovies"));
            });

            services.AddScoped<IAccountService, AccountService>();
            services.AddScoped<IMovieRepository, MovieRepository>();
            services.AddScoped<IMovieService, MovieService>();
            services.AddScoped<IUserMovieRepository, UserMovieRepository>();
            services.AddScoped<IUserMovieService, UserMovieService>();
            services.AddScoped<IMovieCommentRepository, MovieCommentRepository>();
            services.AddScoped<IMovieCommentService, MovieCommentService>();

            services.AddMvc(config =>
            {
                var policy = new AuthorizationPolicyBuilder()
                             .RequireAuthenticatedUser()
                             .Build();
                config.Filters.Add(new AuthorizeFilter(policy));
            });
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/StatusCode/GlobalError");
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseCookiePolicy();

            app.UseAuthentication();

            app.UseStatusCodePagesWithRedirects("/error/{0}");

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=UserMovie}/{action=UserMovies}");
            });
        }
    }
}
