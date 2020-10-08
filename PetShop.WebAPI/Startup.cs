using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Newtonsoft.Json;
using PetShop.Core.ApplicationService;
using PetShop.Core.ApplicationService.Services;
using PetShop.Core.DomainService;
using PetShop.Core.Entity;
using PetShop.Infrastructer.SQLite;
using PetShop.Infrastructer.SQLite.Data.Repositories;
using System;
using System.ComponentModel.DataAnnotations;

namespace PetShop.WebAPI
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
            services.AddControllers();

            services.AddSwaggerGen(optione => {
                optione.SwaggerDoc("v1", new Microsoft.OpenApi.Models.OpenApiInfo
                {
                    Title = "Swagger Demo",
                    Description = "getr",
                    Version = "v1"
                });
            
            });

            services.AddCors(options =>
                options.AddDefaultPolicy(
                    builder =>
                    {
                        builder.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader();
                    })
            );

            services.AddDbContext<PetShopContext>(

                opt => opt.UseSqlite("Data Source=petShop.db")
                );



            services.AddTransient<IPetShopRepository, PetShopRepository>();
            services.AddScoped<IPetShopService, PetShopService>();
            services.AddTransient<IOwnerRepository, OwnerRepository>();
            services.AddScoped<IOwnerService, OwnerService>();
            services.AddTransient<IPetTypeRepository, PetTypeRepository>();
            services.AddScoped<ITypeService, PetTypeService>();
            services.AddControllers().AddNewtonsoftJson(o =>
            {
                o.SerializerSettings.ReferenceLoopHandling = ReferenceLoopHandling.Ignore;
                o.SerializerSettings.MaxDepth = 5;

            });

            var serviceProvider = services.BuildServiceProvider();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                using (var scope = app.ApplicationServices.CreateScope())
                {
                    var ctx = scope.ServiceProvider.GetService<PetShopContext>();
                    ctx.Database.EnsureDeleted();
                    ctx.Database.EnsureCreated();
                    var pet = ctx.Pets.Add(new Pet()
                    {
                        PetName = "Max",
                        PetType = "Dog",
                        Birthday = DateTime.Parse("2000-01-01"),
                        SoldDate = DateTime.Parse("2001-02-03"),
                        PetColor = "brown",
                        PreviousOwner = "Someone Cool",
                        PetPrice = 2000
                    }).Entity;

                    ctx.Pets.Add(new Pet()
                    {
                        PetName = "Mox",
                        PetType = "Cat",
                        Birthday = DateTime.Parse("2002-01-01"),
                        SoldDate = DateTime.Parse("2003-02-03"),
                        PetColor = "Black",
                        PreviousOwner = "Someone Rad",
                        PetPrice = 1200
                    });

                    ctx.Owners.Add(new Owner()
                    {
                        OwnerName = "Frank"
                    });

                    ctx.PetTypes.Add(new PetType()
                    {
                        Type = "Cat"
                    });

                    ctx.SaveChanges();
                }
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseCors();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

            app.UseSwagger();

            app.UseSwaggerUI(option => {
                option.SwaggerEndpoint("/swagger/v1/Swagger.json", "Swagger Demo API");
            
            });
        }
    }
}
