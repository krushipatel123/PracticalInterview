using ApplicationForm.Interface;
using ApplicationForm.Manager;
using ApplicationForm.Models;
using ApplicationForm.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace ApplicationForm
{
    public class Startup
    {
        public IConfiguration Configuration { get; }
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));

            services.AddScoped<IApplicationRepository, ApplicationRepository>();
            services.AddScoped<IAplicationManager, ApplicationManager>();

            services.AddScoped<IEducationRepository, EducationRepository>();
            services.AddScoped<IEducationManager, EducationManager>();

            services.AddScoped<IWorkExperienceRepository, WorkExperienceRepository>();
            services.AddScoped<IWorkExperienceManager, WorkExperienceManager>();

            services.AddControllers();
            services.AddControllers();
        }
    }
}
