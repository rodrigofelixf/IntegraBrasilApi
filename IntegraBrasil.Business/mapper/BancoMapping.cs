using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using IntegraBrasil.Model.models;
using IntegraBrasil.Model.Responses;

namespace IntegraBrasil.Business.mapper
{
    public class BancoMapping : Profile
    {

        public BancoMapping()
        {
            CreateMap(typeof(GenericResponse<>), typeof(GenericResponse<>));
            CreateMap<BancoResponse, BancoModel>();
            CreateMap<BancoModel, BancoResponse>();


        }
    }
}
