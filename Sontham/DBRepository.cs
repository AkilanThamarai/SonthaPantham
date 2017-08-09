using System;
using System.Collections.Generic;
using System.IO;
using SQLite;

namespace Sontham
{
    class DBRepository
    {

        public string CreateDB()
        {
            var output = "";
            output += "creating DB if it doesn't exist";
            string dbPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Personal), "SonthamDemo");
            var db = new SQLiteConnection(dbPath);
            output += "\n db created";
            return output;

        }


        public string CreateTable()
        {
            try
            {
                string dbPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Personal), "SonthamDemo");
                var db = new SQLiteConnection(dbPath);
                db.CreateTable<ToDoTask>();
                string result = "table created successfully";
                return result;
            }

            catch (Exception ex)
            {
                return "Error: " + ex.Message;
            }
        }


        //Insert a Record
        public string InsertRecord(string CName, string FName, string MName, string Sib1, string Sib2, string Address1,
            string Address2, string City, string Pincode, string Kootam, string FamilyGod, string Job, string MobileNo1, string MobileNo2)
        {
            //  ToDoTask item = new ToDoTask();

            try
            {
                string dbPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Personal), "SonthamDemo");
                var db = new SQLiteConnection(dbPath);
                ToDoTask contact = new ToDoTask();
                contact.TContactName = CName;
                contact.TFatherName = FName;
                contact.TMName = MName;
                contact.TSiblings1 = Sib1;
                contact.TSiblings2 = Sib2;
                contact.TAddress1 = Address1;
                contact.TAddress2 = Address2;
                contact.TCity = City;
                contact.TPincode = Pincode;
                contact.TKootam = Kootam;
                contact.TFamilyGod = FamilyGod;
                contact.TJob = Job;
                contact.TMobileNo1 = MobileNo1;
                contact.TMobileNo1 = MobileNo2;

                db.Insert(contact);
                return "Record Added";
            }


            catch (Exception ex)
            {
                return "Error: " + ex.Message;
            }


        }



        //To Retrive

        public TableQuery<ToDoTask> GetAllContactsName( )
        {
            string dbPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Personal), "SonthamDemo");
            var db = new SQLiteConnection(dbPath);
            string output = "";
            //output += "All Contacts";
            //var item1 = db.Get<ToDoTask>(TContactName);
            
            var table = db.Table<ToDoTask>();

            // var Namequery = SQLiteConnection.Query<ToDoTask>("select  TContactName from ToDoTask");

            return table;
            //foreach (var item in table)
            //{
            //    //ToDoTask fname = new ToDoTask();
            //    output += item.Id + "..." + item.TContactName  + "\n";


            //    //+item.TFatherName + item.TMName + item.TSiblings1 + item.TSiblings2 + item.TAddress1
            //      //  + item.TAddress2 + item.TCity + item.TPincode + item.TKootam + item.TFamilyGod + item.TJob + item.TMobileNo1 + item.TMobileNo2 +

            //}



            //return output;

        }

        List<string> All = new List<string>();

        //public List<string> GetAllRecords()
        //{
        //    string dbPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Personal), "SonthamDemo");
        //    var db = new SQLiteConnection(dbPath);


        //    string output = "";
        //    //output += "All Contacts";
        //    var table = db.Table<ToDoTask>();

        //    foreach (var item in table)
        //    {
        //        //output += "\n" + item.TContactName + "," + item.TFatherName + "," + item.TMName + "," + item.TSiblings1 + ","
        //        //+ item.TSiblings2 + "," + item.TAddress1 + "," + item.TAddress2 + "," + item.TCity + "," + item.TPincode + ","
        //        //+ item.TKootam + "," + item.TFamilyGod + "," + item.TJob + "," + item.TMobileNo1 + "," + item.TMobileNo2 + "," + item.TBirthPlace;

        //        All.Add(item.TContactName + item.TFatherName + item.TMName);

        //    }
        //    return All;
           
        //}



        //to Retrive by id


        public string GetTaskById()
        {
            string output = "";
            string dbPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Personal), "ormdemo");
            var db = new SQLiteConnection(dbPath);
            var table = db.Table<ToDoTask>();
            foreach (var item in table)
            {
                 output += item.Id.ToString();
            }
            return output;

        }
        //public string RemoveTask( string TContactName)
        //{
        //    string dbPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Personal), "ormdemo");
        //    var db = new SQLiteConnection(dbPath);
        //   // var item = db.Get<ToDoTask>(id);

        //    var item1 = db.Get<ToDoTask>(TContactName);
        //  //  db.Delete(item);
        //    db.Delete(item1);

        //    return "record deleted";

        //}


    }
}