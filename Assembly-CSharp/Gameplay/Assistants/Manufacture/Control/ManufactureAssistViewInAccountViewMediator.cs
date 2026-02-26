using System;
using System.Collections.Generic;
using Core.Data;
using Gameplay.Assistants.Manufacture.Model;
using Gameplay.Assistants.Manufacture.View;
using Il2CppDummyDll;
using MVC;
using Protocol.Common;
using UnityEngine.EventSystems;

namespace Gameplay.Assistants.Manufacture.Control
{
	// Token: 0x02000CB4 RID: 3252
	[Token(Token = "0x2000CB4")]
	public class ManufactureAssistViewInAccountViewMediator : AbstractViewMediator<ManufactureAssistModel, ManufactureAssistantEvents, ManufactureAssistController, ManufactureViewInAccountView>
	{
		// Token: 0x06004F3C RID: 20284 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004F3C")]
		[Address(RVA = "0x9D64", Offset = "0x9D64", VA = "0x9D64")]
		public ManufactureAssistViewInAccountViewMediator(ManufactureAssistModel model, ManufactureAssistantEvents events, ManufactureAssistController controller)
		{
		/* --- GHIDRA: <ShowSelectCountForDisassembleWindow>b__15_0 ---
		void Gameplay_Assistants_Manufacture_Control_ManufactureAssistViewInAccountViewMediator___ShowSelectCountForDisassembleWindow_b__15_0
		               (undefined4 param1)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a589b6 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Gameplay_Assistants_Manufacture_Control_ManufactureAssistViewInAccountViewMediator___c_TypeInfo
		              );
		    DAT_ram_00a589b6 = '\x01';
		  }
		  uVar1 = unnamed_function_1417
		                    (
		                    Gameplay_Assistants_Manufacture_Control_ManufactureAssistViewInAccountViewMediator___c_TypeInfo
		                    );
		  **(undefined4 **)
		    (Gameplay_Assistants_Manufacture_Control_ManufactureAssistViewInAccountViewMediator___c_TypeInfo
		    + 0x5c) = uVar1;
		  return;
		}
		*/

		/* --- GHIDRA: .cctor ---
		void Gameplay_Assistants_Manufacture_Control_ManufactureAssistViewInAccountViewMediator___cctor
		               (int *param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  undefined4 param1_00;
		  
		  param1_00 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x14c));
		  Gameplay_Assistants_Manufacture_Control_ManufactureAssistController__Take(param1_00,param3,param1)
		  ;
		  return;
		}
		*/

		/* --- GHIDRA: .ctor ---
		void Gameplay_Assistants_Manufacture_Control_ManufactureAssistViewInAccountViewMediator___ctor
		               (int *param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  int iVar3;
		  int iVar4;
		  int *piVar5;
		  undefined4 uVar6;
		  
		  if (DAT_ram_00a589a6 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_ManufactureAssistModel__ManufactureAssistantEvents__ManufactureAssistController__ManufactureViewInAccountView__set_Events__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_ArtifactInfo__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Assistants_Manufacture_Control_ManufactureAssistViewInAccountViewMediator_HandleDismantleSlotsChangedEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Assistants_Manufacture_Control_ManufactureAssistViewInAccountViewMediator_HandleDismantleStatusChangedEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Assistants_Manufacture_Control_ManufactureAssistViewInAccountViewMediator_HandleDropChangedEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Assistants_Manufacture_Control_ManufactureAssistViewInAccountViewMediator_HandleInfoChangedEvent__
		              );
		    DAT_ram_00a589a6 = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x13c));
		  if (iVar1 != 0) {
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar6 = *(undefined4 *)(iVar1 + 0x20);
		    uVar2 = unnamed_function_1417(System_Action_ArtifactInfo__TypeInfo);
		    UnityEngine_UIElements_VisualElement__get_layout
		              (uVar2,param1,
		               Method_Gameplay_Assistants_Manufacture_Control_ManufactureAssistViewInAccountViewMediator_HandleDismantleSlotsChangedEvent__
		               ,0);
		    iVar3 = func_ii_7048(uVar6,uVar2,0);
		    uVar2 = System_Action_ArtifactInfo__TypeInfo;
		    if (iVar3 == 0) {
		      *(undefined4 *)(iVar1 + 0x20) = 0;
		    }
		    else {
		      iVar4 = func_ii_1082(iVar3,System_Action_ArtifactInfo__TypeInfo);
		      if (iVar4 == 0) {
		        System_Activator__CreateInstance(iVar3,uVar2);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      *(int *)(iVar1 + 0x20) = iVar4;
		      uVar2 = System_Action_ArtifactInfo__TypeInfo;
		      iVar1 = func_ii_1082(iVar3,System_Action_ArtifactInfo__TypeInfo);
		      if (iVar1 == 0) {
		        System_Activator__CreateInstance(iVar3,uVar2);
		        do {
		          halt_trap();
		        } while( true );
		      }
		    }
		    iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar6 = *(undefined4 *)(iVar3 + 0x14);
		    uVar2 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar2,param1,
		               Method_Gameplay_Assistants_Manufacture_Control_ManufactureAssistViewInAccountViewMediator_HandleDismantleStatusChangedEvent__
		               ,0);
		    piVar5 = (int *)func_ii_7048(uVar6,uVar2,0);
		    iVar1 = System_Action_TypeInfo;
		    if (piVar5 == (int *)0x0) {
		      *(undefined4 *)(iVar3 + 0x14) = 0;
		    }
		    else if ((System_Action_TypeInfo != *piVar5) ||
		            (*(int **)(iVar3 + 0x14) = piVar5, *piVar5 != iVar1)) {
		      System_Activator__CreateInstance(piVar5,iVar1);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar6 = *(undefined4 *)(iVar3 + 0x1c);
		    uVar2 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar2,param1,
		               Method_Gameplay_Assistants_Manufacture_Control_ManufactureAssistViewInAccountViewMediator_HandleDropChangedEvent__
		               ,0);
		    piVar5 = (int *)func_ii_7048(uVar6,uVar2,0);
		    iVar1 = System_Action_TypeInfo;
		    if (piVar5 == (int *)0x0) {
		      *(undefined4 *)(iVar3 + 0x1c) = 0;
		    }
		    else if ((System_Action_TypeInfo != *piVar5) ||
		            (*(int **)(iVar3 + 0x1c) = piVar5, *piVar5 != iVar1)) {
		      System_Activator__CreateInstance(piVar5,iVar1);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar6 = *(undefined4 *)(iVar3 + 0x18);
		    uVar2 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar2,param1,
		               Method_Gameplay_Assistants_Manufacture_Control_ManufactureAssistViewInAccountViewMediator_HandleInfoChangedEvent__
		               ,0);
		    piVar5 = (int *)func_ii_7048(uVar6,uVar2,0);
		    iVar1 = System_Action_TypeInfo;
		    if (piVar5 == (int *)0x0) {
		      *(undefined4 *)(iVar3 + 0x18) = 0;
		    }
		    else if ((System_Action_TypeInfo != *piVar5) ||
		            (*(int **)(iVar3 + 0x18) = piVar5, *piVar5 != iVar1)) {
		      System_Activator__CreateInstance(piVar5,iVar1);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  param1[3] = param2;
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x13c));
		  if (iVar1 != 0) {
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar6 = *(undefined4 *)(iVar1 + 0x20);
		    uVar2 = unnamed_function_1417(System_Action_ArtifactInfo__TypeInfo);
		    UnityEngine_UIElements_VisualElement__get_layout
		              (uVar2,param1,
		               Method_Gameplay_Assistants_Manufacture_Control_ManufactureAssistViewInAccountViewMediator_HandleDismantleSlotsChangedEvent__
		               ,0);
		    iVar3 = UnityEngine_UI_Image__set_sprite(uVar6,uVar2,0);
		    uVar2 = System_Action_ArtifactInfo__TypeInfo;
		    if (iVar3 == 0) {
		      *(undefined4 *)(iVar1 + 0x20) = 0;
		    }
		    else {
		      iVar4 = func_ii_1082(iVar3,System_Action_ArtifactInfo__TypeInfo);
		      if (iVar4 == 0) {
		        System_Activator__CreateInstance(iVar3,uVar2);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      *(int *)(iVar1 + 0x20) = iVar4;
		      uVar2 = System_Action_ArtifactInfo__TypeInfo;
		      iVar1 = func_ii_1082(iVar3,System_Action_ArtifactInfo__TypeInfo);
		      if (iVar1 == 0) {
		        System_Activator__CreateInstance(iVar3,uVar2);
		        do {
		          halt_trap();
		        } while( true );
		      }
		    }
		    iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar6 = *(undefined4 *)(iVar3 + 0x14);
		    uVar2 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar2,param1,
		               Method_Gameplay_Assistants_Manufacture_Control_ManufactureAssistViewInAccountViewMediator_HandleDismantleStatusChangedEvent__
		               ,0);
		    piVar5 = (int *)UnityEngine_UI_Image__set_sprite(uVar6,uVar2,0);
		    iVar1 = System_Action_TypeInfo;
		    if (piVar5 == (int *)0x0) {
		      *(undefined4 *)(iVar3 + 0x14) = 0;
		    }
		    else if ((System_Action_TypeInfo != *piVar5) ||
		            (*(int **)(iVar3 + 0x14) = piVar5, *piVar5 != iVar1)) {
		      System_Activator__CreateInstance(piVar5,iVar1);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar6 = *(undefined4 *)(iVar3 + 0x1c);
		    uVar2 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar2,param1,
		               Method_Gameplay_Assistants_Manufacture_Control_ManufactureAssistViewInAccountViewMediator_HandleDropChangedEvent__
		               ,0);
		    piVar5 = (int *)UnityEngine_UI_Image__set_sprite(uVar6,uVar2,0);
		    iVar1 = System_Action_TypeInfo;
		    if (piVar5 == (int *)0x0) {
		      *(undefined4 *)(iVar3 + 0x1c) = 0;
		    }
		    else if ((System_Action_TypeInfo != *piVar5) ||
		            (*(int **)(iVar3 + 0x1c) = piVar5, *piVar5 != iVar1)) {
		      System_Activator__CreateInstance(piVar5,iVar1);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar6 = *(undefined4 *)(iVar3 + 0x18);
		    uVar2 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar2,param1,
		               Method_Gameplay_Assistants_Manufacture_Control_ManufactureAssistViewInAccountViewMediator_HandleInfoChangedEvent__
		               ,0);
		    piVar5 = (int *)UnityEngine_UI_Image__set_sprite(uVar6,uVar2,0);
		    iVar1 = System_Action_TypeInfo;
		    if (piVar5 == (int *)0x0) {
		      *(undefined4 *)(iVar3 + 0x18) = 0;
		      return;
		    }
		    if ((System_Action_TypeInfo != *piVar5) || (*(int **)(iVar3 + 0x18) = piVar5, *piVar5 != iVar1))
		    {
		      System_Activator__CreateInstance(piVar5,iVar1);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x1700101D RID: 4125
		// (set) Token: 0x06004F3D RID: 20285 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700101D")]
		public override ManufactureAssistantEvents Events
		{
			[Token(Token = "0x6004F3D")]
			[Address(RVA = "0x9D65", Offset = "0x9D65", VA = "0x9D65", Slot = "16")]
			set
			{
			}
		}

		// Token: 0x1700101E RID: 4126
		// (set) Token: 0x06004F3E RID: 20286 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700101E")]
		public override ManufactureViewInAccountView View
		{
			[Token(Token = "0x6004F3E")]
			[Address(RVA = "0x9D66", Offset = "0x9D66", VA = "0x9D66", Slot = "20")]
			set
			{
			}
		}

		// Token: 0x06004F3F RID: 20287 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004F3F")]
		[Address(RVA = "0x9D67", Offset = "0x9D67", VA = "0x9D67")]
		private void HandleAddButtonClickEvent(PointerEventData data)
		{
		/* --- GHIDRA: HandleAddButtonClickEvent ---
		void Gameplay_Assistants_Manufacture_Control_ManufactureAssistViewInAccountViewMediator__HandleAddButtonClickEvent
		               (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  int iVar3;
		  int local_4;
		  
		  if (DAT_ram_00a589a9 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_ManufactureAssistModel__ManufactureAssistantEvents__ManufactureAssistController__ManufactureViewInAccountView__get_Model__
		              );
		    DAT_ram_00a589a9 = '\x01';
		  }
		  local_4 = 0;
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar3 = **(int **)(iVar1 + 0x20);
		  uVar2 = (**(code **)((ulonglong)*(uint *)(iVar3 + 0x130) * 4))
		                    (*(int **)(iVar1 + 0x20),*(undefined4 *)(iVar3 + 0x134));
		  iVar3 = Gameplay_Assistants_Manufacture_Model_ManufactureAssistModel__get_TotalStackSize
		                    (param1[2],uVar2,&local_4,param1);
		  iVar1 = local_4;
		  if (iVar3 == 0) {
		    Gameplay_Assistants_Manufacture_Control_ManufactureAssistViewInAccountViewMediator__ShowSelectCountForDisassembleWindow
		              (param1,local_4,param1);
		    if (iVar1 == 4) {
		      Gameplay_Assistants_Manufacture_Control_ManufactureAssistViewInAccountViewMediator__ValidateDescription
		                (param1,param1);
		    }
		  }
		  else {
		    uVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x14c));
		    Gameplay_Assistants_Manufacture_Control_ManufactureAssistController__Take(uVar2,0,param1);
		  }
		  return;
		}
		*/

		}

