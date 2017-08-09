using System;
using System.Collections.Generic;
using System.IO;
using SQLite;


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
           
            //string dbPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Personal), "ormdemo");
            //var db = new SQLiteConnection(dbPath);
            //ToDoTask item = new ToDoTask();
            //item.SaveContact = store;
            //db.Insert(item);
          
            
            return AllContacts;

        }


    }
}