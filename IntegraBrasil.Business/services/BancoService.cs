using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using IntegraBrasil.Business.interfaces;
using IntegraBrasil.Model.models;
using IntegraBrasil.Model.Responses;

namespace IntegraBrasil.Business.services
{

    
    public class BancoService : IBancoService
    {
        private readonly IMapper _mapper;
        private readonly IBrasilApi _brasilApi;

        public BancoService(IMapper mapper, IBrasilApi brasilApi)
        {
            _mapper = mapper;
            _brasilApi = brasilApi;
        }

        public async Task<GenericResponse<BancoResponse>> FindBank(string bankCode)
        {
            var bank = await _brasilApi.FindBank(bankCode);
            return _mapper.Map<GenericResponse<BancoResponse>>(bank);
        }

        public async Task<GenericResponse<List<BancoResponse>>> GetAllBanks()
        {
            var banks = await _brasilApi.GetAllBanks();
           
            return _mapper.Map<GenericResponse<List<BancoResponse>>>(banks);
        }
    }
}
