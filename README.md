# Booking Information Management System

## Description:
The Booking Information Management System is a Windows Forms application developed in C#. It is designed to handle booking operations, allowing the user to input booking data which is then stored in a text file. The application utilizes basic I/O operations, user interaction through forms, and data validation.

## Project Structure:
- **`Form1.cs`**: Contains the main form with user interface elements and logic to handle button clicks and data storage.
- **`Form1.resx`**: Resource file for the form, includes metadata and design properties.
- **`Program.cs`**: Contains the Main method, which is the entry point of the application.
- **`booking.csproj`**: MSBuild project file that defines how the build platform processes the project.
- **`booking.sln`**: Solution file used by Visual Studio to manage the project and its dependencies.

## Installation and Running the Project:
1. Ensure you have the `.NET 5.0 SDK` and `Visual Studio` installed on your machine.
2. Clone the repository or download the project files.  https://github.com/YasamanMVS/Semester3-Advanced-OOP-BookingForm.git
3. Open the solution file `booking.sln` in Visual Studio.
4. Build the solution by clicking on `Build > Build Solution`.
5. Run the application by clicking on `Debug > Start Without Debugging`.

## Features:
- **Data Input**: Allows users to input booking details such as Booking ID, Booking Date, Customer Name, and Flight Number.
- **Data Storage**: Stores the input data into a text file named `database.txt`.
- **User Feedback**: Provides a confirmation message once data is successfully uploaded. 
