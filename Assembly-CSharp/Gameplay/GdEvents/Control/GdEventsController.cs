using System;
using System.Collections.Generic;
using Gameplay.GdEvents.Model;
using Gameplay.GdEvents.Model.Categories;
using Gameplay.GdEvents.Model.Milestone;
using Google.Protobuf;
using Il2CppDummyDll;
using MVC;
using Protocol.Common;
using Utils;
using Utils.Accumulators;

namespace Gameplay.GdEvents.Control
{
	// Token: 0x02000765 RID: 1893
	[Token(Token = "0x2000765")]
	public class GdEventsController : AbstractController<GdEventsModel, GdEventsEvents>
	{
		// Token: 0x06002D11 RID: 11537 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002D11")]
		[Address(RVA = "0x7D8F", Offset = "0x7D8F", VA = "0x7D8F")]
		public GdEventsController(GdEventsModel model, GdEventsEvents events)
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_GdEvents_Control_GdEventsController___ctor(int *param1,undefined4 param2)
		
		{
		  uint uVar1;
		  int iVar2;
		  undefined4 uVar3;
		  undefined4 param1_00;
		  uint *puVar4;
		  int *param1_01;
		  
		  if (DAT_ram_00a5a302 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Utils_Accumulators_AccumulatorBase_int__TriggerValue__remove_UpdateEvent__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Utils_Accumulators_AccumulatorBase_AccumulatorUpdateDelegate_int__TriggerValue__TypeInfo
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_GdEvents_Control_GdEventsController_HandleDictProviderChangeEvent__)
		    ;
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_GdEvents_Control_GdEventsController_HandleTriggersUpdateEvent__);
		    Mono_Security_ASN1__get_Item(&Core_Dict_IDictProvider_TypeInfo);
		    DAT_ram_00a5a302 = '\x01';
		  }
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  uVar3 = Core_Gameplay_Managers_UserManager__get_User(*(undefined4 *)(iVar2 + 8),0);
		  param1_00 = unnamed_function_1417
		                        (
		                        Utils_Accumulators_AccumulatorBase_AccumulatorUpdateDelegate_int__TriggerValue__TypeInfo
		                        );
		  Utils_Accumulators_AccumulatorBase___Il2CppFullySharedGenericType____Il2CppFullySharedGenericType___remove_UpdateEvent
		            (param1_00,param1,
		             Method_Gameplay_GdEvents_Control_GdEventsController_HandleTriggersUpdateEvent__,0);
		  UnityEngine_Events_InvokableCall_InputAction_CallbackContext___add_Delegate
		            (uVar3,param1_00,
		             Method_Utils_Accumulators_AccumulatorBase_int__TriggerValue__remove_UpdateEvent__);
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  param1_01 = *(int **)(iVar2 + 0x18);
		  uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar3,param1,
		             Method_Gameplay_GdEvents_Control_GdEventsController_HandleDictProviderChangeEvent__,0);
		  iVar2 = *param1_01;
		  if (*(ushort *)(iVar2 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Dict_IDictProvider_TypeInfo == *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8)) {
		        puVar4 = (uint *)(*(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8 + 4) * 8 + iVar2 + 200);
		        goto code_r0x811fb7ae;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		  }
		  puVar4 = (uint *)func_ii_1080(param1_01,Core_Dict_IDictProvider_TypeInfo,1);
		code_r0x811fb7ae:
		  (**(code **)((ulonglong)*puVar4 * 4))(param1_01,uVar3,puVar4[1]);
		  return;
		}
		*/

		}

		// Token: 0x06002D12 RID: 11538 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002D12")]
		[Address(RVA = "0x7D90", Offset = "0x7D90", VA = "0x7D90", Slot = "6")]
		protected override void HandleStop()
		{
		/* --- GHIDRA: HandleStop ---
		void Gameplay_GdEvents_Control_GdEventsController__HandleStop(int *param1,undefined4 param2)
		
		{
		  uint uVar1;
		  int iVar2;
		  uint *puVar3;
		  undefined4 uVar4;
		  undefined4 param1_00;
		  int iVar5;
		  int *piVar6;
		  int iVar7;
		  int *piVar8;
		  int local_20;
		  undefined8 *puStack_1c;
		  undefined8 local_18;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  iVar5 = 0;
		  if (DAT_ram_00a5a303 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Utils_Accumulators_AccumulatorBase_int__TriggerValue__add_UpdateEvent__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Utils_Accumulators_AccumulatorBase_AccumulatorUpdateDelegate_int__TriggerValue__TypeInfo
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_AbstractGdEventCatData__Dispose__)
		    ;
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_AbstractGdEventCatData__MoveNext__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_Enumerator_AbstractGdEventCatData__get_Current__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_GdEvents_Control_GdEventsController_HandleDictProviderChangeEvent__)
		    ;
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_GdEvents_Control_GdEventsController_HandleTriggersUpdateEvent__);
		    Mono_Security_ASN1__get_Item(&Core_Dict_IDictProvider_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_AbstractGdEventCatData__GetEnumerator__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_GameEventDic__get_Count__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_GameEventDic__get_Item__);
		    DAT_ram_00a5a303 = '\x01';
		  }
		  local_8 = 0;
		  local_10 = 0;
		  do {
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x104));
		    piVar6 = *(int **)(iVar2 + 0x18);
		    iVar2 = *piVar6;
		    if (*(ushort *)(iVar2 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        piVar8 = (int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8);
		        if (Core_Dict_IDictProvider_TypeInfo == *piVar8) {
		          puVar3 = (uint *)(piVar8[1] * 8 + iVar2 + 0xd0);
		          goto code_r0x811fb8e9;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		    }
		    puVar3 = (uint *)func_ii_1080(piVar6,Core_Dict_IDictProvider_TypeInfo,2);
		code_r0x811fb8e9:
		    iVar2 = (**(code **)((ulonglong)*puVar3 * 4))(piVar6,puVar3[1]);
		    iVar7 = *(int *)(*(int *)(iVar2 + 0x2d4) + 0xc);
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x104));
		    if (iVar7 <= iVar5) {
		      uVar1 = 0;
		      uVar4 = Core_Gameplay_Managers_UserManager__get_User(*(undefined4 *)(iVar2 + 8),0);
		      param1_00 = unnamed_function_1417
		                            (
		                            Utils_Accumulators_AccumulatorBase_AccumulatorUpdateDelegate_int__TriggerValue__TypeInfo
		                            );
		      Utils_Accumulators_AccumulatorBase___Il2CppFullySharedGenericType____Il2CppFullySharedGenericType___remove_UpdateEvent
		                (param1_00,param1,
		                 Method_Gameplay_GdEvents_Control_GdEventsController_HandleTriggersUpdateEvent__,0);
		      UnityEngine_Events_InvokableCall_InputAction_CallbackContext___Invoke
		                (uVar4,param1_00,
		                 Method_Utils_Accumulators_AccumulatorBase_int__TriggerValue__add_UpdateEvent__);
		      iVar5 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x104));
		      piVar6 = *(int **)(iVar5 + 0x18);
		      uVar4 = unnamed_function_1417(System_Action_TypeInfo);
		      UnityEngine_Events_UnityEvent__AddListener
		                (uVar4,param1,
		                 Method_Gameplay_GdEvents_Control_GdEventsController_HandleDictProviderChangeEvent__
		                 ,0);
		      iVar5 = *piVar6;
		      if (*(ushort *)(iVar5 + 0xb6) == 0) goto code_r0x811fbd66;
		      break;
		    }
		    iVar7 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x104));
		    piVar6 = *(int **)(iVar7 + 0x18);
		    iVar7 = *piVar6;
		    if (*(ushort *)(iVar7 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        piVar8 = (int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8);
		        if (Core_Dict_IDictProvider_TypeInfo == *piVar8) {
		          puVar3 = (uint *)(piVar8[1] * 8 + iVar7 + 0xd0);
		          goto code_r0x811fb9a8;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		    }
		    puVar3 = (uint *)func_ii_1080(piVar6,Core_Dict_IDictProvider_TypeInfo,2);
		code_r0x811fb9a8:
		    iVar7 = (**(code **)((ulonglong)*puVar3 * 4))(piVar6,puVar3[1]);
		    uVar4 = Google_Protobuf_Collections_RepeatedField_Int32Enum___get_IsReadOnly
		                      (*(undefined4 *)(iVar7 + 0x2d4),iVar5,
		                       Method_Google_Protobuf_Collections_RepeatedField_GameEventDic__get_Item__);
		    iVar2 = Gameplay_GdEvents_Model_GdEventsModel___ctor(iVar2,uVar4,puVar3);
		    iVar7 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x104));
		    System_Collections_Generic_List_RegexCharClass_SingleRange___ForEach
		              (&local_20,*(undefined4 *)(iVar7 + 0x10),
		               Method_System_Collections_Generic_List_AbstractGdEventCatData__GetEnumerator__);
		    local_8 = local_18;
		    local_10 = CONCAT44(puStack_1c,local_20);
		    local_20 = 0;
		    puStack_1c = &local_10;
		    while( true ) {
		      DAT_ram_009d3e38 = 0;
		      iVar7 = import::env::invoke_iii
		                        (s_struct_Uniforms___color__array<v_ram_00000aff + 0x44,&local_10,
		                         Method_System_Collections_Generic_List_Enumerator_AbstractGdEventCatData__MoveNext__
		                        );
		      if (DAT_ram_009d3e38 == 1) break;
		      if (iVar7 == 0) goto code_r0x811fbc4e;
		      piVar6 = local_8._4_4_;
		      DAT_ram_009d3e38 = 0;
		      iVar7 = import::env::invoke_iiii
		                        (*(undefined4 *)(*local_8._4_4_ + 0x110),local_8._4_4_,iVar2,
		                         *(undefined4 *)(*local_8._4_4_ + 0x114));
		      if (DAT_ram_009d3e38 == 1) break;
		      if (iVar7 != 0) {
		        iVar7 = *piVar6;
		        DAT_ram_009d3e38 = 0;
		        iVar7 = import::env::invoke_iiii
		                          (*(undefined4 *)(iVar7 + 0xe8),piVar6,iVar2,*(undefined4 *)(iVar7 + 0xec))
		        ;
		        if (DAT_ram_009d3e38 == 1) break;
		        if (iVar7 != 0) {
		          DAT_ram_009d3e38 = 0;
		          iVar7 = import::env::invoke_iii
		                            (*(undefined4 *)(*param1 + 0x100),param1,
		                             *(undefined4 *)(*param1 + 0x104));
		          if (DAT_ram_009d3e38 == 1) break;
		          iVar7 = *(int *)(iVar7 + 0x30);
		          uVar4 = *(undefined4 *)(*(int *)(iVar2 + 0x10) + 0xc);
		          if (DAT_ram_00a5a2d0 == '\0') {
		            DAT_ram_009d3e38 = 0;
		            import::env::invoke_vi(0x7ff,&Method_System_Collections_Generic_List_uint__Contains__);
		            if (DAT_ram_009d3e38 == 1) break;
		            DAT_ram_00a5a2d0 = '\x01';
		          }
		          DAT_ram_009d3e38 = 0;
		          uVar4 = import::env::invoke_iiii
		                            (s_struct_Uniforms___color__array<v_ram_00001f04 + 0xa4,
		                             *(undefined4 *)(*(int *)(iVar7 + 0xc) + 8),uVar4,
		                             Method_System_Collections_Generic_List_uint__Contains__);
		          if (DAT_ram_009d3e38 == 1) break;
		          *(char *)(iVar2 + 0x18) = (char)uVar4;
		        }
		      }
		    }
		    DAT_ram_009d3e38 = 0;
		    uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		    iVar2 = global_1;
		    iVar7 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		    if (iVar2 != iVar7) {
		code_r0x811fbcf8:
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001f04 + 0x28e,&local_20);
		      iVar5 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar5 != 1) {
		        import::env::__resumeException(uVar4);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      import::env::__cxa_find_matching_catch_3(0);
		      unnamed_function_937();
		      do {
		        halt_trap();
		      } while( true );
		    }
		    piVar6 = (int *)import::env::__cxa_begin_catch(uVar4);
		    iVar7 = *piVar6;
		    DAT_ram_009d3e38 = 0;
		    local_20 = iVar7;
		    import::env::invoke_v(0x123);
		    iVar2 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar2 == 1) {
		      uVar4 = import::env::__cxa_find_matching_catch_2();
		      goto code_r0x811fbcf8;
		    }
		    if (iVar7 != 0) {
		      System_Data_DataSet__ValidateLocaleConstraint(iVar7);
		      do {
		        halt_trap();
		      } while( true );
		    }
		code_r0x811fbc4e:
		    DAT_ram_009d3e38 = 0;
		    iVar5 = iVar5 + 1;
		  } while( true );
		  while (uVar1 = uVar1 + 1, *(ushort *)(iVar5 + 0xb6) != uVar1) {
		    if (Core_Dict_IDictProvider_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		      puVar3 = (uint *)(iVar5 + *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		      goto code_r0x811fbd70;
		    }
		  }
		code_r0x811fbd66:
		  puVar3 = (uint *)func_ii_1080(piVar6,Core_Dict_IDictProvider_TypeInfo,0);
		code_r0x811fbd70:
		  (**(code **)((ulonglong)*puVar3 * 4))(piVar6,uVar4,puVar3[1]);
		  iVar5 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x114));
		  iVar5 = *(int *)(iVar5 + 8);
		  if (iVar5 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar5 + 0xc) * 4))
		              (*(undefined4 *)(iVar5 + 0x20),*(undefined4 *)(iVar5 + 0x14));
		  }
		  return;
		}
		*/

		}

		// Token: 0x06002D13 RID: 11539 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002D13")]
		[Address(RVA = "0x7D91", Offset = "0x7D91", VA = "0x7D91", Slot = "7")]
		protected override void HandleRun()
		{
		/* --- GHIDRA: HandleRun ---
		/* WARNING: Removing unreachable block (ram,0x811fc0c5) */
		
		void Gameplay_GdEvents_Control_GdEventsController__HandleRun
		               (int *param1,int *param2,undefined4 param3,undefined4 param4)
		
		{
		  undefined4 uVar1;
		  uint *puVar2;
		  undefined4 *puVar3;
		  undefined4 uVar4;
		  int iVar5;
		  int *piVar6;
		  int iVar7;
		  int iVar8;
		  undefined4 uVar9;
		  int *piVar10;
		  uint uVar11;
		  int iVar12;
		  int local_28;
		  int **local_24;
		  undefined8 local_20;
		  undefined8 local_18;
		  undefined8 local_10;
		  int *local_4;
		  
		  if (DAT_ram_00a5a304 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Events_Scopes_GdEventsScope_CompletionsArgs_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_Where_TriggerDic___);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_TriggerDic__Dispose__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_TriggerDic__MoveNext__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_TriggerDic__get_Current__);
		    Mono_Security_ASN1__get_Item(&System_Func_TriggerDic__bool__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Application_IApp_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_IDisposable_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_IEnumerable_TriggerValue__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_IEnumerator_TriggerValue__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_IEnumerator_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_TriggerDic__AddRange__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_TriggerDic__GetEnumerator__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_TriggerDic___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_List_TriggerDic__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_GdEvents_Control_GdEventsController___c__DisplayClass3_0__HandleTriggersUpdateEvent_b__0__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_GdEvents_Control_GdEventsController___c__DisplayClass3_0_TypeInfo);
		    DAT_ram_00a5a304 = '\x01';
		  }
		  local_4 = (int *)0x0;
		  local_10 = 0;
		  local_18 = 0;
		  uVar1 = unnamed_function_1417(System_Collections_Generic_List_TriggerDic__TypeInfo);
		  GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		            (uVar1,Method_System_Collections_Generic_List_TriggerDic___ctor__);
		  iVar12 = *param2;
		  if (*(ushort *)(iVar12 + 0xb6) != 0) {
		    uVar11 = 0;
		    do {
		      if (System_Collections_Generic_IEnumerable_TriggerValue__TypeInfo ==
		          *(int *)(*(int *)(iVar12 + 0x58) + uVar11 * 8)) {
		        puVar2 = (uint *)(iVar12 + *(int *)(*(int *)(iVar12 + 0x58) + uVar11 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x811fbf45;
		      }
		      uVar11 = uVar11 + 1;
		    } while (*(ushort *)(iVar12 + 0xb6) != uVar11);
		  }
		  puVar2 = (uint *)func_ii_1080(param2,System_Collections_Generic_IEnumerable_TriggerValue__TypeInfo
		                                ,0);
		code_r0x811fbf45:
		  local_4 = (int *)(**(code **)((ulonglong)*puVar2 * 4))(param2,puVar2[1]);
		  local_28 = 0;
		  local_24 = &local_4;
		  do {
		    do {
		      piVar6 = local_4;
		      iVar12 = *local_4;
		      if (*(ushort *)(iVar12 + 0xb6) != 0) {
		        uVar11 = 0;
		        do {
		          piVar10 = (int *)(*(int *)(iVar12 + 0x58) + uVar11 * 8);
		          if (System_Collections_IEnumerator_TypeInfo == *piVar10) {
		            puVar3 = (undefined4 *)(iVar12 + piVar10[1] * 8 + 0xc0);
		            goto code_r0x811fc016;
		          }
		          uVar11 = uVar11 + 1;
		        } while (*(ushort *)(iVar12 + 0xb6) != uVar11);
		      }
		      DAT_ram_009d3e38 = 0;
		      puVar3 = (undefined4 *)
		               import::env::invoke_iiii
		                         (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                          System_Collections_IEnumerator_TypeInfo,0);
		      if (DAT_ram_009d3e38 == 1) {
		code_r0x811fc05e:
		        DAT_ram_009d3e38 = 0;
		        uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x811fc314;
		      }
		code_r0x811fc016:
		      DAT_ram_009d3e38 = 0;
		      iVar12 = import::env::invoke_iii(*puVar3,piVar6,puVar3[1]);
		      if (DAT_ram_009d3e38 == 1) goto code_r0x811fc05e;
		      if (iVar12 == 0) {
		        iVar12 = 0;
		        goto code_r0x811fc35d;
		      }
		      DAT_ram_009d3e38 = 0;
		      iVar12 = import::env::invoke_ii
		                         (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x199,
		                          Gameplay_GdEvents_Control_GdEventsController___c__DisplayClass3_0_TypeInfo
		                         );
		      piVar6 = local_4;
		      if (DAT_ram_009d3e38 == 1) {
		        DAT_ram_009d3e38 = 0;
		        uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x811fc314;
		      }
		      iVar5 = *local_4;
		      if (*(ushort *)(iVar5 + 0xb6) != 0) {
		        uVar11 = 0;
		        do {
		          piVar10 = (int *)(*(int *)(iVar5 + 0x58) + uVar11 * 8);
		          if (System_Collections_Generic_IEnumerator_TriggerValue__TypeInfo == *piVar10) {
		            puVar3 = (undefined4 *)(iVar5 + piVar10[1] * 8 + 0xc0);
		            goto code_r0x811fc160;
		          }
		          uVar11 = uVar11 + 1;
		        } while (*(ushort *)(iVar5 + 0xb6) != uVar11);
		      }
		      DAT_ram_009d3e38 = 0;
		      puVar3 = (undefined4 *)
		               import::env::invoke_iiii
		                         (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                          System_Collections_Generic_IEnumerator_TriggerValue__TypeInfo,0);
		      if (DAT_ram_009d3e38 == 1) {
		code_r0x811fc1bb:
		        DAT_ram_009d3e38 = 0;
		        uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x811fc314;
		      }
		code_r0x811fc160:
		      DAT_ram_009d3e38 = 0;
		      iVar5 = import::env::invoke_iii(*puVar3,piVar6,puVar3[1]);
		      if (DAT_ram_009d3e38 == 1) goto code_r0x811fc1bb;
		      *(int *)(iVar12 + 8) = iVar5;
		    } while (*(longlong *)(iVar5 + 0x10) != 1);
		    DAT_ram_009d3e38 = 0;
		    iVar7 = import::env::invoke_iii
		                      (*(undefined4 *)(*param1 + 0x100),param1,*(undefined4 *)(*param1 + 0x104));
		    iVar5 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar5 == 1) {
		      uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x811fc314;
		    }
		    uVar9 = *(undefined4 *)(iVar7 + 0x14);
		    DAT_ram_009d3e38 = 0;
		    uVar4 = import::env::invoke_ii
		                      (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x199,
		                       System_Func_TriggerDic__bool__TypeInfo);
		    if (DAT_ram_009d3e38 == 1) {
		code_r0x811fc302:
		      DAT_ram_009d3e38 = 0;
		      uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x811fc314;
		    }
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_viiii
		              (s_struct_Uniforms___color__array<v_ram_00000aff + 0x21b,uVar4,iVar12,
		               Method_Gameplay_GdEvents_Control_GdEventsController___c__DisplayClass3_0__HandleTriggersUpdateEvent_b__0__
		               ,0);
		    if (DAT_ram_009d3e38 == 1) goto code_r0x811fc302;
		    DAT_ram_009d3e38 = 0;
		    uVar4 = import::env::invoke_iiii
		                      (s_struct_Uniforms___color__array<v_ram_00000aff + 0x226,uVar9,uVar4,
		                       Method_System_Linq_Enumerable_Where_TriggerDic___);
		    iVar12 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar12 == 1) {
		      uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x811fc314;
		    }
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_viii
		              (s_struct_Uniforms___color__array<v_ram_000017c8 + 0xf8,uVar1,uVar4,
		               Method_System_Collections_Generic_List_TriggerDic__AddRange__);
		    iVar12 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		  } while (iVar12 != 1);
		  uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x811fc314:
		  iVar12 = global_1;
		  iVar5 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar12 == iVar5) {
		    piVar6 = (int *)import::env::__cxa_begin_catch(uVar4);
		    iVar12 = *piVar6;
		    DAT_ram_009d3e38 = 0;
		    local_28 = iVar12;
		    import::env::invoke_v(0x123);
		    iVar5 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar5 != 1) {
		code_r0x811fc35d:
		      piVar6 = local_4;
		      DAT_ram_009d3e38 = 0;
		      if (local_4 != (int *)0x0) {
		        uVar11 = 0;
		        iVar5 = *local_4;
		        if (*(ushort *)(iVar5 + 0xb6) != 0) {
		          do {
		            if (System_IDisposable_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar11 * 8)) {
		              puVar2 = (uint *)(iVar5 + *(int *)(*(int *)(iVar5 + 0x58) + uVar11 * 8 + 4) * 8 + 0xc0
		                               );
		              goto code_r0x811fc3d5;
		            }
		            uVar11 = uVar11 + 1;
		          } while (*(ushort *)(iVar5 + 0xb6) != uVar11);
		        }
		        puVar2 = (uint *)func_ii_1080(local_4,System_IDisposable_TypeInfo,0);
		code_r0x811fc3d5:
		        (**(code **)((ulonglong)*puVar2 * 4))(piVar6,puVar2[1]);
		      }
		      if (iVar12 != 0) {
		        System_Data_DataSet__ValidateLocaleConstraint(iVar12);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      System_Collections_Generic_List_RegexCharClass_SingleRange___ForEach
		                (&local_28,uVar1,Method_System_Collections_Generic_List_TriggerDic__GetEnumerator__)
		      ;
		      local_10 = local_20;
		      local_18 = CONCAT44(local_24,local_28);
		      local_28 = 0;
		      local_24 = (int **)&local_18;
		      do {
		        do {
		          do {
		            DAT_ram_009d3e38 = 0;
		            iVar5 = import::env::invoke_iii
		                              (s_struct_Uniforms___color__array<v_ram_00000aff + 0x44,&local_18,
		                               Method_System_Collections_Generic_List_Enumerator_TriggerDic__MoveNext__
		                              );
		            iVar12 = DAT_ram_009d3e38;
		            DAT_ram_009d3e38 = 0;
		            if (iVar12 == 1) {
		              uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		              goto code_r0x811fcdbd;
		            }
		            if (iVar5 == 0) {
		              DAT_ram_009d3e38 = 0;
		              return;
		            }
		            iVar12 = local_10._4_4_;
		            iVar5 = *(int *)(local_10._4_4_ + 0x10);
		            if (iVar5 == 0x98) {
		              DAT_ram_009d3e38 = 0;
		              iVar7 = import::env::invoke_iii
		                                (*(undefined4 *)(*param1 + 0x100),param1,
		                                 *(undefined4 *)(*param1 + 0x104));
		              iVar5 = DAT_ram_009d3e38;
		              DAT_ram_009d3e38 = 0;
		              if (iVar5 == 1) {
		                uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		              }
		              else {
		                piVar6 = *(int **)(iVar7 + 0x3c);
		                iVar5 = *piVar6;
		                if (*(ushort *)(iVar5 + 0xb6) != 0) {
		                  uVar11 = 0;
		                  do {
		                    piVar10 = (int *)(*(int *)(iVar5 + 0x58) + uVar11 * 8);
		                    if (Core_Gameplay_IGame_TypeInfo == *piVar10) {
		                      puVar3 = (undefined4 *)(piVar10[1] * 8 + iVar5 + 0xe0);
		                      goto code_r0x811fc5c4;
		                    }
		                    uVar11 = uVar11 + 1;
		                  } while (*(ushort *)(iVar5 + 0xb6) != uVar11);
		                }
		                DAT_ram_009d3e38 = 0;
		                puVar3 = (undefined4 *)
		                         import::env::invoke_iiii
		                                   (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,piVar6,
		                                    Core_Gameplay_IGame_TypeInfo,4);
		                if (DAT_ram_009d3e38 != 1) {
		code_r0x811fc5c4:
		                  DAT_ram_009d3e38 = 0;
		                  piVar6 = (int *)import::env::invoke_iii(*puVar3,piVar6,puVar3[1]);
		                  if (DAT_ram_009d3e38 != 1) {
		                    iVar5 = *piVar6;
		                    if (*(ushort *)(iVar5 + 0xb6) != 0) {
		                      uVar11 = 0;
		                      do {
		                        piVar10 = (int *)(*(int *)(iVar5 + 0x58) + uVar11 * 8);
		                        if (Core_Application_IApp_TypeInfo == *piVar10) {
		                          puVar3 = (undefined4 *)(piVar10[1] * 8 + iVar5 + 0x100);
		                          goto code_r0x811fc695;
		                        }
		                        uVar11 = uVar11 + 1;
		                      } while (*(ushort *)(iVar5 + 0xb6) != uVar11);
		                    }
		                    DAT_ram_009d3e38 = 0;
		                    puVar3 = (undefined4 *)
		                             import::env::invoke_iiii
		                                       (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,
		                                        piVar6,Core_Application_IApp_TypeInfo,8);
		                    if (DAT_ram_009d3e38 != 1) {
		code_r0x811fc695:
		                      DAT_ram_009d3e38 = 0;
		                      iVar5 = import::env::invoke_iii(*puVar3,piVar6,puVar3[1]);
		                      if (DAT_ram_009d3e38 != 1) {
		                        iVar5 = *(int *)(*(int *)(*(int *)(iVar5 + 0x10) + 0x94) + 0x14);
		                        if (iVar5 == 0) {
		code_r0x811fc91c:
		                          iVar5 = *(int *)(iVar12 + 0x10);
		                          goto code_r0x811fc925;
		                        }
		                        DAT_ram_009d3e38 = 0;
		                        iVar8 = import::env::invoke_iii
		                                          (*(undefined4 *)(*param1 + 0x100),param1,
		                                           *(undefined4 *)(*param1 + 0x104));
		                        iVar7 = DAT_ram_009d3e38;
		                        DAT_ram_009d3e38 = 0;
		                        if (iVar7 == 1) {
		                          uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		                        }
		                        else {
		                          piVar6 = *(int **)(iVar8 + 0x3c);
		                          iVar7 = *piVar6;
		                          if (*(ushort *)(iVar7 + 0xb6) != 0) {
		                            uVar11 = 0;
		                            do {
		                              piVar10 = (int *)(*(int *)(iVar7 + 0x58) + uVar11 * 8);
		                              if (Core_Gameplay_IGame_TypeInfo == *piVar10) {
		                                puVar3 = (undefined4 *)(piVar10[1] * 8 + iVar7 + 0xe0);
		                                goto code_r0x811fc7e6;
		                              }
		                              uVar11 = uVar11 + 1;
		                            } while (*(ushort *)(iVar7 + 0xb6) != uVar11);
		                          }
		                          DAT_ram_009d3e38 = 0;
		                          puVar3 = (undefined4 *)
		                                   import::env::invoke_iiii
		                                             (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18
		                                              ,piVar6,Core_Gameplay_IGame_TypeInfo,4);
		                          if (DAT_ram_009d3e38 != 1) {
		code_r0x811fc7e6:
		                            DAT_ram_009d3e38 = 0;
		                            uVar1 = import::env::invoke_iii(*puVar3,piVar6,puVar3[1]);
		                            if (DAT_ram_009d3e38 != 1) {
		                              DAT_ram_009d3e38 = 0;
		                              iVar8 = import::env::invoke_iii
		                                                (*(undefined4 *)(*param1 + 0x100),param1,
		                                                 *(undefined4 *)(*param1 + 0x104));
		                              iVar7 = DAT_ram_009d3e38;
		                              DAT_ram_009d3e38 = 0;
		                              if (iVar7 == 1) {
		                                uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		                              }
		                              else {
		                                uVar9 = *(undefined4 *)(iVar8 + 0x3c);
		                                DAT_ram_009d3e38 = 0;
		                                uVar4 = import::env::invoke_ii
		                                                  (s_var<private>_posTex__array<vec4<_ram_00000655 +
		                                                   0x199,
		                                                  Core_Events_Scopes_GdEventsScope_CompletionsArgs_TypeInfo
		                                                  );
		                                if (DAT_ram_009d3e38 != 1) {
		                                  DAT_ram_009d3e38 = 0;
		                                  import::env::invoke_viiiii
		                                            (s_struct_Uniforms___color__array<v_ram_00001f04 + 0x290
		                                             ,uVar4,iVar12,uVar1,uVar9,0);
		                                  if (DAT_ram_009d3e38 != 1) {
		                                    DAT_ram_009d3e38 = 0;
		                                    import::env::invoke_viii
		                                              (*(undefined4 *)(iVar5 + 0xc),
		                                               *(undefined4 *)(iVar5 + 0x20),uVar4,
		                                               *(undefined4 *)(iVar5 + 0x14));
		                                    if (DAT_ram_009d3e38 != 1) goto code_r0x811fc91c;
		                                  }
		                                }
		                                DAT_ram_009d3e38 = 0;
		                                uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		                              }
		                              goto code_r0x811fcdbd;
		                            }
		                          }
		                          DAT_ram_009d3e38 = 0;
		                          uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		                        }
		                        goto code_r0x811fcdbd;
		                      }
		                    }
		                    DAT_ram_009d3e38 = 0;
		                    uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		                    goto code_r0x811fcdbd;
		                  }
		                }
		                DAT_ram_009d3e38 = 0;
		                uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		              }
		              goto code_r0x811fcdbd;
		            }
		code_r0x811fc925:
		          } while (iVar5 != 0x99);
		          DAT_ram_009d3e38 = 0;
		          iVar7 = import::env::invoke_iii
		                            (*(undefined4 *)(*param1 + 0x100),param1,
		                             *(undefined4 *)(*param1 + 0x104));
		          iVar5 = DAT_ram_009d3e38;
		          DAT_ram_009d3e38 = 0;
		          if (iVar5 == 1) {
		            uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		            goto code_r0x811fcdbd;
		          }
		          piVar6 = *(int **)(iVar7 + 0x3c);
		          iVar5 = *piVar6;
		          if (*(ushort *)(iVar5 + 0xb6) != 0) {
		            uVar11 = 0;
		            do {
		              piVar10 = (int *)(*(int *)(iVar5 + 0x58) + uVar11 * 8);
		              if (Core_Gameplay_IGame_TypeInfo == *piVar10) {
		                puVar3 = (undefined4 *)(piVar10[1] * 8 + iVar5 + 0xe0);
		                goto code_r0x811fca2f;
		              }
		              uVar11 = uVar11 + 1;
		            } while (*(ushort *)(iVar5 + 0xb6) != uVar11);
		          }
		          DAT_ram_009d3e38 = 0;
		          puVar3 = (undefined4 *)
		                   import::env::invoke_iiii
		                             (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,piVar6,
		                              Core_Gameplay_IGame_TypeInfo,4);
		          if (DAT_ram_009d3e38 == 1) {
		code_r0x811fcbc9:
		            DAT_ram_009d3e38 = 0;
		            uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		            goto code_r0x811fcdbd;
		          }
		code_r0x811fca2f:
		          DAT_ram_009d3e38 = 0;
		          piVar6 = (int *)import::env::invoke_iii(*puVar3,piVar6,puVar3[1]);
		          if (DAT_ram_009d3e38 == 1) goto code_r0x811fcbc9;
		          iVar5 = *piVar6;
		          if (*(ushort *)(iVar5 + 0xb6) != 0) {
		            uVar11 = 0;
		            do {
		              piVar10 = (int *)(*(int *)(iVar5 + 0x58) + uVar11 * 8);
		              if (Core_Application_IApp_TypeInfo == *piVar10) {
		                puVar3 = (undefined4 *)(piVar10[1] * 8 + iVar5 + 0x100);
		                goto code_r0x811fcb00;
		              }
		              uVar11 = uVar11 + 1;
		            } while (*(ushort *)(iVar5 + 0xb6) != uVar11);
		          }
		          DAT_ram_009d3e38 = 0;
		          puVar3 = (undefined4 *)
		                   import::env::invoke_iiii
		                             (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,piVar6,
		                              Core_Application_IApp_TypeInfo,8);
		          if (DAT_ram_009d3e38 == 1) {
		code_r0x811fcbd3:
		            DAT_ram_009d3e38 = 0;
		            uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		            goto code_r0x811fcdbd;
		          }
		code_r0x811fcb00:
		          DAT_ram_009d3e38 = 0;
		          iVar5 = import::env::invoke_iii(*puVar3,piVar6,puVar3[1]);
		          if (DAT_ram_009d3e38 == 1) goto code_r0x811fcbd3;
		          iVar5 = *(int *)(*(int *)(*(int *)(iVar5 + 0x10) + 0x94) + 0x10);
		        } while (iVar5 == 0);
		        DAT_ram_009d3e38 = 0;
		        iVar8 = import::env::invoke_iii
		                          (*(undefined4 *)(*param1 + 0x100),param1,*(undefined4 *)(*param1 + 0x104))
		        ;
		        iVar7 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar7 == 1) {
		          uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x811fcdbd;
		        }
		        piVar6 = *(int **)(iVar8 + 0x3c);
		        iVar7 = *piVar6;
		        if (*(ushort *)(iVar7 + 0xb6) != 0) {
		          uVar11 = 0;
		          do {
		            piVar10 = (int *)(*(int *)(iVar7 + 0x58) + uVar11 * 8);
		            if (Core_Gameplay_IGame_TypeInfo == *piVar10) {
		              puVar3 = (undefined4 *)(piVar10[1] * 8 + iVar7 + 0xe0);
		              goto code_r0x811fcc48;
		            }
		            uVar11 = uVar11 + 1;
		          } while (*(ushort *)(iVar7 + 0xb6) != uVar11);
		        }
		        DAT_ram_009d3e38 = 0;
		        puVar3 = (undefined4 *)
		                 import::env::invoke_iiii
		                           (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,piVar6,
		                            Core_Gameplay_IGame_TypeInfo,4);
		        if (DAT_ram_009d3e38 == 1) {
		code_r0x811fcd97:
		          DAT_ram_009d3e38 = 0;
		          uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x811fcdbd;
		        }
		code_r0x811fcc48:
		        DAT_ram_009d3e38 = 0;
		        uVar1 = import::env::invoke_iii(*puVar3,piVar6,puVar3[1]);
		        if (DAT_ram_009d3e38 == 1) goto code_r0x811fcd97;
		        DAT_ram_009d3e38 = 0;
		        iVar8 = import::env::invoke_iii
		                          (*(undefined4 *)(*param1 + 0x100),param1,*(undefined4 *)(*param1 + 0x104))
		        ;
		        iVar7 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar7 == 1) {
		          uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x811fcdbd;
		        }
		        uVar9 = *(undefined4 *)(iVar8 + 0x3c);
		        DAT_ram_009d3e38 = 0;
		        uVar4 = import::env::invoke_ii
		                          (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x199,
		                           Core_Events_Scopes_GdEventsScope_CompletionsArgs_TypeInfo);
		        if (DAT_ram_009d3e38 == 1) break;
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_viiiii
		                  (s_struct_Uniforms___color__array<v_ram_00001f04 + 0x290,uVar4,iVar12,uVar1,uVar9,
		                   0);
		        if (DAT_ram_009d3e38 == 1) break;
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_viii
		                  (*(undefined4 *)(iVar5 + 0xc),*(undefined4 *)(iVar5 + 0x20),uVar4,
		                   *(undefined4 *)(iVar5 + 0x14));
		      } while (DAT_ram_009d3e38 != 1);
		      DAT_ram_009d3e38 = 0;
		      uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x811fcdbd:
		      iVar12 = global_1;
		      iVar5 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		      if (iVar12 == iVar5) {
		        piVar6 = (int *)import::env::__cxa_begin_catch(uVar4);
		        iVar5 = *piVar6;
		        DAT_ram_009d3e38 = 0;
		        local_28 = iVar5;
		        import::env::invoke_v(0x123);
		        iVar12 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar12 != 1) {
		          if (iVar5 == 0) {
		            DAT_ram_009d3e38 = 0;
		            return;
		          }
		          System_Data_DataSet__ValidateLocaleConstraint(iVar5);
		          do {
		            halt_trap();
		          } while( true );
		        }
		        uVar4 = import::env::__cxa_find_matching_catch_2();
		      }
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001f04 + 0x291,&local_28);
		      goto joined_r0x811fce50;
		    }
		    uVar4 = import::env::__cxa_find_matching_catch_2();
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001f04 + 0x28f,&local_28);
		joined_r0x811fce50:
		  if (DAT_ram_009d3e38 != 1) {
		    DAT_ram_009d3e38 = 0;
		    import::env::__resumeException(uVar4);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::__cxa_find_matching_catch_3(0);
		  unnamed_function_937();
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x06002D14 RID: 11540 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002D14")]
		[Address(RVA = "0x7D92", Offset = "0x7D92", VA = "0x7D92")]
		private void HandleTriggersUpdateEvent(IEnumerable<TriggerValue> changes, AccumulatorBase<int, TriggerValue> accumulator)
		{
		/* --- GHIDRA: HandleTriggersUpdateEvent ---
		/* WARNING: Removing unreachable block (ram,0x811fda5f) */
		
		void Gameplay_GdEvents_Control_GdEventsController__HandleTriggersUpdateEvent
		               (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  int iVar2;
		  int iVar3;
		  int iVar4;
		  undefined4 uVar5;
		  int *piVar6;
		  uint *puVar7;
		  float param3;
		  undefined4 *puVar8;
		  int iVar9;
		  int iVar10;
		  int iVar11;
		  int *piVar12;
		  undefined4 uVar13;
		  uint uVar14;
		  int *piVar15;
		  int *piVar16;
		  int local_48;
		  undefined8 *local_44;
		  int local_40;
		  undefined8 *puStack_3c;
		  undefined8 local_38;
		  undefined8 local_30;
		  undefined8 local_28;
		  undefined4 local_1c;
		  undefined8 local_18;
		  undefined8 local_10;
		  undefined4 local_4;
		  
		  iVar9 = 0;
		  if (DAT_ram_00a5a305 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Extensions_Dict_DictExt_BinarySearch_GameEventDic__uint___);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_AbstractGdEventCatData__Dispose__)
		    ;
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_GdEventData__Dispose__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_GdEventData__MoveNext__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_AbstractGdEventCatData__MoveNext__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_GdEventData__get_Current__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_Enumerator_AbstractGdEventCatData__get_Current__
		              );
		    Mono_Security_ASN1__get_Item(&System_Func_GameEventDic__uint__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_ICollection_GdEventData__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Dict_IDictProvider_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_IList_GdEventData__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_GdEventData__Add__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_AbstractGdEventCatData__GetEnumerator__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_GdEventData__GetEnumerator__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_GdEventData___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_List_GdEventData__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_GameEventDic__get_Count__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_GameEventDic__get_Item__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_GdEvents_Control_GdEventsController___c__HandleDictProviderChangeEvent_b__4_0__
		              );
		    Mono_Security_ASN1__get_Item(&Gameplay_GdEvents_Control_GdEventsController___c_TypeInfo);
		    DAT_ram_00a5a305 = '\x01';
		  }
		  local_10 = 0;
		  local_18 = 0;
		  local_1c = 0;
		  local_28 = 0;
		  local_30 = 0;
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  System_Collections_Generic_List_RegexCharClass_SingleRange___ForEach
		            (&local_40,*(undefined4 *)(iVar2 + 0x10),
		             Method_System_Collections_Generic_List_AbstractGdEventCatData__GetEnumerator__);
		  local_10 = local_38;
		  local_18 = CONCAT44(puStack_3c,local_40);
		  local_48 = 0;
		  local_44 = &local_18;
		code_r0x811fcfe6:
		  DAT_ram_009d3e38 = 0;
		  iVar3 = import::env::invoke_iii
		                    (s_struct_Uniforms___color__array<v_ram_00000aff + 0x44,&local_18,
		                     Method_System_Collections_Generic_List_Enumerator_AbstractGdEventCatData__MoveNext__
		                    );
		  iVar2 = DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = 0;
		  if (iVar2 == 1) {
		    uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		    iVar2 = global_1;
		    goto code_r0x811fdb0d;
		  }
		  if (iVar3 != 0) {
		    DAT_ram_009d3e38 = 0;
		    piVar6 = local_10._4_4_;
		    iVar2 = import::env::invoke_ii
		                      (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x199,
		                       System_Collections_Generic_List_GdEventData__TypeInfo);
		    if (DAT_ram_009d3e38 != 1) {
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_vii
		                (s_struct_Uniforms___color__array<v_ram_00000aff + 0x252,iVar2,
		                 Method_System_Collections_Generic_List_GdEventData___ctor__);
		      if (DAT_ram_009d3e38 != 1) {
		        iVar3 = 0;
		        do {
		          piVar12 = (int *)piVar6[3];
		          iVar1 = *piVar12;
		          if (*(ushort *)(iVar1 + 0xb6) != 0) {
		            uVar14 = 0;
		            do {
		              piVar16 = (int *)(*(int *)(iVar1 + 0x58) + uVar14 * 8);
		              if (System_Collections_Generic_ICollection_GdEventData__TypeInfo == *piVar16) {
		                puVar8 = (undefined4 *)(iVar1 + piVar16[1] * 8 + 0xc0);
		                goto code_r0x811fd14b;
		              }
		              uVar14 = uVar14 + 1;
		            } while (*(ushort *)(iVar1 + 0xb6) != uVar14);
		          }
		          DAT_ram_009d3e38 = 0;
		          puVar8 = (undefined4 *)
		                   import::env::invoke_iiii
		                             (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,piVar12,
		                              System_Collections_Generic_ICollection_GdEventData__TypeInfo,0);
		          if (DAT_ram_009d3e38 == 1) {
		code_r0x811fd63f:
		            DAT_ram_009d3e38 = 0;
		            uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		            iVar2 = global_1;
		            goto code_r0x811fdb0d;
		          }
		code_r0x811fd14b:
		          DAT_ram_009d3e38 = 0;
		          iVar1 = import::env::invoke_iii(*puVar8,piVar12,puVar8[1]);
		          if (DAT_ram_009d3e38 == 1) goto code_r0x811fd63f;
		          if (iVar1 <= iVar3) goto code_r0x811fd5d6;
		          piVar12 = (int *)piVar6[3];
		          iVar1 = *piVar12;
		          if (*(ushort *)(iVar1 + 0xb6) != 0) {
		            uVar14 = 0;
		            do {
		              piVar16 = (int *)(*(int *)(iVar1 + 0x58) + uVar14 * 8);
		              if (System_Collections_Generic_IList_GdEventData__TypeInfo == *piVar16) {
		                puVar8 = (undefined4 *)(iVar1 + piVar16[1] * 8 + 0xc0);
		                goto code_r0x811fd234;
		              }
		              uVar14 = uVar14 + 1;
		            } while (*(ushort *)(iVar1 + 0xb6) != uVar14);
		          }
		          DAT_ram_009d3e38 = 0;
		          puVar8 = (undefined4 *)
		                   import::env::invoke_iiii
		                             (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,piVar12,
		                              System_Collections_Generic_IList_GdEventData__TypeInfo,0);
		          if (DAT_ram_009d3e38 == 1) {
		code_r0x811fd565:
		            DAT_ram_009d3e38 = 0;
		            uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		            iVar2 = global_1;
		            goto code_r0x811fdb0d;
		          }
		code_r0x811fd234:
		          DAT_ram_009d3e38 = 0;
		          iVar1 = import::env::invoke_iiii(*puVar8,piVar12,iVar3,puVar8[1]);
		          if (DAT_ram_009d3e38 == 1) goto code_r0x811fd565;
		          DAT_ram_009d3e38 = 0;
		          iVar10 = import::env::invoke_iii
		                             (*(undefined4 *)(*param1 + 0x100),param1,
		                              *(undefined4 *)(*param1 + 0x104));
		          iVar11 = DAT_ram_009d3e38;
		          DAT_ram_009d3e38 = 0;
		          if (iVar11 == 1) {
		            uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		            iVar2 = global_1;
		            goto code_r0x811fdb0d;
		          }
		          piVar12 = *(int **)(iVar10 + 0x18);
		          iVar11 = *piVar12;
		          if (*(ushort *)(iVar11 + 0xb6) != 0) {
		            uVar14 = 0;
		            do {
		              piVar16 = (int *)(*(int *)(iVar11 + 0x58) + uVar14 * 8);
		              if (Core_Dict_IDictProvider_TypeInfo == *piVar16) {
		                puVar8 = (undefined4 *)(piVar16[1] * 8 + iVar11 + 0xd0);
		                goto code_r0x811fd354;
		              }
		              uVar14 = uVar14 + 1;
		            } while (*(ushort *)(iVar11 + 0xb6) != uVar14);
		          }
		          DAT_ram_009d3e38 = 0;
		          puVar8 = (undefined4 *)
		                   import::env::invoke_iiii
		                             (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,piVar12,
		                              Core_Dict_IDictProvider_TypeInfo,2);
		          if (DAT_ram_009d3e38 == 1) {
		code_r0x811fd551:
		            DAT_ram_009d3e38 = 0;
		            uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		            iVar2 = global_1;
		            goto code_r0x811fdb0d;
		          }
		code_r0x811fd354:
		          DAT_ram_009d3e38 = 0;
		          iVar11 = import::env::invoke_iii(*puVar8,piVar12,puVar8[1]);
		          if (DAT_ram_009d3e38 == 1) goto code_r0x811fd551;
		          local_1c = *(undefined4 *)(iVar11 + 0x2d4);
		          if (*(int *)(Gameplay_GdEvents_Control_GdEventsController___c_TypeInfo + 0x74) == 0) {
		            DAT_ram_009d3e38 = 0;
		            import::env::invoke_vi
		                      (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x180,
		                       Gameplay_GdEvents_Control_GdEventsController___c_TypeInfo);
		            iVar11 = DAT_ram_009d3e38;
		            DAT_ram_009d3e38 = 0;
		            if (iVar11 == 1) {
		              uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		              iVar2 = global_1;
		              goto code_r0x811fdb0d;
		            }
		          }
		          puVar8 = *(undefined4 **)
		                    (Gameplay_GdEvents_Control_GdEventsController___c_TypeInfo + 0x5c);
		          iVar11 = puVar8[1];
		          if (iVar11 == 0) {
		            if (*(int *)(Gameplay_GdEvents_Control_GdEventsController___c_TypeInfo + 0x74) == 0) {
		              DAT_ram_009d3e38 = 0;
		              import::env::invoke_vi
		                        (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x180,
		                         Gameplay_GdEvents_Control_GdEventsController___c_TypeInfo);
		              iVar11 = DAT_ram_009d3e38;
		              DAT_ram_009d3e38 = 0;
		              if (iVar11 == 1) {
		                uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		                iVar2 = global_1;
		                goto code_r0x811fdb0d;
		              }
		              puVar8 = *(undefined4 **)
		                        (Gameplay_GdEvents_Control_GdEventsController___c_TypeInfo + 0x5c);
		            }
		            uVar5 = *puVar8;
		            DAT_ram_009d3e38 = 0;
		            iVar11 = import::env::invoke_ii
		                               (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x199,
		                                System_Func_GameEventDic__uint__TypeInfo);
		            if (DAT_ram_009d3e38 != 1) {
		              DAT_ram_009d3e38 = 0;
		              import::env::invoke_viiii
		                        (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x76,iVar11,uVar5,
		                         Method_Gameplay_GdEvents_Control_GdEventsController___c__HandleDictProviderChangeEvent_b__4_0__
		                         ,0);
		              if (DAT_ram_009d3e38 != 1) {
		                *(int *)(*(int *)(Gameplay_GdEvents_Control_GdEventsController___c_TypeInfo + 0x5c)
		                        + 4) = iVar11;
		                goto code_r0x811fd4b6;
		              }
		            }
		            DAT_ram_009d3e38 = 0;
		            uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		            iVar2 = global_1;
		            goto code_r0x811fdb0d;
		          }
		code_r0x811fd4b6:
		          DAT_ram_009d3e38 = 0;
		          iVar4 = import::env::invoke_iiiii
		                            (s_struct_Uniforms___color__array<v_ram_00001f04 + 0x292,&local_1c,
		                             iVar11,*(undefined4 *)(*(int *)(iVar1 + 0x10) + 0xc),
		                             Method_Core_Extensions_Dict_DictExt_BinarySearch_GameEventDic__uint___)
		          ;
		          iVar10 = DAT_ram_009d3e38;
		          iVar11 = Method_System_Collections_Generic_List_GdEventData__Add__;
		          DAT_ram_009d3e38 = 0;
		          if (iVar10 == 1) {
		            uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		            iVar2 = global_1;
		            goto code_r0x811fdb0d;
		          }
		          if (iVar4 == 0) {
		            *(int *)(iVar2 + 0x10) = *(int *)(iVar2 + 0x10) + 1;
		            uVar14 = *(uint *)(iVar2 + 0xc);
		            if (uVar14 < *(uint *)(*(int *)(iVar2 + 8) + 0xc)) {
		              *(uint *)(iVar2 + 0xc) = uVar14 + 1;
		              *(int *)(*(int *)(iVar2 + 8) + uVar14 * 4 + 0x10) = iVar1;
		            }
		            else {
		              DAT_ram_009d3e38 = 0;
		              import::env::invoke_viii
		                        (s_struct_Uniforms___color__array<v_ram_00000aff + 0x6e,iVar2,iVar1,
		                         *(undefined4 *)(*(int *)(*(int *)(iVar11 + 0x10) + 0x60) + 0x38));
		              iVar1 = DAT_ram_009d3e38;
		              DAT_ram_009d3e38 = 0;
		              if (iVar1 == 1) {
		                uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		                iVar2 = global_1;
		                goto code_r0x811fdb0d;
		              }
		            }
		          }
		          iVar3 = iVar3 + 1;
		        } while( true );
		      }
		    }
		    DAT_ram_009d3e38 = 0;
		    uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		    iVar2 = global_1;
		    goto code_r0x811fdb0d;
		  }
		  iVar1 = 10;
		  iVar3 = local_48;
		  goto code_r0x811fdb58;
		code_r0x811fd5d6:
		  DAT_ram_009d3e38 = 0;
		  System_Collections_Generic_List_RegexCharClass_SingleRange___ForEach
		            (&local_40,iVar2,Method_System_Collections_Generic_List_GdEventData__GetEnumerator__);
		  iVar2 = DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = 0;
		  if (iVar2 == 1) {
		    uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		    iVar2 = global_1;
		    goto code_r0x811fdb0d;
		  }
		  local_28 = local_38;
		  local_30 = CONCAT44(puStack_3c,local_40);
		  local_40 = 0;
		  puStack_3c = &local_30;
		  do {
		    do {
		      do {
		        DAT_ram_009d3e38 = 0;
		        iVar2 = import::env::invoke_iii
		                          (s_struct_Uniforms___color__array<v_ram_00000aff + 0x44,&local_30,
		                           Method_System_Collections_Generic_List_Enumerator_GdEventData__MoveNext__
		                          );
		        if (DAT_ram_009d3e38 == 1) goto code_r0x811fd9db;
		        if (iVar2 == 0) goto code_r0x811fda2d;
		        iVar2 = local_28._4_4_;
		        if (DAT_ram_00a5a2ee == '\0') {
		          DAT_ram_009d3e38 = 0;
		          import::env::invoke_vi
		                    (0x7ff,&System_Collections_Generic_ICollection_GdEventData__TypeInfo);
		          if (DAT_ram_009d3e38 == 1) goto code_r0x811fd9db;
		          DAT_ram_00a5a2ee = '\x01';
		        }
		        piVar12 = (int *)piVar6[3];
		        iVar3 = *piVar12;
		        if (*(ushort *)(iVar3 + 0xb6) != 0) {
		          uVar14 = 0;
		          do {
		            piVar16 = (int *)(*(int *)(iVar3 + 0x58) + uVar14 * 8);
		            if (System_Collections_Generic_ICollection_GdEventData__TypeInfo == *piVar16) {
		              puVar8 = (undefined4 *)(piVar16[1] * 8 + iVar3 + 0xf0);
		              goto code_r0x811fd77c;
		            }
		            uVar14 = uVar14 + 1;
		          } while (*(ushort *)(iVar3 + 0xb6) != uVar14);
		        }
		        DAT_ram_009d3e38 = 0;
		        puVar8 = (undefined4 *)
		                 import::env::invoke_iiii
		                           (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,piVar12,
		                            System_Collections_Generic_ICollection_GdEventData__TypeInfo,6);
		        if (DAT_ram_009d3e38 == 1) goto code_r0x811fd9db;
		code_r0x811fd77c:
		        DAT_ram_009d3e38 = 0;
		        iVar3 = import::env::invoke_iiii(*puVar8,piVar12,iVar2,puVar8[1]);
		        if (DAT_ram_009d3e38 == 1) goto code_r0x811fd9db;
		      } while (iVar3 == 0);
		      *(undefined4 *)(iVar2 + 0x14) = 0;
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_vifi
		                (s_struct_Uniforms___color__array<v_ram_00001f04 + 0x293,
		                 *(undefined4 *)(iVar2 + 0xc),0.0,0);
		      if (DAT_ram_009d3e38 == 1) goto code_r0x811fd9db;
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_vii
		                (*(undefined4 *)(*piVar6 + 0x118),piVar6,*(undefined4 *)(*piVar6 + 0x11c));
		      if (DAT_ram_009d3e38 == 1) goto code_r0x811fd9db;
		      DAT_ram_009d3e38 = 0;
		      iVar3 = import::env::invoke_iii
		                        (*(undefined4 *)(*param1 + 0x100),param1,*(undefined4 *)(*param1 + 0x104));
		      iVar9 = iVar9 + 1;
		      if (DAT_ram_009d3e38 == 1) goto code_r0x811fd9db;
		      iVar2 = *(int *)(iVar2 + 0x10);
		      if (DAT_ram_00a5a2d6 == '\0') {
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_vi
		                  (0x7ff,&Method_System_Collections_Generic_Dictionary_uint__GdEventData__Remove__);
		        if (DAT_ram_009d3e38 == 1) goto code_r0x811fd9db;
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_vi
		                  (0x7ff,&
		                         Method_System_Collections_Generic_Dictionary_uint__GdEventData__TryGetValue__
		                  );
		        if (DAT_ram_009d3e38 == 1) goto code_r0x811fd9db;
		        DAT_ram_00a5a2d6 = '\x01';
		      }
		      local_4 = 0;
		      DAT_ram_009d3e38 = 0;
		      iVar1 = import::env::invoke_iiiii
		                        (s_struct_Uniforms___color__array<v_ram_00000aff + 0x39d,
		                         *(undefined4 *)(iVar3 + 0x44),*(undefined4 *)(iVar2 + 0xc),&local_4,
		                         Method_System_Collections_Generic_Dictionary_uint__GdEventData__TryGetValue__
		                        );
		      if (DAT_ram_009d3e38 == 1) goto code_r0x811fd9db;
		    } while (iVar1 == 0);
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_vii(s_struct_Uniforms___color__array<v_ram_00001f04 + 0x289,local_4,iVar3);
		    if (DAT_ram_009d3e38 == 1) break;
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_iiii
		              (s_struct_Uniforms___color__array<v_ram_00000aff + 0x3ba,*(undefined4 *)(iVar3 + 0x44)
		               ,*(undefined4 *)(iVar2 + 0xc),
		               Method_System_Collections_Generic_Dictionary_uint__GdEventData__Remove__);
		  } while (DAT_ram_009d3e38 != 1);
		code_r0x811fd9db:
		  DAT_ram_009d3e38 = 0;
		  uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		  iVar2 = global_1;
		  iVar3 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar2 == iVar3) {
		    piVar6 = (int *)import::env::__cxa_begin_catch(uVar5);
		    local_40 = *piVar6;
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_v(0x123);
		    iVar2 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar2 != 1) {
		code_r0x811fda2d:
		      if (local_40 != 0) goto code_r0x811fda6c;
		      goto code_r0x811fcfe6;
		    }
		    uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		    iVar2 = global_1;
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001f04 + 0x294,&local_40);
		  iVar3 = DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = 0;
		  if (iVar3 != 1) goto code_r0x811fdb0d;
		  goto code_r0x811fe539;
		code_r0x811fda6c:
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_vi(s_var<private>_posTex__array<vec4<_ram_00000655 + 0x1d3,local_40);
		  iVar2 = DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = 0;
		  if (iVar2 != 1) {
		    do {
		      halt_trap();
		    } while( true );
		  }
		  uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		  iVar2 = global_1;
		code_r0x811fdb0d:
		  iVar3 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar3 == iVar2) {
		    piVar6 = (int *)import::env::__cxa_begin_catch(uVar5);
		    iVar3 = *piVar6;
		    iVar1 = 0;
		    DAT_ram_009d3e38 = 0;
		    local_48 = iVar3;
		    import::env::invoke_v(0x123);
		    iVar2 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar2 != 1) {
		code_r0x811fdb58:
		      DAT_ram_009d3e38 = 0;
		      if (iVar3 != 0) {
		        System_Data_DataSet__ValidateLocaleConstraint(iVar3);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      if ((iVar1 != 0) &&
		         ((((((iVar1 == 1 || (iVar1 == 2)) || (iVar1 == 3)) || ((iVar1 == 4 || (iVar1 == 5)))) ||
		           ((iVar1 == 6 || ((iVar1 == 7 || (iVar1 == 8)))))) || ((iVar1 == 9 || (iVar1 != 10)))))) {
		        return;
		      }
		      iVar2 = 0;
		      do {
		        iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                          (param1,*(undefined4 *)(*param1 + 0x104));
		        piVar6 = *(int **)(iVar3 + 0x18);
		        iVar3 = *piVar6;
		        if (*(ushort *)(iVar3 + 0xb6) != 0) {
		          uVar14 = 0;
		          do {
		            piVar12 = (int *)(*(int *)(iVar3 + 0x58) + uVar14 * 8);
		            if (Core_Dict_IDictProvider_TypeInfo == *piVar12) {
		              puVar7 = (uint *)(piVar12[1] * 8 + iVar3 + 0xd0);
		              goto code_r0x811fdc4a;
		            }
		            uVar14 = uVar14 + 1;
		          } while (*(ushort *)(iVar3 + 0xb6) != uVar14);
		        }
		        puVar7 = (uint *)func_ii_1080(piVar6,Core_Dict_IDictProvider_TypeInfo,2);
		code_r0x811fdc4a:
		        iVar3 = (**(code **)((ulonglong)*puVar7 * 4))(piVar6,puVar7[1]);
		        if (*(int *)(*(int *)(iVar3 + 0x2d4) + 0xc) <= iVar2) {
		          if (0 < iVar9) {
		            iVar9 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                              (param1,*(undefined4 *)(*param1 + 0x104));
		            uVar13 = *(undefined4 *)(*(int *)(iVar9 + 0x30) + 8);
		            uVar5 = UI_Preloader_PreloaderBackgroundLoader_PreloaderBackgroundDto___ctor
		                              (*(undefined4 *)(*(int *)(iVar9 + 0x30) + 0xc),0);
		            func_ii_7893(uVar13,uVar5,0);
		            func_ii_10838(0);
		            iVar9 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                              (param1,*(undefined4 *)(*param1 + 0x114));
		            iVar9 = *(int *)(iVar9 + 0x14);
		            if (iVar9 != 0) {
		              (**(code **)((ulonglong)*(uint *)(iVar9 + 0xc) * 4))
		                        (*(undefined4 *)(iVar9 + 0x20),*(undefined4 *)(iVar9 + 0x14));
		            }
		          }
		          iVar9 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                            (param1,*(undefined4 *)(*param1 + 0x114));
		          iVar9 = *(int *)(iVar9 + 0x1c);
		          if (iVar9 == 0) {
		            return;
		          }
		          (**(code **)((ulonglong)*(uint *)(iVar9 + 0xc) * 4))
		                    (*(undefined4 *)(iVar9 + 0x20),*(undefined4 *)(iVar9 + 0x14));
		          return;
		        }
		        uVar5 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                          (param1,*(undefined4 *)(*param1 + 0x104));
		        iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                          (param1,*(undefined4 *)(*param1 + 0x104));
		        piVar6 = *(int **)(iVar3 + 0x18);
		        iVar3 = *piVar6;
		        if (*(ushort *)(iVar3 + 0xb6) != 0) {
		          uVar14 = 0;
		          do {
		            piVar12 = (int *)(*(int *)(iVar3 + 0x58) + uVar14 * 8);
		            if (Core_Dict_IDictProvider_TypeInfo == *piVar12) {
		              puVar7 = (uint *)(piVar12[1] * 8 + iVar3 + 0xd0);
		              goto code_r0x811fdd15;
		            }
		            uVar14 = uVar14 + 1;
		          } while (*(ushort *)(iVar3 + 0xb6) != uVar14);
		        }
		        puVar7 = (uint *)func_ii_1080(piVar6,Core_Dict_IDictProvider_TypeInfo,2);
		code_r0x811fdd15:
		        iVar3 = (**(code **)((ulonglong)*puVar7 * 4))(piVar6,puVar7[1]);
		        uVar13 = Google_Protobuf_Collections_RepeatedField_Int32Enum___get_IsReadOnly
		                           (*(undefined4 *)(iVar3 + 0x2d4),iVar2,
		                            Method_Google_Protobuf_Collections_RepeatedField_GameEventDic__get_Item__
		                           );
		        iVar3 = Gameplay_GdEvents_Model_GdEventsModel___ctor(uVar5,uVar13,puVar7);
		        iVar11 = *(int *)(iVar3 + 0x14);
		        iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                          (param1,*(undefined4 *)(*param1 + 0x104));
		        System_Collections_Generic_List_RegexCharClass_SingleRange___ForEach
		                  (&local_40,*(undefined4 *)(iVar1 + 0x10),
		                   Method_System_Collections_Generic_List_AbstractGdEventCatData__GetEnumerator__);
		        local_10 = local_38;
		        local_18 = CONCAT44(puStack_3c,local_40);
		        local_40 = 0;
		        puStack_3c = &local_18;
		        do {
		          while( true ) {
		            DAT_ram_009d3e38 = 0;
		            iVar1 = import::env::invoke_iii
		                              (s_struct_Uniforms___color__array<v_ram_00000aff + 0x44,&local_18,
		                               Method_System_Collections_Generic_List_Enumerator_AbstractGdEventCatData__MoveNext__
		                              );
		            if (DAT_ram_009d3e38 == 1) goto code_r0x811fe313;
		            if (iVar1 == 0) goto code_r0x811fe377;
		            piVar6 = local_10._4_4_;
		            DAT_ram_009d3e38 = 0;
		            iVar1 = import::env::invoke_iiii
		                              (*(undefined4 *)(*local_10._4_4_ + 0x110),local_10._4_4_,iVar3,
		                               *(undefined4 *)(*local_10._4_4_ + 0x114));
		            if (DAT_ram_009d3e38 == 1) goto code_r0x811fe313;
		            piVar12 = *(int **)(iVar3 + 0x14);
		            if (iVar1 != 0) break;
		            if (piVar12 == piVar6) {
		              if (DAT_ram_00a5a2ee == '\0') {
		                DAT_ram_009d3e38 = 0;
		                import::env::invoke_vi
		                          (0x7ff,&System_Collections_Generic_ICollection_GdEventData__TypeInfo);
		                if (DAT_ram_009d3e38 == 1) goto code_r0x811fe313;
		                DAT_ram_00a5a2ee = '\x01';
		              }
		              piVar12 = (int *)piVar6[3];
		              iVar1 = *piVar12;
		              if (*(ushort *)(iVar1 + 0xb6) != 0) {
		                uVar14 = 0;
		                do {
		                  piVar16 = (int *)(*(int *)(iVar1 + 0x58) + uVar14 * 8);
		                  if (System_Collections_Generic_ICollection_GdEventData__TypeInfo == *piVar16) {
		                    puVar8 = (undefined4 *)(piVar16[1] * 8 + iVar1 + 0xf0);
		                    goto code_r0x811fe199;
		                  }
		                  uVar14 = uVar14 + 1;
		                } while (*(ushort *)(iVar1 + 0xb6) != uVar14);
		              }
		              DAT_ram_009d3e38 = 0;
		              puVar8 = (undefined4 *)
		                       import::env::invoke_iiii
		                                 (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,piVar12,
		                                  System_Collections_Generic_ICollection_GdEventData__TypeInfo,6);
		              if (DAT_ram_009d3e38 == 1) goto code_r0x811fe313;
		code_r0x811fe199:
		              DAT_ram_009d3e38 = 0;
		              iVar1 = import::env::invoke_iiii(*puVar8,piVar12,iVar3,puVar8[1]);
		              if (DAT_ram_009d3e38 == 1) goto code_r0x811fe313;
		              if (iVar1 != 0) {
		                *(undefined4 *)(iVar3 + 0x14) = 0;
		                DAT_ram_009d3e38 = 0;
		                import::env::invoke_vifi
		                          (s_struct_Uniforms___color__array<v_ram_00001f04 + 0x293,
		                           *(undefined4 *)(iVar3 + 0xc),0.0,0);
		                if (DAT_ram_009d3e38 == 1) goto code_r0x811fe313;
		                DAT_ram_009d3e38 = 0;
		                import::env::invoke_vii
		                          (*(undefined4 *)(*piVar6 + 0x118),piVar6,*(undefined4 *)(*piVar6 + 0x11c))
		                ;
		joined_r0x811fe0af:
		                if (DAT_ram_009d3e38 == 1) goto code_r0x811fe313;
		              }
		            }
		          }
		          if (piVar12 == piVar6) {
		            uVar5 = *(undefined4 *)(iVar3 + 0xc);
		            DAT_ram_009d3e38 = 0;
		            param3 = import::env::invoke_fiii
		                               (*(undefined4 *)(*piVar6 + 0xf8),piVar6,iVar3,
		                                *(undefined4 *)(*piVar6 + 0xfc));
		            if (DAT_ram_009d3e38 != 1) {
		              DAT_ram_009d3e38 = 0;
		              import::env::invoke_vifi
		                        (s_struct_Uniforms___color__array<v_ram_00001f04 + 0x293,uVar5,param3,0);
		              goto joined_r0x811fe0af;
		            }
		            break;
		          }
		          if (piVar12 != (int *)0x0) {
		            if (DAT_ram_00a5a2ee == '\0') {
		              DAT_ram_009d3e38 = 0;
		              import::env::invoke_vi
		                        (0x7ff,&System_Collections_Generic_ICollection_GdEventData__TypeInfo);
		              if (DAT_ram_009d3e38 == 1) break;
		              DAT_ram_00a5a2ee = '\x01';
		            }
		            piVar16 = (int *)piVar12[3];
		            iVar1 = *piVar16;
		            if (*(ushort *)(iVar1 + 0xb6) != 0) {
		              uVar14 = 0;
		              do {
		                piVar15 = (int *)(*(int *)(iVar1 + 0x58) + uVar14 * 8);
		                if (System_Collections_Generic_ICollection_GdEventData__TypeInfo == *piVar15) {
		                  puVar8 = (undefined4 *)(piVar15[1] * 8 + iVar1 + 0xf0);
		                  goto code_r0x811fdf22;
		                }
		                uVar14 = uVar14 + 1;
		              } while (*(ushort *)(iVar1 + 0xb6) != uVar14);
		            }
		            DAT_ram_009d3e38 = 0;
		            puVar8 = (undefined4 *)
		                     import::env::invoke_iiii
		                               (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,piVar16,
		                                System_Collections_Generic_ICollection_GdEventData__TypeInfo,6);
		            if (DAT_ram_009d3e38 == 1) break;
		code_r0x811fdf22:
		            DAT_ram_009d3e38 = 0;
		            iVar1 = import::env::invoke_iiii(*puVar8,piVar16,iVar3,puVar8[1]);
		            if (DAT_ram_009d3e38 == 1) break;
		            if (iVar1 != 0) {
		              *(undefined4 *)(iVar3 + 0x14) = 0;
		              DAT_ram_009d3e38 = 0;
		              import::env::invoke_vifi
		                        (s_struct_Uniforms___color__array<v_ram_00001f04 + 0x293,
		                         *(undefined4 *)(iVar3 + 0xc),0.0,0);
		              if (DAT_ram_009d3e38 == 1) break;
		              DAT_ram_009d3e38 = 0;
		              import::env::invoke_vii
		                        (*(undefined4 *)(*piVar12 + 0x118),piVar12,*(undefined4 *)(*piVar12 + 0x11c)
		                        );
		              if (DAT_ram_009d3e38 == 1) break;
		            }
		          }
		          DAT_ram_009d3e38 = 0;
		          import::env::invoke_iiii
		                    (*(undefined4 *)(*piVar6 + 0xe8),piVar6,iVar3,*(undefined4 *)(*piVar6 + 0xec));
		        } while (DAT_ram_009d3e38 != 1);
		code_r0x811fe313:
		        DAT_ram_009d3e38 = 0;
		        uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        iVar1 = global_1;
		        iVar10 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		        if (iVar1 != iVar10) {
		code_r0x811fe392:
		          DAT_ram_009d3e38 = 0;
		          import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001f04 + 0x296,&local_40);
		          goto joined_r0x811fdbbd;
		        }
		        piVar6 = (int *)import::env::__cxa_begin_catch(uVar5);
		        iVar10 = *piVar6;
		        DAT_ram_009d3e38 = 0;
		        local_40 = iVar10;
		        import::env::invoke_v(0x123);
		        iVar1 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar1 == 1) {
		          uVar5 = import::env::__cxa_find_matching_catch_2();
		          goto code_r0x811fe392;
		        }
		        if (iVar10 != 0) {
		          System_Data_DataSet__ValidateLocaleConstraint(iVar10);
		          do {
		            halt_trap();
		          } while( true );
		        }
		code_r0x811fe377:
		        DAT_ram_009d3e38 = 0;
		        iVar1 = *(int *)(iVar3 + 0x14);
		        if (iVar1 == iVar11) {
		          *(undefined1 *)(iVar3 + 0x18) = 0;
		code_r0x811fe3f8:
		          iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                            (param1,*(undefined4 *)(*param1 + 0x104));
		          iVar1 = *(int *)(iVar1 + 0x30);
		          uVar5 = *(undefined4 *)(*(int *)(iVar3 + 0x10) + 0xc);
		          if (DAT_ram_00a5a2ce == '\0') {
		            Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_uint__Remove__);
		            DAT_ram_00a5a2ce = '\x01';
		          }
		          System_Collections_Generic_List_uint___IsCompatibleObject
		                    (*(undefined4 *)(*(int *)(iVar1 + 0xc) + 8),uVar5,
		                     Method_System_Collections_Generic_List_uint__Remove__);
		        }
		        else {
		          iVar11 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                             (param1,*(undefined4 *)(*param1 + 0x104));
		          iVar11 = *(int *)(iVar11 + 0xc);
		          *(bool *)(iVar3 + 0x18) = iVar1 == iVar11;
		          iVar9 = iVar9 + 1;
		          if (iVar1 != iVar11) goto code_r0x811fe3f8;
		          iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                            (param1,*(undefined4 *)(*param1 + 0x104));
		          iVar1 = *(int *)(iVar1 + 0x30);
		          uVar5 = *(undefined4 *)(*(int *)(iVar3 + 0x10) + 0xc);
		          if (DAT_ram_00a5a2cd == '\0') {
		            Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_uint__Add__);
		            Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_uint__Contains__);
		            DAT_ram_00a5a2cd = '\x01';
		          }
		          iVar11 = System_Collections_Generic_List_uint___GetEnumerator
		                             (*(undefined4 *)(*(int *)(iVar1 + 0xc) + 8),uVar5,
		                              Method_System_Collections_Generic_List_uint__Contains__);
		          iVar3 = Method_System_Collections_Generic_List_uint__Add__;
		          if (iVar11 == 0) {
		            iVar1 = *(int *)(*(int *)(iVar1 + 0xc) + 8);
		            *(int *)(iVar1 + 0x10) = *(int *)(iVar1 + 0x10) + 1;
		            uVar14 = *(uint *)(iVar1 + 0xc);
		            if (uVar14 < *(uint *)(*(int *)(iVar1 + 8) + 0xc)) {
		              *(uint *)(iVar1 + 0xc) = uVar14 + 1;
		              *(undefined4 *)(*(int *)(iVar1 + 8) + uVar14 * 4 + 0x10) = uVar5;
		            }
		            else {
		              System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		                        (iVar1,uVar5,*(undefined4 *)(*(int *)(*(int *)(iVar3 + 0x10) + 0x60) + 0x38)
		                        );
		            }
		          }
		        }
		        iVar2 = iVar2 + 1;
		      } while( true );
		    }
		    uVar5 = import::env::__cxa_find_matching_catch_2();
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001f04 + 0x295,&local_48);
		joined_r0x811fdbbd:
		  if (DAT_ram_009d3e38 != 1) {
		    DAT_ram_009d3e38 = 0;
		    import::env::__resumeException(uVar5);
		    do {
		      halt_trap();
		    } while( true );
		  }
		code_r0x811fe539:
		  DAT_ram_009d3e38 = 0;
		  import::env::__cxa_find_matching_catch_3(0);
		  unnamed_function_937();
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x06002D15 RID: 11541 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002D15")]
		[Address(RVA = "0x7D93", Offset = "0x7D93", VA = "0x7D93")]
		private void HandleDictProviderChangeEvent()
		{
		/* --- GHIDRA: HandleDictProviderChangeEvent ---
		void Gameplay_GdEvents_Control_GdEventsController__HandleDictProviderChangeEvent
		               (undefined4 param1,int param2,undefined4 param3,undefined4 param4)
		
		{
		  undefined4 uVar1;
		  undefined4 uVar2;
		  undefined4 uVar3;
		  undefined4 *puVar4;
		  int param1_00;
		  
		  if (DAT_ram_00a5a306 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_OpToken_IMessage__object___TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_Select_MilestoneData__uint___);
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_ToArray_uint___);
		    Mono_Security_ASN1__get_Item(&System_Func_MilestoneData__uint__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_GdEvents_Control_GdEventsController_HandleGetEventMilestonesRewardsInfoService__
		              );
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__SetCustomData__);
		    Mono_Security_ASN1__get_Item(&Method_Core_Net_ServiceFactory_GetService_MainService___);
		    Mono_Security_ASN1__get_Item(&Core_Net_ServiceFactory_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_GdEvents_Control_GdEventsController___c__RequestEventMilestoneRewards_b__5_0__
		              );
		    Mono_Security_ASN1__get_Item(&Gameplay_GdEvents_Control_GdEventsController___c_TypeInfo);
		    DAT_ram_00a5a306 = '\x01';
		  }
		  if (*(int *)(Core_Net_ServiceFactory_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Net_ServiceFactory_TypeInfo);
		  }
		  uVar1 = Core_Gameplay_Managers_LoggedManager__RequestLogin
		                    (Method_Core_Net_ServiceFactory_GetService_MainService___);
		  uVar3 = *(undefined4 *)(*(int *)(param2 + 0x10) + 0xc);
		  if (*(int *)(Gameplay_GdEvents_Control_GdEventsController___c_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Gameplay_GdEvents_Control_GdEventsController___c_TypeInfo);
		  }
		  puVar4 = *(undefined4 **)(Gameplay_GdEvents_Control_GdEventsController___c_TypeInfo + 0x5c);
		  param1_00 = puVar4[2];
		  if (param1_00 == 0) {
		    if (*(int *)(Gameplay_GdEvents_Control_GdEventsController___c_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Gameplay_GdEvents_Control_GdEventsController___c_TypeInfo);
		      puVar4 = *(undefined4 **)(Gameplay_GdEvents_Control_GdEventsController___c_TypeInfo + 0x5c);
		    }
		    uVar2 = *puVar4;
		    param1_00 = unnamed_function_1417(System_Func_MilestoneData__uint__TypeInfo);
		    System_Collections_Generic_Dictionary_KeyCollection_uint__object___GetEnumerator
		              (param1_00,uVar2,
		               Method_Gameplay_GdEvents_Control_GdEventsController___c__RequestEventMilestoneRewards_b__5_0__
		               ,0);
		    *(int *)(*(int *)(Gameplay_GdEvents_Control_GdEventsController___c_TypeInfo + 0x5c) + 8) =
		         param1_00;
		  }
		  uVar2 = System_Linq_Enumerable__ReverseIterator___Il2CppFullySharedGenericType_
		                    (param3,param1_00,Method_System_Linq_Enumerable_Select_MilestoneData__uint___);
		  uVar2 = System_Linq_Enumerable__OrderBy_uint__uint_
		                    (uVar2,Method_System_Linq_Enumerable_ToArray_uint___);
		  uVar1 = ServicesNamespace_MainService__GetGameEventsRewardsInfo(uVar1,uVar3,uVar2,0);
		  uVar1 = DG_Tweening_TweenParams__SetId
		                    (uVar1,param2,Method_Utils_OpToken_IMessage__object__SetCustomData__);
		  uVar3 = unnamed_function_1417(System_Action_OpToken_IMessage__object___TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar3,param1,
		             Method_Gameplay_GdEvents_Control_GdEventsController_HandleGetEventMilestonesRewardsInfoService__
		             ,0);
		  uVar1 = ServicesNamespace_MainService__GetUserStats
		                    (uVar1,uVar3,0,Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		  Utils_OpToken_int__object___AddHandlers(param1,uVar1,0);
		  return;
		}
		*/

		}

		// Token: 0x06002D16 RID: 11542 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002D16")]
		[Address(RVA = "0x7D94", Offset = "0x7D94", VA = "0x7D94")]
		private void RequestEventMilestoneRewards(GdEventData evt, params MilestoneData[] milestones)
		{
		/* --- GHIDRA: RequestEventMilestoneRewards ---
		void Gameplay_GdEvents_Control_GdEventsController__RequestEventMilestoneRewards
		               (int *param1,int param2,undefined4 param3)
		
		{
		  uint uVar1;
		  undefined4 *puVar2;
		  undefined4 uVar3;
		  int iVar4;
		  int iVar5;
		  uint *puVar6;
		  int *piVar7;
		  int *piVar8;
		  int iVar9;
		  int *piVar10;
		  int local_c;
		  int **local_8;
		  int *local_4;
		  
		  if (DAT_ram_00a5a307 == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_GdEvents_Model_GdEventData_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_IDisposable_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               System_Collections_Generic_IEnumerator_ProtoGetEventMilestonesRewardsInfoAns_Types_MilestoneRewards__TypeInfo
		              );
		    Mono_Security_ASN1__get_Item(&System_Collections_IEnumerator_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_GdEvents_Model_IRewardProvider_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__get_Result__);
		    Mono_Security_ASN1__get_Item(&Protocol_Main_ProtoGetEventMilestonesRewardsInfoAns_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Google_Protobuf_Collections_RepeatedField_ProtoGetEventMilestonesRewardsInfoAns_Types_MilestoneRewards__GetEnumerator__
		              );
		    DAT_ram_00a5a307 = '\x01';
		  }
		  MVC_AbstractController__CancelRequests(param1,param2,0);
		  piVar7 = *(int **)(param2 + 0xc);
		  if (piVar7 != (int *)0x0) {
		    if (((uint)*(byte *)(*piVar7 + 0xb8) <
		         (uint)*(byte *)(Gameplay_GdEvents_Model_GdEventData_TypeInfo + 0xb8)) ||
		       (*(int *)(*(int *)(*piVar7 + 100) +
		                 (uint)*(byte *)(Gameplay_GdEvents_Model_GdEventData_TypeInfo + 0xb8) * 4 + -4) !=
		        Gameplay_GdEvents_Model_GdEventData_TypeInfo)) {
		      System_Activator__CreateInstance(piVar7,Gameplay_GdEvents_Model_GdEventData_TypeInfo);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  piVar8 = *(int **)(param2 + 0x20);
		  if ((piVar8 != (int *)0x0) &&
		     (Protocol_Main_ProtoGetEventMilestonesRewardsInfoAns_TypeInfo != *piVar8)) {
		    System_Activator__CreateInstance
		              (piVar8,Protocol_Main_ProtoGetEventMilestonesRewardsInfoAns_TypeInfo);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  local_4 = (int *)Google_Protobuf_Collections_RepeatedField_float___Equals
		                             (piVar8[3],
		                              Method_Google_Protobuf_Collections_RepeatedField_ProtoGetEventMilestonesRewardsInfoAns_Types_MilestoneRewards__GetEnumerator__
		                             );
		  local_c = 0;
		  local_8 = &local_4;
		  do {
		    do {
		      do {
		        piVar8 = local_4;
		        iVar9 = *local_4;
		        if (*(ushort *)(iVar9 + 0xb6) != 0) {
		          uVar1 = 0;
		          do {
		            piVar10 = (int *)(*(int *)(iVar9 + 0x58) + uVar1 * 8);
		            if (System_Collections_IEnumerator_TypeInfo == *piVar10) {
		              puVar2 = (undefined4 *)(iVar9 + piVar10[1] * 8 + 0xc0);
		              goto code_r0x811fe89f;
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
		code_r0x811fe8e7:
		          DAT_ram_009d3e38 = 0;
		          uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x811fec44;
		        }
		code_r0x811fe89f:
		        DAT_ram_009d3e38 = 0;
		        iVar9 = import::env::invoke_iii(*puVar2,piVar8,puVar2[1]);
		        piVar8 = local_4;
		        if (DAT_ram_009d3e38 == 1) goto code_r0x811fe8e7;
		        if (iVar9 == 0) {
		          iVar9 = 0;
		          goto code_r0x811fec8b;
		        }
		        iVar9 = *local_4;
		        if (*(ushort *)(iVar9 + 0xb6) != 0) {
		          uVar1 = 0;
		          do {
		            piVar10 = (int *)(*(int *)(iVar9 + 0x58) + uVar1 * 8);
		            if (System_Collections_Generic_IEnumerator_ProtoGetEventMilestonesRewardsInfoAns_Types_MilestoneRewards__TypeInfo
		                == *piVar10) {
		              puVar2 = (undefined4 *)(iVar9 + piVar10[1] * 8 + 0xc0);
		              goto code_r0x811fe98c;
		            }
		            uVar1 = uVar1 + 1;
		          } while (*(ushort *)(iVar9 + 0xb6) != uVar1);
		        }
		        DAT_ram_009d3e38 = 0;
		        puVar2 = (undefined4 *)
		                 import::env::invoke_iiii
		                           (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                            System_Collections_Generic_IEnumerator_ProtoGetEventMilestonesRewardsInfoAns_Types_MilestoneRewards__TypeInfo
		                            ,0);
		        if (DAT_ram_009d3e38 == 1) {
		code_r0x811febf6:
		          DAT_ram_009d3e38 = 0;
		          uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x811fec44;
		        }
		code_r0x811fe98c:
		        DAT_ram_009d3e38 = 0;
		        iVar9 = import::env::invoke_iii(*puVar2,piVar8,puVar2[1]);
		        if (DAT_ram_009d3e38 == 1) goto code_r0x811febf6;
		        DAT_ram_009d3e38 = 0;
		        iVar4 = import::env::invoke_iii
		                          (*(undefined4 *)(*param1 + 0x100),param1,*(undefined4 *)(*param1 + 0x104))
		        ;
		        iVar5 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar5 == 1) {
		          uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x811fec44;
		        }
		        uVar3 = *(undefined4 *)(piVar7[4] + 0xc);
		        piVar8 = *(int **)(iVar4 + 0x2c);
		        iVar5 = *piVar8;
		        if (*(ushort *)(iVar5 + 0xb6) != 0) {
		          uVar1 = 0;
		          do {
		            piVar10 = (int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8);
		            if (Gameplay_GdEvents_Model_IRewardProvider_TypeInfo == *piVar10) {
		              puVar2 = (undefined4 *)(piVar10[1] * 8 + iVar5 + 0xd0);
		              goto code_r0x811feab0;
		            }
		            uVar1 = uVar1 + 1;
		          } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		        }
		        DAT_ram_009d3e38 = 0;
		        puVar2 = (undefined4 *)
		                 import::env::invoke_iiii
		                           (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,piVar8,
		                            Gameplay_GdEvents_Model_IRewardProvider_TypeInfo,2);
		        if (DAT_ram_009d3e38 == 1) {
		code_r0x811fec0e:
		          DAT_ram_009d3e38 = 0;
		          uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x811fec44;
		        }
		code_r0x811feab0:
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_viiii(*puVar2,piVar8,uVar3,iVar9,puVar2[1]);
		        if (DAT_ram_009d3e38 == 1) goto code_r0x811fec0e;
		        DAT_ram_009d3e38 = 0;
		        iVar4 = import::env::invoke_iii
		                          (*(undefined4 *)(*param1 + 0x100),param1,*(undefined4 *)(*param1 + 0x104))
		        ;
		        iVar5 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar5 == 1) {
		          uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x811fec44;
		        }
		      } while ((*(int **)(iVar4 + 0x4c) != piVar7) ||
		              (*(int *)(*(int *)(piVar7[0xd] + 8) + 0xc) != *(int *)(iVar9 + 0xc)));
		      DAT_ram_009d3e38 = 0;
		      iVar5 = import::env::invoke_iii
		                        (*(undefined4 *)(*param1 + 0x110),param1,*(undefined4 *)(*param1 + 0x114));
		      iVar9 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar9 == 1) {
		        uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x811fec44;
		      }
		      iVar9 = *(int *)(iVar5 + 0x20);
		    } while (iVar9 == 0);
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_viii
		              (*(undefined4 *)(iVar9 + 0xc),*(undefined4 *)(iVar9 + 0x20),piVar7[0xd],
		               *(undefined4 *)(iVar9 + 0x14));
		    iVar9 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		  } while (iVar9 != 1);
		  uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x811fec44:
		  iVar9 = global_1;
		  iVar5 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar9 == iVar5) {
		    piVar7 = (int *)import::env::__cxa_begin_catch(uVar3);
		    iVar9 = *piVar7;
		    DAT_ram_009d3e38 = 0;
		    local_c = iVar9;
		    import::env::invoke_v(0x123);
		    iVar5 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar5 != 1) {
		code_r0x811fec8b:
		      piVar7 = local_4;
		      DAT_ram_009d3e38 = 0;
		      if (local_4 != (int *)0x0) {
		        uVar1 = 0;
		        iVar5 = *local_4;
		        if (*(ushort *)(iVar5 + 0xb6) != 0) {
		          do {
		            if (System_IDisposable_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		              puVar6 = (uint *)(iVar5 + *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0)
		              ;
		              goto code_r0x811fed03;
		            }
		            uVar1 = uVar1 + 1;
		          } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		        }
		        puVar6 = (uint *)func_ii_1080(local_4,System_IDisposable_TypeInfo,0);
		code_r0x811fed03:
		        (**(code **)((ulonglong)*puVar6 * 4))(piVar7,puVar6[1]);
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
		  import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001f04 + 0x297,&local_c);
		  iVar9 = DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = 0;
		  if (iVar9 == 1) {
		    import::env::__cxa_find_matching_catch_3(0);
		    unnamed_function_937();
		    do {
		      halt_trap();
		    } while( true );
		  }
		  import::env::__resumeException(uVar3);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x06002D17 RID: 11543 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002D17")]
		[Address(RVA = "0x7D95", Offset = "0x7D95", VA = "0x7D95")]
		private void HandleGetEventMilestonesRewardsInfoService(OpToken<IMessage, object> op)
		{
		/* --- GHIDRA: HandleGetEventMilestonesRewardsInfoService ---
		void Gameplay_GdEvents_Control_GdEventsController__HandleGetEventMilestonesRewardsInfoService
		               (undefined4 param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a5a308 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_OpToken_IMessage__object___TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_GdEvents_Control_GdEventsController_HandleGetGameEventsRewardsInfoService__
		              );
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__SetCustomData__);
		    Mono_Security_ASN1__get_Item(&Method_Core_Net_ServiceFactory_GetService_MainService___);
		    Mono_Security_ASN1__get_Item(&Core_Net_ServiceFactory_TypeInfo);
		    DAT_ram_00a5a308 = '\x01';
		  }
		  if (*(int *)(Core_Net_ServiceFactory_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Net_ServiceFactory_TypeInfo);
		  }
		  uVar1 = Core_Gameplay_Managers_LoggedManager__RequestLogin
		                    (Method_Core_Net_ServiceFactory_GetService_MainService___);
		  uVar1 = ServicesNamespace_MainService__UserSettingsSave
		                    (uVar1,*(undefined4 *)(*(int *)(param2 + 0x10) + 0xc),0);
		  uVar1 = DG_Tweening_TweenParams__SetId
		                    (uVar1,param2,Method_Utils_OpToken_IMessage__object__SetCustomData__);
		  param1_00 = unnamed_function_1417(System_Action_OpToken_IMessage__object___TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (param1_00,param1,
		             Method_Gameplay_GdEvents_Control_GdEventsController_HandleGetGameEventsRewardsInfoService__
		             ,0);
		  uVar1 = ServicesNamespace_MainService__GetUserStats
		                    (uVar1,param1_00,0,Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		  Utils_OpToken_int__object___AddHandlers(param1,uVar1,0);
		  return;
		}
		*/

		}

		// Token: 0x06002D18 RID: 11544 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002D18")]
		[Address(RVA = "0x7D96", Offset = "0x7D96", VA = "0x7D96")]
		private void RequestEventRewards(GdEventData evt)
		{
		/* --- GHIDRA: RequestEventRewards ---
		void Gameplay_GdEvents_Control_GdEventsController__RequestEventRewards
		               (int *param1,int param2,undefined4 param3)
		
		{
		  uint uVar1;
		  int iVar2;
		  undefined4 uVar3;
		  uint *puVar4;
		  int *param1_00;
		  int *param1_01;
		  int *param1_02;
		  undefined4 uVar5;
		  
		  if (DAT_ram_00a5a309 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_ToArray_RewardInfo___);
		    Mono_Security_ASN1__get_Item(&Gameplay_GdEvents_Model_GdEventData_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_GdEvents_Model_IRewardProvider_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__get_Result__);
		    Mono_Security_ASN1__get_Item(&Protocol_Main_ProtoGetGameEventRewardsInfoAns_TypeInfo);
		    DAT_ram_00a5a309 = '\x01';
		  }
		  MVC_AbstractController__CancelRequests(param1,param2,0);
		  param1_00 = *(int **)(param2 + 0xc);
		  if (param1_00 != (int *)0x0) {
		    if (((uint)*(byte *)(*param1_00 + 0xb8) <
		         (uint)*(byte *)(Gameplay_GdEvents_Model_GdEventData_TypeInfo + 0xb8)) ||
		       (*(int *)(*(int *)(*param1_00 + 100) +
		                 (uint)*(byte *)(Gameplay_GdEvents_Model_GdEventData_TypeInfo + 0xb8) * 4 + -4) !=
		        Gameplay_GdEvents_Model_GdEventData_TypeInfo)) {
		      System_Activator__CreateInstance(param1_00,Gameplay_GdEvents_Model_GdEventData_TypeInfo);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  param1_01 = *(int **)(param2 + 0x20);
		  if ((param1_01 != (int *)0x0) &&
		     (Protocol_Main_ProtoGetGameEventRewardsInfoAns_TypeInfo != *param1_01)) {
		    System_Activator__CreateInstance
		              (param1_01,Protocol_Main_ProtoGetGameEventRewardsInfoAns_TypeInfo);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  param1_02 = *(int **)(iVar2 + 0x2c);
		  uVar5 = *(undefined4 *)(param1_00[4] + 0xc);
		  uVar3 = func_ii_6295(param1_01[3],Method_System_Linq_Enumerable_ToArray_RewardInfo___);
		  iVar2 = *param1_02;
		  if (*(ushort *)(iVar2 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Gameplay_GdEvents_Model_IRewardProvider_TypeInfo ==
		          *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8)) {
		        puVar4 = (uint *)(*(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8 + 4) * 8 + iVar2 + 200);
		        goto code_r0x811fef83;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		  }
		  puVar4 = (uint *)func_ii_1080(param1_02,Gameplay_GdEvents_Model_IRewardProvider_TypeInfo,1);
		code_r0x811fef83:
		  (**(code **)((ulonglong)*puVar4 * 4))(param1_02,uVar5,uVar3,puVar4[1]);
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  if (*(int **)(iVar2 + 0x4c) == param1_00) {
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x114));
		    iVar2 = *(int *)(iVar2 + 0x24);
		    if (iVar2 != 0) {
		      (**(code **)((ulonglong)*(uint *)(iVar2 + 0xc) * 4))
		                (*(undefined4 *)(iVar2 + 0x20),param1_00,*(undefined4 *)(iVar2 + 0x14));
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x06002D19 RID: 11545 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002D19")]
		[Address(RVA = "0x7D97", Offset = "0x7D97", VA = "0x7D97")]
		private void HandleGetGameEventsRewardsInfoService(OpToken<IMessage, object> op)
		{
		/* --- GHIDRA: HandleGetGameEventsRewardsInfoService ---
		void Gameplay_GdEvents_Control_GdEventsController__HandleGetGameEventsRewardsInfoService
		               (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  int iVar2;
		  int iVar3;
		  undefined4 uVar4;
		  undefined4 param1_00;
		  
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  iVar3 = *(int *)(iVar1 + 0x4c);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  *(undefined4 *)(iVar1 + 0x4c) = param2;
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  if (*(int *)(iVar1 + 0x4c) != 0) {
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x104));
		    *(undefined1 *)(*(int *)(iVar1 + 0x4c) + 0x18) = 0;
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x104));
		    iVar2 = *(int *)(iVar1 + 0x30);
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x104));
		    uVar4 = *(undefined4 *)(*(int *)(*(int *)(iVar1 + 0x4c) + 0x10) + 0xc);
		    if (DAT_ram_00a5a2ce == '\0') {
		      Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_uint__Remove__);
		      DAT_ram_00a5a2ce = '\x01';
		    }
		    iVar1 = System_Collections_Generic_List_uint___IsCompatibleObject
		                      (*(undefined4 *)(*(int *)(iVar2 + 0xc) + 8),uVar4,
		                       Method_System_Collections_Generic_List_uint__Remove__);
		    if (iVar1 != 0) {
		      iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x104));
		      param1_00 = *(undefined4 *)(*(int *)(iVar1 + 0x30) + 8);
		      uVar4 = UI_Preloader_PreloaderBackgroundLoader_PreloaderBackgroundDto___ctor
		                        (*(undefined4 *)(*(int *)(iVar1 + 0x30) + 0xc),0);
		      func_ii_7893(param1_00,uVar4,0);
		      func_ii_10838(0);
		    }
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  if (iVar3 != *(int *)(iVar1 + 0x4c)) {
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x114));
		    iVar1 = *(int *)(iVar1 + 0x18);
		    if (iVar1 != 0) {
		      iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x104));
		      (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		                (*(undefined4 *)(iVar1 + 0x20),iVar3,*(undefined4 *)(iVar2 + 0x4c),
		                 *(undefined4 *)(iVar1 + 0x14));
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x06002D1A RID: 11546 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002D1A")]
		[Address(RVA = "0x7D98", Offset = "0x7D98", VA = "0x7D98")]
		public void SetCurrentEvent(GdEventData data)
		{
		/* --- GHIDRA: SetCurrentEvent ---
		int Gameplay_GdEvents_Control_GdEventsController__SetCurrentEvent(int *param1,undefined4 param2)
		
		{
		  int param1_00;
		  int iVar1;
		  uint *puVar2;
		  int iVar3;
		  int *param1_01;
		  int iVar4;
		  uint uVar5;
		  int param2_00;
		  int *piVar6;
		  
		  param2_00 = 0;
		  if (DAT_ram_00a5a30a == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_ICollection_GdEventData__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_AbstractGdEventCatData__Add__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_AbstractGdEventCatData___ctor__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_AbstractGdEventCatData__get_Count__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_AbstractGdEventCatData__get_Item__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_List_AbstractGdEventCatData__TypeInfo);
		    DAT_ram_00a5a30a = '\x01';
		  }
		  param1_00 = unnamed_function_1417
		                        (System_Collections_Generic_List_AbstractGdEventCatData__TypeInfo);
		  GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		            (param1_00,Method_System_Collections_Generic_List_AbstractGdEventCatData___ctor__);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  if (0 < *(int *)(*(int *)(iVar1 + 0x10) + 0xc)) {
		    do {
		      iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x104));
		      iVar1 = System_Linq_Enumerable__ToList_object_
		                        (*(undefined4 *)(iVar1 + 0x10),param2_00,
		                         Method_System_Collections_Generic_List_AbstractGdEventCatData__get_Item__);
		      param1_01 = *(int **)(iVar1 + 0xc);
		      iVar4 = *param1_01;
		      if (*(ushort *)(iVar4 + 0xb6) != 0) {
		        uVar5 = 0;
		        do {
		          piVar6 = (int *)(*(int *)(iVar4 + 0x58) + uVar5 * 8);
		          if (System_Collections_Generic_ICollection_GdEventData__TypeInfo == *piVar6) {
		            puVar2 = (uint *)(iVar4 + piVar6[1] * 8 + 0xc0);
		            goto code_r0x811ff2a3;
		          }
		          uVar5 = uVar5 + 1;
		        } while (*(ushort *)(iVar4 + 0xb6) != uVar5);
		      }
		      puVar2 = (uint *)func_ii_1080(param1_01,
		                                    System_Collections_Generic_ICollection_GdEventData__TypeInfo,0);
		code_r0x811ff2a3:
		      iVar3 = (**(code **)((ulonglong)*puVar2 * 4))(param1_01,puVar2[1]);
		      iVar4 = Method_System_Collections_Generic_List_AbstractGdEventCatData__Add__;
		      if (0 < iVar3) {
		        *(int *)(param1_00 + 0x10) = *(int *)(param1_00 + 0x10) + 1;
		        uVar5 = *(uint *)(param1_00 + 0xc);
		        if (uVar5 < *(uint *)(*(int *)(param1_00 + 8) + 0xc)) {
		          *(uint *)(param1_00 + 0xc) = uVar5 + 1;
		          *(int *)(*(int *)(param1_00 + 8) + uVar5 * 4 + 0x10) = iVar1;
		        }
		        else {
		          System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		                    (param1_00,iVar1,*(undefined4 *)(*(int *)(*(int *)(iVar4 + 0x10) + 0x60) + 0x38)
		                    );
		        }
		      }
		      param2_00 = param2_00 + 1;
		      iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x104));
		    } while (param2_00 < *(int *)(*(int *)(iVar1 + 0x10) + 0xc));
		  }
		  return param1_00;
		}
		*/

		}

		// Token: 0x06002D1B RID: 11547 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6002D1B")]
		[Address(RVA = "0x7D99", Offset = "0x7D99", VA = "0x7D99")]
		public List<AbstractGdEventCatData> GetCategories()
		{
		/* --- GHIDRA: GetCategories ---
		void Gameplay_GdEvents_Control_GdEventsController__GetCategories
		               (undefined4 param1,undefined4 param2,int param3,undefined4 param4)
		
		{
		  int *param3_00;
		  int iVar1;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a5a30b == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_GdEvents_Model_Milestone_MilestoneData___TypeInfo);
		    DAT_ram_00a5a30b = '\x01';
		  }
		  param3_00 = (int *)Mono_Security_ASN1Convert__ToOid
		                               (Gameplay_GdEvents_Model_Milestone_MilestoneData___TypeInfo,1);
		  if ((param3 != 0) && (iVar1 = func_ii_1082(param3,*(undefined4 *)(*param3_00 + 0x20)), iVar1 == 0)
		     ) {
		    param1_00 = func_ii_1083();
		    func_ii_1050(param1_00,0);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  param3_00[4] = param3;
		  Gameplay_GdEvents_Control_GdEventsController__HandleDictProviderChangeEvent
		            (param1,param2,param3_00,param3);
		  return;
		}
		*/

			return null;
		}

		// Token: 0x06002D1C RID: 11548 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002D1C")]
		[Address(RVA = "0x7D9A", Offset = "0x7D9A", VA = "0x7D9A")]
		public void RequestRewards(GdEventData evt, MilestoneData milestone)
		{
		/* --- GHIDRA: RequestRewards ---
		void Gameplay_GdEvents_Control_GdEventsController__RequestRewards
		               (undefined4 param1,undefined4 param2)
		
		{
		  Gameplay_GdEvents_Control_GdEventsController__HandleGetGameEventsRewardsInfoService
		            (param1,0,param1);
		  return;
		}
		*/

		/* --- GHIDRA: RequestRewards ---
		void Gameplay_GdEvents_Control_GdEventsController__RequestRewards
		               (undefined4 param1,undefined4 param2)
		
		{
		  Gameplay_GdEvents_Control_GdEventsController__HandleGetGameEventsRewardsInfoService
		            (param1,0,param1);
		  return;
		}
		*/

		}

		// Token: 0x06002D1D RID: 11549 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002D1D")]
		[Address(RVA = "0x7D9B", Offset = "0x7D9B", VA = "0x7D9B")]
		public void RequestRewards(GdEventData evt)
		{
		}

		// Token: 0x06002D1E RID: 11550 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002D1E")]
		[Address(RVA = "0x7D9C", Offset = "0x7D9C", VA = "0x7D9C")]
		public void ResetCurrentEvent()
		{
		/* --- GHIDRA: ResetCurrentEvent ---
		void Gameplay_GdEvents_Control_GdEventsController__ResetCurrentEvent(int *param1,undefined4 param2)
		
		{
		  uint uVar1;
		  int iVar2;
		  uint *puVar3;
		  int *param1_00;
		  
		  if (DAT_ram_00a5a30c == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_GdEvents_Model_IRewardProvider_TypeInfo);
		    DAT_ram_00a5a30c = '\x01';
		  }
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  param1_00 = *(int **)(iVar2 + 0x2c);
		  iVar2 = *param1_00;
		  if (*(ushort *)(iVar2 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Gameplay_GdEvents_Model_IRewardProvider_TypeInfo ==
		          *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(iVar2 + *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x811ff468;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(param1_00,Gameplay_GdEvents_Model_IRewardProvider_TypeInfo,0);
		code_r0x811ff468:
		  (**(code **)((ulonglong)*puVar3 * 4))(param1_00,puVar3[1]);
		  return;
		}
		*/

		}

		// Token: 0x06002D1F RID: 11551 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002D1F")]
		[Address(RVA = "0x7D9D", Offset = "0x7D9D", VA = "0x7D9D")]
		public void ResetRewards()
		{
		/* --- GHIDRA: ResetRewards ---
		void Gameplay_GdEvents_Control_GdEventsController__ResetRewards(undefined4 param1)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a5a30d == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_GdEvents_Control_GdEventsController___c_TypeInfo);
		    DAT_ram_00a5a30d = '\x01';
		  }
		  uVar1 = unnamed_function_1417(Gameplay_GdEvents_Control_GdEventsController___c_TypeInfo);
		  **(undefined4 **)(Gameplay_GdEvents_Control_GdEventsController___c_TypeInfo + 0x5c) = uVar1;
		  return;
		}
		*/

		}
	}
}
