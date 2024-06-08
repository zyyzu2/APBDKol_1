using System.Collections;
using System.Data.SqlTypes;

namespace APBD_Kol1.Model;

public class Subscription
{
    public int IdSubscription { get; set; }
    public string Name { get; set; }
    public int RenewalPeriod { get; set; }
    public DateTime EndTime { get; set; }
    public SqlMoney Price { get; set; }
    
    public virtual ICollection<Payment> PaymentsNavigation { get; set; }
    public virtual ICollection<Sale> SalesNavigation { get; set; }
    public virtual ICollection<Discount> DiscountsNavigation { get; set; }
}