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
  public  class PersonalContact
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

        public static explicit operator Parcelable(PersonalContact v)
        {
            throw new NotImplementedException();
        }
    }
}