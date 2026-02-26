using System;
using Gameplay.Clans.Buildings.MagicTower.Events;
using Gameplay.Clans.Buildings.MagicTower.Model;
using Gameplay.Clans.Buildings.MagicTower.View;
using Gameplay.MageSchool.View;
using Gameplay.School.Model;
using Gameplay.School.View;
using Il2CppDummyDll;
using MVC;
using UI.Windows;

namespace Gameplay.Clans.Buildings.MagicTower.Controller
{
	// Token: 0x02000ABB RID: 2747
	[Token(Token = "0x2000ABB")]
	public class MagicTowerViewMediator : AbstractViewMediator<MagicTowerModel, MagicTowerEvents, MagicTowerController, MagicTowerWindow>
	{
		// Token: 0x0600424D RID: 16973 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600424D")]
		[Address(RVA = "0x9101", Offset = "0x9101", VA = "0x9101")]
		public MagicTowerViewMediator(MagicTowerModel model, MagicTowerEvents events, MagicTowerController controller)
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Clans_Buildings_MagicTower_Controller_MagicTowerViewMediator___ctor
		               (int *param1,int param2,undefined4 param3)
		
		{
		  bool bVar1;
		  int iVar2;
		  int iVar3;
		  undefined4 uVar4;
		  int iVar5;
		  int iVar6;
		  int *piVar7;
		  undefined4 uVar8;
		  
		  if (DAT_ram_00a57825 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_MagicTowerModel__MagicTowerEvents__MagicTowerController__MagicTowerWindow__set_View__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_SchoolSpellData__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Clans_Buildings_MagicTower_Controller_MagicTowerViewMediator_DeselectSpellEventHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Clans_Buildings_MagicTower_Controller_MagicTowerViewMediator_SelectSpellEventHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Clans_Buildings_MagicTower_Controller_MagicTowerViewMediator_UseSpellButtonClickedEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&UI_Elements_RightPanel_TitledList_TitledListWithCustomTitleArgs_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Elements_RightPanel_TitledList_TitledListWithCustomTitle_SpellTitle__Init__
		              );
		    DAT_ram_00a57825 = '\x01';
		  }
		  uVar4 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar5 = Cysharp_Threading_Tasks_CancellationTokenExtensions___cctor(uVar4,0);
		  if (iVar5 != 0) {
		    iVar5 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar4 = unnamed_function_1417(System_Action_SchoolSpellData__TypeInfo);
		    UnityEngine_UIElements_VisualElement__get_layout
		              (uVar4,param1,
		               Method_Gameplay_Clans_Buildings_MagicTower_Controller_MagicTowerViewMediator_SelectSpellEventHandler__
		               ,0);
		    if (DAT_ram_00a577ff == '\0') {
		      Mono_Security_ASN1__get_Item(&System_Action_SchoolSpellData__TypeInfo);
		      DAT_ram_00a577ff = '\x01';
		    }
		    iVar2 = *(int *)(iVar5 + 0x50);
		    do {
		      iVar3 = 0;
		      iVar6 = func_ii_7048(iVar2,uVar4,0);
		      uVar8 = System_Action_SchoolSpellData__TypeInfo;
		      if ((iVar6 != 0) &&
		         (iVar3 = func_ii_1082(iVar6,System_Action_SchoolSpellData__TypeInfo), iVar3 == 0)) {
		        System_Activator__CreateInstance(iVar6,uVar8);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      iVar3 = func_ii_4329(iVar5 + 0x50,iVar3,iVar2);
		      bVar1 = iVar3 != iVar2;
		      iVar2 = iVar3;
		    } while (bVar1);
		    iVar5 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar4 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar4,param1,
		               Method_Gameplay_Clans_Buildings_MagicTower_Controller_MagicTowerViewMediator_DeselectSpellEventHandler__
		               ,0);
		    if (DAT_ram_00a57801 == '\0') {
		      Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		      DAT_ram_00a57801 = '\x01';
		    }
		    iVar2 = *(int *)(iVar5 + 0x54);
		    do {
		      piVar7 = (int *)func_ii_7048(iVar2,uVar4,0);
		      if ((piVar7 != (int *)0x0) && (System_Action_TypeInfo != *piVar7)) {
		        System_Activator__CreateInstance(piVar7,System_Action_TypeInfo);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      iVar3 = func_ii_4329(iVar5 + 0x54,piVar7,iVar2);
		      bVar1 = iVar3 != iVar2;
		      iVar2 = iVar3;
		    } while (bVar1);
		    iVar5 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar4 = unnamed_function_1417(System_Action_SchoolSpellData__TypeInfo);
		    UnityEngine_UIElements_VisualElement__get_layout
		              (uVar4,param1,
		               Method_Gameplay_Clans_Buildings_MagicTower_Controller_MagicTowerViewMediator_UseSpellButtonClickedEvent__
		               ,0);
		    if (DAT_ram_00a57803 == '\0') {
		      Mono_Security_ASN1__get_Item(&System_Action_SchoolSpellData__TypeInfo);
		      DAT_ram_00a57803 = '\x01';
		    }
		    iVar2 = *(int *)(iVar5 + 0x58);
		    do {
		      iVar3 = 0;
		      iVar6 = func_ii_7048(iVar2,uVar4,0);
		      uVar8 = System_Action_SchoolSpellData__TypeInfo;
		      if ((iVar6 != 0) &&
		         (iVar3 = func_ii_1082(iVar6,System_Action_SchoolSpellData__TypeInfo), iVar3 == 0)) {
		        System_Activator__CreateInstance(iVar6,uVar8);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      iVar3 = func_ii_4329(iVar5 + 0x58,iVar3,iVar2);
		      bVar1 = iVar3 != iVar2;
		      iVar2 = iVar3;
		    } while (bVar1);
		  }
		  param1[5] = param2;
		  uVar4 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar5 = Cysharp_Threading_Tasks_CancellationTokenExtensions___cctor(uVar4,0);
		  if (iVar5 != 0) {
		    iVar5 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar4 = unnamed_function_1417(System_Action_SchoolSpellData__TypeInfo);
		    UnityEngine_UIElements_VisualElement__get_layout
		              (uVar4,param1,
		               Method_Gameplay_Clans_Buildings_MagicTower_Controller_MagicTowerViewMediator_SelectSpellEventHandler__
		               ,0);
		    if (DAT_ram_00a577fe == '\0') {
		      Mono_Security_ASN1__get_Item(&System_Action_SchoolSpellData__TypeInfo);
		      DAT_ram_00a577fe = '\x01';
		    }
		    iVar2 = *(int *)(iVar5 + 0x50);
		    do {
		      iVar3 = 0;
		      iVar6 = UnityEngine_UI_Image__set_sprite(iVar2,uVar4,0);
		      uVar8 = System_Action_SchoolSpellData__TypeInfo;
		      if ((iVar6 != 0) &&
		         (iVar3 = func_ii_1082(iVar6,System_Action_SchoolSpellData__TypeInfo), iVar3 == 0)) {
		        System_Activator__CreateInstance(iVar6,uVar8);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      iVar3 = func_ii_4329(iVar5 + 0x50,iVar3,iVar2);
		      bVar1 = iVar3 != iVar2;
		      iVar2 = iVar3;
		    } while (bVar1);
		    iVar5 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar4 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar4,param1,
		               Method_Gameplay_Clans_Buildings_MagicTower_Controller_MagicTowerViewMediator_DeselectSpellEventHandler__
		               ,0);
		    if (DAT_ram_00a57800 == '\0') {
		      Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		      DAT_ram_00a57800 = '\x01';
		    }
		    iVar2 = *(int *)(iVar5 + 0x54);
		    do {
		      piVar7 = (int *)UnityEngine_UI_Image__set_sprite(iVar2,uVar4,0);
		      if ((piVar7 != (int *)0x0) && (System_Action_TypeInfo != *piVar7)) {
		        System_Activator__CreateInstance(piVar7,System_Action_TypeInfo);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      iVar3 = func_ii_4329(iVar5 + 0x54,piVar7,iVar2);
		      bVar1 = iVar3 != iVar2;
		      iVar2 = iVar3;
		    } while (bVar1);
		    iVar5 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar4 = unnamed_function_1417(System_Action_SchoolSpellData__TypeInfo);
		    UnityEngine_UIElements_VisualElement__get_layout
		              (uVar4,param1,
		               Method_Gameplay_Clans_Buildings_MagicTower_Controller_MagicTowerViewMediator_UseSpellButtonClickedEvent__
		               ,0);
		    if (DAT_ram_00a57802 == '\0') {
		      Mono_Security_ASN1__get_Item(&System_Action_SchoolSpellData__TypeInfo);
		      DAT_ram_00a57802 = '\x01';
		    }
		    iVar2 = *(int *)(iVar5 + 0x58);
		    do {
		      iVar3 = 0;
		      iVar6 = UnityEngine_UI_Image__set_sprite(iVar2,uVar4,0);
		      uVar8 = System_Action_SchoolSpellData__TypeInfo;
		      if ((iVar6 != 0) &&
		         (iVar3 = func_ii_1082(iVar6,System_Action_SchoolSpellData__TypeInfo), iVar3 == 0)) {
		        System_Activator__CreateInstance(iVar6,uVar8);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      iVar3 = func_ii_4329(iVar5 + 0x58,iVar3,iVar2);
		      bVar1 = iVar3 != iVar2;
		      iVar2 = iVar3;
		    } while (bVar1);
		    iVar5 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar8 = *(undefined4 *)(iVar5 + 0x40);
		    uVar4 = unnamed_function_1417
		                      (UI_Elements_RightPanel_TitledList_TitledListWithCustomTitleArgs_TypeInfo);
		    UI_Elements_RightPanel_TitledList_TitledListWithCustomTitle_object___Clear
		              (uVar8,uVar4,
		               Method_UI_Elements_RightPanel_TitledList_TitledListWithCustomTitle_SpellTitle__Init__
		              );
		    iVar5 = *param1;
		    uVar4 = (**(code **)((ulonglong)*(uint *)(iVar5 + 0x148) * 4))
		                      (param1,*(undefined4 *)(iVar5 + 0x14c));
		    Gameplay_Clans_Buildings_MagicTower_Controller_MagicTowerController___ctor(uVar4,iVar5);
		  }
		  return;
		}
		*/

		}

		// Token: 0x17000D0D RID: 3341
		// (set) Token: 0x0600424E RID: 16974 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000D0D")]
		public override MagicTowerWindow View
		{
			[Token(Token = "0x600424E")]
			[Address(RVA = "0x9102", Offset = "0x9102", VA = "0x9102", Slot = "20")]
			set
			{
			}
		}

		// Token: 0x0600424F RID: 16975 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600424F")]
		[Address(RVA = "0x9103", Offset = "0x9103", VA = "0x9103")]
		private void UseSpellButtonClickedEvent(SchoolSpellData data)
		{
		/* --- GHIDRA: UseSpellButtonClickedEvent ---
		void Gameplay_Clans_Buildings_MagicTower_Controller_MagicTowerViewMediator__UseSpellButtonClickedEvent
		               (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 uVar3;
		  
		  if (DAT_ram_00a57826 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Clans_Buildings_MagicTower_Controller_MagicTowerViewMediator_OnBoostSpellClicked__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Clans_Buildings_MagicTower_Controller_MagicTowerViewMediator_OnCancelSpellClicked__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Clans_Buildings_MagicTower_Controller_MagicTowerViewMediator_OnLearnSpellClicked__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Elements_RightPanel_TitledList_TitledListWithCustomTitle_SpellTitle__Clear__
		              );
		    Mono_Security_ASN1__get_Item(&UnityEngine_Events_UnityAction_TypeInfo);
		    DAT_ram_00a57826 = '\x01';
		  }
		  param1[6] = 0;
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  UI_Elements_RightPanel_TitledList_TitledListWithCustomTitle_object___AddElement
		            (*(undefined4 *)(iVar1 + 0x40),
		             Method_UI_Elements_RightPanel_TitledList_TitledListWithCustomTitle_SpellTitle__Clear__)
		  ;
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar2 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (*(undefined4 *)(iVar1 + 0x40),0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar2,0,0);
		  uVar3 = *(undefined4 *)(*(int *)(param1[8] + 0x24) + 0xb4);
		  uVar2 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		  Utils_ObjectUtils__IsNotNull
		            (uVar2,param1,
		             Method_Gameplay_Clans_Buildings_MagicTower_Controller_MagicTowerViewMediator_OnLearnSpellClicked__
		             ,0);
		  UnityEngine_Events_UnityAction___ctor(uVar3,uVar2,0);
		  uVar3 = *(undefined4 *)(*(int *)(param1[8] + 0x28) + 0xb4);
		  uVar2 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		  Utils_ObjectUtils__IsNotNull
		            (uVar2,param1,
		             Method_Gameplay_Clans_Buildings_MagicTower_Controller_MagicTowerViewMediator_OnLearnSpellClicked__
		             ,0);
		  UnityEngine_Events_UnityAction___ctor(uVar3,uVar2,0);
		  uVar3 = *(undefined4 *)(*(int *)(param1[8] + 0x2c) + 0xb4);
		  uVar2 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		  Utils_ObjectUtils__IsNotNull
		            (uVar2,param1,
		             Method_Gameplay_Clans_Buildings_MagicTower_Controller_MagicTowerViewMediator_OnBoostSpellClicked__
		             ,0);
		  UnityEngine_Events_UnityAction___ctor(uVar3,uVar2,0);
		  uVar3 = *(undefined4 *)(*(int *)(param1[8] + 0x30) + 0xb4);
		  uVar2 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		  Utils_ObjectUtils__IsNotNull
		            (uVar2,param1,
		             Method_Gameplay_Clans_Buildings_MagicTower_Controller_MagicTowerViewMediator_OnCancelSpellClicked__
		             ,0);
		  UnityEngine_Events_UnityAction___ctor(uVar3,uVar2,0);
		  param1[9] = 0;
		  param1[7] = 0;
		  param1[8] = 0;
		  return;
		}
		*/

		}

		// Token: 0x06004250 RID: 16976 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004250")]
		[Address(RVA = "0x9104", Offset = "0x9104", VA = "0x9104")]
		private void DeselectSpellEventHandler()
		{
		/* --- GHIDRA: DeselectSpellEventHandler ---
		void Gameplay_Clans_Buildings_MagicTower_Controller_MagicTowerViewMediator__DeselectSpellEventHandler
		               (int *param1,int *param2,undefined4 param3)
		
		{
		  uint uVar1;
		  int iVar2;
		  undefined4 uVar3;
		  uint *puVar4;
		  undefined4 uVar5;
		  int *piVar6;
		  undefined4 uVar7;
		  int iVar8;
		  
		  if (DAT_ram_00a57827 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_MagicTowerModel__MagicTowerEvents__MagicTowerController__MagicTowerWindow__get_Model__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Gameplay_Clans_Buildings_MagicTower_View_ClanSpellUpgradeRequirementsTitledListElement_ClanSpellUpgradeRequirementsTitledListElementArgs_TypeInfo
		              );
		    Mono_Security_ASN1__get_Item(&Gameplay_Discounts_Model_IDiscountHandler_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Clans_Buildings_MagicTower_Controller_MagicTowerViewMediator_OnBoostSpellClicked__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Clans_Buildings_MagicTower_Controller_MagicTowerViewMediator_OnCancelSpellClicked__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Clans_Buildings_MagicTower_Controller_MagicTowerViewMediator_OnLearnSpellClicked__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_School_View_SpellCurrentDescriptionTitledListElementArgs_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_MageSchool_View_SpellUpgradeTitledListElementArgs_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Elements_RightPanel_TitledList_TitledListWithCustomTitle_SpellTitle__AddElement_ClanSpellUpgradeRequirementsTitledListElement___
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Elements_RightPanel_TitledList_TitledListWithCustomTitle_SpellTitle__AddElement_SpellCurrentDescriptionTitledListElement___
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Elements_RightPanel_TitledList_TitledListWithCustomTitle_SpellTitle__AddElement_SpellUpgradeTitledListElement___
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Elements_RightPanel_TitledList_TitledListWithCustomTitle_SpellTitle__Clear__
		              );
		    Mono_Security_ASN1__get_Item(&UnityEngine_Events_UnityAction_TypeInfo);
		    DAT_ram_00a57827 = '\x01';
		  }
		  param1[6] = (int)param2;
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  UI_Elements_RightPanel_TitledList_TitledListWithCustomTitle_object___AddElement
		            (*(undefined4 *)(iVar2 + 0x40),
		             Method_UI_Elements_RightPanel_TitledList_TitledListWithCustomTitle_SpellTitle__Clear__)
		  ;
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar3 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (*(undefined4 *)(iVar2 + 0x40),0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar3,1,0);
		  Gameplay_Clans_Buildings_MagicTower_Controller_MagicTowerViewMediator__UpdateState
		            (param1,param2,param1);
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param2 + 0xf0) * 4))
		                    (param2,*(undefined4 *)(*param2 + 0xf4));
		  if (iVar2 == 0) {
		    iVar2 = 0;
		  }
		  else {
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar5 = *(undefined4 *)(iVar2 + 0x40);
		    uVar3 = unnamed_function_1417
		                      (Gameplay_School_View_SpellCurrentDescriptionTitledListElementArgs_TypeInfo);
		    Unity_Services_Core_Environments_Internal_Environments__get_Current(uVar3,param2,0);
		    iVar2 = func_ii_8512(uVar5,uVar3,
		                         Method_UI_Elements_RightPanel_TitledList_TitledListWithCustomTitle_SpellTitle__AddElement_SpellCurrentDescriptionTitledListElement___
		                        );
		  }
		  param1[7] = iVar2;
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar5 = *(undefined4 *)(iVar2 + 0x40);
		  uVar3 = unnamed_function_1417(Gameplay_MageSchool_View_SpellUpgradeTitledListElementArgs_TypeInfo)
		  ;
		  Unity_Services_Core_Environments_Internal_Environments__get_Current(uVar3,param2,0);
		  iVar2 = func_ii_8512(uVar5,uVar3,
		                       Method_UI_Elements_RightPanel_TitledList_TitledListWithCustomTitle_SpellTitle__AddElement_SpellUpgradeTitledListElement___
		                      );
		  param1[8] = iVar2;
		  piVar6 = *(int **)(param1[2] + 0x18);
		  if (piVar6 != (int *)0x0) {
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar3 = *(undefined4 *)(iVar2 + 0x40);
		    iVar2 = *piVar6;
		    if (*(ushort *)(iVar2 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        if (Gameplay_Discounts_Model_IDiscountHandler_TypeInfo ==
		            *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8)) {
		          puVar4 = (uint *)(iVar2 + *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		          goto code_r0x80de5123;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		    }
		    puVar4 = (uint *)func_ii_1080(piVar6,Gameplay_Discounts_Model_IDiscountHandler_TypeInfo,0);
		code_r0x80de5123:
		    (**(code **)((ulonglong)*puVar4 * 4))(piVar6,uVar3,puVar4[1]);
		  }
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar3 = *(undefined4 *)(iVar2 + 0x40);
		  uVar5 = *(undefined4 *)(param1[2] + 8);
		  uVar7 = *(undefined4 *)(*(int *)(param1[2] + 0x10) + 0x18);
		  iVar2 = unnamed_function_1417
		                    (
		                    Gameplay_Clans_Buildings_MagicTower_View_ClanSpellUpgradeRequirementsTitledListElement_ClanSpellUpgradeRequirementsTitledListElementArgs_TypeInfo
		                    );
		  *(undefined4 *)(iVar2 + 0x10) = uVar7;
		  *(undefined4 *)(iVar2 + 0xc) = uVar5;
		  *(int **)(iVar2 + 8) = param2;
		  iVar2 = func_ii_8512(uVar3,iVar2,
		                       Method_UI_Elements_RightPanel_TitledList_TitledListWithCustomTitle_SpellTitle__AddElement_ClanSpellUpgradeRequirementsTitledListElement___
		                      );
		  param1[9] = iVar2;
		  uVar5 = *(undefined4 *)(*(int *)(param1[8] + 0x24) + 0xb4);
		  uVar3 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		  Utils_ObjectUtils__IsNotNull
		            (uVar3,param1,
		             Method_Gameplay_Clans_Buildings_MagicTower_Controller_MagicTowerViewMediator_OnLearnSpellClicked__
		             ,0);
		  Gameplay_Boss_View_CaptainTab_BossInfoView__add_AttackButtonClickEvent(uVar5,uVar3,0);
		  uVar5 = *(undefined4 *)(*(int *)(param1[8] + 0x28) + 0xb4);
		  uVar3 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		  Utils_ObjectUtils__IsNotNull
		            (uVar3,param1,
		             Method_Gameplay_Clans_Buildings_MagicTower_Controller_MagicTowerViewMediator_OnLearnSpellClicked__
		             ,0);
		  Gameplay_Boss_View_CaptainTab_BossInfoView__add_AttackButtonClickEvent(uVar5,uVar3,0);
		  uVar5 = *(undefined4 *)(*(int *)(param1[8] + 0x2c) + 0xb4);
		  uVar3 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		  Utils_ObjectUtils__IsNotNull
		            (uVar3,param1,
		             Method_Gameplay_Clans_Buildings_MagicTower_Controller_MagicTowerViewMediator_OnBoostSpellClicked__
		             ,0);
		  Gameplay_Boss_View_CaptainTab_BossInfoView__add_AttackButtonClickEvent(uVar5,uVar3,0);
		  uVar5 = *(undefined4 *)(*(int *)(param1[8] + 0x30) + 0xb4);
		  uVar3 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		  Utils_ObjectUtils__IsNotNull
		            (uVar3,param1,
		             Method_Gameplay_Clans_Buildings_MagicTower_Controller_MagicTowerViewMediator_OnCancelSpellClicked__
		             ,0);
		  Gameplay_Boss_View_CaptainTab_BossInfoView__add_AttackButtonClickEvent(uVar5,uVar3,0);
		  Gameplay_Clans_Buildings_MagicTower_Controller_MagicTowerViewMediator__OnCancelSpellClicked
		            (param1,param1);
		  piVar6 = *(int **)(param1[2] + 0x18);
		  if (piVar6 != (int *)0x0) {
		    uVar1 = 0;
		    iVar2 = param1[8];
		    iVar8 = *piVar6;
		    if (*(ushort *)(iVar8 + 0xb6) != 0) {
		      do {
		        if (Gameplay_Discounts_Model_IDiscountHandler_TypeInfo ==
		            *(int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8)) {
		          puVar4 = (uint *)(iVar8 + *(int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		          goto code_r0x80de52f3;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar8 + 0xb6) != uVar1);
		    }
		    puVar4 = (uint *)func_ii_1080(piVar6,Gameplay_Discounts_Model_IDiscountHandler_TypeInfo,0);
		code_r0x80de52f3:
		    (**(code **)((ulonglong)*puVar4 * 4))(piVar6,iVar2,puVar4[1]);
		  }
		  return;
		}
		*/

		}

		// Token: 0x06004251 RID: 16977 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004251")]
		[Address(RVA = "0x9105", Offset = "0x9105", VA = "0x9105")]
		private void SelectSpellEventHandler(SchoolSpellData spell)
		{
		/* --- GHIDRA: SelectSpellEventHandler ---
		void Gameplay_Clans_Buildings_MagicTower_Controller_MagicTowerViewMediator__SelectSpellEventHandler
		               (int *param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  int iVar2;
		  undefined4 uVar3;
		  int *piVar4;
		  int iVar5;
		  undefined4 uVar6;
		  
		  if (DAT_ram_00a57828 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_MagicTowerModel__MagicTowerEvents__MagicTowerController__MagicTowerWindow__set_Events__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_uint__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Clans_Buildings_MagicTower_Controller_MagicTowerViewMediator_TowerInfoRequestedEventHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Clans_Buildings_MagicTower_Controller_MagicTowerViewMediator_UpdateSpell__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Clans_Buildings_MagicTower_Controller_MagicTowerViewMediator_UpdateState__
		              );
		    DAT_ram_00a57828 = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x13c));
		  if (iVar1 != 0) {
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar6 = *(undefined4 *)(iVar2 + 0x14);
		    uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar3,param1,
		               Method_Gameplay_Clans_Buildings_MagicTower_Controller_MagicTowerViewMediator_TowerInfoRequestedEventHandler__
		               ,0);
		    piVar4 = (int *)func_ii_7048(uVar6,uVar3,0);
		    iVar1 = System_Action_TypeInfo;
		    if (piVar4 == (int *)0x0) {
		      *(undefined4 *)(iVar2 + 0x14) = 0;
		    }
		    else if ((System_Action_TypeInfo != *piVar4) ||
		            (*(int **)(iVar2 + 0x14) = piVar4, *piVar4 != iVar1)) {
		      System_Activator__CreateInstance(piVar4,iVar1);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar6 = *(undefined4 *)(iVar1 + 0x18);
		    uVar3 = unnamed_function_1417(System_Action_uint__TypeInfo);
		    func_ii_12322(uVar3,param1,
		                  Method_Gameplay_Clans_Buildings_MagicTower_Controller_MagicTowerViewMediator_UpdateState__
		                  ,0);
		    iVar2 = func_ii_7048(uVar6,uVar3,0);
		    uVar3 = System_Action_uint__TypeInfo;
		    if (iVar2 == 0) {
		      *(undefined4 *)(iVar1 + 0x18) = 0;
		    }
		    else {
		      iVar5 = func_ii_1082(iVar2,System_Action_uint__TypeInfo);
		      if (iVar5 == 0) {
		        System_Activator__CreateInstance(iVar2,uVar3);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      *(int *)(iVar1 + 0x18) = iVar5;
		      uVar3 = System_Action_uint__TypeInfo;
		      iVar1 = func_ii_1082(iVar2,System_Action_uint__TypeInfo);
		      if (iVar1 == 0) {
		        System_Activator__CreateInstance(iVar2,uVar3);
		        do {
		          halt_trap();
		        } while( true );
		      }
		    }
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar6 = *(undefined4 *)(iVar1 + 0x1c);
		    uVar3 = unnamed_function_1417(System_Action_uint__TypeInfo);
		    func_ii_12322(uVar3,param1,
		                  Method_Gameplay_Clans_Buildings_MagicTower_Controller_MagicTowerViewMediator_UpdateSpell__
		                  ,0);
		    iVar2 = func_ii_7048(uVar6,uVar3,0);
		    uVar3 = System_Action_uint__TypeInfo;
		    if (iVar2 == 0) {
		      *(undefined4 *)(iVar1 + 0x1c) = 0;
		    }
		    else {
		      iVar5 = func_ii_1082(iVar2,System_Action_uint__TypeInfo);
		      if (iVar5 == 0) {
		        System_Activator__CreateInstance(iVar2,uVar3);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      *(int *)(iVar1 + 0x1c) = iVar5;
		      uVar3 = System_Action_uint__TypeInfo;
		      iVar1 = func_ii_1082(iVar2,System_Action_uint__TypeInfo);
		      if (iVar1 == 0) {
		        System_Activator__CreateInstance(iVar2,uVar3);
		        do {
		          halt_trap();
		        } while( true );
		      }
		    }
		  }
		  param1[3] = param2;
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x13c));
		  if (iVar1 != 0) {
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar6 = *(undefined4 *)(iVar2 + 0x14);
		    uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar3,param1,
		               Method_Gameplay_Clans_Buildings_MagicTower_Controller_MagicTowerViewMediator_TowerInfoRequestedEventHandler__
		               ,0);
		    piVar4 = (int *)UnityEngine_UI_Image__set_sprite(uVar6,uVar3,0);
		    iVar1 = System_Action_TypeInfo;
		    if (piVar4 == (int *)0x0) {
		      *(undefined4 *)(iVar2 + 0x14) = 0;
		    }
		    else if ((System_Action_TypeInfo != *piVar4) ||
		            (*(int **)(iVar2 + 0x14) = piVar4, *piVar4 != iVar1)) {
		      System_Activator__CreateInstance(piVar4,iVar1);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar6 = *(undefined4 *)(iVar1 + 0x18);
		    uVar3 = unnamed_function_1417(System_Action_uint__TypeInfo);
		    func_ii_12322(uVar3,param1,
		                  Method_Gameplay_Clans_Buildings_MagicTower_Controller_MagicTowerViewMediator_UpdateState__
		                  ,0);
		    iVar2 = UnityEngine_UI_Image__set_sprite(uVar6,uVar3,0);
		    uVar3 = System_Action_uint__TypeInfo;
		    if (iVar2 == 0) {
		      *(undefined4 *)(iVar1 + 0x18) = 0;
		    }
		    else {
		      iVar5 = func_ii_1082(iVar2,System_Action_uint__TypeInfo);
		      if (iVar5 == 0) {
		        System_Activator__CreateInstance(iVar2,uVar3);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      *(int *)(iVar1 + 0x18) = iVar5;
		      uVar3 = System_Action_uint__TypeInfo;
		      iVar1 = func_ii_1082(iVar2,System_Action_uint__TypeInfo);
		      if (iVar1 == 0) {
		        System_Activator__CreateInstance(iVar2,uVar3);
		        do {
		          halt_trap();
		        } while( true );
		      }
		    }
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar6 = *(undefined4 *)(iVar1 + 0x1c);
		    uVar3 = unnamed_function_1417(System_Action_uint__TypeInfo);
		    func_ii_12322(uVar3,param1,
		                  Method_Gameplay_Clans_Buildings_MagicTower_Controller_MagicTowerViewMediator_UpdateSpell__
		                  ,0);
		    iVar2 = UnityEngine_UI_Image__set_sprite(uVar6,uVar3,0);
		    uVar3 = System_Action_uint__TypeInfo;
		    if (iVar2 == 0) {
		      *(undefined4 *)(iVar1 + 0x1c) = 0;
		      return;
		    }
		    iVar5 = func_ii_1082(iVar2,System_Action_uint__TypeInfo);
		    if (iVar5 == 0) {
		      System_Activator__CreateInstance(iVar2,uVar3);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    *(int *)(iVar1 + 0x1c) = iVar5;
		    uVar3 = System_Action_uint__TypeInfo;
		    iVar1 = func_ii_1082(iVar2,System_Action_uint__TypeInfo);
		    if (iVar1 == 0) {
		      System_Activator__CreateInstance(iVar2,uVar3);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x17000D0E RID: 3342
		// (set) Token: 0x06004252 RID: 16978 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000D0E")]
		public override MagicTowerEvents Events
		{
			[Token(Token = "0x6004252")]
			[Address(RVA = "0x9106", Offset = "0x9106", VA = "0x9106", Slot = "16")]
			set
			{
			}
		}

		// Token: 0x06004253 RID: 16979 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004253")]
		[Address(RVA = "0x9107", Offset = "0x9107", VA = "0x9107")]
		private void TowerInfoRequestedEventHandler()
		{
		/* --- GHIDRA: TowerInfoRequestedEventHandler ---
		void Gameplay_Clans_Buildings_MagicTower_Controller_MagicTowerViewMediator__TowerInfoRequestedEventHandler
		               (int *param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  
		  if (DAT_ram_00a5782a == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_MagicTowerModel__MagicTowerEvents__MagicTowerController__MagicTowerWindow__get_Model__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_uint__ClanSchoolSpellData__get_Item__);
		    DAT_ram_00a5782a = '\x01';
		  }
		  if ((param1[6] != 0) &&
		     (iVar1 = UnityEngine_AndroidJavaObject___GetRawObject(param1[6],0), iVar1 == param2)) {
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar2 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                      (*(undefined4 *)(iVar1 + 0x40),0);
		    Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		              (uVar2,1,0);
		    iVar1 = param1[8];
		    if (iVar1 != 0) {
		      uVar2 = System_Collections_Generic_List_object___get_Item
		                        (*(undefined4 *)(param1[2] + 0x1c),param2,
		                         Method_System_Collections_Generic_Dictionary_uint__ClanSchoolSpellData__get_Item__
		                        );
		      Gameplay_MageSchool_View_SpellUpgradeTitledListElement__OnDestroy
		                (iVar1,uVar2,*(undefined4 *)(*(int *)(param1[2] + 0x10) + 0x18),0);
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x06004254 RID: 16980 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004254")]
		[Address(RVA = "0x9108", Offset = "0x9108", VA = "0x9108")]
		private void UpdateState(uint spellId)
		{
		/* --- GHIDRA: UpdateState ---
		void Gameplay_Clans_Buildings_MagicTower_Controller_MagicTowerViewMediator__UpdateState
		               (int *param1,int *param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 uVar3;
		  
		  if (DAT_ram_00a5782b == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Elements_RightPanel_TitledList_TitledListWithCustomTitle_SpellTitle__get_Title__
		              );
		    DAT_ram_00a5782b = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar3 = *(undefined4 *)(*(int *)(iVar1 + 0x40) + 0x10);
		  uVar2 = (**(code **)((ulonglong)*(uint *)(*param2 + 0xf0) * 4))
		                    (param2,*(undefined4 *)(*param2 + 0xf4));
		  Gameplay_School_View_SpellTitle__set_Title(uVar3,uVar2,0);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar3 = *(undefined4 *)(*(int *)(iVar1 + 0x40) + 0x10);
		  uVar2 = Gameplay_School_Model_SchoolSpellData__get_Level(param2,0);
		  Gameplay_School_View_SpellCurrentDescriptionTitledListElementArgs___ctor(uVar3,uVar2,0);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar3 = *(undefined4 *)(*(int *)(iVar1 + 0x40) + 0x10);
		  uVar2 = Core_Extensions_Dict_SpellDicExt__GetAnimationOnAvatarCanvasAssetId(param2[3],0);
		  Gameplay_Antiq_View_Grid_GridList__SetData(uVar3,uVar2,0);
		  return;
		}
		*/

		}

		// Token: 0x06004255 RID: 16981 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004255")]
		[Address(RVA = "0x9109", Offset = "0x9109", VA = "0x9109")]
		private void SetSpellToTitleList(SchoolSpellData schoolSpellData)
		{
		/* --- GHIDRA: SetSpellToTitleList ---
		void Gameplay_Clans_Buildings_MagicTower_Controller_MagicTowerViewMediator__SetSpellToTitleList
		               (int *param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  
		  param1_00 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x14c));
		  Gameplay_Clans_Buildings_MagicTower_Controller_MagicTowerController__GetMagicTowerInfoResultHandler
		            (param1_00,param1[6],param1);
		  return;
		}
		*/

		}

		// Token: 0x06004256 RID: 16982 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004256")]
		[Address(RVA = "0x910A", Offset = "0x910A", VA = "0x910A")]
		private void OnLearnSpellClicked()
		{
		/* --- GHIDRA: OnLearnSpellClicked ---
		void Gameplay_Clans_Buildings_MagicTower_Controller_MagicTowerViewMediator__OnLearnSpellClicked
		               (int param1,undefined4 param2)
		
		{
		  Gameplay_Clans_Buildings_MagicTower_Controller_MagicTowerViewMediator__ShowConfirmCancelImproveSpell
		            (param1,*(undefined4 *)(param1 + 0x18),param1);
		  return;
		}
		*/

		}

		// Token: 0x06004257 RID: 16983 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004257")]
		[Address(RVA = "0x910B", Offset = "0x910B", VA = "0x910B")]
		private void OnBoostSpellClicked()
		{
		/* --- GHIDRA: OnBoostSpellClicked ---
		void Gameplay_Clans_Buildings_MagicTower_Controller_MagicTowerViewMediator__OnBoostSpellClicked
		               (int param1,undefined4 param2)
		
		{
		  Gameplay_Clans_Buildings_MagicTower_Controller_MagicTowerViewMediator__UpdateSpell
		            (param1,*(undefined4 *)(param1 + 0x18),param1);
		  return;
		}
		*/

		}

		// Token: 0x06004258 RID: 16984 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004258")]
		[Address(RVA = "0x910C", Offset = "0x910C", VA = "0x910C")]
		private void OnCancelSpellClicked()
		{
		/* --- GHIDRA: OnCancelSpellClicked ---
		void Gameplay_Clans_Buildings_MagicTower_Controller_MagicTowerViewMediator__OnCancelSpellClicked
		               (int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  longlong lVar2;
		  longlong lVar3;
		  int iVar4;
		  
		  if (DAT_ram_00a5782c == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_MagicTowerModel__MagicTowerEvents__MagicTowerController__MagicTowerWindow__get_Model__
		              );
		    DAT_ram_00a5782c = '\x01';
		  }
		  lVar2 = System_Collections_Generic_LinkedList_Enumerator_object___MoveNext
		                    (*(undefined4 *)(*(int *)(param1 + 8) + 8),0);
		  iVar4 = *(int *)(param1 + 8);
		  if (DAT_ram_00a5780b == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Isles_Base_AbstractIsle_ClanIsleEvents__ClanIsleModel__ClanIsleController__ClanBuildingTypes__get_Model__
		              );
		    DAT_ram_00a5780b = '\x01';
		  }
		  lVar3 = System_Collections_Generic_LinkedList_Enumerator_object___MoveNext
		                    (*(undefined4 *)
		                      (*(int *)(*(int *)(*(int *)(iVar4 + 0x14) + 0x10) + 0x30) + 0x14),0);
		  if (lVar3 != lVar2) {
		    uVar1 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                      (*(undefined4 *)(*(int *)(param1 + 0x20) + 0x24),0);
		    Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		              (uVar1,0,0);
		    uVar1 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                      (*(undefined4 *)(*(int *)(param1 + 0x20) + 0x28),0);
		    Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		              (uVar1,0,0);
		    uVar1 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                      (*(undefined4 *)(*(int *)(param1 + 0x20) + 0x30),0);
		    Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		              (uVar1,0,0);
		  }
		  return;
		}
		*/

		}

		// Token: 0x06004259 RID: 16985 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004259")]
		[Address(RVA = "0x910D", Offset = "0x910D", VA = "0x910D")]
		private void ValidateButtons()
		{
		/* --- GHIDRA: ValidateButtons ---
		void Gameplay_Clans_Buildings_MagicTower_Controller_MagicTowerViewMediator__ValidateButtons
		               (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 param2_00;
		  int iVar2;
		  undefined4 uVar3;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a5782d == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_MagicTowerModel__MagicTowerEvents__MagicTowerController__MagicTowerWindow__get_Model__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_uint__ClanSchoolSpellData__get_Item__);
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_First_ClanSpellListElement___);
		    Mono_Security_ASN1__get_Item(&System_Func_ClanSpellListElement__bool__TypeInfo);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Clans_Buildings_MagicTower_Controller_MagicTowerViewMediator___c__DisplayClass19_0__UpdateSpell_b__0__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Gameplay_Clans_Buildings_MagicTower_Controller_MagicTowerViewMediator___c__DisplayClass19_0_TypeInfo
		              );
		    DAT_ram_00a5782d = '\x01';
		  }
		  iVar1 = unnamed_function_1417
		                    (
		                    Gameplay_Clans_Buildings_MagicTower_Controller_MagicTowerViewMediator___c__DisplayClass19_0_TypeInfo
		                    );
		  *(undefined4 *)(iVar1 + 8) = param2;
		  param2_00 = System_Collections_Generic_List_object___get_Item
		                        (*(undefined4 *)(param1[2] + 0x1c),param2,
		                         Method_System_Collections_Generic_Dictionary_uint__ClanSchoolSpellData__get_Item__
		                        );
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  param1_00 = *(undefined4 *)(iVar2 + 0x4c);
		  uVar3 = unnamed_function_1417(System_Func_ClanSpellListElement__bool__TypeInfo);
		  System_Collections_Generic_Dictionary_uint__object___GetEnumerator
		            (uVar3,iVar1,
		             Method_Gameplay_Clans_Buildings_MagicTower_Controller_MagicTowerViewMediator___c__DisplayClass19_0__UpdateSpell_b__0__
		             ,0);
		  uVar3 = func_ii_7423(param1_00,uVar3,Method_System_Linq_Enumerable_First_ClanSpellListElement___);
		  Gameplay_Clans_Buildings_MagicTower_View_ClanSpellListElement__OnDestroy(uVar3,param2_00,param1);
		  iVar1 = param1[7];
		  if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		    func_ii_306000(UnityEngine_Object_TypeInfo);
		  }
		  iVar1 = func_ii_3812(iVar1,0,0);
		  if (iVar1 == 0) {
		    iVar1 = param1[8];
		    if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		      func_ii_306000(UnityEngine_Object_TypeInfo);
		    }
		    iVar1 = func_ii_3812(iVar1,0,0);
		    if (iVar1 == 0) {
		      iVar1 = param1[7];
		      if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		        func_ii_306000(UnityEngine_Object_TypeInfo);
		      }
		      iVar1 = func_ii_3812(iVar1,0,0);
		      if (iVar1 == 0) {
		        Gameplay_Clans_Buildings_MagicTower_Controller_MagicTowerViewMediator__UpdateState
		                  (param1,param2_00,param1);
		        Gameplay_School_View_SpellCurrentDescriptionTitledListElement__OnInit(param1[7],param2_00,0)
		        ;
		        Gameplay_MageSchool_View_SpellUpgradeTitledListElement__OnDestroy
		                  (param1[8],param2_00,*(undefined4 *)(*(int *)(param1[2] + 0x10) + 0x18),0);
		        Gameplay_Clans_Buildings_MagicTower_View_ClanSpellUpgradeRequirementsTitledListElement__OnInit
		                  (param1[9],param2_00,*(undefined4 *)(param1[2] + 8),
		                   *(undefined4 *)(*(int *)(param1[2] + 0x10) + 0x18),param1);
		        Gameplay_Clans_Buildings_MagicTower_Controller_MagicTowerViewMediator__OnCancelSpellClicked
		                  (param1,param1);
		        return;
		      }
		    }
		  }
		  Gameplay_Clans_Buildings_MagicTower_Controller_MagicTowerViewMediator__DeselectSpellEventHandler
		            (param1,param2_00,param1);
		  Gameplay_Clans_Buildings_MagicTower_Controller_MagicTowerViewMediator__OnCancelSpellClicked
		            (param1,param1);
		  return;
		}
		*/

		}

		// Token: 0x0600425A RID: 16986 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600425A")]
		[Address(RVA = "0x910E", Offset = "0x910E", VA = "0x910E")]
		private void UpdateSpell(uint spellId)
		{
		/* --- GHIDRA: UpdateSpell ---
		undefined4
		Gameplay_Clans_Buildings_MagicTower_Controller_MagicTowerViewMediator__UpdateSpell
		          (undefined4 param1,int *param2,undefined4 param3)
		
		{
		  undefined4 in_register_20000014;
		  undefined4 uVar1;
		  undefined4 uVar2;
		  int iVar3;
		  undefined4 param1_00;
		  int param1_01;
		  int param1_02;
		  double param2_00;
		  undefined4 *puVar4;
		  int param1_03;
		  uint uVar5;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a5782e == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_MagicTowerModel__MagicTowerEvents__MagicTowerController__MagicTowerWindow__get_Model__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_ButtonCallbackDelegate_DialogWindow_DialogWindowArgs__SchoolSpellData__TypeInfo
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_DialogWindow_DialogWindowArgs__SchoolSpellData___ctor__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_DialogWindow_DialogWindowArgs__SchoolSpellData__TypeInfo
		              );
		    Mono_Security_ASN1__get_Item(&UI_Windows_DialogWindow_DialogWindowArgs_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs___ctor__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs__TypeInfo
		              );
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_KeyValuePair_string__string____TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_KeyValuePair_string__string___ctor__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs___Add__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Clans_Buildings_MagicTower_Controller_MagicTowerViewMediator__ShowConfirmCancelImproveSpell_b__20_0__
		              );
		    Mono_Security_ASN1__get_Item(&StringLiteral_13733);
		    Mono_Security_ASN1__get_Item(&StringLiteral_13734);
		    Mono_Security_ASN1__get_Item(&StringLiteral_26445);
		    Mono_Security_ASN1__get_Item(&StringLiteral_2556);
		    Mono_Security_ASN1__get_Item(&StringLiteral_13732);
		    Mono_Security_ASN1__get_Item(&StringLiteral_4111);
		    DAT_ram_00a5782e = '\x01';
		  }
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param2 + 0x110) * 4))
		                    (param2,CONCAT44(in_register_20000014,*(undefined4 *)(*param2 + 0x114)));
		  uVar1 = Protocol_Common_ResourceSet___ctor(uVar1,0);
		  param2_00 = Gameplay_Clans_Buildings_MagicTower_Model_MagicTowerModel__GetCancelImproveMoneyBack
		                        (param2,param2);
		  uVar2 = Core_Extensions_Dict_ResourceSetExt__Round(uVar1,param2_00,0);
		  uVar1 = (undefined4)((ulonglong)param2_00 >> 0x20);
		  uVar2 = Core_Extensions_Dict_ResourceSetExt__SetValue(uVar2,0);
		  iVar3 = (**(code **)((ulonglong)*(uint *)(*param2 + 0xf0) * 4))
		                    (param2,CONCAT44(uVar1,*(undefined4 *)(*param2 + 0xf4)));
		  if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_GameLocalization_TypeInfo);
		  }
		  puVar4 = &StringLiteral_13732;
		  if (iVar3 == 0) {
		    puVar4 = &StringLiteral_13734;
		  }
		  uVar1 = func_ii_7508(*puVar4,1,0,1,0,0,0,0);
		  puVar4 = &StringLiteral_4111;
		  if (iVar3 == 0) {
		    puVar4 = &StringLiteral_13733;
		  }
		  param1_00 = func_ii_7508(*puVar4,1,0,1,0,0,0,0);
		  param1_01 = unnamed_function_1417(UI_Windows_DialogWindow_DialogWindowArgs_TypeInfo);
		  func_ii_8625(param1_01,0);
		  *(undefined4 *)(param1_01 + 0x18) = uVar1;
		  iVar3 = Mono_Security_ASN1Convert__ToOid
		                    (System_Collections_Generic_KeyValuePair_string__string____TypeInfo,1);
		  uVar1 = Core_Extensions_Dict_ResourceSetExt__ToLocaleString(uVar2,NAN,0,StringLiteral_2556,0,0,0);
		  local_8 = 0;
		  System_Text_Formatting_StringView__get_IsEmpty
		            (&local_8,StringLiteral_26445,uVar1,
		             Method_System_Collections_Generic_KeyValuePair_string__string___ctor__);
		  *(undefined8 *)(iVar3 + 0x10) = local_8;
		  uVar1 = Gameplay_Clans_Office_View_ClanWarsTab_ClanWarsRewardsTab_ClanWarsRewardsView__GetPlacesText
		                    (param1_00,iVar3,0);
		  *(undefined4 *)(param1_01 + 0x1c) = uVar1;
		  param1_03 = *(int *)(param1_01 + 0x24);
		  param1_02 = unnamed_function_1417
		                        (
		                        UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs__TypeInfo
		                        );
		  UI_Windows_DialogWindow_DialogWindowArgs___ctor
		            (param1_02,
		             Method_UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs___ctor__
		            );
		  uVar1 = UI_Windows_DialogWindow__get_WindowId(0);
		  *(undefined4 *)(param1_02 + 8) = uVar1;
		  iVar3 = unnamed_function_1417
		                    (
		                    UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_DialogWindow_DialogWindowArgs__SchoolSpellData__TypeInfo
		                    );
		  *(int **)(iVar3 + 0xc) = param2;
		  uVar1 = unnamed_function_1417
		                    (
		                    UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_ButtonCallbackDelegate_DialogWindow_DialogWindowArgs__SchoolSpellData__TypeInfo
		                    );
		  UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_ButtonCallbackDelegate_object__Int32Enum___Invoke
		            (uVar1,param1,
		             Method_Gameplay_Clans_Buildings_MagicTower_Controller_MagicTowerViewMediator__ShowConfirmCancelImproveSpell_b__20_0__
		             ,0);
		  *(undefined4 *)(iVar3 + 0x10) = uVar1;
		  *(int *)(param1_02 + 0x14) = iVar3;
		  iVar3 = 
		  Method_System_Collections_Generic_List_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs___Add__
		  ;
		  *(int *)(param1_03 + 0x10) = *(int *)(param1_03 + 0x10) + 1;
		  uVar5 = *(uint *)(param1_03 + 0xc);
		  if (uVar5 < *(uint *)(*(int *)(param1_03 + 8) + 0xc)) {
		    *(uint *)(param1_03 + 0xc) = uVar5 + 1;
		    *(int *)(*(int *)(param1_03 + 8) + uVar5 * 4 + 0x10) = param1_02;
		  }
		  else {
		    System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		              (param1_03,param1_02,*(undefined4 *)(*(int *)(*(int *)(iVar3 + 0x10) + 0x60) + 0x38));
		  }
		  uVar1 = UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_ButtonCallbackDelegate_object____ctor
		                    (param1_01,0);
		  return uVar1;
		}
		*/

		}

		// Token: 0x0600425B RID: 16987 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600425B")]
		[Address(RVA = "0x910F", Offset = "0x910F", VA = "0x910F")]
		private DialogWindow ShowConfirmCancelImproveSpell(SchoolSpellData spell)
		{
		/* --- GHIDRA: ShowConfirmCancelImproveSpell ---
		undefined4
		Gameplay_Clans_Buildings_MagicTower_Controller_MagicTowerViewMediator__ShowConfirmCancelImproveSpell
		          (int param1,int *param2,undefined4 param3)
		
		{
		  undefined4 in_register_20000014;
		  int param2_00;
		  int iVar1;
		  uint uVar2;
		  undefined4 uVar3;
		  double param3_00;
		  undefined4 param4;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a5782f == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_MagicTowerModel__MagicTowerEvents__MagicTowerController__MagicTowerWindow__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Clans_Buildings_MagicTower_Controller_MagicTowerViewMediator___c__DisplayClass21_0__ShowAccelerateImroveSpell_b__0__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Gameplay_Clans_Buildings_MagicTower_Controller_MagicTowerViewMediator___c__DisplayClass21_0_TypeInfo
		              );
		    Mono_Security_ASN1__get_Item(&StringLiteral_25458);
		    DAT_ram_00a5782f = '\x01';
		  }
		  param2_00 = unnamed_function_1417
		                        (
		                        Gameplay_Clans_Buildings_MagicTower_Controller_MagicTowerViewMediator___c__DisplayClass21_0_TypeInfo
		                        );
		  *(int **)(param2_00 + 0xc) = param2;
		  *(int *)(param2_00 + 8) = param1;
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param2 + 0xf0) * 4))
		                    (param2,CONCAT44(in_register_20000014,*(undefined4 *)(*param2 + 0xf4)));
		  uVar2 = func_ii_8746(*(undefined4 *)(param2_00 + 0xc),0);
		  param3_00 = Core_Extensions_Dict_DictExt__GetIntParameter
		                        (*(undefined4 *)(*(int *)(param1 + 8) + 0xc),StringLiteral_25458,0);
		  param4 = *(undefined4 *)(*(int *)(*(int *)(*(int *)(param1 + 8) + 0x10) + 0x18) + 8);
		  uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar3,param2_00,
		             Method_Gameplay_Clans_Buildings_MagicTower_Controller_MagicTowerViewMediator___c__DisplayClass21_0__ShowAccelerateImroveSpell_b__0__
		             ,0);
		  param1_00 = 3;
		  if (iVar1 == 0) {
		    param1_00 = 1;
		  }
		  uVar3 = UI_Windows_ConfirmAccelerateWindow__Show(param1_00,(double)uVar2,param3_00,param4,uVar3,0)
		  ;
		  return uVar3;
		}
		*/

			return null;
		}

		// Token: 0x0600425C RID: 16988 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600425C")]
		[Address(RVA = "0x9110", Offset = "0x9110", VA = "0x9110")]
		private DialogWindow ShowAccelerateImroveSpell(SchoolSpellData spell)
		{
		/* --- GHIDRA: ShowAccelerateImroveSpell ---
		void Gameplay_Clans_Buildings_MagicTower_Controller_MagicTowerViewMediator__ShowAccelerateImroveSpell
		               (int *param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  undefined4 param1_00;
		  undefined4 param2_00;
		  
		  param1_00 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x14c));
		  param2_00 = UnityEngine_AndroidJavaObject___GetRawObject(param3,0);
		  Gameplay_Clans_Buildings_MagicTower_Controller_MagicTowerController__StartLearnSpellResultHandler
		            (param1_00,param2_00,param1);
		  return;
		}
		*/

			return null;
		}

		// Token: 0x04002493 RID: 9363
		[Token(Token = "0x4002493")]
		[FieldOffset(Offset = "0x18")]
		private SchoolSpellData _selectedSpell;

		// Token: 0x04002494 RID: 9364
		[Token(Token = "0x4002494")]
		[FieldOffset(Offset = "0x1C")]
		private SpellCurrentDescriptionTitledListElement _spellCurrentDescription;

		// Token: 0x04002495 RID: 9365
		[Token(Token = "0x4002495")]
		[FieldOffset(Offset = "0x20")]
		private SpellUpgradeTitledListElement _spellUpgradeElement;

		// Token: 0x04002496 RID: 9366
		[Token(Token = "0x4002496")]
		[FieldOffset(Offset = "0x24")]
		private ClanSpellUpgradeRequirementsTitledListElement _spellUpgradeRequirements;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_View ---
		void Gameplay_Clans_Buildings_MagicTower_Controller_MagicTowerViewMediator__set_View
		               (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 param1_00;
		  
		  param1_00 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x14c));
		  Gameplay_Clans_Buildings_MagicTower_Controller_MagicTowerController__AccelerateLearnSpellResultHandler
		            (param1_00,param2,param1);
		  return;
		}
		*/


