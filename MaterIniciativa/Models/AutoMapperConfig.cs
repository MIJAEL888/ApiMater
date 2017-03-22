using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using MaterIniciativa.Areas.MaterIniciativa.Models;
using MaterIniciativaEntity;

namespace MaterIniciativa.Models
{
    public class AutoMapperConfig
    {
        public static void RegisterMappings()
        {
            Mapper.Initialize(cfg =>
            {
                cfg.CreateMap<User, InLoginModel>();
                cfg.CreateMap<InLoginModel, User>();
                cfg.CreateMap<User, OutUserModel>();
                cfg.CreateMap<InPlantModel, Plant>();
                cfg.CreateMap<InDepartmentModel, Department>();
                cfg.CreateMap<InEcoRegionModel, EcoRegion>();
                cfg.CreateMap<InPhotoModel, Photo>();
                cfg.CreateMap<EcoRegion, OutEcoRegionModel>();
                cfg.CreateMap<Department, OutDepartmentModel>();
                cfg.CreateMap<Plant, OutPlantModel>();
                cfg.CreateMap<Photo, OutPhotoModel>();
            });
        }
    }
}