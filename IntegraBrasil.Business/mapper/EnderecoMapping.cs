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
    public class EnderecoMapping : Profile
    {

        public EnderecoMapping() 
        { 
            CreateMap(typeof(GenericResponse<>), typeof(GenericResponse<>));
            CreateMap<EnderecoResponse, EnderecoModel>();
            CreateMap<EnderecoModel, EnderecoResponse>();


        }
    }
}
