using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;
using BCDL;
using BCBL;
using Microsoft.OpenApi.Models;

namespace BCWebUI
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
            services.AddScoped<IUserBL, UserBL>();
            services.AddScoped<IUserRepo, UserRepo>();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "BCWebUI", Version = "v1" });
            });
            services.AddDbContext<BookClubDBContext>(options => options.UseNpgsql(Configuration.GetConnectionString("BookClubDB")));
            services.AddScoped<IBookBL, BookBL>();
            services.AddScoped<IBookRepo, BookRepo>();
            services.AddScoped<IBookClubBL, BookClubBL>();
            services.AddScoped<IBookClubRepo, BookClubRepo>();

            services.AddScoped<IUserPostBL, UserPostBL>();
            services.AddScoped<IUserPostRepo, UserPostRepo>();
            services.AddScoped<IClubPostBL, ClubPostBL>();
            services.AddScoped<IClubPostRepo, ClubPostRepo>();
            services.AddScoped<IUserCommentBL, CommentBL>();
            services.AddScoped<IUserCommentRepo, UserCommentRepo>();

            services.AddScoped<IBooksReadBL, BooksReadBL>();
            services.AddScoped<IBooksReadRepo, BooksReadRepo>();
            services.AddScoped<IBooksToReadBL, BooksToReadBL>();
            services.AddScoped<IBooksToReadRepo, BookToReadRepo>();
            services.AddScoped<IFavoriteBookBL, FavoriteBookBL>();
            services.AddScoped<IFavoriteBookRepo, FavoriteBookRepo>();

            services.AddScoped<ICategoryRepo, CategoryRepo>();
            services.AddScoped<ICategoryBL, CategoryBL>();

            services.AddScoped<IFollowClubRepo, FollowClubRepo>();
            services.AddScoped<IFollowClubBL, FollowClubBL>();
            services.AddScoped<IFollowUserRepo, FollowUserRepo>();
            services.AddScoped<IFollowUserBL, FollowUserBL>();

            services.AddScoped<IClubPostLikesRepo, ClubPostLikesRepo>();
            services.AddScoped<IClubPostLikesBL, ClubPostLikesBL>();
            services.AddScoped<IUserPostLikesRepo, UserPostLikesRepo>();
            services.AddScoped<IUserPostLikesBL, UserPostLikesBL>();
            services.AddScoped<IUserCommentLikesRepo, UserCommentLikesRepo>();
            services.AddScoped<IUserCommentLikeBL, UserCommentLikesBL>();

            services.AddCors(options => {
                options.AddDefaultPolicy(builder =>
                {
                   builder.WithOrigins("http://127.0.0.1:4200", "http://localhost:4200", "https://bookclub.azurewebsites.net").AllowAnyMethod().AllowAnyHeader();

                   // builder.WithOrigins("http:127.0.0.1:4200", "http:localhost:4200").DisallowCredentials();
                });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "BCWebUI v1"));
            }

            app.UseSwagger();

            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "BCWebUI v1");
                c.RoutePrefix = string.Empty;
            });

            app.UseHttpsRedirection();

            app.UseRouting();
            app.UseCors();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
