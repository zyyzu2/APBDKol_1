namespace APBD_Kol1.Model;

public class Client
{
    public int IdClient { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public string? Phone { get; set; }

    public virtual ICollection<Sale> SalesNavigation { get; set; }
    public virtual ICollection<Payment> PaymentsNavigation { get; set; }
}