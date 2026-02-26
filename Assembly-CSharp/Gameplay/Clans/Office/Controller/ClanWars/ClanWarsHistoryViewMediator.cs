using System;
using Gameplay.Clans.Office.Events.ClanWars;
using Gameplay.Clans.Office.Model.ClanWars;
using Gameplay.Clans.Office.View.ClanWarsTab.ClanWarsHistoryTab;
using Il2CppDummyDll;
using MVC;
using MVC.Interfaces;

namespace Gameplay.Clans.Office.Controller.ClanWars
{
	// Token: 0x02000A83 RID: 2691
	[Token(Token = "0x2000A83")]
	public class ClanWarsHistoryViewMediator : AbstractViewMediator<ClanWarsHistoryModel, ClanWarsHistoryEvents, ClanWarsHistoryController, ClanWarsHistoryView>, IHideableMediator
	{
		// Token: 0x06004044 RID: 16452 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004044")]
		[Address(RVA = "0x8EFE", Offset = "0x8EFE", VA = "0x8EFE")]
		public ClanWarsHistoryViewMediator(ClanWarsHistoryModel model, ClanWarsHistoryEvents events, ClanWarsHistoryController controller)
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Clans_Office_Controller_ClanWars_ClanWarsHistoryViewMediator___ctor
		               (int *param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  undefined4 uVar3;
		  undefined4 uVar4;
		  int *piVar5;
		  
		  if (DAT_ram_00a57706 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_ClanWarsHistoryModel__ClanWarsHistoryEvents__ClanWarsHistoryController__ClanWarsHistoryView__set_View__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Clans_Office_Controller_ClanWars_ClanWarsHistoryViewMediator_InfoButtonClickedEventHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Clans_Office_Controller_ClanWars_ClanWarsHistoryViewMediator_MembersButtonClickedEventHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Clans_Office_Controller_ClanWars_ClanWarsHistoryViewMediator_MoreItemsAfterNeededEventHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Clans_Office_Controller_ClanWars_ClanWarsHistoryViewMediator_WarButtonClickedEventHandler__
		              );
		    Mono_Security_ASN1__get_Item(&UnityEngine_Events_UnityAction_TypeInfo);
		    DAT_ram_00a57706 = '\x01';
		  }
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar2 = Cysharp_Threading_Tasks_CancellationTokenExtensions___cctor(uVar1,0);
		  if (iVar2 != 0) {
		    uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar3 = Gameplay_Clans_Office_View_ClanResumesTab_ClanResumesView__get_AdditionalButtons
		                      (uVar1,0);
		    uVar4 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar4,param1,
		               Method_Gameplay_Clans_Office_Controller_ClanWars_ClanWarsHistoryViewMediator_MoreItemsAfterNeededEventHandler__
		               ,0);
		    piVar5 = (int *)func_ii_7048(uVar3,uVar4,0);
		    if ((piVar5 != (int *)0x0) && (System_Action_TypeInfo != *piVar5)) {
		      System_Activator__CreateInstance(piVar5,System_Action_TypeInfo);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    Gameplay_Clans_Office_View_ClanResumesTab_ClanResumesView__get_MoreItemsAfterNeededEvent
		              (uVar1,piVar5,0);
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar3 = *(undefined4 *)(*(int *)(iVar2 + 0x24) + 0xb4);
		    uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		    Utils_ObjectUtils__IsNotNull
		              (uVar1,param1,
		               Method_Gameplay_Clans_Office_Controller_ClanWars_ClanWarsHistoryViewMediator_InfoButtonClickedEventHandler__
		               ,0);
		    UnityEngine_Events_UnityAction___ctor(uVar3,uVar1,0);
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar3 = *(undefined4 *)(*(int *)(iVar2 + 0x28) + 0xb4);
		    uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		    Utils_ObjectUtils__IsNotNull
		              (uVar1,param1,
		               Method_Gameplay_Clans_Office_Controller_ClanWars_ClanWarsHistoryViewMediator_MembersButtonClickedEventHandler__
		               ,0);
		    UnityEngine_Events_UnityAction___ctor(uVar3,uVar1,0);
		    uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    iVar2 = Gameplay_Clans_Office_View_ClanWarsTab_ClanWarsHistoryTab_ClanWarsHistoryView__get_MembersButton
		                      (uVar1,0);
		    uVar3 = *(undefined4 *)(iVar2 + 0xb4);
		    uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		    Utils_ObjectUtils__IsNotNull
		              (uVar1,param1,
		               Method_Gameplay_Clans_Office_Controller_ClanWars_ClanWarsHistoryViewMediator_WarButtonClickedEventHandler__
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
		    uVar3 = Gameplay_Clans_Office_View_ClanResumesTab_ClanResumesView__get_AdditionalButtons
		                      (uVar1,0);
		    uVar4 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar4,param1,
		               Method_Gameplay_Clans_Office_Controller_ClanWars_ClanWarsHistoryViewMediator_MoreItemsAfterNeededEventHandler__
		               ,0);
		    piVar5 = (int *)UnityEngine_UI_Image__set_sprite(uVar3,uVar4,0);
		    if ((piVar5 != (int *)0x0) && (System_Action_TypeInfo != *piVar5)) {
		      System_Activator__CreateInstance(piVar5,System_Action_TypeInfo);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    Gameplay_Clans_Office_View_ClanResumesTab_ClanResumesView__get_MoreItemsAfterNeededEvent
		              (uVar1,piVar5,0);
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar3 = *(undefined4 *)(*(int *)(iVar2 + 0x24) + 0xb4);
		    uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		    Utils_ObjectUtils__IsNotNull
		              (uVar1,param1,
		               Method_Gameplay_Clans_Office_Controller_ClanWars_ClanWarsHistoryViewMediator_InfoButtonClickedEventHandler__
		               ,0);
		    Gameplay_Boss_View_CaptainTab_BossInfoView__add_AttackButtonClickEvent(uVar3,uVar1,0);
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar3 = *(undefined4 *)(*(int *)(iVar2 + 0x28) + 0xb4);
		    uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		    Utils_ObjectUtils__IsNotNull
		              (uVar1,param1,
		               Method_Gameplay_Clans_Office_Controller_ClanWars_ClanWarsHistoryViewMediator_MembersButtonClickedEventHandler__
		               ,0);
		    Gameplay_Boss_View_CaptainTab_BossInfoView__add_AttackButtonClickEvent(uVar3,uVar1,0);
		    uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    iVar2 = Gameplay_Clans_Office_View_ClanWarsTab_ClanWarsHistoryTab_ClanWarsHistoryView__get_MembersButton
		                      (uVar1,0);
		    uVar3 = *(undefined4 *)(iVar2 + 0xb4);
		    uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		    Utils_ObjectUtils__IsNotNull
		              (uVar1,param1,
		               Method_Gameplay_Clans_Office_Controller_ClanWars_ClanWarsHistoryViewMediator_WarButtonClickedEventHandler__
		               ,0);
		    Gameplay_Boss_View_CaptainTab_BossInfoView__add_AttackButtonClickEvent(uVar3,uVar1,0);
		    Gameplay_Clans_Office_Controller_ClanWars_ClanWarsHistoryViewMediator__set_View(param1,param1);
		  }
		  return;
		}
		*/

		}

