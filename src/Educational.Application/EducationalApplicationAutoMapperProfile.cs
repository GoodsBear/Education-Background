using AutoMapper;
using Educational.Dto.PositionsDto;
using Educational.Positions;

namespace Educational;

public class EducationalApplicationAutoMapperProfile : Profile
{
    public EducationalApplicationAutoMapperProfile()
    {
        /* You can configure your AutoMapper mapping configuration here.
         * Alternatively, you can split your mapping configurations
         * into multiple profile classes for a better organization. */
        CreateMap<Position, PositionsDto>().ReverseMap();
        CreateMap<CreateUpdatePositionDto,Position>().ReverseMap();
    }
}
