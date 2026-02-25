using System;
using Il2CppDummyDll;
using MVC;

namespace Gameplay.MageSchool.Events
{
	// Token: 0x02000640 RID: 1600
	[Token(Token = "0x2000640")]
	public class SchoolEvents : AbstractMVCEvents
	{
		// Token: 0x060026D6 RID: 9942 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60026D6")]
		[Address(RVA = "0x780B", Offset = "0x780B", VA = "0x780B")]
		public SchoolEvents()
		{
		}

		// Token: 0x0400153C RID: 5436
		[Token(Token = "0x400153C")]
		[FieldOffset(Offset = "0x14")]
		public Action<uint> LearnSpellAccelerated;

		// Token: 0x0400153D RID: 5437
		[Token(Token = "0x400153D")]
		[FieldOffset(Offset = "0x18")]
		public Action<uint> LearnSpellCanceled;

		// Token: 0x0400153E RID: 5438
		[Token(Token = "0x400153E")]
		[FieldOffset(Offset = "0x1C")]
		public Action<uint> LearnSpellStarted;

		// Token: 0x0400153F RID: 5439
		[Token(Token = "0x400153F")]
		[FieldOffset(Offset = "0x20")]
		public Action<uint> SpellUpdated;

		// Token: 0x04001540 RID: 5440
		[Token(Token = "0x4001540")]
		[FieldOffset(Offset = "0x24")]
		public Action<uint> SpellStateChanged;

		// Token: 0x04001541 RID: 5441
		[Token(Token = "0x4001541")]
		[FieldOffset(Offset = "0x28")]
		public Action SchoolLoadedEvent;
	}
}
