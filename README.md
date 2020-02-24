# GRestApiClient for C#/.Net

This project is a simple to use Rest api in c#.

## General info
### Features:
- request method: GET, POST, PUT, DELETE
- supports query
- supports headers
- Check succes status code response
- Generic desiaralization response message.

## Setup
[Nuget package](https://www.nuget.org/packages/GRestApiClient/). <br />
Compiling bin library is located in /bin folder. <br />
Copy files (.dll files) to your project.<br />

## Simple code example
```C#
string url = @"testurl.com/api";

RestClient client = new RestClient(url);

client.SendGET();    // send get request

ResponseObject response;
if (client.ResponseHasNoErrors())
  response = client.GetResponse<ResponseObject>();
```
For view examples click [here](https://github.com/Guzik1/RestApiClient_for_.Net/tree/master/Examples). <br />
Documentatio available [here](https://github.com/Guzik1/RestApiClient_for_.Net/blob/master/docs/RestApiClient.md).

## Built with
- .Net Core 3.1
- NUnit Framework (for testing)

## Status
Version: 1.0.0

## License
[MIT License](https://github.com/Guzik1/RestApiClient_for_.Net/blob/master/LICENSE) © [Sebastian Guzik](https://github.com/Guzik1).

