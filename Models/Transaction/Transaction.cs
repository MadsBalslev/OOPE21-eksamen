using System;

namespace stregsystem.Models
{
    public abstract class Transaction
    {
        public Transaction(User user, decimal amount)
        {
            _user = user;
            _amount = amount;
        }
        protected int _id = 1;
        protected User _user;
        protected decimal _amount;
        protected DateTime _date;

        public virtual void Execute()
        {
            _date = DateTime.Now;
        }
        public override string ToString() => $"{this._id} {this._user.Username} {this._amount} {this._date.ToString()}";
    }
}