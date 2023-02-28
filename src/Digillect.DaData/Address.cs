using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace Digillect.DaData;

/// <summary>
/// Адрес.
/// </summary>
public class Address
{
	/// <summary>
	/// Индекс.
	/// </summary>
	public string? PostalCode { get; set; }

	/// <summary>
	/// Страна.
	/// </summary>
	public string? Country { get; set; }

	/// <summary>
	/// ISO-код страны (двухсимвольный).
	/// </summary>
	public string? CountryIsoCode { get; set; }

	/// <summary>
	/// Федеральный округ.
	/// </summary>
	public string? FederalDistrict { get; set; }

	/// <summary>
	/// ФИАС-код региона.
	/// </summary>
	public string? RegionFiasId { get; set; }

	/// <summary>
	/// КЛАДР-код региона.
	/// </summary>
	public string? RegionKladrId { get; set; }

	/// <summary>
	/// ISO-код региона.
	/// </summary>
	public string? RegionIsoCode { get; set; }

	/// <summary>
	/// Регион с типом.
	/// </summary>
	public string? RegionWithType { get; set; }

	/// <summary>
	/// Тип региона (сокращённый).
	/// </summary>
	public string? RegionType { get; set; }

	/// <summary>
	/// Тип региона.
	/// </summary>
	public string? RegionTypeFull { get; set; }

	/// <summary>
	/// Регион.
	/// </summary>
	public string? Region { get; set; }

	/// <summary>
	/// ФИАС-код района в регионе.
	/// </summary>
	public string? AreaFiasId { get; set; }

	/// <summary>
	/// КЛАДР-код района в регионе.
	/// </summary>
	public string? AreaKladrId { get; set; }

	/// <summary>
	/// Район в регионе с типом.
	/// </summary>
	public string? AreaWithType { get; set; }

	/// <summary>
	/// Тип района в регионе (сокращённый).
	/// </summary>
	public string? AreaType { get; set; }

	/// <summary>
	/// Тип района в регионе.
	/// </summary>
	public string? AreaTypeFull { get; set; }

	/// <summary>
	/// Район в регионе.
	/// </summary>
	public string? Area { get; set; }

	/// <summary>
	/// ФИАС-код муниципального поселения.
	/// </summary>
	public string? SubAreaFiasId { get; set; }

	/// <summary>
	/// КЛАДР-код муниципального поселения.
	/// </summary>
	public string? SubAreaKladrId { get; set; }

	/// <summary>
	/// Муниципальное поселение с типом.
	/// </summary>
	public string? SubAreaWithType { get; set; }

	/// <summary>
	/// Тип муниципального поселения (сокращённый).
	/// </summary>
	public string? SubAreaType { get; set; }

	/// <summary>
	/// Тип муниципального поселения.
	/// </summary>
	public string? SubAreaTypeFull { get; set; }

	/// <summary>
	/// Муниципальное поселение.
	/// </summary>
	public string? SubArea { get; set; }

	/// <summary>
	/// ФИАС-код города.
	/// </summary>
	public string? CityFiasId { get; set; }

	/// <summary>
	/// КЛАДР-код города.
	/// </summary>
	public string? CityKladrId { get; set; }

	/// <summary>
	/// Город с типом.
	/// </summary>
	public string? CityWithType { get; set; }

	/// <summary>
	/// Тип города (сокращённый).
	/// </summary>
	public string? CityType { get; set; }

	/// <summary>
	/// Тип города.
	/// </summary>
	public string? CityTypeFull { get; set; }

	/// <summary>
	/// Город.
	/// </summary>
	public string? City { get; set; }

	/// <summary>
	/// Административный округ (только для Москвы).
	/// </summary>
	/// <remarks>
	/// Доступно только при использовании платного тарифа.
	/// </remarks>
	public string? CityArea { get; set; }

	/// <summary>
	/// ФИАС-код административного района города.
	/// </summary>
	public string? CityDistrictFiasId { get; set; }

	/// <summary>
	/// КЛАДР-код административного района города (не заполняется).
	/// </summary>
	[EditorBrowsable(EditorBrowsableState.Never)]
	public string? CityDistrictKladrId { get; set; }

	/// <summary>
	/// Административный район города с типом.
	/// </summary>
	public string? CityDistrictWithType { get; set; }

	/// <summary>
	/// Тип административного района города (сокращённый).
	/// </summary>
	public string? CityDistrictType { get; set; }

	/// <summary>
	/// Тип административного района города.
	/// </summary>
	public string? CityDistrictTypeFull { get; set; }

	/// <summary>
	/// Административный район города.
	/// </summary>
	public string? CityDistrict { get; set; }