		// Token: 0x17000CB1 RID: 3249
		// (set) Token: 0x06004045 RID: 16453 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000CB1")]
		public override ClanWarsHistoryView View
		{
			[Token(Token = "0x6004045")]
			[Address(RVA = "0x8EFF", Offset = "0x8EFF", VA = "0x8EFF", Slot = "20")]
			set
			{
			}
		}

		// Token: 0x06004046 RID: 16454 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004046")]
		[Address(RVA = "0x8F00", Offset = "0x8F00", VA = "0x8F00")]
		private void Init()
		{
		/* --- GHIDRA: Init ---
		void Gameplay_Clans_Office_Controller_ClanWars_ClanWarsHistoryViewMediator__Init
		               (int *param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  undefined4 param3;
		  
		  if (DAT_ram_00a57708 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_ClanWarsHistoryModel__ClanWarsHistoryEvents__ClanWarsHistoryController__ClanWarsHistoryView__get_Model__
		              );
		    DAT_ram_00a57708 = '\x01';
		  }
		  param1_00 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x14c));
		  param3 = Gameplay_Clans_Office_Model_ClanWars_ClanWarsHistoryModel___ctor(param1[2],0);
		  Gameplay_Clans_Office_Controller_ClanWars_ClanWarsHistoryController__ClanWarDeclaredEventHandler
		            (param1_00,100,param3,param1);
		  return;
		}
		*/

		}

