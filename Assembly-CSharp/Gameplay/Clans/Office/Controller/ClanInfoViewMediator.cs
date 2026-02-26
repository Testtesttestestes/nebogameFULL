using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Gameplay.Clans.Office.Controller.ClanWars;
using Gameplay.Clans.Office.Events;
using Gameplay.Clans.Office.Model;
using Gameplay.Clans.Office.View;
using Il2CppDummyDll;
using MVC;
using MVC.Interfaces;

namespace Gameplay.Clans.Office.Controller
{
	// Token: 0x02000A69 RID: 2665
	[Token(Token = "0x2000A69")]
	public class ClanInfoViewMediator : AbstractViewMediator<ClanInfoModel, ClanInfoEvents, ClanInfoController, ClanInfoWindow>
	{
		// Token: 0x06003F05 RID: 16133 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003F05")]
		[Address(RVA = "0x8DC0", Offset = "0x8DC0", VA = "0x8DC0")]
		public ClanInfoViewMediator(ClanInfoModel model, ClanInfoEvents events, ClanInfoController controller)
		{
		/* --- GHIDRA: <ShowClassTab>g__CreateClanResumesMVC|28_0 ---
		void Gameplay_Clans_Office_Controller_ClanInfoViewMediator___ShowClassTab_g__CreateClanResumesMVC_28_0
		               (undefined4 param1,undefined4 param2,undefined4 param3,undefined4 param4,
		               undefined4 param5)
		
		{
		  if (DAT_ram_00a57ffc == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_ClanInfoModel__ClanInfoEvents__ClanInfoController__ClanMembersView___ctor__
		              );
		    DAT_ram_00a57ffc = '\x01';
		  }
		  Gameplay_Combat_TeamCombat_View_AbstractTeamCombatView_object___get_HideInstantElements
		            (param1,param2,param3,param4,
		             Method_MVC_AbstractViewMediator_ClanInfoModel__ClanInfoEvents__ClanInfoController__ClanMembersView___ctor__
		            );
		  return;
		}
		*/

		/* --- GHIDRA: <ShowSquadTab>g__CreateClanResumesMVC|27_0 ---
		void Gameplay_Clans_Office_Controller_ClanInfoViewMediator___ShowSquadTab_g__CreateClanResumesMVC_27_0
		               (int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 param1_00;
		  undefined4 param1_01;
		  int *param1_02;
		  int iVar3;
		  undefined4 uVar4;
		  undefined4 param3;
		  
		  if (DAT_ram_00a57ffb == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_ClanInfoModel__ClanInfoEvents__ClanInfoController__ClanInfoWindow__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&Gameplay_Clans_Office_Controller_ClassController_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Clans_Office_Events_ClassEvents_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Clans_Office_Model_ClassModel_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Clans_Office_Controller_ClassViewMediator_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a57ffb = '\x01';
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
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + iVar3 + 600);
		        goto code_r0x80e910d6;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_02,Core_Gameplay_IGame_TypeInfo,0x33);
		code_r0x80e910d6:
		  iVar3 = (**(code **)((ulonglong)*puVar2 * 4))(param1_02,puVar2[1]);
		  uVar4 = *(undefined4 *)(*(int *)(param1 + 8) + 8);
		  param1_00 = unnamed_function_1417(Gameplay_Clans_Office_Model_ClassModel_TypeInfo);
		  Gameplay_Clans_Office_Model_ClassModel__get_Dict(param1_00,uVar4,iVar3,iVar3);
		  uVar4 = *(undefined4 *)(iVar3 + 0x18);
		  iVar3 = unnamed_function_1417(Gameplay_Clans_Office_Events_ClassEvents_TypeInfo);
		  *(undefined4 *)(iVar3 + 0x14) = uVar4;
		  *(int *)(param1 + 0x40) = iVar3;
		  uVar4 = unnamed_function_1417(Gameplay_Clans_Office_Controller_ClassController_TypeInfo);
		  Gameplay_Clans_Office_Controller_ClansButtonViewMediator__SetupView(uVar4,param1_00,iVar3,0);
		  param3 = *(undefined4 *)(param1 + 0x40);
		  param1_01 = unnamed_function_1417(Gameplay_Clans_Office_Controller_ClassViewMediator_TypeInfo);
		  Gameplay_Clans_Office_Controller_ClassController__GetDollSpellsResultHandler
		            (param1_01,param1_00,param3,uVar4,0);
		  *(undefined4 *)(param1 + 0x30) = param1_01;
		  return;
		}
		*/

		/* --- GHIDRA: <ShowClanResumesTab>g__CreateClanResumesMVC|25_0 ---
		void Gameplay_Clans_Office_Controller_ClanInfoViewMediator___ShowClanResumesTab_g__CreateClanResumesMVC_25_0
		               (int *param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 param1_00;
		  int *param1_01;
		  int iVar3;
		  undefined4 uVar4;
		  int iVar5;
		  undefined4 uVar6;
		  
		  if (DAT_ram_00a57ffa == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_ClanInfoModel__ClanInfoEvents__ClanInfoController__ClanInfoWindow__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Clans_Office_Controller_SquadController_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Clans_Office_Events_SquadEvents_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Clans_Office_Model_SquadModel_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Clans_Office_Controller_SquadViewMediator_TypeInfo);
		    DAT_ram_00a57ffa = '\x01';
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
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + iVar3 + 600);
		        goto code_r0x80e90e8a;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_01,Core_Gameplay_IGame_TypeInfo,0x33);
		code_r0x80e90e8a:
		  iVar3 = (**(code **)((ulonglong)*puVar2 * 4))(param1_01,puVar2[1]);
		  uVar4 = *(undefined4 *)(iVar3 + 0x14);
		  iVar5 = param1[2];
		  uVar6 = *(undefined4 *)(iVar5 + 8);
		  param1_00 = unnamed_function_1417(Gameplay_Clans_Office_Model_SquadModel_TypeInfo);
		  Gameplay_Clans_Office_Model_SquadModel__set_Treasury(param1_00,uVar6,iVar5,uVar4,iVar3);
		  uVar4 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x13c));
		  uVar6 = *(undefined4 *)(iVar3 + 0x18);
		  iVar3 = unnamed_function_1417(Gameplay_Clans_Office_Events_SquadEvents_TypeInfo);
		  *(undefined4 *)(iVar3 + 0x18) = uVar6;
		  *(undefined4 *)(iVar3 + 0x14) = uVar4;
		  param1[0xf] = iVar3;
		  uVar4 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x14c));
		  uVar6 = unnamed_function_1417(Gameplay_Clans_Office_Controller_SquadController_TypeInfo);
		  Gameplay_Clans_Office_Controller_ClassViewMediator___c__DisplayClass21_0___EquipmentViewOnSlotClickedEventHandler_b__0
		            (uVar6,param1_00,iVar3,uVar4,0);
		  iVar5 = param1[0xf];
		  iVar3 = unnamed_function_1417(Gameplay_Clans_Office_Controller_SquadViewMediator_TypeInfo);
		  Gameplay_Clans_Office_Controller_SquadController__ChangeSlotsResultHandler
		            (iVar3,param1_00,iVar5,uVar6,0);
		  param1[0xb] = iVar3;
		  return;
		}
		*/

		/* --- GHIDRA: <ShowClanWarsTab>g__CreateClanWarsMVC|24_0 ---
		void Gameplay_Clans_Office_Controller_ClanInfoViewMediator___ShowClanWarsTab_g__CreateClanWarsMVC_24_0
		               (int *param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  undefined4 param1_01;
		  int iVar1;
		  undefined4 uVar2;
		  int param3;
		  
		  if (DAT_ram_00a57ff9 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_ClanInfoModel__ClanInfoEvents__ClanInfoController__ClanInfoWindow__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&Gameplay_Clans_Office_Controller_ClanResumesController_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Clans_Office_Events_ClanResumesEvents_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Clans_Office_Model_ClanResumesModel_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Clans_Office_Controller_ClanResumesViewMediator_TypeInfo)
		    ;
		    DAT_ram_00a57ff9 = '\x01';
		  }
		  iVar1 = param1[2];
		  uVar2 = *(undefined4 *)(iVar1 + 8);
		  param1_00 = unnamed_function_1417(Gameplay_Clans_Office_Model_ClanResumesModel_TypeInfo);
		  Gameplay_Clans_Office_Model_ClanResumesModel__set_MaxListCount(param1_00,uVar2,iVar1,param1);
		  uVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x13c));
		  iVar1 = unnamed_function_1417(Gameplay_Clans_Office_Events_ClanResumesEvents_TypeInfo);
		  *(undefined4 *)(iVar1 + 0x14) = uVar2;
		  param1[0xe] = iVar1;
		  uVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x14c));
		  param1_01 = unnamed_function_1417(Gameplay_Clans_Office_Controller_ClanResumesController_TypeInfo)
		  ;
		  Gameplay_Clans_Office_Controller_ClanResumesController__set_ClanInfoController
		            (param1_01,param1_00,iVar1,uVar2,0);
		  param3 = param1[0xe];
		  iVar1 = unnamed_function_1417(Gameplay_Clans_Office_Controller_ClanResumesViewMediator_TypeInfo);
		  Gameplay_Clans_Office_Controller_ClanResumesController___ShowMembersExceededDiaogWindow_b__14_0
		            (iVar1,param1_00,param3,param1_01,0);
		  param1[9] = iVar1;
		  return;
		}
		*/

		/* --- GHIDRA: <Init>b__19_0 ---
		void Gameplay_Clans_Office_Controller_ClanInfoViewMediator___Init_b__19_0
		               (int *param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 param1_00;
		  int iVar3;
		  int *param1_01;
		  int iVar4;
		  undefined4 uVar5;
		  undefined4 uVar6;
		  undefined4 param4;
		  
		  if (DAT_ram_00a57ff8 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_ClanInfoModel__ClanInfoEvents__ClanInfoController__ClanInfoWindow__get_Model__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_Clans_Office_Controller_ClanWars_ClanWarsOfficeController_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Clans_Office_Events_ClanWarsOfficeEvents_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Clans_Office_Model_ClanWarsOfficeModel_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_Clans_Office_Controller_ClanWars_ClanWarsOfficeViewMediator_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a57ff8 = '\x01';
		  }
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
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0x240);
		        goto code_r0x80e909a9;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_01,Core_Gameplay_IGame_TypeInfo,0x30);
		code_r0x80e909a9:
		  iVar4 = (**(code **)((ulonglong)*puVar2 * 4))(param1_01,puVar2[1]);
		  uVar5 = *(undefined4 *)(iVar4 + 0x10);
		  uVar6 = *(undefined4 *)(param1[2] + 8);
		  param1_00 = unnamed_function_1417(Gameplay_Clans_Office_Model_ClanWarsOfficeModel_TypeInfo);
		  Gameplay_Clans_Office_Model_ClanWarsOfficeModel__set_ClanData(param1_00,uVar6,uVar5,uVar5);
		  uVar5 = *(undefined4 *)(iVar4 + 0x14);
		  iVar3 = unnamed_function_1417(Gameplay_Clans_Office_Events_ClanWarsOfficeEvents_TypeInfo);
		  *(undefined4 *)(iVar3 + 0x14) = uVar5;
		  param1[0xd] = iVar3;
		  param4 = *(undefined4 *)(iVar4 + 0x18);
		  uVar5 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x14c));
		  uVar6 = unnamed_function_1417
		                    (Gameplay_Clans_Office_Controller_ClanWars_ClanWarsOfficeController_TypeInfo);
		  Gameplay_Clans_Office_Controller_ClanWars_ClanWarsOfficeController__set_ClanInfoController
		            (uVar6,param1_00,iVar3,param4,uVar5,0);
		  iVar3 = param1[0xd];
		  iVar4 = unnamed_function_1417
		                    (Gameplay_Clans_Office_Controller_ClanWars_ClanWarsOfficeViewMediator_TypeInfo);
		  Gameplay_Clans_Office_Controller_ClanWars_ClanWarsOfficeController__Dispose
		            (iVar4,param1_00,iVar3,uVar6,0);
		  param1[8] = iVar4;
		  MVC_AbstractController__Dispose(uVar6,0);
		  return;
		}
		*/

		/* --- GHIDRA: .ctor ---
		void Gameplay_Clans_Office_Controller_ClanInfoViewMediator___ctor
		               (int *param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  undefined4 uVar3;
		  
		  if (DAT_ram_00a57fed == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_ClanInfoModel__ClanInfoEvents__ClanInfoController__ClanInfoWindow__set_View__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Clans_Office_Controller_ClanInfoViewMediator_TabChangedEventHandler__
		              );
		    DAT_ram_00a57fed = '\x01';
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
		               Method_Gameplay_Clans_Office_Controller_ClanInfoViewMediator_TabChangedEventHandler__
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
		               Method_Gameplay_Clans_Office_Controller_ClanInfoViewMediator_TabChangedEventHandler__
		               ,0);
		    UI_Tabs_CategoryTabBarItemView___ctor(uVar3,uVar1,0);
		    Gameplay_Clans_Office_Controller_ClanInfoViewMediator__NewHeadAppiontedEventHandler
		              (param1,param1);
		  }
		  return;
		}
		*/

		}

