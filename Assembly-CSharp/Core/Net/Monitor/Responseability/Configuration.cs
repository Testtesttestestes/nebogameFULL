using System;
using Il2CppDummyDll;

namespace Core.Net.Monitor.Responseability
{
	// Token: 0x02000E93 RID: 3731
	[Token(Token = "0x2000E93")]
	[Serializable]
	public class Configuration
	{
		// Token: 0x06005ABF RID: 23231 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005ABF")]
		[Address(RVA = "0xA7AA", Offset = "0xA7AA", VA = "0xA7AA")]
		public Configuration()
		{
		}

		// Token: 0x04003192 RID: 12690
		[Token(Token = "0x4003192")]
		[FieldOffset(Offset = "0x8")]
		public int Capacity;

		// Token: 0x04003193 RID: 12691
		[Token(Token = "0x4003193")]
		[FieldOffset(Offset = "0xC")]
		public int StartTestThreshold;

		// Token: 0x04003194 RID: 12692
		[Token(Token = "0x4003194")]
		[FieldOffset(Offset = "0x10")]
		public int TestMin;

		// Token: 0x04003195 RID: 12693
		[Token(Token = "0x4003195")]
		[FieldOffset(Offset = "0x14")]
		public int TestMax;

		// Token: 0x04003196 RID: 12694
		[Token(Token = "0x4003196")]
		[FieldOffset(Offset = "0x18")]
		public int AwaitResponseThreshold;

		// Token: 0x04003197 RID: 12695
		[Token(Token = "0x4003197")]
		[FieldOffset(Offset = "0x1C")]
		public bool EnableDbg;
	}
}
