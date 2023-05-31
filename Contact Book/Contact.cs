using System;
using System.Collections.Generic;

class Contact
{
    public string Name { get; set; }
    public string Email { get; set; }
    public string Phone { get; set; }

    public Contact(string name, string email, string phone)
    {
        Name = name;
        Email = email;
        Phone = phone;
    }
}

class ContactBook
{
    private List<Contact> contacts;

    public ContactBook()
    {
        contacts = new List<Contact>();
    }

    public void AddContact(Contact contact)
    {
        contacts.Add(contact);
        Console.WriteLine("Contact added successfully.");
    }

    public void SearchContact(string name)
    {
        bool found = false;

        foreach (Contact contact in contacts)
        {
            if (contact.Name.Equals(name, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Contact found:");
                Console.WriteLine("Name: " + contact.Name);
                Console.WriteLine("Email: " + contact.Email);
                Console.WriteLine("Phone: " + contact.Phone);
                found = true;
                break;
            }
        }

        if (!found)
        {
            Console.WriteLine("Contact not found.");
        }
    }

    public void UpdateContact(string name)
    {
        bool found = false;

        foreach (Contact contact in contacts)
        {
            if (contact.Name.Equals(name, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Enter new email (leave blank to keep existing):");
                string newEmail = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(newEmail))
                {
                    contact.Email = newEmail;
                }

                Console.WriteLine("Enter new phone number (leave blank to keep existing):");
                string newPhone = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(newPhone))
                {
                    contact.Phone = newPhone;
                }

                Console.WriteLine("Contact updated successfully.");
                found = true;
                break;
            }
        }

        if (!found)
        {
            Console.WriteLine("Contact not found.");
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        ContactBook contactBook = new ContactBook();
        bool exit = false;

        while (!exit)
        {
            Console.WriteLine();
            Console.WriteLine("1. Add a contact");
            Console.WriteLine("2. Search for a contact");
            Console.WriteLine("3. Update a contact");
            Console.WriteLine("4. Exit");

            Console.Write("Enter your choice: ");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.Write("Enter name: ");
                    string name = Console.ReadLine();
                    Console.Write("Enter email: ");
                    string email = Console.ReadLine();
                    Console.Write("Enter phone number: ");
                    string phone = Console.ReadLine();

                    Contact contact = new Contact(name, email, phone);
                    contactBook.AddContact(contact);
                    break;
                case 2:
                    Console.Write("Enter name to search: ");
                    string searchName = Console.ReadLine();
                    contactBook.SearchContact(searchName);
                    break;
                case 3:
                    Console.Write("Enter name to update: ");
                    string updateName = Console.ReadLine();
                    contactBook.UpdateContact(updateName);
                    break;
                case 4:
                    exit = true;
                    break;
                default:
                    Console.WriteLine("Invalid choice. Try again.");
                    break;
            }
        }
    }
}

