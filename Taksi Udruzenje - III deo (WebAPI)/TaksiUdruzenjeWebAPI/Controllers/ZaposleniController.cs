using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TaksiUdruzenjeLibrary;
using TaksiUdruzenjeLibrary.DTOs;

namespace TaksiUdruzenjeWebAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ZaposleniController : ControllerBase
    {
        public ZaposleniController() { }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [HttpGet]
        [Route("VratiAdministrativnoOsoblje")]
        public async Task<ActionResult> VratiAdministrativnoOsoblje()
        {
            var (isError, admini, error) = await DTOProvider.VratiSveAdmineAsync();
            if (isError)
            {
                return BadRequest(error);
            }
            return Ok(admini);
        }
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [HttpGet]
        [Route("VratiVoznjePrimioPozivAdmin/{jmbgAdmin}")]
        public async Task<ActionResult> VratiVoznjePrimioPozivAdmin(string jmbgAdmin)
        {
            var (IsError, voznje, error) = DTOProvider.VratiVoznjePrimioPozivAdmin(jmbgAdmin);
            if (IsError)
            {
                return BadRequest(error);
            }
            return Ok(voznje);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [HttpGet]
        [Route("VratiVozace")]
        public async Task<ActionResult> VratiVozace()
        {
            var (isError, vozaci, error) = await DTOProvider.VratiSveVozaceAsync();
            if (isError)
            {
                return BadRequest(error);
            }
            return Ok(vozaci);
        }
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [HttpGet]
        [Route("VratiSopstvenaVozila/{jmbg}")]
        public async Task<ActionResult> VratiSopstvenaVozila(string jmbg)
        {
            var (isError, sopVozila, error) = await DTOProvider.VratiSopVozilaVozacaAsync(jmbg);
            if (isError)
            {
                return BadRequest(error);
            }
            return Ok(sopVozila);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [HttpGet]
        [Route("VratiVoznjeObavioVozac/{jmbgVozaca}")]
        public async Task<ActionResult> VratiVoznjeObavioVozac(string jmbgVozaca)
        {
            var (IsError, voznje, error) = DTOProvider.VratiVoznjeObavioVozac(jmbgVozaca);
            if (IsError)
            {
                return BadRequest(error);
            }
            return Ok(voznje);
        }
    }
}
