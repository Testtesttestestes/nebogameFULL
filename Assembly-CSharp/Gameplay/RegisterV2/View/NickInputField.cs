using System;
using Il2CppDummyDll;
using UI;

namespace Gameplay.RegisterV2.View
{
	// Token: 0x02000559 RID: 1369
	[Token(Token = "0x2000559")]
	public class NickInputField : MonoBehaviourWithStates<NickInputField.NickInputFiledStates>
	{
		// Token: 0x060020F7 RID: 8439 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020F7")]
		[Address(RVA = "0x725A", Offset = "0x725A", VA = "0x725A")]
		public NickInputField()
		{
		}

		// Token: 0x0200055A RID: 1370
		[Token(Token = "0x200055A")]
		public enum NickInputFiledStates
		{
			// Token: 0x040011FC RID: 4604
			[Token(Token = "0x40011FC")]
			Unknown,
			// Token: 0x040011FD RID: 4605
			[Token(Token = "0x40011FD")]
			Idle,
			// Token: 0x040011FE RID: 4606
			[Token(Token = "0x40011FE")]
			Error
		}
	}
}
