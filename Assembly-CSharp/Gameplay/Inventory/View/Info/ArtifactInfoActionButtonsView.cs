using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Protocol.Dic;
using UI.Inventory;
using UI.Scroll;
using UnityEngine;

namespace Gameplay.Inventory.View.Info
{
	// Token: 0x02000666 RID: 1638
	[Token(Token = "0x2000666")]
	public class ArtifactInfoActionButtonsView : MonoBehaviour
	{
		// Token: 0x14000154 RID: 340
		// (add) Token: 0x060027CB RID: 10187 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060027CC RID: 10188 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000154")]
		public static event Action<ArtikulMenuActionDic.Types.Actions> ActionHandledEvent
		{
			[Token(Token = "0x60027CB")]
			[Address(RVA = "0x78F1", Offset = "0x78F1", VA = "0x78F1")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60027CC")]
			[Address(RVA = "0x78F2", Offset = "0x78F2", VA = "0x78F2")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x1700078A RID: 1930
		// (get) Token: 0x060027CD RID: 10189 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060027CE RID: 10190 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700078A")]
		public ArtifactView ArtifactView
		{
			[Token(Token = "0x60027CD")]
			[Address(RVA = "0x78F3", Offset = "0x78F3", VA = "0x78F3")]
			get
			{
				return null;
			}
			[Token(Token = "0x60027CE")]
			[Address(RVA = "0x78F4", Offset = "0x78F4", VA = "0x78F4")]
			set
			{
			}
		}

		// Token: 0x060027CF RID: 10191 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60027CF")]
		[Address(RVA = "0x78F5", Offset = "0x78F5", VA = "0x78F5")]
		private void OnButtonClickEvent(ArtifactContextMenuElement element)
		{
		/* --- GHIDRA: <set_ArtifactView>b__10_2 ---
		void Gameplay_Inventory_View_Info_ArtifactInfoActionButtonsView___set_ArtifactView_b__10_2
		               (undefined4 param1)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a5a0bb == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_Inventory_View_Info_ArtifactInfoActionButtonsView___c_TypeInfo);
		    DAT_ram_00a5a0bb = '\x01';
		  }
		  uVar1 = unnamed_function_1417
		                    (Gameplay_Inventory_View_Info_ArtifactInfoActionButtonsView___c_TypeInfo);
		  **(undefined4 **)(Gameplay_Inventory_View_Info_ArtifactInfoActionButtonsView___c_TypeInfo + 0x5c)
		       = uVar1;
		  return;
		}
		*/

		/* --- GHIDRA: <set_ArtifactView>b__10_1 ---
		undefined4
		Gameplay_Inventory_View_Info_ArtifactInfoActionButtonsView___set_ArtifactView_b__10_1
		          (int param1,int *param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param2 + 0xe8) * 4))
		                    (param2,*(undefined4 *)(param1 + 0x20),*(undefined4 *)(*param2 + 0xec));
		  return uVar1;
		}
		*/

		/* --- GHIDRA: OnButtonClickEvent ---
		void Gameplay_Inventory_View_Info_ArtifactInfoActionButtonsView__OnButtonClickEvent
		               (undefined4 param1,undefined4 param2)
		
		{
		  Gameplay_Inventory_View_Info_ArtifactInfoActionButtonsView__get_ArtifactView(param1,0,param1);
		  return;
		}
		*/

		}

		// Token: 0x060027D0 RID: 10192 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60027D0")]
		[Address(RVA = "0x78F6", Offset = "0x78F6", VA = "0x78F6")]
		private void OnDestroy()
		{
		/* --- GHIDRA: OnDestroy ---
		void Gameplay_Inventory_View_Info_ArtifactInfoActionButtonsView__OnDestroy
		               (int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a5a0ba == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_ArtifactContextMenuElement___ctor__);
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_List_ArtifactContextMenuElement__TypeInfo);
		    DAT_ram_00a5a0ba = '\x01';
		  }
		  param1_00 = unnamed_function_1417
		                        (System_Collections_Generic_List_ArtifactContextMenuElement__TypeInfo);
		  GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		            (param1_00,Method_System_Collections_Generic_List_ArtifactContextMenuElement___ctor__);
		  *(undefined4 *)(param1 + 0x1c) = param1_00;
		  UnityEngine_RectTransform__GetParentSize(param1,0);
		  return;
		}
		*/

		}

		// Token: 0x060027D1 RID: 10193 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60027D1")]
		[Address(RVA = "0x78F7", Offset = "0x78F7", VA = "0x78F7")]
		public ArtifactInfoActionButtonsView()
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Inventory_View_Info_ArtifactInfoActionButtonsView___ctor
		               (int param1,int *param2,undefined4 param3)
		
		{
		  (**(code **)((ulonglong)*(uint *)(*param2 + 0xf0) * 4))
		            (param2,*(undefined4 *)(param1 + 0x20),*(undefined4 *)(*param2 + 0xf4));
		  return;
		}
		*/

		}

		// Token: 0x040015CA RID: 5578
		[Token(Token = "0x40015CA")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private ArtifactContextMenuElement _buttonPrefab;

		// Token: 0x040015CB RID: 5579
		[Token(Token = "0x40015CB")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private Transform _container;

		// Token: 0x040015CC RID: 5580
		[Token(Token = "0x40015CC")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private ScrollWithButtons _scrollWithButtons;

		// Token: 0x040015CE RID: 5582
		[Token(Token = "0x40015CE")]
		[FieldOffset(Offset = "0x1C")]
		private List<ArtifactContextMenuElement> _buttons;

		// Token: 0x040015CF RID: 5583
		[Token(Token = "0x40015CF")]
		[FieldOffset(Offset = "0x20")]
		private ArtifactView _artifactView;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: add_ActionHandledEvent ---
		void Gameplay_Inventory_View_Info_ArtifactInfoActionButtonsView__add_ActionHandledEvent
		               (undefined4 param1,undefined4 param2)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a5a0b7 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ArtikulMenuActionDic_Types_Actions__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_Inventory_View_Info_ArtifactInfoActionButtonsView_TypeInfo);
		    DAT_ram_00a5a0b7 = '\x01';
		  }
		  param1_00 = **(int **)(Gameplay_Inventory_View_Info_ArtifactInfoActionButtonsView_TypeInfo + 0x5c)
		  ;
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param1,0);
		    param2_00 = System_Action_ArtikulMenuActionDic_Types_Actions__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_ArtikulMenuActionDic_Types_Actions__TypeInfo),
		       iVar2 == 0)) break;
		    iVar2 = func_ii_4329(*(undefined4 *)
		                          (Gameplay_Inventory_View_Info_ArtifactInfoActionButtonsView_TypeInfo +
		                          0x5c),iVar2,param1_00);
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


