namespace Digillect.DaData;

/// <summary>
/// Код точности координат.
/// </summary>
public enum GeoCoordinatesQuality
{
	/// <summary>
	/// Точные координаты.
	/// </summary>
	Exact,

	/// <summary>
	/// Ближайший дом.
	/// </summary>
	NearestHouse,

	/// <summary>
	/// Улица.
	/// </summary>
	Street,

	/// <summary>
	/// Населённый пункт.
	/// </summary>
	Settlement,

	/// <summary>
	/// Город.
	/// </summary>
	City,

	/// <summary>
	/// Координаты не определены.
	/// </summary>
	NotDefined
}
