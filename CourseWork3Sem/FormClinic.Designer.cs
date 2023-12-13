namespace CourseWork3Sem
{
    partial class FormClinic
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
            this.btnReturnBack = new System.Windows.Forms.Button();
            this.listBoxPatientList = new System.Windows.Forms.ListBox();
            this.btnTakePatiens = new System.Windows.Forms.Button();
            this.listBoxOldPatienList = new System.Windows.Forms.ListBox();
            this.btnReturnPatient = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnReturnBack
            // 
            this.btnReturnBack.Location = new System.Drawing.Point(487, 304);
            this.btnReturnBack.Margin = new System.Windows.Forms.Padding(2);
            this.btnReturnBack.Name = "btnReturnBack";
            this.btnReturnBack.Size = new System.Drawing.Size(68, 29);
            this.btnReturnBack.TabIndex = 0;
            this.btnReturnBack.Text = "Выйти";
            this.btnReturnBack.UseVisualStyleBackColor = true;
            this.btnReturnBack.Click += new System.EventHandler(this.btnReturnBack_Click);
            // 
            // listBoxPatientList
            // 
            this.listBoxPatientList.FormattingEnabled = true;
            this.listBoxPatientList.HorizontalScrollbar = true;
            this.listBoxPatientList.Location = new System.Drawing.Point(20, 55);
            this.listBoxPatientList.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxPatientList.Name = "listBoxPatientList";
            this.listBoxPatientList.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.listBoxPatientList.ScrollAlwaysVisible = true;
            this.listBoxPatientList.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBoxPatientList.Size = new System.Drawing.Size(243, 173);
            this.listBoxPatientList.TabIndex = 1;
            // 
            // btnTakePatiens
            // 
            this.btnTakePatiens.Location = new System.Drawing.Point(45, 252);
            this.btnTakePatiens.Margin = new System.Windows.Forms.Padding(2);
            this.btnTakePatiens.Name = "btnTakePatiens";
            this.btnTakePatiens.Size = new System.Drawing.Size(130, 44);
            this.btnTakePatiens.TabIndex = 2;
            this.btnTakePatiens.Text = "Выбрать время";
            this.btnTakePatiens.UseVisualStyleBackColor = true;
            this.btnTakePatiens.Click += new System.EventHandler(this.btnTakePatients_Click);
            // 
            // listBoxOldPatienList
            // 
            this.listBoxOldPatienList.FormattingEnabled = true;
            this.listBoxOldPatienList.HorizontalScrollbar = true;
            this.listBoxOldPatienList.Location = new System.Drawing.Point(308, 55);
            this.listBoxOldPatienList.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxOldPatienList.Name = "listBoxOldPatienList";
            this.listBoxOldPatienList.ScrollAlwaysVisible = true;
            this.listBoxOldPatienList.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBoxOldPatienList.Size = new System.Drawing.Size(528, 173);
            this.listBoxOldPatienList.TabIndex = 3;
            // 
            // btnReturnPatient
            // 
            this.btnReturnPatient.Location = new System.Drawing.Point(308, 252);
            this.btnReturnPatient.Margin = new System.Windows.Forms.Padding(2);
            this.btnReturnPatient.Name = "btnReturnPatient";
            this.btnReturnPatient.Size = new System.Drawing.Size(130, 44);
            this.btnReturnPatient.TabIndex = 4;
            this.btnReturnPatient.Text = "Отменить запись";
            this.btnReturnPatient.UseVisualStyleBackColor = true;
            this.btnReturnPatient.Click += new System.EventHandler(this.btnReturnPatients_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Свободное время работы";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(305, 27);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(204, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Время на которое записаны пациенты";
            // 
            // FormClinic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 343);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnReturnPatient);
            this.Controls.Add(this.listBoxOldPatienList);
            this.Controls.Add(this.btnTakePatiens);
            this.Controls.Add(this.listBoxPatientList);
            this.Controls.Add(this.btnReturnBack);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormClinic";
            this.Text = "Поликлиника";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormClinic_FormClosing);
            this.Load += new System.EventHandler(this.FormClinic_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReturnBack;
        private System.Windows.Forms.ListBox listBoxPatientList;
        private System.Windows.Forms.Button btnTakePatiens;
        private System.Windows.Forms.ListBox listBoxOldPatienList;
        private System.Windows.Forms.Button btnReturnPatient;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}