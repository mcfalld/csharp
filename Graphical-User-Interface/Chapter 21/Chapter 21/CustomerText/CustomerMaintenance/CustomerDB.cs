using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomerMaintenance
{
    /// <summary>
    /// CustomerDB class
    /// </summary>
    public static class CustomerDB
	{
        private const string dir = @"C:\Users\mcfal\Desktop\osu\OsuIT\Graphical User Interface\Chapter 21\";
        private const string path = dir + "Customers.txt";

        public static void SaveCustomers(List<Customer> customers)
		{
            StreamWriter outPut =
                new StreamWriter(
                new FileStream(path, FileMode.Create, FileAccess.Write));

            foreach (Customer customer in customers)
            {
                outPut.Write(customer.FirstName + "|");
                outPut.Write(customer.LastName + "|");
                outPut.WriteLine(customer.Email);
            }

            outPut.Close();
        }

        public static List<Customer> GetCustomers()
		{
            if (!Directory.Exists(dir))
                Directory.CreateDirectory(dir);

            StreamReader inPut =
                new StreamReader(
                    new FileStream(path, FileMode.OpenOrCreate, FileAccess.Read));

            List<Customer> customers = new List<Customer>();

            while (inPut.Peek() != -1)
            {
                string row = inPut.ReadLine();
                string[] columns = row.Split('|');
                Customer customer = new Customer();
                customer.FirstName = columns[0];
                customer.LastName = columns[1];
                customer.Email = columns[2];
                customers.Add(customer);
            }

            inPut.Close();

            return customers;
		}
	}
}
