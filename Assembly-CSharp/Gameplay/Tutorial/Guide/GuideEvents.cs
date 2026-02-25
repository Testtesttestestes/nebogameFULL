using System;
using Gameplay.Tutorial.Guide.Model.Data;
using Gameplay.Tutorial.Guide.Model.Data.Config;
using Il2CppDummyDll;
using MVC;

namespace Gameplay.Tutorial.Guide
{
	// Token: 0x02000456 RID: 1110
	[Token(Token = "0x2000456")]
	public class GuideEvents : AbstractMVCEvents
	{
		// Token: 0x06001A4C RID: 6732 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001A4C")]
		[Address(RVA = "0x6BE3", Offset = "0x6BE3", VA = "0x6BE3")]
		public GuideEvents()
		{
		}

		// Token: 0x04000E20 RID: 3616
		[Token(Token = "0x4000E20")]
		[FieldOffset(Offset = "0x14")]
		public Action<IGuideTarget, GuideConfig> CurrentStepChangedEvent;

		// Token: 0x04000E21 RID: 3617
		[Token(Token = "0x4000E21")]
		[FieldOffset(Offset = "0x18")]
		public Action DevEditorToolEnabledChangedEvent;

		// Token: 0x04000E22 RID: 3618
		[Token(Token = "0x4000E22")]
		[FieldOffset(Offset = "0x1C")]
		public Action<GuideConfig> TargetAchievedStartEvent;
	}
}
