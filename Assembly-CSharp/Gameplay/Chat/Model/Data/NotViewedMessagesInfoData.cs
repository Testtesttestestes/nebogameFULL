using System;
using Il2CppDummyDll;

namespace Gameplay.Chat.Model.Data
{
	// Token: 0x02000B13 RID: 2835
	[Token(Token = "0x2000B13")]
	public struct NotViewedMessagesInfoData
	{
		// Token: 0x040025C4 RID: 9668
		[Token(Token = "0x40025C4")]
		[FieldOffset(Offset = "0x0")]
		public int TotalCount;

		// Token: 0x040025C5 RID: 9669
		[Token(Token = "0x40025C5")]
		[FieldOffset(Offset = "0x4")]
		public int[] CountByRoomIndex;
	}
}
