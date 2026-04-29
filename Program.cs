using System.Globalization;

Dictionary<string, string> phonebook = new Dictionary<string, string>();

// string adminUserName = "Peng";
// string adminPassword = "784569";
string[] lines = File.ReadAllLines("config.txt");
string adminUserName = lines[0];
string adminPassword = lines[1];



while (true)
{
    Console.WriteLine("----Login to get contact access----");
    Console.WriteLine("Enter your username: ");
    string inputAdminUserName = Console.ReadLine();
    Console.WriteLine("Enter the password: ");
    string inputAdminPassword = Console.ReadLine();

    if (inputAdminUserName == adminUserName && inputAdminPassword == adminPassword)
    {

        break;
    }
    else
    {
        Console.WriteLine("Please input valid username and password");
    }

}
while (true)
{
    Console.WriteLine("----------Phone Book------------");
    Console.WriteLine("1. Add a contact");
    Console.WriteLine("2. Search contact");
    Console.WriteLine("3. View all contact");
    Console.WriteLine("4. Delete contact");
    Console.WriteLine("5. Edit contact");
    Console.WriteLine("6. Exit");
    Console.WriteLine();
    Console.WriteLine("Chose an option: ");

    string choice = Console.ReadLine();
    if (choice == "1")
    {

        while (true)
        {

            Console.Write("Enter your name: ");
            string username = Console.ReadLine().ToLower();

            if (!string.IsNullOrWhiteSpace(username))
            {
                while (true)
                {
                    Console.Write("Enter your mobile number: ");
                    string mobileNumber = Console.ReadLine();

                    if (!string.IsNullOrWhiteSpace(mobileNumber))
                    {
                        phonebook[username] = mobileNumber;
                        Console.WriteLine("Contact added succesfully....");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("---Mobile no cannot be empty---");
                    }

                }
                break;
            }
            else
            {
                Console.WriteLine("---Name cannot be empty---");
            }
        }
    }




    else if (choice == "2")
    {

        Console.Write("Please Enter name of contact: ");
        string searchContact = Console.ReadLine().ToLower();

        if (phonebook.ContainsKey(searchContact))
        {
            Console.WriteLine($"Number :{phonebook[searchContact]}");

        }
        else
        {
            Console.WriteLine("Sorry Username can't be found");

        }
    }

    else if (choice == "3")
    {
        Console.WriteLine("-------All contacts---------");
        foreach (var contact in phonebook)
        {
            Console.WriteLine($"{contact.Key}->{contact.Value}");
        }
    }

    else if (choice == "4")
    {
        Console.WriteLine("Please Enter name of contact you want to delete: ");
        string deleteContact = Console.ReadLine().ToLower();

        if (phonebook.Remove(deleteContact))
        {
            Console.WriteLine("Contact deleted...");

        }
        else
        {
            Console.WriteLine("Contact not found");
        }
    }

    else if (choice == "5")
    {
        Console.WriteLine("Please Enter name of contact you want to edit: ");
        string editContact = Console.ReadLine().ToLower();

        if (phonebook.ContainsKey(editContact))
        {
            Console.WriteLine("Enter your number: ");
            string newNumber = Console.ReadLine();

            phonebook[editContact] = newNumber;
            Console.WriteLine("Contact updated");
        }

    }
    else if (choice == "6")
    {
        break;
    }

    else
    {
        Console.WriteLine("Invalid option!");
    }

}




