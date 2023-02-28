namespace Digillect.DaData.Serialization;

internal sealed class CapitalMarkerConverter : EnumConverter<CapitalMarker>
{
	public CapitalMarkerConverter()
	{
		Add(CapitalMarker.None, "0");
		Add(CapitalMarker.Area, "1");
		Add(CapitalMarker.Region, "2");
		Add(CapitalMarker.AreaAndRegion, "3");
		Add(CapitalMarker.CentralAreaOfRegion, "4");
	}
}
