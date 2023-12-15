# Http in .Net
В **.Net** имеем класс `HttpMethod` библиотеки `System.Net.Http`. Для работы с запросами в приложении класс `HttpMethod` представляет статические свойства, которые возвращают обект `HttpMethod`, предоставляющий отдельный запрос:
+ `.Delete`
+ `.Get`
+ `.Head`
+ `.Options`
+ `.Patch`
+ `.Post`
+ `.Put`
+ `.Trace`
  
Если используется HTTP-метод, который не покрывается этими **свойствами**, то можно использовать **конструктор**, в который передается название метода:
```csharp
HttpMethod http = new HttpMethod("GET");
```

Сервер при ответе на запрос. По умолчанию этот код содержит **3 цифры** '404'. Существует пять групп статусных кодов:
+ `1XX`: запрос обрабатывается сервером.
+ `2XX`: запрос успешно обработан.
+ `3XX`: код переадресации.
+ `4XX`: указывает что со тороны клиента запрос ошибочный.
+ `5XX`: указывает что со стороны клиента запрос верен, но сервер работает некоректно.

В .Net за представление статусных кодов отвечсает перечислени `System.Net.HttpStatusCode`, иммет следующие константы:
+ `Continue`: **100**
+ `Processing`: **102**
+ `Accepted`: **202**
+ `AlreadyReported`: **208**
+ `Created`: **201**
+ `MultiStatus` **207**
+ `NoContent`: **204**
+ `OK`: **200**
+ `ResetContent`: **205**
+ `Ambiguous` **300**
+ `Found` **302**
+ `Moved` **301**
+ `PermanentRedirect` **303**
+ `BadRequest` **400**
+ `Conflict` **409**
+ `Locked` **423**
+ `NotFound` **404**

## Создание HttpClient
Для отправки **Http** запросов в **c#** существует класс `HttpClient` библиотеки `System.Net.Http`.

Для создания экземпляра класса `HttpClient` используем следующий конструктор класса:
```csharp
HttpClient http = new HttpClient(HttpMessageHandler handler)
```
Пример конструктора, работа с `Dispose` абстрактного класса `HttpMessageHandler`:
```csharp
HttpClient http = new HttpClient(HttpMessageHandler handler, bool disposeHandler)
```
В данном примере при передаче в `disposeHandler` - **true**, то объект `HttpMessageHandler` удаляется вместе с вызовом `HttpClient.Dispose`. При передаче в `disposeHandler` - false, то при удалении объекта `HttpClient`, `HttpMessageHandler` мы продолжим его использовать.

```csharp
HttpClient http = new HttpClient()
```
Этот конструктор эквивалентен следующим значениям:
```csharp
public HttpClient(new HttpMessageHandler, true)
```
