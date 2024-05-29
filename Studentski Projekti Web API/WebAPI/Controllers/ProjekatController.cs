using Microsoft.AspNetCore.Mvc;
using Library;
using Library.DTOs;

namespace WebAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class ProjekatController : Controller
{
	[HttpGet]
	[Route("PreuzmiProjekteZaPredmet/{id}")]
	[ProducesResponseType(StatusCodes.Status200OK)]
	[ProducesResponseType(StatusCodes.Status400BadRequest)]
	[ProducesResponseType(StatusCodes.Status403Forbidden)]
	public async Task<IActionResult> VratiProjekteZaPredmet(string id)
	{
		(bool isError, var projekti, var error) = await DataProvider.VratiSveProjektePredmetaAsync(id);

		if (isError)
		{
			return StatusCode(error?.StatusCode ?? 400, error?.Message);
		}

		return Ok(projekti);
	}

	[HttpGet]
	[Route("PreuzmiSortiraneProjekteZaPredmet/{id}")]
	[ProducesResponseType(StatusCodes.Status200OK)]
	[ProducesResponseType(StatusCodes.Status400BadRequest)]
	[ProducesResponseType(StatusCodes.Status403Forbidden)]
	public IActionResult VratiSortiraneProjekteZaPredmet(string id, [FromQuery(Name = "vrsta")] string? vrstaProjekta = null, [FromQuery(Name = "tip")] string? tipProjekta = null, [FromQuery(Name = "godina")] string? skolskaGodina = null)
	{
		(bool isError, var projekti, var error) = DataProvider.VratiSortiraneProjekteZaPredmet(id, vrstaProjekta!, tipProjekta!, skolskaGodina!);

		if (isError)
		{
			return StatusCode(error?.StatusCode ?? 400, error?.Message);
		}

		return Ok(projekti);
	}
}
