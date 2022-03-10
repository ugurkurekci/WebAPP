using PersonalWebAPPMvc.Models.Concrete;

namespace PersonalWebAPPMvc.Repository.Category;

public interface ICategoryRepository
{
    public Task<List<Categories>> GetAll();

    public Task AddAsync(Categories categories);

    public Task UpdateAsync(Categories categories);

    public Task<Categories> GetByIdAsync(int id);
}
