using Microsoft.AspNetCore.Mvc;
using Library;
using Library.DTOs;
using System.Text.Json;

namespace WebAPI.Controllers;

[ApiController]
[Route("Projekat/Teorijski/Literatura/Clanak")]
public class ClanakUCasopisuController : ControllerBase
{
    [HttpGet]
    [Route("Preuzmi/Sve/{id}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status403Forbidden)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public IActionResult PreuzmiSveClanke(int id)
    {
        (bool isError, var clanci, var error) = DataProvider.VratiSveClanakeZaTProj(id);

        if (isError)
        {
            return StatusCode(error?.StatusCode ?? 400, error?.Message);
        }

        return Ok(clanci);
    }

    [HttpGet]
    [Route("Preuzmi/Id/{issn}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status403Forbidden)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public IActionResult VratiIdLiteratureClanka(string issn)
    {
        (bool isError, var litid, var error) = DataProvider.VratiIdLiteratureClanka(issn);

        if (isError)
        {
            return StatusCode(error?.StatusCode ?? 400, error?.Message);
        }

        return Ok(litid);
    }

    [HttpPost]
    [Route("Dodaj/{idProjekta}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status403Forbidden)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public IActionResult DodajClanak([FromBody] JsonElement parameters, int idProjekta)
    {
        try
        {
            var clanakJson = parameters.GetProperty("clanak").GetRawText();
            var autoriJson = parameters.GetProperty("autori").GetRawText();

            var clanak = JsonSerializer.Deserialize<ClanakUCasopisuView>(clanakJson);
            var autori = JsonSerializer.Deserialize<List<AutorView>>(autoriJson);

            var result = DataProvider.DodajClanak(idProjekta, clanak!, autori!);

            if (result.IsError)
            {
                return StatusCode(result.Error!.StatusCode, result.Error.Message);
            }

            return StatusCode(201, "Uspešno dodat članak na projekat.");
        }
        catch (JsonException ex)
        {
            return BadRequest($"Nevalidan JSON format: {ex.Message}");
        }
    }

    [HttpGet]
    [Route("Preuzmi/{id}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status403Forbidden)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public IActionResult PreuzmiClanak(int id)
    {
        (bool isError, var clanak, var error) = DataProvider.VratiClanak(id);

        if (isError)
        {
            return StatusCode(error?.StatusCode ?? 400, error?.Message);
        }

        return Ok(clanak);
    }

    [HttpDelete]
    [Route("Obrisi/{idProjekta}/{issn}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status403Forbidden)]
    public IActionResult ObrisiClanak(int idProjekta, string issn)
    {
        (bool isError, var clanak, var error) = DataProvider.ObrisiClanak(idProjekta, issn);

        if (isError)
        {
            return StatusCode(error?.StatusCode ?? 400, error?.Message);
        }

        return Ok($"Članak sa ISSN-om {issn} je uspešno obrisan sa projekta.");
    }

    [HttpPut]
    [Route("Izmeni")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status403Forbidden)]
    public IActionResult IzmeniClanak([FromBody] JsonElement parameters)
    {
        try
        {
            var clanakJson = parameters.GetProperty("clanak").GetRawText();
            var autoriJson = parameters.GetProperty("autori").GetRawText();

            var clanak = JsonSerializer.Deserialize<ClanakUCasopisuView>(clanakJson);
            var autori = JsonSerializer.Deserialize<List<AutorView>>(autoriJson);

            var result = DataProvider.AzurirajClanakSaAutorima(clanak!, autori!);

            if (result.IsError)
            {
                return StatusCode(result.Error!.StatusCode, result.Error.Message);
            }

            return Ok($"Članak sa ISSN-om {clanak!.ISSN} je uspešno izmenjen.");
        }
        catch (JsonException ex)
        {
            return BadRequest($"Nevalidan JSON format: {ex.Message}");
        }
    }
}
