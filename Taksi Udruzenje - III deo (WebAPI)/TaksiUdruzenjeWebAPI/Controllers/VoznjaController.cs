using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TaksiUdruzenjeLibrary;
using TaksiUdruzenjeLibrary.DTOs;

namespace TaksiUdruzenjeWebAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class VoznjaController : ControllerBase
    {
        public VoznjaController() { }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [HttpGet]
        [Route("VratiSveVoznje")]
        public async Task<ActionResult> VratiSveVoznje()
        {
            var (isError, voznje, error) = await DTOProvider.VratiSveVoznjeAsync();
            if (isError)
            {
                return BadRequest(error);
            }
            return Ok(voznje);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [HttpDelete]
        [Route("ObrisiVoznju/{id}")]
        public async Task<ActionResult> ObrisiVoznju(int id)
        {
            var data = await DTOProvider.ObrisiVoznjuAsync(id);
            if (data.IsError)
            {
                return BadRequest(data.Error);
            }
            return Ok($"Obrisana voznja sa id-jem : {id}");
        }
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [HttpPost]
        [Route("DodajVoznju/{jmbgVozaca}/{jmbgAdmina}/{idMusterije}")]
        public async Task<ActionResult> DodajVoznju([FromBody] VoznjaView v
            ,string jmbgVozaca, string jmbgAdmina, int idMusterije)
        {
            var data = await DTOProvider.DodajVoznjuAsync(v,jmbgVozaca,jmbgAdmina,idMusterije);
            if (data.IsError)
            {
                return BadRequest(data.Error);
            }
            return Ok($"Dodata nova voznja :\n" +
                $"Obavio vozac : {jmbgVozaca} \n" +
                $"Primio poziv admin : {jmbgAdmina}\n" +
                $"Redovna musterija : {idMusterije}");
        }

        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [HttpPost]
        [Route("KreirajNoveRedovneMusterije")]
        public async Task<ActionResult> KreirajNoveRedovneMusterije()
        {
            var (IsError, noveMusterije, error) = await DTOProvider.KreirajNoveRedovneMusterije();
            if (IsError)
            {
                return BadRequest(error);
            }
            return Ok(noveMusterije);
        }
    }
}
