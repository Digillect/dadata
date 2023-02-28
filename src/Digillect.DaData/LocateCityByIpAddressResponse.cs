namespace Digillect.DaData;

/// <summary>
/// Ответ запроса "Поиск адреса по IP-адресу".
/// </summary>
public class LocateCityByIpAddressResponse
{
	/// <summary>
	/// Подсказка с обнаруженным городом.
	/// </summary>
	public Suggestion<Address>? Location { get; set; }
}
