namespace SETMystify
{
    partial class frmMain
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
            this.btnStart = new System.Windows.Forms.Button();
            this.lineTimer = new System.Windows.Forms.Timer(this.components);
            this.speedBar = new System.Windows.Forms.TrackBar();
            this.lblSpeed = new System.Windows.Forms.Label();
            this.lblTailLength = new System.Windows.Forms.Label();
            this.tailBar = new System.Windows.Forms.TrackBar();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.drawPanel = new SETMystify.Panel_DoubleBuffered();
            this.btnFade = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.speedBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tailBar)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStart.Location = new System.Drawing.Point(430, 368);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "START";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lineTimer
            // 
            this.lineTimer.Interval = 50;
            this.lineTimer.Tick += new System.EventHandler(this.lineTimer_Tick);
            // 
            // speedBar
            // 
            this.speedBar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.speedBar.Location = new System.Drawing.Point(286, 397);
            this.speedBar.Name = "speedBar";
            this.speedBar.Size = new System.Drawing.Size(104, 45);
            this.speedBar.TabIndex = 1;
            this.speedBar.Scroll += new System.EventHandler(this.speedBar_Scroll);
            // 
            // lblSpeed
            // 
            this.lblSpeed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSpeed.AutoSize = true;
            this.lblSpeed.Location = new System.Drawing.Point(293, 381);
            this.lblSpeed.Name = "lblSpeed";
            this.lblSpeed.Size = new System.Drawing.Size(38, 13);
            this.lblSpeed.TabIndex = 2;
            this.lblSpeed.Text = "Speed";
            // 
            // lblTailLength
            // 
            this.lblTailLength.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTailLength.AutoSize = true;
            this.lblTailLength.Location = new System.Drawing.Point(183, 381);
            this.lblTailLength.Name = "lblTailLength";
            this.lblTailLength.Size = new System.Drawing.Size(60, 13);
            this.lblTailLength.TabIndex = 4;
            this.lblTailLength.Text = "Tail Length";
            // 
            // tailBar
            // 
            this.tailBar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tailBar.Location = new System.Drawing.Point(176, 397);
            this.tailBar.Name = "tailBar";
            this.tailBar.Size = new System.Drawing.Size(104, 45);
            this.tailBar.TabIndex = 3;
            this.tailBar.Scroll += new System.EventHandler(this.tailBar_Scroll);
            // 
            // btnCreate
            // 
            this.btnCreate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCreate.Location = new System.Drawing.Point(511, 368);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(75, 23);
            this.btnCreate.TabIndex = 0;
            this.btnCreate.Text = "CREATE";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnClear
            // 
            this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClear.Location = new System.Drawing.Point(430, 397);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "CLEAR";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // drawPanel
            // 
            this.drawPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.drawPanel.BackColor = System.Drawing.SystemColors.Control;
            this.drawPanel.Location = new System.Drawing.Point(0, 0);
            this.drawPanel.Name = "drawPanel";
            this.drawPanel.Size = new System.Drawing.Size(598, 349);
            this.drawPanel.TabIndex = 0;
            this.drawPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.drawPanel_Paint);
            // 
            // btnFade
            // 
            this.btnFade.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFade.Location = new System.Drawing.Point(511, 397);
            this.btnFade.Name = "btnFade";
            this.btnFade.Size = new System.Drawing.Size(75, 23);
            this.btnFade.TabIndex = 6;
            this.btnFade.Text = "FADE";
            this.btnFade.UseVisualStyleBackColor = true;
            this.btnFade.Click += new System.EventHandler(this.btnFade_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(598, 432);
            this.Controls.Add(this.btnFade);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lblTailLength);
            this.Controls.Add(this.tailBar);
            this.Controls.Add(this.lblSpeed);
            this.Controls.Add(this.speedBar);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.drawPanel);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMain";
            this.Text = "SET Mystify";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.Resize += new System.EventHandler(this.frmMain_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.speedBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tailBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel_DoubleBuffered drawPanel;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Timer lineTimer;
        private System.Windows.Forms.TrackBar speedBar;
        private System.Windows.Forms.Label lblSpeed;
        private System.Windows.Forms.Label lblTailLength;
        private System.Windows.Forms.TrackBar tailBar;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnFade;
    }
}

