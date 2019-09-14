////-------------------------------------------------------------------------------------------------------------------------------
////<copyright file = "EmployeeDetail.cs" company ="Bridgelabz">
////Copyright © 2019 company ="Bridgelabz"
////</copyright>
////<creator name ="Priyanka khichar"/>
////
////-------------------------------------------------------------------------------------------------------------------------------
namespace BusinessManager.Service
{
    using BusinessManager.Interface;
    using CommanLayer;
    using RepositeryManager.Interface;
    using System.Collections.Generic;

    /// <summary>
    /// Employee details
    /// </summary>
    /// <seealso cref="BusinessManager.Interface.IEmployee" />
    public class EmployeeDetail : IEmployee
    {
        /// <summary>
        /// The details
        /// </summary>
        private readonly  IEmployeeDetails details;
      public EmployeeDetail(IEmployeeDetails details)
        {
            this.details = details;
        }

        /// <summary>
        /// Adds the employee.
        /// </summary>
        /// <param name="obj">The object.</param>
        public void AddEmployee(EmployeeModel obj)
        {
             this.details.AddEmployee(obj); 
        }

        /// <summary>
        /// Gets the employee.
        /// </summary>
        /// <returns>
        /// returning employee list
        /// </returns>
        public List<EmployeeModel> GetEmployee()
        {
           return this.details.GetAllEmployeeList();
        }

        /// <summary>
        /// Gets the employee by identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>
        /// returning employee list according to id
        /// </returns>
        public List<EmployeeModel> GetEmployeeById(string id)
        {
            return this.details.GetEmployeeById(id);
        }

        /// <summary>
        /// Updates the employee.
        /// </summary>
        /// <param name="obj">The object.</param>
        /// <returns>
        /// returning true if employee details updated
        /// </returns>
        public bool UpdateEmployee(EmployeeModel obj)
        {
            return this.details.UpdateEmployee(obj);
        }

        /// <summary>
        /// Deletes the employee.
        /// </summary>
        /// <param name="obj">The object.</param>
        /// <returns>
        /// returning true if employee details deleted
        /// </returns>
        public bool DeleteEmployee(string obj)
        {
            return this.details.DeleteEmployee(obj);
        }  
    }
}
