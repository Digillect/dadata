using System;
using System.Collections.Generic;

namespace Digillect.DaData;

/// <summary>
/// Ответ запроса "Подсказки по адресам".
/// </summary>
public class SuggestAddressResponse
{
	/// <summary>
	/// Подсказки.
	/// </summary>
	public IReadOnlyList<Suggestion<Address>> Suggestions { get; set; } = Array.Empty<Suggestion<Address>>();
}
