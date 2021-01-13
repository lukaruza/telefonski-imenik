using DataAccessLayer;
using DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class ContactBusiness
    {
        private ContactRepository contactRepository;

        public ContactBusiness()
        {
            this.contactRepository = new ContactRepository();

        }

        public List<Contact> GetAllContacts()
        {
            return this.contactRepository.GetAllContacts();
        }
        public bool InsertContact(Contact s)
        {
            if(this.contactRepository.InsertContact(s) > 0)
            {
                return true;
            }
            return false;   
        }
        public bool DeleteContact(string e)
        {
            if(this.contactRepository.DeleteContact(e)>0)
            {
                return true;
            }
            return false;
        }
    }
}
