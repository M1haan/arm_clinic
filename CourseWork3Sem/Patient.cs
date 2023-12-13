using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWork3Sem
{
    class Patient : IComparable
    {
        public string NamePatient { get; private set; }
        public string Doctor { get; private set; }
        public string RecordingTime { get; private set; }
        public string Diagnosis { get; private set; }
        public string ReturningDate { get; set; } //наверное убрать надо
        private bool isHeld = false;

        public Patient(string namePatient, string doctor, string diagnosis, string recordingTime, string returningDate)
        {
            NamePatient = namePatient;
            Doctor = doctor;
            Diagnosis = diagnosis;
            RecordingTime = recordingTime;
            ReturningDate = returningDate;
        }

        public void IsHeld()
        {
            isHeld = true;
        }

        public override string ToString()
        {
            string str = "";
            str = ($"{NamePatient}, Жалобы: {Diagnosis}, Время обращения: {RecordingTime}");
            if (isHeld == true)
                str += ($", Повторное посещение: {ReturningDate}");
            return str;
        }

        public int CompareTo(object obj)
        {
            if (obj is Patient patient)
                return NamePatient.CompareTo(patient.NamePatient);
            else 
                throw new ArgumentException("Некорректное значение параметра");
        }

    }
}
