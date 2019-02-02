using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animations
{
	public class SizeAnimator : Animator
	{
		#region Constructors
		/// <summary>
		///  Initializes an object that periodically calculates size values to animate between the currentSize and the targetSize
		/// </summary>
		/// <param name="currentSize">Current size the object (width or height)</param>
		/// <param name="targetSize">Initial target size of the object (width or height)</param>
		/// <param name="interval">Number of miliseconds between ticks of the animation timer (must be declared separately)</param>
		/// <param name="multiplier">Value that multiplies the interval to slow down or speed up animations</param>
		
		public SizeAnimator(int currentSize, int targetSize, int interval = 1, int multiplier = 7)
		{
			SizeTargetA = Math.Min(currentSize, targetSize);
			SizeTargetB = Math.Max(currentSize, targetSize);
			CurrentSize = currentSize;

			if (currentSize < targetSize)
				ReverseAnimationDirection = true;
		}

		#endregion

		#region Field members
		public int SizeTargetA { get; private set; } // Lower bound
		public int SizeTargetB { get; private set; } // Upper bound
		public int CurrentSize { get; private set; } // Current size of object
		#endregion

		#region Size update methods
		public int UpdateDimension(int current, int final)
		{
			ChangeByAmmount = Math.Max(MinimumChangePerTick, GetChangePerTick(current, final, base.Interval, base.Multiplier));

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
		public int ToggleDimension()
		{
			// int value = CurrentSize;
			if (CurrentSize > SizeTargetA && !ReverseAnimationDirection)
				CurrentSize = UpdateDimension(CurrentSize, SizeTargetA);
			else if (CurrentSize < SizeTargetB)
				CurrentSize = UpdateDimension(CurrentSize, SizeTargetB);
			else
				AnimationComplete = false;
				
			if (CurrentSize == SizeTargetA)
				ReverseAnimationDirection = true;
			else if (CurrentSize == SizeTargetB)
				ReverseAnimationDirection = false;

			return CurrentSize;
		}
		#endregion
	}
}