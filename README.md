# Banking App Template
[![tech](https://img.shields.io/badge/powredby-.netcore-purple.svg)](https://dotnet.microsoft.com/en-us/download) [![NUnit License](https://img.shields.io/badge/powredby-NUnit-green.svg)](https://nunit.org/) [![Mediator](https://img.shields.io/badge/powredby-MediatR-blue.svg)](https://www.nuget.org/packages/mediatr/) [![DomainDrivenDesign](https://img.shields.io/badge/powredby-DDD-red.svg)](https://en.wikipedia.org/wiki/Domain-driven_design) [![Swagger](https://img.shields.io/badge/powredby-swagger-gree.svg)](https://swagger.io/) [![SeriLog](https://img.shields.io/badge/powredby-serilog-orange.svg)](https://serilog.net/)

This is a .NET Core solution template for a Microservice API using CQRS architecture with MediatR, Dapper, FluentValidation and Entity Framework Core.

## 📌 Features
- **CQRS Architecture** (MediatR)
- **Dapper** for efficient queries
- **Entity Framework Core** for persistence
- **NUnit** for unit testing
- **Web API** interface

## Project Structure

📂 ApplicationTemplate
 ├── 📂 src
    ├── 📂 ApplicationTemplate.API            # ASP.NET Core Web API
    ├── 📂 ApplicationTemplate.Domain         # Domain models
    ├── 📂 ApplicationTemplate.Infrastructure # Data access (EF Core)
 ├── 📂 ApplicationTemplate.Tests          # NUnit test project
 ├── 🗂️ ApplicationTemplate.sln


---

## 🚀 Installation

### **1️⃣ Install the Template**

1. Clone the repository
2. Open Application foler (cd application)
3. Run
```powershell
dotnet new --install .


### After Install use

```powershell
dotnet new MicroserviceAPI -n <YourSolutionName>
