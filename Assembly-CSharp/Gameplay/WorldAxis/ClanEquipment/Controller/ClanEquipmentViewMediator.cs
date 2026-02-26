using System;
using System.Collections.Generic;
using Gameplay.WorldAxis.ClanEquipment.Events;
using Gameplay.WorldAxis.ClanEquipment.Model;
using Gameplay.WorldAxis.ClanEquipment.View;
using Il2CppDummyDll;
using MVC;
using Protocol.Clans;
using Protocol.Dic;

namespace Gameplay.WorldAxis.ClanEquipment.Controller
{
	// Token: 0x02000355 RID: 853
	[Token(Token = "0x2000355")]
	public class ClanEquipmentViewMediator : AbstractViewMediator<ClanEquipmentModel, ClanEquipmentEvents, ClanEquipmentController, ClanEquipmentWindow>
	{
		// Token: 0x0600136D RID: 4973 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600136D")]
		[Address(RVA = "0x655D", Offset = "0x655D", VA = "0x655D")]
		public ClanEquipmentViewMediator(ClanEquipmentModel model, ClanEquipmentEvents events, ClanEquipmentController controller)
		{
		/* --- GHIDRA: <OnlyEquippedToggledEventHandler>b__10_0 ---
		uint Gameplay_WorldAxis_ClanEquipment_Controller_ClanEquipmentViewMediator___OnlyEquippedToggledEventHandler_b__10_0
		               (int param1,int param2,undefined4 param3)
		
		{
		  longlong lVar1;
		  
		  if (DAT_ram_00a58c57 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_ClanEquipmentModel__ClanEquipmentEvents__ClanEquipmentController__ClanEquipmentWindow__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&Method_System_Nullable_ulong__GetValueOrDefault__);
		    Mono_Security_ASN1__get_Item(&Method_System_Nullable_ulong__get_HasValue__);
		    DAT_ram_00a58c57 = '\x01';
		  }
		  lVar1 = System_Collections_Generic_LinkedList_Enumerator_object___MoveNext
		                    (*(undefined4 *)(*(int *)(param2 + 0x1c) + 8),0);
		  return (uint)(*(char *)(*(int *)(param1 + 8) + 0x20) != '\0' &&
		               lVar1 == *(longlong *)(*(int *)(param1 + 8) + 0x28));
		}
		*/

		/* --- GHIDRA: .ctor ---
		uint Gameplay_WorldAxis_ClanEquipment_Controller_ClanEquipmentViewMediator___ctor
		               (int param1,int param2,undefined4 param3)
		
		{
		  uint uVar1;
		  undefined8 param2_00;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a58c4a == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_HashSet_ulong__Contains__);
		    DAT_ram_00a58c4a = '\x01';
		  }
		  param1_00 = *(undefined4 *)(param1 + 0x24);
		  param2_00 = System_Collections_Generic_LinkedList_Enumerator_object___MoveNext
		                        (*(undefined4 *)(*(int *)(param2 + 0x1c) + 8),0);
		  uVar1 = System_Collections_Generic_HashSet_ulong___Clear
		                    (param1_00,param2_00,Method_System_Collections_Generic_HashSet_ulong__Contains__
		                    );
		  return uVar1 ^ 1;
		}
		*/

		}

