EmergencyMateAPI

EmergencyMateAPI is the backend component of EmergencyMate, an Android application designed to provide users with access to emergency information and resources.

The API was developed using ASP.NET Core and provides the backend services required for communication between the Android application and the database.

OVERVIEW

EmergencyMateAPI follows a client-server architecture in which the Android application acts as the client and communicates with the backend through HTTP requests.

The API is responsible for receiving requests from the mobile application, processing application logic, and interacting with the database.

ARCHITECTURE

Android Application
|
| HTTP Requests
v
ASP.NET Core Web API
|
| Database Operations
v
Microsoft SQL Server

TECHNOLOGIES

* C#
* ASP.NET Core
* ASP.NET Core Web API
* REST API
* Microsoft SQL Server
* Visual Studio
* Git
* GitHub

PROJECT STRUCTURE

EmergencyMateAPI
├── EmergencyMateAPI.sln
├── EmergencyMateAPI
└── README.md

API ROLE

The backend provides the communication layer between the Android application and the database.

The mobile application sends HTTP requests to the API, which processes those requests and returns the corresponding responses.

The API is responsible for handling application data without requiring the Android application to communicate directly with the database.

INTEGRATION WITH EMERGENCYMATE

EmergencyMate is divided into two main components:

Mobile Application
Kotlin-based Android application responsible for the user interface and user interaction.

Backend API
ASP.NET Core Web API responsible for processing requests and communicating with the database.

The two components communicate through REST API endpoints.

REQUEST FLOW

Android Application
|
v
HTTP Request
|
v
EmergencyMateAPI
|
v
Application Logic
|
v
Database
|
v
HTTP Response
|
v
Android Application

PROJECT PURPOSE

This project was developed to gain practical experience in:

* Backend development with C#
* ASP.NET Core Web API development
* REST API integration
* Client-server architecture
* Database communication
* API design
* Backend integration with an Android application
* Git and GitHub version control

RELATED PROJECT

EmergencyMate is the Android client that consumes this API.

Android Application:
https://github.com/Xenviia/EmergencyMate

AUTHOR

Hilary Rodríguez

Software Development Student
