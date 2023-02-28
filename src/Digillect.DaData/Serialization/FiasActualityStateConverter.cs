using System.Text.Json;

namespace Digillect.DaData.Serialization;

internal sealed class FiasActualityStateConverter : EnumConverter<FiasActualityState>
{
	public FiasActualityStateConverter()
	{
		Add(FiasActualityState.Actual, "0");
		Add(FiasActualityState.Reassigned, "51");
		Add(FiasActualityState.Deleted, "99");
	}

	protected override FiasActualityState ConvertUnknownValue(string value, JsonSerializerOptions options)
	{
		if (int.TryParse(value, out int state) && state is > 0 and < 51)
		{
			return FiasActualityState.Renamed;
		}

		return base.ConvertUnknownValue(value, options);
	}

	protected override string ConvertUnknownValue(FiasActualityState value, JsonSerializerOptions options)
	{
		return value == FiasActualityState.Renamed
			? "1"
			: base.ConvertUnknownValue(value, options);
	}
}
