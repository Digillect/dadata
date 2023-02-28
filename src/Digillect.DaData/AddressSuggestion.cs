namespace Digillect.DaData;

/// <summary>
/// Ответ API подсказок.
/// </summary>
/// <typeparam name="T">Тип элемента подсказки.</typeparam>
public class Suggestion<T>
	where T : class, new()
{
	/// <summary>
	/// Значение элемента одной строкой (как показывается в списке подсказок).
	/// </summary>
	public string Value { get; set; }

	/// <summary>
	/// Значение элемента одной строкой (полное).
	/// </summary>
	public string UnrestrictedValue { get; set; }

	/// <summary>
	/// Данные.
	/// </summary>
	public T Data { get; set; }
}
