namespace Program
{
    using System.Reflection.Metadata;
    using HtmlAgilityPack;
    class Program
    {
        static async Task Main()
        {
            HtmlDocument doc = new HtmlDocument();
            doc.Load("https://vc.ru/dev/148017-parsing-na-c-s-htmlagilitypack");
            HtmlNodeCollection collection = doc.GetElementbyId("id").ChildNodes;
            
        }   
    }
}