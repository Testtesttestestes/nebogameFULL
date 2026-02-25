using System;
using Il2CppDummyDll;
using UI;

namespace Gameplay.EndlessPaymentOptionsList.View
{
	// Token: 0x0200082F RID: 2095
	[Token(Token = "0x200082F")]
	public class EndlessPaymentOptionListTitleLayoutView : MonoBehaviourWithStates<EndlessPaymentOptionListTitleLayoutView.States>
	{
		// Token: 0x06003152 RID: 12626 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003152")]
		[Address(RVA = "0x81AA", Offset = "0x81AA", VA = "0x81AA")]
		public EndlessPaymentOptionListTitleLayoutView()
		{
		}

		// Token: 0x02000830 RID: 2096
		[Token(Token = "0x2000830")]
		public enum States
		{
			// Token: 0x04001AEF RID: 6895
			[Token(Token = "0x4001AEF")]
			None,
			// Token: 0x04001AF0 RID: 6896
			[Token(Token = "0x4001AF0")]
			Default,
			// Token: 0x04001AF1 RID: 6897
			[Token(Token = "0x4001AF1")]
			Discount
		}
	}
}
