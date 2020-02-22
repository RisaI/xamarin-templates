using Android.App;
using Android.OS;
using Android.Widget;
using Android.Views;
using Android.Net;
using System.Threading;

namespace XamarinAndroid
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.activity_main);
        }
    }
}