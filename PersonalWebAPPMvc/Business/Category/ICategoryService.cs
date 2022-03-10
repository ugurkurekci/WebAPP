using PersonalWebAPPMvc.Models.Concrete;
using PersonalWebAPPMvc.DTO_s.Categories;

namespace PersonalWebAPPMvc.Business.Category;

public interface ICategoryService
{
    public Task AddAsync(CategoryCreateModel categoryCreateModel);

    public Task UpdateAsync(CategoryUpdateModel categoryUpdateModel);

    public Task<CategoryDetailsModel> GetCategoriesAsyncId(int id);

    public Task<List<Categories>> GetAllCategoriesAsync();


}
