////-------------------------------------------------------------------------------------------------------------------------------
////<copyright file = "EmployeeModel.cs" company ="Bridgelabz">
////Copyright © 2019 company ="Bridgelabz"
////</copyright>
////<creator name ="Priyanka khichar"/>
////
////-------------------------------------------------------------------------------------------------------------------------------
namespace CommanLayer
{
    /// <summary>
    /// Employee Model having attributes for Employee
    /// </summary>
    public class EmployeeModel
    {
        /// <summary>
        /// The emp identifier
        /// </summary>
        private string empId;

        /// <summary>
        /// The first name
        /// </summary>
        private string firstName;

        /// <summary>
        /// The last name
        /// </summary>
        private string lastName;

        /// <summary>
        /// The contact
        /// </summary>
        private string contact;

        /// <summary>
        /// The city
        /// </summary>
        private string city;

        /// <summary>
        /// The email
        /// </summary>
        private string email;

        /// <summary>
        /// The salary
        /// </summary>
        private string salary;

        /// <summary>
        /// Gets or sets the emp identifier.
        /// </summary>
        /// <value>
        /// The emp identifier.
        /// </value>
        public string EmpId
        {
            get;set;
        }

        /// <summary>
        /// Gets or sets the first name.
        /// </summary>
        /// <value>
        /// The first name.
        /// </value>
        public string FirstName
        {
            get;set;
        }

        /// <summary>
        /// Gets or sets the last name.
        /// </summary>
        /// <value>
        /// The last name.
        /// </value>
        public string LastName
        {
            get;set;
        }

        /// <summary>
        /// Gets or sets the contact.
        /// </summary>
        /// <value>
        /// The contact.
        /// </value>
        public string Contact
        {
            get;set;
        }

        /// <summary>
        /// Gets or sets the city.
        /// </summary>
        /// <value>
        /// The city.
        /// </value>
        public string City
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets the email.
        /// </summary>
        /// <value>
        /// The email.
        /// </value>
        public string Email
        {
            get;set;
        }

        /// <summary>
        /// Gets or sets the salary.
        /// </summary>
        /// <value>
        /// The salary.
        /// </value>
        public string Salary
        {
            get;set;
        }
    }
}
