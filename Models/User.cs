using System;
using System.Text.RegularExpressions;

namespace Stregsystem.Models
{
  public class User : IComparable
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

    public string Firstname { get; private set; }
    public string Lastname { get; private set; }
    public string Username { get; private set; }
    public string Email { get => _email; private 
		set { 
			Regex EmailPattern =  new Regex(@"[\a-z0-9\.\-_]+@[a-zA-Z0-9]+[\w\.-]+\.{1,}\w*[a-z0-9]$"); // https://docs.microsoft.com/en-us/dotnet/api/system.text.regularexpressions.regex.ismatch?view=net-5.0
			if (EmailPattern.IsMatch(value)) _email = value;
			else throw new FormatException("Email is not in correct format");
		}
	}
    public decimal Balance { get; private set; }

    public override string ToString() => $"{Firstname} {Lastname} ({Email})";

	// TODO Implement CompareTo Method
    public int CompareTo(object obj)
    {
      throw new NotImplementedException();
    }
  }
}