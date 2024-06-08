using APBD_Kol1.Exceptions;
using APBD_Kol1.Services;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace APBD_Kol1.Controllers;

[Route("/api/client")]
[ApiController]
public class ClientController
{
    private readonly IClientService _service;

    public ClientController(IClientService service)
    {
        _service = service;
    }
    
    
    [Route("/{id}")]
    [HttpGet]
    public async Task<IResult> getUserByID([FromRoute] int id)
    {
        try
        {
            var result = await _service.getClientDetails(id);
            return Results.Ok(result);
        }
        catch (NotFoundException e)
        {

            return Results.NotFound(e.Message);
        }
    }
}