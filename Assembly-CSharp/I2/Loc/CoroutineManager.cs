using System;
using System.Collections;
using Il2CppDummyDll;
using UnityEngine;

namespace I2.Loc
{
	// Token: 0x0200139F RID: 5023
	[Token(Token = "0x200139F")]
	public class CoroutineManager : MonoBehaviour
	{
		// Token: 0x170017B5 RID: 6069
		// (get) Token: 0x0600779F RID: 30623 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170017B5")]
		private static CoroutineManager pInstance
		{
			[Token(Token = "0x600779F")]
			[Address(RVA = "0xC0FD", Offset = "0xC0FD", VA = "0xC0FD")]
			get
			{
				return null;
			}
		}

		// Token: 0x060077A0 RID: 30624 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60077A0")]
		[Address(RVA = "0xC0FE", Offset = "0xC0FE", VA = "0xC0FE")]
		private void Awake()
		{
		/* --- GHIDRA: Awake ---
		undefined4 I2_Loc_CoroutineManager__Awake(undefined4 param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  
		  uVar1 = I2_Loc_AutoChangeCultureInfo___ctor(param1);
		  uVar1 = UnityEngine_MonoBehaviour__StartCoroutine(uVar1,param1,0);
		  return uVar1;
		}
		*/

		}

		// Token: 0x060077A1 RID: 30625 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60077A1")]
		[Address(RVA = "0xC0FF", Offset = "0xC0FF", VA = "0xC0FF")]
		public static Coroutine Start(IEnumerator coroutine)
		{
			return null;
		}

		// Token: 0x060077A2 RID: 30626 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60077A2")]
		[Address(RVA = "0xC100", Offset = "0xC100", VA = "0xC100")]
		public CoroutineManager()
		{
		/* --- GHIDRA: .ctor ---
		void I2_Loc_CoroutineManager___ctor(undefined4 param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a54e00 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_I2_Loc_CustomLocalizeCallback_OnLocalize__);
		    Mono_Security_ASN1__get_Item(&I2_Loc_LocalizationManager_TypeInfo);
		    Mono_Security_ASN1__get_Item(&I2_Loc_LocalizationManager_OnLocalizeCallback_TypeInfo);
		    DAT_ram_00a54e00 = '\x01';
		  }
		  uVar1 = unnamed_function_1417(I2_Loc_LocalizationManager_OnLocalizeCallback_TypeInfo);
		  I2_Loc_LocalizationManager__GetParam__EndInvoke
		            (uVar1,param1,Method_I2_Loc_CustomLocalizeCallback_OnLocalize__,0);
		  if (*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x74) == 0) {
		    func_ii_306000(I2_Loc_LocalizationManager_TypeInfo);
		  }
		  I2_Loc_LocalizationManager__add_OnLocalizeEvent(uVar1,0);
		  uVar1 = unnamed_function_1417(I2_Loc_LocalizationManager_OnLocalizeCallback_TypeInfo);
		  I2_Loc_LocalizationManager__GetParam__EndInvoke
		            (uVar1,param1,Method_I2_Loc_CustomLocalizeCallback_OnLocalize__,0);
		  I2_Loc_LocalizationManager__RegisterTarget(uVar1,0);
		  return;
		}
		*/

		}

		// Token: 0x04003E71 RID: 15985
		[Token(Token = "0x4003E71")]
		[FieldOffset(Offset = "0x0")]
		private static CoroutineManager mInstance;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_pInstance ---
		void I2_Loc_CoroutineManager__get_pInstance(undefined4 param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a54dff == '\0') {
		    Mono_Security_ASN1__get_Item(&UnityEngine_Application_TypeInfo);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    DAT_ram_00a54dff = '\x01';
		  }
		  if (*(int *)(UnityEngine_Application_TypeInfo + 0x74) == 0) {
		    func_ii_306000(UnityEngine_Application_TypeInfo);
		  }
		  iVar1 = func_ii_3441(0);
		  if (iVar1 != 0) {
		    param1_00 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                          (param1,0);
		    if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		      func_ii_306000(UnityEngine_Object_TypeInfo);
		    }
		    UnityEngine_Object__FindObjectsByType(param1_00,0);
		  }
		  return;
		}
		*/

}
