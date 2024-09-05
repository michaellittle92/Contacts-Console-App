namespace Contacts;

public class Contact
{
    private string Name { get; set; }
    private string PhoneNumber { get; set; }
    private string Email { get; set; }

    public Contact(string name, string phoneNumber, string email)
    {
        Name = name;
        PhoneNumber = phoneNumber;
        Email = email;
    }

    public void Print()
    {
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"PhoneNumber: {PhoneNumber}");
        Console.WriteLine($"Email: {Email}");
    }
}

