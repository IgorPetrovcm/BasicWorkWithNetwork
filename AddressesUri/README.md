# Uri адреса .Net
**Uniform Resource Identifier (URI)** строка, которая глобально и уникально идентифицирует ресурс в сети.

**URI** и **URL** взаимозаменяемы.

## Из каких частей состоит **URL**
___
```csharp
схема: [/*[authority]path[query][#fragment]*/]
```
**authority** включает домен и порт, а также возможные данные пользователя, такие как логин и пароль:
```csharp
//[учетные данные доступа][@]домен/хост[:port]
```
Символ **@** отделяет учетные данные от домена. Например **учетные данные доступа**, записывают в виде:
```csharp
[user_id][:][password]
```

Компонент **query** иммет следующую форму:
```csharp
?[parametr1=value1]&[parametr2=value2]...
```

## System.Uri
___
Для использования класса для представления URI-адресов, используем класс `Uri`, библиотеки `System.Net`.
```csharp
using System.Net;
```

Самый простой способ реализовать экземпляр класса `Uri`:
```csharp
Uri uri = new Uri("https://github.com/IgorPetrovcm");
```

___
Для получение информации об адресе, класс `Uri` предоставляет ряд **свойств**:
+ `AbsoluteUri`:  возвращает абсолютный адрес URI
+ `Authority`: возвращает либо имя хоста в соответствии с системой доменных имен DNS, либо IP-адрес и порт сервера.
+ `Fragment`: возвращает фрагмент адреса URI.
+ `Host`: возвращает хост.
+ `IsAbsoluteUri`: возвращает true, если адрес абсолютный.
+ `IsDefaultPort`: возвращает true, если адрес URI использует порт по умолчанию для своей схемы.
+ `IsFile`: возвращает true, если адрес Uri представляет адрес файла.
+ `IsLoopback`: возвращает true, если адрес Uri указывает на локальный хост.
+ `OriginalString`: возвращает оригинальную строку адреса URI, которая передана в конструктор Uri.
+ `PathAndQuery`: возвращает значения свойств AbsolutePath и Query, разделяя их вопросительным знаком (?).
+ `Port`: возвращает номер порта для текущего адреса URI.
+ `Queri`: возвращает строку запроса из текущего адреса URI.
+ `Scheme`: возвращает схему текущего адреса URI.
+ `Segments`: возвращает массив сегментов пути для текущего адреса URI. Каждый сегмент представляет часть пути, которая ограничена слешами
+ `UserInfo`: возвращает имя и пароль пользователя.

**Пример исползования:**
```csharp
Uri uri = new Uri("https://github.com/IgorPetrovcm/BasicWorkWithNetwork/tree/main/AddressesUri");
        System.Console.WriteLine("Absolute path: " + uri.AbsolutePath);
        System.Console.WriteLine("Authority: " + uri.Authority);
        System.Console.WriteLine("Fragment: " + uri.Fragment);
        System.Console.WriteLine("Host: " + uri.Host);
        System.Console.WriteLine("Is absolute uri: " + uri.IsAbsoluteUri);
        System.Console.WriteLine("Is default port: " + uri.IsDefaultPort);
        System.Console.WriteLine("If file: " + uri.IsFile);
        System.Console.WriteLine("Is loop back: " + uri.IsLoopback);
        System.Console.WriteLine("Original string in construct: " + uri.OriginalString);
        System.Console.WriteLine("Path and query: " + uri.PathAndQuery);
        System.Console.WriteLine("Port: " + uri.Port);
        System.Console.WriteLine("Query: " + uri.Query);
        System.Console.WriteLine("Scheme: " + uri.Scheme);
        System.Console.WriteLine("Segments: " + string.Join(", ",uri.Segments));
        System.Console.WriteLine("User info: " + uri.UserInfo);
```
**Ответ компилятора:**
```
Absolute path: /IgorPetrovcm/BasicWorkWithNetwork/tree/main/AddressesUri
Authority: github.com
Fragment: 
Host: github.com
Is absolute uri: True
Is default port: True
If file: False
Is loop back: False
Original string in construct: https://github.com/IgorPetrovcm/BasicWorkWithNetwork/tree/main/AddressesUri
Path and query: /IgorPetrovcm/BasicWorkWithNetwork/tree/main/AddressesUri
Port: 443
Query: 
Scheme: https
Segments: /, IgorPetrovcm/, BasicWorkWithNetwork/, tree/, main/, AddressesUri
User info: 
```

## TryCreate
Статический метод `TryCreate` позволяет создать новый Url имея **абсолютный** и **относительный** адрес, их мы можем создать с помощью значений перечисления `UriKind` и одного из  конструкторов `Uri`:
```csharp
Uri uriAbsolute = new Uri("https://github.com", UriKind.Absolute) ;
Uri uriRelative = new Uri("IgorPetrovcm/BasicWorkWithNetwork/tree/main/AddressesUri", UriKind.Relative);
```
далее создаем экземпляр класса `Uri`, в который хотим передать полный URl, и:
``` csharp
Uri uri;
Uri.TryCreate(uriAbcolute, uriRelative, out uri);
```