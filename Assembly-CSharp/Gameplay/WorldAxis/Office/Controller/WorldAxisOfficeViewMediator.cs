using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Gameplay.WorldAxis.Office.Events;
using Gameplay.WorldAxis.Office.Model;
using Gameplay.WorldAxis.Office.View;
using Il2CppDummyDll;
using MVC;
using MVC.Interfaces;

namespace Gameplay.WorldAxis.Office.Controller
{
	// Token: 0x020002E6 RID: 742
	[Token(Token = "0x20002E6")]
	public class WorldAxisOfficeViewMediator : AbstractViewMediator<WorldAxisOfficeModel, WorldAxisOfficeEvents, WorldAxisOfficeController, WorldAxisOfficeWindow>
	{
		// Token: 0x06001195 RID: 4501 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001195")]
		[Address(RVA = "0x6392", Offset = "0x6392", VA = "0x6392")]
		public WorldAxisOfficeViewMediator(WorldAxisOfficeModel model, WorldAxisOfficeEvents events, WorldAxisOfficeController controller)
		{
		/* --- GHIDRA: <ShowHistoryTab>g__CreateHistoryMVC|26_0 ---
		void Gameplay_WorldAxis_Office_Controller_WorldAxisOfficeViewMediator___ShowHistoryTab_g__CreateHistoryMVC_26_0
		               (undefined4 param1,undefined4 param2,undefined4 param3,undefined4 param4,
		               undefined4 param5)
		
		{
		  if (DAT_ram_00a58b7f == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_WorldAxisOfficeModel__WorldAxisOfficeEvents__WorldAxisOfficeController__WorldAxisScheduleView___ctor__
		              );
		    DAT_ram_00a58b7f = '\x01';
		  }
		  Gameplay_Combat_TeamCombat_View_AbstractTeamCombatView_object___get_HideInstantElements
		            (param1,param2,param3,param4,
		             Method_MVC_AbstractViewMediator_WorldAxisOfficeModel__WorldAxisOfficeEvents__WorldAxisOfficeController__WorldAxisScheduleView___ctor__
		            );
		  return;
		}
		*/

		/* --- GHIDRA: <InitTabBar>b__18_0 ---
		void Gameplay_WorldAxis_Office_Controller_WorldAxisOfficeViewMediator___InitTabBar_b__18_0
		               (int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  int param1_01;
		  undefined4 uVar1;
		  undefined4 param3;
		  
		  if (DAT_ram_00a58b7e == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_WorldAxisOfficeModel__WorldAxisOfficeEvents__WorldAxisOfficeController__WorldAxisOfficeWindow__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&Gameplay_WorldAxis_Office_Controller_HistoryController_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_WorldAxis_Office_Events_HistoryEvents_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_WorldAxis_Office_Model_HistoryModel_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_WorldAxis_Office_Controller_HistoryViewMediator_TypeInfo)
		    ;
		    DAT_ram_00a58b7e = '\x01';
		  }
		  uVar1 = *(undefined4 *)(*(int *)(param1 + 8) + 8);
		  param1_00 = unnamed_function_1417(Gameplay_WorldAxis_Office_Model_HistoryModel_TypeInfo);
		  Gameplay_WorldAxis_Office_Model_HistoryModel__set_CurrentBattleInfo(param1_00,uVar1,param1);
		  uVar1 = unnamed_function_1417(Gameplay_WorldAxis_Office_Events_HistoryEvents_TypeInfo);
		  *(undefined4 *)(param1 + 0x38) = uVar1;
		  param1_01 = unnamed_function_1417(Gameplay_WorldAxis_Office_Controller_HistoryController_TypeInfo)
		  ;
		  if (DAT_ram_00a58b3c == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_MVC_AbstractController_HistoryModel__HistoryEvents___ctor__);
		    Mono_Security_ASN1__get_Item(&Method_Core_Net_ServiceFactory_GetService_ColossusService___);
		    Mono_Security_ASN1__get_Item(&Core_Net_ServiceFactory_TypeInfo);
		    DAT_ram_00a58b3c = '\x01';
		  }
		  Gameplay_Combat_AbstractCombat_object__object__object__object__object___set_User
		            (param1_01,param1_00,uVar1,
		             Method_MVC_AbstractController_HistoryModel__HistoryEvents___ctor__);
		  if (*(int *)(Core_Net_ServiceFactory_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Net_ServiceFactory_TypeInfo);
		  }
		  uVar1 = Core_Gameplay_Managers_LoggedManager__RequestLogin
		                    (Method_Core_Net_ServiceFactory_GetService_ColossusService___);
		  *(undefined4 *)(param1_01 + 0x18) = uVar1;
		  param3 = *(undefined4 *)(param1 + 0x38);
		  uVar1 = unnamed_function_1417(Gameplay_WorldAxis_Office_Controller_HistoryViewMediator_TypeInfo);
		  if (DAT_ram_00a58b44 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_HistoryModel__HistoryEvents__HistoryController__HistoryView___ctor__
		              );
		    DAT_ram_00a58b44 = '\x01';
		  }
		  Gameplay_Combat_TeamCombat_View_AbstractTeamCombatView_object___get_HideInstantElements
		            (uVar1,param1_00,param3,param1_01,
		             Method_MVC_AbstractViewMediator_HistoryModel__HistoryEvents__HistoryController__HistoryView___ctor__
		            );
		  *(undefined4 *)(param1 + 0x28) = uVar1;
		  return;
		}
		*/

		/* --- GHIDRA: .ctor ---
		void Gameplay_WorldAxis_Office_Controller_WorldAxisOfficeViewMediator___ctor
		               (int *param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  undefined4 uVar3;
		  
		  if (DAT_ram_00a58b71 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_WorldAxisOfficeModel__WorldAxisOfficeEvents__WorldAxisOfficeController__WorldAxisOfficeWindow__set_View__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_WorldAxis_Office_Controller_WorldAxisOfficeViewMediator_TabChangedEventHandler__
		              );
		    DAT_ram_00a58b71 = '\x01';
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
		               Method_Gameplay_WorldAxis_Office_Controller_WorldAxisOfficeViewMediator_TabChangedEventHandler__
		               ,0);
		    UI_Tabs_TabBar__add_ChangeEvent(uVar3,uVar1,0);
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
		               Method_Gameplay_WorldAxis_Office_Controller_WorldAxisOfficeViewMediator_TabChangedEventHandler__
		               ,0);
		    UI_Tabs_CategoryTabBarItemView___ctor(uVar3,uVar1,0);
		  }
		  return;
		}
		*/

		}

