using System;
using System.Collections.Generic;
using Gameplay.VortexRating.Events;
using Gameplay.VortexRating.Model;
using Gameplay.VortexRating.View;
using Il2CppDummyDll;
using MVC;
using MVC.Interfaces;

namespace Gameplay.VortexRating.Controller
{
	// Token: 0x020003A0 RID: 928
	[Token(Token = "0x20003A0")]
	public class VortexRatingViewMediator : AbstractViewMediator<VortexRatingModel, VortexRatingEvents, VortexRatingController, VortexRatingWindow>
	{
		// Token: 0x0600159F RID: 5535 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600159F")]
		[Address(RVA = "0x6761", Offset = "0x6761", VA = "0x6761")]
		public VortexRatingViewMediator(VortexRatingModel model, VortexRatingEvents events, VortexRatingController controller)
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_VortexRating_Controller_VortexRatingViewMediator___ctor
		               (int *param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  undefined4 uVar3;
		  
		  if (DAT_ram_00a581f2 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_VortexRatingModel__VortexRatingEvents__VortexRatingController__VortexRatingWindow__set_View__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Events_UnityAction_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_VortexRating_Controller_VortexRatingViewMediator_InRatingButtonClickedEventHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_VortexRating_Controller_VortexRatingViewMediator_TabChangedEventHandler__
		              );
		    DAT_ram_00a581f2 = '\x01';
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
		               Method_Gameplay_VortexRating_Controller_VortexRatingViewMediator_TabChangedEventHandler__
		               ,0);
		    UI_Tabs_TabBar__add_ChangeEvent(uVar3,uVar1,0);
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar3 = *(undefined4 *)(*(int *)(iVar2 + 0x54) + 0xb4);
		    uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		    Utils_ObjectUtils__IsNotNull
		              (uVar1,param1,
		               Method_Gameplay_VortexRating_Controller_VortexRatingViewMediator_InRatingButtonClickedEventHandler__
		               ,0);
		    UnityEngine_Events_UnityAction___ctor(uVar3,uVar1,0);
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
		               Method_Gameplay_VortexRating_Controller_VortexRatingViewMediator_TabChangedEventHandler__
		               ,0);
		    UI_Tabs_CategoryTabBarItemView___ctor(uVar3,uVar1,0);
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar3 = *(undefined4 *)(*(int *)(iVar2 + 0x54) + 0xb4);
		    uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		    Utils_ObjectUtils__IsNotNull
		              (uVar1,param1,
		               Method_Gameplay_VortexRating_Controller_VortexRatingViewMediator_InRatingButtonClickedEventHandler__
		               ,0);
		    Gameplay_Boss_View_CaptainTab_BossInfoView__add_AttackButtonClickEvent(uVar3,uVar1,0);
		    if (DAT_ram_00a581f3 == '\0') {
		      Mono_Security_ASN1__get_Item
		                (&
		                 Method_MVC_AbstractViewMediator_VortexRatingModel__VortexRatingEvents__VortexRatingController__VortexRatingWindow__get_Model__
		                );
		      DAT_ram_00a581f3 = '\x01';
		    }
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar3 = *(undefined4 *)(iVar2 + 0x3c);
		    uVar1 = Gameplay_VortexRating_Model_VortexRatingModel__set_Prizes(param1,param1);
		    UI_Tabs_TabBar__HandleSelected(uVar3,uVar1,0);
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    Gameplay_GameEvents_Model_GameEventData__get_ContainsArtifactRewards
		              (*(undefined4 *)(iVar2 + 0x3c),0,0,0);
		  }
		  return;
		}
		*/

		}

		// Token: 0x17000391 RID: 913
		// (set) Token: 0x060015A0 RID: 5536 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000391")]
		public override VortexRatingWindow View
		{
			[Token(Token = "0x60015A0")]
			[Address(RVA = "0x6762", Offset = "0x6762", VA = "0x6762", Slot = "20")]
			set
			{
			}
		}

		// Token: 0x060015A1 RID: 5537 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60015A1")]
		[Address(RVA = "0x6763", Offset = "0x6763", VA = "0x6763")]
		private void Init()
		{
		/* --- GHIDRA: Init ---
		void Gameplay_VortexRating_Controller_VortexRatingViewMediator__Init(int *param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  int iVar3;
		  int *param1_00;
		  int param1_01;
		  
		  if (DAT_ram_00a581f4 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_uint__Func_IHideableMediator___get_Item__
		              );
		    Mono_Security_ASN1__get_Item(&MVC_Interfaces_IHideableMediator_TypeInfo);
		    DAT_ram_00a581f4 = '\x01';
		  }
		  param1_00 = (int *)param1[0xc];
		  if (param1_00 != (int *)0x0) {
		    uVar1 = 0;
		    iVar3 = *param1_00;
		    if (*(ushort *)(iVar3 + 0xb6) != 0) {
		      do {
		        if (MVC_Interfaces_IHideableMediator_TypeInfo ==
		            *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8)) {
		          puVar2 = (uint *)(iVar3 + *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		          goto code_r0x80eb7e3b;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		    }
		    puVar2 = (uint *)func_ii_1080(param1_00,MVC_Interfaces_IHideableMediator_TypeInfo,0);
		code_r0x80eb7e3b:
		    (**(code **)((ulonglong)*puVar2 * 4))(param1_00,puVar2[1]);
		  }
		  param1_01 = param1[0xb];
		  iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar3 = UI_Tabs_TabBar__get_SelectedIndex(*(undefined4 *)(iVar3 + 0x3c),0);
		  iVar3 = System_Collections_Generic_List_object___get_Item
		                    (param1_01,*(undefined4 *)(iVar3 + 0x14),
		                     Method_System_Collections_Generic_Dictionary_uint__Func_IHideableMediator___get_Item__
		                    );
		  iVar3 = (**(code **)((ulonglong)*(uint *)(iVar3 + 0xc) * 4))
		                    (*(undefined4 *)(iVar3 + 0x20),*(undefined4 *)(iVar3 + 0x14));
		  param1[0xc] = iVar3;
		  return;
		}
		*/

		}

		// Token: 0x060015A2 RID: 5538 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60015A2")]
		[Address(RVA = "0x6764", Offset = "0x6764", VA = "0x6764")]
		private void TabChangedEventHandler()
		{
		/* --- GHIDRA: TabChangedEventHandler ---
		void Gameplay_VortexRating_Controller_VortexRatingViewMediator__TabChangedEventHandler
		               (undefined4 param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 param1_00;
		  int *param1_01;
		  int iVar3;
		  
		  if (DAT_ram_00a581f5 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Rating_View_RatingWindow_RatingWindowArgs_TypeInfo);
		    DAT_ram_00a581f5 = '\x01';
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
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + iVar3 + 0x1b0);
		        goto code_r0x80eb7f57;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_01,Core_Gameplay_IGame_TypeInfo,0x1e);
		code_r0x80eb7f57:
		  param1_00 = (**(code **)((ulonglong)*puVar2 * 4))(param1_01,puVar2[1]);
		  iVar3 = unnamed_function_1417(Gameplay_Rating_View_RatingWindow_RatingWindowArgs_TypeInfo);
		  Gameplay_Rating_View_RatingWindow___ctor(iVar3,0);
		  *(undefined8 *)(iVar3 + 0x18) = 0x700000001;
		  Core_Gameplay_Managers_GameActivityRouting_GameFeatureRouterManager__ShowRatingWindow
		            (param1_00,iVar3,0);
		  return;
		}
		*/

		}

		// Token: 0x060015A3 RID: 5539 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60015A3")]
		[Address(RVA = "0x6765", Offset = "0x6765", VA = "0x6765")]
		private void InRatingButtonClickedEventHandler()
		{
		/* --- GHIDRA: InRatingButtonClickedEventHandler ---
		int Gameplay_VortexRating_Controller_VortexRatingViewMediator__InRatingButtonClickedEventHandler
		              (int *param1,undefined4 param2)
		
		{
		  undefined4 param4;
		  undefined4 uVar1;
		  int iVar2;
		  int *piVar3;
		  int iVar4;
		  
		  if (DAT_ram_00a581f6 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_VortexRatingModel__VortexRatingEvents__VortexRatingController__VortexRatingWindow__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&Gameplay_VortexRating_Controller_VortexViewMediator_TypeInfo);
		    DAT_ram_00a581f6 = '\x01';
		  }
		  piVar3 = (int *)param1[6];
		  if (piVar3 == (int *)0x0) {
		    iVar2 = param1[2];
		    uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    param4 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                       (param1,*(undefined4 *)(*param1 + 0x14c));
		    piVar3 = (int *)unnamed_function_1417
		                              (Gameplay_VortexRating_Controller_VortexViewMediator_TypeInfo);
		    if (DAT_ram_00a581fc == '\0') {
		      Mono_Security_ASN1__get_Item
		                (&
		                 Method_MVC_AbstractViewMediator_VortexRatingModel__VortexRatingEvents__VortexRatingController__VortexView___ctor__
		                );
		      DAT_ram_00a581fc = '\x01';
		    }
		    Gameplay_Combat_TeamCombat_View_AbstractTeamCombatView_object___get_HideInstantElements
		              (piVar3,iVar2,uVar1,param4,
		               Method_MVC_AbstractViewMediator_VortexRatingModel__VortexRatingEvents__VortexRatingController__VortexView___ctor__
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
		            (piVar3,*(undefined4 *)(iVar2 + 0x50),*(undefined4 *)(iVar4 + 0x164));
		  return param1[6];
		}
		*/

		}

		// Token: 0x060015A4 RID: 5540 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60015A4")]
		[Address(RVA = "0x6766", Offset = "0x6766", VA = "0x6766")]
		private IHideableMediator ShowVortexTab()
		{
		/* --- GHIDRA: ShowVortexTab ---
		int Gameplay_VortexRating_Controller_VortexRatingViewMediator__ShowVortexTab
		              (int *param1,undefined4 param2)
		
		{
		  undefined4 param4;
		  undefined4 uVar1;
		  int iVar2;
		  int *piVar3;
		  int iVar4;
		  
		  if (DAT_ram_00a581f7 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_VortexRatingModel__VortexRatingEvents__VortexRatingController__VortexRatingWindow__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&Gameplay_VortexRating_Controller_GreatOnesViewMediator_TypeInfo);
		    DAT_ram_00a581f7 = '\x01';
		  }
		  piVar3 = (int *)param1[7];
		  if (piVar3 == (int *)0x0) {
		    iVar2 = param1[2];
		    uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    param4 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                       (param1,*(undefined4 *)(*param1 + 0x14c));
		    piVar3 = (int *)unnamed_function_1417
		                              (Gameplay_VortexRating_Controller_GreatOnesViewMediator_TypeInfo);
		    if (DAT_ram_00a581cf == '\0') {
		      Mono_Security_ASN1__get_Item
		                (&
		                 Method_MVC_AbstractViewMediator_VortexRatingModel__VortexRatingEvents__VortexRatingController__GreatOnesView___ctor__
		                );
		      DAT_ram_00a581cf = '\x01';
		    }
		    Gameplay_Combat_TeamCombat_View_AbstractTeamCombatView_object___get_HideInstantElements
		              (piVar3,iVar2,uVar1,param4,
		               Method_MVC_AbstractViewMediator_VortexRatingModel__VortexRatingEvents__VortexRatingController__GreatOnesView___ctor__
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
		            (piVar3,*(undefined4 *)(iVar2 + 0x40),*(undefined4 *)(iVar4 + 0x164));
		  return param1[7];
		}
		*/

			return null;
		}

		// Token: 0x060015A5 RID: 5541 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60015A5")]
		[Address(RVA = "0x6767", Offset = "0x6767", VA = "0x6767")]
		private IHideableMediator ShowGreatOnesTab()
		{
		/* --- GHIDRA: ShowGreatOnesTab ---
		int Gameplay_VortexRating_Controller_VortexRatingViewMediator__ShowGreatOnesTab
		              (int *param1,undefined4 param2)
		
		{
		  undefined4 param4;
		  undefined4 uVar1;
		  int iVar2;
		  int *piVar3;
		  int iVar4;
		  
		  if (DAT_ram_00a581f8 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_VortexRatingModel__VortexRatingEvents__VortexRatingController__VortexRatingWindow__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&Gameplay_VortexRating_Controller_VoteRewardsViewMediator_TypeInfo)
		    ;
		    DAT_ram_00a581f8 = '\x01';
		  }
		  piVar3 = (int *)param1[8];
		  if (piVar3 == (int *)0x0) {
		    iVar2 = param1[2];
		    uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    param4 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                       (param1,*(undefined4 *)(*param1 + 0x14c));
		    piVar3 = (int *)unnamed_function_1417
		                              (Gameplay_VortexRating_Controller_VoteRewardsViewMediator_TypeInfo);
		    if (DAT_ram_00a58200 == '\0') {
		      Mono_Security_ASN1__get_Item
		                (&
		                 Method_MVC_AbstractViewMediator_VortexRatingModel__VortexRatingEvents__VortexRatingController__VoteRewardsView___ctor__
		                );
		      Mono_Security_ASN1__get_Item
		                (&Gameplay_VortexRating_View_VoteRewardsTab_GiftListElement___TypeInfo);
		      DAT_ram_00a58200 = '\x01';
		    }
		    iVar4 = Mono_Security_ASN1Convert__ToOid
		                      (Gameplay_VortexRating_View_VoteRewardsTab_GiftListElement___TypeInfo,0);
		    piVar3[6] = iVar4;
		    Gameplay_Combat_TeamCombat_View_AbstractTeamCombatView_object___get_HideInstantElements
		              (piVar3,iVar2,uVar1,param4,
		               Method_MVC_AbstractViewMediator_VortexRatingModel__VortexRatingEvents__VortexRatingController__VoteRewardsView___ctor__
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
		            (piVar3,*(undefined4 *)(iVar2 + 0x44),*(undefined4 *)(iVar4 + 0x164));
		  return param1[8];
		}
		*/

			return null;
		}

		// Token: 0x060015A6 RID: 5542 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60015A6")]
		[Address(RVA = "0x6768", Offset = "0x6768", VA = "0x6768")]
		private IHideableMediator ShowVoteRewardsTab()
		{
		/* --- GHIDRA: ShowVoteRewardsTab ---
		int Gameplay_VortexRating_Controller_VortexRatingViewMediator__ShowVoteRewardsTab
		              (int *param1,undefined4 param2)
		
		{
		  undefined4 param4;
		  undefined4 uVar1;
		  int iVar2;
		  int *piVar3;
		  int iVar4;
		  
		  if (DAT_ram_00a581f9 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_VortexRatingModel__VortexRatingEvents__VortexRatingController__VortexRatingWindow__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&Gameplay_VortexRating_Controller_RulesViewMediator_TypeInfo);
		    DAT_ram_00a581f9 = '\x01';
		  }
		  piVar3 = (int *)param1[9];
		  if (piVar3 == (int *)0x0) {
		    iVar2 = param1[2];
		    uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    param4 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                       (param1,*(undefined4 *)(*param1 + 0x14c));
		    piVar3 = (int *)unnamed_function_1417
		                              (Gameplay_VortexRating_Controller_RulesViewMediator_TypeInfo);
		    if (DAT_ram_00a581e0 == '\0') {
		      Mono_Security_ASN1__get_Item
		                (&
		                 Method_MVC_AbstractViewMediator_VortexRatingModel__VortexRatingEvents__VortexRatingController__RulesView___ctor__
		                );
		      DAT_ram_00a581e0 = '\x01';
		    }
		    Gameplay_Combat_TeamCombat_View_AbstractTeamCombatView_object___get_HideInstantElements
		              (piVar3,iVar2,uVar1,param4,
		               Method_MVC_AbstractViewMediator_VortexRatingModel__VortexRatingEvents__VortexRatingController__RulesView___ctor__
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
		            (piVar3,*(undefined4 *)(iVar2 + 0x48),*(undefined4 *)(iVar4 + 0x164));
		  return param1[9];
		}
		*/

			return null;
		}

		// Token: 0x060015A7 RID: 5543 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60015A7")]
		[Address(RVA = "0x6769", Offset = "0x6769", VA = "0x6769")]
		private IHideableMediator ShowRulesTab()
		{
		/* --- GHIDRA: ShowRulesTab ---
		int Gameplay_VortexRating_Controller_VortexRatingViewMediator__ShowRulesTab
		              (int *param1,undefined4 param2)
		
		{
		  undefined4 param4;
		  undefined4 uVar1;
		  int iVar2;
		  int *piVar3;
		  int iVar4;
		  
		  if (DAT_ram_00a581fa == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_VortexRatingModel__VortexRatingEvents__VortexRatingController__VortexRatingWindow__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&Gameplay_VortexRating_Controller_GreatPrizesViewMediator_TypeInfo)
		    ;
		    DAT_ram_00a581fa = '\x01';
		  }
		  piVar3 = (int *)param1[10];
		  if (piVar3 == (int *)0x0) {
		    iVar2 = param1[2];
		    uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    param4 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                       (param1,*(undefined4 *)(*param1 + 0x14c));
		    piVar3 = (int *)unnamed_function_1417
		                              (Gameplay_VortexRating_Controller_GreatPrizesViewMediator_TypeInfo);
		    if (DAT_ram_00a581d8 == '\0') {
		      Mono_Security_ASN1__get_Item
		                (&
		                 Method_MVC_AbstractViewMediator_VortexRatingModel__VortexRatingEvents__VortexRatingController__GreatPrizesView___ctor__
		                );
		      Mono_Security_ASN1__get_Item
		                (&Gameplay_VortexRating_View_GreatPrizesTab_PrizeListElement___TypeInfo);
		      DAT_ram_00a581d8 = '\x01';
		    }
		    iVar4 = Mono_Security_ASN1Convert__ToOid
		                      (Gameplay_VortexRating_View_GreatPrizesTab_PrizeListElement___TypeInfo,0);
		    piVar3[7] = iVar4;
		    Gameplay_Combat_TeamCombat_View_AbstractTeamCombatView_object___get_HideInstantElements
		              (piVar3,iVar2,uVar1,param4,
		               Method_MVC_AbstractViewMediator_VortexRatingModel__VortexRatingEvents__VortexRatingController__GreatPrizesView___ctor__
		              );
		    param1[10] = (int)piVar3;
		  }
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x13c));
		  (**(code **)((ulonglong)*(uint *)(*piVar3 + 0x140) * 4))
		            (piVar3,uVar1,*(undefined4 *)(*piVar3 + 0x144));
		  piVar3 = (int *)param1[10];
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar4 = *piVar3;
		  (**(code **)((ulonglong)*(uint *)(iVar4 + 0x160) * 4))
		            (piVar3,*(undefined4 *)(iVar2 + 0x4c),*(undefined4 *)(iVar4 + 0x164));
		  return param1[10];
		}
		*/

			return null;
		}

		// Token: 0x060015A8 RID: 5544 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60015A8")]
		[Address(RVA = "0x676A", Offset = "0x676A", VA = "0x676A")]
		private IHideableMediator ShowGreatPrizesTab()
		{
		/* --- GHIDRA: ShowGreatPrizesTab ---
		void Gameplay_VortexRating_Controller_VortexRatingViewMediator__ShowGreatPrizesTab
		               (int param1,undefined4 param2)
		
		{
		  int *piVar1;
		  
		  if (DAT_ram_00a581fb == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_VortexRatingModel__VortexRatingEvents__VortexRatingController__VortexRatingWindow__Dispose__
		              );
		    DAT_ram_00a581fb = '\x01';
		  }
		  MVC_AbstractViewMediator_object__object__object__object___Core_MVC_Interfaces_IViewMediator_set_View
		            (param1,
		             Method_MVC_AbstractViewMediator_VortexRatingModel__VortexRatingEvents__VortexRatingController__VortexRatingWindow__Dispose__
		            );
		  piVar1 = *(int **)(param1 + 0x1c);
		  if (piVar1 != (int *)0x0) {
		    (**(code **)((ulonglong)*(uint *)(*piVar1 + 0x130) * 4))
		              (piVar1,*(undefined4 *)(*piVar1 + 0x134));
		  }
		  piVar1 = *(int **)(param1 + 0x20);
		  if (piVar1 != (int *)0x0) {
		    (**(code **)((ulonglong)*(uint *)(*piVar1 + 0x130) * 4))
		              (piVar1,*(undefined4 *)(*piVar1 + 0x134));
		  }
		  piVar1 = *(int **)(param1 + 0x24);
		  if (piVar1 != (int *)0x0) {
		    (**(code **)((ulonglong)*(uint *)(*piVar1 + 0x130) * 4))
		              (piVar1,*(undefined4 *)(*piVar1 + 0x134));
		  }
		  piVar1 = *(int **)(param1 + 0x28);
		  if (piVar1 != (int *)0x0) {
		    (**(code **)((ulonglong)*(uint *)(*piVar1 + 0x130) * 4))
		              (piVar1,*(undefined4 *)(*piVar1 + 0x134));
		  }
		  piVar1 = *(int **)(param1 + 0x18);
		  if (piVar1 != (int *)0x0) {
		    (**(code **)((ulonglong)*(uint *)(*piVar1 + 0x130) * 4))
		              (piVar1,*(undefined4 *)(*piVar1 + 0x134));
		  }
		  return;
		}
		*/

			return null;
		}

		// Token: 0x060015A9 RID: 5545 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60015A9")]
		[Address(RVA = "0x676B", Offset = "0x676B", VA = "0x676B", Slot = "14")]
		public override void Dispose()
		{
		/* --- GHIDRA: Dispose ---
		void Gameplay_VortexRating_Controller_VortexRatingViewMediator__Dispose
		               (undefined4 param1,undefined4 param2,undefined4 param3,undefined4 param4,
		               undefined4 param5)
		
		{
		  if (DAT_ram_00a581fc == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_VortexRatingModel__VortexRatingEvents__VortexRatingController__VortexView___ctor__
		              );
		    DAT_ram_00a581fc = '\x01';
		  }
		  Gameplay_Combat_TeamCombat_View_AbstractTeamCombatView_object___get_HideInstantElements
		            (param1,param2,param3,param4,
		             Method_MVC_AbstractViewMediator_VortexRatingModel__VortexRatingEvents__VortexRatingController__VortexView___ctor__
		            );
		  return;
		}
		*/

		}

		// Token: 0x04000B73 RID: 2931
		[Token(Token = "0x4000B73")]
		[FieldOffset(Offset = "0x18")]
		private VortexViewMediator _vortexViewMediator;

		// Token: 0x04000B74 RID: 2932
		[Token(Token = "0x4000B74")]
		[FieldOffset(Offset = "0x1C")]
		private GreatOnesViewMediator _greatOnesViewMediator;

		// Token: 0x04000B75 RID: 2933
		[Token(Token = "0x4000B75")]
		[FieldOffset(Offset = "0x20")]
		private VoteRewardsViewMediator _voteRewardsViewMediator;

		// Token: 0x04000B76 RID: 2934
		[Token(Token = "0x4000B76")]
		[FieldOffset(Offset = "0x24")]
		private RulesViewMediator _rulesViewMediator;

		// Token: 0x04000B77 RID: 2935
		[Token(Token = "0x4000B77")]
		[FieldOffset(Offset = "0x28")]
		private GreatPrizesViewMediator _greatPrizesViewMediator;

		// Token: 0x04000B78 RID: 2936
		[Token(Token = "0x4000B78")]
		[FieldOffset(Offset = "0x2C")]
		private Dictionary<uint, Func<IHideableMediator>> _tabsOpenersById;

		// Token: 0x04000B79 RID: 2937
		[Token(Token = "0x4000B79")]
		[FieldOffset(Offset = "0x30")]
		private IHideableMediator _currentMediator;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_View ---
		void Gameplay_VortexRating_Controller_VortexRatingViewMediator__set_View
		               (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 param2_00;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a581f3 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_VortexRatingModel__VortexRatingEvents__VortexRatingController__VortexRatingWindow__get_Model__
		              );
		    DAT_ram_00a581f3 = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  param1_00 = *(undefined4 *)(iVar1 + 0x3c);
		  param2_00 = Gameplay_VortexRating_Model_VortexRatingModel__set_Prizes(param1,param1);
		  UI_Tabs_TabBar__HandleSelected(param1_00,param2_00,0);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  Gameplay_GameEvents_Model_GameEventData__get_ContainsArtifactRewards
		            (*(undefined4 *)(iVar1 + 0x3c),0,0,0);
		  return;
		}
		*/

}
