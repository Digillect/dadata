namespace Digillect.DaData;

/// <summary>
/// Граница для получения гранулярных подсказок по адресу.
/// </summary>
public sealed class AddressSuggestionBoundValue
{
	/// <summary>
	/// Создаёт новый экземпляр объекта.
	/// </summary>
	/// <param name="value">Значение границы.</param>
	public AddressSuggestionBoundValue(AddressSuggestionBound value)
	{
		Value = value;
	}

	/// <summary>
	/// Значение границы.
	/// </summary>
	public AddressSuggestionBound Value { get; }
}
