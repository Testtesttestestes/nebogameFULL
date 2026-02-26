using System;
using Core.Data;
using Cysharp.Threading.Tasks;
using Gameplay.Medals.Events;
using Gameplay.Medals.Model;
using Google.Protobuf;
using Il2CppDummyDll;
using MVC;
using Protocol.Main;
using ServicesNamespace;
using Utils;

namespace Gameplay.Medals.Controller
{
	// Token: 0x0200060C RID: 1548
	[Token(Token = "0x200060C")]
	public class MedalsController : AbstractController<MedalsModel, MedalsEvents>
	{
		// Token: 0x06002592 RID: 9618 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002592")]
		[Address(RVA = "0x76D6", Offset = "0x76D6", VA = "0x76D6", Slot = "5")]
		public override void Dispose()
		{
		/* --- GHIDRA: Dispose ---
		void Gameplay_Medals_Controller_MedalsController__Dispose
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a57dc5 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_MVC_AbstractController_MedalsModel__MedalsEvents___ctor__);
		    Mono_Security_ASN1__get_Item(&Method_Core_Net_ServiceFactory_GetService_MainService___);
		    Mono_Security_ASN1__get_Item(&Method_Core_Net_ServiceFactory_GetService_ServicesService___);
		    Mono_Security_ASN1__get_Item(&Core_Net_ServiceFactory_TypeInfo);
		    DAT_ram_00a57dc5 = '\x01';
		  }
		  Gameplay_Combat_AbstractCombat_object__object__object__object__object___set_User
		            (param1,param2,param3,Method_MVC_AbstractController_MedalsModel__MedalsEvents___ctor__);
		  if (*(int *)(Core_Net_ServiceFactory_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Net_ServiceFactory_TypeInfo);
		  }
		  uVar1 = Core_Gameplay_Managers_LoggedManager__RequestLogin
		                    (Method_Core_Net_ServiceFactory_GetService_MainService___);
		  *(undefined4 *)(param1 + 0x18) = uVar1;
		  uVar1 = Core_Gameplay_Managers_LoggedManager__RequestLogin
		                    (Method_Core_Net_ServiceFactory_GetService_ServicesService___);
		  *(undefined4 *)(param1 + 0x1c) = uVar1;
		  return;
		}
		*/

		}

