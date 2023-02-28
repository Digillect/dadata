namespace Digillect.DaData;

/// <summary>
/// Методы-расширения для конструирования запроса подсказок по адресам.
/// </summary>
public static class SuggestAddressRequestExtensions
{
	/// <summary>
	/// Вернуть не более указанного количества подсказок.
	/// </summary>
	/// <param name="request">запрос для добавления ограничений.</param>
	/// <param name="numberOfSuggestions">максимальное количество подсказок.</param>
	/// <returns>Запрос подсказок по адресам.</returns>
	public static SuggestAddressRequest Take(this SuggestAddressRequest request, int numberOfSuggestions)
	{
		request.Count = numberOfSuggestions;

		return request;
	}

	/// <summary>
	/// Использовать муниципальное деление.
	/// </summary>
	/// <param name="request">запрос для добавления ограничений.</param>
	/// <returns>Запрос подсказок по адресам.</returns>
	public static SuggestAddressRequest UsingMunicipalDivision(this SuggestAddressRequest request)
	{
		request.Division = AddressSuggestionDivision.Municipal;

		return request;
	}

	/// <summary>
	/// Использовать указанный язык для подсказок.
	/// </summary>
	/// <param name="request">запрос для добавления ограничений.</param>
	/// <param name="language">язык подсказок.</param>
	/// <returns>Запрос подсказок по адресам.</returns>
	public static SuggestAddressRequest UsingLanguage(this SuggestAddressRequest request, string language)
	{
		Check.NotEmpty(language, nameof(language));

		request.Language = language;

		return request;
	}

	/// <summary>
	/// Ограничивает сектор поиска адресов используя указанные ISO-коды страны и региона.
	/// </summary>
	/// <param name="request">запрос для добавления ограничений.</param>
	/// <param name="countryIsoCode">ISO-код страны.</param>
	/// <param name="regionIsoCode">ISO-код региона.</param>
	/// <returns>Запрос подсказок по адресам.</returns>
	public static SuggestAddressRequest RestrictByIsoCode(this SuggestAddressRequest request, string countryIsoCode, string? regionIsoCode = null)
	{
		Check.NotEmpty(countryIsoCode, nameof(countryIsoCode));

		var value = new AddressSuggestionLocationRestriction {
			CountryIsoCode = countryIsoCode,
			RegionIsoCode = regionIsoCode
		};

		request.AddLocationRestriction(value);

		return request;
	}

	/// <summary>
	/// Ограничивает сектор поиска адресов используя указанный код КЛАДР.
	/// </summary>
	/// <param name="request">запрос для добавления ограничений.</param>
	/// <param name="kladrId">код КЛАДР.</param>
	/// <returns>Запрос подсказок по адресам.</returns>
	public static SuggestAddressRequest RestrictByKladrId(this SuggestAddressRequest request, string kladrId)
	{
		Check.NotEmpty(kladrId, nameof(kladrId));

		var value = new AddressSuggestionLocationRestriction {
			KladrId = kladrId
		};

		request.AddLocationRestriction(value);

		return request;
	}

	/// <summary>
	/// Ограничивает сектор поиска адресов используя указанный код ФИАС.
	/// </summary>
	/// <param name="request">запрос для добавления ограничений.</param>
	/// <param name="fiasId">код ФИАС.</param>
	/// <returns>Запрос подсказок по адресам.</returns>
	public static SuggestAddressRequest RestrictByFiasId(this SuggestAddressRequest request, string fiasId)
	{
		Check.NotEmpty(fiasId, nameof(fiasId));

		var value = new AddressSuggestionLocationRestriction {
			FiasId = fiasId
		};

		request.AddLocationRestriction(value);

		return request;
	}

	/// <summary>
	/// Ограничивает сектор поиска адресов по названию страны.
	/// </summary>
	/// <param name="request">запрос для добавления ограничений.</param>
	/// <param name="countryName">название страны.</param>
	/// <returns>Запрос подсказок по адресам.</returns>
	public static SuggestAddressRequest RestrictByCountryName(this SuggestAddressRequest request, string countryName)
	{
		Check.NotEmpty(countryName, nameof(countryName));

		var value = new AddressSuggestionLocationRestriction {
			Country = countryName
		};

		request.AddLocationRestriction(value);

		return request;
	}

