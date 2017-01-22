namespace TwitchPoll
{
    partial class ObsScreen
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
            this.LblQuestion = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PnlAnswers = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // LblQuestion
            // 
            this.LblQuestion.BackColor = System.Drawing.Color.Transparent;
            this.LblQuestion.Font = new System.Drawing.Font("Elephant", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblQuestion.Location = new System.Drawing.Point(61, 58);
            this.LblQuestion.Name = "LblQuestion";
            this.LblQuestion.Size = new System.Drawing.Size(228, 23);
            this.LblQuestion.TabIndex = 0;
            this.LblQuestion.Text = "[Question]";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Elephant", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(48, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(255, 55);
            this.label1.TabIndex = 2;
            this.label1.Text = "Type number(0..1) or whole answer in chat!";
            // 
            // PnlAnswers
            // 
            this.PnlAnswers.AutoSize = true;
            this.PnlAnswers.BackColor = System.Drawing.Color.Transparent;
            this.PnlAnswers.Location = new System.Drawing.Point(52, 159);
            this.PnlAnswers.Name = "PnlAnswers";
            this.PnlAnswers.Size = new System.Drawing.Size(271, 221);
            this.PnlAnswers.TabIndex = 3;
            // 
            // ObsScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Magenta;
            this.BackgroundImage = global::TwitchPoll.Properties.Resources.Empty3;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(370, 425);
            this.ControlBox = false;
            this.Controls.Add(this.PnlAnswers);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LblQuestion);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ObsScreen";
            this.Text = "ObsScreen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblQuestion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel PnlAnswers;
    }
}