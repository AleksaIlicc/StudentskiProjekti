using Microsoft.AspNetCore.Mvc;
using Library;
using Library.DTOs;

namespace WebAPI.Controllers;

[ApiController]
[Route("Predmet")]
public class PredmetController : ControllerBase
{
	[HttpGet]
	[Route("Preuzmi/Sve")]
	[ProducesResponseType(StatusCodes.Status200OK)]
	[ProducesResponseType(StatusCodes.Status400BadRequest)]
	[ProducesResponseType(StatusCodes.Status403Forbidden)]
	public async Task<IActionResult> VratiSvePredmete()
	{
		(bool isError, var predmeti, var error) = await DataProvider.VratiSvePredmeteAsync();

		if (isError)
		{
			return StatusCode(error?.StatusCode ?? 400, error?.Message);
		}

		return Ok(predmeti);
	}

	[HttpGet]
	[Route("Preuzmi/Sortirani")]
	[ProducesResponseType(StatusCodes.Status200OK)]
	[ProducesResponseType(StatusCodes.Status400BadRequest)]
	[ProducesResponseType(StatusCodes.Status403Forbidden)]
	public IActionResult VratiSortiranePredmete(string? semestar = null, string? katedra = null)
	{
		(bool isError, var predmeti, var error) = DataProvider.VratiSortiranePredmete(semestar, katedra);

		if (isError)
		{
			return StatusCode(error?.StatusCode ?? 400, error?.Message);
		}

		return Ok(predmeti);
	}

	[HttpPost]
	[Route("Dodaj")]
	[ProducesResponseType(StatusCodes.Status201Created)]
	[ProducesResponseType(StatusCodes.Status404NotFound)]
	[ProducesResponseType(StatusCodes.Status403Forbidden)]
	[ProducesResponseType(StatusCodes.Status400BadRequest)]
	public IActionResult DodajPredmet([FromBody] PredmetView predmet)
	{
		(bool isError, var result, var error) = DataProvider.DodajPredmet(predmet);

		if (isError)
		{
			return StatusCode(error?.StatusCode ?? 400, error?.Message);
		}

		return StatusCode(201, $"Predmet sa sifrom {predmet.Id} uspesno dodat.");
	}

	[HttpDelete]
	[Route("Obrisi/{sifra}")]
	[ProducesResponseType(StatusCodes.Status200OK)]
	[ProducesResponseType(StatusCodes.Status400BadRequest)]
	[ProducesResponseType(StatusCodes.Status403Forbidden)]
	public IActionResult ObrisiPredmet(string sifra)
	{
		(bool isError, var result, var error) = DataProvider.ObrisiPredmet(sifra);

		if (isError)
		{
			return StatusCode(error?.StatusCode ?? 400, error?.Message);
		}

		return Ok($"Predmet sa sifrom {sifra} je uspesno obrisan.");
	}

	[HttpPut]
	[Route("Izmeni")]
	[ProducesResponseType(StatusCodes.Status200OK)]
	[ProducesResponseType(StatusCodes.Status400BadRequest)]
	[ProducesResponseType(StatusCodes.Status403Forbidden)]
	public IActionResult IzmeniPredmet([FromBody] PredmetView predmet)
	{
		(bool isError, var result, var error) = DataProvider.AzurirajPredmet(predmet);

		if (isError)
		{
			return StatusCode(error?.StatusCode ?? 400, error?.Message);
		}

		return Ok($"Predmet sa sifrom {predmet.Id} je uspesno izmenjen.");
	}

	[HttpGet]
	[Route("Preuzmi/{sifra}")]
	[ProducesResponseType(StatusCodes.Status200OK)]
	[ProducesResponseType(StatusCodes.Status404NotFound)]
	[ProducesResponseType(StatusCodes.Status403Forbidden)]
	[ProducesResponseType(StatusCodes.Status400BadRequest)]
	public IActionResult PreuzmiPredmet(string sifra)
	{
		(bool isError, var predmet, var error) = DataProvider.VratiPredmet(sifra);

		if (isError)
		{
			return StatusCode(error?.StatusCode ?? 400, error?.Message);
		}

		return Ok(predmet);
	}
}
