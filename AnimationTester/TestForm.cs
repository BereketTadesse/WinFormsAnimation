using Animations;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace AnimationTester
{
	public partial class TestForm : Form
	{
		// bool flip = false;

		// bool flipLocX = false;
		// bool flipLocY = true;

		// string sandwichButtonIcon = '\u9776'.ToString(); // html (?)
		// string sandwichButtonIcon = '\u2630'.ToString(); // unicode
		// string backButtonIcon = '\u2190'.ToString();     // unicode

		string sandwichButtonIcon = "☰";
		string backButtonIcon = "←";

		SizeAnimator saX;
		// SizeAnimator saY;
		LocationAnimator laX;

		SizeAnimator scaleSizeX;
		SizeAnimator scaleSizeY;

		ColorAnimator caR;
		ColorAnimator caG;
		ColorAnimator caB;

		public TestForm()
		{
			InitializeComponent();
			saX = new SizeAnimator(TestPanel.Width, 0);
			// saY = new SizeAnimator(TimerPanelSize.Interval, 5, 0, TestPanel.Height);
			laX = new LocationAnimator(-TestPanel.Width, 0);
			// ca = new ColorAnimator(Pic.BackColor, Color.FromArgb(0xfff));
			caR = new ColorAnimator(Pic.BackColor.R, 26);
			caG = new ColorAnimator(Pic.BackColor.G, 74);
			caB = new ColorAnimator(Pic.BackColor.B, 85);
			



			scaleSizeX = new SizeAnimator(PicToScale.Width, PicToScale.Width + 100, 1, 3);
			scaleSizeY = new SizeAnimator(PicToScale.Height, PicToScale.Height + 100, 1, 3);


			LabelPicTransparency.Text = "ARGB: " + Pic.BackColor.A.ToString() + ", " + Pic.BackColor.R.ToString() + ", " + Pic.BackColor.G.ToString() + ", " + Pic.BackColor.B.ToString();
		}

		private void BtnSize_Click(object sender, EventArgs e)
		{
			TimerPanelSize.Enabled = true;
		}

		private void TimerPanelSize_Tick(object sender, EventArgs e)
		{
			TestPanel.Width = saX.ToggleDimension();

			if (saX.AnimationComplete)
				TimerPanelSize.Enabled = false;

			/*			
			bool doneX = false;
			bool doneY = false;

			int distanceX = Math.Abs(TestPanel.Width - (saX.toggleFlip ? saX.SizeTargetB : saX.SizeTargetA));
			int distanceY = Math.Abs(TestPanel.Height - (saY.toggleFlip ? saY.SizeTargetB : saY.SizeTargetA));

			TestPanel.Width = saX.ToggleDimensions(TestPanel.Width, out doneX);

			if (distanceY > distanceX)
			{
				saX.toggleFlip = saY.toggleFlip;
				doneX = doneY;
			}
			else if (distanceX > distanceY)
			{
				saY.toggleFlip = saX.toggleFlip;
				doneY = doneX;
			}

			TestPanel.Height = saY.ToggleDimensions(TestPanel.Height, out doneY);
			
			*/

			/*
			if (doneX && !doneY)
				saX.toggleFlip = !saX.toggleFlip;
			else if (doneY && !doneX)
				saY.toggleFlip = !saY.toggleFlip;
			*/

			/*

			if (doneX && doneY)
			{
				TimerPanelSize.Enabled = false;
			}
			*/
			/*
			int targetA = 0;
			int targetB = 350;
			bool doneX = true;
			bool doneY = true;
			SizeAnimator sa = new SizeAnimator(TimerPanelSize.Interval, 5);
			//sa.MinimumChangePerTick = 7;

			if (TestPanel.Width > targetA && !flip)
			{
				TestPanel.Width = sa.UpdateDimension(TestPanel.Width, targetA, out doneX);
				// TestPanel.Height = sa.UpdateWidth(TestPanel.Height, targetA, out doneY);
			}
			else if (TestPanel.Width < targetB)
			{
				TestPanel.Width = sa.UpdateDimension(TestPanel.Width, targetB, out doneX);
				// TestPanel.Height = sa.UpdateWidth(TestPanel.Height, targetB, out doneY);
			}

			LabelPanelSize.Text = "W: " + TestPanel.Width.ToString() + ", H: " + TestPanel.Height.ToString();

			if (doneX && doneY)
			{
				TimerPanelSize.Enabled = false;
				if (flip)
					BtnSize.Text = "Collapse";
				else
					BtnSize.Text = "Expand";
			}

			if ((TestPanel.Width == targetA || TestPanel.Width == targetB)/* && (TestPanel.Height == targetA || TestPanel.Height == targetB) *////)
			// flip = !flip;
		}

		private void TimerPicLocation_Tick(object sender, EventArgs e)
		{


			/*
			int finalPosXA = 500;
			int finalPosXB = 350;

			int finalPosYA = 300;
			int finalPosYB = 0;

			bool doneX = false;
			bool doneY = false;

			int posX = Pic.Location.X, posY = Pic.Location.Y;
			LocationAnimator la = new LocationAnimator(TimerPicLocation.Interval, 5);
			//sa.MinimumChangePerTick = 7;

			if (Pic.Location.X != finalPosXA && !doneX)
			{
				posX = la.UpdateDimension(Pic.Location.X, finalPosXA, LocationAnimator.Directions.Right, out doneX);
				// posY = la.UpdateDimension(Pic.Location.Y, finalPosYA, LocationAnimator.Directions.Down, out doneY);
			}
			else if (Pic.Location.X != finalPosXB && flipLocX)
			{
				posX = la.UpdateDimension(Pic.Location.X, finalPosXB, LocationAnimator.Directions.Left, out doneX);
				// posY = la.UpdateDimension(Pic.Location.Y, finalPosYB, LocationAnimator.Directions.Up, out doneY);
			}
			// Pic.Location = new Point(la.UpdateDimension(Pic.Location.X, incrementB, LocationAnimator.Directions.Left, out doneX), Pic.Location.Y);

			if (Pic.Location.Y != finalPosYA && !doneY)
				posY = la.UpdateDimension(Pic.Location.Y, finalPosYA, LocationAnimator.Directions.Down, out doneY);
			else if (Pic.Location.Y != finalPosYB && flipLocY)
				posY = la.UpdateDimension(Pic.Location.Y, finalPosYB, LocationAnimator.Directions.Up, out doneY);

			Pic.Location = new Point(posX, posY);

			LabelPicLocation.Text = "X: " + Pic.Location.X.ToString() + ", Y: " + Pic.Location.Y.ToString();

			if (doneX && doneY)
			{
				TimerPicLocation.Enabled = false;
			}

			if (Pic.Location.X == finalPosXA || Pic.Location.X == finalPosXB)
				flipLocX = flipLocX ^ doneX;

			if (Pic.Location.Y == finalPosYA || Pic.Location.Y == finalPosYB)
				flipLocY = flipLocY ^ doneY;
			*/

			/*
			if ((Pic.Location.X == finalPosXA || Pic.Location.X == finalPosXB) && (Pic.Location.Y == finalPosYA || Pic.Location.Y == finalPosYB))
				flip = !flip;
			*/

		}

		private void TestForm_SizeChanged(object sender, EventArgs e)
		{
			TestPanel.Height = this.Height;
			LabelPanelSize.Text = "W: " + TestPanel.Width.ToString() + ", W: " + TestPanel.Height.ToString();
		}

		private void TestForm_Load(object sender, EventArgs e)
		{
			TestPanel.Height = this.Height;
			LabelPanelSize.Text = "W: " + TestPanel.Width.ToString() + ", H: " + TestPanel.Height.ToString();
		}

		private void BtnMove_Click(object sender, EventArgs e)
		{
			TimerPanelLocation.Enabled = true;

			if (button5.Text == backButtonIcon)
				button5.Text = sandwichButtonIcon;
			else
				button5.Text = backButtonIcon;

		}

		private void ButtonTransparencyToggle_Click(object sender, EventArgs e)
		{
			TimerPicColorR.Enabled = true;
			TimerPicColorG.Enabled = true;
			TimerPicColorB.Enabled = true;
			/*
			if (Pic.BackColor.A == 0)
				Pic.BackColor = Color.FromArgb(255, Pic.BackColor);
			else
				Pic.BackColor = Color.FromArgb(0, Pic.BackColor);
			*/

		}

		private void TimerPicColor_Tick(object sender, EventArgs e)
		{
			// Pic.BackColor = Color.FromArgb(255, ca.ToggleValue(Pic.BackColor.R), Pic.BackColor.G, Pic.BackColor.B);
			Pic.BackColor = Color.FromArgb(255, Pic.BackColor.R, caG.ToggleValue(), Pic.BackColor.B);
			// Pic.BackColor = ca.Strobe(Pic.BackColor);

			// LabelPicTransparency.Text = "A: " + Pic.BackColor.A.ToString();

			LabelPicTransparency.Text = "ARGB: " + Pic.BackColor.A.ToString() + ", " + Pic.BackColor.R.ToString() + ", " + Pic.BackColor.G.ToString() + ", " + Pic.BackColor.B.ToString();

			if (caG.AnimationComplete)
				TimerPicColorG.Enabled = false;
		}

		private void TimerPanelLocation_Tick(object sender, EventArgs e)
		{
			TestPanel.Location = laX.ToggleBackAndForth(TestPanel.Location, LocationAnimator.Directions.Left);
			if (laX.AnimationComplete)
				TimerPanelLocation.Enabled = false;


			if (TestPanel.Location.X >= 0)
				button5.BackColor = TestPanel.BackColor;
			else
				button5.BackColor = TestPanel.Parent.BackColor;

		}

		private void TimerScale_SizeX_Tick(object sender, EventArgs e)
		{
			int prevWidth = PicToScale.Width;
			PicToScale.Width = scaleSizeX.ToggleDimension();

			PicToScale.Location = new Point(PicToScale.Location.X + ((prevWidth - PicToScale.Width) / 2), PicToScale.Location.Y);

			if (scaleSizeX.AnimationComplete)
				TimerScale_SizeX.Enabled = false;
		}

		private void TimerScale_SizeY_Tick(object sender, EventArgs e)
		{
			int prevHeight = PicToScale.Height;
			PicToScale.Height = scaleSizeY.ToggleDimension();

			PicToScale.Location = new Point(PicToScale.Location.X, PicToScale.Location.Y + ((prevHeight - PicToScale.Height) / 2));

			if (scaleSizeY.AnimationComplete)
				TimerScale_SizeY.Enabled = false;
		}

		private void button6_Click(object sender, EventArgs e)
		{
			TimerScale_SizeX.Enabled = true;
			TimerScale_SizeY.Enabled = true;
		}

		private void TimerPicColorB_Tick(object sender, EventArgs e)
		{
			// Pic.BackColor = Color.FromArgb(255, ca.ToggleValue(Pic.BackColor.R), Pic.BackColor.G, Pic.BackColor.B);
			Pic.BackColor = Color.FromArgb(255, Pic.BackColor.R, Pic.BackColor.G, caB.ToggleValue());
			// Pic.BackColor = ca.Strobe(Pic.BackColor);

			// LabelPicTransparency.Text = "A: " + Pic.BackColor.A.ToString();

			LabelPicTransparency.Text = "ARGB: " + Pic.BackColor.A.ToString() + ", " + Pic.BackColor.R.ToString() + ", " + Pic.BackColor.G.ToString() + ", " + Pic.BackColor.B.ToString();

			if (caB.AnimationComplete)
				TimerPicColorB.Enabled = false;

		}

		private void TimerPicColorR_Tick(object sender, EventArgs e)
		{
			// Pic.BackColor = Color.FromArgb(255, ca.ToggleValue(Pic.BackColor.R), Pic.BackColor.G, Pic.BackColor.B);
			Pic.BackColor = Color.FromArgb(255, caR.ToggleValue(), Pic.BackColor.G, Pic.BackColor.B);
			// Pic.BackColor = ca.Strobe(Pic.BackColor);

			// LabelPicTransparency.Text = "A: " + Pic.BackColor.A.ToString();

			LabelPicTransparency.Text = "ARGB: " + Pic.BackColor.A.ToString() + ", " + Pic.BackColor.R.ToString() + ", " + Pic.BackColor.G.ToString() + ", " + Pic.BackColor.B.ToString();

			if (caR.AnimationComplete)
				TimerPicColorR.Enabled = false;


		}
	}
}