		// Token: 0x06004F40 RID: 20288 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004F40")]
		[Address(RVA = "0x9D68", Offset = "0x9D68", VA = "0x9D68")]
		private void HandleDisassembleAllButtonClickEvent()
		{
		/* --- GHIDRA: HandleDisassembleAllButtonClickEvent ---
		void Gameplay_Assistants_Manufacture_Control_ManufactureAssistViewInAccountViewMediator__HandleDisassembleAllButtonClickEvent
		               (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 param2_00;
		  int iVar2;
		  int local_4;
		  
		  if (DAT_ram_00a589aa == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_ManufactureAssistModel__ManufactureAssistantEvents__ManufactureAssistController__ManufactureViewInAccountView__get_Model__
		              );
		    DAT_ram_00a589aa = '\x01';
		  }
		  local_4 = 0;
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar2 = **(int **)(iVar1 + 0x20);
		  param2_00 = (**(code **)((ulonglong)*(uint *)(iVar2 + 0x130) * 4))
		                        (*(int **)(iVar1 + 0x20),*(undefined4 *)(iVar2 + 0x134));
		  iVar2 = Gameplay_Assistants_Manufacture_Model_ManufactureAssistModel__get_TotalStackSize
		                    (param1[2],param2_00,&local_4,param1);
		  iVar1 = local_4;
		  if (iVar2 == 0) {
		    Gameplay_Assistants_Manufacture_Control_ManufactureAssistViewInAccountViewMediator__ShowSelectCountForDisassembleWindow
		              (param1,local_4,param1);
		    if (iVar1 == 4) {
		      Gameplay_Assistants_Manufacture_Control_ManufactureAssistViewInAccountViewMediator__ValidateDescription
		                (param1,param1);
		    }
		  }
		  else {
		    iVar1 = Gameplay_Inventory_Model_InventoryBaseModel__GetArtifactById(param2_00,0);
		    if (iVar1 == 0) {
		      Gameplay_Assistants_Manufacture_Control_ManufactureAssistViewInAccountViewMediator__ShowSelectCountForDisassembleWindow
		                (param1,2,param1);
		    }
		    else {
		      Gameplay_Assistants_Manufacture_Control_ManufactureAssistViewInAccountViewMediator__ValidateDismantleControls
		                (param1,param2_00,param1);
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x06004F41 RID: 20289 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004F41")]
		[Address(RVA = "0x9D69", Offset = "0x9D69", VA = "0x9D69")]
		private void HandleDisassemblePartButtonClickEvent()
		{
		/* --- GHIDRA: HandleDisassemblePartButtonClickEvent ---
		void Gameplay_Assistants_Manufacture_Control_ManufactureAssistViewInAccountViewMediator__HandleDisassemblePartButtonClickEvent
		               (undefined4 param1,undefined4 param2)
		
		{
		  Gameplay_Assistants_Manufacture_Control_ManufactureAssistViewInAccountViewMediator__ValidateDescription
		            (param1,param1);
		  return;
		}
		*/

		}

