using System;
using Il2CppDummyDll;

namespace Gameplay.Tutorial.Guide.Model.Data
{
	// Token: 0x02000484 RID: 1156
	[Token(Token = "0x2000484")]
	[Serializable]
	public struct GuideId
	{
		// Token: 0x06001B66 RID: 7014 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B66")]
		[Address(RVA = "0x6CEC", Offset = "0x6CEC", VA = "0x6CEC")]
		public GuideId(uint tutorialId, uint stepId)
		{
		}

		// Token: 0x06001B67 RID: 7015 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6001B67")]
		[Address(RVA = "0x6CED", Offset = "0x6CED", VA = "0x6CED", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x04000ED0 RID: 3792
		[Token(Token = "0x4000ED0")]
		[FieldOffset(Offset = "0x0")]
		public uint TutorialId;

		// Token: 0x04000ED1 RID: 3793
		[Token(Token = "0x4000ED1")]
		[FieldOffset(Offset = "0x4")]
		public uint StepId;
	}
}