		// Token: 0x17000297 RID: 663
		// (set) Token: 0x06001196 RID: 4502 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000297")]
		public override WorldAxisOfficeWindow View
		{
			[Token(Token = "0x6001196")]
			[Address(RVA = "0x6393", Offset = "0x6393", VA = "0x6393", Slot = "20")]
			set
			{
			}
		}

		// Token: 0x06001197 RID: 4503 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001197")]
		[Address(RVA = "0x6394", Offset = "0x6394", VA = "0x6394")]
		private void Init()
		{
		/* --- GHIDRA: Init ---
		void Gameplay_WorldAxis_Office_Controller_WorldAxisOfficeViewMediator__Init
		               (int *param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a58b72 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_WorldAxisOfficeModel__WorldAxisOfficeEvents__WorldAxisOfficeController__WorldAxisOfficeWindow__get_Model__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_TabBarItemData_WorldAxisOfficeWindow_Tab___FindIndex__
		              );
		    Mono_Security_ASN1__get_Item
		              (&System_Predicate_TabBarItemData_WorldAxisOfficeWindow_Tab___TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_WorldAxis_Office_Controller_WorldAxisOfficeViewMediator__InitTabBar_b__18_0__
		              );
		    DAT_ram_00a58b72 = '\x01';
		  }
		  if (*(char *)((int)param1 + 0x49) == '\0') {
		    *(undefined1 *)((int)param1 + 0x49) = 1;
		    uVar1 = Gameplay_WorldAxis_Office_Model_WorldAxisOfficeModel__set_ColossusBattles
		                      (param1[2],param1);
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    UI_Tabs_TabBar__HandleSelected(*(undefined4 *)(iVar2 + 0x3c),uVar1,0);
		    param1_00 = unnamed_function_1417
		                          (System_Predicate_TabBarItemData_WorldAxisOfficeWindow_Tab___TypeInfo);
		    func_ii_7297(param1_00,param1,
		                 Method_Gameplay_WorldAxis_Office_Controller_WorldAxisOfficeViewMediator__InitTabBar_b__18_0__
		                 ,0);
		    uVar1 = System_Collections_Generic_List_UsageHint___FindAll
		                      (uVar1,param1_00,
		                       Method_System_Collections_Generic_List_TabBarItemData_WorldAxisOfficeWindow_Tab___FindIndex__
		                      );
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    Gameplay_GameEvents_Model_GameEventData__get_ContainsArtifactRewards
		              (*(undefined4 *)(iVar2 + 0x3c),uVar1,1,0);
		  }
		  return;
		}
		*/

		}

		// Token: 0x06001198 RID: 4504 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001198")]
		[Address(RVA = "0x6395", Offset = "0x6395", VA = "0x6395")]
		private void InitTabBar()
		{
		/* --- GHIDRA: InitTabBar ---
		void Gameplay_WorldAxis_Office_Controller_WorldAxisOfficeViewMediator__InitTabBar
		               (int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint *param2_00;
		  int *param1_00;
		  int iVar2;
		  
		  if (DAT_ram_00a58b73 == '\0') {
		    Mono_Security_ASN1__get_Item(&MVC_Interfaces_IHideableMediator_TypeInfo);
		    DAT_ram_00a58b73 = '\x01';
		  }
		  param1_00 = *(int **)(param1 + 0x1c);
		  iVar2 = *param1_00;
		  if (*(ushort *)(iVar2 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (MVC_Interfaces_IHideableMediator_TypeInfo == *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8))
		      {
		        param2_00 = (uint *)(iVar2 + *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x80f7cde9;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		  }
		  param2_00 = (uint *)func_ii_1080(param1_00,MVC_Interfaces_IHideableMediator_TypeInfo,0);
		code_r0x80f7cde9:
		  (**(code **)((ulonglong)*param2_00 * 4))(param1_00,param2_00[1]);
		  Gameplay_WorldAxis_Office_Controller_WorldAxisOfficeViewMediator__ScheduleChangedEventHandler
		            (param1,param2_00);
		  return;
		}
		*/

		}

