using Zad.dom_6;
Employee employee1 = new Employee("Andrzej", "Wielki", "18 lat");
Employee employee2 = new Employee("Rafał", "Długi", "20 lat");
Employee employee3 = new Employee("Piotr", "Szeroki", "22 lata");

employee1.AddScore(5);
employee1.AddScore(5);
employee1.AddScore(4);
employee1.AddScore(5);
employee1.AddScore(1);

employee2.AddScore(6);
employee2.AddScore(7);
employee2.AddScore(8);
employee2.AddScore(9);
employee2.AddScore(10);

employee3.AddScore(10);
employee3.AddScore(10);
employee3.AddScore(10);
employee3.AddScore(8);
employee3.AddScore(10);

List<Employee> employees = new List<Employee> { employee1, employee2, employee3 };

int maxResult = -1;
Employee employeeWithMaxResult = null;

foreach (var employee in employees)
{
    if (employee.Result > maxResult)
    {
        employeeWithMaxResult = employee;
        maxResult = employee.Result;
    }
}
Console.WriteLine("Pracownik najwyżej oceniony: " + employeeWithMaxResult.Name + " " + employeeWithMaxResult.Surname + " " + maxResult + "pkt");