		// Token: 0x06004F42 RID: 20290 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004F42")]
		[Address(RVA = "0x9D6A", Offset = "0x9D6A", VA = "0x9D6A")]
		private void HandleOpenRewardsButtonClickEvent()
		{
		/* --- GHIDRA: HandleOpenRewardsButtonClickEvent ---
		void Gameplay_Assistants_Manufacture_Control_ManufactureAssistViewInAccountViewMediator__HandleOpenRewardsButtonClickEvent
		               (int *param1,int param2,undefined4 param3)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 uVar3;
		  int iVar4;
		  int *param1_00;
		  int iVar5;
		  int iVar6;
		  
		  if (DAT_ram_00a589ab == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_ManufactureAssistModel__ManufactureAssistantEvents__ManufactureAssistController__ManufactureViewInAccountView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a589ab = '\x01';
		  }
		  if (param2 == 0) {
		    iVar5 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    iVar4 = **(int **)(iVar5 + 0x20);
		    (**(code **)((ulonglong)*(uint *)(iVar4 + 0x138) * 4))
		              (*(int **)(iVar5 + 0x20),0,*(undefined4 *)(iVar4 + 0x13c));
		  }
		  else {
		    if (DAT_ram_00a6456f == '\0') {
		      Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		      DAT_ram_00a6456f = '\x01';
		    }
		    param1_00 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		    iVar5 = *param1_00;
		    if (*(ushort *)(iVar5 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		          puVar2 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0x158);
		          goto code_r0x80f5526e;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		    }
		    puVar2 = (uint *)func_ii_1080(param1_00,Core_Gameplay_IGame_TypeInfo,0x13);
		code_r0x80f5526e:
		    uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(param1_00,puVar2[1]);
		    uVar3 = Core_Gameplay_Managers_CacheManager__GetEndOfFrameCacheRequestAccumulator(uVar3,0);
		    iVar5 = func_ii_8553(uVar3,param2,*(undefined4 *)(param1[2] + 8),0);
		    *(undefined4 *)(iVar5 + 0x80) = 5;
		    iVar4 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    iVar6 = **(int **)(iVar4 + 0x20);
		    (**(code **)((ulonglong)*(uint *)(iVar6 + 0x138) * 4))
		              (*(int **)(iVar4 + 0x20),iVar5,*(undefined4 *)(iVar6 + 0x13c));
		  }
		  iVar4 = *param1;
		  iVar5 = (**(code **)((ulonglong)*(uint *)(iVar4 + 0x158) * 4))
		                    (param1,*(undefined4 *)(iVar4 + 0x15c));
		  uVar3 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (*(undefined4 *)(iVar5 + 0x20),0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar3,(uint)(param2 != 0),0);
		  Gameplay_Assistants_Manufacture_Control_ManufactureAssistViewInAccountViewMediator__HandleDisassembleFailReason
		            (param1,iVar4);
		  return;
		}
		*/

		}

		// Token: 0x06004F43 RID: 20291 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004F43")]
		[Address(RVA = "0x9D6B", Offset = "0x9D6B", VA = "0x9D6B")]
		private void HandleDismantleSlotsChangedEvent(ArtifactInfo info)
		{
		/* --- GHIDRA: HandleDismantleSlotsChangedEvent ---
		void Gameplay_Assistants_Manufacture_Control_ManufactureAssistViewInAccountViewMediator__HandleDismantleSlotsChangedEvent
		               (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a589ac == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_ManufactureAssistModel__ManufactureAssistantEvents__ManufactureAssistController__ManufactureViewInAccountView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_ArtifactInfo__get_Count__);
		    DAT_ram_00a589ac = '\x01';
		  }
		  Gameplay_Assistants_Manufacture_Control_ManufactureAssistViewInAccountViewMediator__SetupView
		            (param1,param1);
		  Gameplay_Assistants_Manufacture_Control_ManufactureAssistViewInAccountViewMediator__HandleDisassembleFailReason
		            (param1,param1);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  param1_00 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                        (*(undefined4 *)(iVar1 + 0x24),0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (param1_00,(uint)(0 < *(int *)(*(int *)(*(int *)(param1[2] + 0x24) + 0x18) + 0xc)),0);
		  return;
		}
		*/

		}

		// Token: 0x06004F44 RID: 20292 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004F44")]
		[Address(RVA = "0x9D6C", Offset = "0x9D6C", VA = "0x9D6C")]
		private void HandleDismantleStatusChangedEvent()
		{
		/* --- GHIDRA: HandleDismantleStatusChangedEvent ---
		void Gameplay_Assistants_Manufacture_Control_ManufactureAssistViewInAccountViewMediator__HandleDismantleStatusChangedEvent
		               (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 param1_00;
		  undefined4 uVar2;
		  
		  if (DAT_ram_00a589ad == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_ManufactureAssistModel__ManufactureAssistantEvents__ManufactureAssistController__ManufactureViewInAccountView__get_Model__
		              );
		    DAT_ram_00a589ad = '\x01';
		  }
		  iVar1 = param1[2];
		  if (DAT_ram_00a58981 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_ArtifactInfo__get_Count__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_ArtifactInfo__get_Item__);
		    DAT_ram_00a58981 = '\x01';
		  }
		  iVar1 = *(int *)(*(int *)(iVar1 + 0x24) + 0x14);
		  if (*(int *)(iVar1 + 0xc) < 1) {
		    uVar2 = 0;
		  }
		  else {
		    uVar2 = Google_Protobuf_Collections_RepeatedField_Int32Enum___get_IsReadOnly
		                      (iVar1,0,
		                       Method_Google_Protobuf_Collections_RepeatedField_ArtifactInfo__get_Item__);
		  }
		  Gameplay_Assistants_Manufacture_Control_ManufactureAssistViewInAccountViewMediator__HandleOpenRewardsButtonClickEvent
		            (param1,uVar2,param1);
		  Gameplay_Assistants_Manufacture_Control_ManufactureAssistViewInAccountViewMediator__HandleDismantleSlotsChangedEvent
		            (param1,param1);
		  if (DAT_ram_00a589ae == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_ManufactureAssistModel__ManufactureAssistantEvents__ManufactureAssistController__ManufactureViewInAccountView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_Count_ArtifactData___);
		    DAT_ram_00a589ae = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  param1_00 = *(undefined4 *)(iVar1 + 0x38);
		  uVar2 = Gameplay_Assistants_Manufacture_Model_ManufactureAssistModel__CheckStartDisassembleCommon
		                    (param1[2],param1);
		  uVar2 = func_ii_6330(uVar2,Method_System_Linq_Enumerable_Count_ArtifactData___);
		  System_Collections_Generic_Dictionary_int__object___get_Count(param1_00,uVar2,0);
		  return;
		}
		*/

		}

		// Token: 0x06004F45 RID: 20293 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004F45")]
		[Address(RVA = "0x9D6D", Offset = "0x9D6D", VA = "0x9D6D")]
		private void HandleInfoChangedEvent()
		{
		/* --- GHIDRA: HandleInfoChangedEvent ---
		void Gameplay_Assistants_Manufacture_Control_ManufactureAssistViewInAccountViewMediator__HandleInfoChangedEvent
		               (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a589ae == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_ManufactureAssistModel__ManufactureAssistantEvents__ManufactureAssistController__ManufactureViewInAccountView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_Count_ArtifactData___);
		    DAT_ram_00a589ae = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  param1_00 = *(undefined4 *)(iVar1 + 0x38);
		  uVar2 = Gameplay_Assistants_Manufacture_Model_ManufactureAssistModel__CheckStartDisassembleCommon
		                    (param1[2],param1);
		  uVar2 = func_ii_6330(uVar2,Method_System_Linq_Enumerable_Count_ArtifactData___);
		  System_Collections_Generic_Dictionary_int__object___get_Count(param1_00,uVar2,0);
		  return;
		}
		*/

		}

		// Token: 0x06004F46 RID: 20294 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004F46")]
		[Address(RVA = "0x9D6E", Offset = "0x9D6E", VA = "0x9D6E")]
		private void HandleDropChangedEvent()
		{
		/* --- GHIDRA: HandleDropChangedEvent ---
		void Gameplay_Assistants_Manufacture_Control_ManufactureAssistViewInAccountViewMediator__HandleDropChangedEvent
		               (int *param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a589af == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_ManufactureAssistModel__ManufactureAssistantEvents__ManufactureAssistController__ManufactureViewInAccountView__get_Model__
		              );
		    DAT_ram_00a589af = '\x01';
		  }
		  if (*(int *)(param1[2] + 0x24) == 0) {
		    param1_00 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                          (param1,*(undefined4 *)(*param1 + 0x14c));
		    Gameplay_Assistants_Manufacture_Control_ManufactureAssistController__Put(param1_00,param1);
		    return;
		  }
		  Gameplay_Assistants_Manufacture_Control_ManufactureAssistViewInAccountViewMediator__HandleDismantleStatusChangedEvent
		            (param1,param1);
		  return;
		}
		*/

		}

