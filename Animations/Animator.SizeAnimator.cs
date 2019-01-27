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

		public SizeAnimator(int minSize, int maxSize) : this(1, minSize, maxSize)  { }

		public SizeAnimator(int interval, int minSize, int maxSize, int multiplier = 7) : base(interval, multiplier)
		{
			SizeTargetA = minSize;
			SizeTargetB = maxSize;
		}
		#endregion

		#region Field members
		public int SizeTargetA { get; private set; } // Lower bound
		public int SizeTargetB { get; private set; } // Upper bound
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
		public int ToggleDimension(int current)
		{
			int value = current;
			if (current > SizeTargetA && !reverseChange)
				value = UpdateDimension(current, SizeTargetA);
			else if (current < SizeTargetB)
				value = UpdateDimension(current, SizeTargetB);
			else
				AnimationComplete = false;
				
			if (value == SizeTargetA)
				reverseChange = true;
			else if (current == SizeTargetB)
				reverseChange = false;

			return value;
		}
		#endregion
	}
}