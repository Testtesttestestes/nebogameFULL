using System;
using System.Collections.Generic;
using Core.Data;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

namespace Gameplay.Inventory.View.Info.InfoBox
{
	// Token: 0x02000673 RID: 1651
	[Token(Token = "0x2000673")]
	public class ArtifactNotesView : MonoBehaviour
	{
		// Token: 0x06002800 RID: 10240 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002800")]
		[Address(RVA = "0x7925", Offset = "0x7925", VA = "0x7925")]
		private void Awake()
		{
		}

		// Token: 0x17000796 RID: 1942
		// (get) Token: 0x06002801 RID: 10241 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06002802 RID: 10242 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000796")]
		public ArtifactData ArtifactData
		{
			[Token(Token = "0x6002801")]
			[Address(RVA = "0x7926", Offset = "0x7926", VA = "0x7926")]
			get
			{
				return null;
			}
			[Token(Token = "0x6002802")]
			[Address(RVA = "0x7927", Offset = "0x7927", VA = "0x7927")]
			set
			{
			}
		}

		// Token: 0x06002803 RID: 10243 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002803")]
		[Address(RVA = "0x7928", Offset = "0x7928", VA = "0x7928")]
		private void OnEnable()
		{
		/* --- GHIDRA: OnEnable ---
		void Gameplay_Inventory_View_Info_InfoBox_ArtifactNotesView__OnEnable(int param1,undefined4 param2)
		
		{
		  if (*(int *)(param1 + 0x34) != 0) {
		    Gameplay_Inventory_View_Info_InfoBox_ArtifactNotesView__StartListenEvents
		              (param1,*(int *)(param1 + 0x34),param1);
		  }
		  return;
		}
		*/

		}

		// Token: 0x06002804 RID: 10244 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002804")]
		[Address(RVA = "0x7929", Offset = "0x7929", VA = "0x7929")]
		private void OnDisable()
		{
		/* --- GHIDRA: OnDisable ---
		void Gameplay_Inventory_View_Info_InfoBox_ArtifactNotesView__OnDisable
		               (undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a5a0cc == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Inventory_View_Info_InfoBox_ArtifactNotesView_ArtifactDataOnIsFavoriteChangedEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Inventory_View_Info_InfoBox_ArtifactNotesView_ArtifactDataOnIsFreshChangedEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Inventory_View_Info_InfoBox_ArtifactNotesView_ArtifactDataOnIsFreshWatchedChangedEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Inventory_View_Info_InfoBox_ArtifactNotesView_ArtifactDataOnIsMostPowerfulChangedEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Inventory_View_Info_InfoBox_ArtifactNotesView_ArtifactDataOnSlotIdChangedEvent__
		              );
		    DAT_ram_00a5a0cc = '\x01';
		  }
		  uVar1 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar1,param1,
		             Method_Gameplay_Inventory_View_Info_InfoBox_ArtifactNotesView_ArtifactDataOnIsFavoriteChangedEvent__
		             ,0);
		  Core_Dev_LaunchLevelPlayTestSuite___ctor(param2,uVar1,0);
		  uVar1 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar1,param1,
		             Method_Gameplay_Inventory_View_Info_InfoBox_ArtifactNotesView_ArtifactDataOnIsFreshChangedEvent__
		             ,0);
		  Core_Data_ArtifactData__remove_IsFavoriteChangedEvent(param2,uVar1,0);
		  uVar1 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar1,param1,
		             Method_Gameplay_Inventory_View_Info_InfoBox_ArtifactNotesView_ArtifactDataOnIsFreshWatchedChangedEvent__
		             ,0);
		  Core_Data_ArtifactData__remove_IsFreshChangedEvent(param2,uVar1,0);
		  uVar1 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar1,param1,
		             Method_Gameplay_Inventory_View_Info_InfoBox_ArtifactNotesView_ArtifactDataOnIsMostPowerfulChangedEvent__
		             ,0);
		  Core_Data_ArtifactData__remove_ArtifactInfoChangedEvent(param2,uVar1,0);
		  uVar1 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar1,param1,
		             Method_Gameplay_Inventory_View_Info_InfoBox_ArtifactNotesView_ArtifactDataOnSlotIdChangedEvent__
		             ,0);
		  Core_Data_ArtifactData__remove_IsMostPowerfulChangedEvent(param2,uVar1,0);
		  return;
		}
		*/

		}

