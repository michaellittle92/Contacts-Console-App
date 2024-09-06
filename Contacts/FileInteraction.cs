namespace Contacts;

public class FileInteraction
{
    private string filePath = @"./Contacts.txt"; 

    public void Initialization()
    {
        if (!File.Exists(filePath))
        {
            Console.WriteLine("Contacts.txt not found");
            
            try
            {
                Console.WriteLine("Creating Contacts.txt...");
                StreamWriter sw = File.CreateText(filePath);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }
    }
    

}