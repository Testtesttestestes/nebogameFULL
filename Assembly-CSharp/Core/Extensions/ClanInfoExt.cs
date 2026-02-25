using System;
using Il2CppDummyDll;
using Protocol.Common;
using Protocol.Rating;

namespace Core.Extensions
{
	// Token: 0x02000F01 RID: 3841
	[Token(Token = "0x2000F01")]
	public static class ClanInfoExt
	{
		// Token: 0x06005D16 RID: 23830 RVA: 0x00010BD8 File Offset: 0x0000EDD8
		[Token(Token = "0x6005D16")]
		[Address(RVA = "0xA99C", Offset = "0xA99C", VA = "0xA99C")]
		public static long GetClanRating(this ClanInfo clan, ClanRatingTypes ratingType)
		{
			return 0L;
		}

		// Token: 0x06005D17 RID: 23831 RVA: 0x00010BF0 File Offset: 0x0000EDF0
		[Token(Token = "0x6005D17")]
		[Address(RVA = "0xA99D", Offset = "0xA99D", VA = "0xA99D")]
		public static uint GetHonorRating(this ClanInfo clan)
		{
			return 0U;
		}

		// Token: 0x06005D18 RID: 23832 RVA: 0x00010C08 File Offset: 0x0000EE08
		[Token(Token = "0x6005D18")]
		[Address(RVA = "0xA99E", Offset = "0xA99E", VA = "0xA99E")]
		public static int GetTotalMembersNum(this ClanInfo clan)
		{
			return 0;
		}

		// Token: 0x06005D19 RID: 23833 RVA: 0x00010C20 File Offset: 0x0000EE20
		[Token(Token = "0x6005D19")]
		[Address(RVA = "0xA99F", Offset = "0xA99F", VA = "0xA99F")]
		public static int GetLegendMembersNum(this ClanInfo clan)
		{
			return 0;
		}

		// Token: 0x06005D1A RID: 23834 RVA: 0x00010C38 File Offset: 0x0000EE38
		[Token(Token = "0x6005D1A")]
		[Address(RVA = "0xA9A0", Offset = "0xA9A0", VA = "0xA9A0")]
		public static int GetGeneralMembersNum(this ClanInfo clan)
		{
			return 0;
		}
	}
}
