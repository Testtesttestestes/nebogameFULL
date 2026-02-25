using System;
using Il2CppDummyDll;
using MVC;

namespace Gameplay.FeedbackForm
{
	// Token: 0x02000813 RID: 2067
	[Token(Token = "0x2000813")]
	public class FeedbackFormEvents : AbstractMVCEvents
	{
		// Token: 0x060030C2 RID: 12482 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60030C2")]
		[Address(RVA = "0x8127", Offset = "0x8127", VA = "0x8127")]
		public FeedbackFormEvents()
		{
		}

		// Token: 0x04001A92 RID: 6802
		[Token(Token = "0x4001A92")]
		[FieldOffset(Offset = "0x14")]
		public Action<string> FormErrorEvent;

		// Token: 0x04001A93 RID: 6803
		[Token(Token = "0x4001A93")]
		[FieldOffset(Offset = "0x18")]
		public Action<string> SubmitCompleteEvent;

		// Token: 0x04001A94 RID: 6804
		[Token(Token = "0x4001A94")]
		[FieldOffset(Offset = "0x1C")]
		public Action SubmitCompleteSuccessEvent;
	}
}
