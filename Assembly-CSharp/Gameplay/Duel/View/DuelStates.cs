using System;
using Il2CppDummyDll;
using UI;

namespace Gameplay.Duel.View
{
	// Token: 0x02000858 RID: 2136
	[Token(Token = "0x2000858")]
	public class DuelStates : MonoBehaviourWithStates<DuelStates.State>
	{
		// Token: 0x06003239 RID: 12857 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003239")]
		[Address(RVA = "0x828F", Offset = "0x828F", VA = "0x828F")]
		public DuelStates()
		{
		/* --- GHIDRA: .ctor ---
		undefined4 Gameplay_Duel_View_DuelStates___ctor(undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a57bcc == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_12613);
		    DAT_ram_00a57bcc = '\x01';
		  }
		  return StringLiteral_12613;
		}
		*/

		}

		// Token: 0x02000859 RID: 2137
		[Token(Token = "0x2000859")]
		public enum State
		{
			// Token: 0x04001B6F RID: 7023
			[Token(Token = "0x4001B6F")]
			UNKNOWN_STATE,
			// Token: 0x04001B70 RID: 7024
			[Token(Token = "0x4001B70")]
			ATTACKER,
			// Token: 0x04001B71 RID: 7025
			[Token(Token = "0x4001B71")]
			DEFENDER
		}
	}
}
