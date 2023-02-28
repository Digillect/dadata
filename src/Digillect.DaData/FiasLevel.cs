namespace Digillect.DaData;

/// <summary>
/// Уровень детализации, до которого адрес найден в ФИАС (ГАР).
/// </summary>
public enum FiasLevel
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
	/// Район города.
	/// </summary>
	CityArea,

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
	/// Квартира или комната.
	/// </summary>
	FlatOrRoom,

	/// <summary>
	/// Планировочная структура.
	/// </summary>
	PlanningStructure,

	/// <summary>
	/// Земельный участок.
	/// </summary>
	Stead,

	/// <summary>
	/// Иностранный или пустой.
	/// </summary>
	ForeignOrEmpty
}
