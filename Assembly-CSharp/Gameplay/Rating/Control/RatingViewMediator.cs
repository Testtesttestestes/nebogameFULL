using System;
using System.Collections.Generic;
using Core.MVC.Interfaces;
using Gameplay.Rating.Events;
using Gameplay.Rating.Model;
using Gameplay.Rating.View;
using Il2CppDummyDll;
using MVC;
using Protocol.Dic;

namespace Gameplay.Rating.Control
{
	// Token: 0x0200059C RID: 1436
	[Token(Token = "0x200059C")]
	public class RatingViewMediator : AbstractViewMediator<RatingModel, RatingEvents, RatingController, RatingWindow>
	{
		// Token: 0x0600226A RID: 8810 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600226A")]
		[Address(RVA = "0x73C1", Offset = "0x73C1", VA = "0x73C1", Slot = "14")]
		public override void Dispose()
		{
		/* --- GHIDRA: <Init>b__9_0 ---
		undefined4 Gameplay_Rating_Control_RatingViewMediator___Init_b__9_0(int *param1,undefined4 param2)
		
		{
		  undefined4 param2_00;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a580a2 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_RatingRequestDto__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Rating_Control_RatingController_RequestUsersRating__);
		    DAT_ram_00a580a2 = '\x01';
		  }
		  param2_00 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x14c));
		  param1_00 = unnamed_function_1417(System_Action_RatingRequestDto__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (param1_00,param2_00,
		             Method_Gameplay_Rating_Control_RatingController_RequestUsersRating__,0);
		  return param1_00;
		}
		*/

		/* --- GHIDRA: Dispose ---
		void Gameplay_Rating_Control_RatingViewMediator__Dispose
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4,undefined4 param5)
		
		{
		  undefined4 param1_00;
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a58098 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_RatingModel__RatingEvents__RatingController__RatingWindow___ctor__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_RatingKindTypeDic_Types_RatingKindType__Func_RatingKindTypeDic_Types_RatingKindType__uint__BaseRatingViewMediator___Add__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_RatingKindTypeDic_Types_RatingKindType__Func_RatingKindTypeDic_Types_RatingKindType__uint__BaseRatingViewMediator____ctor__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               System_Collections_Generic_Dictionary_RatingKindTypeDic_Types_RatingKindType__Func_RatingKindTypeDic_Types_RatingKindType__uint__BaseRatingViewMediator___TypeInfo
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               System_Func_RatingKindTypeDic_Types_RatingKindType__uint__BaseRatingViewMediator__TypeInfo
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Rating_Control_RatingViewMediator_SelectClanRatings__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Rating_Control_RatingViewMediator_SelectCultRatings__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Rating_Control_RatingViewMediator_SelectUserRatings__);
		    DAT_ram_00a58098 = '\x01';
		  }
		  Gameplay_Combat_TeamCombat_View_AbstractTeamCombatView_object___get_HideInstantElements
		            (param1,param2,param3,param4,
		             Method_MVC_AbstractViewMediator_RatingModel__RatingEvents__RatingController__RatingWindow___ctor__
		            );
		  param1_00 = unnamed_function_1417
		                        (
		                        System_Collections_Generic_Dictionary_RatingKindTypeDic_Types_RatingKindType__Func_RatingKindTypeDic_Types_RatingKindType__uint__BaseRatingViewMediator___TypeInfo
		                        );
		  System_Collections_Generic_Dictionary_Int32Enum__Int32Enum___set_Item
		            (param1_00,
		             Method_System_Collections_Generic_Dictionary_RatingKindTypeDic_Types_RatingKindType__Func_RatingKindTypeDic_Types_RatingKindType__uint__BaseRatingViewMediator____ctor__
		            );
		  uVar1 = unnamed_function_1417
		                    (
		                    System_Func_RatingKindTypeDic_Types_RatingKindType__uint__BaseRatingViewMediator__TypeInfo
		                    );
		  System_Func_Int32Enum__object__bool___Invoke
		            (uVar1,param1,Method_Gameplay_Rating_Control_RatingViewMediator_SelectUserRatings__,0);
		  func_ii_10812(param1_00,1,uVar1,
		                Method_System_Collections_Generic_Dictionary_RatingKindTypeDic_Types_RatingKindType__Func_RatingKindTypeDic_Types_RatingKindType__uint__BaseRatingViewMediator___Add__
		               );
		  uVar1 = unnamed_function_1417
		                    (
		                    System_Func_RatingKindTypeDic_Types_RatingKindType__uint__BaseRatingViewMediator__TypeInfo
		                    );
		  System_Func_Int32Enum__object__bool___Invoke
		            (uVar1,param1,Method_Gameplay_Rating_Control_RatingViewMediator_SelectClanRatings__,0);
		  func_ii_10812(param1_00,2,uVar1,
		                Method_System_Collections_Generic_Dictionary_RatingKindTypeDic_Types_RatingKindType__Func_RatingKindTypeDic_Types_RatingKindType__uint__BaseRatingViewMediator___Add__
		               );
		  uVar1 = unnamed_function_1417
		                    (
		                    System_Func_RatingKindTypeDic_Types_RatingKindType__uint__BaseRatingViewMediator__TypeInfo
		                    );
		  System_Func_Int32Enum__object__bool___Invoke
		            (uVar1,param1,Method_Gameplay_Rating_Control_RatingViewMediator_SelectCultRatings__,0);
		  func_ii_10812(param1_00,3,uVar1,
		                Method_System_Collections_Generic_Dictionary_RatingKindTypeDic_Types_RatingKindType__Func_RatingKindTypeDic_Types_RatingKindType__uint__BaseRatingViewMediator___Add__
		               );
		  *(undefined4 *)(param1 + 0x28) = param1_00;
		  return;
		}
		*/

		}

