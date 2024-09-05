using System.Net.Sockets;

namespace Contacts;

class Program
{
    static void Main(string[] args)
    {
        //1. Basic Structure - complete.
        //----------
        //Create class with Name, Phone number and email.
        // create object/class with hardcoded values, output contact to console. 

       // Contact con = new Contact("Michael", "03 9020 5961", "michaellittle92@gmail.com");
       // con.Print();

        //2. Create and Read 
        //----------
        // Let user input contact details, store values in list. 
        //Output all contact details to console, using a method (*I think it should be in the contact class???*). Make sure formatting is good.

        List<Contact> contacts = new List<Contact>();

        for (int i = 0; i < 2; i++)
        {
            Console.WriteLine("Add Contact");
            Console.WriteLine("----------");
            Console.WriteLine("Enter Name:");
            string name = Console.ReadLine();
            Console.WriteLine("Enter Phone Number:");
            string phoneNumber = Console.ReadLine();
            Console.WriteLine("Enter Email:");
            string email = Console.ReadLine();
            Contact cont = new Contact(name, phoneNumber, email);
            
            contacts.Add(cont);
        }

        foreach (Contact c in contacts)
        {
            c.Print();
        }

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
}