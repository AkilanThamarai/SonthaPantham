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
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            //Set our view from the "AddUrContact" layout resource
            SetContentView(Resource.Layout.AddUrContact);


            // Create your application here
        }
    }
}