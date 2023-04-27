using System;
using System.Collections.Generic;

class AddressBook
{
    static List<Contact> contacts = new List<Contact>();
    
    static void Main()
    {
        bool exit = false;
        while (!exit)
        {
            Console.Clear();
            Console.WriteLine("Address Book");
            Console.WriteLine("1. View Contacts");
            Console.WriteLine("2. Add Contact");
            Console.WriteLine("3. Edit Contact");
            Console.WriteLine("4. Delete Contact");
            Console.WriteLine("5. Exit");

            switch (Console.ReadLine())
            {
                case "1":
                    ViewContacts();
                    break;
                case "2":
                    AddContact();
                    break;
                case "3":
                    EditContact();
                    break;
                case "4":
                    DeleteContact();
                    break;
                case "5":
                    exit = true;
                    break;
            }
        }
    }

    static void ViewContacts()
    {
        Console.Clear();
        Console.WriteLine("Contacts:");

        if (contacts.Count == 0)
        {
            Console.WriteLine("No contacts found.");
        }
        else
        {
            for (int i = 0; i < contacts.Count; i++)
            {
                Console.WriteLine("{0}. {1} ({2})", i + 1, contacts[i].Name, contacts[i].Email);
            }
        }

        Console.WriteLine();
        Console.WriteLine("Press any key to continue...");
        Console.ReadKey();
    }

    static void AddContact()
    {
        Console.Clear();
        Console.WriteLine("Add Contact");

        Console.Write("Name: ");
        string name = Console.ReadLine();

        Console.Write("Email: ");
        string email = Console.ReadLine();

        contacts.Add(new Contact(name, email));

        Console.WriteLine("Contact added successfully!");
        Console.WriteLine();
        Console.WriteLine("Press any key to continue...");
        Console.ReadKey();
    }

    static void EditContact()
    {
        Console.Clear();
        Console.WriteLine("Edit Contact");

        Console.Write("Enter contact number to edit: ");
        int index = int.Parse(Console.ReadLine()) - 1;

        Console.Write("Name: ");
        string name = Console.ReadLine();

        Console.Write("Email: ");
        string email = Console.ReadLine();

        contacts[index] = new Contact(name, email);

        Console.WriteLine("Contact edited successfully!");
        Console.WriteLine();
        Console.WriteLine("Press any key to continue...");
        Console.ReadKey();
    }

    static void DeleteContact()
    {
        Console.Clear();
        Console.WriteLine("Delete Contact");

        Console.Write("Enter contact number to delete: ");
        int index = int.Parse(Console.ReadLine()) - 1;

        contacts.RemoveAt(index);

        Console.WriteLine("Contact deleted successfully!");
        Console.WriteLine();
        Console.WriteLine("Press any key to continue...");
        Console.ReadKey();
    }
}

class Contact
{
    public string Name { get; set; }
    public string Email { get; set; }

    public Contact(string name, string email)
    {
        Name = name;
        Email = email;
    }
}

