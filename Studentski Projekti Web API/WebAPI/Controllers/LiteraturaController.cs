using Microsoft.AspNetCore.Mvc;
using Library;
using Library.DTOs;

namespace WebAPI.Controllers;

[ApiController]
[Route("Projekat/Teorijski/Literatura")]
public class LiteraturaController : Controller
{
	[HttpPost]
	[Route("Autori/Dodaj/{idLit}")]
	[ProducesResponseType(StatusCodes.Status201Created)]
	[ProducesResponseType(StatusCodes.Status404NotFound)]
	[ProducesResponseType(StatusCodes.Status403Forbidden)]
	[ProducesResponseType(StatusCodes.Status400BadRequest)]
	[ProducesResponseType(StatusCodes.Status409Conflict)]
	public IActionResult DodajAutora([FromBody] AutorView autor, string idLit)
	{
		(bool isError, var result, var error) = DataProvider.DodajAutora(Int32.Parse(idLit), autor );

		if (isError)
		{
			return StatusCode(error?.StatusCode ?? 400, error?.Message);
		}

		return StatusCode(201, $"Uspesno je dodat autor {autor.Autor} za literaturu.");
	}

	[HttpGet]
	[Route("Autori/Preuzmi/{id}")]
	[ProducesResponseType(StatusCodes.Status200OK)]
	[ProducesResponseType(StatusCodes.Status404NotFound)]
	[ProducesResponseType(StatusCodes.Status403Forbidden)]
	[ProducesResponseType(StatusCodes.Status400BadRequest)]
	public IActionResult PreuzmiAutore(string id)
	{
		(bool isError, var autori, var error) = DataProvider.VratiAutoreZaLiteraturu(Int32.Parse(id));

		if (isError)
		{
			return StatusCode(error?.StatusCode ?? 400, error?.Message);
		}

		return Ok(autori);
	}

	[HttpDelete]
	[Route("Autori/Obrisi/{idLit}")]
	[ProducesResponseType(StatusCodes.Status200OK)]
	[ProducesResponseType(StatusCodes.Status404NotFound)]
	[ProducesResponseType(StatusCodes.Status403Forbidden)]
	[ProducesResponseType(StatusCodes.Status400BadRequest)]
	public IActionResult ObrisiAutora(string idLit, [FromBody] AutorView autor)
	{
		(bool isError, var result, var error) = DataProvider.ObrisiAutora(Int32.Parse(idLit), autor);

		if (isError)
		{
			return StatusCode(error?.StatusCode ?? 400, error?.Message);
		}

		return Ok($"Uspesno je obrisan autor {autor.Autor} za literaturu.");
	}

	[HttpDelete]
	[Route("Obrisi/{idLit}")]
	[ProducesResponseType(StatusCodes.Status200OK)]
	[ProducesResponseType(StatusCodes.Status403Forbidden)]
	[ProducesResponseType(StatusCodes.Status400BadRequest)]
	public IActionResult ObrisiLiteraturu(string idLit)
	{
		(bool isError, var result, var error) = DataProvider.ObrisiLiteraturu(Int32.Parse(idLit));

		if (isError)
		{
			return StatusCode(error?.StatusCode ?? 400, error?.Message);
		}

		return Ok($"Uspesno je obrisana literatura.");
	}
}
