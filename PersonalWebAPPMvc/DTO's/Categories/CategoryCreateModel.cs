using System.ComponentModel.DataAnnotations;

namespace PersonalWebAPPMvc.DTO_s.Categories;

public class CategoryCreateModel
{
    [Key]
    public int Id { get; set; }
    public string CategoryName { get; set; }
}
