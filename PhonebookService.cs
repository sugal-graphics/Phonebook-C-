using System.Net;

public class PhonebookService
{
    private Dictionary<string, string> _phonebook = new Dictionary<string, string>();

    public void AddContact()
    {
        while (true)
        {
            Console.Write("Enter name: ");
            string? _inputUserName = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(_inputUserName))
            {
                Console.WriteLine("Name cannot be empty");
                continue;
            }
            string name = _inputUserName.ToLower();

            while (true)
            {
                Console.Write("Enter number: ");
                string? _inputUserNumber = Console.ReadLine()?.ToLower();

                if (string.IsNullOrWhiteSpace(_inputUserNumber))
                {
                    Console.WriteLine("Number cannot be empty");
                    continue;
                }

                if (!long.TryParse(_inputUserNumber, out _))
                {
                    Console.WriteLine("Invalid number, only digits are allowed");
                    continue;
                }

                _phonebook[name] = _inputUserNumber;
                Console.WriteLine("Contact Added Succesfully....");
                return;
            }
        }

    }

    public void SearchContact()
    {
        Console.Write("Enter name: ");
        string? _inputUserName = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(_inputUserName))
        {
            Console.WriteLine("Invalid name");
            return;
        }
        string name = _inputUserName.ToLower();

        if (_phonebook.ContainsKey(name))
            Console.WriteLine($"Number: {_phonebook[name]}");
        else
            Console.WriteLine("Contact not found");

    }

    public void ViewAll()
    {
        Console.WriteLine("-----All Contacts-----");
        foreach (var contact in _phonebook)
        {

            Console.WriteLine($"{contact.Key} : {contact.Value}");
        }
    }

    public void DeleteContact()
    {
        Console.Write("Enter name: ");
        string? _inputUserName = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(_inputUserName))
        {
            Console.WriteLine("Name cannot be empty");
            return;
        }
        string name = _inputUserName.ToLower();
        if (_phonebook.Remove(name))
            Console.WriteLine("Contact deleted succesfully...");
        else
            Console.WriteLine("Contact not found..");
    }

    public void UpdateContact()
    {

        Console.Write("Enter name: ");
        string? _inputUserName = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(_inputUserName))
        {
            Console.WriteLine("Name cannot be empty");
            return;
        }

        string name = _inputUserName.ToLower();

        if (_phonebook.ContainsKey(name))
        {

            while (true)
            {
                Console.Write("Enter number: ");
                string? _newNumber = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(_newNumber))
                {
                    Console.WriteLine("Invalid number");
                    continue;
                }

                if (!long.TryParse(_newNumber, out _))
                {
                    Console.WriteLine("Invalid, Only digits are allowed");
                    continue;

                }

                _phonebook[name] = _newNumber;
                Console.WriteLine("Number added succesfully");
                return;

            }
        }

        else
        {
            Console.WriteLine("Contact not found..");
        }
    }
}



