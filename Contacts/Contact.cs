namespace Contacts;


public class Contact
{
    private string Name { get; set; }
    private string PhoneNumber { get; set; }
    private string Email { get; set; }



    public Contact()
    {
        Console.WriteLine("Add Contact");
        Console.WriteLine("----------");
        Console.WriteLine("Enter Name:");
        string name = Console.ReadLine();
        Console.WriteLine("Enter Phone Number:");
        string phoneNumber = Console.ReadLine();
        Console.WriteLine("Enter Email:");
        string email = Console.ReadLine();
        
        Name = name;
        PhoneNumber = phoneNumber;
        Email = email;
    }
    
    public Contact(string name, string phoneNumber, string email)
    {
        Name = name;
        PhoneNumber = phoneNumber;
        Email = email;
    }

    public void Print()
    {
        Console.WriteLine("-------------");
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"PhoneNumber: {PhoneNumber}");
        Console.WriteLine($"Email: {Email}\n");
        
    }

    public void Save()
    {
        string obj = "test data";
        string path ="/Users/michael/RiderProjects/Contacts/Contacts/Files/Contacts.txt";

        if (!File.Exists(path))
        {
            File.WriteAllText(path, $"{Name} {PhoneNumber} {Email}\n");
           
        }
        else
        {
            
            File.AppendAllText(path, $"{Name} {PhoneNumber} {Email}\n");
        }
    }
    
}

