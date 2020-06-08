using System.Collections.Generic;
using Application;
using Domain;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DiagnosticoController : ControllerBase
    {
        [HttpPost("{sintomas}")]
        public ActionResult<List<Enfermedad>> ObtenerDiagnostico(int[] sintomas)
        {
            var service = new DiagnosticoGeneralService();
            var response = service.Ejecute(new DiagnosticoGeneralRequest() {Sintomas = sintomas});
            return Ok(response);
        }
    }
}