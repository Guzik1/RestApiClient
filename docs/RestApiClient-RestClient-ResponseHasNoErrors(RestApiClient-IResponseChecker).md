### [RestApiClient](./RestApiClient.md 'RestApiClient').[RestClient](./RestApiClient-RestClient.md 'RestApiClient.RestClient')
## RestClient.ResponseHasNoErrors(RestApiClient.IResponseChecker) Method
Check response has no errors, with own response checker.  
```csharp
public bool ResponseHasNoErrors(RestApiClient.IResponseChecker checker);
```
#### Parameters
<a name='RestApiClient-RestClient-ResponseHasNoErrors(RestApiClient-IResponseChecker)-checker'></a>
`checker` [IResponseChecker](./RestApiClient-IResponseChecker.md 'RestApiClient.IResponseChecker')  
  
#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
True when response have no error, or false in else.  
