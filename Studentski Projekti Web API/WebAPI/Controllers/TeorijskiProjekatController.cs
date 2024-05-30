using Microsoft.AspNetCore.Mvc;
using Library;
using Library.DTOs;

namespace WebAPI.Controllers;

[ApiController]
[Route("/Projekat/Teorijski")]
public class TeorijskiProjekatController : Controller
{
	[HttpPost]
	[Route("Dodaj")]
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
	[Route("Obrisi/{id}")]
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
	[Route("Izmeni")]
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
	[Route("Preuzmi/{id}")]
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

	[HttpDelete]
	[Route("ObrisiSvaUcesca/{id}")]
	[ProducesResponseType(StatusCodes.Status200OK)]
	[ProducesResponseType(StatusCodes.Status400BadRequest)]
	[ProducesResponseType(StatusCodes.Status403Forbidden)]
	public IActionResult ObrisiSvaUcescaNaProjektu(int id)
	{
		(bool isError, var result, var error) = DataProvider.ObrisiUcesnikeProjekta(id);

		if (isError)
		{
			return StatusCode(error?.StatusCode ?? 400, error?.Message);
		}

		return Ok("Uspesno obrisana sva ucesca na projektu.");
	}
}
