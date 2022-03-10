using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace PersonalWebAPPMvc.Models.Concrete;
public class Categories : BaseEntity
{

    [MaxLength(20)]
    public string CategoryName { get; set; }


    [DefaultValue(typeof(DateTime), "2021-01-01")]
    public DateTime CreateDate { get; set; }


    [DefaultValue(typeof(DateTime), "2021-01-01")]
    public DateTime UpdateDate { get; set; }


    [DefaultValue(typeof(DateTime), "2021-01-01")]
    public DateTime LastCheckDate { get; set; }

}