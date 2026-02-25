using System;
using Core.Data.Skills;
using Core.Money;
using Google.Protobuf.Collections;
using Il2CppDummyDll;
using Protocol.Common;
using Protocol.Consts;

namespace Utils
{
	// Token: 0x02000047 RID: 71
	[Token(Token = "0x2000047")]
	public static class MoneyUtils
	{
		// Token: 0x06000290 RID: 656 RVA: 0x00002AA8 File Offset: 0x00000CA8
		[Token(Token = "0x6000290")]
		[Address(RVA = "0x572D", Offset = "0x572D", VA = "0x572D")]
		public static double CalculateResource(Resources type, double value, bool isSending)
		{
			return 0.0;
		}

		// Token: 0x06000291 RID: 657 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000291")]
		[Address(RVA = "0x572E", Offset = "0x572E", VA = "0x572E")]
		public static ResourceSet CreateZero()
		{
			return null;
		}

		// Token: 0x06000292 RID: 658 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000292")]
		[Address(RVA = "0x572F", Offset = "0x572F", VA = "0x572F")]
		public static ResourceSet Create(double value)
		{
			return null;
		}

		// Token: 0x06000293 RID: 659 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000293")]
		[Address(RVA = "0x5730", Offset = "0x5730", VA = "0x5730")]
		public static ResourceSet Create(double mr = 0.0, double mg = 0.0, double e = 0.0, double nr = double.NaN, double cf = double.NaN)
		{
			return null;
		}

		// Token: 0x06000294 RID: 660 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000294")]
		[Address(RVA = "0x5731", Offset = "0x5731", VA = "0x5731")]
		public static Money ExtractSpellCostMoney(Skills value)
		{
			return null;
		}

		// Token: 0x06000295 RID: 661 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000295")]
		[Address(RVA = "0x5732", Offset = "0x5732", VA = "0x5732")]
		public static ResourceSet ExtractSpellCost(Skills value)
		{
			return null;
		}

		// Token: 0x06000296 RID: 662 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000296")]
		[Address(RVA = "0x5733", Offset = "0x5733", VA = "0x5733")]
		public static Money ExtractArtifactCostMoney(RepeatedField<double> skills)
		{
			return null;
		}

		// Token: 0x06000297 RID: 663 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000297")]
		[Address(RVA = "0x5734", Offset = "0x5734", VA = "0x5734")]
		public static ResourceSet ExtractArtifactCost(RepeatedField<double> skills)
		{
			return null;
		}

		// Token: 0x06000298 RID: 664 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000298")]
		[Address(RVA = "0x5735", Offset = "0x5735", VA = "0x5735")]
		public static ResourceSet ExtractResourceSetFromArray(double[] arr)
		{
			return null;
		}

		// Token: 0x06000299 RID: 665 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000299")]
		[Address(RVA = "0x5736", Offset = "0x5736", VA = "0x5736")]
		public static ResourceSet StringToResourcesSet(string raw)
		{
			return null;
		}
	}
}
