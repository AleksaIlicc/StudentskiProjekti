using Microsoft.AspNetCore.Mvc;
using Library;
using Library.DTOs;

namespace WebAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class PredmetController : ControllerBase
{
	[HttpGet]
	[Route("PreuzmiPredmete")]
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
	[Route("PreuzmiSortiranePredmete")]
	[ProducesResponseType(StatusCodes.Status200OK)]
	[ProducesResponseType(StatusCodes.Status400BadRequest)]
	[ProducesResponseType(StatusCodes.Status403Forbidden)]
	public IActionResult VratiSortiranePredmete([FromQuery(Name = "semestar")] string? semestarFilter = null, [FromQuery(Name = "katedra")] string? katedraFilter = null)
	{
		(bool isError, var predmeti, var error) = DataProvider.VratiSortiranePredmete(semestarFilter, katedraFilter);

		if (isError)
		{
			return StatusCode(error?.StatusCode ?? 400, error?.Message);
		}

		return Ok(predmeti);
	}

	[HttpPost]
	[Route("DodajPredmet")]
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
	[Route("ObrisiPredmet/{sifra}")]
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

		return Ok($"Predmet sa sifrom {sifra} uspesno obrisan.");
	}

	[HttpPut]
	[Route("IzmeniPredmet")]
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

		return Ok($"Predmet sa sifrom {predmet.Id} uspesno izmenjen.");
	}

	[HttpGet]
	[Route("PreuzmiPredmet/{sifra}")]
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
