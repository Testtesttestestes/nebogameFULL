using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Gameplay.GameEvents.Model.ActionsOnEvents;
using Gameplay.GameEvents.View.ActionsOnEvens;
using Il2CppDummyDll;
using Protocol.Dic;
using UnityEngine;

namespace Gameplay.GameEvents.View
{
	// Token: 0x02000775 RID: 1909
	[Token(Token = "0x2000775")]
	public class ActionsOnEventBox : MonoBehaviour
	{
		// Token: 0x14000164 RID: 356
		// (add) Token: 0x06002D7F RID: 11647 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06002D80 RID: 11648 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000164")]
		public event EventHandler<AbstractActionOnEvent> OnActionTriggeredEvent
		{
			[Token(Token = "0x6002D7F")]
			[Address(RVA = "0x7DFD", Offset = "0x7DFD", VA = "0x7DFD")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6002D80")]
			[Address(RVA = "0x7DFE", Offset = "0x7DFE", VA = "0x7DFE")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x06002D81 RID: 11649 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6002D81")]
		[Address(RVA = "0x7DFF", Offset = "0x7DFF", VA = "0x7DFF")]
		public ActionsOnEventBox.ActionsPrefabConfig GetConfig(EventActionDic.Types.BehaviorTypes type)
		{
		/* --- GHIDRA: GetConfig ---
		undefined4
		Gameplay_GameEvents_View_ActionsOnEventBox__GetConfig(int param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  int iVar2;
		  int iVar3;
		  
		  iVar2 = *(int *)(*(int *)(param1 + 0x14) + 0xc);
		  if (0 < iVar2) {
		    iVar1 = 0;
		    do {
		      iVar3 = *(int *)(*(int *)(param1 + 0x14) + iVar1 * 4 + 0x10);
		      if (*(int *)(iVar3 + 8) == param2) {
		        return iVar3;
		      }
		      iVar1 = iVar1 + 1;
		    } while (iVar1 != iVar2);
		  }
		  return 0;
		}
		*/

			return null;
		}

		// Token: 0x06002D82 RID: 11650 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6002D82")]
		[Address(RVA = "0x7E00", Offset = "0x7E00", VA = "0x7E00")]
		public ActionsOnEventBox.ActionViewPlaceHolder GetPlaceHolder(EventActionDic.Types.BehaviorTypes type)
		{
			return null;
		}

		// Token: 0x170008BA RID: 2234
		// (get) Token: 0x06002D83 RID: 11651 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06002D84 RID: 11652 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170008BA")]
		public List<AbstractActionOnEvent> ActionsOnEvent
		{
			[Token(Token = "0x6002D83")]
			[Address(RVA = "0x7E01", Offset = "0x7E01", VA = "0x7E01")]
			get
			{
				return null;
			}
			[Token(Token = "0x6002D84")]
			[Address(RVA = "0x7E02", Offset = "0x7E02", VA = "0x7E02")]
			set
			{
			}
		}

		// Token: 0x06002D85 RID: 11653 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002D85")]
		[Address(RVA = "0x7E03", Offset = "0x7E03", VA = "0x7E03")]
		private void handleActionOnEventChanged()
		{
		/* --- GHIDRA: handleActionOnEventChanged ---
		void Gameplay_GameEvents_View_ActionsOnEventBox__handleActionOnEventChanged
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  int iVar1;
		  
		  if (DAT_ram_00a57485 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_GameEvents_View_ActionsOnEvens_AbstractActionOnEventView_TypeInfo);
		    DAT_ram_00a57485 = '\x01';
		  }
		  iVar1 = *(int *)(param1 + 0x18);
		  if (iVar1 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		              (*(undefined4 *)(iVar1 + 0x20),param1,param3,*(undefined4 *)(iVar1 + 0x14));
		  }
		  return;
		}
		*/

		}

		// Token: 0x06002D86 RID: 11654 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002D86")]
		[Address(RVA = "0x7E04", Offset = "0x7E04", VA = "0x7E04")]
		private void HandleOnTriggeredEvent(object sender, AbstractActionOnEvent data)
		{
		}

		// Token: 0x06002D87 RID: 11655 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002D87")]
		[Address(RVA = "0x7E05", Offset = "0x7E05", VA = "0x7E05")]
		public ActionsOnEventBox()
		{
		}

		// Token: 0x040018E1 RID: 6369
		[Token(Token = "0x40018E1")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private ActionsOnEventBox.ActionsPrefabConfig[] _viewPrefabs;

		// Token: 0x040018E2 RID: 6370
		[Token(Token = "0x40018E2")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private ActionsOnEventBox.ActionViewPlaceHolder[] _actionViewsPlaceholders;

		// Token: 0x040018E4 RID: 6372
		[Token(Token = "0x40018E4")]
		[FieldOffset(Offset = "0x1C")]
		public List<AbstractActionOnEvent> _actionsOnEvent;

		// Token: 0x02000776 RID: 1910
		[Token(Token = "0x2000776")]
		[Serializable]
		public class ActionsPrefabConfig
		{
			// Token: 0x06002D88 RID: 11656 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6002D88")]
			[Address(RVA = "0x7E06", Offset = "0x7E06", VA = "0x7E06")]
			public ActionsPrefabConfig()
			{
			}

			// Token: 0x040018E5 RID: 6373
			[Token(Token = "0x40018E5")]
			[FieldOffset(Offset = "0x8")]
			public EventActionDic.Types.BehaviorTypes BehaviorType;

			// Token: 0x040018E6 RID: 6374
			[Token(Token = "0x40018E6")]
			[FieldOffset(Offset = "0xC")]
			public AbstractActionOnEventView ViewPrefab;
		}

		// Token: 0x02000777 RID: 1911
		[Token(Token = "0x2000777")]
		[Serializable]
		public class ActionViewPlaceHolder
		{
			// Token: 0x06002D89 RID: 11657 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6002D89")]
			[Address(RVA = "0x7E07", Offset = "0x7E07", VA = "0x7E07")]
			public ActionViewPlaceHolder()
			{
			}

			// Token: 0x040018E7 RID: 6375
			[Token(Token = "0x40018E7")]
			[FieldOffset(Offset = "0x8")]
			public EventActionDic.Types.BehaviorTypes BehaviorType;

			// Token: 0x040018E8 RID: 6376
			[Token(Token = "0x40018E8")]
			[FieldOffset(Offset = "0xC")]
			public Transform Parent;
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: add_OnActionTriggeredEvent ---
		void Gameplay_GameEvents_View_ActionsOnEventBox__add_OnActionTriggeredEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a57483 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_EventHandler_AbstractActionOnEvent__TypeInfo);
		    DAT_ram_00a57483 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x18);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_EventHandler_AbstractActionOnEvent__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_EventHandler_AbstractActionOnEvent__TypeInfo),
		       iVar2 == 0)) break;
		    iVar2 = func_ii_4329(param1 + 0x18,iVar2,param1_00);
		    bVar1 = iVar2 == param1_00;
		    param1_00 = iVar2;
		    if (bVar1) {
		      return;
		    }
		  }
		  System_Activator__CreateInstance(param1_01,param2_00);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/


