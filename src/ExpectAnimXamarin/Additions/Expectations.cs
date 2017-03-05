using Android.Views;
using Java.Lang;

namespace Florent37.XamarinExpectAnim.Core.Scale
{
	//Fixing parameter type GravityFlags to Integer
	public partial class ScaleAnimExpectation
	{
		
		public ScaleAnimExpectation(GravityFlags gravityHorizontal, GravityFlags gravityVertical) : this(Integer.ValueOf((int)gravityHorizontal), Integer.ValueOf((int)gravityVertical))
		{

		}

		public ScaleAnimExpectation WithGravity(GravityFlags gravityHorizontal, GravityFlags gravityVertical)
		{
			return WithGravity(Integer.ValueOf((int)gravityHorizontal), Integer.ValueOf((int)gravityVertical));
		}
	}

	public partial class ScaleAnimExpectationHeight
	{

		public ScaleAnimExpectationHeight(int height, GravityFlags gravityHorizontal, GravityFlags gravityVertical) : this(height, Integer.ValueOf((int)gravityHorizontal), Integer.ValueOf((int)gravityVertical))
		{

		}
	}

	public partial class ScaleAnimExpectationSameHeightAs
	{

		public ScaleAnimExpectationSameHeightAs(View view, GravityFlags gravityHorizontal, GravityFlags gravityVertical) : this(view, Integer.ValueOf((int)gravityHorizontal), Integer.ValueOf((int)gravityVertical))
		{

		}
	}

	public partial class ScaleAnimExpectationSameWidthAs
	{

		public ScaleAnimExpectationSameWidthAs(View view, GravityFlags gravityHorizontal, GravityFlags gravityVertical) : this(view, Integer.ValueOf((int)gravityHorizontal), Integer.ValueOf((int)gravityVertical))
		{

		}
	}

	public partial class ScaleAnimExpectationViewDependant
	{

		public ScaleAnimExpectationViewDependant(View view, GravityFlags gravityHorizontal, GravityFlags gravityVertical) : this(view, Integer.ValueOf((int)gravityHorizontal), Integer.ValueOf((int)gravityVertical))
		{

		}
	}

	public partial class ScaleAnimExpectationValues
	{

		public ScaleAnimExpectationValues(float scaleX, float scaleY, GravityFlags gravityHorizontal, GravityFlags gravityVertical) : this(scaleX, scaleY, Integer.ValueOf((int)gravityHorizontal), Integer.ValueOf((int)gravityVertical))
		{

		}
	}

	public partial class ScaleAnimExpectationWidth
	{

		public ScaleAnimExpectationWidth(int width, GravityFlags gravityHorizontal, GravityFlags gravityVertical) : this(width, Integer.ValueOf((int)gravityHorizontal), Integer.ValueOf((int)gravityVertical))
		{

		}
	}
}