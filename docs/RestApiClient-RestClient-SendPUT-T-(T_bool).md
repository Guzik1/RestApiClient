### [RestApiClient](./RestApiClient.md 'RestApiClient').[RestClient](./RestApiClient-RestClient.md 'RestApiClient.RestClient')
## RestClient.SendPUT&lt;T&gt;(T, bool) Method
Send put request with data.  
```csharp
public void SendPUT<T>(T dataToSend, bool serializeData=true);
```
#### Type parameters
<a name='RestApiClient-RestClient-SendPUT-T-(T_bool)-T'></a>
`T`  
Type of data to send  
  
#### Parameters
<a name='RestApiClient-RestClient-SendPUT-T-(T_bool)-dataToSend'></a>
`dataToSend` [T](#RestApiClient-RestClient-SendPUT-T-(T_bool)-T 'RestApiClient.RestClient.SendPUT&lt;T&gt;(T, bool).T')  
generic object data to send (type T).  
  
<a name='RestApiClient-RestClient-SendPUT-T-(T_bool)-serializeData'></a>
`serializeData` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
True: serialize dataToSend and add to body request, false: add raw dataToSend to request body.  
  
