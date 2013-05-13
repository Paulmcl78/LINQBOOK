using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter1.Common
{
    public class Contact
    {
        public int id;
        public string Name;

        public static void PublicContacts(Contact[] contacts)
        {
            foreach (Contact contact in contacts)
            {
                Console.WriteLine("Contact Id: {0} Contact: {1}",contact.id,contact.Name);
            }
        }
    }
}