		// Token: 0x06001199 RID: 4505 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001199")]
		[Address(RVA = "0x6396", Offset = "0x6396", VA = "0x6396")]
		private void TabChangedEventHandler()
		{
		/* --- GHIDRA: TabChangedEventHandler ---
		void Gameplay_WorldAxis_Office_Controller_WorldAxisOfficeViewMediator__TabChangedEventHandler
		               (int *param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  int iVar2;
		  undefined4 uVar3;
		  int *piVar4;
		  undefined4 uVar5;
		  
		  if (DAT_ram_00a58b74 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_WorldAxisOfficeModel__WorldAxisOfficeEvents__WorldAxisOfficeController__WorldAxisOfficeWindow__set_Events__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_WorldAxis_Office_Controller_WorldAxisOfficeViewMediator_ScheduleChangedEventHandler__
		              );
		    DAT_ram_00a58b74 = '\x01';
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
		               Method_Gameplay_WorldAxis_Office_Controller_WorldAxisOfficeViewMediator_ScheduleChangedEventHandler__
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
		               Method_Gameplay_WorldAxis_Office_Controller_WorldAxisOfficeViewMediator_ScheduleChangedEventHandler__
		               ,0);
		    piVar4 = (int *)UnityEngine_UI_Image__set_sprite(uVar5,uVar3,0);
		    iVar1 = System_Action_TypeInfo;
		    if (piVar4 == (int *)0x0) {
		      *(undefined4 *)(iVar2 + 0x1c) = 0;
		      return;
		    }
		    if ((System_Action_TypeInfo != *piVar4) || (*(int **)(iVar2 + 0x1c) = piVar4, *piVar4 != iVar1))
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

		// Token: 0x17000298 RID: 664
		// (set) Token: 0x0600119A RID: 4506 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000298")]
		public override WorldAxisOfficeEvents Events
		{
			[Token(Token = "0x600119A")]
			[Address(RVA = "0x6397", Offset = "0x6397", VA = "0x6397", Slot = "16")]
			set
			{
			}
		}

		// Token: 0x0600119B RID: 4507 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600119B")]
		[Address(RVA = "0x6398", Offset = "0x6398", VA = "0x6398")]
		private void ScheduleChangedEventHandler()
		{
		/* --- GHIDRA: ScheduleChangedEventHandler ---
		void Gameplay_WorldAxis_Office_Controller_WorldAxisOfficeViewMediator__ScheduleChangedEventHandler
		               (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  int param1_00;
		  
		  if (DAT_ram_00a58b75 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_WorldAxisOfficeWindow_Tab__Func_IHideableMediator___get_Item__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_Tabs_TabBarItemData_WorldAxisOfficeWindow_Tab__get_Data__);
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_Tabs_TabBar_GetSelectedItem_WorldAxisOfficeWindow_Tab___);
		    DAT_ram_00a58b75 = '\x01';
		  }
		  param1_00 = param1[6];
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar1 = UI_Tabs_TabBar__GetSelectedItem_UInt32Enum_
		                    (*(undefined4 *)(iVar1 + 0x3c),
		                     Method_UI_Tabs_TabBar_GetSelectedItem_WorldAxisOfficeWindow_Tab___);
		  iVar1 = GAFInternal_Reader_GAFReader__OpenTag
		                    (param1_00,*(undefined4 *)(iVar1 + 0x20),
		                     Method_System_Collections_Generic_Dictionary_WorldAxisOfficeWindow_Tab__Func_IHideableMediator___get_Item__
		                    );
		  iVar1 = (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		                    (*(undefined4 *)(iVar1 + 0x20),*(undefined4 *)(iVar1 + 0x14));
		  param1[7] = iVar1;
		  return;
		}
		*/

		}

		// Token: 0x0600119C RID: 4508 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600119C")]
		[Address(RVA = "0x6399", Offset = "0x6399", VA = "0x6399")]
		private void AssignNewMediator()
		{
		/* --- GHIDRA: AssignNewMediator ---
		int Gameplay_WorldAxis_Office_Controller_WorldAxisOfficeViewMediator__AssignNewMediator
		              (int *param1,undefined4 param2)
		
		{
		  undefined4 param4;
		  undefined4 uVar1;
		  int iVar2;
		  int *piVar3;
		  int iVar4;
		  
		  if (DAT_ram_00a58b76 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_WorldAxisOfficeModel__WorldAxisOfficeEvents__WorldAxisOfficeController__WorldAxisOfficeWindow__get_Model__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_WorldAxis_Office_Controller_FrontPageViewMediator_TypeInfo);
		    DAT_ram_00a58b76 = '\x01';
		  }
		  piVar3 = (int *)param1[8];
		  if (piVar3 == (int *)0x0) {
		    iVar2 = param1[2];
		    uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    param4 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                       (param1,*(undefined4 *)(*param1 + 0x14c));
		    piVar3 = (int *)unnamed_function_1417
		                              (Gameplay_WorldAxis_Office_Controller_FrontPageViewMediator_TypeInfo);
		    if (DAT_ram_00a58b35 == '\0') {
		      Mono_Security_ASN1__get_Item
		                (&
		                 Method_MVC_AbstractViewMediator_WorldAxisOfficeModel__WorldAxisOfficeEvents__WorldAxisOfficeController__FrontPageView___ctor__
		                );
		      DAT_ram_00a58b35 = '\x01';
		    }
		    Gameplay_Combat_TeamCombat_View_AbstractTeamCombatView_object___get_HideInstantElements
		              (piVar3,iVar2,uVar1,param4,
		               Method_MVC_AbstractViewMediator_WorldAxisOfficeModel__WorldAxisOfficeEvents__WorldAxisOfficeController__FrontPageView___ctor__
		              );
		    param1[8] = (int)piVar3;
		  }
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x13c));
		  (**(code **)((ulonglong)*(uint *)(*piVar3 + 0x140) * 4))
		            (piVar3,uVar1,*(undefined4 *)(*piVar3 + 0x144));
		  piVar3 = (int *)param1[8];
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar4 = *piVar3;
		  (**(code **)((ulonglong)*(uint *)(iVar4 + 0x160) * 4))
		            (piVar3,*(undefined4 *)(iVar2 + 0x40),*(undefined4 *)(iVar4 + 0x164));
		  return param1[8];
		}
		*/

		}