		/* --- GHIDRA: remove_OnActionTriggeredEvent ---
		undefined4
		Gameplay_GameEvents_View_ActionsOnEventBox__remove_OnActionTriggeredEvent
		          (int param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  int iVar2;
		  int iVar3;
		  
		  iVar2 = *(int *)(*(int *)(param1 + 0x10) + 0xc);
		  if (0 < iVar2) {
		    iVar1 = 0;
		    do {
		      iVar3 = *(int *)(*(int *)(param1 + 0x10) + iVar1 * 4 + 0x10);
		      if (*(int *)(iVar3 + 8) == param2) {
		        return iVar3;
		      }
		      iVar1 = iVar1 + 1;
		    } while (iVar1 != iVar2);
		  }
		  return 0;
		}
		*/


		/* --- GHIDRA: get_ActionsOnEvent ---
		void Gameplay_GameEvents_View_ActionsOnEventBox__get_ActionsOnEvent
		               (int param1,int param2,undefined4 param3)
		
		{
		  if (param2 != *(int *)(param1 + 0x1c)) {
		    *(int *)(param1 + 0x1c) = param2;
		    Gameplay_GameEvents_View_ActionsOnEventBox__set_ActionsOnEvent(param1,param1);
		  }
		  return;
		}
		*/


		/* --- GHIDRA: set_ActionsOnEvent ---
		void Gameplay_GameEvents_View_ActionsOnEventBox__set_ActionsOnEvent(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  int iVar2;
		  undefined4 uVar3;
		  int *piVar4;
		  int iVar5;
		  int iVar6;
		  undefined4 param3;
		  int iVar7;
		  int iVar8;
		  int local_20;
		  undefined1 *puStack_1c;
		  undefined8 local_18;
		  undefined1 local_10 [8];
		  undefined8 local_8;
		  
		  if (DAT_ram_00a57484 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_GameEvents_View_ActionsOnEventBox_HandleOnTriggeredEvent__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_AbstractActionOnEvent__Dispose__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_AbstractActionOnEvent__MoveNext__)
		    ;
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_Enumerator_AbstractActionOnEvent__get_Current__
		              );
		    Mono_Security_ASN1__get_Item(&System_EventHandler_AbstractActionOnEvent__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_AbstractActionOnEvent__GetEnumerator__);
		    Mono_Security_ASN1__get_Item
		              (&Method_UnityEngine_Object_Instantiate_AbstractActionOnEventView___);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    DAT_ram_00a57484 = '\x01';
		  }
		  System_Collections_Generic_List_RegexCharClass_SingleRange___ForEach
		            (&local_20,*(undefined4 *)(param1 + 0x1c),
		             Method_System_Collections_Generic_List_AbstractActionOnEvent__GetEnumerator__);
		  local_8 = local_18;
		  local_20 = 0;
		  puStack_1c = local_10;
		code_r0x80d8d29e:
		  do {
		    do {
		      DAT_ram_009d3e38 = 0;
		      iVar2 = import::env::invoke_iii
		                        (s_struct_Uniforms___color__array<v_ram_00000aff + 0x44,local_10,
		                         Method_System_Collections_Generic_List_Enumerator_AbstractActionOnEvent__MoveNext__
		                        );
		      iVar1 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar1 == 1) {
		        uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x80d8d523;
		      }
		      if (iVar2 == 0) {
		        DAT_ram_009d3e38 = 0;
		        return;
		      }
		      iVar1 = local_8._4_4_;
		      iVar5 = *(int *)(*(int *)(local_8._4_4_ + 8) + 0x10);
		      iVar2 = 0;
		      iVar6 = *(int *)(*(int *)(param1 + 0x10) + 0xc);
		    } while (iVar6 < 1);
		    while (iVar7 = *(int *)(*(int *)(param1 + 0x10) + iVar2 * 4 + 0x10),
		          iVar5 != *(int *)(iVar7 + 8)) {
		      iVar2 = iVar2 + 1;
		      if (iVar2 == iVar6) goto code_r0x80d8d29e;
		    }
		    iVar2 = 0;
		    iVar6 = *(int *)(*(int *)(param1 + 0x14) + 0x10);
		    iVar8 = *(int *)(iVar6 + 8);
		    while (iVar5 != iVar8) {
		      iVar2 = iVar2 + 1;
		      iVar6 = *(int *)(*(int *)(param1 + 0x14) + iVar2 * 4 + 0x10);
		      iVar8 = *(int *)(iVar6 + 8);
		    }
		    uVar3 = *(undefined4 *)(iVar7 + 0xc);
		    param3 = *(undefined4 *)(iVar6 + 0xc);
		    if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_vi
		                (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x180,UnityEngine_Object_TypeInfo
		                );
		      iVar2 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar2 == 1) {
		        uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x80d8d523;
		      }
		    }
		    DAT_ram_009d3e38 = 0;
		    piVar4 = (int *)import::env::invoke_iiii
		                              (s_struct_Uniforms___color__array<v_ram_000017c8 + 0x2ce,uVar3,param3,
		                               Method_UnityEngine_Object_Instantiate_AbstractActionOnEventView___);
		    iVar2 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar2 == 1) {
		      uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x80d8d523:
		      iVar1 = global_1;
		      iVar2 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		      if (iVar1 == iVar2) {
		        piVar4 = (int *)import::env::__cxa_begin_catch(uVar3);
		        iVar2 = *piVar4;
		        DAT_ram_009d3e38 = 0;
		        local_20 = iVar2;
		        import::env::invoke_v(0x123);
		        iVar1 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar1 != 1) {
		          if (iVar2 == 0) {
		            DAT_ram_009d3e38 = 0;
		            return;
		          }
		          System_Data_DataSet__ValidateLocaleConstraint(iVar2);
		          do {
		            halt_trap();
		          } while( true );
		        }
		        uVar3 = import::env::__cxa_find_matching_catch_2();
		      }
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_000017c8 + 0x2d0,&local_20);
		      iVar1 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar1 == 1) {
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
		    if (iVar1 != piVar4[5]) {
		      piVar4[5] = iVar1;
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_vii
		                (*(undefined4 *)(*piVar4 + 0xe8),piVar4,*(undefined4 *)(*piVar4 + 0xec));
		      iVar1 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar1 == 1) {
		        uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x80d8d523;
		      }
		    }
		    DAT_ram_009d3e38 = 0;
		    uVar3 = import::env::invoke_ii
		                      (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x199,
		                       System_EventHandler_AbstractActionOnEvent__TypeInfo);
		    if (DAT_ram_009d3e38 == 1) break;
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_viiii
		              (s_struct_Uniforms___color__array<v_ram_000017c8 + 0x2cf,uVar3,param1,
		               Method_Gameplay_GameEvents_View_ActionsOnEventBox_HandleOnTriggeredEvent__,0);
		    if (DAT_ram_009d3e38 == 1) break;
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_viii
		              (*(undefined4 *)(*piVar4 + 0xe0),piVar4,uVar3,*(undefined4 *)(*piVar4 + 0xe4));
		  } while (DAT_ram_009d3e38 != 1);
		  DAT_ram_009d3e38 = 0;
		  uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		  goto code_r0x80d8d523;
		}
		*/

}
