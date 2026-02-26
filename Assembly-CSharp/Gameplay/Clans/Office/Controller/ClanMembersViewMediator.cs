using System;
using Core.Money;
using Gameplay.Clans.Office.Events;
using Gameplay.Clans.Office.Model;
using Gameplay.Clans.Office.View.ClanMembersTab;
using Il2CppDummyDll;
using MVC;
using MVC.Interfaces;
using Protocol.Rating;
using UI.Elements.RatingElements.SubRatings;
using UI.Windows;

namespace Gameplay.Clans.Office.Controller
{
	// Token: 0x02000A6A RID: 2666
	[Token(Token = "0x2000A6A")]
	public class ClanMembersViewMediator : AbstractViewMediator<ClanInfoModel, ClanInfoEvents, ClanInfoController, ClanMembersView>, IHideableMediator
	{
		// Token: 0x06003F19 RID: 16153 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003F19")]
		[Address(RVA = "0x8DD4", Offset = "0x8DD4", VA = "0x8DD4")]
		public ClanMembersViewMediator(ClanInfoModel model, ClanInfoEvents events, ClanInfoController controller)
		{
		/* --- GHIDRA: <ShowBuyPlaceConfirmationWindow>b__38_0 ---
		void Gameplay_Clans_Office_Controller_ClanMembersViewMediator___ShowBuyPlaceConfirmationWindow_b__38_0
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4,undefined4 param5)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a58013 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_MVC_AbstractController_ClanOfficeModel__ClanOfficeEvents___ctor__);
		    Mono_Security_ASN1__get_Item(&Method_Core_Net_ServiceFactory_GetService_ClansService___);
		    Mono_Security_ASN1__get_Item(&Core_Net_ServiceFactory_TypeInfo);
		    DAT_ram_00a58013 = '\x01';
		  }
		  Gameplay_Combat_AbstractCombat_object__object__object__object__object___set_User
		            (param1,param2,param3,
		             Method_MVC_AbstractController_ClanOfficeModel__ClanOfficeEvents___ctor__);
		  if (*(int *)(Core_Net_ServiceFactory_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Net_ServiceFactory_TypeInfo);
		  }
		  uVar1 = Core_Gameplay_Managers_LoggedManager__RequestLogin
		                    (Method_Core_Net_ServiceFactory_GetService_ClansService___);
		  *(undefined4 *)(param1 + 0x1c) = param4;
		  *(undefined4 *)(param1 + 0x18) = uVar1;
		  return;
		}
		*/

		/* --- GHIDRA: <ShowDisbandConfirmationWindow>b__37_0 ---
		void Gameplay_Clans_Office_Controller_ClanMembersViewMediator___ShowDisbandConfirmationWindow_b__37_0
		               (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 param1_00;
		  
		  param1_00 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x14c));
		  Gameplay_Clans_Office_Controller_ClanInfoController__AppointHeadResultHandler(param1_00,param1);
		  return;
		}
		*/

		/* --- GHIDRA: <ShowLeaveConfirmationWindow>b__36_0 ---
		void Gameplay_Clans_Office_Controller_ClanMembersViewMediator___ShowLeaveConfirmationWindow_b__36_0
		               (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  int *piVar1;
		  int iVar2;
		  int param1_00;
		  
		  piVar1 = (int *)(**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                            (param1,*(undefined4 *)(*param1 + 0x14c));
		  param1_00 = piVar1[6];
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*piVar1 + 0x100) * 4))
		                    (piVar1,*(undefined4 *)(*piVar1 + 0x104));
		  Gameplay_Clans_Controller_ClansController__UserInfoChangedEventHandler
		            (param1_00,*(undefined4 *)(*(int *)(iVar2 + 0x30) + 0xc),0);
		  return;
		}
		*/

		/* --- GHIDRA: <DrawMembersList>b__20_0 ---
		void Gameplay_Clans_Office_Controller_ClanMembersViewMediator___DrawMembersList_b__20_0
		               (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x14c));
		  Gameplay_Clans_Controller_ClansController__KickMemberResultHandler
		            (*(undefined4 *)(iVar1 + 0x18),0);
		  return;
		}
		*/

		/* --- GHIDRA: .ctor ---
		void Gameplay_Clans_Office_Controller_ClanMembersViewMediator___ctor
		               (int *param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  undefined4 uVar3;
		  
		  if (DAT_ram_00a57ffd == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_ClanInfoModel__ClanInfoEvents__ClanInfoController__ClanMembersView__set_View__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_object__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Clans_Office_Controller_ClanMembersViewMediator_AddVacancyButtonClickedEventHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Clans_Office_Controller_ClanMembersViewMediator_FilterSelectedEventHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Clans_Office_Controller_ClanMembersViewMediator_JoinButtonClickedEventHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Clans_Office_Controller_ClanMembersViewMediator_OpenClanToggleChangedEventHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Clans_Office_Controller_ClanMembersViewMediator_SubRatingSelectedEventHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Clans_Office_Controller_ClanMembersViewMediator_WithdrawButtonClickedEventHandler__
		              );
		    Mono_Security_ASN1__get_Item(&UnityEngine_Events_UnityAction_SubRatingListElementArgs__TypeInfo)
		    ;
		    Mono_Security_ASN1__get_Item(&UnityEngine_Events_UnityAction_bool__TypeInfo);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Events_UnityAction_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Events_UnityEvent_bool__AddListener__);
		    Mono_Security_ASN1__get_Item
		              (&Method_UnityEngine_Events_UnityEvent_SubRatingListElementArgs__AddListener__);
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Events_UnityEvent_bool__RemoveListener__);
		    Mono_Security_ASN1__get_Item
		              (&Method_UnityEngine_Events_UnityEvent_SubRatingListElementArgs__RemoveListener__);
		    DAT_ram_00a57ffd = '\x01';
		  }
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar2 = Cysharp_Threading_Tasks_CancellationTokenExtensions___cctor(uVar1,0);
		  if (iVar2 != 0) {
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar3 = *(undefined4 *)(iVar2 + 0x20);
		    uVar1 = unnamed_function_1417(System_Action_object__TypeInfo);
		    UnityEngine_UIElements_VisualElement__get_layout
		              (uVar1,param1,
		               Method_Gameplay_Clans_Office_Controller_ClanMembersViewMediator_FilterSelectedEventHandler__
		               ,0);
		    UI_Elements_Filters_GenericFilter_GenericFilterView__add_SelectedEvent(uVar3,uVar1,0);
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar3 = *(undefined4 *)(*(int *)(iVar2 + 0x1c) + 0x18);
		    uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_SubRatingListElementArgs__TypeInfo)
		    ;
		    func_ii_7054(uVar1,param1,
		                 Method_Gameplay_Clans_Office_Controller_ClanMembersViewMediator_SubRatingSelectedEventHandler__
		                 ,0);
		    UnityEngine_Events_UnityEvent_InputAction_CallbackContext___Invoke
		              (uVar3,uVar1,
		               Method_UnityEngine_Events_UnityEvent_SubRatingListElementArgs__RemoveListener__);
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar3 = *(undefined4 *)(*(int *)(iVar2 + 0x34) + 0xb4);
		    uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		    Utils_ObjectUtils__IsNotNull
		              (uVar1,param1,
		               Method_Gameplay_Clans_Office_Controller_ClanMembersViewMediator_JoinButtonClickedEventHandler__
		               ,0);
		    UnityEngine_Events_UnityAction___ctor(uVar3,uVar1,0);
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar3 = *(undefined4 *)(*(int *)(iVar2 + 0x38) + 0xb4);
		    uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		    Utils_ObjectUtils__IsNotNull
		              (uVar1,param1,
		               Method_Gameplay_Clans_Office_Controller_ClanMembersViewMediator_WithdrawButtonClickedEventHandler__
		               ,0);
		    UnityEngine_Events_UnityAction___ctor(uVar3,uVar1,0);
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar3 = *(undefined4 *)(*(int *)(iVar2 + 0x3c) + 0xb4);
		    uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		    Utils_ObjectUtils__IsNotNull
		              (uVar1,param1,
		               Method_Gameplay_Clans_Office_Controller_ClanMembersViewMediator_AddVacancyButtonClickedEventHandler__
		               ,0);
		    UnityEngine_Events_UnityAction___ctor(uVar3,uVar1,0);
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar3 = *(undefined4 *)(*(int *)(iVar2 + 0x40) + 0xc0);
		    uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_bool__TypeInfo);
		    UnityEngine_UI_Toggle__set_group
		              (uVar1,param1,
		               Method_Gameplay_Clans_Office_Controller_ClanMembersViewMediator_OpenClanToggleChangedEventHandler__
		               ,0);
		    UnityEngine_Events_UnityEvent_InputAction_CallbackContext___Invoke
		              (uVar3,uVar1,Method_UnityEngine_Events_UnityEvent_bool__RemoveListener__);
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    func_ii_14558(*(undefined4 *)(*(int *)(*(int *)(iVar2 + 0x28) + 0x1c) + 0xb4),0);
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    func_ii_14558(*(undefined4 *)(*(int *)(*(int *)(iVar2 + 0x28) + 0x20) + 0xb4),0);
		  }
		  param1[5] = param2;
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar2 = Cysharp_Threading_Tasks_CancellationTokenExtensions___cctor(uVar1,0);
		  if (iVar2 != 0) {
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar3 = *(undefined4 *)(iVar2 + 0x20);
		    uVar1 = unnamed_function_1417(System_Action_object__TypeInfo);
		    UnityEngine_UIElements_VisualElement__get_layout
		              (uVar1,param1,
		               Method_Gameplay_Clans_Office_Controller_ClanMembersViewMediator_FilterSelectedEventHandler__
		               ,0);
		    UI_Elements_Filters_GenericFilter_FilterWithIconListElement_FilterWithIconData___ctor
		              (uVar3,uVar1,0);
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar3 = *(undefined4 *)(*(int *)(iVar2 + 0x1c) + 0x18);
		    uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_SubRatingListElementArgs__TypeInfo)
		    ;
		    func_ii_7054(uVar1,param1,
		                 Method_Gameplay_Clans_Office_Controller_ClanMembersViewMediator_SubRatingSelectedEventHandler__
		                 ,0);
		    UnityEngine_Events_UnityEvent_InputAction_CallbackContext____ctor
		              (uVar3,uVar1,
		               Method_UnityEngine_Events_UnityEvent_SubRatingListElementArgs__AddListener__);
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar3 = *(undefined4 *)(*(int *)(iVar2 + 0x34) + 0xb4);
		    uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		    Utils_ObjectUtils__IsNotNull
		              (uVar1,param1,
		               Method_Gameplay_Clans_Office_Controller_ClanMembersViewMediator_JoinButtonClickedEventHandler__
		               ,0);
		    Gameplay_Boss_View_CaptainTab_BossInfoView__add_AttackButtonClickEvent(uVar3,uVar1,0);
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar3 = *(undefined4 *)(*(int *)(iVar2 + 0x38) + 0xb4);
		    uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		    Utils_ObjectUtils__IsNotNull
		              (uVar1,param1,
		               Method_Gameplay_Clans_Office_Controller_ClanMembersViewMediator_WithdrawButtonClickedEventHandler__
		               ,0);
		    Gameplay_Boss_View_CaptainTab_BossInfoView__add_AttackButtonClickEvent(uVar3,uVar1,0);
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar3 = *(undefined4 *)(*(int *)(iVar2 + 0x3c) + 0xb4);
		    uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		    Utils_ObjectUtils__IsNotNull
		              (uVar1,param1,
		               Method_Gameplay_Clans_Office_Controller_ClanMembersViewMediator_AddVacancyButtonClickedEventHandler__
		               ,0);
		    Gameplay_Boss_View_CaptainTab_BossInfoView__add_AttackButtonClickEvent(uVar3,uVar1,0);
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar3 = *(undefined4 *)(*(int *)(iVar2 + 0x40) + 0xc0);
		    uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_bool__TypeInfo);
		    UnityEngine_UI_Toggle__set_group
		              (uVar1,param1,
		               Method_Gameplay_Clans_Office_Controller_ClanMembersViewMediator_OpenClanToggleChangedEventHandler__
		               ,0);
		    UnityEngine_Events_UnityEvent_InputAction_CallbackContext____ctor
		              (uVar3,uVar1,Method_UnityEngine_Events_UnityEvent_bool__AddListener__);
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    func_ii_14558(*(undefined4 *)(*(int *)(iVar2 + 0x2c) + 0xb4),0);
		    Gameplay_Clans_Office_Controller_ClanMembersViewMediator__AddVacancyButtonClickedEventHandler
		              (param1,param1);
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		              (*(undefined4 *)(iVar2 + 0x44),1,0);
		    Gameplay_Clans_Office_Controller_ClanMembersViewMediator__set_View(param1,param1);
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x14c));
		    if (*(char *)(iVar2 + 9) != '\0') {
		      Gameplay_Clans_Office_Controller_ClanMembersViewMediator__JoinRequestSentEventHandler
		                (param1,param1);
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x17000C9C RID: 3228
		// (set) Token: 0x06003F1A RID: 16154 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000C9C")]
		public override ClanMembersView View
		{
			[Token(Token = "0x6003F1A")]
			[Address(RVA = "0x8DD5", Offset = "0x8DD5", VA = "0x8DD5", Slot = "20")]
			set
			{
			}
		}

		// Token: 0x06003F1B RID: 16155 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003F1B")]
		[Address(RVA = "0x8DD6", Offset = "0x8DD6", VA = "0x8DD6")]
		private void Init()
		{
		/* --- GHIDRA: Init ---
		void Gameplay_Clans_Office_Controller_ClanMembersViewMediator__Init
		               (int *param1,int param2,undefined4 param3)
		
		{
		  undefined4 param1_00;
		  undefined4 param2_00;
		  
		  param1_00 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x14c));
		  param2_00 = 2;
		  if (param2 == 0) {
		    param2_00 = 0;
		  }
		  Gameplay_Clans_Office_Controller_ClanInfoController__AddVacancyResultHandler
		            (param1_00,param2_00,param1);
		  return;
		}
		*/

		}

