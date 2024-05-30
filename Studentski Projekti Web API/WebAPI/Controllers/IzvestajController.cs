using Microsoft.AspNetCore.Mvc;
using Library;
using Library.DTOs;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace WebAPI.Controllers;

[ApiController]
[Route("Projekat/Prakticni/Izvestaj")]
public class IzvestajController :Controller
{
    [HttpPost]
    [Route("Dodaj/{prakProjId}/{studBrInd}")]
    [ProducesResponseType(StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ProducesResponseType(StatusCodes.Status403Forbidden)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public IActionResult DodajIzvestaj(int prakProjId, string studBrInd, [FromBody] IzvestajView izvesPreg)
    {
        (bool isError, var izvestaj, var error) = DataProvider.DodajIzvestaj(prakProjId, studBrInd, izvesPreg);

        if (isError)
        {
            return StatusCode(error?.StatusCode ?? 400, error?.Message);
        }

        return StatusCode(201, "Izvestaj uspesno dodat.");
    }

    [HttpPut]
    [Route("Azuriraj")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status403Forbidden)]
    public IActionResult AzurirajIzvestaj([FromBody] IzvestajView p)
    {
        (bool isError, var izvestaj, var error) = DataProvider.AzurirajIzvestaj(p);

        if (isError)
        {
            return StatusCode(error?.StatusCode ?? 400, error?.Message);
        }

        return Ok("Izvestaj uspesno azuriran.");
    }

    [HttpDelete]
    [Route("Obrisi/{id}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status403Forbidden)]
    public IActionResult ObrisiIzvestaj(int id)
    {
        (bool isError, var izvestaj, var error) = DataProvider.ObrisiIzvestaj(id);

        if (isError)
        {
            return StatusCode(error?.StatusCode ?? 400, error?.Message);
        }

        return Ok("Izvestaj uspesno obrisan.");
    }

    [HttpGet]
    [Route("Preuzmi/{Id_Izvestaj}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ProducesResponseType(StatusCodes.Status403Forbidden)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public IActionResult PreuzmiIzvestaj(int Id_Izvestaj)
    {
        (bool isError, var izvestaj, var error) = DataProvider.VratiIzvestaj(Id_Izvestaj);

        if (isError)
        {
            return StatusCode(error?.StatusCode ?? 400, error?.Message);
        }

        return Ok(izvestaj);
    }

    [HttpGet]
    [Route("PreuzmiZaStudenta/{prakProjId}/{studBrInd}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ProducesResponseType(StatusCodes.Status403Forbidden)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public IActionResult PreuzmiIzvestajeZaStudenta(string studBrInd, int prakProjId)
    {
        (bool isError, var izvestaj, var error) = DataProvider.VratiIzvestajeZaStudenta(studBrInd, prakProjId);

        if (isError)
        {
            return StatusCode(error?.StatusCode ?? 400, error?.Message);
        }

        return Ok(izvestaj);
    }

    [HttpGet]
    [Route("BrojIzvestaja/{projid}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ProducesResponseType(StatusCodes.Status403Forbidden)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public IActionResult VratiBrPredIzvestajaNaGrupi(int projid)
    {
        (bool isError, var izvestaj, var error) = DataProvider.VratiBrPredIzvestajaNaGrupi(projid);

        if (isError)
        {
            return StatusCode(error?.StatusCode ?? 400, error?.Message);
        }

        return Ok($"Broj izvestaja na prokeltu sa id-jem {projid} je {izvestaj}");
    }
}


