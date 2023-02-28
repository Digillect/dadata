using System;
using System.Runtime.CompilerServices;

namespace Digillect.DaData;

internal static class Check
{
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static T NotNull<T>(T? value, string parameterName)
		where T : class
	{
		if (value is null)
		{
			throw new ArgumentNullException(parameterName, "Parameter should not be a null value");
		}

		return value;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static string NotEmpty(string? value, string parameterName)
	{
		NotNull(value, parameterName);

		if (string.IsNullOrEmpty(value))
		{
			throw new ArgumentException("Parameter should not be an empty string", parameterName);
		}

		return value!;
	}
}
