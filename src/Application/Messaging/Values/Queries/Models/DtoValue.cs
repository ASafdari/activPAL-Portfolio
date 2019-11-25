using System;
using AutoMapper;
using Portfolio.Application.Common.Mappings;
using Portfolio.Domain.Entities;

namespace Portfolio.Application.Messaging.Values.Queries.Models
{
    public class DtoValue : IMapFrom<Value>
    {
        public string MyValue { get; set; }
        public DateTime Birtday { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<Value, DtoValue>();
        }
    }
}