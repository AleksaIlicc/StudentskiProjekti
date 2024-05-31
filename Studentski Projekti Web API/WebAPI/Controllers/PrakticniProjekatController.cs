using Microsoft.AspNetCore.Mvc;
using Library;
using Library.DTOs;
using System.Text.Json;
using static System.Runtime.InteropServices.JavaScript.JSType;

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

            (bool isError, var result, var error) = DataProvider.DodajPrakticniProjekat(projekat!, stranice!);

            if (isError)
            {
                return StatusCode(error?.StatusCode ?? 400, error?.Message);
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
        (bool isError, var result, var error) = DataProvider.ObrisiUcesnikePrakticnogProjekta(id);

        if (isError)
        {
            return StatusCode(error?.StatusCode ?? 400, error?.Message);
        }

        return Ok($"Ucesca prakticnog projekta su uspesno obrisana.");
    }

    [HttpDelete]
    [Route("Obrisi/{id}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ProducesResponseType(StatusCodes.Status403Forbidden)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public IActionResult ObrisiPrakticniProjekat(int id)
    {
        (bool isError, var result, var error) = DataProvider.ObrisiPrakticniProjekat(id);

        if (isError)
        {
            return StatusCode(error?.StatusCode ?? 400, error?.Message);
        }

        return Ok($"Prakticni projekat je uspesno obrisan.");
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

            (bool isError, var result, var error) = DataProvider.AzurirajPrakticniProjekatSaStranicama(projekat!, stranice!);

            if (isError)
            {
                return StatusCode(error?.StatusCode ?? 400, error?.Message);
            }

            return Ok($"Prakticni projekat je uspesno azuriran.");
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
        (bool isError, var projekat, var error) = DataProvider.VratiPrakticniProjekat(id);
        if (isError)
        {
            return StatusCode(error?.StatusCode ?? 400, error?.Message);
        }

        return Ok(projekat);
    }
}