		// Token: 0x06004F47 RID: 20295 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004F47")]
		[Address(RVA = "0x9D6F", Offset = "0x9D6F", VA = "0x9D6F")]
		private void SetupView()
		{
		/* --- GHIDRA: SetupView ---
		void Gameplay_Assistants_Manufacture_Control_ManufactureAssistViewInAccountViewMediator__SetupView
		               (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  int *param2_00;
		  undefined4 uVar2;
		  float fVar3;
		  int *piVar4;
		  int iVar5;
		  undefined4 *puVar6;
		  
		  if (DAT_ram_00a589b0 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_ManufactureAssistModel__ManufactureAssistantEvents__ManufactureAssistController__ManufactureViewInAccountView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_UnityEngine_Component_GetComponentInChildren_TextMeshProUGUI___);
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item(&object___TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_2686);
		    Mono_Security_ASN1__get_Item(&StringLiteral_15063);
		    Mono_Security_ASN1__get_Item(&StringLiteral_17761);
		    Mono_Security_ASN1__get_Item(&StringLiteral_5);
		    Mono_Security_ASN1__get_Item(&StringLiteral_4412);
		    DAT_ram_00a589b0 = '\x01';
		  }
		  iVar5 = *(int *)param1[2];
		  iVar5 = (**(code **)((ulonglong)*(uint *)(iVar5 + 0xf8) * 4))
		                    ((int *)param1[2],*(undefined4 *)(iVar5 + 0xfc));
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  piVar4 = *(int **)(iVar1 + 0x30);
		  if (iVar5 == 0) {
		    if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_GameLocalization_TypeInfo);
		    }
		    uVar2 = func_ii_7508(StringLiteral_17761,1,0,1,0,0,0,0);
		    (**(code **)((ulonglong)*(uint *)(*piVar4 + 0x2d0) * 4))
		              (piVar4,uVar2,*(undefined4 *)(*piVar4 + 0x2d4));
		    iVar5 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    UI_Elements_RightPanel_TitleWithLevel__set_Level(*(undefined4 *)(iVar5 + 0x34),0,0);
		    iVar5 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    UI_AbstractBacktimeView__DisplayCurrentBackTime
		              (*(undefined4 *)(iVar5 + 0x34),*(undefined4 *)(param1[2] + 0x18),0);
		  }
		  else {
		    if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_GameLocalization_TypeInfo);
		    }
		    uVar2 = func_ii_7508(StringLiteral_15063,1,0,1,0,0,0,0);
		    param2_00 = (int *)Mono_Security_ASN1Convert__ToOid(object___TypeInfo,1);
		    if (StringLiteral_5 == 0) {
		      iVar5 = 0;
		    }
		    else {
		      iVar1 = func_ii_1082(StringLiteral_5,*(undefined4 *)(*param2_00 + 0x20));
		      iVar5 = StringLiteral_5;
		      if (iVar1 == 0) {
		        uVar2 = func_ii_1083();
		        func_ii_1050(uVar2,0);
		        do {
		          halt_trap();
		        } while( true );
		      }
		    }
		    param2_00[4] = iVar5;
		    uVar2 = Locale__GetText(uVar2,param2_00,0);
		    (**(code **)((ulonglong)*(uint *)(*piVar4 + 0x2d0) * 4))
		              (piVar4,uVar2,*(undefined4 *)(*piVar4 + 0x2d4));
		    iVar5 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    UI_Elements_RightPanel_TitleWithLevel__set_Level
		              (*(undefined4 *)(iVar5 + 0x34),*(undefined4 *)(param1[2] + 0x18),0);
		  }
		  iVar5 = *(int *)param1[2];
		  iVar5 = (**(code **)((ulonglong)*(uint *)(iVar5 + 0x100) * 4))
		                    ((int *)param1[2],*(undefined4 *)(iVar5 + 0x104));
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  piVar4 = (int *)UI_Rewards_AbstractRewardsRender__SetRewards
		                            (*(undefined4 *)(iVar1 + 0x14),
		                             Method_UnityEngine_Component_GetComponentInChildren_TextMeshProUGUI___)
		  ;
		  if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_GameLocalization_TypeInfo);
		  }
		  puVar6 = &StringLiteral_4412;
		  if (iVar5 == 0) {
		    puVar6 = &StringLiteral_2686;
		  }
		  uVar2 = func_ii_7508(*puVar6,1,0,1,0,0,0,0);
		  (**(code **)((ulonglong)*(uint *)(*piVar4 + 0x2d0) * 4))
		            (piVar4,uVar2,*(undefined4 *)(*piVar4 + 0x2d4));
		  iVar5 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar2 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (*(undefined4 *)(iVar5 + 0x2c),0);
		  fVar3 = func_ii_7103(*(undefined4 *)(param1[2] + 0x18),0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar2,(uint)(0.0 < fVar3),0);
		  return;
		}
		*/

		}

		// Token: 0x06004F48 RID: 20296 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004F48")]
		[Address(RVA = "0x9D70", Offset = "0x9D70", VA = "0x9D70")]
		private void ValidateDismantleControls()
		{
		/* --- GHIDRA: ValidateDismantleControls ---
		void Gameplay_Assistants_Manufacture_Control_ManufactureAssistViewInAccountViewMediator__ValidateDismantleControls
		               (undefined4 param1,int *param2,undefined4 param3)
		
		{
		  undefined4 in_register_20000004;
		  undefined8 uVar1;
		  undefined4 uVar2;
		  int param1_00;
		  undefined4 uVar3;
		  int iVar4;
		  double dVar5;
		  double param1_01;
		  ulonglong uVar6;
		  float8 local_8;
		  
		  if (DAT_ram_00a589b1 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_ButtonCallbackDelegate_IntegerValuePickerWindow_IntegerValuePickerWindowArgs__int__TypeInfo
		              );
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_ToArray_int___);
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&UI_Windows_IntegerValuePickerWindow_IntegerValuePickerWindowArgs_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Assistants_Manufacture_Control_ManufactureAssistViewInAccountViewMediator__ShowSelectCountForDisassembleWindow_b__15_0__
		              );
		    Mono_Security_ASN1__get_Item(&StringLiteral_2688);
		    Mono_Security_ASN1__get_Item(&StringLiteral_2687);
		    Mono_Security_ASN1__get_Item(&StringLiteral_6154);
		    DAT_ram_00a589b1 = '\x01';
		  }
		  if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_GameLocalization_TypeInfo);
		  }
		  uVar2 = func_ii_7508(StringLiteral_6154,1,0,1,0,0,0,0);
		  param1_00 = unnamed_function_1417
		                        (UI_Windows_IntegerValuePickerWindow_IntegerValuePickerWindowArgs_TypeInfo);
		  UI_Windows_IntegerValuePickerWindow_IntegerValuePickerWindowArgs__set_SelectedValue
		            (param1_00,uVar2,0);
		  uVar2 = func_ii_7508(StringLiteral_2688,1,0,1,0,0,0,0);
		  *(undefined4 *)(param1_00 + 0x18) = uVar2;
		  uVar2 = func_ii_7508(StringLiteral_2687,1,0,1,0,0,0,0);
		  *(undefined4 *)(param1_00 + 0x1c) = uVar2;
		  uVar1 = CONCAT44(in_register_20000004,param2);
		  uVar3 = (**(code **)((ulonglong)*(uint *)(*param2 + 0xf8) * 4))
		                    (uVar1,*(undefined4 *)(*param2 + 0xfc));
		  uVar2 = (undefined4)((ulonglong)uVar1 >> 0x20);
		  uVar3 = System_Linq_Error__NotSupported(1,uVar3,0);
		  uVar3 = System_Linq_Enumerable__ToArray_double_
		                    (uVar3,Method_System_Linq_Enumerable_ToArray_int___);
		  *(undefined4 *)(param1_00 + 0x2c) = uVar3;
		  iVar4 = (**(code **)((ulonglong)*(uint *)(*param2 + 0xf8) * 4))
		                    (CONCAT44(uVar2,param2),*(undefined4 *)(*param2 + 0xfc));
		  if (DAT_ram_00a6445d == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Math_TypeInfo);
		    DAT_ram_00a6445d = '\x01';
		  }
		  if (*(int *)(System_Math_TypeInfo + 0x74) == 0) {
		    func_ii_306000(System_Math_TypeInfo);
		  }
		  param1_01 = (double)(iVar4 / 2);
		  dVar5 = unnamed_function_4206(param1_01,&local_8);
		  if (iVar4 < -1) {
		    if (dVar5 == -0.5) {
		      if (ABS((double)local_8) < 9.223372036854776e+18) {
		        uVar6 = (ulonglong)(double)local_8;
		      }
		      else {
		        uVar6 = 0;
		      }
		      if ((uVar6 & 1) != 0) {
		        local_8 = (float8)((double)local_8 + -1.0);
		      }
		    }
		    else {
		      local_8 = (float8)CEIL(param1_01 + -0.5);
		    }
		  }
		  else if (dVar5 == 0.5) {
		    if (ABS((double)local_8) < 9.223372036854776e+18) {
		      uVar6 = (ulonglong)(double)local_8;
		    }
		    else {
		      uVar6 = 0;
		    }
		    if ((uVar6 & 1) != 0) {
		      local_8 = (float8)((double)local_8 + 1.0);
		    }
		  }
		  else {
		    local_8 = (float8)FLOOR(param1_01 + 0.5);
		  }
		  if (ABS((double)local_8) < 2147483648.0) {
		    iVar4 = (int)(double)local_8;
		  }
		  else {
		    iVar4 = -0x80000000;
		  }
		  *(int *)(param1_00 + 0x30) = iVar4;
		  uVar2 = unnamed_function_1417
		                    (
		                    UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_ButtonCallbackDelegate_IntegerValuePickerWindow_IntegerValuePickerWindowArgs__int__TypeInfo
		                    );
		  UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_ButtonCallbackDelegate_object___Invoke
		            (uVar2,param1,
		             Method_Gameplay_Assistants_Manufacture_Control_ManufactureAssistViewInAccountViewMediator__ShowSelectCountForDisassembleWindow_b__15_0__
		             ,0);
		  *(undefined4 *)(param1_00 + 0x34) = uVar2;
		  UI_Windows_IntegerValuePickerWindow__HandleContent(param1_00,0);
		  return;
		}
		*/

		}