		// Token: 0x0600119D RID: 4509 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600119D")]
		[Address(RVA = "0x639A", Offset = "0x639A", VA = "0x639A")]
		private IHideableMediator ShowFrontPageTab()
		{
		/* --- GHIDRA: ShowFrontPageTab ---
		int Gameplay_WorldAxis_Office_Controller_WorldAxisOfficeViewMediator__ShowFrontPageTab
		              (int *param1,undefined4 param2)
		
		{
		  undefined4 param4;
		  undefined4 uVar1;
		  int iVar2;
		  int *piVar3;
		  int iVar4;
		  
		  if (DAT_ram_00a58b77 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_WorldAxisOfficeModel__WorldAxisOfficeEvents__WorldAxisOfficeController__WorldAxisOfficeWindow__get_Model__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_WorldAxis_Office_Controller_WorldAxisScheduleViewMediator_TypeInfo);
		    DAT_ram_00a58b77 = '\x01';
		  }
		  piVar3 = (int *)param1[9];
		  if (piVar3 == (int *)0x0) {
		    iVar2 = param1[2];
		    uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    param4 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                       (param1,*(undefined4 *)(*param1 + 0x14c));
		    piVar3 = (int *)unnamed_function_1417
		                              (
		                              Gameplay_WorldAxis_Office_Controller_WorldAxisScheduleViewMediator_TypeInfo
		                              );
		    if (DAT_ram_00a58b7f == '\0') {
		      Mono_Security_ASN1__get_Item
		                (&
		                 Method_MVC_AbstractViewMediator_WorldAxisOfficeModel__WorldAxisOfficeEvents__WorldAxisOfficeController__WorldAxisScheduleView___ctor__
		                );
		      DAT_ram_00a58b7f = '\x01';
		    }
		    Gameplay_Combat_TeamCombat_View_AbstractTeamCombatView_object___get_HideInstantElements
		              (piVar3,iVar2,uVar1,param4,
		               Method_MVC_AbstractViewMediator_WorldAxisOfficeModel__WorldAxisOfficeEvents__WorldAxisOfficeController__WorldAxisScheduleView___ctor__
		              );
		    param1[9] = (int)piVar3;
		  }
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x13c));
		  (**(code **)((ulonglong)*(uint *)(*piVar3 + 0x140) * 4))
		            (piVar3,uVar1,*(undefined4 *)(*piVar3 + 0x144));
		  piVar3 = (int *)param1[9];
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar4 = *piVar3;
		  (**(code **)((ulonglong)*(uint *)(iVar4 + 0x160) * 4))
		            (piVar3,*(undefined4 *)(iVar2 + 0x44),*(undefined4 *)(iVar4 + 0x164));
		  return param1[9];
		}
		*/

			return null;
		}

		// Token: 0x0600119E RID: 4510 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600119E")]
		[Address(RVA = "0x639B", Offset = "0x639B", VA = "0x639B")]
		private IHideableMediator ShowScheduleTab()
		{
		/* --- GHIDRA: ShowScheduleTab ---
		int Gameplay_WorldAxis_Office_Controller_WorldAxisOfficeViewMediator__ShowScheduleTab
		              (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 param1_00;
		  int *piVar2;
		  int iVar3;
		  
		  piVar2 = (int *)param1[10];
		  if (piVar2 == (int *)0x0) {
		    Gameplay_WorldAxis_Office_Controller_WorldAxisOfficeViewMediator___InitTabBar_b__18_0
		              (param1,param1);
		  }
		  else {
		    (**(code **)((ulonglong)*(uint *)(*piVar2 + 0x140) * 4))
		              (piVar2,param1[0xe],*(undefined4 *)(*piVar2 + 0x144));
		  }
		  piVar2 = (int *)param1[10];
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar3 = *piVar2;
		  (**(code **)((ulonglong)*(uint *)(iVar3 + 0x160) * 4))
		            (piVar2,*(undefined4 *)(iVar1 + 0x48),*(undefined4 *)(iVar3 + 0x164));
		  iVar1 = *(int *)param1[10];
		  param1_00 = (**(code **)((ulonglong)*(uint *)(iVar1 + 0x148) * 4))
		                        ((int *)param1[10],*(undefined4 *)(iVar1 + 0x14c));
		  MVC_AbstractController__Dispose(param1_00,0);
		  return param1[10];
		}
		*/

			return null;
		}

