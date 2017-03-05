using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Widget;

namespace ExpectAnimSample
{
	[Activity(Label = "MainActivity", MainLauncher = true)]
	public class MainActivity : AppCompatActivity
	{
		protected override void OnCreate(Bundle bundle)
		{
			base.OnCreate(bundle);
			
			SetContentView (Resource.Layout.activity_main);

			FindViewById<Button>(Resource.Id.sample).Click += (sender, args) => StartActivity(typeof(SampleActivity));
			FindViewById<Button>(Resource.Id.flip).Click += (sender, args) => StartActivity(typeof(FlipActivity));
			FindViewById<Button>(Resource.Id.rotation).Click += (sender, args) => StartActivity(typeof(RotationActivity));
			FindViewById<Button>(Resource.Id.scroll).Click += (sender, args) => StartActivity(typeof(ScrollActivity));
			FindViewById<Button>(Resource.Id.setnow).Click += (sender, args) => StartActivity(typeof(SetNowActivity));
		}
	}
}