		// Token: 0x06003F1C RID: 16156 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003F1C")]
		[Address(RVA = "0x8DD7", Offset = "0x8DD7", VA = "0x8DD7")]
		private void OpenClanToggleChangedEventHandler(bool enable)
		{
		/* --- GHIDRA: OpenClanToggleChangedEventHandler ---
		void Gameplay_Clans_Office_Controller_ClanMembersViewMediator__OpenClanToggleChangedEventHandler
		               (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 param1_00;
		  undefined4 param2_00;
		  
		  if (DAT_ram_00a57fff == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_ClanInfoModel__ClanInfoEvents__ClanInfoController__ClanMembersView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&Core_Money_Money_TypeInfo);
		    DAT_ram_00a57fff = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  param1_00 = *(undefined4 *)(*(int *)(iVar1 + 0x3c) + 0xb8);
		  iVar1 = param1[2];
		  param2_00 = *(undefined4 *)(*(int *)(iVar1 + 0x24) + 0x18);
		  uVar2 = Gameplay_Clans_Office_Model_ClanInfoModel__PopulateMembers(iVar1,iVar1);
		  if (*(int *)(Core_Money_Money_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Money_Money_TypeInfo);
		  }
		  uVar2 = Core_Money_Money__op_Explicit(uVar2,0);
		  UI_Price_Price__SetColor(param1_00,param2_00,uVar2,0);
		  return;
		}
		*/

		}

		// Token: 0x06003F1D RID: 16157 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003F1D")]
		[Address(RVA = "0x8DD8", Offset = "0x8DD8", VA = "0x8DD8")]
		private void UpdateAddVacancyPrice()
		{
		/* --- GHIDRA: UpdateAddVacancyPrice ---
		void Gameplay_Clans_Office_Controller_ClanMembersViewMediator__UpdateAddVacancyPrice
		               (int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a58000 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_ClanInfoModel__ClanInfoEvents__ClanInfoController__ClanMembersView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&Core_Money_Money_TypeInfo);
		    DAT_ram_00a58000 = '\x01';
		  }
		  uVar1 = Gameplay_Clans_Office_Model_ClanInfoModel__PopulateMembers
		                    (*(undefined4 *)(param1 + 8),param1);
		  if (*(int *)(Core_Money_Money_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Money_Money_TypeInfo);
		  }
		  uVar1 = Core_Money_Money__op_Explicit(uVar1,0);
		  Gameplay_Clans_Office_Controller_ClanMembersViewMediator__ShowDisbandConfirmationWindow
		            (param1,uVar1,param1);
		  return;
		}
		*/

		}

		// Token: 0x06003F1E RID: 16158 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003F1E")]
		[Address(RVA = "0x8DD9", Offset = "0x8DD9", VA = "0x8DD9")]
		private void AddVacancyButtonClickedEventHandler()
		{
		/* --- GHIDRA: AddVacancyButtonClickedEventHandler ---
		void Gameplay_Clans_Office_Controller_ClanMembersViewMediator__AddVacancyButtonClickedEventHandler
		               (int *param1,undefined4 param2)
		
		{
		  undefined4 *puVar1;
		  undefined4 *puVar2;
		  int iVar3;
		  undefined4 uVar4;
		  int iVar5;
		  undefined4 uVar6;
		  
		  if (DAT_ram_00a58001 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_ClanInfoModel__ClanInfoEvents__ClanInfoController__ClanMembersView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Clans_Office_Controller_ClanMembersViewMediator_AssignLeaderButtonClickedEventHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Clans_Office_Controller_ClanMembersViewMediator_KickButtonClickedEventHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Clans_Office_Controller_ClanMembersViewMediator_ToUserIsleButtonClickedEventHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Clans_Office_Controller_ClanMembersViewMediator_UserInfoButtonClickedEventHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_UnityEngine_Component_GetComponentInChildren_TextMeshProUGUI___);
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Events_UnityAction_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_9094);
		    Mono_Security_ASN1__get_Item(&StringLiteral_4317);
		    Mono_Security_ASN1__get_Item(&StringLiteral_4308);
		    Mono_Security_ASN1__get_Item(&StringLiteral_3645);
		    DAT_ram_00a58001 = '\x01';
		  }
		  iVar5 = *(int *)(param1[2] + 0x20);
		  iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar6 = *(undefined4 *)(*(int *)(*(int *)(iVar3 + 0x28) + 0x1c) + 0xb4);
		  uVar4 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		  if (iVar5 == 3) {
		    Utils_ObjectUtils__IsNotNull
		              (uVar4,param1,
		               Method_Gameplay_Clans_Office_Controller_ClanMembersViewMediator_AssignLeaderButtonClickedEventHandler__
		               ,0);
		    Gameplay_Boss_View_CaptainTab_BossInfoView__add_AttackButtonClickEvent(uVar6,uVar4,0);
		    iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar6 = *(undefined4 *)(*(int *)(*(int *)(iVar3 + 0x28) + 0x20) + 0xb4);
		    uVar4 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		    Utils_ObjectUtils__IsNotNull
		              (uVar4,param1,
		               Method_Gameplay_Clans_Office_Controller_ClanMembersViewMediator_KickButtonClickedEventHandler__
		               ,0);
		    Gameplay_Boss_View_CaptainTab_BossInfoView__add_AttackButtonClickEvent(uVar6,uVar4,0);
		    iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar4 = UI_Rewards_AbstractRewardsRender__SetRewards
		                      (*(undefined4 *)(*(int *)(iVar3 + 0x28) + 0x1c),
		                       Method_UnityEngine_Component_GetComponentInChildren_TextMeshProUGUI___);
		    puVar1 = &StringLiteral_4308;
		    puVar2 = &StringLiteral_4317;
		    iVar3 = *(int *)(Core_GameLocalization_TypeInfo + 0x74);
		  }
		  else {
		    Utils_ObjectUtils__IsNotNull
		              (uVar4,param1,
		               Method_Gameplay_Clans_Office_Controller_ClanMembersViewMediator_ToUserIsleButtonClickedEventHandler__
		               ,0);
		    Gameplay_Boss_View_CaptainTab_BossInfoView__add_AttackButtonClickEvent(uVar6,uVar4,0);
		    iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar6 = *(undefined4 *)(*(int *)(*(int *)(iVar3 + 0x28) + 0x20) + 0xb4);
		    uVar4 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		    Utils_ObjectUtils__IsNotNull
		              (uVar4,param1,
		               Method_Gameplay_Clans_Office_Controller_ClanMembersViewMediator_UserInfoButtonClickedEventHandler__
		               ,0);
		    Gameplay_Boss_View_CaptainTab_BossInfoView__add_AttackButtonClickEvent(uVar6,uVar4,0);
		    iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar4 = UI_Rewards_AbstractRewardsRender__SetRewards
		                      (*(undefined4 *)(*(int *)(iVar3 + 0x28) + 0x1c),
		                       Method_UnityEngine_Component_GetComponentInChildren_TextMeshProUGUI___);
		    puVar1 = &StringLiteral_9094;
		    puVar2 = &StringLiteral_3645;
		    iVar3 = *(int *)(Core_GameLocalization_TypeInfo + 0x74);
		  }
		  if (iVar3 == 0) {
		    func_ii_306000(Core_GameLocalization_TypeInfo);
		  }
		  uVar6 = Core_Extensions_Dict_CultDicExt__GetTitle(*puVar2,1,0,1,0,0,0,0);
		  UnityEngine_Component__GetComponentInChildren_object_(uVar4,uVar6,0);
		  iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar4 = UI_Rewards_AbstractRewardsRender__SetRewards
		                    (*(undefined4 *)(*(int *)(iVar3 + 0x28) + 0x20),
		                     Method_UnityEngine_Component_GetComponentInChildren_TextMeshProUGUI___);
		  uVar6 = Core_Extensions_Dict_CultDicExt__GetTitle(*puVar1,1,0,1,0,0,0,0);
		  UnityEngine_Component__GetComponentInChildren_object_(uVar4,uVar6,0);
		  return;
		}
		*/

		}

		// Token: 0x06003F1F RID: 16159 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003F1F")]
		[Address(RVA = "0x8DDA", Offset = "0x8DDA", VA = "0x8DDA")]
		private void SetupLeftRightButtons()
		{
		/* --- GHIDRA: SetupLeftRightButtons ---
		void Gameplay_Clans_Office_Controller_ClanMembersViewMediator__SetupLeftRightButtons
		               (int *param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  
		  param1_00 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x14c));
		  Gameplay_Clans_Office_Controller_ClanInfoController__LeaveClan
		            (param1_00,*(undefined4 *)(param1[6] + 0x18),param1);
		  return;
		}
		*/

		}

		// Token: 0x06003F20 RID: 16160 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003F20")]
		[Address(RVA = "0x8DDB", Offset = "0x8DDB", VA = "0x8DDB")]
		private void AssignLeaderButtonClickedEventHandler()
		{
		/* --- GHIDRA: AssignLeaderButtonClickedEventHandler ---
		void Gameplay_Clans_Office_Controller_ClanMembersViewMediator__AssignLeaderButtonClickedEventHandler
		               (int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 param1_00;
		  int *param1_01;
		  int iVar3;
		  
		  if (DAT_ram_00a58002 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a58002 = '\x01';
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
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + iVar3 + 0x230);
		        goto code_r0x80e925fb;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_01,Core_Gameplay_IGame_TypeInfo,0x2e);
		code_r0x80e925fb:
		  param1_00 = (**(code **)((ulonglong)*puVar2 * 4))(param1_01,puVar2[1]);
		  Core_Gameplay_Managers_ClansManager__ShowClanInfoPopupWindow
		            (param1_00,*(undefined4 *)(*(int *)(param1 + 0x18) + 0x18),0);
		  return;
		}
		*/

		}

