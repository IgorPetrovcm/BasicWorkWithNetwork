# Отправка запросов с помощью HttpClient

Для отправки запросов, класс `HttpClient`, библиотеки `System.Net.Http`, предоставляет ряд **методов**:
+ `Send()/SendAsync()`: отправляет запрос в виде объекта `HttpRequestMessage` и получает ответ в виде объекта `HttpResponseMessage`.
+ `GetAsync()`: отправляет **Get** запрос на указанный адрес и получает ответ в виде объекта `HttpResponseMessage`.
+ `GetByteArrayAsync`: вотправляет **Get** запрос на указанный адрес и получает ответ в виде массиыва байтов.

Также есть методы, отправляющие не только **Get** запросы:
+ `PostAsync`: аналогично с `GetAsync()`, только метод отпрвки **POST**.
+ `PutAsync`: аналоогично.
+ `PatchAsync`
+ `DeleteAsync`