using System;
using System.Text.RegularExpressions;
using stregsystem.Shared;

namespace stregsystem.Models
{
    public class User : IComparable<User>
    {
        public User(int id, string fName, string lName, string uName, string email, decimal balance)
        {
            this._id = id;
            this.Firstname = fName;
            this.Lastname = lName;
            this.Username = uName;
            this.Email = email;
            this.Balance = balance;
        }
        private int _id;
        private string _email;
        private Name _firstname;
        private Name _lastname;

        public string Firstname
        {
            get => _firstname.String;
            private set => _firstname = new Name(value);
        }
        public string Lastname
        {
            get => _lastname.String;
            private set => _lastname = new Name(value);
        }
        public string Username { get; private set; }
        public string Email
        {
            get => _email;
            private set
            {
                // https://docs.microsoft.com/en-us/dotnet/api/system.text.regularexpressions.regex.ismatch?view=net-5.0
                Regex EmailPattern = new Regex(@"[\a-z0-9\.\-_]+@[a-zA-Z0-9]+[\w\.-]+\.{1,}\w*[a-z0-9]$");
                if (EmailPattern.IsMatch(value)) _email = value;
                else throw new FormatException("Email is not in correct format");
            }
        }
        public decimal Balance { get; private set; }

        public void UpdateBalance(decimal amount)
        {
            Balance = Balance + amount;
        }

        public override string ToString() => $"{Firstname} {Lastname} ({Email})";

        public int CompareTo(User u)
        {
            if (this._id > u._id) return -1;
            if (this._id < u._id) return 1;
            return 0;
        }

        public override int GetHashCode()
        {
            return _id;
        }
        
    }
}