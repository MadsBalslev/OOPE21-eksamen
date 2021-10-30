using System;

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
    private string Firstname { get; set; }
    private string Lastname { get; set; }
    private string Username { get; set; }
    private string Email { get; set; }
    private decimal Balance { get; set; }

    public override string ToString() => $"{Firstname} {Lastname} ({Email}";

    public int CompareTo(object obj)
    {
      throw new NotImplementedException();
    }
  }
}