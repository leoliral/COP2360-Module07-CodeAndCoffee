# COP2360 – Module 7: Collections Group Project

**Group Name:** Code and Coffee  
**Course:** COP2360 – C# Programming  
**Instructor:** Scott G. Hammond

## Project Overview

For our Module 7 group project, we created a simple Employee Directory application using C#. The purpose of this program is to practice working with dictionaries, switch statements, loops, and basic data management.

The application stores employee IDs as keys and employee names and positions as values. Users can manage employee information through an interactive menu.

## Program Features

The program includes eight menu options:

1. **Populate Dictionary** – Adds three sample employees to the dictionary.
2. **Display Dictionary Contents** – Displays all employee IDs and their information.
3. **Remove an Employee** – Removes an employee using their ID.
4. **Add a New Employee** – Adds a new employee ID, name, and position.
5. **Add Information to an Employee** – Appends additional information to an existing employee.
6. **Sort Employee IDs** – Displays employee IDs in alphabetical order.
7. **Edit Employee Information** – Allows users to correct an employee's name or position.
8. **Exit** – Closes the application.

## How to Run the Program

1. Download the project from GitHub using **Code → Download ZIP**.
2. Extract the ZIP file to your computer.
3. Open the extracted project folder in Visual Studio Code.
4. Open **Terminal → New Terminal**.
5. Enter the following command:

   `dotnet run`

6. The Employee Directory menu will appear. Enter a number from 1 to 8 to select an option.

**Requirement:** The .NET SDK must be installed.

## Example

After selecting Option 1 to populate the dictionary and Option 2 to display it, the program shows:

```
E101: John Smith - Dispatcher
E103: Maria Lopez - Manager
E102: David Brown - Driver
```

Users can then add, remove, edit, or sort employee information.

## Group Members

- Leonardo Lira
- Bradley Cesar
- Jesus Cahue
- Alexandra Stephens
- Landon Lappeman

## Group Collaboration

Our group worked together throughout the project, with each member taking responsibility for different parts of the assignment.

- **Leonardo Lira:** GitHub repository setup, collaborator invitations, organizing project files, and preparing the final submission.
- **Bradley Cesar:** Functional testing, verifying program outputs, identifying possible issues, and helping troubleshoot errors.
- **Jesus Cahue:** Developed the initial C# code and made improvements based on the team's suggestions and feedback.
- **Alexandra Stephens:** Created and organized the README documentation, including the project overview, program features, and instructions for running the application.
- **Landon Lappeman:** Project coordination, reviewing assignment requirements, organizing team feedback, reviewing the final code, and ensuring everything was ready for submission.

### Team Testing and Communication

Testing was a shared responsibility. All five members participated in running the application, checking the dictionary operations, discussing possible improvements, and providing feedback.

We communicated throughout the project to review the program's functionality, address issues, and make sure all the assignment requirements were covered.

Although each member had specific responsibilities, the development, testing, and final review were a team effort.

## Conclusion

This project helped us practice using C# dictionaries to organize and manage information. We also used a switch statement to give users different options and a loop to keep the program running until they choose to exit.

The program includes comments explaining how each section works.

**Note:** Employee information is stored in memory and resets when the program is closed.
