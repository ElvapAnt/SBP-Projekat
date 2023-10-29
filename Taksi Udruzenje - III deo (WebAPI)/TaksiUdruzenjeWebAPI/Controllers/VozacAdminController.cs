using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using TaksiUdruzenjeLibrary;
using TaksiUdruzenjeLibrary.DTOs;

namespace TaksiUdruzenjeWebAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class VozacAdminController : ControllerBase
    {
        public VozacAdminController() { }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [HttpDelete]
        [Route("ObrisiVozaca/{jmbg}")]
        public async Task<ActionResult> ObrisiVozaca(string jmbg)
        {
            var data = await DTOProvider.ObrisiVozacaAsync(jmbg);
            if (data.IsError)
            {
                return BadRequest(data.Error);
            }
            return Ok($"Obrisan vozac sa jmbg-om : {jmbg}");
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [HttpPut]
        [Route("AzurirajVozaca")]
        public async Task<ActionResult> AzurirajVozacaAsync([FromBody]VozacView vozac)
        {
            var data = await DTOProvider.AzurirajVozacaAsync(vozac);
            if (data.IsError)
            {
                return BadRequest(data.Error);
            }
            return Ok($"Upisan izmenjeni vozac sa jmbg-om : {vozac.Jmbg}");
        }
        
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [HttpPost]
        [Route("DodajVozaca")]
        public async Task<ActionResult> DodajVozacaAsync([FromBody] VozacView vozac)
        {
            var data = await DTOProvider.DodajVozacaAsync(vozac);
            if (data.IsError)
            {
                return BadRequest(data.Error);
            }
            return Ok($"Dodat novi vozac sa jmbg-om : {vozac.Jmbg}");
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [HttpDelete]
        [Route("ObrisiAdmina/{jmbg}")]
        public async Task<ActionResult> ObrisiAdmina(string jmbg)
        {
            var data = await DTOProvider.ObrisiAdminaAsync(jmbg);
            if (data.IsError)
            {
                return BadRequest(data.Error);
            }
            return Ok($"Obrisan admin sa jmbg-om : {jmbg}");
        }
        
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [HttpPut]
        [Route("AzurirajAdmina")]
        public async Task<ActionResult> AzurirajAdmina([FromBody] AdministrativnoOsobljeView admin)
        {
            var data = await DTOProvider.AzurirajAdminaAsync(admin);
            if (data.IsError)
            {
                return BadRequest(data.Error);
            }
            return Ok($"Upisan izmenjeni vozac sa jmbg-om : {admin.Jmbg}");
        }
        
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [HttpPost]
        [Route("DodajAdmina")]
        public async Task<ActionResult> DodajAdminaAsync([FromBody] AdministrativnoOsobljeView admin)
        {
            var data = await DTOProvider.DodajAdminaAsync(admin);
            if (data.IsError)
            {
                return BadRequest(data.Error);
            }
            return Ok($"Dodat novi vozac sa jmbg-om : {admin.Jmbg}");
        }


    }
}
