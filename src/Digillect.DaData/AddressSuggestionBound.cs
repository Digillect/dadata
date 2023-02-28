namespace Digillect.DaData;

/// <summary>
/// Значения границ для получения гранулярных подсказок по адресу.
/// </summary>
public enum AddressSuggestionBound
{
	/// <summary>
	/// Страна.
	/// </summary>
	Country,

	/// <summary>
	/// Регион.
	/// </summary>
	Region,

	/// <summary>
	/// Район.
	/// </summary>
	Area,

	/// <summary>
	/// Город.
	/// </summary>
	City,

	/// <summary>
	/// Населённый пункт.
	/// </summary>
	Settlement,

	/// <summary>
	/// Улица.
	/// </summary>
	Street,

	/// <summary>
	/// Дом.
	/// </summary>
	House,

	/// <summary>
	/// Квартира.
	/// </summary>
	Flat
}