		// Token: 0x06003F21 RID: 16161 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003F21")]
		[Address(RVA = "0x8DDC", Offset = "0x8DDC", VA = "0x8DDC")]
		private void KickButtonClickedEventHandler()
		{
		/* --- GHIDRA: KickButtonClickedEventHandler ---
		void Gameplay_Clans_Office_Controller_ClanMembersViewMediator__KickButtonClickedEventHandler
		               (int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  undefined4 in_register_20000014;
		  uint *puVar2;
		  undefined4 uVar3;
		  undefined8 param2_00;
		  int *param1_00;
		  int iVar4;
		  
		  if (DAT_ram_00a58003 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a58003 = '\x01';
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
		        goto code_r0x80e926d8;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_00,Core_Gameplay_IGame_TypeInfo,10);
		code_r0x80e926d8:
		  uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(param1_00,CONCAT44(in_register_20000014,puVar2[1]));
		  param2_00 = System_Collections_Generic_LinkedList_Enumerator_object___MoveNext
		                        (*(undefined4 *)(*(int *)(param1 + 0x18) + 0x18),0);
		  Core_Gameplay_Managers_WorldManager__GoHome(uVar3,param2_00,0);
		  uVar3 = System_Uri___ctor(0);
		  uVar3 = System_Globalization_TimeSpanFormat_FormatLiterals__get_Start(uVar3,0);
		  UI_Windows_PopupController__Close(uVar3,2,0);
		  return;
		}
		*/

		}

		// Token: 0x06003F22 RID: 16162 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003F22")]
		[Address(RVA = "0x8DDD", Offset = "0x8DDD", VA = "0x8DDD")]
		private void ToUserIsleButtonClickedEventHandler()
		{
		/* --- GHIDRA: ToUserIsleButtonClickedEventHandler ---
		void Gameplay_Clans_Office_Controller_ClanMembersViewMediator__ToUserIsleButtonClickedEventHandler
		               (int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 param1_00;
		  undefined4 param1_01;
		  int *param1_02;
		  int iVar3;
		  undefined4 param2_00;
		  
		  if (DAT_ram_00a58004 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_UserInfo_View_UserInfoWindow_UserInfoWindowArgs_TypeInfo)
		    ;
		    DAT_ram_00a58004 = '\x01';
		  }
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  uVar1 = 0;
		  param1_02 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar3 = *param1_02;
		  if (*(ushort *)(iVar3 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + iVar3 + 0x1b0);
		        goto code_r0x80e927d6;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_02,Core_Gameplay_IGame_TypeInfo,0x1e);
		code_r0x80e927d6:
		  param1_00 = (**(code **)((ulonglong)*puVar2 * 4))(param1_02,puVar2[1]);
		  param2_00 = *(undefined4 *)(*(int *)(param1 + 0x18) + 0x18);
		  param1_01 = unnamed_function_1417
		                        (Gameplay_UserInfo_View_UserInfoWindow_UserInfoWindowArgs_TypeInfo);
		  Core_Browser_BrowserWindow___ctor(param1_01,param2_00,0);
		  Core_Gameplay_Managers_GameActivityRouting_GameFeatureRouterManager__ShowCraft
		            (param1_00,param1_01,0);
		  return;
		}
		*/

		}

		// Token: 0x06003F23 RID: 16163 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003F23")]
		[Address(RVA = "0x8DDE", Offset = "0x8DDE", VA = "0x8DDE")]
		private void UserInfoButtonClickedEventHandler()
		{
		/* --- GHIDRA: UserInfoButtonClickedEventHandler ---
		void Gameplay_Clans_Office_Controller_ClanMembersViewMediator__UserInfoButtonClickedEventHandler
		               (int *param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  
		  param1_00 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x14c));
		  Gameplay_Clans_Office_Controller_ClanInfoController__RequestJoinClanResultHandler
		            (param1_00,param1);
		  return;
		}
		*/

		}

		// Token: 0x06003F24 RID: 16164 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003F24")]
		[Address(RVA = "0x8DDF", Offset = "0x8DDF", VA = "0x8DDF")]
		private void WithdrawButtonClickedEventHandler()
		{
		/* --- GHIDRA: WithdrawButtonClickedEventHandler ---
		void Gameplay_Clans_Office_Controller_ClanMembersViewMediator__WithdrawButtonClickedEventHandler
		               (int *param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  
		  param1_00 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x14c));
		  Gameplay_Clans_Office_Controller_ClanInfoController__GetMembersListResultHandler(param1_00,param1)
		  ;
		  return;
		}
		*/

		}

		// Token: 0x06003F25 RID: 16165 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003F25")]
		[Address(RVA = "0x8DE0", Offset = "0x8DE0", VA = "0x8DE0")]
		private void JoinButtonClickedEventHandler()
		{
		/* --- GHIDRA: JoinButtonClickedEventHandler ---
		void Gameplay_Clans_Office_Controller_ClanMembersViewMediator__JoinButtonClickedEventHandler
		               (int param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  
		  *(undefined4 *)(param1 + 0x20) = *(undefined4 *)(*(int *)(param2 + 0xc) + 0xc);
		  iVar1 = *(int *)(param1 + 0x18);
		  if ((iVar1 != 0) && (*(char *)(iVar1 + 0xc) != '\0')) {
		    *(undefined1 *)(iVar1 + 0xc) = 0;
		    iVar1 = *(int *)(iVar1 + 0x10);
		    if (iVar1 != 0) {
		      (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		                (*(undefined4 *)(iVar1 + 0x20),0,*(undefined4 *)(iVar1 + 0x14));
		    }
		  }
		  Gameplay_Clans_Office_Controller_ClanMembersViewMediator__RedrawMembersList(param1,param1);
		  return;
		}
		*/

		}

		// Token: 0x06003F26 RID: 16166 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003F26")]
		[Address(RVA = "0x8DE1", Offset = "0x8DE1", VA = "0x8DE1")]
		private void SubRatingSelectedEventHandler(SubRatingListElementArgs subRating)
		{
		/* --- GHIDRA: SubRatingSelectedEventHandler ---
		void Gameplay_Clans_Office_Controller_ClanMembersViewMediator__SubRatingSelectedEventHandler
		               (int param1,int *param2,undefined4 param3)
		
		{
		  int iVar1;
		  
		  if (DAT_ram_00a58005 == '\0') {
		    Mono_Security_ASN1__get_Item(&Protocol_Dic_RatingTypesDic_TypeInfo);
		    DAT_ram_00a58005 = '\x01';
		  }
		  if ((param2 != (int *)0x0) && (Protocol_Dic_RatingTypesDic_TypeInfo != *param2)) {
		    System_Activator__CreateInstance(param2,Protocol_Dic_RatingTypesDic_TypeInfo);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  *(int *)(param1 + 0x1c) = param2[3];
		  iVar1 = *(int *)(param1 + 0x18);
		  if ((iVar1 != 0) && (*(char *)(iVar1 + 0xc) != '\0')) {
		    *(undefined1 *)(iVar1 + 0xc) = 0;
		    iVar1 = *(int *)(iVar1 + 0x10);
		    if (iVar1 != 0) {
		      (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		                (*(undefined4 *)(iVar1 + 0x20),0,*(undefined4 *)(iVar1 + 0x14));
		    }
		  }
		  Gameplay_Clans_Office_Controller_ClanMembersViewMediator__RedrawMembersList(param1,param1);
		  return;
		}
		*/

		}

		// Token: 0x06003F27 RID: 16167 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003F27")]
		[Address(RVA = "0x8DE2", Offset = "0x8DE2", VA = "0x8DE2")]
		private void FilterSelectedEventHandler(object obj)
		{
		}

		// Token: 0x06003F28 RID: 16168 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003F28")]
		[Address(RVA = "0x8DE3", Offset = "0x8DE3", VA = "0x8DE3")]
		private void RedrawMembersList()
		{
		/* --- GHIDRA: RedrawMembersList ---
		void Gameplay_Clans_Office_Controller_ClanMembersViewMediator__RedrawMembersList
		               (int *param1,undefined4 param2)
		
		{
		  undefined4 in_register_20000014;
		  undefined4 uVar1;
		  int iVar2;
		  int iVar3;
		  uint uVar4;
		  uint uVar5;
		  uint uVar6;
		  uint uVar7;
		  undefined1 local_1;
		  
		  uVar5 = 0;
		  if (DAT_ram_00a58006 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_ClanInfoModel__ClanInfoEvents__ClanInfoController__ClanMembersView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Clans_Office_Controller_ClanMembersViewMediator__DrawMembersList_b__20_0__
		              );
		    Mono_Security_ASN1__get_Item(&OKG_Logs_Debug_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Linq_Enumerable_OrderByDescending_ClanMemberListElement_ClanMemberListElementArgs__ulong___
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Linq_Enumerable_ToArray_ClanMemberListElement_ClanMemberListElementArgs___
		              );
		    Mono_Security_ASN1__get_Item
		              (&System_Func_ClanMemberListElement_ClanMemberListElementArgs__ulong__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_ClanMemberListElement_ClanMemberListElementArgs__get_Count__
		              );
		    Mono_Security_ASN1__get_Item(&StringLiteral_7252);
		    DAT_ram_00a58006 = '\x01';
		  }
		  iVar2 = OKG_Logs_Debug_TypeInfo;
		  iVar3 = *(int *)(param1[2] + 0x34);
		  if ((iVar3 == 0) || (*(int *)(iVar3 + 0xc) == 0)) {
		    if (*(int *)(OKG_Logs_Debug_TypeInfo + 0x74) == 0) {
		      func_ii_306000(OKG_Logs_Debug_TypeInfo);
		    }
		    func_ii_7109(StringLiteral_7252,0);
		    Gameplay_Clans_Office_Controller_ClanMembersViewMediator__MembersRequestedEventHandler
		              (param1,0,iVar2);
		  }
		  else {
		    uVar1 = unnamed_function_1417
		                      (System_Func_ClanMemberListElement_ClanMemberListElementArgs__ulong__TypeInfo)
		    ;
		    func_ii_7542(uVar1,param1,
		                 Method_Gameplay_Clans_Office_Controller_ClanMembersViewMediator__DrawMembersList_b__20_0__
		                 ,0);
		    uVar1 = System_Linq_Enumerable__OrderByDescending_object__long_
		                      (iVar3,uVar1,
		                       Method_System_Linq_Enumerable_OrderByDescending_ClanMemberListElement_ClanMemberListElementArgs__ulong___
		                      );
		    iVar2 = func_ii_6295(uVar1,
		                         Method_System_Linq_Enumerable_ToArray_ClanMemberListElement_ClanMemberListElementArgs___
		                        );
		    uVar4 = *(uint *)(iVar2 + 0xc);
		    if (0 < (int)uVar4) {
		      uVar7 = 0;
		      if (3 < uVar4) {
		        iVar3 = iVar2 + 0x10;
		        do {
		          *(uint *)(*(int *)(iVar3 + uVar7 * 4) + 8) = uVar7 | 1;
		          *(uint *)(*(int *)(iVar3 + (uVar7 | 1) * 4) + 8) = uVar7 | 2;
		          uVar6 = uVar7 | 3;
		          *(uint *)(*(int *)(iVar3 + (uVar7 | 2) * 4) + 8) = uVar6;
		          uVar7 = uVar7 + 4;
		          *(uint *)(*(int *)(iVar3 + uVar6 * 4) + 8) = uVar7;
		          uVar5 = uVar5 + 4;
		        } while (uVar5 != (uVar4 & 0xfffffffc));
		      }
		      if ((uVar4 & 3) != 0) {
		        uVar5 = 0;
		        do {
		          iVar3 = uVar7 * 4;
		          uVar7 = uVar7 + 1;
		          *(uint *)(*(int *)(iVar2 + iVar3 + 0x10) + 8) = uVar7;
		          uVar5 = uVar5 + 1;
		        } while (uVar5 != (uVar4 & 3));
		      }
		    }
		    iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,CONCAT44(in_register_20000014,*(undefined4 *)(*param1 + 0x15c)));
		    iVar3 = *(int *)(iVar3 + 0x24);
		    if (DAT_ram_00a57f80 == '\0') {
		      Mono_Security_ASN1__get_Item
		                (&
		                 Method_Com_TheFallenGames_OSA_Core_OSA_BaseParamsWithPrefab__ClanMembersViewsHolder__SetVirtualAbstractNormalizedScrollPosition__
		                );
		      Mono_Security_ASN1__get_Item
		                (&
		                 Method_Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_ClanMemberListElement_ClanMemberListElementArgs__ResetItems__
		                );
		      DAT_ram_00a57f80 = '\x01';
		    }
		    local_1 = 0;
		    Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_object___RemoveOneFromStart
		              (*(undefined4 *)(iVar3 + 0xa0),iVar2,0,
		               Method_Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_ClanMemberListElement_ClanMemberListElementArgs__ResetItems__
		              );
		    Com_TheFallenGames_OSA_Core_OSA_object__object___SetViewsHolderEnabled
		              (iVar3,1.0,1,&local_1,0,
		               Method_Com_TheFallenGames_OSA_Core_OSA_BaseParamsWithPrefab__ClanMembersViewsHolder__SetVirtualAbstractNormalizedScrollPosition__
		              );
		    Gameplay_Clans_Office_Controller_ClanMembersViewMediator__MembersRequestedEventHandler
		              (param1,*(undefined4 *)(iVar2 + 0x10),iVar3);
		  }
		  return;
		}
		*/

		}

