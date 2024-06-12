using BootCamp_Inheritance_Polymorphism.Entities;
using System.Globalization;
using System.Runtime.InteropServices;


List<Employee> employees = new List<Employee>();

Console.WriteLine("Digite a quantidade de funcionarios que deseja cadastrar");
int quantFunc = int.Parse(Console.ReadLine());

for (int i = 1; i <= quantFunc; i++)
{
    Console.WriteLine("============================================");
    Console.WriteLine($"Cadastrar funcionario: {i}");
    Console.WriteLine("============================================");

    Console.WriteLine("");

    Console.Write("Outsourced (y/n): ");
    string respOut = Console.ReadLine().ToLower();

    Console.Write("Name: ");
    string funcName = Console.ReadLine();

    Console.Write("Hours: ");
    int workedHours = int.Parse(Console.ReadLine());

    Console.Write("Value per hour: ");
    double valPerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

    Console.WriteLine("============================================");

    Console.WriteLine("");

    if (respOut == "y" || respOut == "Y")
    {
        Console.WriteLine("Additional Charge: ");
        double additionalCharge = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        OutsourcedEmployee employee = new OutsourcedEmployee(additionalCharge, funcName, workedHours, valPerHour);
        employees.Add(employee);
    }

    else
    {
        employees.Add(new Employee(funcName, workedHours, valPerHour));
    }

    Console.WriteLine("");
}

foreach (Employee emp in employees)
{
    Console.WriteLine($"{emp.GetName()} - $ {emp.Payment().ToString("F2", CultureInfo.InvariantCulture)}");
}





