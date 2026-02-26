using System;
using Gameplay.Competition.Events;
using Gameplay.Competition.Model;
using Gameplay.Competition.View;
using Il2CppDummyDll;
using MVC;
using Protocol.Competition;

namespace Gameplay.Competition.Control
{
	// Token: 0x02000906 RID: 2310
	[Token(Token = "0x2000906")]
	public class CompetitionViewMediator : AbstractCozyViewMediator<CompetitionModel, Gameplay.Competition.Events.CompetitionEvents, CompetitionController, CompetitionView>
	{
		// Token: 0x0600364B RID: 13899 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600364B")]
		[Address(RVA = "0x8658", Offset = "0x8658", VA = "0x8658")]
		public CompetitionViewMediator(CompetitionModel model, Gameplay.Competition.Events.CompetitionEvents events, CompetitionController controller)
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Competition_Control_CompetitionViewMediator___ctor
		               (undefined4 param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  int iVar3;
		  int *param1_00;
		  undefined4 uVar4;
		  
		  if (DAT_ram_00a63ae3 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_CompetitionData__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Competition_Control_CompetitionViewMediator_HandleActiveQuestsCountChanged__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Competition_Control_CompetitionViewMediator_HandleStateChangedEvent__
		              );
		    DAT_ram_00a63ae3 = '\x01';
		  }
		  uVar4 = *(undefined4 *)(param2 + 0x14);
		  uVar1 = unnamed_function_1417(System_Action_CompetitionData__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar1,param1,
		             Method_Gameplay_Competition_Control_CompetitionViewMediator_HandleStateChangedEvent__,0
		            );
		  iVar2 = func_ii_7048(uVar4,uVar1,0);
		  uVar1 = System_Action_CompetitionData__TypeInfo;
		  if (iVar2 == 0) {
		    *(undefined4 *)(param2 + 0x14) = 0;
		  }
		  else {
		    iVar3 = func_ii_1082(iVar2,System_Action_CompetitionData__TypeInfo);
		    if (iVar3 == 0) {
		      System_Activator__CreateInstance(iVar2,uVar1);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    *(int *)(param2 + 0x14) = iVar3;
		    uVar1 = System_Action_CompetitionData__TypeInfo;
		    iVar3 = func_ii_1082(iVar2,System_Action_CompetitionData__TypeInfo);
		    if (iVar3 == 0) {
		      System_Activator__CreateInstance(iVar2,uVar1);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  uVar4 = *(undefined4 *)(param2 + 0x24);
		  uVar1 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar1,param1,
		             Method_Gameplay_Competition_Control_CompetitionViewMediator_HandleActiveQuestsCountChanged__
		             ,0);
		  param1_00 = (int *)func_ii_7048(uVar4,uVar1,0);
		  iVar2 = System_Action_TypeInfo;
		  if (param1_00 == (int *)0x0) {
		    *(undefined4 *)(param2 + 0x24) = 0;
		    return;
		  }
		  if ((System_Action_TypeInfo == *param1_00) &&
		     (*(int **)(param2 + 0x24) = param1_00, *param1_00 == iVar2)) {
		    return;
		  }
		  System_Activator__CreateInstance(param1_00,iVar2);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x0600364C RID: 13900 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600364C")]
		[Address(RVA = "0x8659", Offset = "0x8659", VA = "0x8659", Slot = "21")]
		protected override void ResetEvents(Gameplay.Competition.Events.CompetitionEvents events)
		{
		/* --- GHIDRA: ResetEvents ---
		void Gameplay_Competition_Control_CompetitionViewMediator__ResetEvents
		               (undefined4 param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  int iVar3;
		  int *param1_00;
		  undefined4 uVar4;
		  
		  if (DAT_ram_00a63ae4 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_CompetitionData__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Competition_Control_CompetitionViewMediator_HandleActiveQuestsCountChanged__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Competition_Control_CompetitionViewMediator_HandleStateChangedEvent__
		              );
		    DAT_ram_00a63ae4 = '\x01';
		  }
		  uVar4 = *(undefined4 *)(param2 + 0x14);
		  uVar1 = unnamed_function_1417(System_Action_CompetitionData__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar1,param1,
		             Method_Gameplay_Competition_Control_CompetitionViewMediator_HandleStateChangedEvent__,0
		            );
		  iVar2 = UnityEngine_UI_Image__set_sprite(uVar4,uVar1,0);
		  uVar1 = System_Action_CompetitionData__TypeInfo;
		  if (iVar2 == 0) {
		    *(undefined4 *)(param2 + 0x14) = 0;
		  }
		  else {
		    iVar3 = func_ii_1082(iVar2,System_Action_CompetitionData__TypeInfo);
		    if (iVar3 == 0) {
		      System_Activator__CreateInstance(iVar2,uVar1);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    *(int *)(param2 + 0x14) = iVar3;
		    uVar1 = System_Action_CompetitionData__TypeInfo;
		    iVar3 = func_ii_1082(iVar2,System_Action_CompetitionData__TypeInfo);
		    if (iVar3 == 0) {
		      System_Activator__CreateInstance(iVar2,uVar1);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  uVar4 = *(undefined4 *)(param2 + 0x24);
		  uVar1 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar1,param1,
		             Method_Gameplay_Competition_Control_CompetitionViewMediator_HandleActiveQuestsCountChanged__
		             ,0);
		  param1_00 = (int *)UnityEngine_UI_Image__set_sprite(uVar4,uVar1,0);
		  iVar2 = System_Action_TypeInfo;
		  if (param1_00 == (int *)0x0) {
		    *(undefined4 *)(param2 + 0x24) = 0;
		    return;
		  }
		  if ((System_Action_TypeInfo == *param1_00) &&
		     (*(int **)(param2 + 0x24) = param1_00, *param1_00 == iVar2)) {
		    return;
		  }
		  System_Activator__CreateInstance(param1_00,iVar2);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x0600364D RID: 13901 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600364D")]
		[Address(RVA = "0x865A", Offset = "0x865A", VA = "0x865A", Slot = "22")]
		protected override void SetupEvents(Gameplay.Competition.Events.CompetitionEvents events)
		{
		/* --- GHIDRA: SetupEvents ---
		void Gameplay_Competition_Control_CompetitionViewMediator__SetupEvents
		               (undefined4 param1,int param2,undefined4 param3)
		
		{
		  undefined4 param1_00;
		  undefined4 param1_01;
		  
		  if (DAT_ram_00a63ae5 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Competition_Control_CompetitionViewMediator_HandleTabBarChangeEvent__
		              );
		    DAT_ram_00a63ae5 = '\x01';
		  }
		  param1_01 = *(undefined4 *)(param2 + 0x14);
		  param1_00 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (param1_00,param1,
		             Method_Gameplay_Competition_Control_CompetitionViewMediator_HandleTabBarChangeEvent__,0
		            );
		  UI_Tabs_TabBar__add_ChangeEvent(param1_01,param1_00,0);
		  return;
		}
		*/

		}

		// Token: 0x0600364E RID: 13902 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600364E")]
		[Address(RVA = "0x865B", Offset = "0x865B", VA = "0x865B", Slot = "23")]
		protected override void ResetView(CompetitionView view)
		{
		/* --- GHIDRA: ResetView ---
		void Gameplay_Competition_Control_CompetitionViewMediator__ResetView
		               (int *param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  undefined4 uVar3;
		  int *piVar4;
		  
		  if (DAT_ram_00a63ae6 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_CompetitionModel__CompetitionEvents__CompetitionController__CompetitionView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Competition_Control_CompetitionViewMediator_HandleTabBarChangeEvent__
		              );
		    DAT_ram_00a63ae6 = '\x01';
		  }
		  uVar3 = *(undefined4 *)(param2 + 0x14);
		  uVar1 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar1,param1,
		             Method_Gameplay_Competition_Control_CompetitionViewMediator_HandleTabBarChangeEvent__,0
		            );
		  UI_Tabs_CategoryTabBarItemView___ctor(uVar3,uVar1,0);
		  if (DAT_ram_00a63ae7 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Competition_Control_CompetitionViewMediator_FormatBackTime__);
		    Mono_Security_ASN1__get_Item(&UI_AbstractBacktimeView_FormatCallback_TypeInfo);
		    DAT_ram_00a63ae7 = '\x01';
		  }
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar2 = *(int *)(iVar2 + 0x18);
		  if (*(int *)(iVar2 + 0x14) == 0) {
		    uVar1 = unnamed_function_1417(UI_AbstractBacktimeView_FormatCallback_TypeInfo);
		    UI_AbstractBacktimeView___ctor
		              (uVar1,param1,
		               Method_Gameplay_Competition_Control_CompetitionViewMediator_FormatBackTime__,0);
		    *(undefined4 *)(iVar2 + 0x14) = uVar1;
		  }
		  uVar3 = *(undefined4 *)(param2 + 0x10);
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x14c));
		  Gameplay_Competition_View_Sections_SectionContainer__Awake(uVar3,uVar1,param1);
		  UI_Elements_RightPanel_TitleWithLevel__set_Level
		            (*(undefined4 *)(param2 + 0x18),*(undefined4 *)(param1[2] + 0x20),0);
		  piVar4 = *(int **)(param2 + 0x1c);
		  if (*(int *)(param1[2] + 0x2c) == 0) {
		    uVar1 = 0;
		  }
		  else {
		    uVar1 = Core_Extensions_Dict_CombatEventDicExt__GetSoundAssetId
		                      (*(undefined4 *)(*(int *)(param1[2] + 0x2c) + 8),0);
		  }
		  iVar2 = *piVar4;
		  (**(code **)((ulonglong)*(uint *)(iVar2 + 0x2d0) * 4))
		            (piVar4,uVar1,*(undefined4 *)(iVar2 + 0x2d4));
		  uVar1 = *(undefined4 *)(*(int *)(*(int *)(param1[2] + 0x2c) + 0xc) + 0xc);
		  if (DAT_ram_00a63aeb == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_CompetitionModel__CompetitionEvents__CompetitionController__CompetitionView__get_Model__
		              );
		    DAT_ram_00a63aeb = '\x01';
		  }
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar3 = *(undefined4 *)(iVar2 + 0x14);
		  uVar1 = Gameplay_Competition_Model_CompetitionModel___ctor(param1[2],uVar1,param1);
		  UI_Tabs_TabBar__HandleSelected(uVar3,uVar1,0);
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  UI_Tabs_TabBar__Init(*(undefined4 *)(iVar2 + 0x14),*(undefined4 *)(param1[2] + 0x10),0);
		  return;
		}
		*/

		}

		// Token: 0x0600364F RID: 13903 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600364F")]
		[Address(RVA = "0x865C", Offset = "0x865C", VA = "0x865C", Slot = "24")]
		protected override void SetupView(CompetitionView view)
		{
		/* --- GHIDRA: SetupView ---
		void Gameplay_Competition_Control_CompetitionViewMediator__SetupView(int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a63ae7 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Competition_Control_CompetitionViewMediator_FormatBackTime__);
		    Mono_Security_ASN1__get_Item(&UI_AbstractBacktimeView_FormatCallback_TypeInfo);
		    DAT_ram_00a63ae7 = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar1 = *(int *)(iVar1 + 0x18);
		  if (*(int *)(iVar1 + 0x14) == 0) {
		    param1_00 = unnamed_function_1417(UI_AbstractBacktimeView_FormatCallback_TypeInfo);
		    UI_AbstractBacktimeView___ctor
		              (param1_00,param1,
		               Method_Gameplay_Competition_Control_CompetitionViewMediator_FormatBackTime__,0);
		    *(undefined4 *)(iVar1 + 0x14) = param1_00;
		  }
		  return;
		}
		*/

		}

		// Token: 0x06003650 RID: 13904 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003650")]
		[Address(RVA = "0x865D", Offset = "0x865D", VA = "0x865D")]
		private void HandleFireAnimationTime()
		{
		/* --- GHIDRA: HandleFireAnimationTime ---
		undefined4
		Gameplay_Competition_Control_CompetitionViewMediator__HandleFireAnimationTime
		          (int *param1,float param2,undefined4 param3)
		
		{
		  float fVar1;
		  uint uVar2;
		  undefined4 in_register_20000004;
		  int iVar3;
		  undefined4 uVar4;
		  ulonglong local_8;
		  
		  fVar1 = 0.0;
		  uVar2 = 0;
		  if (DAT_ram_00a63ae8 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_CompetitionModel__CompetitionEvents__CompetitionController__CompetitionView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&Method_System_Nullable_float__GetValueOrDefault__);
		    Mono_Security_ASN1__get_Item(&Method_System_Nullable_float___ctor__);
		    Mono_Security_ASN1__get_Item(&Method_System_Nullable_float__get_HasValue__);
		    Mono_Security_ASN1__get_Item(&Utils_TimeUtils_TypeInfo);
		    DAT_ram_00a63ae8 = '\x01';
		  }
		  if (param1[2] != 0) {
		    local_8 = 0;
		    System_Type__GetProperty
		              (&local_8,*(float *)(param1[2] + 0x34),Method_System_Nullable_float___ctor__);
		    uVar2 = (uint)((local_8 & 0xff) != 0);
		    fVar1 = (float)(local_8 >> 0x20);
		  }
		  iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (CONCAT44(in_register_20000004,param1),*(undefined4 *)(*param1 + 0x15c));
		  uVar4 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (*(undefined4 *)(iVar3 + 0x20),0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar4,param2 < fVar1 & uVar2,0);
		  if (param2 <= 0.0) {
		    uVar4 = **(undefined4 **)(DAT_ram_00a66978 + 0x5c);
		  }
		  else {
		    if (*(int *)(Utils_TimeUtils_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Utils_TimeUtils_TypeInfo);
		    }
		    uVar4 = Utils_TimeUtils__DateFormat((double)param2,0);
		  }
		  return uVar4;
		}
		*/

		}

		// Token: 0x06003651 RID: 13905 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6003651")]
		[Address(RVA = "0x865E", Offset = "0x865E", VA = "0x865E")]
		private string FormatBackTime(float value)
		{
		/* --- GHIDRA: FormatBackTime ---
		void Gameplay_Competition_Control_CompetitionViewMediator__FormatBackTime
		               (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  int *param1_00;
		  undefined4 param2_00;
		  
		  if (DAT_ram_00a63ae9 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_CompetitionModel__CompetitionEvents__CompetitionController__CompetitionView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&Method_UI_MonoBehaviourWithStates_Sections__set_CurrentState__);
		    Mono_Security_ASN1__get_Item(&Method_UI_Tabs_TabBarItemData_Sections__get_Data__);
		    Mono_Security_ASN1__get_Item(&UI_Tabs_TabBarItemData_Sections__TypeInfo);
		    DAT_ram_00a63ae9 = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  param1_00 = (int *)UI_Tabs_TabBar__get_SelectedIndex(*(undefined4 *)(iVar1 + 0x14),0);
		  if (param1_00 != (int *)0x0) {
		    if (((uint)*(byte *)(*param1_00 + 0xb8) <
		         (uint)*(byte *)(UI_Tabs_TabBarItemData_Sections__TypeInfo + 0xb8)) ||
		       (*(int *)(*(int *)(*param1_00 + 100) +
		                 (uint)*(byte *)(UI_Tabs_TabBarItemData_Sections__TypeInfo + 0xb8) * 4 + -4) !=
		        UI_Tabs_TabBarItemData_Sections__TypeInfo)) {
		      System_Activator__CreateInstance(param1_00,UI_Tabs_TabBarItemData_Sections__TypeInfo);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  *(undefined1 *)(param1[2] + 0x24) = *(undefined1 *)((int)param1_00 + 0x1d);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  UI_MonoBehaviourWithStates_ByteEnum___remove_CurrentStateChangedEvent
		            (*(undefined4 *)(iVar1 + 0x10),(uint)*(byte *)((int)param1_00 + 0x1d),
		             Method_UI_MonoBehaviourWithStates_Sections__set_CurrentState__);
		  if (DAT_ram_00a63aec == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_CompetitionModel__CompetitionEvents__CompetitionController__CompetitionView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&Method_UI_Tabs_TabBar_GetItem_Sections___);
		    DAT_ram_00a63aec = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar1 = TMPro_TMPro_ExtensionMethods__FindInstanceID_object_
		                    (*(undefined4 *)(iVar1 + 0x14),3,Method_UI_Tabs_TabBar_GetItem_Sections___);
		  if (iVar1 != 0) {
		    param2_00 = Gameplay_Competition_Model_CompetitionModel__GetAvailSections(param1[2],param1);
		    Core_Extensions_Dict_BossGroupDictExt__GetTitle(iVar1,param2_00,0);
		  }
		  return;
		}
		*/

			return null;
		}

		// Token: 0x06003652 RID: 13906 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003652")]
		[Address(RVA = "0x865F", Offset = "0x865F", VA = "0x865F")]
		private void HandleTabBarChangeEvent()
		{
		/* --- GHIDRA: HandleTabBarChangeEvent ---
		void Gameplay_Competition_Control_CompetitionViewMediator__HandleTabBarChangeEvent
		               (int *param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a63aea == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_CompetitionModel__CompetitionEvents__CompetitionController__CompetitionView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&Method_UI_Windows_PopupController_Close_CompetitionWindow___);
		    DAT_ram_00a63aea = '\x01';
		  }
		  if (param2 == 0) {
		    DG_Tweening_Plugins_Core_PluginsManager__GetDefaultPlugin___Il2CppFullySharedGenericType____Il2CppFullySharedGenericType____Il2CppFullySharedGenericStructType_
		              (*(undefined4 *)(*(int *)(param1[2] + 0xc) + 0x1c),1,
		               Method_UI_Windows_PopupController_Close_CompetitionWindow___);
		    return;
		  }
		  uVar2 = *(undefined4 *)(*(int *)(param2 + 0xc) + 0xc);
		  if (DAT_ram_00a63aeb == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_CompetitionModel__CompetitionEvents__CompetitionController__CompetitionView__get_Model__
		              );
		    DAT_ram_00a63aeb = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  param1_00 = *(undefined4 *)(iVar1 + 0x14);
		  uVar2 = Gameplay_Competition_Model_CompetitionModel___ctor(param1[2],uVar2,param1);
		  UI_Tabs_TabBar__HandleSelected(param1_00,uVar2,0);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  UI_Tabs_TabBar__Init(*(undefined4 *)(iVar1 + 0x14),*(undefined4 *)(param1[2] + 0x10),0);
		  if (DAT_ram_00a63aec == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_CompetitionModel__CompetitionEvents__CompetitionController__CompetitionView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&Method_UI_Tabs_TabBar_GetItem_Sections___);
		    DAT_ram_00a63aec = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar1 = TMPro_TMPro_ExtensionMethods__FindInstanceID_object_
		                    (*(undefined4 *)(iVar1 + 0x14),3,Method_UI_Tabs_TabBar_GetItem_Sections___);
		  if (iVar1 != 0) {
		    uVar2 = Gameplay_Competition_Model_CompetitionModel__GetAvailSections(param1[2],param1);
		    Core_Extensions_Dict_BossGroupDictExt__GetTitle(iVar1,uVar2,0);
		  }
		  return;
		}
		*/

		}

		// Token: 0x06003653 RID: 13907 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003653")]
		[Address(RVA = "0x8660", Offset = "0x8660", VA = "0x8660")]
		private void HandleStateChangedEvent(CompetitionData data)
		{
		/* --- GHIDRA: HandleStateChangedEvent ---
		void Gameplay_Competition_Control_CompetitionViewMediator__HandleStateChangedEvent
		               (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 param2_00;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a63aeb == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_CompetitionModel__CompetitionEvents__CompetitionController__CompetitionView__get_Model__
		              );
		    DAT_ram_00a63aeb = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  param1_00 = *(undefined4 *)(iVar1 + 0x14);
		  param2_00 = Gameplay_Competition_Model_CompetitionModel___ctor(param1[2],param2,param1);
		  UI_Tabs_TabBar__HandleSelected(param1_00,param2_00,0);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  UI_Tabs_TabBar__Init(*(undefined4 *)(iVar1 + 0x14),*(undefined4 *)(param1[2] + 0x10),0);
		  return;
		}
		*/

		}

		// Token: 0x06003654 RID: 13908 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003654")]
		[Address(RVA = "0x8661", Offset = "0x8661", VA = "0x8661")]
		private void SetState(EventState state)
		{
		}

		// Token: 0x06003655 RID: 13909 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003655")]
		[Address(RVA = "0x8662", Offset = "0x8662", VA = "0x8662")]
		private void HandleActiveQuestsCountChanged()
		{
		/* --- GHIDRA: HandleActiveQuestsCountChanged ---
		void Gameplay_Competition_Control_CompetitionViewMediator__HandleActiveQuestsCountChanged
		               (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 param2_00;
		  
		  if (DAT_ram_00a63aec == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_CompetitionModel__CompetitionEvents__CompetitionController__CompetitionView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&Method_UI_Tabs_TabBar_GetItem_Sections___);
		    DAT_ram_00a63aec = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar1 = TMPro_TMPro_ExtensionMethods__FindInstanceID_object_
		                    (*(undefined4 *)(iVar1 + 0x14),3,Method_UI_Tabs_TabBar_GetItem_Sections___);
		  if (iVar1 != 0) {
		    param2_00 = Gameplay_Competition_Model_CompetitionModel__GetAvailSections(param1[2],param1);
		    Core_Extensions_Dict_BossGroupDictExt__GetTitle(iVar1,param2_00,0);
		  }
		  return;
		}
		*/

		}

		// Token: 0x06003656 RID: 13910 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003656")]
		[Address(RVA = "0x8663", Offset = "0x8663", VA = "0x8663")]
		private void ValidateTabCounters()
		{
		/* --- GHIDRA: ValidateTabCounters ---
		void Gameplay_Competition_Control_CompetitionViewMediator__ValidateTabCounters
		               (undefined4 param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  if (DAT_ram_00a63aed == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_MVC_AbstractController_QuestModel__QuestEvents___ctor__);
		    DAT_ram_00a63aed = '\x01';
		  }
		  Gameplay_Combat_AbstractCombat_object__object__object__object__object___set_User
		            (param1,param2,param3,Method_MVC_AbstractController_QuestModel__QuestEvents___ctor__);
		  return;
		}
		*/

		}
	}
}
