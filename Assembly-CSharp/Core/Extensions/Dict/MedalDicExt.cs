using System;
using Core.Dict;
using Core.Dict.DictWrappers.Wrappers;
using Gameplay.Medals.Model;
using Il2CppDummyDll;
using Protocol.Dic;

namespace Core.Extensions.Dict
{
	// Token: 0x02000F7E RID: 3966
	[Token(Token = "0x2000F7E")]
	public static class MedalDicExt
	{
		// Token: 0x06005F54 RID: 24404 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005F54")]
		[Address(RVA = "0xAB9C", Offset = "0xAB9C", VA = "0xAB9C")]
		public static string GetIconAssetId(this MedalDic medalDic)
		{
			return null;
		}

		// Token: 0x06005F55 RID: 24405 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005F55")]
		[Address(RVA = "0x36E7", Offset = "0x36E7", VA = "0x36E7")]
		public static string GetTitle(this MedalDic medalDic)
		{
			return null;
		}

		// Token: 0x06005F56 RID: 24406 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005F56")]
		[Address(RVA = "0xAB9D", Offset = "0xAB9D", VA = "0xAB9D")]
		public static string GetDescription(this MedalDic medalDic)
		{
			return null;
		}

		// Token: 0x06005F57 RID: 24407 RVA: 0x000116E8 File Offset: 0x0000F8E8
		[Token(Token = "0x6005F57")]
		[Address(RVA = "0xAB9E", Offset = "0xAB9E", VA = "0xAB9E")]
		public static bool TryGetApr(this MedalDic medalDic, IDictProvider dict, uint cult, uint gender, out AprDicWrapper apr)
		{
			return default(bool);
		}

		// Token: 0x06005F58 RID: 24408 RVA: 0x00011700 File Offset: 0x0000F900
		[Token(Token = "0x6005F58")]
		[Address(RVA = "0xAB9F", Offset = "0xAB9F", VA = "0xAB9F")]
		public static bool IsMedalHasRanks(this MedalDic medalDic, MedalDicGroupStorage medalDicGroupStorage)
		{
			return default(bool);
		}

		// Token: 0x06005F59 RID: 24409 RVA: 0x00011718 File Offset: 0x0000F918
		[Token(Token = "0x6005F59")]
		[Address(RVA = "0xABA0", Offset = "0xABA0", VA = "0xABA0")]
		public static uint GetMaxRank(this MedalDic medalDic, MedalDicGroupStorage medalDicGroupStorage)
		{
			return 0U;
		}

		// Token: 0x06005F5A RID: 24410 RVA: 0x00011730 File Offset: 0x0000F930
		[Token(Token = "0x6005F5A")]
		[Address(RVA = "0x1E38", Offset = "0x1E38", VA = "0x1E38")]
		public static bool IsSetDiscount(this MedalDic dict)
		{
			return default(bool);
		}
	}
}
