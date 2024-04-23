using System.Net;
using IntegraBrasil.Business.interfaces;
using Microsoft.AspNetCore.Mvc;

namespace IntegraBrasil.Api.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class EnderecoController : ControllerBase
    {

        private readonly IEnderecoService _enderecoService;

        public EnderecoController(IEnderecoService enderecoService)
        {
            _enderecoService = enderecoService;
        }

        [HttpGet("buscar/{cep}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
      
        public async Task<IActionResult> FindAddressPerCep ([FromRoute]string cep)
        {
            var response = await _enderecoService.FindAddressPerCep(cep);
            if (response.StatusCode == HttpStatusCode.OK)
            {
                return Ok(response);
            }
            return StatusCode((int)response.StatusCode, response.ReturnError);
        }
    }
}
