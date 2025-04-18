# Leave Management API

This project is a simple **Leave Request Management System** built with **ASP.NET Core 8**, using **SQLite** for data storage and **Docker** for deployment.

---

## 🚀 Features

- Create, update leave requests
- Business rules enforced:
  - No overlapping leave dates per employee
  - Maximum 20 annual leave days per year
  - Sick leave requires a non-empty reason
- filter, sort and search leave requests 
- Summary report with filters (by department, date range)
- Admin approval endpoint
- Dockerized for easy deployment

---

## 🛠️ Technologies

- .NET 8
- Entity Framework Core
- SQLite
- Docker
- Swagger (for API testing)

---

## 📦 Setup Instructions

1. Clone the repository:

```bash
git clone https://github.com/dhiaeddin123/.net-employees-api.git
cd .net-employees-api
exit

2. Run with docker :

```bash
docker build -t .net-employees-api .
docker run -p 5000:8080 .net-employees-api
exit

3. Access the API:

```bash
Swagger UI: http://localhost:5000/swagger

API Base URL: http://localhost:5000/api
exit
