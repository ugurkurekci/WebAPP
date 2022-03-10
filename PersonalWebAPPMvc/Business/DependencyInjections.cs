using PersonalWebAPPMvc.Business.Category;
using System.Reflection;

namespace PersonalWebAPPMvc.Business;

public static class DependencyInjections
{
    public static void AddMyServices(this IServiceCollection services)
    {
        services.AddAutoMapper(Assembly.GetExecutingAssembly());
    }
}
