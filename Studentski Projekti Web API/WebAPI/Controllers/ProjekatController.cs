using Microsoft.AspNetCore.Mvc;
using Library;

namespace WebAPI.Controllers;

[ApiController]
[Route("Projekat")]
public class ProjekatController : Controller
{
	[HttpGet]
	[Route("Preuzmi/ZaPredmet/{id}")]
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
	[Route("Preuzmi/Sortirani/ZaPredmet/{id}")]
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

	[HttpGet]
	[Route("Teorijski/Preuzmi/ZaPredmet/{id}")]
	[ProducesResponseType(StatusCodes.Status200OK)]
	[ProducesResponseType(StatusCodes.Status400BadRequest)]
	[ProducesResponseType(StatusCodes.Status403Forbidden)]
	public async Task<IActionResult> VratiTProjekteZaPredmet(string id)
	{
		(bool isError, var projekti, var error) = await DataProvider.VratiTeorijskeProjekteZaPredmetAsync(id);

		if (isError)
		{
			return StatusCode(error?.StatusCode ?? 400, error?.Message);
		}

		return Ok(projekti);
	}

    [HttpGet]
    [Route("Prakticni/Preuzmi/ZaPredmet/{id}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status403Forbidden)]
    public async Task<IActionResult> PreuzmiPProjekteZaPredmet(string id)
    {
        (bool isError, var pprojekti, var error) = await DataProvider.VratiPrakticneProjekteZaPredmetAsync(id);

        if (isError)
        {
            return StatusCode(error?.StatusCode ?? 400, error?.Message);
        }

        return Ok(pprojekti);
    }

	[HttpGet]
	[Route("Prakticni/Preuzmi/Studenti/{id}")]
	[Route("Teorijski/Preuzmi/Studenti/{id}")]
	[ProducesResponseType(StatusCodes.Status200OK)]
	[ProducesResponseType(StatusCodes.Status400BadRequest)]
	[ProducesResponseType(StatusCodes.Status403Forbidden)]
	public IActionResult VratiStudenteNaProjektu(int id)
	{
		(bool isError, var studenti, var error) = DataProvider.VratiStudenteNaProjektu(id);

		if (isError)
		{
			return StatusCode(error?.StatusCode ?? 400, error?.Message);
		}

		return Ok(studenti);
	}
}
