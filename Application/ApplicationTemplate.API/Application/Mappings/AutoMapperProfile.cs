﻿

namespace ApplicationTemplate.API.Application.Mappings;

public class AutoMapperProfile : Profile
{
    public AutoMapperProfile()
    {
        CreateMap<Sample, SampleViewModel>();
    }
}
