namespace TeamNRE_SeniorProject
{
    partial class AddEditTime
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
            this.label1 = new System.Windows.Forms.Label();
            this.taskCbx = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.hoursWorkedTxt = new System.Windows.Forms.TextBox();
            this.saveHoursBtn = new System.Windows.Forms.Button();
            this.clearAllButton = new System.Windows.Forms.Button();
            this.returnHomeBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 25);
            this.label1.TabIndex = 12;
            this.label1.Text = "Task:";
            // 
            // taskCbx
            // 
            this.taskCbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taskCbx.FormattingEnabled = true;
            this.taskCbx.Location = new System.Drawing.Point(80, 16);
            this.taskCbx.Name = "taskCbx";
            this.taskCbx.Size = new System.Drawing.Size(425, 33);
            this.taskCbx.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(75, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 25);
            this.label2.TabIndex = 14;
            this.label2.Text = "Hours Worked:";
            // 
            // hoursWorkedTxt
            // 
            this.hoursWorkedTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hoursWorkedTxt.Location = new System.Drawing.Point(228, 133);
            this.hoursWorkedTxt.Name = "hoursWorkedTxt";
            this.hoursWorkedTxt.Size = new System.Drawing.Size(100, 30);
            this.hoursWorkedTxt.TabIndex = 15;
            // 
            // saveHoursBtn
            // 
            this.saveHoursBtn.Location = new System.Drawing.Point(17, 241);
            this.saveHoursBtn.Name = "saveHoursBtn";
            this.saveHoursBtn.Size = new System.Drawing.Size(140, 40);
            this.saveHoursBtn.TabIndex = 16;
            this.saveHoursBtn.Text = "Save Hours";
            this.saveHoursBtn.UseVisualStyleBackColor = true;
            // 
            // clearAllButton
            // 
            this.clearAllButton.Location = new System.Drawing.Point(228, 172);
            this.clearAllButton.Name = "clearAllButton";
            this.clearAllButton.Size = new System.Drawing.Size(100, 38);
            this.clearAllButton.TabIndex = 17;
            this.clearAllButton.Text = "Clear All";
            this.clearAllButton.UseVisualStyleBackColor = true;
            this.clearAllButton.Click += new System.EventHandler(this.clearAllButton_Click);
            // 
            // returnHomeBtn
            // 
            this.returnHomeBtn.Location = new System.Drawing.Point(365, 241);
            this.returnHomeBtn.Name = "returnHomeBtn";
            this.returnHomeBtn.Size = new System.Drawing.Size(140, 40);
            this.returnHomeBtn.TabIndex = 18;
            this.returnHomeBtn.Text = "Return Home";
            this.returnHomeBtn.UseVisualStyleBackColor = true;
            this.returnHomeBtn.Click += new System.EventHandler(this.returnHomeBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(75, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 25);
            this.label4.TabIndex = 20;
            this.label4.Text = "Total Hours:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(256, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 25);
            this.label5.TabIndex = 22;
            this.label5.Text = "---";
            // 
            // AddEditTime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 315);
            this.ControlBox = false;
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.returnHomeBtn);
            this.Controls.Add(this.clearAllButton);
            this.Controls.Add(this.saveHoursBtn);
            this.Controls.Add(this.hoursWorkedTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.taskCbx);
            this.Name = "AddEditTime";
            this.Text = "Input / Edit Time";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox taskCbx;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox hoursWorkedTxt;
        private System.Windows.Forms.Button saveHoursBtn;
        private System.Windows.Forms.Button clearAllButton;
        private System.Windows.Forms.Button returnHomeBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}