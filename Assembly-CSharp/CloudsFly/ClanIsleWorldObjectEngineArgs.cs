using System;
using Il2CppDummyDll;

namespace CloudsFly
{
	// Token: 0x020012F6 RID: 4854
	[Token(Token = "0x20012F6")]
	public class ClanIsleWorldObjectEngineArgs : BaseIsleWorldObjectEngineArgs
	{
		// Token: 0x06007387 RID: 29575 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6007387")]
		[Address(RVA = "0xBD73", Offset = "0xBD73", VA = "0xBD73", Slot = "4")]
		public override IWorldObjectEngine GetEngine()
		{
			return null;
		}

		// Token: 0x06007388 RID: 29576 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007388")]
		[Address(RVA = "0xBD74", Offset = "0xBD74", VA = "0xBD74")]
		public ClanIsleWorldObjectEngineArgs()
		{
		/* --- GHIDRA: .ctor ---
		void CloudsFly_ClanIsleWorldObjectEngineArgs___ctor(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  
		  uVar1 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (param1,0);
		  iVar2 = UnityEngine_InputSystem_Users_InputUser__UnpairDevices(uVar1,0);
		  if (iVar2 != 0) {
		    if (*(int *)(param1 + 0x2c) != 0) {
		      func_ii_20511(param1,*(int *)(param1 + 0x2c),0);
		    }
		    if (DAT_ram_00a59677 == '\0') {
		      Mono_Security_ASN1__get_Item(&CloudsFly_CloudBGParallax__MoveBG_d__8_TypeInfo);
		      DAT_ram_00a59677 = '\x01';
		    }
		    iVar2 = unnamed_function_1417(CloudsFly_CloudBGParallax__MoveBG_d__8_TypeInfo);
		    *(int *)(iVar2 + 0x10) = param1;
		    *(undefined4 *)(iVar2 + 8) = 0;
		    uVar1 = UnityEngine_MonoBehaviour__StartCoroutine(param1,iVar2,0);
		    *(undefined4 *)(param1 + 0x2c) = uVar1;
		  }
		  return;
		}
		*/

		}
	}
}
