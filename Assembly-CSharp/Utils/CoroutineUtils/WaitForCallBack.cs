using System;
using Il2CppDummyDll;

namespace Utils.CoroutineUtils
{
	// Token: 0x0200006B RID: 107
	[Token(Token = "0x200006B")]
	public class WaitForCallBack : MyCustomYieldInstruction
	{
		// Token: 0x0600033D RID: 829 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600033D")]
		[Address(RVA = "0x57A9", Offset = "0x57A9", VA = "0x57A9")]
		public void CallBack()
		{
		}

		// Token: 0x0600033E RID: 830 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600033E")]
		[Address(RVA = "0x57AA", Offset = "0x57AA", VA = "0x57AA")]
		public WaitForCallBack()
		{
		/* --- GHIDRA: .ctor ---
		undefined4 Utils_CoroutineUtils_WaitForCallBack___ctor(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a62849 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_UnityEngine_Component_TryGetComponent_MaskingShapeContainer___);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    DAT_ram_00a62849 = '\x01';
		  }
		  param1_00 = *(undefined4 *)(param1 + 0x18);
		  if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		    func_ii_306000(UnityEngine_Object_TypeInfo);
		  }
		  uVar1 = 0;
		  iVar2 = UnityEngine_Component__GetComponent_object_(param1_00,0);
		  if ((iVar2 != 0) ||
		     (iVar2 = UnityEngine_UIElements_GroupBoxUtility__UnregisterGroupBoxOption_object_
		                        (*(undefined4 *)(param1 + 0x10),(undefined4 *)(param1 + 0x18),
		                         Method_UnityEngine_Component_TryGetComponent_MaskingShapeContainer___),
		     iVar2 != 0)) {
		    uVar1 = *(undefined4 *)(param1 + 0x18);
		  }
		  return uVar1;
		}
		*/

		}
	}
}
