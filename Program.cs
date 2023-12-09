using Microsoft.AspNetCore;
using Microsoft.Extensions.Logging;

namespace MyCourses
{

    public class Program
        {
            public static void Main(string[] args)
            {
                CreateWebHostBuilder(args).Biuld().Run();
            }

            public static IWebHostBuilder CreateWebHostBuilder (string[] args) =>
                WebHost.CreateDefaultBuilder (args) 
                    .UseStartup<Startup>();
        }

}
