# 🅿️ Parking Management System

A Windows desktop application for managing parking lots, users, and vehicle entry/exit tickets. Built with C# and SQL Server as a final project for the Software Architecture course in the Information Systems Engineering degree program.

---

## 📌 Project Overview

This application allows you to:

- Register users
- Register parking lots with maximum capacity
- Generate tickets when a vehicle enters a parking lot
- Register vehicle exits by closing the ticket
- Prevent new entries when the parking lot is full

It features a clean, user-friendly interface designed for simplicity and effective control.


## 🛠️ Technologies Used

- **Language:** C#  
- **Framework:** .NET Framework (Windows Forms)  
- **Database:** SQL Server  
- **Data Access:** ADO.NET  
- **IDE:** Visual Studio

---

## 🧩 Database Structure

### Tables

#### `Users`
- `IDUser (PK)`
- `Name`
- `Email`
- `Password`

#### `ParkingLots`
- `IDParking (PK)`
- `Name`
- `Address`
- `Capacity`

#### `Tickets`
- `IDTicket (PK)`
- `EntryTime`
- `ExitTime`
- `IDUser (FK)`
- `IDParking (FK)`

---

## 🚦 System Workflow

1. **Register a User**  
   Add user data and save it to the system.

2. **Create a Parking Lot**  
   Define name, address, and capacity.

3. **Generate a Ticket**  
   Select a user and parking lot. If capacity is available, a ticket is created with the current time.

4. **Register an Exit**  
   Select the ticket and mark the vehicle's exit. The exit time is recorded.

---

## 💻 How to Run the Project

1. Open the `.sln` file in Visual Studio
2. Ensure your SQL Server instance is running
3. Update the connection string in the code if necessary
4. Build and run the project with `F5`

---
