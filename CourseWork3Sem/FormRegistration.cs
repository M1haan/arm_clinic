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
    public partial class FormRegistration : Form
    {
        private bool verificationPhoneNumber = true;
        private bool verificationPassportId = true;
        public FormRegistration()
        {
            InitializeComponent();
        }

        private void btnRegistration_Click(object sender, EventArgs e)
        {
            int flag = 0;
            string fullName = null;
            string passportID = null;
            string residentialAddress = null;
            string phoneNumber = null;
            string password = null;
            WorkingWithDB DB = new WorkingWithDB();
            string FileName = DB.GetFileNameForDoctors();
            DB.OpenOrCreatFile(FileName);

            verificationPhoneNumber = true;
            verificationPassportId = true;
            CheckDoctor();

            if (txtSurname.Text == "" || txtName.Text == "")
                MessageBox.Show("Некорректое ФИО");
            else
            {
                if (LetterInputCheckForFullName(txtSurname.Text) == true && 
                    LetterInputCheckForFullName(txtName.Text) == true &&
                    (txtPatronymic.Text == "" || LetterInputCheckForFullName(txtPatronymic.Text) == true))
                {
                    fullName = txtSurname.Text + " " + txtName.Text + " " + txtPatronymic.Text; 
                    flag++;
                }           
                else
                    MessageBox.Show("Некорректое ФИО");
            }

                
            if (mtxtPassportID.Text.Length == 6)
            {
                if(verificationPassportId == true)
                {
                    passportID = mtxtPassportID.Text;
                    flag++;
                }
                else
                    MessageBox.Show("Пользователь с таким номером паспорта уже существует");
            }         
            else
                MessageBox.Show("Некорректный номер паспорта");


            if(txtStreet.Text == ""  || txtHouseNumber.Text == "")
                MessageBox.Show("Некорректный адрес");
            else
            {
                if (LetterInputCheckForStreet(txtStreet.Text) == true 
                    && LetterInputCheckForHouseNumber(txtHouseNumber.Text))
                {
                    residentialAddress = txtStreet.Text + " " + txtHouseNumber.Text;
                    flag++;
                }   
                else
                    MessageBox.Show("Некорректный адрес");
            }
                
         
            if (mtxtPhoneNumber.Text.Length == 14)
            {
                if(verificationPhoneNumber == true)
                {
                    phoneNumber = "+7" + mtxtPhoneNumber.Text;
                    flag++;
                }
                else
                    MessageBox.Show("Пользователь с таким номером телефона уже зарегестрирован");
            }         
            else
                MessageBox.Show("Некорректный номер телефона");

            if(txtPassword.Text.Length > 0)
            {
                password = txtPassword.Text;
                flag++;
            }
            else
                MessageBox.Show("Заполните поле <Пароль>");

            if(flag == 5)
            {
                Doctor newDoctor = new Doctor(fullName, passportID, residentialAddress, phoneNumber, password);
                DB.SaveToDB<Doctor>(newDoctor);
                MessageBox.Show("Вы успешно зарегистрировались");

                Form formAuthorization = Application.OpenForms[0];
                formAuthorization.Show();
                this.Close();
            }
        }

        private bool LetterInputCheckForFullName(string str)
        {
            bool result = false;
            int c = 0;
            if (str.Length == 1)
                return result;
            for (int i = 0; i < str.Length; i++)
            {
                if ((str[i] >= 'А') && (str[i] <= 'я') || (str[i] == 'ё') || (str[i] == 'Ё'))
                    c++;
            }
            if (c == str.Length)
                result = true;
            return result;
        }

        private bool LetterInputCheckForStreet(string str)
        {
            bool result = false;
            int c = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if ((str[i] >= 'А') && (str[i] <= 'я') || (str[i] == ' ') || (str[i] == 'ё') || (str[i] == 'Ё'))
                    c++;
            }
            if (c == str.Length)
                result = true;
            return result;
        }

        private bool LetterInputCheckForHouseNumber(string str)
        {
            bool result = false;
            int c = 0;
            if (str[0] >= '0' && str[0] <= '9')
                c++;
            for (int i = 1; i < str.Length; i++)
            {
                if ((str[i] >= '0') && (str[i] <= '9') || (str[i] == '/'))
                    c++;
            }
            if (c == str.Length)
                result = true;
            return result;
        }

        private void CheckDoctor()
        {
            int counter = 0;
            WorkingWithDB DB = new WorkingWithDB();
            string FilePath = DB.GetFileNameForDoctors();
            DB.OpenOrCreatFile(FilePath);

            List<Doctor> doctors = new List<Doctor>();
            doctors = DB.ReadAllFromDB<Doctor>();

            string phoneNumber = "+7" + mtxtPhoneNumber.Text;

            foreach (var doctor in doctors)
            {
                if (doctor.PhoneNumber == phoneNumber)
                {
                    verificationPhoneNumber = false;
                    counter++;
                }
                if (doctor.PassportID == mtxtPassportID.Text)
                {
                    verificationPassportId = false;
                    counter++;
                }

                if (counter == 2)
                    break;
            }
        }

        private void btnReturnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormRegistration_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            Form formAuthorization = Application.OpenForms[0];
            formAuthorization.Show();
        }
    }
}
