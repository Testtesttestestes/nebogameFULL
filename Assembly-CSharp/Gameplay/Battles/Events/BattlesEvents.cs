using System;
using Il2CppDummyDll;
using MVC;

namespace Gameplay.Battles.Events
{
	// Token: 0x02000C2E RID: 3118
	[Token(Token = "0x2000C2E")]
	public class BattlesEvents : AbstractMVCEvents
	{
		// Token: 0x06004BFF RID: 19455 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004BFF")]
		[Address(RVA = "0x9A43", Offset = "0x9A43", VA = "0x9A43")]
		public BattlesEvents()
		{
		}

		// Token: 0x04002974 RID: 10612
		[Token(Token = "0x4002974")]
		[FieldOffset(Offset = "0x14")]
		public Action NotificationNumChangedEvent;
	}
}
