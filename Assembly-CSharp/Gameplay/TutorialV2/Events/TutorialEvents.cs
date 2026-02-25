using System;
using Il2CppDummyDll;
using MVC;

namespace Gameplay.TutorialV2.Events
{
	// Token: 0x02000430 RID: 1072
	[Token(Token = "0x2000430")]
	public class TutorialEvents : AbstractMVCEvents
	{
		// Token: 0x06001963 RID: 6499 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001963")]
		[Address(RVA = "0x6B02", Offset = "0x6B02", VA = "0x6B02")]
		public TutorialEvents()
		{
		}

		// Token: 0x04000D7B RID: 3451
		[Token(Token = "0x4000D7B")]
		[FieldOffset(Offset = "0x14")]
		public Action RequestPrepareCombatViewEvent;

		// Token: 0x04000D7C RID: 3452
		[Token(Token = "0x4000D7C")]
		[FieldOffset(Offset = "0x18")]
		public Action RequestPrepareGuideViewEvent;

		// Token: 0x04000D7D RID: 3453
		[Token(Token = "0x4000D7D")]
		[FieldOffset(Offset = "0x1C")]
		public Action CombatCompleteEvent;
	}
}