		// Token: 0x06002805 RID: 10245 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002805")]
		[Address(RVA = "0x792A", Offset = "0x792A", VA = "0x792A")]
		private void StartListenEvents(ArtifactData artifact)
		{
		/* --- GHIDRA: StartListenEvents ---
		void Gameplay_Inventory_View_Info_InfoBox_ArtifactNotesView__StartListenEvents
		               (undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a5a0cd == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Inventory_View_Info_InfoBox_ArtifactNotesView_ArtifactDataOnIsFavoriteChangedEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Inventory_View_Info_InfoBox_ArtifactNotesView_ArtifactDataOnIsFreshChangedEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Inventory_View_Info_InfoBox_ArtifactNotesView_ArtifactDataOnIsFreshWatchedChangedEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Inventory_View_Info_InfoBox_ArtifactNotesView_ArtifactDataOnIsMostPowerfulChangedEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Inventory_View_Info_InfoBox_ArtifactNotesView_ArtifactDataOnSlotIdChangedEvent__
		              );
		    DAT_ram_00a5a0cd = '\x01';
		  }
		  uVar1 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar1,param1,
		             Method_Gameplay_Inventory_View_Info_InfoBox_ArtifactNotesView_ArtifactDataOnIsFavoriteChangedEvent__
		             ,0);
		  Core_Data_ArtifactData__add_IsFavoriteChangedEvent(param2,uVar1,0);
		  uVar1 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar1,param1,
		             Method_Gameplay_Inventory_View_Info_InfoBox_ArtifactNotesView_ArtifactDataOnIsFreshChangedEvent__
		             ,0);
		  Core_Data_ArtifactData__add_IsFreshChangedEvent(param2,uVar1,0);
		  uVar1 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar1,param1,
		             Method_Gameplay_Inventory_View_Info_InfoBox_ArtifactNotesView_ArtifactDataOnIsFreshWatchedChangedEvent__
		             ,0);
		  Core_Data_ArtifactData__add_IsFreshWatchedChangedEvent(param2,uVar1,0);
		  uVar1 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar1,param1,
		             Method_Gameplay_Inventory_View_Info_InfoBox_ArtifactNotesView_ArtifactDataOnIsMostPowerfulChangedEvent__
		             ,0);
		  Core_Data_ArtifactData__add_IsMostPowerfulChangedEvent(param2,uVar1,0);
		  uVar1 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar1,param1,
		             Method_Gameplay_Inventory_View_Info_InfoBox_ArtifactNotesView_ArtifactDataOnSlotIdChangedEvent__
		             ,0);
		  Core_Data_ArtifactData__add_SlotIdChangedEvent(param2,uVar1,0);
		  return;
		}
		*/

		}

		// Token: 0x06002806 RID: 10246 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002806")]
		[Address(RVA = "0x792B", Offset = "0x792B", VA = "0x792B")]
		private void StopListenEvents(ArtifactData artifact)
		{
		}

		// Token: 0x06002807 RID: 10247 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002807")]
		[Address(RVA = "0x792C", Offset = "0x792C", VA = "0x792C")]
		private void ArtifactDataOnIsMostPowerfulChangedEvent()
		{
		}

		// Token: 0x06002808 RID: 10248 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002808")]
		[Address(RVA = "0x792D", Offset = "0x792D", VA = "0x792D")]
		private void ArtifactDataOnSlotIdChangedEvent()
		{
		}

		// Token: 0x06002809 RID: 10249 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002809")]
		[Address(RVA = "0x792E", Offset = "0x792E", VA = "0x792E")]
		private void ArtifactDataOnIsFreshChangedEvent()
		{
		}

		// Token: 0x0600280A RID: 10250 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600280A")]
		[Address(RVA = "0x792F", Offset = "0x792F", VA = "0x792F")]
		private void ArtifactDataOnIsFreshWatchedChangedEvent()
		{
		/* --- GHIDRA: ArtifactDataOnIsFreshWatchedChangedEvent ---
		void Gameplay_Inventory_View_Info_InfoBox_ArtifactNotesView__ArtifactDataOnIsFreshWatchedChangedEvent
		               (undefined4 param1,undefined4 param2)
		
		{
		  Gameplay_Inventory_View_Info_InfoBox_ArtifactNotesView__ArtifactDataOnIsFavoriteChangedEvent
		            (param1,param1);
		  return;
		}
		*/

		}

