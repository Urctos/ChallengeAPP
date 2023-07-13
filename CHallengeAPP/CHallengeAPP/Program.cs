using CHallengeAPP;

var employee = new Employee("Jan", "Kowalski");

employee.AddGrade(2);
employee.AddGrade(5);
employee.AddGrade(6.356);
employee.AddGrade(1555.34254);

var statistics = employee.GetStatistics();

//Console.WriteLine($"Average: " + statistics.Max);
Console.WriteLine($"Average: {statistics.Average:N2} "); 
Console.WriteLine($"Max: {statistics.Max} ");
Console.WriteLine($"MIn: {statistics.Min} ");







