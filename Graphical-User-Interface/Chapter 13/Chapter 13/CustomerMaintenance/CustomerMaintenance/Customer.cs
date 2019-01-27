using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerMaintenance
{
    public class Customer
	{
		private string firstName;
		private string lastName;
		private string email;

		public Customer()
		{
		}

		public Customer(string firstName, string lastName, string email)
		{
			this.FirstName = firstName;
			this.LastName = lastName;
			this.Email = email;
		}

		public string FirstName
		{
			get
			{
				return firstName;
			}
			set
			{
                if (value.Length > 25)
                {
                    throw new ArgumentException("First name may contain a maximum of 30 characters");
                }
				firstName = value;
			}
		}

		public string LastName
		{
			get
			{
				return lastName;
			}
			set
			{
                if (value.Length <= 30)
                {
                    lastName = value;
                }
                else { throw new ArgumentException("The Maximum amount of charaters allowed is 30."); }
			}
		}

		public string Email
		{
			get
			{
				return email;
			}
			set
			{
                if(value.Length > 30)
                {
                    throw new ArgumentException("Email field may only contain 30 characters maximum");
                }
				email = value;
			}
		}

		public string GetDisplayText() => firstName + " " + lastName + ", " + email;
	}
}
