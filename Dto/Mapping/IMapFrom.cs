using AutoMapper;

namespace DTO.Mappings;

public interface IMapFrom<T>
{
    void Mapping(Profile profile)
    {
        profile.CreateMap(GetType(), typeof(T))
            .ReverseMap();
    }
}
