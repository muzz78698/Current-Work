namespace WindowsFormsApplication4
{
    partial class Guesser
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
            this.button1 = new System.Windows.Forms.Button();
            this.txtEnterNumber = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.lblQuestion = new System.Windows.Forms.Label();
            this.lblGuessed = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(708, 305);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtEnterNumber
            // 
            this.txtEnterNumber.Location = new System.Drawing.Point(201, 139);
            this.txtEnterNumber.Name = "txtEnterNumber";
            this.txtEnterNumber.Size = new System.Drawing.Size(460, 22);
            this.txtEnterNumber.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(423, 180);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(147, 69);
            this.button2.TabIndex = 2;
            this.button2.Text = "Check";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.CheckNumber);
            // 
            // lblQuestion
            // 
            this.lblQuestion.AutoSize = true;
            this.lblQuestion.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestion.Location = new System.Drawing.Point(274, 83);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(230, 22);
            this.lblQuestion.TabIndex = 3;
            this.lblQuestion.Text = "I am thinking of a number of";
            // 
            // lblGuessed
            // 
            this.lblGuessed.AutoSize = true;
            this.lblGuessed.Location = new System.Drawing.Point(313, 327);
            this.lblGuessed.Name = "lblGuessed";
            this.lblGuessed.Size = new System.Drawing.Size(148, 17);
            this.lblGuessed.TabIndex = 4;
            this.lblGuessed.Text = "You Guessed 0 Times";
            // 
            // Guesser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApplication4.Properties.Resources.Guessnumber;
            this.ClientSize = new System.Drawing.Size(957, 397);
            this.Controls.Add(this.lblGuessed);
            this.Controls.Add(this.lblQuestion);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtEnterNumber);
            this.Controls.Add(this.button1);
            this.Name = "Guesser";
            this.Text = "Guesser";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtEnterNumber;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.Label lblGuessed;
    }
}