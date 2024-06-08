namespace APBD_Kol1.DTOs;

public class ClientDetWithSubDTO
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public string? Phone { get; set; }
    public ICollection<SubscriptionDetDTO> subs { get; set; }
}