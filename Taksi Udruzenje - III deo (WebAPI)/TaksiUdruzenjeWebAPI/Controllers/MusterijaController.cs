using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TaksiUdruzenjeLibrary;
using TaksiUdruzenjeLibrary.DTOs;

namespace TaksiUdruzenjeWebAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class MusterijaController : ControllerBase
    {
        public MusterijaController() { }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [HttpGet]
        [Route("VratiRedovneMusterije")]
        public async Task<ActionResult> VratiRedovneMusterije()
        {
            var (isError, musterije, error) = await DTOProvider.VratiRedovneMusterijeAsync();
            if (isError)
            {
                return BadRequest(error);
            }
            return Ok(musterije);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [HttpPut]
        [Route("AzurirajMusteriju")]
        public async Task<ActionResult> AzurirajMusteriju([FromBody] RedovnaMusterijaView rm)
        {
            var data = await DTOProvider.AzurirajMusterijuAsync(rm);
            if (data.IsError)
            {
                return BadRequest(data.Error);
            }
            return Ok($"Upisana izmenjena musterija sa id-jem : {rm.RedMusterijaId}");
        }

        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [HttpPost]
        [Route("DodajMusteriju")]
        public async Task<ActionResult> DodajMusteriju([FromBody] RedovnaMusterijaView rm)
        {
            var data = await DTOProvider.DodajMusterijuAsync(rm);
            if (data.IsError)
            {
                return BadRequest(data.Error);
            }
            return Ok($"Dodata nova musterija!");
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [HttpGet]
        [Route("VratiPopustMusterije/{id}")]
        public async Task<ActionResult> VratiPopustMusterije(int id)
        {
            var data = DTOProvider.VratiPopustMusterije(id);
            if (data.IsError)
            {
                return BadRequest(data.Error);
            }
            return Ok($"Musterija sa id-jem {id} je ostvarila popust : {data.Data * 100}%");
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [HttpGet]
        [Route("VratiVoznjeRedovneMusterije/{id}")]
        public async Task<ActionResult> VratiVoznjeRedovneMusterije(int id)
        {
            var (IsError, voznje, error) = DTOProvider.VratiVoznjeRedovneMusterije(id);
            if (IsError)
            {
                return BadRequest(error);
            }
            return Ok(voznje);
        }

    }
}
