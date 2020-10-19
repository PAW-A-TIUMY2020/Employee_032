using Employee_032.Models;
using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Employee_032.Startup))]
namespace Employee_032
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            services.AddDbContext<EmployeeContext>(options => options.UseSqlServer(Configuration.GetConnectionString("DevConnection")));
        }
    }
}
