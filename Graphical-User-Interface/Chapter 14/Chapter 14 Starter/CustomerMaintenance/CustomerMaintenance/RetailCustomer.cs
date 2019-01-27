﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerMaintenance
{
    class RetailCustomer: Customer
    {
        private string homePhone;


        public RetailCustomer()
        {

        }

        public RetailCustomer(string firstName, string lastName, string email,
            string homePhone) : base(firstName, lastName, email)
        {
            this.homePhone = homePhone;
        }
        
        public string HomePhone
        {
            get
            {
                return this.homePhone;
            }
            set
            {
                this.homePhone = value;
            }
                
        }


        public override string GetDisplayText() => base.GetDisplayText() + "ph:" + " " + this.homePhone;
 


    }
}
