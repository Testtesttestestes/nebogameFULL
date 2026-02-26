using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Gameplay.Clans.Office.Events;
using Gameplay.Clans.Office.Events.ClanWars;
using Gameplay.Clans.Office.Model;
using Gameplay.Clans.Office.View.ClanWarsTab;
using Il2CppDummyDll;
using MVC;
using MVC.Interfaces;

namespace Gameplay.Clans.Office.Controller.ClanWars
{
	// Token: 0x02000A85 RID: 2693
	[Token(Token = "0x2000A85")]
	public class ClanWarsOfficeViewMediator : AbstractViewMediator<ClanWarsOfficeModel, ClanWarsOfficeEvents, ClanWarsOfficeController, ClanWarsView>, IHideableMediator
	{
		// Token: 0x06004065 RID: 16485 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004065")]
		[Address(RVA = "0x8F1F", Offset = "0x8F1F", VA = "0x8F1F")]
		public ClanWarsOfficeViewMediator(ClanWarsOfficeModel model, ClanWarsOfficeEvents events, ClanWarsOfficeController controller)
		{
		/* --- GHIDRA: <ShowHistoryTab>g__CreateClanWarsHistoryMVC|17_0 ---
		void Gameplay_Clans_Office_Controller_ClanWars_ClanWarsOfficeViewMediator___ShowHistoryTab_g__CreateClanWarsHistoryMVC_17_0
		               (undefined4 param1,undefined4 param2,undefined4 param3,undefined4 param4,
		               undefined4 param5)
		
		{
		  if (DAT_ram_00a57728 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_ClanWarsOfficeModel__ClanWarsOfficeEvents__ClanWarsOfficeController__ClanWarsRewardsView___ctor__
		              );
		    DAT_ram_00a57728 = '\x01';
		  }
		  Gameplay_Combat_TeamCombat_View_AbstractTeamCombatView_object___get_HideInstantElements
		            (param1,param2,param3,param4,
		             Method_MVC_AbstractViewMediator_ClanWarsOfficeModel__ClanWarsOfficeEvents__ClanWarsOfficeController__ClanWarsRewardsView___ctor__
		            );
		  return;
		}
		*/

		/* --- GHIDRA: .ctor ---
		void Gameplay_Clans_Office_Controller_ClanWars_ClanWarsOfficeViewMediator___ctor
		               (int *param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  undefined4 uVar3;
		  int param1_00;
		  
		  if (DAT_ram_00a5771e == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_ClanWarsOfficeModel__ClanWarsOfficeEvents__ClanWarsOfficeController__ClanWarsView__set_View__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Clans_Office_Controller_ClanWars_ClanWarsOfficeViewMediator_TabChangedEventHandler__
		              );
		    DAT_ram_00a5771e = '\x01';
		  }
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar2 = Cysharp_Threading_Tasks_CancellationTokenExtensions___cctor(uVar1,0);
		  if (iVar2 != 0) {
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar3 = *(undefined4 *)(iVar2 + 0x10);
		    uVar1 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar1,param1,
		               Method_Gameplay_Clans_Office_Controller_ClanWars_ClanWarsOfficeViewMediator_TabChangedEventHandler__
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
		    uVar3 = *(undefined4 *)(iVar2 + 0x10);
		    uVar1 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar1,param1,
		               Method_Gameplay_Clans_Office_Controller_ClanWars_ClanWarsOfficeViewMediator_TabChangedEventHandler__
		               ,0);
		    UI_Tabs_CategoryTabBarItemView___ctor(uVar3,uVar1,0);
		    uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar1 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                      (uVar1,0);
		    Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		              (uVar1,1,0);
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x14c));
		    if (*(char *)(iVar2 + 9) != '\0') {
		      if ((char)param1[0xc] != '\0') {
		        if (DAT_ram_00a57722 == '\0') {
		          Mono_Security_ASN1__get_Item
		                    (&
		                     Method_System_Collections_Generic_Dictionary_uint__Func_IHideableMediator___get_Item__
		                    );
		          DAT_ram_00a57722 = '\x01';
		        }
		        param1_00 = param1[9];
		        iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                          (param1,*(undefined4 *)(*param1 + 0x15c));
		        iVar2 = UI_Tabs_TabBar__get_SelectedIndex(*(undefined4 *)(iVar2 + 0x10),0);
		        iVar2 = System_Collections_Generic_List_object___get_Item
		                          (param1_00,*(undefined4 *)(iVar2 + 0x14),
		                           Method_System_Collections_Generic_Dictionary_uint__Func_IHideableMediator___get_Item__
		                          );
		        iVar2 = (**(code **)((ulonglong)*(uint *)(iVar2 + 0xc) * 4))
		                          (*(undefined4 *)(iVar2 + 0x20),*(undefined4 *)(iVar2 + 0x14));
		        param1[10] = iVar2;
		        return;
		      }
		      Gameplay_Clans_Office_Controller_ClanWars_ClanWarsOfficeViewMediator__set_Events
		                (param1,param1);
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x17000CB5 RID: 3253
		// (set) Token: 0x06004066 RID: 16486 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000CB5")]
		public override ClanWarsView View
		{
			[Token(Token = "0x6004066")]
			[Address(RVA = "0x8F20", Offset = "0x8F20", VA = "0x8F20", Slot = "20")]
			set
			{
			}
		}

		// Token: 0x17000CB6 RID: 3254
		// (set) Token: 0x06004067 RID: 16487 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000CB6")]
		public override ClanWarsOfficeEvents Events
		{
			[Token(Token = "0x6004067")]
			[Address(RVA = "0x8F21", Offset = "0x8F21", VA = "0x8F21", Slot = "16")]
			set
			{
			}
		}

		// Token: 0x06004068 RID: 16488 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004068")]
		[Address(RVA = "0x8F22", Offset = "0x8F22", VA = "0x8F22")]
		private void InitEventHandler()
		{
		/* --- GHIDRA: InitEventHandler ---
		void Gameplay_Clans_Office_Controller_ClanWars_ClanWarsOfficeViewMediator__InitEventHandler
		               (int *param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  int *param1_00;
		  int iVar3;
		  int param1_01;
		  
		  if (DAT_ram_00a57721 == '\0') {
		    Mono_Security_ASN1__get_Item(&MVC_Interfaces_IHideableMediator_TypeInfo);
		    DAT_ram_00a57721 = '\x01';
		  }
		  param1_00 = (int *)param1[10];
		  iVar3 = *param1_00;
		  if (*(ushort *)(iVar3 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (MVC_Interfaces_IHideableMediator_TypeInfo == *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8))
		      {
		        puVar2 = (uint *)(iVar3 + *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x80dd0915;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_00,MVC_Interfaces_IHideableMediator_TypeInfo,0);
		code_r0x80dd0915:
		  (**(code **)((ulonglong)*puVar2 * 4))(param1_00,puVar2[1]);
		  if (DAT_ram_00a57722 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_uint__Func_IHideableMediator___get_Item__
		              );
		    DAT_ram_00a57722 = '\x01';
		  }
		  param1_01 = param1[9];
		  iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar3 = UI_Tabs_TabBar__get_SelectedIndex(*(undefined4 *)(iVar3 + 0x10),0);
		  iVar3 = System_Collections_Generic_List_object___get_Item
		                    (param1_01,*(undefined4 *)(iVar3 + 0x14),
		                     Method_System_Collections_Generic_Dictionary_uint__Func_IHideableMediator___get_Item__
		                    );
		  iVar3 = (**(code **)((ulonglong)*(uint *)(iVar3 + 0xc) * 4))
		                    (*(undefined4 *)(iVar3 + 0x20),*(undefined4 *)(iVar3 + 0x14));
		  param1[10] = iVar3;
		  return;
		}
		*/

		}

