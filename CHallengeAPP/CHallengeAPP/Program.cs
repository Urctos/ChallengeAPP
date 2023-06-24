// Klasa np użykownik systemu czy zamówienie 


User user2 = new User("Jan");
User user3 = new User("Ola");
User user4 = new User("Aleksander");

//user1.login = "Jan";

var name = user1.Login;
class User
{

    string login; // public - dostęp do zmiennej dostepny poza klasą
    string password; // jak nie ma modyfiktaora to z automatu jest private
    string name;

    public User(string login)  // uruchami się gyd twory się nowy obiekt
    {
        this.login = login;
    }
    public User(string login, string password)  
    {
        this.login = login;
        this.password = password;

    }

    public string Login { get; private set; }
    public string Password { get; private set; }

}



