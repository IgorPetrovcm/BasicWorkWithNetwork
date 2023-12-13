namespace Program;
using System.Net;
class Program
{
    static void Main()
    {
        Uri uriAbsolute = new Uri("https://github.com",UriKind.Absolute);
        Uri uriRelative = new Uri("IgorPetrovcm/BasicWorkWithNetwork/tree/main/AddressesUri",UriKind.Relative);
        Uri uri;
        if (Uri.TryCreate(uriAbsolute, uriRelative, out uri)) 
        {
            System.Console.WriteLine("URL успешно создан: " + uri.OriginalString);
        }
        else System.Console.WriteLine("URL введен неправильно.");
    }
}