using CHallengeAPP;


Console.WriteLine("=======================================================================");
Console.WriteLine("Witaj w programie do oceny Twoich pracowników!");
Console.WriteLine("Aplikacja wyliczy minimalną, maksymalną oraz średnią z uzyskanych ocen.");
Console.WriteLine("Zakres ocen: 1-100");
Console.WriteLine("Aby zakończyć wprowadzanie ocen wpisz literę: q.");
Console.WriteLine("=======================================================================");
Console.WriteLine();

var employee = new EmployeeInMemory("Wincent", "Adam");
employee.GradeAdded += EmployeeGradeAdded;


while (true)
{
    Console.WriteLine("wprowadz ocenę: ");
    var input = Console.ReadLine();
    if (input == "q" || input == "q")
    {
        break;
    }

    try
    {
        employee.AddGrade(input);
        Console.WriteLine();
    }
    catch (Exception e)
    {
        Console.WriteLine($"nieprawidłowa ocena: {e.Message}");
    }

}
var statistics = employee.GetStatistics();
Console.WriteLine("=======================================================================");
//Console.WriteLine($"oto wyniki pracownika: {employee.name} {employee.surname} ");
//Console.WriteLine("=======================================================================");
Console.WriteLine($"ocena literowa:     {statistics.AverageLetter}");
Console.WriteLine($"średnia z ocen:     {statistics.Average}");
Console.WriteLine($"wartość minimalna:  {statistics.Min}");
Console.WriteLine($"wartość maksymalna: {statistics.Max}");
Console.WriteLine("=======================================================================");

void EmployeeGradeAdded(object sender, EventArgs args)
{
    Console.WriteLine("Dodano nową ocenę! ");
}








