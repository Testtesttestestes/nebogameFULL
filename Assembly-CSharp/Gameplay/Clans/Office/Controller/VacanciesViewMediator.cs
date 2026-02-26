using System;
using Gameplay.Clans.Office.Events;
using Gameplay.Clans.Office.Model;
using Gameplay.Clans.Office.View;
using Gameplay.Clans.Office.View.VacanciesTab;
using Il2CppDummyDll;
using MVC;
using MVC.Interfaces;
using Protocol.Dic;
using Protocol.Rating;
using UI.Elements.RatingElements.SubRatings;
using UI.Windows;

namespace Gameplay.Clans.Office.Controller
{
	// Token: 0x02000A7E RID: 2686
	[Token(Token = "0x2000A7E")]
	public class VacanciesViewMediator : AbstractViewMediator<ClanOfficeModel, ClanOfficeEvents, ClanOfficeController, VacanciesView>, IHideableMediator
	{
		// Token: 0x06003FFA RID: 16378 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003FFA")]
		[Address(RVA = "0x8EB4", Offset = "0x8EB4", VA = "0x8EB4")]
		public VacanciesViewMediator(ClanOfficeModel model, ClanOfficeEvents events, ClanOfficeController controller)
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Clans_Office_Controller_VacanciesViewMediator___ctor
		               (int *param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  
		  if (DAT_ram_00a576d4 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_ClanOfficeModel__ClanOfficeEvents__ClanOfficeController__VacanciesView__set_View__
		              );
		    DAT_ram_00a576d4 = '\x01';
		  }
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar2 = Cysharp_Threading_Tasks_CancellationTokenExtensions___cctor(uVar1,0);
		  if (iVar2 != 0) {
		    Gameplay_Clans_Office_Controller_VacanciesViewMediator__set_View(param1,param1);
		  }
		  param1[5] = param2;
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar2 = Cysharp_Threading_Tasks_CancellationTokenExtensions___cctor(uVar1,0);
		  if (iVar2 != 0) {
		    Gameplay_Clans_Office_Controller_VacanciesViewMediator__ResetView(param1,param1);
		  }
		  return;
		}
		*/

		}

		// Token: 0x17000CAD RID: 3245
		// (set) Token: 0x06003FFB RID: 16379 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000CAD")]
		public override VacanciesView View
		{
			[Token(Token = "0x6003FFB")]
			[Address(RVA = "0x8EB5", Offset = "0x8EB5", VA = "0x8EB5", Slot = "20")]
			set
			{
			}
		}

		// Token: 0x06003FFC RID: 16380 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003FFC")]
		[Address(RVA = "0x8EB6", Offset = "0x8EB6", VA = "0x8EB6")]
		private void ResetView()
		{
		/* --- GHIDRA: ResetView ---
		void Gameplay_Clans_Office_Controller_VacanciesViewMediator__ResetView
		               (int *param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  undefined4 uVar2;
		  undefined4 uVar3;
		  int *piVar4;
		  int iVar5;
		  uint uVar6;
		  
		  if (DAT_ram_00a576d6 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_ClanOfficeModel__ClanOfficeEvents__ClanOfficeController__VacanciesView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_string__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_object__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Dic_RatingTypesDic_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Elements_GenericList_SelectorGenericList_SubRatingsListArgs__SubRatingListElement__SubRatingListElementArgs__set_Data__
		              );
		    Mono_Security_ASN1__get_Item(&UnityEngine_Events_UnityAction_SubRatingListElementArgs__TypeInfo)
		    ;
		    Mono_Security_ASN1__get_Item(&UnityEngine_Events_UnityAction_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_UnityEngine_Events_UnityEvent_SubRatingListElementArgs__AddListener__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Clans_Office_Controller_VacanciesViewMediator_AvailableFilterChangedEventHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Clans_Office_Controller_VacanciesViewMediator_ClanInfoButtonClickedEventHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Clans_Office_Controller_VacanciesViewMediator_FilterSelectedEventHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Clans_Office_Controller_VacanciesViewMediator_InfoButtonClickedEventHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Clans_Office_Controller_VacanciesViewMediator_InputChangedEventHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Clans_Office_Controller_VacanciesViewMediator_MoreItemsAfterNeededEventHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Clans_Office_Controller_VacanciesViewMediator_MoreItemsBeforeNeededEventHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Clans_Office_Controller_VacanciesViewMediator_RequestButtonClickedEventHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Clans_Office_Controller_VacanciesViewMediator_ResetButtonClickedEventHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Clans_Office_Controller_VacanciesViewMediator_SearchButtonClickedEventHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Clans_Office_Controller_VacanciesViewMediator_SubRatingSelectedEventHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Clans_Office_Controller_VacanciesViewMediator_WithdrawButtonClickedEventHandler__
		              );
		    DAT_ram_00a576d6 = '\x01';
		  }
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar2 = Gameplay_Clans_Office_View_ClanWarsTab_ClanPoliticsTab_ClanPoliticsView__get_MyZigguratButton
		                    (uVar1,0);
		  uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar3,param1,
		             Method_Gameplay_Clans_Office_Controller_VacanciesViewMediator_MoreItemsAfterNeededEventHandler__
		             ,0);
		  piVar4 = (int *)UnityEngine_UI_Image__set_sprite(uVar2,uVar3,0);
		  if ((piVar4 != (int *)0x0) && (System_Action_TypeInfo != *piVar4)) {
		    System_Activator__CreateInstance(piVar4,System_Action_TypeInfo);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  Gameplay_Clans_Office_View_ClanWarsTab_ClanPoliticsTab_ClanPoliticsView__get_MoreItemsAfterNeededEvent
		            (uVar1,piVar4,0);
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar2 = Gameplay_Clans_Office_View_VacanciesTab_VacanciesView__set_MoreItemsAfterNeededEvent
		                    (uVar1,0);
		  uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar3,param1,
		             Method_Gameplay_Clans_Office_Controller_VacanciesViewMediator_MoreItemsBeforeNeededEventHandler__
		             ,0);
		  piVar4 = (int *)UnityEngine_UI_Image__set_sprite(uVar2,uVar3,0);
		  if ((piVar4 != (int *)0x0) && (System_Action_TypeInfo != *piVar4)) {
		    System_Activator__CreateInstance(piVar4,System_Action_TypeInfo);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  Gameplay_Clans_Office_View_VacanciesTab_VacanciesView__get_MoreItemsBeforeNeededEvent
		            (uVar1,piVar4,0);
		  iVar5 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar2 = *(undefined4 *)(*(int *)(iVar5 + 0x14) + 0x18);
		  uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_SubRatingListElementArgs__TypeInfo);
		  func_ii_7054(uVar1,param1,
		               Method_Gameplay_Clans_Office_Controller_VacanciesViewMediator_SubRatingSelectedEventHandler__
		               ,0);
		  UnityEngine_Events_UnityEvent_InputAction_CallbackContext____ctor
		            (uVar2,uVar1,
		             Method_UnityEngine_Events_UnityEvent_SubRatingListElementArgs__AddListener__);
		  iVar5 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar2 = *(undefined4 *)(iVar5 + 0x18);
		  uVar1 = unnamed_function_1417(System_Action_object__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar1,param1,
		             Method_Gameplay_Clans_Office_Controller_VacanciesViewMediator_FilterSelectedEventHandler__
		             ,0);
		  UI_Elements_Filters_GenericFilter_FilterWithIconListElement_FilterWithIconData___ctor
		            (uVar2,uVar1,0);
		  iVar5 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar2 = *(undefined4 *)(iVar5 + 0x24);
		  uVar1 = unnamed_function_1417(System_Action_string__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar1,param1,
		             Method_Gameplay_Clans_Office_Controller_VacanciesViewMediator_InputChangedEventHandler__
		             ,0);
		  UI_NumbersInput___ctor(uVar2,uVar1,0);
		  iVar5 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar2 = *(undefined4 *)(iVar5 + 0x20);
		  uVar1 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar1,param1,
		             Method_Gameplay_Clans_Office_Controller_VacanciesViewMediator_AvailableFilterChangedEventHandler__
		             ,0);
		  UI_ToolTip_Controller_Android_ToolTipController__GetPointerPosition(uVar2,uVar1,0);
		  iVar5 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar2 = *(undefined4 *)(*(int *)(iVar5 + 0x28) + 0xb4);
		  uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		  Utils_ObjectUtils__IsNotNull
		            (uVar1,param1,
		             Method_Gameplay_Clans_Office_Controller_VacanciesViewMediator_SearchButtonClickedEventHandler__
		             ,0);
		  Gameplay_Boss_View_CaptainTab_BossInfoView__add_AttackButtonClickEvent(uVar2,uVar1,0);
		  iVar5 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar2 = *(undefined4 *)(*(int *)(iVar5 + 0x2c) + 0xb4);
		  uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		  Utils_ObjectUtils__IsNotNull
		            (uVar1,param1,
		             Method_Gameplay_Clans_Office_Controller_VacanciesViewMediator_ResetButtonClickedEventHandler__
		             ,0);
		  Gameplay_Boss_View_CaptainTab_BossInfoView__add_AttackButtonClickEvent(uVar2,uVar1,0);
		  iVar5 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar2 = *(undefined4 *)(*(int *)(*(int *)(iVar5 + 0x1c) + 0x2c) + 0xb4);
		  uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		  Utils_ObjectUtils__IsNotNull
		            (uVar1,param1,
		             Method_Gameplay_Clans_Office_Controller_VacanciesViewMediator_ClanInfoButtonClickedEventHandler__
		             ,0);
		  Gameplay_Boss_View_CaptainTab_BossInfoView__add_AttackButtonClickEvent(uVar2,uVar1,0);
		  iVar5 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar2 = *(undefined4 *)(*(int *)(*(int *)(iVar5 + 0x1c) + 0x30) + 0xb4);
		  uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		  Utils_ObjectUtils__IsNotNull
		            (uVar1,param1,
		             Method_Gameplay_Clans_Office_Controller_VacanciesViewMediator_RequestButtonClickedEventHandler__
		             ,0);
		  Gameplay_Boss_View_CaptainTab_BossInfoView__add_AttackButtonClickEvent(uVar2,uVar1,0);
		  iVar5 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar2 = *(undefined4 *)(*(int *)(*(int *)(iVar5 + 0x1c) + 0x34) + 0xb4);
		  uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		  Utils_ObjectUtils__IsNotNull
		            (uVar1,param1,
		             Method_Gameplay_Clans_Office_Controller_VacanciesViewMediator_WithdrawButtonClickedEventHandler__
		             ,0);
		  Gameplay_Boss_View_CaptainTab_BossInfoView__add_AttackButtonClickEvent(uVar2,uVar1,0);
		  iVar5 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar2 = *(undefined4 *)(*(int *)(iVar5 + 0x34) + 0xb4);
		  uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		  Utils_ObjectUtils__IsNotNull
		            (uVar1,param1,
		             Method_Gameplay_Clans_Office_Controller_VacanciesViewMediator_InfoButtonClickedEventHandler__
		             ,0);
		  Gameplay_Boss_View_CaptainTab_BossInfoView__add_AttackButtonClickEvent(uVar2,uVar1,0);
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar1 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (uVar1,0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar1,1,0);
		  iVar5 = Gameplay_Clans_Office_Model_ClanOfficeModel__get_PageDifferenceExceeded(param1[2],0);
		  piVar4 = *(int **)(*(int *)(iVar5 + 0x10) + 0xc);
		  if ((piVar4 != (int *)0x0) && (Protocol_Dic_RatingTypesDic_TypeInfo != *piVar4)) {
		    System_Activator__CreateInstance(piVar4,Protocol_Dic_RatingTypesDic_TypeInfo);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  param1[8] = piVar4[3];
		  iVar5 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  piVar4 = *(int **)(iVar5 + 0x18);
		  uVar1 = Gameplay_Clans_Office_Model_ClanOfficeModel__get_PageDifferenceExceeded(param1[2],0);
		  iVar5 = *piVar4;
		  (**(code **)((ulonglong)*(uint *)(iVar5 + 0xe0) * 4))(piVar4,uVar1,*(undefined4 *)(iVar5 + 0xe4));
		  iVar5 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  UI_Elements_GenericList_SelectorGenericList_object__object__object___get_SelectedIndex
		            (*(undefined4 *)(iVar5 + 0x14),*(undefined4 *)(param1[2] + 0x18),
		             Method_UI_Elements_GenericList_SelectorGenericList_SubRatingsListArgs__SubRatingListElement__SubRatingListElementArgs__set_Data__
		            );
		  iVar5 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar2 = *(undefined4 *)(iVar5 + 0x28);
		  iVar5 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar1 = func_ii_7457(*(undefined4 *)(iVar5 + 0x24),0);
		  uVar6 = func_ii_4769(uVar1,0);
		  System_Linq_Enumerable__First_object_(uVar2,uVar6 ^ 1,0);
		  return;
		}
		*/

		}

		// Token: 0x06003FFD RID: 16381 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003FFD")]
		[Address(RVA = "0x8EB7", Offset = "0x8EB7", VA = "0x8EB7")]
		private void SetupView()
		{
		/* --- GHIDRA: SetupView ---
		void Gameplay_Clans_Office_Controller_VacanciesViewMediator__SetupView
		               (int *param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  
		  param1_00 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x14c));
		  Gameplay_Clans_Office_Controller_ClanOfficeController__RequestJoinClanResultHandler(param1_00,0);
		  return;
		}
		*/

		}

		// Token: 0x06003FFE RID: 16382 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003FFE")]
		[Address(RVA = "0x8EB8", Offset = "0x8EB8", VA = "0x8EB8")]
		private void WithdrawButtonClickedEventHandler()
		{
		/* --- GHIDRA: WithdrawButtonClickedEventHandler ---
		void Gameplay_Clans_Office_Controller_VacanciesViewMediator__WithdrawButtonClickedEventHandler
		               (int *param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  
		  param1_00 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x14c));
		  Gameplay_Clans_Office_Controller_ClanOfficeController__HandleMinPage(param1_00,param1[6],0);
		  return;
		}
		*/

		}

		// Token: 0x06003FFF RID: 16383 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003FFF")]
		[Address(RVA = "0x8EB9", Offset = "0x8EB9", VA = "0x8EB9")]
		private void RequestButtonClickedEventHandler()
		{
		/* --- GHIDRA: RequestButtonClickedEventHandler ---
		void Gameplay_Clans_Office_Controller_VacanciesViewMediator__RequestButtonClickedEventHandler
		               (int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  undefined4 in_register_20000014;
		  uint *puVar2;
		  undefined4 param1_00;
		  int iVar3;
		  int *param1_01;
		  int iVar4;
		  
		  if (DAT_ram_00a576d7 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a576d7 = '\x01';
		  }
		  iVar3 = *(int *)(*(int *)(*(int *)(param1 + 0x18) + 0x1c) + 0x1c);
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  uVar1 = 0;
		  param1_01 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar4 = *param1_01;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0x230);
		        goto code_r0x80dca5c7;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_01,Core_Gameplay_IGame_TypeInfo,0x2e);
		code_r0x80dca5c7:
		  param1_00 = (**(code **)((ulonglong)*puVar2 * 4))
		                        (param1_01,CONCAT44(in_register_20000014,puVar2[1]));
		  Core_Gameplay_Managers_ClansManager__DissociateClanFromUser
		            (param1_00,*(undefined8 *)(iVar3 + 0x10),0,0);
		  return;
		}
		*/

		}

		// Token: 0x06004000 RID: 16384 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004000")]
		[Address(RVA = "0x8EBA", Offset = "0x8EBA", VA = "0x8EBA")]
		private void ClanInfoButtonClickedEventHandler()
		{
		/* --- GHIDRA: ClanInfoButtonClickedEventHandler ---
		void Gameplay_Clans_Office_Controller_VacanciesViewMediator__ClanInfoButtonClickedEventHandler
		               (int param1,undefined4 param2)
		
		{
		  undefined4 param2_00;
		  
		  if (DAT_ram_00a576d8 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_ClanOfficeModel__ClanOfficeEvents__ClanOfficeController__VacanciesView__get_Model__
		              );
		    DAT_ram_00a576d8 = '\x01';
		  }
		  param2_00 = Core_Extensions_Dict_DictExt__GetUserRatingKindDic
		                        (*(undefined4 *)(*(int *)(param1 + 8) + 0xc),*(undefined4 *)(param1 + 0x1c),
		                         0);
		  Gameplay_Clans_Office_Controller_VacanciesViewMediator__UpdateInfoBoxState
		            (param1,param2_00,param1);
		  return;
		}
		*/

		}

		// Token: 0x06004001 RID: 16385 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004001")]
		[Address(RVA = "0x8EBB", Offset = "0x8EBB", VA = "0x8EBB")]
		private void InfoButtonClickedEventHandler()
		{
		/* --- GHIDRA: InfoButtonClickedEventHandler ---
		void Gameplay_Clans_Office_Controller_VacanciesViewMediator__InfoButtonClickedEventHandler
		               (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  uint uVar3;
		  undefined4 param1_00;
		  int param2_00;
		  int param3;
		  int param4;
		  
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  UI_SearchInput__Awake(*(undefined4 *)(iVar1 + 0x24),0);
		  param1[9] = 0;
		  uVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x14c));
		  param2_00 = param1[7];
		  param3 = param1[8];
		  param4 = param1[9];
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  Gameplay_Clans_Office_Controller_ClanOfficeController___ctor
		            (uVar2,param2_00,param3,param4,(uint)*(byte *)(*(int *)(iVar1 + 0x20) + 0x48),0);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  param1_00 = *(undefined4 *)(iVar1 + 0x28);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar2 = func_ii_7457(*(undefined4 *)(iVar1 + 0x24),0);
		  uVar3 = func_ii_4769(uVar2,0);
		  System_Linq_Enumerable__First_object_(param1_00,uVar3 ^ 1,0);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar2 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (*(undefined4 *)(iVar1 + 0x2c),0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar2,0,0);
		  return;
		}
		*/

		}

		// Token: 0x06004002 RID: 16386 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004002")]
		[Address(RVA = "0x8EBC", Offset = "0x8EBC", VA = "0x8EBC")]
		private void ResetButtonClickedEventHandler()
		{
		/* --- GHIDRA: ResetButtonClickedEventHandler ---
		void Gameplay_Clans_Office_Controller_VacanciesViewMediator__ResetButtonClickedEventHandler
		               (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  int param2_00;
		  int param3;
		  int param4;
		  
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar1 = func_ii_7457(*(undefined4 *)(iVar1 + 0x24),0);
		  param1[9] = iVar1;
		  uVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x14c));
		  param2_00 = param1[7];
		  param3 = param1[8];
		  param4 = param1[9];
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  Gameplay_Clans_Office_Controller_ClanOfficeController___ctor
		            (uVar2,param2_00,param3,param4,(uint)*(byte *)(*(int *)(iVar1 + 0x20) + 0x48),0);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar2 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (*(undefined4 *)(iVar1 + 0x2c),0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar2,1,0);
		  return;
		}
		*/

		}

		// Token: 0x06004003 RID: 16387 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004003")]
		[Address(RVA = "0x8EBD", Offset = "0x8EBD", VA = "0x8EBD")]
		private void SearchButtonClickedEventHandler()
		{
		/* --- GHIDRA: SearchButtonClickedEventHandler ---
		void Gameplay_Clans_Office_Controller_VacanciesViewMediator__SearchButtonClickedEventHandler
		               (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 param1_00;
		  uint uVar2;
		  undefined4 param1_01;
		  
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  param1_01 = *(undefined4 *)(iVar1 + 0x28);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  param1_00 = func_ii_7457(*(undefined4 *)(iVar1 + 0x24),0);
		  uVar2 = func_ii_4769(param1_00,0);
		  System_Linq_Enumerable__First_object_(param1_01,uVar2 ^ 1,0);
		  return;
		}
		*/

		}

		// Token: 0x06004004 RID: 16388 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004004")]
		[Address(RVA = "0x8EBE", Offset = "0x8EBE", VA = "0x8EBE")]
		private void InputChangedEventHandler(string str)
		{
		}

		// Token: 0x06004005 RID: 16389 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004005")]
		[Address(RVA = "0x8EBF", Offset = "0x8EBF", VA = "0x8EBF")]
		private void AvailableFilterChangedEventHandler()
		{
		/* --- GHIDRA: AvailableFilterChangedEventHandler ---
		void Gameplay_Clans_Office_Controller_VacanciesViewMediator__AvailableFilterChangedEventHandler
		               (int *param1,int *param2,undefined4 param3)
		
		{
		  undefined4 param1_00;
		  int iVar1;
		  int param2_00;
		  int param3_00;
		  int param4;
		  
		  if (DAT_ram_00a576d9 == '\0') {
		    Mono_Security_ASN1__get_Item(&Protocol_Dic_RatingTypesDic_TypeInfo);
		    DAT_ram_00a576d9 = '\x01';
		  }
		  if ((param2 != (int *)0x0) && (Protocol_Dic_RatingTypesDic_TypeInfo != *param2)) {
		    System_Activator__CreateInstance(param2,Protocol_Dic_RatingTypesDic_TypeInfo);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  param1[8] = param2[3];
		  param1_00 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x14c));
		  param2_00 = param1[7];
		  param3_00 = param1[8];
		  param4 = param1[9];
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  Gameplay_Clans_Office_Controller_ClanOfficeController___ctor
		            (param1_00,param2_00,param3_00,param4,(uint)*(byte *)(*(int *)(iVar1 + 0x20) + 0x48),0);
		  return;
		}
		*/

		}

		// Token: 0x06004006 RID: 16390 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004006")]
		[Address(RVA = "0x8EC0", Offset = "0x8EC0", VA = "0x8EC0")]
		private void FilterSelectedEventHandler(object obj)
		{
		/* --- GHIDRA: FilterSelectedEventHandler ---
		void Gameplay_Clans_Office_Controller_VacanciesViewMediator__FilterSelectedEventHandler
		               (int *param1,int param2,undefined4 param3)
		
		{
		  undefined4 param1_00;
		  int iVar1;
		  int param2_00;
		  int param3_00;
		  int param4;
		  
		  param1[7] = *(int *)(*(int *)(param2 + 0xc) + 0xc);
		  param1_00 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x14c));
		  param2_00 = param1[7];
		  param3_00 = param1[8];
		  param4 = param1[9];
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  Gameplay_Clans_Office_Controller_ClanOfficeController___ctor
		            (param1_00,param2_00,param3_00,param4,(uint)*(byte *)(*(int *)(iVar1 + 0x20) + 0x48),0);
		  return;
		}
		*/

		}

		// Token: 0x06004007 RID: 16391 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004007")]
		[Address(RVA = "0x8EC1", Offset = "0x8EC1", VA = "0x8EC1")]
		private void SubRatingSelectedEventHandler(SubRatingListElementArgs subRating)
		{
		/* --- GHIDRA: SubRatingSelectedEventHandler ---
		void Gameplay_Clans_Office_Controller_VacanciesViewMediator__SubRatingSelectedEventHandler
		               (int *param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  int iVar1;
		  int param2_00;
		  int param3;
		  int iVar2;
		  int param5;
		  
		  if (DAT_ram_00a576da == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_ClanOfficeModel__ClanOfficeEvents__ClanOfficeController__VacanciesView__get_Model__
		              );
		    DAT_ram_00a576da = '\x01';
		  }
		  if (*(int *)(param1[2] + 0x3c) != 0) {
		    param1_00 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                          (param1,*(undefined4 *)(*param1 + 0x14c));
		    param2_00 = param1[7];
		    param3 = param1[8];
		    iVar2 = *(int *)(param1[2] + 0x3c);
		    param5 = param1[9];
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    Gameplay_Clans_Office_Controller_ClanOfficeController__RequestFirstClanVacanciesResultHandler
		              (param1_00,param2_00,param3,iVar2 + -1,param5,
		               (uint)*(byte *)(*(int *)(iVar1 + 0x20) + 0x48),0);
		  }
		  return;
		}
		*/

		}

		// Token: 0x06004008 RID: 16392 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004008")]
		[Address(RVA = "0x8EC2", Offset = "0x8EC2", VA = "0x8EC2")]
		private void MoreItemsBeforeNeededEventHandler()
		{
		/* --- GHIDRA: MoreItemsBeforeNeededEventHandler ---
		void Gameplay_Clans_Office_Controller_VacanciesViewMediator__MoreItemsBeforeNeededEventHandler
		               (int *param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  int iVar1;
		  int param2_00;
		  int param3;
		  int iVar2;
		  int param5;
		  
		  if (DAT_ram_00a576db == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_ClanOfficeModel__ClanOfficeEvents__ClanOfficeController__VacanciesView__get_Model__
		              );
		    DAT_ram_00a576db = '\x01';
		  }
		  param1_00 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x14c));
		  param2_00 = param1[7];
		  param3 = param1[8];
		  iVar2 = *(int *)(param1[2] + 0x40);
		  param5 = param1[9];
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  Gameplay_Clans_Office_Controller_ClanOfficeController__RequestFirstClanVacanciesResultHandler
		            (param1_00,param2_00,param3,iVar2 + 1,param5,
		             (uint)*(byte *)(*(int *)(iVar1 + 0x20) + 0x48),0);
		  return;
		}
		*/

		}

		// Token: 0x06004009 RID: 16393 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004009")]
		[Address(RVA = "0x8EC3", Offset = "0x8EC3", VA = "0x8EC3")]
		private void MoreItemsAfterNeededEventHandler()
		{
		/* --- GHIDRA: MoreItemsAfterNeededEventHandler ---
		void Gameplay_Clans_Office_Controller_VacanciesViewMediator__MoreItemsAfterNeededEventHandler
		               (int param1,int param2,undefined4 param3)
		
		{
		  if (DAT_ram_00a576dc == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Elements_GenericList_GenericListElement_ClanInRatingListElement_ClanInRatingListElementArgs__get_args__
		              );
		    DAT_ram_00a576dc = '\x01';
		  }
		  Gameplay_Clans_Office_View_ClanMembersTab_ClanMemberListElement_ClanMemberListElementArgs__get_Selected
		            (*(undefined4 *)(param1 + 0x18),0,0);
		  Gameplay_Clans_Office_Controller_VacanciesViewMediator__UpdateOSARequestBounds
		            (param1,*(undefined4 *)(param2 + 0x18),param1);
		  return;
		}
		*/

		}

		// Token: 0x0600400A RID: 16394 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600400A")]
		[Address(RVA = "0x8EC4", Offset = "0x8EC4", VA = "0x8EC4")]
		private void ClanListElementClickedEventHandler(ClanInRatingListElement element)
		{
		/* --- GHIDRA: ClanListElementClickedEventHandler ---
		void Gameplay_Clans_Office_Controller_VacanciesViewMediator__ClanListElementClickedEventHandler
		               (int *param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  int iVar3;
		  int iVar4;
		  int *piVar5;
		  undefined4 uVar6;
		  
		  if (DAT_ram_00a576dd == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_ClanOfficeModel__ClanOfficeEvents__ClanOfficeController__VacanciesView__set_Events__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_uint__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_int__bool__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Clans_Office_Controller_VacanciesViewMediator_AdditionalVacanciesRequestedEventHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Clans_Office_Controller_VacanciesViewMediator_ClanPageRemovedEventHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Clans_Office_Controller_VacanciesViewMediator_FirstVacanciesRequestedEventHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Clans_Office_Controller_VacanciesViewMediator_JoinRequestCancelledEventHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Clans_Office_Controller_VacanciesViewMediator_JoinRequestSentEventHandler__
		              );
		    DAT_ram_00a576dd = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x13c));
		  if (iVar1 != 0) {
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar6 = *(undefined4 *)(iVar1 + 0x14);
		    uVar2 = unnamed_function_1417(System_Action_uint__TypeInfo);
		    func_ii_12322(uVar2,param1,
		                  Method_Gameplay_Clans_Office_Controller_VacanciesViewMediator_FirstVacanciesRequestedEventHandler__
		                  ,0);
		    iVar3 = func_ii_7048(uVar6,uVar2,0);
		    uVar2 = System_Action_uint__TypeInfo;
		    if (iVar3 == 0) {
		      *(undefined4 *)(iVar1 + 0x14) = 0;
		    }
		    else {
		      iVar4 = func_ii_1082(iVar3,System_Action_uint__TypeInfo);
		      if (iVar4 == 0) {
		        System_Activator__CreateInstance(iVar3,uVar2);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      *(int *)(iVar1 + 0x14) = iVar4;
		      uVar2 = System_Action_uint__TypeInfo;
		      iVar1 = func_ii_1082(iVar3,System_Action_uint__TypeInfo);
		      if (iVar1 == 0) {
		        System_Activator__CreateInstance(iVar3,uVar2);
		        do {
		          halt_trap();
		        } while( true );
		      }
		    }
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar6 = *(undefined4 *)(iVar1 + 0x18);
		    uVar2 = unnamed_function_1417(System_Action_uint__TypeInfo);
		    func_ii_12322(uVar2,param1,
		                  Method_Gameplay_Clans_Office_Controller_VacanciesViewMediator_AdditionalVacanciesRequestedEventHandler__
		                  ,0);
		    iVar3 = func_ii_7048(uVar6,uVar2,0);
		    uVar2 = System_Action_uint__TypeInfo;
		    if (iVar3 == 0) {
		      *(undefined4 *)(iVar1 + 0x18) = 0;
		    }
		    else {
		      iVar4 = func_ii_1082(iVar3,System_Action_uint__TypeInfo);
		      if (iVar4 == 0) {
		        System_Activator__CreateInstance(iVar3,uVar2);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      *(int *)(iVar1 + 0x18) = iVar4;
		      uVar2 = System_Action_uint__TypeInfo;
		      iVar1 = func_ii_1082(iVar3,System_Action_uint__TypeInfo);
		      if (iVar1 == 0) {
		        System_Activator__CreateInstance(iVar3,uVar2);
		        do {
		          halt_trap();
		        } while( true );
		      }
		    }
		    iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar6 = *(undefined4 *)(iVar3 + 0x20);
		    uVar2 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar2,param1,
		               Method_Gameplay_Clans_Office_Controller_VacanciesViewMediator_JoinRequestSentEventHandler__
		               ,0);
		    piVar5 = (int *)func_ii_7048(uVar6,uVar2,0);
		    iVar1 = System_Action_TypeInfo;
		    if (piVar5 == (int *)0x0) {
		      *(undefined4 *)(iVar3 + 0x20) = 0;
		    }
		    else if ((System_Action_TypeInfo != *piVar5) ||
		            (*(int **)(iVar3 + 0x20) = piVar5, *piVar5 != iVar1)) {
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
		               Method_Gameplay_Clans_Office_Controller_VacanciesViewMediator_JoinRequestCancelledEventHandler__
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
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar6 = *(undefined4 *)(iVar1 + 0x28);
		    uVar2 = unnamed_function_1417(System_Action_int__bool__TypeInfo);
		    System_Action_InputEventPtr__object___Invoke
		              (uVar2,param1,
		               Method_Gameplay_Clans_Office_Controller_VacanciesViewMediator_ClanPageRemovedEventHandler__
		               ,0);
		    iVar3 = func_ii_7048(uVar6,uVar2,0);
		    uVar2 = System_Action_int__bool__TypeInfo;
		    if (iVar3 == 0) {
		      *(undefined4 *)(iVar1 + 0x28) = 0;
		    }
		    else {
		      iVar4 = func_ii_1082(iVar3,System_Action_int__bool__TypeInfo);
		      if (iVar4 == 0) {
		        System_Activator__CreateInstance(iVar3,uVar2);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      *(int *)(iVar1 + 0x28) = iVar4;
		      uVar2 = System_Action_int__bool__TypeInfo;
		      iVar1 = func_ii_1082(iVar3,System_Action_int__bool__TypeInfo);
		      if (iVar1 == 0) {
		        System_Activator__CreateInstance(iVar3,uVar2);
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
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar6 = *(undefined4 *)(iVar1 + 0x14);
		    uVar2 = unnamed_function_1417(System_Action_uint__TypeInfo);
		    func_ii_12322(uVar2,param1,
		                  Method_Gameplay_Clans_Office_Controller_VacanciesViewMediator_FirstVacanciesRequestedEventHandler__
		                  ,0);
		    iVar3 = UnityEngine_UI_Image__set_sprite(uVar6,uVar2,0);
		    uVar2 = System_Action_uint__TypeInfo;
		    if (iVar3 == 0) {
		      *(undefined4 *)(iVar1 + 0x14) = 0;
		    }
		    else {
		      iVar4 = func_ii_1082(iVar3,System_Action_uint__TypeInfo);
		      if (iVar4 == 0) {
		        System_Activator__CreateInstance(iVar3,uVar2);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      *(int *)(iVar1 + 0x14) = iVar4;
		      uVar2 = System_Action_uint__TypeInfo;
		      iVar1 = func_ii_1082(iVar3,System_Action_uint__TypeInfo);
		      if (iVar1 == 0) {
		        System_Activator__CreateInstance(iVar3,uVar2);
		        do {
		          halt_trap();
		        } while( true );
		      }
		    }
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar6 = *(undefined4 *)(iVar1 + 0x18);
		    uVar2 = unnamed_function_1417(System_Action_uint__TypeInfo);
		    func_ii_12322(uVar2,param1,
		                  Method_Gameplay_Clans_Office_Controller_VacanciesViewMediator_AdditionalVacanciesRequestedEventHandler__
		                  ,0);
		    iVar3 = UnityEngine_UI_Image__set_sprite(uVar6,uVar2,0);
		    uVar2 = System_Action_uint__TypeInfo;
		    if (iVar3 == 0) {
		      *(undefined4 *)(iVar1 + 0x18) = 0;
		    }
		    else {
		      iVar4 = func_ii_1082(iVar3,System_Action_uint__TypeInfo);
		      if (iVar4 == 0) {
		        System_Activator__CreateInstance(iVar3,uVar2);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      *(int *)(iVar1 + 0x18) = iVar4;
		      uVar2 = System_Action_uint__TypeInfo;
		      iVar1 = func_ii_1082(iVar3,System_Action_uint__TypeInfo);
		      if (iVar1 == 0) {
		        System_Activator__CreateInstance(iVar3,uVar2);
		        do {
		          halt_trap();
		        } while( true );
		      }
		    }
		    iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar6 = *(undefined4 *)(iVar3 + 0x20);
		    uVar2 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar2,param1,
		               Method_Gameplay_Clans_Office_Controller_VacanciesViewMediator_JoinRequestSentEventHandler__
		               ,0);
		    piVar5 = (int *)UnityEngine_UI_Image__set_sprite(uVar6,uVar2,0);
		    iVar1 = System_Action_TypeInfo;
		    if (piVar5 == (int *)0x0) {
		      *(undefined4 *)(iVar3 + 0x20) = 0;
		    }
		    else if ((System_Action_TypeInfo != *piVar5) ||
		            (*(int **)(iVar3 + 0x20) = piVar5, *piVar5 != iVar1)) {
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
		               Method_Gameplay_Clans_Office_Controller_VacanciesViewMediator_JoinRequestCancelledEventHandler__
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
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar6 = *(undefined4 *)(iVar1 + 0x28);
		    uVar2 = unnamed_function_1417(System_Action_int__bool__TypeInfo);
		    System_Action_InputEventPtr__object___Invoke
		              (uVar2,param1,
		               Method_Gameplay_Clans_Office_Controller_VacanciesViewMediator_ClanPageRemovedEventHandler__
		               ,0);
		    iVar3 = UnityEngine_UI_Image__set_sprite(uVar6,uVar2,0);
		    uVar2 = System_Action_int__bool__TypeInfo;
		    if (iVar3 == 0) {
		      *(undefined4 *)(iVar1 + 0x28) = 0;
		      return;
		    }
		    iVar4 = func_ii_1082(iVar3,System_Action_int__bool__TypeInfo);
		    if (iVar4 == 0) {
		      System_Activator__CreateInstance(iVar3,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    *(int *)(iVar1 + 0x28) = iVar4;
		    uVar2 = System_Action_int__bool__TypeInfo;
		    iVar1 = func_ii_1082(iVar3,System_Action_int__bool__TypeInfo);
		    if (iVar1 == 0) {
		      System_Activator__CreateInstance(iVar3,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x17000CAE RID: 3246
		// (set) Token: 0x0600400B RID: 16395 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000CAE")]
		public override ClanOfficeEvents Events
		{
			[Token(Token = "0x600400B")]
			[Address(RVA = "0x8EC5", Offset = "0x8EC5", VA = "0x8EC5", Slot = "16")]
			set
			{
			}
		}

		// Token: 0x0600400C RID: 16396 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600400C")]
		[Address(RVA = "0x8EC6", Offset = "0x8EC6", VA = "0x8EC6")]
		private void JoinRequestCancelledEventHandler()
		{
		/* --- GHIDRA: JoinRequestCancelledEventHandler ---
		void Gameplay_Clans_Office_Controller_VacanciesViewMediator__JoinRequestCancelledEventHandler
		               (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  longlong lVar2;
		  longlong lVar3;
		  undefined4 param2_00;
		  
		  if (DAT_ram_00a576e4 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_ClanOfficeModel__ClanOfficeEvents__ClanOfficeController__VacanciesView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_MonoBehaviourWithStates_ClanVacancyInfoBox_State__set_CurrentState__);
		    DAT_ram_00a576e4 = '\x01';
		  }
		  lVar2 = *(longlong *)(param1[2] + 0x48);
		  lVar3 = *(longlong *)(*(int *)(*(int *)(param1[6] + 0x1c) + 0x1c) + 0x10);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  param2_00 = 2;
		  if (lVar2 != lVar3) {
		    param2_00 = 1;
		  }
		  Gameplay_Boss_View_CaptainTab_BossTeamView__set_TeamInfoData
		            (*(undefined4 *)(iVar1 + 0x1c),param2_00,
		             Method_UI_MonoBehaviourWithStates_ClanVacancyInfoBox_State__set_CurrentState__);
		  Gameplay_Clans_Office_Controller_VacanciesViewMediator__ClanPageRemovedEventHandler(param1,param1)
		  ;
		  return;
		}
		*/

		}

		// Token: 0x0600400D RID: 16397 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600400D")]
		[Address(RVA = "0x8EC7", Offset = "0x8EC7", VA = "0x8EC7")]
		private void JoinRequestSentEventHandler()
		{
		/* --- GHIDRA: JoinRequestSentEventHandler ---
		void Gameplay_Clans_Office_Controller_VacanciesViewMediator__JoinRequestSentEventHandler
		               (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  uint uVar1;
		  int *param2_00;
		  undefined4 uVar2;
		  uint *param3_00;
		  int iVar3;
		  
		  if (DAT_ram_00a576de == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_ClanOfficeModel__ClanOfficeEvents__ClanOfficeController__VacanciesView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_uint__IList_ClanInRatingListElement_ClanInRatingListElementArgs___get_Item__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               System_Collections_Generic_ICollection_ClanInRatingListElement_ClanInRatingListElementArgs__TypeInfo
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               System_Collections_Generic_IList_ClanInRatingListElement_ClanInRatingListElementArgs__TypeInfo
		              );
		    DAT_ram_00a576de = '\x01';
		  }
		  Gameplay_Clans_Office_Controller_VacanciesViewMediator__AdditionalVacanciesRequestedEventHandler
		            (param1,param2,param2);
		  Gameplay_Clans_Office_Controller_VacanciesViewMediator__RequestFirstClanVacancies(param1,param2);
		  param2_00 = (int *)System_Collections_Generic_List_object___get_Item
		                               (*(undefined4 *)(param1[2] + 0x14),0,
		                                Method_System_Collections_Generic_Dictionary_uint__IList_ClanInRatingListElement_ClanInRatingListElementArgs___get_Item__
		                               );
		  uVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  Gameplay_Clans_Office_View_VacanciesTab_VacanciesView__set_MoreItemsBeforeNeededEvent
		            (uVar2,param2_00,0);
		  iVar3 = *param2_00;
		  if (*(ushort *)(iVar3 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (System_Collections_Generic_ICollection_ClanInRatingListElement_ClanInRatingListElementArgs__TypeInfo
		          == *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8)) {
		        param3_00 = (uint *)(iVar3 + *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x80dcb52d;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		  }
		  param3_00 = (uint *)func_ii_1080(param2_00,
		                                   System_Collections_Generic_ICollection_ClanInRatingListElement_ClanInRatingListElementArgs__TypeInfo
		                                   ,0);
		code_r0x80dcb52d:
		  iVar3 = (**(code **)((ulonglong)*param3_00 * 4))(param2_00,param3_00[1]);
		  if (0 < iVar3) {
		    uVar1 = 0;
		    iVar3 = *param2_00;
		    if (*(ushort *)(iVar3 + 0xb6) != 0) {
		      do {
		        if (System_Collections_Generic_IList_ClanInRatingListElement_ClanInRatingListElementArgs__TypeInfo
		            == *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8)) {
		          param3_00 = (uint *)(iVar3 + *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		          goto code_r0x80dcb5b2;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		    }
		    param3_00 = (uint *)func_ii_1080(param2_00,
		                                     System_Collections_Generic_IList_ClanInRatingListElement_ClanInRatingListElementArgs__TypeInfo
		                                     ,0);
		code_r0x80dcb5b2:
		    uVar2 = (**(code **)((ulonglong)*param3_00 * 4))(param2_00,0,param3_00[1]);
		    Gameplay_Clans_Office_Controller_VacanciesViewMediator__UpdateOSARequestBounds
		              (param1,uVar2,param3_00);
		  }
		  Gameplay_Clans_Office_Controller_VacanciesViewMediator__ClanPageRemovedEventHandler
		            (param1,param3_00);
		  return;
		}
		*/

		}

		// Token: 0x0600400E RID: 16398 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600400E")]
		[Address(RVA = "0x8EC8", Offset = "0x8EC8", VA = "0x8EC8")]
		private void FirstVacanciesRequestedEventHandler(uint pageNumber)
		{
		/* --- GHIDRA: FirstVacanciesRequestedEventHandler ---
		void Gameplay_Clans_Office_Controller_VacanciesViewMediator__FirstVacanciesRequestedEventHandler
		               (int *param1,int param2,undefined4 param3)
		
		{
		  undefined4 param1_00;
		  undefined4 param2_00;
		  
		  if (DAT_ram_00a576df == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_ClanOfficeModel__ClanOfficeEvents__ClanOfficeController__VacanciesView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_uint__IList_ClanInRatingListElement_ClanInRatingListElementArgs___get_Item__
		              );
		    DAT_ram_00a576df = '\x01';
		  }
		  Gameplay_Clans_Office_Controller_VacanciesViewMediator__AdditionalVacanciesRequestedEventHandler
		            (param1,param2,param1);
		  Gameplay_Clans_Office_Controller_VacanciesViewMediator__RequestFirstClanVacancies(param1,param1);
		  param1_00 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x15c));
		  param2_00 = System_Collections_Generic_List_object___get_Item
		                        (*(undefined4 *)(param1[2] + 0x14),param2,
		                         Method_System_Collections_Generic_Dictionary_uint__IList_ClanInRatingListElement_ClanInRatingListElementArgs___get_Item__
		                        );
		  Gameplay_Clans_Office_View_VacanciesTab_VacanciesView__Init
		            (param1_00,param2_00,(uint)(*(int *)(param1[2] + 0x40) == param2),0);
		  Gameplay_Clans_Office_Controller_VacanciesViewMediator__ClanPageRemovedEventHandler(param1,param1)
		  ;
		  return;
		}
		*/

		}

		// Token: 0x0600400F RID: 16399 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600400F")]
		[Address(RVA = "0x8EC9", Offset = "0x8EC9", VA = "0x8EC9")]
		private void AdditionalVacanciesRequestedEventHandler(uint pageNumber)
		{
		/* --- GHIDRA: AdditionalVacanciesRequestedEventHandler ---
		void Gameplay_Clans_Office_Controller_VacanciesViewMediator__AdditionalVacanciesRequestedEventHandler
		               (int param1,undefined4 param2,undefined4 param3)
		
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
		  
		  if (DAT_ram_00a576e0 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_ClanOfficeModel__ClanOfficeEvents__ClanOfficeController__VacanciesView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_ClanInRatingListElement__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_uint__IList_ClanInRatingListElement_ClanInRatingListElementArgs___get_Item__
		              );
		    Mono_Security_ASN1__get_Item(&System_IDisposable_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               System_Collections_Generic_IEnumerable_ClanInRatingListElement_ClanInRatingListElementArgs__TypeInfo
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               System_Collections_Generic_IEnumerator_ClanInRatingListElement_ClanInRatingListElementArgs__TypeInfo
		              );
		    Mono_Security_ASN1__get_Item(&System_Collections_IEnumerator_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Clans_Office_Controller_VacanciesViewMediator_ClanListElementClickedEventHandler__
		              );
		    DAT_ram_00a576e0 = '\x01';
		  }
		  piVar2 = (int *)System_Collections_Generic_List_object___get_Item
		                            (*(undefined4 *)(*(int *)(param1 + 8) + 0x14),param2,
		                             Method_System_Collections_Generic_Dictionary_uint__IList_ClanInRatingListElement_ClanInRatingListElementArgs___get_Item__
		                            );
		  iVar8 = *piVar2;
		  if (*(ushort *)(iVar8 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (System_Collections_Generic_IEnumerable_ClanInRatingListElement_ClanInRatingListElementArgs__TypeInfo
		          == *(int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(iVar8 + *(int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x80dcb6bb;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar8 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(piVar2,
		                                System_Collections_Generic_IEnumerable_ClanInRatingListElement_ClanInRatingListElementArgs__TypeInfo
		                                ,0);
		code_r0x80dcb6bb:
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
		          goto code_r0x80dcb786;
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
		code_r0x80dcb936:
		      DAT_ram_009d3e38 = 0;
		      uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80dcb93e;
		    }
		code_r0x80dcb786:
		    DAT_ram_009d3e38 = 0;
		    iVar8 = import::env::invoke_iii(*puVar4,piVar2,puVar4[1]);
		    piVar2 = local_4;
		    if (DAT_ram_009d3e38 == 1) goto code_r0x80dcb936;
		    if (iVar8 == 0) {
		      iVar8 = 0;
		      goto code_r0x80dcb987;
		    }
		    iVar8 = *local_4;
		    if (*(ushort *)(iVar8 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        piVar7 = (int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8);
		        if (System_Collections_Generic_IEnumerator_ClanInRatingListElement_ClanInRatingListElementArgs__TypeInfo
		            == *piVar7) {
		          puVar4 = (undefined4 *)(iVar8 + piVar7[1] * 8 + 0xc0);
		          goto code_r0x80dcb860;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar8 + 0xb6) != uVar1);
		    }
		    DAT_ram_009d3e38 = 0;
		    puVar4 = (undefined4 *)
		             import::env::invoke_iiii
		                       (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                        System_Collections_Generic_IEnumerator_ClanInRatingListElement_ClanInRatingListElementArgs__TypeInfo
		                        ,0);
		    if (DAT_ram_009d3e38 == 1) {
		code_r0x80dcb922:
		      DAT_ram_009d3e38 = 0;
		      uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80dcb93e;
		    }
		code_r0x80dcb860:
		    DAT_ram_009d3e38 = 0;
		    iVar8 = import::env::invoke_iii(*puVar4,piVar2,puVar4[1]);
		    if (DAT_ram_009d3e38 == 1) goto code_r0x80dcb922;
		    DAT_ram_009d3e38 = 0;
		    uVar5 = import::env::invoke_ii
		                      (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x199,
		                       System_Action_ClanInRatingListElement__TypeInfo);
		    if (DAT_ram_009d3e38 == 1) break;
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_viiii
		              (s_struct_Uniforms___color__array<v_ram_000017c8 + 0x241,uVar5,param1,
		               Method_Gameplay_Clans_Office_Controller_VacanciesViewMediator_ClanListElementClickedEventHandler__
		               ,0);
		    if (DAT_ram_009d3e38 == 1) break;
		    *(undefined4 *)(iVar8 + 0x18) = uVar5;
		  } while( true );
		  DAT_ram_009d3e38 = 0;
		  uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x80dcb93e:
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
		code_r0x80dcb987:
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
		              goto code_r0x80dcb9ff;
		            }
		            uVar1 = uVar1 + 1;
		          } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		        }
		        puVar3 = (uint *)func_ii_1080(local_4,System_IDisposable_TypeInfo,0);
		code_r0x80dcb9ff:
		        (**(code **)((ulonglong)*puVar3 * 4))(piVar2,puVar3[1]);
		      }
		      if (iVar8 == 0) {
		        iVar8 = *(int *)(*(int *)(param1 + 8) + 0x38);
		        if (iVar8 != 0) {
		          uVar5 = unnamed_function_1417(System_Action_ClanInRatingListElement__TypeInfo);
		          UnityEngine_UIElements_VisualElement__get_layout
		                    (uVar5,param1,
		                     Method_Gameplay_Clans_Office_Controller_VacanciesViewMediator_ClanListElementClickedEventHandler__
		                     ,0);
		          *(undefined4 *)(iVar8 + 0x18) = uVar5;
		        }
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
		  import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_000017c8 + 0x350,&local_c);
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

		// Token: 0x06004010 RID: 16400 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004010")]
		[Address(RVA = "0x8ECA", Offset = "0x8ECA", VA = "0x8ECA")]
		private void RequestInjectCallbackEventHandler(uint pageNumber)
		{
		/* --- GHIDRA: RequestInjectCallbackEventHandler ---
		void Gameplay_Clans_Office_Controller_VacanciesViewMediator__RequestInjectCallbackEventHandler
		               (int *param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  undefined4 param1_00;
		  
		  param1_00 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x15c));
		  Gameplay_Clans_Office_View_VacanciesTab_VacanciesView__Add(param1_00,param2,param3,0);
		  return;
		}
		*/

		}

		// Token: 0x06004011 RID: 16401 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004011")]
		[Address(RVA = "0x8ECB", Offset = "0x8ECB", VA = "0x8ECB")]
		private void ClanPageRemovedEventHandler(int count, bool fromEnd)
		{
		/* --- GHIDRA: ClanPageRemovedEventHandler ---
		void Gameplay_Clans_Office_Controller_VacanciesViewMediator__ClanPageRemovedEventHandler
		               (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 param1_00;
		  int iVar2;
		  
		  if (DAT_ram_00a576e1 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_ClanOfficeModel__ClanOfficeEvents__ClanOfficeController__VacanciesView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Elements_GenericList_SelectableListElement_ClanInRatingListElement_ClanInRatingListElementArgs__set_Data__
		              );
		    DAT_ram_00a576e1 = '\x01';
		  }
		  iVar2 = *(int *)(param1[2] + 0x38);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  param1_00 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                        (*(undefined4 *)(iVar1 + 0x30),0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (param1_00,(uint)(iVar2 != 0),0);
		  if (iVar2 != 0) {
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    func_ii_7635(*(undefined4 *)(iVar1 + 0x30),*(undefined4 *)(param1[2] + 0x38),
		                 Method_UI_Elements_GenericList_SelectableListElement_ClanInRatingListElement_ClanInRatingListElementArgs__set_Data__
		                );
		  }
		  return;
		}
		*/

		}

		// Token: 0x06004012 RID: 16402 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004012")]
		[Address(RVA = "0x8ECC", Offset = "0x8ECC", VA = "0x8ECC")]
		private void UpdateRequestedClanView()
		{
		/* --- GHIDRA: UpdateRequestedClanView ---
		void Gameplay_Clans_Office_Controller_VacanciesViewMediator__UpdateRequestedClanView
		               (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 param1_00;
		  uint uVar2;
		  undefined4 param1_01;
		  
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  param1_01 = *(undefined4 *)(iVar1 + 0x28);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  param1_00 = func_ii_7457(*(undefined4 *)(iVar1 + 0x24),0);
		  uVar2 = func_ii_4769(param1_00,0);
		  System_Linq_Enumerable__First_object_(param1_01,uVar2 ^ 1,0);
		  return;
		}
		*/

		}

		// Token: 0x06004013 RID: 16403 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004013")]
		[Address(RVA = "0x8ECD", Offset = "0x8ECD", VA = "0x8ECD")]
		private void ValidateSearchButton()
		{
		/* --- GHIDRA: ValidateSearchButton ---
		void Gameplay_Clans_Office_Controller_VacanciesViewMediator__ValidateSearchButton
		               (int *param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  int iVar1;
		  int param2_00;
		  int param3;
		  int param4;
		  
		  param1_00 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x14c));
		  param2_00 = param1[7];
		  param3 = param1[8];
		  param4 = param1[9];
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  Gameplay_Clans_Office_Controller_ClanOfficeController___ctor
		            (param1_00,param2_00,param3,param4,(uint)*(byte *)(*(int *)(iVar1 + 0x20) + 0x48),0);
		  return;
		}
		*/

		}

		// Token: 0x06004014 RID: 16404 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004014")]
		[Address(RVA = "0x8ECE", Offset = "0x8ECE", VA = "0x8ECE")]
		private void RequestFirstClanVacancies()
		{
		/* --- GHIDRA: RequestFirstClanVacancies ---
		void Gameplay_Clans_Office_Controller_VacanciesViewMediator__RequestFirstClanVacancies
		               (int *param1,undefined4 param2)
		
		{
		  uint uVar1;
		  int *param1_00;
		  uint *puVar2;
		  undefined4 param1_01;
		  int iVar3;
		  int iVar4;
		  int iVar5;
		  
		  if (DAT_ram_00a576e2 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_ClanOfficeModel__ClanOfficeEvents__ClanOfficeController__VacanciesView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_uint__IList_ClanInRatingListElement_ClanInRatingListElementArgs___get_Item__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               System_Collections_Generic_ICollection_ClanInRatingListElement_ClanInRatingListElementArgs__TypeInfo
		              );
		    DAT_ram_00a576e2 = '\x01';
		  }
		  param1_00 = (int *)System_Collections_Generic_List_object___get_Item
		                               (*(undefined4 *)(param1[2] + 0x14),*(undefined4 *)(param1[2] + 0x40),
		                                Method_System_Collections_Generic_Dictionary_uint__IList_ClanInRatingListElement_ClanInRatingListElementArgs___get_Item__
		                               );
		  iVar5 = *param1_00;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (System_Collections_Generic_ICollection_ClanInRatingListElement_ClanInRatingListElementArgs__TypeInfo
		          == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(iVar5 + *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x80dcbb55;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_00,
		                                System_Collections_Generic_ICollection_ClanInRatingListElement_ClanInRatingListElementArgs__TypeInfo
		                                ,0);
		code_r0x80dcbb55:
		  iVar5 = (**(code **)((ulonglong)*puVar2 * 4))(param1_00,puVar2[1]);
		  iVar3 = *(int *)(param1[2] + 0x1c);
		  iVar4 = *(int *)(param1[2] + 0x3c);
		  param1_01 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x15c));
		  Gameplay_Clans_Office_View_VacanciesTab_VacanciesView__Remove
		            (param1_01,(uint)(iVar5 == iVar3),(uint)(iVar4 != 0),0);
		  return;
		}
		*/

		}

		// Token: 0x06004015 RID: 16405 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004015")]
		[Address(RVA = "0x8ECF", Offset = "0x8ECF", VA = "0x8ECF")]
		private void UpdateOSARequestBounds()
		{
		/* --- GHIDRA: UpdateOSARequestBounds ---
		void Gameplay_Clans_Office_Controller_VacanciesViewMediator__UpdateOSARequestBounds
		               (int *param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  longlong lVar2;
		  longlong lVar3;
		  undefined4 param2_00;
		  int iVar4;
		  
		  if (DAT_ram_00a576e3 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_ClanOfficeModel__ClanOfficeEvents__ClanOfficeController__VacanciesView__get_Model__
		              );
		    DAT_ram_00a576e3 = '\x01';
		  }
		  param1[6] = param2;
		  Gameplay_Clans_Office_View_ClanMembersTab_ClanMemberListElement_ClanMemberListElementArgs__get_Selected
		            (param2,1,0);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar4 = param1[2];
		  Gameplay_Clans_Office_View_VacanciesTab_ClanVacancyInfoBox__get_WithdrawButton
		            (*(undefined4 *)(iVar1 + 0x1c),param2,*(undefined4 *)(iVar4 + 0xc),
		             *(undefined4 *)(iVar4 + 8),*(undefined4 *)(iVar4 + 0x10),0);
		  if (DAT_ram_00a576e4 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_ClanOfficeModel__ClanOfficeEvents__ClanOfficeController__VacanciesView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_MonoBehaviourWithStates_ClanVacancyInfoBox_State__set_CurrentState__);
		    DAT_ram_00a576e4 = '\x01';
		  }
		  lVar2 = *(longlong *)(param1[2] + 0x48);
		  lVar3 = *(longlong *)(*(int *)(*(int *)(param1[6] + 0x1c) + 0x1c) + 0x10);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  param2_00 = 2;
		  if (lVar2 != lVar3) {
		    param2_00 = 1;
		  }
		  Gameplay_Boss_View_CaptainTab_BossTeamView__set_TeamInfoData
		            (*(undefined4 *)(iVar1 + 0x1c),param2_00,
		             Method_UI_MonoBehaviourWithStates_ClanVacancyInfoBox_State__set_CurrentState__);
		  return;
		}
		*/

		}

		// Token: 0x06004016 RID: 16406 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004016")]
		[Address(RVA = "0x8ED0", Offset = "0x8ED0", VA = "0x8ED0")]
		private void SelectArgs(ClanInRatingListElement.ClanInRatingListElementArgs args)
		{
		/* --- GHIDRA: SelectArgs ---
		void Gameplay_Clans_Office_Controller_VacanciesViewMediator__SelectArgs
		               (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  longlong lVar2;
		  longlong lVar3;
		  undefined4 param2_00;
		  
		  if (DAT_ram_00a576e4 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_ClanOfficeModel__ClanOfficeEvents__ClanOfficeController__VacanciesView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_MonoBehaviourWithStates_ClanVacancyInfoBox_State__set_CurrentState__);
		    DAT_ram_00a576e4 = '\x01';
		  }
		  lVar2 = *(longlong *)(param1[2] + 0x48);
		  lVar3 = *(longlong *)(*(int *)(*(int *)(param1[6] + 0x1c) + 0x1c) + 0x10);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  param2_00 = 2;
		  if (lVar2 != lVar3) {
		    param2_00 = 1;
		  }
		  Gameplay_Boss_View_CaptainTab_BossTeamView__set_TeamInfoData
		            (*(undefined4 *)(iVar1 + 0x1c),param2_00,
		             Method_UI_MonoBehaviourWithStates_ClanVacancyInfoBox_State__set_CurrentState__);
		  return;
		}
		*/

		}

		// Token: 0x06004017 RID: 16407 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004017")]
		[Address(RVA = "0x8ED1", Offset = "0x8ED1", VA = "0x8ED1")]
		private void UpdateInfoBoxState()
		{
		/* --- GHIDRA: UpdateInfoBoxState ---
		undefined4
		Gameplay_Clans_Office_Controller_VacanciesViewMediator__UpdateInfoBoxState
		          (undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  int param1_00;
		  undefined4 uVar2;
		  int param1_01;
		  int param1_02;
		  uint uVar3;
		  
		  if (DAT_ram_00a576e5 == '\0') {
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
		              (&
		               Method_System_Collections_Generic_List_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs___Add__
		              );
		    Mono_Security_ASN1__get_Item(&StringLiteral_4297);
		    Mono_Security_ASN1__get_Item(&StringLiteral_16790);
		    DAT_ram_00a576e5 = '\x01';
		  }
		  param1_00 = unnamed_function_1417(UI_Windows_DialogWindow_DialogWindowArgs_TypeInfo);
		  func_ii_8625(param1_00,0);
		  if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_GameLocalization_TypeInfo);
		  }
		  uVar2 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_4297,1,0,1,0,0,0,0);
		  *(undefined4 *)(param1_00 + 0x18) = uVar2;
		  uVar2 = Core_Extensions_Dict_ClanRatingKindDicExt__GetTitle(param2,0);
		  uVar2 = Core_Extensions_Dict_CultDicExt__GetTitle(uVar2,1,0,1,0,0,0,0);
		  *(undefined4 *)(param1_00 + 0x1c) = uVar2;
		  param1_02 = *(int *)(param1_00 + 0x24);
		  param1_01 = unnamed_function_1417
		                        (
		                        UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs__TypeInfo
		                        );
		  UI_Windows_DialogWindow_DialogWindowArgs___ctor
		            (param1_01,
		             Method_UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs___ctor__
		            );
		  uVar2 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_16790,1,0,1,0,0,0,0);
		  *(undefined4 *)(param1_01 + 8) = uVar2;
		  iVar1 = 
		  Method_System_Collections_Generic_List_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs___Add__
		  ;
		  *(int *)(param1_02 + 0x10) = *(int *)(param1_02 + 0x10) + 1;
		  uVar3 = *(uint *)(param1_02 + 0xc);
		  if (uVar3 < *(uint *)(*(int *)(param1_02 + 8) + 0xc)) {
		    *(uint *)(param1_02 + 0xc) = uVar3 + 1;
		    *(int *)(*(int *)(param1_02 + 8) + uVar3 * 4 + 0x10) = param1_01;
		  }
		  else {
		    System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		              (param1_02,param1_01,*(undefined4 *)(*(int *)(*(int *)(iVar1 + 0x10) + 0x60) + 0x38));
		  }
		  uVar2 = UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_ButtonCallbackDelegate_object____ctor
		                    (param1_00,0);
		  return uVar2;
		}
		*/

		}

		// Token: 0x06004018 RID: 16408 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6004018")]
		[Address(RVA = "0x8ED2", Offset = "0x8ED2", VA = "0x8ED2")]
		private DialogWindow ShowClanRatingInfoWindow(ClanRatingKindDic dic)
		{
			return null;
		}

		// Token: 0x06004019 RID: 16409 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004019")]
		[Address(RVA = "0x8ED3", Offset = "0x8ED3", VA = "0x8ED3", Slot = "21")]
		public void Hide()
		{
		}

		// Token: 0x040023C5 RID: 9157
		[Token(Token = "0x40023C5")]
		[FieldOffset(Offset = "0x18")]
		private ClanInRatingListElement.ClanInRatingListElementArgs _selectedArgs;

		// Token: 0x040023C6 RID: 9158
		[Token(Token = "0x40023C6")]
		[FieldOffset(Offset = "0x1C")]
		private ClanRatingTypes _ratingType;

		// Token: 0x040023C7 RID: 9159
		[Token(Token = "0x40023C7")]
		[FieldOffset(Offset = "0x20")]
		private RatingPeriods _ratingPeriod;

		// Token: 0x040023C8 RID: 9160
		[Token(Token = "0x40023C8")]
		[FieldOffset(Offset = "0x24")]
		private string _searchValue;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_View ---
		void Gameplay_Clans_Office_Controller_VacanciesViewMediator__set_View(int *param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  undefined4 uVar2;
		  undefined4 uVar3;
		  int *piVar4;
		  int iVar5;
		  
		  if (DAT_ram_00a576d5 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_string__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_object__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Events_UnityAction_SubRatingListElementArgs__TypeInfo)
		    ;
		    Mono_Security_ASN1__get_Item(&UnityEngine_Events_UnityAction_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_UnityEngine_Events_UnityEvent_SubRatingListElementArgs__RemoveListener__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Clans_Office_Controller_VacanciesViewMediator_AvailableFilterChangedEventHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Clans_Office_Controller_VacanciesViewMediator_ClanInfoButtonClickedEventHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Clans_Office_Controller_VacanciesViewMediator_FilterSelectedEventHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Clans_Office_Controller_VacanciesViewMediator_InfoButtonClickedEventHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Clans_Office_Controller_VacanciesViewMediator_InputChangedEventHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Clans_Office_Controller_VacanciesViewMediator_MoreItemsAfterNeededEventHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Clans_Office_Controller_VacanciesViewMediator_MoreItemsBeforeNeededEventHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Clans_Office_Controller_VacanciesViewMediator_RequestButtonClickedEventHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Clans_Office_Controller_VacanciesViewMediator_ResetButtonClickedEventHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Clans_Office_Controller_VacanciesViewMediator_SearchButtonClickedEventHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Clans_Office_Controller_VacanciesViewMediator_SubRatingSelectedEventHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Clans_Office_Controller_VacanciesViewMediator_WithdrawButtonClickedEventHandler__
		              );
		    DAT_ram_00a576d5 = '\x01';
		  }
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar2 = Gameplay_Clans_Office_View_ClanWarsTab_ClanPoliticsTab_ClanPoliticsView__get_MyZigguratButton
		                    (uVar1,0);
		  uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar3,param1,
		             Method_Gameplay_Clans_Office_Controller_VacanciesViewMediator_MoreItemsAfterNeededEventHandler__
		             ,0);
		  piVar4 = (int *)func_ii_7048(uVar2,uVar3,0);
		  if ((piVar4 != (int *)0x0) && (System_Action_TypeInfo != *piVar4)) {
		    System_Activator__CreateInstance(piVar4,System_Action_TypeInfo);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  Gameplay_Clans_Office_View_ClanWarsTab_ClanPoliticsTab_ClanPoliticsView__get_MoreItemsAfterNeededEvent
		            (uVar1,piVar4,0);
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar2 = Gameplay_Clans_Office_View_VacanciesTab_VacanciesView__set_MoreItemsAfterNeededEvent
		                    (uVar1,0);
		  uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar3,param1,
		             Method_Gameplay_Clans_Office_Controller_VacanciesViewMediator_MoreItemsBeforeNeededEventHandler__
		             ,0);
		  piVar4 = (int *)func_ii_7048(uVar2,uVar3,0);
		  if ((piVar4 != (int *)0x0) && (System_Action_TypeInfo != *piVar4)) {
		    System_Activator__CreateInstance(piVar4,System_Action_TypeInfo);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  Gameplay_Clans_Office_View_VacanciesTab_VacanciesView__get_MoreItemsBeforeNeededEvent
		            (uVar1,piVar4,0);
		  iVar5 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar2 = *(undefined4 *)(*(int *)(iVar5 + 0x14) + 0x18);
		  uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_SubRatingListElementArgs__TypeInfo);
		  func_ii_7054(uVar1,param1,
		               Method_Gameplay_Clans_Office_Controller_VacanciesViewMediator_SubRatingSelectedEventHandler__
		               ,0);
		  UnityEngine_Events_UnityEvent_InputAction_CallbackContext___Invoke
		            (uVar2,uVar1,
		             Method_UnityEngine_Events_UnityEvent_SubRatingListElementArgs__RemoveListener__);
		  iVar5 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar2 = *(undefined4 *)(iVar5 + 0x18);
		  uVar1 = unnamed_function_1417(System_Action_object__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar1,param1,
		             Method_Gameplay_Clans_Office_Controller_VacanciesViewMediator_FilterSelectedEventHandler__
		             ,0);
		  UI_Elements_Filters_GenericFilter_GenericFilterView__add_SelectedEvent(uVar2,uVar1,0);
		  iVar5 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar2 = *(undefined4 *)(iVar5 + 0x24);
		  uVar1 = unnamed_function_1417(System_Action_string__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar1,param1,
		             Method_Gameplay_Clans_Office_Controller_VacanciesViewMediator_InputChangedEventHandler__
		             ,0);
		  UI_SearchInput__add_InputChangedEvent(uVar2,uVar1,0);
		  iVar5 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar2 = *(undefined4 *)(iVar5 + 0x20);
		  uVar1 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar1,param1,
		             Method_Gameplay_Clans_Office_Controller_VacanciesViewMediator_AvailableFilterChangedEventHandler__
		             ,0);
		  UI_Toggle_GreenToggle__add_ChangedEvent(uVar2,uVar1,0);
		  iVar5 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar2 = *(undefined4 *)(*(int *)(iVar5 + 0x28) + 0xb4);
		  uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		  Utils_ObjectUtils__IsNotNull
		            (uVar1,param1,
		             Method_Gameplay_Clans_Office_Controller_VacanciesViewMediator_SearchButtonClickedEventHandler__
		             ,0);
		  UnityEngine_Events_UnityAction___ctor(uVar2,uVar1,0);
		  iVar5 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar2 = *(undefined4 *)(*(int *)(iVar5 + 0x2c) + 0xb4);
		  uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		  Utils_ObjectUtils__IsNotNull
		            (uVar1,param1,
		             Method_Gameplay_Clans_Office_Controller_VacanciesViewMediator_ResetButtonClickedEventHandler__
		             ,0);
		  UnityEngine_Events_UnityAction___ctor(uVar2,uVar1,0);
		  iVar5 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar2 = *(undefined4 *)(*(int *)(*(int *)(iVar5 + 0x1c) + 0x2c) + 0xb4);
		  uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		  Utils_ObjectUtils__IsNotNull
		            (uVar1,param1,
		             Method_Gameplay_Clans_Office_Controller_VacanciesViewMediator_ClanInfoButtonClickedEventHandler__
		             ,0);
		  UnityEngine_Events_UnityAction___ctor(uVar2,uVar1,0);
		  iVar5 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar2 = *(undefined4 *)(*(int *)(*(int *)(iVar5 + 0x1c) + 0x30) + 0xb4);
		  uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		  Utils_ObjectUtils__IsNotNull
		            (uVar1,param1,
		             Method_Gameplay_Clans_Office_Controller_VacanciesViewMediator_RequestButtonClickedEventHandler__
		             ,0);
		  UnityEngine_Events_UnityAction___ctor(uVar2,uVar1,0);
		  iVar5 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar2 = *(undefined4 *)(*(int *)(*(int *)(iVar5 + 0x1c) + 0x34) + 0xb4);
		  uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		  Utils_ObjectUtils__IsNotNull
		            (uVar1,param1,
		             Method_Gameplay_Clans_Office_Controller_VacanciesViewMediator_WithdrawButtonClickedEventHandler__
		             ,0);
		  UnityEngine_Events_UnityAction___ctor(uVar2,uVar1,0);
		  iVar5 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar2 = *(undefined4 *)(*(int *)(iVar5 + 0x34) + 0xb4);
		  uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		  Utils_ObjectUtils__IsNotNull
		            (uVar1,param1,
		             Method_Gameplay_Clans_Office_Controller_VacanciesViewMediator_InfoButtonClickedEventHandler__
		             ,0);
		  UnityEngine_Events_UnityAction___ctor(uVar2,uVar1,0);
		  return;
		}
		*/

}
