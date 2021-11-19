namespace stregsystem.Models
{
    public class BuyTransaction : Transaction
    {
        public BuyTransaction(int id, User user, decimal amount) : base(id, user, amount)
        {
        }
    }
}