using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Database
{
    public static class DbInitializer
    {
		public static void Initialize(IServiceCollection services , string connectionString) 
		{
			services.AddDbContext<MyAppContext>(options => options.UseSqlServer(connectionString));
		}
    }
}
