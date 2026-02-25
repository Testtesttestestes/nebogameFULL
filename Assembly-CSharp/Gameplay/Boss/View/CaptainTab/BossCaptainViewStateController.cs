using System;
using Il2CppDummyDll;
using UI;

namespace Gameplay.Boss.View.CaptainTab
{
	// Token: 0x02000B7B RID: 2939
	[Token(Token = "0x2000B7B")]
	public class BossCaptainViewStateController : MonoBehaviourWithStates<BossCaptainViewStateController.BossCaptainViewState>
	{
		// Token: 0x06004762 RID: 18274 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004762")]
		[Address(RVA = "0x95F6", Offset = "0x95F6", VA = "0x95F6")]
		public BossCaptainViewStateController()
		{
		}

		// Token: 0x02000B7C RID: 2940
		[Token(Token = "0x2000B7C")]
		public enum BossCaptainViewState
		{
			// Token: 0x0400272E RID: 10030
			[Token(Token = "0x400272E")]
			UNKNOWN_STATE,
			// Token: 0x0400272F RID: 10031
			[Token(Token = "0x400272F")]
			DEFAULT_STATE,
			// Token: 0x04002730 RID: 10032
			[Token(Token = "0x4002730")]
			EDIT_STATE
		}
	}
}
