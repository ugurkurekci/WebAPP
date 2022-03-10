using Microsoft.EntityFrameworkCore;
using PersonalWebAPPMvc.Models.Concrete;
using PersonalWebAPPMvc.DTO_s.Categories;

namespace PersonalWebAPPMvc.Models.DataAccess;

public class WebAPPProjectDbContext : DbContext
{
    public DbSet<Categories> Categories { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            optionsBuilder.UseSqlServer(@"Server=.;Database=WebAPP;Trusted_Connection=true");
        }
    }

    public DbSet<PersonalWebAPPMvc.DTO_s.Categories.CategoryCreateModel> CategoryCreateModel { get; set; }
}