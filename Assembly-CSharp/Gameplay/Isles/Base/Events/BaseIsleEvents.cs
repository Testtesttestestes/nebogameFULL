using System;
using Il2CppDummyDll;
using MVC;

namespace Gameplay.Isles.Base.Events
{
	// Token: 0x02000CFE RID: 3326
	[Token(Token = "0x2000CFE")]
	public class BaseIsleEvents : AbstractMVCEvents
	{
		// Token: 0x06005130 RID: 20784 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005130")]
		[Address(RVA = "0x9F20", Offset = "0x9F20", VA = "0x9F20")]
		public BaseIsleEvents()
		{
		}

		// Token: 0x04002C36 RID: 11318
		[Token(Token = "0x4002C36")]
		[FieldOffset(Offset = "0x14")]
		public Action<uint> BuildingStateChangedEvent;

		// Token: 0x04002C37 RID: 11319
		[Token(Token = "0x4002C37")]
		[FieldOffset(Offset = "0x18")]
		public Action IsCurrentChangedEvent;

		// Token: 0x04002C38 RID: 11320
		[Token(Token = "0x4002C38")]
		[FieldOffset(Offset = "0x1C")]
		public Action IsleInformationChangedEvent;

		// Token: 0x04002C39 RID: 11321
		[Token(Token = "0x4002C39")]
		[FieldOffset(Offset = "0x20")]
		public Action DisposeEvent;
	}
}
