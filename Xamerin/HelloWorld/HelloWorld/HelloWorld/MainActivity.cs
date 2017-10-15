using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace HelloWorld
{
    [Activity(Label = "Phone Word", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {


        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            //My Code to follow
            Button translateButton = FindViewById<Button>(Resource.Id.TranslateButton);
            EditText editText = FindViewById<EditText>(Resource.Id.PhoneNumberText);
            Button callButton = FindViewById<Button>(Resource.Id.CallButton);
            string convertedNumber = string.Empty;
            translateButton.Click += (object sender, EventArgs e) =>
                {


                    //get the number
                    convertedNumber = Core.PhonewordTranslator.ToNumber(editText.Text);
                    if (string.IsNullOrEmpty(convertedNumber))
                    {
                        callButton.Text = "Call";
                        callButton.Enabled = false;
                    }
                    else
                    {
                        callButton.Text = string.Format("Call: {0}", convertedNumber);
                        callButton.Enabled = true;
                    };
                };

            callButton.Click += (object sender, EventArgs e) =>
                   {
                       var callDialog = new AlertDialog.Builder(this);
                       callDialog.SetMessage("Call " + convertedNumber + "?");
                       callDialog.SetNeutralButton("Call", delegate
                       {
                           // Create intent to dial phone
                           var callIntent = new Intent(Intent.ActionCall);
                           callIntent.SetData(Android.Net.Uri.Parse("tel:" + convertedNumber));
                           StartActivity(callIntent);
                       });
                       callDialog.SetNegativeButton("Cancel", delegate { });

                       // Show the alert dialog to the user and wait for response.
                       callDialog.Show();
                   };

            //Button callHistory = this.FindViewById<Button>(Resource.Id.CallHistoryActivity);
            //callHistory.Click += (object sender, EventArgs e) =>
            //{
            //    var intent = new Intent(this, typeof(CallHistoryActivity));
            //};

        }
    }
}