		// Token: 0x06003F29 RID: 16169 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003F29")]
		[Address(RVA = "0x8DE4", Offset = "0x8DE4", VA = "0x8DE4")]
		private void DrawMembersList()
		{
		/* --- GHIDRA: DrawMembersList ---
		void Gameplay_Clans_Office_Controller_ClanMembersViewMediator__DrawMembersList
		               (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 param1_00;
		  undefined4 param2_00;
		  
		  if (DAT_ram_00a58007 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_ClanInfoModel__ClanInfoEvents__ClanInfoController__ClanMembersView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&Core_Money_Money_TypeInfo);
		    DAT_ram_00a58007 = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  param1_00 = *(undefined4 *)(*(int *)(iVar1 + 0x34) + 0xb8);
		  iVar1 = param1[2];
		  param2_00 = *(undefined4 *)(iVar1 + 8);
		  uVar2 = Gameplay_Clans_Office_Model_ClanInfoModel__CreateUserRatingSubFilters(iVar1,iVar1);
		  if (*(int *)(Core_Money_Money_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Money_Money_TypeInfo);
		  }
		  uVar2 = Core_Money_Money__op_Explicit(uVar2,0);
		  UI_Price_Price__SetColor(param1_00,param2_00,uVar2,0);
		  return;
		}
		*/

		}

		// Token: 0x06003F2A RID: 16170 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003F2A")]
		[Address(RVA = "0x8DE5", Offset = "0x8DE5", VA = "0x8DE5")]
		private void UpdateJoinCost()
		{
		/* --- GHIDRA: UpdateJoinCost ---
		void Gameplay_Clans_Office_Controller_ClanMembersViewMediator__UpdateJoinCost
		               (int *param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  int iVar2;
		  undefined4 uVar3;
		  int *piVar4;
		  undefined4 uVar5;
		  
		  if (DAT_ram_00a58008 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_ClanInfoModel__ClanInfoEvents__ClanInfoController__ClanMembersView__set_Events__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Clans_Office_Controller_ClanMembersViewMediator_ClanStateFlagsChangedEventHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Clans_Office_Controller_ClanMembersViewMediator_InitEventHandler__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Clans_Office_Controller_ClanMembersViewMediator_JoinRequestCancelledEventHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Clans_Office_Controller_ClanMembersViewMediator_JoinRequestSentEventHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Clans_Office_Controller_ClanMembersViewMediator_MembersChangedEventHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Clans_Office_Controller_ClanMembersViewMediator_MembersRequestedEventHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Clans_Office_Controller_ClanMembersViewMediator_VacancyAddedEventHandler__
		              );
		    DAT_ram_00a58008 = '\x01';
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
		               Method_Gameplay_Clans_Office_Controller_ClanMembersViewMediator_MembersRequestedEventHandler__
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
		    uVar5 = *(undefined4 *)(iVar2 + 8);
		    uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar3,param1,
		               Method_Gameplay_Clans_Office_Controller_ClanMembersViewMediator_InitEventHandler__,0)
		    ;
		    piVar4 = (int *)func_ii_7048(uVar5,uVar3,0);
		    iVar1 = System_Action_TypeInfo;
		    if (piVar4 == (int *)0x0) {
		      *(undefined4 *)(iVar2 + 8) = 0;
		    }
		    else if ((System_Action_TypeInfo != *piVar4) ||
		            (*(int **)(iVar2 + 8) = piVar4, *piVar4 != iVar1)) {
		      System_Activator__CreateInstance(piVar4,iVar1);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar5 = *(undefined4 *)(iVar2 + 0x20);
		    uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar3,param1,
		               Method_Gameplay_Clans_Office_Controller_ClanMembersViewMediator_JoinRequestSentEventHandler__
		               ,0);
		    piVar4 = (int *)func_ii_7048(uVar5,uVar3,0);
		    iVar1 = System_Action_TypeInfo;
		    if (piVar4 == (int *)0x0) {
		      *(undefined4 *)(iVar2 + 0x20) = 0;
		    }
		    else if ((System_Action_TypeInfo != *piVar4) ||
		            (*(int **)(iVar2 + 0x20) = piVar4, *piVar4 != iVar1)) {
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
		               Method_Gameplay_Clans_Office_Controller_ClanMembersViewMediator_JoinRequestCancelledEventHandler__
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
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar5 = *(undefined4 *)(iVar2 + 0x28);
		    uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar3,param1,
		               Method_Gameplay_Clans_Office_Controller_ClanMembersViewMediator_MembersChangedEventHandler__
		               ,0);
		    piVar4 = (int *)func_ii_7048(uVar5,uVar3,0);
		    iVar1 = System_Action_TypeInfo;
		    if (piVar4 == (int *)0x0) {
		      *(undefined4 *)(iVar2 + 0x28) = 0;
		    }
		    else if ((System_Action_TypeInfo != *piVar4) ||
		            (*(int **)(iVar2 + 0x28) = piVar4, *piVar4 != iVar1)) {
		      System_Activator__CreateInstance(piVar4,iVar1);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar5 = *(undefined4 *)(iVar2 + 0x30);
		    uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar3,param1,
		               Method_Gameplay_Clans_Office_Controller_ClanMembersViewMediator_VacancyAddedEventHandler__
		               ,0);
		    piVar4 = (int *)func_ii_7048(uVar5,uVar3,0);
		    iVar1 = System_Action_TypeInfo;
		    if (piVar4 == (int *)0x0) {
		      *(undefined4 *)(iVar2 + 0x30) = 0;
		    }
		    else if ((System_Action_TypeInfo != *piVar4) ||
		            (*(int **)(iVar2 + 0x30) = piVar4, *piVar4 != iVar1)) {
		      System_Activator__CreateInstance(piVar4,iVar1);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar5 = *(undefined4 *)(iVar2 + 0x34);
		    uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar3,param1,
		               Method_Gameplay_Clans_Office_Controller_ClanMembersViewMediator_ClanStateFlagsChangedEventHandler__
		               ,0);
		    piVar4 = (int *)func_ii_7048(uVar5,uVar3,0);
		    iVar1 = System_Action_TypeInfo;
		    if (piVar4 == (int *)0x0) {
		      *(undefined4 *)(iVar2 + 0x34) = 0;
		    }
		    else if ((System_Action_TypeInfo != *piVar4) ||
		            (*(int **)(iVar2 + 0x34) = piVar4, *piVar4 != iVar1)) {
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
		               Method_Gameplay_Clans_Office_Controller_ClanMembersViewMediator_MembersRequestedEventHandler__
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
		    uVar5 = *(undefined4 *)(iVar2 + 8);
		    uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar3,param1,
		               Method_Gameplay_Clans_Office_Controller_ClanMembersViewMediator_InitEventHandler__,0)
		    ;
		    piVar4 = (int *)UnityEngine_UI_Image__set_sprite(uVar5,uVar3,0);
		    iVar1 = System_Action_TypeInfo;
		    if (piVar4 == (int *)0x0) {
		      *(undefined4 *)(iVar2 + 8) = 0;
		    }
		    else if ((System_Action_TypeInfo != *piVar4) ||
		            (*(int **)(iVar2 + 8) = piVar4, *piVar4 != iVar1)) {
		      System_Activator__CreateInstance(piVar4,iVar1);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar5 = *(undefined4 *)(iVar2 + 0x20);
		    uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar3,param1,
		               Method_Gameplay_Clans_Office_Controller_ClanMembersViewMediator_JoinRequestSentEventHandler__
		               ,0);
		    piVar4 = (int *)UnityEngine_UI_Image__set_sprite(uVar5,uVar3,0);
		    iVar1 = System_Action_TypeInfo;
		    if (piVar4 == (int *)0x0) {
		      *(undefined4 *)(iVar2 + 0x20) = 0;
		    }
		    else if ((System_Action_TypeInfo != *piVar4) ||
		            (*(int **)(iVar2 + 0x20) = piVar4, *piVar4 != iVar1)) {
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
		               Method_Gameplay_Clans_Office_Controller_ClanMembersViewMediator_JoinRequestCancelledEventHandler__
		               ,0);
		    piVar4 = (int *)UnityEngine_UI_Image__set_sprite(uVar5,uVar3,0);
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
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar5 = *(undefined4 *)(iVar2 + 0x28);
		    uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar3,param1,
		               Method_Gameplay_Clans_Office_Controller_ClanMembersViewMediator_MembersChangedEventHandler__
		               ,0);
		    piVar4 = (int *)UnityEngine_UI_Image__set_sprite(uVar5,uVar3,0);
		    iVar1 = System_Action_TypeInfo;
		    if (piVar4 == (int *)0x0) {
		      *(undefined4 *)(iVar2 + 0x28) = 0;
		    }
		    else if ((System_Action_TypeInfo != *piVar4) ||
		            (*(int **)(iVar2 + 0x28) = piVar4, *piVar4 != iVar1)) {
		      System_Activator__CreateInstance(piVar4,iVar1);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar5 = *(undefined4 *)(iVar2 + 0x30);
		    uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar3,param1,
		               Method_Gameplay_Clans_Office_Controller_ClanMembersViewMediator_VacancyAddedEventHandler__
		               ,0);
		    piVar4 = (int *)UnityEngine_UI_Image__set_sprite(uVar5,uVar3,0);
		    iVar1 = System_Action_TypeInfo;
		    if (piVar4 == (int *)0x0) {
		      *(undefined4 *)(iVar2 + 0x30) = 0;
		    }
		    else if ((System_Action_TypeInfo != *piVar4) ||
		            (*(int **)(iVar2 + 0x30) = piVar4, *piVar4 != iVar1)) {
		      System_Activator__CreateInstance(piVar4,iVar1);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar5 = *(undefined4 *)(iVar2 + 0x34);
		    uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar3,param1,
		               Method_Gameplay_Clans_Office_Controller_ClanMembersViewMediator_ClanStateFlagsChangedEventHandler__
		               ,0);
		    piVar4 = (int *)UnityEngine_UI_Image__set_sprite(uVar5,uVar3,0);
		    iVar1 = System_Action_TypeInfo;
		    if (piVar4 == (int *)0x0) {
		      *(undefined4 *)(iVar2 + 0x34) = 0;
		      return;
		    }
		    if ((System_Action_TypeInfo != *piVar4) || (*(int **)(iVar2 + 0x34) = piVar4, *piVar4 != iVar1))
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

		// Token: 0x17000C9D RID: 3229
		// (set) Token: 0x06003F2B RID: 16171 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000C9D")]
		public override ClanInfoEvents Events
		{
			[Token(Token = "0x6003F2B")]
			[Address(RVA = "0x8DE6", Offset = "0x8DE6", VA = "0x8DE6", Slot = "16")]
			set
			{
			}
		}

		// Token: 0x06003F2C RID: 16172 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003F2C")]
		[Address(RVA = "0x8DE7", Offset = "0x8DE7", VA = "0x8DE7")]
		private void ClanStateFlagsChangedEventHandler()
		{
		/* --- GHIDRA: ClanStateFlagsChangedEventHandler ---
		void Gameplay_Clans_Office_Controller_ClanMembersViewMediator__ClanStateFlagsChangedEventHandler
		               (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  int param2_00;
		  
		  if (DAT_ram_00a5800a == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_ClanInfoModel__ClanInfoEvents__ClanInfoController__ClanMembersView__get_Model__
		              );
		    DAT_ram_00a5800a = '\x01';
		  }
		  Gameplay_Clans_Office_Controller_ClanMembersViewMediator__OpenClanToggleChangedEventHandler
		            (param1,param1);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  param2_00 = *(int *)(param1[2] + 0x30);
		  Gameplay_Clans_Office_View_ClanTitle___ctor(*(undefined4 *)(iVar1 + 0x30),param2_00,0);
		  func_ii_7603(*(undefined4 *)(iVar1 + 0x40),
		               (*(uint *)(*(int *)(*(int *)(param2_00 + 0xc) + 0x1c) + 0x20) & 2) >> 1,0);
		  return;
		}
		*/

		}

