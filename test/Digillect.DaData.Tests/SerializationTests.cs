using System.Text.Json;
using Microsoft.Extensions.DependencyInjection;

namespace Digillect.DaData.Tests;

public class SerializationTests
{
	[Fact]
	public Task SerializeRequest()
	{
		var jsonSerializerOptions = DaDataServiceCollectionExtensions.GetJsonSerializerOptions(true);

		var request = SuggestAddressRequest
			.Create("Урюпинск")
			.UsingMunicipalDivision()
			.UsingLanguage("en")
			.From(AddressSuggestionBound.City)
			.To(AddressSuggestionBound.Settlement)
			.RestrictBySettlementType("район")
			.RestrictByLocation(12, 21, 50_000);

		string text = JsonSerializer.Serialize(request, jsonSerializerOptions);

		return Verify(text);
	}
}
