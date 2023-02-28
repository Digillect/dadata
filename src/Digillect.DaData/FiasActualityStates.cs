namespace Digillect.DaData;

/// <summary>
/// Признак актуальности адреса в ФИАС.
/// </summary>
public enum FiasActualityState
{
	/// <summary>
	/// Актуальный.
	/// </summary>
	Actual,

	/// <summary>
	/// Переименован.
	/// </summary>
	Renamed,

	/// <summary>
	/// Переподчинён.
	/// </summary>
	Reassigned,

	/// <summary>
	/// Удалён.
	/// </summary>
	Deleted
}
