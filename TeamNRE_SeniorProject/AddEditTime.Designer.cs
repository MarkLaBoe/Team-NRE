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
            this.label3 = new System.Windows.Forms.Label();
            this.projectCbx = new System.Windows.Forms.ComboBox();
            this.selectProjectBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.taskCbx = new System.Windows.Forms.ComboBox();
            this.selectTaskBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.hoursTxt = new System.Windows.Forms.TextBox();
            this.saveHoursBtn = new System.Windows.Forms.Button();
            this.clearAllButton = new System.Windows.Forms.Button();
            this.returnHomeBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 25);
            this.label3.TabIndex = 9;
            this.label3.Text = "Project:";
            // 
            // projectCbx
            // 
            this.projectCbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.projectCbx.FormattingEnabled = true;
            this.projectCbx.Location = new System.Drawing.Point(108, 16);
            this.projectCbx.Name = "projectCbx";
            this.projectCbx.Size = new System.Drawing.Size(415, 33);
            this.projectCbx.TabIndex = 8;
            // 
            // selectProjectBtn
            // 
            this.selectProjectBtn.Location = new System.Drawing.Point(540, 18);
            this.selectProjectBtn.Name = "selectProjectBtn";
            this.selectProjectBtn.Size = new System.Drawing.Size(140, 33);
            this.selectProjectBtn.TabIndex = 10;
            this.selectProjectBtn.Text = "Select Project";
            this.selectProjectBtn.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 25);
            this.label1.TabIndex = 12;
            this.label1.Text = "Task:";
            // 
            // taskCbx
            // 
            this.taskCbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taskCbx.FormattingEnabled = true;
            this.taskCbx.Location = new System.Drawing.Point(108, 92);
            this.taskCbx.Name = "taskCbx";
            this.taskCbx.Size = new System.Drawing.Size(415, 33);
            this.taskCbx.TabIndex = 11;
            // 
            // selectTaskBtn
            // 
            this.selectTaskBtn.Location = new System.Drawing.Point(540, 94);
            this.selectTaskBtn.Name = "selectTaskBtn";
            this.selectTaskBtn.Size = new System.Drawing.Size(140, 33);
            this.selectTaskBtn.TabIndex = 13;
            this.selectTaskBtn.Text = "Select Task";
            this.selectTaskBtn.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 189);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 25);
            this.label2.TabIndex = 14;
            this.label2.Text = "Hours Worked:";
            // 
            // hoursTxt
            // 
            this.hoursTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hoursTxt.Location = new System.Drawing.Point(162, 186);
            this.hoursTxt.Name = "hoursTxt";
            this.hoursTxt.Size = new System.Drawing.Size(100, 30);
            this.hoursTxt.TabIndex = 15;
            // 
            // saveHoursBtn
            // 
            this.saveHoursBtn.Location = new System.Drawing.Point(12, 284);
            this.saveHoursBtn.Name = "saveHoursBtn";
            this.saveHoursBtn.Size = new System.Drawing.Size(140, 33);
            this.saveHoursBtn.TabIndex = 16;
            this.saveHoursBtn.Text = "Save Hours";
            this.saveHoursBtn.UseVisualStyleBackColor = true;
            // 
            // clearAllButton
            // 
            this.clearAllButton.Location = new System.Drawing.Point(559, 284);
            this.clearAllButton.Name = "clearAllButton";
            this.clearAllButton.Size = new System.Drawing.Size(140, 33);
            this.clearAllButton.TabIndex = 17;
            this.clearAllButton.Text = "Clear All";
            this.clearAllButton.UseVisualStyleBackColor = true;
            // 
            // returnHomeBtn
            // 
            this.returnHomeBtn.Location = new System.Drawing.Point(297, 284);
            this.returnHomeBtn.Name = "returnHomeBtn";
            this.returnHomeBtn.Size = new System.Drawing.Size(140, 33);
            this.returnHomeBtn.TabIndex = 18;
            this.returnHomeBtn.Text = "Return Home";
            this.returnHomeBtn.UseVisualStyleBackColor = true;
            this.returnHomeBtn.Click += new System.EventHandler(this.returnHomeBtn_Click);
            // 
            // AddEditTime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 329);
            this.ControlBox = false;
            this.Controls.Add(this.returnHomeBtn);
            this.Controls.Add(this.clearAllButton);
            this.Controls.Add(this.saveHoursBtn);
            this.Controls.Add(this.hoursTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.selectTaskBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.taskCbx);
            this.Controls.Add(this.selectProjectBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.projectCbx);
            this.Name = "AddEditTime";
            this.Text = "Input / Edit Time";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox projectCbx;
        private System.Windows.Forms.Button selectProjectBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox taskCbx;
        private System.Windows.Forms.Button selectTaskBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox hoursTxt;
        private System.Windows.Forms.Button saveHoursBtn;
        private System.Windows.Forms.Button clearAllButton;
        private System.Windows.Forms.Button returnHomeBtn;
    }
}