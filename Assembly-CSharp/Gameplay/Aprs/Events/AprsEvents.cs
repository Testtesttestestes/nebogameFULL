using System;
using Gameplay.Aprs.Model;
using Il2CppDummyDll;
using MVC;

namespace Gameplay.Aprs.Events
{
	// Token: 0x02000D69 RID: 3433
	[Token(Token = "0x2000D69")]
	public class AprsEvents : AbstractMVCEvents
	{
		// Token: 0x0600542C RID: 21548 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600542C")]
		[Address(RVA = "0xA1E3", Offset = "0xA1E3", VA = "0xA1E3")]
		public AprsEvents()
		{
		}

		// Token: 0x04002D98 RID: 11672
		[Token(Token = "0x4002D98")]
		[FieldOffset(Offset = "0x14")]
		public AprsEvents.AprChangedEventDelegate AprChangedEvent;

		// Token: 0x04002D99 RID: 11673
		[Token(Token = "0x4002D99")]
		[FieldOffset(Offset = "0x18")]
		public Action OwnerChangedEvent;

		// Token: 0x04002D9A RID: 11674
		[Token(Token = "0x4002D9A")]
		[FieldOffset(Offset = "0x1C")]
		public Action DictProviderChanged;

		// Token: 0x02000D6A RID: 3434
		// (Invoke) Token: 0x0600542E RID: 21550
		[Token(Token = "0x2000D6A")]
		public delegate void AprChangedEventDelegate(AprData aprData, uint medalId);
	}
}