		// Token: 0x17000C9A RID: 3226
		// (set) Token: 0x06003F06 RID: 16134 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000C9A")]
		public override ClanInfoWindow View
		{
			[Token(Token = "0x6003F06")]
			[Address(RVA = "0x8DC1", Offset = "0x8DC1", VA = "0x8DC1", Slot = "20")]
			set
			{
			}
		}

		// Token: 0x17000C9B RID: 3227
		// (set) Token: 0x06003F07 RID: 16135 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000C9B")]
		public override ClanInfoEvents Events
		{
			[Token(Token = "0x6003F07")]
			[Address(RVA = "0x8DC2", Offset = "0x8DC2", VA = "0x8DC2", Slot = "16")]
			set
			{
			}
		}

		// Token: 0x06003F08 RID: 16136 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003F08")]
		[Address(RVA = "0x8DC3", Offset = "0x8DC3", VA = "0x8DC3")]
		private void NewHeadAppiontedEventHandler()
		{
		/* --- GHIDRA: NewHeadAppiontedEventHandler ---
		void Gameplay_Clans_Office_Controller_ClanInfoViewMediator__NewHeadAppiontedEventHandler
		               (int *param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  undefined4 param1_00;
		  int param1_01;
		  
		  if (DAT_ram_00a57ff0 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_ClanInfoModel__ClanInfoEvents__ClanInfoController__ClanInfoWindow__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&Method_System_Array_FindIndex_TabBarItemData___);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Clans_Office_Controller_ClanInfoViewMediator__Init_b__19_0__);
		    Mono_Security_ASN1__get_Item(&System_Predicate_TabBarItemData__TypeInfo);
		    DAT_ram_00a57ff0 = '\x01';
		  }
		  uVar1 = Gameplay_Clans_Office_Model_ClanInfoModel__SetIsleInfo(param1[2],param1);
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  UI_Tabs_TabBar__HandleSelected(*(undefined4 *)(iVar2 + 0x3c),uVar1,0);
		  param1_00 = unnamed_function_1417(System_Predicate_TabBarItemData__TypeInfo);
		  func_ii_7297(param1_00,param1,
		               Method_Gameplay_Clans_Office_Controller_ClanInfoViewMediator__Init_b__19_0__,0);
		  uVar1 = System_Array__FindAll___Il2CppFullySharedGenericType_
		                    (uVar1,param1_00,Method_System_Array_FindIndex_TabBarItemData___);
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  Gameplay_GameEvents_Model_GameEventData__get_ContainsArtifactRewards
		            (*(undefined4 *)(iVar2 + 0x3c),uVar1,1,0);
		  if (DAT_ram_00a57ff2 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_ClanInfoWindow_Tab__Func_IHideableMediator___get_Item__
		              );
		    DAT_ram_00a57ff2 = '\x01';
		  }
		  param1_01 = param1[0x11];
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar2 = UI_Tabs_TabBar__get_SelectedIndex(*(undefined4 *)(iVar2 + 0x3c),0);
		  iVar2 = GAFInternal_Reader_GAFReader__OpenTag
		                    (param1_01,*(undefined4 *)(iVar2 + 0x14),
		                     Method_System_Collections_Generic_Dictionary_ClanInfoWindow_Tab__Func_IHideableMediator___get_Item__
		                    );
		  iVar2 = (**(code **)((ulonglong)*(uint *)(iVar2 + 0xc) * 4))
		                    (*(undefined4 *)(iVar2 + 0x20),*(undefined4 *)(iVar2 + 0x14));
		  param1[0x12] = iVar2;
		  return;
		}
		*/

		}

