using System;
using Il2CppDummyDll;
using MVC;

namespace Gameplay.Cave
{
	// Token: 0x02000B31 RID: 2865
	[Token(Token = "0x2000B31")]
	public class CaveEvents : AbstractMVCEvents, IDisposable
	{
		// Token: 0x0600459D RID: 17821 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600459D")]
		[Address(RVA = "0x943F", Offset = "0x943F", VA = "0x943F", Slot = "4")]
		public void Dispose()
		{
		}

		// Token: 0x0600459E RID: 17822 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600459E")]
		[Address(RVA = "0x9440", Offset = "0x9440", VA = "0x9440")]
		public CaveEvents()
		{
		}

		// Token: 0x0400260D RID: 9741
		[Token(Token = "0x400260D")]
		[FieldOffset(Offset = "0x14")]
		public Action CaveStateChangedEvent;

		// Token: 0x0400260E RID: 9742
		[Token(Token = "0x400260E")]
		[FieldOffset(Offset = "0x18")]
		public Action MonsterStatusChangedEvent;

		// Token: 0x0400260F RID: 9743
		[Token(Token = "0x400260F")]
		[FieldOffset(Offset = "0x1C")]
		public Action DeinitEvent;
	}
}