		// Token: 0x0600136E RID: 4974 RVA: 0x00004B48 File Offset: 0x00002D48
		[Token(Token = "0x600136E")]
		[Address(RVA = "0x655E", Offset = "0x655E", VA = "0x655E")]
		private bool DefaultListPredicate(ClanMemberDollsListElement.ClanMemberDollsListElementArgs args)
		{
		/* --- GHIDRA: DefaultListPredicate ---
		void Gameplay_WorldAxis_ClanEquipment_Controller_ClanEquipmentViewMediator__DefaultListPredicate
		               (int *param1,int param2,undefined4 param3)
		
		{
		  undefined4 param1_00;
		  undefined4 uVar1;
		  int iVar2;
		  undefined4 uVar3;
		  int *piVar4;
		  int iVar5;
		  
		  if (DAT_ram_00a58c4b == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_ClanEquipmentModel__ClanEquipmentEvents__ClanEquipmentController__ClanEquipmentWindow__set_View__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoUserLeftClanEvt__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_object__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_WorldAxis_ClanEquipment_Controller_ClanEquipmentViewMediator_ClansServiceOnUserLeftClanEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_WorldAxis_ClanEquipment_Controller_ClanEquipmentViewMediator_ExpellButtonClickedEventHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_WorldAxis_ClanEquipment_Controller_ClanEquipmentViewMediator_FilterDeselectedEventHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_WorldAxis_ClanEquipment_Controller_ClanEquipmentViewMediator_FilterSelectedEventHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_WorldAxis_ClanEquipment_Controller_ClanEquipmentViewMediator_OnlyEquippedToggledEventHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_WorldAxis_ClanEquipment_Controller_ClanEquipmentViewMediator_TakeOffAllButtonClickedEventHandler__
		              );
		    Mono_Security_ASN1__get_Item(&Method_Core_Net_ServiceFactory_GetService_ClansService___);
		    Mono_Security_ASN1__get_Item(&Core_Net_ServiceFactory_TypeInfo);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Events_UnityAction_bool__TypeInfo);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Events_UnityAction_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Events_UnityEvent_bool__AddListener__);
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Events_UnityEvent_bool__RemoveListener__);
		    DAT_ram_00a58c4b = '\x01';
		  }
		  if (*(int *)(Core_Net_ServiceFactory_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Net_ServiceFactory_TypeInfo);
		  }
		  param1_00 = Core_Gameplay_Managers_LoggedManager__RequestLogin
		                        (Method_Core_Net_ServiceFactory_GetService_ClansService___);
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar2 = Cysharp_Threading_Tasks_CancellationTokenExtensions___cctor(uVar1,0);
		  if (iVar2 != 0) {
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar3 = *(undefined4 *)(iVar2 + 0x4c);
		    uVar1 = unnamed_function_1417(System_Action_object__TypeInfo);
		    UnityEngine_UIElements_VisualElement__get_layout
		              (uVar1,param1,
		               Method_Gameplay_WorldAxis_ClanEquipment_Controller_ClanEquipmentViewMediator_FilterSelectedEventHandler__
		               ,0);
		    UI_Elements_Filters_GenericFilter_GenericFilterView__add_SelectedEvent(uVar3,uVar1,0);
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar3 = *(undefined4 *)(iVar2 + 0x4c);
		    uVar1 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar1,param1,
		               Method_Gameplay_WorldAxis_ClanEquipment_Controller_ClanEquipmentViewMediator_FilterDeselectedEventHandler__
		               ,0);
		    UI_Elements_Filters_GenericFilter_DeselectableGenericFilterView__add_DeselectedEvent
		              (uVar3,uVar1,0);
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar3 = *(undefined4 *)(*(int *)(iVar2 + 0x50) + 0xc0);
		    uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_bool__TypeInfo);
		    UnityEngine_UI_Toggle__set_group
		              (uVar1,param1,
		               Method_Gameplay_WorldAxis_ClanEquipment_Controller_ClanEquipmentViewMediator_OnlyEquippedToggledEventHandler__
		               ,0);
		    UnityEngine_Events_UnityEvent_InputAction_CallbackContext___Invoke
		              (uVar3,uVar1,Method_UnityEngine_Events_UnityEvent_bool__RemoveListener__);
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar3 = *(undefined4 *)(*(int *)(iVar2 + 0x48) + 0xb4);
		    uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		    Utils_ObjectUtils__IsNotNull
		              (uVar1,param1,
		               Method_Gameplay_WorldAxis_ClanEquipment_Controller_ClanEquipmentViewMediator_ExpellButtonClickedEventHandler__
		               ,0);
		    UnityEngine_Events_UnityAction___ctor(uVar3,uVar1,0);
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar3 = *(undefined4 *)(*(int *)(iVar2 + 0x44) + 0xb4);
		    uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		    Utils_ObjectUtils__IsNotNull
		              (uVar1,param1,
		               Method_Gameplay_WorldAxis_ClanEquipment_Controller_ClanEquipmentViewMediator_TakeOffAllButtonClickedEventHandler__
		               ,0);
		    UnityEngine_Events_UnityAction___ctor(uVar3,uVar1,0);
		    uVar1 = unnamed_function_1417(System_Action_ProtoUserLeftClanEvt__TypeInfo);
		    UnityEngine_UIElements_VisualElement__get_layout
		              (uVar1,param1,
		               Method_Gameplay_WorldAxis_ClanEquipment_Controller_ClanEquipmentViewMediator_ClansServiceOnUserLeftClanEvent__
		               ,0);
		    ServicesNamespace_ClansService__add_UserLeftClanEvent(param1_00,uVar1,0);
		  }
		  param1[5] = param2;
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar2 = Cysharp_Threading_Tasks_CancellationTokenExtensions___cctor(uVar1,0);
		  if (iVar2 != 0) {
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar3 = *(undefined4 *)(iVar2 + 0x4c);
		    uVar1 = unnamed_function_1417(System_Action_object__TypeInfo);
		    UnityEngine_UIElements_VisualElement__get_layout
		              (uVar1,param1,
		               Method_Gameplay_WorldAxis_ClanEquipment_Controller_ClanEquipmentViewMediator_FilterSelectedEventHandler__
		               ,0);
		    UI_Elements_Filters_GenericFilter_FilterWithIconListElement_FilterWithIconData___ctor
		              (uVar3,uVar1,0);
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar3 = *(undefined4 *)(iVar2 + 0x4c);
		    uVar1 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar1,param1,
		               Method_Gameplay_WorldAxis_ClanEquipment_Controller_ClanEquipmentViewMediator_FilterDeselectedEventHandler__
		               ,0);
		    UI_Elements_GenericList_SelectableListElementArgs___ctor(uVar3,uVar1,0);
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar3 = *(undefined4 *)(*(int *)(iVar2 + 0x50) + 0xc0);
		    uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_bool__TypeInfo);
		    UnityEngine_UI_Toggle__set_group
		              (uVar1,param1,
		               Method_Gameplay_WorldAxis_ClanEquipment_Controller_ClanEquipmentViewMediator_OnlyEquippedToggledEventHandler__
		               ,0);
		    UnityEngine_Events_UnityEvent_InputAction_CallbackContext____ctor
		              (uVar3,uVar1,Method_UnityEngine_Events_UnityEvent_bool__AddListener__);
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar3 = *(undefined4 *)(*(int *)(iVar2 + 0x48) + 0xb4);
		    uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		    Utils_ObjectUtils__IsNotNull
		              (uVar1,param1,
		               Method_Gameplay_WorldAxis_ClanEquipment_Controller_ClanEquipmentViewMediator_ExpellButtonClickedEventHandler__
		               ,0);
		    Gameplay_Boss_View_CaptainTab_BossInfoView__add_AttackButtonClickEvent(uVar3,uVar1,0);
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar3 = *(undefined4 *)(*(int *)(iVar2 + 0x44) + 0xb4);
		    uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		    Utils_ObjectUtils__IsNotNull
		              (uVar1,param1,
		               Method_Gameplay_WorldAxis_ClanEquipment_Controller_ClanEquipmentViewMediator_TakeOffAllButtonClickedEventHandler__
		               ,0);
		    Gameplay_Boss_View_CaptainTab_BossInfoView__add_AttackButtonClickEvent(uVar3,uVar1,0);
		    uVar1 = unnamed_function_1417(System_Action_ProtoUserLeftClanEvt__TypeInfo);
		    UnityEngine_UIElements_VisualElement__get_layout
		              (uVar1,param1,
		               Method_Gameplay_WorldAxis_ClanEquipment_Controller_ClanEquipmentViewMediator_ClansServiceOnUserLeftClanEvent__
		               ,0);
		    ServicesNamespace_ClansService__remove_TreasuryChangedEvent(param1_00,uVar1,0);
		    if (DAT_ram_00a58c4d == '\0') {
		      Mono_Security_ASN1__get_Item
		                (&
		                 Method_MVC_AbstractViewMediator_ClanEquipmentModel__ClanEquipmentEvents__ClanEquipmentController__ClanEquipmentWindow__get_Model__
		                );
		      DAT_ram_00a58c4d = '\x01';
		    }
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    piVar4 = *(int **)(iVar2 + 0x4c);
		    iVar5 = param1[2];
		    iVar2 = *(int *)(iVar5 + 0x30);
		    if (iVar2 == 0) {
		      iVar2 = Gameplay_WorldAxis_ClanEquipment_Model_ClanEquipmentModel__PopulateUsers(0,0);
		      *(int *)(iVar5 + 0x30) = iVar2;
		    }
		    iVar5 = *piVar4;
		    (**(code **)((ulonglong)*(uint *)(iVar5 + 0xe0) * 4))
		              (piVar4,iVar2,*(undefined4 *)(iVar5 + 0xe4));
		  }
		  return;
		}
		*/

			return default(bool);
		}

