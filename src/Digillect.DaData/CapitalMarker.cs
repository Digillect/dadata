namespace Digillect.DaData;

/// <summary>
/// Признак центра района или региона.
/// </summary>
public enum CapitalMarker
{
	/// <summary>
	/// Центра района.
	/// </summary>
	/// <remarks>
	/// Московская обл, Одинцовский р-н, г Одинцово.
	/// </remarks>
	Area,

	/// <summary>
	/// Центр региона.
	/// </summary>
	/// <remarks>
	/// Новосибирская обл, г Новосибирск.
	/// </remarks>
	Region,

	/// <summary>
	/// Центр района и региона.
	/// </summary>
	/// <remarks>
	/// Томская обл, г Томск.
	/// </remarks>
	AreaAndRegion,

	/// <summary>
	/// Центральный район региона.
	/// </summary>
	/// <remarks>
	/// Тюменская обл, Тюменский р-н.
	/// </remarks>
	CentralAreaOfRegion,

	/// <summary>
	/// Ничего из перечисленного.
	/// </summary>
	/// <remarks>
	/// Московская обл, г Балашиха.
	/// </remarks>
	None
}
