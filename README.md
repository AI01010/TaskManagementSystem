# Task Management System using C# and .NET
## c-.net_web-P1

### How to Run the Task Management System in VS Code
Follow these steps to set up and run the Task Management System:

1. Prerequisites
Make sure you have the following installed:

- .NET 7.0 SDK or higher
- Visual Studio Code
- C# extension for VS Code


2. Create the Project Structure

Open a terminal and create a new directory for your project:
bash - 

$ mkdir TaskManagementSystem

$ cd TaskManagementSystem

Create a new ASP.NET Core MVC project:
bash -  

$ dotnet new mvc

Install the required package:
bash -  

$ dotnet add package Microsoft.EntityFrameworkCore.InMemory



3. Add Project Files

Create all the folders and files as shown in the artifact above.
Copy and paste the code from the artifact into each corresponding file.


4. Open the Project in VS Code

Open VS Code:
bash -

$ code .

VS Code will prompt you to add required assets for build and debug. Click "Yes".


5. Build and Run the Application

Open the integrated terminal in VS Code (Ctrl+` or View > Terminal).
Build the project:
bash -

$ dotnet build

Run the application:
bash -

$ dotnet run

Open a web browser and navigate to:
https://localhost:5001
or
http://localhost:5000
(or 5###)


6. Using VS Code Debugging

Set breakpoints by clicking in the left margin next to line numbers.
Press F5 or go to Run > Start Debugging to launch the application in debug mode.
The application will start, and VS Code will attach the debugger. Your breakpoints will be hit when that code executes.

Features of the Task Management System
This simplified Task Management System includes:

Task listing with priority, status, and due dates
Create, edit, view details, and delete operations for tasks
Form validation
In-memory database for easy testing (no database setup required)
Responsive Bootstrap UI

Don't deploy on Vercel!
Deploy to heroku?

