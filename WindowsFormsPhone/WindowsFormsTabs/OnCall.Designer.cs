namespace WindowsFormsTabs
{
    partial class OnCall
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OnCall));
            this.time = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.timerstart = new System.Windows.Forms.Timer(this.components);
            this.timertalk = new System.Windows.Forms.Timer(this.components);
            this.pause = new System.Windows.Forms.Button();
            this.minutes = new System.Windows.Forms.Label();
            this.seconds = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.EndButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // time
            // 
            this.time.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.time.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.time.ForeColor = System.Drawing.Color.Snow;
            this.time.Location = new System.Drawing.Point(12, 9);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(269, 77);
            this.time.TabIndex = 0;
            this.time.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(12, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(269, 324);
            this.label1.TabIndex = 1;
            // 
            // timerstart
            // 
            this.timerstart.Interval = 5000;
            this.timerstart.Tick += new System.EventHandler(this.timerstart_Tick);
            // 
            // timertalk
            // 
            this.timertalk.Interval = 1000;
            this.timertalk.Tick += new System.EventHandler(this.timertalk_Tick);
            // 
            // pause
            // 
            this.pause.Enabled = false;
            this.pause.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pause.Location = new System.Drawing.Point(157, 110);
            this.pause.Name = "pause";
            this.pause.Size = new System.Drawing.Size(70, 70);
            this.pause.TabIndex = 21;
            this.pause.Tag = "pause";
            this.pause.UseVisualStyleBackColor = true;
            this.pause.Click += new System.EventHandler(this.pause_Click);
            // 
            // minutes
            // 
            this.minutes.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minutes.Location = new System.Drawing.Point(94, 35);
            this.minutes.Name = "minutes";
            this.minutes.Size = new System.Drawing.Size(54, 23);
            this.minutes.TabIndex = 23;
            this.minutes.Text = "0";
            this.minutes.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.minutes.Visible = false;
            // 
            // seconds
            // 
            this.seconds.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seconds.Location = new System.Drawing.Point(154, 35);
            this.seconds.Name = "seconds";
            this.seconds.Size = new System.Drawing.Size(45, 23);
            this.seconds.TabIndex = 24;
            this.seconds.Text = "0";
            this.seconds.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.seconds.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(141, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(19, 29);
            this.label4.TabIndex = 25;
            this.label4.Text = ":";
            this.label4.Visible = false;
            // 
            // button4
            // 
            this.button4.Image = global::WindowsFormsTabs.Properties.Resources.feature_settings;
            this.button4.Location = new System.Drawing.Point(65, 201);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(70, 70);
            this.button4.TabIndex = 22;
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.Image = global::WindowsFormsTabs.Properties.Resources.add;
            this.button2.Location = new System.Drawing.Point(157, 201);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(70, 70);
            this.button2.TabIndex = 20;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Image = global::WindowsFormsTabs.Properties.Resources.microphone;
            this.button1.Location = new System.Drawing.Point(65, 110);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(70, 70);
            this.button1.TabIndex = 19;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // EndButton
            // 
            this.EndButton.BackColor = System.Drawing.Color.Red;
            this.EndButton.Image = global::WindowsFormsTabs.Properties.Resources.feature3;
            this.EndButton.Location = new System.Drawing.Point(65, 316);
            this.EndButton.Name = "EndButton";
            this.EndButton.Size = new System.Drawing.Size(162, 70);
            this.EndButton.TabIndex = 18;
            this.EndButton.UseVisualStyleBackColor = false;
            this.EndButton.Click += new System.EventHandler(this.EndButton_Click);
            // 
            // OnCall
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(293, 419);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.minutes);
            this.Controls.Add(this.seconds);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.pause);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.EndButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.time);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "OnCall";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "OnCall";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.OnCall_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label time;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button EndButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Timer timerstart;
        private System.Windows.Forms.Timer timertalk;
        private System.Windows.Forms.Button pause;
        private System.Windows.Forms.Label minutes;
        private System.Windows.Forms.Label seconds;
        private System.Windows.Forms.Label label4;

    }
}