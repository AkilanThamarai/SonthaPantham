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

            PersonalContact personalContact = new PersonalContact();


            personalContact.ContactName = editTextCNameBox.Text;
            personalContact.FatherName = editTextCFNameBox.Text.ToString();
            personalContact.MName = editTextCMNameBox.Text.ToString();
            personalContact.Siblings1 = editTextCS1NameBox.Text.ToString();
            personalContact.Siblings2 = editTextCS2NameBox.Text.ToString();
            personalContact.Address1 = editTextCAddressBox1.Text.ToString();
            personalContact.Address1 = editTextCAddressBox1.Text.ToString();
            personalContact.Address2 = editTextCAddressBox2.Text.ToString();
            personalContact.City = editTextCCityBox.Text.ToString();
            personalContact.Pincode = editTextCPINBox.Text.ToString();
            personalContact.Kootam = editTextKNameBox.Text.ToString();
            personalContact.Job = editTextCJobBox.Text.ToString();
            personalContact.MobileNo1 = editTextCMN1Box.Text.ToString();
            personalContact.MobileNo2 = editTextCMN2Box.Text.ToString();



            ContactList contactList = new ContactList();

            contactList.AddNewContact(new PersonalContact
            {
                ContactName = "Akilan",
                FatherName = "thamarai",
                City = "Srivi",

                BirthPlace = "PerumalDevan",
                Kootam = "Mookkaiyan"
            });

            contactList.AddNewContact(new PersonalContact
            {
                ContactName = "Karthi",
                FatherName = "thamarai",
                City = "Srivi",

                BirthPlace = "PerumalDevan",
                Kootam = "Mookkaiyan"
            });

            List<PersonalContact> newStoredContacts = new List<PersonalContact>();

            newStoredContacts = contactList.GetAllContacts1();

            //  contactList.AddNewContact( personalContact);



            buttonSC = FindViewById<Button>(Resource.Id.buttonSC);

            string c1 = newStoredContacts[0].ContactName.ToString();
            string c2 = newStoredContacts[1].ContactName.ToString();
            string c3 = c1 + "," + c2;

            buttonSC.Click += delegate
            {




                for (int i = 0; i < newStoredContacts.Count-1 ; i++)
                {
                    Intent intent = new Intent(this, typeof(Contacts));
                    

                    //  intent.PutExtra("ContactNames", newStoredContacts[i].ContactName.ToString());
                    intent.PutExtra("ContactNames", c3);
                    this.StartActivity(intent);
                }


                //Intent intent = new Intent(this, typeof(Contacts));
                ////i.PutExtra("ContactNames", personalContact);

                //intent.PutExtra("ContactNames", c3);
                //this.StartActivity(intent);

            };

            // Create your application here
        }
    }
}