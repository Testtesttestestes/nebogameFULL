using System;
using Il2CppDummyDll;
using UI;

namespace Gameplay.Boss.View
{
	// Token: 0x02000B49 RID: 2889
	[Token(Token = "0x2000B49")]
	public class BossPossibleEmptyWindowStateController : MonoBehaviourWithStates<BossPossibleEmptyWindowStateController.WindowStates>
	{
		// Token: 0x060045FD RID: 17917 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60045FD")]
		[Address(RVA = "0x9497", Offset = "0x9497", VA = "0x9497")]
		public BossPossibleEmptyWindowStateController()
		{
		/* --- GHIDRA: .ctor ---
		undefined4
		Gameplay_Boss_View_BossPossibleEmptyWindowStateController___ctor
		          (undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a579a1 == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_12581);
		    DAT_ram_00a579a1 = '\x01';
		  }
		  return StringLiteral_12581;
		}
		*/

		}

		// Token: 0x02000B4A RID: 2890
		[Token(Token = "0x2000B4A")]
		public enum WindowStates
		{
			// Token: 0x04002636 RID: 9782
			[Token(Token = "0x4002636")]
			UNKNOWN_STATE,
			// Token: 0x04002637 RID: 9783
			[Token(Token = "0x4002637")]
			EMPTY_STATE,
			// Token: 0x04002638 RID: 9784
			[Token(Token = "0x4002638")]
			DEFAULT_STATE
		}
	}
}
