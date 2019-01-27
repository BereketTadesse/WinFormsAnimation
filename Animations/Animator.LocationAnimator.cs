using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animations
{
	public class LocationAnimator : Animator
	{
		#region Constructors

		public LocationAnimator(int minPoint, int maxPoint) : this(1, minPoint, maxPoint) { }

		public LocationAnimator(int interval, int minPoint, int maxPoint, int multiplier = 4) : base(interval, multiplier)
		{
			LocationTargetA = minPoint;
			LocationTargetB = maxPoint;
		}
		#endregion

		#region Direction enum
		// Decide the direction of movement
		public enum Directions
		{
			Down = 0,
			Right = 1,
			Up = 2,
			Left = 3
		}
		#endregion

		#region Field members

		public int LocationTargetA { get; private set; } // Lower bound
		public int LocationTargetB { get; private set; } // Upper bound
	
		#endregion

		#region Location update methods
		// Decides whether to Increment() or Decrement() the location and returns the appropriate value. Called every tick of a timer
		public int UpdateLocationValue(int current, int final, Directions direction)
		{
			ChangeByAmmount = Math.Max(MinimumChangePerTick, GetChangePerTick(current, final, Interval, Multiplier));

			if (direction == Directions.Down || direction == Directions.Right)
				AnimationComplete = Increase(ref current, final);
			else if (direction == Directions.Up || direction == Directions.Left)
				AnimationComplete = Decrease(ref current, final);
			else
				AnimationComplete = true;

			return current;
		}
		#endregion

		#region Toggle methods
		// Toggles location between the set lower and upper bounds and returns updated value every tick of a timer
		public Point ToggleBackAndForth(Point current, Directions direction)
		{
			Point value = current;

			if (reverseChange)
				direction = FlipToggleDirection(direction);

			if (direction == Directions.Up || direction == Directions.Down)
				value = ToggleY(current, direction);
			else
				value = ToggleX(current, direction);

			if (AnimationComplete)
				reverseChange = !reverseChange;

			return value;
		}

		// Decides direction of movement if toggleFlip is true
		private Directions FlipToggleDirection(Directions direction)
		{
			switch (direction)
			{
				case Directions.Left:
					return Directions.Right;
				case Directions.Right:
					return Directions.Left;
				case Directions.Up:
					return Directions.Down;
				default:
					return Directions.Up;
			}
		}

		// Generates point for horizontal toggle movement
		private Point ToggleX(Point current, Directions direction)
		{
			if (reverseChange)
				return new Point(UpdateLocationValue(current.X, LocationTargetB, direction), current.Y);
			else
				return new Point(UpdateLocationValue(current.X, LocationTargetA, direction), current.Y);
		}
		// Generates point for vertical toggle movement
		private Point ToggleY(Point current, Directions direction)
		{
			if (reverseChange)
				return new Point(current.X, UpdateLocationValue(current.Y, LocationTargetB, direction));
			else
				return new Point(current.X, UpdateLocationValue(current.Y, LocationTargetA, direction));
		}
		#endregion
	}

}