		// Token: 0x0600119F RID: 4511 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600119F")]
		[Address(RVA = "0x639C", Offset = "0x639C", VA = "0x639C")]
		private IHideableMediator ShowHistoryTab()
		{
		/* --- GHIDRA: ShowHistoryTab ---
		int Gameplay_WorldAxis_Office_Controller_WorldAxisOfficeViewMediator__ShowHistoryTab
		              (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 param1_00;
		  int *piVar2;
		  int param3;
		  int param2_00;
		  
		  if (DAT_ram_00a58b78 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_WorldAxis_Office_Controller_ClanRatingsViewMediator_TypeInfo);
		    DAT_ram_00a58b78 = '\x01';
		  }
		  piVar2 = (int *)param1[0xb];
		  if (piVar2 == (int *)0x0) {
		    Gameplay_WorldAxis_Office_Controller_WorldAxisOfficeViewMediator__ShowRewardsTab(param1,param1);
		    iVar1 = param1[0x11];
		    param3 = param1[0x10];
		    param2_00 = param1[0xf];
		    piVar2 = (int *)unnamed_function_1417
		                              (Gameplay_WorldAxis_Office_Controller_ClanRatingsViewMediator_TypeInfo
		                              );
		    if (DAT_ram_00a58b29 == '\0') {
		      Mono_Security_ASN1__get_Item
		                (&
		                 Method_MVC_AbstractViewMediator_RatingsModel__RatingsEvents__RatingsController__ClanRatingsView___ctor__
		                );
		      DAT_ram_00a58b29 = '\x01';
		    }
		    Gameplay_Combat_TeamCombat_View_AbstractTeamCombatView_object___get_HideInstantElements
		              (piVar2,param2_00,param3,iVar1,
		               Method_MVC_AbstractViewMediator_RatingsModel__RatingsEvents__RatingsController__ClanRatingsView___ctor__
		              );
		    param1[0xb] = (int)piVar2;
		  }
		  else {
		    (**(code **)((ulonglong)*(uint *)(*piVar2 + 0x140) * 4))
		              (piVar2,param1[0x10],*(undefined4 *)(*piVar2 + 0x144));
		    piVar2 = (int *)param1[0xb];
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  (**(code **)((ulonglong)*(uint *)(*piVar2 + 0x160) * 4))
		            (piVar2,*(undefined4 *)(iVar1 + 0x4c),*(undefined4 *)(*piVar2 + 0x164));
		  iVar1 = *(int *)param1[0xb];
		  param1_00 = (**(code **)((ulonglong)*(uint *)(iVar1 + 0x148) * 4))
		                        ((int *)param1[0xb],*(undefined4 *)(iVar1 + 0x14c));
		  MVC_AbstractController__Dispose(param1_00,0);
		  return param1[0xb];
		}
		*/

			return null;
		}

		// Token: 0x060011A0 RID: 4512 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60011A0")]
		[Address(RVA = "0x639D", Offset = "0x639D", VA = "0x639D")]
		private IHideableMediator ShowClanRatingsTab()
		{
		/* --- GHIDRA: ShowClanRatingsTab ---
		int Gameplay_WorldAxis_Office_Controller_WorldAxisOfficeViewMediator__ShowClanRatingsTab
		              (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 param1_00;
		  int *piVar2;
		  int param3;
		  int param2_00;
		  
		  if (DAT_ram_00a58b79 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_WorldAxis_Office_Controller_UserRatingsViewMediator_TypeInfo);
		    DAT_ram_00a58b79 = '\x01';
		  }
		  piVar2 = (int *)param1[0xc];
		  if (piVar2 == (int *)0x0) {
		    Gameplay_WorldAxis_Office_Controller_WorldAxisOfficeViewMediator__ShowRewardsTab(param1,param1);
		    iVar1 = param1[0x11];
		    param3 = param1[0x10];
		    param2_00 = param1[0xf];
		    piVar2 = (int *)unnamed_function_1417
		                              (Gameplay_WorldAxis_Office_Controller_UserRatingsViewMediator_TypeInfo
		                              );
		    if (DAT_ram_00a58b5e == '\0') {
		      Mono_Security_ASN1__get_Item
		                (&
		                 Method_MVC_AbstractViewMediator_RatingsModel__RatingsEvents__RatingsController__UserRatingsView___ctor__
		                );
		      DAT_ram_00a58b5e = '\x01';
		    }
		    Gameplay_Combat_TeamCombat_View_AbstractTeamCombatView_object___get_HideInstantElements
		              (piVar2,param2_00,param3,iVar1,
		               Method_MVC_AbstractViewMediator_RatingsModel__RatingsEvents__RatingsController__UserRatingsView___ctor__
		              );
		    param1[0xc] = (int)piVar2;
		  }
		  else {
		    (**(code **)((ulonglong)*(uint *)(*piVar2 + 0x140) * 4))
		              (piVar2,param1[0x10],*(undefined4 *)(*piVar2 + 0x144));
		    piVar2 = (int *)param1[0xc];
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  (**(code **)((ulonglong)*(uint *)(*piVar2 + 0x160) * 4))
		            (piVar2,*(undefined4 *)(iVar1 + 0x50),*(undefined4 *)(*piVar2 + 0x164));
		  iVar1 = *(int *)param1[0xc];
		  param1_00 = (**(code **)((ulonglong)*(uint *)(iVar1 + 0x148) * 4))
		                        ((int *)param1[0xc],*(undefined4 *)(iVar1 + 0x14c));
		  MVC_AbstractController__Dispose(param1_00,0);
		  return param1[0xc];
		}
		*/

			return null;
		}

