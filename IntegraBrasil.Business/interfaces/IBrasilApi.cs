using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IntegraBrasil.Model.models;
using IntegraBrasil.Model.Responses;

namespace IntegraBrasil.Business.interfaces
{
    public interface IBrasilApi
    {

        Task<GenericResponse<EnderecoModel>> FindAddressPerCep(string cep);
        Task<GenericResponse<List<BancoModel>>> GetAllBanks();
        Task<GenericResponse<BancoModel>> FindBank(string bankCode);

    }
}
