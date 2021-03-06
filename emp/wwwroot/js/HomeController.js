﻿var app = angular.module('MyApp', [])
app.controller("HomeController", function ($scope, $http) {

    //ListOfEmployees variable decared.
    $scope.ListOfEmployee;

    //EmployeeId variable
    $scope.EmployeeId;
    $scope.SearchedEmployee;

    //Insert function to add details in database
    $scope.InsertData = function ()
    {

        //adding the details  to EmployeeModel object
        var EmployeeModel = {
                  EmpId: $scope.EmployeeModel.EmpId,
                  FirstName: $scope.EmployeeModel.FirstName,
                  LastName: $scope.EmployeeModel.LastName,
                  Contact: $scope.EmployeeModel.Contact,
                  City: $scope.EmployeeModel.City,
                  Email: $scope.EmployeeModel.Email,
                  Salary: $scope.EmployeeModel.Salary
                   };

        $http({
               method: "post",

                //it recdirecting the url to add method in Employee controller
                url: "https://localhost:44383/api/Employee/add",
                datatype: "json",

               //converting the data to json object
               data: JSON.stringify(EmployeeModel)
               }).then(function (response) {
                   alert(response.data);

                 //storing the response to the Employee model
                  $scope.EmployeeModel = response.data;

                //reinitilizing the data with empty string
                $scope.EmpId = "";
                $scope.FirstName = "";
                $scope.LastName = "";
                $scope.Contact = "";
                $scope.City = "";
                $scope.Email = "";
                $scope.Salary = "";
        })

    };

    $http({
             method: "get",
             url: "https://localhost:44383/api/Employee/get",

          }).then(function (response) {
                    console.log(response.data);
                     //alert(response.data);
                     $scope.ListOfEmployee = response.data;

          })

    //Delete employee function 
    $scope.DeleteEmp = function (emp)
    {
        console.log(emp);
        var empId = {
                      "EmpId": emp
                     }
        $http({
                 method: "Delete",
                 url: "https://localhost:44383/api/Employee/del/" + emp, //empId is added with url
                 datatype: "json",

             }).then(function (response)
                       {
                         alert(response.data);

                         //getting the data from database
                         $scope.GetAllData();
                        })
     };

    //Update Employee function
    $scope.UpdateEmployee = function (Emp)
    {
        $http({
                 method: "put",
                 url: "https://localhost:44383/api/Employee/update/" + Emp.empId,
                 datatype: "json",
                 data: JSON.stringify(Emp)
             }).then(function (response)
                       {
                         alert(response);
                     })
    };

  //getting All Employee details
    $scope.GetAllData = function ()
    {
        $http({
                 method: "get",
                 url: "https://localhost:44383/api/Employee/get",
  
               }).then(function (response)
                   {
                    console.log(response.data);
                    // alert(response.data);
                     $scope.ListOfEmployee = response.data;
                   })
    };


    //GetById function
    $scope.GetById = function ()
    {       
        var empId = {
                     "EmpId": $scope.EmployeeModel.search
                    }
       
        $http({
                 method: "get",
                 url: "https://localhost:44383/api/Employee/getById/" + empId.EmpId,
                 datatype: "json",

             }).then(function (response)
                 {
                 console.log("response........", response.data);
                 $scope.SearchedEmployee = response.data;

                  alert(response.data[0].firstName, response.data[0].lastName , response.data[0].email, response.data[0].contact , response.data[0].city);
                  console.log("Serchid", response.data[0].firstName + "", response.data[0].firstName + " " + response.data[0].lastName + " " + response.data[0].email + "" + response.data[0].contact + " " + response.data[0].city)
          
                 })
     };

})