using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Views;
using Florent37.XamarinExpectAnim;
using static Florent37.XamarinExpectAnim.Core.Expectations;

namespace ExpectAnimSample
{
	[Activity(Label = "FlipActivity")]
	public class FlipActivity : AppCompatActivity
	{
		private View _image1;
		private View _image2;
		private View _image3;
		private View _image4;

		private ExpectAnim _expectAnimMove;

		protected override void OnCreate(Bundle savedInstanceState)
		{
			base.OnCreate(savedInstanceState);

			SetContentView(Resource.Layout.activity_flip);

			_image1 = FindViewById(Resource.Id.image_1);
			_image2 = FindViewById(Resource.Id.image_2);
			_image3 = FindViewById(Resource.Id.image_3);
			_image4 = FindViewById(Resource.Id.image_4);

			_expectAnimMove = new ExpectAnim()
				.Expect(_image1)
				.ToBe(
					WithCameraDistance(500f),
					FlippedHorizontally()
				)
				.Expect(_image2)
				.ToBe(
					WithCameraDistance(1000f),
					FlippedVertically()
				)
				.Expect(_image3)
				.ToBe(
					WithCameraDistance(1500f),
					FlippedVertically()
				)
				.Expect(_image4)
				.ToBe(
					WithCameraDistance(2000f),
					FlippedHorizontallyAndVertically()
				)
				.ToAnimation()
				.SetDuration(1500);
			FindViewById(Resource.Id.content).Click += (sender, args) =>
			{
				_expectAnimMove.SetPercent(0);
				_expectAnimMove.Start();
			};
		}
	}
}