using AllergyHistory.Contract.Converters;
using AllergyHistory.DAL;
using AllergyHistory.DAL.Repositories;
using AllergyHistory.Domain.Entities;
using AllergyHistory.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Formatters;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Swashbuckle.AspNetCore.Swagger;

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
            services.AddMvc(options =>
            {
                options.RespectBrowserAcceptHeader = true;
                options.InputFormatters.Add(new XmlSerializerInputFormatter());
                options.OutputFormatters.Add(new XmlSerializerOutputFormatter());
            })
            .AddXmlSerializerFormatters().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);


            services.AddDbContext<AllergyHistoryContext>(opts => opts.UseSqlServer(Configuration["ConnectionStrings:AllergyHistoyDB"]));

            services.AddScoped<IRepository<Patient>, PatientRepository>();
            services.AddScoped<IRepository<AllergenHistory>, AllegenHistoryRepository>();
            services.AddScoped<IRepository<AllergenSeverity>, AllergenSeverityRepository>();
            services.AddScoped<IRepository<AllergenType>, AllergenTypeRepository>();
            services.AddScoped<IRepository<AllergenReaction>, AllergenReactionRepository>();
            services.AddScoped<IRepository<Allergen>, AllergenRepository>();
            services.AddScoped<IRepository<Drug>, DrugRepository>();


            services.AddScoped<IAllergenInputConverter, AllergenInputConverter>();
            services.AddScoped<IAllergyHistoryConverter, AllergyHistoryConverter>();
            services.AddScoped<IAllergenInputService, AllergenInputService>();
            services.AddScoped<IAllergyHistoryDataService, AllergyHistoryDataService>();

            services.AddCors(opts => opts.AddDefaultPolicy(
                builder =>
                {
                    builder.WithOrigins("*").AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod();
                }));

            services.AddSwaggerGen(options =>
            {
                options.SwaggerDoc("v1", new Info
                {
                    Title = "HiMA Test API",
                    Version = "v1",
                    Description = "Hims Test API",
                    TermsOfService = "Saigon Technology Solutions"
                });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseMvc();

            app.UseSwagger();
            app.UseSwaggerUI(options =>
            {
                options.SwaggerEndpoint("/swagger/v1/swagger.json", "HiMS test API v1");
            });
        }
    }
}
