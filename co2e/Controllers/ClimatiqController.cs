using AutoMapper;
using co2e.Mapper;
using co2e.Models;
using co2e.Repositorio;
using co2e.Services;
using co2e.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace co2e.Controllers
{
    [Route("[controller]/[action]")]
    [ApiController]
    public class ClimatiqController : ControllerBase
    {
        public APIRequest apiservices = new APIRequest();
        public ResponseRepo responseRepo = new ResponseRepo();
        private IMapper _mapper;

        [HttpPost]
        public IActionResult Salvar(emission_factor id)
        {
            var resultado = apiservices.ApiClimatiqRequest(id.emissionFactorRequest, id.parameters);

            if (resultado == null)
            {
                return NotFound();
            }

            var constituentgases = _mapper.Map<ConstituentGasesMapper>(resultado.ConstituentGases);

                responseRepo.SaveConstituentGasesApi(constituentgases);

                var apiresponse = _mapper.Map<ApiResponseMapper>(resultado);  
            
                responseRepo.SaveResponse(apiresponse);
                return Ok();
            
            
        }

        public ClimatiqController(IMapper mapper)
        {

            _mapper = mapper;

        }

        [HttpGet]

        public IActionResult Teste()
        {


            return Ok("ok funcionou");

        }
    }

    
}
