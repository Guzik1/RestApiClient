#### [RestApiClient](./index.md 'index')
### [RestApiClient](./RestApiClient.md 'RestApiClient')
## RestClient Class
Rest client manager.  
```csharp
public class RestClient
```
Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &gt; [RestClient](./RestApiClient-RestClient.md 'RestApiClient.RestClient')  
### Constructors
- [RestClient(string)](./RestApiClient-RestClient-RestClient(string).md 'RestApiClient.RestClient.RestClient(string)')
### Properties
- [GetResponseToString](./RestApiClient-RestClient-GetResponseToString.md 'RestApiClient.RestClient.GetResponseToString')
- [GetStatusCode](./RestApiClient-RestClient-GetStatusCode.md 'RestApiClient.RestClient.GetStatusCode')
- [ResponseHasSuccessStatusCode](./RestApiClient-RestClient-ResponseHasSuccessStatusCode.md 'RestApiClient.RestClient.ResponseHasSuccessStatusCode')
### Methods
- [AddOwnHeaderToRequest(RestApiClient.IAddOwnHeaderToRequest)](./RestApiClient-RestClient-AddOwnHeaderToRequest(RestApiClient-IAddOwnHeaderToRequest).md 'RestApiClient.RestClient.AddOwnHeaderToRequest(RestApiClient.IAddOwnHeaderToRequest)')
- [AddQuery(System.Collections.Generic.Dictionary&lt;string,string&gt;)](./RestApiClient-RestClient-AddQuery(System-Collections-Generic-Dictionary-string_string-).md 'RestApiClient.RestClient.AddQuery(System.Collections.Generic.Dictionary&lt;string,string&gt;)')
- [AddQuery(object)](./RestApiClient-RestClient-AddQuery(object).md 'RestApiClient.RestClient.AddQuery(object)')
- [GetResponse&lt;T&gt;()](./RestApiClient-RestClient-GetResponse-T-().md 'RestApiClient.RestClient.GetResponse&lt;T&gt;()')
- [GetResponse&lt;T&gt;(RestApiClient.IResponseDeserializer&lt;T&gt;)](./RestApiClient-RestClient-GetResponse-T-(RestApiClient-IResponseDeserializer-T-).md 'RestApiClient.RestClient.GetResponse&lt;T&gt;(RestApiClient.IResponseDeserializer&lt;T&gt;)')
- [GetResponseDynamic()](./RestApiClient-RestClient-GetResponseDynamic().md 'RestApiClient.RestClient.GetResponseDynamic()')
- [ResponseHasNoErrors()](./RestApiClient-RestClient-ResponseHasNoErrors().md 'RestApiClient.RestClient.ResponseHasNoErrors()')
- [ResponseHasNoErrors(RestApiClient.IResponseChecker)](./RestApiClient-RestClient-ResponseHasNoErrors(RestApiClient-IResponseChecker).md 'RestApiClient.RestClient.ResponseHasNoErrors(RestApiClient.IResponseChecker)')
- [SendDELETE()](./RestApiClient-RestClient-SendDELETE().md 'RestApiClient.RestClient.SendDELETE()')
- [SendGET()](./RestApiClient-RestClient-SendGET().md 'RestApiClient.RestClient.SendGET()')
- [SendPOST&lt;T&gt;(T)](./RestApiClient-RestClient-SendPOST-T-(T).md 'RestApiClient.RestClient.SendPOST&lt;T&gt;(T)')
- [SendPUT&lt;T&gt;(T)](./RestApiClient-RestClient-SendPUT-T-(T).md 'RestApiClient.RestClient.SendPUT&lt;T&gt;(T)')
- [WriteResponseInScreen()](./RestApiClient-RestClient-WriteResponseInScreen().md 'RestApiClient.RestClient.WriteResponseInScreen()')
