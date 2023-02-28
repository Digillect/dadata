using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Digillect.DaData.Serialization;

internal abstract class EnumConverter<T> : JsonConverter<T>
	where T : Enum
{
	private readonly Dictionary<string, T> _readCache = new();
	private readonly Dictionary<T, string> _writeCache = new();

	protected void Add(T enumValue, string stringValue)
	{
		_readCache.Add(stringValue, enumValue);
		_writeCache.Add(enumValue, stringValue);
	}

	public override T Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
	{
		string? json;

		if (reader.TokenType != JsonTokenType.String || (json = reader.GetString()) == null)
		{
			throw new JsonException($"{typeof(T).FullName} value expected to be string, got {reader.TokenType}");
		}

		return _readCache.TryGetValue(json, out var value)
			? value
			: ConvertUnknownValue(json, options);
	}

	public override void Write(Utf8JsonWriter writer, T value, JsonSerializerOptions options)
	{
		if (!_writeCache.TryGetValue(value, out string? json))
		{
			json = ConvertUnknownValue(value, options);
		}

		writer.WriteStringValue(json);
	}

	protected virtual T ConvertUnknownValue(string value, JsonSerializerOptions options)
	{
		throw new JsonException($"Invalid value \"{value}\" for type {typeof(T).FullName}");
	}

	protected virtual string ConvertUnknownValue(T value, JsonSerializerOptions options)
	{
		throw new ArgumentOutOfRangeException(nameof(value));
	}
}
