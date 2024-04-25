# Student Portal

Welcome to the Student Portal! This web application is built using the ASP.NET MVC framework and is designed to manage student information through CRUD (Create, Read, Update, Delete) operations. 

## Features

- **Create:** Add new student records with ease.
- **Read:** View existing student information conveniently.
- **Update:** Modify student details as necessary.
- **Delete:** Remove student records when needed.

## Technologies Used

- **Framework:** ASP.NET MVC
- **Frontend:** HTML, Bootstrape
- **Backend:** C# programming language
- **Database:** SQL Server

## Installation

1. **Clone the repository:**

    ```
    git clone <repository-url>
    ```

2. **Open the project in Visual Studio:**

    - Navigate to the project directory.
    - Open the solution file (`StudentPortal.sln`) in Visual Studio.

3. **Build the solution:**

    - Build the solution to restore packages and compile the project.

4. **Set up the database:**

    - Ensure you have SQL Server installed and running.
    - Update the connection string in `Web.config` to point to your SQL Server instance.
    - Run the Entity Framework migrations to create the database schema and seed initial data.

5. **Start the application:**

    - Press `F5` or click on the "Start" button in Visual Studio to run the application.
    - The application should launch in your default web browser.

## Usage

1. **Create Operation:**
    - Navigate to the "Students" section.
    - Click on the "Add Student" button.
    - Fill in the required information in the form.
    - Click on the "Save" button to add the student record.

2. **Read Operation:**
    - The list of existing student records is displayed on the homepage.
    - Click on a student's name to view their details.

3. **Update Operation:**
    - Navigate to the "Students" section.
    - Click on the "Edit" button next to the student record you wish to update.
    - Modify the information in the form.
    - Click on the "Save" button to update the student record.

4. **Delete Operation:**
    - Navigate to the "Students" section.
    - Click on the "Edit" button next to the student record you want to remove.
    - Click on the "Delete" button to update the student record.

## Contributing

Contributions are welcome! If you have suggestions, feature requests, or find any bugs, please open an issue or submit a pull request.

