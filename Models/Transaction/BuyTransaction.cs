namespace stregsystem.Models
{
    public class BuyTransaction : Transaction
    {
        public BuyTransaction(User user, Product product) : base(user, product.Price)
        {
            Execute();
        }

        public override void Execute()
        {
            _user.UpdateBalance(-_amount);
            base.Execute();
        }
    }
}