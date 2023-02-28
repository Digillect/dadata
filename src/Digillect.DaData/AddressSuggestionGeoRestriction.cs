namespace Digillect.DaData;

/// <summary>
/// Ограничение по радиусу окружности.
/// </summary>
public sealed class AddressSuggestionGeoRestriction
{
	/// <summary>
	/// Географическая широта.
	/// </summary>
	public double Lat { get; set; }

	/// <summary>
	/// Географическая долгота.
	/// </summary>
	public double Lon { get; set; }

	/// <summary>
	/// Радиус поиска в метрах.
	/// </summary>
	/// <remarks>
	/// По-умолчанию <c>100</c>, максимум <c>100000</c>.
	/// </remarks>
	public int? RadiusMeters { get; set; }
}