		// Token: 0x0600280B RID: 10251 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600280B")]
		[Address(RVA = "0x7930", Offset = "0x7930", VA = "0x7930")]
		private void ArtifactDataOnIsFavoriteChangedEvent()
		{
		/* --- GHIDRA: ArtifactDataOnIsFavoriteChangedEvent ---
		void Gameplay_Inventory_View_Info_InfoBox_ArtifactNotesView__ArtifactDataOnIsFavoriteChangedEvent
		               (int param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  int *piVar3;
		  undefined4 uVar4;
		  int iVar5;
		  int local_20;
		  undefined8 *puStack_1c;
		  undefined8 local_18;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a5a0ce == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_ArtifactNoteView__Dispose__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_ArtifactNoteView__MoveNext__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_ArtifactNoteView__get_Current__);
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_ArtifactNoteView__Clear__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_ArtifactNoteView__GetEnumerator__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_ArtifactNoteView__get_Count__);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_2648);
		    Mono_Security_ASN1__get_Item(&StringLiteral_2647);
		    Mono_Security_ASN1__get_Item(&StringLiteral_2646);
		    Mono_Security_ASN1__get_Item(&StringLiteral_2649);
		    DAT_ram_00a5a0ce = '\x01';
		  }
		  local_8 = 0;
		  local_10 = 0;
		  System_Collections_Generic_List_RegexCharClass_SingleRange___ForEach
		            (&local_20,*(undefined4 *)(param1 + 0x30),
		             Method_System_Collections_Generic_List_ArtifactNoteView__GetEnumerator__);
		  local_8 = local_18;
		  local_20 = 0;
		  puStack_1c = &local_10;
		  do {
		    DAT_ram_009d3e38 = 0;
		    iVar1 = import::env::invoke_iii
		                      (s_struct_Uniforms___color__array<v_ram_00000aff + 0x44,&local_10,
		                       Method_System_Collections_Generic_List_Enumerator_ArtifactNoteView__MoveNext__
		                      );
		    iVar5 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar5 == 1) {
		      uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x811c50dd;
		    }
		    if (iVar1 == 0) goto code_r0x811c5133;
		    DAT_ram_009d3e38 = 0;
		    uVar2 = import::env::invoke_iii
		                      (s_struct_Uniforms___color__array<v_ram_00000aff + 0x25c,local_8._4_4_,0);
		    if (DAT_ram_009d3e38 == 1) break;
		    if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_vi
		                (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x180,UnityEngine_Object_TypeInfo
		                );
		      if (DAT_ram_009d3e38 == 1) break;
		    }
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_vii(s_struct_Uniforms___color__array<v_ram_00000aff + 0x274,uVar2,0);
		  } while (DAT_ram_009d3e38 != 1);
		  DAT_ram_009d3e38 = 0;
		  uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x811c50dd:
		  iVar5 = global_1;
		  iVar1 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar5 == iVar1) {
		    piVar3 = (int *)import::env::__cxa_begin_catch(uVar2);
		    iVar1 = *piVar3;
		    DAT_ram_009d3e38 = 0;
		    local_20 = iVar1;
		    import::env::invoke_v(0x123);
		    iVar5 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar5 != 1) {
		      if (iVar1 != 0) {
		        System_Data_DataSet__ValidateLocaleConstraint(iVar1);
		        do {
		          halt_trap();
		        } while( true );
		      }
		code_r0x811c5133:
		      DAT_ram_009d3e38 = 0;
		      iVar5 = *(int *)(param1 + 0x30);
		      iVar1 = *(int *)(iVar5 + 0xc);
		      *(undefined4 *)(iVar5 + 0xc) = 0;
		      *(int *)(iVar5 + 0x10) = *(int *)(iVar5 + 0x10) + 1;
		      if (0 < iVar1) {
		        func_ii_2064(*(undefined4 *)(iVar5 + 8),0,iVar1,0);
		      }
		      iVar5 = *(int *)(param1 + 0x34);
		      if (iVar5 != 0) {
		        if (*(char *)(iVar5 + 0x78) != '\0') {
		          uVar2 = *(undefined4 *)(param1 + 0x20);
		          if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		            func_ii_306000(Core_GameLocalization_TypeInfo);
		          }
		          uVar4 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_2647,1,0,1,0,0,0,0);
		          Gameplay_Inventory_View_Info_InfoBox_ArtifactNotesView__RenderView
		                    (param1,uVar2,uVar4,&local_20);
		          iVar5 = *(int *)(param1 + 0x34);
		        }
		        if (*(char *)(iVar5 + 0x79) != '\0') {
		          uVar2 = *(undefined4 *)(param1 + 0x28);
		          if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		            func_ii_306000(Core_GameLocalization_TypeInfo);
		          }
		          uVar4 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_2648,1,0,1,0,0,0,0);
		          Gameplay_Inventory_View_Info_InfoBox_ArtifactNotesView__RenderView
		                    (param1,uVar2,uVar4,&local_20);
		          iVar5 = *(int *)(param1 + 0x34);
		        }
		        if (*(char *)(iVar5 + 0x68) != '\0') {
		          uVar2 = *(undefined4 *)(param1 + 0x24);
		          if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		            func_ii_306000(Core_GameLocalization_TypeInfo);
		          }
		          uVar4 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_2649,1,0,1,0,0,0,0);
		          Gameplay_Inventory_View_Info_InfoBox_ArtifactNotesView__RenderView
		                    (param1,uVar2,uVar4,&local_20);
		          iVar5 = *(int *)(param1 + 0x34);
		        }
		        iVar5 = Gameplay_Inventory_Model_ArtifactDataUtils__IsInBag(iVar5,0);
		        if (iVar5 != 0) {
		          uVar2 = *(undefined4 *)(param1 + 0x2c);
		          if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		            func_ii_306000(Core_GameLocalization_TypeInfo);
		          }
		          uVar4 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_2646,1,0,1,0,0,0,0);
		          Gameplay_Inventory_View_Info_InfoBox_ArtifactNotesView__RenderView
		                    (param1,uVar2,uVar4,&local_20);
		        }
		      }
		      uVar2 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                        (*(undefined4 *)(param1 + 0x18),0);
		      Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		                (uVar2,(uint)(0 < *(int *)(*(int *)(param1 + 0x30) + 0xc)),0);
		      return;
		    }
		    uVar2 = import::env::__cxa_find_matching_catch_2();
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001f04 + 0x248,&local_20);
		  iVar5 = DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = 0;
		  if (iVar5 == 1) {
		    import::env::__cxa_find_matching_catch_3(0);
		    unnamed_function_937();
		    do {
		      halt_trap();
		    } while( true );
		  }
		  import::env::__resumeException(uVar2);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x0600280C RID: 10252 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600280C")]
		[Address(RVA = "0x7931", Offset = "0x7931", VA = "0x7931")]
		private void RenderView()
		{
		/* --- GHIDRA: RenderView ---
		void Gameplay_Inventory_View_Info_InfoBox_ArtifactNotesView__RenderView
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  int param2_00;
		  undefined4 param2_01;
		  undefined4 param1_00;
		  int param1_01;
		  uint uVar1;
		  int iVar2;
		  
		  if (DAT_ram_00a5a0cf == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_ArtifactNoteView__Add__);
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Object_Instantiate_ArtifactNoteView___);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    DAT_ram_00a5a0cf = '\x01';
		  }
		  param2_01 = *(undefined4 *)(param1 + 0x1c);
		  param1_00 = *(undefined4 *)(param1 + 0x10);
		  if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		    func_ii_306000(UnityEngine_Object_TypeInfo);
		  }
		  param2_00 = func_ii_6805(param1_00,param2_01,
		                           Method_UnityEngine_Object_Instantiate_ArtifactNoteView___);
		  func_ii_7050(*(undefined4 *)(param2_00 + 0x10),param2,0);
		  iVar2 = **(int **)(param2_00 + 0x10);
		  (**(code **)((ulonglong)*(uint *)(iVar2 + 0x228) * 4))
		            (*(int **)(param2_00 + 0x10),*(undefined4 *)(iVar2 + 0x22c));
		  iVar2 = **(int **)(param2_00 + 0x14);
		  (**(code **)((ulonglong)*(uint *)(iVar2 + 0x2d0) * 4))
		            (*(int **)(param2_00 + 0x14),param3,*(undefined4 *)(iVar2 + 0x2d4));
		  iVar2 = Method_System_Collections_Generic_List_ArtifactNoteView__Add__;
		  param1_01 = *(int *)(param1 + 0x30);
		  *(int *)(param1_01 + 0x10) = *(int *)(param1_01 + 0x10) + 1;
		  uVar1 = *(uint *)(param1_01 + 0xc);
		  if (uVar1 < *(uint *)(*(int *)(param1_01 + 8) + 0xc)) {
		    *(uint *)(param1_01 + 0xc) = uVar1 + 1;
		    *(int *)(*(int *)(param1_01 + 8) + uVar1 * 4 + 0x10) = param2_00;
		    return;
		  }
		  System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		            (param1_01,param2_00,*(undefined4 *)(*(int *)(*(int *)(iVar2 + 0x10) + 0x60) + 0x38));
		  return;
		}
		*/

		}

