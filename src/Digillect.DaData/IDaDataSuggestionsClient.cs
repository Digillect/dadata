using System.Threading;
using System.Threading.Tasks;
using Refit;

namespace Digillect.DaData;

/// <summary>
/// Клиент подсказок сервиса DaData.
/// </summary>
public interface IDaDataSuggestionsClient
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
	/// <param name="request">параметры запроса.</param>
	/// <param name="cancellationToken">токен отмены асинхронных операций</param>
	/// <returns>Результат поиска адреса.</returns>
	[Post("/api/4_1/rs/findById/address")]
	Task<SuggestAddressResponse> FindAddressByIdAsync([Body] SuggestAddressRequest request, CancellationToken cancellationToken = default);

	/// <summary>
	/// Возвращает подсказки адреса для указанного запроса.
	/// </summary>
	/// <param name="request">параметры запроса.</param>
	/// <param name="cancellationToken">токен отмены асинхронных операций.</param>
	/// <returns>Ответ с подсказками по адресам.</returns>
	[Post("/api/4_1/rs/suggest/address")]
	Task<SuggestAddressResponse> SuggestAddressAsync([Body] SuggestAddressRequest request, CancellationToken cancellationToken = default);

	/// <summary>
	/// Определяет город по IP-адресу в России.
	/// </summary>
	/// <param name="ip">IP-адрес.</param>
	/// <param name="cancellationToken">токен отмены асинхронных операций.</param>
	/// <returns>Результаты поиска города по IP-адресу.</returns>
	[Get("/api/4_1/rs/iplocate/address?ip={ip}")]
	Task<LocateCityByIpAddressResponse> LocateCityByIpAddressAsync(string ip, CancellationToken cancellationToken = default);
}
