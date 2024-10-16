# Application Architecture Project - Online Library System

## Project Overview

This project is developed as part of the **IMAT3914 Application Architecture** module for the academic year 2023/24. The aim is to build a web-based **Online Library System** using the **MVC (Model-View-Controller)** architecture in **Visual Studio 2022**, **ASP.NET**, and **C#**. The system provides users with an intuitive platform to browse, borrow, and review books online.

## Key Features

1. **User Registration and Authentication:**
   - Users can create accounts by providing personal details.
   - Secure authentication ensures safe user login and management, with optional two-factor authentication.

2. **Book Catalogue:**
   - A comprehensive catalogue of available books, including titles, authors, genres, and availability status.
   - High-quality book covers and summaries enhance the user experience.

3. **Search and Filters:**
   - Users can search for books based on title, author, genre, or availability.
   - Filtering options allow users to narrow down results for better navigation.

4. **Check-out and Check-in System:**
   - Users can borrow and return books electronically.
   - The system includes due date reminders for borrowed books.

5. **User Profile and History:**
   - Each user has a dedicated profile page displaying their borrowing history and reserved books.
   - Personalized experience based on user preferences and history.

6. **Payment System:**
   - Online payment functionality for managing outstanding fines or fees.

7. **Rating and Review System:**
   - Users can rate and review books they’ve borrowed, with displayed ratings helping others make informed decisions.

## Technologies Used

- **ASP.NET Core (MVC)**
- **C#**
- **Visual Studio 2022**
- **SQL Server** (for database management)

## Design and Architecture

- The project follows the **MVC (Model-View-Controller)** pattern, with the following components:
   - **Model**: Defines the data structures and logic for interacting with the database.
   - **View**: Renders the user interface and displays the data to the users.
   - **Controller**: Handles the user inputs, updates the model, and selects the appropriate view.

- **SOLID principles** and design patterns are followed to ensure scalability and maintainability.
- The system is designed with security best practices, including secure password handling and user input validation.

## Project Development

- The project has been built incrementally, starting with user authentication and expanding to include book management, borrowing systems, and user profiles.
- Automation scripts have been implemented for deployment and testing.

## How to Run the Project

1. Clone the repository:
   ```bash
   git clone https://github.com/lucrece456/Online-Library-System.git

Open the solution in Visual Studio 2022.
Build the project to restore dependencies.
Run the application using IIS Express or any configured web server.
Future Enhancements

Integration of advanced book recommendation algorithms based on user preferences.
Addition of real-time notifications for overdue books and fines.
Contact Information

For any questions or collaboration, feel free to reach out to me:

Helen Chris
Email:  Chrishelen410@gmail.com
License

This project is developed for academic purposes under the Application Architecture (IMAT3914) module and is open for educational collaboration.