		// Token: 0x060011A1 RID: 4513 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60011A1")]
		[Address(RVA = "0x639E", Offset = "0x639E", VA = "0x639E")]
		private IHideableMediator ShowUserRatingsTab()
		{
		/* --- GHIDRA: ShowUserRatingsTab ---
		int Gameplay_WorldAxis_Office_Controller_WorldAxisOfficeViewMediator__ShowUserRatingsTab
		              (int *param1,undefined4 param2)
		
		{
		  undefined4 param4;
		  undefined4 uVar1;
		  int iVar2;
		  int *piVar3;
		  undefined4 uVar4;
		  int iVar5;
		  
		  if (DAT_ram_00a58b7a == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_WorldAxisOfficeModel__WorldAxisOfficeEvents__WorldAxisOfficeController__WorldAxisOfficeWindow__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&Gameplay_WorldAxis_Office_Model_SeasonRewardsModel_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_WorldAxis_Office_Controller_SeasonRewardsViewMediator_TypeInfo);
		    DAT_ram_00a58b7a = '\x01';
		  }
		  piVar3 = (int *)param1[0xd];
		  if (piVar3 == (int *)0x0) {
		    uVar4 = *(undefined4 *)(param1[2] + 8);
		    uVar1 = unnamed_function_1417(Gameplay_WorldAxis_Office_Model_SeasonRewardsModel_TypeInfo);
		    Gameplay_WorldAxis_Office_Model_SeasonRewardsModel__get_Dict(uVar1,uVar4,param1);
		    uVar4 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    param4 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                       (param1,*(undefined4 *)(*param1 + 0x14c));
		    piVar3 = (int *)unnamed_function_1417
		                              (
		                              Gameplay_WorldAxis_Office_Controller_SeasonRewardsViewMediator_TypeInfo
		                              );
		    if (DAT_ram_00a58b57 == '\0') {
		      Mono_Security_ASN1__get_Item
		                (&
		                 Method_MVC_AbstractViewMediator_SeasonRewardsModel__WorldAxisOfficeEvents__WorldAxisOfficeController__SeasonRewardsView___ctor__
		                );
		      Mono_Security_ASN1__get_Item
		                (&Gameplay_VortexRating_View_GreatPrizesTab_PrizeListElement___TypeInfo);
		      DAT_ram_00a58b57 = '\x01';
		    }
		    iVar2 = Mono_Security_ASN1Convert__ToOid
		                      (Gameplay_VortexRating_View_GreatPrizesTab_PrizeListElement___TypeInfo,0);
		    piVar3[7] = iVar2;
		    Gameplay_Combat_TeamCombat_View_AbstractTeamCombatView_object___get_HideInstantElements
		              (piVar3,uVar1,uVar4,param4,
		               Method_MVC_AbstractViewMediator_SeasonRewardsModel__WorldAxisOfficeEvents__WorldAxisOfficeController__SeasonRewardsView___ctor__
		              );
		    param1[0xd] = (int)piVar3;
		  }
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x13c));
		  (**(code **)((ulonglong)*(uint *)(*piVar3 + 0x140) * 4))
		            (piVar3,uVar1,*(undefined4 *)(*piVar3 + 0x144));
		  piVar3 = (int *)param1[0xd];
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar5 = *piVar3;
		  (**(code **)((ulonglong)*(uint *)(iVar5 + 0x160) * 4))
		            (piVar3,*(undefined4 *)(iVar2 + 0x54),*(undefined4 *)(iVar5 + 0x164));
		  return param1[0xd];
		}
		*/

			return null;
		}

		// Token: 0x060011A2 RID: 4514 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60011A2")]
		[Address(RVA = "0x639F", Offset = "0x639F", VA = "0x639F")]
		private IHideableMediator ShowRewardsTab()
		{
		/* --- GHIDRA: ShowRewardsTab ---
		void Gameplay_WorldAxis_Office_Controller_WorldAxisOfficeViewMediator__ShowRewardsTab
		               (int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  undefined4 uVar2;
		  int iVar3;
		  undefined4 uVar4;
		  
		  if (DAT_ram_00a58b7b == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_WorldAxisOfficeModel__WorldAxisOfficeEvents__WorldAxisOfficeController__WorldAxisOfficeWindow__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&Gameplay_WorldAxis_Office_Controller_RatingsController_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_WorldAxis_Office_Events_RatingsEvents_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_WorldAxis_Office_Model_RatingsModel_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Core_Net_ServiceFactory_GetService_ColossusService___);
		    Mono_Security_ASN1__get_Item(&Core_Net_ServiceFactory_TypeInfo);
		    DAT_ram_00a58b7b = '\x01';
		  }
		  if (*(char *)(param1 + 0x48) == '\0') {
		    *(undefined1 *)(param1 + 0x48) = 1;
		    iVar3 = *(int *)(param1 + 8);
		    uVar4 = *(undefined4 *)(iVar3 + 8);
		    uVar1 = unnamed_function_1417(Gameplay_WorldAxis_Office_Model_RatingsModel_TypeInfo);
		    Gameplay_WorldAxis_Office_Model_RatingsModel__get_Dict(uVar1,uVar4,iVar3,param1);
		    *(undefined4 *)(param1 + 0x3c) = uVar1;
		    uVar1 = unnamed_function_1417(Gameplay_WorldAxis_Office_Events_RatingsEvents_TypeInfo);
		    *(undefined4 *)(param1 + 0x40) = uVar1;
		    uVar4 = *(undefined4 *)(param1 + 0x3c);
		    if (*(int *)(Core_Net_ServiceFactory_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Net_ServiceFactory_TypeInfo);
		    }
		    uVar2 = Core_Gameplay_Managers_LoggedManager__RequestLogin
		                      (Method_Core_Net_ServiceFactory_GetService_ColossusService___);
		    iVar3 = unnamed_function_1417(Gameplay_WorldAxis_Office_Controller_RatingsController_TypeInfo);
		    if (DAT_ram_00a58b52 == '\0') {
		      Mono_Security_ASN1__get_Item
		                (&Method_MVC_AbstractController_RatingsModel__RatingsEvents___ctor__);
		      DAT_ram_00a58b52 = '\x01';
		    }
		    Gameplay_Combat_AbstractCombat_object__object__object__object__object___set_User
		              (iVar3,uVar4,uVar1,Method_MVC_AbstractController_RatingsModel__RatingsEvents___ctor__)
		    ;
		    *(undefined4 *)(iVar3 + 0x18) = uVar2;
		    *(int *)(param1 + 0x44) = iVar3;
		    MVC_AbstractController__Dispose(iVar3,0);
		  }
		  return;
		}
		*/

			return null;
		}

