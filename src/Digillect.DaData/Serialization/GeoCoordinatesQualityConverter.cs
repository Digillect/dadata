namespace Digillect.DaData.Serialization;

internal sealed class GeoCoordinatesQualityConverter : EnumConverter<GeoCoordinatesQuality>
{
	public GeoCoordinatesQualityConverter()
	{
		Add(GeoCoordinatesQuality.Exact, "0");
		Add(GeoCoordinatesQuality.NearestHouse, "1");
		Add(GeoCoordinatesQuality.Street, "2");
		Add(GeoCoordinatesQuality.Settlement, "3");
		Add(GeoCoordinatesQuality.City, "4");
		Add(GeoCoordinatesQuality.NotDefined, "5");
	}
}
