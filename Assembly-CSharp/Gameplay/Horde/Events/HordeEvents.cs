using System;
using Il2CppDummyDll;
using MVC;

namespace Gameplay.Horde.Events
{
	// Token: 0x02000701 RID: 1793
	[Token(Token = "0x2000701")]
	public class HordeEvents : AbstractMVCEvents
	{
		// Token: 0x06002AF0 RID: 10992 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002AF0")]
		[Address(RVA = "0x7B8B", Offset = "0x7B8B", VA = "0x7B8B")]
		public HordeEvents()
		{
		}

		// Token: 0x04001779 RID: 6009
		[Token(Token = "0x4001779")]
		[FieldOffset(Offset = "0x14")]
		public Action HordeInfoRequestedEvent;

		// Token: 0x0400177A RID: 6010
		[Token(Token = "0x400177A")]
		[FieldOffset(Offset = "0x18")]
		public Action HordeExitedEvent;
	}
}