		// Token: 0x06003F2D RID: 16173 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003F2D")]
		[Address(RVA = "0x8DE8", Offset = "0x8DE8", VA = "0x8DE8")]
		private void VacancyAddedEventHandler()
		{
		/* --- GHIDRA: VacancyAddedEventHandler ---
		void Gameplay_Clans_Office_Controller_ClanMembersViewMediator__VacancyAddedEventHandler
		               (int param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  iVar1 = *(int *)(param1 + 0x18);
		  if ((iVar1 != 0) && (*(char *)(iVar1 + 0xc) != '\0')) {
		    *(undefined1 *)(iVar1 + 0xc) = 0;
		    iVar1 = *(int *)(iVar1 + 0x10);
		    if (iVar1 != 0) {
		      (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		                (*(undefined4 *)(iVar1 + 0x20),0,*(undefined4 *)(iVar1 + 0x14));
		    }
		  }
		  Gameplay_Clans_Office_Controller_ClanMembersViewMediator__RedrawMembersList(param1,param1);
		  return;
		}
		*/

		}

		// Token: 0x06003F2E RID: 16174 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003F2E")]
		[Address(RVA = "0x8DE9", Offset = "0x8DE9", VA = "0x8DE9")]
		private void MembersChangedEventHandler()
		{
		/* --- GHIDRA: MembersChangedEventHandler ---
		void Gameplay_Clans_Office_Controller_ClanMembersViewMediator__MembersChangedEventHandler
		               (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar2 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (*(undefined4 *)(iVar1 + 0x34),0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar2,1,0);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar2 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (*(undefined4 *)(iVar1 + 0x38),0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar2,0,0);
		  return;
		}
		*/

		}

		// Token: 0x06003F2F RID: 16175 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003F2F")]
		[Address(RVA = "0x8DEA", Offset = "0x8DEA", VA = "0x8DEA")]
		private void JoinRequestCancelledEventHandler()
		{
		/* --- GHIDRA: JoinRequestCancelledEventHandler ---
		void Gameplay_Clans_Office_Controller_ClanMembersViewMediator__JoinRequestCancelledEventHandler
		               (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar2 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (*(undefined4 *)(iVar1 + 0x34),0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar2,0,0);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar2 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (*(undefined4 *)(iVar1 + 0x38),0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar2,1,0);
		  return;
		}
		*/

		}

		// Token: 0x06003F30 RID: 16176 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003F30")]
		[Address(RVA = "0x8DEB", Offset = "0x8DEB", VA = "0x8DEB")]
		private void JoinRequestSentEventHandler()
		{
		/* --- GHIDRA: JoinRequestSentEventHandler ---
		void Gameplay_Clans_Office_Controller_ClanMembersViewMediator__JoinRequestSentEventHandler
		               (int *param1,undefined4 param2)
		
		{
		  undefined4 in_register_20000014;
		  undefined8 uVar1;
		  int iVar2;
		  undefined4 uVar3;
		  int param2_00;
		  
		  if (DAT_ram_00a5800b == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_ClanInfoModel__ClanInfoEvents__ClanInfoController__ClanMembersView__get_Model__
		              );
		    DAT_ram_00a5800b = '\x01';
		  }
		  uVar1 = CONCAT44(in_register_20000014,*(undefined4 *)(*param1 + 0x15c));
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))(param1,uVar1);
		  param2_00 = *(int *)(param1[2] + 0x30);
		  uVar3 = (undefined4)((ulonglong)uVar1 >> 0x20);
		  Gameplay_Clans_Office_View_ClanTitle___ctor(*(undefined4 *)(iVar2 + 0x30),param2_00,0);
		  func_ii_7603(*(undefined4 *)(iVar2 + 0x40),
		               (*(uint *)(*(int *)(*(int *)(param2_00 + 0xc) + 0x1c) + 0x20) & 2) >> 1,0);
		  Gameplay_Clans_Office_Controller_ClanMembersViewMediator__OpenClanToggleChangedEventHandler
		            (param1,param1);
		  uVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                    (param1,CONCAT44(uVar3,*(undefined4 *)(*param1 + 0x14c)));
		  Gameplay_Clans_Office_Controller_ClanInfoController__GetIsleInfoResultHandler
		            (uVar3,*(undefined8 *)(param1[2] + 0x10),param1);
		  return;
		}
		*/

		}

		// Token: 0x06003F31 RID: 16177 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003F31")]
		[Address(RVA = "0x8DEC", Offset = "0x8DEC", VA = "0x8DEC")]
		private void InitEventHandler()
		{
		/* --- GHIDRA: InitEventHandler ---
		void Gameplay_Clans_Office_Controller_ClanMembersViewMediator__InitEventHandler
		               (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  if (DAT_ram_00a5800c == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_ClanInfoModel__ClanInfoEvents__ClanInfoController__ClanMembersView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Elements_GenericList_SelectorGenericList_SubRatingsListArgs__SubRatingListElement__SubRatingListElementArgs__set_Data__
		              );
		    DAT_ram_00a5800c = '\x01';
		  }
		  Gameplay_Clans_Office_Controller_ClanMembersViewMediator__LeaveButtonClickedEventHandler
		            (param1,param1);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  UI_Elements_GenericList_SelectorGenericList_object__object__object___get_SelectedIndex
		            (*(undefined4 *)(iVar1 + 0x1c),*(undefined4 *)(param1[2] + 0x18),
		             Method_UI_Elements_GenericList_SelectorGenericList_SubRatingsListArgs__SubRatingListElement__SubRatingListElementArgs__set_Data__
		            );
		  return;
		}
		*/

		}

		// Token: 0x06003F32 RID: 16178 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003F32")]
		[Address(RVA = "0x8DED", Offset = "0x8DED", VA = "0x8DED")]
		private void MembersRequestedEventHandler()
		{
		/* --- GHIDRA: MembersRequestedEventHandler ---
		void Gameplay_Clans_Office_Controller_ClanMembersViewMediator__MembersRequestedEventHandler
		               (int *param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  uint *puVar2;
		  undefined4 uVar3;
		  undefined4 param2_00;
		  longlong lVar4;
		  longlong lVar5;
		  int iVar6;
		  int param1_00;
		  int *param1_01;
		  undefined4 param1_02;
		  uint uVar7;
		  
		  if (DAT_ram_00a5800d == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_ClanInfoModel__ClanInfoEvents__ClanInfoController__ClanMembersView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_ClanMemberListElement_ClanMemberListElementArgs__get_Count__
		              );
		    DAT_ram_00a5800d = '\x01';
		  }
		  if (param2 == 0) {
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar3 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                      (*(undefined4 *)(*(int *)(iVar1 + 0x28) + 0x1c),0);
		    Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		              (uVar3,0,0);
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar3 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                      (*(undefined4 *)(*(int *)(iVar1 + 0x28) + 0x20),0);
		    Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		              (uVar3,0,0);
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar3 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                      (*(undefined4 *)(iVar1 + 0x2c),0);
		    Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		              (uVar3,0,0);
		    return;
		  }
		  param1[6] = param2;
		  if (*(char *)(param2 + 0xc) == '\0') {
		    *(undefined1 *)(param2 + 0xc) = 1;
		    iVar1 = *(int *)(param2 + 0x10);
		    if (iVar1 != 0) {
		      (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		                (*(undefined4 *)(iVar1 + 0x20),1,*(undefined4 *)(iVar1 + 0x14));
		    }
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar1 = *(int *)(iVar1 + 0x28);
		  iVar6 = param1[2];
		  param1_00 = *(int *)(param2 + 0x18);
		  if (DAT_ram_00a57f87 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Dict_IDictProvider_TypeInfo);
		    DAT_ram_00a57f87 = '\x01';
		  }
		  param1_01 = *(int **)(iVar6 + 0xc);
		  iVar6 = *param1_01;
		  if (*(ushort *)(iVar6 + 0xb6) != 0) {
		    uVar7 = 0;
		    do {
		      if (Core_Dict_IDictProvider_TypeInfo == *(int *)(*(int *)(iVar6 + 0x58) + uVar7 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar7 * 8 + 4) * 8 + iVar6 + 0xd0);
		        goto code_r0x80e92d52;
		      }
		      uVar7 = uVar7 + 1;
		    } while (*(ushort *)(iVar6 + 0xb6) != uVar7);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_01,Core_Dict_IDictProvider_TypeInfo,2);
		code_r0x80e92d52:
		  uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(param1_01,puVar2[1]);
		  param1_02 = *(undefined4 *)(iVar1 + 0x10);
		  param2_00 = Google_Protobuf_Collections_RepeatedField_object___GetEnumerator(param1_00,0);
		  UnityEngine_Component__GetComponentInChildren_object_(param1_02,param2_00,0);
		  iVar6 = **(int **)(iVar1 + 0x14);
		  (**(code **)((ulonglong)*(uint *)(iVar6 + 0x138) * 4))
		            (*(int **)(iVar1 + 0x14),*(undefined4 *)(param1_00 + 0x38),
		             *(undefined4 *)(iVar6 + 0x13c));
		  Gameplay_Clans_Office_View_ClansButtonView___ctor(*(undefined4 *)(iVar1 + 0x18),param1_00,uVar3,0)
		  ;
		  if (*(int *)(param1[2] + 0x20) == 2) {
		    lVar4 = System_Collections_Generic_LinkedList_Enumerator_object___MoveNext
		                      (*(undefined4 *)(param1[6] + 0x18),0);
		    lVar5 = System_Collections_Generic_LinkedList_Enumerator_object___MoveNext
		                      (*(undefined4 *)(param1[2] + 8),0);
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar3 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                      (*(undefined4 *)(*(int *)(iVar1 + 0x28) + 0x1c),0);
		    Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		              (uVar3,(uint)(lVar4 != lVar5),0);
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar3 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                      (*(undefined4 *)(*(int *)(iVar1 + 0x28) + 0x20),0);
		    Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		              (uVar3,(uint)(lVar4 != lVar5),0);
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar3 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                      (*(undefined4 *)(iVar1 + 0x2c),0);
		    Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		              (uVar3,(uint)(lVar4 == lVar5),0);
		  }
		  else if (*(int *)(param1[2] + 0x20) == 3) {
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar3 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                      (*(undefined4 *)(*(int *)(iVar1 + 0x28) + 0x1c),0);
		    Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		              (uVar3,(uint)(*(char *)(param2 + 0x24) == '\0'),0);
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar3 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                      (*(undefined4 *)(*(int *)(iVar1 + 0x28) + 0x20),0);
		    Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		              (uVar3,(uint)(*(char *)(param2 + 0x24) == '\0'),0);
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar3 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                      (*(undefined4 *)(iVar1 + 0x2c),0);
		    Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		              (uVar3,(uint)(*(int *)(*(int *)(param1[2] + 0x34) + 0xc) == 1),0);
		    return;
		  }
		  return;
		}
		*/

		}

		// Token: 0x06003F33 RID: 16179 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003F33")]
		[Address(RVA = "0x8DEE", Offset = "0x8DEE", VA = "0x8DEE")]
		private void SelectArgs(ClanMemberListElement.ClanMemberListElementArgs args)
		{
		/* --- GHIDRA: SelectArgs ---
		void Gameplay_Clans_Office_Controller_ClanMembersViewMediator__SelectArgs
		               (undefined4 param1,undefined4 param2)
		
		{
		  Gameplay_Clans_Office_Controller_ClanMembersViewMediator__ShowLeaveConfirmationWindow
		            (param1,param1);
		  return;
		}
		*/

		}

