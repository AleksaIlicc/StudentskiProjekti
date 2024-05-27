using Microsoft.AspNetCore.Mvc;
using Library;

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
}
