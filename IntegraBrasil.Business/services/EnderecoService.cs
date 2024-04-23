using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using IntegraBrasil.Business.interfaces;
using IntegraBrasil.Model.Responses;

namespace IntegraBrasil.Business.services
{
    public class EnderecoService : IEnderecoService
    {

        private readonly IMapper _mapper;
        private readonly IBrasilApi _brasilApi;

        public EnderecoService(IMapper mapper, IBrasilApi brasilApi)
        {
            _mapper = mapper;
            _brasilApi = brasilApi;
        }

        public async Task<GenericResponse<EnderecoResponse>> FindAddressPerCep(string cep)
        {
            var address = await _brasilApi.FindAddressPerCep(cep);
            return _mapper.Map<GenericResponse<EnderecoResponse>>(address);
            
        }
    }
}