		/* --- GHIDRA: get_ArtifactView ---
		void Gameplay_Inventory_View_Info_ArtifactInfoActionButtonsView__get_ArtifactView
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  uint uVar2;
		  int iVar3;
		  uint *puVar4;
		  undefined4 uVar5;
		  undefined4 uVar6;
		  undefined4 *puVar7;
		  int *piVar8;
		  int iVar9;
		  int param1_00;
		  uint uVar10;
		  int *piVar11;
		  float fVar12;
		  float fVar13;
		  undefined8 local_68;
		  undefined4 local_60;
		  undefined8 local_58;
		  undefined8 local_50;
		  float4 local_44;
		  float4 local_40;
		  undefined4 local_3c;
		  float4 local_38;
		  undefined4 local_34;
		  float4 local_30;
		  undefined4 local_2c;
		  int local_28;
		  int **ppiStack_24;
		  int *local_20;
		  undefined4 uStack_1c;
		  int local_18;
		  int *local_14;
		  undefined8 local_10;
		  int *local_8;
		  undefined4 uStack_4;
		  
		  if (DAT_ram_00a5a0b8 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ArtifactContextMenuElement__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_AbstractArtifactContextMenuElement__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_Inventory_View_ContextMenu_ArtifactContextMenuUtils_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Inventory_View_Info_ArtifactInfoActionButtonsView_OnButtonClickEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Inventory_View_Info_ArtifactInfoActionButtonsView__set_ArtifactView_b__10_1__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Inventory_View_Info_ArtifactInfoActionButtonsView__set_ArtifactView_b__10_2__
		              );
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Component_GetComponent_RectTransform___);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Linq_Enumerable_OrderBy_AbstractArtifactContextMenuElement__uint___);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Linq_Enumerable_ToArray_AbstractArtifactContextMenuElement___);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Linq_Enumerable_Where_AbstractArtifactContextMenuElement___);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_Enumerator_ArtifactContextMenuElement__Dispose__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_Enumerator_ArtifactContextMenuElement__MoveNext__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_Enumerator_ArtifactContextMenuElement__get_Current__
		              );
		    Mono_Security_ASN1__get_Item(&System_Func_AbstractArtifactContextMenuElement__bool__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Func_AbstractArtifactContextMenuElement__uint__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_IDisposable_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_IEnumerator_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Sirenix_Utilities_LinqExtensions_ForEach_AbstractArtifactContextMenuElement___
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_ArtifactContextMenuElement__Add__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_ArtifactContextMenuElement__Clear__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_ArtifactContextMenuElement__GetEnumerator__);
		    Mono_Security_ASN1__get_Item
		              (&Method_UnityEngine_Object_Instantiate_ArtifactContextMenuElement___);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    Mono_Security_ASN1__get_Item(&UnityEngine_RectTransform_TypeInfo);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Transform_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Inventory_View_Info_ArtifactInfoActionButtonsView___c__set_ArtifactView_b__10_0__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Inventory_View_Info_ArtifactInfoActionButtonsView___c__set_ArtifactView_b__10_3__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_Inventory_View_Info_ArtifactInfoActionButtonsView___c_TypeInfo);
		    DAT_ram_00a5a0b8 = '\x01';
		  }
		  local_8 = (int *)0x0;
		  uStack_4 = 0;
		  local_10 = 0;
		  local_14 = (int *)0x0;
		  local_18 = 0;
		  iVar3 = Cysharp_Threading_Tasks_CancellationTokenExtensions___cctor
		                    (*(undefined4 *)(param1 + 0x20),0);
		  if (iVar3 == 0) {
		code_r0x811c3bfb:
		    *(undefined4 *)(param1 + 0x20) = param2;
		    iVar3 = Cysharp_Threading_Tasks_CancellationTokenExtensions___cctor(param2,0);
		    if (iVar3 != 0) {
		      uVar6 = *(undefined4 *)(*(int *)(param1 + 0x20) + 0x54);
		      if (*(int *)(Gameplay_Inventory_View_ContextMenu_ArtifactContextMenuUtils_TypeInfo + 0x74) ==
		          0) {
		        func_ii_306000(Gameplay_Inventory_View_ContextMenu_ArtifactContextMenuUtils_TypeInfo);
		      }
		      uVar6 = Gameplay_Inventory_View_ContextMenu_ArtifactContextMenuUtils__get_DefaultActions
		                        (uVar6,0);
		      if (*(int *)(Gameplay_Inventory_View_Info_ArtifactInfoActionButtonsView___c_TypeInfo + 0x74)
		          == 0) {
		        func_ii_306000(Gameplay_Inventory_View_Info_ArtifactInfoActionButtonsView___c_TypeInfo);
		      }
		      puVar7 = *(undefined4 **)
		                (Gameplay_Inventory_View_Info_ArtifactInfoActionButtonsView___c_TypeInfo + 0x5c);
		      iVar3 = puVar7[1];
		      if (iVar3 == 0) {
		        if (*(int *)(Gameplay_Inventory_View_Info_ArtifactInfoActionButtonsView___c_TypeInfo + 0x74)
		            == 0) {
		          func_ii_306000(Gameplay_Inventory_View_Info_ArtifactInfoActionButtonsView___c_TypeInfo);
		          puVar7 = *(undefined4 **)
		                    (Gameplay_Inventory_View_Info_ArtifactInfoActionButtonsView___c_TypeInfo + 0x5c)
		          ;
		        }
		        uVar5 = *puVar7;
		        iVar3 = unnamed_function_1417
		                          (System_Func_AbstractArtifactContextMenuElement__bool__TypeInfo);
		        System_Collections_Generic_Dictionary_uint__object___GetEnumerator
		                  (iVar3,uVar5,
		                   Method_Gameplay_Inventory_View_Info_ArtifactInfoActionButtonsView___c__set_ArtifactView_b__10_0__
		                   ,0);
		        *(int *)(*(int *)(Gameplay_Inventory_View_Info_ArtifactInfoActionButtonsView___c_TypeInfo +
		                         0x5c) + 4) = iVar3;
		      }
		      uVar6 = System_Linq_Enumerable__Where_PlayerLoopSystem_
		                        (uVar6,iVar3,
		                         Method_System_Linq_Enumerable_Where_AbstractArtifactContextMenuElement___);
		      uVar5 = unnamed_function_1417(System_Action_AbstractArtifactContextMenuElement__TypeInfo);
		      UnityEngine_UIElements_VisualElement__get_layout
		                (uVar5,param1,
		                 Method_Gameplay_Inventory_View_Info_ArtifactInfoActionButtonsView__set_ArtifactView_b__10_1__
		                 ,0);
		      uVar6 = Sirenix_Utilities_LinqExtensions__FilterCast___Il2CppFullySharedGenericType_
		                        (uVar6,uVar5,
		                         Method_Sirenix_Utilities_LinqExtensions_ForEach_AbstractArtifactContextMenuElement___
		                        );
		      uVar5 = unnamed_function_1417(System_Func_AbstractArtifactContextMenuElement__bool__TypeInfo);
		      System_Collections_Generic_Dictionary_uint__object___GetEnumerator
		                (uVar5,param1,
		                 Method_Gameplay_Inventory_View_Info_ArtifactInfoActionButtonsView__set_ArtifactView_b__10_2__
		                 ,0);
		      uVar6 = System_Linq_Enumerable__Where_PlayerLoopSystem_
		                        (uVar6,uVar5,
		                         Method_System_Linq_Enumerable_Where_AbstractArtifactContextMenuElement___);
		      if (*(int *)(Gameplay_Inventory_View_Info_ArtifactInfoActionButtonsView___c_TypeInfo + 0x74)
		          == 0) {
		        func_ii_306000(Gameplay_Inventory_View_Info_ArtifactInfoActionButtonsView___c_TypeInfo);
		      }
		      puVar7 = *(undefined4 **)
		                (Gameplay_Inventory_View_Info_ArtifactInfoActionButtonsView___c_TypeInfo + 0x5c);
		      iVar3 = puVar7[2];
		      if (iVar3 == 0) {
		        if (*(int *)(Gameplay_Inventory_View_Info_ArtifactInfoActionButtonsView___c_TypeInfo + 0x74)
		            == 0) {
		          func_ii_306000(Gameplay_Inventory_View_Info_ArtifactInfoActionButtonsView___c_TypeInfo);
		          puVar7 = *(undefined4 **)
		                    (Gameplay_Inventory_View_Info_ArtifactInfoActionButtonsView___c_TypeInfo + 0x5c)
		          ;
		        }
		        uVar5 = *puVar7;
		        iVar3 = unnamed_function_1417
		                          (System_Func_AbstractArtifactContextMenuElement__uint__TypeInfo);
		        System_Collections_Generic_Dictionary_KeyCollection_uint__object___GetEnumerator
		                  (iVar3,uVar5,
		                   Method_Gameplay_Inventory_View_Info_ArtifactInfoActionButtonsView___c__set_ArtifactView_b__10_3__
		                   ,0);
		        *(int *)(*(int *)(Gameplay_Inventory_View_Info_ArtifactInfoActionButtonsView___c_TypeInfo +
		                         0x5c) + 8) = iVar3;
		      }
		      uVar6 = System_Linq_Enumerable__Min___Il2CppFullySharedGenericType____Il2CppFullySharedGenericType_
		                        (uVar6,iVar3,
		                         Method_System_Linq_Enumerable_OrderBy_AbstractArtifactContextMenuElement__uint___
		                        );
		      iVar3 = func_ii_6295(uVar6,
		                           Method_System_Linq_Enumerable_ToArray_AbstractArtifactContextMenuElement___
		                          );
		      piVar8 = *(int **)(param1 + 0x14);
		      if ((piVar8 != (int *)0x0) && (UnityEngine_RectTransform_TypeInfo != *piVar8)) {
		        System_Activator__CreateInstance(piVar8,UnityEngine_RectTransform_TypeInfo);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      local_2c = 0x3f800000;
		      fVar13 = (float)*(int *)(iVar3 + 0xc) * 0.125;
		      fVar12 = 0.0;
		      if (fVar13 <= 1.0) {
		        fVar12 = (1.0 - fVar13) * 0.5;
		      }
		      local_30 = (float4)0.5;
		      if (0.0 <= fVar13) {
		        local_30 = (float4)fVar12;
		      }
		      local_50 = CONCAT44(0x3f800000,local_30);
		      UnityEngine_RectTransform__get_pivot(piVar8,&local_50,0);
		      iVar9 = *(int *)(iVar3 + 0xc);
		      uVar6 = func_ii_5677(*(undefined4 *)(param1 + 0x14),
		                           Method_UnityEngine_Component_GetComponent_RectTransform___);
		      local_34 = 0x43960000;
		      local_38 = (float4)(float)(iVar9 * 0x38 + 0x3c);
		      local_58 = CONCAT44(0x43960000,local_38);
		      UnityEngine_RectTransform__get_sizeDelta(uVar6,&local_58,0);
		      if (0 < *(int *)(iVar3 + 0xc)) {
		        uVar2 = 0;
		        do {
		          uVar6 = *(undefined4 *)(param1 + 0x14);
		          uVar5 = *(undefined4 *)(param1 + 0x10);
		          if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		            func_ii_306000(UnityEngine_Object_TypeInfo);
		          }
		          iVar9 = func_ii_6805(uVar5,uVar6,
		                               Method_UnityEngine_Object_Instantiate_ArtifactContextMenuElement___);
		          uVar6 = System_Collections_Generic_SortedDictionary_Enumerator_object__object___get_Current
		                            (iVar9,0);
		          local_3c = 0;
		          local_60 = 0;
		          local_40 = -170.0;
		          if ((uVar2 & 1) == 0) {
		            local_40 = -60.0;
		          }
		          local_44 = (float4)(float)(int)(uVar2 * 0x38 + 0x3c);
		          local_68 = CONCAT44(local_40,local_44);
		          Gameplay_Isles_User_View_IsleAccountMarkersLayerView__GetView(uVar6,&local_68,0);
		          UI_Inventory_ArtifactContextMenuElement__get_AbstractContextMenuElement
		                    (iVar9,*(undefined4 *)(iVar3 + uVar2 * 4 + 0x10),0);
		          *(undefined1 *)(iVar9 + 0x2c) = 1;
		          uVar6 = unnamed_function_1417(System_Action_ArtifactContextMenuElement__TypeInfo);
		          UnityEngine_UIElements_VisualElement__get_layout
		                    (uVar6,param1,
		                     Method_Gameplay_Inventory_View_Info_ArtifactInfoActionButtonsView_OnButtonClickEvent__
		                     ,0);
		          UI_Inventory_ArtifactContextMenuElement__set_ButtonBehaviour(iVar9,uVar6,0);
		          iVar1 = Method_System_Collections_Generic_List_ArtifactContextMenuElement__Add__;
		          param1_00 = *(int *)(param1 + 0x1c);
		          *(int *)(param1_00 + 0x10) = *(int *)(param1_00 + 0x10) + 1;
		          uVar10 = *(uint *)(param1_00 + 0xc);
		          if (uVar10 < *(uint *)(*(int *)(param1_00 + 8) + 0xc)) {
		            *(uint *)(param1_00 + 0xc) = uVar10 + 1;
		            *(int *)(*(int *)(param1_00 + 8) + uVar10 * 4 + 0x10) = iVar9;
		          }
		          else {
		            System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		                      (param1_00,iVar9,
		                       *(undefined4 *)(*(int *)(*(int *)(iVar1 + 0x10) + 0x60) + 0x38));
		          }
		          uVar2 = uVar2 + 1;
		        } while ((int)uVar2 < *(int *)(iVar3 + 0xc));
		      }
		      iVar3 = func_ii_12174(*(undefined4 *)(param1 + 0x18),0);
		      if (iVar3 != 0) {
		        UI_Scroll_ScrollWithButtons__GetRectAxis(*(undefined4 *)(param1 + 0x18),0);
		      }
		    }
		    return;
		  }
		  System_Collections_Generic_List_RegexCharClass_SingleRange___ForEach
		            (&local_28,*(undefined4 *)(param1 + 0x1c),
		             Method_System_Collections_Generic_List_ArtifactContextMenuElement__GetEnumerator__);
		  local_8 = local_20;
		  uStack_4 = uStack_1c;
		  local_10 = CONCAT44(ppiStack_24,local_28);
		  local_28 = 0;
		  ppiStack_24 = (int **)&local_10;
		  do {
		    DAT_ram_009d3e38 = 0;
		    iVar9 = import::env::invoke_iii
		                      (s_struct_Uniforms___color__array<v_ram_00000aff + 0x44,&local_10,
		                       Method_System_Collections_Generic_List_Enumerator_ArtifactContextMenuElement__MoveNext__
		                      );
		    uVar6 = uStack_4;
		    iVar3 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar3 == 1) {
		      uVar6 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x811c3723;
		    }
		    if (iVar9 == 0) goto code_r0x811c3779;
		    DAT_ram_009d3e38 = 0;
		    uVar5 = import::env::invoke_ii
		                      (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x199,
		                       System_Action_ArtifactContextMenuElement__TypeInfo);
		    if (DAT_ram_009d3e38 == 1) break;
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_viiii
		              (s_struct_Uniforms___color__array<v_ram_000017c8 + 0x241,uVar5,param1,
		               Method_Gameplay_Inventory_View_Info_ArtifactInfoActionButtonsView_OnButtonClickEvent__
		               ,0);
		    if (DAT_ram_009d3e38 == 1) break;
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_viii(s_struct_Uniforms___color__array<v_ram_00001f04 + 0x245,uVar6,uVar5,0);
		  } while (DAT_ram_009d3e38 != 1);
		  DAT_ram_009d3e38 = 0;
		  uVar6 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x811c3723:
		  iVar3 = global_1;
		  iVar9 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar3 == iVar9) {
		    piVar8 = (int *)import::env::__cxa_begin_catch(uVar6);
		    iVar9 = *piVar8;
		    DAT_ram_009d3e38 = 0;
		    local_28 = iVar9;
		    import::env::invoke_v(0x123);
		    iVar3 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar3 != 1) {
		      if (iVar9 != 0) {
		        System_Data_DataSet__ValidateLocaleConstraint(iVar9);
		        do {
		          halt_trap();
		        } while( true );
		      }
		code_r0x811c3779:
		      DAT_ram_009d3e38 = 0;
		      iVar3 = *(int *)(param1 + 0x1c);
		      iVar9 = *(int *)(iVar3 + 0xc);
		      *(undefined4 *)(iVar3 + 0xc) = 0;
		      *(int *)(iVar3 + 0x10) = *(int *)(iVar3 + 0x10) + 1;
		      if (0 < iVar9) {
		        func_ii_2064(*(undefined4 *)(iVar3 + 8),0,iVar9,0);
		      }
		      local_14 = (int *)UnityEngine_Transform__set_hasChanged(*(undefined4 *)(param1 + 0x14),0);
		      local_20 = &local_18;
		      local_28 = 0;
		      ppiStack_24 = &local_14;
		      do {
		        piVar8 = local_14;
		        iVar3 = *local_14;
		        if (*(ushort *)(iVar3 + 0xb6) != 0) {
		          uVar2 = 0;
		          do {
		            piVar11 = (int *)(*(int *)(iVar3 + 0x58) + uVar2 * 8);
		            if (System_Collections_IEnumerator_TypeInfo == *piVar11) {
		              puVar7 = (undefined4 *)(iVar3 + piVar11[1] * 8 + 0xc0);
		              goto code_r0x811c38bf;
		            }
		            uVar2 = uVar2 + 1;
		          } while (*(ushort *)(iVar3 + 0xb6) != uVar2);
		        }
		        DAT_ram_009d3e38 = 0;
		        puVar7 = (undefined4 *)
		                 import::env::invoke_iiii
		                           (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_14,
		                            System_Collections_IEnumerator_TypeInfo,0);
		        if (DAT_ram_009d3e38 == 1) {
		code_r0x811c3b02:
		          DAT_ram_009d3e38 = 0;
		          uVar6 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x811c3b0a;
		        }
		code_r0x811c38bf:
		        DAT_ram_009d3e38 = 0;
		        iVar3 = import::env::invoke_iii(*puVar7,piVar8,puVar7[1]);
		        piVar8 = local_14;
		        if (DAT_ram_009d3e38 == 1) goto code_r0x811c3b02;
		        if (iVar3 == 0) goto code_r0x811c3b53;
		        iVar3 = *local_14;
		        if (*(ushort *)(iVar3 + 0xb6) != 0) {
		          uVar2 = 0;
		          do {
		            piVar11 = (int *)(*(int *)(iVar3 + 0x58) + uVar2 * 8);
		            if (System_Collections_IEnumerator_TypeInfo == *piVar11) {
		              puVar7 = (undefined4 *)(piVar11[1] * 8 + iVar3 + 200);
		              goto code_r0x811c399c;
		            }
		            uVar2 = uVar2 + 1;
		          } while (*(ushort *)(iVar3 + 0xb6) != uVar2);
		        }
		        DAT_ram_009d3e38 = 0;
		        puVar7 = (undefined4 *)
		                 import::env::invoke_iiii
		                           (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_14,
		                            System_Collections_IEnumerator_TypeInfo,1);
		        if (DAT_ram_009d3e38 == 1) {
		code_r0x811c3ae4:
		          DAT_ram_009d3e38 = 0;
		          uVar6 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x811c3b0a;
		        }
		code_r0x811c399c:
		        DAT_ram_009d3e38 = 0;
		        piVar8 = (int *)import::env::invoke_iii(*puVar7,piVar8,puVar7[1]);
		        if (DAT_ram_009d3e38 == 1) goto code_r0x811c3ae4;
		        if (piVar8 != (int *)0x0) {
		          if (((uint)*(byte *)(*piVar8 + 0xb8) <
		               (uint)*(byte *)(UnityEngine_Transform_TypeInfo + 0xb8)) ||
		             (*(int *)(*(int *)(*piVar8 + 100) +
		                       (uint)*(byte *)(UnityEngine_Transform_TypeInfo + 0xb8) * 4 + -4) !=
		              UnityEngine_Transform_TypeInfo)) {
		            DAT_ram_009d3e38 = 0;
		            import::env::invoke_vii
		                      (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x183,piVar8,
		                       UnityEngine_Transform_TypeInfo);
		            iVar3 = DAT_ram_009d3e38;
		            DAT_ram_009d3e38 = 0;
		            if (iVar3 != 1) {
		              do {
		                halt_trap();
		              } while( true );
		            }
		            uVar6 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		            goto code_r0x811c3b0a;
		          }
		        }
		        DAT_ram_009d3e38 = 0;
		        uVar6 = import::env::invoke_iii
		                          (s_struct_Uniforms___color__array<v_ram_00000aff + 0x25c,piVar8,0);
		        if (DAT_ram_009d3e38 == 1) break;
		        if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		          DAT_ram_009d3e38 = 0;
		          import::env::invoke_vi
		                    (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x180,
		                     UnityEngine_Object_TypeInfo);
		          if (DAT_ram_009d3e38 == 1) break;
		        }
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_vii(s_struct_Uniforms___color__array<v_ram_00000aff + 0x274,uVar6,0);
		      } while (DAT_ram_009d3e38 != 1);
		      DAT_ram_009d3e38 = 0;
		      uVar6 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x811c3b0a:
		      iVar3 = global_1;
		      iVar9 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		      if (iVar3 == iVar9) {
		        piVar8 = (int *)import::env::__cxa_begin_catch(uVar6);
		        local_28 = *piVar8;
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_v(0x123);
		        iVar3 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar3 != 1) {
		code_r0x811c3b53:
		          DAT_ram_009d3e38 = 0;
		          local_18 = func_ii_1082(local_14,System_IDisposable_TypeInfo);
		          piVar8 = (int *)*local_20;
		          if (piVar8 != (int *)0x0) {
		            iVar3 = *piVar8;
		            if (*(ushort *)(iVar3 + 0xb6) != 0) {
		              uVar2 = 0;
		              do {
		                if (System_IDisposable_TypeInfo == *(int *)(*(int *)(iVar3 + 0x58) + uVar2 * 8)) {
		                  puVar4 = (uint *)(iVar3 + *(int *)(*(int *)(iVar3 + 0x58) + uVar2 * 8 + 4) * 8 +
		                                   0xc0);
		                  goto code_r0x811c3be3;
		                }
		                uVar2 = uVar2 + 1;
		              } while (*(ushort *)(iVar3 + 0xb6) != uVar2);
		            }
		            puVar4 = (uint *)func_ii_1080(piVar8,System_IDisposable_TypeInfo,0);
		code_r0x811c3be3:
		            (**(code **)((ulonglong)*puVar4 * 4))(piVar8,puVar4[1]);
		          }
		          if (local_28 != 0) {
		            System_Data_DataSet__ValidateLocaleConstraint(local_28);
		            do {
		              halt_trap();
		            } while( true );
		          }
		          goto code_r0x811c3bfb;
		        }
		        uVar6 = import::env::__cxa_find_matching_catch_2();
		      }
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001f04 + 0x247,&local_28);
		      goto joined_r0x811c3e20;
		    }
		    uVar6 = import::env::__cxa_find_matching_catch_2();
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001f04 + 0x246,&local_28);
		joined_r0x811c3e20:
		  if (DAT_ram_009d3e38 == 1) {
		    DAT_ram_009d3e38 = 0;
		    import::env::__cxa_find_matching_catch_3(0);
		    unnamed_function_937();
		    do {
		      halt_trap();
		    } while( true );
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::__resumeException(uVar6);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/


		/* --- GHIDRA: set_ArtifactView ---
		void Gameplay_Inventory_View_Info_ArtifactInfoActionButtonsView__set_ArtifactView
		               (int param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  int iVar3;
		  
		  if (DAT_ram_00a5a0b9 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_Inventory_View_Info_ArtifactInfoActionButtonsView_TypeInfo);
		    DAT_ram_00a5a0b9 = '\x01';
		  }
		  iVar3 = **(int **)(param2 + 0x34);
		  (**(code **)((ulonglong)*(uint *)(iVar3 + 0xf8) * 4))
		            (*(int **)(param2 + 0x34),*(undefined4 *)(param1 + 0x20),*(undefined4 *)(iVar3 + 0xfc));
		  iVar3 = **(int **)(Gameplay_Inventory_View_Info_ArtifactInfoActionButtonsView_TypeInfo + 0x5c);
		  if (iVar3 != 0) {
		    iVar2 = **(int **)(param2 + 0x34);
		    uVar1 = (**(code **)((ulonglong)*(uint *)(iVar2 + 0xe0) * 4))
		                      (*(int **)(param2 + 0x34),*(undefined4 *)(iVar2 + 0xe4));
		    (**(code **)((ulonglong)*(uint *)(iVar3 + 0xc) * 4))
		              (*(undefined4 *)(iVar3 + 0x20),uVar1,*(undefined4 *)(iVar3 + 0x14));
		  }
		  return;
		}
		*/

}
