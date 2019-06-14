using System;
using System.Linq;
using System.Reflection;
using AutoMapper;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Star.Data.DataContext;
using Star.Repository.Repositories.OfficeRepository;
using Star.Service.OfficeUoW;
using Star.Web.Features.Office;

namespace Star.Web
{
	public class Startup
	{
		public Startup(IConfiguration configuration)
		{
			Configuration = configuration;
		}

		public IConfiguration Configuration { get; }

		public void ConfigureServices(IServiceCollection services)
		{
			services.Configure<CookiePolicyOptions>(options =>
			{
				options.CheckConsentNeeded = context => true;
				options.MinimumSameSitePolicy = SameSiteMode.None;
			});

			var connectionString = Configuration.GetConnectionString("StarDatabase");
			services.AddDbContext<StarDbContext>(options => { options.UseSqlServer(connectionString); });

			services.AddScoped<OfficeRepository>();
			services.AddScoped<IOfficeUoW, OfficeUoW>();
			services.AddScoped<IOfficeViewModelFactory, OfficeViewModelFactory>();

			services.AddAutoMapper(LoadAssembliesForAutoMapper());
			services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
		}

		public void Configure(IApplicationBuilder app, IHostingEnvironment env)
		{
			if (env.IsDevelopment())
			{
				app.UseDeveloperExceptionPage();
			}
			else
			{
				app.UseExceptionHandler("/Home/Error");
				// The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
				app.UseHsts();
			}

			app.UseHttpsRedirection();
			app.UseStaticFiles();
			app.UseCookiePolicy();

			app.UseMvc(routes =>
			{
				routes.MapRoute(
					name: "default",
					template: "{controller=Home}/{action=Index}/{id?}");
			});
		}

		public Assembly[] LoadAssembliesForAutoMapper()
		{
			var starWebAssembly = Assembly.GetExecutingAssembly();
			var starServiceAssembly = AppDomain.CurrentDomain.GetAssemblies()
				.First(a => a.FullName.StartsWith("Star.Data"));

			return new[] { starWebAssembly, starServiceAssembly };
		}
	}
}
