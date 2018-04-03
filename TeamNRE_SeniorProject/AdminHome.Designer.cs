namespace TeamNRE_SeniorProject
{
    partial class AdminHome
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
            this.projectCbx = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.burndownBtn = new System.Windows.Forms.Button();
            this.deleteProjectBtn = new System.Windows.Forms.Button();
            this.addProjectBtn = new System.Windows.Forms.Button();
            this.quitBtn = new System.Windows.Forms.Button();
            this.editProjectBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // projectCbx
            // 
            this.projectCbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.projectCbx.FormattingEnabled = true;
            this.projectCbx.Items.AddRange(new object[] {
            "",
            "Project",
            "Project 2",
            "Project 3",
            "Project 4",
            "Project 8"});
            this.projectCbx.Location = new System.Drawing.Point(96, 71);
            this.projectCbx.Name = "projectCbx";
            this.projectCbx.Size = new System.Drawing.Size(415, 33);
            this.projectCbx.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Project:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(133, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(321, 36);
            this.label2.TabIndex = 2;
            this.label2.Text = "Supervisor Home Page";
            // 
            // burndownBtn
            // 
            this.burndownBtn.Location = new System.Drawing.Point(550, 180);
            this.burndownBtn.Name = "burndownBtn";
            this.burndownBtn.Size = new System.Drawing.Size(140, 50);
            this.burndownBtn.TabIndex = 6;
            this.burndownBtn.Text = "View Burndown Chart";
            this.burndownBtn.UseVisualStyleBackColor = true;
            this.burndownBtn.Click += new System.EventHandler(this.burndownBtn_Click);
            // 
            // deleteProjectBtn
            // 
            this.deleteProjectBtn.Location = new System.Drawing.Point(550, 124);
            this.deleteProjectBtn.Name = "deleteProjectBtn";
            this.deleteProjectBtn.Size = new System.Drawing.Size(140, 50);
            this.deleteProjectBtn.TabIndex = 8;
            this.deleteProjectBtn.Text = "Delete Project";
            this.deleteProjectBtn.UseVisualStyleBackColor = true;
            this.deleteProjectBtn.Click += new System.EventHandler(this.deleteProjectBtn_Click);
            // 
            // addProjectBtn
            // 
            this.addProjectBtn.Location = new System.Drawing.Point(550, 12);
            this.addProjectBtn.Name = "addProjectBtn";
            this.addProjectBtn.Size = new System.Drawing.Size(140, 50);
            this.addProjectBtn.TabIndex = 9;
            this.addProjectBtn.Text = "Add Project";
            this.addProjectBtn.UseVisualStyleBackColor = true;
            this.addProjectBtn.Click += new System.EventHandler(this.addProjectBtn_Click);
            // 
            // quitBtn
            // 
            this.quitBtn.Location = new System.Drawing.Point(550, 236);
            this.quitBtn.Name = "quitBtn";
            this.quitBtn.Size = new System.Drawing.Size(140, 50);
            this.quitBtn.TabIndex = 10;
            this.quitBtn.Text = "Quit";
            this.quitBtn.UseVisualStyleBackColor = true;
            this.quitBtn.Click += new System.EventHandler(this.quitBtn_Click);
            // 
            // editProjectBtn
            // 
            this.editProjectBtn.Location = new System.Drawing.Point(550, 68);
            this.editProjectBtn.Name = "editProjectBtn";
            this.editProjectBtn.Size = new System.Drawing.Size(140, 50);
            this.editProjectBtn.TabIndex = 11;
            this.editProjectBtn.Text = "Edit Project";
            this.editProjectBtn.UseVisualStyleBackColor = true;
            this.editProjectBtn.Click += new System.EventHandler(this.editProjectBtn_Click);
            // 
            // AdminHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 298);
            this.ControlBox = false;
            this.Controls.Add(this.editProjectBtn);
            this.Controls.Add(this.quitBtn);
            this.Controls.Add(this.addProjectBtn);
            this.Controls.Add(this.deleteProjectBtn);
            this.Controls.Add(this.burndownBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.projectCbx);
            this.Name = "AdminHome";
            this.Text = "Supervisor Home Page";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox projectCbx;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button burndownBtn;
        private System.Windows.Forms.Button deleteProjectBtn;
        private System.Windows.Forms.Button addProjectBtn;
        private System.Windows.Forms.Button quitBtn;
        private System.Windows.Forms.Button editProjectBtn;
    }
}