		// Token: 0x06004F49 RID: 20297 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004F49")]
		[Address(RVA = "0x9D71", Offset = "0x9D71", VA = "0x9D71")]
		private void ShowSelectCountForDisassembleWindow(ArtifactData artifact)
		{
		/* --- GHIDRA: ShowSelectCountForDisassembleWindow ---
		void Gameplay_Assistants_Manufacture_Control_ManufactureAssistViewInAccountViewMediator__ShowSelectCountForDisassembleWindow
		               (undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 param1_00;
		  undefined4 local_10;
		  undefined4 local_c;
		  undefined4 local_8;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a589b2 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_ManufactureAssistModel_StartFailDisassembleReasons__string__TryGetValue__
		              );
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Gameplay_Assistants_Manufacture_Control_ManufactureAssistViewInAccountViewMediator_TypeInfo
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Gameplay_Assistants_Manufacture_Model_ManufactureAssistModel_StartFailDisassembleReasons_TypeInfo
		              );
		    DAT_ram_00a589b2 = '\x01';
		  }
		  local_4 = 0;
		  if (*(int *)(
		              Gameplay_Assistants_Manufacture_Control_ManufactureAssistViewInAccountViewMediator_TypeInfo
		              + 0x74) == 0) {
		    func_ii_306000(
		                  Gameplay_Assistants_Manufacture_Control_ManufactureAssistViewInAccountViewMediator_TypeInfo
		                  );
		  }
		  iVar1 = System_Collections_Generic_List_Enumerator_ValueTuple_object__double____MoveNext
		                    (**(undefined4 **)
		                       (
		                       Gameplay_Assistants_Manufacture_Control_ManufactureAssistViewInAccountViewMediator_TypeInfo
		                       + 0x5c),param2,&local_4,
		                     Method_System_Collections_Generic_Dictionary_ManufactureAssistModel_StartFailDisassembleReasons__string__TryGetValue__
		                    );
		  uVar2 = System_Uri___ctor(0);
		  param1_00 = System_Globalization_TimeSpanFormat_FormatLiterals__get_DayHourSep(uVar2,0);
		  uVar2 = local_4;
		  if (iVar1 == 0) {
		    local_c = 0xffffffff;
		    local_10 = 
		    Gameplay_Assistants_Manufacture_Model_ManufactureAssistModel_StartFailDisassembleReasons_TypeInfo
		    ;
		    local_8 = param2;
		    uVar2 = Spine_SkeletonJson__GetFloat(&local_10,0);
		    Core_Application_App__get_ToastController(param1_00,1,uVar2,0);
		  }
		  else {
		    if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_GameLocalization_TypeInfo);
		    }
		    uVar2 = func_ii_7508(uVar2,1,0,1,0,0,0,0);
		    Core_Application_App__get_ToastController(param1_00,1,uVar2,0);
		  }
		  return;
		}
		*/

		}

		// Token: 0x06004F4A RID: 20298 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004F4A")]
		[Address(RVA = "0x9D72", Offset = "0x9D72", VA = "0x9D72")]
		private void DisplayStartDisassembleFailReason(ManufactureAssistModel.StartFailDisassembleReasons reason)
		{
		/* --- GHIDRA: DisplayStartDisassembleFailReason ---
		void Gameplay_Assistants_Manufacture_Control_ManufactureAssistViewInAccountViewMediator__DisplayStartDisassembleFailReason
		               (undefined4 param1,int param2,undefined4 param3)
		
		{
		  Gameplay_Assistants_Manufacture_Control_ManufactureAssistViewInAccountViewMediator__ShowSelectCountForDisassembleWindow
		            (param2,param2,param2);
		  if (param2 == 4) {
		    Gameplay_Assistants_Manufacture_Control_ManufactureAssistViewInAccountViewMediator__ValidateDescription
		              (param1,4);
		  }
		  return;
		}
		*/

		}