		// Token: 0x060011A3 RID: 4515 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60011A3")]
		[Address(RVA = "0x63A0", Offset = "0x63A0", VA = "0x63A0")]
		private void CreateRatingsMVC()
		{
		/* --- GHIDRA: CreateRatingsMVC ---
		void Gameplay_WorldAxis_Office_Controller_WorldAxisOfficeViewMediator__CreateRatingsMVC
		               (int param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  if (*(char *)(param1 + 0x48) != '\0') {
		    *(undefined1 *)(param1 + 0x48) = 0;
		    MVC_AbstractController__Run(*(undefined4 *)(param1 + 0x44),0);
		    iVar1 = **(int **)(param1 + 0x44);
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xe8) * 4))
		              (*(int **)(param1 + 0x44),*(undefined4 *)(iVar1 + 0xec));
		    iVar1 = **(int **)(param1 + 0x3c);
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xe8) * 4))
		              (*(int **)(param1 + 0x3c),*(undefined4 *)(iVar1 + 0xec));
		  }
		  return;
		}
		*/

		}

		// Token: 0x060011A4 RID: 4516 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60011A4")]
		[Address(RVA = "0x63A1", Offset = "0x63A1", VA = "0x63A1")]
		private void DestroyRatingsMVC()
		{
		/* --- GHIDRA: DestroyRatingsMVC ---
		void Gameplay_WorldAxis_Office_Controller_WorldAxisOfficeViewMediator__DestroyRatingsMVC
		               (int param1,undefined4 param2)
		
		{
		  int *piVar1;
		  int *piVar2;
		  int iVar3;
		  
		  if (DAT_ram_00a58b7c == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_WorldAxisOfficeModel__WorldAxisOfficeEvents__WorldAxisOfficeController__WorldAxisOfficeWindow__Dispose__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_SeasonRewardsModel__WorldAxisOfficeEvents__WorldAxisOfficeController__SeasonRewardsView__get_Model__
		              );
		    DAT_ram_00a58b7c = '\x01';
		  }
		  piVar2 = *(int **)(param1 + 0x20);
		  if (piVar2 != (int *)0x0) {
		    (**(code **)((ulonglong)*(uint *)(*piVar2 + 0x130) * 4))
		              (piVar2,*(undefined4 *)(*piVar2 + 0x134));
		  }
		  piVar2 = *(int **)(param1 + 0x24);
		  if (piVar2 != (int *)0x0) {
		    (**(code **)((ulonglong)*(uint *)(*piVar2 + 0x130) * 4))
		              (piVar2,*(undefined4 *)(*piVar2 + 0x134));
		  }
		  piVar2 = *(int **)(param1 + 0x2c);
		  if (piVar2 != (int *)0x0) {
		    (**(code **)((ulonglong)*(uint *)(*piVar2 + 0x130) * 4))
		              (piVar2,*(undefined4 *)(*piVar2 + 0x134));
		  }
		  piVar2 = *(int **)(param1 + 0x30);
		  if (piVar2 != (int *)0x0) {
		    (**(code **)((ulonglong)*(uint *)(*piVar2 + 0x130) * 4))
		              (piVar2,*(undefined4 *)(*piVar2 + 0x134));
		  }
		  piVar2 = *(int **)(param1 + 0x28);
		  if (piVar2 != (int *)0x0) {
		    piVar2 = (int *)(**(code **)((ulonglong)*(uint *)(*piVar2 + 0x148) * 4))
		                              (piVar2,*(undefined4 *)(*piVar2 + 0x14c));
		    piVar1 = (int *)(**(code **)((ulonglong)*(uint *)(*piVar2 + 0x100) * 4))
		                              (piVar2,*(undefined4 *)(*piVar2 + 0x104));
		    MVC_AbstractController__Run(piVar2,0);
		    iVar3 = **(int **)(param1 + 0x28);
		    (**(code **)((ulonglong)*(uint *)(iVar3 + 0x130) * 4))
		              (*(int **)(param1 + 0x28),*(undefined4 *)(iVar3 + 0x134));
		    (**(code **)((ulonglong)*(uint *)(*piVar2 + 0xe8) * 4))(piVar2,*(undefined4 *)(*piVar2 + 0xec));
		    (**(code **)((ulonglong)*(uint *)(*piVar1 + 0xe8) * 4))(piVar1,*(undefined4 *)(*piVar1 + 0xec));
		  }
		  if (*(int *)(param1 + 0x34) != 0) {
		    piVar2 = *(int **)(*(int *)(param1 + 0x34) + 8);
		    iVar3 = *piVar2;
		    (**(code **)((ulonglong)*(uint *)(iVar3 + 0xe8) * 4))(piVar2,*(undefined4 *)(iVar3 + 0xec));
		    iVar3 = **(int **)(param1 + 0x34);
		    (**(code **)((ulonglong)*(uint *)(iVar3 + 0x130) * 4))
		              (*(int **)(param1 + 0x34),*(undefined4 *)(iVar3 + 0x134));
		  }
		  if (*(char *)(param1 + 0x48) != '\0') {
		    *(undefined1 *)(param1 + 0x48) = 0;
		    MVC_AbstractController__Run(*(undefined4 *)(param1 + 0x44),0);
		    iVar3 = **(int **)(param1 + 0x44);
		    (**(code **)((ulonglong)*(uint *)(iVar3 + 0xe8) * 4))
		              (*(int **)(param1 + 0x44),*(undefined4 *)(iVar3 + 0xec));
		    iVar3 = **(int **)(param1 + 0x3c);
		    (**(code **)((ulonglong)*(uint *)(iVar3 + 0xe8) * 4))
		              (*(int **)(param1 + 0x3c),*(undefined4 *)(iVar3 + 0xec));
		  }
		  MVC_AbstractViewMediator_object__object__object__object___Core_MVC_Interfaces_IViewMediator_set_View
		            (param1,
		             Method_MVC_AbstractViewMediator_WorldAxisOfficeModel__WorldAxisOfficeEvents__WorldAxisOfficeController__WorldAxisOfficeWindow__Dispose__
		            );
		  return;
		}
		*/

		}

