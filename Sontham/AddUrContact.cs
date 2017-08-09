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
    [Activity(Label = "AddYourContact")]
    public class AddUrContact : Activity
    {
        Button buttonSC;
        EditText editTextCNameBox;
        EditText editTextCFNameBox;
        EditText editTextCMNameBox;
        EditText editTextCS1NameBox;
        EditText editTextCS2NameBox;
        EditText editTextCAddressBox1;
        EditText editTextCAddressBox2;
        EditText editTextCCityBox;
        EditText editTextCPINBox;
        EditText editTextKNameBox;
        EditText editTextCFGodBox;
        EditText editTextCJobBox;
        EditText editTextCMN1Box;
        EditText editTextCMN2Box;
        Spinner spinnerBP;




        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            //Set our view from the "AddUrContact" layout resource
            SetContentView(Resource.Layout.AddUrContact);

            editTextCNameBox = FindViewById<EditText>(Resource.Id.editTextCNameBox);
            editTextCFNameBox = FindViewById<EditText>(Resource.Id.editTextCFNameBox);

            editTextCMNameBox = FindViewById<EditText>(Resource.Id.editTextCMNameBox);
            editTextCS1NameBox = FindViewById<EditText>(Resource.Id.editTextCS1NameBox);
            editTextCS2NameBox = FindViewById<EditText>(Resource.Id.editTextCS2NameBox);
            editTextCAddressBox1 = FindViewById<EditText>(Resource.Id.editTextCAddressBox1);
            editTextCAddressBox2 = FindViewById<EditText>(Resource.Id.editTextCAddressBox2);
            editTextCCityBox = FindViewById<EditText>(Resource.Id.editTextCCityBox);
            editTextCPINBox = FindViewById<EditText>(Resource.Id.editTextCPINBox);
            editTextKNameBox = FindViewById<EditText>(Resource.Id.editTextKNameBox);
            editTextCFGodBox = FindViewById<EditText>(Resource.Id.editTextCFGodBox);
            editTextCJobBox = FindViewById<EditText>(Resource.Id.editTextCJobBox);
            editTextCMN1Box = FindViewById<EditText>(Resource.Id.editTextCMN1Box);
            editTextCMN2Box = FindViewById<EditText>(Resource.Id.editTextCMN2Box);
            spinnerBP = FindViewById<Spinner>(Resource.Id.spinnerBP);



            ContactList contactList = new ContactList();

            //contactList.AddNewContact(new PersonalContact
            //{
            //    // ContactName = "akil",

            //});

            //contactList.AddNewContact(new PersonalContact
            //{
            //    ContactName = "Karthi",
            //    FatherName = "thamarai",
            //    City = "Srivi",

            //    BirthPlace = "PerumalDevan",
            //    Kootam = "Mookkaiyan"
            //});

            List<PersonalContact> newStoredContacts = new List<PersonalContact>();

            newStoredContacts = contactList.GetAllContacts1();

         

            buttonSC = FindViewById<Button>(Resource.Id.buttonSC);


            buttonSC.Click += delegate
            {


                //PersonalContact personalContact = new PersonalContact();


                //personalContact.ContactName = editTextCNameBox.Text.ToString();
                //personalContact.FatherName = editTextCFNameBox.Text.ToString();
                //personalContact.MName = editTextCMNameBox.Text.ToString();
                //personalContact.Siblings1 = editTextCS1NameBox.Text.ToString();
                //personalContact.Siblings2 = editTextCS2NameBox.Text.ToString();
                //personalContact.Address1 = editTextCAddressBox1.Text.ToString();
                //personalContact.Address2 = editTextCAddressBox2.Text.ToString();
                //personalContact.City = editTextCCityBox.Text.ToString();
                //personalContact.Pincode = editTextCPINBox.Text.ToString();
                //personalContact.Kootam = editTextKNameBox.Text.ToString();
                //personalContact.FamilyGod = editTextCFGodBox.Text.ToString();
                //personalContact.Job = editTextCJobBox.Text.ToString();
                //personalContact.MobileNo1 = editTextCMN1Box.Text.ToString();
                //personalContact.MobileNo2 = editTextCMN2Box.Text.ToString();
                //personalContact.BirthPlace = spinnerBP.ToString();
                //contactList.AddNewContact(personalContact);



               DBRepository dbr = new DBRepository();

             string InsertAll=   dbr.InsertRecord(editTextCNameBox.Text, editTextCFNameBox.Text, editTextCMNameBox.Text, editTextCS1NameBox.Text,
                   editTextCS2NameBox.Text, editTextCAddressBox1.Text, editTextCAddressBox2.Text, editTextCCityBox.Text,
                   editTextCPINBox.Text, editTextKNameBox.Text, editTextCFGodBox.Text, editTextCJobBox.Text,
                   editTextCMN1Box.Text, editTextCMN2Box.Text);


                StartActivity(typeof(Contacts));

                //string CName = dbr.InsertRecord(editTextCNameBox.Text);
                //string FName = dbr.InsertRecord(editTextCFNameBox.Text);
                //string MName = dbr.InsertRecord(editTextCMNameBox.Text);
                //string Sib1 = dbr.InsertRecord(editTextCS1NameBox.Text);
                //string Sib2 = dbr.InsertRecord(editTextCS2NameBox.Text);
                //string Address1 = dbr.InsertRecord(editTextCAddressBox1.Text);
                //string Address2 = dbr.InsertRecord(editTextCAddressBox2.Text);
                //string City = dbr.InsertRecord(editTextCCityBox.Text);
                //string Pincode = dbr.InsertRecord(editTextCPINBox.Text);
                //string Kootam = dbr.InsertRecord(editTextKNameBox.Text);
                //string FamilyGod = dbr.InsertRecord(editTextCFGodBox.Text);
                //string Job = dbr.InsertRecord(editTextCJobBox.Text);
                //string MobileNo1 = dbr.InsertRecord(editTextCMN1Box.Text);
                //string MobileNo2 = dbr.InsertRecord(editTextCMN2Box.Text);

                // string BirthPlace = dbr.InsertRecord(spinnerBP.Selected);

                //Toast.MakeText(this, CName, ToastLength.Short).Show();

                // string result1 = dbr.GetAllContactsName();
                //   Toast.MakeText(this, result1, ToastLength.Short).Show();


                //  string name = "";
                //for (int i = 0; i <= newStoredContacts.Count - 1; i++)
                //{
                //    name = name + "," + newStoredContacts[i].ContactName.ToString();
                //}

                //for (int i = 0; i <= result1.Length; i++)
                //{
                //    name = name + "," + result1.ToString();
                //}


                // name = name.Substring(1);
                //Intent intent = new Intent(this, typeof(Contacts));
                //intent.PutExtra("ContactNames", result1);
                //// intent.PutExtra("ContactNames", c3);
                //this.StartActivity(intent);

                //DBRepository dbr = new DBRepository();
                //string result = dbr.InsertRecord(personalContact.ContactName.ToString());


                // DBRepository dbr = new DBRepository();
                // var deltable = dbr.Query<Stack>("SELECT * FROM ToDoTask);
                //  EditText txtTaskId = FindViewById<EditText>(Resource.Id.txtTaskId);
                //string result2 = dbr.RemoveTask(editTextCNameBox.Text);
                //Toast.MakeText(this, result2, ToastLength.Short).Show();



            };

            //buttonSC = FindViewById<Button>(Resource.Id.buttonSC);

            // Create your application here
        }
    }
}