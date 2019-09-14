////-------------------------------------------------------------------------------------------------------------------------------
////<copyright file = "EmployeeDetails.cs" company ="Bridgelabz">
////Copyright © 2019 company ="Bridgelabz"
////</copyright>
////<creator name ="Priyanka khichar"/>
////
////-------------------------------------------------------------------------------------------------------------------------------
namespace RepositeryManager.Service
{
    using CommanLayer;
    using RepositeryManager.Interface;
    using System;
    using System.Collections.Generic;
    using System.Data.SqlClient;
    using System.Data;

    /// <summary>
    /// Employee Details class have curd operation implemention
    /// </summary>
    /// <seealso cref="RepositeryManager.Interface.IEmployeeDetails" />
    public class EmployeeDetails : IEmployeeDetails
    {
        /// <summary>
        /// The connection string
        /// </summary>
        public readonly static string constring = "Server= (LocalDb)\\localdbDemo;Database=EmployeeDatabase;Trusted_connection=True;MultipleActiveResultSets=True";

        /// <summary>
        /// The connection object
        /// </summary>
        SqlConnection connection = new SqlConnection(constring);
 

        /// <summary>
        /// add employee details
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public void AddEmployee(EmployeeModel obj)
        {
         ////creating the sqlcommand object to    
            SqlCommand command = new SqlCommand("spAddEmployee", this.connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@EmpId", obj.EmpId);
            command.Parameters.AddWithValue("@FirstName", obj.FirstName);
            command.Parameters.AddWithValue("@LastName", obj.LastName);
            command.Parameters.AddWithValue("@Contact", obj.Contact);
            command.Parameters.AddWithValue("@City", obj.City);
            command.Parameters.AddWithValue("@Email", obj.Email);
            command.Parameters.AddWithValue("@Salary", obj.Salary);
            connection.Open();
            int i = command.ExecuteNonQuery();
            connection.Close();
        }

        /// <summary>
        /// Get employee list
        /// </summary>
        /// <returns></returns>
        public List<EmployeeModel> GetAllEmployeeList()
        {
            try
            {
                ////created the list for employee records
                List<EmployeeModel> empList = new List<EmployeeModel>();
                SqlCommand command = new SqlCommand("spRetriveRecords", connection);
                command.CommandType = CommandType.StoredProcedure;
                connection.Open();

                ////reading the records and storing in data reader
                SqlDataReader dataReader = command.ExecuteReader();
                EmployeeModel model = null;

                ////checking if data reader has record or not
                if (dataReader.HasRows)
                {
                    ////reading the records from data reader
                    while (dataReader.Read())
                    {
                        model = new EmployeeModel();

                        ////string the EmpId from database to EmployeeModel list
                        model.EmpId = dataReader["EmpId"].ToString();
                        model.FirstName = dataReader["FirstName"].ToString();
                        model.LastName = dataReader["Lastname"].ToString();
                        model.Contact = dataReader["Contact"].ToString();
                        model.City = dataReader["City"].ToString();
                        model.Email = dataReader["Email"].ToString();
                        model.Salary = dataReader["Salary"].ToString();

                        ////adding the model object to the list
                        empList.Add(model);
                    }
                }
                ////returning the list
                return empList;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw new Exception(ex.Message);
            }
            finally
            {
                ////closing the connection
                connection.Close();
            }
        }

        /// <summary>
        /// Update Employee details
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public bool UpdateEmployee(EmployeeModel obj)
        {
           ////creating the command object to identify the stored procedure.
            SqlCommand command = new SqlCommand("UpdateEmployee", connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@EmpId",obj.EmpId);
            command.Parameters.AddWithValue("@FirstName", obj.FirstName);
            command.Parameters.AddWithValue("@LastName", obj.LastName);    
            command.Parameters.AddWithValue("@Contact",obj.Contact);
            command.Parameters.AddWithValue("@City", obj.City);
            command.Parameters.AddWithValue("@Email", obj.Email);
            connection.Open();

            ////it returns number of records updated
            int i = command.ExecuteNonQuery();
            connection.Close();
            if(i > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Gets the employee by id.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        public List<EmployeeModel> GetEmployeeById(string id)
        {
            List<EmployeeModel> empList = new List<EmployeeModel>();

            ////create a command object to indentify the stored procedure
            SqlCommand command = new SqlCommand("GetEmployeeById", connection);

            ////set the command object so it knows to execute a stored procedure
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@EmpId", id);
            connection.Open();

            ////call Execute reader to get records from data base
            SqlDataReader dataReader = command.ExecuteReader();

            ////initilizng the employee model object with null so we can use outside of the if block.
            EmployeeModel model = null;
            if (dataReader.HasRows)
            {
                while (dataReader.Read())
                {
                    model = new EmployeeModel();
                    model.EmpId = dataReader["EmpId"].ToString();
                    model.FirstName = dataReader["FirstName"].ToString();
                    model.LastName = dataReader["Lastname"].ToString();
                    model.Contact = dataReader["Contact"].ToString();
                    model.City = dataReader["City"].ToString();
                    model.Email = dataReader["Email"].ToString();
                    model.Salary = dataReader["Salary"].ToString();

                    ////adding object to the list
                    empList.Add(model);
                }
            }
            ////returning the list
            return empList;
        }

        /// <summary>
        /// Deletes the employee according to id.
        /// </summary>
        /// <param name="obj">The object.</param>
        /// <returns></returns>
        public bool DeleteEmployee(string obj)
        {
            ////initilizing a command that have connection and query and creating the command object
            SqlCommand command = new SqlCommand("DeleteById", connection);

            ////set the command object so it knows to which procedure has to be execute
            command.CommandType = CommandType.StoredProcedure;

            ////giving the input to the procedure
            command.Parameters.AddWithValue("@EmpId", obj);
            connection.Open();
            int i = command.ExecuteNonQuery();
            connection.Close();
            if (i > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
