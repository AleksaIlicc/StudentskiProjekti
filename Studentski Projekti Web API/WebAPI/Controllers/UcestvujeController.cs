using Microsoft.AspNetCore.Mvc;
using Library;
using Library.DTOs;

namespace WebAPI.Controllers;

[ApiController]
[Route("Ucesce")]
public class UcestvujeController : ControllerBase
{
	[HttpGet]
	[Route("Preuzmi/{projid}/{studid}")]
	[ProducesResponseType(StatusCodes.Status200OK)]
	[ProducesResponseType(StatusCodes.Status400BadRequest)]
	[ProducesResponseType(StatusCodes.Status403Forbidden)]
	public IActionResult VratiUcesce(int projid, string studid)
	{
		(bool isError, var ucesce, var error) = DataProvider.VratiUcesce(projid,studid);

		if (isError)
		{
			return StatusCode(error?.StatusCode ?? 400, error?.Message);
		}

		return Ok(ucesce);
	}

    [HttpGet]
    [Route("PreuzmiDetalje/{projid}/{studid}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status403Forbidden)]
    public IActionResult VratiUcesceDetalji(int projid, string studid)
    {
        (bool isError, var ucesce, var error) = DataProvider.VratiUcesceDetalji(studid, projid);

        if (isError)
        {
            return StatusCode(error?.StatusCode ?? 400, error?.Message);
        }

        return Ok(ucesce);
    }

    [HttpPost]
	[Route("Dodaj/{projid}/{studid}")]
	[ProducesResponseType(StatusCodes.Status201Created)]
	[ProducesResponseType(StatusCodes.Status404NotFound)]
	[ProducesResponseType(StatusCodes.Status403Forbidden)]
	[ProducesResponseType(StatusCodes.Status400BadRequest)]
	[ProducesResponseType(StatusCodes.Status409Conflict)]
	public IActionResult DodajUcesce([FromBody] UcestvujeView ucestvuje, int projid, string studid)
	{
		(bool isError, var result, var error) = DataProvider.DodajUcesce(studid, projid, ucestvuje);

		if (isError)
		{
			return StatusCode(error?.StatusCode ?? 400, error?.Message);
		}

		return StatusCode(201, $"Uspesno dodato ucesce studenta na projektu.");
	}

	[HttpDelete]
	[Route("Obrisi/{id}")]
	[ProducesResponseType(StatusCodes.Status200OK)]
	[ProducesResponseType(StatusCodes.Status400BadRequest)]
	[ProducesResponseType(StatusCodes.Status403Forbidden)]
	public IActionResult ObrisiUcesce(int id)
	{
		(bool isError, var result, var error) = DataProvider.ObrisiUcesce(id);

		if (isError)
		{
			return StatusCode(error?.StatusCode ?? 400, error?.Message);
		}

		return Ok($"Uspesno obrisano ucesce studenta na projektu.");
	}

	[HttpPut]
	[Route("Azuriraj")]
	[ProducesResponseType(StatusCodes.Status200OK)]
	[ProducesResponseType(StatusCodes.Status400BadRequest)]
	[ProducesResponseType(StatusCodes.Status403Forbidden)]
	public IActionResult AzurirajUcesce([FromBody] UcestvujeView ucestvuje)
	{
		(bool isError, var result, var error) = DataProvider.AzurirajUcesce(ucestvuje);

		if (isError)
		{
			return StatusCode(error?.StatusCode ?? 400, error?.Message);
		}

		return Ok($"Uspesno azurirano ucesce studenta na projektu.");
	}

    [HttpGet]
    [Route("ZaStudenta/{studentId}/{projId}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ProducesResponseType(StatusCodes.Status403Forbidden)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public IActionResult VratiUcesceDetalji(string studentId, int projId)
    {
        (bool isError, var result, var error) = DataProvider.VratiUcesceDetalji(studentId, projId);

        if (isError)
        {
            return StatusCode(error?.StatusCode ?? 400, error?.Message);
        }

        return Ok(result);
    }
}
