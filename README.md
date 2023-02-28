# Digillect DaData.ru client

Implementation of the [DaData](https://dadata.ru/) features, based on HTTP Client through Refit. 

## Available features

- [Address suggestions](https://dadata.ru/api/suggest/address/) 
- [Address by FIAS/KLADR identifier](https://dadata.ru/api/find-address/)
- [City by IP address](https://dadata.ru/api/iplocate/)

## Usage

Register the client in DI container passing API key, if any:

```csharp
services.AddDaDataSuggestionsClient("123456");
```

Then inject the client into your services/controllers:

```csharp
[Route("/api/addresses")]
public sealed class AddressesController : ApiController
{
    private readonly IDaDataSuggestionsClient _client;
    
    public AddressesController(IDaDataSuggestionsClient client)
    {
        _client = client;
    }

    /// <summary>
    /// Suggests addresses for the specified query.
    /// </summary>
    [HttpGet("suggestions")]
    public Task<IReadOnlyList<AddressSuggestion>> GetSuggestionsAsync(string query) => _client.SuggestAddressAsync(query);
    
    /// <summary>
    /// Suggests cities for the specified query.
    /// </summary>
    [HttpGet("cities")]
    public async Task<IReadOnlyList<AddressSuggestion>> GetCitiesAsync(string query)
    {
        var request = SuggestAddressRequest.Create(query).From(SuggestAddressBound.City).To(SuggestAddressBound.City);
        var response = await _client.SuggestAddressAsync(request);
        
        return response.Suggestions;
    }
}
```
