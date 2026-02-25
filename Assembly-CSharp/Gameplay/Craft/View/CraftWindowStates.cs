using System;
using Il2CppDummyDll;
using UI;

namespace Gameplay.Craft.View
{
	// Token: 0x020008BB RID: 2235
	[Token(Token = "0x20008BB")]
	public class CraftWindowStates : MonoBehaviourWithStates<CraftWindowStates.State>
	{
		// Token: 0x06003486 RID: 13446 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003486")]
		[Address(RVA = "0x84B0", Offset = "0x84B0", VA = "0x84B0")]
		public CraftWindowStates()
		{
		}

		// Token: 0x020008BC RID: 2236
		[Token(Token = "0x20008BC")]
		public enum State
		{
			// Token: 0x04001CBC RID: 7356
			[Token(Token = "0x4001CBC")]
			UNKNOWN_STATE,
			// Token: 0x04001CBD RID: 7357
			[Token(Token = "0x4001CBD")]
			RECIPES,
			// Token: 0x04001CBE RID: 7358
			[Token(Token = "0x4001CBE")]
			MANUFACTURE,
			// Token: 0x04001CBF RID: 7359
			[Token(Token = "0x4001CBF")]
			NO_RECIPES
		}
	}
}
