namespace Digillect.DaData;

/// <summary>
/// Информация о ближайшей к адресу станции метро.
/// </summary>
public sealed class SubwayStationProximity
{
	/// <summary>
	/// Название станции.
	/// </summary>
	public string Name { get; set; }

	/// <summary>
	/// Название линии.
	/// </summary>
	public string Line { get; set; }

	/// <summary>
	/// Расстояние до станции в километрах.
	/// </summary>
	public double Distance { get; set; }
}
