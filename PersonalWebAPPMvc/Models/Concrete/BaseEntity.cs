using System.ComponentModel.DataAnnotations;

namespace PersonalWebAPPMvc.Models.Concrete;
public class BaseEntity
{
    [Key]
    public int Id { get; set; }
}