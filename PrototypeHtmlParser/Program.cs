namespace Program ;
class Program 
{
    static string CorrectIndentation(int count) 
    {
        string indentation = "";
        for (int i = 0; i < count; i++)
        {
            indentation += "    ";
        }
        return indentation;
    }
    static void Main()
    {
        string html = @"<!doctype html> <html><head><meta charset=""utf-8"" /><title>Hello</title></head><body><h2>World</h2></body></html>";
        Stack<char> stack = new Stack<char>();

        int stringRouteCount = 0;

        int count = 0;
        while (html[count] != '>')
        {
            System.Console.Write(html[count]);
            count++;
        }
        System.Console.Write(html[count] + "\n");
        for (int i = count+1; i < html.Length; i++)
        {
            if (html[i] == '<')
            {
                int countToEndTag = 0;

                if (html[i+1] == '/')
                {
                    if (stringRouteCount > stack.Count)
                    {
                        stringRouteCount--;
                    }
                    stack.Pop();
                    Console.Write("\n" + CorrectIndentation(stack.Count));
                    while (html[i+countToEndTag] != '>')
                    {
                        System.Console.Write(html[i+countToEndTag]);
                        countToEndTag++;
                    }
                    System.Console.Write(html[i+countToEndTag]);
                    i += countToEndTag;
                    continue;
                }
                if (stringRouteCount > stack.Count)
                {
                    Console.Write("\n" + CorrectIndentation(stack.Count));
                    stringRouteCount--;
                }
                stack.Push('<');
                stringRouteCount++;
                while (html[i+countToEndTag] != '>' && html[i+countToEndTag] != '/' )
                {
                    Console.Write(html[i + countToEndTag]);
                    countToEndTag++;
                }
                if (html[i + countToEndTag] == '>')
                {
                    System.Console.Write(html[i+countToEndTag] + "\n" + CorrectIndentation(stack.Count));
                    i += countToEndTag;
                    continue;
                }
                if (html[i + countToEndTag] == '/')
                {                    
                    stack.Pop();
                    stringRouteCount--;
                    System.Console.Write(html[countToEndTag + i].ToString() + html[countToEndTag + i + 1].ToString() + "\n" + CorrectIndentation(stack.Count));
                    i += countToEndTag+1;
                    continue;
                }
            }
            Console.Write(html[i]);
        }
    }
}