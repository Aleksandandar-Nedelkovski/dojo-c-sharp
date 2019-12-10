using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Login_Regis.Models;
using Microsoft.EntityFrameworkCore;


namespace Login_Regis
{
    public class Startup
    {

        public IConfiguration Configuration {get;}
 
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            //  string mySqlConnection = "server=localhost;userid=root;password=root;port=3306;database=mydb;SslMode=None";

            // services.AddDbContext<MyContext>(options => options.UseMySql(mySqlConnection));
 
            services.AddDbContext<MyContext>(options => options.UseMySql(Configuration["DBInfo:ConnectionString"]));
            services.AddSession();            
            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            
            app.UseSession();
            app.UseStaticFiles();
            app.UseMvc();
        }
    }
}