		// Token: 0x06004F4B RID: 20299 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004F4B")]
		[Address(RVA = "0x9D73", Offset = "0x9D73", VA = "0x9D73")]
		private void HandleDisassembleFailReason(ManufactureAssistModel.StartFailDisassembleReasons reason)
		{
		/* --- GHIDRA: HandleDisassembleFailReason ---
		void Gameplay_Assistants_Manufacture_Control_ManufactureAssistViewInAccountViewMediator__HandleDisassembleFailReason
		               (int *param1,undefined4 param2)
		
		{
		  uint uVar1;
		  int iVar2;
		  undefined4 uVar3;
		  undefined4 param2_00;
		  uint *puVar4;
		  int iVar5;
		  int *piVar6;
		  undefined8 local_28;
		  undefined8 local_20;
		  float8 local_18;
		  undefined4 local_c;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a589b3 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_ManufactureAssistModel__ManufactureAssistantEvents__ManufactureAssistController__ManufactureViewInAccountView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_KeyValuePair_string__string____TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_KeyValuePair_string__string___ctor__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_ArtifactInfo__get_Count__);
		    Mono_Security_ASN1__get_Item(&StringLiteral_2692);
		    Mono_Security_ASN1__get_Item(&StringLiteral_21978);
		    Mono_Security_ASN1__get_Item(&StringLiteral_22118);
		    Mono_Security_ASN1__get_Item(&StringLiteral_2693);
		    Mono_Security_ASN1__get_Item(&StringLiteral_27779);
		    Mono_Security_ASN1__get_Item(&StringLiteral_2691);
		    Mono_Security_ASN1__get_Item(&StringLiteral_2690);
		    Mono_Security_ASN1__get_Item(&StringLiteral_2685);
		    Mono_Security_ASN1__get_Item(&StringLiteral_5);
		    DAT_ram_00a589b3 = '\x01';
		  }
		  local_8 = 0;
		  local_c = 0;
		  local_18 = 0.0;
		  local_20 = 0;
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar3 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (*(undefined4 *)(iVar2 + 0x28),0);
		  iVar2 = *(int *)param1[2];
		  param2_00 = (**(code **)((ulonglong)*(uint *)(iVar2 + 0x100) * 4))
		                        ((int *)param1[2],*(undefined4 *)(iVar2 + 0x104));
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar3,param2_00,0);
		  iVar2 = *(int *)param1[2];
		  iVar2 = (**(code **)((ulonglong)*(uint *)(iVar2 + 0x100) * 4))
		                    ((int *)param1[2],*(undefined4 *)(iVar2 + 0x104));
		  if (iVar2 == 0) {
		    iVar2 = *(int *)param1[2];
		    iVar2 = (**(code **)((ulonglong)*(uint *)(iVar2 + 0x108) * 4))
		                      ((int *)param1[2],*(undefined4 *)(iVar2 + 0x10c));
		    if (iVar2 == 0) {
		      iVar2 = *(int *)param1[2];
		      iVar2 = (**(code **)((ulonglong)*(uint *)(iVar2 + 0xf0) * 4))
		                        ((int *)param1[2],*(undefined4 *)(iVar2 + 0xf4));
		      if ((iVar2 == 0) &&
		         (iVar2 = *(int *)param1[2],
		         iVar2 = (**(code **)((ulonglong)*(uint *)(iVar2 + 0xf8) * 4))
		                           ((int *)param1[2],*(undefined4 *)(iVar2 + 0xfc)), iVar2 == 0)) {
		        iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                          (param1,*(undefined4 *)(*param1 + 0x15c));
		        piVar6 = *(int **)(iVar2 + 0x10);
		        uVar3 = Core_Extensions_Dict_AssistantDictExt__GetTitle(*(undefined4 *)(param1[2] + 0x10),0)
		        ;
		        iVar2 = *piVar6;
		        (**(code **)((ulonglong)*(uint *)(iVar2 + 0x2d0) * 4))
		                  (piVar6,uVar3,*(undefined4 *)(iVar2 + 0x2d4));
		      }
		      else {
		        local_28 = (ulonglong)local_28._4_4_ << 0x20;
		        uVar3 = func_ii_7504(*(undefined4 *)(param1[2] + 8),0);
		        iVar2 = Core_Data_UserData__get_Accounts(uVar3,3,&local_28,0);
		        iVar5 = param1[2];
		        if ((iVar2 == 0) || ((int)local_28 == 0)) {
		          iVar5 = *(int *)(*(int *)(*(int *)(iVar5 + 0x24) + 0x18) + 0xc);
		          iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                            (param1,*(undefined4 *)(*param1 + 0x15c));
		          piVar6 = *(int **)(iVar2 + 0x10);
		          if (iVar5 < 1) {
		            uVar3 = Core_Extensions_Dict_AssistantDictExt__GetTitle
		                              (*(undefined4 *)(param1[2] + 0x10),0);
		            (**(code **)((ulonglong)*(uint *)(*piVar6 + 0x2d0) * 4))
		                      (piVar6,uVar3,*(undefined4 *)(*piVar6 + 0x2d4));
		          }
		          else {
		            if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		              func_ii_306000(Core_GameLocalization_TypeInfo);
		            }
		            uVar3 = func_ii_7508(StringLiteral_2685,1,0,1,0,0,0,0);
		            (**(code **)((ulonglong)*(uint *)(*piVar6 + 0x2d0) * 4))
		                      (piVar6,uVar3,*(undefined4 *)(*piVar6 + 0x2d4));
		          }
		        }
		        else {
		          if (DAT_ram_00a58981 == '\0') {
		            Mono_Security_ASN1__get_Item
		                      (&Method_Google_Protobuf_Collections_RepeatedField_ArtifactInfo__get_Count__);
		            Mono_Security_ASN1__get_Item
		                      (&Method_Google_Protobuf_Collections_RepeatedField_ArtifactInfo__get_Item__);
		            DAT_ram_00a58981 = '\x01';
		          }
		          iVar2 = *(int *)(*(int *)(iVar5 + 0x24) + 0x14);
		          if ((*(int *)(iVar2 + 0xc) < 1) ||
		             (iVar2 = Google_Protobuf_Collections_RepeatedField_Int32Enum___get_IsReadOnly
		                                (iVar2,0,
		                                 Method_Google_Protobuf_Collections_RepeatedField_ArtifactInfo__get_Item__
		                                ), iVar2 == 0)) {
		            iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                              (param1,*(undefined4 *)(*param1 + 0x15c));
		            piVar6 = *(int **)(iVar2 + 0x10);
		            if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		              func_ii_306000(Core_GameLocalization_TypeInfo);
		            }
		            uVar3 = func_ii_7508(StringLiteral_2691,1,0,1,0,0,0,0);
		            iVar2 = *piVar6;
		            (**(code **)((ulonglong)*(uint *)(iVar2 + 0x2d0) * 4))
		                      (piVar6,uVar3,*(undefined4 *)(iVar2 + 0x2d4));
		          }
		          else {
		            if (DAT_ram_00a6456f == '\0') {
		              Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		              DAT_ram_00a6456f = '\x01';
		            }
		            uVar1 = 0;
		            piVar6 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		            iVar2 = *piVar6;
		            if (*(ushort *)(iVar2 + 0xb6) != 0) {
		              do {
		                if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8)) {
		                  puVar4 = (uint *)(*(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8 + 4) * 8 + iVar2 +
		                                   0x120);
		                  goto code_r0x80f55959;
		                }
		                uVar1 = uVar1 + 1;
		              } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		            }
		            puVar4 = (uint *)func_ii_1080(piVar6,Core_Gameplay_IGame_TypeInfo,0xc);
		code_r0x80f55959:
		            iVar2 = (**(code **)((ulonglong)*puVar4 * 4))(piVar6,puVar4[1]);
		            local_20 = Gameplay_Inventory_Model_InventoryBaseModel__get_ChestTotalSlotsNum
		                                 (*(undefined4 *)(iVar2 + 0x10),0);
		            iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                              (param1,*(undefined4 *)(*param1 + 0x15c));
		            piVar6 = *(int **)(iVar2 + 0x10);
		            if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		              func_ii_306000(Core_GameLocalization_TypeInfo);
		            }
		            uVar3 = func_ii_7508(StringLiteral_2690,1,0,1,0,0,0,0);
		            iVar5 = Mono_Security_ASN1Convert__ToOid
		                              (System_Collections_Generic_KeyValuePair_string__string____TypeInfo,1)
		            ;
		            iVar2 = UnityEngine_GameObject__SetActive(&local_20,0);
		            local_28 = 0;
		            if (iVar2 == 0) {
		              iVar2 = StringLiteral_5;
		            }
		            System_Text_Formatting_StringView__get_IsEmpty
		                      (&local_28,StringLiteral_21978,iVar2,
		                       Method_System_Collections_Generic_KeyValuePair_string__string___ctor__);
		            *(longlong *)(iVar5 + 0x10) = local_28;
		            uVar3 = Gameplay_Clans_Office_View_ClanWarsTab_ClanWarsRewardsTab_ClanWarsRewardsView__GetPlacesText
		                              (uVar3,iVar5,0);
		            iVar2 = *piVar6;
		            (**(code **)((ulonglong)*(uint *)(iVar2 + 0x2d0) * 4))
		                      (piVar6,uVar3,*(undefined4 *)(iVar2 + 0x2d4));
		          }
		        }
		      }
		    }
		    else {
		      iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x15c));
		      piVar6 = *(int **)(iVar2 + 0x10);
		      if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		        func_ii_306000(Core_GameLocalization_TypeInfo);
		      }
		      uVar3 = func_ii_7508(StringLiteral_2693,1,0,1,0,0,0,0);
		      iVar5 = Mono_Security_ASN1Convert__ToOid
		                        (System_Collections_Generic_KeyValuePair_string__string____TypeInfo,2);
		      local_c = *(undefined4 *)(*(int *)(*(int *)(param1[2] + 0x24) + 0x18) + 0xc);
		      iVar2 = func_ii_4443(&local_c,0);
		      local_28 = 0;
		      if (iVar2 == 0) {
		        iVar2 = StringLiteral_5;
		      }
		      System_Text_Formatting_StringView__get_IsEmpty
		                (&local_28,StringLiteral_22118,iVar2,
		                 Method_System_Collections_Generic_KeyValuePair_string__string___ctor__);
		      *(longlong *)(iVar5 + 0x10) = local_28;
		      local_18 = (float8)Gameplay_Assistants_Manufacture_Model_ManufactureAssistModel__get_Account
		                                   (param1[2],iVar5);
		      iVar2 = func_ii_7515(&local_18,0);
		      local_28 = 0;
		      if (iVar2 == 0) {
		        iVar2 = StringLiteral_5;
		      }
		      System_Text_Formatting_StringView__get_IsEmpty
		                (&local_28,StringLiteral_27779,iVar2,
		                 Method_System_Collections_Generic_KeyValuePair_string__string___ctor__);
		      *(longlong *)(iVar5 + 0x18) = local_28;
		      uVar3 = Gameplay_Clans_Office_View_ClanWarsTab_ClanWarsRewardsTab_ClanWarsRewardsView__GetPlacesText
		                        (uVar3,iVar5,0);
		      iVar2 = *piVar6;
		      (**(code **)((ulonglong)*(uint *)(iVar2 + 0x2d0) * 4))
		                (piVar6,uVar3,*(undefined4 *)(iVar2 + 0x2d4));
		    }
		  }
		  else {
		    if (DAT_ram_00a6456f == '\0') {
		      Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		      DAT_ram_00a6456f = '\x01';
		    }
		    piVar6 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		    iVar2 = *piVar6;
		    if (*(ushort *)(iVar2 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8)) {
		          puVar4 = (uint *)(*(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8 + 4) * 8 + iVar2 + 0x120);
		          goto code_r0x80f554b2;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		    }
		    puVar4 = (uint *)func_ii_1080(piVar6,Core_Gameplay_IGame_TypeInfo,0xc);
		code_r0x80f554b2:
		    iVar2 = (**(code **)((ulonglong)*puVar4 * 4))(piVar6,puVar4[1]);
		    local_8 = Gameplay_Inventory_Model_InventoryBaseModel__get_ChestTotalSlotsNum
		                        (*(undefined4 *)(iVar2 + 0x10),0);
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    piVar6 = *(int **)(iVar2 + 0x10);
		    if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_GameLocalization_TypeInfo);
		    }
		    uVar3 = func_ii_7508(StringLiteral_2692,1,0,1,0,0,0,0);
		    iVar5 = Mono_Security_ASN1Convert__ToOid
		                      (System_Collections_Generic_KeyValuePair_string__string____TypeInfo,1);
		    iVar2 = UnityEngine_GameObject__SetActive(&local_8,0);
		    local_28 = 0;
		    if (iVar2 == 0) {
		      iVar2 = StringLiteral_5;
		    }
		    System_Text_Formatting_StringView__get_IsEmpty
		              (&local_28,StringLiteral_21978,iVar2,
		               Method_System_Collections_Generic_KeyValuePair_string__string___ctor__);
		    *(longlong *)(iVar5 + 0x10) = local_28;
		    uVar3 = Gameplay_Clans_Office_View_ClanWarsTab_ClanWarsRewardsTab_ClanWarsRewardsView__GetPlacesText
		                      (uVar3,iVar5,0);
		    iVar2 = *piVar6;
		    (**(code **)((ulonglong)*(uint *)(iVar2 + 0x2d0) * 4))
		              (piVar6,uVar3,*(undefined4 *)(iVar2 + 0x2d4));
		  }
		  return;
		}
		*/

		}

