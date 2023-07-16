using CHallengeAPP;

var employee = new Employee("Jan", "Kowalski");
var employee2 = new Employee("Jan", "Kozlowski");
var employee3 = new Employee("Jan", "Kanski");
var employee4 = new Employee("Jan", "Kotarowski");

employee.AddGrade(2);
employee.AddGrade(5);
employee.AddGrade(6.356);
employee.AddGrade(1555.34254);
employee2.AddGrade(2);
employee2.AddGrade(5);
employee2.AddGrade(6.356);
employee2.AddGrade(1555.34254);
employee3.AddGrade(2);
employee3.AddGrade(5);
employee3.AddGrade(6.356);
employee3.AddGrade(1555.34254);
employee4.AddGrade(2);
employee4.AddGrade(5);
employee4.AddGrade(6.356);
employee4.AddGrade(1555.34254);

var statistics = employee.GetStatistics();
var statistics2 = employee.GetStatisticsWithWhile();
var statistics3 = employee.GetStatisticsWithDoWhile();
var statistics4 = employee.GetStatisticsWithFor();

//Console.WriteLine($"Average: " + statistics.Max);
Console.WriteLine($"Average: {statistics.Average:N2} "); 
Console.WriteLine($"Max: {statistics.Max} ");
Console.WriteLine($"MIn: {statistics.Min} ");
Console.WriteLine($"Average: {statistics2.Average:N2} ");
Console.WriteLine($"Max: {statistics2.Max} ");
Console.WriteLine($"MIn: {statistics2.Min} ");
Console.WriteLine($"Average: {statistics3.Average:N2} ");
Console.WriteLine($"Max: {statistics3.Max} ");
Console.WriteLine($"MIn: {statistics3.Min} ");
Console.WriteLine($"Average: {statistics4.Average:N2} ");
Console.WriteLine($"Max: {statistics4.Max} ");
Console.WriteLine($"MIn: {statistics4.Min} ");