		/* --- GHIDRA: set_Events ---
		void Gameplay_Clans_Buildings_MagicTower_Controller_MagicTowerViewMediator__set_Events
		               (int *param1,undefined4 param2)
		
		{
		  uint uVar1;
		  undefined4 uVar2;
		  undefined4 uVar3;
		  uint *puVar4;
		  int iVar5;
		  int *param1_00;
		  int iVar6;
		  int iVar7;
		  int *piVar8;
		  
		  iVar6 = 0;
		  if (DAT_ram_00a57829 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_MagicTowerModel__MagicTowerEvents__MagicTowerController__MagicTowerWindow__get_Model__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_uint__ClanSchoolSpellData__get_Values__
		              );
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_ToArray_ClanSchoolSpellData___);
		    Mono_Security_ASN1__get_Item(&Gameplay_Discounts_Model_IDiscountHandler_TypeInfo);
		    DAT_ram_00a57829 = '\x01';
		  }
		  iVar7 = *param1;
		  uVar2 = (**(code **)((ulonglong)*(uint *)(iVar7 + 0x158) * 4))
		                    (param1,*(undefined4 *)(iVar7 + 0x15c));
		  uVar3 = System_Collections_Generic_Dictionary_int__object___TryAdd
		                    (*(undefined4 *)(param1[2] + 0x1c),
		                     Method_System_Collections_Generic_Dictionary_uint__ClanSchoolSpellData__get_Values__
		                    );
		  uVar3 = func_ii_6295(uVar3,Method_System_Linq_Enumerable_ToArray_ClanSchoolSpellData___);
		  Gameplay_Clans_Buildings_MagicTower_View_MagicTowerWindow__OnClose(uVar2,uVar3,iVar7);
		  iVar7 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar5 = *(int *)(iVar7 + 0x4c);
		  iVar7 = *(int *)(iVar5 + 0xc);
		  if ((0 < iVar7) && (*(int *)(param1[2] + 0x18) != 0)) {
		    do {
		      param1_00 = *(int **)(param1[2] + 0x18);
		      if (param1_00 != (int *)0x0) {
		        uVar2 = *(undefined4 *)(iVar5 + iVar6 * 4 + 0x10);
		        iVar7 = *param1_00;
		        if (*(ushort *)(iVar7 + 0xb6) != 0) {
		          uVar1 = 0;
		          do {
		            piVar8 = (int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8);
		            if (Gameplay_Discounts_Model_IDiscountHandler_TypeInfo == *piVar8) {
		              puVar4 = (uint *)(iVar7 + piVar8[1] * 8 + 0xc0);
		              goto code_r0x80de598b;
		            }
		            uVar1 = uVar1 + 1;
		          } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		        }
		        puVar4 = (uint *)func_ii_1080(param1_00,Gameplay_Discounts_Model_IDiscountHandler_TypeInfo,0
		                                     );
		code_r0x80de598b:
		        (**(code **)((ulonglong)*puVar4 * 4))(param1_00,uVar2,puVar4[1]);
		        iVar7 = *(int *)(iVar5 + 0xc);
		      }
		      iVar6 = iVar6 + 1;
		    } while (iVar6 < iVar7);
		  }
		  return;
		}
		*/

}