		// Token: 0x060011A5 RID: 4517 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60011A5")]
		[Address(RVA = "0x63A2", Offset = "0x63A2", VA = "0x63A2", Slot = "14")]
		public override void Dispose()
		{
		/* --- GHIDRA: Dispose ---
		uint Gameplay_WorldAxis_Office_Controller_WorldAxisOfficeViewMediator__Dispose
		               (int *param1,int param2,undefined4 param3)
		
		{
		  undefined4 param1_00;
		  int iVar1;
		  int iVar2;
		  
		  if (DAT_ram_00a58b7d == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_BaseWindow_WorldAxisOfficeWindow_WorldAxisOfficeWindowArgs__get_WindowArgs__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_Tabs_TabBarItemData_WorldAxisOfficeWindow_Tab__get_Data__);
		    DAT_ram_00a58b7d = '\x01';
		  }
		  iVar2 = *(int *)(param2 + 0x20);
		  param1_00 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar1 = func_ii_8093(param1_00,
		                       Method_UI_Windows_BaseWindow_WorldAxisOfficeWindow_WorldAxisOfficeWindowArgs__get_WindowArgs__
		                      );
		  return (uint)(iVar2 == *(int *)(iVar1 + 0x18));
		}
		*/

		}

		// Token: 0x060011A7 RID: 4519 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60011A7")]
		[Address(RVA = "0x63A4", Offset = "0x63A4", VA = "0x63A4")]
		[CompilerGenerated]
		private void <ShowHistoryTab>g__CreateHistoryMVC|26_0()
		{
		}

		// Token: 0x04000906 RID: 2310
		[Token(Token = "0x4000906")]
		[FieldOffset(Offset = "0x18")]
		private readonly Dictionary<WorldAxisOfficeWindow.Tab, Func<IHideableMediator>> _tabsOpenersById;

		// Token: 0x04000907 RID: 2311
		[Token(Token = "0x4000907")]
		[FieldOffset(Offset = "0x1C")]
		private IHideableMediator _currentMediator;

		// Token: 0x04000908 RID: 2312
		[Token(Token = "0x4000908")]
		[FieldOffset(Offset = "0x20")]
		private FrontPageViewMediator _frontPageViewMediator;

		// Token: 0x04000909 RID: 2313
		[Token(Token = "0x4000909")]
		[FieldOffset(Offset = "0x24")]
		private WorldAxisScheduleViewMediator _worldAxisScheduleViewMediator;

		// Token: 0x0400090A RID: 2314
		[Token(Token = "0x400090A")]
		[FieldOffset(Offset = "0x28")]
		private HistoryViewMediator _historyViewMediator;

		// Token: 0x0400090B RID: 2315
		[Token(Token = "0x400090B")]
		[FieldOffset(Offset = "0x2C")]
		private ClanRatingsViewMediator _clanRatingsViewMediator;

		// Token: 0x0400090C RID: 2316
		[Token(Token = "0x400090C")]
		[FieldOffset(Offset = "0x30")]
		private UserRatingsViewMediator _userRatingsViewMediator;

		// Token: 0x0400090D RID: 2317
		[Token(Token = "0x400090D")]
		[FieldOffset(Offset = "0x34")]
		private SeasonRewardsViewMediator _seasonRewardsViewMediator;

		// Token: 0x0400090E RID: 2318
		[Token(Token = "0x400090E")]
		[FieldOffset(Offset = "0x38")]
		private HistoryEvents _historyEvents;

		// Token: 0x0400090F RID: 2319
		[Token(Token = "0x400090F")]
		[FieldOffset(Offset = "0x3C")]
		private RatingsModel _ratingsModel;

		// Token: 0x04000910 RID: 2320
		[Token(Token = "0x4000910")]
		[FieldOffset(Offset = "0x40")]
		private RatingsEvents _ratingsEvents;

		// Token: 0x04000911 RID: 2321
		[Token(Token = "0x4000911")]
		[FieldOffset(Offset = "0x44")]
		private RatingsController _ratingsController;

		// Token: 0x04000912 RID: 2322
		[Token(Token = "0x4000912")]
		[FieldOffset(Offset = "0x48")]
		private bool _ratingsMVCCreated;

		// Token: 0x04000913 RID: 2323
		[Token(Token = "0x4000913")]
		[FieldOffset(Offset = "0x49")]
		private bool _tabBarInitialized;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_Events ---
		void Gameplay_WorldAxis_Office_Controller_WorldAxisOfficeViewMediator__set_Events
		               (undefined4 param1,undefined4 param2)
		
		{
		  Gameplay_WorldAxis_Office_Controller_WorldAxisOfficeViewMediator__Init(param1,param1);
		  Gameplay_WorldAxis_Office_Controller_WorldAxisOfficeViewMediator__ScheduleChangedEventHandler
		            (param1,param1);
		  return;
		}
		*/

}
