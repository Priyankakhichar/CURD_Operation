////-------------------------------------------------------------------------------------------------------------------------------
////<copyright file = "IEmployeeDetails.cs" company ="Bridgelabz">
////Copyright © 2019 company ="Bridgelabz"
////</copyright>
////<creator name ="Priyanka khichar"/>
////
////-------------------------------------------------------------------------------------------------------------------------------
namespace RepositeryManager.Interface
{
    using CommanLayer;
    using System.Collections.Generic;

    /// <summary>
    /// Employee Details interface
    /// </summary>
    public interface IEmployeeDetails
    {
        /// <summary>
        /// Adds the employee.
        /// </summary>
        /// <param name="obj">The object.</param>
        void AddEmployee(EmployeeModel obj);

        /// <summary>
        /// Gets all employee list.
        /// </summary>
        /// <returns></returns>
        List<EmployeeModel> GetAllEmployeeList();

        /// <summary>
        /// Gets the employee by identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        List<EmployeeModel> GetEmployeeById(string id);

        /// <summary>
        /// Updates the employee.
        /// </summary>
        /// <param name="obj">The object.</param>
        /// <returns></returns>
        bool UpdateEmployee(EmployeeModel obj);

        /// <summary>
        /// Deletes the employee.
        /// </summary>
        /// <param name="obj">The object.</param>
        /// <returns></returns>
        bool DeleteEmployee(string obj);

    }
}
