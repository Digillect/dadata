// ReSharper disable once CheckNamespace

namespace System.Text.Json;

/// <summary>
/// Конвертер сериализации JSON, превращающий имена формата PascalCase в формат snake_case.
/// </summary>
internal class JsonSnakeCaseNamingPolicy : JsonNamingPolicy
{
	private const char Separator = '_';

	/// <inheritdoc cref="JsonNamingPolicy.ConvertName"/>
	public override string ConvertName(string name)
	{
		if (String.IsNullOrEmpty(name) || String.IsNullOrWhiteSpace(name))
		{
			return String.Empty;
		}

		ReadOnlySpan<char> spanName = name.AsSpan().Trim();

		var stringBuilder = new StringBuilder();
		bool addCharacter = true;

		bool isNextLower = false;
		bool isNextUpper = false;
		bool isNextSpace = false;

		for (int position = 0; position < spanName.Length; position++)
		{
			if (position != 0)
			{
				bool isCurrentSpace = spanName[position] == 32;
				bool isPreviousSpace = spanName[position - 1] == 32;
				bool isPreviousSeparator = spanName[position - 1] == 95;

				if (position + 1 != spanName.Length)
				{
					isNextLower = spanName[position + 1] > 96 && spanName[position + 1] < 123;
					isNextUpper = spanName[position + 1] > 64 && spanName[position + 1] < 91;
					isNextSpace = spanName[position + 1] == 32;
				}

				if (isCurrentSpace && (isPreviousSpace || isPreviousSeparator || isNextUpper || isNextSpace))
				{
					addCharacter = false;
				}
				else
				{
					bool isCurrentUpper = spanName[position] > 64 && spanName[position] < 91;
					bool isPreviousLower = spanName[position - 1] > 96 && spanName[position - 1] < 123;
					bool isPreviousNumber = spanName[position - 1] > 47 && spanName[position - 1] < 58;

					if (isCurrentUpper
						&& (isPreviousLower || isPreviousNumber || isNextLower || isNextSpace || (isNextLower && !isPreviousSpace)))
					{
						stringBuilder.Append(Separator);
					}
					else
					{
						if (isCurrentSpace && !isPreviousSpace && !isNextSpace)
						{
							stringBuilder.Append(Separator);
							addCharacter = false;
						}
					}
				}
			}

			if (addCharacter)
			{
				stringBuilder.Append(spanName[position]);
			}
			else
			{
				addCharacter = true;
			}
		}

		return stringBuilder.ToString().ToLower();
	}
}
