namespace AnimationTester
{
	partial class TestForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TestForm));
			this.TestPanel = new System.Windows.Forms.Panel();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.button4 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.BtnSize = new System.Windows.Forms.Button();
			this.TimerPanelSize = new System.Windows.Forms.Timer(this.components);
			this.LabelPanelSize = new System.Windows.Forms.Label();
			this.TimerPanelLocation = new System.Windows.Forms.Timer(this.components);
			this.BtnMoveLeft = new System.Windows.Forms.Button();
			this.BtnMoveRight = new System.Windows.Forms.Button();
			this.Pic = new System.Windows.Forms.Panel();
			this.button1 = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.LabelPicLocation = new System.Windows.Forms.Label();
			this.BtnMove = new System.Windows.Forms.Button();
			this.ButtonTransparencyToggle = new System.Windows.Forms.Button();
			this.LabelPicTransparency = new System.Windows.Forms.Label();
			this.button5 = new System.Windows.Forms.Button();
			this.TimerPicColorG = new System.Windows.Forms.Timer(this.components);
			this.PicToScale = new System.Windows.Forms.PictureBox();
			this.button6 = new System.Windows.Forms.Button();
			this.TimerScale_SizeX = new System.Windows.Forms.Timer(this.components);
			this.TimerScale_SizeY = new System.Windows.Forms.Timer(this.components);
			this.TimerPicColorR = new System.Windows.Forms.Timer(this.components);
			this.TimerPicColorB = new System.Windows.Forms.Timer(this.components);
			this.TestPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.Pic.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.PicToScale)).BeginInit();
			this.SuspendLayout();
			// 
			// TestPanel
			// 
			this.TestPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
			this.TestPanel.Controls.Add(this.pictureBox1);
			this.TestPanel.Controls.Add(this.button4);
			this.TestPanel.Controls.Add(this.button3);
			this.TestPanel.Controls.Add(this.button2);
			this.TestPanel.Location = new System.Drawing.Point(0, 0);
			this.TestPanel.Name = "TestPanel";
			this.TestPanel.Size = new System.Drawing.Size(350, 557);
			this.TestPanel.TabIndex = 0;
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
			this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.pictureBox1.Location = new System.Drawing.Point(15, 129);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(100, 100);
			this.pictureBox1.TabIndex = 1;
			this.pictureBox1.TabStop = false;
			// 
			// button4
			// 
			this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
			this.button4.FlatAppearance.BorderSize = 0;
			this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button4.Location = new System.Drawing.Point(15, 99);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(73, 23);
			this.button4.TabIndex = 0;
			this.button4.Text = "Option 3";
			this.button4.UseVisualStyleBackColor = false;
			// 
			// button3
			// 
			this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
			this.button3.FlatAppearance.BorderSize = 0;
			this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button3.Location = new System.Drawing.Point(15, 70);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(73, 23);
			this.button3.TabIndex = 0;
			this.button3.Text = "Option 2";
			this.button3.UseVisualStyleBackColor = false;
			// 
			// button2
			// 
			this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
			this.button2.FlatAppearance.BorderSize = 0;
			this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button2.Location = new System.Drawing.Point(15, 41);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(73, 23);
			this.button2.TabIndex = 0;
			this.button2.Text = "Option 1";
			this.button2.UseVisualStyleBackColor = false;
			// 
			// BtnSize
			// 
			this.BtnSize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.BtnSize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
			this.BtnSize.FlatAppearance.BorderSize = 0;
			this.BtnSize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.BtnSize.ForeColor = System.Drawing.Color.White;
			this.BtnSize.Location = new System.Drawing.Point(13, 522);
			this.BtnSize.Name = "BtnSize";
			this.BtnSize.Size = new System.Drawing.Size(75, 23);
			this.BtnSize.TabIndex = 1;
			this.BtnSize.Text = "Collapse";
			this.BtnSize.UseVisualStyleBackColor = false;
			this.BtnSize.Click += new System.EventHandler(this.BtnSize_Click);
			// 
			// TimerPanelSize
			// 
			this.TimerPanelSize.Interval = 1;
			this.TimerPanelSize.Tick += new System.EventHandler(this.TimerPanelSize_Tick);
			// 
			// LabelPanelSize
			// 
			this.LabelPanelSize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.LabelPanelSize.AutoSize = true;
			this.LabelPanelSize.Location = new System.Drawing.Point(12, 506);
			this.LabelPanelSize.Name = "LabelPanelSize";
			this.LabelPanelSize.Size = new System.Drawing.Size(16, 13);
			this.LabelPanelSize.TabIndex = 2;
			this.LabelPanelSize.Text = "---";
			// 
			// TimerPanelLocation
			// 
			this.TimerPanelLocation.Interval = 1;
			this.TimerPanelLocation.Tick += new System.EventHandler(this.TimerPanelLocation_Tick);
			// 
			// BtnMoveLeft
			// 
			this.BtnMoveLeft.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.BtnMoveLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
			this.BtnMoveLeft.Enabled = false;
			this.BtnMoveLeft.FlatAppearance.BorderSize = 0;
			this.BtnMoveLeft.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.BtnMoveLeft.ForeColor = System.Drawing.Color.White;
			this.BtnMoveLeft.Location = new System.Drawing.Point(649, 522);
			this.BtnMoveLeft.Name = "BtnMoveLeft";
			this.BtnMoveLeft.Size = new System.Drawing.Size(23, 23);
			this.BtnMoveLeft.TabIndex = 1;
			this.BtnMoveLeft.Text = "<";
			this.BtnMoveLeft.UseVisualStyleBackColor = false;
			// 
			// BtnMoveRight
			// 
			this.BtnMoveRight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.BtnMoveRight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
			this.BtnMoveRight.Enabled = false;
			this.BtnMoveRight.FlatAppearance.BorderSize = 0;
			this.BtnMoveRight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.BtnMoveRight.ForeColor = System.Drawing.Color.White;
			this.BtnMoveRight.Location = new System.Drawing.Point(678, 522);
			this.BtnMoveRight.Name = "BtnMoveRight";
			this.BtnMoveRight.Size = new System.Drawing.Size(23, 23);
			this.BtnMoveRight.TabIndex = 1;
			this.BtnMoveRight.Text = ">";
			this.BtnMoveRight.UseVisualStyleBackColor = false;
			// 
			// Pic
			// 
			this.Pic.BackColor = System.Drawing.Color.White;
			this.Pic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.Pic.Controls.Add(this.button1);
			this.Pic.Controls.Add(this.label1);
			this.Pic.Location = new System.Drawing.Point(350, 0);
			this.Pic.Name = "Pic";
			this.Pic.Size = new System.Drawing.Size(190, 185);
			this.Pic.TabIndex = 3;
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
			this.button1.FlatAppearance.BorderSize = 0;
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.Location = new System.Drawing.Point(4, 21);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 1;
			this.button1.Text = "Sample Button";
			this.button1.UseVisualStyleBackColor = false;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(23)))), ((int)(((byte)(24)))));
			this.label1.Location = new System.Drawing.Point(4, 4);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(62, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Sample text";
			// 
			// LabelPicLocation
			// 
			this.LabelPicLocation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.LabelPicLocation.AutoSize = true;
			this.LabelPicLocation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(23)))), ((int)(((byte)(24)))));
			this.LabelPicLocation.Location = new System.Drawing.Point(646, 506);
			this.LabelPicLocation.Name = "LabelPicLocation";
			this.LabelPicLocation.Size = new System.Drawing.Size(16, 13);
			this.LabelPicLocation.TabIndex = 4;
			this.LabelPicLocation.Text = "---";
			this.LabelPicLocation.TextAlign = System.Drawing.ContentAlignment.BottomRight;
			// 
			// BtnMove
			// 
			this.BtnMove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.BtnMove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
			this.BtnMove.FlatAppearance.BorderSize = 0;
			this.BtnMove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.BtnMove.ForeColor = System.Drawing.Color.White;
			this.BtnMove.Location = new System.Drawing.Point(707, 522);
			this.BtnMove.Name = "BtnMove";
			this.BtnMove.Size = new System.Drawing.Size(75, 23);
			this.BtnMove.TabIndex = 1;
			this.BtnMove.Text = "Move";
			this.BtnMove.UseVisualStyleBackColor = false;
			this.BtnMove.Click += new System.EventHandler(this.BtnMove_Click);
			// 
			// ButtonTransparencyToggle
			// 
			this.ButtonTransparencyToggle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.ButtonTransparencyToggle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
			this.ButtonTransparencyToggle.FlatAppearance.BorderSize = 0;
			this.ButtonTransparencyToggle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.ButtonTransparencyToggle.ForeColor = System.Drawing.Color.White;
			this.ButtonTransparencyToggle.Location = new System.Drawing.Point(568, 522);
			this.ButtonTransparencyToggle.Name = "ButtonTransparencyToggle";
			this.ButtonTransparencyToggle.Size = new System.Drawing.Size(75, 23);
			this.ButtonTransparencyToggle.TabIndex = 5;
			this.ButtonTransparencyToggle.Text = "Color";
			this.ButtonTransparencyToggle.UseVisualStyleBackColor = false;
			this.ButtonTransparencyToggle.Click += new System.EventHandler(this.ButtonTransparencyToggle_Click);
			// 
			// LabelPicTransparency
			// 
			this.LabelPicTransparency.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.LabelPicTransparency.AutoSize = true;
			this.LabelPicTransparency.Location = new System.Drawing.Point(568, 505);
			this.LabelPicTransparency.Name = "LabelPicTransparency";
			this.LabelPicTransparency.Size = new System.Drawing.Size(16, 13);
			this.LabelPicTransparency.TabIndex = 6;
			this.LabelPicTransparency.Text = "---";
			// 
			// button5
			// 
			this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
			this.button5.FlatAppearance.BorderSize = 0;
			this.button5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button5.Location = new System.Drawing.Point(15, 12);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(23, 23);
			this.button5.TabIndex = 7;
			this.button5.Text = "←";
			this.button5.UseVisualStyleBackColor = false;
			this.button5.Click += new System.EventHandler(this.BtnMove_Click);
			// 
			// TimerPicColorG
			// 
			this.TimerPicColorG.Interval = 1;
			this.TimerPicColorG.Tick += new System.EventHandler(this.TimerPicColor_Tick);
			// 
			// PicToScale
			// 
			this.PicToScale.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PicToScale.BackgroundImage")));
			this.PicToScale.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.PicToScale.Location = new System.Drawing.Point(528, 283);
			this.PicToScale.Name = "PicToScale";
			this.PicToScale.Size = new System.Drawing.Size(100, 100);
			this.PicToScale.TabIndex = 1;
			this.PicToScale.TabStop = false;
			// 
			// button6
			// 
			this.button6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
			this.button6.FlatAppearance.BorderSize = 0;
			this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button6.ForeColor = System.Drawing.Color.White;
			this.button6.Location = new System.Drawing.Point(357, 522);
			this.button6.Name = "button6";
			this.button6.Size = new System.Drawing.Size(75, 23);
			this.button6.TabIndex = 5;
			this.button6.Text = "Scale Photo";
			this.button6.UseVisualStyleBackColor = false;
			this.button6.Click += new System.EventHandler(this.button6_Click);
			// 
			// TimerScale_SizeX
			// 
			this.TimerScale_SizeX.Interval = 1;
			this.TimerScale_SizeX.Tick += new System.EventHandler(this.TimerScale_SizeX_Tick);
			// 
			// TimerScale_SizeY
			// 
			this.TimerScale_SizeY.Interval = 1;
			this.TimerScale_SizeY.Tick += new System.EventHandler(this.TimerScale_SizeY_Tick);
			// 
			// TimerPicColorR
			// 
			this.TimerPicColorR.Interval = 1;
			this.TimerPicColorR.Tick += new System.EventHandler(this.TimerPicColorR_Tick);
			// 
			// TimerPicColorB
			// 
			this.TimerPicColorB.Interval = 1;
			this.TimerPicColorB.Tick += new System.EventHandler(this.TimerPicColorB_Tick);
			// 
			// TestForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(23)))), ((int)(((byte)(24)))));
			this.ClientSize = new System.Drawing.Size(794, 557);
			this.Controls.Add(this.PicToScale);
			this.Controls.Add(this.button5);
			this.Controls.Add(this.LabelPicTransparency);
			this.Controls.Add(this.button6);
			this.Controls.Add(this.ButtonTransparencyToggle);
			this.Controls.Add(this.LabelPicLocation);
			this.Controls.Add(this.Pic);
			this.Controls.Add(this.LabelPanelSize);
			this.Controls.Add(this.BtnMoveRight);
			this.Controls.Add(this.BtnMoveLeft);
			this.Controls.Add(this.BtnMove);
			this.Controls.Add(this.BtnSize);
			this.Controls.Add(this.TestPanel);
			this.ForeColor = System.Drawing.Color.White;
			this.Name = "TestForm";
			this.Text = "Test Form";
			this.Load += new System.EventHandler(this.TestForm_Load);
			this.SizeChanged += new System.EventHandler(this.TestForm_SizeChanged);
			this.TestPanel.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.Pic.ResumeLayout(false);
			this.Pic.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.PicToScale)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Panel TestPanel;
		private System.Windows.Forms.Button BtnSize;
		private System.Windows.Forms.Timer TimerPanelSize;
		private System.Windows.Forms.Label LabelPanelSize;
		private System.Windows.Forms.Timer TimerPanelLocation;
		private System.Windows.Forms.Button BtnMoveLeft;
		private System.Windows.Forms.Button BtnMoveRight;
		private System.Windows.Forms.Panel Pic;
		private System.Windows.Forms.Label LabelPicLocation;
		private System.Windows.Forms.Button BtnMove;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button ButtonTransparencyToggle;
		private System.Windows.Forms.Label LabelPicTransparency;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.Timer TimerPicColorG;
		private System.Windows.Forms.PictureBox PicToScale;
		private System.Windows.Forms.Button button6;
		private System.Windows.Forms.Timer TimerScale_SizeX;
		private System.Windows.Forms.Timer TimerScale_SizeY;
		private System.Windows.Forms.Timer TimerPicColorR;
		private System.Windows.Forms.Timer TimerPicColorB;
	}
}

