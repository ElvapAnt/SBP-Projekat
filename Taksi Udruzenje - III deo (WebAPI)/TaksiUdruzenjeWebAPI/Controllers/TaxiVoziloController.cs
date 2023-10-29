using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TaksiUdruzenjeLibrary;
using TaksiUdruzenjeLibrary.DTOs;

namespace TaksiUdruzenjeWebAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class TaxiVoziloController : ControllerBase
    {
        public TaxiVoziloController() { }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [HttpGet]
        [Route("VratiTaxiVozila")]
        public async Task<ActionResult> VratiTaxiVozila()
        {
            var (isError, taxiVozila, error) = DTOProvider.VratiSvaTaxiVozila();
            if (isError)
            {
                return BadRequest(error);
            }
            return Ok(taxiVozila);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [HttpDelete]
        [Route("ObrisiTaxiVozilo/{regOznaka}")]
        public async Task<ActionResult> ObrisiTaxiVozilo(string regOznaka)
        {
            var data = await DTOProvider.ObrisiTaxiVoziloAsync(regOznaka);
            if (data.IsError)
            {
                return BadRequest(data.Error);
            }
            return Ok($"Obrisano taxi vozilo sa registracijom : {regOznaka}");
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [HttpPut]
        [Route("AzurirajTaxiVozilo")]
        public async Task<ActionResult> AzurirajTaxiVozilo([FromBody] TaxiVoziloView taxi)
        {
            var data = await DTOProvider.AzurirajTaxiVoziloAsync(taxi);
            if (data.IsError)
            {
                return BadRequest(data.Error);
            }
            return Ok($"Upisano izmenjeno taxi vozilo sa registracijom : {taxi.RegistarskaOznaka}");
        }

        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [HttpPost]
        [Route("DodajTaxiVozilo")]
        public async Task<ActionResult> DodajTaxiVozilo([FromBody] TaxiVoziloView taxi)
        {
            var data = await DTOProvider.DodajTaxiVoziloAsync(taxi);
            if (data.IsError)
            {
                return BadRequest(data.Error);
            }
            return Ok($"Dodato novo vozilo sa registracijom : {taxi.RegistarskaOznaka}");
        }
    }
}
