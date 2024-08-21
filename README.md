# Wil-Website
V.1.2 Beta
HEAL Foundation - MVC Web Application
Overview
The HEAL Foundation is a non-profit organization dedicated to improving Humanitarian, environmental and animal liberation This web application is developed using ASP.NET MVC in Visual Studio and serves as the foundation's online platform for sharing information, managing programs, and facilitating donations.

Features
Homepage: Information about the HEAL Foundation, its mission.
Programs: they offer help to all those in need was well has hosting events and talk in schools and community centres.
Donate: A secure portal for making online donations.
Contact Us: A form to get in touch with the foundation.
Admin Panel: Restricted area for managing website content and donor information.
Prerequisites
Visual Studio 2019 or later
.NET Framework 4.7.2 or later
SQL Server (Express or higher)
Git
Installation
Clone the repository:

bash
Copy code
git clone:https://github.com/InnoTech-IT-Solutions/Wil-Website.git
cd HEAL-Foundation
Open the project in Visual Studio:

Launch Visual Studio.
Click on "Open a project or solution."
Navigate to the cloned repository and select the .sln file.
Restore NuGet packages:

In Visual Studio, right-click on the solution in the Solution Explorer.
Select "Restore NuGet Packages."
Set up the database:

Open the Web.config file and update the connection string with your SQL Server credentials.
Run the migrations to set up the database schema. You can do this through the Package Manager Console:
bash
Copy code
Update-Database
Run the application:

Press F5 or click on "Start" in Visual Studio to run the application.
The website will launch in your default browser.
Usage
Homepage: Visit the home page to learn about the foundation's goals and recent activities.
Admin Panel: Log in with your admin credentials to manage the content and view donation reports.