		// Token: 0x1700030B RID: 779
		// (set) Token: 0x0600136F RID: 4975 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700030B")]
		public override ClanEquipmentWindow View
		{
			[Token(Token = "0x600136F")]
			[Address(RVA = "0x655F", Offset = "0x655F", VA = "0x655F", Slot = "20")]
			set
			{
			}
		}

		// Token: 0x06001370 RID: 4976 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001370")]
		[Address(RVA = "0x6560", Offset = "0x6560", VA = "0x6560")]
		private void ClansServiceOnUserLeftClanEvent(ProtoUserLeftClanEvt evt)
		{
		/* --- GHIDRA: ClansServiceOnUserLeftClanEvent ---
		void Gameplay_WorldAxis_ClanEquipment_Controller_ClanEquipmentViewMediator__ClansServiceOnUserLeftClanEvent
		               (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  int *piVar2;
		  int iVar3;
		  
		  if (DAT_ram_00a58c4d == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_ClanEquipmentModel__ClanEquipmentEvents__ClanEquipmentController__ClanEquipmentWindow__get_Model__
		              );
		    DAT_ram_00a58c4d = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  piVar2 = *(int **)(iVar1 + 0x4c);
		  iVar3 = param1[2];
		  iVar1 = *(int *)(iVar3 + 0x30);
		  if (iVar1 == 0) {
		    iVar1 = Gameplay_WorldAxis_ClanEquipment_Model_ClanEquipmentModel__PopulateUsers(0,0);
		    *(int *)(iVar3 + 0x30) = iVar1;
		  }
		  iVar3 = *piVar2;
		  (**(code **)((ulonglong)*(uint *)(iVar3 + 0xe0) * 4))(piVar2,iVar1,*(undefined4 *)(iVar3 + 0xe4));
		  return;
		}
		*/

		}

		// Token: 0x06001371 RID: 4977 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001371")]
		[Address(RVA = "0x6561", Offset = "0x6561", VA = "0x6561")]
		private void Init()
		{
		/* --- GHIDRA: Init ---
		void Gameplay_WorldAxis_ClanEquipment_Controller_ClanEquipmentViewMediator__Init
		               (int param1,int param2,undefined4 param3)
		
		{
		  undefined4 param1_00;
		  undefined4 *puVar1;
		  
		  if (DAT_ram_00a58c4e == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_WorldAxis_ClanEquipment_Controller_ClanEquipmentViewMediator_DefaultListPredicate__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_WorldAxis_ClanEquipment_Controller_ClanEquipmentViewMediator__OnlyEquippedToggledEventHandler_b__10_0__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               System_Func_ClanMemberDollsListElement_ClanMemberDollsListElementArgs__bool__TypeInfo
		              );
		    DAT_ram_00a58c4e = '\x01';
		  }
		  param1_00 = unnamed_function_1417
		                        (
		                        System_Func_ClanMemberDollsListElement_ClanMemberDollsListElementArgs__bool__TypeInfo
		                        );
		  puVar1 = &
		           Method_Gameplay_WorldAxis_ClanEquipment_Controller_ClanEquipmentViewMediator__OnlyEquippedToggledEventHandler_b__10_0__
		  ;
		  if (param2 == 0) {
		    puVar1 = &
		             Method_Gameplay_WorldAxis_ClanEquipment_Controller_ClanEquipmentViewMediator_DefaultListPredicate__
		    ;
		  }
		  System_Collections_Generic_Dictionary_uint__object___GetEnumerator(param1_00,param1,*puVar1,0);
		  *(undefined4 *)(param1 + 0x20) = param1_00;
		  Gameplay_WorldAxis_ClanEquipment_Controller_ClanEquipmentViewMediator__DollArtifactsRequestedEventHandler
		            (param1,param1);
		  return;
		}
		*/

		}