		// Token: 0x06004069 RID: 16489 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004069")]
		[Address(RVA = "0x8F23", Offset = "0x8F23", VA = "0x8F23")]
		private void TabChangedEventHandler()
		{
		/* --- GHIDRA: TabChangedEventHandler ---
		void Gameplay_Clans_Office_Controller_ClanWars_ClanWarsOfficeViewMediator__TabChangedEventHandler
		               (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  int param1_00;
		  
		  if (DAT_ram_00a57722 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_uint__Func_IHideableMediator___get_Item__
		              );
		    DAT_ram_00a57722 = '\x01';
		  }
		  param1_00 = param1[9];
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar1 = UI_Tabs_TabBar__get_SelectedIndex(*(undefined4 *)(iVar1 + 0x10),0);
		  iVar1 = System_Collections_Generic_List_object___get_Item
		                    (param1_00,*(undefined4 *)(iVar1 + 0x14),
		                     Method_System_Collections_Generic_Dictionary_uint__Func_IHideableMediator___get_Item__
		                    );
		  iVar1 = (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		                    (*(undefined4 *)(iVar1 + 0x20),*(undefined4 *)(iVar1 + 0x14));
		  param1[10] = iVar1;
		  return;
		}
		*/

		}

		// Token: 0x0600406A RID: 16490 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600406A")]
		[Address(RVA = "0x8F24", Offset = "0x8F24", VA = "0x8F24")]
		private void AssignNewMediator()
		{
		/* --- GHIDRA: AssignNewMediator ---
		int Gameplay_Clans_Office_Controller_ClanWars_ClanWarsOfficeViewMediator__AssignNewMediator
		              (int *param1,undefined4 param2)
		
		{
		  undefined4 param4;
		  undefined4 uVar1;
		  int iVar2;
		  int *piVar3;
		  int iVar4;
		  
		  if (DAT_ram_00a57723 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_ClanWarsOfficeModel__ClanWarsOfficeEvents__ClanWarsOfficeController__ClanWarsView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_Clans_Office_Controller_ClanWars_ClanWarsRewardsViewMediator_TypeInfo);
		    DAT_ram_00a57723 = '\x01';
		  }
		  piVar3 = (int *)param1[6];
		  if (piVar3 == (int *)0x0) {
		    iVar2 = param1[2];
		    uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    param4 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                       (param1,*(undefined4 *)(*param1 + 0x14c));
		    piVar3 = (int *)unnamed_function_1417
		                              (
		                              Gameplay_Clans_Office_Controller_ClanWars_ClanWarsRewardsViewMediator_TypeInfo
		                              );
		    if (DAT_ram_00a57728 == '\0') {
		      Mono_Security_ASN1__get_Item
		                (&
		                 Method_MVC_AbstractViewMediator_ClanWarsOfficeModel__ClanWarsOfficeEvents__ClanWarsOfficeController__ClanWarsRewardsView___ctor__
		                );
		      DAT_ram_00a57728 = '\x01';
		    }
		    Gameplay_Combat_TeamCombat_View_AbstractTeamCombatView_object___get_HideInstantElements
		              (piVar3,iVar2,uVar1,param4,
		               Method_MVC_AbstractViewMediator_ClanWarsOfficeModel__ClanWarsOfficeEvents__ClanWarsOfficeController__ClanWarsRewardsView___ctor__
		              );
		    param1[6] = (int)piVar3;
		  }
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x13c));
		  (**(code **)((ulonglong)*(uint *)(*piVar3 + 0x140) * 4))
		            (piVar3,uVar1,*(undefined4 *)(*piVar3 + 0x144));
		  piVar3 = (int *)param1[6];
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar4 = *piVar3;
		  (**(code **)((ulonglong)*(uint *)(iVar4 + 0x160) * 4))
		            (piVar3,*(undefined4 *)(iVar2 + 0x14),*(undefined4 *)(iVar4 + 0x164));
		  return param1[6];
		}
		*/

		}

