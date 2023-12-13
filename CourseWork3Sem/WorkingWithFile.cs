using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CourseWork3Sem
{
    abstract class WorkingWithFile
    {
        public string DBFilepath { get; private set; }
        private string fileNameForDoctors = "C:/Users/mihaa/Downloads/data/Doctors.txt"; //были читатели стали врачи  
        private string fileNameForPatient = "C:/Users/mihaa/Downloads/data/Patient.txt"; //были книги стали пациенты 
        private string fileNameForAvailablePatients = "C:/Users/mihaa/Downloads/data/AvailableBooks.txt";
        private string fileNameForOldPatients = "C:/Users/mihaa/Downloads/data/Debtors.txt";
        private string fileNameForAdmin = "C:/Users/mihaa/Downloads/data/Admin.txt";

        public void OpenOrCreatFile(string nameFile)
        {
            DBFilepath = nameFile;
            if (File.Exists(DBFilepath) == false)
            {
                var file = File.Create(DBFilepath);
                file.Close();
            }
            else
                Console.WriteLine("Файл уже создан");
        }

        public string GetFileNameForDoctors()
        {
            return fileNameForDoctors;
        }
        public string GetFileNameForPatient()
        {
            return fileNameForPatient;
        }
        public string GetFileNameForOldPatient()
        {
            return fileNameForOldPatients;
        }
        public string GetFileNameForAvailablePatients()
        {
            return fileNameForAvailablePatients;

        }
        public string GetFileNameForAdmin()
        {
            return fileNameForAdmin;
        }
    }
}
