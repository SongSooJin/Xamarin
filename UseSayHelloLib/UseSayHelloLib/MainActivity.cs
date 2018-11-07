using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;
using Com.Example.Topc290.Helloaar;

namespace UseSayHelloLib
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        ISayHello hello;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);

            Button button1 = FindViewById<Button>(Resource.Id.button1);
            TextView textView1 = FindViewById<TextView>(Resource.Id.textView1);

            hello = new SayHelloImpl();
            button1.Click += (sender, args) => textView1.Text = hello.SayHello("송수진");

        }
    }
}