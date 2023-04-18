namespace Digillect.DaData;

/// <summary>
/// Значения нахождения адреса относительно кольцевой.
/// </summary>
public enum BeltwayHit
{
	/// <summary>
	/// Внутри МКАД.
	/// </summary>
	InMkad,

	/// <summary>
	/// За МКАД.
	/// </summary>
	OutMkad,

	/// <summary>
	/// Внутри КАД (Санкт-Петербург).
	/// </summary>
	InKad,

	/// <summary>
	/// За КАД (Санкт-Петербург).
	/// </summary>
	OutKad
}
