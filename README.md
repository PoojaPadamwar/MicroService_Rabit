# MicroService_Rabit
# Projects
MicroRabbit.Banking.Api
MicroRabbit.Banking.Application
MicroRabbit.Banking.Data
MicroRabbit.Domain.Core
MicroRabbit.Infra.Bus
MicroRabbit.Infra.IoC
MicroRabbit.MVC
MicroRabbit.Transfer.Api
MicroRabbit.Transfer.Application
MicroRabbit.Banking.Domain
MicroRabbit.Transfer.Data
MicroRabbit.Transfer.Domain
WebAPiApplication

# Notable features
Microservice architecture design pattern
RabbitMQ messaging

# Project notes
MicroRabbit.Banking.Api project is listening on localhost port 5001 (https) and 5000 (http) 

MicroRabbit.Transfer.Api project is listening on localhost port 5003 (https) and 5002 (http) 

MicroRabbit.MVC project is listeing on localhost port 5005 (https) and 5004 (http) 

Installation
Check if .NET Core Framework 3.1 and SQL Server 2016+ is installed on your machine. 
Next configure the database connection string in appsettings.json file before creating a needed database for MicroRabbit.Banking.Api and MicroRabbit.Transfer.Api project.

To create a database for MicroRabbit.Banking.Api project, select MicroRabbit.Banking.Data in Visual Studio as >Start Project< and execute the following commands in Package Manager Console:

Add-Migration "Initial Migration" -Context BankingDbContext
Update-database
To create a database for MicroRabbit.Transfer.Api project, select MicroRabbit.Transfer.Data in Visual Studio as >Start Project< and execute the following commands in Package Manager Console:

Add-Migration "Initial Migration" -Context TransferDbContext
Update-database
After successfully created the BankingDb and the TransferDb databases you can add some test data to Accounts and TransferLogs tables. Alternatively run the MicroRabbit.Banking.Api, MicroRabbit.Transfer.Api and MicroRabbit.MVC and use swagger or MVC form input to create test data.
