using Microsoft.AspNetCore.Mvc;
using Library;
using Library.DTOs;
using System.Text.Json;

namespace WebAPI.Controllers;

[ApiController]
[Route("Projekat/Teorijski/Literatura/Rad")]
public class RadController:ControllerBase
{
    [HttpGet]
    [Route("Preuzmi/Sve/{id}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status403Forbidden)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public IActionResult PreuzmiSveRadove(string id)
	{
		(bool isError, var radovi, var error) = DataProvider.VratiRadoveZaTProjekat(Int32.Parse(id));

		if (isError)
		{
			return StatusCode(error?.StatusCode ?? 400, error?.Message);
		}

		return Ok(radovi);
	}

	[HttpGet]
	[Route("Preuzmi/Id/{id}")]
	[ProducesResponseType(StatusCodes.Status200OK)]
	[ProducesResponseType(StatusCodes.Status403Forbidden)]
	[ProducesResponseType(StatusCodes.Status400BadRequest)]
	public IActionResult VratiIdLiteratureRada(string id)
	{
		(bool isError, var litId, var error) = DataProvider.VratiIdLiteratureRada(Int32.Parse(id));

		if (isError)
		{
			return StatusCode(error?.StatusCode ?? 400, error?.Message);
		}

		return Ok(litId);
	}

	[HttpPost]
	[Route("Dodaj/{idProjekta}")]
	[ProducesResponseType(StatusCodes.Status200OK)]
	[ProducesResponseType(StatusCodes.Status403Forbidden)]
	[ProducesResponseType(StatusCodes.Status400BadRequest)]
	public IActionResult DodajRad([FromBody] JsonElement parameters, string idProjekta)
	{
		try
		{
			var radJson = parameters.GetProperty("rad").GetRawText();
			var autoriJson = parameters.GetProperty("autori").GetRawText();

			var rad = JsonSerializer.Deserialize<RadView>(radJson);
			var autori = JsonSerializer.Deserialize<List<AutorView>>(autoriJson);

			var (isError, result, error) = DataProvider.DodajRad(Int32.Parse(idProjekta), rad!, autori!);

			if (isError)
			{
				return StatusCode(error?.StatusCode ?? 400, error?.Message);
			}

			return StatusCode(201, $"Uspesno dodat rad na projektu.");
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
	public IActionResult PreuzmiRad(string id)
	{
		(bool isError, var rad, var error) = DataProvider.VratiRad(Int32.Parse(id));

		if (isError)
		{
			return StatusCode(error?.StatusCode ?? 400, error?.Message);
		}

		return Ok(rad);
	}

	[HttpDelete]
	[Route("Obrisi/{idProjekta}/{id}")]
	[ProducesResponseType(StatusCodes.Status200OK)]
	[ProducesResponseType(StatusCodes.Status400BadRequest)]
	[ProducesResponseType(StatusCodes.Status403Forbidden)]
	public IActionResult ObrisiRad(int idProjekta, int id)
	{
		(bool isError, var result, var error) = DataProvider.ObrisiRad(idProjekta, id);

		if (isError)
		{
			return StatusCode(error?.StatusCode ?? 400, error?.Message);
		}

		return Ok($"Rad je uspesno uklonjen sa projekta.");
	}

	[HttpPut]
	[Route("Izmeni")]
	[ProducesResponseType(StatusCodes.Status200OK)]
	[ProducesResponseType(StatusCodes.Status400BadRequest)]
	[ProducesResponseType(StatusCodes.Status403Forbidden)]
	public IActionResult IzmeniRad([FromBody] JsonElement parameters)
	{
		try
		{
			var radJson = parameters.GetProperty("rad").GetRawText();
			var autoriJson = parameters.GetProperty("autori").GetRawText();

			var rad = JsonSerializer.Deserialize<RadView>(radJson);
			var autori = JsonSerializer.Deserialize<List<AutorView>>(autoriJson);

			var (isError, result, error) = DataProvider.AzurirajRadSaAutorima(rad!, autori!);

			if (isError)
			{
				return StatusCode(error?.StatusCode ?? 400, error?.Message);
			}

			return Ok($"Rad je uspesno izmenjen.");
		}
		catch (JsonException ex)
		{
			return BadRequest($"Nevalidan JSON format: {ex.Message}");
		}
	}
}
