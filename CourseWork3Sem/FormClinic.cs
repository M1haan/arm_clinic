using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace CourseWork3Sem
{
    public partial class FormClinic : Form
    {
        FormAuthorization formAuthorization;
        WorkingWithDB DB = new WorkingWithDB();
       
        Doctor thisDoctor = null;
        OldPatien thisOldPatien = null;
        int indexOldPatien;

        public FormClinic(FormAuthorization owner)
        {
            InitializeComponent();
            formAuthorization = owner;

            string fileName = DB.GetFileNameForAvailablePatients();
            DB.OpenOrCreatFile(fileName);

            listBoxPatientList.ScrollAlwaysVisible = true;

            List<Patient> patients = DB.ReadAllFromDB<Patient>();
            if(patients != null)
                patients.Sort();

            if (patients.Count == 0)
                listBoxPatientList.Items.Add("Пациенты отсутствуют");

            for (int i = 0; i < patients.Count; i++)
                listBoxPatientList.Items.Add(patients[i]);


            DefineTheDoctor();

            formAuthorization.mtxtPhoneNumber.Text = "";
            formAuthorization.txtPassword.Text = "";



            if (DefineTheOldPatien() == true)
            {
                for (int i = 0; i < thisOldPatien.patients.Count; i++)
                {
                    thisOldPatien.patients[i].IsHeld();
                    listBoxOldPatienList.Items.Add(thisOldPatien.patients[i]);
                }
            }
               
        }

        private void DefineTheDoctor()
        {
            string fileName = DB.GetFileNameForDoctors();
            DB.OpenOrCreatFile(fileName);


            List<Doctor> doctors = DB.ReadAllFromDB<Doctor>();
            foreach (var doctor in doctors)
            {
                if (doctor.PhoneNumber == "+7" + formAuthorization.mtxtPhoneNumber.Text)
                {
                    thisDoctor = doctor;
                    break;
                }
            }
        }

        private bool DefineTheOldPatien()
        {
            string fileName = DB.GetFileNameForOldPatient();
            DB.OpenOrCreatFile(fileName);
            int i = 0;

            WorkingWithDB.IsAdmin = true;

            List<OldPatien> oldPatiens = DB.ReadAllFromDB<OldPatien>();
            foreach (var oldPatien in oldPatiens)
            {
                if (oldPatien.doctor.PhoneNumber == thisDoctor.PhoneNumber)
                {
                    thisOldPatien = oldPatien;
                    indexOldPatien = i;
                    break;
                }
                i++;
            }

            if (thisOldPatien != null)
                return true;
            else
                return false;
        }

        private void btnReturnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTakePatients_Click(object sender, EventArgs e)
        {
            if(listBoxPatientList.Items.Count == 0)
            {
                MessageBox.Show("Пациенты отсутствуют");
                return;
            }

            List<Patient> patients = listBoxPatientList.SelectedItems.Cast<Patient>().ToList<Patient>();

            if (patients.Count != 0)
            {
                if (patients.Count <= 5)
                {
                    string fileNameForOldPatients = DB.GetFileNameForOldPatient();
                    DB.OpenOrCreatFile(fileNameForOldPatients);

                    if (thisOldPatien != null)
                    {
                        for (int j = 0; j < thisOldPatien.patients.Count; j++)
                            patients.Add(thisOldPatien.patients[j]);

                        if (patients.Count > 5)
                        {
                            MessageBox.Show("Невозможно принять более 5 пациентов");
                            return;
                        }    

                        DB.DeletFromDB<OldPatien>(indexOldPatien);
                        listBoxOldPatienList.Items.Clear();
                    }
                    
                    DateTime PatientReturnDate = new DateTime();
                    PatientReturnDate = DateTime.Now.AddDays(7);
                    string PatientReturnDateToString = PatientReturnDate.ToString();
                    PatientReturnDateToString = DateTime.Parse(PatientReturnDateToString).ToShortDateString();

                    thisOldPatien = new OldPatien(thisDoctor, patients);

                    for (int i = 0; i < thisOldPatien.patients.Count; i++)
                    {
                        thisOldPatien.patients[i].IsHeld();
                        thisOldPatien.patients[i].ReturningDate = PatientReturnDateToString;
                        listBoxOldPatienList.Items.Add(thisOldPatien.patients[i]);
                    }

                    DB.SaveToDB<OldPatien>(thisOldPatien);

                    string fileNameForPatients = DB.GetFileNameForAvailablePatients();
                    DB.OpenOrCreatFile(fileNameForPatients);

                    for (int x = listBoxPatientList.SelectedIndices.Count; x > 0; x--)
                    {
                        DB.DeletFromDB<Patient>(listBoxPatientList.SelectedIndex);
                        listBoxPatientList.Items.RemoveAt(listBoxPatientList.SelectedIndex);
                    }
                }
                else
                    MessageBox.Show("Невозможно принять более 5 пациентов"); 
            }
            else
                MessageBox.Show("Вы ничего не выбрали");

        }

        private void btnReturnPatients_Click(object sender, EventArgs e)
        {
            if (listBoxOldPatienList.Items.Count == 0)
            {
                MessageBox.Show("У вас нет записей");
                return;
            }

            List<Patient> selectedPatients = listBoxOldPatienList.SelectedItems.Cast<Patient>().ToList<Patient>();
            List<Patient> remainingPatients;
            if (selectedPatients.Count != 0)
            {
                string fileNameForAvailablePatients = DB.GetFileNameForAvailablePatients();
                DB.OpenOrCreatFile(fileNameForAvailablePatients);

                for (int x = listBoxOldPatienList.SelectedIndices.Count; x > 0; x--)
                {
                    DB.SaveToDB<Patient>(listBoxOldPatienList.SelectedItem);
                    listBoxPatientList.Items.Add(listBoxOldPatienList.SelectedItem);

                    listBoxOldPatienList.Items.RemoveAt(listBoxOldPatienList.SelectedIndex);
                }
                remainingPatients = listBoxOldPatienList.Items.Cast<Patient>().ToList<Patient>();

                string fileNameForOldPatients = DB.GetFileNameForOldPatient();
                DB.OpenOrCreatFile(fileNameForOldPatients);
                DB.DeletFromDB<OldPatien>(indexOldPatien);

                if (listBoxOldPatienList.Items.Count != 0)
                {
                    thisOldPatien = new OldPatien(thisDoctor, remainingPatients);
                    DB.SaveToDB<OldPatien>(thisOldPatien);
                }
            }
            else
                MessageBox.Show("Вы не выбрали запись, которую хотите отменить");
        }

        private void FormClinic_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form MainForm = Application.OpenForms[0];
            MainForm.Show();
        }

        private void FormClinic_Load(object sender, EventArgs e)
        {

        }
    }
}
