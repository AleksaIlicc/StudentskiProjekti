using Microsoft.AspNetCore.Mvc;
using Library;
using Library.DTOs;

namespace WebAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class TeorijskiProjekatController : Controller
{
	[HttpPost]
	[Route("DodajProjekat")]
	[ProducesResponseType(StatusCodes.Status201Created)]
	[ProducesResponseType(StatusCodes.Status404NotFound)]
	[ProducesResponseType(StatusCodes.Status403Forbidden)]
	[ProducesResponseType(StatusCodes.Status400BadRequest)]
	public IActionResult DodajProjekat([FromBody] TeorijskiProjekatView projekat)
	{
		(bool isError, var result, var error) = DataProvider.DodajTeorijskiProjekat(projekat);

		if (isError)
		{
			return StatusCode(error?.StatusCode ?? 400, error?.Message);
		}

		return StatusCode(201, $"Teorijski projekat je uspesno dodat.");
	}

	[HttpDelete]
	[Route("ObrisiProjekat/{id}")]
	[ProducesResponseType(StatusCodes.Status200OK)]
	[ProducesResponseType(StatusCodes.Status400BadRequest)]
	[ProducesResponseType(StatusCodes.Status403Forbidden)]
	public IActionResult ObrisiProjekat(int id)
	{
		(bool isError, var result, var error) = DataProvider.ObrisiTeorijskiProjekat(id);

		if (isError)
		{
			return StatusCode(error?.StatusCode ?? 400, error?.Message);
		}

		return Ok("Teorijski projekat je uspesno obrisan.");
	}

	[HttpPut]
	[Route("IzmeniProjekat")]
	[ProducesResponseType(StatusCodes.Status200OK)]
	[ProducesResponseType(StatusCodes.Status400BadRequest)]
	[ProducesResponseType(StatusCodes.Status403Forbidden)]
	public IActionResult IzmeniProjekat([FromBody] TeorijskiProjekatView projekat)
	{
		(bool isError, var result, var error) = DataProvider.AzurirajTeorijskiProjekat(projekat);

		if (isError)
		{
			return StatusCode(error?.StatusCode ?? 400, error?.Message);
		}

		return Ok("Teorijski projekat je uspesno izmenjen.");
	}

	[HttpGet]
	[Route("PreuzmiTeorijskiProjekat/{id}")]
	[ProducesResponseType(StatusCodes.Status200OK)]
	[ProducesResponseType(StatusCodes.Status404NotFound)]
	[ProducesResponseType(StatusCodes.Status403Forbidden)]
	[ProducesResponseType(StatusCodes.Status400BadRequest)]
	public IActionResult PreuzmiTeorijskiProjekat(int id)
	{
		(bool isError, var result, var error) = DataProvider.VratiTeorijskiProjekat(id);

		if (isError)
		{
			return StatusCode(error?.StatusCode ?? 400, error?.Message);
		}

		return Ok(result);
	}
}
