﻿using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Vedly.Dtos;
using Vedly.Models;

namespace Vedly.App_Start
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            //Domain to Dto...
            Mapper.CreateMap<Customer, CustomerDto>();
            Mapper.CreateMap<Movie, MovieDto>();
            Mapper.CreateMap<MembershipType, MembershipTypeDto>();
            Mapper.CreateMap<Genre, GenreDto>();

            //Dto to Domain...
            Mapper.CreateMap<CustomerDto, Customer>()
                 .ForMember(m => m.Id, opt => opt.Ignore());
            Mapper.CreateMap<MovieDto, Movie>()
                 .ForMember(m => m.Id, opt => opt.Ignore());



        }
    }
}