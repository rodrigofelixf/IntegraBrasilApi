using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using IntegraBrasil.Business.interfaces;
using IntegraBrasil.Model.models;
using IntegraBrasil.Model.Responses;

namespace IntegraBrasil.Business.rest
{
    public class BrasilApiRest : IBrasilApi
    {
        public async Task<GenericResponse<EnderecoModel>> FindAddressPerCep(string cep)
        {
            var request = new HttpRequestMessage(HttpMethod.Get, $"https://brasilapi.com.br/api/cep/v1/{cep}");

            var response = new GenericResponse<EnderecoModel>();
            using(var cliente = new HttpClient())
            {
                var responseBrasilApi = await cliente.SendAsync(request);
                var contentResp = await responseBrasilApi.Content.ReadAsStringAsync();
                var objResponse = JsonSerializer.Deserialize<EnderecoModel>(contentResp);

                if (responseBrasilApi.IsSuccessStatusCode) 
                {
                    response.StatusCode = responseBrasilApi.StatusCode;
                    response.ReturnData = objResponse;
                }
                else {
                    response.StatusCode = responseBrasilApi.StatusCode;
                    response.ReturnError = JsonSerializer.Deserialize<ExpandoObject>(contentResp);
                }                 
            }
            return response;
        }

        public async Task<GenericResponse<BancoModel>> FindBank(string bankCode)
        {
            var request = new HttpRequestMessage(HttpMethod.Get, $"https://brasilapi.com.br/api/banks/v1/{bankCode}");

            var response = new GenericResponse<BancoModel>();
            using (var cliente = new HttpClient())
            {
                var responseBrasilApi = await cliente.SendAsync(request);
                var contentResp = await responseBrasilApi.Content.ReadAsStringAsync();
                var objResponse = JsonSerializer.Deserialize<BancoModel>(contentResp);

                if (responseBrasilApi.IsSuccessStatusCode)
                {
                    response.StatusCode = responseBrasilApi.StatusCode;
                    response.ReturnData = objResponse;
                }
                else
                {
                    response.StatusCode = responseBrasilApi.StatusCode;
                    response.ReturnError = JsonSerializer.Deserialize<ExpandoObject>(contentResp);
                }
            }
            return response;
        }

        public async Task<GenericResponse<List<BancoModel>>> GetAllBanks()
        {
            var request = new HttpRequestMessage(HttpMethod.Get, "https://brasilapi.com.br/api/banks/v1");

            var response = new GenericResponse<List<BancoModel>>();
            using (var cliente = new HttpClient())
            {
                var responseBrasilApi = await cliente.SendAsync(request);
                var contentResp = await responseBrasilApi.Content.ReadAsStringAsync();
                var objResponse = JsonSerializer.Deserialize<List<BancoModel>>(contentResp);

                if (responseBrasilApi.IsSuccessStatusCode)
                {
                    response.StatusCode = responseBrasilApi.StatusCode;
                    response.ReturnData = objResponse;
                }
                else
                {
                    response.StatusCode = responseBrasilApi.StatusCode;
                    response.ReturnError = JsonSerializer.Deserialize<ExpandoObject>(contentResp);
                }
            }
            return response;
        }
    }
}
