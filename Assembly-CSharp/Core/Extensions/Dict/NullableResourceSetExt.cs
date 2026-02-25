using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Protocol.Common;
using Protocol.Consts;

namespace Core.Extensions.Dict
{
	// Token: 0x02000F9B RID: 3995
	[Token(Token = "0x2000F9B")]
	public static class NullableResourceSetExt
	{
		// Token: 0x06005FC8 RID: 24520 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005FC8")]
		[Address(RVA = "0xAC03", Offset = "0xAC03", VA = "0xAC03")]
		public static ResourceSet ToResourceSet(this NullableResourceSet value)
		{
			return null;
		}

		// Token: 0x06005FC9 RID: 24521 RVA: 0x00011910 File Offset: 0x0000FB10
		[Token(Token = "0x6005FC9")]
		[Address(RVA = "0x1B0F", Offset = "0x1B0F", VA = "0x1B0F")]
		public static double GetValue(this NullableResourceSet rs, Resources id)
		{
			return 0.0;
		}

		// Token: 0x06005FCA RID: 24522 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005FCA")]
		[Address(RVA = "0xAC04", Offset = "0xAC04", VA = "0xAC04")]
		public static List<Resources> GetResourcesesIds(this NullableResourceSet rs, double greaterThresholdValue = 0.0)
		{
			return null;
		}
	}
}