		// Token: 0x06004047 RID: 16455 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004047")]
		[Address(RVA = "0x8F01", Offset = "0x8F01", VA = "0x8F01")]
		private void MoreItemsAfterNeededEventHandler()
		{
		/* --- GHIDRA: MoreItemsAfterNeededEventHandler ---
		void Gameplay_Clans_Office_Controller_ClanWars_ClanWarsHistoryViewMediator__MoreItemsAfterNeededEventHandler
		               (int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 param1_00;
		  int *param1_01;
		  int iVar3;
		  
		  if (DAT_ram_00a57709 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a57709 = '\x01';
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
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + iVar3 + 0x240);
		        goto code_r0x80dceec6;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_01,Core_Gameplay_IGame_TypeInfo,0x30);
		code_r0x80dceec6:
		  param1_00 = (**(code **)((ulonglong)*puVar2 * 4))(param1_01,puVar2[1]);
		  Core_Gameplay_Managers_ClanWarsManager__ShowDeclareWarDialogWindow
		            (param1_00,*(undefined4 *)(*(int *)(param1 + 0x18) + 0x20),0);
		  return;
		}
		*/

		}

		// Token: 0x06004048 RID: 16456 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004048")]
		[Address(RVA = "0x8F02", Offset = "0x8F02", VA = "0x8F02")]
		private void WarButtonClickedEventHandler()
		{
		/* --- GHIDRA: WarButtonClickedEventHandler ---
		void Gameplay_Clans_Office_Controller_ClanWars_ClanWarsHistoryViewMediator__WarButtonClickedEventHandler
		               (int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  undefined4 in_register_20000014;
		  uint *puVar2;
		  undefined4 param1_00;
		  int *param1_01;
		  int iVar3;
		  
		  if (DAT_ram_00a5770a == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a5770a = '\x01';
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
		        goto code_r0x80dcefa3;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_01,Core_Gameplay_IGame_TypeInfo,0x2e);
		code_r0x80dcefa3:
		  param1_00 = (**(code **)((ulonglong)*puVar2 * 4))
		                        (param1_01,CONCAT44(in_register_20000014,puVar2[1]));
		  Core_Gameplay_Managers_ClansManager__DissociateClanFromUser
		            (param1_00,*(undefined8 *)(*(int *)(*(int *)(param1 + 0x18) + 0x20) + 0x10),1,0);
		  return;
		}
		*/

		}

		// Token: 0x06004049 RID: 16457 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004049")]
		[Address(RVA = "0x8F03", Offset = "0x8F03", VA = "0x8F03")]
		private void MembersButtonClickedEventHandler()
		{
		/* --- GHIDRA: MembersButtonClickedEventHandler ---
		void Gameplay_Clans_Office_Controller_ClanWars_ClanWarsHistoryViewMediator__MembersButtonClickedEventHandler
		               (int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  undefined4 in_register_20000014;
		  uint *puVar2;
		  undefined4 param1_00;
		  int *param1_01;
		  int iVar3;
		  
		  if (DAT_ram_00a5770b == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a5770b = '\x01';
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
		        goto code_r0x80dcf084;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_01,Core_Gameplay_IGame_TypeInfo,0x2e);
		code_r0x80dcf084:
		  param1_00 = (**(code **)((ulonglong)*puVar2 * 4))
		                        (param1_01,CONCAT44(in_register_20000014,puVar2[1]));
		  Core_Gameplay_Managers_ClansManager__DissociateClanFromUser
		            (param1_00,*(undefined8 *)(*(int *)(*(int *)(param1 + 0x18) + 0x20) + 0x10),0,0);
		  return;
		}
		*/

		}

