namespace Program;
using System.Net;
using System.Text;

class Program 
{
    static void Main()
    {
        IPHostEntry git =Dns.GetHostEntry("github.com");
        System.Console.WriteLine(git.HostName);

        foreach (var address in git.AddressList) {
            System.Console.WriteLine(address);
        }
        
        string ipaddress = string.Join(".",git.AddressList.Cast<object>().ToArray());
        System.Console.WriteLine(ipaddress);
    }
}