using Microsoft.EntityFrameworkCore;
using PersonalWebAPPMvc.Models.Concrete;
using PersonalWebAPPMvc.Models.DataAccess;

namespace PersonalWebAPPMvc.Repository.Category;

public class CategoryRepository : ICategoryRepository
{
    private readonly WebAPPProjectDbContext _webAPPProjectDbContext;

    public CategoryRepository(WebAPPProjectDbContext webAPPProjectDbContext)
    {

        _webAPPProjectDbContext = webAPPProjectDbContext;

    }

    public async Task AddAsync(Categories categories)
    {

        _webAPPProjectDbContext.Add(categories);
        _webAPPProjectDbContext.SaveChanges();
        await Task.CompletedTask;

    }

    public async Task<List<Categories>> GetAll()
    {

        return await _webAPPProjectDbContext.Categories.ToListAsync();

    }

    public async Task<Categories> GetByIdAsync(int id)
    {

        var find = _webAPPProjectDbContext.Categories.FindAsync(id);
        return await find;

    }

    public async Task UpdateAsync(Categories categories)
    {

        _webAPPProjectDbContext.Update(categories);
        _webAPPProjectDbContext.SaveChanges();
        await Task.CompletedTask;

    }
}
