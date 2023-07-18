using CHallengeAPP;


Console.WriteLine("=======================================================================");
Console.WriteLine("Witaj w programie do oceny Twoich pracowników!");
Console.WriteLine("Aplikacja wyliczy minimalną, maksymalną oraz średnią z uzyskanych ocen.");
Console.WriteLine("Aby zakończyć wprowadzanie ocen wpisz literę: q.");
Console.WriteLine("=======================================================================");
Console.WriteLine();

var employee = new Employee("Wincent", "Adam");

while (true)
{
    Console.WriteLine("Wprowadz ocenę: ");
    var input = Console.ReadLine();
    if(input == "q" || input == "Q")
    {
        break;
    }
    employee.AddGrade(input);
}
var statistics = employee.GetStatistics();
Console.WriteLine("=======================================================================");
Console.WriteLine($"Oto wyniki pracownika: {employee.Name} {employee.Surname} ");
Console.WriteLine("=======================================================================");
Console.WriteLine($"Ocena literowa:     {statistics.AverageLetter}");
Console.WriteLine($"Średnia z ocen:     {statistics.Average}");
Console.WriteLine($"Wartość minimalna:  {statistics.Min}");
Console.WriteLine($"Wartość maksymalna: {statistics.Max}");
Console.WriteLine("=======================================================================");











