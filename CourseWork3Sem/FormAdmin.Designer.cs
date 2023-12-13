namespace CourseWork3Sem
{
    partial class FormAdmin
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
            this.listBoxOnlineQueue = new System.Windows.Forms.ListBox();
            this.btnAddPatientFromFile = new System.Windows.Forms.Button();
            this.listBoxPatient = new System.Windows.Forms.ListBox();
            this.btnReturnBack = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPatientName = new System.Windows.Forms.TextBox();
            this.txtDoctor = new System.Windows.Forms.TextBox();
            this.btnAddPatient = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePickerPublicationData = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDiagnosis = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBoxOnlineQueue
            // 
            this.listBoxOnlineQueue.FormattingEnabled = true;
            this.listBoxOnlineQueue.HorizontalScrollbar = true;
            this.listBoxOnlineQueue.Location = new System.Drawing.Point(11, 22);
            this.listBoxOnlineQueue.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxOnlineQueue.Name = "listBoxOnlineQueue";
            this.listBoxOnlineQueue.ScrollAlwaysVisible = true;
            this.listBoxOnlineQueue.Size = new System.Drawing.Size(399, 290);
            this.listBoxOnlineQueue.TabIndex = 0;
            // 
            // btnAddPatientFromFile
            // 
            this.btnAddPatientFromFile.Location = new System.Drawing.Point(540, 344);
            this.btnAddPatientFromFile.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddPatientFromFile.Name = "btnAddPatientFromFile";
            this.btnAddPatientFromFile.Size = new System.Drawing.Size(164, 26);
            this.btnAddPatientFromFile.TabIndex = 1;
            this.btnAddPatientFromFile.Text = "Загрузить из файла";
            this.btnAddPatientFromFile.UseVisualStyleBackColor = true;
            this.btnAddPatientFromFile.Click += new System.EventHandler(this.btnAddPatientsFromFile_Click);
            // 
            // listBoxPatient
            // 
            this.listBoxPatient.FormattingEnabled = true;
            this.listBoxPatient.HorizontalScrollbar = true;
            this.listBoxPatient.Location = new System.Drawing.Point(424, 22);
            this.listBoxPatient.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxPatient.Name = "listBoxPatient";
            this.listBoxPatient.ScrollAlwaysVisible = true;
            this.listBoxPatient.Size = new System.Drawing.Size(399, 290);
            this.listBoxPatient.TabIndex = 3;
            // 
            // btnReturnBack
            // 
            this.btnReturnBack.Location = new System.Drawing.Point(540, 401);
            this.btnReturnBack.Margin = new System.Windows.Forms.Padding(2);
            this.btnReturnBack.Name = "btnReturnBack";
            this.btnReturnBack.Size = new System.Drawing.Size(164, 24);
            this.btnReturnBack.TabIndex = 4;
            this.btnReturnBack.Text = "Выйти";
            this.btnReturnBack.UseVisualStyleBackColor = true;
            this.btnReturnBack.Click += new System.EventHandler(this.btnReturnBack_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(460, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Распределенные пациенты";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 7);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Люди в онлайн очереди";
            // 
            // txtPatientName
            // 
            this.txtPatientName.Location = new System.Drawing.Point(21, 348);
            this.txtPatientName.Margin = new System.Windows.Forms.Padding(2);
            this.txtPatientName.Name = "txtPatientName";
            this.txtPatientName.Size = new System.Drawing.Size(108, 20);
            this.txtPatientName.TabIndex = 8;
            // 
            // txtDoctor
            // 
            this.txtDoctor.Location = new System.Drawing.Point(374, 558);
            this.txtDoctor.Margin = new System.Windows.Forms.Padding(2);
            this.txtDoctor.Name = "txtDoctor";
            this.txtDoctor.Size = new System.Drawing.Size(115, 20);
            this.txtDoctor.TabIndex = 9;
            // 
            // btnAddPatient
            // 
            this.btnAddPatient.Location = new System.Drawing.Point(21, 400);
            this.btnAddPatient.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddPatient.Name = "btnAddPatient";
            this.btnAddPatient.Size = new System.Drawing.Size(389, 25);
            this.btnAddPatient.TabIndex = 10;
            this.btnAddPatient.Text = "Добавить пациента";
            this.btnAddPatient.UseVisualStyleBackColor = true;
            this.btnAddPatient.Click += new System.EventHandler(this.btnAddPatient_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 328);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Имя";
            // 
            // dateTimePickerPublicationData
            // 
            this.dateTimePickerPublicationData.Location = new System.Drawing.Point(284, 348);
            this.dateTimePickerPublicationData.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePickerPublicationData.Name = "dateTimePickerPublicationData";
            this.dateTimePickerPublicationData.Size = new System.Drawing.Size(114, 20);
            this.dateTimePickerPublicationData.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(281, 328);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Дата обращения";
            // 
            // txtDiagnosis
            // 
            this.txtDiagnosis.Location = new System.Drawing.Point(151, 348);
            this.txtDiagnosis.Margin = new System.Windows.Forms.Padding(2);
            this.txtDiagnosis.Name = "txtDiagnosis";
            this.txtDiagnosis.Size = new System.Drawing.Size(115, 20);
            this.txtDiagnosis.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(148, 328);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Жалобы";
            // 
            // FormAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 550);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtDiagnosis);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateTimePickerPublicationData);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnAddPatient);
            this.Controls.Add(this.txtDoctor);
            this.Controls.Add(this.txtPatientName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnReturnBack);
            this.Controls.Add(this.listBoxPatient);
            this.Controls.Add(this.btnAddPatientFromFile);
            this.Controls.Add(this.listBoxOnlineQueue);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormAdmin";
            this.Text = "Администратор";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormAdmin_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxOnlineQueue;
        private System.Windows.Forms.Button btnAddPatientFromFile;
        private System.Windows.Forms.ListBox listBoxPatient;
        private System.Windows.Forms.Button btnReturnBack;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPatientName;
        private System.Windows.Forms.TextBox txtDoctor;
        private System.Windows.Forms.Button btnAddPatient;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePickerPublicationData;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDiagnosis;
        private System.Windows.Forms.Label label6;
    }
}