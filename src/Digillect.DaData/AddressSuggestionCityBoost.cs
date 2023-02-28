namespace Digillect.DaData;

/// <summary>
/// Приоритет города при ранжировании.
/// </summary>
public sealed class AddressSuggestionCityBoost
{
	/// <summary>
	/// Инициализирует новый экземпляр.
	/// </summary>
	/// <param name="kladrId">КЛАДР-код города.</param>
	public AddressSuggestionCityBoost(string kladrId)
	{
		KladrId = kladrId;
	}

	/// <summary>
	/// КЛАДР-код города.
	/// </summary>
	public string KladrId { get; }
}
