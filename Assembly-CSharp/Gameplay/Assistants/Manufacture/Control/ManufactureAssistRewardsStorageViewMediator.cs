using System;
using System.Collections.Generic;
using Core.Data;
using Gameplay.Assistants.Manufacture.Model;
using Gameplay.Assistants.Manufacture.View;
using Il2CppDummyDll;
using JetBrains.Annotations;
using MVC;

namespace Gameplay.Assistants.Manufacture.Control
{
	// Token: 0x02000CB2 RID: 3250
	[Token(Token = "0x2000CB2")]
	public class ManufactureAssistRewardsStorageViewMediator : AbstractViewMediator<ManufactureAssistModel, ManufactureAssistantEvents, ManufactureAssistController, ManufactureAssistantRewardStorageWindow>
	{
		// Token: 0x06004F2F RID: 20271 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004F2F")]
		[Address(RVA = "0x9D57", Offset = "0x9D57", VA = "0x9D57")]
		public ManufactureAssistRewardsStorageViewMediator(ManufactureAssistModel model, ManufactureAssistantEvents events, ManufactureAssistController controller)
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Assistants_Manufacture_Control_ManufactureAssistRewardsStorageViewMediator___ctor
		               (int *param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  int iVar2;
		  undefined4 uVar3;
		  int *piVar4;
		  undefined4 uVar5;
		  
		  if (DAT_ram_00a5899d == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_ManufactureAssistModel__ManufactureAssistantEvents__ManufactureAssistController__ManufactureAssistantRewardStorageWindow__set_Events__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Assistants_Manufacture_Control_ManufactureAssistRewardsStorageViewMediator_HandleDropChangedEvent__
		              );
		    DAT_ram_00a5899d = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x13c));
		  if (iVar1 != 0) {
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar5 = *(undefined4 *)(iVar2 + 0x1c);
		    uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar3,param1,
		               Method_Gameplay_Assistants_Manufacture_Control_ManufactureAssistRewardsStorageViewMediator_HandleDropChangedEvent__
		               ,0);
		    piVar4 = (int *)func_ii_7048(uVar5,uVar3,0);
		    iVar1 = System_Action_TypeInfo;
		    if (piVar4 == (int *)0x0) {
		      *(undefined4 *)(iVar2 + 0x1c) = 0;
		    }
		    else if ((System_Action_TypeInfo != *piVar4) ||
		            (*(int **)(iVar2 + 0x1c) = piVar4, *piVar4 != iVar1)) {
		      System_Activator__CreateInstance(piVar4,iVar1);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  param1[3] = param2;
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x13c));
		  if (iVar1 != 0) {
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar5 = *(undefined4 *)(iVar2 + 0x1c);
		    uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar3,param1,
		               Method_Gameplay_Assistants_Manufacture_Control_ManufactureAssistRewardsStorageViewMediator_HandleDropChangedEvent__
		               ,0);
		    piVar4 = (int *)UnityEngine_UI_Image__set_sprite(uVar5,uVar3,0);
		    iVar1 = System_Action_TypeInfo;
		    if (piVar4 == (int *)0x0) {
		      *(undefined4 *)(iVar2 + 0x1c) = 0;
		      return;
		    }
		    if ((System_Action_TypeInfo != *piVar4) || (*(int **)(iVar2 + 0x1c) = piVar4, *piVar4 != iVar1))
		    {
		      System_Activator__CreateInstance(piVar4,iVar1);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x1700101B RID: 4123
		// (set) Token: 0x06004F30 RID: 20272 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700101B")]
		public override ManufactureAssistantEvents Events
		{
			[Token(Token = "0x6004F30")]
			[Address(RVA = "0x9D58", Offset = "0x9D58", VA = "0x9D58", Slot = "16")]
			set
			{
			}
		}

		// Token: 0x1700101C RID: 4124
		// (set) Token: 0x06004F31 RID: 20273 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700101C")]
		public override ManufactureAssistantRewardStorageWindow View
		{
			[Token(Token = "0x6004F31")]
			[Address(RVA = "0x9D59", Offset = "0x9D59", VA = "0x9D59", Slot = "20")]
			set
			{
			}
		}

		// Token: 0x06004F32 RID: 20274 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004F32")]
		[Address(RVA = "0x9D5A", Offset = "0x9D5A", VA = "0x9D5A")]
		private void HandleSortValueChangedEvent(bool enabled)
		{
		/* --- GHIDRA: HandleSortValueChangedEvent ---
		void Gameplay_Assistants_Manufacture_Control_ManufactureAssistRewardsStorageViewMediator__HandleSortValueChangedEvent
		               (undefined4 param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 param1_00;
		  int *param1_01;
		  int iVar3;
		  
		  if (DAT_ram_00a589a0 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a589a0 = '\x01';
		  }
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  uVar1 = 0;
		  param1_01 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar3 = *param1_01;
		  if (*(ushort *)(iVar3 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + iVar3 + 0x120);
		        goto code_r0x80f53eaf;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_01,Core_Gameplay_IGame_TypeInfo,0xc);
		code_r0x80f53eaf:
		  param1_00 = (**(code **)((ulonglong)*puVar2 * 4))(param1_01,puVar2[1]);
		  Core_Gameplay_Managers_Inventory_InventoryManager__ShowChestWindow(param1_00,0);
		  return;
		}
		*/

		}

		// Token: 0x06004F33 RID: 20275 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004F33")]
		[Address(RVA = "0x9D5B", Offset = "0x9D5B", VA = "0x9D5B")]
		private void HandleInChestButtonClickEvent()
		{
		/* --- GHIDRA: HandleInChestButtonClickEvent ---
		void Gameplay_Assistants_Manufacture_Control_ManufactureAssistRewardsStorageViewMediator__HandleInChestButtonClickEvent
		               (int *param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  
		  param1_00 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x14c));
		  Gameplay_Assistants_Manufacture_Control_ManufactureAssistController__TakeAll(param1_00,param1);
		  return;
		}
		*/

		}

		// Token: 0x06004F34 RID: 20276 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004F34")]
		[Address(RVA = "0x9D5C", Offset = "0x9D5C", VA = "0x9D5C")]
		private void HandleSellAllDropButtonClickEvent()
		{
		/* --- GHIDRA: HandleSellAllDropButtonClickEvent ---
		void Gameplay_Assistants_Manufacture_Control_ManufactureAssistRewardsStorageViewMediator__HandleSellAllDropButtonClickEvent
		               (int *param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  
		  param1_00 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x14c));
		  Gameplay_Assistants_Manufacture_Control_ManufactureAssistController__Dismantle(param1_00,param1);
		  return;
		}
		*/

		}

		// Token: 0x06004F35 RID: 20277 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004F35")]
		[Address(RVA = "0x9D5D", Offset = "0x9D5D", VA = "0x9D5D")]
		private void HandleTakeAllDropButtonClickEvent()
		{
		/* --- GHIDRA: HandleTakeAllDropButtonClickEvent ---
		void Gameplay_Assistants_Manufacture_Control_ManufactureAssistRewardsStorageViewMediator__HandleTakeAllDropButtonClickEvent
		               (undefined4 param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 param1_00;
		  int *param1_01;
		  int iVar3;
		  int iVar4;
		  int local_4;
		  
		  if (DAT_ram_00a589a1 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_ArtifactData___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_List_ArtifactData__TypeInfo);
		    DAT_ram_00a589a1 = '\x01';
		  }
		  local_4 = 0;
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  uVar1 = 0;
		  param1_01 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar3 = *param1_01;
		  if (*(ushort *)(iVar3 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + iVar3 + 0x150);
		        goto code_r0x80f53fe1;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_01,Core_Gameplay_IGame_TypeInfo,0x12);
		code_r0x80f53fe1:
		  iVar3 = (**(code **)((ulonglong)*puVar2 * 4))(param1_01,puVar2[1]);
		  iVar4 = **(int **)(iVar3 + 0x10);
		  iVar3 = (**(code **)((ulonglong)*(uint *)(iVar4 + 0x100) * 4))
		                    (*(int **)(iVar3 + 0x10),*(undefined4 *)(iVar4 + 0x104));
		  if (DAT_ram_00a589da == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_DropTypes__ArtifactDropModel_ArtifactDrop__TryGetValue__
		              );
		    DAT_ram_00a589da = '\x01';
		  }
		  iVar3 = System_Collections_Generic_List_Enumerator_ValueTuple_object__double____MoveNext
		                    (*(undefined4 *)(iVar3 + 0x14),7,&local_4,
		                     Method_System_Collections_Generic_Dictionary_DropTypes__ArtifactDropModel_ArtifactDrop__TryGetValue__
		                    );
		  if (iVar3 == 0) {
		    param1_00 = unnamed_function_1417(System_Collections_Generic_List_ArtifactData__TypeInfo);
		    GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		              (param1_00,Method_System_Collections_Generic_List_ArtifactData___ctor__);
		  }
		  else {
		    param1_00 = *(undefined4 *)(local_4 + 0xc);
		  }
		  Gameplay_Assistants_Manufacture_Control_ManufactureAssistRewardsStorageViewMediator__SetupView
		            (param1,param1_00,param1_00);
		  return;
		}
		*/

		}

		// Token: 0x06004F36 RID: 20278 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004F36")]
		[Address(RVA = "0x9D5E", Offset = "0x9D5E", VA = "0x9D5E")]
		private void HandleDropChangedEvent()
		{
		/* --- GHIDRA: HandleDropChangedEvent ---
		void Gameplay_Assistants_Manufacture_Control_ManufactureAssistRewardsStorageViewMediator__HandleDropChangedEvent
		               (int *param1,undefined4 param2)
		
		{
		  uint uVar1;
		  int iVar2;
		  uint *puVar3;
		  int *param1_00;
		  int iVar4;
		  int local_4;
		  
		  if (DAT_ram_00a589a2 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_ManufactureAssistModel__ManufactureAssistantEvents__ManufactureAssistController__ManufactureAssistantRewardStorageWindow__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a589a2 = '\x01';
		  }
		  local_4 = 0;
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  func_ii_7603(*(undefined4 *)(iVar2 + 0x50),(uint)*(byte *)(param1[2] + 0x20),0);
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  uVar1 = 0;
		  param1_00 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar2 = *param1_00;
		  if (*(ushort *)(iVar2 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8 + 4) * 8 + iVar2 + 0x150);
		        goto code_r0x80f53ac9;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(param1_00,Core_Gameplay_IGame_TypeInfo,0x12);
		code_r0x80f53ac9:
		  iVar2 = (**(code **)((ulonglong)*puVar3 * 4))(param1_00,puVar3[1]);
		  iVar4 = **(int **)(iVar2 + 0x10);
		  iVar2 = (**(code **)((ulonglong)*(uint *)(iVar4 + 0x100) * 4))
		                    (*(int **)(iVar2 + 0x10),*(undefined4 *)(iVar4 + 0x104));
		  if (DAT_ram_00a589da == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_DropTypes__ArtifactDropModel_ArtifactDrop__TryGetValue__
		              );
		    DAT_ram_00a589da = '\x01';
		  }
		  iVar4 = System_Collections_Generic_List_Enumerator_ValueTuple_object__double____MoveNext
		                    (*(undefined4 *)(iVar2 + 0x14),7,&local_4,
		                     Method_System_Collections_Generic_Dictionary_DropTypes__ArtifactDropModel_ArtifactDrop__TryGetValue__
		                    );
		  if (iVar4 != 0) {
		    Gameplay_Assistants_Manufacture_Control_ManufactureAssistRewardsStorageViewMediator__SetupView
		              (param1,*(undefined4 *)(local_4 + 0xc),iVar2);
		  }
		  return;
		}
		*/

		}

		// Token: 0x06004F37 RID: 20279 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004F37")]
		[Address(RVA = "0x9D5F", Offset = "0x9D5F", VA = "0x9D5F")]
		private void SetupView()
		{
		/* --- GHIDRA: SetupView ---
		void Gameplay_Assistants_Manufacture_Control_ManufactureAssistRewardsStorageViewMediator__SetupView
		               (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  undefined4 param1_00;
		  undefined4 *puVar3;
		  
		  if (DAT_ram_00a589a3 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_ManufactureAssistModel__ManufactureAssistantEvents__ManufactureAssistController__ManufactureAssistantRewardStorageWindow__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_Any_ArtifactData___);
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_OrderBy_ArtifactData__uint___);
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_ToList_ArtifactData___);
		    Mono_Security_ASN1__get_Item(&System_Func_ArtifactData__uint__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Assistants_Manufacture_Control_ManufactureAssistRewardsStorageViewMediator___c__RenderItems_b__11_0__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Gameplay_Assistants_Manufacture_Control_ManufactureAssistRewardsStorageViewMediator___c_TypeInfo
		              );
		    DAT_ram_00a589a3 = '\x01';
		  }
		  if ((*(char *)(param1[2] + 0x20) != '\0') &&
		     (iVar2 = System_Linq_Enumerable__OrderBy_object__ulong_
		                        (param2,Method_System_Linq_Enumerable_Any_ArtifactData___), iVar2 != 0)) {
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    param1_00 = *(undefined4 *)(iVar2 + 0x40);
		    if (*(int *)(
		                Gameplay_Assistants_Manufacture_Control_ManufactureAssistRewardsStorageViewMediator___c_TypeInfo
		                + 0x74) == 0) {
		      func_ii_306000(
		                    Gameplay_Assistants_Manufacture_Control_ManufactureAssistRewardsStorageViewMediator___c_TypeInfo
		                    );
		    }
		    puVar3 = *(undefined4 **)
		              (
		              Gameplay_Assistants_Manufacture_Control_ManufactureAssistRewardsStorageViewMediator___c_TypeInfo
		              + 0x5c);
		    iVar2 = puVar3[1];
		    if (iVar2 == 0) {
		      if (*(int *)(
		                  Gameplay_Assistants_Manufacture_Control_ManufactureAssistRewardsStorageViewMediator___c_TypeInfo
		                  + 0x74) == 0) {
		        func_ii_306000(
		                      Gameplay_Assistants_Manufacture_Control_ManufactureAssistRewardsStorageViewMediator___c_TypeInfo
		                      );
		        puVar3 = *(undefined4 **)
		                  (
		                  Gameplay_Assistants_Manufacture_Control_ManufactureAssistRewardsStorageViewMediator___c_TypeInfo
		                  + 0x5c);
		      }
		      uVar1 = *puVar3;
		      iVar2 = unnamed_function_1417(System_Func_ArtifactData__uint__TypeInfo);
		      System_Collections_Generic_Dictionary_KeyCollection_uint__object___GetEnumerator
		                (iVar2,uVar1,
		                 Method_Gameplay_Assistants_Manufacture_Control_ManufactureAssistRewardsStorageViewMediator___c__RenderItems_b__11_0__
		                 ,0);
		      *(int *)(*(int *)(
		                       Gameplay_Assistants_Manufacture_Control_ManufactureAssistRewardsStorageViewMediator___c_TypeInfo
		                       + 0x5c) + 4) = iVar2;
		    }
		    uVar1 = System_Linq_Enumerable__Min___Il2CppFullySharedGenericType____Il2CppFullySharedGenericType_
		                      (param2,iVar2,Method_System_Linq_Enumerable_OrderBy_ArtifactData__uint___);
		    uVar1 = System_Linq_Enumerable__Select_object__object_
		                      (uVar1,Method_System_Linq_Enumerable_ToList_ArtifactData___);
		    Gameplay_SmallGames_View_RewardStorageOSAView__RemoveItemsFrom(param1_00,uVar1,0);
		    return;
		  }
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  Gameplay_SmallGames_View_RewardStorageOSAView__RemoveItemsFrom
		            (*(undefined4 *)(iVar2 + 0x40),param2,0);
		  return;
		}
		*/

		}

		// Token: 0x06004F38 RID: 20280 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004F38")]
		[Address(RVA = "0x9D60", Offset = "0x9D60", VA = "0x9D60")]
		private void RenderItems([NotNull] IList<ArtifactData> items)
		{
		/* --- GHIDRA: RenderItems ---
		void Gameplay_Assistants_Manufacture_Control_ManufactureAssistRewardsStorageViewMediator__RenderItems
		               (undefined4 param1)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a589a4 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Gameplay_Assistants_Manufacture_Control_ManufactureAssistRewardsStorageViewMediator___c_TypeInfo
		              );
		    DAT_ram_00a589a4 = '\x01';
		  }
		  uVar1 = unnamed_function_1417
		                    (
		                    Gameplay_Assistants_Manufacture_Control_ManufactureAssistRewardsStorageViewMediator___c_TypeInfo
		                    );
		  **(undefined4 **)
		    (
		    Gameplay_Assistants_Manufacture_Control_ManufactureAssistRewardsStorageViewMediator___c_TypeInfo
		    + 0x5c) = uVar1;
		  return;
		}
		*/

		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_Events ---
		void Gameplay_Assistants_Manufacture_Control_ManufactureAssistRewardsStorageViewMediator__set_Events
		               (int *param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  undefined4 uVar3;
		  
		  if (DAT_ram_00a5899e == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_ManufactureAssistModel__ManufactureAssistantEvents__ManufactureAssistController__ManufactureAssistantRewardStorageWindow__set_View__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Assistants_Manufacture_Control_ManufactureAssistRewardsStorageViewMediator_HandleInChestButtonClickEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Assistants_Manufacture_Control_ManufactureAssistRewardsStorageViewMediator_HandleSellAllDropButtonClickEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Assistants_Manufacture_Control_ManufactureAssistRewardsStorageViewMediator_HandleSortValueChangedEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Assistants_Manufacture_Control_ManufactureAssistRewardsStorageViewMediator_HandleTakeAllDropButtonClickEvent__
		              );
		    Mono_Security_ASN1__get_Item(&UnityEngine_Events_UnityAction_bool__TypeInfo);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Events_UnityAction_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Events_UnityEvent_bool__AddListener__);
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Events_UnityEvent_bool__RemoveListener__);
		    DAT_ram_00a5899e = '\x01';
		  }
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar2 = Cysharp_Threading_Tasks_CancellationTokenExtensions___cctor(uVar1,0);
		  if (iVar2 != 0) {
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar3 = *(undefined4 *)(*(int *)(iVar2 + 0x50) + 0xc0);
		    uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_bool__TypeInfo);
		    UnityEngine_UI_Toggle__set_group
		              (uVar1,param1,
		               Method_Gameplay_Assistants_Manufacture_Control_ManufactureAssistRewardsStorageViewMediator_HandleSortValueChangedEvent__
		               ,0);
		    UnityEngine_Events_UnityEvent_InputAction_CallbackContext___Invoke
		              (uVar3,uVar1,Method_UnityEngine_Events_UnityEvent_bool__RemoveListener__);
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar3 = *(undefined4 *)(*(int *)(iVar2 + 0x4c) + 0xb4);
		    uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		    Utils_ObjectUtils__IsNotNull
		              (uVar1,param1,
		               Method_Gameplay_Assistants_Manufacture_Control_ManufactureAssistRewardsStorageViewMediator_HandleInChestButtonClickEvent__
		               ,0);
		    UnityEngine_Events_UnityAction___ctor(uVar3,uVar1,0);
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar3 = *(undefined4 *)(*(int *)(iVar2 + 0x48) + 0xb4);
		    uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		    Utils_ObjectUtils__IsNotNull
		              (uVar1,param1,
		               Method_Gameplay_Assistants_Manufacture_Control_ManufactureAssistRewardsStorageViewMediator_HandleSellAllDropButtonClickEvent__
		               ,0);
		    UnityEngine_Events_UnityAction___ctor(uVar3,uVar1,0);
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar3 = *(undefined4 *)(*(int *)(iVar2 + 0x44) + 0xb4);
		    uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		    Utils_ObjectUtils__IsNotNull
		              (uVar1,param1,
		               Method_Gameplay_Assistants_Manufacture_Control_ManufactureAssistRewardsStorageViewMediator_HandleTakeAllDropButtonClickEvent__
		               ,0);
		    UnityEngine_Events_UnityAction___ctor(uVar3,uVar1,0);
		  }
		  param1[5] = param2;
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar2 = Cysharp_Threading_Tasks_CancellationTokenExtensions___cctor(uVar1,0);
		  if (iVar2 != 0) {
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar3 = *(undefined4 *)(*(int *)(iVar2 + 0x50) + 0xc0);
		    uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_bool__TypeInfo);
		    UnityEngine_UI_Toggle__set_group
		              (uVar1,param1,
		               Method_Gameplay_Assistants_Manufacture_Control_ManufactureAssistRewardsStorageViewMediator_HandleSortValueChangedEvent__
		               ,0);
		    UnityEngine_Events_UnityEvent_InputAction_CallbackContext____ctor
		              (uVar3,uVar1,Method_UnityEngine_Events_UnityEvent_bool__AddListener__);
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar3 = *(undefined4 *)(*(int *)(iVar2 + 0x4c) + 0xb4);
		    uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		    Utils_ObjectUtils__IsNotNull
		              (uVar1,param1,
		               Method_Gameplay_Assistants_Manufacture_Control_ManufactureAssistRewardsStorageViewMediator_HandleInChestButtonClickEvent__
		               ,0);
		    Gameplay_Boss_View_CaptainTab_BossInfoView__add_AttackButtonClickEvent(uVar3,uVar1,0);
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar3 = *(undefined4 *)(*(int *)(iVar2 + 0x48) + 0xb4);
		    uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		    Utils_ObjectUtils__IsNotNull
		              (uVar1,param1,
		               Method_Gameplay_Assistants_Manufacture_Control_ManufactureAssistRewardsStorageViewMediator_HandleSellAllDropButtonClickEvent__
		               ,0);
		    Gameplay_Boss_View_CaptainTab_BossInfoView__add_AttackButtonClickEvent(uVar3,uVar1,0);
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar3 = *(undefined4 *)(*(int *)(iVar2 + 0x44) + 0xb4);
		    uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		    Utils_ObjectUtils__IsNotNull
		              (uVar1,param1,
		               Method_Gameplay_Assistants_Manufacture_Control_ManufactureAssistRewardsStorageViewMediator_HandleTakeAllDropButtonClickEvent__
		               ,0);
		    Gameplay_Boss_View_CaptainTab_BossInfoView__add_AttackButtonClickEvent(uVar3,uVar1,0);
		    Gameplay_Assistants_Manufacture_Control_ManufactureAssistRewardsStorageViewMediator__HandleDropChangedEvent
		              (param1,param1);
		  }
		  return;
		}
		*/


		/* --- GHIDRA: set_View ---
		void Gameplay_Assistants_Manufacture_Control_ManufactureAssistRewardsStorageViewMediator__set_View
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  int *param1_00;
		  int iVar3;
		  int iVar4;
		  int local_4;
		  
		  if (DAT_ram_00a5899f == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_ManufactureAssistModel__ManufactureAssistantEvents__ManufactureAssistController__ManufactureAssistantRewardStorageWindow__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a5899f = '\x01';
		  }
		  local_4 = 0;
		  *(undefined1 *)(*(int *)(param1 + 8) + 0x20) = (undefined1)param2;
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  uVar1 = 0;
		  param1_00 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar3 = *param1_00;
		  if (*(ushort *)(iVar3 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + iVar3 + 0x150);
		        goto code_r0x80f53d76;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_00,Core_Gameplay_IGame_TypeInfo,0x12);
		code_r0x80f53d76:
		  iVar3 = (**(code **)((ulonglong)*puVar2 * 4))(param1_00,puVar2[1]);
		  iVar4 = **(int **)(iVar3 + 0x10);
		  iVar3 = (**(code **)((ulonglong)*(uint *)(iVar4 + 0x100) * 4))
		                    (*(int **)(iVar3 + 0x10),*(undefined4 *)(iVar4 + 0x104));
		  if (DAT_ram_00a589da == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_DropTypes__ArtifactDropModel_ArtifactDrop__TryGetValue__
		              );
		    DAT_ram_00a589da = '\x01';
		  }
		  iVar4 = System_Collections_Generic_List_Enumerator_ValueTuple_object__double____MoveNext
		                    (*(undefined4 *)(iVar3 + 0x14),7,&local_4,
		                     Method_System_Collections_Generic_Dictionary_DropTypes__ArtifactDropModel_ArtifactDrop__TryGetValue__
		                    );
		  if (iVar4 != 0) {
		    Gameplay_Assistants_Manufacture_Control_ManufactureAssistRewardsStorageViewMediator__SetupView
		              (param1,*(undefined4 *)(local_4 + 0xc),iVar3);
		  }
		  return;
		}
		*/

}
