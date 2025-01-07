
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
---
### Setup Instruction
1. **Clone the Repository**:

    ```
    git clone https://github.com/your-username/ems-solution.git
    cd ems-solution
2. **Configure Database**:
	- Update the connection string in `appsettings.json` to point to your SQL Server instance:
		```
	    "ConnectionStrings": {
	      "DefaultConnection": "Server=your-server;Database=EMS;MultipleActiveResult Sets=True;TrustServerCertificate=True"
	    }
3. **Apply Migrations**:
	- Create and update the database with seed data:
		```
		dotnet ef database update
4. **Run the Application**:
	```
	dotnet run --project EMS.API
5. **Access the API**:
	-   Open Swagger UI at `https://localhost:7275/swagger`.

---
### **Predefined Seed Data**

The solution includes predefined data for demonstration purposes:

1.  **Employees**:
    
    -   `John Doe (EMP001)`
    -   `Jane Smith (EMP002)`
2.  **Attendance Records**:
    
    -   Includes attendance history for both employees.
---
## **How to Use the API**

### **1. Get Employees Sorted by Salary**

-   **Endpoint**: `GET /api/Employee/salary`
-   **Response**:
    ```   
    [
      {
        "id": "employee1-id",
        "name": "John Doe",
        "employeeCode": "EMP001",
        "salary": 50000
      },
      {
        "id": "employee2-id",
        "name": "Jane Smith",
        "employeeCode": "EMP002",
        "salary": 45000
      }
    ]   

### **2. Update Employee Code**

-   **Endpoint**: `PUT /api/Employee/{id}/code`
-   **Body**:
    ```    
    "NEW_CODE"    
### **3. View Attendance**

-   **Endpoint**: `GET /api/Attendance/{employeeId}`
-   **Response**:
     ```
    [
      {
        "id": "attendance1-id",
        "date": "2023-12-31",
        "isPresent": true
      }
    ]  
----------

## **Contributing**

We welcome contributions to enhance this project! Follow these steps to contribute:

1.  Fork the repository.
2.  Create a new branch:
    ```    
    git checkout -b feature-name    
3.  Make your changes and commit them:
    ```    
    git commit -m "Add new feature"    
4.  Push your changes:
    ```
    git push origin feature-name
    
5.  Open a Pull Request.

----------

## **License**

This project is licensed under the MIT License. See the LICENSE file for details.

----------

## **Contact**

For any inquiries or suggestions, feel free to reach out:
-   **Email**: sujad.ud@outlook.com
- **LinkedIn**: [sujadud](https://linkedin.com/in/sujadud/)

If you like it, give me a star 🌟 
