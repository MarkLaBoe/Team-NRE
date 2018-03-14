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
            this.label3 = new System.Windows.Forms.Label();
            this.projectCbx = new System.Windows.Forms.ComboBox();
            this.addTimeBtn = new System.Windows.Forms.Button();
            this.burndownBtn = new System.Windows.Forms.Button();
            this.editTimeBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(122, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(312, 36);
            this.label2.TabIndex = 5;
            this.label2.Text = "Developer Home Page";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Project:";
            // 
            // projectCbx
            // 
            this.projectCbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.projectCbx.FormattingEnabled = true;
            this.projectCbx.Location = new System.Drawing.Point(117, 62);
            this.projectCbx.Name = "projectCbx";
            this.projectCbx.Size = new System.Drawing.Size(415, 33);
            this.projectCbx.TabIndex = 6;
            // 
            // addTimeBtn
            // 
            this.addTimeBtn.Location = new System.Drawing.Point(52, 127);
            this.addTimeBtn.Name = "addTimeBtn";
            this.addTimeBtn.Size = new System.Drawing.Size(140, 38);
            this.addTimeBtn.TabIndex = 8;
            this.addTimeBtn.Text = "Add Time";
            this.addTimeBtn.UseVisualStyleBackColor = true;
            // 
            // burndownBtn
            // 
            this.burndownBtn.Location = new System.Drawing.Point(168, 194);
            this.burndownBtn.Name = "burndownBtn";
            this.burndownBtn.Size = new System.Drawing.Size(211, 38);
            this.burndownBtn.TabIndex = 9;
            this.burndownBtn.Text = "View Burndown Chart";
            this.burndownBtn.UseVisualStyleBackColor = true;
            // 
            // editTimeBtn
            // 
            this.editTimeBtn.Location = new System.Drawing.Point(351, 127);
            this.editTimeBtn.Name = "editTimeBtn";
            this.editTimeBtn.Size = new System.Drawing.Size(140, 38);
            this.editTimeBtn.TabIndex = 10;
            this.editTimeBtn.Text = "Edit Time";
            this.editTimeBtn.UseVisualStyleBackColor = true;
            // 
            // UserHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1120, 583);
            this.Controls.Add(this.editTimeBtn);
            this.Controls.Add(this.burndownBtn);
            this.Controls.Add(this.addTimeBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.projectCbx);
            this.Controls.Add(this.label2);
            this.Name = "UserHome";
            this.Text = "Developer Home Page";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox projectCbx;
        private System.Windows.Forms.Button addTimeBtn;
        private System.Windows.Forms.Button burndownBtn;
        private System.Windows.Forms.Button editTimeBtn;
    }
}