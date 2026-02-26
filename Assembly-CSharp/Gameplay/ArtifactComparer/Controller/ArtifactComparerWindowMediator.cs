using System;
using System.Collections.Generic;
using Core.Data;
using Core.Data.InfoRows;
using Gameplay.ArtifactComparer.Model;
using Gameplay.ArtifactComparer.View;
using Gameplay.ArtifactComparer.View.SkillSelector;
using Gameplay.Inventory.Controller.Filters;
using Il2CppDummyDll;
using MVC;
using UI;
using UI.Filters;

namespace Gameplay.ArtifactComparer.Controller
{
	// Token: 0x02000CED RID: 3309
	[Token(Token = "0x2000CED")]
	public class ArtifactComparerWindowMediator : AbstractViewMediator<ArtifactComparerModel, ArtifactComparerEvents, ArtifactComparerController, ArtifactComparerWindow>
	{
		// Token: 0x0600507B RID: 20603 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600507B")]
		[Address(RVA = "0x9E8A", Offset = "0x9E8A", VA = "0x9E8A")]
		public ArtifactComparerWindowMediator(ArtifactComparerModel model, ArtifactComparerEvents events, ArtifactComparerController controller, bool sameArticulTypeOnly)
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_ArtifactComparer_Controller_ArtifactComparerWindowMediator___ctor
		               (int *param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  int iVar2;
		  undefined4 uVar3;
		  int *piVar4;
		  undefined4 uVar5;
		  
		  if (DAT_ram_00a58a3b == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_ArtifactComparerModel__ArtifactComparerEvents__ArtifactComparerController__ArtifactComparerWindow__set_Events__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_ArtifactComparer_Controller_ArtifactComparerWindowMediator_InventoryChangedEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_ArtifactComparer_Controller_ArtifactComparerWindowMediator_PowersChangedEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_ArtifactComparer_Controller_ArtifactComparerWindowMediator_TargetArtifactChangedEvent__
		              );
		    DAT_ram_00a58a3b = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x13c));
		  if (iVar1 != 0) {
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar5 = *(undefined4 *)(iVar2 + 0x18);
		    uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar3,param1,
		               Method_Gameplay_ArtifactComparer_Controller_ArtifactComparerWindowMediator_TargetArtifactChangedEvent__
		               ,0);
		    piVar4 = (int *)func_ii_7048(uVar5,uVar3,0);
		    iVar1 = System_Action_TypeInfo;
		    if (piVar4 == (int *)0x0) {
		      *(undefined4 *)(iVar2 + 0x18) = 0;
		    }
		    else if ((System_Action_TypeInfo != *piVar4) ||
		            (*(int **)(iVar2 + 0x18) = piVar4, *piVar4 != iVar1)) {
		      System_Activator__CreateInstance(piVar4,iVar1);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar5 = *(undefined4 *)(iVar2 + 0x1c);
		    uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar3,param1,
		               Method_Gameplay_ArtifactComparer_Controller_ArtifactComparerWindowMediator_InventoryChangedEvent__
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
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar5 = *(undefined4 *)(iVar2 + 0x24);
		    uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar3,param1,
		               Method_Gameplay_ArtifactComparer_Controller_ArtifactComparerWindowMediator_PowersChangedEvent__
		               ,0);
		    piVar4 = (int *)func_ii_7048(uVar5,uVar3,0);
		    iVar1 = System_Action_TypeInfo;
		    if (piVar4 == (int *)0x0) {
		      *(undefined4 *)(iVar2 + 0x24) = 0;
		    }
		    else if ((System_Action_TypeInfo != *piVar4) ||
		            (*(int **)(iVar2 + 0x24) = piVar4, *piVar4 != iVar1)) {
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
		    uVar5 = *(undefined4 *)(iVar2 + 0x18);
		    uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar3,param1,
		               Method_Gameplay_ArtifactComparer_Controller_ArtifactComparerWindowMediator_TargetArtifactChangedEvent__
		               ,0);
		    piVar4 = (int *)UnityEngine_UI_Image__set_sprite(uVar5,uVar3,0);
		    iVar1 = System_Action_TypeInfo;
		    if (piVar4 == (int *)0x0) {
		      *(undefined4 *)(iVar2 + 0x18) = 0;
		    }
		    else if ((System_Action_TypeInfo != *piVar4) ||
		            (*(int **)(iVar2 + 0x18) = piVar4, *piVar4 != iVar1)) {
		      System_Activator__CreateInstance(piVar4,iVar1);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar5 = *(undefined4 *)(iVar2 + 0x1c);
		    uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar3,param1,
		               Method_Gameplay_ArtifactComparer_Controller_ArtifactComparerWindowMediator_InventoryChangedEvent__
		               ,0);
		    piVar4 = (int *)UnityEngine_UI_Image__set_sprite(uVar5,uVar3,0);
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
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar5 = *(undefined4 *)(iVar2 + 0x24);
		    uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar3,param1,
		               Method_Gameplay_ArtifactComparer_Controller_ArtifactComparerWindowMediator_PowersChangedEvent__
		               ,0);
		    piVar4 = (int *)UnityEngine_UI_Image__set_sprite(uVar5,uVar3,0);
		    iVar1 = System_Action_TypeInfo;
		    if (piVar4 == (int *)0x0) {
		      *(undefined4 *)(iVar2 + 0x24) = 0;
		      return;
		    }
		    if ((System_Action_TypeInfo != *piVar4) || (*(int **)(iVar2 + 0x24) = piVar4, *piVar4 != iVar1))
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

		// Token: 0x17001048 RID: 4168
		// (set) Token: 0x0600507C RID: 20604 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001048")]
		public override ArtifactComparerEvents Events
		{
			[Token(Token = "0x600507C")]
			[Address(RVA = "0x9E8B", Offset = "0x9E8B", VA = "0x9E8B", Slot = "16")]
			set
			{
			}
		}

		// Token: 0x0600507D RID: 20605 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600507D")]
		[Address(RVA = "0x9E8C", Offset = "0x9E8C", VA = "0x9E8C")]
		private void PowersChangedEvent()
		{
		/* --- GHIDRA: PowersChangedEvent ---
		void Gameplay_ArtifactComparer_Controller_ArtifactComparerWindowMediator__PowersChangedEvent
		               (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined8 uVar2;
		  undefined4 uVar3;
		  int iVar4;
		  
		  if (DAT_ram_00a58a3c == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_ArtifactComparerModel__ArtifactComparerEvents__ArtifactComparerController__ArtifactComparerWindow__get_Model__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_ulong__ArtifactData__ContainsKey__);
		    DAT_ram_00a58a3c = '\x01';
		  }
		  uVar3 = *(undefined4 *)(*(int *)(param1[2] + 0x10) + 0x28);
		  uVar2 = func_ii_7957(*(undefined4 *)(param1[2] + 0x14),0);
		  iVar1 = Google_Protobuf_Collections_RepeatedField_ulong___GetEnumerator
		                    (uVar3,uVar2,
		                     Method_System_Collections_Generic_Dictionary_ulong__ArtifactData__ContainsKey__
		                    );
		  uVar3 = (undefined4)((ulonglong)uVar2 >> 0x20);
		  if (iVar1 == 0) {
		    uVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,CONCAT44(uVar3,*(undefined4 *)(*param1 + 0x15c)));
		    System_ComponentModel_BindingList___Il2CppFullySharedGenericType___OnAddingNew(uVar3,0,0);
		    return;
		  }
		  iVar1 = *(int *)(param1[2] + 0x18);
		  if (iVar1 != 0) {
		    uVar3 = *(undefined4 *)(*(int *)(param1[2] + 0x10) + 0x28);
		    uVar2 = func_ii_7957(iVar1,0);
		    iVar1 = Google_Protobuf_Collections_RepeatedField_ulong___GetEnumerator
		                      (uVar3,uVar2,
		                       Method_System_Collections_Generic_Dictionary_ulong__ArtifactData__ContainsKey__
		                      );
		    uVar3 = (undefined4)((ulonglong)uVar2 >> 0x20);
		    if (iVar1 == 0) {
		      *(undefined4 *)(param1[2] + 0x18) = 0;
		    }
		  }
		  if (DAT_ram_00a58a40 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_ArtifactComparerModel__ArtifactComparerEvents__ArtifactComparerController__ArtifactComparerWindow__get_Model__
		              );
		    DAT_ram_00a58a40 = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,CONCAT44(uVar3,*(undefined4 *)(*param1 + 0x15c)));
		  iVar4 = **(int **)(iVar1 + 0x3c);
		  (**(code **)((ulonglong)*(uint *)(iVar4 + 0x138) * 4))
		            (*(int **)(iVar1 + 0x3c),*(undefined4 *)(param1[2] + 0x14),
		             *(undefined4 *)(iVar4 + 0x13c));
		  Gameplay_ArtifactComparer_Controller_ArtifactComparerWindowMediator__ViewOnSelectArtifactEvent
		            (param1,param1);
		  Gameplay_ArtifactComparer_Controller_ArtifactComparerWindowMediator__FilterArtifacts
		            (param1,param1);
		  return;
		}
		*/

		}

		// Token: 0x0600507E RID: 20606 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600507E")]
		[Address(RVA = "0x9E8D", Offset = "0x9E8D", VA = "0x9E8D")]
		private void InventoryChangedEvent()
		{
		}

		// Token: 0x0600507F RID: 20607 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600507F")]
		[Address(RVA = "0x9E8E", Offset = "0x9E8E", VA = "0x9E8E")]
		private void TargetArtifactChangedEvent()
		{
		/* --- GHIDRA: TargetArtifactChangedEvent ---
		void Gameplay_ArtifactComparer_Controller_ArtifactComparerWindowMediator__TargetArtifactChangedEvent
		               (int *param1,int param2,undefined4 param3)
		
		{
		  bool bVar1;
		  int iVar2;
		  undefined4 uVar3;
		  int iVar4;
		  int iVar5;
		  undefined4 uVar6;
		  int iVar7;
		  
		  if (DAT_ram_00a58a3d == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_ArtifactComparerModel__ArtifactComparerEvents__ArtifactComparerController__ArtifactComparerWindow__set_View__
		              );
		    Mono_Security_ASN1__get_Item
		              (&System_Action_ArtifactComparerWindow_ArtifactComparerWindowArgs__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_ArtifactData__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_ToggleButton__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_SkillSelectorItemView__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_ArtifactComparer_Controller_ArtifactComparerWindowMediator_FiltersViewOnChangedEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_ArtifactComparer_Controller_ArtifactComparerWindowMediator_SkillSelectorButtonClickHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_ArtifactComparer_Controller_ArtifactComparerWindowMediator_SkillSelectorViewOnSelectEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_ArtifactComparer_Controller_ArtifactComparerWindowMediator_ViewOnNewDataEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_ArtifactComparer_Controller_ArtifactComparerWindowMediator_ViewOnSelectArtifactEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_BaseWindow_ArtifactComparerWindow_ArtifactComparerWindowArgs__get_WindowArgs__
		              );
		    DAT_ram_00a58a3d = '\x01';
		  }
		  uVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar4 = Cysharp_Threading_Tasks_CancellationTokenExtensions___cctor(uVar3,0);
		  if (iVar4 != 0) {
		    iVar4 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar6 = *(undefined4 *)(iVar4 + 0x5c);
		    uVar3 = unnamed_function_1417(System_Action_ToggleButton__TypeInfo);
		    UnityEngine_UIElements_VisualElement__get_layout
		              (uVar3,param1,
		               Method_Gameplay_ArtifactComparer_Controller_ArtifactComparerWindowMediator_SkillSelectorButtonClickHandler__
		               ,0);
		    UI_ToggleButton__add_ClickEvent(uVar6,uVar3,0);
		    iVar4 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    iVar4 = *(int *)(iVar4 + 0x58);
		    uVar3 = unnamed_function_1417(System_Action_SkillSelectorItemView__TypeInfo);
		    UnityEngine_UIElements_VisualElement__get_layout
		              (uVar3,param1,
		               Method_Gameplay_ArtifactComparer_Controller_ArtifactComparerWindowMediator_SkillSelectorViewOnSelectEvent__
		               ,0);
		    if (DAT_ram_00a58a23 == '\0') {
		      Mono_Security_ASN1__get_Item(&System_Action_SkillSelectorItemView__TypeInfo);
		      DAT_ram_00a58a23 = '\x01';
		    }
		    iVar7 = *(int *)(iVar4 + 0x2c);
		    do {
		      iVar2 = 0;
		      iVar5 = func_ii_7048(iVar7,uVar3,0);
		      uVar6 = System_Action_SkillSelectorItemView__TypeInfo;
		      if ((iVar5 != 0) &&
		         (iVar2 = func_ii_1082(iVar5,System_Action_SkillSelectorItemView__TypeInfo), iVar2 == 0)) {
		        System_Activator__CreateInstance(iVar5,uVar6);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      iVar2 = func_ii_4329(iVar4 + 0x2c,iVar2,iVar7);
		      bVar1 = iVar2 != iVar7;
		      iVar7 = iVar2;
		    } while (bVar1);
		    iVar4 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar3 = unnamed_function_1417(System_Action_ArtifactData__TypeInfo);
		    UnityEngine_UIElements_VisualElement__get_layout
		              (uVar3,param1,
		               Method_Gameplay_ArtifactComparer_Controller_ArtifactComparerWindowMediator_ViewOnSelectArtifactEvent__
		               ,0);
		    if (DAT_ram_00a58a0b == '\0') {
		      Mono_Security_ASN1__get_Item(&System_Action_ArtifactData__TypeInfo);
		      DAT_ram_00a58a0b = '\x01';
		    }
		    iVar7 = *(int *)(iVar4 + 0x7c);
		    do {
		      iVar2 = 0;
		      iVar5 = func_ii_7048(iVar7,uVar3,0);
		      uVar6 = System_Action_ArtifactData__TypeInfo;
		      if ((iVar5 != 0) &&
		         (iVar2 = func_ii_1082(iVar5,System_Action_ArtifactData__TypeInfo), iVar2 == 0)) {
		        System_Activator__CreateInstance(iVar5,uVar6);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      iVar2 = func_ii_4329(iVar4 + 0x7c,iVar2,iVar7);
		      bVar1 = iVar2 != iVar7;
		      iVar7 = iVar2;
		    } while (bVar1);
		    iVar4 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar6 = *(undefined4 *)(iVar4 + 0x54);
		    uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar3,param1,
		               Method_Gameplay_ArtifactComparer_Controller_ArtifactComparerWindowMediator_FiltersViewOnChangedEvent__
		               ,0);
		    UI_Filters_FiltersView__add_ChangedEvent(uVar6,uVar3,0);
		    iVar4 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar3 = unnamed_function_1417
		                      (System_Action_ArtifactComparerWindow_ArtifactComparerWindowArgs__TypeInfo);
		    UnityEngine_UIElements_VisualElement__get_layout
		              (uVar3,param1,
		               Method_Gameplay_ArtifactComparer_Controller_ArtifactComparerWindowMediator_ViewOnNewDataEvent__
		               ,0);
		    if (DAT_ram_00a58a0d == '\0') {
		      Mono_Security_ASN1__get_Item
		                (&System_Action_ArtifactComparerWindow_ArtifactComparerWindowArgs__TypeInfo);
		      DAT_ram_00a58a0d = '\x01';
		    }
		    iVar7 = *(int *)(iVar4 + 0x80);
		    do {
		      iVar2 = 0;
		      iVar5 = func_ii_7048(iVar7,uVar3,0);
		      uVar6 = System_Action_ArtifactComparerWindow_ArtifactComparerWindowArgs__TypeInfo;
		      if ((iVar5 != 0) &&
		         (iVar2 = func_ii_1082(iVar5,
		                               System_Action_ArtifactComparerWindow_ArtifactComparerWindowArgs__TypeInfo
		                              ), iVar2 == 0)) {
		        System_Activator__CreateInstance(iVar5,uVar6);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      iVar2 = func_ii_4329(iVar4 + 0x80,iVar2,iVar7);
		      bVar1 = iVar2 != iVar7;
		      iVar7 = iVar2;
		    } while (bVar1);
		  }
		  param1[5] = param2;
		  uVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar4 = Cysharp_Threading_Tasks_CancellationTokenExtensions___cctor(uVar3,0);
		  if (iVar4 != 0) {
		    iVar4 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar6 = *(undefined4 *)(iVar4 + 0x5c);
		    uVar3 = unnamed_function_1417(System_Action_ToggleButton__TypeInfo);
		    UnityEngine_UIElements_VisualElement__get_layout
		              (uVar3,param1,
		               Method_Gameplay_ArtifactComparer_Controller_ArtifactComparerWindowMediator_SkillSelectorButtonClickHandler__
		               ,0);
		    UI_TileAndScrollEntitieDescription___ctor(uVar6,uVar3,0);
		    iVar4 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    iVar4 = *(int *)(iVar4 + 0x58);
		    uVar3 = unnamed_function_1417(System_Action_SkillSelectorItemView__TypeInfo);
		    UnityEngine_UIElements_VisualElement__get_layout
		              (uVar3,param1,
		               Method_Gameplay_ArtifactComparer_Controller_ArtifactComparerWindowMediator_SkillSelectorViewOnSelectEvent__
		               ,0);
		    if (DAT_ram_00a58a22 == '\0') {
		      Mono_Security_ASN1__get_Item(&System_Action_SkillSelectorItemView__TypeInfo);
		      DAT_ram_00a58a22 = '\x01';
		    }
		    iVar7 = *(int *)(iVar4 + 0x2c);
		    do {
		      iVar2 = 0;
		      iVar5 = UnityEngine_UI_Image__set_sprite(iVar7,uVar3,0);
		      uVar6 = System_Action_SkillSelectorItemView__TypeInfo;
		      if ((iVar5 != 0) &&
		         (iVar2 = func_ii_1082(iVar5,System_Action_SkillSelectorItemView__TypeInfo), iVar2 == 0)) {
		        System_Activator__CreateInstance(iVar5,uVar6);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      iVar2 = func_ii_4329(iVar4 + 0x2c,iVar2,iVar7);
		      bVar1 = iVar2 != iVar7;
		      iVar7 = iVar2;
		    } while (bVar1);
		    iVar4 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar3 = unnamed_function_1417(System_Action_ArtifactData__TypeInfo);
		    UnityEngine_UIElements_VisualElement__get_layout
		              (uVar3,param1,
		               Method_Gameplay_ArtifactComparer_Controller_ArtifactComparerWindowMediator_ViewOnSelectArtifactEvent__
		               ,0);
		    if (DAT_ram_00a58a0a == '\0') {
		      Mono_Security_ASN1__get_Item(&System_Action_ArtifactData__TypeInfo);
		      DAT_ram_00a58a0a = '\x01';
		    }
		    iVar7 = *(int *)(iVar4 + 0x7c);
		    do {
		      iVar2 = 0;
		      iVar5 = UnityEngine_UI_Image__set_sprite(iVar7,uVar3,0);
		      uVar6 = System_Action_ArtifactData__TypeInfo;
		      if ((iVar5 != 0) &&
		         (iVar2 = func_ii_1082(iVar5,System_Action_ArtifactData__TypeInfo), iVar2 == 0)) {
		        System_Activator__CreateInstance(iVar5,uVar6);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      iVar2 = func_ii_4329(iVar4 + 0x7c,iVar2,iVar7);
		      bVar1 = iVar2 != iVar7;
		      iVar7 = iVar2;
		    } while (bVar1);
		    iVar4 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar6 = *(undefined4 *)(iVar4 + 0x54);
		    uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar3,param1,
		               Method_Gameplay_ArtifactComparer_Controller_ArtifactComparerWindowMediator_FiltersViewOnChangedEvent__
		               ,0);
		    UI_Filters_FiltersView__get_PriceFilterButton(uVar6,uVar3,0);
		    iVar4 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar3 = unnamed_function_1417
		                      (System_Action_ArtifactComparerWindow_ArtifactComparerWindowArgs__TypeInfo);
		    UnityEngine_UIElements_VisualElement__get_layout
		              (uVar3,param1,
		               Method_Gameplay_ArtifactComparer_Controller_ArtifactComparerWindowMediator_ViewOnNewDataEvent__
		               ,0);
		    if (DAT_ram_00a58a0c == '\0') {
		      Mono_Security_ASN1__get_Item
		                (&System_Action_ArtifactComparerWindow_ArtifactComparerWindowArgs__TypeInfo);
		      DAT_ram_00a58a0c = '\x01';
		    }
		    iVar7 = *(int *)(iVar4 + 0x80);
		    do {
		      iVar2 = 0;
		      iVar5 = UnityEngine_UI_Image__set_sprite(iVar7,uVar3,0);
		      uVar6 = System_Action_ArtifactComparerWindow_ArtifactComparerWindowArgs__TypeInfo;
		      if ((iVar5 != 0) &&
		         (iVar2 = func_ii_1082(iVar5,
		                               System_Action_ArtifactComparerWindow_ArtifactComparerWindowArgs__TypeInfo
		                              ), iVar2 == 0)) {
		        System_Activator__CreateInstance(iVar5,uVar6);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      iVar2 = func_ii_4329(iVar4 + 0x80,iVar2,iVar7);
		      bVar1 = iVar2 != iVar7;
		      iVar7 = iVar2;
		    } while (bVar1);
		    iVar7 = *param1;
		    iVar4 = (**(code **)((ulonglong)*(uint *)(iVar7 + 0x158) * 4))
		                      (param1,*(undefined4 *)(iVar7 + 0x15c));
		    uVar3 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                      (*(undefined4 *)(iVar4 + 0x58),0);
		    Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		              (uVar3,0,0);
		    Gameplay_ArtifactComparer_Controller_ArtifactComparerWindowMediator__FiltersViewOnChangedEvent
		              (param1,iVar7);
		    uVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x14c));
		    iVar7 = *param1;
		    uVar6 = (**(code **)((ulonglong)*(uint *)(iVar7 + 0x158) * 4))
		                      (param1,*(undefined4 *)(iVar7 + 0x15c));
		    iVar4 = func_ii_8093(uVar6,
		                         Method_UI_Windows_BaseWindow_ArtifactComparerWindow_ArtifactComparerWindowArgs__get_WindowArgs__
		                        );
		    Gameplay_ArtifactComparer_Controller_ArtifactComparerController__SetSkillEnable
		              (uVar3,*(undefined4 *)(iVar4 + 0x18),iVar7);
		  }
		  return;
		}
		*/

		}

		// Token: 0x17001049 RID: 4169
		// (set) Token: 0x06005080 RID: 20608 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001049")]
		public override ArtifactComparerWindow View
		{
			[Token(Token = "0x6005080")]
			[Address(RVA = "0x9E8F", Offset = "0x9E8F", VA = "0x9E8F", Slot = "20")]
			set
			{
			}
		}

		// Token: 0x06005081 RID: 20609 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005081")]
		[Address(RVA = "0x9E90", Offset = "0x9E90", VA = "0x9E90")]
		private void SkillSelectorButtonClickHandler(ToggleButton toggleButton)
		{
		/* --- GHIDRA: SkillSelectorButtonClickHandler ---
		void Gameplay_ArtifactComparer_Controller_ArtifactComparerWindowMediator__SkillSelectorButtonClickHandler
		               (int *param1,int param2,undefined4 param3)
		
		{
		  undefined4 param3_00;
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a58a3f == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_ArtifactComparerModel__ArtifactComparerEvents__ArtifactComparerController__ArtifactComparerWindow__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_HashSet_int__get_Count__);
		    Mono_Security_ASN1__get_Item(&StringLiteral_2643);
		    DAT_ram_00a58a3f = '\x01';
		  }
		  if ((*(int *)(*(int *)(param1[2] + 0x20) + 0x10) == 1) &&
		     (*(char *)(*(int *)(param2 + 0x10) + 0xc4) == '\0')) {
		    func_ii_7603(*(int *)(param2 + 0x10),1,0);
		    uVar1 = System_Uri___ctor(0);
		    uVar1 = System_Globalization_TimeSpanFormat_FormatLiterals__get_DayHourSep(uVar1,0);
		    if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_GameLocalization_TypeInfo);
		    }
		    param3_00 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_2643,1,0,1,0,0,0,0);
		    Core_Application_App__get_ToastController(uVar1,1,param3_00,0);
		    return;
		  }
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x14c));
		  Gameplay_ArtifactComparer_Controller_ArtifactComparerController__Compare
		            (uVar1,*(undefined4 *)(param2 + 0x20),(uint)*(byte *)(*(int *)(param2 + 0x10) + 0xc4),
		             param1);
		  return;
		}
		*/

		}

		// Token: 0x06005082 RID: 20610 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005082")]
		[Address(RVA = "0x9E91", Offset = "0x9E91", VA = "0x9E91")]
		private void SkillSelectorViewOnSelectEvent(SkillSelectorItemView skill)
		{
		/* --- GHIDRA: SkillSelectorViewOnSelectEvent ---
		void Gameplay_ArtifactComparer_Controller_ArtifactComparerWindowMediator__SkillSelectorViewOnSelectEvent
		               (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  int iVar2;
		  
		  if (DAT_ram_00a58a40 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_ArtifactComparerModel__ArtifactComparerEvents__ArtifactComparerController__ArtifactComparerWindow__get_Model__
		              );
		    DAT_ram_00a58a40 = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar2 = **(int **)(iVar1 + 0x3c);
		  (**(code **)((ulonglong)*(uint *)(iVar2 + 0x138) * 4))
		            (*(int **)(iVar1 + 0x3c),*(undefined4 *)(param1[2] + 0x14),
		             *(undefined4 *)(iVar2 + 0x13c));
		  Gameplay_ArtifactComparer_Controller_ArtifactComparerWindowMediator__ViewOnSelectArtifactEvent
		            (param1,param1);
		  Gameplay_ArtifactComparer_Controller_ArtifactComparerWindowMediator__FilterArtifacts
		            (param1,param1);
		  return;
		}
		*/

		}

		// Token: 0x06005083 RID: 20611 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005083")]
		[Address(RVA = "0x9E92", Offset = "0x9E92", VA = "0x9E92")]
		private void Render()
		{
		/* --- GHIDRA: Render ---
		void Gameplay_ArtifactComparer_Controller_ArtifactComparerWindowMediator__Render
		               (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  int iVar2;
		  
		  if (DAT_ram_00a58a40 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_ArtifactComparerModel__ArtifactComparerEvents__ArtifactComparerController__ArtifactComparerWindow__get_Model__
		              );
		    DAT_ram_00a58a40 = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar2 = **(int **)(iVar1 + 0x3c);
		  (**(code **)((ulonglong)*(uint *)(iVar2 + 0x138) * 4))
		            (*(int **)(iVar1 + 0x3c),*(undefined4 *)(param1[2] + 0x14),
		             *(undefined4 *)(iVar2 + 0x13c));
		  return;
		}
		*/

		}

		// Token: 0x06005084 RID: 20612 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005084")]
		[Address(RVA = "0x9E93", Offset = "0x9E93", VA = "0x9E93")]
		private void RenderTargetArtifact()
		{
		/* --- GHIDRA: RenderTargetArtifact ---
		void Gameplay_ArtifactComparer_Controller_ArtifactComparerWindowMediator__RenderTargetArtifact
		               (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  undefined4 param1_00;
		  int iVar2;
		  
		  if (DAT_ram_00a58a41 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_BaseWindow_ArtifactComparerWindow_ArtifactComparerWindowArgs__get_WindowArgs__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_BaseWindow_ArtifactComparerWindow_ArtifactComparerWindowArgs__set_WindowArgs__
		              );
		    DAT_ram_00a58a41 = '\x01';
		  }
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  UnityEngine_Purchasing_Default_WinProductDescription__set_priceDecimal
		            (uVar1,param2,
		             Method_UI_Windows_BaseWindow_ArtifactComparerWindow_ArtifactComparerWindowArgs__set_WindowArgs__
		            );
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x14c));
		  param1_00 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar2 = func_ii_8093(param1_00,
		                       Method_UI_Windows_BaseWindow_ArtifactComparerWindow_ArtifactComparerWindowArgs__get_WindowArgs__
		                      );
		  Gameplay_ArtifactComparer_Controller_ArtifactComparerController__SetSkillEnable
		            (uVar1,*(undefined4 *)(iVar2 + 0x18),param1);
		  return;
		}
		*/

		}

		// Token: 0x06005085 RID: 20613 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005085")]
		[Address(RVA = "0x9E94", Offset = "0x9E94", VA = "0x9E94")]
		private void ViewOnNewDataEvent(ArtifactComparerWindow.ArtifactComparerWindowArgs newData)
		{
		/* --- GHIDRA: ViewOnNewDataEvent ---
		void Gameplay_ArtifactComparer_Controller_ArtifactComparerWindowMediator__ViewOnNewDataEvent
		               (int *param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a58a42 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_ArtifactComparerModel__ArtifactComparerEvents__ArtifactComparerController__ArtifactComparerWindow__get_Model__
		              );
		    DAT_ram_00a58a42 = '\x01';
		  }
		  Gameplay_ArtifactComparer_Controller_ArtifactComparerWindowMediator__FiltersViewOnChangedEvent
		            (param1,param1);
		  Gameplay_ArtifactComparer_Controller_ArtifactComparerWindowMediator__ViewOnSelectArtifactEvent
		            (param1,param1);
		  param1_00 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x15c));
		  Gameplay_ArtifactComparer_View_ArtifactComparerWindow__ViewOnClickEvent
		            (param1_00,*(undefined4 *)(param1[2] + 0x18),param1);
		  return;
		}
		*/

		}

		// Token: 0x06005086 RID: 20614 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005086")]
		[Address(RVA = "0x9E95", Offset = "0x9E95", VA = "0x9E95")]
		private void FiltersViewOnChangedEvent()
		{
		/* --- GHIDRA: FiltersViewOnChangedEvent ---
		void Gameplay_ArtifactComparer_Controller_ArtifactComparerWindowMediator__FiltersViewOnChangedEvent
		               (int *param1,undefined4 param2)
		
		{
		  uint uVar1;
		  undefined4 uVar2;
		  int iVar3;
		  undefined4 *puVar4;
		  int *piVar5;
		  int iVar6;
		  int *piVar7;
		  int local_18;
		  undefined8 *local_14;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a58a43 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_FilterInfo_FilterType__IArtifactFilter__get_Item__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_FilterInfo_FilterType__FilterInfo__get_Item__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_FilterInfo_FilterType__IArtifactFilter__get_Keys__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_KeyCollection_Enumerator_FilterInfo_FilterType__IArtifactFilter__Dispose__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_KeyCollection_Enumerator_FilterInfo_FilterType__IArtifactFilter__MoveNext__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_KeyCollection_Enumerator_FilterInfo_FilterType__IArtifactFilter__get_Current__
		              );
		    Mono_Security_ASN1__get_Item(&Gameplay_Inventory_Controller_Filters_IArtifactFilter_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_KeyCollection_FilterInfo_FilterType__IArtifactFilter__GetEnumerator__
		              );
		    DAT_ram_00a58a43 = '\x01';
		  }
		  local_8 = 0;
		  local_10 = 0;
		  uVar2 = System_Collections_Generic_Dictionary_TypeConverterRegistry_ConverterKey__object___System_Collections_Generic_ICollection_System_Collections_Generic_KeyValuePair_TKey_TValue___get_IsReadOnly
		                    (param1[6],
		                     Method_System_Collections_Generic_Dictionary_FilterInfo_FilterType__IArtifactFilter__get_Keys__
		                    );
		  System_Collections_Generic_Dictionary_Int32Enum__object___get_Values
		            (&local_10,uVar2,
		             Method_System_Collections_Generic_Dictionary_KeyCollection_FilterInfo_FilterType__IArtifactFilter__GetEnumerator__
		            );
		  local_18 = 0;
		  local_14 = &local_10;
		  do {
		    DAT_ram_009d3e38 = 0;
		    iVar3 = import::env::invoke_iii
		                      (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x96,&local_10,
		                       Method_System_Collections_Generic_Dictionary_KeyCollection_Enumerator_FilterInfo_FilterType__IArtifactFilter__MoveNext__
		                      );
		    iVar6 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar6 == 1) {
		      uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80f66cbd;
		    }
		    if (iVar3 == 0) {
		      DAT_ram_009d3e38 = 0;
		      return;
		    }
		    DAT_ram_009d3e38 = 0;
		    uVar2 = local_8._4_4_;
		    piVar5 = (int *)import::env::invoke_iiii
		                              (s_struct_Uniforms___color__array<v_ram_00000aff + 0x151,param1[6],
		                               local_8._4_4_,
		                               Method_System_Collections_Generic_Dictionary_FilterInfo_FilterType__IArtifactFilter__get_Item__
		                              );
		    iVar6 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar6 == 1) {
		      uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80f66cbd;
		    }
		    DAT_ram_009d3e38 = 0;
		    iVar3 = import::env::invoke_iii
		                      (*(undefined4 *)(*param1 + 0x158),param1,*(undefined4 *)(*param1 + 0x15c));
		    iVar6 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar6 == 1) {
		      uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80f66cbd;
		    }
		    DAT_ram_009d3e38 = 0;
		    uVar2 = import::env::invoke_iiii
		                      (s_struct_Uniforms___color__array<v_ram_00000aff + 0x151,
		                       *(undefined4 *)(*(int *)(iVar3 + 0x54) + 0x38),uVar2,
		                       Method_System_Collections_Generic_Dictionary_FilterInfo_FilterType__FilterInfo__get_Item__
		                      );
		    if (DAT_ram_009d3e38 == 1) break;
		    iVar6 = *piVar5;
		    if (*(ushort *)(iVar6 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        piVar7 = (int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8);
		        if (Gameplay_Inventory_Controller_Filters_IArtifactFilter_TypeInfo == *piVar7) {
		          puVar4 = (undefined4 *)(piVar7[1] * 8 + iVar6 + 200);
		          goto code_r0x80f66c4a;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		    }
		    DAT_ram_009d3e38 = 0;
		    puVar4 = (undefined4 *)
		             import::env::invoke_iiii
		                       (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,piVar5,
		                        Gameplay_Inventory_Controller_Filters_IArtifactFilter_TypeInfo,1);
		    if (DAT_ram_009d3e38 == 1) break;
		code_r0x80f66c4a:
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_viii(*puVar4,piVar5,uVar2,puVar4[1]);
		  } while (DAT_ram_009d3e38 != 1);
		  DAT_ram_009d3e38 = 0;
		  uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x80f66cbd:
		  iVar6 = global_1;
		  iVar3 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar6 == iVar3) {
		    piVar5 = (int *)import::env::__cxa_begin_catch(uVar2);
		    iVar3 = *piVar5;
		    DAT_ram_009d3e38 = 0;
		    local_18 = iVar3;
		    import::env::invoke_v(0x123);
		    iVar6 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar6 != 1) {
		      if (iVar3 == 0) {
		        DAT_ram_009d3e38 = 0;
		        return;
		      }
		      System_Data_DataSet__ValidateLocaleConstraint(iVar3);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    uVar2 = import::env::__cxa_find_matching_catch_2();
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001b87 + 0x22c,&local_18);
		  iVar6 = DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = 0;
		  if (iVar6 != 1) {
		    import::env::__resumeException(uVar2);
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
		*/

		}

		// Token: 0x06005087 RID: 20615 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005087")]
		[Address(RVA = "0x9E96", Offset = "0x9E96", VA = "0x9E96")]
		private void SetFiltersData()
		{
		/* --- GHIDRA: SetFiltersData ---
		void Gameplay_ArtifactComparer_Controller_ArtifactComparerWindowMediator__SetFiltersData
		               (int param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  
		  if (DAT_ram_00a58a44 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_ArtifactComparerModel__ArtifactComparerEvents__ArtifactComparerController__ArtifactComparerWindow__get_Model__
		              );
		    DAT_ram_00a58a44 = '\x01';
		  }
		  iVar1 = param2;
		  if (*(int *)(*(int *)(param1 + 8) + 0x18) == param2) {
		    iVar1 = 0;
		  }
		  *(int *)(*(int *)(param1 + 8) + 0x18) = iVar1;
		  Gameplay_ArtifactComparer_Controller_ArtifactComparerWindowMediator__FilterArtifacts
		            (param1,param2);
		  return;
		}
		*/

		}

		// Token: 0x06005088 RID: 20616 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005088")]
		[Address(RVA = "0x9E97", Offset = "0x9E97", VA = "0x9E97")]
		private void ViewOnSelectArtifactEvent(ArtifactData artifactData)
		{
		/* --- GHIDRA: ViewOnSelectArtifactEvent ---
		void Gameplay_ArtifactComparer_Controller_ArtifactComparerWindowMediator__ViewOnSelectArtifactEvent
		               (int *param1,undefined4 param2)
		
		{
		  uint uVar1;
		  int iVar2;
		  undefined4 uVar3;
		  int iVar4;
		  int iVar5;
		  int *piVar6;
		  undefined4 uVar7;
		  uint *puVar8;
		  int iVar9;
		  int *piVar10;
		  int iVar11;
		  undefined4 param3;
		  undefined4 *puVar12;
		  undefined4 param3_00;
		  int *piVar13;
		  int local_24;
		  int **ppiStack_20;
		  undefined8 local_1c;
		  int *local_14;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a58a45 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_ArtifactComparerModel__ArtifactComparerEvents__ArtifactComparerController__ArtifactComparerWindow__get_Model__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_ArtikulTypeDic__List_ArtifactData___ContainsKey__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_ArtikulTypeDic__List_ArtifactData____ctor__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_ArtikulTypeDic__List_ArtifactData___get_Item__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_ulong__ArtifactData__get_Values__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_ArtikulTypeDic__List_ArtifactData___set_Item__
		              );
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_Dictionary_ArtikulTypeDic__List_ArtifactData___TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Linq_Enumerable_OrderByDescending_ArtifactData__long___);
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_ToList_ArtifactData___);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_ValueCollection_Enumerator_ulong__ArtifactData__Dispose__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_ValueCollection_Enumerator_ulong__ArtifactData__MoveNext__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_ValueCollection_Enumerator_ulong__ArtifactData__get_Current__
		              );
		    Mono_Security_ASN1__get_Item(&System_Func_ArtifactData__long__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_ICollection_ArtifactData__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_IDisposable_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_IEnumerable_ArtifactData__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_IEnumerator_ArtifactData__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_IEnumerator_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_ArtifactData__Add__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_ArtifactData___ctor__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_ArtifactData__get_Count__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_List_ArtifactData__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_ArtifactComparer_Controller_ArtifactComparerWindowMediator___c__RenderPossibleArtifacts_b__18_0__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_ArtifactComparer_Controller_ArtifactComparerWindowMediator___c_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_ValueCollection_ulong__ArtifactData__GetEnumerator__
		              );
		    DAT_ram_00a58a45 = '\x01';
		  }
		  local_8 = 0;
		  local_10 = 0;
		  local_14 = (int *)0x0;
		  iVar2 = unnamed_function_1417(System_Collections_Generic_List_ArtifactData__TypeInfo);
		  GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		            (iVar2,Method_System_Collections_Generic_List_ArtifactData___ctor__);
		  uVar3 = System_Collections_Generic_Dictionary_int__object___TryAdd
		                    (*(undefined4 *)(*(int *)(param1[2] + 0x10) + 0x28),
		                     Method_System_Collections_Generic_Dictionary_ulong__ArtifactData__get_Values__)
		  ;
		  System_Collections_Generic_Dictionary_Int32Enum__object___get_Values
		            (&local_24,uVar3,
		             Method_System_Collections_Generic_Dictionary_ValueCollection_ulong__ArtifactData__GetEnumerator__
		            );
		  local_8 = local_1c;
		  local_24 = 0;
		  ppiStack_20 = (int **)&local_10;
		  do {
		    while( true ) {
		      do {
		        do {
		          do {
		            DAT_ram_009d3e38 = 0;
		            iVar4 = import::env::invoke_iii
		                              (s_struct_Uniforms___color__array<v_ram_000017c8 + 0x2e2,&local_10,
		                               Method_System_Collections_Generic_Dictionary_ValueCollection_Enumerator_ulong__ArtifactData__MoveNext__
		                              );
		            iVar11 = DAT_ram_009d3e38;
		            DAT_ram_009d3e38 = 0;
		            if (iVar11 == 1) {
		              uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		              goto code_r0x80f659ff;
		            }
		            if (iVar4 == 0) {
		              iVar4 = 5;
		              iVar11 = local_24;
		              goto code_r0x80f65a4c;
		            }
		            DAT_ram_009d3e38 = 0;
		            iVar4 = local_8._4_4_;
		            iVar9 = import::env::invoke_iii
		                              (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x227,local_8._4_4_
		                               ,0);
		            iVar11 = DAT_ram_009d3e38;
		            DAT_ram_009d3e38 = 0;
		            if (iVar11 == 1) {
		              uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		              goto code_r0x80f659ff;
		            }
		          } while (iVar9 == 0);
		          DAT_ram_009d3e38 = 0;
		          iVar9 = import::env::invoke_iii
		                            (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x228,iVar4,0);
		          iVar11 = DAT_ram_009d3e38;
		          DAT_ram_009d3e38 = 0;
		          if (iVar11 == 1) {
		            uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		            goto code_r0x80f659ff;
		          }
		          DAT_ram_009d3e38 = 0;
		          iVar5 = import::env::invoke_iii
		                            (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x228,
		                             *(undefined4 *)(param1[2] + 0x14),0);
		          iVar11 = DAT_ram_009d3e38;
		          DAT_ram_009d3e38 = 0;
		          if (iVar11 == 1) {
		            uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		            goto code_r0x80f659ff;
		          }
		        } while (((iVar9 != iVar5) || (iVar11 = *(int *)(param1[2] + 0x14), iVar4 == iVar11)) ||
		                (((char)param1[7] != '\0' &&
		                 (*(int *)(*(int *)(iVar4 + 0xc) + 0xc) != *(int *)(*(int *)(iVar11 + 0xc) + 0xc))))
		                );
		        DAT_ram_009d3e38 = 0;
		        iVar5 = import::env::invoke_iiii
		                          (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x229,iVar4,iVar11,0);
		        iVar9 = DAT_ram_009d3e38;
		        iVar11 = Method_System_Collections_Generic_List_ArtifactData__Add__;
		        DAT_ram_009d3e38 = 0;
		        if (iVar9 == 1) {
		          uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x80f659ff;
		        }
		      } while (iVar5 == 0);
		      *(int *)(iVar2 + 0x10) = *(int *)(iVar2 + 0x10) + 1;
		      uVar1 = *(uint *)(iVar2 + 0xc);
		      if (*(uint *)(*(int *)(iVar2 + 8) + 0xc) <= uVar1) break;
		      *(uint *)(iVar2 + 0xc) = uVar1 + 1;
		      *(int *)(*(int *)(iVar2 + 8) + uVar1 * 4 + 0x10) = iVar4;
		    }
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_viii
		              (s_struct_Uniforms___color__array<v_ram_00000aff + 0x6e,iVar2,iVar4,
		               *(undefined4 *)(*(int *)(*(int *)(iVar11 + 0x10) + 0x60) + 0x38));
		    iVar11 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		  } while (iVar11 != 1);
		  uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x80f659ff:
		  iVar11 = global_1;
		  iVar4 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar11 == iVar4) {
		    piVar6 = (int *)import::env::__cxa_begin_catch(uVar3);
		    iVar11 = *piVar6;
		    iVar4 = 0;
		    DAT_ram_009d3e38 = 0;
		    local_24 = iVar11;
		    import::env::invoke_v(0x123);
		    iVar9 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar9 != 1) {
		code_r0x80f65a4c:
		      DAT_ram_009d3e38 = 0;
		      if (iVar11 != 0) {
		        System_Data_DataSet__ValidateLocaleConstraint(iVar11);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      if ((iVar4 != 0) &&
		         ((((iVar4 == 1 || (iVar4 == 2)) || (iVar4 == 3)) || ((iVar4 == 4 || (iVar4 != 5)))))) {
		        return;
		      }
		      param3 = *(undefined4 *)(iVar2 + 0xc);
		      uVar3 = Gameplay_ArtifactComparer_Controller_ArtifactComparerWindowMediator__RenderPossibleArtifacts
		                        (param1,iVar2,0);
		      if (*(int *)(Gameplay_ArtifactComparer_Controller_ArtifactComparerWindowMediator___c_TypeInfo
		                  + 0x74) == 0) {
		        func_ii_306000(
		                      Gameplay_ArtifactComparer_Controller_ArtifactComparerWindowMediator___c_TypeInfo
		                      );
		      }
		      puVar12 = *(undefined4 **)
		                 (Gameplay_ArtifactComparer_Controller_ArtifactComparerWindowMediator___c_TypeInfo +
		                 0x5c);
		      iVar2 = puVar12[1];
		      if (iVar2 == 0) {
		        if (*(int *)(
		                    Gameplay_ArtifactComparer_Controller_ArtifactComparerWindowMediator___c_TypeInfo
		                    + 0x74) == 0) {
		          func_ii_306000(
		                        Gameplay_ArtifactComparer_Controller_ArtifactComparerWindowMediator___c_TypeInfo
		                        );
		          puVar12 = *(undefined4 **)
		                     (
		                     Gameplay_ArtifactComparer_Controller_ArtifactComparerWindowMediator___c_TypeInfo
		                     + 0x5c);
		        }
		        uVar7 = *puVar12;
		        iVar2 = unnamed_function_1417(System_Func_ArtifactData__long__TypeInfo);
		        System_Func_object__Int32Enum___Invoke
		                  (iVar2,uVar7,
		                   Method_Gameplay_ArtifactComparer_Controller_ArtifactComparerWindowMediator___c__RenderPossibleArtifacts_b__18_0__
		                   ,0);
		        *(int *)(*(int *)(
		                         Gameplay_ArtifactComparer_Controller_ArtifactComparerWindowMediator___c_TypeInfo
		                         + 0x5c) + 4) = iVar2;
		      }
		      uVar1 = 0;
		      uVar3 = System_Linq_Enumerable__OrderByDescending_KeyValuePair_object__object___uint_
		                        (uVar3,iVar2,
		                         Method_System_Linq_Enumerable_OrderByDescending_ArtifactData__long___);
		      piVar6 = (int *)System_Linq_Enumerable__Select_object__object_
		                                (uVar3,Method_System_Linq_Enumerable_ToList_ArtifactData___);
		      uVar7 = unnamed_function_1417
		                        (
		                        System_Collections_Generic_Dictionary_ArtikulTypeDic__List_ArtifactData___TypeInfo
		                        );
		      System_Collections_Generic_Dictionary_object__StyleComplexSelector_PseudoStateData___set_Item
		                (uVar7,
		                 Method_System_Collections_Generic_Dictionary_ArtikulTypeDic__List_ArtifactData____ctor__
		                );
		      iVar2 = *piVar6;
		      if (*(ushort *)(iVar2 + 0xb6) != 0) {
		        do {
		          if (System_Collections_Generic_IEnumerable_ArtifactData__TypeInfo ==
		              *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8)) {
		            puVar8 = (uint *)(iVar2 + *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		            goto code_r0x80f65bd8;
		          }
		          uVar1 = uVar1 + 1;
		        } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		      }
		      puVar8 = (uint *)func_ii_1080(piVar6,
		                                    System_Collections_Generic_IEnumerable_ArtifactData__TypeInfo,0)
		      ;
		code_r0x80f65bd8:
		      local_14 = (int *)(**(code **)((ulonglong)*puVar8 * 4))(piVar6,puVar8[1]);
		      local_24 = 0;
		      ppiStack_20 = &local_14;
		code_r0x80f65c0d:
		      do {
		        piVar10 = local_14;
		        iVar2 = *local_14;
		        if (*(ushort *)(iVar2 + 0xb6) != 0) {
		          uVar1 = 0;
		          do {
		            piVar13 = (int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8);
		            if (System_Collections_IEnumerator_TypeInfo == *piVar13) {
		              puVar12 = (undefined4 *)(iVar2 + piVar13[1] * 8 + 0xc0);
		              goto code_r0x80f65ca1;
		            }
		            uVar1 = uVar1 + 1;
		          } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		        }
		        DAT_ram_009d3e38 = 0;
		        puVar12 = (undefined4 *)
		                  import::env::invoke_iiii
		                            (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_14,
		                             System_Collections_IEnumerator_TypeInfo,0);
		        if (DAT_ram_009d3e38 == 1) {
		code_r0x80f65fb3:
		          DAT_ram_009d3e38 = 0;
		          uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x80f65fbb;
		        }
		code_r0x80f65ca1:
		        DAT_ram_009d3e38 = 0;
		        iVar2 = import::env::invoke_iii(*puVar12,piVar10,puVar12[1]);
		        piVar10 = local_14;
		        if (DAT_ram_009d3e38 == 1) goto code_r0x80f65fb3;
		        if (iVar2 == 0) {
		          iVar2 = 10;
		          goto code_r0x80f66008;
		        }
		        iVar2 = *local_14;
		        if (*(ushort *)(iVar2 + 0xb6) != 0) {
		          uVar1 = 0;
		          do {
		            piVar13 = (int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8);
		            if (System_Collections_Generic_IEnumerator_ArtifactData__TypeInfo == *piVar13) {
		              puVar12 = (undefined4 *)(iVar2 + piVar13[1] * 8 + 0xc0);
		              goto code_r0x80f65d81;
		            }
		            uVar1 = uVar1 + 1;
		          } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		        }
		        DAT_ram_009d3e38 = 0;
		        puVar12 = (undefined4 *)
		                  import::env::invoke_iiii
		                            (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_14,
		                             System_Collections_Generic_IEnumerator_ArtifactData__TypeInfo,0);
		        if (DAT_ram_009d3e38 == 1) {
		code_r0x80f65eb5:
		          DAT_ram_009d3e38 = 0;
		          uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x80f65fbb;
		        }
		code_r0x80f65d81:
		        DAT_ram_009d3e38 = 0;
		        iVar2 = import::env::invoke_iii(*puVar12,piVar10,puVar12[1]);
		        if (DAT_ram_009d3e38 == 1) goto code_r0x80f65eb5;
		        DAT_ram_009d3e38 = 0;
		        iVar4 = import::env::invoke_iiii
		                          (s_struct_Uniforms___color__array<v_ram_00000f84 + 0xf7,uVar7,
		                           *(undefined4 *)(iVar2 + 0xc),
		                           Method_System_Collections_Generic_Dictionary_ArtikulTypeDic__List_ArtifactData___ContainsKey__
		                          );
		        iVar11 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar11 == 1) {
		          uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x80f65fbb;
		        }
		        if (iVar4 == 0) {
		          param3_00 = *(undefined4 *)(iVar2 + 0xc);
		          DAT_ram_009d3e38 = 0;
		          uVar3 = import::env::invoke_ii
		                            (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x199,
		                             System_Collections_Generic_List_ArtifactData__TypeInfo);
		          if (DAT_ram_009d3e38 != 1) {
		            DAT_ram_009d3e38 = 0;
		            import::env::invoke_vii
		                      (s_struct_Uniforms___color__array<v_ram_00000aff + 0x252,uVar3,
		                       Method_System_Collections_Generic_List_ArtifactData___ctor__);
		            if (DAT_ram_009d3e38 != 1) {
		              DAT_ram_009d3e38 = 0;
		              import::env::invoke_viiii
		                        (s_struct_Uniforms___color__array<v_ram_00000aff + 0x84,uVar7,param3_00,
		                         uVar3,
		                         Method_System_Collections_Generic_Dictionary_ArtikulTypeDic__List_ArtifactData___set_Item__
		                        );
		              if (DAT_ram_009d3e38 != 1) goto code_r0x80f65ec9;
		            }
		          }
		          DAT_ram_009d3e38 = 0;
		          uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x80f65fbb;
		        }
		code_r0x80f65ec9:
		        DAT_ram_009d3e38 = 0;
		        iVar9 = import::env::invoke_iiii
		                          (s_struct_Uniforms___color__array<v_ram_00000f84 + 0x2ec,uVar7,
		                           *(undefined4 *)(iVar2 + 0xc),
		                           Method_System_Collections_Generic_Dictionary_ArtikulTypeDic__List_ArtifactData___get_Item__
		                          );
		        iVar4 = DAT_ram_009d3e38;
		        iVar11 = Method_System_Collections_Generic_List_ArtifactData__Add__;
		        DAT_ram_009d3e38 = 0;
		        if (iVar4 == 1) {
		          uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x80f65fbb;
		        }
		        *(int *)(iVar9 + 0x10) = *(int *)(iVar9 + 0x10) + 1;
		        uVar1 = *(uint *)(iVar9 + 0xc);
		        if (uVar1 < *(uint *)(*(int *)(iVar9 + 8) + 0xc)) {
		          *(uint *)(iVar9 + 0xc) = uVar1 + 1;
		          *(int *)(*(int *)(iVar9 + 8) + uVar1 * 4 + 0x10) = iVar2;
		          goto code_r0x80f65c0d;
		        }
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_viii
		                  (s_struct_Uniforms___color__array<v_ram_00000aff + 0x6e,iVar9,iVar2,
		                   *(undefined4 *)(*(int *)(*(int *)(iVar11 + 0x10) + 0x60) + 0x38));
		        iVar2 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		      } while (iVar2 != 1);
		      uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x80f65fbb:
		      iVar2 = global_1;
		      iVar11 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		      if (iVar2 == iVar11) {
		        piVar10 = (int *)import::env::__cxa_begin_catch(uVar3);
		        local_24 = *piVar10;
		        iVar2 = 0;
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_v(0x123);
		        iVar11 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar11 != 1) {
		code_r0x80f66008:
		          DAT_ram_009d3e38 = 0;
		          piVar10 = *ppiStack_20;
		          if (piVar10 != (int *)0x0) {
		            uVar1 = 0;
		            iVar11 = *piVar10;
		            if (*(ushort *)(iVar11 + 0xb6) != 0) {
		              do {
		                if (System_IDisposable_TypeInfo == *(int *)(*(int *)(iVar11 + 0x58) + uVar1 * 8)) {
		                  puVar8 = (uint *)(iVar11 + *(int *)(*(int *)(iVar11 + 0x58) + uVar1 * 8 + 4) * 8 +
		                                   0xc0);
		                  goto code_r0x80f66083;
		                }
		                uVar1 = uVar1 + 1;
		              } while (*(ushort *)(iVar11 + 0xb6) != uVar1);
		            }
		            puVar8 = (uint *)func_ii_1080(piVar10,System_IDisposable_TypeInfo,0);
		code_r0x80f66083:
		            (**(code **)((ulonglong)*puVar8 * 4))(piVar10,puVar8[1]);
		          }
		          if (local_24 != 0) {
		            System_Data_DataSet__ValidateLocaleConstraint(local_24);
		            do {
		              halt_trap();
		            } while( true );
		          }
		          if (iVar2 != 0) {
		            if (iVar2 == 1) {
		              return;
		            }
		            if (iVar2 == 2) {
		              return;
		            }
		            if (iVar2 == 3) {
		              return;
		            }
		            if (iVar2 == 4) {
		              return;
		            }
		            if (iVar2 == 5) {
		              return;
		            }
		            if (iVar2 == 6) {
		              return;
		            }
		            if (iVar2 == 7) {
		              return;
		            }
		            if (iVar2 == 8) {
		              return;
		            }
		            if (iVar2 == 9) {
		              return;
		            }
		            if (iVar2 != 10) {
		              return;
		            }
		          }
		          iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                            (param1,*(undefined4 *)(*param1 + 0x15c));
		          *(undefined4 *)(iVar2 + 0x84) = uVar7;
		          Gameplay_ArtifactComparer_View_ArtifactComparerWindow__set_PossibleArtifacts(iVar2,iVar2);
		          iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                            (param1,*(undefined4 *)(*param1 + 0x15c));
		          uVar3 = *(undefined4 *)(iVar2 + 0x54);
		          uVar1 = 0;
		          iVar2 = *piVar6;
		          if (*(ushort *)(iVar2 + 0xb6) != 0) {
		            do {
		              if (System_Collections_Generic_ICollection_ArtifactData__TypeInfo ==
		                  *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8)) {
		                puVar8 = (uint *)(iVar2 + *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8 + 4) * 8 +
		                                 0xc0);
		                goto code_r0x80f6615f;
		              }
		              uVar1 = uVar1 + 1;
		            } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		          }
		          puVar8 = (uint *)func_ii_1080(piVar6,
		                                        System_Collections_Generic_ICollection_ArtifactData__TypeInfo
		                                        ,0);
		code_r0x80f6615f:
		          uVar7 = (**(code **)((ulonglong)*puVar8 * 4))(piVar6,puVar8[1]);
		          UI_Filters_FiltersView__AchievedToggleOnChangedEvent(uVar3,uVar7,param3,0);
		          return;
		        }
		        uVar3 = import::env::__cxa_find_matching_catch_2();
		      }
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001b87 + 0x22b,&local_24);
		      goto joined_r0x80f661b1;
		    }
		    uVar3 = import::env::__cxa_find_matching_catch_2();
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001b87 + 0x22a,&local_24);
		joined_r0x80f661b1:
		  if (DAT_ram_009d3e38 != 1) {
		    DAT_ram_009d3e38 = 0;
		    import::env::__resumeException(uVar3);
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

		// Token: 0x06005089 RID: 20617 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005089")]
		[Address(RVA = "0x9E98", Offset = "0x9E98", VA = "0x9E98")]
		private void RenderPossibleArtifacts()
		{
		/* --- GHIDRA: RenderPossibleArtifacts ---
		/* WARNING: Removing unreachable block (ram,0x80f6776a) */
		
		int Gameplay_ArtifactComparer_Controller_ArtifactComparerWindowMediator__RenderPossibleArtifacts
		              (int param1,int *param2,undefined4 param3)
		
		{
		  uint uVar1;
		  uint uVar2;
		  int iVar3;
		  int iVar4;
		  uint *puVar5;
		  undefined4 *puVar6;
		  undefined4 uVar7;
		  int iVar8;
		  int iVar9;
		  int *piVar10;
		  int *piVar11;
		  int iVar12;
		  int local_30;
		  undefined8 *puStack_2c;
		  undefined8 local_28;
		  int local_20;
		  int **local_1c;
		  undefined8 local_18;
		  undefined8 local_10;
		  int *local_4;
		  
		  if (DAT_ram_00a58a46 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_FilterInfo_FilterType__IArtifactFilter__get_Values__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_ValueCollection_Enumerator_FilterInfo_FilterType__IArtifactFilter__Dispose__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_ValueCollection_Enumerator_FilterInfo_FilterType__IArtifactFilter__MoveNext__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_ValueCollection_Enumerator_FilterInfo_FilterType__IArtifactFilter__get_Current__
		              );
		    Mono_Security_ASN1__get_Item(&Gameplay_Inventory_Controller_Filters_IArtifactFilter_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_IDisposable_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_IEnumerable_ArtifactData__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_IEnumerator_ArtifactData__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_IEnumerator_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_ArtifactData__Add__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_ArtifactData___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_List_ArtifactData__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_ValueCollection_FilterInfo_FilterType__IArtifactFilter__GetEnumerator__
		              );
		    DAT_ram_00a58a46 = '\x01';
		  }
		  local_4 = (int *)0x0;
		  local_10 = 0;
		  local_18 = 0;
		  iVar4 = unnamed_function_1417(System_Collections_Generic_List_ArtifactData__TypeInfo);
		  GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		            (iVar4,Method_System_Collections_Generic_List_ArtifactData___ctor__);
		  iVar12 = *param2;
		  if (*(ushort *)(iVar12 + 0xb6) != 0) {
		    uVar2 = 0;
		    do {
		      if (System_Collections_Generic_IEnumerable_ArtifactData__TypeInfo ==
		          *(int *)(*(int *)(iVar12 + 0x58) + uVar2 * 8)) {
		        puVar5 = (uint *)(iVar12 + *(int *)(*(int *)(iVar12 + 0x58) + uVar2 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x80f672ef;
		      }
		      uVar2 = uVar2 + 1;
		    } while (*(ushort *)(iVar12 + 0xb6) != uVar2);
		  }
		  puVar5 = (uint *)func_ii_1080(param2,System_Collections_Generic_IEnumerable_ArtifactData__TypeInfo
		                                ,0);
		code_r0x80f672ef:
		  local_4 = (int *)(**(code **)((ulonglong)*puVar5 * 4))(param2,puVar5[1]);
		  local_20 = 0;
		  local_1c = &local_4;
		code_r0x80f67314:
		  do {
		    do {
		      do {
		        piVar10 = local_4;
		        iVar12 = *local_4;
		        if (*(ushort *)(iVar12 + 0xb6) != 0) {
		          uVar2 = 0;
		          do {
		            piVar11 = (int *)(*(int *)(iVar12 + 0x58) + uVar2 * 8);
		            if (System_Collections_IEnumerator_TypeInfo == *piVar11) {
		              puVar6 = (undefined4 *)(iVar12 + piVar11[1] * 8 + 0xc0);
		              goto code_r0x80f673be;
		            }
		            uVar2 = uVar2 + 1;
		          } while (*(ushort *)(iVar12 + 0xb6) != uVar2);
		        }
		        DAT_ram_009d3e38 = 0;
		        puVar6 = (undefined4 *)
		                 import::env::invoke_iiii
		                           (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                            System_Collections_IEnumerator_TypeInfo,0);
		        if (DAT_ram_009d3e38 == 1) {
		code_r0x80f67402:
		          DAT_ram_009d3e38 = 0;
		          uVar7 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          iVar12 = global_1;
		          goto code_r0x80f6789a;
		        }
		code_r0x80f673be:
		        DAT_ram_009d3e38 = 0;
		        iVar12 = import::env::invoke_iii(*puVar6,piVar10,puVar6[1]);
		        piVar10 = local_4;
		        if (DAT_ram_009d3e38 == 1) goto code_r0x80f67402;
		        if (iVar12 == 0) goto code_r0x80f678e1;
		        iVar12 = *local_4;
		        if (*(ushort *)(iVar12 + 0xb6) != 0) {
		          uVar2 = 0;
		          do {
		            piVar11 = (int *)(*(int *)(iVar12 + 0x58) + uVar2 * 8);
		            if (System_Collections_Generic_IEnumerator_ArtifactData__TypeInfo == *piVar11) {
		              puVar6 = (undefined4 *)(iVar12 + piVar11[1] * 8 + 0xc0);
		              goto code_r0x80f674a9;
		            }
		            uVar2 = uVar2 + 1;
		          } while (*(ushort *)(iVar12 + 0xb6) != uVar2);
		        }
		        DAT_ram_009d3e38 = 0;
		        puVar6 = (undefined4 *)
		                 import::env::invoke_iiii
		                           (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                            System_Collections_Generic_IEnumerator_ArtifactData__TypeInfo,0);
		        if (DAT_ram_009d3e38 == 1) {
		code_r0x80f674ed:
		          DAT_ram_009d3e38 = 0;
		          uVar7 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          iVar12 = global_1;
		          goto code_r0x80f6789a;
		        }
		code_r0x80f674a9:
		        DAT_ram_009d3e38 = 0;
		        iVar9 = import::env::invoke_iii(*puVar6,piVar10,puVar6[1]);
		        if (DAT_ram_009d3e38 == 1) goto code_r0x80f674ed;
		      } while (iVar9 == 0);
		      DAT_ram_009d3e38 = 0;
		      uVar7 = import::env::invoke_iii
		                        (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x9f,
		                         *(undefined4 *)(param1 + 0x18),
		                         Method_System_Collections_Generic_Dictionary_FilterInfo_FilterType__IArtifactFilter__get_Values__
		                        );
		      iVar12 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar12 == 1) {
		        uVar7 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        iVar12 = global_1;
		        goto code_r0x80f6789a;
		      }
		      DAT_ram_009d3e38 = 0;
		      System_Collections_Generic_Dictionary_Int32Enum__object___get_Values
		                (&local_30,uVar7,
		                 Method_System_Collections_Generic_Dictionary_ValueCollection_FilterInfo_FilterType__IArtifactFilter__GetEnumerator__
		                );
		      iVar12 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar12 == 1) {
		        uVar7 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        iVar12 = global_1;
		        goto code_r0x80f6789a;
		      }
		      local_10 = local_28;
		      local_18 = CONCAT44(puStack_2c,local_30);
		      local_30 = 0;
		      puStack_2c = &local_18;
		      do {
		        DAT_ram_009d3e38 = 0;
		        uVar2 = import::env::invoke_iii
		                          (s_struct_Uniforms___color__array<v_ram_00001b87 + 0xa1,&local_18,
		                           Method_System_Collections_Generic_Dictionary_ValueCollection_Enumerator_FilterInfo_FilterType__IArtifactFilter__MoveNext__
		                          );
		        if (DAT_ram_009d3e38 == 1) {
		code_r0x80f676e2:
		          DAT_ram_009d3e38 = 0;
		          uVar7 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          iVar12 = global_1;
		          iVar8 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		          if (iVar12 == iVar8) {
		            piVar10 = (int *)import::env::__cxa_begin_catch(uVar7);
		            iVar8 = *piVar10;
		            iVar3 = 0;
		            DAT_ram_009d3e38 = 0;
		            local_30 = iVar8;
		            import::env::invoke_v(0x123);
		            iVar12 = DAT_ram_009d3e38;
		            DAT_ram_009d3e38 = 0;
		            uVar2 = 1;
		            if (iVar12 != 1) goto code_r0x80f6773c;
		            uVar7 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		            iVar12 = global_1;
		          }
		          DAT_ram_009d3e38 = 0;
		          import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001b87 + 0x22f,&local_30);
		          iVar9 = DAT_ram_009d3e38;
		          DAT_ram_009d3e38 = 0;
		          if (iVar9 != 1) goto code_r0x80f6789a;
		          goto code_r0x80f679b4;
		        }
		        if (uVar2 == 0) break;
		        piVar10 = local_10._4_4_;
		        iVar12 = *local_10._4_4_;
		        if (*(ushort *)(iVar12 + 0xb6) != 0) {
		          uVar1 = 0;
		          do {
		            piVar11 = (int *)(*(int *)(iVar12 + 0x58) + uVar1 * 8);
		            if (Gameplay_Inventory_Controller_Filters_IArtifactFilter_TypeInfo == *piVar11) {
		              puVar6 = (undefined4 *)(piVar11[1] * 8 + iVar12 + 0xd0);
		              goto code_r0x80f6768b;
		            }
		            uVar1 = uVar1 + 1;
		          } while (*(ushort *)(iVar12 + 0xb6) != uVar1);
		        }
		        DAT_ram_009d3e38 = 0;
		        puVar6 = (undefined4 *)
		                 import::env::invoke_iiii
		                           (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_10._4_4_,
		                            Gameplay_Inventory_Controller_Filters_IArtifactFilter_TypeInfo,2);
		        if (DAT_ram_009d3e38 == 1) goto code_r0x80f676e2;
		code_r0x80f6768b:
		        DAT_ram_009d3e38 = 0;
		        iVar12 = import::env::invoke_iiii(*puVar6,piVar10,iVar9,puVar6[1]);
		        if (DAT_ram_009d3e38 == 1) goto code_r0x80f676e2;
		      } while (iVar12 != 0);
		      uVar2 = uVar2 ^ 1;
		      iVar3 = 6;
		      iVar8 = 0;
		code_r0x80f6773c:
		      iVar12 = Method_System_Collections_Generic_List_ArtifactData__Add__;
		      if (iVar8 != 0) {
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_vi(s_var<private>_posTex__array<vec4<_ram_00000655 + 0x1d3,iVar8);
		        iVar12 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar12 != 1) {
		          do {
		            halt_trap();
		          } while( true );
		        }
		        uVar7 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        iVar12 = global_1;
		        goto code_r0x80f6789a;
		      }
		      if ((iVar3 != 0) &&
		         ((((iVar3 == 1 || (iVar3 == 2)) || (iVar3 == 3)) ||
		          (((iVar3 == 4 || (iVar3 == 5)) || (iVar3 != 6)))))) goto code_r0x80f678e1;
		    } while (uVar2 == 0);
		    *(int *)(iVar4 + 0x10) = *(int *)(iVar4 + 0x10) + 1;
		    uVar2 = *(uint *)(iVar4 + 0xc);
		    if (uVar2 < *(uint *)(*(int *)(iVar4 + 8) + 0xc)) {
		      *(uint *)(iVar4 + 0xc) = uVar2 + 1;
		      *(int *)(*(int *)(iVar4 + 8) + uVar2 * 4 + 0x10) = iVar9;
		      goto code_r0x80f67314;
		    }
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_viii
		              (s_struct_Uniforms___color__array<v_ram_00000aff + 0x6e,iVar4,iVar9,
		               *(undefined4 *)(*(int *)(*(int *)(iVar12 + 0x10) + 0x60) + 0x38));
		    iVar12 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		  } while (iVar12 != 1);
		  uVar7 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		  iVar12 = global_1;
		code_r0x80f6789a:
		  iVar9 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar9 == iVar12) {
		    piVar10 = (int *)import::env::__cxa_begin_catch(uVar7);
		    local_20 = *piVar10;
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_v(0x123);
		    iVar12 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar12 != 1) {
		code_r0x80f678e1:
		      DAT_ram_009d3e38 = 0;
		      piVar10 = *local_1c;
		      if (piVar10 != (int *)0x0) {
		        uVar2 = 0;
		        iVar12 = *piVar10;
		        if (*(ushort *)(iVar12 + 0xb6) != 0) {
		          do {
		            if (System_IDisposable_TypeInfo == *(int *)(*(int *)(iVar12 + 0x58) + uVar2 * 8)) {
		              puVar5 = (uint *)(iVar12 + *(int *)(*(int *)(iVar12 + 0x58) + uVar2 * 8 + 4) * 8 +
		                               0xc0);
		              goto code_r0x80f6795c;
		            }
		            uVar2 = uVar2 + 1;
		          } while (*(ushort *)(iVar12 + 0xb6) != uVar2);
		        }
		        puVar5 = (uint *)func_ii_1080(piVar10,System_IDisposable_TypeInfo,0);
		code_r0x80f6795c:
		        (**(code **)((ulonglong)*puVar5 * 4))(piVar10,puVar5[1]);
		      }
		      if (local_20 != 0) {
		        System_Data_DataSet__ValidateLocaleConstraint(local_20);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      return iVar4;
		    }
		    uVar7 = import::env::__cxa_find_matching_catch_2();
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001b87 + 0x230,&local_20);
		  iVar4 = DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = 0;
		  if (iVar4 != 1) {
		    import::env::__resumeException(uVar7);
		    do {
		      halt_trap();
		    } while( true );
		  }
		code_r0x80f679b4:
		  DAT_ram_009d3e38 = 0;
		  import::env::__cxa_find_matching_catch_3(0);
		  unnamed_function_937();
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x0600508A RID: 20618 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600508A")]
		[Address(RVA = "0x9E99", Offset = "0x9E99", VA = "0x9E99")]
		private IList<ArtifactData> FilterArtifacts(IList<ArtifactData> rawData)
		{
		/* --- GHIDRA: FilterArtifacts ---
		void Gameplay_ArtifactComparer_Controller_ArtifactComparerWindowMediator__FilterArtifacts
		               (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 param1_00;
		  int iVar2;
		  
		  if (DAT_ram_00a58a47 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_ArtifactComparerModel__ArtifactComparerEvents__ArtifactComparerController__ArtifactComparerWindow__get_Model__
		              );
		    DAT_ram_00a58a47 = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar2 = **(int **)(iVar1 + 0x40);
		  (**(code **)((ulonglong)*(uint *)(iVar2 + 0x138) * 4))
		            (*(int **)(iVar1 + 0x40),*(undefined4 *)(param1[2] + 0x18),
		             *(undefined4 *)(iVar2 + 0x13c));
		  Gameplay_ArtifactComparer_Controller_ArtifactComparerWindowMediator__RenderCurrentComparison
		            (param1,param1);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar2 = param1[2];
		  Gameplay_ArtifactComparer_View_ArtifactComparerPossibleArtifactView___ctor
		            (*(undefined4 *)(iVar1 + 0x48),*(undefined4 *)(iVar2 + 0x14),
		             *(undefined4 *)(iVar2 + 0x18),(uint)*(byte *)(iVar2 + 0xc),param1);
		  param1_00 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x15c));
		  Gameplay_ArtifactComparer_View_ArtifactComparerWindow__ViewOnClickEvent
		            (param1_00,*(undefined4 *)(param1[2] + 0x18),param1);
		  return;
		}
		*/

			return null;
		}

		// Token: 0x0600508B RID: 20619 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600508B")]
		[Address(RVA = "0x9E9A", Offset = "0x9E9A", VA = "0x9E9A")]
		private void RenderCurrentComparison()
		{
		/* --- GHIDRA: RenderCurrentComparison ---
		void Gameplay_ArtifactComparer_Controller_ArtifactComparerWindowMediator__RenderCurrentComparison
		               (int *param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  undefined4 uVar2;
		  int param1_00;
		  int iVar3;
		  undefined4 uVar4;
		  undefined4 uVar5;
		  int iVar6;
		  undefined1 auStack_10 [4];
		  undefined4 local_c;
		  undefined4 local_8;
		  undefined4 local_4;
		  
		  iVar3 = 0;
		  if (DAT_ram_00a58a48 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_ArtifactComparerModel__ArtifactComparerEvents__ArtifactComparerController__ArtifactComparerWindow__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&Gameplay_Inventory_Model_ArtifactInfoProvider_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_FirstOrDefault_IInformationRow___);
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_ArtifactComparerRowData___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_List_ArtifactComparerRowData__TypeInfo)
		    ;
		    Mono_Security_ASN1__get_Item(&StringLiteral_2634);
		    Mono_Security_ASN1__get_Item(&StringLiteral_2636);
		    Mono_Security_ASN1__get_Item(&StringLiteral_2628);
		    DAT_ram_00a58a48 = '\x01';
		  }
		  local_4 = 0;
		  local_8 = 0;
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x14c));
		  Gameplay_ArtifactComparer_Controller_ArtifactComparerController__HandleStop
		            (uVar1,&local_4,&local_8,auStack_10);
		  uVar1 = unnamed_function_1417(System_Collections_Generic_List_ArtifactComparerRowData__TypeInfo);
		  GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		            (uVar1,Method_System_Collections_Generic_List_ArtifactComparerRowData___ctor__);
		  uVar4 = *(undefined4 *)(param1[2] + 0x14);
		  uVar5 = *(undefined4 *)(param1[2] + 8);
		  local_c = uVar1;
		  uVar2 = unnamed_function_1417(Gameplay_Inventory_Model_ArtifactInfoProvider_TypeInfo);
		  Gameplay_Inventory_Model_ArtifactInfoProvider__Dispose(uVar2,uVar5,uVar5,uVar4,0);
		  iVar6 = *(int *)(param1[2] + 0x18);
		  if (iVar6 != 0) {
		    uVar4 = *(undefined4 *)(param1[2] + 8);
		    iVar3 = unnamed_function_1417(Gameplay_Inventory_Model_ArtifactInfoProvider_TypeInfo);
		    Gameplay_Inventory_Model_ArtifactInfoProvider__Dispose(iVar3,uVar4,uVar4,iVar6,0);
		  }
		  iVar6 = 0;
		  if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_GameLocalization_TypeInfo);
		  }
		  uVar4 = func_ii_7508(StringLiteral_2628,1,0,1,0,0,0,0);
		  Gameplay_ArtifactComparer_Controller_ArtifactComparerWindowMediator__AddSkills
		            (param1,&local_c,uVar4,auStack_10);
		  uVar4 = Gameplay_Inventory_Model_ArtifactInfoProvider__HandleCollectionRow(uVar2,0);
		  if (iVar3 == 0) {
		    uVar5 = 0;
		  }
		  else {
		    uVar5 = Gameplay_Inventory_Model_ArtifactInfoProvider__HandleCollectionRow(iVar3,0);
		  }
		  Gameplay_ArtifactComparer_Controller_ArtifactComparerWindowMediator__AddRow
		            (param1,&local_c,2,uVar4,uVar5,auStack_10);
		  uVar4 = Gameplay_Inventory_Model_ArtifactInfoProvider__GetArtifactProps(uVar2,0);
		  if (iVar3 == 0) {
		    uVar5 = 0;
		  }
		  else {
		    uVar5 = Gameplay_Inventory_Model_ArtifactInfoProvider__GetArtifactProps(iVar3,0);
		  }
		  Gameplay_ArtifactComparer_Controller_ArtifactComparerWindowMediator__AddTitle
		            (auStack_10,&local_c,2,uVar4,uVar5,auStack_10);
		  uVar4 = Gameplay_Inventory_Model_ArtifactInfoProvider__GetArtifactRepairableRow(uVar2,0);
		  if (iVar3 == 0) {
		    uVar5 = 0;
		  }
		  else {
		    uVar5 = Gameplay_Inventory_Model_ArtifactInfoProvider__GetArtifactRepairableRow(iVar3,0);
		  }
		  Gameplay_ArtifactComparer_Controller_ArtifactComparerWindowMediator__AddTitle
		            (auStack_10,&local_c,2,uVar4,uVar5,auStack_10);
		  uVar4 = Gameplay_Inventory_Model_ArtifactInfoProvider__GetArtifactDurabilityRow(uVar2,0);
		  if (iVar3 == 0) {
		    uVar5 = 0;
		  }
		  else {
		    uVar5 = Gameplay_Inventory_Model_ArtifactInfoProvider__GetArtifactDurabilityRow(iVar3,0);
		  }
		  Gameplay_ArtifactComparer_Controller_ArtifactComparerWindowMediator__AddTitle
		            (auStack_10,&local_c,2,uVar4,uVar5,auStack_10);
		  uVar4 = Gameplay_Inventory_Model_ArtifactInfoProvider__GetArtifactLevelRow(uVar2,0);
		  if (iVar3 == 0) {
		    uVar5 = 0;
		  }
		  else {
		    uVar5 = Gameplay_Inventory_Model_ArtifactInfoProvider__GetArtifactLevelRow(iVar3,0);
		  }
		  Gameplay_ArtifactComparer_Controller_ArtifactComparerWindowMediator__AddTitle
		            (auStack_10,&local_c,2,uVar4,uVar5,auStack_10);
		  uVar4 = Gameplay_Inventory_Model_ArtifactInfoProvider__GetArtifactSellableRow(uVar2,0);
		  if (iVar3 == 0) {
		    uVar5 = 0;
		  }
		  else {
		    uVar5 = Gameplay_Inventory_Model_ArtifactInfoProvider__GetArtifactSellableRow(iVar3,0);
		  }
		  Gameplay_ArtifactComparer_Controller_ArtifactComparerWindowMediator__AddTitle
		            (auStack_10,&local_c,2,uVar4,uVar5,auStack_10);
		  uVar4 = Gameplay_Inventory_Model_ArtifactInfoProvider__GetArtifactPriceRow(uVar2,0);
		  if (iVar3 == 0) {
		    uVar5 = 0;
		  }
		  else {
		    uVar5 = Gameplay_Inventory_Model_ArtifactInfoProvider__GetArtifactPriceRow(iVar3,0);
		  }
		  Gameplay_ArtifactComparer_Controller_ArtifactComparerWindowMediator__AddTitle
		            (auStack_10,&local_c,3,uVar4,uVar5,auStack_10);
		  if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_GameLocalization_TypeInfo);
		  }
		  uVar4 = func_ii_7508(StringLiteral_2634,1,0,1,0,0,0,0);
		  Gameplay_ArtifactComparer_Controller_ArtifactComparerWindowMediator__AddSkills
		            (param1,&local_c,uVar4,auStack_10);
		  Gameplay_ArtifactComparer_Controller_ArtifactComparerWindowMediator__RenderTable
		            (auStack_10,&local_c,local_4,local_8,auStack_10);
		  param1_00 = Gameplay_Inventory_Model_ArtifactInfoProvider__GetUserSkillsMods(uVar2,0);
		  if (iVar3 != 0) {
		    iVar6 = Gameplay_Inventory_Model_ArtifactInfoProvider__GetUserSkillsMods(iVar3,0);
		  }
		  if (param1_00 != 0 || iVar6 != 0) {
		    if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_GameLocalization_TypeInfo);
		    }
		    uVar2 = func_ii_7508(StringLiteral_2636,1,0,1,0,0,0,0);
		    Gameplay_ArtifactComparer_Controller_ArtifactComparerWindowMediator__AddSkills
		              (param1,&local_c,uVar2,auStack_10);
		    if (param1_00 == 0) {
		      uVar2 = 0;
		    }
		    else {
		      uVar2 = UnityEngine_Purchasing_Utils_ProductDetailsConverter__BuildProductDescription
		                        (param1_00,Method_System_Linq_Enumerable_FirstOrDefault_IInformationRow___);
		    }
		    if (iVar6 == 0) {
		      uVar4 = 0;
		    }
		    else {
		      uVar4 = UnityEngine_Purchasing_Utils_ProductDetailsConverter__BuildProductDescription
		                        (iVar6,Method_System_Linq_Enumerable_FirstOrDefault_IInformationRow___);
		    }
		    Gameplay_ArtifactComparer_Controller_ArtifactComparerWindowMediator__AddTitle
		              (auStack_10,&local_c,5,uVar2,uVar4,auStack_10);
		  }
		  iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  Gameplay_ArtifactComparer_View_ArtifactComparerTable__get_Data
		            (*(undefined4 *)(iVar3 + 0x44),uVar1,auStack_10);
		  return;
		}
		*/

		}

		// Token: 0x0600508C RID: 20620 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600508C")]
		[Address(RVA = "0x9E9B", Offset = "0x9E9B", VA = "0x9E9B")]
		private void RenderTable()
		{
		/* --- GHIDRA: RenderTable ---
		void Gameplay_ArtifactComparer_Controller_ArtifactComparerWindowMediator__RenderTable
		               (undefined4 param1,undefined4 param2,int param3,int param4,undefined4 param5)
		
		{
		  uint uVar1;
		  int param1_00;
		  int param1_01;
		  uint *puVar2;
		  undefined4 uVar3;
		  int param1_02;
		  undefined4 uVar4;
		  int *param1_03;
		  int iVar5;
		  int param2_00;
		  int *piVar6;
		  
		  param2_00 = 0;
		  if (DAT_ram_00a58a49 == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_ArtifactComparer_Model_ComparerValueRow_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_ComparedSkillData__get_Count__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_ComparedSkillData__get_Item__);
		    DAT_ram_00a58a49 = '\x01';
		  }
		  if (0 < *(int *)(param3 + 0xc)) {
		    do {
		      param1_01 = System_Linq_Enumerable__ToList_object_
		                            (param3,param2_00,
		                             Method_System_Collections_Generic_List_ComparedSkillData__get_Item__);
		      param1_00 = 0;
		      if (param4 != 0) {
		        param1_00 = System_Linq_Enumerable__ToList_object_
		                              (param4,param2_00,
		                               Method_System_Collections_Generic_List_ComparedSkillData__get_Item__)
		        ;
		      }
		      if (DAT_ram_00a6456f == '\0') {
		        Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		        DAT_ram_00a6456f = '\x01';
		      }
		      param1_03 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		      iVar5 = *param1_03;
		      if (*(ushort *)(iVar5 + 0xb6) != 0) {
		        uVar1 = 0;
		        do {
		          piVar6 = (int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8);
		          if (Core_Gameplay_IGame_TypeInfo == *piVar6) {
		            puVar2 = (uint *)(piVar6[1] * 8 + iVar5 + 0x178);
		            goto code_r0x80f68265;
		          }
		          uVar1 = uVar1 + 1;
		        } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		      }
		      puVar2 = (uint *)func_ii_1080(param1_03,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x80f68265:
		      iVar5 = 0;
		      uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(param1_03,puVar2[1]);
		      uVar3 = Newtonsoft_Json_Converters_XmlDocumentTypeWrapper__get_System(uVar3,0);
		      uVar3 = System_Collections_Generic_Dictionary_int__object___get_Item
		                        (uVar3,*(undefined4 *)(param1_01 + 8),0);
		      param1_02 = unnamed_function_1417(Gameplay_ArtifactComparer_Model_ComparerValueRow_TypeInfo);
		      System_Collections_Generic_List_object____ctor(param1_02,0);
		      *(int *)(param1_02 + 0x38) = param1_01;
		      uVar4 = func_ii_7990(uVar3,0);
		      *(undefined4 *)(param1_02 + 0xc) = uVar4;
		      uVar4 = Assets_Scripts_Core_Extensions_Dict_DollSkillDicExt__GetIconAssetId(param1_01,0);
		      *(undefined4 *)(param1_02 + 0x18) = uVar4;
		      uVar4 = Core_Extensions_Dict_UserSkillDicExt__GetTitle(uVar3,0);
		      *(undefined4 *)(param1_02 + 0x14) = uVar4;
		      if (param1_00 != 0) {
		        iVar5 = unnamed_function_1417(Gameplay_ArtifactComparer_Model_ComparerValueRow_TypeInfo);
		        System_Collections_Generic_List_object____ctor(iVar5,0);
		        *(int *)(iVar5 + 0x38) = param1_00;
		        uVar4 = func_ii_7990(uVar3,0);
		        *(undefined4 *)(iVar5 + 0xc) = uVar4;
		        uVar4 = Assets_Scripts_Core_Extensions_Dict_DollSkillDicExt__GetIconAssetId(param1_00,0);
		        *(undefined4 *)(iVar5 + 0x18) = uVar4;
		        uVar3 = Core_Extensions_Dict_UserSkillDicExt__GetTitle(uVar3,0);
		        *(undefined4 *)(iVar5 + 0x14) = uVar3;
		      }
		      Gameplay_ArtifactComparer_Controller_ArtifactComparerWindowMediator__AddTitle
		                (param1_02,param2,4,param1_02,iVar5,param1_02);
		      param2_00 = param2_00 + 1;
		    } while (param2_00 < *(int *)(param3 + 0xc));
		  }
		  return;
		}
		*/

		}

		// Token: 0x0600508D RID: 20621 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600508D")]
		[Address(RVA = "0x9E9C", Offset = "0x9E9C", VA = "0x9E9C")]
		private void AddSkills(in List<ArtifactComparerRowData> list, List<ComparedSkillData> skills1, List<ComparedSkillData> skills2)
		{
		/* --- GHIDRA: AddSkills ---
		void Gameplay_ArtifactComparer_Controller_ArtifactComparerWindowMediator__AddSkills
		               (int param1,int *param2,undefined4 param3,undefined4 param4)
		
		{
		  int param2_00;
		  int iVar1;
		  int param1_00;
		  uint uVar2;
		  int iVar3;
		  undefined4 uVar4;
		  
		  if (DAT_ram_00a58a4a == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_ArtifactComparerModel__ArtifactComparerEvents__ArtifactComparerController__ArtifactComparerWindow__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&Gameplay_ArtifactComparer_Model_ArtifactComparerRowData_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Data_InfoRows_CommonRow_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_ArtifactComparerRowData__Add__);
		    DAT_ram_00a58a4a = '\x01';
		  }
		  param1_00 = *param2;
		  param2_00 = unnamed_function_1417
		                        (Gameplay_ArtifactComparer_Model_ArtifactComparerRowData_TypeInfo);
		  *(undefined4 *)(param2_00 + 8) = 1;
		  iVar1 = unnamed_function_1417(Core_Data_InfoRows_CommonRow_TypeInfo);
		  *(undefined4 *)(iVar1 + 0xc) = param3;
		  *(int *)(param2_00 + 0xc) = iVar1;
		  iVar1 = unnamed_function_1417(Core_Data_InfoRows_CommonRow_TypeInfo);
		  iVar3 = *(int *)(*(int *)(param1 + 8) + 0x14);
		  if (iVar3 == 0) {
		    uVar4 = 0;
		  }
		  else {
		    uVar4 = Core_Data_ArtikulData__get_IsSellable(iVar3,0);
		  }
		  *(undefined4 *)(iVar1 + 0xc) = uVar4;
		  *(int *)(param2_00 + 0x10) = iVar1;
		  iVar1 = unnamed_function_1417(Core_Data_InfoRows_CommonRow_TypeInfo);
		  iVar3 = *(int *)(*(int *)(param1 + 8) + 0x18);
		  if (iVar3 == 0) {
		    uVar4 = 0;
		  }
		  else {
		    uVar4 = Core_Data_ArtikulData__get_IsSellable(iVar3,0);
		  }
		  *(undefined4 *)(iVar1 + 0xc) = uVar4;
		  *(int *)(param2_00 + 0x14) = iVar1;
		  iVar1 = Method_System_Collections_Generic_List_ArtifactComparerRowData__Add__;
		  *(int *)(param1_00 + 0x10) = *(int *)(param1_00 + 0x10) + 1;
		  uVar2 = *(uint *)(param1_00 + 0xc);
		  if (uVar2 < *(uint *)(*(int *)(param1_00 + 8) + 0xc)) {
		    *(uint *)(param1_00 + 0xc) = uVar2 + 1;
		    *(int *)(*(int *)(param1_00 + 8) + uVar2 * 4 + 0x10) = param2_00;
		    return;
		  }
		  System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		            (param1_00,param2_00,*(undefined4 *)(*(int *)(*(int *)(iVar1 + 0x10) + 0x60) + 0x38));
		  return;
		}
		*/

		}

		// Token: 0x0600508E RID: 20622 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600508E")]
		[Address(RVA = "0x9E9D", Offset = "0x9E9D", VA = "0x9E9D")]
		private void AddTitle(in List<ArtifactComparerRowData> list, string title)
		{
		/* --- GHIDRA: AddTitle ---
		void Gameplay_ArtifactComparer_Controller_ArtifactComparerWindowMediator__AddTitle
		               (undefined4 param1,int *param2,undefined4 param3,int param4,int param5,
		               undefined4 param6)
		
		{
		  int iVar1;
		  int param2_00;
		  int param1_00;
		  uint uVar2;
		  
		  if (DAT_ram_00a58a4b == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_ArtifactComparer_Model_ArtifactComparerRowData_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_ArtifactComparerRowData__Add__);
		    DAT_ram_00a58a4b = '\x01';
		  }
		  iVar1 = param4;
		  if ((param4 != 0) || (iVar1 = param5, param5 != 0)) {
		    param1_00 = *param2;
		    param2_00 = unnamed_function_1417
		                          (Gameplay_ArtifactComparer_Model_ArtifactComparerRowData_TypeInfo);
		    *(int *)(param2_00 + 0x14) = param5;
		    *(int *)(param2_00 + 0x10) = param4;
		    *(int *)(param2_00 + 0xc) = iVar1;
		    *(undefined4 *)(param2_00 + 8) = param3;
		    iVar1 = Method_System_Collections_Generic_List_ArtifactComparerRowData__Add__;
		    *(int *)(param1_00 + 0x10) = *(int *)(param1_00 + 0x10) + 1;
		    uVar2 = *(uint *)(param1_00 + 0xc);
		    if (uVar2 < *(uint *)(*(int *)(param1_00 + 8) + 0xc)) {
		      *(uint *)(param1_00 + 0xc) = uVar2 + 1;
		      *(int *)(*(int *)(param1_00 + 8) + uVar2 * 4 + 0x10) = param2_00;
		      return;
		    }
		    System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		              (param1_00,param2_00,*(undefined4 *)(*(int *)(*(int *)(iVar1 + 0x10) + 0x60) + 0x38));
		  }
		  return;
		}
		*/

		}

		// Token: 0x0600508F RID: 20623 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600508F")]
		[Address(RVA = "0x9E9E", Offset = "0x9E9E", VA = "0x9E9E")]
		private void AddRow(in List<ArtifactComparerRowData> list, ArtifactComparerRowData.RowType rowType, IInformationRow targetProp, IInformationRow comparableProp)
		{
		/* --- GHIDRA: AddRow ---
		void Gameplay_ArtifactComparer_Controller_ArtifactComparerWindowMediator__AddRow
		               (undefined4 param1,undefined4 param2,undefined4 param3,int param4,int param5,
		               undefined4 param6)
		
		{
		  int param2_00;
		  undefined4 uVar1;
		  undefined4 param5_00;
		  
		  if (DAT_ram_00a58a4c == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_IInformationRow__get_Count__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_IInformationRow__get_Item__);
		    DAT_ram_00a58a4c = '\x01';
		  }
		  if (0 < *(int *)(param4 + 0xc)) {
		    param2_00 = 0;
		    if (param5 == 0) {
		      do {
		        uVar1 = System_Linq_Enumerable__ToList_object_
		                          (param4,param2_00,
		                           Method_System_Collections_Generic_List_IInformationRow__get_Item__);
		        Gameplay_ArtifactComparer_Controller_ArtifactComparerWindowMediator__AddTitle
		                  (param2_00,param2,param3,uVar1,0,param2_00);
		        param2_00 = param2_00 + 1;
		      } while (param2_00 < *(int *)(param4 + 0xc));
		    }
		    else {
		      do {
		        uVar1 = System_Linq_Enumerable__ToList_object_
		                          (param4,param2_00,
		                           Method_System_Collections_Generic_List_IInformationRow__get_Item__);
		        param5_00 = System_Linq_Enumerable__ToList_object_
		                              (param5,param2_00,
		                               Method_System_Collections_Generic_List_IInformationRow__get_Item__);
		        Gameplay_ArtifactComparer_Controller_ArtifactComparerWindowMediator__AddTitle
		                  (param2_00,param2,param3,uVar1,param5_00,param2_00);
		        param2_00 = param2_00 + 1;
		      } while (param2_00 < *(int *)(param4 + 0xc));
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x06005090 RID: 20624 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005090")]
		[Address(RVA = "0x9E9F", Offset = "0x9E9F", VA = "0x9E9F")]
		private void AddRows(in List<ArtifactComparerRowData> result, ArtifactComparerRowData.RowType rowType, List<IInformationRow> targetProps, List<IInformationRow> comparableProps)
		{
		/* --- GHIDRA: AddRows ---
		void Gameplay_ArtifactComparer_Controller_ArtifactComparerWindowMediator__AddRows(undefined4 param1)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a58ca7 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_ArtifactComparer_Controller_ArtifactComparerWindowMediator___c_TypeInfo);
		    DAT_ram_00a58ca7 = '\x01';
		  }
		  uVar1 = unnamed_function_1417
		                    (
		                    Gameplay_ArtifactComparer_Controller_ArtifactComparerWindowMediator___c_TypeInfo
		                    );
		  **(undefined4 **)
		    (Gameplay_ArtifactComparer_Controller_ArtifactComparerWindowMediator___c_TypeInfo + 0x5c) =
		       uVar1;
		  return;
		}
		*/

		}

		// Token: 0x04002C05 RID: 11269
		[Token(Token = "0x4002C05")]
		[FieldOffset(Offset = "0x18")]
		private Dictionary<FilterInfo.FilterType, IArtifactFilter> _filters;

		// Token: 0x04002C06 RID: 11270
		[Token(Token = "0x4002C06")]
		[FieldOffset(Offset = "0x1C")]
		private readonly bool _sameArticulTypeOnly;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_View ---
		void Gameplay_ArtifactComparer_Controller_ArtifactComparerWindowMediator__set_View
		               (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  int iVar2;
		  int *piVar3;
		  undefined4 uVar4;
		  uint uVar5;
		  int local_18;
		  undefined8 *local_14;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a58a3e == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_ArtifactComparerModel__ArtifactComparerEvents__ArtifactComparerController__ArtifactComparerWindow__get_Model__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_SkillSelectorItemView__Dispose__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_SkillSelectorItemView__MoveNext__)
		    ;
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_Enumerator_SkillSelectorItemView__get_Current__
		              );
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_HashSet_int__Contains__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_SkillSelectorItemView__GetEnumerator__);
		    DAT_ram_00a58a3e = '\x01';
		  }
		  local_8 = 0;
		  local_10 = 0;
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  if (*(char *)(*(int *)(iVar1 + 0x58) + 0x28) == '\0') {
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    Gameplay_ArtifactComparer_View_SkillSelector_SkillSelectorView__Awake
		              (*(undefined4 *)(iVar1 + 0x58),*(undefined4 *)(param1[2] + 0x1c),param1);
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    System_Collections_Generic_List_RegexCharClass_SingleRange___ForEach
		              (&local_10,*(undefined4 *)(*(int *)(iVar1 + 0x58) + 0x30),
		               Method_System_Collections_Generic_List_SkillSelectorItemView__GetEnumerator__);
		    local_18 = 0;
		    local_14 = &local_10;
		    do {
		      DAT_ram_009d3e38 = 0;
		      iVar2 = import::env::invoke_iii
		                        (s_struct_Uniforms___color__array<v_ram_00000aff + 0x44,&local_10,
		                         Method_System_Collections_Generic_List_Enumerator_SkillSelectorItemView__MoveNext__
		                        );
		      iVar1 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar1 == 1) {
		        uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x80f66f6c;
		      }
		      if (iVar2 == 0) goto code_r0x80f66fc2;
		      iVar1 = local_8._4_4_;
		      DAT_ram_009d3e38 = 0;
		      uVar4 = import::env::invoke_iiii
		                        (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x220,
		                         *(undefined4 *)(param1[2] + 0x20),*(undefined4 *)(local_8._4_4_ + 0x20),
		                         Method_System_Collections_Generic_HashSet_int__Contains__);
		      if (DAT_ram_009d3e38 == 1) break;
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_viii
		                (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x22d,
		                 *(undefined4 *)(iVar1 + 0x10),uVar4,0);
		    } while (DAT_ram_009d3e38 != 1);
		    DAT_ram_009d3e38 = 0;
		    uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x80f66f6c:
		    iVar1 = global_1;
		    iVar2 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		    if (iVar1 == iVar2) {
		      piVar3 = (int *)import::env::__cxa_begin_catch(uVar4);
		      iVar2 = *piVar3;
		      DAT_ram_009d3e38 = 0;
		      local_18 = iVar2;
		      import::env::invoke_v(0x123);
		      iVar1 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar1 != 1) {
		        if (iVar2 != 0) {
		          System_Data_DataSet__ValidateLocaleConstraint(iVar2);
		          do {
		            halt_trap();
		          } while( true );
		        }
		        goto code_r0x80f66fc2;
		      }
		      uVar4 = import::env::__cxa_find_matching_catch_2();
		    }
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001b87 + 0x22e,&local_18);
		    iVar1 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar1 != 1) {
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
		code_r0x80f66fc2:
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar4 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (*(undefined4 *)(iVar1 + 0x58),0);
		  uVar5 = func_ii_7305(uVar4,0);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  if (uVar5 == 0) {
		    Gameplay_ArtifactComparer_View_SkillSelector_SkillSelectorView__OnDestroy
		              (*(undefined4 *)(iVar1 + 0x58),param1);
		  }
		  else {
		    Gameplay_ArtifactComparer_View_SkillSelector_SkillSelectorView__Show
		              (*(undefined4 *)(iVar1 + 0x58),param1);
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  UI_ToggleButton__get_Selected(*(undefined4 *)(iVar1 + 0x5c),uVar5 ^ 1,0);
		  return;
		}
		*/

}