		// Token: 0x06003F34 RID: 16180 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003F34")]
		[Address(RVA = "0x8DEF", Offset = "0x8DEF", VA = "0x8DEF")]
		private void DisbandButtonClickedEventHandler()
		{
		/* --- GHIDRA: DisbandButtonClickedEventHandler ---
		void Gameplay_Clans_Office_Controller_ClanMembersViewMediator__DisbandButtonClickedEventHandler
		               (undefined4 param1,undefined4 param2)
		
		{
		  Gameplay_Clans_Office_Controller_ClanMembersViewMediator__MemberButtonClickedEventHandler
		            (param1,param1);
		  return;
		}
		*/

		}

		// Token: 0x06003F35 RID: 16181 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003F35")]
		[Address(RVA = "0x8DF0", Offset = "0x8DF0", VA = "0x8DF0")]
		private void LeaveButtonClickedEventHandler()
		{
		/* --- GHIDRA: LeaveButtonClickedEventHandler ---
		void Gameplay_Clans_Office_Controller_ClanMembersViewMediator__LeaveButtonClickedEventHandler
		               (int param1,undefined4 param2)
		
		{
		  int iVar1;
		  int iVar2;
		  undefined4 uVar3;
		  int *piVar4;
		  int local_18;
		  undefined8 *local_14;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a5800e == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_ClanInfoModel__ClanInfoEvents__ClanInfoController__ClanMembersView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_ClanMemberListElement__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Clans_Office_Controller_ClanMembersViewMediator_MemberButtonClickedEventHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_Enumerator_ClanMemberListElement_ClanMemberListElementArgs__Dispose__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_Enumerator_ClanMemberListElement_ClanMemberListElementArgs__MoveNext__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_Enumerator_ClanMemberListElement_ClanMemberListElementArgs__get_Current__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_ClanMemberListElement_ClanMemberListElementArgs__GetEnumerator__
		              );
		    DAT_ram_00a5800e = '\x01';
		  }
		  local_8 = 0;
		  local_10 = 0;
		  System_Collections_Generic_List_RegexCharClass_SingleRange___ForEach
		            (&local_10,*(undefined4 *)(*(int *)(param1 + 8) + 0x34),
		             Method_System_Collections_Generic_List_ClanMemberListElement_ClanMemberListElementArgs__GetEnumerator__
		            );
		  local_18 = 0;
		  local_14 = &local_10;
		  do {
		    DAT_ram_009d3e38 = 0;
		    iVar2 = import::env::invoke_iii
		                      (s_struct_Uniforms___color__array<v_ram_00000aff + 0x44,&local_10,
		                       Method_System_Collections_Generic_List_Enumerator_ClanMemberListElement_ClanMemberListElementArgs__MoveNext__
		                      );
		    iVar1 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar1 == 1) {
		      uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x80e93a0b:
		      iVar1 = global_1;
		      iVar2 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		      if (iVar1 == iVar2) {
		        piVar4 = (int *)import::env::__cxa_begin_catch(uVar3);
		        iVar2 = *piVar4;
		        DAT_ram_009d3e38 = 0;
		        local_18 = iVar2;
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
		      import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001b87 + 0x102,&local_18);
		      iVar1 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar1 != 1) {
		        import::env::__resumeException(uVar3);
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
		    if (iVar2 == 0) {
		      DAT_ram_009d3e38 = 0;
		      return;
		    }
		    DAT_ram_009d3e38 = 0;
		    iVar1 = local_8._4_4_;
		    uVar3 = import::env::invoke_ii
		                      (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x199,
		                       System_Action_ClanMemberListElement__TypeInfo);
		    if (DAT_ram_009d3e38 == 1) {
		code_r0x80e939f9:
		      DAT_ram_009d3e38 = 0;
		      uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80e93a0b;
		    }
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_viiii
		              (s_struct_Uniforms___color__array<v_ram_000017c8 + 0x241,uVar3,param1,
		               Method_Gameplay_Clans_Office_Controller_ClanMembersViewMediator_MemberButtonClickedEventHandler__
		               ,0);
		    if (DAT_ram_009d3e38 == 1) goto code_r0x80e939f9;
		    *(undefined4 *)(iVar1 + 0x14) = uVar3;
		  } while( true );
		}
		*/

		}

		// Token: 0x06003F36 RID: 16182 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003F36")]
		[Address(RVA = "0x8DF1", Offset = "0x8DF1", VA = "0x8DF1")]
		private void RequestInjectCallbackEventHandler()
		{
		/* --- GHIDRA: RequestInjectCallbackEventHandler ---
		void Gameplay_Clans_Office_Controller_ClanMembersViewMediator__RequestInjectCallbackEventHandler
		               (int param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  
		  if (DAT_ram_00a5800f == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Elements_GenericList_GenericListElement_ClanMemberListElement_ClanMemberListElementArgs__get_args__
		              );
		    DAT_ram_00a5800f = '\x01';
		  }
		  iVar1 = *(int *)(param1 + 0x18);
		  if (*(char *)(iVar1 + 0xc) != '\0') {
		    *(undefined1 *)(iVar1 + 0xc) = 0;
		    iVar1 = *(int *)(iVar1 + 0x10);
		    if (iVar1 != 0) {
		      (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		                (*(undefined4 *)(iVar1 + 0x20),0,*(undefined4 *)(iVar1 + 0x14));
		    }
		  }
		  Gameplay_Clans_Office_Controller_ClanMembersViewMediator__MembersRequestedEventHandler
		            (param1,*(undefined4 *)(param2 + 0x18),param1);
		  return;
		}
		*/

		}

		// Token: 0x06003F37 RID: 16183 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003F37")]
		[Address(RVA = "0x8DF2", Offset = "0x8DF2", VA = "0x8DF2")]
		private void MemberButtonClickedEventHandler(ClanMemberListElement element)
		{
		/* --- GHIDRA: MemberButtonClickedEventHandler ---
		undefined4
		Gameplay_Clans_Office_Controller_ClanMembersViewMediator__MemberButtonClickedEventHandler
		          (int param1,undefined4 param2)
		
		{
		  undefined4 in_register_20000004;
		  uint *puVar1;
		  undefined4 uVar2;
		  undefined4 param1_00;
		  float fVar3;
		  undefined4 param3;
		  int iVar4;
		  int iVar5;
		  undefined8 param1_01;
		  int iVar6;
		  int *param1_02;
		  int iVar7;
		  uint uVar8;
		  
		  uVar8 = 0;
		  if (DAT_ram_00a58010 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_ClanInfoModel__ClanInfoEvents__ClanInfoController__ClanMembersView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_ButtonCallbackDelegate_DialogWindow_DialogWindowArgs__TypeInfo
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_DialogWindow_DialogWindowArgs___ctor__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_DialogWindow_DialogWindowArgs__set_Callback__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_DialogWindow_DialogWindowArgs__TypeInfo
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Clans_Office_Controller_ClanMembersViewMediator__ShowLeaveConfirmationWindow_b__36_0__
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
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__string__Add__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__string___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_Dictionary_string__string__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs___Add__
		              );
		    Mono_Security_ASN1__get_Item(&Utils_TimeUtils_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_4314);
		    Mono_Security_ASN1__get_Item(&StringLiteral_4107);
		    Mono_Security_ASN1__get_Item(&StringLiteral_4316);
		    Mono_Security_ASN1__get_Item(&StringLiteral_27717);
		    Mono_Security_ASN1__get_Item(&StringLiteral_21185);
		    Mono_Security_ASN1__get_Item(&StringLiteral_4315);
		    Mono_Security_ASN1__get_Item(&StringLiteral_21210);
		    DAT_ram_00a58010 = '\x01';
		  }
		  iVar6 = *(int *)(param1 + 8);
		  if (DAT_ram_00a57f87 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Dict_IDictProvider_TypeInfo);
		    DAT_ram_00a57f87 = '\x01';
		  }
		  param1_02 = *(int **)(iVar6 + 0xc);
		  iVar6 = *param1_02;
		  if (*(ushort *)(iVar6 + 0xb6) != 0) {
		    do {
		      if (Core_Dict_IDictProvider_TypeInfo == *(int *)(*(int *)(iVar6 + 0x58) + uVar8 * 8)) {
		        puVar1 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar8 * 8 + 4) * 8 + iVar6 + 0xd0);
		        goto code_r0x80e93ec3;
		      }
		      uVar8 = uVar8 + 1;
		    } while (*(ushort *)(iVar6 + 0xb6) != uVar8);
		  }
		  puVar1 = (uint *)func_ii_1080(param1_02,Core_Dict_IDictProvider_TypeInfo,2);
		code_r0x80e93ec3:
		  uVar2 = (**(code **)((ulonglong)*puVar1 * 4))(CONCAT44(in_register_20000004,param1_02),puVar1[1]);
		  param1_01 = Core_Extensions_Dict_DictExt__GetDoubleParameter(uVar2,StringLiteral_21210,0);
		  iVar6 = unnamed_function_1417(UI_Windows_DialogWindow_DialogWindowArgs_TypeInfo);
		  func_ii_8625(iVar6,0);
		  if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_GameLocalization_TypeInfo);
		  }
		  uVar2 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_4316,1,0,1,0,0,0,0);
		  *(undefined4 *)(iVar6 + 0x18) = uVar2;
		  uVar2 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_4315,1,0,1,0,0,0,0);
		  param1_00 = unnamed_function_1417(System_Collections_Generic_Dictionary_string__string__TypeInfo);
		  System_Collections_Generic_Dictionary_object__StyleComplexSelector_PseudoStateData___set_Item
		            (param1_00,Method_System_Collections_Generic_Dictionary_string__string___ctor__);
		  System_Reflection_FieldInfo__get_IsStatic
		            (param1_00,StringLiteral_21185,
		             *(undefined4 *)
		              (*(int *)(*(int *)(*(int *)(*(int *)(param1 + 8) + 0x30) + 0xc) + 0x1c) + 0x18),
		             Method_System_Collections_Generic_Dictionary_string__string__Add__);
		  if (*(int *)(Utils_TimeUtils_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Utils_TimeUtils_TypeInfo);
		  }
		  fVar3 = func_ii_7331(param1_01,0);
		  param3 = Utils_TimeUtils__DateFormat((double)fVar3,0);
		  System_Reflection_FieldInfo__get_IsStatic
		            (param1_00,StringLiteral_27717,param3,
		             Method_System_Collections_Generic_Dictionary_string__string__Add__);
		  uVar2 = Core_GameLocalization__GetTranslation(uVar2,param1_00,0);
		  *(undefined4 *)(iVar6 + 0x1c) = uVar2;
		  iVar7 = *(int *)(iVar6 + 0x24);
		  iVar4 = unnamed_function_1417
		                    (
		                    UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs__TypeInfo
		                    );
		  UI_Windows_DialogWindow_DialogWindowArgs___ctor
		            (iVar4,
		             Method_UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs___ctor__
		            );
		  uVar2 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_4314,1,0,1,0,0,0,0);
		  *(undefined4 *)(iVar4 + 8) = uVar2;
		  iVar5 = unnamed_function_1417
		                    (
		                    UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_DialogWindow_DialogWindowArgs__TypeInfo
		                    );
		  uVar2 = unnamed_function_1417
		                    (
		                    UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_ButtonCallbackDelegate_DialogWindow_DialogWindowArgs__TypeInfo
		                    );
		  UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_object____ctor
		            (uVar2,param1,
		             Method_Gameplay_Clans_Office_Controller_ClanMembersViewMediator__ShowLeaveConfirmationWindow_b__36_0__
		             ,0);
		  *(undefined4 *)(iVar5 + 8) = uVar2;
		  *(int *)(iVar4 + 0x14) = iVar5;
		  iVar5 = 
		  Method_System_Collections_Generic_List_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs___Add__
		  ;
		  *(int *)(iVar7 + 0x10) = *(int *)(iVar7 + 0x10) + 1;
		  uVar8 = *(uint *)(iVar7 + 0xc);
		  if (uVar8 < *(uint *)(*(int *)(iVar7 + 8) + 0xc)) {
		    *(uint *)(iVar7 + 0xc) = uVar8 + 1;
		    *(int *)(*(int *)(iVar7 + 8) + uVar8 * 4 + 0x10) = iVar4;
		  }
		  else {
		    System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		              (iVar7,iVar4,*(undefined4 *)(*(int *)(*(int *)(iVar5 + 0x10) + 0x60) + 0x38));
		  }
		  iVar7 = *(int *)(iVar6 + 0x24);
		  iVar4 = unnamed_function_1417
		                    (
		                    UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs__TypeInfo
		                    );
		  UI_Windows_DialogWindow_DialogWindowArgs___ctor
		            (iVar4,
		             Method_UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs___ctor__
		            );
		  uVar2 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_4107,1,0,1,0,0,0,0);
		  *(undefined4 *)(iVar4 + 8) = uVar2;
		  iVar5 = 
		  Method_System_Collections_Generic_List_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs___Add__
		  ;
		  *(int *)(iVar7 + 0x10) = *(int *)(iVar7 + 0x10) + 1;
		  uVar8 = *(uint *)(iVar7 + 0xc);
		  if (uVar8 < *(uint *)(*(int *)(iVar7 + 8) + 0xc)) {
		    *(uint *)(iVar7 + 0xc) = uVar8 + 1;
		    *(int *)(*(int *)(iVar7 + 8) + uVar8 * 4 + 0x10) = iVar4;
		  }
		  else {
		    System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		              (iVar7,iVar4,*(undefined4 *)(*(int *)(*(int *)(iVar5 + 0x10) + 0x60) + 0x38));
		  }
		  uVar2 = UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_ButtonCallbackDelegate_object____ctor
		                    (iVar6,0);
		  return uVar2;
		}
		*/

		}

