namespace TwitchPoll
{
    partial class AnswerItem
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.LblNumber = new System.Windows.Forms.Label();
            this.LblAnswer = new System.Windows.Forms.Label();
            this.PBAmount = new System.Windows.Forms.ProgressBar();
            this.LblAmount = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LblNumber
            // 
            this.LblNumber.AutoSize = true;
            this.LblNumber.Font = new System.Drawing.Font("Elephant", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNumber.Location = new System.Drawing.Point(3, 4);
            this.LblNumber.Name = "LblNumber";
            this.LblNumber.Size = new System.Drawing.Size(39, 37);
            this.LblNumber.TabIndex = 0;
            this.LblNumber.Text = "0";
            // 
            // LblAnswer
            // 
            this.LblAnswer.AutoSize = true;
            this.LblAnswer.Font = new System.Drawing.Font("Elephant", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAnswer.Location = new System.Drawing.Point(38, 4);
            this.LblAnswer.Name = "LblAnswer";
            this.LblAnswer.Size = new System.Drawing.Size(79, 20);
            this.LblAnswer.TabIndex = 1;
            this.LblAnswer.Text = "[Answer]";
            // 
            // PBAmount
            // 
            this.PBAmount.Location = new System.Drawing.Point(42, 27);
            this.PBAmount.MarqueeAnimationSpeed = 0;
            this.PBAmount.Name = "PBAmount";
            this.PBAmount.Size = new System.Drawing.Size(131, 10);
            this.PBAmount.Step = 1;
            this.PBAmount.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.PBAmount.TabIndex = 2;
            // 
            // LblAmount
            // 
            this.LblAmount.AutoSize = true;
            this.LblAmount.Location = new System.Drawing.Point(179, 20);
            this.LblAmount.Name = "LblAmount";
            this.LblAmount.Size = new System.Drawing.Size(52, 17);
            this.LblAmount.TabIndex = 3;
            this.LblAmount.Text = "[100%]";
            // 
            // AnswerItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.LblAmount);
            this.Controls.Add(this.PBAmount);
            this.Controls.Add(this.LblAnswer);
            this.Controls.Add(this.LblNumber);
            this.Name = "AnswerItem";
            this.Size = new System.Drawing.Size(228, 40);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblNumber;
        private System.Windows.Forms.Label LblAnswer;
        private System.Windows.Forms.ProgressBar PBAmount;
        private System.Windows.Forms.Label LblAmount;
    }
}
