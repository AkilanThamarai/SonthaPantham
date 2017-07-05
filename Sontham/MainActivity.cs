using System;
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
        //Button buttonLogin;
        Button buttonLogin;
        EditText editTextPWBox;
        EditText editTextUNBox;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            // Get our button from the layout resource,
            // and attach an event to it
            buttonLogin = FindViewById<Button>(Resource.Id.buttonLogin);
            editTextUNBox = FindViewById<EditText>(Resource.Id.editTextUNBox);
            editTextPWBox = FindViewById<EditText>(Resource.Id.editTextPWBox);

            // buttonLogin.Click += ButtonLogin_Click;

            buttonLogin.Click += delegate
            {
                StartActivity(typeof(AddUrContact));
            };

        }

        //private void ButtonLogin_Click(object sender, EventArgs e)
        //{

        //    Intent MyIntent = new Intent(AddUrContact.cs);
        //    StartActivity(MyIntent);
        //}
    }
}

