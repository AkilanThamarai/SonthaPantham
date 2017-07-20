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
    [Activity(Label = "Contacts")]
    public class Contacts : Activity
    {
        TextView textViewContacts1;
        TextView textViewContacts2;



     


        
        protected  override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.Contacts);

            textViewContacts1 = FindViewById<TextView>(Resource.Id.textViewContacts1);
            textViewContacts2 = FindViewById<TextView>(Resource.Id.textViewContacts2);

        


            ////foreach (string name in names)
            ////{
            ////    textViewContacts1.Text = name.ToString();
            ////    textViewContacts2.Text = name.ToString();

            ////}

            string c3 = Intent.GetStringExtra("ContactNames");

            string[] names = c3.Split(',');

            for (int i = 0; i < names.Length; i++)
            {
                textViewContacts1.Text = names[0];
                textViewContacts2.Text = names[1];
            }

          


        }


    }
}