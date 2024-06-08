namespace APBD_Kol1.Model;

public class Sale
{
    public int IdSale { get; set; }
    public int IdClient { get; set; }
    public int IdSubscription { get; set; }
    public DateTime CreatedAt { get; set; }
    
    public virtual Subscription SubscriptionNavigation { get; set; }
    public virtual Client ClientNavigation { get; set; }
}