		// Token: 0x06002593 RID: 9619 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002593")]
		[Address(RVA = "0x76D7", Offset = "0x76D7", VA = "0x76D7")]
		public MedalsController(MedalsModel model, MedalsEvents events)
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Medals_Controller_MedalsController___ctor(int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  uint *puVar2;
		  undefined4 uVar3;
		  undefined8 uVar4;
		  int iVar5;
		  int *piVar6;
		  uint uVar7;
		  
		  if (DAT_ram_00a57dc6 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoTakeOffMedalsEvt__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoNewMedalsEvt__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Cache_CacheResultCallback_UserData__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Cache_ICache_ulong__UserData__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Medals_Controller_MedalsController_MainServiceOnNewMedalsEvent__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Medals_Controller_MedalsController_MainServiceOnTakeOffMedalsEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Medals_Controller_MedalsController_UserCacheResultCallback__);
		    Mono_Security_ASN1__get_Item(&ulong___TypeInfo);
		    DAT_ram_00a57dc6 = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  iVar5 = *(int *)(iVar1 + 8);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  if (iVar5 == *(int *)(iVar1 + 0x10)) {
		    uVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x104));
		    iVar5 = *param1;
		    iVar1 = (**(code **)((ulonglong)*(uint *)(iVar5 + 0x100) * 4))
		                      (param1,*(undefined4 *)(iVar5 + 0x104));
		    Gameplay_Medals_Model_MedalsModel___ctor
		              (uVar3,*(undefined4 *)(*(int *)(iVar1 + 8) + 0x40),iVar5);
		    if (*(char *)((int)param1 + 9) == '\0') {
		      *(undefined1 *)((int)param1 + 9) = 1;
		      iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x114));
		      iVar1 = *(int *)(iVar1 + 8);
		      if (iVar1 != 0) {
		        (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		                  (*(undefined4 *)(iVar1 + 0x20),*(undefined4 *)(iVar1 + 0x14));
		      }
		    }
		    iVar1 = param1[6];
		    uVar3 = unnamed_function_1417(System_Action_ProtoNewMedalsEvt__TypeInfo);
		    UnityEngine_UIElements_VisualElement__get_layout
		              (uVar3,param1,
		               Method_Gameplay_Medals_Controller_MedalsController_MainServiceOnNewMedalsEvent__,0);
		    ServicesNamespace_MainService__remove_InventoryChangedEvent(iVar1,uVar3,0);
		    iVar1 = param1[6];
		    uVar3 = unnamed_function_1417(System_Action_ProtoTakeOffMedalsEvt__TypeInfo);
		    UnityEngine_UIElements_VisualElement__get_layout
		              (uVar3,param1,
		               Method_Gameplay_Medals_Controller_MedalsController_MainServiceOnTakeOffMedalsEvent__,
		               0);
		    ServicesNamespace_MainService__remove_NewMedalsEvent(iVar1,uVar3,0);
		    return;
		  }
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  piVar6 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar1 = *piVar6;
		  if (*(ushort *)(iVar1 + 0xb6) != 0) {
		    uVar7 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar1 + 0x58) + uVar7 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar1 + 0x58) + uVar7 * 8 + 4) * 8 + iVar1 + 0x158);
		        goto code_r0x80e60d63;
		      }
		      uVar7 = uVar7 + 1;
		    } while (*(ushort *)(iVar1 + 0xb6) != uVar7);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar6,Core_Gameplay_IGame_TypeInfo,0x13);
		code_r0x80e60d63:
		  iVar1 = (**(code **)((ulonglong)*puVar2 * 4))(piVar6,puVar2[1]);
		  piVar6 = *(int **)(iVar1 + 0x18);
		  uVar7 = 0;
		  uVar3 = unnamed_function_1417(Core_Cache_CacheResultCallback_UserData__TypeInfo);
		  Cysharp_Threading_Tasks_UniTaskCompletionSource__get_Task
		            (uVar3,param1,
		             Method_Gameplay_Medals_Controller_MedalsController_UserCacheResultCallback__,0);
		  iVar1 = Mono_Security_ASN1Convert__ToOid(ulong___TypeInfo,1);
		  iVar5 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  uVar4 = System_Collections_Generic_LinkedList_Enumerator_object___MoveNext
		                    (*(undefined4 *)(iVar5 + 8),0);
		  *(undefined8 *)(iVar1 + 0x10) = uVar4;
		  iVar5 = *piVar6;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    do {
		      if (Core_Cache_ICache_ulong__UserData__TypeInfo ==
		          *(int *)(*(int *)(iVar5 + 0x58) + uVar7 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar7 * 8 + 4) * 8 + iVar5 + 200);
		        goto code_r0x80e60e3a;
		      }
		      uVar7 = uVar7 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar7);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar6,Core_Cache_ICache_ulong__UserData__TypeInfo,1);
		code_r0x80e60e3a:
		  (**(code **)((ulonglong)*puVar2 * 4))(piVar6,uVar3,iVar1,puVar2[1]);
		  return;
		}
		*/

		}

		// Token: 0x06002594 RID: 9620 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002594")]
		[Address(RVA = "0x76D8", Offset = "0x76D8", VA = "0x76D8", Slot = "7")]
		protected override void HandleRun()
		{
		/* --- GHIDRA: HandleRun ---
		void Gameplay_Medals_Controller_MedalsController__HandleRun
		               (int *param1,int param2,undefined4 param3)
		
		{
		  uint uVar1;
		  undefined4 *puVar2;
		  undefined4 param2_00;
		  undefined4 uVar3;
		  int iVar4;
		  int *piVar5;
		  int iVar6;
		  uint *puVar7;
		  int iVar8;
		  int *piVar9;
		  int local_c;
		  int **local_8;
		  int *local_4;
		  
		  if (DAT_ram_00a57dc7 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_IDisposable_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               System_Collections_Generic_IEnumerator_ProtoTakeOffMedalsEvt_Types_MedalInform__TypeInfo
		              );
		    Mono_Security_ASN1__get_Item(&System_Collections_IEnumerator_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Google_Protobuf_Collections_RepeatedField_ProtoTakeOffMedalsEvt_Types_MedalInform__GetEnumerator__
		              );
		    DAT_ram_00a57dc7 = '\x01';
		  }
		  local_4 = (int *)Google_Protobuf_Collections_RepeatedField_float___Equals
		                             (*(undefined4 *)(param2 + 0xc),
		                              Method_Google_Protobuf_Collections_RepeatedField_ProtoTakeOffMedalsEvt_Types_MedalInform__GetEnumerator__
		                             );
		  local_c = 0;
		  local_8 = &local_4;
		  do {
		    piVar5 = local_4;
		    iVar8 = *local_4;
		    if (*(ushort *)(iVar8 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        piVar9 = (int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8);
		        if (System_Collections_IEnumerator_TypeInfo == *piVar9) {
		          puVar2 = (undefined4 *)(iVar8 + piVar9[1] * 8 + 0xc0);
		          goto code_r0x80e60fa7;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar8 + 0xb6) != uVar1);
		    }
		    DAT_ram_009d3e38 = 0;
		    puVar2 = (undefined4 *)
		             import::env::invoke_iiii
		                       (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                        System_Collections_IEnumerator_TypeInfo,0);
		    if (DAT_ram_009d3e38 == 1) {
		code_r0x80e611e6:
		      DAT_ram_009d3e38 = 0;
		      uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80e611ee;
		    }
		code_r0x80e60fa7:
		    DAT_ram_009d3e38 = 0;
		    iVar8 = import::env::invoke_iii(*puVar2,piVar5,puVar2[1]);
		    piVar5 = local_4;
		    if (DAT_ram_009d3e38 == 1) goto code_r0x80e611e6;
		    if (iVar8 == 0) {
		      iVar8 = 0;
		      goto code_r0x80e61237;
		    }
		    iVar8 = *local_4;
		    if (*(ushort *)(iVar8 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        piVar9 = (int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8);
		        if (System_Collections_Generic_IEnumerator_ProtoTakeOffMedalsEvt_Types_MedalInform__TypeInfo
		            == *piVar9) {
		          puVar2 = (undefined4 *)(iVar8 + piVar9[1] * 8 + 0xc0);
		          goto code_r0x80e61081;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar8 + 0xb6) != uVar1);
		    }
		    DAT_ram_009d3e38 = 0;
		    puVar2 = (undefined4 *)
		             import::env::invoke_iiii
		                       (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                        System_Collections_Generic_IEnumerator_ProtoTakeOffMedalsEvt_Types_MedalInform__TypeInfo
		                        ,0);
		    if (DAT_ram_009d3e38 == 1) {
		code_r0x80e611c8:
		      DAT_ram_009d3e38 = 0;
		      uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80e611ee;
		    }
		code_r0x80e61081:
		    DAT_ram_009d3e38 = 0;
		    iVar8 = import::env::invoke_iii(*puVar2,piVar5,puVar2[1]);
		    if (DAT_ram_009d3e38 == 1) goto code_r0x80e611c8;
		    DAT_ram_009d3e38 = 0;
		    iVar6 = import::env::invoke_iii
		                      (*(undefined4 *)(*param1 + 0x100),param1,*(undefined4 *)(*param1 + 0x104));
		    iVar4 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar4 == 1) {
		      uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80e611ee;
		    }
		    uVar3 = *(undefined4 *)(iVar8 + 0xc);
		    if (DAT_ram_00a57dad == '\0') {
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_vi
		                (0x7ff,&Method_System_Collections_Generic_Dictionary_uint__MedalData__get_Item__);
		      if (DAT_ram_009d3e38 == 1) break;
		      DAT_ram_00a57dad = '\x01';
		    }
		    DAT_ram_009d3e38 = 0;
		    param2_00 = import::env::invoke_iiii
		                          (s_struct_Uniforms___color__array<v_ram_00000aff + 0x22b,
		                           *(undefined4 *)(iVar6 + 0x20),uVar3,
		                           Method_System_Collections_Generic_Dictionary_uint__MedalData__get_Item__)
		    ;
		    if (DAT_ram_009d3e38 == 1) break;
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_viii
		              (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x8f,param2_00,uVar3,0);
		  } while (DAT_ram_009d3e38 != 1);
		  DAT_ram_009d3e38 = 0;
		  uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x80e611ee:
		  iVar8 = global_1;
		  iVar4 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar8 == iVar4) {
		    piVar5 = (int *)import::env::__cxa_begin_catch(uVar3);
		    iVar8 = *piVar5;
		    DAT_ram_009d3e38 = 0;
		    local_c = iVar8;
		    import::env::invoke_v(0x123);
		    iVar4 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar4 != 1) {
		code_r0x80e61237:
		      piVar5 = local_4;
		      DAT_ram_009d3e38 = 0;
		      if (local_4 != (int *)0x0) {
		        uVar1 = 0;
		        iVar4 = *local_4;
		        if (*(ushort *)(iVar4 + 0xb6) != 0) {
		          do {
		            if (System_IDisposable_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		              puVar7 = (uint *)(iVar4 + *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0)
		              ;
		              goto code_r0x80e612af;
		            }
		            uVar1 = uVar1 + 1;
		          } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		        }
		        puVar7 = (uint *)func_ii_1080(local_4,System_IDisposable_TypeInfo,0);
		code_r0x80e612af:
		        (**(code **)((ulonglong)*puVar7 * 4))(piVar5,puVar7[1]);
		      }
		      if (iVar8 != 0) {
		        System_Data_DataSet__ValidateLocaleConstraint(iVar8);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      local_4 = (int *)Google_Protobuf_Collections_RepeatedField_float___Equals
		                                 (*(undefined4 *)(param2 + 0xc),
		                                  Method_Google_Protobuf_Collections_RepeatedField_ProtoTakeOffMedalsEvt_Types_MedalInform__GetEnumerator__
		                                 );
		      local_c = 0;
		      local_8 = &local_4;
		      do {
		        do {
		          piVar5 = local_4;
		          iVar8 = *local_4;
		          if (*(ushort *)(iVar8 + 0xb6) != 0) {
		            uVar1 = 0;
		            do {
		              piVar9 = (int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8);
		              if (System_Collections_IEnumerator_TypeInfo == *piVar9) {
		                puVar2 = (undefined4 *)(iVar8 + piVar9[1] * 8 + 0xc0);
		                goto code_r0x80e61391;
		              }
		              uVar1 = uVar1 + 1;
		            } while (*(ushort *)(iVar8 + 0xb6) != uVar1);
		          }
		          DAT_ram_009d3e38 = 0;
		          puVar2 = (undefined4 *)
		                   import::env::invoke_iiii
		                             (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                              System_Collections_IEnumerator_TypeInfo,0);
		          if (DAT_ram_009d3e38 == 1) {
		code_r0x80e613d9:
		            DAT_ram_009d3e38 = 0;
		            uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		            goto code_r0x80e61576;
		          }
		code_r0x80e61391:
		          DAT_ram_009d3e38 = 0;
		          iVar8 = import::env::invoke_iii(*puVar2,piVar5,puVar2[1]);
		          piVar5 = local_4;
		          if (DAT_ram_009d3e38 == 1) goto code_r0x80e613d9;
		          if (iVar8 == 0) {
		            iVar8 = 0;
		            goto code_r0x80e615bf;
		          }
		          iVar8 = *local_4;
		          if (*(ushort *)(iVar8 + 0xb6) != 0) {
		            uVar1 = 0;
		            do {
		              piVar9 = (int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8);
		              if (System_Collections_Generic_IEnumerator_ProtoTakeOffMedalsEvt_Types_MedalInform__TypeInfo
		                  == *piVar9) {
		                puVar2 = (undefined4 *)(iVar8 + piVar9[1] * 8 + 0xc0);
		                goto code_r0x80e61482;
		              }
		              uVar1 = uVar1 + 1;
		            } while (*(ushort *)(iVar8 + 0xb6) != uVar1);
		          }
		          DAT_ram_009d3e38 = 0;
		          puVar2 = (undefined4 *)
		                   import::env::invoke_iiii
		                             (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                              System_Collections_Generic_IEnumerator_ProtoTakeOffMedalsEvt_Types_MedalInform__TypeInfo
		                              ,0);
		          if (DAT_ram_009d3e38 == 1) {
		code_r0x80e6150f:
		            DAT_ram_009d3e38 = 0;
		            uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		            goto code_r0x80e61576;
		          }
		code_r0x80e61482:
		          DAT_ram_009d3e38 = 0;
		          iVar8 = import::env::invoke_iii(*puVar2,piVar5,puVar2[1]);
		          if (DAT_ram_009d3e38 == 1) goto code_r0x80e6150f;
		          DAT_ram_009d3e38 = 0;
		          iVar6 = import::env::invoke_iii
		                            (*(undefined4 *)(*param1 + 0x110),param1,
		                             *(undefined4 *)(*param1 + 0x114));
		          iVar4 = DAT_ram_009d3e38;
		          DAT_ram_009d3e38 = 0;
		          if (iVar4 == 1) {
		            uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		            goto code_r0x80e61576;
		          }
		          iVar4 = *(int *)(iVar6 + 0x18);
		        } while (iVar4 == 0);
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_viii
		                  (*(undefined4 *)(iVar4 + 0xc),*(undefined4 *)(iVar4 + 0x20),
		                   *(undefined4 *)(iVar8 + 0xc),*(undefined4 *)(iVar4 + 0x14));
		        iVar8 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		      } while (iVar8 != 1);
		      uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x80e61576:
		      iVar8 = global_1;
		      iVar4 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		      if (iVar8 == iVar4) {
		        piVar5 = (int *)import::env::__cxa_begin_catch(uVar3);
		        iVar8 = *piVar5;
		        DAT_ram_009d3e38 = 0;
		        local_c = iVar8;
		        import::env::invoke_v(0x123);
		        iVar4 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar4 != 1) {
		code_r0x80e615bf:
		          piVar5 = local_4;
		          DAT_ram_009d3e38 = 0;
		          if (local_4 != (int *)0x0) {
		            uVar1 = 0;
		            iVar4 = *local_4;
		            if (*(ushort *)(iVar4 + 0xb6) != 0) {
		              do {
		                if (System_IDisposable_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		                  puVar7 = (uint *)(iVar4 + *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 +
		                                   0xc0);
		                  goto code_r0x80e61637;
		                }
		                uVar1 = uVar1 + 1;
		              } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		            }
		            puVar7 = (uint *)func_ii_1080(local_4,System_IDisposable_TypeInfo,0);
		code_r0x80e61637:
		            (**(code **)((ulonglong)*puVar7 * 4))(piVar5,puVar7[1]);
		          }
		          if (iVar8 != 0) {
		            System_Data_DataSet__ValidateLocaleConstraint(iVar8);
		            do {
		              halt_trap();
		            } while( true );
		          }
		          return;
		        }
		        uVar3 = import::env::__cxa_find_matching_catch_2();
		      }
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001b87 + 0x90,&local_c);
		      goto joined_r0x80e61685;
		    }
		    uVar3 = import::env::__cxa_find_matching_catch_2();
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001b87 + 0x91,&local_c);
		joined_r0x80e61685:
		  if (DAT_ram_009d3e38 == 1) {
		    DAT_ram_009d3e38 = 0;
		    import::env::__cxa_find_matching_catch_3(0);
		    unnamed_function_937();
		    do {
		      halt_trap();
		    } while( true );
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::__resumeException(uVar3);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x06002595 RID: 9621 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002595")]
		[Address(RVA = "0x76D9", Offset = "0x76D9", VA = "0x76D9")]
		private void MainServiceOnTakeOffMedalsEvent(ProtoTakeOffMedalsEvt evt)
		{
		/* --- GHIDRA: MainServiceOnTakeOffMedalsEvent ---
		void Gameplay_Medals_Controller_MedalsController__MainServiceOnTakeOffMedalsEvent
		               (int *param1,int param2,undefined4 param3)
		
		{
		  uint uVar1;
		  undefined4 param1_00;
		  undefined4 *puVar2;
		  undefined4 uVar3;
		  int iVar4;
		  int *piVar5;
		  int iVar6;
		  int iVar7;
		  uint *puVar8;
		  int iVar9;
		  int *piVar10;
		  int local_c;
		  int **local_8;
		  int *local_4;
		  
		  if (DAT_ram_00a57dc8 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_uint__MedalData__get_Item__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_HashSet_uint__Add__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_HashSet_uint__Contains__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_HashSet_uint___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_HashSet_uint__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_IDisposable_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_IEnumerator_MedalInfo__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_IEnumerator_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_MedalInfo__GetEnumerator__);
		    DAT_ram_00a57dc8 = '\x01';
		  }
		  param1_00 = unnamed_function_1417(System_Collections_Generic_HashSet_uint__TypeInfo);
		  System_Collections_Generic_HashSet_PropertyPath___get_Count
		            (param1_00,Method_System_Collections_Generic_HashSet_uint___ctor__);
		  local_4 = (int *)Google_Protobuf_Collections_RepeatedField_float___Equals
		                             (*(undefined4 *)(param2 + 0xc),
		                              Method_Google_Protobuf_Collections_RepeatedField_MedalInfo__GetEnumerator__
		                             );
		  local_c = 0;
		  local_8 = &local_4;
		  do {
		    do {
		      piVar5 = local_4;
		      iVar9 = *local_4;
		      if (*(ushort *)(iVar9 + 0xb6) != 0) {
		        uVar1 = 0;
		        do {
		          piVar10 = (int *)(*(int *)(iVar9 + 0x58) + uVar1 * 8);
		          if (System_Collections_IEnumerator_TypeInfo == *piVar10) {
		            puVar2 = (undefined4 *)(iVar9 + piVar10[1] * 8 + 0xc0);
		            goto code_r0x80e61840;
		          }
		          uVar1 = uVar1 + 1;
		        } while (*(ushort *)(iVar9 + 0xb6) != uVar1);
		      }
		      DAT_ram_009d3e38 = 0;
		      puVar2 = (undefined4 *)
		               import::env::invoke_iiii
		                         (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                          System_Collections_IEnumerator_TypeInfo,0);
		      if (DAT_ram_009d3e38 == 1) {
		code_r0x80e61888:
		        DAT_ram_009d3e38 = 0;
		        uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x80e61a51;
		      }
		code_r0x80e61840:
		      DAT_ram_009d3e38 = 0;
		      iVar9 = import::env::invoke_iii(*puVar2,piVar5,puVar2[1]);
		      piVar5 = local_4;
		      if (DAT_ram_009d3e38 == 1) goto code_r0x80e61888;
		      if (iVar9 == 0) {
		        iVar9 = 0;
		        goto code_r0x80e61a9a;
		      }
		      iVar9 = *local_4;
		      if (*(ushort *)(iVar9 + 0xb6) != 0) {
		        uVar1 = 0;
		        do {
		          piVar10 = (int *)(*(int *)(iVar9 + 0x58) + uVar1 * 8);
		          if (System_Collections_Generic_IEnumerator_MedalInfo__TypeInfo == *piVar10) {
		            puVar2 = (undefined4 *)(iVar9 + piVar10[1] * 8 + 0xc0);
		            goto code_r0x80e61933;
		          }
		          uVar1 = uVar1 + 1;
		        } while (*(ushort *)(iVar9 + 0xb6) != uVar1);
		      }
		      DAT_ram_009d3e38 = 0;
		      puVar2 = (undefined4 *)
		               import::env::invoke_iiii
		                         (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                          System_Collections_Generic_IEnumerator_MedalInfo__TypeInfo,0);
		      if (DAT_ram_009d3e38 == 1) {
		code_r0x80e619ed:
		        DAT_ram_009d3e38 = 0;
		        uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x80e61a51;
		      }
		code_r0x80e61933:
		      DAT_ram_009d3e38 = 0;
		      iVar9 = import::env::invoke_iii(*puVar2,piVar5,puVar2[1]);
		      if (DAT_ram_009d3e38 == 1) goto code_r0x80e619ed;
		      DAT_ram_009d3e38 = 0;
		      uVar3 = import::env::invoke_iii
		                        (*(undefined4 *)(*param1 + 0x100),param1,*(undefined4 *)(*param1 + 0x104));
		      iVar4 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar4 == 1) {
		        uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x80e61a51;
		      }
		      DAT_ram_009d3e38 = 0;
		      iVar6 = import::env::invoke_iiii
		                        (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x92,uVar3,iVar9,iVar9);
		      iVar4 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar4 == 1) {
		        uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x80e61a51;
		      }
		    } while (iVar6 == 0);
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_iiii
		              (s_struct_Uniforms___color__array<v_ram_00000aff + 0x3bf,param1_00,
		               *(undefined4 *)(iVar9 + 0xc),Method_System_Collections_Generic_HashSet_uint__Add__);
		    iVar9 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		  } while (iVar9 != 1);
		  uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x80e61a51:
		  iVar9 = global_1;
		  iVar4 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar9 == iVar4) {
		    piVar5 = (int *)import::env::__cxa_begin_catch(uVar3);
		    iVar9 = *piVar5;
		    DAT_ram_009d3e38 = 0;
		    local_c = iVar9;
		    import::env::invoke_v(0x123);
		    iVar4 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar4 != 1) {
		code_r0x80e61a9a:
		      piVar5 = local_4;
		      DAT_ram_009d3e38 = 0;
		      if (local_4 != (int *)0x0) {
		        uVar1 = 0;
		        iVar4 = *local_4;
		        if (*(ushort *)(iVar4 + 0xb6) != 0) {
		          do {
		            if (System_IDisposable_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		              puVar8 = (uint *)(iVar4 + *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0)
		              ;
		              goto code_r0x80e61b12;
		            }
		            uVar1 = uVar1 + 1;
		          } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		        }
		        puVar8 = (uint *)func_ii_1080(local_4,System_IDisposable_TypeInfo,0);
		code_r0x80e61b12:
		        (**(code **)((ulonglong)*puVar8 * 4))(piVar5,puVar8[1]);
		      }
		      if (iVar9 != 0) {
		        System_Data_DataSet__ValidateLocaleConstraint(iVar9);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      local_4 = (int *)Google_Protobuf_Collections_RepeatedField_float___Equals
		                                 (*(undefined4 *)(param2 + 0xc),
		                                  Method_Google_Protobuf_Collections_RepeatedField_MedalInfo__GetEnumerator__
		                                 );
		      local_c = 0;
		      local_8 = &local_4;
		      do {
		        do {
		          piVar5 = local_4;
		          iVar9 = *local_4;
		          if (*(ushort *)(iVar9 + 0xb6) != 0) {
		            uVar1 = 0;
		            do {
		              piVar10 = (int *)(*(int *)(iVar9 + 0x58) + uVar1 * 8);
		              if (System_Collections_IEnumerator_TypeInfo == *piVar10) {
		                puVar2 = (undefined4 *)(iVar9 + piVar10[1] * 8 + 0xc0);
		                goto code_r0x80e61c02;
		              }
		              uVar1 = uVar1 + 1;
		            } while (*(ushort *)(iVar9 + 0xb6) != uVar1);
		          }
		          DAT_ram_009d3e38 = 0;
		          puVar2 = (undefined4 *)
		                   import::env::invoke_iiii
		                             (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                              System_Collections_IEnumerator_TypeInfo,0);
		          if (DAT_ram_009d3e38 == 1) {
		code_r0x80e61c4a:
		            DAT_ram_009d3e38 = 0;
		            uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		            goto code_r0x80e61f1d;
		          }
		code_r0x80e61c02:
		          DAT_ram_009d3e38 = 0;
		          iVar9 = import::env::invoke_iii(*puVar2,piVar5,puVar2[1]);
		          piVar5 = local_4;
		          if (DAT_ram_009d3e38 == 1) goto code_r0x80e61c4a;
		          if (iVar9 == 0) {
		            iVar9 = 0;
		            goto code_r0x80e61f66;
		          }
		          iVar9 = *local_4;
		          if (*(ushort *)(iVar9 + 0xb6) != 0) {
		            uVar1 = 0;
		            do {
		              piVar10 = (int *)(*(int *)(iVar9 + 0x58) + uVar1 * 8);
		              if (System_Collections_Generic_IEnumerator_MedalInfo__TypeInfo == *piVar10) {
		                puVar2 = (undefined4 *)(iVar9 + piVar10[1] * 8 + 0xc0);
		                goto code_r0x80e61cef;
		              }
		              uVar1 = uVar1 + 1;
		            } while (*(ushort *)(iVar9 + 0xb6) != uVar1);
		          }
		          DAT_ram_009d3e38 = 0;
		          puVar2 = (undefined4 *)
		                   import::env::invoke_iiii
		                             (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                              System_Collections_Generic_IEnumerator_MedalInfo__TypeInfo,0);
		          if (DAT_ram_009d3e38 == 1) {
		code_r0x80e61ed9:
		            DAT_ram_009d3e38 = 0;
		            uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		            goto code_r0x80e61f1d;
		          }
		code_r0x80e61cef:
		          DAT_ram_009d3e38 = 0;
		          iVar9 = import::env::invoke_iii(*puVar2,piVar5,puVar2[1]);
		          if (DAT_ram_009d3e38 == 1) goto code_r0x80e61ed9;
		          DAT_ram_009d3e38 = 0;
		          iVar6 = import::env::invoke_iii
		                            (*(undefined4 *)(*param1 + 0x110),param1,
		                             *(undefined4 *)(*param1 + 0x114));
		          iVar4 = DAT_ram_009d3e38;
		          DAT_ram_009d3e38 = 0;
		          if (iVar4 == 1) {
		            uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		            goto code_r0x80e61f1d;
		          }
		          iVar4 = *(int *)(iVar6 + 0x14);
		          if (iVar4 != 0) {
		            DAT_ram_009d3e38 = 0;
		            iVar7 = import::env::invoke_iii
		                              (*(undefined4 *)(*param1 + 0x100),param1,
		                               *(undefined4 *)(*param1 + 0x104));
		            iVar6 = DAT_ram_009d3e38;
		            DAT_ram_009d3e38 = 0;
		            if (iVar6 == 1) {
		              uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		              goto code_r0x80e61f1d;
		            }
		            DAT_ram_009d3e38 = 0;
		            uVar3 = import::env::invoke_iiii
		                              (s_struct_Uniforms___color__array<v_ram_00000aff + 0x22b,
		                               *(undefined4 *)(iVar7 + 0x20),*(undefined4 *)(iVar9 + 0xc),
		                               Method_System_Collections_Generic_Dictionary_uint__MedalData__get_Item__
		                              );
		            iVar6 = DAT_ram_009d3e38;
		            DAT_ram_009d3e38 = 0;
		            if (iVar6 == 1) {
		              uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		              goto code_r0x80e61f1d;
		            }
		            DAT_ram_009d3e38 = 0;
		            import::env::invoke_viiii
		                      (*(undefined4 *)(iVar4 + 0xc),*(undefined4 *)(iVar4 + 0x20),uVar3,
		                       *(undefined4 *)(iVar9 + 0xc),*(undefined4 *)(iVar4 + 0x14));
		            iVar4 = DAT_ram_009d3e38;
		            DAT_ram_009d3e38 = 0;
		            if (iVar4 == 1) {
		              uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		              goto code_r0x80e61f1d;
		            }
		          }
		          DAT_ram_009d3e38 = 0;
		          iVar6 = import::env::invoke_iiii
		                            (s_struct_Uniforms___color__array<v_ram_00000aff + 0x3bc,param1_00,
		                             *(undefined4 *)(iVar9 + 0xc),
		                             Method_System_Collections_Generic_HashSet_uint__Contains__);
		          iVar4 = DAT_ram_009d3e38;
		          DAT_ram_009d3e38 = 0;
		          if (iVar4 == 1) {
		            uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		            goto code_r0x80e61f1d;
		          }
		        } while (iVar6 == 0);
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_viii
		                  (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x93,param1,iVar9,iVar9);
		        iVar9 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		      } while (iVar9 != 1);
		      uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x80e61f1d:
		      iVar9 = global_1;
		      iVar4 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		      if (iVar9 == iVar4) {
		        piVar5 = (int *)import::env::__cxa_begin_catch(uVar3);
		        iVar9 = *piVar5;
		        DAT_ram_009d3e38 = 0;
		        local_c = iVar9;
		        import::env::invoke_v(0x123);
		        iVar4 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar4 != 1) {
		code_r0x80e61f66:
		          piVar5 = local_4;
		          DAT_ram_009d3e38 = 0;
		          if (local_4 != (int *)0x0) {
		            uVar1 = 0;
		            iVar4 = *local_4;
		            if (*(ushort *)(iVar4 + 0xb6) != 0) {
		              do {
		                if (System_IDisposable_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		                  puVar8 = (uint *)(iVar4 + *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 +
		                                   0xc0);
		                  goto code_r0x80e61fde;
		                }
		                uVar1 = uVar1 + 1;
		              } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		            }
		            puVar8 = (uint *)func_ii_1080(local_4,System_IDisposable_TypeInfo,0);
		code_r0x80e61fde:
		            (**(code **)((ulonglong)*puVar8 * 4))(piVar5,puVar8[1]);
		          }
		          if (iVar9 == 0) {
		            return;
		          }
		          System_Data_DataSet__ValidateLocaleConstraint(iVar9);
		          do {
		            halt_trap();
		          } while( true );
		        }
		        uVar3 = import::env::__cxa_find_matching_catch_2();
		      }
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001b87 + 0x94,&local_c);
		      goto joined_r0x80e6202c;
		    }
		    uVar3 = import::env::__cxa_find_matching_catch_2();
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001b87 + 0x95,&local_c);
		joined_r0x80e6202c:
		  if (DAT_ram_009d3e38 == 1) {
		    DAT_ram_009d3e38 = 0;
		    import::env::__cxa_find_matching_catch_3(0);
		    unnamed_function_937();
		    do {
		      halt_trap();
		    } while( true );
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::__resumeException(uVar3);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x06002596 RID: 9622 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002596")]
		[Address(RVA = "0x76DA", Offset = "0x76DA", VA = "0x76DA")]
		private void MainServiceOnNewMedalsEvent(ProtoNewMedalsEvt evt)
		{
		/* --- GHIDRA: MainServiceOnNewMedalsEvent ---
		void Gameplay_Medals_Controller_MedalsController__MainServiceOnNewMedalsEvent
		               (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  uint uVar1;
		  int iVar2;
		  uint *puVar3;
		  undefined4 uVar4;
		  undefined4 uVar5;
		  undefined4 uVar6;
		  int *param1_00;
		  
		  if (DAT_ram_00a57dc9 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Dict_DictWrappers_Base_AbstractDictWrapperStorage_MedalDicWrapper__uint__GetWrapper__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Dict_DictWrappers_Base_AbstractDictWrapper_MedalDic__uint__get_Data__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__string__Add__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__string___ctor__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_uint__MedalDicGroup__get_Item__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_Dictionary_string__string__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Utils_StringUtils_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_26295);
		    Mono_Security_ASN1__get_Item(&StringLiteral_11296);
		    Mono_Security_ASN1__get_Item(&StringLiteral_27734);
		    DAT_ram_00a57dc9 = '\x01';
		  }
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  iVar2 = System_Collections_Generic_List_object___get_Item
		                    (*(undefined4 *)(*(int *)(iVar2 + 0x14) + 8),param2,
		                     Method_System_Collections_Generic_Dictionary_uint__MedalDicGroup__get_Item__);
		  if (*(char *)(iVar2 + 0x18) != '\0') {
		    if (DAT_ram_00a6456f == '\0') {
		      Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		      DAT_ram_00a6456f = '\x01';
		    }
		    param1_00 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		    iVar2 = *param1_00;
		    if (*(ushort *)(iVar2 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8)) {
		          puVar3 = (uint *)(*(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8 + 4) * 8 + iVar2 + 0x178);
		          goto code_r0x80e622ec;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		    }
		    puVar3 = (uint *)func_ii_1080(param1_00,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x80e622ec:
		    iVar2 = (**(code **)((ulonglong)*puVar3 * 4))(param1_00,puVar3[1]);
		    iVar2 = func_ii_7730(*(undefined4 *)(*(int *)(iVar2 + 0x24) + 0xc),param2,
		                         Method_Core_Dict_DictWrappers_Base_AbstractDictWrapperStorage_MedalDicWrapper__uint__GetWrapper__
		                        );
		    if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_GameLocalization_TypeInfo);
		    }
		    uVar4 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_11296,1,0,1,0,0,0,0);
		    uVar5 = unnamed_function_1417(System_Collections_Generic_Dictionary_string__string__TypeInfo);
		    System_Collections_Generic_Dictionary_object__StyleComplexSelector_PseudoStateData___set_Item
		              (uVar5,Method_System_Collections_Generic_Dictionary_string__string___ctor__);
		    uVar6 = func_ii_14054(*(undefined4 *)(iVar2 + 0x10),0);
		    System_Reflection_FieldInfo__get_IsStatic
		              (uVar5,StringLiteral_27734,uVar6,
		               Method_System_Collections_Generic_Dictionary_string__string__Add__);
		    uVar6 = *(undefined4 *)(*(int *)(iVar2 + 0x10) + 0x20);
		    if (*(int *)(Utils_StringUtils_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Utils_StringUtils_TypeInfo);
		    }
		    uVar6 = Utils_SetAsFirstSibling___ctor(uVar6,0);
		    System_Reflection_FieldInfo__get_IsStatic
		              (uVar5,StringLiteral_26295,uVar6,
		               Method_System_Collections_Generic_Dictionary_string__string__Add__);
		    uVar4 = Core_GameLocalization__GetTranslation(uVar4,uVar5,0);
		    uVar5 = System_Uri___ctor(0);
		    uVar5 = System_Globalization_TimeSpanFormat_FormatLiterals__get_DayHourSep(uVar5,0);
		    uVar4 = UI_Toast_ToastController_ToastData__Create(10,uVar4,iVar2,0);
		    UI_Toast_ToastController__OnReleaseToast(uVar5,uVar4,0);
		  }
		  return;
		}
		*/

		}

		// Token: 0x06002597 RID: 9623 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002597")]
		[Address(RVA = "0x76DB", Offset = "0x76DB", VA = "0x76DB")]
		private void ShowNewMedalToast(uint medalId)
		{
		/* --- GHIDRA: ShowNewMedalToast ---
		void Gameplay_Medals_Controller_MedalsController__ShowNewMedalToast
		               (int *param1,undefined8 param2,undefined4 param3,undefined4 param4)
		
		{
		  undefined4 param1_00;
		  int iVar1;
		  
		  if (DAT_ram_00a57dca == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_First_UserData___);
		    DAT_ram_00a57dca = '\x01';
		  }
		  param1_00 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x104));
		  iVar1 = System_Linq_Enumerable__Count_object_
		                    (param3,Method_System_Linq_Enumerable_First_UserData___);
		  Gameplay_Medals_Model_MedalsModel___ctor(param1_00,*(undefined4 *)(iVar1 + 0x40),param1);
		  if (*(char *)((int)param1 + 9) == '\0') {
		    *(undefined1 *)((int)param1 + 9) = 1;
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x114));
		    iVar1 = *(int *)(iVar1 + 8);
		    if (iVar1 != 0) {
		      (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		                (*(undefined4 *)(iVar1 + 0x20),*(undefined4 *)(iVar1 + 0x14));
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x06002598 RID: 9624 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002598")]
		[Address(RVA = "0x76DC", Offset = "0x76DC", VA = "0x76DC")]
		private void UserCacheResultCallback(long operationIndex, params UserData[] data)
		{
		}

		// Token: 0x06002599 RID: 9625 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002599")]
		[Address(RVA = "0x76DD", Offset = "0x76DD", VA = "0x76DD")]
		private void ValidateInit()
		{
		/* --- GHIDRA: ValidateInit ---
		void Gameplay_Medals_Controller_MedalsController__ValidateInit(int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  int iVar3;
		  
		  if (DAT_ram_00a57dcb == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoTakeOffMedalsEvt__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoNewMedalsEvt__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Medals_Controller_MedalsController_MainServiceOnNewMedalsEvent__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Medals_Controller_MedalsController_MainServiceOnTakeOffMedalsEvent__
		              );
		    DAT_ram_00a57dcb = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  iVar3 = *(int *)(iVar1 + 8);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  if (iVar3 == *(int *)(iVar1 + 0x10)) {
		    iVar1 = param1[6];
		    uVar2 = unnamed_function_1417(System_Action_ProtoNewMedalsEvt__TypeInfo);
		    UnityEngine_UIElements_VisualElement__get_layout
		              (uVar2,param1,
		               Method_Gameplay_Medals_Controller_MedalsController_MainServiceOnNewMedalsEvent__,0);
		    ServicesNamespace_MainService__add_NewMedalsEvent(iVar1,uVar2,0);
		    iVar1 = param1[6];
		    uVar2 = unnamed_function_1417(System_Action_ProtoTakeOffMedalsEvt__TypeInfo);
		    UnityEngine_UIElements_VisualElement__get_layout
		              (uVar2,param1,
		               Method_Gameplay_Medals_Controller_MedalsController_MainServiceOnTakeOffMedalsEvent__,
		               0);
		    ServicesNamespace_MainService__add_TakeOffMedalsEvent(iVar1,uVar2,0);
		  }
		  return;
		}
		*/

		}

		// Token: 0x0600259A RID: 9626 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600259A")]
		[Address(RVA = "0x76DE", Offset = "0x76DE", VA = "0x76DE", Slot = "6")]
		protected override void HandleStop()
		{
		/* --- GHIDRA: HandleStop ---
		void Gameplay_Medals_Controller_MedalsController__HandleStop
		               (int *param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  int iVar3;
		  int iVar4;
		  undefined4 param4;
		  undefined4 param1_00;
		  int *param1_01;
		  int *param1_02;
		  int iVar5;
		  undefined4 param3_00;
		  undefined8 uVar6;
		  int local_4;
		  
		  if (DAT_ram_00a57dce == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Medals_Model_BuyMedalVo_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_uint__MedalData__get_Item__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Errors_Expected_ExpectedErrorsHandler_HandleErrorChain_ExpectedBillingErrors__ExpectedBuyMedalErrors___
		              );
		    Mono_Security_ASN1__get_Item(&Core_Events_Scopes_MedalsScope_MedalEventArgs_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Main_MedalInfo_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__get_Result__);
		    Mono_Security_ASN1__get_Item(&Protocol_Services_ProtoBuyMedalAns_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Cysharp_Threading_Tasks_UniTaskCompletionSource_bool__TrySetResult__);
		    DAT_ram_00a57dce = '\x01';
		  }
		  param1_01 = *(int **)(param2 + 0xc);
		  if (param1_01 != (int *)0x0) {
		    if (((uint)*(byte *)(*param1_01 + 0xb8) <
		         (uint)*(byte *)(Gameplay_Medals_Model_BuyMedalVo_TypeInfo + 0xb8)) ||
		       (*(int *)(*(int *)(*param1_01 + 100) +
		                 (uint)*(byte *)(Gameplay_Medals_Model_BuyMedalVo_TypeInfo + 0xb8) * 4 + -4) !=
		        Gameplay_Medals_Model_BuyMedalVo_TypeInfo)) {
		      System_Activator__CreateInstance(param1_01,Gameplay_Medals_Model_BuyMedalVo_TypeInfo);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  param1_02 = *(int **)(param2 + 0x20);
		  if ((param1_02 != (int *)0x0) && (Protocol_Services_ProtoBuyMedalAns_TypeInfo != *param1_02)) {
		    System_Activator__CreateInstance(param1_02,Protocol_Services_ProtoBuyMedalAns_TypeInfo);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  iVar5 = param1_02[3];
		  local_4 = param1_01[2];
		  uVar1 = func_ii_1081(DAT_ram_00a66958,&local_4);
		  iVar5 = Core_Errors_Expected_ExpectedErrorsHandler__HandleErrorChain_object_
		                    (iVar5,0,uVar1,
		                     Method_Core_Errors_Expected_ExpectedErrorsHandler_HandleErrorChain_ExpectedBillingErrors__ExpectedBuyMedalErrors___
		                    );
		  if (iVar5 == 0) {
		    iVar5 = unnamed_function_1417(Protocol_Main_MedalInfo_TypeInfo);
		    *(ulonglong *)(iVar5 + 0x18) = (ulonglong)(uint)param1_02[6];
		    *(int *)(iVar5 + 0xc) = param1_01[2];
		    uVar6 = *(undefined8 *)(param1_02 + 4);
		    *(undefined8 *)(iVar5 + 0x10) = 0;
		    *(undefined8 *)(iVar5 + 0x20) = uVar6;
		    uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x104));
		    iVar2 = func_ii_7192(uVar1,iVar5,param1);
		    iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x114));
		    iVar3 = *(int *)(iVar3 + 0x14);
		    if (iVar3 != 0) {
		      iVar4 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x104));
		      uVar1 = System_Collections_Generic_List_object___get_Item
		                        (*(undefined4 *)(iVar4 + 0x20),param1_01[2],
		                         Method_System_Collections_Generic_Dictionary_uint__MedalData__get_Item__);
		      (**(code **)((ulonglong)*(uint *)(iVar3 + 0xc) * 4))
		                (*(undefined4 *)(iVar3 + 0x20),uVar1,param1_01[2],*(undefined4 *)(iVar3 + 0x14));
		    }
		    if (iVar2 != 0) {
		      Gameplay_Medals_Model_MedalsModel__AddMedal(param1,iVar5,param1);
		    }
		    Cysharp_Threading_Tasks_UniTaskCompletionSource_object___TrySetResult
		              (param1_01[3],1,
		               Method_Cysharp_Threading_Tasks_UniTaskCompletionSource_bool__TrySetResult__);
		    iVar2 = System_Uri___ctor(0);
		    iVar2 = *(int *)(*(int *)(*(int *)(*(int *)(iVar2 + 0x38) + 0x10) + 0x50) + 0xc);
		    if (iVar2 != 0) {
		      uVar1 = System_Uri___ctor(0);
		      if (DAT_ram_00a6456f == '\0') {
		        Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		        DAT_ram_00a6456f = '\x01';
		      }
		      param3_00 = **(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		      iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x104));
		      param4 = System_Collections_Generic_List_object___get_Item
		                         (*(undefined4 *)(iVar3 + 0x20),param1_01[2],
		                          Method_System_Collections_Generic_Dictionary_uint__MedalData__get_Item__);
		      iVar3 = param1_01[2];
		      param1_00 = unnamed_function_1417(Core_Events_Scopes_MedalsScope_MedalEventArgs_TypeInfo);
		      Core_Events_Scopes_UiScope_WindowClosedEventArgs__get_WindowCloseReason
		                (param1_00,uVar1,param3_00,param4,iVar3,0);
		      (**(code **)((ulonglong)*(uint *)(iVar2 + 0xc) * 4))
		                (*(undefined4 *)(iVar2 + 0x20),param1_00,*(undefined4 *)(iVar2 + 0x14));
		    }
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x114));
		    iVar2 = *(int *)(iVar2 + 0x20);
		    if (iVar2 != 0) {
		      (**(code **)((ulonglong)*(uint *)(iVar2 + 0xc) * 4))
		                (*(undefined4 *)(iVar2 + 0x20),iVar5,*(undefined4 *)(iVar2 + 0x14));
		    }
		  }
		  else {
		    Cysharp_Threading_Tasks_UniTaskCompletionSource_object___TrySetResult
		              (param1_01[3],0,
		               Method_Cysharp_Threading_Tasks_UniTaskCompletionSource_bool__TrySetResult__);
		  }
		  return;
		}
		*/

		}

		// Token: 0x0600259B RID: 9627 RVA: 0x00007290 File Offset: 0x00005490
		[Token(Token = "0x600259B")]
		[Address(RVA = "0x1C14", Offset = "0x1C14", VA = "0x1C14")]
		public UniTask<bool> BuyMedal(MedalData medalData)
		{
			return default(UniTask<bool>);
		}

		// Token: 0x0600259C RID: 9628 RVA: 0x000072A8 File Offset: 0x000054A8
		[Token(Token = "0x600259C")]
		[Address(RVA = "0x1E4D", Offset = "0x1E4D", VA = "0x1E4D")]
		public UniTask BuyMedal(uint medalId)
		{
			return default(UniTask);
		}

		// Token: 0x0600259D RID: 9629 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600259D")]
		[Address(RVA = "0x76DF", Offset = "0x76DF", VA = "0x76DF")]
		private void HandleBuyMedalService(OpToken<IMessage, object> op)
		{
		/* --- GHIDRA: HandleBuyMedalService ---
		void Gameplay_Medals_Controller_MedalsController__HandleBuyMedalService
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4,undefined4 param5)
		
		{
		  uint uVar1;
		  undefined1 uVar2;
		  undefined4 uVar3;
		  undefined4 uVar4;
		  uint *puVar5;
		  undefined4 *puVar6;
		  int iVar7;
		  int *piVar8;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a57dd0 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_MedalsModel__MedalsEvents__MedalsController__MedalsWindow___ctor__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_FilterInfo_FilterType__IMedalFilter__Add__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_FilterInfo_FilterType__IMedalFilter___ctor__
		              );
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_Dictionary_FilterInfo_FilterType__IMedalFilter__TypeInfo)
		    ;
		    Mono_Security_ASN1__get_Item(&Gameplay_Discounts_Model_IDiscountsProvider_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Medals_Controller_Filters_MedalAchievedFilter_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Medals_Controller_Filters_MedalOtherFilter_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Medals_Controller_Filters_MedalPriceFilter_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Medals_Controller_Filters_MedalSkillFilter_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Medals_Controller_Filters_MedalTitleFilter_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Medals_Controller_Filters_PaymentCategoryFilter_TypeInfo)
		    ;
		    Mono_Security_ASN1__get_Item(&System_Predicate_MedalData__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Medals_Controller_MedalsViewMediator___c___ctor_b__4_0__);
		    Mono_Security_ASN1__get_Item(&Gameplay_Medals_Controller_MedalsViewMediator___c_TypeInfo);
		    DAT_ram_00a57dd0 = '\x01';
		  }
		  local_8 = 0;
		  if (*(int *)(Gameplay_Medals_Controller_MedalsViewMediator___c_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Gameplay_Medals_Controller_MedalsViewMediator___c_TypeInfo);
		  }
		  puVar6 = *(undefined4 **)(Gameplay_Medals_Controller_MedalsViewMediator___c_TypeInfo + 0x5c);
		  iVar7 = puVar6[1];
		  if (iVar7 == 0) {
		    if (*(int *)(Gameplay_Medals_Controller_MedalsViewMediator___c_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Gameplay_Medals_Controller_MedalsViewMediator___c_TypeInfo);
		      puVar6 = *(undefined4 **)(Gameplay_Medals_Controller_MedalsViewMediator___c_TypeInfo + 0x5c);
		    }
		    uVar3 = *puVar6;
		    iVar7 = unnamed_function_1417(System_Predicate_MedalData__TypeInfo);
		    func_ii_7297(iVar7,uVar3,
		                 Method_Gameplay_Medals_Controller_MedalsViewMediator___c___ctor_b__4_0__,0);
		    *(int *)(*(int *)(Gameplay_Medals_Controller_MedalsViewMediator___c_TypeInfo + 0x5c) + 4) =
		         iVar7;
		  }
		  *(int *)(param1 + 0x24) = iVar7;
		  Gameplay_Combat_TeamCombat_View_AbstractTeamCombatView_object___get_HideInstantElements
		            (param1,param2,param3,param4,
		             Method_MVC_AbstractViewMediator_MedalsModel__MedalsEvents__MedalsController__MedalsWindow___ctor__
		            );
		  uVar3 = unnamed_function_1417
		                    (
		                    System_Collections_Generic_Dictionary_FilterInfo_FilterType__IMedalFilter__TypeInfo
		                    );
		  System_Collections_Generic_Dictionary_Int32Enum__Int32Enum___set_Item
		            (uVar3,
		             Method_System_Collections_Generic_Dictionary_FilterInfo_FilterType__IMedalFilter___ctor__
		            );
		  *(undefined4 *)(param1 + 0x18) = uVar3;
		  uVar4 = unnamed_function_1417(Gameplay_Medals_Controller_Filters_MedalSkillFilter_TypeInfo);
		  func_ii_10812(uVar3,1,uVar4,
		                Method_System_Collections_Generic_Dictionary_FilterInfo_FilterType__IMedalFilter__Add__
		               );
		  uVar4 = *(undefined4 *)(param1 + 0x18);
		  uVar3 = unnamed_function_1417(Gameplay_Medals_Controller_Filters_MedalPriceFilter_TypeInfo);
		  func_ii_10812(uVar4,3,uVar3,
		                Method_System_Collections_Generic_Dictionary_FilterInfo_FilterType__IMedalFilter__Add__
		               );
		  uVar4 = *(undefined4 *)(param1 + 0x18);
		  uVar3 = unnamed_function_1417(Gameplay_Medals_Controller_Filters_MedalTitleFilter_TypeInfo);
		  func_ii_10812(uVar4,4,uVar3,
		                Method_System_Collections_Generic_Dictionary_FilterInfo_FilterType__IMedalFilter__Add__
		               );
		  uVar4 = *(undefined4 *)(param1 + 0x18);
		  uVar3 = unnamed_function_1417(Gameplay_Medals_Controller_Filters_MedalOtherFilter_TypeInfo);
		  func_ii_10812(uVar4,2,uVar3,
		                Method_System_Collections_Generic_Dictionary_FilterInfo_FilterType__IMedalFilter__Add__
		               );
		  uVar4 = *(undefined4 *)(param1 + 0x18);
		  uVar3 = unnamed_function_1417(Gameplay_Medals_Controller_Filters_MedalAchievedFilter_TypeInfo);
		  func_ii_10812(uVar4,5,uVar3,
		                Method_System_Collections_Generic_Dictionary_FilterInfo_FilterType__IMedalFilter__Add__
		               );
		  iVar7 = unnamed_function_1417(Gameplay_Medals_Controller_Filters_PaymentCategoryFilter_TypeInfo);
		  if (DAT_ram_00a57de0 == '\0') {
		    Mono_Security_ASN1__get_Item(&UI_Filters_FilterInfo_TypeInfo);
		    DAT_ram_00a57de0 = '\x01';
		  }
		  uVar3 = unnamed_function_1417(UI_Filters_FilterInfo_TypeInfo);
		  *(undefined4 *)(iVar7 + 0x10) = uVar3;
		  *(int *)(param1 + 0x20) = iVar7;
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  uVar1 = 0;
		  piVar8 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar7 = *piVar8;
		  if (*(ushort *)(iVar7 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8)) {
		        puVar5 = (uint *)(*(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8 + 4) * 8 + iVar7 + 0x248);
		        goto code_r0x80e5a64a;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		  }
		  puVar5 = (uint *)func_ii_1080(piVar8,Core_Gameplay_IGame_TypeInfo,0x31);
		code_r0x80e5a64a:
		  iVar7 = (**(code **)((ulonglong)*puVar5 * 4))(piVar8,puVar5[1]);
		  uVar1 = 0;
		  piVar8 = *(int **)(iVar7 + 0x20);
		  iVar7 = *piVar8;
		  if (*(ushort *)(iVar7 + 0xb6) != 0) {
		    do {
		      if (Gameplay_Discounts_Model_IDiscountsProvider_TypeInfo ==
		          *(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8)) {
		        puVar5 = (uint *)(*(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8 + 4) * 8 + iVar7 + 200);
		        goto code_r0x80e5a6cf;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		  }
		  puVar5 = (uint *)func_ii_1080(piVar8,Gameplay_Discounts_Model_IDiscountsProvider_TypeInfo,1);
		code_r0x80e5a6cf:
		  uVar2 = (**(code **)((ulonglong)*puVar5 * 4))(piVar8,1,&local_8,puVar5[1]);
		  *(undefined1 *)(param1 + 0x1c) = uVar2;
		  return;
		}
		*/

		}

		// Token: 0x0600259E RID: 9630 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600259E")]
		[Address(RVA = "0x1C1A", Offset = "0x1C1A", VA = "0x1C1A")]
		private void HandleMedalAdded(MedalInfo medalInfo)
		{
		}

		// Token: 0x04001491 RID: 5265
		[Token(Token = "0x4001491")]
		[FieldOffset(Offset = "0x18")]
		private MainService _mainService;

		// Token: 0x04001492 RID: 5266
		[Token(Token = "0x4001492")]
		[FieldOffset(Offset = "0x1C")]
		private ServicesService _servicesService;
	}
}