	/// <summary>
	/// Ограничивает сектор поиска адресов по названию региона.
	/// </summary>
	/// <param name="request">запрос для добавления ограничений.</param>
	/// <param name="regionName">название региона.</param>
	/// <returns>Запрос подсказок по адресам.</returns>
	public static SuggestAddressRequest RestrictByRegionName(this SuggestAddressRequest request, string regionName)
	{
		Check.NotEmpty(regionName, nameof(regionName));

		var value = new AddressSuggestionLocationRestriction {
			Region = regionName
		};

		request.AddLocationRestriction(value);

		return request;
	}

	/// <summary>
	/// Ограничивает сектор поиска адресов по названию района.
	/// </summary>
	/// <param name="request">запрос для добавления ограничений.</param>
	/// <param name="areaName">название района.</param>
	/// <returns>Запрос подсказок по адресам.</returns>
	public static SuggestAddressRequest RestrictByAreaName(this SuggestAddressRequest request, string areaName)
	{
		Check.NotEmpty(areaName, nameof(areaName));

		var value = new AddressSuggestionLocationRestriction {
			Area = areaName
		};

		request.AddLocationRestriction(value);

		return request;
	}

	/// <summary>
	/// Ограничивает сектор поиска адресов по названию города.
	/// </summary>
	/// <param name="request">запрос для добавления ограничений.</param>
	/// <param name="cityName">название города.</param>
	/// <returns>Запрос подсказок по адресам.</returns>
	public static SuggestAddressRequest RestrictByCityName(this SuggestAddressRequest request, string cityName)
	{
		Check.NotEmpty(cityName, nameof(cityName));

		var value = new AddressSuggestionLocationRestriction {
			City = cityName
		};

		request.AddLocationRestriction(value);

		return request;
	}

	/// <summary>
	/// Ограничивает сектор поиска адресов по названию населённого пункта.
	/// </summary>
	/// <param name="request">запрос для добавления ограничений.</param>
	/// <param name="settlementName">название населённого пункта.</param>
	/// <returns>Запрос подсказок по адресам.</returns>
	public static SuggestAddressRequest RestrictBySettlementName(this SuggestAddressRequest request, string settlementName)
	{
		Check.NotEmpty(settlementName, nameof(settlementName));

		var value = new AddressSuggestionLocationRestriction {
			Settlement = settlementName
		};

		request.AddLocationRestriction(value);

		return request;
	}

	/// <summary>
	/// Ограничивает сектор поиска адресов по названию улицы.
	/// </summary>
	/// <param name="request">запрос для добавления ограничений.</param>
	/// <param name="streetName">название улицы.</param>
	/// <returns>Запрос подсказок по адресам.</returns>
	public static SuggestAddressRequest RestrictByStreetName(this SuggestAddressRequest request, string streetName)
	{
		Check.NotEmpty(streetName, nameof(streetName));

		var value = new AddressSuggestionLocationRestriction {
			Street = streetName
		};

		request.AddLocationRestriction(value);

		return request;
	}

	/// <summary>
	/// Ограничивает сектор поиска адресов по типу региона.
	/// </summary>
	/// <param name="request">запрос для добавления ограничений.</param>
	/// <param name="regionType">тип региона.</param>
	/// <returns>Запрос подсказок по адресам.</returns>
	public static SuggestAddressRequest RestrictByRegionType(this SuggestAddressRequest request, string regionType)
	{
		Check.NotEmpty(regionType, nameof(regionType));

		var value = new AddressSuggestionLocationRestriction {
			RegionTypeFull = regionType
		};

		request.AddLocationRestriction(value);

		return request;
	}

	/// <summary>
	/// Ограничивает сектор поиска адресов по типу района в регионе.
	/// </summary>
	/// <param name="request">запрос для добавления ограничений.</param>
	/// <param name="areaType">тип района.</param>
	/// <returns>Запрос подсказок по адресам.</returns>
	public static SuggestAddressRequest RestrictByAreaType(this SuggestAddressRequest request, string areaType)
	{
		Check.NotEmpty(areaType, nameof(areaType));

		var value = new AddressSuggestionLocationRestriction {
			AreaTypeFull = areaType
		};

		request.AddLocationRestriction(value);

		return request;
	}

