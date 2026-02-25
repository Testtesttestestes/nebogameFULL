using System;
using Core.Data;
using Il2CppDummyDll;

namespace UI.ToolTip.Implementations.VO
{
	// Token: 0x02000163 RID: 355
	[Token(Token = "0x2000163")]
	public class CollectionToolTipVO
	{
		// Token: 0x060009F9 RID: 2553 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009F9")]
		[Address(RVA = "0x5D59", Offset = "0x5D59", VA = "0x5D59")]
		public CollectionToolTipVO()
		{
		}

		// Token: 0x04000432 RID: 1074
		[Token(Token = "0x4000432")]
		[FieldOffset(Offset = "0x8")]
		public CollectionData Collection;

		// Token: 0x04000433 RID: 1075
		[Token(Token = "0x4000433")]
		[FieldOffset(Offset = "0xC")]
		public UserData User;

		// Token: 0x04000434 RID: 1076
		[Token(Token = "0x4000434")]
		[FieldOffset(Offset = "0x10")]
		public uint Rank;
	}
}
