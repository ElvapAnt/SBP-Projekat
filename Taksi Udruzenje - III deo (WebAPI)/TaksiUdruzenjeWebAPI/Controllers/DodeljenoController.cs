using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TaksiUdruzenjeLibrary;
using TaksiUdruzenjeLibrary.DTOs;

namespace TaksiUdruzenjeWebAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class DodeljenoController : ControllerBase
    {
        public DodeljenoController() { }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [HttpGet]
        [Route("VratiIstorijuVozilaVozaca/{jmbg}")]
        public async Task<ActionResult> VratiIstorijuVozilaVozaca(string jmbg)
        {
            var (isError, taxiVozila, error) = DTOProvider.VratiDodeljenaVozilaVozaca(jmbg);
            if (isError)
            {
                return BadRequest(error);
            }
            return Ok(taxiVozila);
        }
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [HttpGet]
        [Route("VratiIstorijuVozacaVozila/{regOznaka}")]
        public async Task<ActionResult> VratiIstorijuVozacaVozila(string regOznaka)
        {
            var (isError, vozaci, error) = DTOProvider.VratiDodeljeneVozaceVozila(regOznaka);
            if (isError)
            {
                return BadRequest(error);
            }
            return Ok(vozaci);
        }

        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [HttpPost]
        [Route("KreirajNoviDodeljenoOdnos/{jmbg}/{regOznaka}")]
        public async Task<ActionResult> KreirajNoviDodeljenoOdnos([FromBody] DodeljenoView dv, string jmbg, string regOznaka)
        {
            var data = await DTOProvider.DodajDodeljenoAsync(dv, jmbg, regOznaka);
            if (data.IsError)
            {
                return BadRequest(data.Error);
            }
            return Ok($"Uspesno dodeljeno vozilo sa registracijom {regOznaka} vozacu {jmbg}");
        }
        
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [HttpPost]
        [Route("PoveziTaxiVoziloIVozaca/{jmbg}/{regOznaka}")]
        public async Task<ActionResult> PoveziTaxiVoziloIVozaca(string jmbg, string regOznaka)
        {
            var data = await DTOProvider.PoveziTaxiVoziloIVozacaAsync(jmbg, regOznaka);
            if (data.IsError)
            {
                return BadRequest(data.Error);
            }
            return Ok($"Dodeljeno vozilo {regOznaka} vozacu {jmbg}");
        }

    }
}