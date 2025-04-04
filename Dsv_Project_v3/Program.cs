using Dsv_Project_v3.Repo;
using Dsv_Project_v3.Services;
using Dsv_Project_v3.Repo;

namespace Dsv_Project_v3
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddRazorPages();

            builder.Services.AddSingleton<IRoomRepo, RoomRepo>();
            builder.Services.AddSingleton<IBookingRepo, BookingCollectionRepo>();
            builder.Services.AddSingleton<RoomServices>();
            builder.Services.AddSingleton<BookingService>(); // Add this line

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapRazorPages();

            app.Run();
        }
    }
}
