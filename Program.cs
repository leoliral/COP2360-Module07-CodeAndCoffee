
using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        // Store employee IDs and employee information.
        Dictionary<string, string> employees = new();

        string choice = "";

        // Repeat the menu until the user selects Exit.
        while (choice != "7")
        {
            Console.WriteLine("\n===== EMPLOYEE DIRECTORY =====");
            Console.WriteLine("1. Populate Dictionary");
            Console.WriteLine("2. Display Dictionary Contents");
            Console.WriteLine("3. Remove an Employee");
            Console.WriteLine("4. Add a New Employee");
            Console.WriteLine("5. Add Information to an Employee");
            Console.WriteLine("6. Sort Employee IDs");
            Console.WriteLine("7. Exit");
            Console.WriteLine("8. Edit Employee Information");
            Console.Write("Enter your choice: ");

            choice = Console.ReadLine() ?? "";

            // Run the option selected by the user.
            switch (choice)
            {
                case "1":
                    // Add three sample employees.
                    employees.TryAdd("E101", "John Smith - Dispatcher");
                    employees.TryAdd("E103", "Maria Lopez - Manager");
                    employees.TryAdd("E102", "David Brown - Driver");

                    Console.WriteLine("Dictionary populated!");
                    break;

                case "2":
                    // Display employees using foreach.
                    if (employees.Count == 0)
                    {
                        Console.WriteLine("Dictionary is empty.");
                    }
                    else
                    {
                        foreach (var employee in employees)
                        {
                            Console.WriteLine(
                                $"{employee.Key}: {employee.Value}");
                        }
                    }
                    break;

                case "3":
                    // Remove an employee by ID.
                    Console.Write("Enter Employee ID to remove: ");
                    string removeId = Console.ReadLine() ?? "";

                    if (employees.Remove(removeId))
                        Console.WriteLine("Employee removed!");
                    else
                        Console.WriteLine("Employee not found.");
                    break;

                case "4":
                    // Add a new key and value.
                    Console.Write("Enter new Employee ID: ");
                    string newId = Console.ReadLine() ?? "";

                    Console.Write("Enter employee name and position: ");
                    string newInfo = Console.ReadLine() ?? "";

                    if (string.IsNullOrWhiteSpace(newId) ||
                        string.IsNullOrWhiteSpace(newInfo))
                    {
                        Console.WriteLine("ID and information are required.");
                    }
                    else if (employees.TryAdd(newId, newInfo))
                    {
                        Console.WriteLine("Employee added!");
                    }
                    else
                    {
                        Console.WriteLine("Employee ID already exists.");
                    }
                    break;

                case "5":
                    // Append information to an existing employee.
                    Console.Write("Enter existing Employee ID: ");
                    string existingId = Console.ReadLine() ?? "";

                    if (employees.ContainsKey(existingId))
                    {
                        Console.Write("Enter additional information: ");
                        string extraInfo = Console.ReadLine() ?? "";

                        if (!string.IsNullOrWhiteSpace(extraInfo))
                        {
                            employees[existingId] += " - " + extraInfo;
                            Console.WriteLine("Information updated!");
                        }
                        else
                        {
                            Console.WriteLine("No information entered.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Employee not found.");
                    }
                    break;

                case "6":
                    // Sort and display employee IDs alphabetically.
                    foreach (string id in employees.Keys.OrderBy(id => id))
                    {
                        Console.WriteLine($"{id}: {employees[id]}");
                    }
                    break;

                case "7":
                    Console.WriteLine("Goodbye!");
                    break;
                
                case "8":
                    // Edit the name or position of an existing employee.
                    Console.Write("Enter Employee ID to edit: ");
                    string editId = Console.ReadLine() ?? "";

                    if (employees.ContainsKey(editId))
                    {
                        // Show the current employee information.
                        Console.WriteLine("Current information: " + employees[editId]);

                        Console.Write("Enter corrected name and position: ");
                        string updatedInfo = Console.ReadLine() ?? "";

                        if (!string.IsNullOrWhiteSpace(updatedInfo))
                        {
                            // Replace the old value with the corrected information.
                            employees[editId] = updatedInfo;
                            Console.WriteLine("Employee information updated successfully!");
                        }
                        else
                        {
                            Console.WriteLine("No changes were made.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Employee ID not found.");
                    }
                    break;
    

                default:
                    Console.WriteLine("Invalid choice. Try again.");
                    break;
            }
        }
    }
}
