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
    public partial class FormAuthorization : Form
    {
        public FormAuthorization()
        {
            InitializeComponent();
        }

        private void buttonRegistration_Click(object sender, EventArgs e)
        {
            FormRegistration registration = new FormRegistration();
            registration.Show();
            this.Hide();
        }

        private void buttonInput_Click(object sender, EventArgs e)
        {
            string phoneNumber = "+7" + mtxtPhoneNumber.Text;
            bool flag = false;
            WorkingWithDB DB = new WorkingWithDB();

            string FilePath = DB.GetFileNameForAdmin();
            DB.OpenOrCreatFile(FilePath);
            List<Admin> admins = DB.ReadAllFromDB<Admin>();

            foreach (var admin in admins)
            {
                if (admin.PhoneNumber == phoneNumber && admin.Password == txtPassword.Text)
                {
                    FormAdmin formAdmin = new FormAdmin();
                    formAdmin.Show();
                    mtxtPhoneNumber.Text = "";
                    txtPassword.Text = "";
                    this.Hide();
                    flag = true;
                    break;
                }
            }
            
            if(!flag)
            {
                FilePath = DB.GetFileNameForDoctors();
                DB.OpenOrCreatFile(FilePath);
                List<Doctor> doctors = DB.ReadAllFromDB<Doctor>();

                foreach (var doctor in doctors)
                {
                    if (doctor.PhoneNumber == phoneNumber && doctor.Password == txtPassword.Text)
                    {
                        FormClinic formClinic = new FormClinic(this);
                        formClinic.Show();
                        this.Hide();
                        flag = true;
                        break;
                    }
                }
                if (flag == false)
                    MessageBox.Show("Неверный логин или пароль");

            }
        }

        private void FormAuthorization_FormClosing(object sender, FormClosingEventArgs e)
        {
           // this.Close();
        }

        private void FormAuthorization_Load(object sender, EventArgs e)
        {

        }
    }
}
