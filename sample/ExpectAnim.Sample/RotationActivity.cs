using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Views;
using Florent37.XamarinExpectAnim;
using static Florent37.XamarinExpectAnim.Core.Expectations;

namespace ExpectAnimSample
{
	[Activity(Label = "RotationActivity")]
	public class RotationActivity : AppCompatActivity
	{
		private View _text1;
		private View _text2;
		private View _text3;
		private View _text4;

		private ExpectAnim _expectAnimMove;

		protected override void OnCreate(Bundle savedInstanceState)
		{
			base.OnCreate(savedInstanceState);

			SetContentView(Resource.Layout.activity_rotation);
			_text1 = FindViewById(Resource.Id.text1);
			_text2 = FindViewById(Resource.Id.text2);
			_text3 = FindViewById(Resource.Id.text3);
			_text4 = FindViewById(Resource.Id.text4);

			_expectAnimMove = new ExpectAnim()
				.Expect(_text1)
				.ToBe(
					TopOfParent(),
					LeftOfParent(),
					Rotated(90)
				)
				.Expect(_text2)
				.ToBe(
					AlignLeft(_text1),
					BelowOf(_text1)
				)
				.Expect(_text3)
				.ToBe(
					AlignTop(_text1),
					ToRightOf(_text1)
				)

				.Expect(_text4)
				.ToBe(
					BelowOf(_text3),
					AlignLeft(_text3)
				)

				.ToAnimation()
				.SetDuration(1500);

			FindViewById(Resource.Id.content).Click += (sender, args) =>
			{
				if (_text1.Rotation == 0)
				{
					_expectAnimMove.Start();
				}
				else
				{
					_expectAnimMove.Reset();
				}
			};
		}
	}
}