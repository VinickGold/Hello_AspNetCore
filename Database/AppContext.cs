using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;


namespace Database
{
	public class MyAppContext : DbContext
	{
		public MyAppContext(DbContextOptions<MyAppContext> options) : base(options) { }
	}
}