	/// <summary>
	/// ФИАС-код населённого пункта.
	/// </summary>
	public string? SettlementFiasId { get; set; }

	/// <summary>
	/// КЛАДР-код населённого пункта.
	/// </summary>
	public string? SettlementKladrId { get; set; }

	/// <summary>
	/// Населённый пункт с типом.
	/// </summary>
	public string? SettlementWithType { get; set; }

	/// <summary>
	/// Тип населённого пункта (сокращённый).
	/// </summary>
	public string? SettlementType { get; set; }

	/// <summary>
	/// Тип населённого пункта.
	/// </summary>
	public string? SettlementTypeFull { get; set; }

	/// <summary>
	/// Населённый пункт.
	/// </summary>
	public string? Settlement { get; set; }

	/// <summary>
	/// ФИАС-код улицы.
	/// </summary>
	public string? StreetFiasId { get; set; }

	/// <summary>
	/// КЛАДР-код улицы.
	/// </summary>
	public string? StreetKladrId { get; set; }

	/// <summary>
	/// Улица с типом.
	/// </summary>
	public string? StreetWithType { get; set; }

	/// <summary>
	/// Тип улицы (сокращённый).
	/// </summary>
	public string? StreetType { get; set; }

	/// <summary>
	/// Тип улицы.
	/// </summary>
	public string? StreetTypeFull { get; set; }

	/// <summary>
	/// Улица.
	/// </summary>
	public string? Street { get; set; }

	/// <summary>
	/// ФИАС-код земельного участка.
	/// </summary>
	public string? SteadFiasId { get; set; }

	/// <summary>
	/// КЛАДР-код земельного участка.
	/// </summary>
	public string? SteadKladrId { get; set; }

	/// <summary>
	/// Тип земельного участка (сокращённый).
	/// </summary>
	/// <remarks>
	/// В настоящий момент возвращается значение <с>уч</с>.
	/// </remarks>
	public string? SteadType { get; set; }

	/// <summary>
	/// Тип земельного участка.
	/// </summary>
	/// <remarks>
	/// В настоящий момент возвращается значение <с>участок</с>.
	/// </remarks>
	public string? SteadTypeFull { get; set; }

	/// <summary>
	/// Номер земельного участка.
	/// </summary>
	public string? Stead { get; set; }

	/// <summary>
	/// Кадастровый номер земельного участка.
	/// </summary>
	/// <remarks>
	/// Доступен только при использовании тарифа "Максимальный".
	/// </remarks>
	public string? SteadCadnum { get; set; }

	/// <summary>
	/// ФИАС-код дома.
	/// </summary>
	public string? HouseFiasId { get; set; }

	/// <summary>
	/// КЛАДР-код дома.
	/// </summary>
	public string? HouseKladrId { get; set; }

	/// <summary>
	/// Тип дома (сокращённый).
	/// </summary>
	public string? HouseType { get; set; }

	/// <summary>
	/// Тип дома.
	/// </summary>
	public string? HouseTypeFull { get; set; }

	/// <summary>
	/// Дом.
	/// </summary>
	public string? House { get; set; }

	/// <summary>
	/// Кадастровый номер дома.
	/// </summary>
	/// <remarks>
	/// Доступен только при использовании тарифа "Максимальный".
	/// </remarks>
	public string? HouseCadnum { get; set; }

	/// <summary>
	/// Тип корпуса/строения (сокращённый).
	/// </summary>
	public string? BlockType { get; set; }

	/// <summary>
	/// Тип корпуса/строения.
	/// </summary>
	public string? BlockTypeFull { get; set; }

	/// <summary>
	/// Корпус/строение.
	/// </summary>
	public string? Block { get; set; }

	/// <summary>
	/// Подъезд.
	/// </summary>
	/// <remarks>
	/// Данное поле заполняется только при вызове методов "Стандартизация". При использовании
	/// подсказок данное поле не заполняется.
	/// </remarks>
	public string? Entrance { get; set; }

	/// <summary>
	/// Этаж.
	/// </summary>
	/// <remarks>
	/// Данное поле заполняется только при вызове методов "Стандартизация". При использовании
	/// подсказок данное поле не заполняется.
	/// </remarks>
	public string? Floor { get; set; }

	/// <summary>
	/// ФИАС-код квартиры.
	/// </summary>
	public string? FlatFiasId { get; set; }

	/// <summary>
	/// Тип квартиры (сокращённый).
	/// </summary>
	public string? FlatType { get; set; }

	/// <summary>
	/// Тип квартиры.
	/// </summary>
	public string? FlatTypeFull { get; set; }

	/// <summary>
	/// Квартира.
	/// </summary>
	public string? Flat { get; set; }

