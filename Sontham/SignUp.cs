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
    [Activity(Label = "SignUp")]
    public class SignUp : Activity
    {

        Button buttonSGo;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.SignUp);

            buttonSGo = FindViewById<Button>(Resource.Id.buttonSGo);


            buttonSGo.Click += delegate
            {
                StartActivity(typeof(AddUrContact));
            };

            // Create your application here
        }



    }
}