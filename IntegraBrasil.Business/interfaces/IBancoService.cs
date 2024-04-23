using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IntegraBrasil.Model.models;
using IntegraBrasil.Model.Responses;

namespace IntegraBrasil.Business.interfaces
{
    public interface IBancoService
    {
        Task<GenericResponse<List<BancoResponse>>> GetAllBanks();

        Task<GenericResponse<BancoResponse>> FindBank(string bankCode);
    }
}
