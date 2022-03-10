using AutoMapper;
using PersonalWebAPPMvc.DTO_s.Categories;
using PersonalWebAPPMvc.Models.Concrete;
using PersonalWebAPPMvc.Repository.Category;

namespace PersonalWebAPPMvc.Business.Category;

public class CategoryService : ICategoryService
{
    private readonly ICategoryRepository _categoryRepository;
    private readonly IMapper _mapper;

    public CategoryService(ICategoryRepository categoryRepository, IMapper mapper)
    {
        _categoryRepository = categoryRepository;
        _mapper = mapper;
    }

    public Task AddAsync(CategoryCreateModel categoryCreateModel)
    {
        Categories category = _mapper.Map<Categories>(categoryCreateModel);
        var result = _categoryRepository.AddAsync(category);
        return Task.FromResult(result);
    }

    public async Task UpdateAsync(CategoryUpdateModel categoryUpdateModel)
    {
        Categories exist = await _categoryRepository.GetByIdAsync(categoryUpdateModel.Id);
        Categories model = _mapper.Map(categoryUpdateModel, exist);
        await _categoryRepository.UpdateAsync(model);
        await Task.FromResult(exist.Id);
    }

    public async Task<CategoryDetailsModel> GetCategoriesAsyncId(int id)
    {
        Categories exist = await _categoryRepository.GetByIdAsync(id);
        return _mapper.Map<CategoryDetailsModel>(exist);

    }

    public async Task<List<Categories>> GetAllCategoriesAsync()
    {
        return await _categoryRepository.GetAll();
    }
}