		// Token: 0x06001372 RID: 4978 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001372")]
		[Address(RVA = "0x6562", Offset = "0x6562", VA = "0x6562")]
		private void OnlyEquippedToggledEventHandler(bool enabled)
		{
		/* --- GHIDRA: OnlyEquippedToggledEventHandler ---
		void Gameplay_WorldAxis_ClanEquipment_Controller_ClanEquipmentViewMediator__OnlyEquippedToggledEventHandler
		               (int param1,undefined4 param2)
		
		{
		  *(undefined4 *)(param1 + 0x1c) = 0;
		  Gameplay_WorldAxis_ClanEquipment_Controller_ClanEquipmentViewMediator__Select(param1,param1);
		  return;
		}
		*/

		}

		// Token: 0x06001373 RID: 4979 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001373")]
		[Address(RVA = "0x6563", Offset = "0x6563", VA = "0x6563")]
		private void FilterDeselectedEventHandler()
		{
		/* --- GHIDRA: FilterDeselectedEventHandler ---
		void Gameplay_WorldAxis_ClanEquipment_Controller_ClanEquipmentViewMediator__FilterDeselectedEventHandler
		               (int param1,int *param2,undefined4 param3)
		
		{
		  if (DAT_ram_00a58c4f == '\0') {
		    Mono_Security_ASN1__get_Item(&Protocol_Dic_DollsInfoDic_TypeInfo);
		    DAT_ram_00a58c4f = '\x01';
		  }
		  if ((param2 != (int *)0x0) && (Protocol_Dic_DollsInfoDic_TypeInfo != *param2)) {
		    System_Activator__CreateInstance(param2,Protocol_Dic_DollsInfoDic_TypeInfo);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  *(int **)(param1 + 0x1c) = param2;
		  Gameplay_WorldAxis_ClanEquipment_Controller_ClanEquipmentViewMediator__Select(param1,param2);
		  return;
		}
		*/

		}

		// Token: 0x06001374 RID: 4980 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001374")]
		[Address(RVA = "0x6564", Offset = "0x6564", VA = "0x6564")]
		private void FilterSelectedEventHandler(object obj)
		{
		/* --- GHIDRA: FilterSelectedEventHandler ---
		void Gameplay_WorldAxis_ClanEquipment_Controller_ClanEquipmentViewMediator__FilterSelectedEventHandler
		               (int *param1,undefined4 param2)
		
		{
		  undefined4 in_register_20000014;
		  int iVar1;
		  undefined4 uVar2;
		  int iVar3;
		  undefined4 uVar4;
		  longlong lVar5;
		  longlong lVar6;
		  undefined8 uVar7;
		  int param1_00;
		  
		  if (DAT_ram_00a58c50 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_ClanEquipmentModel__ClanEquipmentEvents__ClanEquipmentController__ClanEquipmentWindow__get_Model__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_ulong__ClanEquipmentModel_DollArtifacts__get_Item__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_ulong__ClanEquipmentModel_DollArtifacts__get_Keys__
		              );
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_ToArray_ulong___);
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item(&ulong___TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_9094);
		    Mono_Security_ASN1__get_Item(&StringLiteral_17772);
		    Mono_Security_ASN1__get_Item(&StringLiteral_17773);
		    DAT_ram_00a58c50 = '\x01';
		  }
		  param1_00 = *(int *)(param1[6] + 0x1c);
		  iVar1 = Core_Data_UserData__get_ClanId(*(undefined4 *)(param1[2] + 8),0);
		  if (iVar1 == 0) {
		    lVar5 = System_Collections_Generic_LinkedList_Enumerator_object___MoveNext
		                      (*(undefined4 *)(param1[2] + 8),0);
		    lVar6 = System_Collections_Generic_LinkedList_Enumerator_object___MoveNext
		                      (*(undefined4 *)(param1_00 + 8),0);
		    if (lVar5 != lVar6) {
		      if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		        func_ii_306000(Core_GameLocalization_TypeInfo);
		      }
		      uVar2 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_9094,1,0,1,0,0,0,0);
		      uVar4 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_17772,1,0,1,0,0,0,0);
		      UI_Windows_DialogWindow__Show(uVar2,uVar4,0);
		      return;
		    }
		  }
		  if (param1[7] == 0) {
		    uVar2 = System_Collections_Generic_Dictionary_TypeConverterRegistry_ConverterKey__object___System_Collections_Generic_ICollection_System_Collections_Generic_KeyValuePair_TKey_TValue___get_IsReadOnly
		                      (*(undefined4 *)(param1_00 + 0xc),
		                       Method_System_Collections_Generic_Dictionary_ulong__ClanEquipmentModel_DollArtifacts__get_Keys__
		                      );
		    iVar1 = System_Linq_Enumerable__ToArray_PlayerLoopSystem_
		                      (uVar2,Method_System_Linq_Enumerable_ToArray_ulong___);
		    iVar3 = Gameplay_WorldAxis_ClanEquipment_Model_ClanEquipmentModel___CreateFilters_g__ConstructData_17_0
		                      (param1_00,param1);
		  }
		  else {
		    uVar7 = *(undefined8 *)(*(int *)(param1[7] + 0xc) + 0x10);
		    iVar1 = Mono_Security_ASN1Convert__ToOid(ulong___TypeInfo,1);
		    *(undefined8 *)(iVar1 + 0x10) = uVar7;
		    iVar3 = System_Collections_Generic_Dictionary_ulong__object___get_Comparer
		                      (*(undefined4 *)(param1_00 + 0xc),uVar7,
		                       Method_System_Collections_Generic_Dictionary_ulong__ClanEquipmentModel_DollArtifacts__get_Item__
		                      );
		    in_register_20000014 = (undefined4)((ulonglong)uVar7 >> 0x20);
		    iVar3 = *(int *)(iVar3 + 0xc);
		  }
		  if (*(int *)(iVar3 + 0xc) == 0) {
		    if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_GameLocalization_TypeInfo);
		    }
		    uVar2 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_9094,1,0,1,0,0,0,0);
		    uVar4 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_17773,1,0,1,0,0,0,0);
		    UI_Windows_DialogWindow__Show(uVar2,uVar4,0);
		    return;
		  }
		  uVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                    (param1,CONCAT44(in_register_20000014,*(undefined4 *)(*param1 + 0x14c)));
		  uVar7 = System_Collections_Generic_LinkedList_Enumerator_object___MoveNext
		                    (*(undefined4 *)(param1_00 + 8),0);
		  Gameplay_WorldAxis_ClanEquipment_Controller_ClanEquipmentController__UsersRequestedEventHandler
		            (uVar2,uVar7,iVar1,param1);
		  return;
		}
		*/

		}

