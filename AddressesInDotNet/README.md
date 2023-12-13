# Адреса в .Net
Используем библиотеку `System.Net`
```csharp
using System.Net;
```
ip-адрес в .Net представлен классом `IPAddress`. Для определения ip-адреса можно применять 
два конструктора класса `IPAddress`
```csharp
IPAddress ip = new IPAddress(new byte[] {127, 0, 0, 1});
IPAddress ip = new IPAddress(0x0100007F);
```
Оба способа ссылаются на адрес: **127.0.0.1**

### Статические методы Parse и TryParse
___
Удобный статический метод `Parse()`, принимает адрес в виде строки 
```csharp
IPAddress ip = IPAddress.Parse("127.0.0.1");
```
`ip` будет ссылаться на адрес: **127.0.0.1**
Строка с ip-адресом может содержать ошибку, чтобы избежать ошибки рекомендуется использовать метод `TryParse()`
```csharp
IPAddress ip;
IPAddress.TryParse("127.0.0.1error", out ip);
```