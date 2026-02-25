using System;
using Core.Data;
using Il2CppDummyDll;
using MVC;
using Protocol.Main;

namespace Gameplay.Medals.Events
{
	// Token: 0x02000608 RID: 1544
	[Token(Token = "0x2000608")]
	public class MedalsEvents : AbstractMVCEvents
	{
		// Token: 0x06002577 RID: 9591 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002577")]
		[Address(RVA = "0x76BC", Offset = "0x76BC", VA = "0x76BC")]
		public MedalsEvents()
		{
		}

		// Token: 0x04001482 RID: 5250
		[Token(Token = "0x4001482")]
		[FieldOffset(Offset = "0x14")]
		public MedalsEvents.MedalChangedEventDelegate MedalChangedEvent;

		// Token: 0x04001483 RID: 5251
		[Token(Token = "0x4001483")]
		[FieldOffset(Offset = "0x18")]
		public Action<uint> MedalRemovedEvent;

		// Token: 0x04001484 RID: 5252
		[Token(Token = "0x4001484")]
		[FieldOffset(Offset = "0x1C")]
		public Action<MedalInfo> MedalAddedEvent;

		// Token: 0x04001485 RID: 5253
		[Token(Token = "0x4001485")]
		[FieldOffset(Offset = "0x20")]
		public Action<MedalInfo> MedalBuyEvent;

		// Token: 0x02000609 RID: 1545
		// (Invoke) Token: 0x06002579 RID: 9593
		[Token(Token = "0x2000609")]
		public delegate void MedalChangedEventDelegate(MedalData medalData, uint medalId);
	}
}
