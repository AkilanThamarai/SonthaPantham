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
        Button buttonLogin;
        
        //EditText editTextLMNBox;
        //EditText editTextLPWBox;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            // Get our button from the layout resource,
            // and attach an event to it
            //editTextLMNBox = FindViewById<EditText>(Resource.Id.editTextPWBox);
            buttonLogin = FindViewById<Button>(Resource.Id.buttonLogin);

            //buttonLogin.Click += ButtonLogin_Click;

            buttonLogin.Click += delegate
            {
                StartActivity(typeof(AddUrContact));
            };



        }


    }
       
}

