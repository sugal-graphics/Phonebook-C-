public class AuthService
{
    private string _username;
    private string _password;

    public AuthService(string configPath)
    {
        string[] lines = File.ReadAllLines(configPath);
        _username = lines[0];
        _password = lines[1];
    }

    public bool login()
    {
        while (true)
        {
            Console.Write("Enter your username: ");
            string userInput = Console.ReadLine();

            Console.Write("Enter your password: ");
            string passwordInput = Console.ReadLine();

            if (userInput == _username && passwordInput == _password)
                return true;

            Console.WriteLine("---Invalid username and Password---");

        }
    }
}