	/// <summary>
	/// Ограничивает сектор поиска адресов по типу города.
	/// </summary>
	/// <param name="request">запрос для добавления ограничений.</param>
	/// <param name="cityType">тип города.</param>
	/// <returns>Запрос подсказок по адресам.</returns>
	public static SuggestAddressRequest RestrictByCityType(this SuggestAddressRequest request, string cityType)
	{
		Check.NotEmpty(cityType, nameof(cityType));

		var value = new AddressSuggestionLocationRestriction {
			CityTypeFull = cityType
		};

		request.AddLocationRestriction(value);

		return request;
	}

	/// <summary>
	/// Ограничивает сектор поиска адресов по типу населённого пункта.
	/// </summary>
	/// <param name="request">запрос для добавления ограничений.</param>
	/// <param name="settlementType">тип населённого пункта.</param>
	/// <returns>Запрос подсказок по адресам.</returns>
	public static SuggestAddressRequest RestrictBySettlementType(this SuggestAddressRequest request, string settlementType)
	{
		Check.NotEmpty(settlementType, nameof(settlementType));

		var value = new AddressSuggestionLocationRestriction {
			SettlementTypeFull = settlementType
		};

		request.AddLocationRestriction(value);

		return request;
	}

	/// <summary>
	/// Ограничивает сектор поиска адресов по типу улицы.
	/// </summary>
	/// <param name="request">запрос для добавления ограничений.</param>
	/// <param name="streetType">тип улицы.</param>
	/// <returns>Запрос подсказок по адресам.</returns>
	public static SuggestAddressRequest RestrictByStreetType(this SuggestAddressRequest request, string streetType)
	{
		Check.NotEmpty(streetType, nameof(streetType));

		var value = new AddressSuggestionLocationRestriction {
			StreetTypeFull = streetType
		};

		request.AddLocationRestriction(value);

		return request;
	}

	/// <summary>
	/// Задаёт левую границу для получения гранулярных подсказок.
	/// </summary>
	/// <param name="request">запрос подсказок по адресам.</param>
	/// <param name="from">левая граница.</param>
	/// <returns>Запрос подсказок по адресам.</returns>
	public static SuggestAddressRequest From(this SuggestAddressRequest request, AddressSuggestionBound from)
	{
		request.FromBound = new AddressSuggestionBoundValue(from);

		return request;
	}

	/// <summary>
	/// Задаёт правую границу для получения гранулярных подсказок.
	/// </summary>
	/// <param name="request">запрос подсказок по адресам.</param>
	/// <param name="to">правая граница.</param>
	/// <returns>Запрос подсказок по адресам.</returns>
	public static SuggestAddressRequest To(this SuggestAddressRequest request, AddressSuggestionBound to)
	{
		request.ToBound = new AddressSuggestionBoundValue(to);

		return request;
	}

	/// <summary>
	/// Добавляет ограничение на поиск адресов в определённом радиусе от заданной точки.
	/// </summary>
	/// <param name="request">запрос для добавления ограничения.</param>
	/// <param name="lat">географическая широта.</param>
	/// <param name="lon">географическая долгота.</param>
	/// <param name="radiusMeters">радиус поиска в метрах (по умолчанию <c>100</c>, максимум <c>100000</c>).</param>
	/// <returns>Запрос подсказок по адресам.</returns>
	public static SuggestAddressRequest RestrictByLocation(this SuggestAddressRequest request, double lat, double lon, int? radiusMeters = null)
	{
		var restriction = new AddressSuggestionGeoRestriction {
			Lat = lat,
			Lon = lon,
			RadiusMeters = radiusMeters
		};

		request.AddGeoLocationRestriction(restriction);

		return request;
	}

	/// <summary>
	/// Добавляет приоритет при ранжировании для города или региона.
	/// </summary>
	/// <param name="request">Запрос подсказок по адресам.</param>
	/// <param name="cityOrRegionKladrId">КЛАДР-код города или региона.</param>
	/// <returns>Запрос подсказок по адресам.</returns>
	public static SuggestAddressRequest BoostCityOrRegion(this SuggestAddressRequest request, string cityOrRegionKladrId)
	{
		Check.NotEmpty(cityOrRegionKladrId, nameof(cityOrRegionKladrId));

		var value = new AddressSuggestionCityBoost(cityOrRegionKladrId);

		request.AddLocationBoost(value);

		return request;
	}
}
