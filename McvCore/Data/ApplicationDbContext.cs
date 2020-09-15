using System;
using System.Collections.Generic;
using System.Text;
using McvCore.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace McvCore.Data
{
	public class ApplicationDbContext : DbContext
	{
		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
			: base(options)
		{
		}

		public DbSet<ApplicationTypeModel> ApplicationTypes { get; set; }
		public DbSet<CategoryModel> CategoryModels { get; set; }
	}
}