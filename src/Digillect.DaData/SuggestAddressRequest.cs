using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Digillect.DaData;

/// <summary>
/// Запрос подсказок по адресам.
/// </summary>
public class SuggestAddressRequest
{
	/// <summary>
	/// Инициализирует новый экземпляр объекта.
	/// </summary>
	/// <param name="query">текст запроса.</param>
	public SuggestAddressRequest(string query)
	{
		Query = Check.NotEmpty(query, nameof(query));
	}

	/// <summary>
	/// Текст запроса.
	/// </summary>
	public string Query { get; }

	/// <summary>
	/// Количество результатов.
	/// </summary>
	/// <remarks>
	/// По умолчанию 10, максимум 20.
	/// </remarks>
	[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
	public int? Count { get; set; }

	/// <summary>
	/// Язык результата.
	/// </summary>
	[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
	public string? Language { get; set; }

	/// <summary>
	/// Тип используемого деления адресов
	/// </summary>
	[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
	public AddressSuggestionDivision? Division { get; set; }

	/// <summary>
	/// Ограничения по родителю.
	/// </summary>
	[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
	public List<AddressSuggestionLocationRestriction>? Locations { get; set; }

	/// <summary>
	/// Ограничения по радиусу окружности.
	/// </summary>
	[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
	public List<AddressSuggestionGeoRestriction>? LocationsGeo { get; set; }

	/// <summary>
	/// Приоритет города при ранжировании.
	/// </summary>
	[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
	public List<AddressSuggestionCityBoost>? LocationsBoost { get; set; }

	/// <summary>
	/// Левая граница гранулярных подсказок.
	/// </summary>
	[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
	public AddressSuggestionBoundValue? FromBound { get; set; }

	/// <summary>
	/// Правая граница гранулярных подсказок.
	/// </summary>
	[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
	public AddressSuggestionBoundValue? ToBound { get; set; }

	/// <summary>
	/// Создаёт новый запрос подсказок по адресам.
	/// </summary>
	/// <param name="query">текст запроса.</param>
	/// <returns>Запрос подсказок по адресам.</returns>
	public static SuggestAddressRequest Create(string query)
	{
		return new SuggestAddressRequest(query);
	}

	/// <summary>
	/// Добавляет к запросу новое ограничение сектора поиска адреса.
	/// </summary>
	/// <param name="restriction">ограничение сектора поиска адреса.</param>
	public void AddLocationRestriction(AddressSuggestionLocationRestriction restriction)
	{
		_ = restriction ?? throw new ArgumentNullException(nameof(restriction));

		Locations ??= new List<AddressSuggestionLocationRestriction>();

		Locations.Add(restriction);
	}

	/// <summary>
	/// Добавляет к запросу новое ограничение по радиусу поиска.
	/// </summary>
	/// <param name="restriction">ограничение по радиусу поиска.</param>
	public void AddGeoLocationRestriction(AddressSuggestionGeoRestriction restriction)
	{
		_ = restriction ?? throw new ArgumentNullException(nameof(restriction));

		LocationsGeo ??= new List<AddressSuggestionGeoRestriction>();

		LocationsGeo.Add(restriction);
	}

	/// <summary>
	/// Добавляет к запросу новый приоритет города при ранжировании.
	/// </summary>
	/// <param name="value">параметры приоритета города при ранжировании.</param>
	public void AddLocationBoost(AddressSuggestionCityBoost value)
	{
		_ = value ?? throw new ArgumentNullException(nameof(value));

		LocationsBoost ??= new List<AddressSuggestionCityBoost>();

		LocationsBoost.Add(value);
	}
}
