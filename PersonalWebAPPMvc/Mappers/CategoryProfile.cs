using AutoMapper;
using PersonalWebAPPMvc.DTO_s.Categories;
using PersonalWebAPPMvc.Models.Concrete;

namespace PersonalWebAPPMvc.Mappers;

public class CategoryProfile : Profile
{
    public CategoryProfile()
    {

        CreateMap<CategoryCreateModel, Categories>()
       .ForMember(destinationMember => destinationMember.CreateDate, source => source.MapFrom(_ => DateTime.Now));

        CreateMap<CategoryUpdateModel, Categories>()
       .ForMember(destinationMember => destinationMember.UpdateDate, source => source.MapFrom(_ => DateTime.Now));

        CreateMap<Categories,CategoryDetailsModel>()
       //.ForMember(destination => destination.LastCheckDate, source => source.MapFrom(i => i.LastCheckDate.ToString(DateFormatConstans.BASICDATEFORMAT)))
       .ForMember(destinationMember => destinationMember.LastCheckDate, source => source.MapFrom(_ => DateTime.Now));



    }
}