		// Token: 0x0600404A RID: 16458 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600404A")]
		[Address(RVA = "0x8F04", Offset = "0x8F04", VA = "0x8F04")]
		private void InfoButtonClickedEventHandler()
		{
		/* --- GHIDRA: InfoButtonClickedEventHandler ---
		void Gameplay_Clans_Office_Controller_ClanWars_ClanWarsHistoryViewMediator__InfoButtonClickedEventHandler
		               (int *param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  int iVar2;
		  undefined4 uVar3;
		  int *piVar4;
		  undefined4 uVar5;
		  
		  if (DAT_ram_00a5770c == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_ClanWarsHistoryModel__ClanWarsHistoryEvents__ClanWarsHistoryController__ClanWarsHistoryView__set_Events__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Clans_Office_Controller_ClanWars_ClanWarsHistoryViewMediator_ClanWarDeclaredEventHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Clans_Office_Controller_ClanWars_ClanWarsHistoryViewMediator_FirstHistoryRequestedEventHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Clans_Office_Controller_ClanWars_ClanWarsHistoryViewMediator_HistoryRequestedEventHandler__
		              );
		    DAT_ram_00a5770c = '\x01';
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
		               Method_Gameplay_Clans_Office_Controller_ClanWars_ClanWarsHistoryViewMediator_FirstHistoryRequestedEventHandler__
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
		               Method_Gameplay_Clans_Office_Controller_ClanWars_ClanWarsHistoryViewMediator_HistoryRequestedEventHandler__
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
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar5 = *(undefined4 *)(iVar2 + 0x1c);
		    uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar3,param1,
		               Method_Gameplay_Clans_Office_Controller_ClanWars_ClanWarsHistoryViewMediator_ClanWarDeclaredEventHandler__
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
		    uVar5 = *(undefined4 *)(iVar2 + 0x14);
		    uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar3,param1,
		               Method_Gameplay_Clans_Office_Controller_ClanWars_ClanWarsHistoryViewMediator_FirstHistoryRequestedEventHandler__
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
		               Method_Gameplay_Clans_Office_Controller_ClanWars_ClanWarsHistoryViewMediator_HistoryRequestedEventHandler__
		               ,0);
		    piVar4 = (int *)UnityEngine_UI_Image__set_sprite(uVar5,uVar3,0);
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
		    uVar5 = *(undefined4 *)(iVar2 + 0x1c);
		    uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar3,param1,
		               Method_Gameplay_Clans_Office_Controller_ClanWars_ClanWarsHistoryViewMediator_ClanWarDeclaredEventHandler__
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

		// Token: 0x17000CB2 RID: 3250
		// (set) Token: 0x0600404B RID: 16459 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000CB2")]
		public override ClanWarsHistoryEvents Events
		{
			[Token(Token = "0x600404B")]
			[Address(RVA = "0x8F05", Offset = "0x8F05", VA = "0x8F05", Slot = "16")]
			set
			{
			}
		}

		// Token: 0x0600404C RID: 16460 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600404C")]
		[Address(RVA = "0x8F06", Offset = "0x8F06", VA = "0x8F06")]
		private void ClanWarDeclaredEventHandler()
		{
		/* --- GHIDRA: ClanWarDeclaredEventHandler ---
		void Gameplay_Clans_Office_Controller_ClanWars_ClanWarsHistoryViewMediator__ClanWarDeclaredEventHandler
		               (int *param1,undefined4 param2)
		
		{
		  uint uVar1;
		  int *param2_00;
		  undefined4 uVar2;
		  uint *puVar3;
		  int iVar4;
		  
		  if (DAT_ram_00a5770d == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_ClanWarsHistoryModel__ClanWarsHistoryEvents__ClanWarsHistoryController__ClanWarsHistoryView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               System_Collections_Generic_ICollection_ClanWarHistoryListElement_ClanWarHistoryListElementArgs__TypeInfo
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               System_Collections_Generic_IList_ClanWarHistoryListElement_ClanWarHistoryListElementArgs__TypeInfo
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_MonoBehaviourWithStates_ClanWarsHistoryView_HistoryState__set_CurrentState__
		              );
		    DAT_ram_00a5770d = '\x01';
		  }
		  Gameplay_Clans_Office_Controller_ClanWars_ClanWarsHistoryViewMediator__UpdateOSARequestBounds
		            (param1,0);
		  Gameplay_Clans_Office_Controller_ClanWars_ClanWarsHistoryViewMediator__HistoryRequestedEventHandler
		            (param1,0);
		  param2_00 = (int *)Gameplay_Clans_Office_Model_ClanWars_ClanWarsHistoryModel__get_LastWarId
		                               (param1[2],0);
		  uVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  Gameplay_Clans_Office_View_ClanWarsTab_ClanWarsHistoryTab_ClanWarsHistoryView__set_MoreItemsAfterNeededEvent
		            (uVar2,param2_00,0);
		  iVar4 = *param2_00;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (System_Collections_Generic_ICollection_ClanWarHistoryListElement_ClanWarHistoryListElementArgs__TypeInfo
		          == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(iVar4 + *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x80dcf629;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(param2_00,
		                                System_Collections_Generic_ICollection_ClanWarHistoryListElement_ClanWarHistoryListElementArgs__TypeInfo
		                                ,0);
		code_r0x80dcf629:
		  iVar4 = (**(code **)((ulonglong)*puVar3 * 4))(param2_00,puVar3[1]);
		  uVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  if (iVar4 < 1) {
		    Gameplay_Boss_View_CaptainTab_BossTeamView__set_TeamInfoData
		              (uVar2,2,
		               Method_UI_MonoBehaviourWithStates_ClanWarsHistoryView_HistoryState__set_CurrentState__
		              );
		    return;
		  }
		  Gameplay_Boss_View_CaptainTab_BossTeamView__set_TeamInfoData
		            (uVar2,1,
		             Method_UI_MonoBehaviourWithStates_ClanWarsHistoryView_HistoryState__set_CurrentState__)
		  ;
		  iVar4 = *param2_00;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (System_Collections_Generic_IList_ClanWarHistoryListElement_ClanWarHistoryListElementArgs__TypeInfo
		          == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(iVar4 + *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x80dcf6de;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(param2_00,
		                                System_Collections_Generic_IList_ClanWarHistoryListElement_ClanWarHistoryListElementArgs__TypeInfo
		                                ,0);
		code_r0x80dcf6de:
		  uVar2 = (**(code **)((ulonglong)*puVar3 * 4))(param2_00,0,puVar3[1]);
		  Gameplay_Clans_Office_Controller_ClanWars_ClanWarsHistoryViewMediator__ListElementClickedEventHandler
		            (param1,uVar2,puVar3);
		  return;
		}
		*/

		}

