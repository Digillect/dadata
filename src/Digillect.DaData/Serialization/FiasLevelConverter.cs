namespace Digillect.DaData.Serialization;

internal sealed class FiasLevelConverter : EnumConverter<FiasLevel>
{
	public FiasLevelConverter()
	{
		Add(FiasLevel.Country, "0");
		Add(FiasLevel.Region, "1");
		Add(FiasLevel.Area, "3");
		Add(FiasLevel.City, "4");
		Add(FiasLevel.CityArea, "5");
		Add(FiasLevel.Settlement, "6");
		Add(FiasLevel.Street, "7");
		Add(FiasLevel.House, "8");
		Add(FiasLevel.FlatOrRoom, "9");
		Add(FiasLevel.PlanningStructure, "65");
		Add(FiasLevel.Stead, "75");
		Add(FiasLevel.ForeignOrEmpty, "-1");
	}
}
