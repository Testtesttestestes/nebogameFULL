using System;
using Il2CppDummyDll;

namespace Core.Gameplay.Managers.Configuration
{
	// Token: 0x0200122E RID: 4654
	[Token(Token = "0x200122E")]
	[Serializable]
	public class ConfigRecord
	{
		// Token: 0x06006E38 RID: 28216 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6006E38")]
		[Address(RVA = "0xB8E4", Offset = "0xB8E4", VA = "0xB8E4")]
		public ConfigRecord Clone()
		{
			return null;
		}

		// Token: 0x06006E39 RID: 28217 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006E39")]
		[Address(RVA = "0x2393", Offset = "0x2393", VA = "0x2393")]
		public ConfigRecord()
		{
		}

		// Token: 0x040039A0 RID: 14752
		[Token(Token = "0x40039A0")]
		[FieldOffset(Offset = "0x8")]
		public string Title;

		// Token: 0x040039A1 RID: 14753
		[Token(Token = "0x40039A1")]
		[FieldOffset(Offset = "0xC")]
		public string EndpointUri;

		// Token: 0x040039A2 RID: 14754
		[Token(Token = "0x40039A2")]
		[FieldOffset(Offset = "0x10")]
		public int PingTimeout;

		// Token: 0x040039A3 RID: 14755
		[Token(Token = "0x40039A3")]
		[FieldOffset(Offset = "0x14")]
		public string CdnUri;

		// Token: 0x040039A4 RID: 14756
		[Token(Token = "0x40039A4")]
		[FieldOffset(Offset = "0x18")]
		public int FileTimeout;
	}
}