		// Token: 0x06001375 RID: 4981 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001375")]
		[Address(RVA = "0x6565", Offset = "0x6565", VA = "0x6565")]
		private void TakeOffAllButtonClickedEventHandler()
		{
		/* --- GHIDRA: TakeOffAllButtonClickedEventHandler ---
		void Gameplay_WorldAxis_ClanEquipment_Controller_ClanEquipmentViewMediator__TakeOffAllButtonClickedEventHandler
		               (int param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 param2_00;
		  uint *puVar2;
		  undefined4 uVar3;
		  int *param1_00;
		  uint uVar4;
		  
		  uVar4 = 0;
		  if (DAT_ram_00a58c51 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_9094);
		    Mono_Security_ASN1__get_Item(&StringLiteral_17771);
		    DAT_ram_00a58c51 = '\x01';
		  }
		  iVar1 = Gameplay_WorldAxis_ClanEquipment_Model_ClanEquipmentModel___CreateFilters_g__ConstructData_17_0
		                    (*(undefined4 *)(*(int *)(param1 + 0x18) + 0x1c),0);
		  if (*(int *)(iVar1 + 0xc) != 0) {
		    if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_GameLocalization_TypeInfo);
		    }
		    uVar3 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_9094,1,0,1,0,0,0,0);
		    param2_00 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_17771,1,0,1,0,0,0,0);
		    UI_Windows_DialogWindow__Show(uVar3,param2_00,0);
		    return;
		  }
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  param1_00 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar1 = *param1_00;
		  if (*(ushort *)(iVar1 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar1 + 0x58) + uVar4 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar1 + 0x58) + uVar4 * 8 + 4) * 8 + iVar1 + 0x230);
		        goto code_r0x80f8fe68;
		      }
		      uVar4 = uVar4 + 1;
		    } while (*(ushort *)(iVar1 + 0xb6) != uVar4);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_00,Core_Gameplay_IGame_TypeInfo,0x2e);
		code_r0x80f8fe68:
		  uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(param1_00,puVar2[1]);
		  Core_Gameplay_Managers_ClansManager__ShowClanInfoPopupWindow
		            (uVar3,*(undefined4 *)(*(int *)(*(int *)(param1 + 0x18) + 0x1c) + 8),0);
		  return;
		}
		*/

		}

		// Token: 0x06001376 RID: 4982 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001376")]
		[Address(RVA = "0x6566", Offset = "0x6566", VA = "0x6566")]
		private void ExpellButtonClickedEventHandler()
		{
		/* --- GHIDRA: ExpellButtonClickedEventHandler ---
		void Gameplay_WorldAxis_ClanEquipment_Controller_ClanEquipmentViewMediator__ExpellButtonClickedEventHandler
		               (int *param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  int iVar2;
		  undefined4 uVar3;
		  int *piVar4;
		  undefined4 uVar5;
		  
		  if (DAT_ram_00a58c52 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_ClanEquipmentModel__ClanEquipmentEvents__ClanEquipmentController__ClanEquipmentWindow__set_Events__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_WorldAxis_ClanEquipment_Controller_ClanEquipmentViewMediator_DataChangedEventHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_WorldAxis_ClanEquipment_Controller_ClanEquipmentViewMediator_DollArtifactsRequestedEventHandler__
		              );
		    DAT_ram_00a58c52 = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x13c));
		  if (iVar1 != 0) {
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar5 = *(undefined4 *)(iVar2 + 0x14);
		    uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar3,param1,
		               Method_Gameplay_WorldAxis_ClanEquipment_Controller_ClanEquipmentViewMediator_DollArtifactsRequestedEventHandler__
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
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar5 = *(undefined4 *)(iVar2 + 0x18);
		    uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar3,param1,
		               Method_Gameplay_WorldAxis_ClanEquipment_Controller_ClanEquipmentViewMediator_DataChangedEventHandler__
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
		  }
		  param1[3] = param2;
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x13c));
		  if (iVar1 != 0) {
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar5 = *(undefined4 *)(iVar2 + 0x14);
		    uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar3,param1,
		               Method_Gameplay_WorldAxis_ClanEquipment_Controller_ClanEquipmentViewMediator_DollArtifactsRequestedEventHandler__
		               ,0);
		    piVar4 = (int *)UnityEngine_UI_Image__set_sprite(uVar5,uVar3,0);
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
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar5 = *(undefined4 *)(iVar2 + 0x18);
		    uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar3,param1,
		               Method_Gameplay_WorldAxis_ClanEquipment_Controller_ClanEquipmentViewMediator_DataChangedEventHandler__
		               ,0);
		    piVar4 = (int *)UnityEngine_UI_Image__set_sprite(uVar5,uVar3,0);
		    iVar1 = System_Action_TypeInfo;
		    if (piVar4 == (int *)0x0) {
		      *(undefined4 *)(iVar2 + 0x18) = 0;
		      return;
		    }
		    if ((System_Action_TypeInfo != *piVar4) || (*(int **)(iVar2 + 0x18) = piVar4, *piVar4 != iVar1))
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

		// Token: 0x1700030C RID: 780
		// (set) Token: 0x06001377 RID: 4983 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700030C")]
		public override ClanEquipmentEvents Events
		{
			[Token(Token = "0x6001377")]
			[Address(RVA = "0x6567", Offset = "0x6567", VA = "0x6567", Slot = "16")]
			set
			{
			}
		}

		// Token: 0x06001378 RID: 4984 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001378")]
		[Address(RVA = "0x6568", Offset = "0x6568", VA = "0x6568")]
		private void DataChangedEventHandler()
		{
		/* --- GHIDRA: DataChangedEventHandler ---
		void Gameplay_WorldAxis_ClanEquipment_Controller_ClanEquipmentViewMediator__DataChangedEventHandler
		               (undefined4 param1,undefined4 param2)
		
		{
		  Gameplay_WorldAxis_ClanEquipment_Controller_ClanEquipmentViewMediator__DollArtifactsRequestedEventHandler
		            (param1,param1);
		  return;
		}
		*/

		}

