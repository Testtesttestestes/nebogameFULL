using System;
using Il2CppDummyDll;

namespace Core.Net.Monitor.Responseability
{
	// Token: 0x02000E97 RID: 3735
	[Token(Token = "0x2000E97")]
	public class LatencyDto : IComparable
	{
		// Token: 0x06005ACD RID: 23245 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005ACD")]
		[Address(RVA = "0xA7B1", Offset = "0xA7B1", VA = "0xA7B1")]
		public LatencyDto(uint index, long latency)
		{
		}

		// Token: 0x06005ACE RID: 23246 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005ACE")]
		[Address(RVA = "0xA7B2", Offset = "0xA7B2", VA = "0xA7B2", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06005ACF RID: 23247 RVA: 0x00010230 File Offset: 0x0000E430
		[Token(Token = "0x6005ACF")]
		[Address(RVA = "0xA7B3", Offset = "0xA7B3", VA = "0xA7B3", Slot = "4")]
		public int CompareTo(object obj)
		{
			return 0;
		}

		// Token: 0x040031A0 RID: 12704
		[Token(Token = "0x40031A0")]
		[FieldOffset(Offset = "0x8")]
		public readonly uint Index;

		// Token: 0x040031A1 RID: 12705
		[Token(Token = "0x40031A1")]
		[FieldOffset(Offset = "0x10")]
		public long Latency;
	}
}
