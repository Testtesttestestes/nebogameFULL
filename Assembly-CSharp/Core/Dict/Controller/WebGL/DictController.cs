using System;
using Core.Dict.Model;
using Il2CppDummyDll;

namespace Core.Dict.Controller.WebGL
{
	// Token: 0x020010A9 RID: 4265
	[Token(Token = "0x20010A9")]
	public class DictController : BaseDictController
	{
		// Token: 0x06006314 RID: 25364 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006314")]
		[Address(RVA = "0xAF20", Offset = "0xAF20", VA = "0xAF20")]
		public DictController(DictModel model, DictEvents events)
		{
		/* --- GHIDRA: .ctor ---
		void Core_Dict_Controller_Android_DictController___ctor(undefined4 param1,undefined4 param2)
		
		{
		  undefined8 local_30;
		  undefined8 local_28;
		  undefined4 local_20;
		  undefined8 local_1c;
		  undefined8 local_14;
		  undefined4 local_c;
		  undefined8 local_8;
		  
		  Core_Dict_Controller_Android_DictController__HandleRun(param1,&local_30);
		  if (DAT_ram_00a60753 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Runtime_CompilerServices_AsyncVoidMethodBuilder_Start_BaseDictController__HandleRun_d__3___
		              );
		    DAT_ram_00a60753 = '\x01';
		  }
		  local_8 = 0;
		  System_Linq_Enumerable__ToDictionary_KeyValuePair_object__object___object__object_(&local_30,0);
		  local_14 = local_28;
		  local_20 = 0xffffffff;
		  local_1c = local_30;
		  local_c = param1;
		  System_Runtime_CompilerServices_AsyncVoidMethodBuilder__Start_AprInfoWindowMediator__HandleBuyAprConfirmation_d__17_
		            (&local_1c,&local_20,
		             Method_System_Runtime_CompilerServices_AsyncVoidMethodBuilder_Start_BaseDictController__HandleRun_d__3___
		            );
		  return;
		}
		*/

		/* --- GHIDRA: .ctor ---
		void Core_Dict_Controller_WebGL_DictController___ctor
		               (undefined4 param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  if (DAT_ram_00a60752 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_MVC_AbstractController_DictModel__DictEvents___ctor__);
		    DAT_ram_00a60752 = '\x01';
		  }
		  Gameplay_Combat_AbstractCombat_object__object__object__object__object___set_User
		            (param1,param2,param3,Method_MVC_AbstractController_DictModel__DictEvents___ctor__);
		  return;
		}
		*/

		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: HandleRun ---
		void Core_Dict_Controller_Android_DictController__HandleRun(int *param1,undefined4 param2)
		
		{
		  uint uVar1;
		  undefined4 uVar2;
		  int iVar3;
		  uint *puVar4;
		  undefined4 uVar5;
		  int iVar6;
		  int iVar7;
		  int *piVar8;
		  undefined4 uVar9;
		  
		  if (DAT_ram_00a6075d == '\0') {
		    Mono_Security_ASN1__get_Item(&UnityEngine_Application_TypeInfo);
		    Mono_Security_ASN1__get_Item(&OKG_Logs_Debug_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IAuthDataProvider_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Managers_IDictNameSource_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_IO_Path_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_6534);
		    Mono_Security_ASN1__get_Item(&StringLiteral_326);
		    DAT_ram_00a6075d = '\x01';
		  }
		  if (*(int *)(UnityEngine_Application_TypeInfo + 0x74) == 0) {
		    func_ii_306000(UnityEngine_Application_TypeInfo);
		  }
		  uVar1 = 0;
		  uVar2 = func_ii_8896(0);
		  iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  piVar8 = *(int **)(iVar3 + 0xc);
		  iVar3 = *piVar8;
		  if (*(ushort *)(iVar3 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IAuthDataProvider_TypeInfo == *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8))
		      {
		        puVar4 = (uint *)(iVar3 + *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x81cdc1e9;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		  }
		  puVar4 = (uint *)func_ii_1080(piVar8,Core_Gameplay_IAuthDataProvider_TypeInfo,0);
		code_r0x81cdc1e9:
		  iVar3 = (**(code **)((ulonglong)*puVar4 * 4))(piVar8,puVar4[1]);
		  uVar9 = *(undefined4 *)(iVar3 + 0x18);
		  iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  uVar1 = 0;
		  piVar8 = *(int **)(iVar3 + 0xc);
		  iVar3 = *piVar8;
		  if (*(ushort *)(iVar3 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IAuthDataProvider_TypeInfo == *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8))
		      {
		        puVar4 = (uint *)(iVar3 + *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x81cdc289;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		  }
		  puVar4 = (uint *)func_ii_1080(piVar8,Core_Gameplay_IAuthDataProvider_TypeInfo,0);
		code_r0x81cdc289:
		  iVar3 = (**(code **)((ulonglong)*puVar4 * 4))(piVar8,puVar4[1]);
		  uVar1 = 0;
		  piVar8 = *(int **)(iVar3 + 0x38);
		  iVar3 = *piVar8;
		  if (*(ushort *)(iVar3 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_Managers_IDictNameSource_TypeInfo ==
		          *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8)) {
		        puVar4 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + iVar3 + 0xd0);
		        goto code_r0x81cdc30e;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		  }
		  puVar4 = (uint *)func_ii_1080(piVar8,Core_Gameplay_Managers_IDictNameSource_TypeInfo,2);
		code_r0x81cdc30e:
		  uVar5 = (**(code **)((ulonglong)*puVar4 * 4))(piVar8,puVar4[1]);
		  uVar9 = Mono_Security_X509_X509Crl_X509CrlEntry___ctor(uVar9,uVar5,0);
		  if (*(int *)(System_IO_Path_TypeInfo + 0x74) == 0) {
		    func_ii_306000(System_IO_Path_TypeInfo);
		  }
		  uVar2 = UnityEngine_Application__get_persistentDataPath(uVar2,uVar9,0);
		  uVar9 = func_ii_15992(uVar2,0);
		  uVar2 = System_IO_Path__CleanPath(uVar2,0);
		  iVar3 = func_ii_2117(uVar2,0);
		  if (iVar3 != 0) {
		    iVar3 = 0;
		    iVar6 = System_IO_DriveNotFoundException___ctor(uVar2,0);
		    if (0 < *(int *)(iVar6 + 0xc)) {
		      do {
		        uVar2 = *(undefined4 *)(iVar6 + iVar3 * 4 + 0x10);
		        if (*(int *)(System_IO_Path_TypeInfo + 0x74) == 0) {
		          func_ii_306000(System_IO_Path_TypeInfo);
		        }
		        uVar5 = func_ii_15992(uVar2,0);
		        iVar7 = Mono_Security_X509_X509CertificateCollection_X509CertificateEnumerator__get_Current
		                          (uVar5,uVar9,0);
		        if (iVar7 != 0) {
		          uVar5 = System_Int32__ToString(StringLiteral_6534,uVar5,StringLiteral_326,uVar9,0);
		          if (*(int *)(OKG_Logs_Debug_TypeInfo + 0x74) == 0) {
		            func_ii_306000(OKG_Logs_Debug_TypeInfo);
		          }
		          System_Collections_Generic_Dictionary_uint__object___get_Count(uVar5,0);
		          System_IO_File__Exists(uVar2,0);
		        }
		        iVar3 = iVar3 + 1;
		      } while (iVar3 < *(int *)(iVar6 + 0xc));
		    }
		  }
		  return;
		}
		*/


		/* --- GHIDRA: PruneOldDictionaries ---
		void Core_Dict_Controller_Android_DictController__PruneOldDictionaries(int param1,undefined4 param2)
		
		{
		  func_ii_14558(*(undefined4 *)(*(int *)(param1 + 0x10) + 0xb4),0);
		  return;
		}
		*/

}
