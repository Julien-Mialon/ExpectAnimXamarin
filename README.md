# ExpectAnimXamarin

[![nuget](https://img.shields.io/nuget/v/Florent37.XamarinExpectAnim.svg)](https://www.nuget.org/packages/Florent37.XamarinExpectAnim)

Describe your animation and run !

[![gif](https://raw.githubusercontent.com/florent37/ExpectAnim/master/media/sample.gif)](https://github.com/Julien-Mialon/ExpectAnimXamarin)

```csharp
new ExpectAnim()

                .Expect(avatar)
                .ToBe(
                    Expectations...
                )
                .ToAnimation()
                .Start();
```

#Download

This library is available on [nuget](https://www.nuget.org/packages/Florent37.XamarinExpectAnim) 

```
Install-Package Florent37.XamarinExpectAnim
```

This code describe the video above

```csharp
new ExpectAnim()
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
	.ToAnimation()
	.SetDuration(1500)
	.Start();
```

## Follow scroll

[![gif](https://raw.githubusercontent.com/florent37/ExpectAnim/master/media/scroll.gif)](https://github.com/Julien-Mialon/ExpectAnimXamarin)

Use `SetPercent` to apply modify the current step of the animation

Exemple with a scrollview

```csharp
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
					Height(_height).WithGravity(Java.Lang.Integer.ValueOf((int)GravityFlags.Left), Java.Lang.Integer.ValueOf((int)GravityFlags.Top))
				)
				.ToAnimation();

			_scrollView.ScrollChange += (sender, args) => {
				float percent = args.ScrollY * 1f / _scrollView.MaxScrollAmount;
				_expectAnimMove.SetPercent(percent);
			};
```

## Apply directly

Use `SetNow` to apply directly the transformation

```csharp
new ExpectAnim()
	.Expect(_view).ToBe(Invisible())
	.ToAnimation()
	.SetNow();
```

## Reset

Use `reset` to return to the initial state of views

```csharp
_expectAnimMove.Reset():
```

# List of expectations

```csharp
new ExpectAnim()
                .Expect(view)
                .ToBe(

                    //.WithMargin(marginPx)
                    //.WithMarginDp(margin)
                    //.WithMarginDimen(R.dimen.margin)

                    ToRightOf(view)
                    ToLeftOf(view)
                    BelowOf(view)
                    AboveOf(view)

                    AtItsOriginalPosition()


                    SameCenterAs(view, horizontal, vertical)
                    SameCenterHorizontalAs(view)
                    SameCenterVerticalAs(view)
                    CenterInParent(horizontal, vertical)
                    CenterVerticalInParent()
                    CenterHorizontalInParent()

                    CenterBetweenViews(view1, view2, horizontal, vertical)
                    CenterBetweenViewAndParent(otherView, horizontal, vertical, toBeOnRight, toBeOnBottom)

                    TopOfParent()
                    RightOfParent()
                    BottomOfParent()
                    LeftOfParent()

                    AlignBottom(otherView)
                    AlignTop(otherView)
                    AlignLeft(otherView)
                    AlignRight(otherView)

                    OutOfScreen(gravitiy)  //GravityFlags.Left / GravityFlags.Right / GravityFlags.Top / GravityFlags.Bottom

                	Alpha(alpha)
                    SameAlphaAs(otherView)
                    Visible()
                    Invisible()

                    //.KeepRatio()
                    //.WithGravity(horizontalGravity, verticalGravity)

                    AtItsOriginalScale()

                    Scale(scaleX, scaleY)
                    Height(height)
                    Width(width)
                    SameScaleAs(otherView)
                    SameWidthAs(otherView)
                    SameHeightAs(otherView)


                    ToHaveTextColor(textColor)
                    ToHaveBackgroundAlpha(alpha)

                    Rotated(rotation)
                    Vertical(bottomOfViewAtLeft)
                    AtItsOriginalRotation()
                )

````

# Changelog

##1.0.2

Added `flips` rotations

`FlippedHorizontally()`
`FlippedVertically()`
`FlippedHorizontallyAndVertically()`
`WithCameraDistance(1000f)`

##1.0.

Added `rotations`

[![gif](https://raw.githubusercontent.com/florent37/ExpectAnim/master/media/rotations.gif)](https://github.com/Julien-Mialon/ExpectAnimXamarin)

# Credits

Author (xamarin binding): Julien Mialon

[![Follow me on Twitter](https://raw.githubusercontent.com/Julien-Mialon/ExpectAnimXamarin/master/.assets/twitter.png)](https://twitter.com/Storm0x2A)
[![Follow me on Linkedin](https://raw.githubusercontent.com/Julien-Mialon/ExpectAnimXamarin/master/.assets/linkedin.png)](https://fr.linkedin.com/in/julienmialon)

Original author (android version): Florent Champigny

[![Follow me on Twitter](https://raw.githubusercontent.com/Julien-Mialon/ExpectAnimXamarin/master/.assets/twitter.png)](https://twitter.com/florent_champ)
[![Follow me on Linkedin](https://raw.githubusercontent.com/Julien-Mialon/ExpectAnimXamarin/master/.assets/linkedin.png)](https://fr.linkedin.com/in/florentchampigny)

#Original license

    Copyright 2017 florent37, Inc.

    Licensed under the Apache License, Version 2.0 (the "License");
    you may not use this file except in compliance with the License.
    You may obtain a copy of the License at

       http://www.apache.org/licenses/LICENSE-2.0

    Unless required by applicable law or agreed to in writing, software
    distributed under the License is distributed on an "AS IS" BASIS,
    WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
    See the License for the specific language governing permissions and
    limitations under the License.
