using PersonalWebAPPMvc.Models.Concrete;
using PersonalWebAPPMvc.DTO_s.Categories;

namespace PersonalWebAPPMvc.Business.Category;

public interface ICategoryService
{
    Task AddAsync(CategoryCreateModel categoryCreateModel);

    Task UpdateAsync(CategoryUpdateModel categoryUpdateModel);

    Task<CategoryDetailsModel> GetCategoriesAsyncId(int id);

    Task<List<Categories>> GetAllCategoriesAsync();


}
