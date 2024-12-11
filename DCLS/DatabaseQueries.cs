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

            return "DELETE FROM Logs WHERE patient_id = " + id + "; " +
                "DELETE FROM Patients WHERE patient_id = " + id + "; ";

        }

        public static string getPatientHistory(int patientId) 
        {

            return "SELECT log_id, date, [procedure] " +
               "FROM Logs " +
               "JOIN Patients ON Logs.patient_id = Patients.patient_id " +
               "WHERE Logs.patient_id = " + patientId;

        }

        public static string addPatient(string firstName, string lastName, string middleInitial, string gender, string birthday, string contactNumber)
        {

            return "INSERT INTO Patients(first_name, last_name, middle_initial, gender, birthday, contact_no)" 
                + "VALUES ( '" + firstName + "', '" + lastName + "', '" + middleInitial + "', '" + gender + "', '" + birthday + "', '" + contactNumber + "')";


        }

        public static string updatePatient(int id, string firstName, string lastName, string middleInitial, string gender, string birthday, string contactNumber)
        {

            return "UPDATE Patients " +
                "SET first_name = '" + firstName + "', " + "last_name = '" + lastName + "', " + "middle_initial = '" + middleInitial + "', " + "gender = '" + gender + "', " + "birthday = '" + birthday + "', " + "contact_no = '" + contactNumber + "' " +
                "WHERE patient_id = " + id;

        }

        public static string addLog(int patientID, string date, string procedure) //JC po to, Might be wrong
        {
            return "INSERT INTO Logs(patient_id, date, procedure)"
                + "VALUES( '" + patientID + "', '" + date + "','" + procedure + "',)";
        }

        public static string viewLog() //Still needs a query
        {
            return null;
        }
    }
}
