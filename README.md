# **Employee Management System (EMS)**

A robust Employee Management System built with .NET 8 using Clean Architecture principles. The solution demonstrates Domain-Driven Design (DDD), SOLID principles, and CQRS pattern using MediatR. This project provides a simple yet scalable API for managing employees and their attendance records.

---

## **Project Features**

- **Employee Management**:
  - Add new employees with unique `EmployeeCode`.
  - Retrieve all employees sorted by salary (maximum to minimum).
  - Update employee details, ensuring no duplicate `EmployeeCode`.

- **Attendance Management**:
  - Track daily attendance records for employees.
  - Generate attendance reports with present/absent status.

- **Design Principles**:
  - Implements Clean Architecture to maintain separation of concerns.
  - Uses Domain-Driven Design (DDD) and SOLID principles for extensibility.
  - Employs MediatR for CQRS implementation, decoupling request handling logic.

---

## **Solution Structure**

The EMS solution adheres to the Clean Architecture structure, consisting of the following layers:

1. **API Layer**:
   - Handles HTTP requests and responses.
   - Configures middleware and routing for the application.

2. **Application Layer**:
   - Contains use cases and business logic.
   - Implements MediatR for command and query handling.

3. **Domain Layer**:
   - Defines core entities (`Employee`, `Attendance`) and business rules.

4. **Infrastructure Layer**:
   - Handles database context, migrations, and external integrations.
   - Contains seed data for predefined values.

---

## **Getting Started**

### **Prerequisites**

1. [.NET SDK 8](https://dotnet.microsoft.com/download/dotnet/8.0) installed.
2. [SQL Server](https://www.microsoft.com/en-us/sql-server) instance running.
3. [Visual Studio](https://visualstudio.microsoft.com/) or any IDE like JetBrains Rider.
4. [Entity Framework Core tools](https://learn.microsoft.com/en-us/ef/core/cli/dotnet) installed:
   ```bash
   dotnet tool install --global dotnet-ef
