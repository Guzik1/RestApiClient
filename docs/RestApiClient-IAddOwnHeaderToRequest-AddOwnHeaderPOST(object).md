#### [RestApiClient](./index.md 'index')
### [RestApiClient](./RestApiClient.md 'RestApiClient').[IAddOwnHeaderToRequest](./RestApiClient-IAddOwnHeaderToRequest.md 'RestApiClient.IAddOwnHeaderToRequest')
## IAddOwnHeaderToRequest.AddOwnHeaderPOST(object) Method
Method to add own header to post request. Call before message send.  
```csharp
System.Collections.Generic.Dictionary<string,string> AddOwnHeaderPOST(object POSTDataToSend);
```
#### Parameters
<a name='RestApiClient-IAddOwnHeaderToRequest-AddOwnHeaderPOST(object)-POSTDataToSend'></a>
`POSTDataToSend` [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')  
  
#### Returns
[System.Collections.Generic.Dictionary&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.Dictionary-2 'System.Collections.Generic.Dictionary`2')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.Dictionary-2 'System.Collections.Generic.Dictionary`2')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.Dictionary-2 'System.Collections.Generic.Dictionary`2')  
Dictionary where key is header name and value is header value.  
