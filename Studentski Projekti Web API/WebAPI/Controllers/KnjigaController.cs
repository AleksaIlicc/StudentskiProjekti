using Microsoft.AspNetCore.Mvc;
using Library;
using Library.DTOs;
using System.Text.Json;

namespace WebAPI.Controllers;

[ApiController]
[Route("Projekat/Teorijski/Literatura/Knjiga")]
public class KnjigaController:ControllerBase
{
    [HttpGet]
    [Route("Preuzmi/Sve/{id}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status403Forbidden)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public IActionResult PreuzmiSveKnjige(int id)
	{
		(bool isError, var knjige, var error) = DataProvider.VratiKnjigeZaTProjekat(id);

		if (isError)
		{
			return StatusCode(error?.StatusCode ?? 400, error?.Message);
		}

		return Ok(knjige);
	}

	[HttpGet]
	[Route("Preuzmi/Id/{isbn}")]
	[ProducesResponseType(StatusCodes.Status200OK)]
	[ProducesResponseType(StatusCodes.Status403Forbidden)]
	[ProducesResponseType(StatusCodes.Status400BadRequest)]
	public IActionResult VratiIdLiteratureKnjige(string isbn)
	{
		(bool isError, var litId, var error) = DataProvider.VratiIdLiteratureKnjige(isbn);

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
	public IActionResult DodajKnjigu([FromBody] JsonElement parameters, int idProjekta)
	{
		try
		{
			var knjigaJson = parameters.GetProperty("knjiga").GetRawText();
			var autoriJson = parameters.GetProperty("autori").GetRawText();

			var knjiga = JsonSerializer.Deserialize<KnjigaView>(knjigaJson);
			var autori = JsonSerializer.Deserialize<List<AutorView>>(autoriJson);

			var (isError, result, error) = DataProvider.DodajKnjigu(idProjekta, knjiga!, autori!);

			if (isError)
			{
				return StatusCode(error?.StatusCode ?? 400, error?.Message);
			}

			return StatusCode(201, $"Uspesno dodata knjiga na projektu.");
		}
		catch (JsonException ex)
		{
			return BadRequest($"Nevalidan JSON format: {ex.Message}");
		}
	}

	[HttpGet]
	[Route("Preuzmi/{isbn}")]
	[ProducesResponseType(StatusCodes.Status200OK)]
	[ProducesResponseType(StatusCodes.Status403Forbidden)]
	[ProducesResponseType(StatusCodes.Status400BadRequest)]
	public IActionResult PreuzmiKnjigu(string isbn)
	{
		(bool isError, var knjiga, var error) = DataProvider.VratiKnjigu(isbn);

		if (isError)
		{
			return StatusCode(error?.StatusCode ?? 400, error?.Message);
		}

		return Ok(knjiga);
	}

	[HttpDelete]
	[Route("Obrisi/{idProjekta}/{isbn}")]
	[ProducesResponseType(StatusCodes.Status200OK)]
	[ProducesResponseType(StatusCodes.Status400BadRequest)]
	[ProducesResponseType(StatusCodes.Status403Forbidden)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public IActionResult ObrisiKnjigu(int idProjekta,string isbn)
	{
		(bool isError, var result, var error) = DataProvider.ObrisiKnjigu(idProjekta, isbn);

		if (isError)
		{
			return StatusCode(error?.StatusCode ?? 400, error?.Message);
		}

		return Ok($"Knjiga sa ISBN-om {isbn} je uspesno uklonjena sa projekta.");
	}

	[HttpPut]
	[Route("Izmeni")]
	[ProducesResponseType(StatusCodes.Status200OK)]
	[ProducesResponseType(StatusCodes.Status400BadRequest)]
	[ProducesResponseType(StatusCodes.Status403Forbidden)]
	public IActionResult IzmeniKnjigu([FromBody] JsonElement parameters)
	{
		try
		{
			var knjigaJson = parameters.GetProperty("knjiga").GetRawText();
			var autoriJson = parameters.GetProperty("autori").GetRawText();

			var knjiga = JsonSerializer.Deserialize<KnjigaView>(knjigaJson);
			var autori = JsonSerializer.Deserialize<List<AutorView>>(autoriJson);

			var (isError, result, error) = DataProvider.AzurirajKnjiguSaAutorima(knjiga!, autori!);

			if (isError)
			{
				return StatusCode(error?.StatusCode ?? 400, error?.Message);
			}

			return Ok($"Knjiga sa ISBN-om {knjiga!.ISBN} je uspesno izmenjena.");
		}
		catch (JsonException ex)
		{
			return BadRequest($"Nevalidan JSON format: {ex.Message}");
		}
	}
}
