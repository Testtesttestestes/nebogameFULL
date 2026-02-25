using System;
using Il2CppDummyDll;
using MVC;
using Protocol.Main;

namespace Gameplay.WorldAxis.Events
{
	// Token: 0x020002C9 RID: 713
	[Token(Token = "0x20002C9")]
	public class WorldAxisEvents : AbstractMVCEvents
	{
		// Token: 0x060010CE RID: 4302 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60010CE")]
		[Address(RVA = "0x62CB", Offset = "0x62CB", VA = "0x62CB")]
		public WorldAxisEvents()
		{
		}

		// Token: 0x040008AE RID: 2222
		[Token(Token = "0x40008AE")]
		[FieldOffset(Offset = "0x14")]
		public Action ScheduleChangedEvent;

		// Token: 0x040008AF RID: 2223
		[Token(Token = "0x40008AF")]
		[FieldOffset(Offset = "0x18")]
		public Action PartyChangedEvent;

		// Token: 0x040008B0 RID: 2224
		[Token(Token = "0x40008B0")]
		[FieldOffset(Offset = "0x1C")]
		public Action<ProtoStackableChangesAns> DollItemsChangedEvent;
	}
}
