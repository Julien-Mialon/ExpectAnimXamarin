using Android.App;
using Android.Graphics;
using Android.OS;
using Android.Support.V7.App;
using Android.Views;
using Florent37.XamarinExpectAnim;
using static Florent37.XamarinExpectAnim.Core.Expectations;

namespace ExpectAnimSample
{
	[Activity(Label = "SampleActivity")]
	public class SampleActivity : AppCompatActivity
	{
		private View _name;
		private View _avatar;
		private View _subname;
		private View _follow;
		private View _message;
		private View _bottomLayout;
		private View _content;

		private ExpectAnim _expectAnimMove;

		protected override void OnCreate(Bundle savedInstanceState)
		{
			base.OnCreate(savedInstanceState);

			SetContentView(Resource.Layout.activity_sample);

			_name = FindViewById(Resource.Id.name);
			_avatar = FindViewById(Resource.Id.avatar);
			_subname = FindViewById(Resource.Id.subname);
			_follow = FindViewById(Resource.Id.follow);
			_message = FindViewById(Resource.Id.message);
			_bottomLayout = FindViewById(Resource.Id.bottomLayout);
			_content = FindViewById(Resource.Id.content);

			new ExpectAnim()
				.Expect(_bottomLayout)
				.ToBe(OutOfScreen((int)GravityFlags.Bottom))
				.Expect(_content)
				.ToBe(OutOfScreen((int)GravityFlags.Bottom), Invisible())
				.ToAnimation().SetNow();

			_expectAnimMove = new ExpectAnim()
				.Expect(_avatar)
				.ToBe(
					BottomOfParent().WithMarginDp(36),
					LeftOfParent().WithMarginDp(16),
					Width(40).ToDp().KeepRatio())
				.Expect(_name)
				.ToBe(
					ToRightOf(_avatar).WithMarginDp(16),
					SameCenterVerticalAs(_avatar),
					ToHaveTextColor(Color.White)
				)

				.Expect(_subname)
				.ToBe(
					ToRightOf(_name).WithMarginDp(5),
					SameCenterVerticalAs(_name),
					ToHaveTextColor(Color.White)
				)

				.Expect(_follow)
				.ToBe(
					RightOfParent().WithMarginDp(4),
					BottomOfParent().WithMarginDp(12),
					ToHaveBackgroundAlpha(0f)
				)

				.Expect(_message)
				.ToBe(
					AboveOf(_follow).WithMarginDp(4),
					RightOfParent().WithMarginDp(4),
					ToHaveBackgroundAlpha(0f)
				)

				.Expect(_bottomLayout)
				.ToBe(
					AtItsOriginalPosition()
				)

				.Expect(_content)
				.ToBe(
					AtItsOriginalPosition(),
					Visible()
				)
				.ToAnimation().SetDuration(1500);

			_message.Click += (sender, args) => _expectAnimMove.Start();

			_follow.Click += (sender, args) => _expectAnimMove.Reset();
		}
	}
}