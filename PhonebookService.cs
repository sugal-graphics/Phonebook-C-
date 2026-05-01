using System.Net;

public class PhonebookService
{
    private Dictionary<string, string> _phonebook = new Dictionary<string, string>();

    public void AddContact()
    {
        while (true)
        {
            Console.Write("Enter name: ");
            string _inputUserName = Console.ReadLine()?.ToLower();

            if (string.IsNullOrWhiteSpace(_inputUserName))
            {
                Console.WriteLine("Name cannot be empty");
                continue;
            }

            while (true)
            {
                Console.Write("Enter number: ");
                string _inputUserNumber = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(_inputUserNumber))
                {
                    Console.WriteLine("Number cannot be empty");
                    continue;
                }

                _phonebook[_inputUserName] = _inputUserNumber;
                Console.WriteLine("Contact Added Succesfully....");
                return;
            }
        }

    }

    public void SearchContact()
    {
        Console.Write("Enter name: ");
        string _inputUserName = Console.ReadLine()?.ToLower();

        if (_phonebook.ContainsKey(_inputUserName))
            Console.WriteLine($"Number: {_phonebook[_inputUserName]}");
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
        string _inputUserName = Console.ReadLine()?.ToLower();

        if (_phonebook.Remove(_inputUserName))
            Console.WriteLine("Contact deleted succesfully...");
        else
            Console.WriteLine("Contact not found..");
    }

    public void UpdateContact()
    {
        Console.Write("Enter name: ");
        string _inputUserName = Console.ReadLine()?.ToLower();

        if (_phonebook.ContainsKey(_inputUserName))
        {
            Console.Write("Enter number: ");
            string _newNumber = Console.ReadLine();

            _phonebook[_inputUserName] = _newNumber;
            Console.WriteLine("Number added succesfully");

        }

        else
        {
            Console.WriteLine("Contact not found..");
        }
    }



}