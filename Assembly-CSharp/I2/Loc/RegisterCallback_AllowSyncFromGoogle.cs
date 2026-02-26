using System;
using Il2CppDummyDll;
using UnityEngine;

namespace I2.Loc
{
	// Token: 0x020013B1 RID: 5041
	[Token(Token = "0x20013B1")]
	public class RegisterCallback_AllowSyncFromGoogle : MonoBehaviour
	{
		// Token: 0x060077DC RID: 30684 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60077DC")]
		[Address(RVA = "0xC137", Offset = "0xC137", VA = "0xC137")]
		public void Awake()
		{
		/* --- GHIDRA: Awake ---
		void I2_Loc_RegisterCallback_AllowSyncFromGoogle__Awake(int *param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a54e21 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Func_LanguageSourceData__bool__TypeInfo);
		    Mono_Security_ASN1__get_Item(&I2_Loc_LocalizationManager_TypeInfo);
		    DAT_ram_00a54e21 = '\x01';
		  }
		  param1_00 = unnamed_function_1417(System_Func_LanguageSourceData__bool__TypeInfo);
		  if (param1 != (int *)0x0) {
		    System_Collections_Generic_Dictionary_uint__object___GetEnumerator
		              (param1_00,param1,*(undefined4 *)(*param1 + 0xe4),0);
		    if (*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x74) == 0) {
		      func_ii_306000(I2_Loc_LocalizationManager_TypeInfo);
		    }
		    *(undefined4 *)(*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x5c) + 0x24) = param1_00;
		    return;
		  }
		  System_Collections_Generic_Comparer_ValueTuple_int__Int32Enum__object____get_Default();
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x060077DD RID: 30685 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60077DD")]
		[Address(RVA = "0xC138", Offset = "0xC138", VA = "0xC138")]
		public void OnEnable()
		{
		/* --- GHIDRA: OnEnable ---
		void I2_Loc_RegisterCallback_AllowSyncFromGoogle__OnEnable(undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a54e22 == '\0') {
		    Mono_Security_ASN1__get_Item(&I2_Loc_LocalizationManager_TypeInfo);
		    DAT_ram_00a54e22 = '\x01';
		  }
		  if (*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x74) == 0) {
		    func_ii_306000(I2_Loc_LocalizationManager_TypeInfo);
		  }
		  *(undefined4 *)(*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x5c) + 0x24) = 0;
		  return;
		}
		*/

		}

		// Token: 0x060077DE RID: 30686 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60077DE")]
		[Address(RVA = "0xC139", Offset = "0xC139", VA = "0xC139")]
		public void OnDisable()
		{
		}

		// Token: 0x060077DF RID: 30687 RVA: 0x00016068 File Offset: 0x00014268
		[Token(Token = "0x60077DF")]
		[Address(RVA = "0xC13A", Offset = "0xC13A", VA = "0xC13A", Slot = "4")]
		public virtual bool AllowSyncFromGoogle(LanguageSourceData Source)
		{
			return default(bool);
		}

		// Token: 0x060077E0 RID: 30688 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60077E0")]
		[Address(RVA = "0xC13B", Offset = "0xC13B", VA = "0xC13B")]
		public RegisterCallback_AllowSyncFromGoogle()
		{
		/* --- GHIDRA: .ctor ---
		void I2_Loc_RegisterCallback_AllowSyncFromGoogle___ctor(undefined4 param1,undefined4 param2)
		
		{
		  int iVar1;
		  int param1_00;
		  uint uVar2;
		  
		  if (DAT_ram_00a54e23 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_ILocalizationParamsManager__Add__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_ILocalizationParamsManager__Contains__);
		    Mono_Security_ASN1__get_Item(&I2_Loc_LocalizationManager_TypeInfo);
		    DAT_ram_00a54e23 = '\x01';
		  }
		  if (*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x74) == 0) {
		    func_ii_306000(I2_Loc_LocalizationManager_TypeInfo);
		  }
		  iVar1 = func_ii_4685(*(undefined4 *)(*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x5c) + 0x10),
		                       param1,
		                       Method_System_Collections_Generic_List_ILocalizationParamsManager__Contains__
		                      );
		  if (iVar1 == 0) {
		    if (*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x74) == 0) {
		      func_ii_306000(I2_Loc_LocalizationManager_TypeInfo);
		    }
		    iVar1 = Method_System_Collections_Generic_List_ILocalizationParamsManager__Add__;
		    param1_00 = *(int *)(*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x5c) + 0x10);
		    *(int *)(param1_00 + 0x10) = *(int *)(param1_00 + 0x10) + 1;
		    uVar2 = *(uint *)(param1_00 + 0xc);
		    if (uVar2 < *(uint *)(*(int *)(param1_00 + 8) + 0xc)) {
		      *(uint *)(param1_00 + 0xc) = uVar2 + 1;
		      *(undefined4 *)(*(int *)(param1_00 + 8) + uVar2 * 4 + 0x10) = param1;
		    }
		    else {
		      System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		                (param1_00,param1,*(undefined4 *)(*(int *)(*(int *)(iVar1 + 0x10) + 0x60) + 0x38));
		    }
		    I2_Loc_LocalizationManager__GetAppName(1,0);
		  }
		  return;
		}
		*/

		}
	}
}
