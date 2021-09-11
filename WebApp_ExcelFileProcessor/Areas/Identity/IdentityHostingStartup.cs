using Microsoft.AspNetCore.Hosting;

[assembly: HostingStartup(typeof(WebApp_ExcelFileProcessor.Areas.Identity.IdentityHostingStartup))]

namespace WebApp_ExcelFileProcessor.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) =>
            {
            });
        }
    }
}