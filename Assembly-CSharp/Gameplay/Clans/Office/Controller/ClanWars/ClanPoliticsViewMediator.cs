using System;
using Core.MVC.Interfaces;
using Gameplay.Clans.Office.Events;
using Gameplay.Clans.Office.Model;
using Gameplay.Clans.Office.View.ClanWarsTab.ClanPoliticsTab;
using Il2CppDummyDll;
using MVC;
using MVC.Interfaces;
using Protocol.Common;
using UI.Elements.Filters.GenericFilter;

namespace Gameplay.Clans.Office.Controller.ClanWars
{
	// Token: 0x02000A80 RID: 2688
	[Token(Token = "0x2000A80")]
	public class ClanPoliticsViewMediator : AbstractViewMediator<ClanWarsOfficeModel, ClanWarsOfficeEvents, ClanWarsOfficeController, ClanPoliticsView>, IHideableMediator
	{
		// Token: 0x0600401F RID: 16415 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600401F")]
		[Address(RVA = "0x8ED9", Offset = "0x8ED9", VA = "0x8ED9")]
		public ClanPoliticsViewMediator(ClanWarsOfficeModel model, ClanWarsOfficeEvents events, ClanWarsOfficeController controller)
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Clans_Office_Controller_ClanWars_ClanPoliticsViewMediator___ctor
		               (int *param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  
		  if (DAT_ram_00a576e9 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_ClanWarsOfficeModel__ClanWarsOfficeEvents__ClanWarsOfficeController__ClanPoliticsView__set_View__
		              );
		    DAT_ram_00a576e9 = '\x01';
		  }
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar2 = Cysharp_Threading_Tasks_CancellationTokenExtensions___cctor(uVar1,0);
		  if (iVar2 != 0) {
		    Gameplay_Clans_Office_Controller_ClanWars_ClanPoliticsViewMediator__set_View(param1,param1);
		  }
		  param1[5] = param2;
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar2 = Cysharp_Threading_Tasks_CancellationTokenExtensions___cctor(uVar1,0);
		  if (iVar2 != 0) {
		    Gameplay_Clans_Office_Controller_ClanWars_ClanPoliticsViewMediator__ResetView(param1,param1);
		  }
		  return;
		}
		*/

		}

		// Token: 0x17000CAF RID: 3247
		// (set) Token: 0x06004020 RID: 16416 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000CAF")]
		public override ClanPoliticsView View
		{
			[Token(Token = "0x6004020")]
			[Address(RVA = "0x8EDA", Offset = "0x8EDA", VA = "0x8EDA", Slot = "20")]
			set
			{
			}
		}

		// Token: 0x06004021 RID: 16417 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004021")]
		[Address(RVA = "0x8EDB", Offset = "0x8EDB", VA = "0x8EDB")]
		private void ResetView()
		{
		/* --- GHIDRA: ResetView ---
		void Gameplay_Clans_Office_Controller_ClanWars_ClanPoliticsViewMediator__ResetView
		               (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 param1_00;
		  int *piVar3;
		  undefined4 uVar4;
		  
		  if (DAT_ram_00a576eb == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_ClanWarsOfficeModel__ClanWarsOfficeEvents__ClanWarsOfficeController__ClanPoliticsView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_SubFilterListElement__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_object__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Clans_Office_Controller_ClanWars_ClanPoliticsViewMediator_FilterSelectedEventHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Clans_Office_Controller_ClanWars_ClanPoliticsViewMediator_MoreItemsAfterNeededEventHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Clans_Office_Controller_ClanWars_ClanPoliticsViewMediator_MyZigguratButtonClickedEventHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Clans_Office_Controller_ClanWars_ClanPoliticsViewMediator_SearchButtonClickedEventHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Clans_Office_Controller_ClanWars_ClanPoliticsViewMediator_SubFilterClickedEventHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Clans_Office_Controller_ClanWars_ClanPoliticsViewMediator_ZigguratButtonClickedEventHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Elements_GenericList_SelectableListElement_ClanPolicyListElement_ClanPolicyListElementArgs__set_Data__
		              );
		    Mono_Security_ASN1__get_Item(&UnityEngine_Events_UnityAction_TypeInfo);
		    DAT_ram_00a576eb = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar4 = *(undefined4 *)(iVar1 + 0x18);
		  uVar2 = unnamed_function_1417(System_Action_SubFilterListElement__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,
		             Method_Gameplay_Clans_Office_Controller_ClanWars_ClanPoliticsViewMediator_SubFilterClickedEventHandler__
		             ,0);
		  UI_Elements_Filters_GenericFilter_GenericFilterView___ctor(uVar4,uVar2,0);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar4 = *(undefined4 *)(iVar1 + 0x14);
		  uVar2 = unnamed_function_1417(System_Action_object__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,
		             Method_Gameplay_Clans_Office_Controller_ClanWars_ClanPoliticsViewMediator_FilterSelectedEventHandler__
		             ,0);
		  UI_Elements_Filters_GenericFilter_FilterWithIconListElement_FilterWithIconData___ctor
		            (uVar4,uVar2,0);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar4 = *(undefined4 *)(*(int *)(iVar1 + 0x20) + 0xb4);
		  uVar2 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		  Utils_ObjectUtils__IsNotNull
		            (uVar2,param1,
		             Method_Gameplay_Clans_Office_Controller_ClanWars_ClanPoliticsViewMediator_SearchButtonClickedEventHandler__
		             ,0);
		  Gameplay_Boss_View_CaptainTab_BossInfoView__add_AttackButtonClickEvent(uVar4,uVar2,0);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar4 = *(undefined4 *)(*(int *)(*(int *)(*(int *)(iVar1 + 0x28) + 0x18) + 0x28) + 0xb4);
		  uVar2 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		  Utils_ObjectUtils__IsNotNull
		            (uVar2,param1,
		             Method_Gameplay_Clans_Office_Controller_ClanWars_ClanPoliticsViewMediator_ZigguratButtonClickedEventHandler__
		             ,0);
		  Gameplay_Boss_View_CaptainTab_BossInfoView__add_AttackButtonClickEvent(uVar4,uVar2,0);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar4 = *(undefined4 *)(*(int *)(iVar1 + 0x2c) + 0xb4);
		  uVar2 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		  Utils_ObjectUtils__IsNotNull
		            (uVar2,param1,
		             Method_Gameplay_Clans_Office_Controller_ClanWars_ClanPoliticsViewMediator_MyZigguratButtonClickedEventHandler__
		             ,0);
		  Gameplay_Boss_View_CaptainTab_BossInfoView__add_AttackButtonClickEvent(uVar4,uVar2,0);
		  uVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar4 = Gameplay_Clans_Office_View_ClanWarsTab_ClanPoliticsTab_ClanPoliticsView__get_MyZigguratButton
		                    (uVar2,0);
		  param1_00 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (param1_00,param1,
		             Method_Gameplay_Clans_Office_Controller_ClanWars_ClanPoliticsViewMediator_MoreItemsAfterNeededEventHandler__
		             ,0);
		  piVar3 = (int *)UnityEngine_UI_Image__set_sprite(uVar4,param1_00,0);
		  if ((piVar3 != (int *)0x0) && (System_Action_TypeInfo != *piVar3)) {
		    System_Activator__CreateInstance(piVar3,System_Action_TypeInfo);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  Gameplay_Clans_Office_View_ClanWarsTab_ClanPoliticsTab_ClanPoliticsView__get_MoreItemsAfterNeededEvent
		            (uVar2,piVar3,0);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  piVar3 = *(int **)(iVar1 + 0x14);
		  uVar2 = Gameplay_Clans_Office_Model_ClanWarsOfficeModel__GetTabBarData(param1[2],0);
		  iVar1 = *piVar3;
		  (**(code **)((ulonglong)*(uint *)(iVar1 + 0xe0) * 4))(piVar3,uVar2,*(undefined4 *)(iVar1 + 0xe4));
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  UI_Elements_Filters_GenericFilter_GenericSubFilterView__remove_ClickedEvent
		            (*(undefined4 *)(iVar1 + 0x18),*(undefined4 *)(param1[2] + 0x14),0);
		  param1[0xb] = 0;
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar2 = UI_Elements_Filters_GenericFilter_GenericSubFilterView__SelectByIndexSilent
		                    (*(undefined4 *)(iVar1 + 0x18),0,0);
		  Gameplay_Clans_Office_Controller_ClanWars_ClanPoliticsViewMediator__RequestFirstPolitics
		            (param1,uVar2,param1);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  func_ii_7635(*(undefined4 *)(iVar1 + 0x24),*(undefined4 *)(param1[2] + 0x28),
		               Method_UI_Elements_GenericList_SelectableListElement_ClanPolicyListElement_ClanPolicyListElementArgs__set_Data__
		              );
		  uVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar2 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (uVar2,0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar2,1,0);
		  return;
		}
		*/

		}

		// Token: 0x06004022 RID: 16418 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004022")]
		[Address(RVA = "0x8EDC", Offset = "0x8EDC", VA = "0x8EDC")]
		private void SetupView()
		{
		/* --- GHIDRA: SetupView ---
		void Gameplay_Clans_Office_Controller_ClanWars_ClanPoliticsViewMediator__SetupView
		               (int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  undefined4 in_register_20000014;
		  uint *puVar2;
		  undefined4 uVar3;
		  undefined8 param2_00;
		  int *param1_00;
		  int iVar4;
		  
		  if (DAT_ram_00a576ec == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_ClanWarsOfficeModel__ClanWarsOfficeEvents__ClanWarsOfficeController__ClanPoliticsView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a576ec = '\x01';
		  }
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  uVar1 = 0;
		  param1_00 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar4 = *param1_00;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0x110);
		        goto code_r0x80dcca17;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_00,Core_Gameplay_IGame_TypeInfo,10);
		code_r0x80dcca17:
		  uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(param1_00,CONCAT44(in_register_20000014,puVar2[1]));
		  param2_00 = Gameplay_World_Model_ClanData__set_ClanCultDic
		                        (*(undefined4 *)(*(int *)(param1 + 8) + 0x30),0);
		  Core_Gameplay_Managers_WorldManager__GoToUserIsleById(uVar3,param2_00,0);
		  uVar3 = System_Uri___ctor(0);
		  uVar3 = System_Globalization_TimeSpanFormat_FormatLiterals__get_Start(uVar3,0);
		  UI_Windows_PopupController__Close(uVar3,2,0);
		  return;
		}
		*/

		}

		// Token: 0x06004023 RID: 16419 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004023")]
		[Address(RVA = "0x8EDD", Offset = "0x8EDD", VA = "0x8EDD")]
		private void MyZigguratButtonClickedEventHandler()
		{
		/* --- GHIDRA: MyZigguratButtonClickedEventHandler ---
		void Gameplay_Clans_Office_Controller_ClanWars_ClanPoliticsViewMediator__MyZigguratButtonClickedEventHandler
		               (int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  undefined4 in_register_20000014;
		  uint *puVar2;
		  undefined4 uVar3;
		  undefined8 param2_00;
		  int *param1_00;
		  int iVar4;
		  
		  if (DAT_ram_00a576ed == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a576ed = '\x01';
		  }
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  uVar1 = 0;
		  param1_00 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar4 = *param1_00;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0x110);
		        goto code_r0x80dccb0d;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_00,Core_Gameplay_IGame_TypeInfo,10);
		code_r0x80dccb0d:
		  uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(param1_00,CONCAT44(in_register_20000014,puVar2[1]));
		  param2_00 = Gameplay_World_Model_ClanData__set_ClanCultDic
		                        (*(undefined4 *)(*(int *)(param1 + 0x28) + 0x1c),0);
		  Core_Gameplay_Managers_WorldManager__GoToUserIsleById(uVar3,param2_00,0);
		  uVar3 = System_Uri___ctor(0);
		  uVar3 = System_Globalization_TimeSpanFormat_FormatLiterals__get_Start(uVar3,0);
		  UI_Windows_PopupController__Close(uVar3,2,0);
		  return;
		}
		*/

		}

		// Token: 0x06004024 RID: 16420 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004024")]
		[Address(RVA = "0x8EDE", Offset = "0x8EDE", VA = "0x8EDE")]
		private void ZigguratButtonClickedEventHandler()
		{
		/* --- GHIDRA: ZigguratButtonClickedEventHandler ---
		void Gameplay_Clans_Office_Controller_ClanWars_ClanPoliticsViewMediator__ZigguratButtonClickedEventHandler
		               (int *param1,undefined4 param2)
		
		{
		  uint uVar1;
		  int *param1_00;
		  uint *puVar2;
		  undefined4 param1_01;
		  int iVar3;
		  
		  if (DAT_ram_00a576ee == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_ClanWarsOfficeModel__ClanWarsOfficeEvents__ClanWarsOfficeController__ClanPoliticsView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               System_Collections_Generic_ICollection_ClanPolicyListElement_ClanPolicyListElementArgs__TypeInfo
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Stack_IList_ClanPolicyListElement_ClanPolicyListElementArgs___Peek__
		              );
		    DAT_ram_00a576ee = '\x01';
		  }
		  param1_00 = (int *)Newtonsoft_Json_Utilities_ThreadSafeStore_object__object___Get
		                               (*(undefined4 *)(param1[2] + 0x18),
		                                Method_System_Collections_Generic_Stack_IList_ClanPolicyListElement_ClanPolicyListElementArgs___Peek__
		                               );
		  iVar3 = *param1_00;
		  if (*(ushort *)(iVar3 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (System_Collections_Generic_ICollection_ClanPolicyListElement_ClanPolicyListElementArgs__TypeInfo
		          == *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(iVar3 + *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x80dccbff;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_00,
		                                System_Collections_Generic_ICollection_ClanPolicyListElement_ClanPolicyListElementArgs__TypeInfo
		                                ,0);
		code_r0x80dccbff:
		  iVar3 = (**(code **)((ulonglong)*puVar2 * 4))(param1_00,puVar2[1]);
		  param1_01 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x15c));
		  Gameplay_Clans_Office_View_ClanWarsTab_ClanPoliticsTab_ClanPoliticsView__Add
		            (param1_01,(uint)(iVar3 == 100),0);
		  return;
		}
		*/

		}

		// Token: 0x06004025 RID: 16421 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004025")]
		[Address(RVA = "0x8EDF", Offset = "0x8EDF", VA = "0x8EDF")]
		private void UpdateOSARequestBounds()
		{
		/* --- GHIDRA: UpdateOSARequestBounds ---
		void Gameplay_Clans_Office_Controller_ClanWars_ClanPoliticsViewMediator__UpdateOSARequestBounds
		               (int *param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  undefined4 param4;
		  int iVar3;
		  int param2_00;
		  undefined8 param3;
		  
		  if (DAT_ram_00a576ef == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_ClanWarsOfficeModel__ClanWarsOfficeEvents__ClanWarsOfficeController__ClanPoliticsView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Linq_Enumerable_Last_ClanPolicyListElement_ClanPolicyListElementArgs___
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Stack_IList_ClanPolicyListElement_ClanPolicyListElementArgs___Peek__
		              );
		    DAT_ram_00a576ef = '\x01';
		  }
		  uVar1 = Newtonsoft_Json_Utilities_ThreadSafeStore_object__object___Get
		                    (*(undefined4 *)(param1[2] + 0x18),
		                     Method_System_Collections_Generic_Stack_IList_ClanPolicyListElement_ClanPolicyListElementArgs___Peek__
		                    );
		  iVar2 = System_Linq_Enumerable__IntersectIterator___Il2CppFullySharedGenericType_
		                    (uVar1,
		                     Method_System_Linq_Enumerable_Last_ClanPolicyListElement_ClanPolicyListElementArgs___
		                    );
		  iVar3 = param1[0xb];
		  iVar2 = *(int *)(*(int *)(iVar2 + 0x1c) + 0x1c);
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x14c));
		  param2_00 = param1[9];
		  param3 = *(undefined8 *)(iVar2 + 0x10);
		  param4 = Core_Extensions_ClanInfoExt__GetClanRating(iVar2,0);
		  Gameplay_Clans_Office_Controller_ClanWars_ClanWarsOfficeController__GetSeasonBankDistributionResultHandler
		            (uVar1,param2_00,param3,param4,param1[7],(uint)(iVar3 == 2),0,100,param1);
		  return;
		}
		*/

		}

		// Token: 0x06004026 RID: 16422 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004026")]
		[Address(RVA = "0x8EE0", Offset = "0x8EE0", VA = "0x8EE0")]
		private void MoreItemsAfterNeededEventHandler()
		{
		/* --- GHIDRA: MoreItemsAfterNeededEventHandler ---
		void Gameplay_Clans_Office_Controller_ClanWars_ClanPoliticsViewMediator__MoreItemsAfterNeededEventHandler
		               (int *param1,int *param2,undefined4 param3)
		
		{
		  int *piVar1;
		  undefined4 param1_00;
		  int iVar2;
		  
		  if (DAT_ram_00a576f0 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_Clans_Office_Model_ClanWarsOfficeModel_ClanPolicyFilter_TypeInfo);
		    DAT_ram_00a576f0 = '\x01';
		  }
		  if (param2 == (int *)0x0) {
		    System_Collections_Generic_Comparer_ValueTuple_int__Int32Enum__object____get_Default();
		    do {
		      halt_trap();
		    } while( true );
		  }
		  if (*(int *)(*param2 + 0x20) !=
		      *(int *)(Gameplay_Clans_Office_Model_ClanWarsOfficeModel_ClanPolicyFilter_TypeInfo + 0x20)) {
		    System_Activator__CreateInstance
		              (param2,Gameplay_Clans_Office_Model_ClanWarsOfficeModel_ClanPolicyFilter_TypeInfo);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  piVar1 = (int *)func_ii_15774(param2);
		  iVar2 = *piVar1;
		  param1[0xb] = iVar2;
		  if (iVar2 == 1) {
		    Gameplay_Clans_Office_Controller_ClanWars_ClanPoliticsViewMediator__FilterSelectedEventHandler
		              (param1,param1);
		    return;
		  }
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar2 = func_ii_7457(*(undefined4 *)(iVar2 + 0x1c),0);
		  param1[7] = iVar2;
		  iVar2 = param1[0xb];
		  param1_00 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x14c));
		  Gameplay_Clans_Office_Controller_ClanWars_ClanWarsOfficeController__RequestPoliticsResultHandler
		            (param1_00,param1[9],param1[7],(uint)(iVar2 == 2),(uint)(iVar2 == 1),100,param1);
		  return;
		}
		*/

		}

		// Token: 0x06004027 RID: 16423 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004027")]
		[Address(RVA = "0x8EE1", Offset = "0x8EE1", VA = "0x8EE1")]
		private void FilterSelectedEventHandler(object data)
		{
		/* --- GHIDRA: FilterSelectedEventHandler ---
		void Gameplay_Clans_Office_Controller_ClanWars_ClanPoliticsViewMediator__FilterSelectedEventHandler
		               (int param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  longlong lVar3;
		  int iVar4;
		  int local_4;
		  
		  if (DAT_ram_00a576f1 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_ClanWarsOfficeModel__ClanWarsOfficeEvents__ClanWarsOfficeController__ClanPoliticsView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Protocol_ClanWar_ProtoRequestClanPolicyAns_Types_PolicyInfo___TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Protocol_ClanWar_ProtoRequestClanPolicyAns_Types_PolicyInfo_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Common_ResourceSet_TypeInfo);
		    DAT_ram_00a576f1 = '\x01';
		  }
		  local_4 = 0;
		  iVar1 = Gameplay_Clans_ClanWars_Model_ClanWarsModel___ctor
		                    (*(undefined4 *)(*(int *)(param1 + 8) + 0x2c),&local_4,0);
		  iVar4 = *(int *)(param1 + 8);
		  if (iVar1 == 0) {
		    uVar2 = Mono_Security_ASN1Convert__ToOid
		                      (Protocol_ClanWar_ProtoRequestClanPolicyAns_Types_PolicyInfo___TypeInfo,0);
		    Gameplay_Clans_Office_Model_ClanWarsOfficeModel__GetSeasonLeagueRewards(iVar4,uVar2,0);
		  }
		  else {
		    lVar3 = Gameplay_Clans_ClanWars_Model_ClanWarsModel__get_CurrenSeasonLeagueDic
		                      (*(undefined4 *)(iVar4 + 0x2c),0);
		    iVar1 = *(int *)(*(int *)(local_4 + 0xc) + 0x10);
		    if (lVar3 != *(longlong *)(iVar1 + 0x10)) {
		      iVar1 = *(int *)(*(int *)(local_4 + 0xc) + 0x14);
		    }
		    iVar4 = unnamed_function_1417
		                      (Protocol_ClanWar_ProtoRequestClanPolicyAns_Types_PolicyInfo_TypeInfo);
		    *(int *)(iVar4 + 0xc) = iVar1;
		    uVar2 = unnamed_function_1417(Protocol_Common_ResourceSet_TypeInfo);
		    *(undefined4 *)(iVar4 + 0x18) = uVar2;
		    uVar2 = *(undefined4 *)(param1 + 8);
		    iVar1 = Mono_Security_ASN1Convert__ToOid
		                      (Protocol_ClanWar_ProtoRequestClanPolicyAns_Types_PolicyInfo___TypeInfo,1);
		    *(int *)(iVar1 + 0x10) = iVar4;
		    Gameplay_Clans_Office_Model_ClanWarsOfficeModel__GetSeasonLeagueRewards(uVar2,iVar1,0);
		  }
		  Gameplay_Clans_Office_Controller_ClanWars_ClanPoliticsViewMediator__PoliticsAddedEventHandler
		            (param1,param1);
		  return;
		}
		*/

		}

		// Token: 0x06004028 RID: 16424 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004028")]
		[Address(RVA = "0x8EE2", Offset = "0x8EE2", VA = "0x8EE2")]
		private void FakeRequestCurrentWar()
		{
		}

		// Token: 0x06004029 RID: 16425 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004029")]
		[Address(RVA = "0x8EE3", Offset = "0x8EE3", VA = "0x8EE3")]
		private void SearchButtonClickedEventHandler()
		{
		/* --- GHIDRA: SearchButtonClickedEventHandler ---
		void Gameplay_Clans_Office_Controller_ClanWars_ClanPoliticsViewMediator__SearchButtonClickedEventHandler
		               (int *param1,int param2,undefined4 param3)
		
		{
		  undefined4 param1_00;
		  undefined4 param4;
		  int iVar1;
		  int param2_00;
		  undefined8 param3_00;
		  
		  iVar1 = param1[0xb];
		  param1_00 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x14c));
		  param2_00 = param1[9];
		  param3_00 = *(undefined8 *)(param2 + 0x10);
		  param4 = Core_Extensions_ClanInfoExt__GetClanRating(param2,0);
		  Gameplay_Clans_Office_Controller_ClanWars_ClanWarsOfficeController__GetSeasonBankDistributionResultHandler
		            (param1_00,param2_00,param3_00,param4,param1[7],(uint)(iVar1 == 2),0,100,param1);
		  return;
		}
		*/

		}

		// Token: 0x0600402A RID: 16426 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600402A")]
		[Address(RVA = "0x8EE4", Offset = "0x8EE4", VA = "0x8EE4")]
		private void RequestPolitics(ClanInfo lastClanInfo)
		{
		/* --- GHIDRA: RequestPolitics ---
		void Gameplay_Clans_Office_Controller_ClanWars_ClanPoliticsViewMediator__RequestPolitics
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  Gameplay_VortexRating_View_GreatPrizesTab_FilterListElement__set_Data
		            (*(undefined4 *)(param1 + 0x20),0,0);
		  Gameplay_Clans_Office_Controller_ClanWars_ClanPoliticsViewMediator__RequestFirstPolitics
		            (param1,param2,param1);
		  return;
		}
		*/

		}

		// Token: 0x0600402B RID: 16427 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600402B")]
		[Address(RVA = "0x8EE5", Offset = "0x8EE5", VA = "0x8EE5")]
		private void SubFilterClickedEventHandler(SubFilterListElement element)
		{
		/* --- GHIDRA: SubFilterClickedEventHandler ---
		void Gameplay_Clans_Office_Controller_ClanWars_ClanPoliticsViewMediator__SubFilterClickedEventHandler
		               (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 param1_00;
		  
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar1 = func_ii_7457(*(undefined4 *)(iVar1 + 0x1c),0);
		  param1[7] = iVar1;
		  iVar1 = param1[0xb];
		  param1_00 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x14c));
		  Gameplay_Clans_Office_Controller_ClanWars_ClanWarsOfficeController__RequestPoliticsResultHandler
		            (param1_00,param1[9],param1[7],(uint)(iVar1 == 2),(uint)(iVar1 == 1),100,param1);
		  return;
		}
		*/

		}

		// Token: 0x0600402C RID: 16428 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600402C")]
		[Address(RVA = "0x8EE6", Offset = "0x8EE6", VA = "0x8EE6")]
		private void RequestFirstPolitics()
		{
		/* --- GHIDRA: RequestFirstPolitics ---
		void Gameplay_Clans_Office_Controller_ClanWars_ClanPoliticsViewMediator__RequestFirstPolitics
		               (int *param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int *param1_00;
		  int iVar2;
		  
		  if (DAT_ram_00a576f2 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_ClanWarsOfficeModel__ClanWarsOfficeEvents__ClanWarsOfficeController__ClanPoliticsView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&Protocol_Dic_ClanLeagueDic_TypeInfo);
		    DAT_ram_00a576f2 = '\x01';
		  }
		  param1_00 = *(int **)(param2 + 0x20);
		  if ((param1_00 != (int *)0x0) && (Protocol_Dic_ClanLeagueDic_TypeInfo != *param1_00)) {
		    System_Activator__CreateInstance(param1_00,Protocol_Dic_ClanLeagueDic_TypeInfo);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  iVar2 = param1_00[3];
		  param1[8] = param2;
		  param1[9] = iVar2;
		  Gameplay_VortexRating_View_GreatPrizesTab_FilterListElement__set_Data(param2,1,0);
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar1 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (*(undefined4 *)(*(int *)(iVar2 + 0x24) + 0x28),0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar1,(uint)(param1_00[3] ==
		                         *(int *)(*(int *)(*(int *)(param1[2] + 0x30) + 0x20) + 0xc)),0);
		  if (param1[0xb] == 1) {
		    Gameplay_Clans_Office_Controller_ClanWars_ClanPoliticsViewMediator__FilterSelectedEventHandler
		              (param1,param1);
		    return;
		  }
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar2 = func_ii_7457(*(undefined4 *)(iVar2 + 0x1c),0);
		  param1[7] = iVar2;
		  iVar2 = param1[0xb];
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x14c));
		  Gameplay_Clans_Office_Controller_ClanWars_ClanWarsOfficeController__RequestPoliticsResultHandler
		            (uVar1,param1[9],param1[7],(uint)(iVar2 == 2),(uint)(iVar2 == 1),100,param1);
		  return;
		}
		*/

		}

		// Token: 0x0600402D RID: 16429 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600402D")]
		[Address(RVA = "0x8EE7", Offset = "0x8EE7", VA = "0x8EE7")]
		private void SelectFilter(SubFilterListElement element)
		{
		/* --- GHIDRA: SelectFilter ---
		void Gameplay_Clans_Office_Controller_ClanWars_ClanPoliticsViewMediator__SelectFilter
		               (int *param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  int iVar2;
		  undefined4 uVar3;
		  int *piVar4;
		  undefined4 uVar5;
		  
		  if (DAT_ram_00a576f3 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_ClanWarsOfficeModel__ClanWarsOfficeEvents__ClanWarsOfficeController__ClanPoliticsView__set_Events__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Clans_Office_Controller_ClanWars_ClanPoliticsViewMediator_FirstPoliticsRequestedEventHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Clans_Office_Controller_ClanWars_ClanPoliticsViewMediator_PoliticsAddedEventHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Clans_Office_Controller_ClanWars_ClanPoliticsViewMediator_WarStateChangedEventHandler__
		              );
		    DAT_ram_00a576f3 = '\x01';
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
		               Method_Gameplay_Clans_Office_Controller_ClanWars_ClanPoliticsViewMediator_FirstPoliticsRequestedEventHandler__
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
		               Method_Gameplay_Clans_Office_Controller_ClanWars_ClanPoliticsViewMediator_PoliticsAddedEventHandler__
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
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    iVar2 = *(int *)(iVar1 + 0x14);
		    uVar5 = *(undefined4 *)(iVar2 + 0x14);
		    uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar3,param1,
		               Method_Gameplay_Clans_Office_Controller_ClanWars_ClanPoliticsViewMediator_WarStateChangedEventHandler__
		               ,0);
		    piVar4 = (int *)func_ii_7048(uVar5,uVar3,0);
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
		               Method_Gameplay_Clans_Office_Controller_ClanWars_ClanPoliticsViewMediator_FirstPoliticsRequestedEventHandler__
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
		               Method_Gameplay_Clans_Office_Controller_ClanWars_ClanPoliticsViewMediator_PoliticsAddedEventHandler__
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
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    iVar2 = *(int *)(iVar1 + 0x14);
		    uVar5 = *(undefined4 *)(iVar2 + 0x14);
		    uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar3,param1,
		               Method_Gameplay_Clans_Office_Controller_ClanWars_ClanPoliticsViewMediator_WarStateChangedEventHandler__
		               ,0);
		    piVar4 = (int *)UnityEngine_UI_Image__set_sprite(uVar5,uVar3,0);
		    iVar1 = System_Action_TypeInfo;
		    if (piVar4 == (int *)0x0) {
		      *(undefined4 *)(iVar2 + 0x14) = 0;
		      return;
		    }
		    if ((System_Action_TypeInfo != *piVar4) || (*(int **)(iVar2 + 0x14) = piVar4, *piVar4 != iVar1))
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

		// Token: 0x17000CB0 RID: 3248
		// (set) Token: 0x0600402E RID: 16430 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000CB0")]
		public override ClanWarsOfficeEvents Events
		{
			[Token(Token = "0x600402E")]
			[Address(RVA = "0x8EE8", Offset = "0x8EE8", VA = "0x8EE8", Slot = "16")]
			set
			{
			}
		}

		// Token: 0x0600402F RID: 16431 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600402F")]
		[Address(RVA = "0x8EE9", Offset = "0x8EE9", VA = "0x8EE9")]
		private void WarStateChangedEventHandler()
		{
		/* --- GHIDRA: WarStateChangedEventHandler ---
		void Gameplay_Clans_Office_Controller_ClanWars_ClanPoliticsViewMediator__WarStateChangedEventHandler
		               (undefined4 param1,undefined4 param2)
		
		{
		  Gameplay_Clans_Office_Controller_ClanWars_ClanPoliticsViewMediator__UpdateWarState(param1,param1);
		  return;
		}
		*/

		}

		// Token: 0x06004030 RID: 16432 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004030")]
		[Address(RVA = "0x8EEA", Offset = "0x8EEA", VA = "0x8EEA")]
		private void UpdateWarState()
		{
		/* --- GHIDRA: UpdateWarState ---
		void Gameplay_Clans_Office_Controller_ClanWars_ClanPoliticsViewMediator__UpdateWarState
		               (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  uint *puVar2;
		  longlong lVar3;
		  int *piVar4;
		  int iVar5;
		  undefined4 param4;
		  undefined4 param5;
		  undefined4 uVar6;
		  undefined4 uVar7;
		  longlong lVar8;
		  uint uVar9;
		  
		  if (DAT_ram_00a576f4 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_ClanWarsOfficeModel__ClanWarsOfficeEvents__ClanWarsOfficeController__ClanPoliticsView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_Clans_Office_Controller_ClanWars_AttackerWarStatusViewMediator_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_Clans_Office_Controller_ClanWars_DefenderWarStatusViewMediator_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_MVC_Interfaces_IViewMediator_ClanWarStatusView__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_MVC_Interfaces_IViewMediator_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_Clans_Office_Controller_ClanWars_TruceStatusViewMediator_TypeInfo);
		    DAT_ram_00a576f4 = '\x01';
		  }
		  lVar8 = *(longlong *)(*(int *)(*(int *)(param1[10] + 0x1c) + 0x1c) + 0x10);
		  lVar3 = Gameplay_Clans_ClanWars_Model_ClanWarsModel__get_CurrenSeasonLeagueDic
		                    (*(undefined4 *)(param1[2] + 0x2c),0);
		  piVar4 = (int *)param1[6];
		  if (piVar4 != (int *)0x0) {
		    uVar9 = 0;
		    iVar5 = *piVar4;
		    if (*(ushort *)(iVar5 + 0xb6) != 0) {
		      do {
		        if (Core_MVC_Interfaces_IViewMediator_TypeInfo ==
		            *(int *)(*(int *)(iVar5 + 0x58) + uVar9 * 8)) {
		          puVar2 = (uint *)(iVar5 + *(int *)(*(int *)(iVar5 + 0x58) + uVar9 * 8 + 4) * 8 + 0xc0);
		          goto code_r0x80dcd681;
		        }
		        uVar9 = uVar9 + 1;
		      } while (*(ushort *)(iVar5 + 0xb6) != uVar9);
		    }
		    puVar2 = (uint *)func_ii_1080(piVar4,Core_MVC_Interfaces_IViewMediator_TypeInfo,0);
		code_r0x80dcd681:
		    (**(code **)((ulonglong)*puVar2 * 4))(piVar4,puVar2[1]);
		  }
		  iVar5 = *(int *)(param1[2] + 0x2c);
		  if (lVar8 == lVar3) {
		    lVar8 = *(longlong *)(*(int *)(*(int *)(iVar5 + 0x14) + 0x10) + 0x10);
		    lVar3 = Gameplay_Clans_ClanWars_Model_ClanWarsModel__get_CurrenSeasonLeagueDic(iVar5,0);
		    uVar6 = *(undefined4 *)(param1[2] + 0x2c);
		    iVar5 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar7 = *(undefined4 *)(iVar5 + 0x14);
		    iVar5 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x14c));
		    param4 = *(undefined4 *)(iVar5 + 0x18);
		    param5 = *(undefined4 *)(*(int *)(*(int *)(param1[10] + 0x1c) + 0x1c) + 0x18);
		    if (lVar8 == lVar3) {
		      piVar4 = (int *)unnamed_function_1417
		                                (
		                                Gameplay_Clans_Office_Controller_ClanWars_DefenderWarStatusViewMediator_TypeInfo
		                                );
		      Gameplay_Clans_Office_Controller_ClanWars_TruceStatusViewMediator__AttackButtonClickedEventHandler
		                (piVar4,uVar6,uVar7,param4,param5,uVar6);
		    }
		    else {
		      piVar4 = (int *)unnamed_function_1417
		                                (
		                                Gameplay_Clans_Office_Controller_ClanWars_AttackerWarStatusViewMediator_TypeInfo
		                                );
		      Gameplay_Clans_Office_Controller_ClanWars_TruceStatusViewMediator__AttackButtonClickedEventHandler
		                (piVar4,uVar6,uVar7,param4,param5,uVar6);
		    }
		  }
		  else {
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar6 = *(undefined4 *)(iVar1 + 0x14);
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x14c));
		    uVar7 = *(undefined4 *)(iVar1 + 0x18);
		    iVar1 = param1[10];
		    piVar4 = (int *)unnamed_function_1417
		                              (
		                              Gameplay_Clans_Office_Controller_ClanWars_TruceStatusViewMediator_TypeInfo
		                              );
		    if (DAT_ram_00a57733 == '\0') {
		      Mono_Security_ASN1__get_Item
		                (&
		                 Method_MVC_AbstractViewMediator_ClanWarsModel__ClanWarsEvents__ClanWarsController__ClanWarStatusView___ctor__
		                );
		      DAT_ram_00a57733 = '\x01';
		    }
		    Gameplay_Combat_TeamCombat_View_AbstractTeamCombatView_object___get_HideInstantElements
		              (piVar4,iVar5,uVar6,uVar7,
		               Method_MVC_AbstractViewMediator_ClanWarsModel__ClanWarsEvents__ClanWarsController__ClanWarStatusView___ctor__
		              );
		    piVar4[6] = iVar1;
		  }
		  param1[6] = (int)piVar4;
		  iVar5 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar6 = *(undefined4 *)(*(int *)(iVar5 + 0x28) + 0x18);
		  uVar9 = 0;
		  iVar5 = *piVar4;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    do {
		      if (Core_MVC_Interfaces_IViewMediator_ClanWarStatusView__TypeInfo ==
		          *(int *)(*(int *)(iVar5 + 0x58) + uVar9 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar9 * 8 + 4) * 8 + iVar5 + 200);
		        goto code_r0x80dcd866;
		      }
		      uVar9 = uVar9 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar9);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar4,Core_MVC_Interfaces_IViewMediator_ClanWarStatusView__TypeInfo
		                                ,1);
		code_r0x80dcd866:
		  (**(code **)((ulonglong)*puVar2 * 4))(piVar4,uVar6,puVar2[1]);
		  return;
		}
		*/

		}

		// Token: 0x06004031 RID: 16433 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004031")]
		[Address(RVA = "0x8EEB", Offset = "0x8EEB", VA = "0x8EEB")]
		private void CheckForWarState()
		{
		/* --- GHIDRA: CheckForWarState ---
		void Gameplay_Clans_Office_Controller_ClanWars_ClanPoliticsViewMediator__CheckForWarState
		               (int *param1,undefined4 param2)
		
		{
		  undefined4 param2_00;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a576f5 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_ClanWarsOfficeModel__ClanWarsOfficeEvents__ClanWarsOfficeController__ClanPoliticsView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Stack_IList_ClanPolicyListElement_ClanPolicyListElementArgs___Peek__
		              );
		    DAT_ram_00a576f5 = '\x01';
		  }
		  Gameplay_Clans_Office_Controller_ClanWars_ClanPoliticsViewMediator__SelectArgs(param1,param1);
		  Gameplay_Clans_Office_Controller_ClanWars_ClanPoliticsViewMediator__ZigguratButtonClickedEventHandler
		            (param1,param1);
		  param2_00 = Newtonsoft_Json_Utilities_ThreadSafeStore_object__object___Get
		                        (*(undefined4 *)(param1[2] + 0x18),
		                         Method_System_Collections_Generic_Stack_IList_ClanPolicyListElement_ClanPolicyListElementArgs___Peek__
		                        );
		  param1_00 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x15c));
		  Gameplay_Clans_Office_View_ClanWarsTab_ClanPoliticsTab_ClanPoliticsView__Init
		            (param1_00,param2_00,0);
		  return;
		}
		*/

		}

		// Token: 0x06004032 RID: 16434 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004032")]
		[Address(RVA = "0x8EEC", Offset = "0x8EEC", VA = "0x8EEC")]
		private void PoliticsAddedEventHandler()
		{
		/* --- GHIDRA: PoliticsAddedEventHandler ---
		void Gameplay_Clans_Office_Controller_ClanWars_ClanPoliticsViewMediator__PoliticsAddedEventHandler
		               (int *param1,undefined4 param2)
		
		{
		  uint uVar1;
		  int *param2_00;
		  undefined4 param1_00;
		  uint *puVar2;
		  int iVar3;
		  int iVar4;
		  
		  if (DAT_ram_00a576f6 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_ClanWarsOfficeModel__ClanWarsOfficeEvents__ClanWarsOfficeController__ClanPoliticsView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               System_Collections_Generic_ICollection_ClanPolicyListElement_ClanPolicyListElementArgs__TypeInfo
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               System_Collections_Generic_IList_ClanPolicyListElement_ClanPolicyListElementArgs__TypeInfo
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Stack_IList_ClanPolicyListElement_ClanPolicyListElementArgs___Peek__
		              );
		    DAT_ram_00a576f6 = '\x01';
		  }
		  Gameplay_Clans_Office_Controller_ClanWars_ClanPoliticsViewMediator__SelectArgs(param1,0);
		  Gameplay_Clans_Office_Controller_ClanWars_ClanPoliticsViewMediator__ZigguratButtonClickedEventHandler
		            (param1,0);
		  param2_00 = (int *)Newtonsoft_Json_Utilities_ThreadSafeStore_object__object___Get
		                               (*(undefined4 *)(param1[2] + 0x18),
		                                Method_System_Collections_Generic_Stack_IList_ClanPolicyListElement_ClanPolicyListElementArgs___Peek__
		                               );
		  param1_00 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x15c));
		  Gameplay_Clans_Office_View_ClanWarsTab_ClanPoliticsTab_ClanPoliticsView__set_MoreItemsAfterNeededEvent
		            (param1_00,param2_00,0);
		  iVar4 = *param2_00;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (System_Collections_Generic_ICollection_ClanPolicyListElement_ClanPolicyListElementArgs__TypeInfo
		          == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(iVar4 + *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x80dccfac;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param2_00,
		                                System_Collections_Generic_ICollection_ClanPolicyListElement_ClanPolicyListElementArgs__TypeInfo
		                                ,0);
		code_r0x80dccfac:
		  iVar4 = (**(code **)((ulonglong)*puVar2 * 4))(param2_00,puVar2[1]);
		  if (0 < iVar4) {
		    uVar1 = 0;
		    iVar4 = *param2_00;
		    if (*(ushort *)(iVar4 + 0xb6) != 0) {
		      do {
		        if (System_Collections_Generic_IList_ClanPolicyListElement_ClanPolicyListElementArgs__TypeInfo
		            == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		          puVar2 = (uint *)(iVar4 + *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		          goto code_r0x80dcd02f;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		    }
		    puVar2 = (uint *)func_ii_1080(param2_00,
		                                  System_Collections_Generic_IList_ClanPolicyListElement_ClanPolicyListElementArgs__TypeInfo
		                                  ,0);
		code_r0x80dcd02f:
		    iVar4 = (**(code **)((ulonglong)*puVar2 * 4))(param2_00,0,puVar2[1]);
		    if (DAT_ram_00a576f8 == '\0') {
		      Mono_Security_ASN1__get_Item
		                (&
		                 Method_MVC_AbstractViewMediator_ClanWarsOfficeModel__ClanWarsOfficeEvents__ClanWarsOfficeController__ClanPoliticsView__get_Model__
		                );
		      DAT_ram_00a576f8 = '\x01';
		    }
		    param1[10] = iVar4;
		    Gameplay_Clans_Office_View_ClanMembersTab_ClanMemberListElement_ClanMemberListElementArgs__get_Selected
		              (iVar4,1,0);
		    iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    Gameplay_Clans_Office_View_ClanWarsTab_ClanPoliticsTab_ClanPolicyInfoBox__get_WarStatusView
		              (*(undefined4 *)(iVar3 + 0x28),*(undefined4 *)(iVar4 + 0x1c),
		               *(undefined4 *)(param1[2] + 0x10),0);
		    Gameplay_Clans_Office_Controller_ClanWars_ClanPoliticsViewMediator__UpdateWarState(param1,iVar4)
		    ;
		  }
		  return;
		}
		*/

		}

		// Token: 0x06004033 RID: 16435 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004033")]
		[Address(RVA = "0x8EED", Offset = "0x8EED", VA = "0x8EED")]
		private void FirstPoliticsRequestedEventHandler()
		{
		/* --- GHIDRA: FirstPoliticsRequestedEventHandler ---
		void Gameplay_Clans_Office_Controller_ClanWars_ClanPoliticsViewMediator__FirstPoliticsRequestedEventHandler
		               (int *param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  int param1_00;
		  
		  if (DAT_ram_00a576f7 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Elements_GenericList_GenericListElement_ClanPolicyListElement_ClanPolicyListElementArgs__get_args__
		              );
		    DAT_ram_00a576f7 = '\x01';
		  }
		  Gameplay_Clans_Office_View_ClanMembersTab_ClanMemberListElement_ClanMemberListElementArgs__get_Selected
		            (param1[10],0,0);
		  param1_00 = *(int *)(param2 + 0x18);
		  if (DAT_ram_00a576f8 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_ClanWarsOfficeModel__ClanWarsOfficeEvents__ClanWarsOfficeController__ClanPoliticsView__get_Model__
		              );
		    DAT_ram_00a576f8 = '\x01';
		  }
		  param1[10] = param1_00;
		  Gameplay_Clans_Office_View_ClanMembersTab_ClanMemberListElement_ClanMemberListElementArgs__get_Selected
		            (param1_00,1,0);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  Gameplay_Clans_Office_View_ClanWarsTab_ClanPoliticsTab_ClanPolicyInfoBox__get_WarStatusView
		            (*(undefined4 *)(iVar1 + 0x28),*(undefined4 *)(param1_00 + 0x1c),
		             *(undefined4 *)(param1[2] + 0x10),0);
		  Gameplay_Clans_Office_Controller_ClanWars_ClanPoliticsViewMediator__UpdateWarState(param1,param1);
		  return;
		}
		*/

		}

		// Token: 0x06004034 RID: 16436 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004034")]
		[Address(RVA = "0x8EEE", Offset = "0x8EEE", VA = "0x8EEE")]
		private void ListElementClickedEventHandler(ClanPolicyListElement element)
		{
		/* --- GHIDRA: ListElementClickedEventHandler ---
		void Gameplay_Clans_Office_Controller_ClanWars_ClanPoliticsViewMediator__ListElementClickedEventHandler
		               (int *param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  
		  if (DAT_ram_00a576f8 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_ClanWarsOfficeModel__ClanWarsOfficeEvents__ClanWarsOfficeController__ClanPoliticsView__get_Model__
		              );
		    DAT_ram_00a576f8 = '\x01';
		  }
		  param1[10] = param2;
		  Gameplay_Clans_Office_View_ClanMembersTab_ClanMemberListElement_ClanMemberListElementArgs__get_Selected
		            (param2,1,0);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  Gameplay_Clans_Office_View_ClanWarsTab_ClanPoliticsTab_ClanPolicyInfoBox__get_WarStatusView
		            (*(undefined4 *)(iVar1 + 0x28),*(undefined4 *)(param2 + 0x1c),
		             *(undefined4 *)(param1[2] + 0x10),0);
		  Gameplay_Clans_Office_Controller_ClanWars_ClanPoliticsViewMediator__UpdateWarState(param1,param1);
		  return;
		}
		*/

		}

		// Token: 0x06004035 RID: 16437 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004035")]
		[Address(RVA = "0x8EEF", Offset = "0x8EEF", VA = "0x8EEF")]
		private void SelectArgs(ClanPolicyListElement.ClanPolicyListElementArgs args)
		{
		/* --- GHIDRA: SelectArgs ---
		void Gameplay_Clans_Office_Controller_ClanWars_ClanPoliticsViewMediator__SelectArgs
		               (int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  int *piVar2;
		  uint *puVar3;
		  undefined4 *puVar4;
		  undefined4 uVar5;
		  int iVar6;
		  int *piVar7;
		  int iVar8;
		  int local_c;
		  int **local_8;
		  int *local_4;
		  
		  if (DAT_ram_00a576f9 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_ClanWarsOfficeModel__ClanWarsOfficeEvents__ClanWarsOfficeController__ClanPoliticsView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_ClanPolicyListElement__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Clans_Office_Controller_ClanWars_ClanPoliticsViewMediator_ListElementClickedEventHandler__
		              );
		    Mono_Security_ASN1__get_Item(&System_IDisposable_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               System_Collections_Generic_IEnumerable_ClanPolicyListElement_ClanPolicyListElementArgs__TypeInfo
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               System_Collections_Generic_IEnumerator_ClanPolicyListElement_ClanPolicyListElementArgs__TypeInfo
		              );
		    Mono_Security_ASN1__get_Item(&System_Collections_IEnumerator_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Stack_IList_ClanPolicyListElement_ClanPolicyListElementArgs___Peek__
		              );
		    DAT_ram_00a576f9 = '\x01';
		  }
		  piVar2 = (int *)Newtonsoft_Json_Utilities_ThreadSafeStore_object__object___Get
		                            (*(undefined4 *)(*(int *)(param1 + 8) + 0x18),
		                             Method_System_Collections_Generic_Stack_IList_ClanPolicyListElement_ClanPolicyListElementArgs___Peek__
		                            );
		  iVar8 = *piVar2;
		  if (*(ushort *)(iVar8 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (System_Collections_Generic_IEnumerable_ClanPolicyListElement_ClanPolicyListElementArgs__TypeInfo
		          == *(int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(iVar8 + *(int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x80dcd1f1;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar8 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(piVar2,
		                                System_Collections_Generic_IEnumerable_ClanPolicyListElement_ClanPolicyListElementArgs__TypeInfo
		                                ,0);
		code_r0x80dcd1f1:
		  local_4 = (int *)(**(code **)((ulonglong)*puVar3 * 4))(piVar2,puVar3[1]);
		  local_c = 0;
		  local_8 = &local_4;
		  do {
		    piVar2 = local_4;
		    iVar8 = *local_4;
		    if (*(ushort *)(iVar8 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        piVar7 = (int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8);
		        if (System_Collections_IEnumerator_TypeInfo == *piVar7) {
		          puVar4 = (undefined4 *)(iVar8 + piVar7[1] * 8 + 0xc0);
		          goto code_r0x80dcd2bc;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar8 + 0xb6) != uVar1);
		    }
		    DAT_ram_009d3e38 = 0;
		    puVar4 = (undefined4 *)
		             import::env::invoke_iiii
		                       (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                        System_Collections_IEnumerator_TypeInfo,0);
		    if (DAT_ram_009d3e38 == 1) {
		code_r0x80dcd46c:
		      DAT_ram_009d3e38 = 0;
		      uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80dcd474;
		    }
		code_r0x80dcd2bc:
		    DAT_ram_009d3e38 = 0;
		    iVar8 = import::env::invoke_iii(*puVar4,piVar2,puVar4[1]);
		    piVar2 = local_4;
		    if (DAT_ram_009d3e38 == 1) goto code_r0x80dcd46c;
		    if (iVar8 == 0) {
		      iVar8 = 0;
		      goto code_r0x80dcd4bd;
		    }
		    iVar8 = *local_4;
		    if (*(ushort *)(iVar8 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        piVar7 = (int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8);
		        if (System_Collections_Generic_IEnumerator_ClanPolicyListElement_ClanPolicyListElementArgs__TypeInfo
		            == *piVar7) {
		          puVar4 = (undefined4 *)(iVar8 + piVar7[1] * 8 + 0xc0);
		          goto code_r0x80dcd396;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar8 + 0xb6) != uVar1);
		    }
		    DAT_ram_009d3e38 = 0;
		    puVar4 = (undefined4 *)
		             import::env::invoke_iiii
		                       (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                        System_Collections_Generic_IEnumerator_ClanPolicyListElement_ClanPolicyListElementArgs__TypeInfo
		                        ,0);
		    if (DAT_ram_009d3e38 == 1) {
		code_r0x80dcd458:
		      DAT_ram_009d3e38 = 0;
		      uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80dcd474;
		    }
		code_r0x80dcd396:
		    DAT_ram_009d3e38 = 0;
		    iVar8 = import::env::invoke_iii(*puVar4,piVar2,puVar4[1]);
		    if (DAT_ram_009d3e38 == 1) goto code_r0x80dcd458;
		    DAT_ram_009d3e38 = 0;
		    uVar5 = import::env::invoke_ii
		                      (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x199,
		                       System_Action_ClanPolicyListElement__TypeInfo);
		    if (DAT_ram_009d3e38 == 1) break;
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_viiii
		              (s_struct_Uniforms___color__array<v_ram_000017c8 + 0x241,uVar5,param1,
		               Method_Gameplay_Clans_Office_Controller_ClanWars_ClanPoliticsViewMediator_ListElementClickedEventHandler__
		               ,0);
		    if (DAT_ram_009d3e38 == 1) break;
		    *(undefined4 *)(iVar8 + 0x18) = uVar5;
		  } while( true );
		  DAT_ram_009d3e38 = 0;
		  uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x80dcd474:
		  iVar8 = global_1;
		  iVar6 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar8 == iVar6) {
		    piVar2 = (int *)import::env::__cxa_begin_catch(uVar5);
		    iVar8 = *piVar2;
		    DAT_ram_009d3e38 = 0;
		    local_c = iVar8;
		    import::env::invoke_v(0x123);
		    iVar6 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar6 != 1) {
		code_r0x80dcd4bd:
		      piVar2 = local_4;
		      DAT_ram_009d3e38 = 0;
		      if (local_4 != (int *)0x0) {
		        uVar1 = 0;
		        iVar6 = *local_4;
		        if (*(ushort *)(iVar6 + 0xb6) != 0) {
		          do {
		            if (System_IDisposable_TypeInfo == *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8)) {
		              puVar3 = (uint *)(iVar6 + *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0)
		              ;
		              goto code_r0x80dcd535;
		            }
		            uVar1 = uVar1 + 1;
		          } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		        }
		        puVar3 = (uint *)func_ii_1080(local_4,System_IDisposable_TypeInfo,0);
		code_r0x80dcd535:
		        (**(code **)((ulonglong)*puVar3 * 4))(piVar2,puVar3[1]);
		      }
		      if (iVar8 == 0) {
		        return;
		      }
		      System_Data_DataSet__ValidateLocaleConstraint(iVar8);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    uVar5 = import::env::__cxa_find_matching_catch_2();
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_000017c8 + 0x351,&local_c);
		  iVar8 = DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = 0;
		  if (iVar8 == 1) {
		    import::env::__cxa_find_matching_catch_3(0);
		    unnamed_function_937();
		    do {
		      halt_trap();
		    } while( true );
		  }
		  import::env::__resumeException(uVar5);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x06004036 RID: 16438 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004036")]
		[Address(RVA = "0x8EF0", Offset = "0x8EF0", VA = "0x8EF0")]
		private void InjectCallback()
		{
		/* --- GHIDRA: InjectCallback ---
		void Gameplay_Clans_Office_Controller_ClanWars_ClanPoliticsViewMediator__InjectCallback
		               (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a576fa == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_SubFilterListElement__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Clans_Office_Controller_ClanWars_ClanPoliticsViewMediator_SubFilterClickedEventHandler__
		              );
		    DAT_ram_00a576fa = '\x01';
		  }
		  (**(code **)((ulonglong)*(uint *)(*param1 + 0x140) * 4))
		            (param1,0,*(undefined4 *)(*param1 + 0x144));
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  param1_00 = *(undefined4 *)(iVar1 + 0x18);
		  uVar2 = unnamed_function_1417(System_Action_SubFilterListElement__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,
		             Method_Gameplay_Clans_Office_Controller_ClanWars_ClanPoliticsViewMediator_SubFilterClickedEventHandler__
		             ,0);
		  UI_Elements_Filters_GenericFilter_GenericSubFilterView__add_ClickedEvent(param1_00,uVar2,0);
		  uVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar2 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (uVar2,0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar2,0,0);
		  return;
		}
		*/

		}

		// Token: 0x06004037 RID: 16439 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004037")]
		[Address(RVA = "0x8EF1", Offset = "0x8EF1", VA = "0x8EF1", Slot = "21")]
		public void Hide()
		{
		/* --- GHIDRA: Hide ---
		void Gameplay_Clans_Office_Controller_ClanWars_ClanPoliticsViewMediator__Hide
		               (int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  int *param1_00;
		  int iVar3;
		  
		  if (DAT_ram_00a576fb == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_ClanWarsOfficeModel__ClanWarsOfficeEvents__ClanWarsOfficeController__ClanPoliticsView__Dispose__
		              );
		    Mono_Security_ASN1__get_Item(&Core_MVC_Interfaces_IViewMediator_TypeInfo);
		    DAT_ram_00a576fb = '\x01';
		  }
		  param1_00 = *(int **)(param1 + 0x18);
		  if (param1_00 != (int *)0x0) {
		    uVar1 = 0;
		    iVar3 = *param1_00;
		    if (*(ushort *)(iVar3 + 0xb6) != 0) {
		      do {
		        if (Core_MVC_Interfaces_IViewMediator_TypeInfo ==
		            *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8)) {
		          puVar2 = (uint *)(iVar3 + *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		          goto code_r0x80dcdf3e;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		    }
		    puVar2 = (uint *)func_ii_1080(param1_00,Core_MVC_Interfaces_IViewMediator_TypeInfo,0);
		code_r0x80dcdf3e:
		    (**(code **)((ulonglong)*puVar2 * 4))(param1_00,puVar2[1]);
		  }
		  *(undefined4 *)(param1 + 0x18) = 0;
		  MVC_AbstractViewMediator_object__object__object__object___Core_MVC_Interfaces_IViewMediator_set_View
		            (param1,
		             Method_MVC_AbstractViewMediator_ClanWarsOfficeModel__ClanWarsOfficeEvents__ClanWarsOfficeController__ClanPoliticsView__Dispose__
		            );
		  return;
		}
		*/

		}

		// Token: 0x06004038 RID: 16440 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004038")]
		[Address(RVA = "0x8EF2", Offset = "0x8EF2", VA = "0x8EF2", Slot = "14")]
		public override void Dispose()
		{
		/* --- GHIDRA: Dispose ---
		void Gameplay_Clans_Office_Controller_ClanWars_ClanPoliticsViewMediator__Dispose
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a576fc == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_MVC_AbstractController_ClanWarsHistoryModel__ClanWarsHistoryEvents___ctor__);
		    Mono_Security_ASN1__get_Item(&Method_Core_Net_ServiceFactory_GetService_ClanWarsService___);
		    Mono_Security_ASN1__get_Item(&Core_Net_ServiceFactory_TypeInfo);
		    DAT_ram_00a576fc = '\x01';
		  }
		  Gameplay_Combat_AbstractCombat_object__object__object__object__object___set_User
		            (param1,param2,param3,
		             Method_MVC_AbstractController_ClanWarsHistoryModel__ClanWarsHistoryEvents___ctor__);
		  if (*(int *)(Core_Net_ServiceFactory_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Net_ServiceFactory_TypeInfo);
		  }
		  uVar1 = Core_Gameplay_Managers_LoggedManager__RequestLogin
		                    (Method_Core_Net_ServiceFactory_GetService_ClanWarsService___);
		  *(undefined4 *)(param1 + 0x18) = uVar1;
		  return;
		}
		*/

		}

		// Token: 0x040023C9 RID: 9161
		[Token(Token = "0x40023C9")]
		public const uint LINES_COUNT = 100U;

		// Token: 0x040023CA RID: 9162
		[Token(Token = "0x40023CA")]
		[FieldOffset(Offset = "0x18")]
		private IViewMediator<ClanWarStatusView> _currentMediator;

		// Token: 0x040023CB RID: 9163
		[Token(Token = "0x40023CB")]
		[FieldOffset(Offset = "0x1C")]
		private string _searchInput;

		// Token: 0x040023CC RID: 9164
		[Token(Token = "0x40023CC")]
		[FieldOffset(Offset = "0x20")]
		private SubFilterListElement _selectedFilter;

		// Token: 0x040023CD RID: 9165
		[Token(Token = "0x40023CD")]
		[FieldOffset(Offset = "0x24")]
		private uint _leagueId;

		// Token: 0x040023CE RID: 9166
		[Token(Token = "0x40023CE")]
		[FieldOffset(Offset = "0x28")]
		private ClanPolicyListElement.ClanPolicyListElementArgs _selectedArgs;

		// Token: 0x040023CF RID: 9167
		[Token(Token = "0x40023CF")]
		[FieldOffset(Offset = "0x2C")]
		private ClanWarsOfficeModel.ClanPolicyFilter _policyFilter;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_View ---
		void Gameplay_Clans_Office_Controller_ClanWars_ClanPoliticsViewMediator__set_View
		               (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 param1_00;
		  int *param1_01;
		  undefined4 uVar3;
		  
		  if (DAT_ram_00a576ea == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_SubFilterListElement__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_object__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Clans_Office_Controller_ClanWars_ClanPoliticsViewMediator_FilterSelectedEventHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Clans_Office_Controller_ClanWars_ClanPoliticsViewMediator_MoreItemsAfterNeededEventHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Clans_Office_Controller_ClanWars_ClanPoliticsViewMediator_MyZigguratButtonClickedEventHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Clans_Office_Controller_ClanWars_ClanPoliticsViewMediator_SearchButtonClickedEventHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Clans_Office_Controller_ClanWars_ClanPoliticsViewMediator_SubFilterClickedEventHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Clans_Office_Controller_ClanWars_ClanPoliticsViewMediator_ZigguratButtonClickedEventHandler__
		              );
		    Mono_Security_ASN1__get_Item(&UnityEngine_Events_UnityAction_TypeInfo);
		    DAT_ram_00a576ea = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar3 = *(undefined4 *)(iVar1 + 0x18);
		  uVar2 = unnamed_function_1417(System_Action_SubFilterListElement__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,
		             Method_Gameplay_Clans_Office_Controller_ClanWars_ClanPoliticsViewMediator_SubFilterClickedEventHandler__
		             ,0);
		  UI_Elements_Filters_GenericFilter_GenericSubFilterView__add_ClickedEvent(uVar3,uVar2,0);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar3 = *(undefined4 *)(iVar1 + 0x14);
		  uVar2 = unnamed_function_1417(System_Action_object__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,
		             Method_Gameplay_Clans_Office_Controller_ClanWars_ClanPoliticsViewMediator_FilterSelectedEventHandler__
		             ,0);
		  UI_Elements_Filters_GenericFilter_GenericFilterView__add_SelectedEvent(uVar3,uVar2,0);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar3 = *(undefined4 *)(*(int *)(iVar1 + 0x20) + 0xb4);
		  uVar2 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		  Utils_ObjectUtils__IsNotNull
		            (uVar2,param1,
		             Method_Gameplay_Clans_Office_Controller_ClanWars_ClanPoliticsViewMediator_SearchButtonClickedEventHandler__
		             ,0);
		  UnityEngine_Events_UnityAction___ctor(uVar3,uVar2,0);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar3 = *(undefined4 *)(*(int *)(*(int *)(*(int *)(iVar1 + 0x28) + 0x18) + 0x28) + 0xb4);
		  uVar2 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		  Utils_ObjectUtils__IsNotNull
		            (uVar2,param1,
		             Method_Gameplay_Clans_Office_Controller_ClanWars_ClanPoliticsViewMediator_ZigguratButtonClickedEventHandler__
		             ,0);
		  UnityEngine_Events_UnityAction___ctor(uVar3,uVar2,0);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar3 = *(undefined4 *)(*(int *)(iVar1 + 0x2c) + 0xb4);
		  uVar2 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		  Utils_ObjectUtils__IsNotNull
		            (uVar2,param1,
		             Method_Gameplay_Clans_Office_Controller_ClanWars_ClanPoliticsViewMediator_MyZigguratButtonClickedEventHandler__
		             ,0);
		  UnityEngine_Events_UnityAction___ctor(uVar3,uVar2,0);
		  uVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar3 = Gameplay_Clans_Office_View_ClanWarsTab_ClanPoliticsTab_ClanPoliticsView__get_MyZigguratButton
		                    (uVar2,0);
		  param1_00 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (param1_00,param1,
		             Method_Gameplay_Clans_Office_Controller_ClanWars_ClanPoliticsViewMediator_MoreItemsAfterNeededEventHandler__
		             ,0);
		  param1_01 = (int *)func_ii_7048(uVar3,param1_00,0);
		  if ((param1_01 != (int *)0x0) && (System_Action_TypeInfo != *param1_01)) {
		    System_Activator__CreateInstance(param1_01,System_Action_TypeInfo);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  Gameplay_Clans_Office_View_ClanWarsTab_ClanPoliticsTab_ClanPoliticsView__get_MoreItemsAfterNeededEvent
		            (uVar2,param1_01,0);
		  return;
		}
		*/


		/* --- GHIDRA: set_Events ---
		void Gameplay_Clans_Office_Controller_ClanWars_ClanPoliticsViewMediator__set_Events
		               (int param1,undefined4 param2)
		
		{
		  Gameplay_Clans_Office_Controller_ClanWars_ClanPoliticsViewMediator__UpdateWarState(param1,param1);
		  Gameplay_Clans_Office_Controller_ClanWars_ClanPoliticsViewMediator__RequestFirstPolitics
		            (param1,*(undefined4 *)(param1 + 0x20),param1);
		  return;
		}
		*/

}
