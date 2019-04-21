using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace TesteMirum.Application.AutoMapper
{
    public class AutoMapperConfig
    {
        public static void RegisterMappings()
        {
            Mapper.Initialize(x =>
            {
                x.AddProfile(new DomainToViewModelMappingProfile());
                x.AddProfile(new ViewModelToDomainMappingProfile());
            });
        }
    }
}
