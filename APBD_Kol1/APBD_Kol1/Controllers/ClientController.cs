using APBD_Kol1.Exceptions;
using APBD_Kol1.Services;
using Microsoft.AspNetCore.Mvc;


namespace APBD_Kol1.Controllers;

[Route("/api/client")]
public class ClientController : ControllerBase
{
    private readonly IClientService _service;

    public ClientController(IClientService service)
    {
        _service = service;
    }
    
    
    [Route("/{id}")]
    [HttpGet]
    public async Task<IActionResult> getUserByID([FromRoute] int id)
    {
        try
        {
            var result = await _service.getClientDetails(id);
            return Ok(result);
        }
        catch (NotFoundException e)
        {

            return NotFound(e.Message);
        }
    }
}