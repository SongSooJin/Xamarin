using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;
using Android.Content;
using Android.Views;

// Simple Intent Example (웹페이지 오픈하기)

namespace OpenWebpage
{
    [Activity(Label = "OpenWebpage", MainLauncher = true)]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);

            Button button = FindViewById<Button>(Resource.Id.mybutton);

            button.Click += (sender, e) =>
            {
                var uri = Android.Net.Uri.Parse("http://ojc.asia");
                var intent = new Intent(Intent.ActionView, uri);
                StartActivity(intent);
            };
        }
    }
}