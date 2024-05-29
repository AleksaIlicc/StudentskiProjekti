using Microsoft.AspNetCore.Mvc;
using Library;
using Library.DTOs;

namespace WebAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class UcestvujeController : ControllerBase
{
	[HttpGet]
	[Route("PreuzmiUcesce/{projid}/{studid}")]
	[ProducesResponseType(StatusCodes.Status200OK)]
	[ProducesResponseType(StatusCodes.Status400BadRequest)]
	[ProducesResponseType(StatusCodes.Status403Forbidden)]
	public IActionResult VratiUcesce(string projid, string studid)
	{
		(bool isError, var ucesce, var error) = DataProvider.VratiUcesce(Int32.Parse(projid),studid);

		if (isError)
		{
			return StatusCode(error?.StatusCode ?? 400, error?.Message);
		}

		return Ok(ucesce);
	}

	[HttpPost]
	[Route("DodajUcesce/{projid}/{studid}")]
	[ProducesResponseType(StatusCodes.Status201Created)]
	[ProducesResponseType(StatusCodes.Status404NotFound)]
	[ProducesResponseType(StatusCodes.Status403Forbidden)]
	[ProducesResponseType(StatusCodes.Status400BadRequest)]
	public IActionResult DodajUcesce([FromBody] UcestvujeView ucestvuje, string projid, string studid)
	{
		(bool isError, var result, var error) = DataProvider.DodajUcesce(studid, Int32.Parse(projid), ucestvuje);

		if (isError)
		{
			return StatusCode(error?.StatusCode ?? 400, error?.Message);
		}

		return StatusCode(201, $"Uspesno dodato ucesce studenta na projektu.");
	}

	[HttpDelete]
	[Route("ObrisiUcesce/{id}")]
	[ProducesResponseType(StatusCodes.Status200OK)]
	[ProducesResponseType(StatusCodes.Status400BadRequest)]
	[ProducesResponseType(StatusCodes.Status403Forbidden)]
	public IActionResult ObrisiUcesce(string id)
	{
		(bool isError, var result, var error) = DataProvider.ObrisiUcesce(Int32.Parse(id));

		if (isError)
		{
			return StatusCode(error?.StatusCode ?? 400, error?.Message);
		}

		return Ok($"Uspesno obrisano ucesce studenta na projektu.");
	}

	[HttpPut]
	[Route("AzurirajUcesce")]
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
}
