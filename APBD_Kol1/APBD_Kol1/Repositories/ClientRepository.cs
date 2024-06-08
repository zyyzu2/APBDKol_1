using APBD_Kol1.Context;
using APBD_Kol1.Model;
using Microsoft.EntityFrameworkCore;

namespace APBD_Kol1.Repositories;
public interface IClientRepository
{
    public Task<Client?> GetClientById(int id);
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
}