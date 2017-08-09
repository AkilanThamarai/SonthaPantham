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
using SQLite;

namespace Sontham
{
    [Activity(Label = "Contacts")]
    public class Contacts : Activity
    {
        //TextView textViewContacts1;
        //TextView textViewContacts2;



     


        
        protected  override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.Contacts);

            //textViewContacts1 = FindViewById<TextView>(Resource.Id.textViewContacts1);
            //textViewContacts2 = FindViewById<TextView>(Resource.Id.textViewContacts2);


            DBRepository dbr = new DBRepository();
            TableQuery<ToDoTask> result1 = dbr.GetAllContactsName();

            ////foreach (string name in names)
            ////{
            ////    textViewContacts1.Text = name.ToString();   
            ////    textViewContacts2.Text = name.ToString();

            ////}

           // string result1 = Intent.GetStringExtra("ContactNames");

            //string[] names = result1.Split(',');

            
            LinearLayout linearLayout = (LinearLayout)FindViewById(Resource.Id.linearlayout);

            foreach(var res in result1)

           // for (int i = 0; i <= result1; i++)
            {
               //string a = i.ToString();

                TextView textview = new TextView(this);

                //  textview.SetText(names[i].ToString(), null);
                textview.Id = res.Id;
                //textview.SetText (res.Id);
                textview.SetText(res.TContactName, null);
                
               
                linearLayout.AddView(textview);


                

                
                textview.Click += Textview_Click;
                
            }

            //List<TextView> textview = new List<TextView>();

            //textview.SetText(names[i].ToString(), null);

            //linearLayout.AddView(textview);

            //string res = dbr.GetTaskById();

            //for (int n = 0; n < textview.)

            //    textview.Click += Textview_Click;


            //for (int i = 0; i < names.Length; i++)
            //{
            //    textViewContacts1.Text = names[0];
            //    textViewContacts2.Text = names[1];
            //}


            //textViewContacts1.Text = names[0].ToString();
            //textViewContacts2.Text = names[1].ToString();



        }

        private void Textview_Click(object sender, EventArgs e)
        {

            string s1 = sender.Text;

            DBRepository dbr = new DBRepository();
            string res = dbr.GetTaskById();



            Intent intent = new Intent(this, typeof(PersonalContact));
            intent.PutExtra("id", res);
            // intent.PutExtra("ContactNames", c3);
            this.StartActivity(intent);


        }
    }
}