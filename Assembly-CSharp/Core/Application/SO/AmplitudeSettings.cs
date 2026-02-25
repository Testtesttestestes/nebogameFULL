using System;
using Il2CppDummyDll;

namespace Core.Application.SO
{
	// Token: 0x0200123C RID: 4668
	[Token(Token = "0x200123C")]
	[Serializable]
	public class AmplitudeSettings
	{
		// Token: 0x06006EC3 RID: 28355 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006EC3")]
		[Address(RVA = "0xB941", Offset = "0xB941", VA = "0xB941")]
		public AmplitudeSettings()
		{
		}

		// Token: 0x040039DB RID: 14811
		[Token(Token = "0x40039DB")]
		[FieldOffset(Offset = "0x8")]
		public string Server;

		// Token: 0x040039DC RID: 14812
		[Token(Token = "0x40039DC")]
		[FieldOffset(Offset = "0xC")]
		public string ApiKey;

		// Token: 0x040039DD RID: 14813
		[Token(Token = "0x40039DD")]
		[FieldOffset(Offset = "0x10")]
		public bool UserDynamicConfig;
	}
}
