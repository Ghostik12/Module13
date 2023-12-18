using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module13
{
    class AddUnique
    {
        public void Add(Contact contact, List<Contact> phoneBook) 
        {
            var arl = false;
            foreach (Contact contact2 in phoneBook)
            {
                if (contact != contact2)
                    arl = true;
                    Console.WriteLine("Данный контакт уже есть в списке");
                break;
            }
            if (!arl) 
                phoneBook.Add(contact);


            phoneBook.Sort((x,y) => String.Compare(x.Name, y.Name, StringComparison.Ordinal));
        }
    }
}
