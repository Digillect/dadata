using System;
using System.Net.Http.Headers;
using System.Text.Json;
using System.Text.Json.Serialization;
using Digillect.DaData;
using Digillect.DaData.Serialization;
using Refit;

// ReSharper disable once CheckNamespace
namespace Microsoft.Extensions.DependencyInjection;

/// <summary>
/// Extension methods to register DaData clients.
/// </summary>
public static class DaDataServiceCollectionExtensions
{
	/// <summary>
	/// Registers DaData.ru suggestion service client.
	/// </summary>
	/// <param name="services">services container.</param>
	/// <param name="apiKey">DaData API key.</param>
	/// <param name="baseAddress">optional URL to override service base address.</param>
	/// <returns>Services container.</returns>
	public static IServiceCollection AddDaDataSuggestions(this IServiceCollection services, string apiKey, string? baseAddress = null)
	{
		Check.NotEmpty(apiKey, nameof(apiKey));

		var refitSettings = new RefitSettings {
			ContentSerializer = new SystemTextJsonContentSerializer(GetJsonSerializerOptions())
		};

		services.AddRefitClient<IDaDataSuggestionsClient>(refitSettings)
			.ConfigureHttpClient(client => {
				client.BaseAddress = new Uri(baseAddress ?? "https://suggestions.dadata.ru/suggestions");
				client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
				client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Token", apiKey);
			});

		return services;
	}

	/// <summary>
	/// Return JSON serialization options with all required converters registered.
	/// </summary>
	/// <param name="writeIndented">use JSON pretty printing.</param>
	/// <returns>Configured JSON serializer options.</returns>
	internal static JsonSerializerOptions GetJsonSerializerOptions(bool writeIndented = false)
	{
		var snakeCaseNamingPolicy = new JsonSnakeCaseNamingPolicy();

		var jsonSerializerOptions = new JsonSerializerOptions {
			PropertyNamingPolicy = snakeCaseNamingPolicy,
			Converters = {
				new BeltwayHitConverter(),
				new CapitalMarkerConverter(),
				new FiasActualityStateConverter(),
				new FiasLevelConverter(),
				new GeoCoordinatesQualityConverter(),
				new JsonStringEnumConverter(snakeCaseNamingPolicy)
			},
			WriteIndented = writeIndented
		};

		return jsonSerializerOptions;
	}
}
