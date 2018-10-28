using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SchoolSystem.Models;
using SchoolSystem.Services;
using DataDomain.Data;
using Repositories;
using AutoMapper;
using SchoolSystem.AutoMapper;
using SchoolSystem.ViewModelFactory;

namespace SchoolSystem
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
            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("SchoolSystemConnection")));

            var config = new MapperConfiguration(map => {
                map.AddProfile(new AutoMapperProfile());
            });

            var mapper = config.CreateMapper();

            services.AddSingleton(mapper);
            services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
            services.AddScoped<IHomeworkRepository, HomeworkRepository>();
            services.AddScoped<ITeacherRepository, TeacherRepository>();
            services.AddScoped<IStudentRepository, StudentRepository>();
            services.AddScoped<ISubjectRepository, SubjectRepository>();

            // View Models
            services.AddScoped<IStudentFactory, StudentFactory>();
            services.AddScoped<IHomeworkFactory, HomeworkFactory>();
            services.AddScoped<IClassFactory, ClassFactory>();

            services.AddIdentity<ApplicationUser, IdentityRole>()
                .AddEntityFrameworkStores<ApplicationDbContext>()
                .AddDefaultTokenProviders();

            // Add application services.
            services.AddTransient<IEmailSender, EmailSender>();

            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseBrowserLink();
                app.UseDeveloperExceptionPage();
                app.UseDatabaseErrorPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }

            app.UseStaticFiles();

            app.UseAuthentication();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
        });
        }
    }
}
