using Android.App;
using Android.Content.PM;
using Android.OS;
using Xamarin.Forms;

namespace FosterCollector.Droid
{
    [Activity(Label = "FosterCollector", Icon = "@drawable/Fosters", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity // FormsApplicationActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            Forms.Init(this, bundle);
            LoadApplication(new App());
        }
    }
}

