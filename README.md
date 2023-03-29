# ASP.NET Razor Pages CRUD App with Entity Framework Core and SQL Server

This project is a full-stack web application built using ASP.NET Razor Pages, Entity Framework Core, and SQL Server. The application allows users to register and login to their account, add employees, delete employees, edit employee information, and view a list of all employees. This CRUD app provides a simple and intuitive interface for managing employee data in a secure and scalable way.

# Installation
To run this application, you'll need to have the following installed on your machine:

1) .NET 5.0 / 6.0 / 7.0
2) SQL Server Express LocalDB

To get started, follow these steps:

1) Clone this repository to your local machine.

2) Open the solution in Visual Studio.

3) Restore the NuGet packages by right-clicking on the solution and selecting "Restore NuGet Packages."

4) Open the appsettings.json file and update the connection string to match your local SQL Server instance.

5) Open the Package Manager Console and run the following command to create the database: Update-Database  (and  Use the '-Context' parameter for PowerShell commands and the name of dbcontexts

This will create the database and its tables using the Entity Framework Code-First approach.

6) Build and run the application in Visual Studio.


# Usage
Once the application is running, you can use it to perform CRUD operations on the Employee entity. Here's a quick rundown of what you can do:

Create: Click the "Create New" button to add a new employee to the database. Fill in the employee's details and click "Create" to save the employee to the database.
Read: Click the "View List" button to see a list of all employees in the database. Click on an employee's name to view their details.
Update: From the list of employees, click the "Edit" button next to the employee you want to update. Update the employee's details and click "Save" to save the changes to the database.
Delete: From the list of employees, click the "Delete" button next to the employee you want to delete. Confirm that you want to delete the employee and click "Delete" to remove them from the database.

# Technologies Used
This application was built using:

ASP.NET Razor Pages
Entity Framework Core
SQL Server
Bootstrap
