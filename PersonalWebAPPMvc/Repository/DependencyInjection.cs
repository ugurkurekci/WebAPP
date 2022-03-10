using PersonalWebAPPMvc.Business.Category;
using PersonalWebAPPMvc.Models.DataAccess;
using PersonalWebAPPMvc.Repository.Category;

namespace PersonalWebAPPMvc.Models.Repository;

public static class DependencyInjection
{
    public static void RegisterRepositories(this IServiceCollection serviceCollection)
    {
        serviceCollection.AddScoped<ICategoryRepository, CategoryRepository>();
        serviceCollection.AddScoped<ICategoryService, CategoryService>();
        serviceCollection.AddScoped<WebAPPProjectDbContext>();
    }
}