		// Token: 0x0600406B RID: 16491 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600406B")]
		[Address(RVA = "0x8F25", Offset = "0x8F25", VA = "0x8F25")]
		private IHideableMediator ShowClanWarsRewardsTab()
		{
		/* --- GHIDRA: ShowClanWarsRewardsTab ---
		int Gameplay_Clans_Office_Controller_ClanWars_ClanWarsOfficeViewMediator__ShowClanWarsRewardsTab
		              (int *param1,undefined4 param2)
		
		{
		  undefined4 param4;
		  undefined4 uVar1;
		  int iVar2;
		  int *piVar3;
		  int iVar4;
		  
		  if (DAT_ram_00a57724 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_ClanWarsOfficeModel__ClanWarsOfficeEvents__ClanWarsOfficeController__ClanWarsView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_Clans_Office_Controller_ClanWars_ClanPoliticsViewMediator_TypeInfo);
		    DAT_ram_00a57724 = '\x01';
		  }
		  piVar3 = (int *)param1[7];
		  if (piVar3 == (int *)0x0) {
		    iVar2 = param1[2];
		    uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    param4 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                       (param1,*(undefined4 *)(*param1 + 0x14c));
		    piVar3 = (int *)unnamed_function_1417
		                              (
		                              Gameplay_Clans_Office_Controller_ClanWars_ClanPoliticsViewMediator_TypeInfo
		                              );
		    if (DAT_ram_00a576e8 == '\0') {
		      Mono_Security_ASN1__get_Item
		                (&
		                 Method_MVC_AbstractViewMediator_ClanWarsOfficeModel__ClanWarsOfficeEvents__ClanWarsOfficeController__ClanPoliticsView___ctor__
		                );
		      DAT_ram_00a576e8 = '\x01';
		    }
		    Gameplay_Combat_TeamCombat_View_AbstractTeamCombatView_object___get_HideInstantElements
		              (piVar3,iVar2,uVar1,param4,
		               Method_MVC_AbstractViewMediator_ClanWarsOfficeModel__ClanWarsOfficeEvents__ClanWarsOfficeController__ClanPoliticsView___ctor__
		              );
		    param1[7] = (int)piVar3;
		  }
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x13c));
		  (**(code **)((ulonglong)*(uint *)(*piVar3 + 0x140) * 4))
		            (piVar3,uVar1,*(undefined4 *)(*piVar3 + 0x144));
		  piVar3 = (int *)param1[7];
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar4 = *piVar3;
		  (**(code **)((ulonglong)*(uint *)(iVar4 + 0x160) * 4))
		            (piVar3,*(undefined4 *)(iVar2 + 0x18),*(undefined4 *)(iVar4 + 0x164));
		  return param1[7];
		}
		*/

			return null;
		}