		// Token: 0x06003F38 RID: 16184 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6003F38")]
		[Address(RVA = "0x8DF3", Offset = "0x8DF3", VA = "0x8DF3")]
		private DialogWindow ShowLeaveConfirmationWindow()
		{
		/* --- GHIDRA: ShowLeaveConfirmationWindow ---
		undefined4
		Gameplay_Clans_Office_Controller_ClanMembersViewMediator__ShowLeaveConfirmationWindow
		          (undefined4 param1,undefined4 param2)
		
		{
		  int param1_00;
		  undefined4 uVar1;
		  int iVar2;
		  int iVar3;
		  int iVar4;
		  uint uVar5;
		  
		  if (DAT_ram_00a58011 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_ButtonCallbackDelegate_DialogWindow_DialogWindowArgs__TypeInfo
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_DialogWindow_DialogWindowArgs___ctor__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_DialogWindow_DialogWindowArgs__set_Callback__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_DialogWindow_DialogWindowArgs__TypeInfo
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Clans_Office_Controller_ClanMembersViewMediator__ShowDisbandConfirmationWindow_b__37_0__
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
		              (&
		               Method_System_Collections_Generic_List_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs___Add__
		              );
		    Mono_Security_ASN1__get_Item(&StringLiteral_4107);
		    Mono_Security_ASN1__get_Item(&StringLiteral_4306);
		    Mono_Security_ASN1__get_Item(&StringLiteral_4307);
		    Mono_Security_ASN1__get_Item(&StringLiteral_4305);
		    DAT_ram_00a58011 = '\x01';
		  }
		  param1_00 = unnamed_function_1417(UI_Windows_DialogWindow_DialogWindowArgs_TypeInfo);
		  func_ii_8625(param1_00,0);
		  if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_GameLocalization_TypeInfo);
		  }
		  uVar1 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_4307,1,0,1,0,0,0,0);
		  *(undefined4 *)(param1_00 + 0x18) = uVar1;
		  uVar1 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_4306,1,0,1,0,0,0,0);
		  *(undefined4 *)(param1_00 + 0x1c) = uVar1;
		  iVar4 = *(int *)(param1_00 + 0x24);
		  iVar2 = unnamed_function_1417
		                    (
		                    UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs__TypeInfo
		                    );
		  UI_Windows_DialogWindow_DialogWindowArgs___ctor
		            (iVar2,
		             Method_UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs___ctor__
		            );
		  uVar1 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_4305,1,0,1,0,0,0,0);
		  *(undefined4 *)(iVar2 + 8) = uVar1;
		  iVar3 = unnamed_function_1417
		                    (
		                    UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_DialogWindow_DialogWindowArgs__TypeInfo
		                    );
		  uVar1 = unnamed_function_1417
		                    (
		                    UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_ButtonCallbackDelegate_DialogWindow_DialogWindowArgs__TypeInfo
		                    );
		  UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_object____ctor
		            (uVar1,param1,
		             Method_Gameplay_Clans_Office_Controller_ClanMembersViewMediator__ShowDisbandConfirmationWindow_b__37_0__
		             ,0);
		  *(undefined4 *)(iVar3 + 8) = uVar1;
		  *(int *)(iVar2 + 0x14) = iVar3;
		  iVar3 = 
		  Method_System_Collections_Generic_List_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs___Add__
		  ;
		  *(int *)(iVar4 + 0x10) = *(int *)(iVar4 + 0x10) + 1;
		  uVar5 = *(uint *)(iVar4 + 0xc);
		  if (uVar5 < *(uint *)(*(int *)(iVar4 + 8) + 0xc)) {
		    *(uint *)(iVar4 + 0xc) = uVar5 + 1;
		    *(int *)(*(int *)(iVar4 + 8) + uVar5 * 4 + 0x10) = iVar2;
		  }
		  else {
		    System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		              (iVar4,iVar2,*(undefined4 *)(*(int *)(*(int *)(iVar3 + 0x10) + 0x60) + 0x38));
		  }
		  iVar4 = *(int *)(param1_00 + 0x24);
		  iVar2 = unnamed_function_1417
		                    (
		                    UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs__TypeInfo
		                    );
		  UI_Windows_DialogWindow_DialogWindowArgs___ctor
		            (iVar2,
		             Method_UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs___ctor__
		            );
		  uVar1 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_4107,1,0,1,0,0,0,0);
		  *(undefined4 *)(iVar2 + 8) = uVar1;
		  iVar3 = 
		  Method_System_Collections_Generic_List_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs___Add__
		  ;
		  *(int *)(iVar4 + 0x10) = *(int *)(iVar4 + 0x10) + 1;
		  uVar5 = *(uint *)(iVar4 + 0xc);
		  if (uVar5 < *(uint *)(*(int *)(iVar4 + 8) + 0xc)) {
		    *(uint *)(iVar4 + 0xc) = uVar5 + 1;
		    *(int *)(*(int *)(iVar4 + 8) + uVar5 * 4 + 0x10) = iVar2;
		  }
		  else {
		    System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		              (iVar4,iVar2,*(undefined4 *)(*(int *)(*(int *)(iVar3 + 0x10) + 0x60) + 0x38));
		  }
		  uVar1 = UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_ButtonCallbackDelegate_object____ctor
		                    (param1_00,0);
		  return uVar1;
		}
		*/

			return null;
		}

		// Token: 0x06003F39 RID: 16185 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6003F39")]
		[Address(RVA = "0x8DF4", Offset = "0x8DF4", VA = "0x8DF4")]
		private DialogWindow ShowDisbandConfirmationWindow()
		{
		/* --- GHIDRA: ShowDisbandConfirmationWindow ---
		undefined4
		Gameplay_Clans_Office_Controller_ClanMembersViewMediator__ShowDisbandConfirmationWindow
		          (int param1,undefined4 param2,undefined4 param3)
		
		{
		  int param1_00;
		  undefined4 uVar1;
		  int iVar2;
		  undefined4 param3_00;
		  int iVar3;
		  int iVar4;
		  uint uVar5;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a58012 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_ClanInfoModel__ClanInfoEvents__ClanInfoController__ClanMembersView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_ButtonCallbackDelegate_DialogWindow_DialogWindowArgs__TypeInfo
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_DialogWindow_DialogWindowArgs___ctor__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_DialogWindow_DialogWindowArgs__set_Callback__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_DialogWindow_DialogWindowArgs__TypeInfo
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Clans_Office_Controller_ClanMembersViewMediator__ShowBuyPlaceConfirmationWindow_b__38_0__
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
		               Method_UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_PriceHolder_DialogWindow_DialogWindowArgs___ctor__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_PriceHolder_DialogWindow_DialogWindowArgs__TypeInfo
		              );
		    Mono_Security_ASN1__get_Item(&StringLiteral_4107);
		    Mono_Security_ASN1__get_Item(&StringLiteral_26152);
		    Mono_Security_ASN1__get_Item(&StringLiteral_2556);
		    Mono_Security_ASN1__get_Item(&StringLiteral_4301);
		    Mono_Security_ASN1__get_Item(&StringLiteral_3708);
		    Mono_Security_ASN1__get_Item(&StringLiteral_4300);
		    DAT_ram_00a58012 = '\x01';
		  }
		  param1_00 = unnamed_function_1417(UI_Windows_DialogWindow_DialogWindowArgs_TypeInfo);
		  func_ii_8625(param1_00,0);
		  if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_GameLocalization_TypeInfo);
		  }
		  uVar1 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_4300,1,0,1,0,0,0,0);
		  *(undefined4 *)(param1_00 + 0x18) = uVar1;
		  uVar1 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_4301,1,0,1,0,0,0,0);
		  iVar2 = Mono_Security_ASN1Convert__ToOid
		                    (System_Collections_Generic_KeyValuePair_string__string____TypeInfo,1);
		  param3_00 = Core_Extensions_Dict_ResourceSetExt__ToNullableResourceSet
		                        (param2,NAN,0,StringLiteral_2556,0,0,0);
		  local_8 = 0;
		  System_Text_Formatting_StringView__get_IsEmpty
		            (&local_8,StringLiteral_26152,param3_00,
		             Method_System_Collections_Generic_KeyValuePair_string__string___ctor__);
		  *(undefined8 *)(iVar2 + 0x10) = local_8;
		  uVar1 = Gameplay_Clans_Office_View_ClanWarsTab_ClanWarsRewardsTab_ClanWarsRewardsView__GetPlacesText
		                    (uVar1,iVar2,0);
		  *(undefined4 *)(param1_00 + 0x1c) = uVar1;
		  iVar4 = *(int *)(param1_00 + 0x24);
		  iVar3 = unnamed_function_1417
		                    (
		                    UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs__TypeInfo
		                    );
		  UI_Windows_DialogWindow_DialogWindowArgs___ctor
		            (iVar3,
		             Method_UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs___ctor__
		            );
		  uVar1 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_3708,1,0,1,0,0,0,0);
		  *(undefined4 *)(iVar3 + 8) = uVar1;
		  iVar2 = unnamed_function_1417
		                    (
		                    UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_DialogWindow_DialogWindowArgs__TypeInfo
		                    );
		  uVar1 = unnamed_function_1417
		                    (
		                    UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_ButtonCallbackDelegate_DialogWindow_DialogWindowArgs__TypeInfo
		                    );
		  UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_object____ctor
		            (uVar1,param1,
		             Method_Gameplay_Clans_Office_Controller_ClanMembersViewMediator__ShowBuyPlaceConfirmationWindow_b__38_0__
		             ,0);
		  *(undefined4 *)(iVar2 + 8) = uVar1;
		  *(int *)(iVar3 + 0x14) = iVar2;
		  iVar2 = unnamed_function_1417
		                    (
		                    UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_PriceHolder_DialogWindow_DialogWindowArgs__TypeInfo
		                    );
		  uVar1 = *(undefined4 *)(*(int *)(*(int *)(param1 + 8) + 0x24) + 0x18);
		  *(undefined4 *)(iVar2 + 8) = param2;
		  *(undefined4 *)(iVar2 + 0xc) = uVar1;
		  *(int *)(iVar3 + 0x10) = iVar2;
		  iVar2 = 
		  Method_System_Collections_Generic_List_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs___Add__
		  ;
		  *(int *)(iVar4 + 0x10) = *(int *)(iVar4 + 0x10) + 1;
		  uVar5 = *(uint *)(iVar4 + 0xc);
		  if (uVar5 < *(uint *)(*(int *)(iVar4 + 8) + 0xc)) {
		    *(uint *)(iVar4 + 0xc) = uVar5 + 1;
		    *(int *)(*(int *)(iVar4 + 8) + uVar5 * 4 + 0x10) = iVar3;
		  }
		  else {
		    System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		              (iVar4,iVar3,*(undefined4 *)(*(int *)(*(int *)(iVar2 + 0x10) + 0x60) + 0x38));
		  }
		  iVar4 = *(int *)(param1_00 + 0x24);
		  iVar3 = unnamed_function_1417
		                    (
		                    UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs__TypeInfo
		                    );
		  UI_Windows_DialogWindow_DialogWindowArgs___ctor
		            (iVar3,
		             Method_UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs___ctor__
		            );
		  uVar1 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_4107,1,0,1,0,0,0,0);
		  *(undefined4 *)(iVar3 + 8) = uVar1;
		  iVar2 = 
		  Method_System_Collections_Generic_List_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs___Add__
		  ;
		  *(int *)(iVar4 + 0x10) = *(int *)(iVar4 + 0x10) + 1;
		  uVar5 = *(uint *)(iVar4 + 0xc);
		  if (uVar5 < *(uint *)(*(int *)(iVar4 + 8) + 0xc)) {
		    *(uint *)(iVar4 + 0xc) = uVar5 + 1;
		    *(int *)(*(int *)(iVar4 + 8) + uVar5 * 4 + 0x10) = iVar3;
		  }
		  else {
		    System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		              (iVar4,iVar3,*(undefined4 *)(*(int *)(*(int *)(iVar2 + 0x10) + 0x60) + 0x38));
		  }
		  uVar1 = UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_ButtonCallbackDelegate_object____ctor
		                    (param1_00,0);
		  return uVar1;
		}
		*/

			return null;
		}

