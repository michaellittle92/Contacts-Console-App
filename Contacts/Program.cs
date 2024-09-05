using System.Net.Sockets;

namespace Contacts;

class Program
{
    static void Main(string[] args)
    {
        //container that holds each contact. 
        List<Contact> contacts = new List<Contact>();

        //1. Basic Structure - complete.
        //----------
        //Create class with Name, Phone number and email.
        // create object/class with hardcoded values, output contact to console. 

        Contact contact1 = new Contact("Michael", "03 9020 5961", "michaellittle92@gmail.com");
        contacts.Add(contact1);

        //2. Create and Read 
        //----------
        // Let user input contact details, store values in list. 
        //Output all contact details to console, using a method (*I think it should be in the contact class???*). Make sure formatting is good.


       
            Console.WriteLine("Add Contact");
            Console.WriteLine("----------");
            Console.WriteLine("Enter Name:");
            string name = Console.ReadLine();
            Console.WriteLine("Enter Phone Number:");
            string phoneNumber = Console.ReadLine();
            Console.WriteLine("Enter Email:");
            string email = Console.ReadLine();
            Contact contact2 = new Contact(name, phoneNumber, email);
            
            contacts.Add(contact2);
            
            PrintAllContacts(contacts);
        
        //3. File Handling
        //----------
        //Create Text File if it doesn't exist. 
        //Save Contact to text file. 
        //Read from text file. 

        //4. Update and Delete 
        //----------
        //Update record in text file 
        //Delete record from text file. 

        //5. UX
        //----------
        //Add input validation, and enforce formatting requirements. 
        //Build out a nice menu
    }

    public static void PrintAllContacts(List<Contact> contacts)
    {
        Console.Clear();
        Console.WriteLine("All Contacts");
        
        foreach (Contact c in contacts)
        {
            c.Print();
        }
    }
}