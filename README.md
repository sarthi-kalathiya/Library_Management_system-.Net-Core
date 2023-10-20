# Library Management System (.NET Core)

## Project Purpose
The Library Management System is a .NET Core application designed to manage library resources, including students, books, authors, and book borrowings.

## Features

### Admin Section
- **Author Management**: Create, edit, and delete author information for the books in the system.
- **Book Management**: Easily add, edit, or remove books from the library catalog.
- **Student Management**: Add, update, or delete student profiles.
- **Borrowing System**: Admins can oversee the borrowing and returning of books by students.

## Instructions for Running the Project

### Prerequisites
Before you start, make sure you have the following software and dependencies installed on your system:
- .NET Core SDK (version X.X or later)
- Visual Studio Code or any .NET Core-compatible IDE
- Entity Framework Core (for database operations)
- SQL Server or a compatible database system

### Clone the Repository
1. **Clone the Repository**: Open your terminal or command prompt and navigate to your desired project directory. Use the following command to clone the repository:
   ```bash
   git clone https://github.com/sarthi-kalathiya/Library_Management_system-.Net-Core.git
2. **Set Up the Database**:
- Create a Database: Create a new database using your preferred database management system (e.g., SQL Server).
- Configure Connection String: In the project's appsettings.json file, update the connection string to match the details of your newly created database

3.**Configure Migration**:
- Apply Migrations: In your terminal or command prompt, navigate to the project directory where you cloned the repository.
- Run Migrations: Apply database migrations using the following command: dotnet ef database update

4. **Build and Run the Application**:
- Open Your IDE: Launch your preferred IDE, such as Visual Studio Code.
- Open the Project: Open the project within your IDE.
- Build and Run: Build the project to resolve dependencies and compile the code. Then, run the application from your IDE.


5. **Getting Started**:
Follow the on-screen instructions or consult any provided documentation to get started with the Library Management System.
You can create student profiles, manage books and authors, and perform various library management tasks.
Enjoy using the Library Management System!

## Contributors
- Kamani Richa (https://github.com/rk096)
- Kalathiya Sarthi (https://github.com/sarthi-kalathiya) 
