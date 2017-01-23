namespace TwitchPoll
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
            this.PnlQuestions = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.LblConnected = new System.Windows.Forms.Label();
            this.TxbUsername = new System.Windows.Forms.TextBox();
            this.TxbAutoKey = new System.Windows.Forms.TextBox();
            this.BtnConnect = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.TxbQuestion = new System.Windows.Forms.TextBox();
            this.BtnNewQuestion = new System.Windows.Forms.Button();
            this.NumAnswers = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnStart = new System.Windows.Forms.Button();
            this.BtnStop = new System.Windows.Forms.Button();
            this.BtnUpdate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.NumAnswers)).BeginInit();
            this.SuspendLayout();
            // 
            // PnlQuestions
            // 
            this.PnlQuestions.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PnlQuestions.Dock = System.Windows.Forms.DockStyle.Right;
            this.PnlQuestions.Location = new System.Drawing.Point(297, 0);
            this.PnlQuestions.Name = "PnlQuestions";
            this.PnlQuestions.Size = new System.Drawing.Size(257, 294);
            this.PnlQuestions.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(80, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Current question:";
            // 
            // LblConnected
            // 
            this.LblConnected.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblConnected.Location = new System.Drawing.Point(48, 157);
            this.LblConnected.Name = "LblConnected";
            this.LblConnected.Size = new System.Drawing.Size(204, 28);
            this.LblConnected.TabIndex = 6;
            this.LblConnected.Text = "Connect to twitch chat";
            this.LblConnected.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TxbUsername
            // 
            this.TxbUsername.Location = new System.Drawing.Point(12, 188);
            this.TxbUsername.Name = "TxbUsername";
            this.TxbUsername.Size = new System.Drawing.Size(275, 22);
            this.TxbUsername.TabIndex = 7;
            this.TxbUsername.Text = "Twitch Username";
            // 
            // TxbAutoKey
            // 
            this.TxbAutoKey.Location = new System.Drawing.Point(13, 226);
            this.TxbAutoKey.Name = "TxbAutoKey";
            this.TxbAutoKey.Size = new System.Drawing.Size(274, 22);
            this.TxbAutoKey.TabIndex = 8;
            this.TxbAutoKey.Text = "OAuth token";
            // 
            // BtnConnect
            // 
            this.BtnConnect.Location = new System.Drawing.Point(113, 254);
            this.BtnConnect.Name = "BtnConnect";
            this.BtnConnect.Size = new System.Drawing.Size(75, 23);
            this.BtnConnect.TabIndex = 9;
            this.BtnConnect.Text = "Connect";
            this.BtnConnect.UseVisualStyleBackColor = true;
            this.BtnConnect.Click += new System.EventHandler(this.BtnConnect_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(231, 259);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 17);
            this.label2.TabIndex = 10;
            // 
            // TxbQuestion
            // 
            this.TxbQuestion.Location = new System.Drawing.Point(13, 41);
            this.TxbQuestion.Name = "TxbQuestion";
            this.TxbQuestion.Size = new System.Drawing.Size(278, 22);
            this.TxbQuestion.TabIndex = 11;
            // 
            // BtnNewQuestion
            // 
            this.BtnNewQuestion.Location = new System.Drawing.Point(199, 81);
            this.BtnNewQuestion.Name = "BtnNewQuestion";
            this.BtnNewQuestion.Size = new System.Drawing.Size(92, 58);
            this.BtnNewQuestion.TabIndex = 14;
            this.BtnNewQuestion.Text = "New Question";
            this.BtnNewQuestion.UseVisualStyleBackColor = true;
            this.BtnNewQuestion.Click += new System.EventHandler(this.BtnNewQuestion_Click);
            // 
            // NumAnswers
            // 
            this.NumAnswers.Location = new System.Drawing.Point(13, 101);
            this.NumAnswers.Maximum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.NumAnswers.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.NumAnswers.Name = "NumAnswers";
            this.NumAnswers.Size = new System.Drawing.Size(127, 22);
            this.NumAnswers.TabIndex = 15;
            this.NumAnswers.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.NumAnswers.ValueChanged += new System.EventHandler(this.NumAnswers_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 17);
            this.label3.TabIndex = 16;
            this.label3.Text = "Amount of answers";
            // 
            // BtnStart
            // 
            this.BtnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnStart.Location = new System.Drawing.Point(13, 216);
            this.BtnStart.Name = "BtnStart";
            this.BtnStart.Size = new System.Drawing.Size(76, 69);
            this.BtnStart.TabIndex = 0;
            this.BtnStart.Text = "Start";
            this.BtnStart.UseVisualStyleBackColor = true;
            this.BtnStart.Visible = false;
            this.BtnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // BtnStop
            // 
            this.BtnStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnStop.Location = new System.Drawing.Point(211, 216);
            this.BtnStop.Name = "BtnStop";
            this.BtnStop.Size = new System.Drawing.Size(76, 69);
            this.BtnStop.TabIndex = 17;
            this.BtnStop.Text = "Stop";
            this.BtnStop.UseVisualStyleBackColor = true;
            this.BtnStop.Visible = false;
            this.BtnStop.Click += new System.EventHandler(this.BtnStop_Click);
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnUpdate.Location = new System.Drawing.Point(95, 216);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(110, 69);
            this.BtnUpdate.TabIndex = 18;
            this.BtnUpdate.Text = "Update";
            this.BtnUpdate.UseVisualStyleBackColor = true;
            this.BtnUpdate.Visible = false;
            this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(554, 294);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.NumAnswers);
            this.Controls.Add(this.BtnNewQuestion);
            this.Controls.Add(this.TxbQuestion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtnConnect);
            this.Controls.Add(this.TxbAutoKey);
            this.Controls.Add(this.TxbUsername);
            this.Controls.Add(this.LblConnected);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PnlQuestions);
            this.Controls.Add(this.BtnStart);
            this.Controls.Add(this.BtnStop);
            this.Controls.Add(this.BtnUpdate);
            this.Name = "MainForm";
            this.Text = "TwitchPoll";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.NumAnswers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel PnlQuestions;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LblConnected;
        private System.Windows.Forms.TextBox TxbUsername;
        private System.Windows.Forms.TextBox TxbAutoKey;
        private System.Windows.Forms.Button BtnConnect;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxbQuestion;
        private System.Windows.Forms.Button BtnNewQuestion;
        private System.Windows.Forms.NumericUpDown NumAnswers;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnStart;
        private System.Windows.Forms.Button BtnStop;
        private System.Windows.Forms.Button BtnUpdate;
    }
}