		// Token: 0x0600404D RID: 16461 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600404D")]
		[Address(RVA = "0x8F07", Offset = "0x8F07", VA = "0x8F07")]
		private void FirstHistoryRequestedEventHandler()
		{
		/* --- GHIDRA: FirstHistoryRequestedEventHandler ---
		void Gameplay_Clans_Office_Controller_ClanWars_ClanWarsHistoryViewMediator__FirstHistoryRequestedEventHandler
		               (int *param1,undefined4 param2)
		
		{
		  undefined4 param2_00;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a5770e == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_ClanWarsHistoryModel__ClanWarsHistoryEvents__ClanWarsHistoryController__ClanWarsHistoryView__get_Model__
		              );
		    DAT_ram_00a5770e = '\x01';
		  }
		  Gameplay_Clans_Office_Controller_ClanWars_ClanWarsHistoryViewMediator__UpdateOSARequestBounds
		            (param1,param1);
		  Gameplay_Clans_Office_Controller_ClanWars_ClanWarsHistoryViewMediator__HistoryRequestedEventHandler
		            (param1,param1);
		  param2_00 = Gameplay_Clans_Office_Model_ClanWars_ClanWarsHistoryModel__get_LastWarId(param1[2],0);
		  param1_00 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x15c));
		  Gameplay_Clans_Office_View_ClanResumesTab_ClanResumesView__Init(param1_00,param2_00,0);
		  return;
		}
		*/

		}

		// Token: 0x0600404E RID: 16462 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600404E")]
		[Address(RVA = "0x8F08", Offset = "0x8F08", VA = "0x8F08")]
		private void HistoryRequestedEventHandler()
		{
		/* --- GHIDRA: HistoryRequestedEventHandler ---
		void Gameplay_Clans_Office_Controller_ClanWars_ClanWarsHistoryViewMediator__HistoryRequestedEventHandler
		               (int *param1,undefined4 param2)
		
		{
		  uint uVar1;
		  int *param1_00;
		  uint *puVar2;
		  undefined4 param1_01;
		  int iVar3;
		  
		  if (DAT_ram_00a5770f == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_ClanWarsHistoryModel__ClanWarsHistoryEvents__ClanWarsHistoryController__ClanWarsHistoryView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               System_Collections_Generic_ICollection_ClanWarHistoryListElement_ClanWarHistoryListElementArgs__TypeInfo
		              );
		    DAT_ram_00a5770f = '\x01';
		  }
		  param1_00 = (int *)Gameplay_Clans_Office_Model_ClanWars_ClanWarsHistoryModel__get_LastWarId
		                               (param1[2],0);
		  iVar3 = *param1_00;
		  if (*(ushort *)(iVar3 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (System_Collections_Generic_ICollection_ClanWarHistoryListElement_ClanWarHistoryListElementArgs__TypeInfo
		          == *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(iVar3 + *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x80dcfc2a;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_00,
		                                System_Collections_Generic_ICollection_ClanWarHistoryListElement_ClanWarHistoryListElementArgs__TypeInfo
		                                ,0);
		code_r0x80dcfc2a:
		  iVar3 = (**(code **)((ulonglong)*puVar2 * 4))(param1_00,puVar2[1]);
		  param1_01 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x15c));
		  Gameplay_Clans_Office_View_ClanWarsTab_ClanWarsHistoryTab_ClanWarsHistoryView__Remove
		            (param1_01,(uint)(iVar3 == 100),0);
		  return;
		}
		*/

		}