	/// <summary>
	/// Кадастровый номер квартиры.
	/// </summary>
	/// <remarks>
	/// Доступен только при использовании тарифа "Максимальный".
	/// </remarks>
	public string? FlatCadnum { get; set; }

	/// <summary>
	/// Площадь квартиры.
	/// </summary>
	/// <remarks>
	/// Доступен только при использовании тарифа "Максимальный".
	/// </remarks>
	public string? FlatArea { get; set; }

	/// <summary>
	/// Рыночная стоимость квадратного метра.
	/// </summary>
	/// <remarks>
	/// Доступен только при использовании тарифа "Максимальный".
	/// </remarks>
	public string? SquareMeterPrice { get; set; }

	/// <summary>
	/// Рыночная стоимость квартиры.
	/// </summary>
	/// <remarks>
	/// Доступен только при использовании тарифа "Максимальный".
	/// </remarks>
	public string? FlatPrice { get; set; }

	/// <summary>
	/// ФИАС-код комнаты.
	/// </summary>
	public string? RoomFiasId { get; set; }

	/// <summary>
	/// Тип комнаты (сокращённый).
	/// </summary>
	public string? RoomType { get; set; }

	/// <summary>
	/// Тип комнаты.
	/// </summary>
	public string? RoomTypeFull { get; set; }

	/// <summary>
	/// Комната.
	/// </summary>
	public string? Room { get; set; }

	/// <summary>
	/// Абонентский ящик.
	/// </summary>
	public string? PostalBox { get; set; }

	/// <summary>
	/// ФИАС-код (он же код ГАР) адреса для России. Идентификатор OpenStreetMap для Белоруссии.
	/// Для остальных стран не заполняется.
	/// </summary>
	public string? FiasId { get; set; }

	/// <summary>
	/// Уровень детализации, до которого адрес найден в ФИАС (ГАР).
	/// </summary>
	public FiasLevel FiasLevel { get; set; }

	/// <summary>
	/// Признак актуальности адреса в ФИАС.
	/// </summary>
	public FiasActualityState FiasActualityState { get; set; }

	/// <summary>
	/// КЛАДР-код.
	/// </summary>
	public string? KladrId { get; set; }

	/// <summary>
	/// Идентификатор объекта в базе GeoNames. Для российских адресов не заполняется.
	/// </summary>
	public string? GeonameId { get; set; }

	/// <summary>
	/// Признак центра района или региона.
	/// </summary>
	public CapitalMarker CapitalMarker { get; set; }

	/// <summary>
	/// Код ОКАТО.
	/// </summary>
	public string? Okato { get; set; }

	/// <summary>
	/// Код ОКТМО.
	/// </summary>
	public string? Oktmo { get; set; }

	/// <summary>
	/// Код ИФНС для физических лиц.
	/// </summary>
	public string? TaxOffice { get; set; }

	/// <summary>
	/// Код ИФНС для организаций.
	/// </summary>
	public string? TaxOfficeLegal { get; set; }

	/// <summary>
	/// Список исторических названия объекта нижнего уровня.
	/// </summary>
	/// <remarks>
	/// Если подсказка до улицы - это прошлые названия этой улицы, если до города - города.
	/// </remarks>
	public IReadOnlyList<string> HistoryValues { get; set; } = Array.Empty<string>();

	/// <summary>
	/// Часовой пояс.
	/// </summary>
	/// <remarks>
	/// Доступен только при использовании тарифа "Максимальный".
	/// </remarks>
	public string? Timezone { get; set; }

	/// <summary>
	/// Координаты: широта.
	/// </summary>
	/// <remarks>
	/// Доступно только на платных тарифах.
	/// </remarks>
	public string? GeoLat { get; set; }

	/// <summary>
	/// Координаты: долгота.
	/// </summary>
	/// <remarks>
	/// Доступно только на платных тарифах.
	/// </remarks>
	public string? GeoLon { get; set; }

	/// <summary>
	/// Код точности координат.
	/// </summary>
	public GeoCoordinatesQuality? QcGeo { get; set; }

	/// <summary>
	/// Внутри кольцевой?
	/// </summary>
	public BeltwayHit? BeltwayHit { get; set; }

	/// <summary>
	/// Расстояние от кольцевой в километрах.
	/// </summary>
	/// <remarks>
	/// Доступно только на тарифах "Расширенный" и "Максимальный".
	/// </remarks>
	public string? BeltwayDistance { get; set; }

	/// <summary>
	/// Список ближайших станций метро (до трёх штук)
	/// </summary>
	public IReadOnlyList<SubwayStationProximity> Metro { get; set; } = Array.Empty<SubwayStationProximity>();
}
