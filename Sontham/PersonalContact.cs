using System;



using SQLite;
using System.IO;
using Android.App;
using Android.Widget;
using Android.OS;
using System.Collections.Generic;

namespace Sontham
{
    [Activity(Label = "PersonalContact")]
    public class PersonalContact : Activity
    {

        public string ContactName { get; set; }
        public string FatherName { get; set; }
        public string MName { get; set; }
        public string Siblings1 { get; set; }
        public string Siblings2 { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string Pincode { get; set; }
        public string Kootam { get; set; }
        public string FamilyGod { get; set; }
        public string Job { get; set; }
        public string MobileNo1 { get; set; }
        public string MobileNo2 { get; set; }
        public string BirthPlace { get; set; }


        EditText editTextPCName;
        EditText editTextPCFName;
        EditText editTextPCMName;
        EditText editTextPCFSib1;
        EditText editTextPCFSib2;
        EditText editTextPCAddr1;
        EditText editTextPCAddr2;
        EditText editTextPCCity;
        EditText editTextPCPostal;
        EditText editTextPCKootam;
        EditText editTextPCFGod;
        EditText editTextPCJob;
        EditText editTextPCMN1;
        EditText editTextPCMN2;


        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            editTextPCName = FindViewById<EditText>(Resource.Id.editTextPCName);
            editTextPCFName = FindViewById<EditText>(Resource.Id.editTextPCFName);
            editTextPCMName = FindViewById<EditText>(Resource.Id.editTextPCMName);
            editTextPCFSib1 = FindViewById<EditText>(Resource.Id.editTextPCFSib1);
            editTextPCFSib2 = FindViewById<EditText>(Resource.Id.editTextPCFSib2);
            editTextPCAddr1 = FindViewById<EditText>(Resource.Id.editTextPCAddr1);
            editTextPCAddr2 = FindViewById<EditText>(Resource.Id.editTextPCAddr2);
            editTextPCCity = FindViewById<EditText>(Resource.Id.editTextPCCity);
            editTextPCPostal = FindViewById<EditText>(Resource.Id.editTextPCPostal);
            editTextPCKootam = FindViewById<EditText>(Resource.Id.editTextPCKootam);
            editTextPCFGod = FindViewById<EditText>(Resource.Id.editTextPCFGod);
            editTextPCJob = FindViewById<EditText>(Resource.Id.editTextPCJob);
            editTextPCMN1 = FindViewById<EditText>(Resource.Id.editTextPCMN1);
            editTextPCMN2 = FindViewById<EditText>(Resource.Id.editTextPCMN2);

            //List<string> All1 = new List<string>();
          DBRepository dbr = new DBRepository();

            //List<string> get = dbr.GetAllRecords();

            string result1 = Intent.GetStringExtra("id");

            string[] names = result1.Split(',');



            string dbPath = Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal), "SonthamDemo");
            var db = new SQLiteConnection(dbPath);
            var table = db.Table<ToDoTask>();


            foreach (var item in table)
            {
                for (int i = 0; i <= names.Length - 1; i++)
                {
                    if (i == item.Id)
                    {
                        editTextPCName.Text = item.TContactName;
                        editTextPCFName.Text = item.TFatherName;

                    }
                }
                   

            }


          
            


            //DBRepository dbr = new DBRepository();
            //string AllRecords = dbr.GetAllRecords();


            //Toast.MakeText(this, AllRecords, ToastLength.Short).Show();

            //// Create your application here

            //string[] Record = AllRecords.Split(',');


            //LinearLayout linearLayout = (LinearLayout)FindViewById(Resource.Id.linearlayout1);
            //for (int i = 0; i <= Record.Length - 1; i++)
            //{
            //    //string a = i.ToString();

            //    TextView textview = new TextView(this);

            //    textview.SetText(Record[i].ToString(), null);

            //   linearLayout.AddView(textview);

            //}

        }
    }
}