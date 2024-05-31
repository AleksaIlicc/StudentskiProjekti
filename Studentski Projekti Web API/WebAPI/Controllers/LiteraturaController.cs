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
	public IActionResult DodajAutora([FromBody] AutorView autor, int idLit)
	{
		(bool isError, var result, var error) = DataProvider.DodajAutora(idLit, autor);

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
	public IActionResult PreuzmiAutore(int id)
	{
		(bool isError, var autori, var error) = DataProvider.VratiAutoreZaLiteraturu(id);

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
	public IActionResult ObrisiAutora(int idLit, [FromBody] AutorView autor)
	{
		(bool isError, var result, var error) = DataProvider.ObrisiAutora(idLit, autor);

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
	public IActionResult ObrisiLiteraturu(int idLit)
	{
		(bool isError, var result, var error) = DataProvider.ObrisiLiteraturu(idLit);

		if (isError)
		{
			return StatusCode(error?.StatusCode ?? 400, error?.Message);
		}

		return Ok($"Uspesno je obrisana literatura.");
	}

    [HttpGet]
    [Route("Preuzmi/Sve")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status403Forbidden)]
    public async Task<IActionResult> VratiSveLiterature()
    {
        (bool isError, var literature, var error) = await DataProvider.VratiSveLiteratureAsync();

        if (isError)
        {
            return StatusCode(error?.StatusCode ?? 400, error?.Message);
        }

        return Ok(literature);
    }

    [HttpGet]
    [Route("Preuzmi/Pretrazene")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status403Forbidden)]
    public IActionResult VratiPretrazeneLiterature(string search)
    {
        (bool isError, var literature, var error) = DataProvider.VratiPretrazeneLiterature(search);

        if (isError)
        {
            return StatusCode(error?.StatusCode ?? 400, error?.Message);
        }

        return Ok(literature);
    }
}
