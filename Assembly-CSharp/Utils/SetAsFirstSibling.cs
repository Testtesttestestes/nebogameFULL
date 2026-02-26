using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Utils
{
	// Token: 0x02000052 RID: 82
	[Token(Token = "0x2000052")]
	public class SetAsFirstSibling : MonoBehaviour
	{
		// Token: 0x060002E2 RID: 738 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002E2")]
		[Address(RVA = "0x575E", Offset = "0x575E", VA = "0x575E")]
		private void Awake()
		{
		}

		// Token: 0x060002E3 RID: 739 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002E3")]
		[Address(RVA = "0x575F", Offset = "0x575F", VA = "0x575F")]
		public SetAsFirstSibling()
		{
		/* --- GHIDRA: .ctor ---
		undefined4 Utils_SetAsFirstSibling___ctor(int param1,undefined4 param2)
		
		{
		  undefined4 *puVar1;
		  
		  if (DAT_ram_00a6281d == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_9071);
		    Mono_Security_ASN1__get_Item(&StringLiteral_17400);
		    Mono_Security_ASN1__get_Item(&StringLiteral_17506);
		    Mono_Security_ASN1__get_Item(&StringLiteral_8914);
		    Mono_Security_ASN1__get_Item(&StringLiteral_2373);
		    Mono_Security_ASN1__get_Item(&StringLiteral_9073);
		    Mono_Security_ASN1__get_Item(&StringLiteral_9186);
		    DAT_ram_00a6281d = '\x01';
		  }
		  if (param1 - 1U < 6) {
		    puVar1 = (undefined4 *)(&PTR_StringLiteral_8914_ram_005a4cc8)[param1 - 1U];
		  }
		  else {
		    puVar1 = &StringLiteral_2373;
		  }
		  return *puVar1;
		}
		*/

		}
	}
}
