# Leave Management API

This project is a simple **Leave Request Management System** built with **ASP.NET Core 8**, using **SQLite** for data storage and **Docker** for deployment.

---

## 🚀 Features

- Create, update, approve or reject leave requests
- Business rules enforced:
  - No overlapping leave dates per employee
  - Maximum 20 annual leave days per year
  - Sick leave requires a non-empty reason
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