		// Token: 0x0600404F RID: 16463 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600404F")]
		[Address(RVA = "0x8F09", Offset = "0x8F09", VA = "0x8F09")]
		private void UpdateOSARequestBounds()
		{
		/* --- GHIDRA: UpdateOSARequestBounds ---
		void Gameplay_Clans_Office_Controller_ClanWars_ClanWarsHistoryViewMediator__UpdateOSARequestBounds
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
		  
		  if (DAT_ram_00a57710 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_ClanWarsHistoryModel__ClanWarsHistoryEvents__ClanWarsHistoryController__ClanWarsHistoryView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_ClanWarHistoryListElement__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Clans_Office_Controller_ClanWars_ClanWarsHistoryViewMediator_ListElementClickedEventHandler__
		              );
		    Mono_Security_ASN1__get_Item(&System_IDisposable_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               System_Collections_Generic_IEnumerable_ClanWarHistoryListElement_ClanWarHistoryListElementArgs__TypeInfo
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               System_Collections_Generic_IEnumerator_ClanWarHistoryListElement_ClanWarHistoryListElementArgs__TypeInfo
		              );
		    Mono_Security_ASN1__get_Item(&System_Collections_IEnumerator_TypeInfo);
		    DAT_ram_00a57710 = '\x01';
		  }
		  piVar2 = (int *)Gameplay_Clans_Office_Model_ClanWars_ClanWarsHistoryModel__get_LastWarId
		                            (*(undefined4 *)(param1 + 8),0);
		  iVar8 = *piVar2;
		  if (*(ushort *)(iVar8 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (System_Collections_Generic_IEnumerable_ClanWarHistoryListElement_ClanWarHistoryListElementArgs__TypeInfo
		          == *(int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(iVar8 + *(int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x80dcf7d8;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar8 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(piVar2,
		                                System_Collections_Generic_IEnumerable_ClanWarHistoryListElement_ClanWarHistoryListElementArgs__TypeInfo
		                                ,0);
		code_r0x80dcf7d8:
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
		          goto code_r0x80dcf8a3;
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
		code_r0x80dcfa53:
		      DAT_ram_009d3e38 = 0;
		      uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80dcfa5b;
		    }
		code_r0x80dcf8a3:
		    DAT_ram_009d3e38 = 0;
		    iVar8 = import::env::invoke_iii(*puVar4,piVar2,puVar4[1]);
		    piVar2 = local_4;
		    if (DAT_ram_009d3e38 == 1) goto code_r0x80dcfa53;
		    if (iVar8 == 0) {
		      iVar8 = 0;
		      goto code_r0x80dcfaa4;
		    }
		    iVar8 = *local_4;
		    if (*(ushort *)(iVar8 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        piVar7 = (int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8);
		        if (System_Collections_Generic_IEnumerator_ClanWarHistoryListElement_ClanWarHistoryListElementArgs__TypeInfo
		            == *piVar7) {
		          puVar4 = (undefined4 *)(iVar8 + piVar7[1] * 8 + 0xc0);
		          goto code_r0x80dcf97d;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar8 + 0xb6) != uVar1);
		    }
		    DAT_ram_009d3e38 = 0;
		    puVar4 = (undefined4 *)
		             import::env::invoke_iiii
		                       (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                        System_Collections_Generic_IEnumerator_ClanWarHistoryListElement_ClanWarHistoryListElementArgs__TypeInfo
		                        ,0);
		    if (DAT_ram_009d3e38 == 1) {
		code_r0x80dcfa3f:
		      DAT_ram_009d3e38 = 0;
		      uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80dcfa5b;
		    }
		code_r0x80dcf97d:
		    DAT_ram_009d3e38 = 0;
		    iVar8 = import::env::invoke_iii(*puVar4,piVar2,puVar4[1]);
		    if (DAT_ram_009d3e38 == 1) goto code_r0x80dcfa3f;
		    DAT_ram_009d3e38 = 0;
		    uVar5 = import::env::invoke_ii
		                      (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x199,
		                       System_Action_ClanWarHistoryListElement__TypeInfo);
		    if (DAT_ram_009d3e38 == 1) break;
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_viiii
		              (s_struct_Uniforms___color__array<v_ram_000017c8 + 0x241,uVar5,param1,
		               Method_Gameplay_Clans_Office_Controller_ClanWars_ClanWarsHistoryViewMediator_ListElementClickedEventHandler__
		               ,0);
		    if (DAT_ram_009d3e38 == 1) break;
		    *(undefined4 *)(iVar8 + 0x18) = uVar5;
		  } while( true );
		  DAT_ram_009d3e38 = 0;
		  uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x80dcfa5b:
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
		code_r0x80dcfaa4:
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
		              goto code_r0x80dcfb1c;
		            }
		            uVar1 = uVar1 + 1;
		          } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		        }
		        puVar3 = (uint *)func_ii_1080(local_4,System_IDisposable_TypeInfo,0);
		code_r0x80dcfb1c:
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
		  import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_000017c8 + 0x353,&local_c);
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

		// Token: 0x06004050 RID: 16464 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004050")]
		[Address(RVA = "0x8F0A", Offset = "0x8F0A", VA = "0x8F0A")]
		private void InjectCallback()
		{
		/* --- GHIDRA: InjectCallback ---
		void Gameplay_Clans_Office_Controller_ClanWars_ClanWarsHistoryViewMediator__InjectCallback
		               (int param1,int param2,undefined4 param3)
		
		{
		  if (DAT_ram_00a57711 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Elements_GenericList_GenericListElement_ClanWarHistoryListElement_ClanWarHistoryListElementArgs__get_args__
		              );
		    DAT_ram_00a57711 = '\x01';
		  }
		  Gameplay_Clans_Office_View_ClanMembersTab_ClanMemberListElement_ClanMemberListElementArgs__get_Selected
		            (*(undefined4 *)(param1 + 0x18),0,0);
		  Gameplay_Clans_Office_Controller_ClanWars_ClanWarsHistoryViewMediator__ListElementClickedEventHandler
		            (param1,*(undefined4 *)(param2 + 0x18),param1);
		  return;
		}
		*/

		}