		// Token: 0x0600406C RID: 16492 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600406C")]
		[Address(RVA = "0x8F26", Offset = "0x8F26", VA = "0x8F26")]
		private IHideableMediator ShowClanPoliticsTab()
		{
		/* --- GHIDRA: ShowClanPoliticsTab ---
		int Gameplay_Clans_Office_Controller_ClanWars_ClanWarsOfficeViewMediator__ShowClanPoliticsTab
		              (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  int *piVar2;
		  int iVar3;
		  
		  piVar2 = (int *)param1[8];
		  if (piVar2 == (int *)0x0) {
		    Gameplay_Clans_Office_Controller_ClanWars_ClanWarsOfficeViewMediator__Dispose(param1,param1);
		  }
		  else {
		    (**(code **)((ulonglong)*(uint *)(*piVar2 + 0x140) * 4))
		              (piVar2,param1[0xb],*(undefined4 *)(*piVar2 + 0x144));
		  }
		  piVar2 = (int *)param1[8];
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar3 = *piVar2;
		  (**(code **)((ulonglong)*(uint *)(iVar3 + 0x160) * 4))
		            (piVar2,*(undefined4 *)(iVar1 + 0x1c),*(undefined4 *)(iVar3 + 0x164));
		  return param1[8];
		}
		*/

			return null;
		}

		// Token: 0x0600406D RID: 16493 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600406D")]
		[Address(RVA = "0x8F27", Offset = "0x8F27", VA = "0x8F27")]
		private IHideableMediator ShowHistoryTab()
		{
		/* --- GHIDRA: ShowHistoryTab ---
		void Gameplay_Clans_Office_Controller_ClanWars_ClanWarsOfficeViewMediator__ShowHistoryTab
		               (int *param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 uVar3;
		  int *param1_00;
		  int iVar4;
		  
		  if (DAT_ram_00a57725 == '\0') {
		    Mono_Security_ASN1__get_Item(&MVC_Interfaces_IHideableMediator_TypeInfo);
		    DAT_ram_00a57725 = '\x01';
		  }
		  param1_00 = (int *)param1[10];
		  iVar4 = *param1_00;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (MVC_Interfaces_IHideableMediator_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8))
		      {
		        puVar2 = (uint *)(iVar4 + *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x80dd0e48;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_00,MVC_Interfaces_IHideableMediator_TypeInfo,0);
		code_r0x80dd0e48:
		  (**(code **)((ulonglong)*puVar2 * 4))(param1_00,puVar2[1]);
		  (**(code **)((ulonglong)*(uint *)(*param1 + 0x140) * 4))
		            (param1,0,*(undefined4 *)(*param1 + 0x144));
		  uVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar3 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (uVar3,0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar3,0,0);
		  return;
		}
		*/

			return null;
		}

