using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/* CURRENTLY KNOWN ISSUES:
 *	- Flickering transitions when changing opacity. Colors seem fine so far
 */
namespace Animations
{
	public class ColorAnimator : Animator
	{
		#region Constructors
		public ColorAnimator(int currentValue, int targetValue, int interval = DEFAULT_INTERVAL, int multiplier = DEFAULT_MULTIPLIER) : base(interval, multiplier)
		{
			ColorValueTargetA = Math.Min(currentValue, targetValue);
			ColorValueTargetB = Math.Max(currentValue, targetValue);
			CurrentColor = currentValue;
			if (currentValue < targetValue)
				ReverseAnimationDirection = true;
		}
		#endregion

		#region Field members
		new public const int DEFAULT_MULTIPLIER = 15;

		public int ColorValueTargetA { get; set; } // Lower bound
		public int ColorValueTargetB { get; set; } // Upper bound
		public int CurrentColor { get; set; }      // Current value for the color
		#endregion

		#region Color update methods
		public int UpdateValue(int current, int final)
		{
			ChangeByAmmount = Math.Max(MinimumChangePerTick, GetChangePerTick(current, final, Interval, Multiplier));

			if (current < final)
				AnimationComplete = Increase(ref current, final);
			else if (current > final)
				AnimationComplete = Decrease(ref current, final);
			else
				AnimationComplete = true;

			return current;
		}
		#endregion

		#region Toggle methods
		public int ToggleValue()
		{
			if (CurrentColor > ColorValueTargetA && !ReverseAnimationDirection)
				CurrentColor = UpdateValue(CurrentColor, ColorValueTargetA);
			else if (CurrentColor < ColorValueTargetB)
				CurrentColor = UpdateValue(CurrentColor, ColorValueTargetB);
			else
				AnimationComplete = false;

			if (CurrentColor == ColorValueTargetA)
				ReverseAnimationDirection = true;
			else if (CurrentColor == ColorValueTargetB)
				ReverseAnimationDirection = false;

			return CurrentColor;
		}
		#endregion
	}
}