		// Token: 0x06004051 RID: 16465 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004051")]
		[Address(RVA = "0x8F0B", Offset = "0x8F0B", VA = "0x8F0B")]
		private void ListElementClickedEventHandler(ClanWarHistoryListElement element)
		{
		/* --- GHIDRA: ListElementClickedEventHandler ---
		void Gameplay_Clans_Office_Controller_ClanWars_ClanWarsHistoryViewMediator__ListElementClickedEventHandler
		               (int *param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  uint param2_00;
		  
		  param1[6] = param2;
		  Gameplay_Clans_Office_View_ClanMembersTab_ClanMemberListElement_ClanMemberListElementArgs__get_Selected
		            (param2,1,0);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  Gameplay_Clans_Office_View_ClanWarsTab_ClanWarsHistoryTab_ClanWarsHistoryInfoBox__Init
		            (*(undefined4 *)(iVar1 + 0x20),*(undefined4 *)(param1[6] + 0x20),
		             *(undefined4 *)(param1[6] + 0x24),0);
		  if (DAT_ram_00a57712 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_ClanWarsHistoryModel__ClanWarsHistoryEvents__ClanWarsHistoryController__ClanWarsHistoryView__get_Model__
		              );
		    DAT_ram_00a57712 = '\x01';
		  }
		  uVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar2 = Gameplay_Clans_Office_View_ClanWarsTab_ClanWarsHistoryTab_ClanWarsHistoryView__get_MembersButton
		                    (uVar2,0);
		  uVar2 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (uVar2,0);
		  iVar1 = Core_Data_UserData__get_ClanId(*(undefined4 *)(param1[2] + 8),0);
		  if (iVar1 == 0) {
		    param2_00 = 0;
		  }
		  else {
		    param2_00 = (uint)(-1 < *(int *)(*(int *)(param1[6] + 0x20) + 0x38));
		  }
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar2,param2_00,0);
		  return;
		}
		*/

		}

