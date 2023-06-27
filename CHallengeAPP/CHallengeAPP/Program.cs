// Klasa np użykownik systemu czy zamówienie 

using CHallengeAPP;

/*User user1 = new User("Ignacy", "434235");
User user2 = new User("Jan", "434235");
User user3 = new User("Ola", "434235");
User user4 = new User("Aleksander", "434235");

//user1.login = "Jan";

user2.AddScore(5);
user2.AddScore(2);

var result = user2.Result;
Console.WriteLine(result);
var name = User.GameName;
var pi = Math.PI; */

Employee nr1 = new Employee("Jan", "Kowalski", 23);
Employee nr2 = new Employee("MIchał", "Wolodyjowski", 45);
Employee nr3 = new Employee("Jeremi", "Wiśniowiecki", 47);

nr1.AddGrade(3);
nr1.AddGrade(7);
nr1.AddGrade(4);
nr1.AddGrade(2);
nr1.AddGrade(4);

nr2.AddGrade(3);
nr2.AddGrade(3);
nr2.AddGrade(3);
nr2.AddGrade(3);
nr2.AddGrade(3);

nr3.AddGrade(1);
nr3.AddGrade(3);
nr3.AddGrade(2);
nr3.AddGrade(5);
nr3.AddGrade(3);

//var result = nr1.Result;

List<Employee> employees = new List<Employee>()
{
    nr1, nr2, nr3
};

int maxGrade = -1;
Employee nrWithMaxResult = null;



foreach (var nr in employees)
{
    if (nr.Result > maxGrade)
    {
        nrWithMaxResult = nr;
        maxGrade = nr.Result;
    }

    
}

Console.WriteLine(nrWithMaxResult.Name);





