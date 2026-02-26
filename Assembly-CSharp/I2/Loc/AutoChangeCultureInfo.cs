using System;
using Il2CppDummyDll;
using UnityEngine;

namespace I2.Loc
{
	// Token: 0x0200139E RID: 5022
	[Token(Token = "0x200139E")]
	public class AutoChangeCultureInfo : MonoBehaviour
	{
		// Token: 0x0600779D RID: 30621 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600779D")]
		[Address(RVA = "0xC0FB", Offset = "0xC0FB", VA = "0xC0FB")]
		public void Start()
		{
		}

		// Token: 0x0600779E RID: 30622 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600779E")]
		[Address(RVA = "0xC0FC", Offset = "0xC0FC", VA = "0xC0FC")]
		public AutoChangeCultureInfo()
		{
		/* --- GHIDRA: .ctor ---
		undefined4 I2_Loc_AutoChangeCultureInfo___ctor(undefined4 param1)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 uVar3;
		  
		  if (DAT_ram_00a54dfe == '\0') {
		    Mono_Security_ASN1__get_Item(&UnityEngine_Application_TypeInfo);
		    Mono_Security_ASN1__get_Item(&I2_Loc_CoroutineManager_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_GameObject_AddComponent_CoroutineManager___);
		    Mono_Security_ASN1__get_Item(&UnityEngine_GameObject_TypeInfo);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_19196);
		    DAT_ram_00a54dfe = '\x01';
		  }
		  uVar3 = **(undefined4 **)(I2_Loc_CoroutineManager_TypeInfo + 0x5c);
		  if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		    func_ii_306000(UnityEngine_Object_TypeInfo);
		  }
		  iVar1 = func_ii_3812(uVar3,0,0);
		  if (iVar1 != 0) {
		    uVar3 = unnamed_function_1417(UnityEngine_GameObject_TypeInfo);
		    func_ii_13018(uVar3,StringLiteral_19196,0);
		    UnityEngine_Collider2D__set_isTrigger(uVar3,0x3d,0);
		    uVar2 = UnityEngine_GameObject__GetComponent_object_
		                      (uVar3,Method_UnityEngine_GameObject_AddComponent_CoroutineManager___);
		    **(undefined4 **)(I2_Loc_CoroutineManager_TypeInfo + 0x5c) = uVar2;
		    if (*(int *)(UnityEngine_Application_TypeInfo + 0x74) == 0) {
		      func_ii_306000(UnityEngine_Application_TypeInfo);
		    }
		    iVar1 = func_ii_3441(0);
		    if (iVar1 != 0) {
		      if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		        func_ii_306000(UnityEngine_Object_TypeInfo);
		      }
		      UnityEngine_Object__FindObjectsByType(uVar3,0);
		    }
		  }
		  return **(undefined4 **)(I2_Loc_CoroutineManager_TypeInfo + 0x5c);
		}
		*/

		}
	}
}
