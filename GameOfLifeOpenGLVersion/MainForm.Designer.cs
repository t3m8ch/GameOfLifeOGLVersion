namespace GameOfLifeOpenGLVersion
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nudDensity = new System.Windows.Forms.NumericUpDown();
            this.nudHeight = new System.Windows.Forms.NumericUpDown();
            this.nudWidth = new System.Windows.Forms.NumericUpDown();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.glControl = new SharpGL.OpenGLControl();
            this.fpsTime = new System.Windows.Forms.Timer(this.components);
            this.cbIsMultithread = new System.Windows.Forms.CheckBox();
            this.tbColorRed = new System.Windows.Forms.TrackBar();
            this.tbColorGreen = new System.Windows.Forms.TrackBar();
            this.tbColorBlue = new System.Windows.Forms.TrackBar();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDensity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.glControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbColorRed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbColorGreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbColorBlue)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.label6);
            this.splitContainer1.Panel1.Controls.Add(this.label5);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.tbColorBlue);
            this.splitContainer1.Panel1.Controls.Add(this.tbColorGreen);
            this.splitContainer1.Panel1.Controls.Add(this.tbColorRed);
            this.splitContainer1.Panel1.Controls.Add(this.cbIsMultithread);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.nudDensity);
            this.splitContainer1.Panel1.Controls.Add(this.nudHeight);
            this.splitContainer1.Panel1.Controls.Add(this.nudWidth);
            this.splitContainer1.Panel1.Controls.Add(this.btnStop);
            this.splitContainer1.Panel1.Controls.Add(this.btnStart);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.glControl);
            this.splitContainer1.Size = new System.Drawing.Size(1174, 711);
            this.splitContainer1.SplitterDistance = 149;
            this.splitContainer1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(570, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Density";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(423, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Height";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(277, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Width";
            // 
            // nudDensity
            // 
            this.nudDensity.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudDensity.Location = new System.Drawing.Point(574, 40);
            this.nudDensity.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nudDensity.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nudDensity.Name = "nudDensity";
            this.nudDensity.Size = new System.Drawing.Size(141, 27);
            this.nudDensity.TabIndex = 4;
            this.nudDensity.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // nudHeight
            // 
            this.nudHeight.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudHeight.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudHeight.Location = new System.Drawing.Point(427, 40);
            this.nudHeight.Maximum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.nudHeight.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nudHeight.Name = "nudHeight";
            this.nudHeight.Size = new System.Drawing.Size(141, 27);
            this.nudHeight.TabIndex = 3;
            this.nudHeight.Value = new decimal(new int[] {
            200,
            0,
            0,
            0});
            // 
            // nudWidth
            // 
            this.nudWidth.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudWidth.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudWidth.Location = new System.Drawing.Point(280, 40);
            this.nudWidth.Maximum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.nudWidth.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nudWidth.Name = "nudWidth";
            this.nudWidth.Size = new System.Drawing.Size(141, 27);
            this.nudWidth.TabIndex = 2;
            this.nudWidth.Value = new decimal(new int[] {
            200,
            0,
            0,
            0});
            // 
            // btnStop
            // 
            this.btnStop.Enabled = false;
            this.btnStop.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnStop.Location = new System.Drawing.Point(146, 12);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(128, 56);
            this.btnStop.TabIndex = 1;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnStart.Location = new System.Drawing.Point(12, 12);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(128, 56);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // glControl
            // 
            this.glControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.glControl.DrawFPS = true;
            this.glControl.FrameRate = 60;
            this.glControl.Location = new System.Drawing.Point(0, 0);
            this.glControl.Name = "glControl";
            this.glControl.OpenGLVersion = SharpGL.Version.OpenGLVersion.OpenGL4_4;
            this.glControl.RenderContextType = SharpGL.RenderContextType.DIBSection;
            this.glControl.RenderTrigger = SharpGL.RenderTrigger.TimerBased;
            this.glControl.Size = new System.Drawing.Size(1174, 558);
            this.glControl.TabIndex = 0;
            this.glControl.OpenGLDraw += new SharpGL.RenderEventHandler(this.glControl_OpenGLDraw);
            // 
            // fpsTime
            // 
            this.fpsTime.Interval = 1000;
            this.fpsTime.Tick += new System.EventHandler(this.fpsTime_Tick);
            // 
            // cbIsMultithread
            // 
            this.cbIsMultithread.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cbIsMultithread.AutoSize = true;
            this.cbIsMultithread.Checked = true;
            this.cbIsMultithread.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbIsMultithread.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbIsMultithread.Location = new System.Drawing.Point(973, 110);
            this.cbIsMultithread.Name = "cbIsMultithread";
            this.cbIsMultithread.Size = new System.Drawing.Size(189, 24);
            this.cbIsMultithread.TabIndex = 8;
            this.cbIsMultithread.Text = "Multithread Generating";
            this.cbIsMultithread.UseVisualStyleBackColor = true;
            // 
            // tbColorRed
            // 
            this.tbColorRed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tbColorRed.Location = new System.Drawing.Point(6, 110);
            this.tbColorRed.Maximum = 255;
            this.tbColorRed.Name = "tbColorRed";
            this.tbColorRed.Size = new System.Drawing.Size(262, 45);
            this.tbColorRed.TabIndex = 9;
            this.tbColorRed.Value = 255;
            this.tbColorRed.Scroll += new System.EventHandler(this.tbColorRed_Scroll);
            // 
            // tbColorGreen
            // 
            this.tbColorGreen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tbColorGreen.Location = new System.Drawing.Point(274, 110);
            this.tbColorGreen.Maximum = 255;
            this.tbColorGreen.Name = "tbColorGreen";
            this.tbColorGreen.Size = new System.Drawing.Size(262, 45);
            this.tbColorGreen.TabIndex = 10;
            this.tbColorGreen.Value = 255;
            this.tbColorGreen.Scroll += new System.EventHandler(this.tbColorGreen_Scroll);
            // 
            // tbColorBlue
            // 
            this.tbColorBlue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tbColorBlue.Location = new System.Drawing.Point(542, 110);
            this.tbColorBlue.Maximum = 255;
            this.tbColorBlue.Name = "tbColorBlue";
            this.tbColorBlue.Size = new System.Drawing.Size(262, 45);
            this.tbColorBlue.TabIndex = 11;
            this.tbColorBlue.Value = 255;
            this.tbColorBlue.Scroll += new System.EventHandler(this.tbColorBlue_Scroll);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(9, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Red";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(277, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "Green";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(545, 83);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "Blue";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1174, 711);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MinimumSize = new System.Drawing.Size(1100, 600);
            this.Name = "MainForm";
            this.Text = "Game Of Life | OpenGL Version";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudDensity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.glControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbColorRed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbColorGreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbColorBlue)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.NumericUpDown nudWidth;
        private System.Windows.Forms.NumericUpDown nudDensity;
        private System.Windows.Forms.NumericUpDown nudHeight;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private SharpGL.OpenGLControl glControl;
        private System.Windows.Forms.Timer fpsTime;
        private System.Windows.Forms.CheckBox cbIsMultithread;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TrackBar tbColorBlue;
        private System.Windows.Forms.TrackBar tbColorGreen;
        private System.Windows.Forms.TrackBar tbColorRed;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.SplitContainer splitContainer1;
    }
}

