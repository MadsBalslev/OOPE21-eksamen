namespace stregsystem.Models
{
    public class InsertCashTransaction : Transaction
    {
        public InsertCashTransaction(int id, User user, decimal amount) : base(id, user, amount)
        {
        }
    }
}