		// Token: 0x06004F4C RID: 20300 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004F4C")]
		[Address(RVA = "0x9D74", Offset = "0x9D74", VA = "0x9D74")]
		private void ValidateDescription()
		{
		/* --- GHIDRA: ValidateDescription ---
		void Gameplay_Assistants_Manufacture_Control_ManufactureAssistViewInAccountViewMediator__ValidateDescription
		               (int *param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  int param1_00;
		  undefined4 uVar2;
		  
		  if (DAT_ram_00a589b4 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Gameplay_Assistants_Manufacture_View_ManufactureAssistantRewardStorageWindow_ManufactureAssistantRewardStorageWindowArgs_TypeInfo
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_Windows_PopupController_Show_ManufactureAssistantRewardStorageWindow___);
		    Mono_Security_ASN1__get_Item(&StringLiteral_12564);
		    DAT_ram_00a589b4 = '\x01';
		  }
		  uVar1 = System_Uri___ctor(0);
		  uVar1 = System_Globalization_TimeSpanFormat_FormatLiterals__get_Start(uVar1,0);
		  param1_00 = unnamed_function_1417
		                        (
		                        Gameplay_Assistants_Manufacture_View_ManufactureAssistantRewardStorageWindow_ManufactureAssistantRewardStorageWindowArgs_TypeInfo
		                        );
		  UI_Windows_BaseWindowArgs__Dispose(param1_00,0);
		  uVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x14c));
		  *(undefined4 *)(param1_00 + 0x18) = uVar2;
		  Gameplay_Antiq_View_GroupReviewWindow_WindowArgs___ctor
		            (uVar1,StringLiteral_12564,param1_00,
		             Method_UI_Windows_PopupController_Show_ManufactureAssistantRewardStorageWindow___);
		  return;
		}
		*/

		}

		// Token: 0x06004F4D RID: 20301 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004F4D")]
		[Address(RVA = "0x9D75", Offset = "0x9D75", VA = "0x9D75")]
		private void ShowRewardsWindow()
		{
		/* --- GHIDRA: ShowRewardsWindow ---
		void Gameplay_Assistants_Manufacture_Control_ManufactureAssistViewInAccountViewMediator__ShowRewardsWindow
		               (undefined4 param1)
		
		{
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a589b5 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_ManufactureAssistModel_StartFailDisassembleReasons__string__Add__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_ManufactureAssistModel_StartFailDisassembleReasons__string___ctor__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               System_Collections_Generic_Dictionary_ManufactureAssistModel_StartFailDisassembleReasons__string__TypeInfo
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Gameplay_Assistants_Manufacture_Control_ManufactureAssistViewInAccountViewMediator_TypeInfo
		              );
		    Mono_Security_ASN1__get_Item(&StringLiteral_2696);
		    Mono_Security_ASN1__get_Item(&StringLiteral_2697);
		    Mono_Security_ASN1__get_Item(&StringLiteral_2694);
		    Mono_Security_ASN1__get_Item(&StringLiteral_2695);
		    DAT_ram_00a589b5 = '\x01';
		  }
		  param1_00 = unnamed_function_1417
		                        (
		                        System_Collections_Generic_Dictionary_ManufactureAssistModel_StartFailDisassembleReasons__string__TypeInfo
		                        );
		  System_Collections_Generic_Dictionary_Int32Enum__Int32Enum___set_Item
		            (param1_00,
		             Method_System_Collections_Generic_Dictionary_ManufactureAssistModel_StartFailDisassembleReasons__string___ctor__
		            );
		  func_ii_10812(param1_00,2,StringLiteral_2695,
		                Method_System_Collections_Generic_Dictionary_ManufactureAssistModel_StartFailDisassembleReasons__string__Add__
		               );
		  func_ii_10812(param1_00,3,StringLiteral_2694,
		                Method_System_Collections_Generic_Dictionary_ManufactureAssistModel_StartFailDisassembleReasons__string__Add__
		               );
		  func_ii_10812(param1_00,1,StringLiteral_2696,
		                Method_System_Collections_Generic_Dictionary_ManufactureAssistModel_StartFailDisassembleReasons__string__Add__
		               );
		  func_ii_10812(param1_00,4,StringLiteral_2697,
		                Method_System_Collections_Generic_Dictionary_ManufactureAssistModel_StartFailDisassembleReasons__string__Add__
		               );
		  **(undefined4 **)
		    (Gameplay_Assistants_Manufacture_Control_ManufactureAssistViewInAccountViewMediator_TypeInfo +
		    0x5c) = param1_00;
		  return;
		}
		*/

		}

