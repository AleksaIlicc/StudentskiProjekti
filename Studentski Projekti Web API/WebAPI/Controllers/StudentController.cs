using Microsoft.AspNetCore.Mvc;
using Library;
using Library.DTOs;

namespace WebAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class StudentController:ControllerBase
{
    [HttpGet]
    [Route("PreuzmiStudente")]
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
    [Route("PreuzmiSortiraneStudente")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status403Forbidden)]
    public IActionResult VratiSortiranePredmete([FromQuery(Name = "brIndeksa")] string? brindFilter = null, [FromQuery(Name = "ime")] string? imeFilter = null, [FromQuery(Name = "prezime")] string? prezimeFilter = null, [FromQuery(Name = "smer")] string? smerFilter = null)
    {
        (bool isError, var studenti, var error) = DataProvider.VratiSortiraneStudente(brindFilter, imeFilter, prezimeFilter, smerFilter);

        if (isError)
        {
            return StatusCode(error?.StatusCode ?? 400, error?.Message);
        }

        return Ok(studenti);
    }

    [HttpPost]
    [Route("DodajStudenta")]
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

        return StatusCode(201, $"Student sa brojem inedksa {student.BrIndeksa} je uspesno dodat.");
    }

    [HttpDelete]
    [Route("ObrisiStudenta/{brInd}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status403Forbidden)]
    public IActionResult ObrisiPredmet(string brInd)
    {
        (bool isError, var result, var error) = DataProvider.ObrisiStudenta(brInd);

        if (isError)
        {
            return StatusCode(error?.StatusCode ?? 400, error?.Message);
        }

        return Ok($"Student sa brojem inedksa {brInd} je uspesno obrisan.");
    }

    [HttpPut]
    [Route("IzmeniStudenta")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status403Forbidden)]
    public IActionResult IzmeniPredmet([FromBody] StudentiView student)
    {
        (bool isError, var result, var error) = DataProvider.AzurirajStudenta(student);

        if (isError)
        {
            return StatusCode(error?.StatusCode ?? 400, error?.Message);
        }

        return Ok($"Student sa brojem inedksa {student.BrIndeksa} je uspesno izmenjen.");
    }
}
