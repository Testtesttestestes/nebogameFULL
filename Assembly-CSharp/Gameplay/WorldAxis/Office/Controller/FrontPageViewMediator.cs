using System;
using Gameplay.WorldAxis.Office.Events;
using Gameplay.WorldAxis.Office.Model;
using Gameplay.WorldAxis.Office.View.FrontPageTab;
using Il2CppDummyDll;
using MVC;
using MVC.Interfaces;

namespace Gameplay.WorldAxis.Office.Controller
{
	// Token: 0x020002DD RID: 733
	[Token(Token = "0x20002DD")]
	public class FrontPageViewMediator : AbstractViewMediator<WorldAxisOfficeModel, WorldAxisOfficeEvents, WorldAxisOfficeController, FrontPageView>, IHideableMediator
	{
		// Token: 0x06001143 RID: 4419 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001143")]
		[Address(RVA = "0x6340", Offset = "0x6340", VA = "0x6340")]
		public FrontPageViewMediator(WorldAxisOfficeModel model, WorldAxisOfficeEvents events, WorldAxisOfficeController controller)
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_WorldAxis_Office_Controller_FrontPageViewMediator___ctor
		               (int *param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  undefined4 uVar3;
		  
		  if (DAT_ram_00a58b36 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_WorldAxisOfficeModel__WorldAxisOfficeEvents__WorldAxisOfficeController__FrontPageView__set_View__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_WorldAxis_Office_Controller_FrontPageViewMediator_CreateClanButtonClickedEventHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_WorldAxis_Office_Controller_FrontPageViewMediator_ToWorldAxisButtonClickedEventHandler__
		              );
		    Mono_Security_ASN1__get_Item(&UnityEngine_Events_UnityAction_TypeInfo);
		    DAT_ram_00a58b36 = '\x01';
		  }
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar2 = Cysharp_Threading_Tasks_CancellationTokenExtensions___cctor(uVar1,0);
		  if (iVar2 != 0) {
		    uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar1 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                      (uVar1,0);
		    Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		              (uVar1,0,0);
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar3 = *(undefined4 *)(*(int *)(iVar2 + 0x18) + 0xb4);
		    uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		    Utils_ObjectUtils__IsNotNull
		              (uVar1,param1,
		               Method_Gameplay_WorldAxis_Office_Controller_FrontPageViewMediator_CreateClanButtonClickedEventHandler__
		               ,0);
		    UnityEngine_Events_UnityAction___ctor(uVar3,uVar1,0);
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar3 = *(undefined4 *)(*(int *)(iVar2 + 0x1c) + 0xb4);
		    uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		    Utils_ObjectUtils__IsNotNull
		              (uVar1,param1,
		               Method_Gameplay_WorldAxis_Office_Controller_FrontPageViewMediator_ToWorldAxisButtonClickedEventHandler__
		               ,0);
		    UnityEngine_Events_UnityAction___ctor(uVar3,uVar1,0);
		  }
		  param1[5] = param2;
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar2 = Cysharp_Threading_Tasks_CancellationTokenExtensions___cctor(uVar1,0);
		  if (iVar2 != 0) {
		    uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar1 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                      (uVar1,0);
		    Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		              (uVar1,1,0);
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar3 = *(undefined4 *)(*(int *)(iVar2 + 0x18) + 0xb4);
		    uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		    Utils_ObjectUtils__IsNotNull
		              (uVar1,param1,
		               Method_Gameplay_WorldAxis_Office_Controller_FrontPageViewMediator_CreateClanButtonClickedEventHandler__
		               ,0);
		    Gameplay_Boss_View_CaptainTab_BossInfoView__add_AttackButtonClickEvent(uVar3,uVar1,0);
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar3 = *(undefined4 *)(*(int *)(iVar2 + 0x1c) + 0xb4);
		    uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		    Utils_ObjectUtils__IsNotNull
		              (uVar1,param1,
		               Method_Gameplay_WorldAxis_Office_Controller_FrontPageViewMediator_ToWorldAxisButtonClickedEventHandler__
		               ,0);
		    Gameplay_Boss_View_CaptainTab_BossInfoView__add_AttackButtonClickEvent(uVar3,uVar1,0);
		    Gameplay_WorldAxis_Office_Controller_FrontPageViewMediator__set_View(param1,param1);
		  }
		  return;
		}
		*/

		}

		// Token: 0x1700028E RID: 654
		// (set) Token: 0x06001144 RID: 4420 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700028E")]
		public override FrontPageView View
		{
			[Token(Token = "0x6001144")]
			[Address(RVA = "0x6341", Offset = "0x6341", VA = "0x6341", Slot = "20")]
			set
			{
			}
		}

		// Token: 0x06001145 RID: 4421 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001145")]
		[Address(RVA = "0x6342", Offset = "0x6342", VA = "0x6342")]
		private void Init()
		{
		}

		// Token: 0x06001146 RID: 4422 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001146")]
		[Address(RVA = "0x6343", Offset = "0x6343", VA = "0x6343")]
		private void HandleClanButton()
		{
		/* --- GHIDRA: HandleClanButton ---
		void Gameplay_WorldAxis_Office_Controller_FrontPageViewMediator__HandleClanButton
		               (undefined4 param1,undefined4 param2)
		
		{
		  uint uVar1;
		  undefined4 uVar2;
		  uint *puVar3;
		  int *param1_00;
		  int iVar4;
		  
		  if (DAT_ram_00a58b39 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a58b39 = '\x01';
		  }
		  uVar2 = System_Uri___ctor(0);
		  uVar2 = System_Globalization_TimeSpanFormat_FormatLiterals__get_Start(uVar2,0);
		  UI_Windows_PopupController__Close(uVar2,2,0);
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
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0x110);
		        goto code_r0x80f79729;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(param1_00,Core_Gameplay_IGame_TypeInfo,10);
		code_r0x80f79729:
		  uVar2 = (**(code **)((ulonglong)*puVar3 * 4))(param1_00,puVar3[1]);
		  Core_Gameplay_Managers_WorldManager__GoToClanIsleById(uVar2,0);
		  return;
		}
		*/

		}

		// Token: 0x06001147 RID: 4423 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001147")]
		[Address(RVA = "0x6344", Offset = "0x6344", VA = "0x6344")]
		private void ToWorldAxisButtonClickedEventHandler()
		{
		/* --- GHIDRA: ToWorldAxisButtonClickedEventHandler ---
		void Gameplay_WorldAxis_Office_Controller_FrontPageViewMediator__ToWorldAxisButtonClickedEventHandler
		               (undefined4 param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 param1_00;
		  int *param1_01;
		  int iVar3;
		  
		  if (DAT_ram_00a58b3a == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a58b3a = '\x01';
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
		        goto code_r0x80f797fd;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_01,Core_Gameplay_IGame_TypeInfo,0x2e);
		code_r0x80f797fd:
		  param1_00 = (**(code **)((ulonglong)*puVar2 * 4))(param1_01,puVar2[1]);
		  Core_Gameplay_Managers_ClansManager__HandleControllerInitEvent(param1_00,0);
		  return;
		}
		*/

		}

		// Token: 0x06001148 RID: 4424 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001148")]
		[Address(RVA = "0x6345", Offset = "0x6345", VA = "0x6345")]
		private void CreateClanButtonClickedEventHandler()
		{
		/* --- GHIDRA: CreateClanButtonClickedEventHandler ---
		void Gameplay_WorldAxis_Office_Controller_FrontPageViewMediator__CreateClanButtonClickedEventHandler
		               (int *param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  int iVar2;
		  undefined4 uVar3;
		  int *piVar4;
		  undefined4 uVar5;
		  
		  if (DAT_ram_00a58b3b == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_WorldAxisOfficeModel__WorldAxisOfficeEvents__WorldAxisOfficeController__FrontPageView__set_Events__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_WorldAxis_Office_Controller_FrontPageViewMediator_ClanStatusChangedEventHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_WorldAxis_Office_Controller_FrontPageViewMediator_ScheduleChangedEventHandler__
		              );
		    DAT_ram_00a58b3b = '\x01';
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
		               Method_Gameplay_WorldAxis_Office_Controller_FrontPageViewMediator_ScheduleChangedEventHandler__
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
		    iVar2 = *(int *)(iVar1 + 0x18);
		    uVar5 = *(undefined4 *)(iVar2 + 0x18);
		    uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar3,param1,
		               Method_Gameplay_WorldAxis_Office_Controller_FrontPageViewMediator_ClanStatusChangedEventHandler__
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
		    uVar5 = *(undefined4 *)(iVar2 + 0x1c);
		    uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar3,param1,
		               Method_Gameplay_WorldAxis_Office_Controller_FrontPageViewMediator_ScheduleChangedEventHandler__
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
		    iVar2 = *(int *)(iVar1 + 0x18);
		    uVar5 = *(undefined4 *)(iVar2 + 0x18);
		    uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar3,param1,
		               Method_Gameplay_WorldAxis_Office_Controller_FrontPageViewMediator_ClanStatusChangedEventHandler__
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

		// Token: 0x1700028F RID: 655
		// (set) Token: 0x06001149 RID: 4425 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700028F")]
		public override WorldAxisOfficeEvents Events
		{
			[Token(Token = "0x6001149")]
			[Address(RVA = "0x6346", Offset = "0x6346", VA = "0x6346", Slot = "16")]
			set
			{
			}
		}

		// Token: 0x0600114A RID: 4426 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600114A")]
		[Address(RVA = "0x6347", Offset = "0x6347", VA = "0x6347")]
		private void ClanStatusChangedEventHandler()
		{
		/* --- GHIDRA: ClanStatusChangedEventHandler ---
		void Gameplay_WorldAxis_Office_Controller_FrontPageViewMediator__ClanStatusChangedEventHandler
		               (undefined4 param1,undefined4 param2)
		
		{
		  Gameplay_WorldAxis_Office_Controller_FrontPageViewMediator__set_View(param1,param1);
		  return;
		}
		*/

		}

		// Token: 0x0600114B RID: 4427 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600114B")]
		[Address(RVA = "0x6348", Offset = "0x6348", VA = "0x6348")]
		private void ScheduleChangedEventHandler()
		{
		}

		// Token: 0x0600114C RID: 4428 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600114C")]
		[Address(RVA = "0x6349", Offset = "0x6349", VA = "0x6349", Slot = "21")]
		public void Hide()
		{
		/* --- GHIDRA: Hide ---
		void Gameplay_WorldAxis_Office_Controller_FrontPageViewMediator__Hide
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a58b3c == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_MVC_AbstractController_HistoryModel__HistoryEvents___ctor__);
		    Mono_Security_ASN1__get_Item(&Method_Core_Net_ServiceFactory_GetService_ColossusService___);
		    Mono_Security_ASN1__get_Item(&Core_Net_ServiceFactory_TypeInfo);
		    DAT_ram_00a58b3c = '\x01';
		  }
		  Gameplay_Combat_AbstractCombat_object__object__object__object__object___set_User
		            (param1,param2,param3,Method_MVC_AbstractController_HistoryModel__HistoryEvents___ctor__
		            );
		  if (*(int *)(Core_Net_ServiceFactory_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Net_ServiceFactory_TypeInfo);
		  }
		  uVar1 = Core_Gameplay_Managers_LoggedManager__RequestLogin
		                    (Method_Core_Net_ServiceFactory_GetService_ColossusService___);
		  *(undefined4 *)(param1 + 0x18) = uVar1;
		  return;
		}
		*/

		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_View ---
		void Gameplay_WorldAxis_Office_Controller_FrontPageViewMediator__set_View
		               (int *param1,undefined4 param2)
		
		{
		  char cVar1;
		  int iVar2;
		  undefined4 param2_00;
		  undefined4 uVar3;
		  undefined4 *puVar4;
		  
		  if (DAT_ram_00a58b37 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_WorldAxisOfficeModel__WorldAxisOfficeEvents__WorldAxisOfficeController__FrontPageView__get_Model__
		              );
		    DAT_ram_00a58b37 = '\x01';
		  }
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  UI_Elements_RightPanel_TitleWithLevel__set_Level
		            (*(undefined4 *)(iVar2 + 0x10),*(undefined4 *)(*(int *)(param1[2] + 0x10) + 0x1c),0);
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar3 = *(undefined4 *)(iVar2 + 0x14);
		  iVar2 = *(int *)(param1[2] + 0x10);
		  if (DAT_ram_00a58ae8 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_17804);
		    Mono_Security_ASN1__get_Item(&StringLiteral_17805);
		    DAT_ram_00a58ae8 = '\x01';
		  }
		  cVar1 = *(char *)(iVar2 + 0x20);
		  if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_GameLocalization_TypeInfo);
		  }
		  puVar4 = &StringLiteral_17804;
		  if (cVar1 == '\0') {
		    puVar4 = &StringLiteral_17805;
		  }
		  param2_00 = Core_Extensions_Dict_CultDicExt__GetTitle(*puVar4,1,0,1,0,0,0,0);
		  UnityEngine_Component__GetComponentInChildren_object_(uVar3,param2_00,0);
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar3 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (*(undefined4 *)(iVar2 + 0x1c),0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar3,(uint)*(byte *)(*(int *)(param1[2] + 0x10) + 0x20),0);
		  if (DAT_ram_00a58b38 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_WorldAxisOfficeModel__WorldAxisOfficeEvents__WorldAxisOfficeController__FrontPageView__get_Model__
		              );
		    DAT_ram_00a58b38 = '\x01';
		  }
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar3 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (*(undefined4 *)(iVar2 + 0x18),0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar3,(uint)(*(int *)(*(int *)(param1[2] + 8) + 0x68) == 0),0);
		  return;
		}
		*/


		/* --- GHIDRA: set_Events ---
		void Gameplay_WorldAxis_Office_Controller_FrontPageViewMediator__set_Events
		               (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a58b38 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_WorldAxisOfficeModel__WorldAxisOfficeEvents__WorldAxisOfficeController__FrontPageView__get_Model__
		              );
		    DAT_ram_00a58b38 = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  param1_00 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                        (*(undefined4 *)(iVar1 + 0x18),0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (param1_00,(uint)(*(int *)(*(int *)(param1[2] + 8) + 0x68) == 0),0);
		  return;
		}
		*/

}
