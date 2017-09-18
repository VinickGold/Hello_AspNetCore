using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Database;
using Microsoft.Extensions.Configuration;

namespace AspNetCoreRepo
{
    public class Startup
    {

		private IConfiguration Configuration;

		public Startup(IConfiguration configuration) 
		{
			Configuration = configuration;
		}

        public void ConfigureServices(IServiceCollection services)
        {
			DbInitializer.Initialize(services, Configuration.GetConnectionString("DefaultConnection"));
			services.AddMvc();
        }

		public void Configure(IApplicationBuilder app, IHostingEnvironment env)
		{
			if (env.IsDevelopment())
			{
				app.UseDeveloperExceptionPage();
			}

			app.UseMvc();

			app.Run(async (context) =>
			{
				await context.Response.WriteAsync("Hello World!");
			});		
		}      
    }
}
