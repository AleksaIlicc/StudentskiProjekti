using Microsoft.AspNetCore.Mvc;
using Library;
using Library.DTOs;
using System.Text.Json;

namespace WebAPI.Controllers;

[ApiController]
[Route("Projekat/Prakticni")]

public class PrakticniProjekatController : Controller
{
    [HttpPost]
    [Route("Dodaj")]
    [ProducesResponseType(StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ProducesResponseType(StatusCodes.Status403Forbidden)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public IActionResult DodajPProjekat([FromBody] JsonElement parameters)
    {
        try
        {
            var projekatJson = parameters.GetProperty("projekat").GetRawText();
            var straniceJson = parameters.GetProperty("stranice").GetRawText();

            var projekat = JsonSerializer.Deserialize<PrakticniProjekatView>(projekatJson);
            var stranice = JsonSerializer.Deserialize<List<PreporucenaWebStranicaView>>(straniceJson);

            var result = DataProvider.DodajPrakticniProjekat(projekat!, stranice!);

            if (result.IsError)
            {
                return StatusCode(result.Error.StatusCode, result.Error.Message);
            }

            return StatusCode(201, $"Prakticni projekat '{projekat!.Naziv}' je uspesno dodat.");
        }
        catch (JsonException ex)
        {
            return BadRequest($"Nevalidan JSON format: {ex.Message}");
        }
    }

    [HttpDelete]
    [Route("ObrisiSvaUcesca/{id}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ProducesResponseType(StatusCodes.Status403Forbidden)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public IActionResult ObrisiUcesnikePrakticnogProjekta(int id)
    {
        var result = DataProvider.ObrisiUcesnikePrakticnogProjekta(id);

        if (result.IsError)
        {
            return StatusCode(result.Error.StatusCode, result.Error.Message);
        }

        return Ok($"Ucesca prakticnog projekta sa id {id} su uspesno obrisani.");
    }

    [HttpDelete]
    [Route("Obrisi/{id}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ProducesResponseType(StatusCodes.Status403Forbidden)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public IActionResult ObrisiPrakticniProjekat(int id)
    {
        var result = DataProvider.ObrisiPrakticniProjekat(id);

        if (result.IsError)
        {
            return StatusCode(result.Error.StatusCode, result.Error.Message);
        }

        return Ok($"Prakticni projekat sa id {id} je uspesno obrisan.");
    }

    [HttpPut]
    [Route("Azuriraj")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ProducesResponseType(StatusCodes.Status403Forbidden)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public IActionResult AzurirajPrakticniProjekat([FromBody] JsonElement parameters)
    {
        try
        {
            var projekatJson = parameters.GetProperty("projekat").GetRawText();
            var straniceJson = parameters.GetProperty("stranice").GetRawText();

            var projekat = JsonSerializer.Deserialize<PrakticniProjekatView>(projekatJson);
            var stranice = JsonSerializer.Deserialize<List<PreporucenaWebStranicaView>>(straniceJson);

            var result = DataProvider.AzurirajPrakticniProjekatSaStranicama(projekat!, stranice!);

            if (result.IsError)
            {
                return StatusCode(result.Error.StatusCode, result.Error.Message);
            }

            return Ok($"Prakticni projekat sa id {projekat!.Id} je uspesno azuriran.");
        }
        catch (JsonException ex)
        {
            return BadRequest($"Nevalidan JSON format: {ex.Message}");
        }
    }

    [HttpGet]
    [Route("VratiProjekat/{id}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ProducesResponseType(StatusCodes.Status403Forbidden)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public IActionResult VratiPrakticniProjekat(int id)
    {
        var result = DataProvider.VratiPrakticniProjekat(id);

        if (result.IsError)
        {
            return StatusCode(result.Error.StatusCode, result.Error.Message);
        }

        var prakticniProjekat = result.Data;

        if (prakticniProjekat == null)
        {
            return NotFound($"Prakticni projekat sa id {id} nije pronađen.");
        }

        return Ok(prakticniProjekat);
    }
}
