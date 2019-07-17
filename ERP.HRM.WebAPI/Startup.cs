using System;
using System.Threading.Tasks;
using AutoMapper;
using ERP.HRM.ORM;
using ERP.HRM.Services;
using ERP.HRM.Services.Interfaces;
using ERP.HRM.WebAPI.Helper;
using ERP.Repositories;
using ERP.Repositories.Interfaces;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;


namespace ERP.HRM.WebAPI
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
            var mappingConfig = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new MappingEntity());
            });
            #region Context
            services.AddDbContext<HRMContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));

            services.AddScoped<DbContext>(sp => sp.GetRequiredService<HRMContext>());

            #endregion
            IMapper mapper = mappingConfig.CreateMapper();
            services.AddSingleton(mapper);

            #region MVC
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);

            #endregion

            services.AddApiVersioning();

            services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));

            services.AddScoped<IUnitOfWork, UnitOfWork>();

            #region Services
            services.AddScoped<IUserService, UserService>();
            #endregion



            #region Cors
            services.AddCors(options =>
            {
                options.AddPolicy("CorsPolicy",
                    builder => builder
                        //.WithOrigins("http://localhost:4200")
                        .AllowAnyOrigin()
                        //.WithMethods("GET", "POST")
                        .AllowAnyMethod()
                        //.WithHeaders("accept", "content-type", "origin", "No-Auth")
                        .AllowAnyHeader()
                        .AllowCredentials());
            });
            #endregion

            #region JWT Token Auth
            services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
                 .AddJwtBearer(options =>
                 {

                     options.TokenValidationParameters = new Microsoft.IdentityModel.Tokens.TokenValidationParameters
                     {
                         ValidAudience = (string)Convert.ChangeType(Configuration["JwtTokenConfig:ValidAudience"], typeof(string)),
                         ValidateAudience = (bool)Convert.ChangeType(Configuration["JwtTokenConfig:ValidateAudience"], typeof(bool)),
                         ValidIssuer = (string)Convert.ChangeType(Configuration["JwtTokenConfig:ValidIssuer"], typeof(string)),
                         ValidateIssuer = (bool)Convert.ChangeType(Configuration["JwtTokenConfig:ValidateIssuer"], typeof(bool)),
                         ValidateLifetime = (bool)Convert.ChangeType(Configuration["JwtTokenConfig:ValidateLifetime"], typeof(bool)),
                         IssuerSigningKey = new SymmetricSecurityKey(System.Text.Encoding.UTF8.GetBytes(
                                             (string)Convert.ChangeType(Configuration["JwtTokenConfig:IssuerSigningKey"], typeof(string)))),
                         ValidateIssuerSigningKey = (bool)Convert.ChangeType(Configuration["JwtTokenConfig:ValidateIssuerSigningKey"], typeof(bool)),
                         ClockSkew = TimeSpan.Zero
                     };

                     options.Events = new JwtBearerEvents
                     {

                         OnAuthenticationFailed = _ =>
                         {
                             Console.WriteLine($"Exception:{_.Exception.Message}");
                             return Task.CompletedTask;
                         },
                         OnTokenValidated = _ =>
                         {
                             Console.WriteLine($"Login Success:{ _.Principal.Identity}");
                             return Task.CompletedTask;
                         },

                     };
                 });
            #endregion
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseHsts();
            }

            #region CorsSection

            app.UseCors("CorsPolicy");

            #endregion CorsSection

            app.UseHttpsRedirection();
            app.UseAuthentication();
            app.UseMvc();
        }
    }
}