		// Token: 0x0600406E RID: 16494 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600406E")]
		[Address(RVA = "0x8F28", Offset = "0x8F28", VA = "0x8F28", Slot = "21")]
		public void Hide()
		{
		/* --- GHIDRA: Hide ---
		void Gameplay_Clans_Office_Controller_ClanWars_ClanWarsOfficeViewMediator__Hide
		               (int param1,undefined4 param2)
		
		{
		  int *piVar1;
		  int *piVar2;
		  int iVar3;
		  
		  if (DAT_ram_00a57726 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_ClanWarsOfficeModel__ClanWarsOfficeEvents__ClanWarsOfficeController__ClanWarsView__Dispose__
		              );
		    DAT_ram_00a57726 = '\x01';
		  }
		  piVar2 = *(int **)(param1 + 0x1c);
		  if (piVar2 != (int *)0x0) {
		    (**(code **)((ulonglong)*(uint *)(*piVar2 + 0x130) * 4))
		              (piVar2,*(undefined4 *)(*piVar2 + 0x134));
		  }
		  piVar2 = *(int **)(param1 + 0x18);
		  if (piVar2 != (int *)0x0) {
		    (**(code **)((ulonglong)*(uint *)(*piVar2 + 0x130) * 4))
		              (piVar2,*(undefined4 *)(*piVar2 + 0x134));
		  }
		  piVar2 = *(int **)(param1 + 0x20);
		  if (piVar2 != (int *)0x0) {
		    piVar2 = (int *)(**(code **)((ulonglong)*(uint *)(*piVar2 + 0x148) * 4))
		                              (piVar2,*(undefined4 *)(*piVar2 + 0x14c));
		    piVar1 = (int *)(**(code **)((ulonglong)*(uint *)(*piVar2 + 0x100) * 4))
		                              (piVar2,*(undefined4 *)(*piVar2 + 0x104));
		    MVC_AbstractController__Run(piVar2,0);
		    iVar3 = **(int **)(param1 + 0x20);
		    (**(code **)((ulonglong)*(uint *)(iVar3 + 0x130) * 4))
		              (*(int **)(param1 + 0x20),*(undefined4 *)(iVar3 + 0x134));
		    (**(code **)((ulonglong)*(uint *)(*piVar2 + 0xe8) * 4))(piVar2,*(undefined4 *)(*piVar2 + 0xec));
		    (**(code **)((ulonglong)*(uint *)(*piVar1 + 0xe8) * 4))(piVar1,*(undefined4 *)(*piVar1 + 0xec));
		  }
		  MVC_AbstractViewMediator_object__object__object__object___Core_MVC_Interfaces_IViewMediator_set_View
		            (param1,
		             Method_MVC_AbstractViewMediator_ClanWarsOfficeModel__ClanWarsOfficeEvents__ClanWarsOfficeController__ClanWarsView__Dispose__
		            );
		  return;
		}
		*/

		}

