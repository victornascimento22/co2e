using AutoMapper;
using co2e.Models;
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
        public APIRequest apirep = new APIRequest();
        private IMapper _mapper;

        [HttpPost]
        public IActionResult Salvar([FromBody] emission_factor id)

        {

            var resultado = apirep.ApiClimatiqRequest(id.emissionFactorRequest, id.parameters);

            var objeto = _mapper.Map<ApiResponseMapper>(resultado);
            

            if (resultado == null)
                return NotFound();

            return Ok(resultado);
        }

        public ClimatiqController(IMapper mapper)
        {

            _mapper = mapper;

        }

    }
}