		// Token: 0x06001379 RID: 4985 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001379")]
		[Address(RVA = "0x6569", Offset = "0x6569", VA = "0x6569")]
		private void DollArtifactsRequestedEventHandler()
		{
		/* --- GHIDRA: DollArtifactsRequestedEventHandler ---
		void Gameplay_WorldAxis_ClanEquipment_Controller_ClanEquipmentViewMediator__DollArtifactsRequestedEventHandler
		               (int *param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  int param2_00;
		  int param1_00;
		  undefined4 param1_01;
		  
		  if (DAT_ram_00a58c53 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_ClanEquipmentModel__ClanEquipmentEvents__ClanEquipmentController__ClanEquipmentWindow__get_Model__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_WorldAxis_ClanEquipment_Controller_ClanEquipmentViewMediator_ConstructArgs__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_WorldAxis_ClanEquipment_Controller_ClanEquipmentViewMediator__RenderList_b__19_0__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Linq_Enumerable_FirstOrDefault_ClanMemberDollsListElement_ClanMemberDollsListElementArgs___
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Linq_Enumerable_Select_ClanEquipmentModel_DollsOwner__ClanMemberDollsListElement_ClanMemberDollsListElementArgs___
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Linq_Enumerable_ToArray_ClanMemberDollsListElement_ClanMemberDollsListElementArgs___
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Linq_Enumerable_Where_ClanMemberDollsListElement_ClanMemberDollsListElementArgs___
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               System_Func_ClanEquipmentModel_DollsOwner__ClanMemberDollsListElement_ClanMemberDollsListElementArgs__TypeInfo
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               System_Func_ClanMemberDollsListElement_ClanMemberDollsListElementArgs__bool__TypeInfo
		              );
		    DAT_ram_00a58c53 = '\x01';
		  }
		  param1_01 = *(undefined4 *)(param1[2] + 0x34);
		  uVar1 = unnamed_function_1417
		                    (
		                    System_Func_ClanEquipmentModel_DollsOwner__ClanMemberDollsListElement_ClanMemberDollsListElementArgs__TypeInfo
		                    );
		  System_Linq_Enumerable__Where_object_
		            (uVar1,param1,
		             Method_Gameplay_WorldAxis_ClanEquipment_Controller_ClanEquipmentViewMediator_ConstructArgs__
		             ,0);
		  uVar1 = System_Linq_Enumerable__ReverseIterator___Il2CppFullySharedGenericType_
		                    (param1_01,uVar1,
		                     Method_System_Linq_Enumerable_Select_ClanEquipmentModel_DollsOwner__ClanMemberDollsListElement_ClanMemberDollsListElementArgs___
		                    );
		  uVar1 = System_Linq_Enumerable__Where_PlayerLoopSystem_
		                    (uVar1,param1[8],
		                     Method_System_Linq_Enumerable_Where_ClanMemberDollsListElement_ClanMemberDollsListElementArgs___
		                    );
		  param2_00 = func_ii_6295(uVar1,
		                           Method_System_Linq_Enumerable_ToArray_ClanMemberDollsListElement_ClanMemberDollsListElementArgs___
		                          );
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  Gameplay_WorldAxis_ClanEquipment_View_ClanEquipmentWindow__OnClose(uVar1,param2_00,param1);
		  if (*(int *)(param2_00 + 0xc) != 0) {
		    uVar1 = unnamed_function_1417
		                      (
		                      System_Func_ClanMemberDollsListElement_ClanMemberDollsListElementArgs__bool__TypeInfo
		                      );
		    System_Collections_Generic_Dictionary_uint__object___GetEnumerator
		              (uVar1,param1,
		               Method_Gameplay_WorldAxis_ClanEquipment_Controller_ClanEquipmentViewMediator__RenderList_b__19_0__
		               ,0);
		    param1_00 = System_Func_object__bool____ctor
		                          (param2_00,uVar1,
		                           Method_System_Linq_Enumerable_FirstOrDefault_ClanMemberDollsListElement_ClanMemberDollsListElementArgs___
		                          );
		    if (param1_00 == 0) {
		      param1_00 = *(int *)(param2_00 + 0x10);
		    }
		    param1[6] = param1_00;
		    Gameplay_Clans_Office_View_ClanMembersTab_ClanMemberListElement_ClanMemberListElementArgs__get_Selected
		              (param1_00,1,0);
		    Gameplay_WorldAxis_ClanEquipment_Controller_ClanEquipmentViewMediator__Select(param1,param1);
		  }
		  return;
		}
		*/

		}

