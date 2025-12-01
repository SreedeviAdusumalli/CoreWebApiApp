# 🚀 **CoreWebApiApp**

A fully functional **ASP.NET Core Web API** built using **.NET 8**,
designed for easy extension, testing, and deployment.\
This project demonstrates clean architecture, API best practices, and
deployment to **AWS Elastic Beanstalk**.

## 📌 **Features**

-   ✔ Built with **.NET 8 Web API**
-   ✔ Uses **Entity Framework Core** (optional based on your setup)
-   ✔ RESTful API endpoints (GET/POST/PUT/DELETE)
-   ✔ Swagger UI enabled for testing
-   ✔ Deployed on **AWS Elastic Beanstalk**
-   ✔ Ready for front-end integration (Angular / React / MVC)

## 📁 **Project Structure**

    CoreWebApiApp/
     ├── Controllers/
     ├── Models/
     ├── Services/
     ├── appsettings.json
     ├── Program.cs
     └── README.md

## ⚙️ **Prerequisites**

Before running the project, install:

-   .NET 8 SDK
-   Optional: SQL Server / LocalDB
-   Git
-   Visual Studio 2022 or VS Code

## ▶️ **How to Run Locally**

### 1. Clone the repo

    git clone https://github.com/<your-username>/CoreWebApiApp.git
    cd CoreWebApiApp

### 2. Restore packages

    dotnet restore

### 3. Run the API

    dotnet run

### 4. Open Swagger UI

    https://localhost:5001/swagger

## 🧪 **API Endpoints (Example)**

  Method   Endpoint              Description
  -------- --------------------- --------------------------
  GET      `/api/weather`        Get all weather records
  GET      `/api/weather/{id}`   Get weather by ID
  POST     `/api/weather`        Create new weather entry
  PUT      `/api/weather/{id}`   Update weather entry
  DELETE   `/api/weather/{id}`   Delete weather entry

## ☁️ **AWS Deployment (Elastic Beanstalk)**

### 1. Install AWS Toolkit for Visual Studio

Allows direct deployment from Visual Studio.

### 2. Publish the project

Right-click project → **Publish to AWS Elastic Beanstalk**

### 3. Configure environment

-   Platform: **.NET Core on Linux**
-   Instance: **t2.micro** (free-tier)
-   Deployment method: **Zip deploy**

### 4. Deploy

AWS gives an API URL like:

    http://corewebapiapp-env.eba-xyz123.ap-south-1.elasticbeanstalk.com/

### 5. Test with Postman or Browser

## 🔗 **Useful Git Commands**

    git init
    git remote add origin https://github.com/<your-username>/CoreWebApiApp.git
    git push -u origin main

## 📌 **Future Enhancements**

-   JWT authentication\
-   Database migrations\
-   Docker support\
-   AWS CI/CD pipeline

## 🙋 **Author**

**Sreedevi Adusumalli**\
.NET Developer \| AWS Learner \| API Enthusiast