		// Token: 0x0600406F RID: 16495 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600406F")]
		[Address(RVA = "0x8F29", Offset = "0x8F29", VA = "0x8F29", Slot = "14")]
		public override void Dispose()
		{
		/* --- GHIDRA: Dispose ---
		void Gameplay_Clans_Office_Controller_ClanWars_ClanWarsOfficeViewMediator__Dispose
		               (int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  undefined4 param1_00;
		  int param1_01;
		  undefined4 uVar2;
		  
		  if (DAT_ram_00a57727 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_ClanWarsOfficeModel__ClanWarsOfficeEvents__ClanWarsOfficeController__ClanWarsView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_Clans_Office_Controller_ClanWars_ClanWarsHistoryController_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_Clans_Office_Events_ClanWars_ClanWarsHistoryEvents_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_Clans_Office_Model_ClanWars_ClanWarsHistoryModel_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_Clans_Office_Controller_ClanWars_ClanWarsHistoryViewMediator_TypeInfo);
		    DAT_ram_00a57727 = '\x01';
		  }
		  uVar2 = *(undefined4 *)(*(int *)(param1 + 8) + 8);
		  uVar1 = Gameplay_Clans_Office_Model_ClanResumesModel___c__DisplayClass13_0___AddUsersList_b__0
		                    (*(int *)(param1 + 8),0);
		  param1_00 = unnamed_function_1417
		                        (Gameplay_Clans_Office_Model_ClanWars_ClanWarsHistoryModel_TypeInfo);
		  Gameplay_Clans_Office_Model_SquadModel___c__DisplayClass15_1___ParsePartyChanges_b__1
		            (param1_00,uVar2,uVar1,0);
		  uVar1 = unnamed_function_1417
		                    (Gameplay_Clans_Office_Events_ClanWars_ClanWarsHistoryEvents_TypeInfo);
		  *(undefined4 *)(param1 + 0x2c) = uVar1;
		  param1_01 = unnamed_function_1417
		                        (
		                        Gameplay_Clans_Office_Controller_ClanWars_ClanWarsHistoryController_TypeInfo
		                        );
		  if (DAT_ram_00a576fc == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_MVC_AbstractController_ClanWarsHistoryModel__ClanWarsHistoryEvents___ctor__);
		    Mono_Security_ASN1__get_Item(&Method_Core_Net_ServiceFactory_GetService_ClanWarsService___);
		    Mono_Security_ASN1__get_Item(&Core_Net_ServiceFactory_TypeInfo);
		    DAT_ram_00a576fc = '\x01';
		  }
		  Gameplay_Combat_AbstractCombat_object__object__object__object__object___set_User
		            (param1_01,param1_00,uVar1,
		             Method_MVC_AbstractController_ClanWarsHistoryModel__ClanWarsHistoryEvents___ctor__);
		  if (*(int *)(Core_Net_ServiceFactory_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Net_ServiceFactory_TypeInfo);
		  }
		  uVar1 = Core_Gameplay_Managers_LoggedManager__RequestLogin
		                    (Method_Core_Net_ServiceFactory_GetService_ClanWarsService___);
		  *(undefined4 *)(param1_01 + 0x18) = uVar1;
		  uVar2 = *(undefined4 *)(param1 + 0x2c);
		  uVar1 = unnamed_function_1417
		                    (Gameplay_Clans_Office_Controller_ClanWars_ClanWarsHistoryViewMediator_TypeInfo)
		  ;
		  if (DAT_ram_00a57705 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_ClanWarsHistoryModel__ClanWarsHistoryEvents__ClanWarsHistoryController__ClanWarsHistoryView___ctor__
		              );
		    DAT_ram_00a57705 = '\x01';
		  }
		  Gameplay_Combat_TeamCombat_View_AbstractTeamCombatView_object___get_HideInstantElements
		            (uVar1,param1_00,uVar2,param1_01,
		             Method_MVC_AbstractViewMediator_ClanWarsHistoryModel__ClanWarsHistoryEvents__ClanWarsHistoryController__ClanWarsHistoryView___ctor__
		            );
		  *(undefined4 *)(param1 + 0x20) = uVar1;
		  MVC_AbstractController__Dispose(param1_01,0);
		  return;
		}
		*/

		}

		// Token: 0x06004070 RID: 16496 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004070")]
		[Address(RVA = "0x8F2A", Offset = "0x8F2A", VA = "0x8F2A")]
		[CompilerGenerated]
		private void <ShowHistoryTab>g__CreateClanWarsHistoryMVC|17_0()
		{
		}

		// Token: 0x040023D8 RID: 9176
		[Token(Token = "0x40023D8")]
		[FieldOffset(Offset = "0x18")]
		private ClanWarsRewardsViewMediator _clanWarsRewardsViewMediator;

		// Token: 0x040023D9 RID: 9177
		[Token(Token = "0x40023D9")]
		[FieldOffset(Offset = "0x1C")]
		private ClanPoliticsViewMediator _clanPoliticsViewMediator;