		// Token: 0x0600226B RID: 8811 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600226B")]
		[Address(RVA = "0x73C2", Offset = "0x73C2", VA = "0x73C2")]
		public RatingViewMediator(RatingModel model, RatingEvents events, RatingController controller)
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Competition_Control_Sections_RatingViewMediator___ctor
		               (undefined4 param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  int iVar3;
		  int *param1_00;
		  int iVar4;
		  undefined4 uVar5;
		  
		  if (DAT_ram_00a63afe == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_ChangedFromTo_OwnerRating__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Competition_Control_Sections_RatingViewMediator_HandleOwnerRatingChangedEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Competition_Control_Sections_RatingViewMediator_HandleRatingChangedEvent__
		              );
		    DAT_ram_00a63afe = '\x01';
		  }
		  iVar4 = *(int *)(param2 + 0x14);
		  uVar5 = *(undefined4 *)(iVar4 + 0x18);
		  uVar1 = unnamed_function_1417(Core_ChangedFromTo_OwnerRating__TypeInfo);
		  UnityEngine_UIElements_ChangeEvent___Il2CppFullySharedGenericType___set_previousValue
		            (uVar1,param1,
		             Method_Gameplay_Competition_Control_Sections_RatingViewMediator_HandleOwnerRatingChangedEvent__
		             ,0);
		  iVar2 = func_ii_7048(uVar5,uVar1,0);
		  uVar1 = Core_ChangedFromTo_OwnerRating__TypeInfo;
		  if (iVar2 == 0) {
		    *(undefined4 *)(iVar4 + 0x18) = 0;
		  }
		  else {
		    iVar3 = func_ii_1082(iVar2,Core_ChangedFromTo_OwnerRating__TypeInfo);
		    if (iVar3 == 0) {
		      System_Activator__CreateInstance(iVar2,uVar1);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    *(int *)(iVar4 + 0x18) = iVar3;
		    uVar1 = Core_ChangedFromTo_OwnerRating__TypeInfo;
		    iVar4 = func_ii_1082(iVar2,Core_ChangedFromTo_OwnerRating__TypeInfo);
		    if (iVar4 == 0) {
		      System_Activator__CreateInstance(iVar2,uVar1);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  iVar4 = *(int *)(param2 + 0x14);
		  uVar5 = *(undefined4 *)(iVar4 + 0x1c);
		  uVar1 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar1,param1,
		             Method_Gameplay_Competition_Control_Sections_RatingViewMediator_HandleRatingChangedEvent__
		             ,0);
		  param1_00 = (int *)func_ii_7048(uVar5,uVar1,0);
		  iVar2 = System_Action_TypeInfo;
		  if (param1_00 == (int *)0x0) {
		    *(undefined4 *)(iVar4 + 0x1c) = 0;
		    return;
		  }
		  if ((System_Action_TypeInfo == *param1_00) &&
		     (*(int **)(iVar4 + 0x1c) = param1_00, *param1_00 == iVar2)) {
		    return;
		  }
		  System_Activator__CreateInstance(param1_00,iVar2);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		/* --- GHIDRA: .ctor ---
		void Gameplay_Rating_Control_RatingViewMediator___ctor(int *param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  undefined4 uVar3;
		  
		  if (DAT_ram_00a58099 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_RatingModel__RatingEvents__RatingController__RatingWindow__set_View__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Rating_Control_RatingViewMediator_ExtraFilterToggleChangedEventHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Rating_Control_RatingViewMediator_PeriodFilterToggleChangedEventHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Rating_Control_RatingViewMediator_TabChangedEventHandler__);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Events_UnityAction_bool__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Events_UnityEvent_bool__AddListener__);
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Events_UnityEvent_bool__RemoveListener__);
		    DAT_ram_00a58099 = '\x01';
		  }
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar2 = Cysharp_Threading_Tasks_CancellationTokenExtensions___cctor(uVar1,0);
		  if (iVar2 != 0) {
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar3 = *(undefined4 *)(iVar2 + 0x3c);
		    uVar1 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar1,param1,
		               Method_Gameplay_Rating_Control_RatingViewMediator_TabChangedEventHandler__,0);
		    UI_Tabs_TabBar__add_ChangeEvent(uVar3,uVar1,0);
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar3 = *(undefined4 *)(*(int *)(iVar2 + 100) + 0xc0);
		    uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_bool__TypeInfo);
		    UnityEngine_UI_Toggle__set_group
		              (uVar1,param1,
		               Method_Gameplay_Rating_Control_RatingViewMediator_PeriodFilterToggleChangedEventHandler__
		               ,0);
		    UnityEngine_Events_UnityEvent_InputAction_CallbackContext___Invoke
		              (uVar3,uVar1,Method_UnityEngine_Events_UnityEvent_bool__RemoveListener__);
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar3 = *(undefined4 *)(*(int *)(iVar2 + 0x68) + 0xc0);
		    uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_bool__TypeInfo);
		    UnityEngine_UI_Toggle__set_group
		              (uVar1,param1,
		               Method_Gameplay_Rating_Control_RatingViewMediator_ExtraFilterToggleChangedEventHandler__
		               ,0);
		    UnityEngine_Events_UnityEvent_InputAction_CallbackContext___Invoke
		              (uVar3,uVar1,Method_UnityEngine_Events_UnityEvent_bool__RemoveListener__);
		  }
		  param1[5] = param2;
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar2 = Cysharp_Threading_Tasks_CancellationTokenExtensions___cctor(uVar1,0);
		  if (iVar2 != 0) {
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar3 = *(undefined4 *)(iVar2 + 0x3c);
		    uVar1 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar1,param1,
		               Method_Gameplay_Rating_Control_RatingViewMediator_TabChangedEventHandler__,0);
		    UI_Tabs_CategoryTabBarItemView___ctor(uVar3,uVar1,0);
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar3 = *(undefined4 *)(*(int *)(iVar2 + 100) + 0xc0);
		    uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_bool__TypeInfo);
		    UnityEngine_UI_Toggle__set_group
		              (uVar1,param1,
		               Method_Gameplay_Rating_Control_RatingViewMediator_PeriodFilterToggleChangedEventHandler__
		               ,0);
		    UnityEngine_Events_UnityEvent_InputAction_CallbackContext____ctor
		              (uVar3,uVar1,Method_UnityEngine_Events_UnityEvent_bool__AddListener__);
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar3 = *(undefined4 *)(*(int *)(iVar2 + 0x68) + 0xc0);
		    uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_bool__TypeInfo);
		    UnityEngine_UI_Toggle__set_group
		              (uVar1,param1,
		               Method_Gameplay_Rating_Control_RatingViewMediator_ExtraFilterToggleChangedEventHandler__
		               ,0);
		    UnityEngine_Events_UnityEvent_InputAction_CallbackContext____ctor
		              (uVar3,uVar1,Method_UnityEngine_Events_UnityEvent_bool__AddListener__);
		    Gameplay_Rating_Control_RatingViewMediator__set_View(param1,param1);
		  }
		  return;
		}
		*/

		}

		// Token: 0x1700064A RID: 1610
		// (set) Token: 0x0600226C RID: 8812 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700064A")]
		public override RatingWindow View
		{
			[Token(Token = "0x600226C")]
			[Address(RVA = "0x73C3", Offset = "0x73C3", VA = "0x73C3", Slot = "20")]
			set
			{
			}
		}

		// Token: 0x0600226D RID: 8813 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600226D")]
		[Address(RVA = "0x73C4", Offset = "0x73C4", VA = "0x73C4")]
		private void Init()
		{
		/* --- GHIDRA: Init ---
		void Gameplay_Rating_Control_RatingViewMediator__Init(int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 param2_00;
		  
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar1 = UI_Tabs_TabBar__get_SelectedIndex(*(undefined4 *)(iVar1 + 0x3c),0);
		  param2_00 = *(undefined4 *)(iVar1 + 0x14);
		  Gameplay_Rating_Control_RatingViewMediator__ActivateCurrentMediator(param1,param1[9],param1);
		  if (DAT_ram_00a5809e == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_RatingKindTypeDic_Types_RatingKindType__Func_RatingKindTypeDic_Types_RatingKindType__uint__BaseRatingViewMediator___get_Item__
		              );
		    DAT_ram_00a5809e = '\x01';
		  }
		  iVar1 = GAFInternal_Reader_GAFReader__OpenTag
		                    (param1[10],param2_00,
		                     Method_System_Collections_Generic_Dictionary_RatingKindTypeDic_Types_RatingKindType__Func_RatingKindTypeDic_Types_RatingKindType__uint__BaseRatingViewMediator___get_Item__
		                    );
		  iVar1 = (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		                    (*(undefined4 *)(iVar1 + 0x20),param2_00,0,*(undefined4 *)(iVar1 + 0x14));
		  param1[9] = iVar1;
		  Gameplay_Rating_Control_RatingViewMediator__ActivateMediator(param1,iVar1,param1);
		  return;
		}
		*/

		}

		// Token: 0x0600226E RID: 8814 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600226E")]
		[Address(RVA = "0x73C5", Offset = "0x73C5", VA = "0x73C5")]
		private void TabChangedEventHandler()
		{
		/* --- GHIDRA: TabChangedEventHandler ---
		void Gameplay_Rating_Control_RatingViewMediator__TabChangedEventHandler
		               (int *param1,uint param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 param1_00;
		  
		  if ((param2 != 0) &&
		     (iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x15c)),
		     *(char *)(*(int *)(iVar1 + 100) + 0xc4) != '\0')) {
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    UnityEngine_UI_Toggle__get_isOn(*(undefined4 *)(iVar1 + 100),0,0);
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  param1_00 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                        (*(undefined4 *)(iVar1 + 0x54),0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (param1_00,param2 ^ 1,0);
		  return;
		}
		*/

		}

		// Token: 0x0600226F RID: 8815 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600226F")]
		[Address(RVA = "0x73C6", Offset = "0x73C6", VA = "0x73C6")]
		private void ExtraFilterToggleChangedEventHandler(bool enabled)
		{
		/* --- GHIDRA: ExtraFilterToggleChangedEventHandler ---
		void Gameplay_Rating_Control_RatingViewMediator__ExtraFilterToggleChangedEventHandler
		               (int *param1,uint param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 param1_00;
		  
		  if ((param2 != 0) &&
		     (iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x15c)),
		     *(char *)(*(int *)(iVar1 + 0x68) + 0xc4) != '\0')) {
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    UnityEngine_UI_Toggle__get_isOn(*(undefined4 *)(iVar1 + 0x68),0,0);
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  param1_00 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                        (*(undefined4 *)(iVar1 + 0x54),0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (param1_00,param2 ^ 1,0);
		  return;
		}
		*/

		}

		// Token: 0x06002270 RID: 8816 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002270")]
		[Address(RVA = "0x73C7", Offset = "0x73C7", VA = "0x73C7")]
		private void PeriodFilterToggleChangedEventHandler(bool enabled)
		{
		/* --- GHIDRA: PeriodFilterToggleChangedEventHandler ---
		int Gameplay_Rating_Control_RatingViewMediator__PeriodFilterToggleChangedEventHandler
		              (int *param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  undefined4 param3_00;
		  undefined4 param4_00;
		  int param1_00;
		  int param2_00;
		  
		  if (DAT_ram_00a5809b == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_RatingModel__RatingEvents__RatingController__RatingWindow__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&Gameplay_Rating_Control_UsersRatingViewMediator_TypeInfo);
		    DAT_ram_00a5809b = '\x01';
		  }
		  param1_00 = param1[6];
		  if (param1_00 == 0) {
		    param2_00 = param1[2];
		    param3_00 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                          (param1,*(undefined4 *)(*param1 + 0x13c));
		    param4_00 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                          (param1,*(undefined4 *)(*param1 + 0x14c));
		    param1_00 = unnamed_function_1417(Gameplay_Rating_Control_UsersRatingViewMediator_TypeInfo);
		    if (DAT_ram_00a5806a == '\0') {
		      Mono_Security_ASN1__get_Item
		                (&
		                 Method_MVC_AbstractViewMediator_RatingModel__RatingEvents__RatingController__RatingWindow___ctor__
		                );
		      DAT_ram_00a5806a = '\x01';
		    }
		    Gameplay_Combat_TeamCombat_View_AbstractTeamCombatView_object___get_HideInstantElements
		              (param1_00,param2_00,param3_00,param4_00,
		               Method_MVC_AbstractViewMediator_RatingModel__RatingEvents__RatingController__RatingWindow___ctor__
		              );
		    *(undefined4 *)(param1_00 + 0x1c) = param3;
		    *(undefined4 *)(param1_00 + 0x18) = param2;
		    param1[6] = param1_00;
		  }
		  return param1_00;
		}
		*/

		}

		// Token: 0x06002271 RID: 8817 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6002271")]
		[Address(RVA = "0x73C8", Offset = "0x73C8", VA = "0x73C8")]
		private BaseRatingViewMediator SelectUserRatings(RatingKindTypeDic.Types.RatingKindType ratingKindType, uint ratingType)
		{
		/* --- GHIDRA: SelectUserRatings ---
		int Gameplay_Rating_Control_RatingViewMediator__SelectUserRatings
		              (int *param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  undefined4 param3_00;
		  undefined4 param4_00;
		  int param1_00;
		  int param2_00;
		  
		  if (DAT_ram_00a5809c == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_RatingModel__RatingEvents__RatingController__RatingWindow__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&Gameplay_Rating_Control_ClansRatingViewMediator_TypeInfo);
		    DAT_ram_00a5809c = '\x01';
		  }
		  param1_00 = param1[7];
		  if (param1_00 == 0) {
		    param2_00 = param1[2];
		    param3_00 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                          (param1,*(undefined4 *)(*param1 + 0x13c));
		    param4_00 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                          (param1,*(undefined4 *)(*param1 + 0x14c));
		    param1_00 = unnamed_function_1417(Gameplay_Rating_Control_ClansRatingViewMediator_TypeInfo);
		    if (DAT_ram_00a58077 == '\0') {
		      Mono_Security_ASN1__get_Item
		                (&
		                 Method_MVC_AbstractViewMediator_RatingModel__RatingEvents__RatingController__RatingWindow__get_Model__
		                );
		      DAT_ram_00a58077 = '\x01';
		    }
		    if (DAT_ram_00a5806a == '\0') {
		      Mono_Security_ASN1__get_Item
		                (&
		                 Method_MVC_AbstractViewMediator_RatingModel__RatingEvents__RatingController__RatingWindow___ctor__
		                );
		      DAT_ram_00a5806a = '\x01';
		    }
		    Gameplay_Combat_TeamCombat_View_AbstractTeamCombatView_object___get_HideInstantElements
		              (param1_00,param2_00,param3_00,param4_00,
		               Method_MVC_AbstractViewMediator_RatingModel__RatingEvents__RatingController__RatingWindow___ctor__
		              );
		    *(undefined4 *)(param1_00 + 0x1c) = param3;
		    *(undefined4 *)(param1_00 + 0x18) = param2;
		    *(bool *)(param1_00 + 0x28) = *(int *)(*(int *)(*(int *)(param1_00 + 8) + 8) + 0x68) != 0;
		    param1[7] = param1_00;
		  }
		  return param1_00;
		}
		*/

			return null;
		}

		// Token: 0x06002272 RID: 8818 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6002272")]
		[Address(RVA = "0x73C9", Offset = "0x73C9", VA = "0x73C9")]
		private BaseRatingViewMediator SelectClanRatings(RatingKindTypeDic.Types.RatingKindType ratingKindType, uint ratingType)
		{
		/* --- GHIDRA: SelectClanRatings ---
		int Gameplay_Rating_Control_RatingViewMediator__SelectClanRatings
		              (int *param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  undefined4 param3_00;
		  undefined4 param4_00;
		  int param1_00;
		  int param2_00;
		  
		  if (DAT_ram_00a5809d == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_RatingModel__RatingEvents__RatingController__RatingWindow__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&Gameplay_Rating_Control_CultsRatingViewMediator_TypeInfo);
		    DAT_ram_00a5809d = '\x01';
		  }
		  param1_00 = param1[8];
		  if (param1_00 == 0) {
		    param2_00 = param1[2];
		    param3_00 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                          (param1,*(undefined4 *)(*param1 + 0x13c));
		    param4_00 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                          (param1,*(undefined4 *)(*param1 + 0x14c));
		    param1_00 = unnamed_function_1417(Gameplay_Rating_Control_CultsRatingViewMediator_TypeInfo);
		    if (DAT_ram_00a5806a == '\0') {
		      Mono_Security_ASN1__get_Item
		                (&
		                 Method_MVC_AbstractViewMediator_RatingModel__RatingEvents__RatingController__RatingWindow___ctor__
		                );
		      DAT_ram_00a5806a = '\x01';
		    }
		    Gameplay_Combat_TeamCombat_View_AbstractTeamCombatView_object___get_HideInstantElements
		              (param1_00,param2_00,param3_00,param4_00,
		               Method_MVC_AbstractViewMediator_RatingModel__RatingEvents__RatingController__RatingWindow___ctor__
		              );
		    *(undefined4 *)(param1_00 + 0x1c) = param3;
		    *(undefined4 *)(param1_00 + 0x18) = param2;
		    param1[8] = param1_00;
		  }
		  return param1_00;
		}
		*/

			return null;
		}

		// Token: 0x06002273 RID: 8819 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6002273")]
		[Address(RVA = "0x73CA", Offset = "0x73CA", VA = "0x73CA")]
		private BaseRatingViewMediator SelectCultRatings(RatingKindTypeDic.Types.RatingKindType ratingKindType, uint ratingType)
		{
		/* --- GHIDRA: SelectCultRatings ---
		void Gameplay_Rating_Control_RatingViewMediator__SelectCultRatings
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  int iVar1;
		  undefined4 param2_00;
		  
		  if (DAT_ram_00a5809e == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_RatingKindTypeDic_Types_RatingKindType__Func_RatingKindTypeDic_Types_RatingKindType__uint__BaseRatingViewMediator___get_Item__
		              );
		    DAT_ram_00a5809e = '\x01';
		  }
		  iVar1 = GAFInternal_Reader_GAFReader__OpenTag
		                    (*(undefined4 *)(param1 + 0x28),param2,
		                     Method_System_Collections_Generic_Dictionary_RatingKindTypeDic_Types_RatingKindType__Func_RatingKindTypeDic_Types_RatingKindType__uint__BaseRatingViewMediator___get_Item__
		                    );
		  param2_00 = (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		                        (*(undefined4 *)(iVar1 + 0x20),param2,param3,*(undefined4 *)(iVar1 + 0x14));
		  *(undefined4 *)(param1 + 0x24) = param2_00;
		  Gameplay_Rating_Control_RatingViewMediator__ActivateMediator(param1,param2_00,param1);
		  return;
		}
		*/

			return null;
		}

		// Token: 0x06002274 RID: 8820 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002274")]
		[Address(RVA = "0x73CB", Offset = "0x73CB", VA = "0x73CB")]
		private void ActivateMediator(RatingKindTypeDic.Types.RatingKindType ratingKindType, uint ratingType = 0U)
		{
		/* --- GHIDRA: ActivateMediator ---
		void Gameplay_Rating_Control_RatingViewMediator__ActivateMediator
		               (int *param1,int *param2,undefined4 param3)
		
		{
		  uint uVar1;
		  undefined4 uVar2;
		  uint *puVar3;
		  int iVar4;
		  
		  if (DAT_ram_00a5809f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_MVC_Interfaces_IViewMediator_TypeInfo);
		    DAT_ram_00a5809f = '\x01';
		  }
		  uVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x13c));
		  iVar4 = *param2;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_MVC_Interfaces_IViewMediator_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)
		         ) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0xe0);
		        goto code_r0x80e9ccbe;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(param2,Core_MVC_Interfaces_IViewMediator_TypeInfo,4);
		code_r0x80e9ccbe:
		  (**(code **)((ulonglong)*puVar3 * 4))(param2,uVar2,puVar3[1]);
		  uVar1 = 0;
		  uVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar4 = *param2;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    do {
		      if (Core_MVC_Interfaces_IViewMediator_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)
		         ) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0x100);
		        goto code_r0x80e9cd54;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(param2,Core_MVC_Interfaces_IViewMediator_TypeInfo,8);
		code_r0x80e9cd54:
		  (**(code **)((ulonglong)*puVar3 * 4))(param2,uVar2,puVar3[1]);
		  return;
		}
		*/

		}

		// Token: 0x06002275 RID: 8821 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002275")]
		[Address(RVA = "0x73CC", Offset = "0x73CC", VA = "0x73CC")]
		private void ActivateCurrentMediator(IViewMediator mediator)
		{
		/* --- GHIDRA: ActivateCurrentMediator ---
		void Gameplay_Rating_Control_RatingViewMediator__ActivateCurrentMediator
		               (undefined4 param1,int *param2,undefined4 param3)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  int iVar3;
		  
		  if (DAT_ram_00a580a0 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_MVC_Interfaces_IViewMediator_TypeInfo);
		    DAT_ram_00a580a0 = '\x01';
		  }
		  iVar3 = *param2;
		  if (*(ushort *)(iVar3 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_MVC_Interfaces_IViewMediator_TypeInfo == *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8)
		         ) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + iVar3 + 0xe0);
		        goto code_r0x80e9cedc;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param2,Core_MVC_Interfaces_IViewMediator_TypeInfo,4);
		code_r0x80e9cedc:
		  uVar1 = 0;
		  (**(code **)((ulonglong)*puVar2 * 4))(param2,0,puVar2[1]);
		  iVar3 = *param2;
		  if (*(ushort *)(iVar3 + 0xb6) != 0) {
		    do {
		      if (Core_MVC_Interfaces_IViewMediator_TypeInfo == *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8)
		         ) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + iVar3 + 0x100);
		        goto code_r0x80e9cf60;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param2,Core_MVC_Interfaces_IViewMediator_TypeInfo,8);
		code_r0x80e9cf60:
		  (**(code **)((ulonglong)*puVar2 * 4))(param2,0,puVar2[1]);
		  return;
		}
		*/

		}

		// Token: 0x06002276 RID: 8822 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002276")]
		[Address(RVA = "0x73CD", Offset = "0x73CD", VA = "0x73CD")]
		private void DeactivateCurrentMediator(IViewMediator mediator)
		{
		/* --- GHIDRA: DeactivateCurrentMediator ---
		uint Gameplay_Rating_Control_RatingViewMediator__DeactivateCurrentMediator
		               (int *param1,int param2,undefined4 param3)
		
		{
		  undefined4 param1_00;
		  int iVar1;
		  int iVar2;
		  
		  if (DAT_ram_00a580a1 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_Windows_BaseWindow_RatingWindow_RatingWindowArgs__get_WindowArgs__);
		    DAT_ram_00a580a1 = '\x01';
		  }
		  iVar2 = *(int *)(param2 + 0x14);
		  param1_00 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar1 = func_ii_8093(param1_00,
		                       Method_UI_Windows_BaseWindow_RatingWindow_RatingWindowArgs__get_WindowArgs__)
		  ;
		  return (uint)(iVar2 == *(int *)(iVar1 + 0x18));
		}
		*/

		}

		// Token: 0x040012D6 RID: 4822
		[Token(Token = "0x40012D6")]
		[FieldOffset(Offset = "0x18")]
		private UsersRatingViewMediator _usersRatingViewMediator;

		// Token: 0x040012D7 RID: 4823
		[Token(Token = "0x40012D7")]
		[FieldOffset(Offset = "0x1C")]
		private ClansRatingViewMediator _clansRatingViewMediator;

		// Token: 0x040012D8 RID: 4824
		[Token(Token = "0x40012D8")]
		[FieldOffset(Offset = "0x20")]
		private CultsRatingViewMediator _cultsRatingViewMediator;

		// Token: 0x040012D9 RID: 4825
		[Token(Token = "0x40012D9")]
		[FieldOffset(Offset = "0x24")]
		private BaseRatingViewMediator _currentMediator;

		// Token: 0x040012DA RID: 4826
		[Token(Token = "0x40012DA")]
		[FieldOffset(Offset = "0x28")]
		private readonly Dictionary<RatingKindTypeDic.Types.RatingKindType, Func<RatingKindTypeDic.Types.RatingKindType, uint, BaseRatingViewMediator>> _tabsOpenersById;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_View ---
		void Gameplay_Rating_Control_RatingViewMediator__set_View(int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 uVar3;
		  
		  if (DAT_ram_00a5809a == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_RatingModel__RatingEvents__RatingController__RatingWindow__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&Method_System_Array_IndexOf_TabBarItemData___);
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_Windows_BaseWindow_RatingWindow_RatingWindowArgs__get_WindowArgs__);
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_First_TabBarItemData___);
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_ToArray_TabBarItemData___);
		    Mono_Security_ASN1__get_Item(&System_Func_TabBarItemData__bool__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Gameplay_Rating_Control_RatingViewMediator__Init_b__9_0__);
		    DAT_ram_00a5809a = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar3 = *(undefined4 *)(iVar1 + 0x3c);
		  uVar2 = Gameplay_Rating_Model_RatingModel___ctor(param1[2],param1);
		  UI_Tabs_TabBar__HandleSelected(uVar3,uVar2,0);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar3 = *(undefined4 *)(*(int *)(iVar1 + 0x3c) + 0x40);
		  uVar2 = unnamed_function_1417(System_Func_TabBarItemData__bool__TypeInfo);
		  System_Collections_Generic_Dictionary_uint__object___GetEnumerator
		            (uVar2,param1,Method_Gameplay_Rating_Control_RatingViewMediator__Init_b__9_0__,0);
		  uVar2 = func_ii_7423(uVar3,uVar2,Method_System_Linq_Enumerable_First_TabBarItemData___);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar3 = func_ii_6295(*(undefined4 *)(*(int *)(iVar1 + 0x3c) + 0x40),
		                       Method_System_Linq_Enumerable_ToArray_TabBarItemData___);
		  uVar2 = LunarConsolePlugin_CVar__set_Value
		                    (uVar3,uVar2,Method_System_Array_IndexOf_TabBarItemData___);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  Gameplay_GameEvents_Model_GameEventData__get_ContainsArtifactRewards
		            (*(undefined4 *)(iVar1 + 0x3c),uVar2,1,0);
		  uVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar1 = func_ii_8093(uVar2,
		                       Method_UI_Windows_BaseWindow_RatingWindow_RatingWindowArgs__get_WindowArgs__)
		  ;
		  uVar3 = *(undefined4 *)(iVar1 + 0x18);
		  uVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar1 = func_ii_8093(uVar2,
		                       Method_UI_Windows_BaseWindow_RatingWindow_RatingWindowArgs__get_WindowArgs__)
		  ;
		  uVar2 = *(undefined4 *)(iVar1 + 0x1c);
		  if (DAT_ram_00a5809e == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_RatingKindTypeDic_Types_RatingKindType__Func_RatingKindTypeDic_Types_RatingKindType__uint__BaseRatingViewMediator___get_Item__
		              );
		    DAT_ram_00a5809e = '\x01';
		  }
		  iVar1 = GAFInternal_Reader_GAFReader__OpenTag
		                    (param1[10],uVar3,
		                     Method_System_Collections_Generic_Dictionary_RatingKindTypeDic_Types_RatingKindType__Func_RatingKindTypeDic_Types_RatingKindType__uint__BaseRatingViewMediator___get_Item__
		                    );
		  iVar1 = (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		                    (*(undefined4 *)(iVar1 + 0x20),uVar3,uVar2,*(undefined4 *)(iVar1 + 0x14));
		  param1[9] = iVar1;
		  Gameplay_Rating_Control_RatingViewMediator__ActivateMediator(param1,iVar1,param1);
		  return;
		}
		*/


		/* --- GHIDRA: ResetEvents ---
		void Gameplay_Competition_Control_Sections_RatingViewMediator__ResetEvents
		               (undefined4 param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  int iVar3;
		  int *param1_00;
		  int iVar4;
		  undefined4 uVar5;
		  
		  if (DAT_ram_00a63aff == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_ChangedFromTo_OwnerRating__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Competition_Control_Sections_RatingViewMediator_HandleOwnerRatingChangedEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Competition_Control_Sections_RatingViewMediator_HandleRatingChangedEvent__
		              );
		    DAT_ram_00a63aff = '\x01';
		  }
		  iVar4 = *(int *)(param2 + 0x14);
		  uVar5 = *(undefined4 *)(iVar4 + 0x18);
		  uVar1 = unnamed_function_1417(Core_ChangedFromTo_OwnerRating__TypeInfo);
		  UnityEngine_UIElements_ChangeEvent___Il2CppFullySharedGenericType___set_previousValue
		            (uVar1,param1,
		             Method_Gameplay_Competition_Control_Sections_RatingViewMediator_HandleOwnerRatingChangedEvent__
		             ,0);
		  iVar2 = UnityEngine_UI_Image__set_sprite(uVar5,uVar1,0);
		  uVar1 = Core_ChangedFromTo_OwnerRating__TypeInfo;
		  if (iVar2 == 0) {
		    *(undefined4 *)(iVar4 + 0x18) = 0;
		  }
		  else {
		    iVar3 = func_ii_1082(iVar2,Core_ChangedFromTo_OwnerRating__TypeInfo);
		    if (iVar3 == 0) {
		      System_Activator__CreateInstance(iVar2,uVar1);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    *(int *)(iVar4 + 0x18) = iVar3;
		    uVar1 = Core_ChangedFromTo_OwnerRating__TypeInfo;
		    iVar4 = func_ii_1082(iVar2,Core_ChangedFromTo_OwnerRating__TypeInfo);
		    if (iVar4 == 0) {
		      System_Activator__CreateInstance(iVar2,uVar1);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  iVar4 = *(int *)(param2 + 0x14);
		  uVar5 = *(undefined4 *)(iVar4 + 0x1c);
		  uVar1 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar1,param1,
		             Method_Gameplay_Competition_Control_Sections_RatingViewMediator_HandleRatingChangedEvent__
		             ,0);
		  param1_00 = (int *)UnityEngine_UI_Image__set_sprite(uVar5,uVar1,0);
		  iVar2 = System_Action_TypeInfo;
		  if (param1_00 == (int *)0x0) {
		    *(undefined4 *)(iVar4 + 0x1c) = 0;
		    return;
		  }
		  if ((System_Action_TypeInfo == *param1_00) &&
		     (*(int **)(iVar4 + 0x1c) = param1_00, *param1_00 == iVar2)) {
		    return;
		  }
		  System_Activator__CreateInstance(param1_00,iVar2);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/


		/* --- GHIDRA: ResetView ---
		void Gameplay_Competition_Control_Sections_RatingViewMediator__ResetView
		               (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 param2_00;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a63b00 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Com_TheFallenGames_OSA_Core_OSA_BaseParamsWithPrefab__UserInCommonRatingsViewsHolder__Init__
		              );
		    DAT_ram_00a63b00 = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  Com_TheFallenGames_OSA_Core_OSA_object__object___GetVirtualAbstractNormalizedScrollPosition
		            (*(undefined4 *)(iVar1 + 0x28),
		             Method_Com_TheFallenGames_OSA_Core_OSA_BaseParamsWithPrefab__UserInCommonRatingsViewsHolder__Init__
		            );
		  Gameplay_Competition_Control_Sections_RatingViewMediator__SetupView(param1,param1);
		  Gameplay_Competition_Control_Sections_RatingViewMediator__UpdateTopLeaders(param1,param1);
		  if (DAT_ram_00a63b03 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_RatingModel__RatingEvents__RatingController__RatingView__get_Model__
		              );
		    DAT_ram_00a63b03 = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  param1_00 = *(undefined4 *)(iVar1 + 0x24);
		  param2_00 = Gameplay_Competition_Model_RatingModel__GetOwnerRating(param1[2],param1);
		  UI_Elements_RatingElements_TopLeader___c__DisplayClass15_0___Init_b__0(param1_00,param2_00,0);
		  Gameplay_Competition_Control_Sections_RatingViewMediator__UpdateRatingView(param1,param1);
		  return;
		}
		*/


		/* --- GHIDRA: SetupView ---
		void Gameplay_Competition_Control_Sections_RatingViewMediator__SetupView
		               (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 uVar3;
		  
		  if (DAT_ram_00a63b01 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_RatingModel__RatingEvents__RatingController__RatingView__get_Model__
		              );
		    DAT_ram_00a63b01 = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar3 = *(undefined4 *)(iVar1 + 0x34);
		  uVar2 = Core_Extensions_Dict_CompetitionDicExt__GetIcon(*(undefined4 *)(param1[2] + 0x18),0);
		  UI_Elements_RightPanel_TitledList_Elements_UpgradeRequirements_UpgradeRequirementElementArgs___ctor
		            (uVar3,uVar2,0);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar3 = *(undefined4 *)(iVar1 + 0x34);
		  uVar2 = Core_Extensions_Dict_CompetitionRatingKindDicExt__GetTitle
		                    (*(undefined4 *)(param1[2] + 0x18),0);
		  Gameplay_Antiq_View_Grid_GridList__SetData(uVar3,uVar2,0);
		  return;
		}
		*/


		/* --- GHIDRA: SetupText ---
		void Gameplay_Competition_Control_Sections_RatingViewMediator__SetupText
		               (int *param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  undefined4 param1_00;
		  
		  Gameplay_Competition_Control_Sections_RatingViewMediator__UpdateRatingView(param1,param1);
		  param1_00 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x14c));
		  Gameplay_Competition_Control_Sections_RatingController__ValidateInit(param1_00,param1);
		  return;
		}
		*/


		/* --- GHIDRA: HandleRatingChangedEvent ---
		void Gameplay_Competition_Control_Sections_RatingViewMediator__HandleRatingChangedEvent
		               (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 param2_00;
		  undefined4 param1_00;
		  
		  Gameplay_Competition_Control_Sections_RatingViewMediator__UpdateTopLeaders(param1,param1);
		  if (DAT_ram_00a63b03 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_RatingModel__RatingEvents__RatingController__RatingView__get_Model__
		              );
		    DAT_ram_00a63b03 = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  param1_00 = *(undefined4 *)(iVar1 + 0x24);
		  param2_00 = Gameplay_Competition_Model_RatingModel__GetOwnerRating(param1[2],param1);
		  UI_Elements_RatingElements_TopLeader___c__DisplayClass15_0___Init_b__0(param1_00,param2_00,0);
		  Gameplay_Competition_Control_Sections_RatingViewMediator__UpdateRatingView(param1,param1);
		  return;
		}
		*/


		/* --- GHIDRA: UpdateRatingView ---
		void Gameplay_Competition_Control_Sections_RatingViewMediator__UpdateRatingView
		               (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  int param1_00;
		  undefined4 param1_01;
		  undefined4 uVar2;
		  
		  if (DAT_ram_00a63b02 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_RatingModel__RatingEvents__RatingController__RatingView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Elements_GenericList_SelectableListElement_UserInRatingListElement_UserInRatingListElementArgs__set_Data__
		              );
		    DAT_ram_00a63b02 = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  param1_01 = *(undefined4 *)(*(int *)(iVar1 + 0x2c) + 0x1c);
		  iVar1 = param1[2];
		  if (DAT_ram_00a63ac4 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Gameplay_Clans_Office_View_ClanResumesTab_UserInRatingListElement_UserInRatingListElementArgs_TypeInfo
		              );
		    DAT_ram_00a63ac4 = '\x01';
		  }
		  param1_00 = unnamed_function_1417
		                        (
		                        Gameplay_Clans_Office_View_ClanResumesTab_UserInRatingListElement_UserInRatingListElementArgs_TypeInfo
		                        );
		  Gameplay_Clans_Office_View_ClanResumesTab_UserInRatingListElement___ctor(param1_00,0);
		  *(undefined4 *)(param1_00 + 0x1c) = *(undefined4 *)(iVar1 + 8);
		  iVar1 = *(int *)(iVar1 + 0x10);
		  *(undefined8 *)(param1_00 + 0x20) = *(undefined8 *)(iVar1 + 0x10);
		  uVar2 = *(undefined4 *)(iVar1 + 0xc);
		  *(undefined1 *)(param1_00 + 0x2c) = 1;
		  *(undefined4 *)(param1_00 + 0x28) = uVar2;
		  func_ii_7635(param1_01,param1_00,
		               Method_UI_Elements_GenericList_SelectableListElement_UserInRatingListElement_UserInRatingListElementArgs__set_Data__
		              );
		  return;
		}
		*/


		/* --- GHIDRA: UpdateOwnerRating ---
		void Gameplay_Competition_Control_Sections_RatingViewMediator__UpdateOwnerRating
		               (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 param2_00;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a63b03 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_RatingModel__RatingEvents__RatingController__RatingView__get_Model__
		              );
		    DAT_ram_00a63b03 = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  param1_00 = *(undefined4 *)(iVar1 + 0x24);
		  param2_00 = Gameplay_Competition_Model_RatingModel__GetOwnerRating(param1[2],param1);
		  UI_Elements_RatingElements_TopLeader___c__DisplayClass15_0___Init_b__0(param1_00,param2_00,0);
		  return;
		}
		*/


		/* --- GHIDRA: UpdateTopLeaders ---
		void Gameplay_Competition_Control_Sections_RatingViewMediator__UpdateTopLeaders
		               (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  int iVar3;
		  
		  if (DAT_ram_00a63b04 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_RatingModel__RatingEvents__RatingController__RatingView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Com_TheFallenGames_OSA_Core_OSA_BaseParamsWithPrefab__UserInCommonRatingsViewsHolder__get_IsInitialized__
		              );
		    DAT_ram_00a63b04 = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  if (*(char *)(*(int *)(iVar1 + 0x28) + 0x50) != '\0') {
		    uVar2 = Gameplay_Competition_Model_RatingModel__SetRating(param1[2],param1);
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    iVar3 = **(int **)(iVar1 + 0x28);
		    (**(code **)((ulonglong)*(uint *)(iVar3 + 0x3b8) * 4))
		              (*(int **)(iVar1 + 0x28),*(undefined4 *)(iVar3 + 0x3bc));
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    iVar3 = **(int **)(iVar1 + 0x28);
		    (**(code **)((ulonglong)
		                 *(uint *)(s_Allocator__0___MaxBlockCount__1__ram_00000478 + iVar3 + 0x10) * 4))
		              (*(int **)(iVar1 + 0x28),uVar2,
		               *(undefined4 *)(s_Allocator__0___MaxBlockCount__1__ram_00000478 + iVar3 + 0x14));
		  }
		  return;
		}
		*/


		/* --- GHIDRA: UpdateOSAView ---
		void Gameplay_Competition_Control_Sections_RatingViewMediator__UpdateOSAView
		               (undefined4 param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  if (DAT_ram_00a63b05 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_MVC_AbstractController_RewardsModel__RewardsEvents___ctor__);
		    DAT_ram_00a63b05 = '\x01';
		  }
		  Gameplay_Combat_AbstractCombat_object__object__object__object__object___set_User
		            (param1,param2,param3,Method_MVC_AbstractController_RewardsModel__RewardsEvents___ctor__
		            );
		  return;
		}
		*/

}