		// Token: 0x06003F09 RID: 16137 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003F09")]
		[Address(RVA = "0x8DC4", Offset = "0x8DC4", VA = "0x8DC4")]
		private void Init()
		{
		/* --- GHIDRA: Init ---
		void Gameplay_Clans_Office_Controller_ClanInfoViewMediator__Init(int *param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  int *param1_00;
		  int iVar3;
		  int param1_01;
		  
		  if (DAT_ram_00a57ff1 == '\0') {
		    Mono_Security_ASN1__get_Item(&MVC_Interfaces_IHideableMediator_TypeInfo);
		    DAT_ram_00a57ff1 = '\x01';
		  }
		  param1_00 = (int *)param1[0x12];
		  iVar3 = *param1_00;
		  if (*(ushort *)(iVar3 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (MVC_Interfaces_IHideableMediator_TypeInfo == *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8))
		      {
		        puVar2 = (uint *)(iVar3 + *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x80e9052f;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_00,MVC_Interfaces_IHideableMediator_TypeInfo,0);
		code_r0x80e9052f:
		  (**(code **)((ulonglong)*puVar2 * 4))(param1_00,puVar2[1]);
		  if (DAT_ram_00a57ff2 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_ClanInfoWindow_Tab__Func_IHideableMediator___get_Item__
		              );
		    DAT_ram_00a57ff2 = '\x01';
		  }
		  param1_01 = param1[0x11];
		  iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar3 = UI_Tabs_TabBar__get_SelectedIndex(*(undefined4 *)(iVar3 + 0x3c),0);
		  iVar3 = GAFInternal_Reader_GAFReader__OpenTag
		                    (param1_01,*(undefined4 *)(iVar3 + 0x14),
		                     Method_System_Collections_Generic_Dictionary_ClanInfoWindow_Tab__Func_IHideableMediator___get_Item__
		                    );
		  iVar3 = (**(code **)((ulonglong)*(uint *)(iVar3 + 0xc) * 4))
		                    (*(undefined4 *)(iVar3 + 0x20),*(undefined4 *)(iVar3 + 0x14));
		  param1[0x12] = iVar3;
		  return;
		}
		*/

		}