		// Token: 0x06003F3A RID: 16186 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6003F3A")]
		[Address(RVA = "0x8DF5", Offset = "0x8DF5", VA = "0x8DF5")]
		private DialogWindow ShowBuyPlaceConfirmationWindow(Money price)
		{
		/* --- GHIDRA: ShowBuyPlaceConfirmationWindow ---
		void Gameplay_Clans_Office_Controller_ClanMembersViewMediator__ShowBuyPlaceConfirmationWindow
		               (int *param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  
		  (**(code **)((ulonglong)*(uint *)(*param1 + 0x140) * 4))
		            (param1,0,*(undefined4 *)(*param1 + 0x144));
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar1 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (uVar1,0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar1,0,0);
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (*(undefined4 *)(iVar2 + 0x44),0,0);
		  return;
		}
		*/

			return null;
		}

		// Token: 0x06003F3B RID: 16187 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003F3B")]
		[Address(RVA = "0x8DF6", Offset = "0x8DF6", VA = "0x8DF6", Slot = "21")]
		public void Hide()
		{
		/* --- GHIDRA: Hide ---
		undefined8
		Gameplay_Clans_Office_Controller_ClanMembersViewMediator__Hide
		          (int param1,int param2,undefined4 param3)
		
		{
		  int *param1_00;
		  uint *puVar1;
		  undefined8 uVar2;
		  int iVar3;
		  int iVar4;
		  uint uVar5;
		  
		  iVar3 = *(int *)(param1 + 0x1c);
		  iVar4 = *(int *)(param1 + 0x20);
		  param1_00 = (int *)0x0;
		  if (DAT_ram_00a57f7a == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_IList_ulong__TypeInfo);
		    DAT_ram_00a57f7a = '\x01';
		  }
		  if (iVar3 == 1) {
		    param1_00 = *(int **)(param2 + 0x1c);
		  }
		  else if (iVar3 == 2) {
		    param1_00 = *(int **)(param2 + 0x20);
		  }
		  else if (iVar3 == 3) {
		    param1_00 = *(int **)(*(int *)(*(int *)(param2 + 0x18) + 0x34) + 0x34);
		  }
		  uVar5 = 0;
		  iVar3 = *param1_00;
		  if (*(ushort *)(iVar3 + 0xb6) != 0) {
		    do {
		      if (System_Collections_Generic_IList_ulong__TypeInfo ==
		          *(int *)(*(int *)(iVar3 + 0x58) + uVar5 * 8)) {
		        puVar1 = (uint *)(iVar3 + *(int *)(*(int *)(iVar3 + 0x58) + uVar5 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x80e942f9;
		      }
		      uVar5 = uVar5 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar5);
		  }
		  puVar1 = (uint *)func_ii_1080(param1_00,System_Collections_Generic_IList_ulong__TypeInfo,0);
		code_r0x80e942f9:
		  uVar2 = (**(code **)((ulonglong)*puVar1 * 4))(param1_00,iVar4 + -1,puVar1[1]);
		  *(undefined8 *)(param2 + 0x28) = uVar2;
		  return uVar2;
		}
		*/

		}

		// Token: 0x04002390 RID: 9104
		[Token(Token = "0x4002390")]
		[FieldOffset(Offset = "0x18")]
		private ClanMemberListElement.ClanMemberListElementArgs _selectedArgs;

		// Token: 0x04002391 RID: 9105
		[Token(Token = "0x4002391")]
		[FieldOffset(Offset = "0x1C")]
		private RatingPeriods _ratingPeriod;

		// Token: 0x04002392 RID: 9106
		[Token(Token = "0x4002392")]
		[FieldOffset(Offset = "0x20")]
		private UserRatingTypes _ratingType;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_View ---
		void Gameplay_Clans_Office_Controller_ClanMembersViewMediator__set_View
		               (int *param1,undefined4 param2)
		
		{
		  bool bVar1;
		  uint *puVar2;
		  undefined4 uVar3;
		  undefined4 uVar4;
		  int iVar5;
		  int iVar6;
		  int *piVar7;
		  uint uVar8;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a57ffe == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_ClanInfoModel__ClanInfoEvents__ClanInfoController__ClanMembersView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Clans_Office_Controller_ClanMembersViewMediator_DisbandButtonClickedEventHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Clans_Office_Controller_ClanMembersViewMediator_LeaveButtonClickedEventHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_UnityEngine_Component_GetComponentInChildren_TextMeshProUGUI___);
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Dic_RatingTypesDic_TypeInfo);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Events_UnityAction_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_4314);
		    Mono_Security_ASN1__get_Item(&StringLiteral_4305);
		    DAT_ram_00a57ffe = '\x01';
		  }
		  local_4 = 0;
		  iVar5 = param1[2];
		  iVar6 = *(int *)(iVar5 + 0x2c);
		  if (iVar6 == 0) {
		    iVar6 = Gameplay_Clans_Office_Model_ClanInfoModel__ConstructArgs(iVar5,0);
		  }
		  *(int *)(iVar5 + 0x2c) = iVar6;
		  piVar7 = *(int **)(*(int *)(iVar6 + 0x10) + 0xc);
		  if ((piVar7 != (int *)0x0) && (Protocol_Dic_RatingTypesDic_TypeInfo != *piVar7)) {
		    System_Activator__CreateInstance(piVar7,Protocol_Dic_RatingTypesDic_TypeInfo);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  param1[7] = piVar7[3];
		  iVar6 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  piVar7 = *(int **)(iVar6 + 0x20);
		  iVar5 = param1[2];
		  iVar6 = *(int *)(iVar5 + 0x2c);
		  if (iVar6 == 0) {
		    iVar6 = Gameplay_Clans_Office_Model_ClanInfoModel__ConstructArgs(iVar5,0);
		  }
		  *(int *)(iVar5 + 0x2c) = iVar6;
		  iVar5 = *piVar7;
		  (**(code **)((ulonglong)*(uint *)(iVar5 + 0xe0) * 4))(piVar7,iVar6,*(undefined4 *)(iVar5 + 0xe4));
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  piVar7 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar6 = *piVar7;
		  if (*(ushort *)(iVar6 + 0xb6) != 0) {
		    uVar8 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar6 + 0x58) + uVar8 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar8 * 8 + 4) * 8 + iVar6 + 0x140);
		        goto code_r0x80e91d2e;
		      }
		      uVar8 = uVar8 + 1;
		    } while (*(ushort *)(iVar6 + 0xb6) != uVar8);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar7,Core_Gameplay_IGame_TypeInfo,0x10);
		code_r0x80e91d2e:
		  bVar1 = true;
		  iVar6 = (**(code **)((ulonglong)*puVar2 * 4))(piVar7,puVar2[1]);
		  uVar8 = (uint)(*(longlong *)(*(int *)(iVar6 + 0x14) + 0x10) == *(longlong *)(param1[2] + 0x10));
		  if (uVar8 == 0) {
		    bVar1 = *(int *)(*(int *)(param1[2] + 8) + 0x68) != 0;
		  }
		  iVar6 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar3 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (*(undefined4 *)(iVar6 + 0x34),0);
		  if (bVar1) {
		    uVar4 = 0;
		  }
		  else {
		    local_4 = *(undefined4 *)(*(int *)(*(int *)(*(int *)(param1[2] + 0x30) + 8) + 0x10) + 0x20);
		    uVar4 = UnityEngine_InputForUI_PointerEvent_ButtonsState__Set(&local_4,2,0);
		  }
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar3,uVar4,0);
		  iVar6 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar3 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (*(undefined4 *)(iVar6 + 0x38),0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar3,uVar8,0);
		  if (*(int *)(param1[2] + 0x20) == 2) {
		    iVar6 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar3 = UI_Rewards_AbstractRewardsRender__SetRewards
		                      (*(undefined4 *)(iVar6 + 0x2c),
		                       Method_UnityEngine_Component_GetComponentInChildren_TextMeshProUGUI___);
		    if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_GameLocalization_TypeInfo);
		    }
		    uVar4 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_4314,1,0,1,0,0,0,0);
		    UnityEngine_Component__GetComponentInChildren_object_(uVar3,uVar4,0);
		    iVar6 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar4 = *(undefined4 *)(*(int *)(iVar6 + 0x2c) + 0xb4);
		    uVar3 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		    Utils_ObjectUtils__IsNotNull
		              (uVar3,param1,
		               Method_Gameplay_Clans_Office_Controller_ClanMembersViewMediator_LeaveButtonClickedEventHandler__
		               ,0);
		    Gameplay_Boss_View_CaptainTab_BossInfoView__add_AttackButtonClickEvent(uVar4,uVar3,0);
		  }
		  else if (*(int *)(param1[2] + 0x20) == 3) {
		    iVar6 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar3 = UI_Rewards_AbstractRewardsRender__SetRewards
		                      (*(undefined4 *)(iVar6 + 0x2c),
		                       Method_UnityEngine_Component_GetComponentInChildren_TextMeshProUGUI___);
		    if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_GameLocalization_TypeInfo);
		    }
		    uVar4 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_4305,1,0,1,0,0,0,0);
		    UnityEngine_Component__GetComponentInChildren_object_(uVar3,uVar4,0);
		    iVar6 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar4 = *(undefined4 *)(*(int *)(iVar6 + 0x2c) + 0xb4);
		    uVar3 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		    Utils_ObjectUtils__IsNotNull
		              (uVar3,param1,
		               Method_Gameplay_Clans_Office_Controller_ClanMembersViewMediator_DisbandButtonClickedEventHandler__
		               ,0);
		    Gameplay_Boss_View_CaptainTab_BossInfoView__add_AttackButtonClickEvent(uVar4,uVar3,0);
		  }
		  if (!bVar1) {
		    Gameplay_Clans_Office_Controller_ClanMembersViewMediator__DrawMembersList(param1,0);
		  }
		  uVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar3 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (uVar3,0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar3,1,0);
		  return;
		}
		*/


		/* --- GHIDRA: set_Events ---
		void Gameplay_Clans_Office_Controller_ClanMembersViewMediator__set_Events
		               (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  if (DAT_ram_00a58009 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_ClanInfoModel__ClanInfoEvents__ClanInfoController__ClanMembersView__get_Model__
		              );
		    DAT_ram_00a58009 = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  func_ii_7603(*(undefined4 *)(iVar1 + 0x40),
		               (*(uint *)(*(int *)(*(int *)(*(int *)(param1[2] + 0x30) + 0xc) + 0x1c) + 0x20) & 2)
		               >> 1,0);
		  return;
		}
		*/

}