		// Token: 0x04002B2D RID: 11053
		[Token(Token = "0x4002B2D")]
		[FieldOffset(Offset = "0x0")]
		public static readonly Dictionary<ManufactureAssistModel.StartFailDisassembleReasons, string> StartDisassembleFailReasonLocaleKeys;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_Events ---
		void Gameplay_Assistants_Manufacture_Control_ManufactureAssistViewInAccountViewMediator__set_Events
		               (int *param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  undefined4 uVar3;
		  
		  if (DAT_ram_00a589a7 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_ManufactureAssistModel__ManufactureAssistantEvents__ManufactureAssistController__ManufactureViewInAccountView__set_View__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_PointerEventData__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Assistants_Manufacture_Control_ManufactureAssistViewInAccountViewMediator_HandleAddButtonClickEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Assistants_Manufacture_Control_ManufactureAssistViewInAccountViewMediator_HandleDisassembleAllButtonClickEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Assistants_Manufacture_Control_ManufactureAssistViewInAccountViewMediator_HandleDisassemblePartButtonClickEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Assistants_Manufacture_Control_ManufactureAssistViewInAccountViewMediator_HandleOpenRewardsButtonClickEvent__
		              );
		    Mono_Security_ASN1__get_Item(&UnityEngine_Events_UnityAction_TypeInfo);
		    DAT_ram_00a589a7 = '\x01';
		  }
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar2 = Cysharp_Threading_Tasks_CancellationTokenExtensions___cctor(uVar1,0);
		  if (iVar2 != 0) {
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar3 = *(undefined4 *)(iVar2 + 0x1c);
		    uVar1 = unnamed_function_1417(System_Action_PointerEventData__TypeInfo);
		    UnityEngine_UIElements_VisualElement__get_layout
		              (uVar1,param1,
		               Method_Gameplay_Assistants_Manufacture_Control_ManufactureAssistViewInAccountViewMediator_HandleAddButtonClickEvent__
		               ,0);
		    Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_object___get_Count(uVar3,uVar1,0);
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar3 = *(undefined4 *)(*(int *)(iVar2 + 0x14) + 0xb4);
		    uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		    Utils_ObjectUtils__IsNotNull
		              (uVar1,param1,
		               Method_Gameplay_Assistants_Manufacture_Control_ManufactureAssistViewInAccountViewMediator_HandleDisassembleAllButtonClickEvent__
		               ,0);
		    UnityEngine_Events_UnityAction___ctor(uVar3,uVar1,0);
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar3 = *(undefined4 *)(*(int *)(iVar2 + 0x18) + 0xb4);
		    uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		    Utils_ObjectUtils__IsNotNull
		              (uVar1,param1,
		               Method_Gameplay_Assistants_Manufacture_Control_ManufactureAssistViewInAccountViewMediator_HandleDisassemblePartButtonClickEvent__
		               ,0);
		    UnityEngine_Events_UnityAction___ctor(uVar3,uVar1,0);
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar3 = *(undefined4 *)(*(int *)(iVar2 + 0x24) + 0xb4);
		    uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		    Utils_ObjectUtils__IsNotNull
		              (uVar1,param1,
		               Method_Gameplay_Assistants_Manufacture_Control_ManufactureAssistViewInAccountViewMediator_HandleOpenRewardsButtonClickEvent__
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
		    uVar3 = *(undefined4 *)(iVar2 + 0x1c);
		    uVar1 = unnamed_function_1417(System_Action_PointerEventData__TypeInfo);
		    UnityEngine_UIElements_VisualElement__get_layout
		              (uVar1,param1,
		               Method_Gameplay_Assistants_Manufacture_Control_ManufactureAssistViewInAccountViewMediator_HandleAddButtonClickEvent__
		               ,0);
		    Gameplay_Chat_View_Smiles_SmileItemView__HandleSmileDicChanged(uVar3,uVar1,0);
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar3 = *(undefined4 *)(*(int *)(iVar2 + 0x14) + 0xb4);
		    uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		    Utils_ObjectUtils__IsNotNull
		              (uVar1,param1,
		               Method_Gameplay_Assistants_Manufacture_Control_ManufactureAssistViewInAccountViewMediator_HandleDisassembleAllButtonClickEvent__
		               ,0);
		    Gameplay_Boss_View_CaptainTab_BossInfoView__add_AttackButtonClickEvent(uVar3,uVar1,0);
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar3 = *(undefined4 *)(*(int *)(iVar2 + 0x18) + 0xb4);
		    uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		    Utils_ObjectUtils__IsNotNull
		              (uVar1,param1,
		               Method_Gameplay_Assistants_Manufacture_Control_ManufactureAssistViewInAccountViewMediator_HandleDisassemblePartButtonClickEvent__
		               ,0);
		    Gameplay_Boss_View_CaptainTab_BossInfoView__add_AttackButtonClickEvent(uVar3,uVar1,0);
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar3 = *(undefined4 *)(*(int *)(iVar2 + 0x24) + 0xb4);
		    uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		    Utils_ObjectUtils__IsNotNull
		              (uVar1,param1,
		               Method_Gameplay_Assistants_Manufacture_Control_ManufactureAssistViewInAccountViewMediator_HandleOpenRewardsButtonClickEvent__
		               ,0);
		    Gameplay_Boss_View_CaptainTab_BossInfoView__add_AttackButtonClickEvent(uVar3,uVar1,0);
		    if (DAT_ram_00a589af == '\0') {
		      Mono_Security_ASN1__get_Item
		                (&
		                 Method_MVC_AbstractViewMediator_ManufactureAssistModel__ManufactureAssistantEvents__ManufactureAssistController__ManufactureViewInAccountView__get_Model__
		                );
		      DAT_ram_00a589af = '\x01';
		    }
		    if (*(int *)(param1[2] + 0x24) == 0) {
		      uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x14c));
		      Gameplay_Assistants_Manufacture_Control_ManufactureAssistController__Put(uVar1,param1);
		      return;
		    }
		    Gameplay_Assistants_Manufacture_Control_ManufactureAssistViewInAccountViewMediator__HandleDismantleStatusChangedEvent
		              (param1,param1);
		  }
		  return;
		}
		*/


		/* --- GHIDRA: set_View ---
		void Gameplay_Assistants_Manufacture_Control_ManufactureAssistViewInAccountViewMediator__set_View
		               (undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 param1_00;
		  int param3_00;
		  int *param1_01;
		  int iVar3;
		  undefined4 *puVar4;
		  int param1_02;
		  undefined4 param2_00;
		  
		  if (DAT_ram_00a589a8 == '\0') {
		    Mono_Security_ASN1__get_Item(&Protocol_Dic_ArtikulMenuActionDic_Types_Actions___TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Gameplay_Inventory_View_Chest_InventoryChestWindowOptions_ArtifactFilterDelegate_TypeInfo
		              );
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Assistants_Manufacture_Control_ManufactureAssistViewInAccountViewMediator___c__HandleAddButtonClickEvent_b__5_0__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Gameplay_Assistants_Manufacture_Control_ManufactureAssistViewInAccountViewMediator___c_TypeInfo
		              );
		    DAT_ram_00a589a8 = '\x01';
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
		        goto code_r0x80f54ab6;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_01,Core_Gameplay_IGame_TypeInfo,0xc);
		code_r0x80f54ab6:
		  param1_00 = (**(code **)((ulonglong)*puVar2 * 4))(param1_01,puVar2[1]);
		  iVar3 = Mono_Security_ASN1Convert__ToOid
		                    (Protocol_Dic_ArtikulMenuActionDic_Types_Actions___TypeInfo,2);
		  *(undefined8 *)(iVar3 + 0x10) = 0x2000000005;
		  param3_00 = Mono_Security_ASN1Convert__ToOid
		                        (Protocol_Dic_ArtikulMenuActionDic_Types_Actions___TypeInfo,1);
		  *(undefined4 *)(param3_00 + 0x10) = 0x20;
		  if (*(int *)(
		              Gameplay_Assistants_Manufacture_Control_ManufactureAssistViewInAccountViewMediator___c_TypeInfo
		              + 0x74) == 0) {
		    func_ii_306000(
		                  Gameplay_Assistants_Manufacture_Control_ManufactureAssistViewInAccountViewMediator___c_TypeInfo
		                  );
		  }
		  puVar4 = *(undefined4 **)
		            (
		            Gameplay_Assistants_Manufacture_Control_ManufactureAssistViewInAccountViewMediator___c_TypeInfo
		            + 0x5c);
		  param1_02 = puVar4[1];
		  if (param1_02 == 0) {
		    if (*(int *)(
		                Gameplay_Assistants_Manufacture_Control_ManufactureAssistViewInAccountViewMediator___c_TypeInfo
		                + 0x74) == 0) {
		      func_ii_306000(
		                    Gameplay_Assistants_Manufacture_Control_ManufactureAssistViewInAccountViewMediator___c_TypeInfo
		                    );
		      puVar4 = *(undefined4 **)
		                (
		                Gameplay_Assistants_Manufacture_Control_ManufactureAssistViewInAccountViewMediator___c_TypeInfo
		                + 0x5c);
		    }
		    param2_00 = *puVar4;
		    param1_02 = unnamed_function_1417
		                          (
		                          Gameplay_Inventory_View_Chest_InventoryChestWindowOptions_ArtifactFilterDelegate_TypeInfo
		                          );
		    Gameplay_Inventory_View_Chest_InventoryChestWindowOptions___ctor
		              (param1_02,param2_00,
		               Method_Gameplay_Assistants_Manufacture_Control_ManufactureAssistViewInAccountViewMediator___c__HandleAddButtonClickEvent_b__5_0__
		               ,0);
		    *(int *)(*(int *)(
		                     Gameplay_Assistants_Manufacture_Control_ManufactureAssistViewInAccountViewMediator___c_TypeInfo
		                     + 0x5c) + 4) = param1_02;
		  }
		  Core_Gameplay_Managers_Inventory_InventoryManager__DismantleArtifact
		            (param1_00,iVar3,param3_00,param1_02,0);
		  return;
		}
		*/

}
