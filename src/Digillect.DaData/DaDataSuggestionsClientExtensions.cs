using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Digillect.DaData;

/// <summary>
/// Методы-расширения клиента подсказок сервиса DaData.
/// </summary>
public static class DaDataSuggestionsClientExtensions
{
	/// <summary>
	/// Находит адрес по идентификатору.
	/// </summary>
	/// <remarks>
	/// В качестве идентификатора может использоваться:
	/// <list type="bullet">
	/// <item>
	/// Кадастровый номер (<see cref="Address.SteadCadnum"/>, <see cref="Address.HouseCadnum"/> или <see cref="Address.FlatCadnum"/>),
	/// только для России.
	/// </item>
	/// <item>ФИАС-код, он же ГАР-код (<see cref="Address.FiasId"/>), только для России.</item>
	/// <item>КЛАДР-код (<see cref="Address.KladrId"/>), только для России.</item>
	/// <item>Идентификатор OpenStreetMap (<see cref="Address.FiasId"/>), только для Белоруссии.</item>
	/// <item>Идентификатор GeoNames (<see cref="Address.GeonameId"/>), для всех остальных стран.</item>
	/// </list>
	/// </remarks>
	/// <param name="client">клиент DaData.</param>
	/// <param name="id">идентификатор.</param>
	/// <param name="cancellationToken">токен отмены асинхронных операций</param>
	/// <returns>Результат поиска адреса.</returns>
	public static Task<SuggestAddressResponse> FindAddressByIdAsync(
		this IDaDataSuggestionsClient client,
		string id,
		CancellationToken cancellationToken = default)
	{
		return client.FindAddressByIdAsync(SuggestAddressRequest.Create(id), cancellationToken);
	}

	/// <summary>
	/// Возвращает подсказки адреса для указанного текста запроса.
	/// </summary>
	/// <param name="client">клиент DaData.</param>
	/// <param name="query">текст запроса.</param>
	/// <param name="count">количество требуемых подсказок.</param>
	/// <param name="cancellationToken">токен отмены асинхронных операций.</param>
	/// <returns>Подсказки адреса.</returns>
	public static async Task<IReadOnlyList<Suggestion<Address>>> SuggestAddressAsync(
		this IDaDataSuggestionsClient client,
		string query,
		int count,
		CancellationToken cancellationToken = default)
	{
		var response = await client.SuggestAddressAsync(SuggestAddressRequest.Create(query).Take(count), cancellationToken);

		return response.Suggestions;
	}

	/// <summary>
	/// Возвращает подсказки адреса для указанного текста запроса.
	/// </summary>
	/// <param name="client">клиент DaData.</param>
	/// <param name="query">текст запроса.</param>
	/// <param name="cancellationToken">токен отмены асинхронных операций.</param>
	/// <returns>Подсказки адреса.</returns>
	public static async Task<IReadOnlyList<Suggestion<Address>>> SuggestAddressAsync(
		this IDaDataSuggestionsClient client,
		string query,
		CancellationToken cancellationToken = default)
	{
		var response = await client.SuggestAddressAsync(SuggestAddressRequest.Create(query), cancellationToken);

		return response.Suggestions;
	}
}
