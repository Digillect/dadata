using System.Text.Json.Serialization;

namespace Digillect.DaData;

/// <summary>
/// Ограничения сектора поиска адреса.
/// </summary>
public sealed class AddressSuggestionLocationRestriction
{
	/// <summary>
	/// ISO-код страны.
	/// </summary>
	[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
	public string? CountryIsoCode { get; set; }

	/// <summary>
	/// ISO-код региона.
	/// </summary>
	[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
	public string? RegionIsoCode { get; set; }

	/// <summary>
	/// КЛАДР-код.
	/// </summary>
	[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
	public string? KladrId { get; set; }

	/// <summary>
	/// ФИАС-код.
	/// </summary>
	[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
	public string? FiasId { get; set; }

	/// <summary>
	/// Ограничение по названию страны.
	/// </summary>
	[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
	public string? Country { get; set; }

	/// <summary>
	/// Ограничение по названию региона.
	/// </summary>
	[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
	public string? Region { get; set; }

	/// <summary>
	/// Ограничение по названию района.
	/// </summary>
	[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
	public string? Area { get; set; }

	/// <summary>
	/// Ограничение по названию города.
	/// </summary>
	[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
	public string? City { get; set; }

	/// <summary>
	/// Ограничение по названию населённого пункта.
	/// </summary>
	[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
	public string? Settlement { get; set; }

	/// <summary>
	/// Ограничение по названию улицы.
	/// </summary>
	[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
	public string? Street { get; set; }

	/// <summary>
	/// Ограничение по полному типу региона.
	/// </summary>
	[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
	public string? RegionTypeFull { get; set; }

	/// <summary>
	/// Ограничение по полному типу района.
	/// </summary>
	[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
	public string? AreaTypeFull { get; set; }

	/// <summary>
	/// Ограничение по полному типу города.
	/// </summary>
	[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
	public string? CityTypeFull { get; set; }

	/// <summary>
	/// Ограничение по полному типу населённого пункта.
	/// </summary>
	[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
	public string? SettlementTypeFull { get; set; }

	/// <summary>
	/// Ограничение по полному типу улицы.
	/// </summary>
	[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
	public string? StreetTypeFull { get; set; }
}