		// Token: 0x06003F0A RID: 16138 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003F0A")]
		[Address(RVA = "0x8DC5", Offset = "0x8DC5", VA = "0x8DC5")]
		private void TabChangedEventHandler()
		{
		/* --- GHIDRA: TabChangedEventHandler ---
		void Gameplay_Clans_Office_Controller_ClanInfoViewMediator__TabChangedEventHandler
		               (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  int param1_00;
		  
		  if (DAT_ram_00a57ff2 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_ClanInfoWindow_Tab__Func_IHideableMediator___get_Item__
		              );
		    DAT_ram_00a57ff2 = '\x01';
		  }
		  param1_00 = param1[0x11];
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar1 = UI_Tabs_TabBar__get_SelectedIndex(*(undefined4 *)(iVar1 + 0x3c),0);
		  iVar1 = GAFInternal_Reader_GAFReader__OpenTag
		                    (param1_00,*(undefined4 *)(iVar1 + 0x14),
		                     Method_System_Collections_Generic_Dictionary_ClanInfoWindow_Tab__Func_IHideableMediator___get_Item__
		                    );
		  iVar1 = (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		                    (*(undefined4 *)(iVar1 + 0x20),*(undefined4 *)(iVar1 + 0x14));
		  param1[0x12] = iVar1;
		  return;
		}
		*/

		}

		// Token: 0x06003F0B RID: 16139 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003F0B")]
		[Address(RVA = "0x8DC6", Offset = "0x8DC6", VA = "0x8DC6")]
		private void AssignNewMediator()
		{
		/* --- GHIDRA: AssignNewMediator ---
		int Gameplay_Clans_Office_Controller_ClanInfoViewMediator__AssignNewMediator
		              (int *param1,undefined4 param2)
		
		{
		  undefined4 param4;
		  undefined4 uVar1;
		  int iVar2;
		  int *piVar3;
		  int iVar4;
		  
		  if (DAT_ram_00a57ff3 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_ClanInfoModel__ClanInfoEvents__ClanInfoController__ClanInfoWindow__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&Gameplay_Clans_Office_Controller_ClanOverviewMediator_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_MonoBehaviourWithStates_ClanInfoWindow_State__set_CurrentState__);
		    DAT_ram_00a57ff3 = '\x01';
		  }
		  piVar3 = (int *)param1[6];
		  if (piVar3 == (int *)0x0) {
		    iVar2 = param1[2];
		    uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    param4 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                       (param1,*(undefined4 *)(*param1 + 0x14c));
		    piVar3 = (int *)unnamed_function_1417
		                              (Gameplay_Clans_Office_Controller_ClanOverviewMediator_TypeInfo);
		    Gameplay_Clans_Office_Controller_ClanOfficeViewMediator__Dispose(piVar3,iVar2,uVar1,param4,0);
		    param1[6] = (int)piVar3;
		  }
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x13c));
		  (**(code **)((ulonglong)*(uint *)(*piVar3 + 0x140) * 4))
		            (piVar3,uVar1,*(undefined4 *)(*piVar3 + 0x144));
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  Gameplay_Boss_View_CaptainTab_BossTeamView__set_TeamInfoData
		            (*(undefined4 *)(iVar2 + 0x40),*(undefined4 *)(param1[2] + 0x20),
		             Method_UI_MonoBehaviourWithStates_ClanInfoWindow_State__set_CurrentState__);
		  piVar3 = (int *)param1[6];
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar4 = *piVar3;
		  (**(code **)((ulonglong)*(uint *)(iVar4 + 0x160) * 4))
		            (piVar3,*(undefined4 *)(iVar2 + 0x40),*(undefined4 *)(iVar4 + 0x164));
		  return param1[6];
		}
		*/

		}

		// Token: 0x06003F0C RID: 16140 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6003F0C")]
		[Address(RVA = "0x8DC7", Offset = "0x8DC7", VA = "0x8DC7")]
		private IHideableMediator ShowClanOverviewTab()
		{
		/* --- GHIDRA: ShowClanOverviewTab ---
		int Gameplay_Clans_Office_Controller_ClanInfoViewMediator__ShowClanOverviewTab
		              (int *param1,undefined4 param2)
		
		{
		  undefined4 param4;
		  undefined4 uVar1;
		  int iVar2;
		  int *piVar3;
		  int iVar4;
		  
		  if (DAT_ram_00a57ff4 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_ClanInfoModel__ClanInfoEvents__ClanInfoController__ClanInfoWindow__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&Gameplay_Clans_Office_Controller_ClanMembersViewMediator_TypeInfo)
		    ;
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_MonoBehaviourWithStates_ClanInfoWindow_State__set_CurrentState__);
		    DAT_ram_00a57ff4 = '\x01';
		  }
		  piVar3 = (int *)param1[7];
		  if (piVar3 == (int *)0x0) {
		    iVar2 = param1[2];
		    uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    param4 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                       (param1,*(undefined4 *)(*param1 + 0x14c));
		    piVar3 = (int *)unnamed_function_1417
		                              (Gameplay_Clans_Office_Controller_ClanMembersViewMediator_TypeInfo);
		    if (DAT_ram_00a57ffc == '\0') {
		      Mono_Security_ASN1__get_Item
		                (&
		                 Method_MVC_AbstractViewMediator_ClanInfoModel__ClanInfoEvents__ClanInfoController__ClanMembersView___ctor__
		                );
		      DAT_ram_00a57ffc = '\x01';
		    }
		    Gameplay_Combat_TeamCombat_View_AbstractTeamCombatView_object___get_HideInstantElements
		              (piVar3,iVar2,uVar1,param4,
		               Method_MVC_AbstractViewMediator_ClanInfoModel__ClanInfoEvents__ClanInfoController__ClanMembersView___ctor__
		              );
		    param1[7] = (int)piVar3;
		  }
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x13c));
		  (**(code **)((ulonglong)*(uint *)(*piVar3 + 0x140) * 4))
		            (piVar3,uVar1,*(undefined4 *)(*piVar3 + 0x144));
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  Gameplay_Boss_View_CaptainTab_BossTeamView__set_TeamInfoData
		            (*(undefined4 *)(iVar2 + 0x44),*(undefined4 *)(param1[2] + 0x20),
		             Method_UI_MonoBehaviourWithStates_ClanInfoWindow_State__set_CurrentState__);
		  piVar3 = (int *)param1[7];
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar4 = *piVar3;
		  (**(code **)((ulonglong)*(uint *)(iVar4 + 0x160) * 4))
		            (piVar3,*(undefined4 *)(iVar2 + 0x44),*(undefined4 *)(iVar4 + 0x164));
		  return param1[7];
		}
		*/

			return null;
		}

