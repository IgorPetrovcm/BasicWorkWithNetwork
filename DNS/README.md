# DNS in .Net

Для идентификации **ip-адресов** .Net предоставляет статический класс `Dns` библиотеки `System.Net`. Для получение **ip-адреса** класс `Dns` предоставляет методы:
+ `GetHostAddresses(string HostNameOrAddress)`: запрашивает у DNS сервера и возвращает все **ip-адреса** для этого хоста в виде массива `IPAddress[]`. У этого класса есть взаимозаменяемый асинхронный метод `GetHostAddresses(string HostNameOrAddress)`.
+ `GetHostEntry(HostNameOrAddress)`: возвоащает информацию с сервера DNS в виде объекта `IPHostEntry` для переданного хоста. У этого класса есть взаимозаменяемый асинхронный метод `GetHostEntryAsync(string HostNameOrAddress)`.
+ `GetHostName()`: возращает имя хоста для локального компьютера.

Далее в коде получим данные по адресу **github.com**:
```csharp
//Создаем эклемпляр IHostEntry и помещаем в него информацию о хосте github.com с помощью стат.класса Dns
 IPHostEntry git =Dns.GetHostEntry("github.com");
        System.Console.WriteLine(git.HostName);//"github.com"

//Проходимся по IEnumerable листу хранящему значения ip-адреса в объектах object
        foreach (var address in git.AddressList) {
            System.Console.WriteLine(address);
        }//140.82.121.4
        
//Объеденим значения свойства addressList с помощью '.' 
        string ipaddress = string.Join(".",git.AddressList.Cast<object>().ToArray());
        System.Console.WriteLine(ipaddress);//140.82.121.4
```