namespace Contacts;

internal class Program
{
    private static void Main(string[] args)
    {
        var contactManager = new Contact();
        var contacts = new List<Contact>();

        var running = true;

        while (running)
        {
            Console.WriteLine("Contact Manager Menu");
            Console.WriteLine("------------------- ");
            Console.WriteLine("1. Add Contact");
            Console.WriteLine("2. View Contacts");
            Console.WriteLine("3. Exit");
            Console.Write("Please choose an option: ");
            
            string choice  = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    //Add new contact
                    Contact newContact = new Contact();
                    newContact.AddContact();
                    newContact.Save();
                    Console.WriteLine("Contact Successfully Added");
                    break;
                case "2":
                    //View all contacts
                    contacts = contactManager.GetContacts();
                    foreach (var contact in contacts)
                    {
                        contact.Print();
                    }

                    break;
                case "3":
                    // Exit the program
                    running = false;
                    Console.WriteLine("Exiting Contact Manager. Goodbye!");
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please select 1, 2, or 3.");
                    break;
            }
        }
    }
}