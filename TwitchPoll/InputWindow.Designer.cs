namespace TwitchPoll
{
    partial class InputWindow
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
            this.BtnDone = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.LblInputQuestion = new System.Windows.Forms.Label();
            this.TxbAnswer = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.NumAnswers = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.NumAnswers)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnDone
            // 
            this.BtnDone.Location = new System.Drawing.Point(118, 189);
            this.BtnDone.Name = "BtnDone";
            this.BtnDone.Size = new System.Drawing.Size(97, 23);
            this.BtnDone.TabIndex = 0;
            this.BtnDone.Text = "Done";
            this.BtnDone.UseVisualStyleBackColor = true;
            this.BtnDone.Click += new System.EventHandler(this.BtnDone_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.Location = new System.Drawing.Point(12, 189);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(100, 23);
            this.BtnCancel.TabIndex = 1;
            this.BtnCancel.Text = "Cancel";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // LblInputQuestion
            // 
            this.LblInputQuestion.AutoSize = true;
            this.LblInputQuestion.Location = new System.Drawing.Point(65, 24);
            this.LblInputQuestion.Name = "LblInputQuestion";
            this.LblInputQuestion.Size = new System.Drawing.Size(89, 17);
            this.LblInputQuestion.TabIndex = 2;
            this.LblInputQuestion.Text = "Poll question";
            // 
            // TxbAnswer
            // 
            this.TxbAnswer.Location = new System.Drawing.Point(12, 44);
            this.TxbAnswer.Name = "TxbAnswer";
            this.TxbAnswer.Size = new System.Drawing.Size(204, 22);
            this.TxbAnswer.TabIndex = 3;
            this.TxbAnswer.TextChanged += new System.EventHandler(this.TxbAnswer_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Poll answer count";
            // 
            // NumAnswers
            // 
            this.NumAnswers.Location = new System.Drawing.Point(12, 114);
            this.NumAnswers.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.NumAnswers.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumAnswers.Name = "NumAnswers";
            this.NumAnswers.Size = new System.Drawing.Size(204, 22);
            this.NumAnswers.TabIndex = 7;
            this.NumAnswers.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // InputWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(228, 224);
            this.Controls.Add(this.NumAnswers);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxbAnswer);
            this.Controls.Add(this.LblInputQuestion);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnDone);
            this.Name = "InputWindow";
            this.Text = "InputWindow";
            ((System.ComponentModel.ISupportInitialize)(this.NumAnswers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnDone;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.Label LblInputQuestion;
        private System.Windows.Forms.TextBox TxbAnswer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown NumAnswers;
    }
}