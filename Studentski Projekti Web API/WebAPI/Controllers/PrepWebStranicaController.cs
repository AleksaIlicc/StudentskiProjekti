using Microsoft.AspNetCore.Mvc;
using Library;
using Library.DTOs;
using System.Xml.Linq;

namespace WebAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class PrepWebStranicaController : Controller
{
    [HttpGet]
    [Route("VratiPrepWebStraniceZaPProjekat/{idproj}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status403Forbidden)]
    public IActionResult VratiPrepWebStraniceZaPProjekat(int idproj)
    {
        (bool isError, var webStranice, var error) = DataProvider.VratiPreporuceneWebStranicePProjekta(idproj);

        if (isError)
        {
            return StatusCode(error?.StatusCode ?? 400, error?.Message);
        }

        return Ok(webStranice);
    }

    [HttpPost]
    [Route("DodajPrepWebStranicu/{idproj}")]
    [ProducesResponseType(StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ProducesResponseType(StatusCodes.Status403Forbidden)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public IActionResult DodajPrepWebStranicu([FromBody] PreporucenaWebStranicaView prepwebstranica, int idproj)
    {
        (bool isError, var result, var error) = DataProvider.DodajPreporucenuWebStranicuZaProjekat(idproj , prepwebstranica);

        if (isError)
        {
            return StatusCode(error?.StatusCode ?? 400, error?.Message);
        }
        return StatusCode(201, $"Uspesno je dodata preoprucena web stranica pod nazivom {prepwebstranica.Naziv}.");
    }

    [HttpDelete]
    [Route("ObrisiPrepWebStranicu/{idproj}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status403Forbidden)]
    public IActionResult ObrisiPrepWebStranicu([FromBody] PreporucenaWebStranicaView p , int idproj)
    {
        (bool isError, var result, var error) = DataProvider.ObrisiPreporucenuWebStranicuZaProjekat(idproj , p);

        if (isError)
        {
            return StatusCode(error?.StatusCode ?? 400, error?.Message);
        }

        return Ok($"Uspesno je obrisana preoprucena web stranica");
    }
}
