using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DCLS
{
    public class DatabaseQueries
    {

        public const string GetAllLogs = "SELECT * FROM Logs";
        public const string GetAllPatients = "SELECT * FROM Patients";
        public const string GetAllLogsWithName = "SELECT log_id, Patients.first_name, Logs.patient_id, date, [procedure] FROM Logs INNER JOIN Patients ON Logs.patient_id = Patients.patient_id";



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
                + "VALUES ( '" + firstName + "', '" + lastName + "', '" + middleInitial + "', '" + gender + "', '" + birthday + "', '" + contactNumber + "') " + 
                "SELECT SCOPE_IDENTITY() AS NewID";


        }

        public static string updatePatient(int id, string firstName, string lastName, string middleInitial, string gender, string birthday, string contactNumber)
        {

            return "UPDATE Patients " +
                "SET first_name = '" + firstName + "', " + "last_name = '" + lastName + "', " + "middle_initial = '" + middleInitial + "', " + "gender = '" + gender + "', " + "birthday = '" + birthday + "', " + "contact_no = '" + contactNumber + "' " +
                "WHERE patient_id = " + id;

        }

        public static string addLog(int id, string date, string procedure)
        {

            return "INSERT INTO Logs (patient_id, date, [procedure]) VALUES (" + id + ", '" + date + "', '" + procedure + "')";

        }

        public static string deleteLog(int id)
        {

            return "DELETE FROM Logs WHERE log_id = " + id;

        }


        public static string filterLogBy(string procedure)
        {

            return "SELECT log_id, Patients.first_name, Logs.patient_id, date, [procedure] FROM Logs INNER JOIN Patients ON Logs.patient_id = Patients.patient_id " +
                "WHERE Logs.[procedure] = '" + procedure +"'";

        }        

        public static string searchById(string id)
        {

            return "SELECT * FROM Patients WHERE patient_id = '" + id + "'";

        }

        public static string searchByFirstName(string firstName)
        {

            return "SELECT * FROM Patients WHERE first_name = '" + firstName + "'";

        }
        
        public static string searchByLastName(string lastName)
        {

            return "SELECT * FROM Patients WHERE last_name = '" + lastName + "'";

        }

        public static string searchByGender(string gender)
        {

            return "SELECT * FROM Patients WHERE gender = '" + gender + "'";

        }
    }
}
