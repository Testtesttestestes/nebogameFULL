using System;
using System.Collections.Generic;
using Coffee.UISoftMask;
using Gameplay.Tutorial.Guide.View.Components;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Pool;

namespace Gameplay.TutorialV2.Controller
{
	// Token: 0x02000434 RID: 1076
	[Token(Token = "0x2000434")]
	public class CombatOverlapQueue : TutorialStepsQueueBase
	{
		// Token: 0x0600196E RID: 6510 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600196E")]
		[Address(RVA = "0x6B0D", Offset = "0x6B0D", VA = "0x6B0D")]
		public CombatOverlapQueue(ShapePointer overlap, ObjectPool<MaskingShape> shapesPool, IEnumerable<CombatOverlapQueue.Item> queue)
		{
		}

		// Token: 0x17000480 RID: 1152
		// (get) Token: 0x0600196F RID: 6511 RVA: 0x000058C8 File Offset: 0x00003AC8
		[Token(Token = "0x17000480")]
		public override StepActionType StepActionType
		{
			[Token(Token = "0x600196F")]
			[Address(RVA = "0x6B0E", Offset = "0x6B0E", VA = "0x6B0E", Slot = "4")]
			get
			{
				return StepActionType.None;
			}
		}

		// Token: 0x06001970 RID: 6512 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001970")]
		[Address(RVA = "0x6B0F", Offset = "0x6B0F", VA = "0x6B0F", Slot = "5")]
		protected override void ShowNextInternal(StepActionType actionType)
		{
		}

		// Token: 0x06001971 RID: 6513 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001971")]
		[Address(RVA = "0x6B10", Offset = "0x6B10", VA = "0x6B10", Slot = "6")]
		public override void Hide()
		{
		}

		// Token: 0x04000D83 RID: 3459
		[Token(Token = "0x4000D83")]
		[FieldOffset(Offset = "0x8")]
		private readonly ShapePointer _overlap;

		// Token: 0x04000D84 RID: 3460
		[Token(Token = "0x4000D84")]
		[FieldOffset(Offset = "0xC")]
		private readonly Queue<CombatOverlapQueue.Item> _queue;

		// Token: 0x04000D85 RID: 3461
		[Token(Token = "0x4000D85")]
		[FieldOffset(Offset = "0x10")]
		private readonly ObjectPool<MaskingShape> _shapesPool;

		// Token: 0x04000D86 RID: 3462
		[Token(Token = "0x4000D86")]
		[FieldOffset(Offset = "0x14")]
		private readonly List<MaskingShape> _shapesCache;

		// Token: 0x02000435 RID: 1077
		[Token(Token = "0x2000435")]
		public class Item
		{
			// Token: 0x06001972 RID: 6514 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001972")]
			[Address(RVA = "0x6B11", Offset = "0x6B11", VA = "0x6B11")]
			public Item(Rect[] rects, Sprite[] shapes)
			{
			}

			// Token: 0x04000D87 RID: 3463
			[Token(Token = "0x4000D87")]
			[FieldOffset(Offset = "0x8")]
			public readonly Rect[] Rects;

			// Token: 0x04000D88 RID: 3464
			[Token(Token = "0x4000D88")]
			[FieldOffset(Offset = "0xC")]
			public readonly Sprite[] Shapes;
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_StepActionType ---
		void Gameplay_TutorialV2_Controller_CombatOverlapQueue__get_StepActionType
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  int iVar3;
		  int iVar4;
		  int *piVar5;
		  int iVar6;
		  int iVar7;
		  int iVar8;
		  uint uVar9;
		  undefined8 uVar10;
		  undefined8 uVar11;
		  undefined8 local_50;
		  undefined4 local_48;
		  undefined8 local_40;
		  undefined8 local_34;
		  undefined4 local_2c;
		  undefined8 local_28;
		  int local_20;
		  undefined1 *puStack_1c;
		  undefined8 local_18;
		  undefined1 local_10 [8];
		  undefined8 local_8;
		  
