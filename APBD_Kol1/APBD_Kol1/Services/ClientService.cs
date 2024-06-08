using APBD_Kol1.DTOs;
using APBD_Kol1.Exceptions;
using APBD_Kol1.Repositories;

namespace APBD_Kol1.Services;

public interface IClientService
{
    public Task<ClientDetWithSubDTO> getClientDetails(int id);
}

public class ClientService : IClientService
{
    private readonly IClientRepository _repository;
    private readonly ISubscriptionService _sub;

    public ClientService(IClientRepository repository, ISubscriptionService sub)
    {
        _repository = repository;
        _sub = sub;
    }
    
    
    public async Task<ClientDetWithSubDTO> getClientDetails(int id)
    {
        var client = await _repository.GetClientById(id);
        if (client is null) throw new NotFoundException("Provided client id doesn't exists");
        //var sub = await _sub.get
        var dto = new ClientDetWithSubDTO()
        {
            Email = client.Email,
            FirstName = client.FirstName,
            LastName = client.LastName
        };
        return dto;
    }
}