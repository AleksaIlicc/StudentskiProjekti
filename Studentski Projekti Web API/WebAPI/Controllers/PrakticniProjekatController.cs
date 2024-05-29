using Library;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers;

[ApiController]
[Route("[controller]")]

public class PrakticniProjekatController : Controller 
{
    [HttpGet]
    [Route("PreuzmiPrakticneProjekteZaPredmet/{id}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status403Forbidden)]
    public async Task<IActionResult> PreuzmiPrakticneProjekteZaPredmet(string id)
    {
        (bool isError, var pprojekti, var error) = await DataProvider.VratiPrakticneProjekteZaPredmetAsync(id);

        if (isError)
        {
            return StatusCode(error?.StatusCode ?? 400, error?.Message);
        }

        return Ok(pprojekti);
    }
}
