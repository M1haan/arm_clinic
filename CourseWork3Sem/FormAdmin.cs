using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseWork3Sem
{
    public partial class FormAdmin : Form
    {
        private WorkingWithDB DB = new WorkingWithDB();
        private string filePath;
        public FormAdmin()
        {
            InitializeComponent();         
           
            filePath = DB.GetFileNameForOldPatient();
            DB.OpenOrCreatFile(filePath);

            WorkingWithDB.IsAdmin = true;
            List<OldPatien> oldPatiens = DB.ReadAllFromDB<OldPatien>();
            if (oldPatiens != null) 
                oldPatiens.Sort();

            if (oldPatiens.Count == 0)
                listBoxPatient.Items.Add("Пациенты отсутствуют");
            foreach (var oldPatien in oldPatiens)
            {
                listBoxPatient.Items.Add(oldPatien);
            }    
                
            filePath = DB.GetFileNameForPatient();
            DB.OpenOrCreatFile(filePath);

            List<Patient> patients = DB.ReadAllFromDB<Patient>();
            if (patients != null)
                patients.Sort();           

            if (patients.Count == 0)
                listBoxOnlineQueue.Items.Add("Пациенты отсутствуют");
            foreach (var patient in patients)
                listBoxOnlineQueue.Items.Add(patient);
        }

        private void btnReturnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddPatient_Click(object sender, EventArgs e)
        {
            if(txtPatientName.Text.Length == 0)
            {
                MessageBox.Show("Пустое поле \"Имя пациента\"");
                return;
            }

            //if(txtDoctor.Text.Length == 0)
            //{
            //    MessageBox.Show("Пустое поле \"Врач\"");
            //    return;
            //}

            //if(txtDoctor.Text.Length < 5)
            //{
            //    MessageBox.Show("Некорректное поле \"Врач\"");
            //    return;
            //}

            if (txtDiagnosis.Text.Length < 2)// исправить
            {
                MessageBox.Show("Некорректное поле \"Жалобы\"");
                return;
            }


            filePath = DB.GetFileNameForPatient();
            DB.OpenOrCreatFile(filePath);
            Patient newPatient;

            try 
            {
                newPatient = new Patient(txtPatientName.Text, txtDoctor.Text, txtDiagnosis.Text, dateTimePickerPublicationData.Text, "");
            }
            catch
            {
                MessageBox.Show("Некорректные данные");
                return;
            }

            DB.SaveToDB<Patient>(newPatient);

            filePath = DB.GetFileNameForAvailablePatients();
            DB.OpenOrCreatFile(filePath);
            DB.SaveToDB<Patient>(newPatient);

            listBoxOnlineQueue.Items.Add(newPatient);

            txtPatientName.Text = "";
            //txtDoctor.Text = "";
        }

        private void FormAdmin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form MainForm = Application.OpenForms[0];
            MainForm.Show();
        }

        private void btnAddPatientsFromFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Open Clinic File";
            openFileDialog.Filter = "Clinic files|*.txt";
            openFileDialog.InitialDirectory = @"C:";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {

                List<Patient> externalPatients;
                try
                {
                    DB.OpenOrCreatFile(openFileDialog.FileName);
                    externalPatients = DB.ReadAllFromDB<Patient>();
                }
                catch
                {
                    MessageBox.Show("Некорректные данные в файле");
                    return;
                }
                
                if (externalPatients[0].NamePatient == null || externalPatients[0].Doctor == null)
                {
                    MessageBox.Show("Некорректные данные в файле");
                    return;
                }
             
                if (externalPatients.Count == 0)
                {
                    MessageBox.Show("Пустой файл");
                    return;
                }

                DB.DeletFile(openFileDialog.FileName);

                DB.OpenOrCreatFile(DB.GetFileNameForPatient());
                List<Patient> allPatients = DB.ReadAllFromDB<Patient>();
                allPatients.AddRange(externalPatients);

                DB.SaveToDB<Patient>(allPatients);

                DB.OpenOrCreatFile(DB.GetFileNameForAvailablePatients());
                List<Patient> availablePatients = DB.ReadAllFromDB<Patient>();
                availablePatients.AddRange(externalPatients);

                DB.SaveToDB<Patient>(availablePatients);

                foreach (var patient in externalPatients)
                    listBoxOnlineQueue.Items.Add(patient);
            }
        }
    }
}
