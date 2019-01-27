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

		/* UNFINISHED
		public ColorAnimator(Color initColor, Color finalColor) : base(DEFAULT_INTERVAL, DEFAULT_MULTIPLIER)
		{
			AnimateR = new ColorAnimator(Math.Min(initColor.R, finalColor.R), Math.Max(initColor.R, finalColor.R));
			AnimateG = new ColorAnimator(Math.Min(initColor.G, finalColor.G), Math.Max(initColor.G, finalColor.G));
			AnimateB = new ColorAnimator(Math.Min(initColor.B, finalColor.B), Math.Max(initColor.B, finalColor.B));

			if (finalColor.R > initColor.R)
				AnimateR.reverseChange = true;
			if (finalColor.G > initColor.G)
				AnimateG.reverseChange = true;
			if (finalColor.B > initColor.B)
				AnimateB.reverseChange = true;
		}
		*/		

		public ColorAnimator(int minValue, int maxValue) : this(DEFAULT_INTERVAL, minValue, maxValue) { }

		public ColorAnimator(int interval, int minValue, int maxValue, int multiplier = DEFAULT_MULTIPLIER) : base(interval, multiplier)
		{
			ColorValueTargetA = minValue;
			ColorValueTargetB = maxValue;
		}

		#endregion

		#region Field members

		public const int DEFAULT_INTERVAL = 1;
		public const int DEFAULT_MULTIPLIER = 15;

		public int ColorValueTargetA { get; set; } // Lower bound
		public int ColorValueTargetB { get; set; } // Upper bound

		// public Color ColorTargetA { get; set; }
		// public Color ColorTargetB { get; set; }

		// public ColorAnimator AnimateR { get; set; }
		// public ColorAnimator AnimateG { get; set; }
		// public ColorAnimator AnimateB { get; set; }

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
		
		public int ToggleValue(int current)
		{
			int value = current;
			if (current > ColorValueTargetA && !reverseChange)
				value = UpdateValue(current, ColorValueTargetA);
			else if (current < ColorValueTargetB)
				value = UpdateValue(current, ColorValueTargetB);
			else
				AnimationComplete = false;

			if (value == ColorValueTargetA)
				reverseChange = true;
			else if (current == ColorValueTargetB)
				reverseChange = false;

			return value;
		}

		/*
		public Color Strobe(Color current)
		{
			Color value = Color.FromArgb(current.A, AnimateR.ToggleValue(current.R), AnimateG.ToggleValue(current.G), AnimateB.ToggleValue(current.B));
			if (AnimateR.AnimationComplete && AnimateG.AnimationComplete && AnimateB.AnimationComplete)
				AnimationComplete = true;
			return value;
		}
		*/
	
		#endregion

	}
}
