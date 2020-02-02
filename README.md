# **Eau Claires's Salon**

###### By Trevor Mackin 01/17/2020  

![ Screenshot of Project ](img/HairSalon.gif)

### **Description**

_This is a server side application built in C# using ASP.Net Core MVC. This project focuses on connecting to a database using the Entity Framework (Core). The application is for a Salon owner to keep track of their stylists, and the Ccients that belong to each stylist individually. The application uses two seperate classes; One class for stylist, and one class for Clients. When a user runs the application they should be welcomed on a splash page and given a link to look at their stylist. From here, the user should be able to navagate to a page showing all the Stylist with options to delete, edit or add new stylist. When you a user clicks on a particular stylist they will be presented with a list of clients for that stylist. The application also provides options to delete, edit and add new clients as well. From the list Orders, a user then click on a specific Order to view further details._

#
###  **Setup/Installation Requirements**

1. Open https://ratta2ii.github.io/HairSalon.Solution
2. Clone repository to local machine
3. Navagate to the project directory (HairSalon)
4. $ dotnet restore
5. $ dotnet build 
6. $ dotnet run (to run the application in the browser)

#
   
### **SQL Statements (Database)**

##### Statement 1
#
CREATE TABLE `stylists` (
  `StylistId` int(11) NOT NULL AUTO_INCREMENT,
  `Name` varchar(255) DEFAULT NULL,
  `Specialty` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`StylistId`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
#

##### Statement 2
#
CREATE TABLE `clients` (
  `ClientId` int(11) NOT NULL AUTO_INCREMENT,
  `Name` varchar(255) DEFAULT NULL,
  `StylistId` int(11) DEFAULT '0',
  PRIMARY KEY (`ClientId`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
#
### **Technologies Used**


* C#
* netcoreapp2.2
* ASP.NET Core Mvc
* Razor
* Entity Framework (Core)
* Html
* Css
* Bootstrap

### **License**

Copyright (c) 2019 **Trevor Mackin**