////-------------------------------------------------------------------------------------------------------------------------------
////<copyright file = "EmployeeController.cs" company ="Bridgelabz">
////Copyright © 2019 company ="Bridgelabz"
////</copyright>
////<creator name ="Priyanka khichar"/>
////
////-------------------------------------------------------------------------------------------------------------------------------
namespace EmployeeManagement.Controllers
{
    using System.Collections.Generic;
    using BusinessManager.Interface;
    using CommanLayer;
    using Microsoft.AspNetCore.Mvc;

    /// <summary>
    /// Employee controller class having all the methods and defining the routes
    /// </summary>
    /// <seealso cref="Microsoft.AspNetCore.Mvc.ControllerBase" />
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        /// <summary>
        /// The employee
        /// </summary>
        private IEmployee employee;

        /// <summary>
        /// Initializes a new instance of the <see cref="EmployeeController"/> class.
        /// </summary>
        /// <param name="employee">The employee.</param>
        public EmployeeController(IEmployee employee)
        {
            this.employee = employee;
        }

        /// <summary>
        /// Gets all emp details.
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route ("get")]
        public IList<EmployeeModel> GetAllEmpDetails()
        {
            List<EmployeeModel> empList = this.employee.GetEmployee();
            return empList;
        }

        /// <summary>
        /// Adds the specified object.
        /// </summary>
        /// <param name="obj">The object.</param>
        /// <returns></returns>
        [HttpPost]
        [Route("add")]
        public bool Add(EmployeeModel obj)
        {
            this.employee.AddEmployee(obj);
            return true;
        }

        ///
        /// <summary>
        /// Updates the specified object.
        /// </summary>
        /// <param name="obj">The object.</param>
        [HttpPut]
        [Route("update/{id}")]
        public void Update(EmployeeModel obj)
        {
            this.employee.UpdateEmployee(obj);
        }

        /// <summary>
        /// Deletes the specified identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        [HttpDelete]
        [Route("del/{id}")]
        public void Delete(string  id)
        {
            this.employee.DeleteEmployee(id);
        }

        /// <summary>
        /// Gets the employee by identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        [HttpGet]
        [Route("getById/{id}")]
        public List<EmployeeModel> GetEmployeeById(string id)
        {
           var list =  this.employee.GetEmployeeById(id);
           return list;
        }
    }
}