		// Token: 0x06003F0D RID: 16141 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6003F0D")]
		[Address(RVA = "0x8DC8", Offset = "0x8DC8", VA = "0x8DC8")]
		private IHideableMediator ShowClanMembersTab()
		{
		/* --- GHIDRA: ShowClanMembersTab ---
		int Gameplay_Clans_Office_Controller_ClanInfoViewMediator__ShowClanMembersTab
		              (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  int *piVar2;
		  int iVar3;
		  
		  piVar2 = (int *)param1[8];
		  if (piVar2 == (int *)0x0) {
		    Gameplay_Clans_Office_Controller_ClanInfoViewMediator___Init_b__19_0(param1,param1);
		  }
		  else {
		    (**(code **)((ulonglong)*(uint *)(*piVar2 + 0x140) * 4))
		              (piVar2,param1[0xd],*(undefined4 *)(*piVar2 + 0x144));
		  }
		  piVar2 = (int *)param1[8];
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar3 = *piVar2;
		  (**(code **)((ulonglong)*(uint *)(iVar3 + 0x160) * 4))
		            (piVar2,*(undefined4 *)(iVar1 + 0x48),*(undefined4 *)(iVar3 + 0x164));
		  return param1[8];
		}
		*/

			return null;
		}

		// Token: 0x06003F0E RID: 16142 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6003F0E")]
		[Address(RVA = "0x8DC9", Offset = "0x8DC9", VA = "0x8DC9")]
		private IHideableMediator ShowClanWarsTab()
		{
		/* --- GHIDRA: ShowClanWarsTab ---
		int Gameplay_Clans_Office_Controller_ClanInfoViewMediator__ShowClanWarsTab
		              (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 param1_00;
		  int *piVar2;
		  int iVar3;
		  
		  piVar2 = (int *)param1[9];
		  if (piVar2 == (int *)0x0) {
		    Gameplay_Clans_Office_Controller_ClanInfoViewMediator___ShowClanWarsTab_g__CreateClanWarsMVC_24_0
		              (param1,param1);
		  }
		  else {
		    (**(code **)((ulonglong)*(uint *)(*piVar2 + 0x140) * 4))
		              (piVar2,param1[0xe],*(undefined4 *)(*piVar2 + 0x144));
		  }
		  piVar2 = (int *)param1[9];
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar3 = *piVar2;
		  (**(code **)((ulonglong)*(uint *)(iVar3 + 0x160) * 4))
		            (piVar2,*(undefined4 *)(iVar1 + 0x4c),*(undefined4 *)(iVar3 + 0x164));
		  iVar1 = *(int *)param1[9];
		  param1_00 = (**(code **)((ulonglong)*(uint *)(iVar1 + 0x148) * 4))
		                        ((int *)param1[9],*(undefined4 *)(iVar1 + 0x14c));
		  MVC_AbstractController__Dispose(param1_00,0);
		  return param1[9];
		}
		*/

			return null;
		}

		// Token: 0x06003F0F RID: 16143 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6003F0F")]
		[Address(RVA = "0x8DCA", Offset = "0x8DCA", VA = "0x8DCA")]
		private IHideableMediator ShowClanResumesTab()
		{
		/* --- GHIDRA: ShowClanResumesTab ---
		int Gameplay_Clans_Office_Controller_ClanInfoViewMediator__ShowClanResumesTab
		              (int *param1,undefined4 param2)
		
		{
		  undefined4 param4;
		  undefined4 uVar1;
		  undefined4 uVar2;
		  int iVar3;
		  int *piVar4;
		  int iVar5;
		  
		  if (DAT_ram_00a57ff5 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_ClanInfoModel__ClanInfoEvents__ClanInfoController__ClanInfoWindow__get_Model__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_Windows_BaseWindow_ClanInfoWindow_ClanInfoWindowArgs__get_WindowArgs__);
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_Clans_Office_Controller_ClanTreasuryViewMediator_TypeInfo);
		    DAT_ram_00a57ff5 = '\x01';
		  }
		  piVar4 = (int *)param1[10];
		  if (piVar4 == (int *)0x0) {
		    iVar5 = param1[2];
		    uVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    param4 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                       (param1,*(undefined4 *)(*param1 + 0x14c));
		    uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    iVar3 = func_ii_8093(uVar1,
		                         Method_UI_Windows_BaseWindow_ClanInfoWindow_ClanInfoWindowArgs__get_WindowArgs__
		                        );
		    uVar1 = *(undefined4 *)(iVar3 + 0x28);
		    piVar4 = (int *)unnamed_function_1417
		                              (Gameplay_Clans_Office_Controller_ClanTreasuryViewMediator_TypeInfo);
		    Gameplay_Clans_Office_Controller_ClanResumesViewMediator__Hide
		              (piVar4,iVar5,uVar2,param4,uVar1,0);
		    param1[10] = (int)piVar4;
		  }
		  uVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x13c));
		  (**(code **)((ulonglong)*(uint *)(*piVar4 + 0x140) * 4))
		            (piVar4,uVar2,*(undefined4 *)(*piVar4 + 0x144));
		  piVar4 = (int *)param1[10];
		  iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar5 = *piVar4;
		  (**(code **)((ulonglong)*(uint *)(iVar5 + 0x160) * 4))
		            (piVar4,*(undefined4 *)(iVar3 + 0x50),*(undefined4 *)(iVar5 + 0x164));
		  return param1[10];
		}
		*/

			return null;
		}