		// Token: 0x0600137A RID: 4986 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600137A")]
		[Address(RVA = "0x656A", Offset = "0x656A", VA = "0x656A")]
		private void RenderList()
		{
		/* --- GHIDRA: RenderList ---
		int Gameplay_WorldAxis_ClanEquipment_Controller_ClanEquipmentViewMediator__RenderList
		              (undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  int param1_00;
		  undefined4 param1_01;
		  
		  if (DAT_ram_00a58c54 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ClanMemberDollsListElement__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_WorldAxis_ClanEquipment_Controller_ClanEquipmentViewMediator_ListElementClickedEventHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Gameplay_WorldAxis_ClanEquipment_View_ClanMemberDollsListElement_ClanMemberDollsListElementArgs_TypeInfo
		              );
		    DAT_ram_00a58c54 = '\x01';
		  }
		  param1_00 = unnamed_function_1417
		                        (
		                        Gameplay_WorldAxis_ClanEquipment_View_ClanMemberDollsListElement_ClanMemberDollsListElementArgs_TypeInfo
		                        );
		  if (DAT_ram_00a58c32 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Elements_GenericList_SelectableListElementArgs_ClanMemberDollsListElement___ctor__
		              );
		    DAT_ram_00a58c32 = '\x01';
		  }
		  UnityEngine_InputSystem_LowLevel_SelectObservable___Il2CppFullySharedGenericType____Il2CppFullySharedGenericType___Subscribe
		            (param1_00,
		             Method_UI_Elements_GenericList_SelectableListElementArgs_ClanMemberDollsListElement___ctor__
		            );
		  *(undefined4 *)(param1_00 + 0x1c) = param2;
		  param1_01 = unnamed_function_1417(System_Action_ClanMemberDollsListElement__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (param1_01,param1,
		             Method_Gameplay_WorldAxis_ClanEquipment_Controller_ClanEquipmentViewMediator_ListElementClickedEventHandler__
		             ,0);
		  *(undefined4 *)(param1_00 + 0x18) = param1_01;
		  return param1_00;
		}
		*/

		}

		// Token: 0x0600137B RID: 4987 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600137B")]
		[Address(RVA = "0x656B", Offset = "0x656B", VA = "0x656B")]
		private ClanMemberDollsListElement.ClanMemberDollsListElementArgs ConstructArgs(ClanEquipmentModel.DollsOwner dollOwner)
		{
		/* --- GHIDRA: ConstructArgs ---
		void Gameplay_WorldAxis_ClanEquipment_Controller_ClanEquipmentViewMediator__ConstructArgs
		               (int param1,int param2,undefined4 param3)
		
		{
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a58c55 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Elements_GenericList_GenericListElement_ClanMemberDollsListElement_ClanMemberDollsListElementArgs__get_args__
		              );
		    DAT_ram_00a58c55 = '\x01';
		  }
		  Gameplay_Clans_Office_View_ClanMembersTab_ClanMemberListElement_ClanMemberListElementArgs__get_Selected
		            (*(undefined4 *)(param1 + 0x18),0,0);
		  param1_00 = *(undefined4 *)(param2 + 0x18);
		  *(undefined4 *)(param1 + 0x18) = param1_00;
		  Gameplay_Clans_Office_View_ClanMembersTab_ClanMemberListElement_ClanMemberListElementArgs__get_Selected
		            (param1_00,1,0);
		  Gameplay_WorldAxis_ClanEquipment_Controller_ClanEquipmentViewMediator__Select(param1,param1);
		  return;
		}
		*/

			return null;
		}

		// Token: 0x0600137C RID: 4988 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600137C")]
		[Address(RVA = "0x656C", Offset = "0x656C", VA = "0x656C")]
		private void ListElementClickedEventHandler(ClanMemberDollsListElement element)
		{
		/* --- GHIDRA: ListElementClickedEventHandler ---
		void Gameplay_WorldAxis_ClanEquipment_Controller_ClanEquipmentViewMediator__ListElementClickedEventHandler
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  *(undefined4 *)(param1 + 0x18) = param2;
		  Gameplay_Clans_Office_View_ClanMembersTab_ClanMemberListElement_ClanMemberListElementArgs__get_Selected
		            (param2,1,0);
		  Gameplay_WorldAxis_ClanEquipment_Controller_ClanEquipmentViewMediator__Select(param1,param2);
		  return;
		}
		*/

		}

