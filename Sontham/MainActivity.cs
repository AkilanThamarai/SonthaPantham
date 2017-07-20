﻿using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;


namespace Sontham
{
    [Activity(Label = "SonthaPantham", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        Button buttonLogin;
        Button buttonSignUp;

        TextView textViewForgot;

        //EditText editTextLPWBox;






        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);




            // Get our button from the layout resource,
            // and attach an event to it

            buttonLogin = FindViewById<Button>(Resource.Id.buttonLogin);
            buttonSignUp = FindViewById<Button>(Resource.Id.buttonSignUp);
            textViewForgot = FindViewById<TextView>(Resource.Id.textViewForgot);





            buttonSignUp.Click += delegate
            {
                StartActivity(typeof(SignUp));
            };

            buttonLogin.Click += delegate
            {
                StartActivity(typeof(AddUrContact));
            };

            textViewForgot.Click += delegate
            {
                StartActivity(typeof(SignUp));
            };

            ContactList contactList = new ContactList();

            //contactList.AddNewContact(new PersonalContact
            //{
            //    ContactName = "Akilan",
            //    FatherName = "thamarai",
            //    City = "Srivi",

            //    BirthPlace = "PerumalDevan",
            //    Kootam = "Mookkaiyan"
            //});

            //contactList.AddNewContact(new PersonalContact
            //{
            //    ContactName = "Kar",
            //    FatherName = "c",
            //    City = "thoo",

            //    BirthPlace = "thoo",
            //    Kootam = "Mookkaiyan"
            //});



        

           

            // cp.GetBirthPlace(city);
           

         






        }


    }

}

