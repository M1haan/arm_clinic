using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWork3Sem
{
    class OldPatien : IComparable
    {
        public Doctor doctor { get; }
        public List<Patient> patients { get; }
     

        public OldPatien(Doctor doctor, List<Patient> patients)
        {
            this.doctor = doctor;
            this.patients = patients;
        }

        public int CompareTo(object obj)
        {
            if (obj is OldPatien oldPatien)
                return doctor.FullName.CompareTo(oldPatien.doctor.FullName);
            else
                throw new ArgumentException("Некорректное значение параметра");
        }

        public override string ToString()
        {
            string str = "";
            if (WorkingWithDB.IsAdmin)
                str = ($"{doctor.FullName}, {doctor.PhoneNumber} - ");
            
            foreach (var patient in patients)
                str += ($"{patient.NamePatient} ({patient.Doctor}), Жалобы: {patient.Diagnosis}, Время обращения: {patient.RecordingTime}, Повторное посещение: {patient.ReturningDate}, \n");

            return str;
        }
    }
}