		// Token: 0x06003F10 RID: 16144 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6003F10")]
		[Address(RVA = "0x8DCB", Offset = "0x8DCB", VA = "0x8DCB")]
		private IHideableMediator ShowTreasuryTab()
		{
		/* --- GHIDRA: ShowTreasuryTab ---
		int Gameplay_Clans_Office_Controller_ClanInfoViewMediator__ShowTreasuryTab
		              (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 param1_00;
		  int *piVar2;
		  int iVar3;
		  
		  piVar2 = (int *)param1[0xb];
		  if (piVar2 == (int *)0x0) {
		    Gameplay_Clans_Office_Controller_ClanInfoViewMediator___ShowClanResumesTab_g__CreateClanResumesMVC_25_0
		              (param1,param1);
		  }
		  else {
		    (**(code **)((ulonglong)*(uint *)(*piVar2 + 0x140) * 4))
		              (piVar2,param1[0xf],*(undefined4 *)(*piVar2 + 0x144));
		  }
		  piVar2 = (int *)param1[0xb];
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar3 = *piVar2;
		  (**(code **)((ulonglong)*(uint *)(iVar3 + 0x160) * 4))
		            (piVar2,*(undefined4 *)(iVar1 + 0x54),*(undefined4 *)(iVar3 + 0x164));
		  iVar1 = *(int *)param1[0xb];
		  param1_00 = (**(code **)((ulonglong)*(uint *)(iVar1 + 0x148) * 4))
		                        ((int *)param1[0xb],*(undefined4 *)(iVar1 + 0x14c));
		  MVC_AbstractController__Dispose(param1_00,0);
		  return param1[0xb];
		}
		*/

			return null;
		}

		// Token: 0x06003F11 RID: 16145 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6003F11")]
		[Address(RVA = "0x8DCC", Offset = "0x8DCC", VA = "0x8DCC")]
		private IHideableMediator ShowSquadTab()
		{
		/* --- GHIDRA: ShowSquadTab ---
		int Gameplay_Clans_Office_Controller_ClanInfoViewMediator__ShowSquadTab
		              (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 param1_00;
		  int *piVar2;
		  int iVar3;
		  
		  piVar2 = (int *)param1[0xc];
		  if (piVar2 == (int *)0x0) {
		    Gameplay_Clans_Office_Controller_ClanInfoViewMediator___ShowSquadTab_g__CreateClanResumesMVC_27_0
		              (param1,param1);
		  }
		  else {
		    (**(code **)((ulonglong)*(uint *)(*piVar2 + 0x140) * 4))
		              (piVar2,param1[0x10],*(undefined4 *)(*piVar2 + 0x144));
		  }
		  piVar2 = (int *)param1[0xc];
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar3 = *piVar2;
		  (**(code **)((ulonglong)*(uint *)(iVar3 + 0x160) * 4))
		            (piVar2,*(undefined4 *)(iVar1 + 0x58),*(undefined4 *)(iVar3 + 0x164));
		  iVar1 = *(int *)param1[0xc];
		  param1_00 = (**(code **)((ulonglong)*(uint *)(iVar1 + 0x148) * 4))
		                        ((int *)param1[0xc],*(undefined4 *)(iVar1 + 0x14c));
		  MVC_AbstractController__Dispose(param1_00,0);
		  return param1[0xc];
		}
		*/

			return null;
		}