		// Token: 0x0600137D RID: 4989 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600137D")]
		[Address(RVA = "0x656D", Offset = "0x656D", VA = "0x656D")]
		private void Select(ClanMemberDollsListElement.ClanMemberDollsListElementArgs args)
		{
		/* --- GHIDRA: Select ---
		void Gameplay_WorldAxis_ClanEquipment_Controller_ClanEquipmentViewMediator__Select
		               (int *param1,undefined4 param2)
		
		{
		  undefined4 in_register_20000014;
		  undefined4 uVar1;
		  int iVar2;
		  longlong lVar3;
		  longlong lVar4;
		  int iVar5;
		  int iVar6;
		  undefined4 uVar7;
		  undefined4 param2_00;
		  uint param2_01;
		  undefined8 uVar8;
		  
		  if (DAT_ram_00a58c56 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_ClanEquipmentModel__ClanEquipmentEvents__ClanEquipmentController__ClanEquipmentWindow__get_Model__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_ulong__ClanEquipmentModel_DollArtifacts__get_Item__
		              );
		    DAT_ram_00a58c56 = '\x01';
		  }
		  iVar5 = param1[7];
		  iVar6 = param1[6];
		  uVar8 = CONCAT44(in_register_20000014,*(undefined4 *)(*param1 + 0x15c));
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))(param1,uVar8);
		  uVar7 = *(undefined4 *)(iVar2 + 0x40);
		  iVar2 = *(int *)(iVar6 + 0x1c);
		  if (iVar5 == 0) {
		    uVar1 = (undefined4)((ulonglong)uVar8 >> 0x20);
		    param2_00 = Gameplay_WorldAxis_ClanEquipment_Model_ClanEquipmentModel___CreateFilters_g__ConstructData_17_0
		                          (iVar2,param1);
		  }
		  else {
		    uVar8 = *(undefined8 *)(*(int *)(param1[7] + 0xc) + 0x10);
		    iVar2 = System_Collections_Generic_Dictionary_ulong__object___get_Comparer
		                      (*(undefined4 *)(iVar2 + 0xc),uVar8,
		                       Method_System_Collections_Generic_Dictionary_ulong__ClanEquipmentModel_DollArtifacts__get_Item__
		                      );
		    uVar1 = (undefined4)((ulonglong)uVar8 >> 0x20);
		    param2_00 = *(undefined4 *)(iVar2 + 0xc);
		  }
		  Gameplay_WorldAxis_ClanEquipment_View_ClanMemberDollsOSAView_ClansMembersViewsHolder___ctor
		            (uVar7,param2_00,*(undefined4 *)(*(int *)(iVar6 + 0x1c) + 8),param1);
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,CONCAT44(uVar1,*(undefined4 *)(*param1 + 0x15c)));
		  uVar7 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (*(undefined4 *)(iVar2 + 0x48),0);
		  iVar2 = Core_Data_UserData__get_ClanId(*(undefined4 *)(param1[2] + 8),0);
		  if (iVar2 == 0) {
		    param2_01 = 0;
		  }
		  else {
		    lVar3 = System_Collections_Generic_LinkedList_Enumerator_object___MoveNext
		                      (*(undefined4 *)(*(int *)(param1[6] + 0x1c) + 8),0);
		    lVar4 = System_Collections_Generic_LinkedList_Enumerator_object___MoveNext
		                      (*(undefined4 *)(param1[2] + 8),0);
		    param2_01 = (uint)(lVar3 != lVar4);
		  }
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar7,param2_01,0);
		  return;
		}
		*/

		}

		// Token: 0x0600137E RID: 4990 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600137E")]
		[Address(RVA = "0x656E", Offset = "0x656E", VA = "0x656E")]
		private void RenderArtifacts()
		{
		/* --- GHIDRA: RenderArtifacts ---
		uint Gameplay_WorldAxis_ClanEquipment_Controller_ClanEquipmentViewMediator__RenderArtifacts
		               (int param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined8 param2_00;
		  undefined4 param1_00;
		  uint uVar2;
		  
		  if (DAT_ram_00a58c4a == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_HashSet_ulong__Contains__);
		    DAT_ram_00a58c4a = '\x01';
		  }
		  param1_00 = *(undefined4 *)(param1 + 0x24);
		  param2_00 = System_Collections_Generic_LinkedList_Enumerator_object___MoveNext
		                        (*(undefined4 *)(*(int *)(param2 + 0x1c) + 8),0);
		  iVar1 = System_Collections_Generic_HashSet_ulong___Clear
		                    (param1_00,param2_00,Method_System_Collections_Generic_HashSet_ulong__Contains__
		                    );
		  if (iVar1 == 0) {
		    iVar1 = Gameplay_WorldAxis_ClanEquipment_Model_ClanEquipmentModel___CreateFilters_g__ConstructData_17_0
		                      (*(undefined4 *)(param2 + 0x1c),param2);
		    uVar2 = (uint)(*(int *)(iVar1 + 0xc) != 0);
		  }
		  else {
		    uVar2 = 0;
		  }
		  return uVar2;
		}
		*/

		}

		// Token: 0x04000A71 RID: 2673
		[Token(Token = "0x4000A71")]
		[FieldOffset(Offset = "0x18")]
		private ClanMemberDollsListElement.ClanMemberDollsListElementArgs _selectedArgs;

		// Token: 0x04000A72 RID: 2674
		[Token(Token = "0x4000A72")]
		[FieldOffset(Offset = "0x1C")]
		private DollsInfoDic _selectedFilter;

		// Token: 0x04000A73 RID: 2675
		[Token(Token = "0x4000A73")]
		[FieldOffset(Offset = "0x20")]
		private Func<ClanMemberDollsListElement.ClanMemberDollsListElementArgs, bool> _predicate;

		// Token: 0x04000A74 RID: 2676
		[Token(Token = "0x4000A74")]
		[FieldOffset(Offset = "0x24")]
		private readonly HashSet<ulong> _removedUsers;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_View ---
		void Gameplay_WorldAxis_ClanEquipment_Controller_ClanEquipmentViewMediator__set_View
		               (int param1,int param2,undefined4 param3)
		
		{
		  if (DAT_ram_00a58c4c == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_HashSet_ulong__Add__);
		    DAT_ram_00a58c4c = '\x01';
		  }
		  func_ii_6873(*(undefined4 *)(param1 + 0x24),*(undefined8 *)(param2 + 0x10),
		               Method_System_Collections_Generic_HashSet_ulong__Add__);
		  Gameplay_WorldAxis_ClanEquipment_Controller_ClanEquipmentViewMediator__DollArtifactsRequestedEventHandler
		            (param1,param1);
		  return;
		}
		*/


		/* --- GHIDRA: set_Events ---
		void Gameplay_WorldAxis_ClanEquipment_Controller_ClanEquipmentViewMediator__set_Events
		               (undefined4 param1,undefined4 param2)
		
		{
		  Gameplay_WorldAxis_ClanEquipment_Controller_ClanEquipmentViewMediator__Select(param1,param1);
		  return;
		}
		*/

}
