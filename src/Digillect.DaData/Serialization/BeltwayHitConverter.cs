namespace Digillect.DaData.Serialization;

internal sealed class BeltwayHitConverter : EnumConverter<BeltwayHit>
{
	public BeltwayHitConverter()
	{
		Add(BeltwayHit.InMkad, "IN_MKAD");
		Add(BeltwayHit.OutMkad, "OUT_MKAD");
	}
}