		// Token: 0x06003F12 RID: 16146 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6003F12")]
		[Address(RVA = "0x8DCD", Offset = "0x8DCD", VA = "0x8DCD")]
		private IHideableMediator ShowClassTab()
		{
		/* --- GHIDRA: ShowClassTab ---
		void Gameplay_Clans_Office_Controller_ClanInfoViewMediator__ShowClassTab
		               (int param1,undefined4 param2)
		
		{
		  int *piVar1;
		  int *piVar2;
		  int iVar3;
		  
		  if (DAT_ram_00a57ff6 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_ClanInfoModel__ClanInfoEvents__ClanInfoController__ClanInfoWindow__Dispose__
		              );
		    DAT_ram_00a57ff6 = '\x01';
		  }
		  piVar2 = *(int **)(param1 + 0x18);
		  if (piVar2 != (int *)0x0) {
		    (**(code **)((ulonglong)*(uint *)(*piVar2 + 0x130) * 4))
		              (piVar2,*(undefined4 *)(*piVar2 + 0x134));
		  }
		  piVar2 = *(int **)(param1 + 0x1c);
		  if (piVar2 != (int *)0x0) {
		    (**(code **)((ulonglong)*(uint *)(*piVar2 + 0x130) * 4))
		              (piVar2,*(undefined4 *)(*piVar2 + 0x134));
		  }
		  piVar2 = *(int **)(param1 + 0x20);
		  if (piVar2 != (int *)0x0) {
		    (**(code **)((ulonglong)*(uint *)(*piVar2 + 0x130) * 4))
		              (piVar2,*(undefined4 *)(*piVar2 + 0x134));
		  }
		  piVar2 = *(int **)(param1 + 0x28);
		  if (piVar2 != (int *)0x0) {
		    (**(code **)((ulonglong)*(uint *)(*piVar2 + 0x130) * 4))
		              (piVar2,*(undefined4 *)(*piVar2 + 0x134));
		  }
		  piVar2 = *(int **)(param1 + 0x24);
		  if (piVar2 != (int *)0x0) {
		    piVar2 = (int *)(**(code **)((ulonglong)*(uint *)(*piVar2 + 0x148) * 4))
		                              (piVar2,*(undefined4 *)(*piVar2 + 0x14c));
		    piVar1 = (int *)(**(code **)((ulonglong)*(uint *)(*piVar2 + 0x100) * 4))
		                              (piVar2,*(undefined4 *)(*piVar2 + 0x104));
		    MVC_AbstractController__Run(piVar2,0);
		    iVar3 = **(int **)(param1 + 0x24);
		    (**(code **)((ulonglong)*(uint *)(iVar3 + 0x130) * 4))
		              (*(int **)(param1 + 0x24),*(undefined4 *)(iVar3 + 0x134));
		    (**(code **)((ulonglong)*(uint *)(*piVar2 + 0xe8) * 4))(piVar2,*(undefined4 *)(*piVar2 + 0xec));
		    (**(code **)((ulonglong)*(uint *)(*piVar1 + 0xe8) * 4))(piVar1,*(undefined4 *)(*piVar1 + 0xec));
		  }
		  piVar2 = *(int **)(param1 + 0x2c);
		  if (piVar2 != (int *)0x0) {
		    piVar2 = (int *)(**(code **)((ulonglong)*(uint *)(*piVar2 + 0x148) * 4))
		                              (piVar2,*(undefined4 *)(*piVar2 + 0x14c));
		    piVar1 = (int *)(**(code **)((ulonglong)*(uint *)(*piVar2 + 0x100) * 4))
		                              (piVar2,*(undefined4 *)(*piVar2 + 0x104));
		    MVC_AbstractController__Run(piVar2,0);
		    iVar3 = **(int **)(param1 + 0x2c);
		    (**(code **)((ulonglong)*(uint *)(iVar3 + 0x130) * 4))
		              (*(int **)(param1 + 0x2c),*(undefined4 *)(iVar3 + 0x134));
		    (**(code **)((ulonglong)*(uint *)(*piVar2 + 0xe8) * 4))(piVar2,*(undefined4 *)(*piVar2 + 0xec));
		    (**(code **)((ulonglong)*(uint *)(*piVar1 + 0xe8) * 4))(piVar1,*(undefined4 *)(*piVar1 + 0xec));
		  }
		  piVar2 = *(int **)(param1 + 0x30);
		  if (piVar2 != (int *)0x0) {
		    piVar2 = (int *)(**(code **)((ulonglong)*(uint *)(*piVar2 + 0x148) * 4))
		                              (piVar2,*(undefined4 *)(*piVar2 + 0x14c));
		    piVar1 = (int *)(**(code **)((ulonglong)*(uint *)(*piVar2 + 0x100) * 4))
		                              (piVar2,*(undefined4 *)(*piVar2 + 0x104));
		    MVC_AbstractController__Run(piVar2,0);
		    iVar3 = **(int **)(param1 + 0x30);
		    (**(code **)((ulonglong)*(uint *)(iVar3 + 0x130) * 4))
		              (*(int **)(param1 + 0x30),*(undefined4 *)(iVar3 + 0x134));
		    (**(code **)((ulonglong)*(uint *)(*piVar2 + 0xe8) * 4))(piVar2,*(undefined4 *)(*piVar2 + 0xec));
		    (**(code **)((ulonglong)*(uint *)(*piVar1 + 0xe8) * 4))(piVar1,*(undefined4 *)(*piVar1 + 0xec));
		  }
		  MVC_AbstractViewMediator_object__object__object__object___Core_MVC_Interfaces_IViewMediator_set_View
		            (param1,
		             Method_MVC_AbstractViewMediator_ClanInfoModel__ClanInfoEvents__ClanInfoController__ClanInfoWindow__Dispose__
		            );
		  return;
		}
		*/

			return null;
		}

		// Token: 0x06003F13 RID: 16147 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003F13")]
		[Address(RVA = "0x8DCE", Offset = "0x8DCE", VA = "0x8DCE", Slot = "14")]
		public override void Dispose()
		{
		/* --- GHIDRA: Dispose ---
		uint Gameplay_Clans_Office_Controller_ClanInfoViewMediator__Dispose
		               (int *param1,int param2,undefined4 param3)
		
		{
		  uint uVar1;
		  undefined4 param1_00;
		  int iVar2;
		  
		  if (DAT_ram_00a57ff7 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_Windows_BaseWindow_ClanInfoWindow_ClanInfoWindowArgs__get_WindowArgs__);
		    DAT_ram_00a57ff7 = '\x01';
		  }
		  uVar1 = *(uint *)(param2 + 0x14);
		  param1_00 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar2 = func_ii_8093(param1_00,
		                       Method_UI_Windows_BaseWindow_ClanInfoWindow_ClanInfoWindowArgs__get_WindowArgs__
		                      );
		  return (uint)((ulonglong)uVar1 == (longlong)*(int *)(iVar2 + 0x2c));
		}
		*/

		}

		// Token: 0x06003F15 RID: 16149 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003F15")]
		[Address(RVA = "0x8DD0", Offset = "0x8DD0", VA = "0x8DD0")]
		[CompilerGenerated]
		private void <ShowClanWarsTab>g__CreateClanWarsMVC|24_0()
		{
		}

		// Token: 0x06003F16 RID: 16150 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003F16")]
		[Address(RVA = "0x8DD1", Offset = "0x8DD1", VA = "0x8DD1")]
		[CompilerGenerated]
		private void <ShowClanResumesTab>g__CreateClanResumesMVC|25_0()
		{
		}

		// Token: 0x06003F17 RID: 16151 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003F17")]
		[Address(RVA = "0x8DD2", Offset = "0x8DD2", VA = "0x8DD2")]
		[CompilerGenerated]
		private void <ShowSquadTab>g__CreateClanResumesMVC|27_0()
		{
		}

		// Token: 0x06003F18 RID: 16152 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003F18")]
		[Address(RVA = "0x8DD3", Offset = "0x8DD3", VA = "0x8DD3")]
		[CompilerGenerated]
		private void <ShowClassTab>g__CreateClanResumesMVC|28_0()
		{
		}

		// Token: 0x04002383 RID: 9091
		[Token(Token = "0x4002383")]
		[FieldOffset(Offset = "0x18")]
		private ClanOverviewMediator _clanOverviewMediator;

		// Token: 0x04002384 RID: 9092
		[Token(Token = "0x4002384")]
		[FieldOffset(Offset = "0x1C")]
		private ClanMembersViewMediator _clanMembersViewMediator;

		// Token: 0x04002385 RID: 9093
		[Token(Token = "0x4002385")]
		[FieldOffset(Offset = "0x20")]
		private ClanWarsOfficeViewMediator _clanWarsViewMediator;

		// Token: 0x04002386 RID: 9094
		[Token(Token = "0x4002386")]
		[FieldOffset(Offset = "0x24")]
		private ClanResumesViewMediator _clanResumesViewMediator;

