using System.Text.Json;
using Microsoft.Extensions.DependencyInjection;

namespace Digillect.DaData.Tests;

public class DeserializationTests
{
	[Theory]
	[InlineData("IN_MKAD", BeltwayHit.InMkad)]
	[InlineData("OUT_MKAD", BeltwayHit.OutMkad)]
	public void DeserializeBeltwayHit(string text, BeltwayHit expected)
	{
		TestDeserialization(text, expected);
	}

	[Theory]
	[InlineData("0", CapitalMarker.None)]
	[InlineData("1", CapitalMarker.Area)]
	[InlineData("2", CapitalMarker.Region)]
	[InlineData("3", CapitalMarker.AreaAndRegion)]
	[InlineData("4", CapitalMarker.CentralAreaOfRegion)]
	public void DeserializeCapitalMarker(string text, CapitalMarker expected)
	{
		TestDeserialization(text, expected);
	}

	[Theory]
	[InlineData("0", FiasActualityState.Actual)]
	[InlineData("1", FiasActualityState.Renamed)]
	[InlineData("33", FiasActualityState.Renamed)]
	[InlineData("42", FiasActualityState.Renamed)]
	[InlineData("51", FiasActualityState.Reassigned)]
	[InlineData("99", FiasActualityState.Deleted)]
	public void DeserializeFiasActualityState(string text, FiasActualityState expected)
	{
		TestDeserialization(text, expected);
	}

	[Theory]
	[InlineData("0", FiasLevel.Country)]
	[InlineData("1", FiasLevel.Region)]
	[InlineData("3", FiasLevel.Area)]
	[InlineData("4", FiasLevel.City)]
	[InlineData("5", FiasLevel.CityArea)]
	[InlineData("6", FiasLevel.Settlement)]
	[InlineData("7", FiasLevel.Street)]
	[InlineData("8", FiasLevel.House)]
	[InlineData("9", FiasLevel.FlatOrRoom)]
	[InlineData("65", FiasLevel.PlanningStructure)]
	[InlineData("75", FiasLevel.Stead)]
	[InlineData("-1", FiasLevel.ForeignOrEmpty)]
	public void DeserializeFiasLevel(string text, FiasLevel expected)
	{
		TestDeserialization(text, expected);
	}

	[Theory]
	[InlineData("0", GeoCoordinatesQuality.Exact)]
	[InlineData("1", GeoCoordinatesQuality.NearestHouse)]
	[InlineData("2", GeoCoordinatesQuality.Street)]
	[InlineData("3", GeoCoordinatesQuality.Settlement)]
	[InlineData("4", GeoCoordinatesQuality.City)]
	[InlineData("5", GeoCoordinatesQuality.NotDefined)]
	public void DeserializeGeoCoordinatesQuality(string text, GeoCoordinatesQuality expected)
	{
		TestDeserialization(text, expected);
	}

	private static void TestDeserialization<T>(string text, T expected)
		where T : Enum
	{
		var jsonSerializerOptions = DaDataServiceCollectionExtensions.GetJsonSerializerOptions();

		var result = JsonSerializer.Deserialize<T>($"\"{text}\"", jsonSerializerOptions);

		Assert.Equal(expected, result);
	}
}
