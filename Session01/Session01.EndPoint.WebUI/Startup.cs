﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Session01.Data.EF.Common;
using Session01.Data.EF.Customers;
using Session01.Data.EF.Goods;
using Session01.Data.EF.Orders;
using Session01.Data.EF.Salesmans;
using Session01.Domain.ApplicationServices.Customers.Query;
using Session01.Domain.Contracts.Customers;
using Session01.Domain.Contracts.Goods;
using Session01.Domain.Contracts.Orders;
using Session01.Domain.Contracts.Salesmans;

namespace Session01.EndPoint.WebUI
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
            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });

            services.AddDbContext<Session01DbContext>(options =>
                                                        options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));


            services.AddScoped<ICustomerRepository, CustomerRepository>();
            services.AddScoped<IOrderRepository, OrderRepository>();
            services.AddScoped<ISalesmanRepository, SalesmanRepository>();
            services.AddScoped<IGoodRepository, GoodRepository>();

            services.AddScoped<IGetAllCustomerQuery, GetAllCustomerQuery>();
            services.AddScoped<IGetAllOrderQuery, GetAllOrderQuery>();
            services.AddScoped<IGetAllSalesmanQuery, GetAllSalesmanQuery>();
            services.AddScoped<IGetAllGoodQuery, GetAllGoodQuery>();

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            using (var serviceScope = app.ApplicationServices.GetService<IServiceScopeFactory>().CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<Session01DbContext>();

                context.Database.Migrate();
            }
                if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
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
    }
}
