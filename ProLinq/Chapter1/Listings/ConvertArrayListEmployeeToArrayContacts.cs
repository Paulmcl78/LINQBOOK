﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Chapter1.Common;
using Common;

namespace Chapter1.Listings
{
    public class ConvertArrayListEmployeeToArrayContacts : IListing
    {
        public void Print()
        {
            ArrayList alEmployees = Employee.GetEmployees();

            Contact[] contacts = alEmployees
                .Cast<Employee>()
                .Select(e => new Contact
                    {
                        id = e.id,
                        Name = string.Format("{0} {1}", e.firstName, e.lastName)
                    })
                .ToArray<Contact>();

            Contact.PublicContacts(contacts);
        }
    }
}
