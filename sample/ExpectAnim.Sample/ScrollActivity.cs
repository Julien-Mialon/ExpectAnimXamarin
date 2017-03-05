using Android.App;
using Android.OS;
using Android.Support.V4.Widget;
using Android.Support.V7.App;
using Android.Views;
using Florent37.XamarinExpectAnim;
using static Florent37.XamarinExpectAnim.Core.Expectations;

namespace ExpectAnimSample
{
	[Activity(Label = "ScrollActivity")]
	public class ScrollActivity : AppCompatActivity
	{
		private View _username;
		private View _avatar;
		private View _follow;
		private View _background;

		NestedScrollView _scrollView;

		private int _height;

		private ExpectAnim _expectAnimMove;

		protected override void OnCreate(Bundle savedInstanceState)
		{
			base.OnCreate(savedInstanceState);

			SetContentView(Resource.Layout.activity_scroll);

			_username = FindViewById(Resource.Id.username);
			_avatar = FindViewById(Resource.Id.avatar);
			_follow = FindViewById(Resource.Id.follow);
			_background = FindViewById(Resource.Id.background);
			_scrollView = FindViewById<NestedScrollView>(Resource.Id.scrollview);

			_height = (int)Resources.GetDimension(Resource.Dimension.height);

			_expectAnimMove = new ExpectAnim()
				.Expect(_avatar)
				.ToBe(
					TopOfParent().WithMarginDp(20),
					LeftOfParent().WithMarginDp(20),
					Scale(0.5f, 0.5f)
				)

				.Expect(_username)
				.ToBe(
					ToRightOf(_avatar).WithMarginDp(16),
					SameCenterVerticalAs(_avatar),

					Alpha(0.5f)
				)

				.Expect(_follow)
				.ToBe(
					RightOfParent().WithMarginDp(20),
					SameCenterVerticalAs(_avatar)
				)

				.Expect(_background)
				.ToBe(
					Height(_height).WithGravity(GravityFlags.Left, GravityFlags.Top)
				)
				.ToAnimation();

			_scrollView.ScrollChange += (sender, args) => {
				float percent = args.ScrollY * 1f / _scrollView.MaxScrollAmount;
				_expectAnimMove.SetPercent(percent);
			};
		}
	}
}