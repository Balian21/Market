namespace RunningButtons
{
    partial class RacingForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RacingForm));
            this.start_button = new System.Windows.Forms.Button();
            this.pause_button = new System.Windows.Forms.Button();
            this.stop_button = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox_finish = new System.Windows.Forms.PictureBox();
            this.third_button = new RunningButtons.ButtonCompare();
            this.second_button = new RunningButtons.ButtonCompare();
            this.first_button = new RunningButtons.ButtonCompare();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_finish)).BeginInit();
            this.SuspendLayout();
            // 
            // start_button
            // 
            this.start_button.Location = new System.Drawing.Point(15, 51);
            this.start_button.Name = "start_button";
            this.start_button.Size = new System.Drawing.Size(75, 23);
            this.start_button.TabIndex = 0;
            this.start_button.Text = "Start";
            this.start_button.UseVisualStyleBackColor = true;
            this.start_button.Click += new System.EventHandler(this.start_button_Click);
            // 
            // pause_button
            // 
            this.pause_button.Enabled = false;
            this.pause_button.Location = new System.Drawing.Point(117, 51);
            this.pause_button.Name = "pause_button";
            this.pause_button.Size = new System.Drawing.Size(75, 23);
            this.pause_button.TabIndex = 0;
            this.pause_button.Text = "Pause";
            this.pause_button.UseVisualStyleBackColor = true;
            this.pause_button.Click += new System.EventHandler(this.pause_button_Click);
            // 
            // stop_button
            // 
            this.stop_button.Enabled = false;
            this.stop_button.Location = new System.Drawing.Point(218, 51);
            this.stop_button.Name = "stop_button";
            this.stop_button.Size = new System.Drawing.Size(75, 23);
            this.stop_button.TabIndex = 0;
            this.stop_button.Text = "Stop";
            this.stop_button.UseVisualStyleBackColor = true;
            this.stop_button.Click += new System.EventHandler(this.stop_button_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.start_button);
            this.groupBox1.Controls.Add(this.stop_button);
            this.groupBox1.Controls.Add(this.pause_button);
            this.groupBox1.Location = new System.Drawing.Point(99, 161);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(306, 100);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // pictureBox_finish
            // 
            this.pictureBox_finish.Image = global::RunningButtons.Properties.Resources.Finish;
            this.pictureBox_finish.Location = new System.Drawing.Point(567, -42);
            this.pictureBox_finish.Name = "pictureBox_finish";
            this.pictureBox_finish.Size = new System.Drawing.Size(5, 200);
            this.pictureBox_finish.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox_finish.TabIndex = 2;
            this.pictureBox_finish.TabStop = false;
            // 
            // third_button
            // 
            this.third_button.Location = new System.Drawing.Point(12, 104);
            this.third_button.Name = "third_button";
            this.third_button.Size = new System.Drawing.Size(75, 23);
            this.third_button.TabIndex = 0;
            this.third_button.Text = "button 3";
            this.third_button.UseVisualStyleBackColor = true;
            // 
            // second_button
            // 
            this.second_button.Location = new System.Drawing.Point(12, 56);
            this.second_button.Name = "second_button";
            this.second_button.Size = new System.Drawing.Size(75, 23);
            this.second_button.TabIndex = 0;
            this.second_button.Text = "button 2";
            this.second_button.UseVisualStyleBackColor = true;
            // 
            // first_button
            // 
            this.first_button.Location = new System.Drawing.Point(12, 12);
            this.first_button.Name = "first_button";
            this.first_button.Size = new System.Drawing.Size(75, 23);
            this.first_button.TabIndex = 0;
            this.first_button.Text = "button 1";
            this.first_button.UseVisualStyleBackColor = true;
            // 
            // RacingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(936, 273);
            this.Controls.Add(this.pictureBox_finish);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.third_button);
            this.Controls.Add(this.second_button);
            this.Controls.Add(this.first_button);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RacingForm";
            this.Text = "Гонки";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RacingForm_FormClosing);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_finish)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ButtonCompare first_button;
        private ButtonCompare second_button;
        private ButtonCompare third_button;
        private System.Windows.Forms.Button start_button;
        private System.Windows.Forms.Button pause_button;
        private System.Windows.Forms.Button stop_button;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox_finish;
    }
}

