namespace Program;
using System.Net;
class Program
{
    static void Main()
    {
        //https://github.com/IgorPetrovcm/BasicWorkWithNetwork
        UriBuilder uriBuild = new UriBuilder();

        uriBuild.Scheme = "https";
        uriBuild.Host = "github.com";
        uriBuild.Path = "IgorPetrovcm/BasicWorkWithNetwork";

        Uri uri = uriBuild.Uri;
        System.Console.WriteLine(uri);
    }
}