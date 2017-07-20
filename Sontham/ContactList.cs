using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace Sontham
{
  public  class ContactList
    {
        private List<PersonalContact> AllContacts = new List<PersonalContact>();



      


        public void AddNewContact(PersonalContact _Contacts)
        {
            AllContacts.Add(_Contacts);

        }


      public  List<PersonalContact> GetAllContacts(List<PersonalContact> AllContacts)
        {
           // List<PersonalContact> AddContact = new List<PersonalContact>();
            return AllContacts;

        }

        public List<PersonalContact> GetAllContacts1()
        {
           
            return AllContacts;

        }

      



    }
}