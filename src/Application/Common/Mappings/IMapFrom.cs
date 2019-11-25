using AutoMapper;

namespace Portfolio.Application.Common.Mappings
{
    public interface IMapFrom<T>
    {
        void Mapping(Profile profile);
    }
}