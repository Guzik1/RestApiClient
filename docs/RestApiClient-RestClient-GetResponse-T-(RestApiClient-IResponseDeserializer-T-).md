### [RestApiClient](./RestApiClient.md 'RestApiClient').[RestClient](./RestApiClient-RestClient.md 'RestApiClient.RestClient')
## RestClient.GetResponse&lt;T&gt;(RestApiClient.IResponseDeserializer&lt;T&gt;) Method
Get response generic object from response, using own response deserializer.  
```csharp
public T GetResponse<T>(RestApiClient.IResponseDeserializer<T> ownResponseDeserializer);
```
#### Type parameters
<a name='RestApiClient-RestClient-GetResponse-T-(RestApiClient-IResponseDeserializer-T-)-T'></a>
`T`  
Type of response object data.  
  
#### Parameters
<a name='RestApiClient-RestClient-GetResponse-T-(RestApiClient-IResponseDeserializer-T-)-ownResponseDeserializer'></a>
`ownResponseDeserializer` [RestApiClient.IResponseDeserializer&lt;](./RestApiClient-IResponseDeserializer-T-.md 'RestApiClient.IResponseDeserializer&lt;T&gt;')[T](#RestApiClient-RestClient-GetResponse-T-(RestApiClient-IResponseDeserializer-T-)-T 'RestApiClient.RestClient.GetResponse&lt;T&gt;(RestApiClient.IResponseDeserializer&lt;T&gt;).T')[&gt;](./RestApiClient-IResponseDeserializer-T-.md 'RestApiClient.IResponseDeserializer&lt;T&gt;')  
  
#### Returns
[T](#RestApiClient-RestClient-GetResponse-T-(RestApiClient-IResponseDeserializer-T-)-T 'RestApiClient.RestClient.GetResponse&lt;T&gt;(RestApiClient.IResponseDeserializer&lt;T&gt;).T')  
Response object  
