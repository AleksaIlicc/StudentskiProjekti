using Microsoft.AspNetCore.Mvc;
using Library;
using Library.DTOs;

namespace WebAPI.Controllers;

[ApiController]
[Route("Student")]
public class StudentController:ControllerBase
{
    [HttpGet]
    [Route("Preuzmi/Sve")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status403Forbidden)]
    public async Task<IActionResult> VratiSveStudente()
    {
        (bool isError, var studenti, var error) = await DataProvider.VratiSveStudenteAsync();

        if (isError)
        {
            return StatusCode(error?.StatusCode ?? 400, error?.Message);
        }

        return Ok(studenti);
    }

    [HttpGet]
    [Route("Preuzmi/Sortirani")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status403Forbidden)]
    public IActionResult VratiSortiraneStudente([FromQuery(Name = "brIndeksa")] string? brindFilter = null, [FromQuery(Name = "ime")] string? imeFilter = null, [FromQuery(Name = "prezime")] string? prezimeFilter = null, [FromQuery(Name = "smer")] string? smerFilter = null)
    {
        (bool isError, var studenti, var error) = DataProvider.VratiSortiraneStudente(brindFilter, imeFilter, prezimeFilter, smerFilter);

        if (isError)
        {
            return StatusCode(error?.StatusCode ?? 400, error?.Message);
        }

        return Ok(studenti);
    }

    [HttpPost]
    [Route("Dodaj")]
    [ProducesResponseType(StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ProducesResponseType(StatusCodes.Status403Forbidden)]
    public IActionResult DodajStudenta([FromBody] StudentiView student)
    {
        (bool isError, var result, var error) = DataProvider.DodajStudenta(student);

        if (isError)
        {
            return StatusCode(error?.StatusCode ?? 400, error?.Message);
        }

        return StatusCode(201, $"Student sa brojem indeksa {student.BrIndeksa} je uspesno dodat.");
    }

    [HttpDelete]
    [Route("Obrisi/{brInd}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status403Forbidden)]
    public IActionResult ObrisiStudenta(string brInd)
    {
        (bool isError, var result, var error) = DataProvider.ObrisiStudenta(brInd);

        if (isError)
        {
            return StatusCode(error?.StatusCode ?? 400, error?.Message);
        }

        return Ok($"Student sa brojem indeksa {brInd} je uspesno obrisan.");
    }

    [HttpPut]
    [Route("Izmeni")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status403Forbidden)]
    public IActionResult IzmeniStudenta([FromBody] StudentiView student)
    {
        (bool isError, var result, var error) = DataProvider.AzurirajStudenta(student);

        if (isError)
        {
            return StatusCode(error?.StatusCode ?? 400, error?.Message);
        }

        return Ok($"Student sa brojem indeksa {student.BrIndeksa} je uspesno izmenjen.");
    }
    [HttpGet]
    [Route("Preuzmi/{brInd}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ProducesResponseType(StatusCodes.Status403Forbidden)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public IActionResult VratiStudenta(string brInd)
	{
		(bool isError, var student, var error) = DataProvider.VratiStudenta(brInd);

		if (isError)
		{
			return StatusCode(error?.StatusCode ?? 400, error?.Message);
		}

		return Ok(student);
	}
}