		// Token: 0x040023DA RID: 9178
		[Token(Token = "0x40023DA")]
		[FieldOffset(Offset = "0x20")]
		private ClanWarsHistoryViewMediator _clanWarsHistoryViewMediator;

		// Token: 0x040023DB RID: 9179
		[Token(Token = "0x40023DB")]
		[FieldOffset(Offset = "0x24")]
		private Dictionary<uint, Func<IHideableMediator>> _tabsOpenersById;

		// Token: 0x040023DC RID: 9180
		[Token(Token = "0x40023DC")]
		[FieldOffset(Offset = "0x28")]
		private IHideableMediator _currentMediator;

		// Token: 0x040023DD RID: 9181
		[Token(Token = "0x40023DD")]
		[FieldOffset(Offset = "0x2C")]
		private ClanWarsHistoryEvents _clanWarsHistoryEvents;

		// Token: 0x040023DE RID: 9182
		[Token(Token = "0x40023DE")]
		[FieldOffset(Offset = "0x30")]
		private bool _isInit;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_View ---
		void Gameplay_Clans_Office_Controller_ClanWars_ClanWarsOfficeViewMediator__set_View
		               (int *param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  int iVar2;
		  undefined4 uVar3;
		  int *piVar4;
		  undefined4 uVar5;
		  
		  if (DAT_ram_00a5771f == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_ClanWarsOfficeModel__ClanWarsOfficeEvents__ClanWarsOfficeController__ClanWarsView__set_Events__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Clans_Office_Controller_ClanWars_ClanWarsOfficeViewMediator_InitEventHandler__
		              );
		    DAT_ram_00a5771f = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x13c));
		  if (iVar1 != 0) {
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar5 = *(undefined4 *)(iVar2 + 8);
		    uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar3,param1,
		               Method_Gameplay_Clans_Office_Controller_ClanWars_ClanWarsOfficeViewMediator_InitEventHandler__
		               ,0);
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
		  }
		  param1[3] = param2;
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x13c));
		  if (iVar1 != 0) {
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar5 = *(undefined4 *)(iVar2 + 8);
		    uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar3,param1,
		               Method_Gameplay_Clans_Office_Controller_ClanWars_ClanWarsOfficeViewMediator_InitEventHandler__
		               ,0);
		    piVar4 = (int *)UnityEngine_UI_Image__set_sprite(uVar5,uVar3,0);
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


		/* --- GHIDRA: set_Events ---
		void Gameplay_Clans_Office_Controller_ClanWars_ClanWarsOfficeViewMediator__set_Events
		               (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 param2_00;
		  undefined4 param1_00;
		  int param1_01;
		  
		  if (DAT_ram_00a57720 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_ClanWarsOfficeModel__ClanWarsOfficeEvents__ClanWarsOfficeController__ClanWarsView__get_Model__
		              );
		    DAT_ram_00a57720 = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  param1_00 = *(undefined4 *)(iVar1 + 0x10);
		  param2_00 = Gameplay_Clans_Office_Model_ClanWarsOfficeModel__InitClanData(param1[2],0);
		  UI_Tabs_TabBar__HandleSelected(param1_00,param2_00,0);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  Gameplay_GameEvents_Model_GameEventData__get_ContainsArtifactRewards
		            (*(undefined4 *)(iVar1 + 0x10),0,1,0);
		  *(undefined1 *)(param1 + 0xc) = 1;
		  if (DAT_ram_00a57722 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_uint__Func_IHideableMediator___get_Item__
		              );
		    DAT_ram_00a57722 = '\x01';
		  }
		  param1_01 = param1[9];
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar1 = UI_Tabs_TabBar__get_SelectedIndex(*(undefined4 *)(iVar1 + 0x10),0);
		  iVar1 = System_Collections_Generic_List_object___get_Item
		                    (param1_01,*(undefined4 *)(iVar1 + 0x14),
		                     Method_System_Collections_Generic_Dictionary_uint__Func_IHideableMediator___get_Item__
		                    );
		  iVar1 = (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		                    (*(undefined4 *)(iVar1 + 0x20),*(undefined4 *)(iVar1 + 0x14));
		  param1[10] = iVar1;
		  return;
		}
		*/

}
