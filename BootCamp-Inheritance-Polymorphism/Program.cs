using BootCamp_Inheritance_Polymorphism.Entities;
using System.Globalization;
using System.Runtime.InteropServices;


Console.Write("Outsourced (y/n): ");
string respOut = Console.ReadLine().ToLower();

Console.Write("Name: ");
string funcName = Console.ReadLine();

Console.WriteLine("Hours: ");
int workedHours = int.Parse(Console.ReadLine());

Console.WriteLine("Value per hour: ");
double valPerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


if (respOut == "y" || respOut == "Y")
{
    Console.WriteLine("Additional Charge: ");
    double additionalCharge = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    OutsourcedEmployee employee = new OutsourcedEmployee(additionalCharge, funcName, workedHours, valPerHour);
    Console.WriteLine($"{funcName}: {employee.Payment().ToString("F2", CultureInfo.InvariantCulture)}");
}

else
{
    Employee employee = new Employee(funcName, workedHours, valPerHour);
    Console.WriteLine($"{funcName}: {employee.Payment().ToString("F2", CultureInfo.InvariantCulture)}");
}





