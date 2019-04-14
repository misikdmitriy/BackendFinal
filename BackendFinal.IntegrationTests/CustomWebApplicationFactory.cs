using System.IO;
using BackendFinal.Db.Context;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace BackendFinal.IntegrationTests
{
	public class CustomWebApplicationFactory<TStartup>
		: WebApplicationFactory<TStartup> where TStartup : class
	{
		protected override IWebHostBuilder CreateWebHostBuilder()
		{
			return WebHost.CreateDefaultBuilder()
				.UseContentRoot(Directory.GetCurrentDirectory())
				.UseStartup<TStartup>();
		}

		protected override void ConfigureWebHost(IWebHostBuilder builder)
		{
			builder.ConfigureServices(services =>
			{
				// Add a database context (ApplicationDbContext) using an in-memory 
				// database for testing.
				services.AddDbContext<AppDbContext>(options =>
				{
					options.UseSqlite("Data Source=test.db");
				});

				// Build the service provider.
				var sp = services.BuildServiceProvider();

				// Create a scope to obtain a reference to the database
				// context (ApplicationDbContext).
				using (var scope = sp.CreateScope())
				{
					var scopedServices = scope.ServiceProvider;
					var db = scopedServices.GetRequiredService<AppDbContext>();

					//CreateTestDb(db);
				}
			});
		}
	}
}
