namespace TeamNRE_SeniorProject
{
    partial class UserHome
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
            this.label2 = new System.Windows.Forms.Label();
            this.addTimeBtn = new System.Windows.Forms.Button();
            this.burndownBtn = new System.Windows.Forms.Button();
            this.quitBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(96, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(312, 36);
            this.label2.TabIndex = 5;
            this.label2.Text = "Developer Home Page";
            // 
            // addTimeBtn
            // 
            this.addTimeBtn.Location = new System.Drawing.Point(12, 59);
            this.addTimeBtn.Name = "addTimeBtn";
            this.addTimeBtn.Size = new System.Drawing.Size(153, 68);
            this.addTimeBtn.TabIndex = 8;
            this.addTimeBtn.Text = "Input / Edit Time Worked";
            this.addTimeBtn.UseVisualStyleBackColor = true;
            this.addTimeBtn.Click += new System.EventHandler(this.addTimeBtn_Click);
            // 
            // burndownBtn
            // 
            this.burndownBtn.Location = new System.Drawing.Point(351, 59);
            this.burndownBtn.Name = "burndownBtn";
            this.burndownBtn.Size = new System.Drawing.Size(140, 68);
            this.burndownBtn.TabIndex = 9;
            this.burndownBtn.Text = "View Burndown Chart";
            this.burndownBtn.UseVisualStyleBackColor = true;
            this.burndownBtn.Click += new System.EventHandler(this.burndownBtn_Click);
            // 
            // quitBtn
            // 
            this.quitBtn.Location = new System.Drawing.Point(180, 147);
            this.quitBtn.Name = "quitBtn";
            this.quitBtn.Size = new System.Drawing.Size(140, 51);
            this.quitBtn.TabIndex = 11;
            this.quitBtn.Text = "Quit";
            this.quitBtn.UseVisualStyleBackColor = true;
            this.quitBtn.Click += new System.EventHandler(this.quitBtn_Click);
            // 
            // UserHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 220);
            this.ControlBox = false;
            this.Controls.Add(this.quitBtn);
            this.Controls.Add(this.burndownBtn);
            this.Controls.Add(this.addTimeBtn);
            this.Controls.Add(this.label2);
            this.Name = "UserHome";
            this.Text = "Developer Home Page";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button addTimeBtn;
        private System.Windows.Forms.Button burndownBtn;
        private System.Windows.Forms.Button quitBtn;
    }
}