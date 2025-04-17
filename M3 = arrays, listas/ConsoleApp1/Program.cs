using ConsoleApp1;
using System;
using System.Collections.Generic;
using System.Collections.Generic;
using System.Globalization;
using System.Numerics;

/* -- STUDENTS ROOMS
Console.Write("how many rooms will be occuped? ");
int rooms = int.Parse(Console.ReadLine());

Students[] students = new Students[rooms];

for (int i = 0; i < rooms; i++)
{
    Console.WriteLine($"Rent #{i + 1}:"); // Fixed increment issue
    Console.Write("Name: ");
    string name = Console.ReadLine();
    Console.Write("Email: ");
    string email = Console.ReadLine();
    Console.Write("Room: ");
    int room = int.Parse(Console.ReadLine());

    students[i] = new Students(name, email, room);
}

Console.WriteLine("Busy rooms:");

foreach (Students p in students)
{
    if (p != null) // Ensure null check to avoid runtime errors
    {
        Console.WriteLine($"{p.Room}: {p.Name}, {p.Email},"); // Fixed invalid statement
    }
}

*/

/* -- Employeesqqqqqaaaaaaaaaaaaaaaaaaaa

Console.Write("how many Employees will be occuped? ");
int impNumber = int.Parse(Console.ReadLine());

List<Employees> list = new List<Employees>();

for (int i = 0; i < impNumber; i++)
{
    Console.WriteLine($"Employee #{i + 1}:"); // Fixed increment issue
    Console.Write("Id: ");
    int id = int.Parse(Console.ReadLine());
    Console.Write("Name: ");
    string name = Console.ReadLine();
    Console.Write("Salary: ");
    double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

    list.Add(new Employees(name, id, salary));
}

Console.Write("Enter the employee id that will have salary increase : ");
int searchId = int.Parse(Console.ReadLine());

Employees emp = list.Find(x => x.Id == searchId); // Convert searchId to string
if (emp != null)
{
    Console.Write("Enter the percentage: ");
    double percentage = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    emp.SalaryIncrease(percentage);
}
else
{
    Console.WriteLine("This id does not exist!");
}

Console.WriteLine("Updated list of employees");

foreach (Employees emp1 in list)
{
    Console.WriteLine($"{emp1.Id}, {emp1.Name}, {emp1.Salary.ToString("F2")}");
}

*/

string[] values1 = Console.ReadLine().Split(' ');

int m = int.Parse(values1[0]);
int n = int.Parse(values1[1]);

int[,] mat = new int[m, n];

for (int i = 0; i < m; i++)
{
    string[] values = Console.ReadLine().Split(' ');
    for (int j = 0; j < n; j++)
    {
        mat[i, j] = int.Parse(values[j]);
    }
}

int x = int.Parse(Console.ReadLine());

for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        if (mat[i, j] == x)
        {
            Console.WriteLine("Position " + i + "," + j + ":");
            if (j > 0)
            {
                Console.WriteLine("Left: " + mat[i, j - 1]);
            }
            if (i > 0)
            {
                Console.WriteLine("Up: " + mat[i - 1, j]);
            }
            if (j < n - 1)
            {
                Console.WriteLine("Right: " + mat[i, j + 1]);
            }
            if (i < m - 1)
            {
                Console.WriteLine("Down: " + mat[i + 1, j]);
            }
        }
    }
}



