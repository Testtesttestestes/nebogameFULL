using System;
using Il2CppDummyDll;

namespace UI.Elements.RightPanel.TitledList.Elements
{
	// Token: 0x02000207 RID: 519
	[Token(Token = "0x2000207")]
	public class CurrentStatusTitledListElementArgs : BaseTitledListElementArgs
	{
		// Token: 0x06000D39 RID: 3385 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D39")]
		[Address(RVA = "0x601C", Offset = "0x601C", VA = "0x601C")]
		public CurrentStatusTitledListElementArgs(int energy, int energyRestoringLimit, int maxLimit)
		{
		}

		// Token: 0x0400068A RID: 1674
		[Token(Token = "0x400068A")]
		[FieldOffset(Offset = "0x8")]
		public int energy;

		// Token: 0x0400068B RID: 1675
		[Token(Token = "0x400068B")]
		[FieldOffset(Offset = "0xC")]
		public int energyRestoringLimit;

		// Token: 0x0400068C RID: 1676
		[Token(Token = "0x400068C")]
		[FieldOffset(Offset = "0x10")]
		public int maxLimit;
	}
}
