namespace Program;
using System.Net;
class Program
{
    static void Main()
    {
        IPAddress ip = new IPAddress(new byte[] {127,0,0,1});
        System.Console.WriteLine(ip);

        ip = new IPAddress(0x0100007F);
        System.Console.WriteLine(ip);

        ip = IPAddress.Parse("127.0.0.1");
        System.Console.WriteLine(ip);

        IPAddress.TryParse("127.0.0.1error", out ip);
        System.Console.WriteLine(ip);
    }
}