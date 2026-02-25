using System;
using Gameplay.DailyQuests.Controller;
using Il2CppDummyDll;
using UI.Windows;

namespace Gameplay.DailyQuests.View
{
	// Token: 0x02000878 RID: 2168
	[Token(Token = "0x2000878")]
	public class DailyQuestsWindowArgs : BaseWindowArgs
	{
		// Token: 0x060032E9 RID: 13033 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60032E9")]
		[Address(RVA = "0x833B", Offset = "0x833B", VA = "0x833B")]
		public DailyQuestsWindowArgs()
		{
		}

		// Token: 0x04001BDF RID: 7135
		[Token(Token = "0x4001BDF")]
		[FieldOffset(Offset = "0x18")]
		public DailyQuestsController Controller;

		// Token: 0x04001BE0 RID: 7136
		[Token(Token = "0x4001BE0")]
		[FieldOffset(Offset = "0x1C")]
		public uint CategoryId;
	}
}
