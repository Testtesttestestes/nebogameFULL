using System;
using Gameplay.Clans.Office.Events;
using Gameplay.Clans.Office.Model;
using Gameplay.Clans.Office.View.ClanResumesTab;
using Il2CppDummyDll;
using MVC;
using MVC.Interfaces;
using Protocol.Rating;
using UI.Elements.Filters.GenericFilter;

namespace Gameplay.Clans.Office.Controller
{
	// Token: 0x02000A6F RID: 2671
	[Token(Token = "0x2000A6F")]
	public class ClanResumesViewMediator : AbstractViewMediator<ClanResumesModel, ClanResumesEvents, ClanResumesController, ClanResumesView>, IHideableMediator
	{
		// Token: 0x06003F75 RID: 16245 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003F75")]
		[Address(RVA = "0x8E30", Offset = "0x8E30", VA = "0x8E30")]
		public ClanResumesViewMediator(ClanResumesModel model, ClanResumesEvents events, ClanResumesController controller)
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Clans_Office_Controller_ClanResumesViewMediator___ctor
		               (int *param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  undefined4 uVar3;
		  int *piVar4;
		  undefined4 uVar5;
		  
		  if (DAT_ram_00a57678 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_ClanResumesModel__ClanResumesEvents__ClanResumesController__ClanResumesView__set_View__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_SubFilterListElement__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_object__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Clans_Office_Controller_ClanResumesViewMediator_AcceptButtonClickedEventHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Clans_Office_Controller_ClanResumesViewMediator_AddVacancyButtonClickedEventHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Clans_Office_Controller_ClanResumesViewMediator_DeclineButtonClickedEventHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Clans_Office_Controller_ClanResumesViewMediator_FilterSelectedEventHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Clans_Office_Controller_ClanResumesViewMediator_MoreItemsAfterNeededEventHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Clans_Office_Controller_ClanResumesViewMediator_OpenClanToggleChangedEventHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Clans_Office_Controller_ClanResumesViewMediator_SubFilterClickedEventHandler__
		              );
		    Mono_Security_ASN1__get_Item(&UnityEngine_Events_UnityAction_bool__TypeInfo);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Events_UnityAction_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Events_UnityEvent_bool__AddListener__);
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Events_UnityEvent_bool__RemoveListener__);
		    DAT_ram_00a57678 = '\x01';
		  }
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar2 = Cysharp_Threading_Tasks_CancellationTokenExtensions___cctor(uVar1,0);
		  if (iVar2 != 0) {
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar5 = *(undefined4 *)(iVar2 + 0x24);
		    uVar1 = unnamed_function_1417(System_Action_SubFilterListElement__TypeInfo);
		    UnityEngine_UIElements_VisualElement__get_layout
		              (uVar1,param1,
		               Method_Gameplay_Clans_Office_Controller_ClanResumesViewMediator_SubFilterClickedEventHandler__
		               ,0);
		    UI_Elements_Filters_GenericFilter_GenericSubFilterView__add_ClickedEvent(uVar5,uVar1,0);
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar5 = *(undefined4 *)(iVar2 + 0x20);
		    uVar1 = unnamed_function_1417(System_Action_object__TypeInfo);
		    UnityEngine_UIElements_VisualElement__get_layout
		              (uVar1,param1,
		               Method_Gameplay_Clans_Office_Controller_ClanResumesViewMediator_FilterSelectedEventHandler__
		               ,0);
		    UI_Elements_Filters_GenericFilter_GenericFilterView__add_SelectedEvent(uVar5,uVar1,0);
		    uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar5 = Gameplay_Clans_Office_View_ClanResumesTab_ClanResumesView__get_AdditionalButtons
		                      (uVar1,0);
		    uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar3,param1,
		               Method_Gameplay_Clans_Office_Controller_ClanResumesViewMediator_MoreItemsAfterNeededEventHandler__
		               ,0);
		    piVar4 = (int *)func_ii_7048(uVar5,uVar3,0);
		    if ((piVar4 != (int *)0x0) && (System_Action_TypeInfo != *piVar4)) {
		      System_Activator__CreateInstance(piVar4,System_Action_TypeInfo);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    Gameplay_Clans_Office_View_ClanResumesTab_ClanResumesView__get_MoreItemsAfterNeededEvent
		              (uVar1,piVar4,0);
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar5 = *(undefined4 *)(*(int *)(*(int *)(iVar2 + 0x28) + 0x1c) + 0xb4);
		    uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		    Utils_ObjectUtils__IsNotNull
		              (uVar1,param1,
		               Method_Gameplay_Clans_Office_Controller_ClanResumesViewMediator_AcceptButtonClickedEventHandler__
		               ,0);
		    UnityEngine_Events_UnityAction___ctor(uVar5,uVar1,0);
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar5 = *(undefined4 *)(*(int *)(*(int *)(iVar2 + 0x28) + 0x20) + 0xb4);
		    uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		    Utils_ObjectUtils__IsNotNull
		              (uVar1,param1,
		               Method_Gameplay_Clans_Office_Controller_ClanResumesViewMediator_DeclineButtonClickedEventHandler__
		               ,0);
		    UnityEngine_Events_UnityAction___ctor(uVar5,uVar1,0);
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar5 = *(undefined4 *)(*(int *)(iVar2 + 0x34) + 0xc0);
		    uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_bool__TypeInfo);
		    UnityEngine_UI_Toggle__set_group
		              (uVar1,param1,
		               Method_Gameplay_Clans_Office_Controller_ClanResumesViewMediator_OpenClanToggleChangedEventHandler__
		               ,0);
		    UnityEngine_Events_UnityEvent_InputAction_CallbackContext___Invoke
		              (uVar5,uVar1,Method_UnityEngine_Events_UnityEvent_bool__RemoveListener__);
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar5 = *(undefined4 *)(*(int *)(iVar2 + 0x30) + 0xb4);
		    uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		    Utils_ObjectUtils__IsNotNull
		              (uVar1,param1,
		               Method_Gameplay_Clans_Office_Controller_ClanResumesViewMediator_AddVacancyButtonClickedEventHandler__
		               ,0);
		    UnityEngine_Events_UnityAction___ctor(uVar5,uVar1,0);
		  }
		  param1[5] = param2;
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar2 = Cysharp_Threading_Tasks_CancellationTokenExtensions___cctor(uVar1,0);
		  if (iVar2 != 0) {
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar5 = *(undefined4 *)(iVar2 + 0x24);
		    uVar1 = unnamed_function_1417(System_Action_SubFilterListElement__TypeInfo);
		    UnityEngine_UIElements_VisualElement__get_layout
		              (uVar1,param1,
		               Method_Gameplay_Clans_Office_Controller_ClanResumesViewMediator_SubFilterClickedEventHandler__
		               ,0);
		    UI_Elements_Filters_GenericFilter_GenericFilterView___ctor(uVar5,uVar1,0);
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar5 = *(undefined4 *)(iVar2 + 0x20);
		    uVar1 = unnamed_function_1417(System_Action_object__TypeInfo);
		    UnityEngine_UIElements_VisualElement__get_layout
		              (uVar1,param1,
		               Method_Gameplay_Clans_Office_Controller_ClanResumesViewMediator_FilterSelectedEventHandler__
		               ,0);
		    UI_Elements_Filters_GenericFilter_FilterWithIconListElement_FilterWithIconData___ctor
		              (uVar5,uVar1,0);
		    uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar5 = Gameplay_Clans_Office_View_ClanResumesTab_ClanResumesView__get_AdditionalButtons
		                      (uVar1,0);
		    uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar3,param1,
		               Method_Gameplay_Clans_Office_Controller_ClanResumesViewMediator_MoreItemsAfterNeededEventHandler__
		               ,0);
		    piVar4 = (int *)UnityEngine_UI_Image__set_sprite(uVar5,uVar3,0);
		    if ((piVar4 != (int *)0x0) && (System_Action_TypeInfo != *piVar4)) {
		      System_Activator__CreateInstance(piVar4,System_Action_TypeInfo);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    Gameplay_Clans_Office_View_ClanResumesTab_ClanResumesView__get_MoreItemsAfterNeededEvent
		              (uVar1,piVar4,0);
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar5 = *(undefined4 *)(*(int *)(*(int *)(iVar2 + 0x28) + 0x1c) + 0xb4);
		    uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		    Utils_ObjectUtils__IsNotNull
		              (uVar1,param1,
		               Method_Gameplay_Clans_Office_Controller_ClanResumesViewMediator_AcceptButtonClickedEventHandler__
		               ,0);
		    Gameplay_Boss_View_CaptainTab_BossInfoView__add_AttackButtonClickEvent(uVar5,uVar1,0);
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar5 = *(undefined4 *)(*(int *)(*(int *)(iVar2 + 0x28) + 0x20) + 0xb4);
		    uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		    Utils_ObjectUtils__IsNotNull
		              (uVar1,param1,
		               Method_Gameplay_Clans_Office_Controller_ClanResumesViewMediator_DeclineButtonClickedEventHandler__
		               ,0);
		    Gameplay_Boss_View_CaptainTab_BossInfoView__add_AttackButtonClickEvent(uVar5,uVar1,0);
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar5 = *(undefined4 *)(*(int *)(iVar2 + 0x34) + 0xc0);
		    uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_bool__TypeInfo);
		    UnityEngine_UI_Toggle__set_group
		              (uVar1,param1,
		               Method_Gameplay_Clans_Office_Controller_ClanResumesViewMediator_OpenClanToggleChangedEventHandler__
		               ,0);
		    UnityEngine_Events_UnityEvent_InputAction_CallbackContext____ctor
		              (uVar5,uVar1,Method_UnityEngine_Events_UnityEvent_bool__AddListener__);
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar5 = *(undefined4 *)(*(int *)(iVar2 + 0x30) + 0xb4);
		    uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		    Utils_ObjectUtils__IsNotNull
		              (uVar1,param1,
		               Method_Gameplay_Clans_Office_Controller_ClanResumesViewMediator_AddVacancyButtonClickedEventHandler__
		               ,0);
		    Gameplay_Boss_View_CaptainTab_BossInfoView__add_AttackButtonClickEvent(uVar5,uVar1,0);
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		              (*(undefined4 *)(iVar2 + 0x38),1,0);
		    Gameplay_Clans_Office_Controller_ClanResumesViewMediator__set_View(param1,param1);
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x14c));
		    if (*(char *)(*(int *)(iVar2 + 0x1c) + 9) != '\0') {
		      Gameplay_Clans_Office_Controller_ClanResumesViewMediator__Init(param1,param1);
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x17000CA3 RID: 3235
		// (set) Token: 0x06003F76 RID: 16246 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000CA3")]
		public override ClanResumesView View
		{
			[Token(Token = "0x6003F76")]
			[Address(RVA = "0x8E31", Offset = "0x8E31", VA = "0x8E31", Slot = "20")]
			set
			{
			}
		}

		// Token: 0x06003F77 RID: 16247 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003F77")]
		[Address(RVA = "0x8E32", Offset = "0x8E32", VA = "0x8E32")]
		private void Init()
		{
		/* --- GHIDRA: Init ---
		void Gameplay_Clans_Office_Controller_ClanResumesViewMediator__Init(int *param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a5767a == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_ClanResumesModel__ClanResumesEvents__ClanResumesController__ClanResumesView__get_Model__
		              );
		    DAT_ram_00a5767a = '\x01';
		  }
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  Gameplay_Clans_Office_View_ClanResumesTab_ClanResumesView__set_MoreItemsAfterNeededEvent
		            (uVar1,*(undefined4 *)(*(int *)(param1[2] + 0x10) + 0x30),0);
		  Gameplay_Clans_Office_Controller_ClanResumesViewMediator__RequestFirstResumes(param1,param1);
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar1 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (uVar1,0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar1,1,0);
		  return;
		}
		*/

		}

		// Token: 0x06003F78 RID: 16248 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003F78")]
		[Address(RVA = "0x8E33", Offset = "0x8E33", VA = "0x8E33")]
		private void InitEventHandler()
		{
		/* --- GHIDRA: InitEventHandler ---
		void Gameplay_Clans_Office_Controller_ClanResumesViewMediator__InitEventHandler
		               (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x14c));
		  Gameplay_Clans_Office_Controller_ClanInfoController__AppointHeadResultHandler
		            (*(undefined4 *)(iVar1 + 0x1c),0);
		  return;
		}
		*/

		}

		// Token: 0x06003F79 RID: 16249 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003F79")]
		[Address(RVA = "0x8E34", Offset = "0x8E34", VA = "0x8E34")]
		private void AddVacancyButtonClickedEventHandler()
		{
		/* --- GHIDRA: AddVacancyButtonClickedEventHandler ---
		void Gameplay_Clans_Office_Controller_ClanResumesViewMediator__AddVacancyButtonClickedEventHandler
		               (int *param1,undefined4 param2)
		
		{
		  undefined4 in_register_20000014;
		  undefined4 param1_00;
		  undefined8 param2_00;
		  
		  param1_00 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                        (param1,CONCAT44(in_register_20000014,*(undefined4 *)(*param1 + 0x14c)));
		  param2_00 = System_Collections_Generic_LinkedList_Enumerator_object___MoveNext
		                        (*(undefined4 *)(param1[6] + 0x1c),0);
		  Gameplay_Clans_Office_Controller_ClanResumesController__GetFirstJoinRequestsResultHandler
		            (param1_00,param2_00,param1);
		  return;
		}
		*/

		}

		// Token: 0x06003F7A RID: 16250 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003F7A")]
		[Address(RVA = "0x8E35", Offset = "0x8E35", VA = "0x8E35")]
		private void DeclineButtonClickedEventHandler()
		{
		/* --- GHIDRA: DeclineButtonClickedEventHandler ---
		void Gameplay_Clans_Office_Controller_ClanResumesViewMediator__DeclineButtonClickedEventHandler
		               (int *param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  
		  param1_00 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x14c));
		  Gameplay_Clans_Office_Controller_ClanResumesController__DeclineJoinRequestsResultHandler
		            (param1_00,*(undefined4 *)(param1[6] + 0x1c),param1);
		  return;
		}
		*/

		}

		// Token: 0x06003F7B RID: 16251 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003F7B")]
		[Address(RVA = "0x8E36", Offset = "0x8E36", VA = "0x8E36")]
		private void AcceptButtonClickedEventHandler()
		{
		/* --- GHIDRA: AcceptButtonClickedEventHandler ---
		void Gameplay_Clans_Office_Controller_ClanResumesViewMediator__AcceptButtonClickedEventHandler
		               (int *param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 param2_00;
		  
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x14c));
		  param2_00 = 2;
		  if (param2 == 0) {
		    param2_00 = 0;
		  }
		  Gameplay_Clans_Office_Controller_ClanInfoController__AddVacancyResultHandler
		            (*(undefined4 *)(iVar1 + 0x1c),param2_00,0);
		  return;
		}
		*/

		}

		// Token: 0x06003F7C RID: 16252 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003F7C")]
		[Address(RVA = "0x8E37", Offset = "0x8E37", VA = "0x8E37")]
		private void OpenClanToggleChangedEventHandler(bool enable)
		{
		/* --- GHIDRA: OpenClanToggleChangedEventHandler ---
		void Gameplay_Clans_Office_Controller_ClanResumesViewMediator__OpenClanToggleChangedEventHandler
		               (int *param1,int param2,undefined4 param3)
		
		{
		  undefined4 param1_00;
		  int *param1_01;
		  int iVar1;
		  
		  if (DAT_ram_00a5767b == '\0') {
		    Mono_Security_ASN1__get_Item(&Protocol_Dic_UserRatingKindDic_TypeInfo);
		    DAT_ram_00a5767b = '\x01';
		  }
		  param1_01 = *(int **)(param2 + 0x20);
		  if ((param1_01 != (int *)0x0) && (Protocol_Dic_UserRatingKindDic_TypeInfo != *param1_01)) {
		    System_Activator__CreateInstance(param1_01,Protocol_Dic_UserRatingKindDic_TypeInfo);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  iVar1 = param1_01[3];
		  param1[7] = param2;
		  param1[9] = iVar1;
		  Gameplay_VortexRating_View_GreatPrizesTab_FilterListElement__set_Data(param2,1,0);
		  param1_00 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x14c));
		  Gameplay_Clans_Office_Controller_ClanResumesController__GetJoinRequestsResultHandler
		            (param1_00,param1[9],param1[8],param1);
		  return;
		}
		*/

		}

		// Token: 0x06003F7D RID: 16253 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003F7D")]
		[Address(RVA = "0x8E38", Offset = "0x8E38", VA = "0x8E38")]
		private void SelectSubFilter(SubFilterListElement element)
		{
		/* --- GHIDRA: SelectSubFilter ---
		void Gameplay_Clans_Office_Controller_ClanResumesViewMediator__SelectSubFilter
		               (int *param1,int param2,undefined4 param3)
		
		{
		  undefined4 param1_00;
		  int *param1_01;
		  int iVar1;
		  
		  Gameplay_VortexRating_View_GreatPrizesTab_FilterListElement__set_Data(param1[7],0,0);
		  if (DAT_ram_00a5767b == '\0') {
		    Mono_Security_ASN1__get_Item(&Protocol_Dic_UserRatingKindDic_TypeInfo);
		    DAT_ram_00a5767b = '\x01';
		  }
		  param1_01 = *(int **)(param2 + 0x20);
		  if ((param1_01 != (int *)0x0) && (Protocol_Dic_UserRatingKindDic_TypeInfo != *param1_01)) {
		    System_Activator__CreateInstance(param1_01,Protocol_Dic_UserRatingKindDic_TypeInfo);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  iVar1 = param1_01[3];
		  param1[7] = param2;
		  param1[9] = iVar1;
		  Gameplay_VortexRating_View_GreatPrizesTab_FilterListElement__set_Data(param2,1,0);
		  param1_00 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x14c));
		  Gameplay_Clans_Office_Controller_ClanResumesController__GetJoinRequestsResultHandler
		            (param1_00,param1[9],param1[8],param1);
		  return;
		}
		*/

		}

		// Token: 0x06003F7E RID: 16254 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003F7E")]
		[Address(RVA = "0x8E39", Offset = "0x8E39", VA = "0x8E39")]
		private void SubFilterClickedEventHandler(SubFilterListElement element)
		{
		/* --- GHIDRA: SubFilterClickedEventHandler ---
		void Gameplay_Clans_Office_Controller_ClanResumesViewMediator__SubFilterClickedEventHandler
		               (int *param1,int *param2,undefined4 param3)
		
		{
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a5767c == '\0') {
		    Mono_Security_ASN1__get_Item(&Protocol_Dic_RatingTypesDic_TypeInfo);
		    DAT_ram_00a5767c = '\x01';
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
		  Gameplay_Clans_Office_Controller_ClanResumesController__GetJoinRequestsResultHandler
		            (param1_00,param1[9],param1[8],param1);
		  return;
		}
		*/

		}

		// Token: 0x06003F7F RID: 16255 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003F7F")]
		[Address(RVA = "0x8E3A", Offset = "0x8E3A", VA = "0x8E3A")]
		private void FilterSelectedEventHandler(object data)
		{
		/* --- GHIDRA: FilterSelectedEventHandler ---
		void Gameplay_Clans_Office_Controller_ClanResumesViewMediator__FilterSelectedEventHandler
		               (int *param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  undefined8 param5;
		  undefined4 param4;
		  
		  if (DAT_ram_00a5767d == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_ClanResumesModel__ClanResumesEvents__ClanResumesController__ClanResumesView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Linq_Enumerable_Last_UserInRatingListElement_UserInRatingListElementArgs___
		              );
		    DAT_ram_00a5767d = '\x01';
		  }
		  uVar1 = Gameplay_Clans_Office_Model_ClanResumesModel___ctor(param1[2],0);
		  iVar2 = System_Linq_Enumerable__IntersectIterator___Il2CppFullySharedGenericType_
		                    (uVar1,
		                     Method_System_Linq_Enumerable_Last_UserInRatingListElement_UserInRatingListElementArgs___
		                    );
		  param5 = System_Collections_Generic_LinkedList_Enumerator_object___MoveNext
		                     (*(undefined4 *)(iVar2 + 0x1c),0);
		  param4 = *(undefined4 *)(iVar2 + 0x20);
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x14c));
		  Gameplay_Clans_Office_Controller_ClanResumesController___ctor
		            (uVar1,param1[9],param1[8],param4,param5,param1);
		  return;
		}
		*/

		}

		// Token: 0x06003F80 RID: 16256 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003F80")]
		[Address(RVA = "0x8E3B", Offset = "0x8E3B", VA = "0x8E3B")]
		private void MoreItemsAfterNeededEventHandler()
		{
		/* --- GHIDRA: MoreItemsAfterNeededEventHandler ---
		void Gameplay_Clans_Office_Controller_ClanResumesViewMediator__MoreItemsAfterNeededEventHandler
		               (int *param1,undefined8 param2,undefined8 param3,undefined4 param4)
		
		{
		  undefined4 param1_00;
		  
		  param1_00 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x14c));
		  Gameplay_Clans_Office_Controller_ClanResumesController___ctor
		            (param1_00,param1[9],param1[8],(undefined4)param3,param2,param1);
		  return;
		}
		*/

		}

		// Token: 0x06003F81 RID: 16257 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003F81")]
		[Address(RVA = "0x8E3C", Offset = "0x8E3C", VA = "0x8E3C")]
		private void RequestResumes(ulong lastUserId, ulong lastUserRating)
		{
		/* --- GHIDRA: RequestResumes ---
		void Gameplay_Clans_Office_Controller_ClanResumesViewMediator__RequestResumes
		               (int *param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  
		  param1_00 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x14c));
		  Gameplay_Clans_Office_Controller_ClanResumesController__GetJoinRequestsResultHandler
		            (param1_00,param1[9],param1[8],param1);
		  return;
		}
		*/

		}

		// Token: 0x06003F82 RID: 16258 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003F82")]
		[Address(RVA = "0x8E3D", Offset = "0x8E3D", VA = "0x8E3D")]
		private void RequestFirstResumes()
		{
		/* --- GHIDRA: RequestFirstResumes ---
		void Gameplay_Clans_Office_Controller_ClanResumesViewMediator__RequestFirstResumes
		               (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 param1_00;
		  undefined4 param2_00;
		  
		  if (DAT_ram_00a5767e == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_ClanResumesModel__ClanResumesEvents__ClanResumesController__ClanResumesView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&Core_Money_Money_TypeInfo);
		    DAT_ram_00a5767e = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  param1_00 = *(undefined4 *)(*(int *)(iVar1 + 0x30) + 0xb8);
		  param2_00 = *(undefined4 *)(*(int *)(*(int *)(param1[2] + 0x10) + 0x24) + 0x18);
		  uVar2 = Gameplay_Clans_Office_Model_ClanInfoModel__PopulateMembers(*(int *)(param1[2] + 0x10),0);
		  if (*(int *)(Core_Money_Money_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Money_Money_TypeInfo);
		  }
		  uVar2 = Core_Money_Money__op_Explicit(uVar2,0);
		  UI_Price_Price__SetColor(param1_00,param2_00,uVar2,0);
		  return;
		}
		*/

		}

		// Token: 0x06003F83 RID: 16259 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003F83")]
		[Address(RVA = "0x8E3E", Offset = "0x8E3E", VA = "0x8E3E")]
		private void UpdateAddVacancyPrice()
		{
		/* --- GHIDRA: UpdateAddVacancyPrice ---
		void Gameplay_Clans_Office_Controller_ClanResumesViewMediator__UpdateAddVacancyPrice
		               (int *param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  int iVar2;
		  undefined4 uVar3;
		  int *piVar4;
		  int iVar5;
		  undefined4 uVar6;
		  
		  if (DAT_ram_00a5767f == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_ClanResumesModel__ClanResumesEvents__ClanResumesController__ClanResumesView__set_Events__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_ulong__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Clans_Office_Controller_ClanResumesViewMediator_ClanStateFlagsChangedEventHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Clans_Office_Controller_ClanResumesViewMediator_FirstResumesRequestedEventHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Clans_Office_Controller_ClanResumesViewMediator_InitEventHandler__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Clans_Office_Controller_ClanResumesViewMediator_ResumeRemovedEventHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Clans_Office_Controller_ClanResumesViewMediator_ResumesAddedEventHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Clans_Office_Controller_ClanResumesViewMediator_VacancyAddedEventHandler__
		              );
		    DAT_ram_00a5767f = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x13c));
		  if (iVar1 != 0) {
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar6 = *(undefined4 *)(iVar2 + 0x18);
		    uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar3,param1,
		               Method_Gameplay_Clans_Office_Controller_ClanResumesViewMediator_FirstResumesRequestedEventHandler__
		               ,0);
		    piVar4 = (int *)func_ii_7048(uVar6,uVar3,0);
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
		    uVar6 = *(undefined4 *)(iVar2 + 0x1c);
		    uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar3,param1,
		               Method_Gameplay_Clans_Office_Controller_ClanResumesViewMediator_ResumesAddedEventHandler__
		               ,0);
		    piVar4 = (int *)func_ii_7048(uVar6,uVar3,0);
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
		    uVar6 = *(undefined4 *)(iVar2 + 0x34);
		    uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar3,param1,
		               Method_Gameplay_Clans_Office_Controller_ClanResumesViewMediator_ClanStateFlagsChangedEventHandler__
		               ,0);
		    piVar4 = (int *)func_ii_7048(uVar6,uVar3,0);
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
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar6 = *(undefined4 *)(iVar1 + 0x20);
		    uVar3 = unnamed_function_1417(System_Action_ulong__TypeInfo);
		    func_ii_6877(uVar3,param1,
		                 Method_Gameplay_Clans_Office_Controller_ClanResumesViewMediator_ResumeRemovedEventHandler__
		                 ,0);
		    iVar2 = func_ii_7048(uVar6,uVar3,0);
		    uVar3 = System_Action_ulong__TypeInfo;
		    if (iVar2 == 0) {
		      *(undefined4 *)(iVar1 + 0x20) = 0;
		    }
		    else {
		      iVar5 = func_ii_1082(iVar2,System_Action_ulong__TypeInfo);
		      if (iVar5 == 0) {
		        System_Activator__CreateInstance(iVar2,uVar3);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      *(int *)(iVar1 + 0x20) = iVar5;
		      uVar3 = System_Action_ulong__TypeInfo;
		      iVar1 = func_ii_1082(iVar2,System_Action_ulong__TypeInfo);
		      if (iVar1 == 0) {
		        System_Activator__CreateInstance(iVar2,uVar3);
		        do {
		          halt_trap();
		        } while( true );
		      }
		    }
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    iVar2 = *(int *)(iVar1 + 0x14);
		    uVar6 = *(undefined4 *)(iVar2 + 0x30);
		    uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar3,param1,
		               Method_Gameplay_Clans_Office_Controller_ClanResumesViewMediator_VacancyAddedEventHandler__
		               ,0);
		    piVar4 = (int *)func_ii_7048(uVar6,uVar3,0);
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
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    iVar2 = *(int *)(iVar1 + 0x14);
		    uVar6 = *(undefined4 *)(iVar2 + 8);
		    uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar3,param1,
		               Method_Gameplay_Clans_Office_Controller_ClanResumesViewMediator_InitEventHandler__,0)
		    ;
		    piVar4 = (int *)func_ii_7048(uVar6,uVar3,0);
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
		  }
		  param1[3] = param2;
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x13c));
		  if (iVar1 != 0) {
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar6 = *(undefined4 *)(iVar2 + 0x18);
		    uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar3,param1,
		               Method_Gameplay_Clans_Office_Controller_ClanResumesViewMediator_FirstResumesRequestedEventHandler__
		               ,0);
		    piVar4 = (int *)UnityEngine_UI_Image__set_sprite(uVar6,uVar3,0);
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
		    uVar6 = *(undefined4 *)(iVar2 + 0x1c);
		    uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar3,param1,
		               Method_Gameplay_Clans_Office_Controller_ClanResumesViewMediator_ResumesAddedEventHandler__
		               ,0);
		    piVar4 = (int *)UnityEngine_UI_Image__set_sprite(uVar6,uVar3,0);
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
		    uVar6 = *(undefined4 *)(iVar2 + 0x34);
		    uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar3,param1,
		               Method_Gameplay_Clans_Office_Controller_ClanResumesViewMediator_ClanStateFlagsChangedEventHandler__
		               ,0);
		    piVar4 = (int *)UnityEngine_UI_Image__set_sprite(uVar6,uVar3,0);
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
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar6 = *(undefined4 *)(iVar1 + 0x20);
		    uVar3 = unnamed_function_1417(System_Action_ulong__TypeInfo);
		    func_ii_6877(uVar3,param1,
		                 Method_Gameplay_Clans_Office_Controller_ClanResumesViewMediator_ResumeRemovedEventHandler__
		                 ,0);
		    iVar2 = UnityEngine_UI_Image__set_sprite(uVar6,uVar3,0);
		    uVar3 = System_Action_ulong__TypeInfo;
		    if (iVar2 == 0) {
		      *(undefined4 *)(iVar1 + 0x20) = 0;
		    }
		    else {
		      iVar5 = func_ii_1082(iVar2,System_Action_ulong__TypeInfo);
		      if (iVar5 == 0) {
		        System_Activator__CreateInstance(iVar2,uVar3);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      *(int *)(iVar1 + 0x20) = iVar5;
		      uVar3 = System_Action_ulong__TypeInfo;
		      iVar1 = func_ii_1082(iVar2,System_Action_ulong__TypeInfo);
		      if (iVar1 == 0) {
		        System_Activator__CreateInstance(iVar2,uVar3);
		        do {
		          halt_trap();
		        } while( true );
		      }
		    }
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    iVar2 = *(int *)(iVar1 + 0x14);
		    uVar6 = *(undefined4 *)(iVar2 + 0x30);
		    uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar3,param1,
		               Method_Gameplay_Clans_Office_Controller_ClanResumesViewMediator_VacancyAddedEventHandler__
		               ,0);
		    piVar4 = (int *)UnityEngine_UI_Image__set_sprite(uVar6,uVar3,0);
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
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    iVar2 = *(int *)(iVar1 + 0x14);
		    uVar6 = *(undefined4 *)(iVar2 + 8);
		    uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar3,param1,
		               Method_Gameplay_Clans_Office_Controller_ClanResumesViewMediator_InitEventHandler__,0)
		    ;
		    piVar4 = (int *)UnityEngine_UI_Image__set_sprite(uVar6,uVar3,0);
		    iVar1 = System_Action_TypeInfo;
		    if (piVar4 == (int *)0x0) {
		      *(undefined4 *)(iVar2 + 8) = 0;
		      return;
		    }
		    if ((System_Action_TypeInfo != *piVar4) || (*(int **)(iVar2 + 8) = piVar4, *piVar4 != iVar1)) {
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

		// Token: 0x17000CA4 RID: 3236
		// (set) Token: 0x06003F84 RID: 16260 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000CA4")]
		public override ClanResumesEvents Events
		{
			[Token(Token = "0x6003F84")]
			[Address(RVA = "0x8E3F", Offset = "0x8E3F", VA = "0x8E3F", Slot = "16")]
			set
			{
			}
		}

		// Token: 0x06003F85 RID: 16261 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003F85")]
		[Address(RVA = "0x8E40", Offset = "0x8E40", VA = "0x8E40")]
		private void ResumeRemovedEventHandler(ulong userId)
		{
		/* --- GHIDRA: ResumeRemovedEventHandler ---
		void Gameplay_Clans_Office_Controller_ClanResumesViewMediator__ResumeRemovedEventHandler
		               (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  if (DAT_ram_00a57681 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_ClanResumesModel__ClanResumesEvents__ClanResumesController__ClanResumesView__get_Model__
		              );
		    DAT_ram_00a57681 = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  Gameplay_Clans_Office_View_ClanTitle___ctor
		            (*(undefined4 *)(iVar1 + 0x2c),*(undefined4 *)(*(int *)(param1[2] + 0x10) + 0x30),0);
		  Gameplay_Clans_Office_Controller_ClanResumesViewMediator__RequestFirstResumes(param1,param1);
		  return;
		}
		*/

		}

		// Token: 0x06003F86 RID: 16262 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003F86")]
		[Address(RVA = "0x8E41", Offset = "0x8E41", VA = "0x8E41")]
		private void VacancyAddedEventHandler()
		{
		/* --- GHIDRA: VacancyAddedEventHandler ---
		void Gameplay_Clans_Office_Controller_ClanResumesViewMediator__VacancyAddedEventHandler
		               (int *param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a57682 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_ClanResumesModel__ClanResumesEvents__ClanResumesController__ClanResumesView__get_Model__
		              );
		    DAT_ram_00a57682 = '\x01';
		  }
		  param1_00 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x15c));
		  Gameplay_Clans_Office_View_ClanResumesTab_ClanResumesView__Init
		            (param1_00,*(undefined4 *)(*(int *)(param1[2] + 0x10) + 0x30),0);
		  return;
		}
		*/

		}

		// Token: 0x06003F87 RID: 16263 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003F87")]
		[Address(RVA = "0x8E42", Offset = "0x8E42", VA = "0x8E42")]
		private void ClanStateFlagsChangedEventHandler()
		{
		/* --- GHIDRA: ClanStateFlagsChangedEventHandler ---
		void Gameplay_Clans_Office_Controller_ClanResumesViewMediator__ClanStateFlagsChangedEventHandler
		               (int *param1,undefined4 param2)
		
		{
		  undefined4 param2_00;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a57683 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_ClanResumesModel__ClanResumesEvents__ClanResumesController__ClanResumesView__get_Model__
		              );
		    DAT_ram_00a57683 = '\x01';
		  }
		  Gameplay_Clans_Office_Controller_ClanResumesViewMediator__UpdateOSARequestBounds(param1,param1);
		  Gameplay_Clans_Office_Controller_ClanResumesViewMediator__FirstResumesRequestedEventHandler
		            (param1,param1);
		  param2_00 = Gameplay_Clans_Office_Model_ClanResumesModel___ctor(param1[2],0);
		  param1_00 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x15c));
		  Gameplay_Clans_Office_View_ClanResumesTab_ClanResumesView__Init(param1_00,param2_00,0);
		  return;
		}
		*/

		}

		// Token: 0x06003F88 RID: 16264 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003F88")]
		[Address(RVA = "0x8E43", Offset = "0x8E43", VA = "0x8E43")]
		private void ResumesAddedEventHandler()
		{
		/* --- GHIDRA: ResumesAddedEventHandler ---
		void Gameplay_Clans_Office_Controller_ClanResumesViewMediator__ResumesAddedEventHandler
		               (int *param1,undefined4 param2)
		
		{
		  uint uVar1;
		  int *param2_00;
		  undefined4 uVar2;
		  uint *puVar3;
		  int iVar4;
		  undefined4 uVar5;
		  int iVar6;
		  undefined4 param2_01;
		  
		  if (DAT_ram_00a57684 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_ClanResumesModel__ClanResumesEvents__ClanResumesController__ClanResumesView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               System_Collections_Generic_ICollection_UserInRatingListElement_UserInRatingListElementArgs__TypeInfo
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               System_Collections_Generic_IList_UserInRatingListElement_UserInRatingListElementArgs__TypeInfo
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_MonoBehaviourWithStates_ClanResumesView_ResumesState__set_CurrentState__);
		    DAT_ram_00a57684 = '\x01';
		  }
		  Gameplay_Clans_Office_Controller_ClanResumesViewMediator__UpdateOSARequestBounds(param1,0);
		  Gameplay_Clans_Office_Controller_ClanResumesViewMediator__FirstResumesRequestedEventHandler
		            (param1,0);
		  param2_00 = (int *)Gameplay_Clans_Office_Model_ClanResumesModel___ctor(param1[2],0);
		  uVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  Gameplay_Clans_Office_View_ClanResumesTab_ClanResumesView__UpdateToggle(uVar2,param2_00,0);
		  iVar6 = *param2_00;
		  if (*(ushort *)(iVar6 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (System_Collections_Generic_ICollection_UserInRatingListElement_UserInRatingListElementArgs__TypeInfo
		          == *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(iVar6 + *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x80dc2fa2;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(param2_00,
		                                System_Collections_Generic_ICollection_UserInRatingListElement_UserInRatingListElementArgs__TypeInfo
		                                ,0);
		code_r0x80dc2fa2:
		  iVar6 = (**(code **)((ulonglong)*puVar3 * 4))(param2_00,puVar3[1]);
		  if (iVar6 < 1) {
		    uVar2 = 2;
		  }
		  else {
		    uVar1 = 0;
		    iVar6 = *param2_00;
		    if (*(ushort *)(iVar6 + 0xb6) != 0) {
		      do {
		        if (System_Collections_Generic_IList_UserInRatingListElement_UserInRatingListElementArgs__TypeInfo
		            == *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8)) {
		          puVar3 = (uint *)(iVar6 + *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		          goto code_r0x80dc3028;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		    }
		    puVar3 = (uint *)func_ii_1080(param2_00,
		                                  System_Collections_Generic_IList_UserInRatingListElement_UserInRatingListElementArgs__TypeInfo
		                                  ,0);
		code_r0x80dc3028:
		    iVar6 = (**(code **)((ulonglong)*puVar3 * 4))(param2_00,0,puVar3[1]);
		    if (DAT_ram_00a57688 == '\0') {
		      Mono_Security_ASN1__get_Item
		                (&
		                 Method_MVC_AbstractViewMediator_ClanResumesModel__ClanResumesEvents__ClanResumesController__ClanResumesView__get_Model__
		                );
		      DAT_ram_00a57688 = '\x01';
		    }
		    param1[6] = iVar6;
		    Gameplay_Clans_Office_View_ClanMembersTab_ClanMemberListElement_ClanMemberListElementArgs__get_Selected
		              (iVar6,1,0);
		    iVar4 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar5 = *(undefined4 *)(iVar4 + 0x28);
		    param2_01 = *(undefined4 *)(iVar6 + 0x1c);
		    uVar2 = Gameplay_Clans_Office_Model_ClanOfficeModel___c__DisplayClass36_0___AddClanList_b__0
		                      (param1[2],0);
		    Gameplay_Clans_Office_View_ClanMembersTab_ClanMemberView__get_RightButton
		              (uVar5,param2_01,uVar2,0);
		    uVar2 = 1;
		  }
		  uVar5 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  Gameplay_Boss_View_CaptainTab_BossTeamView__set_TeamInfoData
		            (uVar5,uVar2,
		             Method_UI_MonoBehaviourWithStates_ClanResumesView_ResumesState__set_CurrentState__);
		  return;
		}
		*/

		}

		// Token: 0x06003F89 RID: 16265 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003F89")]
		[Address(RVA = "0x8E44", Offset = "0x8E44", VA = "0x8E44")]
		private void FirstResumesRequestedEventHandler()
		{
		/* --- GHIDRA: FirstResumesRequestedEventHandler ---
		void Gameplay_Clans_Office_Controller_ClanResumesViewMediator__FirstResumesRequestedEventHandler
		               (int *param1,undefined4 param2)
		
		{
		  uint uVar1;
		  int *param1_00;
		  uint *puVar2;
		  undefined4 param1_01;
		  int iVar3;
		  int iVar4;
		  
		  if (DAT_ram_00a57685 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_ClanResumesModel__ClanResumesEvents__ClanResumesController__ClanResumesView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               System_Collections_Generic_ICollection_UserInRatingListElement_UserInRatingListElementArgs__TypeInfo
		              );
		    DAT_ram_00a57685 = '\x01';
		  }
		  param1_00 = (int *)Gameplay_Clans_Office_Model_ClanResumesModel___ctor(param1[2],0);
		  iVar4 = *param1_00;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (System_Collections_Generic_ICollection_UserInRatingListElement_UserInRatingListElementArgs__TypeInfo
		          == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(iVar4 + *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x80dc2e82;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_00,
		                                System_Collections_Generic_ICollection_UserInRatingListElement_UserInRatingListElementArgs__TypeInfo
		                                ,0);
		code_r0x80dc2e82:
		  iVar4 = (**(code **)((ulonglong)*puVar2 * 4))(param1_00,puVar2[1]);
		  iVar3 = *(int *)(param1[2] + 0x1c);
		  param1_01 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x15c));
		  Gameplay_Clans_Office_View_ClanResumesTab_ClanResumesView__Add(param1_01,(uint)(iVar4 == iVar3),0)
		  ;
		  return;
		}
		*/

		}

		// Token: 0x06003F8A RID: 16266 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003F8A")]
		[Address(RVA = "0x8E45", Offset = "0x8E45", VA = "0x8E45")]
		private void UpdateOSARequestBounds()
		{
		/* --- GHIDRA: UpdateOSARequestBounds ---
		void Gameplay_Clans_Office_Controller_ClanResumesViewMediator__UpdateOSARequestBounds
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
		  
		  if (DAT_ram_00a57686 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_ClanResumesModel__ClanResumesEvents__ClanResumesController__ClanResumesView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_UserInRatingListElement__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Clans_Office_Controller_ClanResumesViewMediator_ListElementClickedEventHandler__
		              );
		    Mono_Security_ASN1__get_Item(&System_IDisposable_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               System_Collections_Generic_IEnumerable_UserInRatingListElement_UserInRatingListElementArgs__TypeInfo
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               System_Collections_Generic_IEnumerator_UserInRatingListElement_UserInRatingListElementArgs__TypeInfo
		              );
		    Mono_Security_ASN1__get_Item(&System_Collections_IEnumerator_TypeInfo);
		    DAT_ram_00a57686 = '\x01';
		  }
		  piVar2 = (int *)Gameplay_Clans_Office_Model_ClanResumesModel___ctor(*(undefined4 *)(param1 + 8),0)
		  ;
		  iVar8 = *piVar2;
		  if (*(ushort *)(iVar8 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (System_Collections_Generic_IEnumerable_UserInRatingListElement_UserInRatingListElementArgs__TypeInfo
		          == *(int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(iVar8 + *(int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x80dc2a30;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar8 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(piVar2,
		                                System_Collections_Generic_IEnumerable_UserInRatingListElement_UserInRatingListElementArgs__TypeInfo
		                                ,0);
		code_r0x80dc2a30:
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
		          goto code_r0x80dc2afb;
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
		code_r0x80dc2cab:
		      DAT_ram_009d3e38 = 0;
		      uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80dc2cb3;
		    }
		code_r0x80dc2afb:
		    DAT_ram_009d3e38 = 0;
		    iVar8 = import::env::invoke_iii(*puVar4,piVar2,puVar4[1]);
		    piVar2 = local_4;
		    if (DAT_ram_009d3e38 == 1) goto code_r0x80dc2cab;
		    if (iVar8 == 0) {
		      iVar8 = 0;
		      goto code_r0x80dc2cfc;
		    }
		    iVar8 = *local_4;
		    if (*(ushort *)(iVar8 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        piVar7 = (int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8);
		        if (System_Collections_Generic_IEnumerator_UserInRatingListElement_UserInRatingListElementArgs__TypeInfo
		            == *piVar7) {
		          puVar4 = (undefined4 *)(iVar8 + piVar7[1] * 8 + 0xc0);
		          goto code_r0x80dc2bd5;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar8 + 0xb6) != uVar1);
		    }
		    DAT_ram_009d3e38 = 0;
		    puVar4 = (undefined4 *)
		             import::env::invoke_iiii
		                       (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                        System_Collections_Generic_IEnumerator_UserInRatingListElement_UserInRatingListElementArgs__TypeInfo
		                        ,0);
		    if (DAT_ram_009d3e38 == 1) {
		code_r0x80dc2c97:
		      DAT_ram_009d3e38 = 0;
		      uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80dc2cb3;
		    }
		code_r0x80dc2bd5:
		    DAT_ram_009d3e38 = 0;
		    iVar8 = import::env::invoke_iii(*puVar4,piVar2,puVar4[1]);
		    if (DAT_ram_009d3e38 == 1) goto code_r0x80dc2c97;
		    DAT_ram_009d3e38 = 0;
		    uVar5 = import::env::invoke_ii
		                      (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x199,
		                       System_Action_UserInRatingListElement__TypeInfo);
		    if (DAT_ram_009d3e38 == 1) break;
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_viiii
		              (s_struct_Uniforms___color__array<v_ram_000017c8 + 0x241,uVar5,param1,
		               Method_Gameplay_Clans_Office_Controller_ClanResumesViewMediator_ListElementClickedEventHandler__
		               ,0);
		    if (DAT_ram_009d3e38 == 1) break;
		    *(undefined4 *)(iVar8 + 0x18) = uVar5;
		  } while( true );
		  DAT_ram_009d3e38 = 0;
		  uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x80dc2cb3:
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
		code_r0x80dc2cfc:
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
		              goto code_r0x80dc2d74;
		            }
		            uVar1 = uVar1 + 1;
		          } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		        }
		        puVar3 = (uint *)func_ii_1080(local_4,System_IDisposable_TypeInfo,0);
		code_r0x80dc2d74:
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
		  import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_000017c8 + 0x346,&local_c);
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

		// Token: 0x06003F8B RID: 16267 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003F8B")]
		[Address(RVA = "0x8E46", Offset = "0x8E46", VA = "0x8E46")]
		private void InjectCallback()
		{
		/* --- GHIDRA: InjectCallback ---
		void Gameplay_Clans_Office_Controller_ClanResumesViewMediator__InjectCallback
		               (int *param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 param3_00;
		  int param1_00;
		  undefined4 param1_01;
		  undefined4 param2_00;
		  
		  if (DAT_ram_00a57687 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Elements_GenericList_GenericListElement_UserInRatingListElement_UserInRatingListElementArgs__get_args__
		              );
		    DAT_ram_00a57687 = '\x01';
		  }
		  Gameplay_Clans_Office_View_ClanMembersTab_ClanMemberListElement_ClanMemberListElementArgs__get_Selected
		            (param1[6],0,0);
		  param1_00 = *(int *)(param2 + 0x18);
		  if (DAT_ram_00a57688 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_ClanResumesModel__ClanResumesEvents__ClanResumesController__ClanResumesView__get_Model__
		              );
		    DAT_ram_00a57688 = '\x01';
		  }
		  param1[6] = param1_00;
		  Gameplay_Clans_Office_View_ClanMembersTab_ClanMemberListElement_ClanMemberListElementArgs__get_Selected
		            (param1_00,1,0);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  param1_01 = *(undefined4 *)(iVar1 + 0x28);
		  param2_00 = *(undefined4 *)(param1_00 + 0x1c);
		  param3_00 = Gameplay_Clans_Office_Model_ClanOfficeModel___c__DisplayClass36_0___AddClanList_b__0
		                        (param1[2],0);
		  Gameplay_Clans_Office_View_ClanMembersTab_ClanMemberView__get_RightButton
		            (param1_01,param2_00,param3_00,0);
		  return;
		}
		*/

		}

		// Token: 0x06003F8C RID: 16268 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003F8C")]
		[Address(RVA = "0x8E47", Offset = "0x8E47", VA = "0x8E47")]
		private void ListElementClickedEventHandler(UserInRatingListElement element)
		{
		/* --- GHIDRA: ListElementClickedEventHandler ---
		void Gameplay_Clans_Office_Controller_ClanResumesViewMediator__ListElementClickedEventHandler
		               (int *param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 param3_00;
		  undefined4 param1_00;
		  undefined4 param2_00;
		  
		  if (DAT_ram_00a57688 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_ClanResumesModel__ClanResumesEvents__ClanResumesController__ClanResumesView__get_Model__
		              );
		    DAT_ram_00a57688 = '\x01';
		  }
		  param1[6] = param2;
		  Gameplay_Clans_Office_View_ClanMembersTab_ClanMemberListElement_ClanMemberListElementArgs__get_Selected
		            (param2,1,0);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  param1_00 = *(undefined4 *)(iVar1 + 0x28);
		  param2_00 = *(undefined4 *)(param2 + 0x1c);
		  param3_00 = Gameplay_Clans_Office_Model_ClanOfficeModel___c__DisplayClass36_0___AddClanList_b__0
		                        (param1[2],0);
		  Gameplay_Clans_Office_View_ClanMembersTab_ClanMemberView__get_RightButton
		            (param1_00,param2_00,param3_00,0);
		  return;
		}
		*/

		}

		// Token: 0x06003F8D RID: 16269 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003F8D")]
		[Address(RVA = "0x8E48", Offset = "0x8E48", VA = "0x8E48")]
		private void SelectArgs(UserInRatingListElement.UserInRatingListElementArgs args)
		{
		/* --- GHIDRA: SelectArgs ---
		void Gameplay_Clans_Office_Controller_ClanResumesViewMediator__SelectArgs
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
		            (*(undefined4 *)(iVar2 + 0x38),0,0);
		  return;
		}
		*/

		}

		// Token: 0x06003F8E RID: 16270 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003F8E")]
		[Address(RVA = "0x8E49", Offset = "0x8E49", VA = "0x8E49", Slot = "21")]
		public void Hide()
		{
		/* --- GHIDRA: Hide ---
		void Gameplay_Clans_Office_Controller_ClanResumesViewMediator__Hide
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4,undefined4 param5,
		               undefined4 param6)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  int *param1_00;
		  int iVar3;
		  
		  if (DAT_ram_00a57689 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_ClanInfoModel__ClanInfoEvents__ClanInfoController__ClanTreasuryView___ctor__
		              );
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a57689 = '\x01';
		  }
		  Gameplay_Combat_TeamCombat_View_AbstractTeamCombatView_object___get_HideInstantElements
		            (param1,param2,param3,param4,
		             Method_MVC_AbstractViewMediator_ClanInfoModel__ClanInfoEvents__ClanInfoController__ClanTreasuryView___ctor__
		            );
		  *(undefined4 *)(param1 + 0x18) = param5;
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
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + iVar3 + 0x240);
		        goto code_r0x80dc32f3;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_00,Core_Gameplay_IGame_TypeInfo,0x30);
		code_r0x80dc32f3:
		  iVar3 = (**(code **)((ulonglong)*puVar2 * 4))(param1_00,puVar2[1]);
		  *(undefined4 *)(param1 + 0x1c) = *(undefined4 *)(iVar3 + 0x10);
		  return;
		}
		*/

		}

		// Token: 0x040023A1 RID: 9121
		[Token(Token = "0x40023A1")]
		[FieldOffset(Offset = "0x18")]
		private UserInRatingListElement.UserInRatingListElementArgs _selectedArgs;

		// Token: 0x040023A2 RID: 9122
		[Token(Token = "0x40023A2")]
		[FieldOffset(Offset = "0x1C")]
		private SubFilterListElement _selectedFilter;

		// Token: 0x040023A3 RID: 9123
		[Token(Token = "0x40023A3")]
		[FieldOffset(Offset = "0x20")]
		private RatingPeriods _ratingPeriod;

		// Token: 0x040023A4 RID: 9124
		[Token(Token = "0x40023A4")]
		[FieldOffset(Offset = "0x24")]
		private UserRatingTypes _ratingType;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_View ---
		void Gameplay_Clans_Office_Controller_ClanResumesViewMediator__set_View
		               (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  int *piVar3;
		  int iVar4;
		  
		  if (DAT_ram_00a57679 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_ClanResumesModel__ClanResumesEvents__ClanResumesController__ClanResumesView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&Protocol_Dic_RatingTypesDic_TypeInfo);
		    DAT_ram_00a57679 = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  piVar3 = *(int **)(iVar1 + 0x20);
		  uVar2 = Gameplay_Clans_Office_Model_ClanInfoModel__set_ClanMembers
		                    (*(undefined4 *)(param1[2] + 0x10),0);
		  iVar1 = *piVar3;
		  (**(code **)((ulonglong)*(uint *)(iVar1 + 0xe0) * 4))(piVar3,uVar2,*(undefined4 *)(iVar1 + 0xe4));
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  UI_Elements_Filters_GenericFilter_GenericSubFilterView__remove_ClickedEvent
		            (*(undefined4 *)(iVar1 + 0x24),*(undefined4 *)(*(int *)(param1[2] + 0x10) + 0x1c),0);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar1 = UI_Elements_Filters_GenericFilter_GenericFilterView__SelectByIndexSilent
		                    (*(undefined4 *)(iVar1 + 0x20),0,0);
		  piVar3 = *(int **)(iVar1 + 0x24);
		  if ((piVar3 != (int *)0x0) && (Protocol_Dic_RatingTypesDic_TypeInfo != *piVar3)) {
		    System_Activator__CreateInstance(piVar3,Protocol_Dic_RatingTypesDic_TypeInfo);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  param1[8] = piVar3[3];
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar1 = UI_Elements_Filters_GenericFilter_GenericSubFilterView__SelectByIndexSilent
		                    (*(undefined4 *)(iVar1 + 0x24),0,0);
		  if (DAT_ram_00a5767b == '\0') {
		    Mono_Security_ASN1__get_Item(&Protocol_Dic_UserRatingKindDic_TypeInfo);
		    DAT_ram_00a5767b = '\x01';
		  }
		  piVar3 = *(int **)(iVar1 + 0x20);
		  if ((piVar3 != (int *)0x0) && (Protocol_Dic_UserRatingKindDic_TypeInfo != *piVar3)) {
		    System_Activator__CreateInstance(piVar3,Protocol_Dic_UserRatingKindDic_TypeInfo);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  iVar4 = piVar3[3];
		  param1[7] = iVar1;
		  param1[9] = iVar4;
		  Gameplay_VortexRating_View_GreatPrizesTab_FilterListElement__set_Data(iVar1,1,0);
		  uVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x14c));
		  Gameplay_Clans_Office_Controller_ClanResumesController__GetJoinRequestsResultHandler
		            (uVar2,param1[9],param1[8],param1);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  UI_Elements_Filters_GenericFilter_GenericFilterView__SelectElement
		            (*(undefined4 *)(iVar1 + 0x20),0,0);
		  return;
		}
		*/


		/* --- GHIDRA: set_Events ---
		void Gameplay_Clans_Office_Controller_ClanResumesViewMediator__set_Events
		               (int *param1,undefined8 param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int *param1_00;
		  uint *puVar2;
		  int iVar3;
		  uint uVar4;
		  
		  if (DAT_ram_00a57680 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_ClanResumesModel__ClanResumesEvents__ClanResumesController__ClanResumesView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               System_Collections_Generic_ICollection_UserInRatingListElement_UserInRatingListElementArgs__TypeInfo
		              );
		    DAT_ram_00a57680 = '\x01';
		  }
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  Gameplay_Clans_Office_View_ClanResumesTab_ClanResumesView__ActivateUpperBound(uVar1,param2,0);
		  uVar1 = (undefined4)((ulonglong)param2 >> 0x20);
		  param1_00 = (int *)Gameplay_Clans_Office_Model_ClanResumesModel___ctor(param1[2],0);
		  iVar3 = *param1_00;
		  if (*(ushort *)(iVar3 + 0xb6) != 0) {
		    uVar4 = 0;
		    do {
		      if (System_Collections_Generic_ICollection_UserInRatingListElement_UserInRatingListElementArgs__TypeInfo
		          == *(int *)(*(int *)(iVar3 + 0x58) + uVar4 * 8)) {
		        puVar2 = (uint *)(iVar3 + *(int *)(*(int *)(iVar3 + 0x58) + uVar4 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x80dc2825;
		      }
		      uVar4 = uVar4 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar4);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_00,
		                                System_Collections_Generic_ICollection_UserInRatingListElement_UserInRatingListElementArgs__TypeInfo
		                                ,0);
		code_r0x80dc2825:
		  iVar3 = (**(code **)((ulonglong)*puVar2 * 4))(param1_00,CONCAT44(uVar1,puVar2[1]));
		  if (iVar3 < 2) {
		    iVar3 = *param1;
		    uVar1 = (**(code **)((ulonglong)*(uint *)(iVar3 + 0x148) * 4))
		                      (param1,*(undefined4 *)(iVar3 + 0x14c));
		    Gameplay_Clans_Office_Controller_ClanResumesController__GetJoinRequestsResultHandler
		              (uVar1,param1[9],param1[8],iVar3);
		  }
		  return;
		}
		*/

}
