using Microsoft.AspNetCore.Mvc;
using PersonalWebAPPMvc.Business.Category;
using PersonalWebAPPMvc.DTO_s.Categories;

namespace PersonalWebAPPMvc.Areas.Admin.Controllers;
public class CategoryController : Controller
{
    ICategoryService _categoryService;

    public CategoryController(ICategoryService categoryService)
    {
        _categoryService = categoryService;
    }

    public async Task<IActionResult> Index()
    {

        return View(await _categoryService.GetAllCategoriesAsync());
    }

    public async Task<IActionResult> CategoryAdd(CategoryCreateModel categoryCreateModel)
    {
        var result = _categoryService.AddAsync(categoryCreateModel);
        return RedirectToAction("Index", "Category");
    }

    public async Task<IActionResult> CategoryUpdate(CategoryUpdateModel categoryUpdateModel)
    {
        var result = _categoryService.UpdateAsync(categoryUpdateModel);
        return View();
    }



    public async Task<IActionResult> CategoryDetails(int id)
    {
        var result = await _categoryService.GetCategoriesAsyncId(id);
        return View(result);
    }
}
