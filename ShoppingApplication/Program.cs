using Microsoft.EntityFrameworkCore;
using ShoppingApplication.Context;
using ShoppingApplication.Interfaces;
using ShoppingApplication.Models;
using ShoppingApplication.Repositories;
using ShoppingApplication.Services;

namespace ShoppingApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            //sush
            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();



            builder.Services.AddCors(opts =>
            {
                opts.AddPolicy("MyCors", options =>
                {
                    options.AllowAnyHeader().AllowAnyMethod().AllowAnyOrigin();
                });
            });
            builder.Services.AddDbContext<dbContext>(opts => {
                opts.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection"));
            });

         /*   builder.Services.AddScoped<IRepository<int, User>, UserRepository>();
            builder.Services.AddScoped<IUserService, UserService>();*/



            builder.Services.AddScoped<IRepository<int, Product>, ProductRepository>();
            builder.Services.AddScoped<IProductService, ProductService>();

            builder.Services.AddScoped<IRepository<int,Carts>, CartsRepository>();
            builder.Services.AddScoped<ICartsService, CartsService>();

            builder.Services.AddScoped<IRepository<int,Orders>,OrderRepository>();
            builder.Services.AddScoped<IOrderService,OrderService>();





            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }
            app.UseCors("MyCors");
            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}