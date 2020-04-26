using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Brainvest.Dscribe.Implementations.EfCore.All;
using Brainvest.Dscribe.Runtime;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace Dscribe.AdvancedServerTemplate.Host
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
			services.AddCors(options => options.AddPolicy("AllowAll",
				builder =>
				builder
					.AllowAnyMethod()
					.AllowAnyOrigin()
					.AllowAnyHeader()));

			RuntimeStartup.ConfigureServices(services, Configuration, (options, connectionStringName) 
				=> options.UseNpgsql(Configuration.GetConnectionString(connectionStringName)));
			services.RegisterEfCore();

			services.AddControllers()
			.AddNewtonsoftJson(options =>
			{
				options.UseMemberCasing();
			})
			.AddJsonOptions(jsonOptions =>
			{
				jsonOptions.JsonSerializerOptions.PropertyNamingPolicy = null;
			});

			services.AddAuthentication("Bearer")
				.AddIdentityServerAuthentication(options =>
				{
					options.Authority = Configuration.GetSection("AuthAuthority").Get<string>();
					options.RequireHttpsMetadata = false;
				});
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
			app.UseCors("AllowAll");
			app.UseRouting();
			app.UseAuthentication();
			RuntimeStartup.Configure(app, env);
			app.UseEndpoints(endpoints =>
			{
				endpoints.MapControllers();
			});
        }
    }
}