		// Token: 0x04002387 RID: 9095
		[Token(Token = "0x4002387")]
		[FieldOffset(Offset = "0x28")]
		private ClanTreasuryViewMediator _clanTreasuryViewMediator;

		// Token: 0x04002388 RID: 9096
		[Token(Token = "0x4002388")]
		[FieldOffset(Offset = "0x2C")]
		private SquadViewMediator _squadViewMediator;

		// Token: 0x04002389 RID: 9097
		[Token(Token = "0x4002389")]
		[FieldOffset(Offset = "0x30")]
		private ClassViewMediator _classViewMediator;

		// Token: 0x0400238A RID: 9098
		[Token(Token = "0x400238A")]
		[FieldOffset(Offset = "0x34")]
		private ClanWarsOfficeEvents _clanWarsEvents;

		// Token: 0x0400238B RID: 9099
		[Token(Token = "0x400238B")]
		[FieldOffset(Offset = "0x38")]
		private ClanResumesEvents _clanResumesEvents;

		// Token: 0x0400238C RID: 9100
		[Token(Token = "0x400238C")]
		[FieldOffset(Offset = "0x3C")]
		private SquadEvents _squadEvents;

		// Token: 0x0400238D RID: 9101
		[Token(Token = "0x400238D")]
		[FieldOffset(Offset = "0x40")]
		private ClassEvents _classEvents;

		// Token: 0x0400238E RID: 9102
		[Token(Token = "0x400238E")]
		[FieldOffset(Offset = "0x44")]
		private Dictionary<ClanInfoWindow.Tab, Func<IHideableMediator>> _tabsOpenersById;

		// Token: 0x0400238F RID: 9103
		[Token(Token = "0x400238F")]
		[FieldOffset(Offset = "0x48")]
		private IHideableMediator _currentMediator;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_View ---
		void Gameplay_Clans_Office_Controller_ClanInfoViewMediator__set_View
		               (int *param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  int iVar2;
		  undefined4 uVar3;
		  int *piVar4;
		  undefined4 uVar5;
		  
		  if (DAT_ram_00a57fee == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_ClanInfoModel__ClanInfoEvents__ClanInfoController__ClanInfoWindow__set_Events__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Clans_Office_Controller_ClanInfoViewMediator_NewHeadAppiontedEventHandler__
		              );
		    DAT_ram_00a57fee = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x13c));
		  if (iVar1 != 0) {
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar5 = *(undefined4 *)(iVar2 + 0x2c);
		    uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar3,param1,
		               Method_Gameplay_Clans_Office_Controller_ClanInfoViewMediator_NewHeadAppiontedEventHandler__
		               ,0);
		    piVar4 = (int *)func_ii_7048(uVar5,uVar3,0);
		    iVar1 = System_Action_TypeInfo;
		    if (piVar4 == (int *)0x0) {
		      *(undefined4 *)(iVar2 + 0x2c) = 0;
		    }
		    else if ((System_Action_TypeInfo != *piVar4) ||
		            (*(int **)(iVar2 + 0x2c) = piVar4, *piVar4 != iVar1)) {
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
		    uVar5 = *(undefined4 *)(iVar2 + 0x2c);
		    uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar3,param1,
		               Method_Gameplay_Clans_Office_Controller_ClanInfoViewMediator_NewHeadAppiontedEventHandler__
		               ,0);
		    piVar4 = (int *)UnityEngine_UI_Image__set_sprite(uVar5,uVar3,0);
		    iVar1 = System_Action_TypeInfo;
		    if (piVar4 == (int *)0x0) {
		      *(undefined4 *)(iVar2 + 0x2c) = 0;
		      return;
		    }
		    if ((System_Action_TypeInfo != *piVar4) || (*(int **)(iVar2 + 0x2c) = piVar4, *piVar4 != iVar1))
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


		/* --- GHIDRA: set_Events ---
		void Gameplay_Clans_Office_Controller_ClanInfoViewMediator__set_Events
		               (int *param1,undefined4 param2)
		
		{
		  uint uVar1;
		  undefined4 in_register_20000014;
		  undefined8 uVar2;
		  undefined4 uVar3;
		  undefined4 uVar4;
		  uint *puVar5;
		  int *piVar6;
		  int iVar7;
		  
		  if (DAT_ram_00a57fef == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a57fef = '\x01';
		  }
		  uVar2 = CONCAT44(in_register_20000014,*(undefined4 *)(*param1 + 0x15c));
		  uVar4 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))(param1,uVar2);
		  uVar3 = (undefined4)((ulonglong)uVar2 >> 0x20);
		  System_ComponentModel_BindingList___Il2CppFullySharedGenericType___OnAddingNew(uVar4,0,0);
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  uVar1 = 0;
		  piVar6 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar7 = *piVar6;
		  if (*(ushort *)(iVar7 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8)) {
		        puVar5 = (uint *)(*(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8 + 4) * 8 + iVar7 + 0x230);
		        goto code_r0x80e90361;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		  }
		  puVar5 = (uint *)func_ii_1080(piVar6,Core_Gameplay_IGame_TypeInfo,0x2e);
		code_r0x80e90361:
		  uVar2 = CONCAT44(uVar3,puVar5[1]);
		  uVar4 = (**(code **)((ulonglong)*puVar5 * 4))(piVar6,uVar2);
		  uVar3 = (undefined4)((ulonglong)uVar2 >> 0x20);
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  piVar6 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar7 = *piVar6;
		  if (*(ushort *)(iVar7 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8)) {
		        puVar5 = (uint *)(*(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8 + 4) * 8 + iVar7 + 0x230);
		        goto code_r0x80e9040d;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		  }
		  puVar5 = (uint *)func_ii_1080(piVar6,Core_Gameplay_IGame_TypeInfo,0x2e);
		code_r0x80e9040d:
		  iVar7 = (**(code **)((ulonglong)*puVar5 * 4))(piVar6,CONCAT44(uVar3,puVar5[1]));
		  Core_Gameplay_Managers_ClansManager__DissociateClanFromUser
		            (uVar4,*(undefined8 *)(*(int *)(iVar7 + 0x10) + 0x10),1,0);
		  return;
		}
		*/

}
