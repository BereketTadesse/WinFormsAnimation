using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animations
{
	public abstract partial class Animator
	{
		#region Constructors

		protected Animator(int interval = 1)
		{
			Interval = interval;
			Multiplier = 5;
		}

		protected Animator(int interval, int multiplier) : this(interval)
		{
			Multiplier = multiplier;
		}

		#endregion

		#region Field members
		public int Interval { get; set; }     // ms between timer ticks. Used to calculate change per interval
		public int Multiplier { get; set; } = 5;   // Increases the time taken to complete animation. Multiplies interval in order to decrease change per interval. Smoother
		public int MinimumChangePerTick { get; set; } = 4; // Prevents freezing when calculated change in value is 0

		public bool AnimationComplete { get; set; } // Used as output variable to confirm the lower or upper bound has been reached
		protected int ChangeByAmmount; // Ammount to increment or decrement values by at every interval. Recalculated per tick to avoid choppy animation

		public bool reverseChange = false; // Reverses direction of animation if true. (Default: true = increase, false = decrease
		#endregion

		#region Change per tick methods

		#region Calculate values
		// Get value to increase/decrease by for every tick of the timer
		protected static int GetChangePerTick(int current, int final, int interval, int multiplier)
		{
			int change = Math.Abs(current - final);
			return change / (interval * multiplier);
		}
		#endregion

			#region Increment/Decrement methods
		// Increments values by ChangeByAmmount until upper bound is reached
		protected bool Increase(ref int current, int final)
		{
			if (current + ChangeByAmmount <= final)
				current += ChangeByAmmount;
			else
				current = final;

			if (current == final)
				return true;
			return false;
		}

		// Decrements values by ChangeByAmmount until lower bound is reached
		protected bool Decrease(ref int current, int final)
		{
			if (current - ChangeByAmmount >= final)
				current -= ChangeByAmmount;
			else
				current = final;

			if (current == final)
				return true;
			return false;
		}
		#endregion

		#endregion
	}
}
