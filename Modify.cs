using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace HosManage
{
    class Modify
    {
        public Modify()
        {
        }
        SqlCommand sqlCommand;
        SqlDataReader dataReader;
        SqlDataAdapter dataAdapter;


        public List<Account> Accounts(string query)
        {
            List<Account> accounts = new List<Account>();
            using (SqlConnection sqlConnection = Connection.GetSqlConnection())
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(query, sqlConnection);
                dataReader = sqlCommand.ExecuteReader();
                while (dataReader.Read())
                {
                    accounts.Add(new Account(dataReader.GetString(0), dataReader.GetString(1)));
                }
                sqlConnection.Close();
            }
            return accounts;
        }
        public void Command(string query)
        {
            using (SqlConnection sqlConnection = Connection.GetSqlConnection())
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();
            }
        }
        public DataTable Table(string query)
        {
            DataTable dataTable = new DataTable();
            using (SqlConnection sqlConnection = Connection.GetSqlConnection())
            {
                sqlConnection.Open();
                dataAdapter = new SqlDataAdapter(query, sqlConnection);
                dataAdapter.Fill(dataTable);
                sqlConnection.Close();
            }
            return dataTable;
        }


        //======================================================================
        public DataTable getAllPatients()
        {
            string query = "select *from Patients";
            DataTable dataTable = new DataTable();
            using (SqlConnection sqlConnection = Connection.GetSqlConnection())
            {
                sqlConnection.Open();
                dataAdapter = new SqlDataAdapter(query, sqlConnection);
                dataAdapter.Fill(dataTable);
                sqlCommand.Clone();

            }
            return dataTable;

        }
        public bool insert(patient patient)
        {
            SqlConnection sqlConnection = Connection.GetSqlConnection();
            string query = "Insert into Patients values (@PatientID, @FullName,@Address,@DateOfBirth,@PhoneNumber)";
            try
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.Parameters.Add("@PatientID", SqlDbType.Int).Value = patient.patientID;
                sqlCommand.Parameters.Add("@FullName", SqlDbType.VarChar).Value = patient.fullName;
                sqlCommand.Parameters.Add("@Address", SqlDbType.VarChar).Value = patient.address;
                sqlCommand.Parameters.Add("@DateOfBirth", SqlDbType.Date).Value = patient.dateOfBirth.ToShortDateString();
                sqlCommand.Parameters.Add("@PhoneNumber", SqlDbType.VarChar).Value = patient.phoneNumber;
                sqlCommand.ExecuteNonQuery();
            }
            catch
            {
                return false;
            }
            finally
            {

                sqlConnection.Close();
            }
            return true;
        }
        public bool DeletePatients(string id)
        {
            SqlConnection sqlConnection = Connection.GetSqlConnection();
            string query = "delete Patients where PatientID = @PatientID";
            try
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.Parameters.Add("@PatientID", SqlDbType.Int).Value = id;

                sqlCommand.ExecuteNonQuery();
            }
            catch
            {
                return false;
            }
            finally
            {

                sqlConnection.Close();
            }
            return true;
        }
        //======================================================================
        public DataTable getAllDoctors()
        {
            string query = "select *from Doctors";
            DataTable dataTable = new DataTable();
            using (SqlConnection sqlConnection = Connection.GetSqlConnection())
            {
                sqlConnection.Open();
                dataAdapter = new SqlDataAdapter(query, sqlConnection);
                dataAdapter.Fill(dataTable);
                sqlCommand.Clone();

            }
            return dataTable;

        }
        public bool insert(doctor doctor)
        {
            SqlConnection sqlConnection = Connection.GetSqlConnection();
            string query = "Insert into Doctors values (@DoctorID, @FullName,@Address,@DateOfBirth,@PhoneNumber)";
            try
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.Parameters.Add("@DoctorID", SqlDbType.Int).Value = doctor.doctorID;
                sqlCommand.Parameters.Add("@FullName", SqlDbType.VarChar).Value = doctor.fullName;
                sqlCommand.Parameters.Add("@Address", SqlDbType.VarChar).Value = doctor.address;
                sqlCommand.Parameters.Add("@DateOfBirth", SqlDbType.Date).Value = doctor.dateOfBirth.ToShortDateString();
                sqlCommand.Parameters.Add("@PhoneNumber", SqlDbType.VarChar).Value = doctor.phoneNumber;
                sqlCommand.ExecuteNonQuery();
            }
            catch
            {
                return false;
            }
            finally
            {

                sqlConnection.Close();
            }
            return true;
        }
        public bool DeleteDoctors(string id)
        {
            SqlConnection sqlConnection = Connection.GetSqlConnection();
            string query = "delete Doctors where DoctorID = @DoctorID";
            try
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.Parameters.Add("@DoctorID", SqlDbType.Int).Value = id;

                sqlCommand.ExecuteNonQuery();
            }
            catch
            {
                return false;
            }
            finally
            {

                sqlConnection.Close();
            }
            return true;
        }
        //======================================================================
        public DataTable getAllFManager()
        {
            string query = "select *from FinancialManagers";
            DataTable dataTable = new DataTable();
            using (SqlConnection sqlConnection = Connection.GetSqlConnection())
            {
                sqlConnection.Open();
                dataAdapter = new SqlDataAdapter(query, sqlConnection);
                dataAdapter.Fill(dataTable);
                sqlCommand.Clone();

            }
            return dataTable;

        }
        public bool insert(FManage fManage)
        {
            SqlConnection sqlConnection = Connection.GetSqlConnection();
            string query = "Insert into FinancialManagers values (@ManagerID, @FullName,@Address,@DateOfBirth,@PhoneNumber)";
            try
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.Parameters.Add("@ManagerID", SqlDbType.Int).Value = fManage.managerID;
                sqlCommand.Parameters.Add("@FullName", SqlDbType.VarChar).Value = fManage.fullName;
                sqlCommand.Parameters.Add("@Address", SqlDbType.VarChar).Value = fManage.address;
                sqlCommand.Parameters.Add("@DateOfBirth", SqlDbType.Date).Value = fManage.dateOfBirth.ToShortDateString();
                sqlCommand.Parameters.Add("@PhoneNumber", SqlDbType.VarChar).Value = fManage.phoneNumber;
                sqlCommand.ExecuteNonQuery();
            }
            catch
            {
                return false;
            }
            finally
            {

                sqlConnection.Close();
            }
            return true;
        }
        public bool DeleteDFManage(string id)
        {
            SqlConnection sqlConnection = Connection.GetSqlConnection();
            string query = "delete FinancialManagers where ManagerID = @ManagerID";
            try
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.Parameters.Add("@ManagerID", SqlDbType.Int).Value = id;

                sqlCommand.ExecuteNonQuery();
            }
            catch
            {
                return false;
            }
            finally
            {

                sqlConnection.Close();
            }
            return true;
        }
        //======================================================================
        public DataTable getAllPM()
        {
            string query = "select *from PatientMedicine";
            DataTable dataTable = new DataTable();
            using (SqlConnection sqlConnection = Connection.GetSqlConnection())
            {
                sqlConnection.Open();
                dataAdapter = new SqlDataAdapter(query, sqlConnection);
                dataAdapter.Fill(dataTable);
                sqlCommand.Clone();

            }
            return dataTable;

        }
        public bool insert(PM pM)
        {
            SqlConnection sqlConnection = Connection.GetSqlConnection();
            string query = "Insert into PatientMedicine values (@PatientID, @FullName,@Address,@NameOfMedicine,@Amount)";
            try
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.Parameters.Add("@PatientID", SqlDbType.Int).Value = pM.patientID;
                sqlCommand.Parameters.Add("@FullName", SqlDbType.VarChar).Value = pM.fullName;
                sqlCommand.Parameters.Add("@Address", SqlDbType.VarChar).Value = pM.address;
                sqlCommand.Parameters.Add("@NameOfMedicine", SqlDbType.VarChar).Value = pM.nameofmedicine;
                sqlCommand.Parameters.Add("@Amount", SqlDbType.VarChar).Value = pM.amount;
                sqlCommand.ExecuteNonQuery();
            }
            catch
            {
                return false;
            }
            finally
            {

                sqlConnection.Close();
            }
            return true;
        }
        public bool DeletePM(string id)
        {
            SqlConnection sqlConnection = Connection.GetSqlConnection();
            string query = "delete PatientMedicine where PatientID = @PatientID";
            try
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.Parameters.Add("@PatientID", SqlDbType.Int).Value = id;

                sqlCommand.ExecuteNonQuery();
            }
            catch
            {
                return false;
            }
            finally
            {

                sqlConnection.Close();
            }
            return true;
        }
    }
}
