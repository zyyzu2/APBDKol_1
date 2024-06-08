namespace APBD_Kol1.Model;

public class Payment
{
    public int IdPayment { get; set; }
    public DateTime Date { get; set; }
    public int IdClient { get; set; }
    public int IdSubscription { get; set; }
    
    public virtual Client ClientNavigation { get; set; }
    public virtual Subscription SubscriptionNavigation { get; set; }
}