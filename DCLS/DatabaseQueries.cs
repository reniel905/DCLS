using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DCLS
{
    public class DatabaseQueries
    {

        public const string GetAllLogs = "SELECT * FROM Logs";
        public const string GetAllPatients = "SELECT * FROM Patients";


        public static string deletePatient(int id)
        {

            return "DELETE FROM Patients WHERE id=" + id;

        }

        public static string getPatientHistory(int patientId) 
        {

            return "SELECT log_id, CONCAT(Patients.first_name, ' ', Patients.middle_initial, '. ', Patients.last_name) AS full_name, date, [procedure] " +
               "FROM Logs " +
               "JOIN Patients ON Logs.patient_id = Patients.patient_id " +
               "WHERE Logs.patient_id = " + patientId;

        }
    }
}