		// Token: 0x06004052 RID: 16466 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004052")]
		[Address(RVA = "0x8F0C", Offset = "0x8F0C", VA = "0x8F0C")]
		private void SelectArgs(ClanWarHistoryListElement.ClanWarHistoryListElementArgs args)
		{
		/* --- GHIDRA: SelectArgs ---
		void Gameplay_Clans_Office_Controller_ClanWars_ClanWarsHistoryViewMediator__SelectArgs
		               (int *param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  uint param2_00;
		  
		  if (DAT_ram_00a57712 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_ClanWarsHistoryModel__ClanWarsHistoryEvents__ClanWarsHistoryController__ClanWarsHistoryView__get_Model__
		              );
		    DAT_ram_00a57712 = '\x01';
		  }
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar1 = Gameplay_Clans_Office_View_ClanWarsTab_ClanWarsHistoryTab_ClanWarsHistoryView__get_MembersButton
		                    (uVar1,0);
		  uVar1 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (uVar1,0);
		  iVar2 = Core_Data_UserData__get_ClanId(*(undefined4 *)(param1[2] + 8),0);
		  if (iVar2 == 0) {
		    param2_00 = 0;
		  }
		  else {
		    param2_00 = (uint)(-1 < *(int *)(*(int *)(param1[6] + 0x20) + 0x38));
		  }
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar1,param2_00,0);
		  return;
		}
		*/

		}

		// Token: 0x06004053 RID: 16467 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004053")]
		[Address(RVA = "0x8F0D", Offset = "0x8F0D", VA = "0x8F0D")]
		private void ValidateWarButton()
		{
		/* --- GHIDRA: ValidateWarButton ---
		void Gameplay_Clans_Office_Controller_ClanWars_ClanWarsHistoryViewMediator__ValidateWarButton
		               (int *param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  
		  (**(code **)((ulonglong)*(uint *)(*param1 + 0x140) * 4))
		            (param1,0,*(undefined4 *)(*param1 + 0x144));
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar1 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (uVar1,0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar1,0,0);
		  return;
		}
		*/

		}

		// Token: 0x06004054 RID: 16468 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004054")]
		[Address(RVA = "0x8F0E", Offset = "0x8F0E", VA = "0x8F0E", Slot = "21")]
		public void Hide()
		{
		}

		// Token: 0x040023D3 RID: 9171
		[Token(Token = "0x40023D3")]
		public const uint LINES_COUNT = 100U;

		// Token: 0x040023D4 RID: 9172
		[Token(Token = "0x40023D4")]
		[FieldOffset(Offset = "0x18")]
		private ClanWarHistoryListElement.ClanWarHistoryListElementArgs _selectedArgs;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_View ---
		void Gameplay_Clans_Office_Controller_ClanWars_ClanWarsHistoryViewMediator__set_View
		               (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  
		  if (DAT_ram_00a57707 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_ClanWarsHistoryModel__ClanWarsHistoryEvents__ClanWarsHistoryController__ClanWarsHistoryView__get_Model__
		              );
		    DAT_ram_00a57707 = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  Gameplay_Clans_Office_View_ClanWarsTab_ClanWarsHistoryTab_ClanWarsHistoryInfoBox__get_WarButton
		            (*(undefined4 *)(iVar1 + 0x20),*(undefined4 *)(param1[2] + 0x10),0);
		  uVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x14c));
		  Gameplay_Clans_Office_Controller_ClanWars_ClanWarsHistoryController__GetWarsHistoryResultHandler
		            (uVar2,100,param1);
		  uVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar2 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (uVar2,0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar2,1,0);
		  return;
		}
		*/


		/* --- GHIDRA: set_Events ---
		void Gameplay_Clans_Office_Controller_ClanWars_ClanWarsHistoryViewMediator__set_Events
		               (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  uint param2_00;
		  
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  Gameplay_Clans_Office_View_ClanWarsTab_ClanWarsHistoryTab_ClanWarsHistoryInfoBox__Init
		            (*(undefined4 *)(iVar1 + 0x20),*(undefined4 *)(param1[6] + 0x20),
		             *(undefined4 *)(param1[6] + 0x24),0);
		  if (DAT_ram_00a57712 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_ClanWarsHistoryModel__ClanWarsHistoryEvents__ClanWarsHistoryController__ClanWarsHistoryView__get_Model__
		              );
		    DAT_ram_00a57712 = '\x01';
		  }
		  uVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar2 = Gameplay_Clans_Office_View_ClanWarsTab_ClanWarsHistoryTab_ClanWarsHistoryView__get_MembersButton
		                    (uVar2,0);
		  uVar2 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (uVar2,0);
		  iVar1 = Core_Data_UserData__get_ClanId(*(undefined4 *)(param1[2] + 8),0);
		  if (iVar1 == 0) {
		    param2_00 = 0;
		  }
		  else {
		    param2_00 = (uint)(-1 < *(int *)(*(int *)(param1[6] + 0x20) + 0x38));
		  }
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar2,param2_00,0);
		  return;
		}
		*/

}
