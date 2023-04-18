namespace Digillect.DaData.Serialization;

internal sealed class BeltwayHitConverter : EnumConverter<BeltwayHit>
{
	public BeltwayHitConverter()
	{
		Add(BeltwayHit.InMkad, "IN_MKAD");
		Add(BeltwayHit.OutMkad, "OUT_MKAD");
		Add(BeltwayHit.InKad, "IN_KAD");
		Add(BeltwayHit.OutKad, "OUT_KAD");
	}
}
