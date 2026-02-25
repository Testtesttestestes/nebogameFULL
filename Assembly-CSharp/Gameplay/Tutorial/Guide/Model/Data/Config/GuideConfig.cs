using System;
using Il2CppDummyDll;
using Protocol.Dic;

namespace Gameplay.Tutorial.Guide.Model.Data.Config
{
	// Token: 0x02000487 RID: 1159
	[Token(Token = "0x2000487")]
	public class GuideConfig
	{
		// Token: 0x06001B70 RID: 7024 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B70")]
		[Address(RVA = "0x6CEF", Offset = "0x6CEF", VA = "0x6CEF")]
		public GuideConfig(in GuideId id, TutorialStepDic stepDic)
		{
		}

		// Token: 0x170004D0 RID: 1232
		// (get) Token: 0x06001B71 RID: 7025 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170004D0")]
		public StepLayoutConfig StepLayoutConfig
		{
			[Token(Token = "0x6001B71")]
			[Address(RVA = "0x6CF0", Offset = "0x6CF0", VA = "0x6CF0")]
			get
			{
				return null;
			}
		}

		// Token: 0x04000ED6 RID: 3798
		[Token(Token = "0x4000ED6")]
		[FieldOffset(Offset = "0x8")]
		public readonly GuideId Id;

		// Token: 0x04000ED7 RID: 3799
		[Token(Token = "0x4000ED7")]
		[FieldOffset(Offset = "0x10")]
		public readonly TutorialStepDic StepDic;

		// Token: 0x04000ED8 RID: 3800
		[Token(Token = "0x4000ED8")]
		[FieldOffset(Offset = "0x14")]
		private StepLayoutConfig _stepLayoutConfig;
	}
}
