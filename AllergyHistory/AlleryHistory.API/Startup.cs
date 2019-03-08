using AllergyHistory.DAL;
using AllergyHistory.DAL.Repositories;
using AllergyHistory.Domain.Entities;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace AlleryHistory.API
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
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
            services.AddDbContext<AllergyHistoryContext>(opts => opts.UseSqlServer(Configuration["ConnectionStrings:AllergyHistoyDB"]));

            services.AddScoped<IRepository<Patient>, PatientRepository>();
            services.AddScoped<IRepository<AllergenHistory>, AllegenHistoryRepository>();
            services.AddScoped<IRepository<AllergenSeverity>, AllergenSeverityRepository>();
            services.AddScoped<IRepository<AllergenType>, AllergenTypeRepository>();
            services.AddScoped<IRepository<AllergenReaction>, AllergenReactionRepository>();
            services.AddScoped<IRepository<Allergen>, AllergenRepository>();
            services.AddScoped<IRepository<Drug>, DrugRepository>();





            services.AddCors(opts => opts.AddDefaultPolicy(
                builder =>
                {
                    builder.WithOrigins("*").AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod();
                }));
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
