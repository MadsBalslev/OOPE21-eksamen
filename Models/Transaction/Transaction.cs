using System;

namespace stregsystem.Models
{
    public abstract class Transaction
    {
        public Transaction(int id, User user, decimal amount)
        {
            _id = id;
            _user = user;
            _amount = amount;
        }
        protected int _id;
        protected User _user;
        protected decimal _amount;
        protected DateTime _date = DateTime.Now;

        public override string ToString() => $"{this._id} {this._user.Username} {this._amount} {this._date.ToString()}";
    }
}