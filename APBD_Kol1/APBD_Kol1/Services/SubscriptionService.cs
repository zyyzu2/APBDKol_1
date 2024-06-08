using APBD_Kol1.DTOs;

namespace APBD_Kol1.Services;

public interface ISubscriptionService
{
    public Task<SubscriptionDetDTO> getSubById(int id);
}


public class SubscriptionService : ISubscriptionService
{
    public Task<SubscriptionDetDTO> getSubById(int id)
    {
        throw new NotImplementedException();
    }
}