# EmergencyMate

EmergencyMate is an Android application designed to provide users with quick access to emergency information and essential resources from a single platform.

The project was developed as part of my university studies, focusing on mobile application development, REST API integration, backend development, database management, and user authentication.

## Overview

EmergencyMate brings together several emergency-related resources within a single mobile application. Users can register and log into the application, access emergency contacts, view emergency protocols, use an interactive map, and consult information related to emergency preparedness.

The application follows a client-server architecture, with an Android client communicating with an ASP.NET Core Web API connected to a SQL Server database.

## Features

* User registration and login
* Emergency contact information
* Emergency alert section
* Emergency protocols and evacuation information
* Virtual emergency kit
* Interactive map
* Emergency-related news
* User data management through a backend API

## Technologies

**Mobile Application**

* Kotlin
* Android Studio
* XML
* ConstraintLayout
* Retrofit
* Gson

**Backend**

* C#
* ASP.NET Core Web API
* REST API

**Database**

* Microsoft SQL Server

**Tools**

* Git
* GitHub
* Android Emulator

## Architecture

The application uses a client-server architecture:

```text
Android Application
        |
        | HTTP / REST API
        v
ASP.NET Core Web API
        |
        | Database Operations
        v
Microsoft SQL Server
```

The Android application communicates with the backend through REST API endpoints. The backend handles requests and manages the application's interaction with the SQL Server database.

## Authentication

EmergencyMate includes a registration and login system connected to the backend.

The authentication flow is:

```text
Android Application
        |
        v
Retrofit
        |
        v
ASP.NET Core API
        |
        v
SQL Server
```

User registration includes information such as name, surname, email, and password. The Android application sends this information to the API, which processes and stores the data in the database.

## Project Structure

The Android application is organized into activities, API services, data models, layouts, and resources.

```text
EmergencyMate
├── LoginActivity
├── RegisterActivity
├── MenuInicio
├── ApiClient
├── ApiService
├── LoginRequest
├── LoginResponse
├── activity_login.xml
├── activity_register.xml
└── Resources
```

## Screenshots

Screenshots of the main application screens will be included here to demonstrate the user interface and functionality.

## Development Goals

This project was developed to gain practical experience in:

* Android application development with Kotlin
* REST API development and integration
* Client-server communication
* Backend development with ASP.NET Core
* SQL Server database management
* User authentication
* Git and GitHub version control
* Mobile user interface development

## Future Improvements

Potential future improvements include:

* Google and Facebook authentication
* Push notifications for emergency alerts
* Enhanced location-based services
* Real-time emergency information
* Additional security measures
* Expanded emergency resources

## Author

**Hilary Rodríguez**

Software Development Student

[GitHub Profile](https://github.com/Xenviia)

