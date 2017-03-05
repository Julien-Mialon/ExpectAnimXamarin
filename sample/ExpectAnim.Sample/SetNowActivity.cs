using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Views;
using Florent37.XamarinExpectAnim;
using static Florent37.XamarinExpectAnim.Core.Expectations;

namespace ExpectAnimSample
{
	[Activity(Label = "SetNowActivity")]
	public class SetNowActivity : AppCompatActivity
	{
		private View _view;
		private ExpectAnim _expectAnimMove;

		protected override void OnCreate(Bundle savedInstanceState)
		{
			base.OnCreate(savedInstanceState);

			SetContentView(Resource.Layout.activity_set_now);

			_view = FindViewById(Resource.Id.follow);

			_expectAnimMove = new ExpectAnim()
				.Expect(_view).ToBe(Invisible())
				.ToAnimation();
			_expectAnimMove.SetNow();
		}
	}
}