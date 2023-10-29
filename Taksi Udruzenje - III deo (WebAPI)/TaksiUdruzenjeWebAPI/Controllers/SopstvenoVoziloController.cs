using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TaksiUdruzenjeLibrary;
using TaksiUdruzenjeLibrary.DTOs;

namespace TaksiUdruzenjeWebAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class SopstvenoVoziloController : ControllerBase
    {
        public SopstvenoVoziloController() { }
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [HttpDelete]
        [Route("ObrisiSopVozilo/{id}")]
        public async Task<ActionResult> ObrisiSopVozilo(int id)
        {
            var data = await DTOProvider.ObrisiSopVoziloAsync(id);
            if (data.IsError)
            {
                return BadRequest(data.Error);
            }
            return Ok($"Obrisano sopstveno vozilo sa id-jem : {id}");
        }
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [HttpPut]
        [Route("AzurirajSopstvenoVozilo")]
        public async Task<ActionResult> AzurirajSopstvenoVozilo([FromBody] SopstvenoVoziloView sv)
        {
            var data = await DTOProvider.AzurirajSopVoziloAsync(sv);
            if (data.IsError)
            {
                return BadRequest(data.Error);
            }
            return Ok($"Upisano izmenjeno sopstveno vozilo sa id-jem : {sv.SopVoziloId}");
        }
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [HttpPost]
        [Route("DodajSopstvenoVozilo/{jmbg}")]
        public async Task<ActionResult> DodajSopstvenoVozilo([FromBody] SopstvenoVoziloView sv, string jmbg)
        {
            var data = await DTOProvider.DodajSopstvenoVoziloAsync(sv, jmbg);
            if (data.IsError)
            {
                return BadRequest(data.Error);
            }
            return Ok($"Dodato novo sopstveno vozilo vozacu {jmbg}");
        }
    }
}
