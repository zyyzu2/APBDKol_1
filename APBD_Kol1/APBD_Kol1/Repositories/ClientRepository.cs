using APBD_Kol1.Context;
using APBD_Kol1.DTOs;
using APBD_Kol1.Exceptions;
using APBD_Kol1.Model;
using Microsoft.EntityFrameworkCore;

namespace APBD_Kol1.Repositories;
public interface IClientRepository
{
    public Task<Client?> GetClientById(int id);
    public Task<ClientDetWithSubDTO> getClientById(int id);
}

public class ClientRepository : IClientRepository
{
    private readonly AppDbContext _context;

    public ClientRepository(AppDbContext context)
    {
        _context = context;
    }
    
    public async Task<Client?> GetClientById(int id)
    {
        var client = await _context.Clients.FirstOrDefaultAsync(s => s.IdClient == id);
        return client;
    }

    public async Task<ClientDetWithSubDTO> getClientById(int id)
    {
        var client = await _context.Clients.FirstOrDefaultAsync(s => s.IdClient == id);
        if (client is null) throw new NotFoundException("Client not found");
        var subs = await _context.Sales.Where(s => s.IdClient == client.IdClient).ToListAsync();
        double sumprice = 0;
        foreach (var sub in subs)
        {
            sumprice += sub.SubscriptionNavigation.Price;
        }

        var result = new ClientDetWithSubDTO()
        {
            FirstName = client.FirstName,
            LastName = client.LastName,
            Email = client.Email,
        };
        if (client.Phone is not null) result.Phone = client.Phone;
        return result;
    }
}