		// Token: 0x0600280D RID: 10253 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600280D")]
		[Address(RVA = "0x7932", Offset = "0x7932", VA = "0x7932")]
		private void AddNote(Sprite icon, string text)
		{
		/* --- GHIDRA: AddNote ---
		void Gameplay_Inventory_View_Info_InfoBox_ArtifactNotesView__AddNote(int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a5a0d0 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_ArtifactNoteView___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_List_ArtifactNoteView__TypeInfo);
		    DAT_ram_00a5a0d0 = '\x01';
		  }
		  param1_00 = unnamed_function_1417(System_Collections_Generic_List_ArtifactNoteView__TypeInfo);
		  GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		            (param1_00,Method_System_Collections_Generic_List_ArtifactNoteView___ctor__);
		  *(undefined4 *)(param1 + 0x30) = param1_00;
		  UnityEngine_RectTransform__GetParentSize(param1,0);
		  return;
		}
		*/

		}

		// Token: 0x0600280E RID: 10254 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600280E")]
		[Address(RVA = "0x7933", Offset = "0x7933", VA = "0x7933")]
		public ArtifactNotesView()
		{
		}

		// Token: 0x04001603 RID: 5635
		[Token(Token = "0x4001603")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private ArtifactNoteView _noteViewPrefab;

		// Token: 0x04001604 RID: 5636
		[Token(Token = "0x4001604")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private TextMeshProUGUI _title;

		// Token: 0x04001605 RID: 5637
		[Token(Token = "0x4001605")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Transform _content;

		// Token: 0x04001606 RID: 5638
		[Token(Token = "0x4001606")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private Transform _notesCont;

		// Token: 0x04001607 RID: 5639
		[Token(Token = "0x4001607")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Sprite _favIcon;

		// Token: 0x04001608 RID: 5640
		[Token(Token = "0x4001608")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private Sprite _bestIcon;

		// Token: 0x04001609 RID: 5641
		[Token(Token = "0x4001609")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Sprite _freshIcon;

		// Token: 0x0400160A RID: 5642
		[Token(Token = "0x400160A")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private Sprite _equippedIcon;

		// Token: 0x0400160B RID: 5643
		[Token(Token = "0x400160B")]
		[FieldOffset(Offset = "0x30")]
		private List<ArtifactNoteView> _notes;

		// Token: 0x0400160C RID: 5644
		[Token(Token = "0x400160C")]
		[FieldOffset(Offset = "0x34")]
		private ArtifactData _artifactData;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_ArtifactData ---
		void Gameplay_Inventory_View_Info_InfoBox_ArtifactNotesView__get_ArtifactData
		               (int param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  int param2_00;
		  
		  param2_00 = *(int *)(param1 + 0x34);
		  if (param2_00 != param2) {
		    *(int *)(param1 + 0x34) = param2;
		    iVar1 = func_ii_12174(param1,0);
		    if (iVar1 != 0) {
		      if (param2_00 != 0) {
		        Gameplay_Inventory_View_Info_InfoBox_ArtifactNotesView__StartListenEvents
		                  (param1,param2_00,param1);
		      }
		      if (*(int *)(param1 + 0x34) != 0) {
		        Gameplay_Inventory_View_Info_InfoBox_ArtifactNotesView__OnDisable
		                  (param1,*(int *)(param1 + 0x34),param1);
		      }
		      Gameplay_Inventory_View_Info_InfoBox_ArtifactNotesView__ArtifactDataOnIsFavoriteChangedEvent
		                (param1,param1);
		    }
		  }
		  return;
		}
		*/


		/* --- GHIDRA: set_ArtifactData ---
		void Gameplay_Inventory_View_Info_InfoBox_ArtifactNotesView__set_ArtifactData
		               (int param1,undefined4 param2)
		
		{
		  Gameplay_Inventory_View_Info_InfoBox_ArtifactNotesView__ArtifactDataOnIsFavoriteChangedEvent
		            (param1,param1);
		  if (*(int *)(param1 + 0x34) != 0) {
		    Gameplay_Inventory_View_Info_InfoBox_ArtifactNotesView__OnDisable
		              (param1,*(int *)(param1 + 0x34),param1);
		  }
		  return;
		}
		*/

}
