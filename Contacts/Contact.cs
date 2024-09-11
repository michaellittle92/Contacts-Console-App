namespace Contacts;

public class Contact
{
    private readonly string path = "/Users/michael/RiderProjects/Contacts/Contacts/Files/Contacts.txt";




    public Contact()
    {
        // Optionally initialize default values or just leave it empty
        Name = "Unknown";
        PhoneNumber = "N/A";
        Email = "N/A";

        // Ensure the path is correctly set up (if needed)
        path = "/Users/michael/RiderProjects/Contacts/Contacts/Files/Contacts.txt";
    }

    public Contact(string name, string phoneNumber, string email)
    {
        Name = name;
        PhoneNumber = phoneNumber;
        Email = email;
    }

    public Contact(int id, string name, string phoneNumber, string email)
    {
        Id = id;
        Name = name;
        PhoneNumber = phoneNumber;
        Email = email;
    }

    private int Id { get; set; }
    private string Name { get; set; }
    private string PhoneNumber { get; set; }
    private string Email { get; set; }

    public void AddContact()
    {
        Console.WriteLine("Add Contact");
        Console.WriteLine("----------");

        // Get Name
        Console.Write("Enter Name: ");
        Name = Console.ReadLine();

        // Get Phone Number
        Console.Write("Enter Phone Number: ");
        PhoneNumber = Console.ReadLine();

        // Get Email
        Console.Write("Enter Email: ");
        Email = Console.ReadLine();
    }
    public void Print()
    {
        Console.WriteLine("-------------");
        Console.WriteLine($"Position: {Id}");
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"PhoneNumber: {PhoneNumber}");
        Console.WriteLine($"Email: {Email}\n");
    }

    public void Save()
    {
        int newId = 1;  // Default value if no contacts exist
    
        // Check if file exists and read all lines
        if (File.Exists(path))
        {
            string[] lines = File.ReadAllLines(path);
        
            // Find the current highest ID by iterating through existing contacts
            foreach (string line in lines)
            {
                string[] elements = line.Split(',');
                if (elements.Length == 4)
                {
                    int currentId = int.Parse(elements[0]);
                    if (currentId >= newId)
                    {
                        newId = currentId + 1;  // Increment to get the new ID
                    }
                }
            }
        }

        // Assign the new ID to the contact
        Id = newId;

        // Append the new contact to the file
        File.AppendAllText(path, $"{Id},{Name},{PhoneNumber},{Email}\n");
    
        Console.WriteLine("Contact saved successfully.");
    }


    public List<Contact> GetContacts()
    {
        var contacts = new List<Contact>();
        if (File.Exists(path))
        {
            var content = File.ReadAllLines(path);

            foreach (var line in content)
            {
                var elements = line.Split(',');
                if (elements.Length == 4)
                {
                    var contact = new Contact(int.Parse(elements[0]), elements[1], elements[2], elements[3]);
                    contacts.Add(contact);
                }
            }
        }
        else
        {
            Console.WriteLine("Contact not found");
        }

        return contacts;
    }
}