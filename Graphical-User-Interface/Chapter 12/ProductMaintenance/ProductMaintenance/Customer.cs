using System;


namespace ProductMaintenance
{
    public class Customer
    {

        private string firstName;
        private string lastName;
        private string email;

        public Customer()
        {

        }
        
        public Customer(string first, string last, string email)
        {
        	this.firstName = first;
        	this.lastName = last;
        	this.email = email;
        }
        
        
        
        public string FirstName
        {
        	get
        	{
        		return firstName;
        	}
        	set
        	{
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
        		lastName = value;
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
        		email = value;
        	}
        }
        
        
        public string GetDisplayText()
        {
            return firstName + " " + lastName + ", " + email;
        }
        
    }
}