		  if (DAT_ram_00a583bc == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Component_GetComponent_Image___);
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Component_GetComponent_RectTransform___);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_MaskingShape__Dispose__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_MaskingShape__MoveNext__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_MaskingShape__get_Current__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_MaskingShape__Add__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_MaskingShape__Clear__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_MaskingShape__GetEnumerator__);
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Pool_ObjectPool_MaskingShape__Get__);
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Pool_ObjectPool_MaskingShape__Release__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Queue_CombatOverlapQueue_Item__Dequeue__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Queue_CombatOverlapQueue_Item__get_Count__);
		    DAT_ram_00a583bc = '\x01';
		  }
		  if (*(int *)(*(int *)(param1 + 0xc) + 0x14) == 0) {
		    return;
		  }
		  uVar1 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (*(undefined4 *)(param1 + 8),0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar1,1,0);
		  iVar2 = func_ii_7387(*(undefined4 *)(param1 + 0xc),
		                       Method_System_Collections_Generic_Queue_CombatOverlapQueue_Item__Dequeue__);
		  System_Collections_Generic_List_RegexCharClass_SingleRange___ForEach
		            (&local_20,*(undefined4 *)(param1 + 0x14),
		             Method_System_Collections_Generic_List_MaskingShape__GetEnumerator__);
		  local_8 = local_18;
		  local_20 = 0;
		  puStack_1c = local_10;
		  do {
		    while( true ) {
		      while( true ) {
		        while( true ) {
		          DAT_ram_009d3e38 = 0;
		          iVar3 = import::env::invoke_iii
		                            (s_struct_Uniforms___color__array<v_ram_00000aff + 0x44,local_10,
		                             Method_System_Collections_Generic_List_Enumerator_MaskingShape__MoveNext__
		                            );
		          iVar4 = DAT_ram_009d3e38;
		          iVar6 = Method_UnityEngine_Pool_ObjectPool_MaskingShape__Release__;
		          DAT_ram_009d3e38 = 0;
		          if (iVar4 == 1) {
		            uVar1 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		            goto code_r0x80edca52;
		          }
		          if (iVar3 == 0) {
		            iVar4 = 5;
		            iVar6 = local_20;
		            goto code_r0x80edca9f;
		          }
		          uVar1 = local_8._4_4_;
		          iVar4 = *(int *)(param1 + 0x10);
		          iVar3 = *(int *)(iVar4 + 0x14);
		          if (iVar3 != 0) {
		            DAT_ram_009d3e38 = 0;
		            import::env::invoke_viii
		                      (*(undefined4 *)(iVar3 + 0xc),*(undefined4 *)(iVar3 + 0x20),local_8._4_4_,
		                       *(undefined4 *)(iVar3 + 0x14));
		            if (DAT_ram_009d3e38 == 1) goto code_r0x80edca40;
		          }
		          if (*(int *)(iVar4 + 0x24) != 0) break;
		          *(undefined4 *)(iVar4 + 0x24) = uVar1;
		        }
		        DAT_ram_009d3e38 = 0;
		        iVar3 = func_ii_7385(iVar4,*(undefined4 *)(*(int *)(*(int *)(iVar6 + 0x10) + 0x60) + 0x48));
		        if (DAT_ram_009d3e38 == 1) goto code_r0x80edca40;
		        if (iVar3 < *(int *)(iVar4 + 0x1c)) break;
		        *(int *)(iVar4 + 0x28) = *(int *)(iVar4 + 0x28) + -1;
		        iVar6 = *(int *)(iVar4 + 0x18);
		        if (iVar6 != 0) {
		          DAT_ram_009d3e38 = 0;
		          import::env::invoke_viii
		                    (*(undefined4 *)(iVar6 + 0xc),*(undefined4 *)(iVar6 + 0x20),uVar1,
		                     *(undefined4 *)(iVar6 + 0x14));
		          if (DAT_ram_009d3e38 == 1) goto code_r0x80edca40;
		        }
		      }
		      iVar6 = *(int *)(*(int *)(*(int *)(iVar6 + 0x10) + 0x60) + 0x4c);
		      iVar4 = *(int *)(iVar4 + 8);
		      *(int *)(iVar4 + 0x10) = *(int *)(iVar4 + 0x10) + 1;
		      uVar9 = *(uint *)(iVar4 + 0xc);
		      if (*(uint *)(*(int *)(iVar4 + 8) + 0xc) <= uVar9) break;
		      *(uint *)(iVar4 + 0xc) = uVar9 + 1;
		      *(undefined4 *)(*(int *)(iVar4 + 8) + uVar9 * 4 + 0x10) = uVar1;
		    }
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_viii
		              (s_struct_Uniforms___color__array<v_ram_00000aff + 0x6e,iVar4,uVar1,
		               *(undefined4 *)(*(int *)(*(int *)(iVar6 + 0x10) + 0x60) + 0x38));
		  } while (DAT_ram_009d3e38 != 1);
		code_r0x80edca40:
		  DAT_ram_009d3e38 = 0;
		  uVar1 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x80edca52:
		  iVar6 = global_1;
		  iVar4 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar6 == iVar4) {
		    piVar5 = (int *)import::env::__cxa_begin_catch(uVar1);
		    iVar6 = *piVar5;
		    iVar4 = 0;
		    DAT_ram_009d3e38 = 0;
		    local_20 = iVar6;
		    import::env::invoke_v(0x123);
		    iVar3 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar3 != 1) {
		code_r0x80edca9f:
		      DAT_ram_009d3e38 = 0;
		      if (iVar6 != 0) {
		        System_Data_DataSet__ValidateLocaleConstraint(iVar6);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      if (iVar4 != 0) {
		        if (iVar4 == 1) {
		          DAT_ram_009d3e38 = 0;
		          return;
		        }
		        if (iVar4 == 2) {
		          DAT_ram_009d3e38 = 0;
		          return;
		        }
		        if (iVar4 == 3) {
		          DAT_ram_009d3e38 = 0;
		          return;
		        }
		        if (iVar4 == 4) {
		          DAT_ram_009d3e38 = 0;
		          return;
		        }
		        if (iVar4 != 5) {
		          DAT_ram_009d3e38 = 0;
		          return;
		        }
		      }
		      iVar6 = *(int *)(param1 + 0x14);
		      iVar4 = *(int *)(iVar6 + 0xc);
		      *(undefined4 *)(iVar6 + 0xc) = 0;
		      *(int *)(iVar6 + 0x10) = *(int *)(iVar6 + 0x10) + 1;
		      if (0 < iVar4) {
		        func_ii_2064(*(undefined4 *)(iVar6 + 8),0,iVar4,0);
		      }
		      iVar6 = *(int *)(iVar2 + 8);
		      if (*(int *)(iVar6 + 0xc) < 1) {
		        return;
		      }
		      iVar4 = 0;
		      do {
		        iVar3 = Method_UnityEngine_Pool_ObjectPool_MaskingShape__Get__;
		        iVar6 = iVar6 + iVar4 * 0x10;
		        uVar10 = *(undefined8 *)(iVar6 + 0x18);
		        uVar11 = *(undefined8 *)(iVar6 + 0x10);
		        iVar7 = *(int *)(param1 + 0x10);
		        iVar6 = *(int *)(iVar7 + 0x24);
		        if (iVar6 == 0) {
		          iVar8 = *(int *)(*(int *)(iVar7 + 8) + 0xc);
		          if (iVar8 == 0) {
		            iVar6 = *(int *)(iVar7 + 0xc);
		            iVar6 = (**(code **)((ulonglong)*(uint *)(iVar6 + 0xc) * 4))
		                              (*(undefined4 *)(iVar6 + 0x20),*(undefined4 *)(iVar6 + 0x14));
		            *(int *)(iVar7 + 0x28) = *(int *)(iVar7 + 0x28) + 1;
		          }
		          else {
		            iVar8 = iVar8 + -1;
		            iVar6 = System_Linq_Enumerable__ToList_object_
		                              (*(int *)(iVar7 + 8),iVar8,
		                               *(undefined4 *)
		                                (*(int *)(*(int *)(
		                                                  Method_UnityEngine_Pool_ObjectPool_MaskingShape__Get__
		                                                  + 0x10) + 0x60) + 0x28));
		            UnityEngine_TextCore_Glyph__set_atlasIndex
		                      (*(undefined4 *)(iVar7 + 8),iVar8,
		                       *(undefined4 *)(*(int *)(*(int *)(iVar3 + 0x10) + 0x60) + 0x2c));
		          }
		        }
		        else {
		          *(undefined4 *)(iVar7 + 0x24) = 0;
		        }
		        iVar3 = *(int *)(iVar7 + 0x10);
		        if (iVar3 != 0) {
		          (**(code **)((ulonglong)*(uint *)(iVar3 + 0xc) * 4))
		                    (*(undefined4 *)(iVar3 + 0x20),iVar6,*(undefined4 *)(iVar3 + 0x14));
		        }
		        uVar1 = func_ii_5677(iVar6,Method_UnityEngine_Component_GetComponent_Image___);
		        func_ii_7050(uVar1,*(undefined4 *)(*(int *)(iVar2 + 0xc) + iVar4 * 4 + 0x10),0);
		        uVar1 = func_ii_5677(iVar6,Method_UnityEngine_Component_GetComponent_RectTransform___);
		        local_40 = uVar10;
		        local_28 = uVar10;
		        UnityEngine_RectTransform__get_sizeDelta(uVar1,&local_40,0);
		        uVar1 = func_ii_5677(iVar6,Method_UnityEngine_Component_GetComponent_RectTransform___);
		        local_2c = 0;
		        local_48 = 0;
		        local_50 = uVar11;
		        local_34 = uVar11;
		        Gameplay_Isles_User_View_IsleAccountMarkersLayerView__GetView(uVar1,&local_50,0);
		        iVar3 = Method_System_Collections_Generic_List_MaskingShape__Add__;
		        iVar7 = *(int *)(param1 + 0x14);
		        *(int *)(iVar7 + 0x10) = *(int *)(iVar7 + 0x10) + 1;
		        uVar9 = *(uint *)(iVar7 + 0xc);
		        if (uVar9 < *(uint *)(*(int *)(iVar7 + 8) + 0xc)) {
		          *(uint *)(iVar7 + 0xc) = uVar9 + 1;
		          *(int *)(*(int *)(iVar7 + 8) + uVar9 * 4 + 0x10) = iVar6;
		        }
		        else {
		          System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		                    (iVar7,iVar6,*(undefined4 *)(*(int *)(*(int *)(iVar3 + 0x10) + 0x60) + 0x38));
		        }
		        iVar4 = iVar4 + 1;
		        iVar6 = *(int *)(iVar2 + 8);
		      } while (iVar4 < *(int *)(iVar6 + 0xc));
		      return;
		    }
		    uVar1 = import::env::__cxa_find_matching_catch_2();
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001b87 + 0x154,&local_20);
		  iVar2 = DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = 0;
		  if (iVar2 == 1) {
		    import::env::__cxa_find_matching_catch_3(0);
		    unnamed_function_937();
		    do {
		      halt_trap();
		    } while( true );
		  }
		  import::env::__resumeException(uVar1);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

}
