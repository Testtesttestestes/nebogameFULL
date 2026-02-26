using System;
using Gameplay.SmallGames.Events;
using Gameplay.SmallGames.Model;
using Gameplay.SmallGames.View.DailyRewards;
using Il2CppDummyDll;
using MVC;
using Protocol.SmallGames;

namespace Gameplay.SmallGames.Controller
{
	// Token: 0x02000539 RID: 1337
	[Token(Token = "0x2000539")]
	public class DailyRewardsViewMediator : AbstractViewMediator<SmallGamesModel, Gameplay.SmallGames.Events.SmallGamesEvents, SmallGamesController, DailyRewardsWindow>
	{
		// Token: 0x06001FD7 RID: 8151 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001FD7")]
		[Address(RVA = "0x713C", Offset = "0x713C", VA = "0x713C")]
		public DailyRewardsViewMediator(SmallGamesModel model, Gameplay.SmallGames.Events.SmallGamesEvents events, SmallGamesController controller)
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_SmallGames_Controller_DailyRewardsViewMediator___ctor
		               (int *param1,int param2,undefined4 param3)
		
		{
		  bool bVar1;
		  int iVar2;
		  undefined4 uVar3;
		  int iVar4;
		  int iVar5;
		  undefined4 uVar6;
		  int iVar7;
		  
		  if (DAT_ram_00a582b8 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_SmallGamesModel__SmallGamesEvents__SmallGamesController__DailyRewardsWindow__set_View__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_RewardsTab__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_SmallGames_Controller_DailyRewardsViewMediator_AccountsButtonClickHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_SmallGames_Controller_DailyRewardsViewMediator_TabSelectedEventHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_SmallGames_Controller_DailyRewardsViewMediator_TakeButtonClickedEventHandler__
		              );
		    Mono_Security_ASN1__get_Item(&UnityEngine_Events_UnityAction_TypeInfo);
		    DAT_ram_00a582b8 = '\x01';
		  }
		  uVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar4 = Cysharp_Threading_Tasks_CancellationTokenExtensions___cctor(uVar3,0);
		  if (iVar4 != 0) {
		    iVar4 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar3 = unnamed_function_1417(System_Action_RewardsTab__TypeInfo);
		    UnityEngine_UIElements_VisualElement__get_layout
		              (uVar3,param1,
		               Method_Gameplay_SmallGames_Controller_DailyRewardsViewMediator_TabSelectedEventHandler__
		               ,0);
		    if (DAT_ram_00a58296 == '\0') {
		      Mono_Security_ASN1__get_Item(&System_Action_RewardsTab__TypeInfo);
		      DAT_ram_00a58296 = '\x01';
		    }
		    iVar7 = *(int *)(iVar4 + 0x74);
		    do {
		      iVar2 = 0;
		      iVar5 = func_ii_7048(iVar7,uVar3,0);
		      uVar6 = System_Action_RewardsTab__TypeInfo;
		      if ((iVar5 != 0) &&
		         (iVar2 = func_ii_1082(iVar5,System_Action_RewardsTab__TypeInfo), iVar2 == 0)) {
		        System_Activator__CreateInstance(iVar5,uVar6);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      iVar2 = func_ii_4329(iVar4 + 0x74,iVar2,iVar7);
		      bVar1 = iVar2 != iVar7;
		      iVar7 = iVar2;
		    } while (bVar1);
		    iVar4 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar6 = *(undefined4 *)(*(int *)(iVar4 + 0x60) + 0xb4);
		    uVar3 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		    Utils_ObjectUtils__IsNotNull
		              (uVar3,param1,
		               Method_Gameplay_SmallGames_Controller_DailyRewardsViewMediator_TakeButtonClickedEventHandler__
		               ,0);
		    UnityEngine_Events_UnityAction___ctor(uVar6,uVar3,0);
		    iVar4 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar6 = *(undefined4 *)(*(int *)(iVar4 + 0x68) + 0xb4);
		    uVar3 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		    Utils_ObjectUtils__IsNotNull
		              (uVar3,param1,
		               Method_Gameplay_SmallGames_Controller_DailyRewardsViewMediator_AccountsButtonClickHandler__
		               ,0);
		    UnityEngine_Events_UnityAction___ctor(uVar6,uVar3,0);
		  }
		  param1[5] = param2;
		  uVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar4 = Cysharp_Threading_Tasks_CancellationTokenExtensions___cctor(uVar3,0);
		  if (iVar4 != 0) {
		    iVar4 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar3 = unnamed_function_1417(System_Action_RewardsTab__TypeInfo);
		    UnityEngine_UIElements_VisualElement__get_layout
		              (uVar3,param1,
		               Method_Gameplay_SmallGames_Controller_DailyRewardsViewMediator_TabSelectedEventHandler__
		               ,0);
		    if (DAT_ram_00a58295 == '\0') {
		      Mono_Security_ASN1__get_Item(&System_Action_RewardsTab__TypeInfo);
		      DAT_ram_00a58295 = '\x01';
		    }
		    iVar7 = *(int *)(iVar4 + 0x74);
		    do {
		      iVar2 = 0;
		      iVar5 = UnityEngine_UI_Image__set_sprite(iVar7,uVar3,0);
		      uVar6 = System_Action_RewardsTab__TypeInfo;
		      if ((iVar5 != 0) &&
		         (iVar2 = func_ii_1082(iVar5,System_Action_RewardsTab__TypeInfo), iVar2 == 0)) {
		        System_Activator__CreateInstance(iVar5,uVar6);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      iVar2 = func_ii_4329(iVar4 + 0x74,iVar2,iVar7);
		      bVar1 = iVar2 != iVar7;
		      iVar7 = iVar2;
		    } while (bVar1);
		    iVar4 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar6 = *(undefined4 *)(*(int *)(iVar4 + 0x60) + 0xb4);
		    uVar3 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		    Utils_ObjectUtils__IsNotNull
		              (uVar3,param1,
		               Method_Gameplay_SmallGames_Controller_DailyRewardsViewMediator_TakeButtonClickedEventHandler__
		               ,0);
		    Gameplay_Boss_View_CaptainTab_BossInfoView__add_AttackButtonClickEvent(uVar6,uVar3,0);
		    iVar4 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar6 = *(undefined4 *)(*(int *)(iVar4 + 0x68) + 0xb4);
		    uVar3 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		    Utils_ObjectUtils__IsNotNull
		              (uVar3,param1,
		               Method_Gameplay_SmallGames_Controller_DailyRewardsViewMediator_AccountsButtonClickHandler__
		               ,0);
		    Gameplay_Boss_View_CaptainTab_BossInfoView__add_AttackButtonClickEvent(uVar6,uVar3,0);
		    iVar7 = *param1;
		    iVar4 = (**(code **)((ulonglong)*(uint *)(iVar7 + 0x148) * 4))
		                      (param1,*(undefined4 *)(iVar7 + 0x14c));
		    if (*(char *)(iVar4 + 9) != '\0') {
		      Gameplay_SmallGames_Controller_DailyRewardsViewMediator__DailyBonusTakenEventHandler
		                (param1,iVar7);
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x170005DA RID: 1498
		// (set) Token: 0x06001FD8 RID: 8152 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170005DA")]
		public override DailyRewardsWindow View
		{
			[Token(Token = "0x6001FD8")]
			[Address(RVA = "0x713D", Offset = "0x713D", VA = "0x713D", Slot = "20")]
			set
			{
			}
		}

		// Token: 0x06001FD9 RID: 8153 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001FD9")]
		[Address(RVA = "0x713E", Offset = "0x713E", VA = "0x713E")]
		private void AccountsButtonClickHandler()
		{
		/* --- GHIDRA: AccountsButtonClickHandler ---
		void Gameplay_SmallGames_Controller_DailyRewardsViewMediator__AccountsButtonClickHandler
		               (int *param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  int iVar2;
		  undefined4 uVar3;
		  int *piVar4;
		  undefined4 uVar5;
		  
		  if (DAT_ram_00a582ba == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_SmallGamesModel__SmallGamesEvents__SmallGamesController__DailyRewardsWindow__set_Events__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_SmallGames_Controller_DailyRewardsViewMediator_CanTakeAdditionalChangedEventHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_SmallGames_Controller_DailyRewardsViewMediator_DailyBonusTakenEventHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_SmallGames_Controller_DailyRewardsViewMediator_VisitRegisteredEventHandler__
		              );
		    DAT_ram_00a582ba = '\x01';
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
		               Method_Gameplay_SmallGames_Controller_DailyRewardsViewMediator_DailyBonusTakenEventHandler__
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
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar5 = *(undefined4 *)(iVar2 + 0x30);
		    uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar3,param1,
		               Method_Gameplay_SmallGames_Controller_DailyRewardsViewMediator_CanTakeAdditionalChangedEventHandler__
		               ,0);
		    piVar4 = (int *)func_ii_7048(uVar5,uVar3,0);
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
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar5 = *(undefined4 *)(iVar2 + 0x14);
		    uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar3,param1,
		               Method_Gameplay_SmallGames_Controller_DailyRewardsViewMediator_VisitRegisteredEventHandler__
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
		               Method_Gameplay_SmallGames_Controller_DailyRewardsViewMediator_DailyBonusTakenEventHandler__
		               ,0);
		    piVar4 = (int *)UnityEngine_UI_Image__set_sprite(uVar5,uVar3,0);
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
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar5 = *(undefined4 *)(iVar2 + 0x30);
		    uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar3,param1,
		               Method_Gameplay_SmallGames_Controller_DailyRewardsViewMediator_CanTakeAdditionalChangedEventHandler__
		               ,0);
		    piVar4 = (int *)UnityEngine_UI_Image__set_sprite(uVar5,uVar3,0);
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
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar5 = *(undefined4 *)(iVar2 + 0x14);
		    uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar3,param1,
		               Method_Gameplay_SmallGames_Controller_DailyRewardsViewMediator_VisitRegisteredEventHandler__
		               ,0);
		    piVar4 = (int *)UnityEngine_UI_Image__set_sprite(uVar5,uVar3,0);
		    iVar1 = System_Action_TypeInfo;
		    if (piVar4 == (int *)0x0) {
		      *(undefined4 *)(iVar2 + 0x14) = 0;
		      return;
		    }
		    if ((System_Action_TypeInfo != *piVar4) || (*(int **)(iVar2 + 0x14) = piVar4, *piVar4 != iVar1))
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

		// Token: 0x170005DB RID: 1499
		// (set) Token: 0x06001FDA RID: 8154 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170005DB")]
		public override Gameplay.SmallGames.Events.SmallGamesEvents Events
		{
			[Token(Token = "0x6001FDA")]
			[Address(RVA = "0x713F", Offset = "0x713F", VA = "0x713F", Slot = "16")]
			set
			{
			}
		}

		// Token: 0x06001FDB RID: 8155 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001FDB")]
		[Address(RVA = "0x7140", Offset = "0x7140", VA = "0x7140")]
		private void VisitRegisteredEventHandler()
		{
		/* --- GHIDRA: VisitRegisteredEventHandler ---
		void Gameplay_SmallGames_Controller_DailyRewardsViewMediator__VisitRegisteredEventHandler
		               (int *param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  undefined1 local_1;
		  
		  if (DAT_ram_00a582bb == '\0') {
		    Mono_Security_ASN1__get_Item(&OKG_Logs_Debug_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_6261);
		    DAT_ram_00a582bb = '\x01';
		  }
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar1 = Cysharp_Threading_Tasks_CancellationTokenExtensions___cctor(uVar1,0);
		  local_1 = (undefined1)uVar1;
		  uVar1 = func_ii_1081(DAT_ram_00a66944,&local_1);
		  uVar1 = func_ii_4419(StringLiteral_6261,uVar1,0);
		  if (*(int *)(OKG_Logs_Debug_TypeInfo + 0x74) == 0) {
		    func_ii_306000(OKG_Logs_Debug_TypeInfo);
		  }
		  System_Collections_Generic_Dictionary_uint__object___get_Count(uVar1,0);
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar2 = Cysharp_Threading_Tasks_CancellationTokenExtensions___cctor(uVar1,0);
		  if (iVar2 != 0) {
		    Gameplay_SmallGames_Controller_DailyRewardsViewMediator__Init(param1,param1);
		  }
		  return;
		}
		*/

		}

		// Token: 0x06001FDC RID: 8156 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001FDC")]
		[Address(RVA = "0x7141", Offset = "0x7141", VA = "0x7141")]
		private void CanTakeAdditionalChangedEventHandler()
		{
		/* --- GHIDRA: CanTakeAdditionalChangedEventHandler ---
		void Gameplay_SmallGames_Controller_DailyRewardsViewMediator__CanTakeAdditionalChangedEventHandler
		               (int *param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  
		  param1_00 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x14c));
		  Gameplay_SmallGames_Controller_SmallGamesController__SetFreeAttempts(param1_00,param1);
		  return;
		}
		*/

		}

		// Token: 0x06001FDD RID: 8157 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001FDD")]
		[Address(RVA = "0x7142", Offset = "0x7142", VA = "0x7142")]
		private void TakeButtonClickedEventHandler()
		{
		/* --- GHIDRA: TakeButtonClickedEventHandler ---
		void Gameplay_SmallGames_Controller_DailyRewardsViewMediator__TakeButtonClickedEventHandler
		               (undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  Gameplay_SmallGames_Controller_DailyRewardsViewMediator__TabSelectedEventHandler
		            (param1,param2,param2);
		  return;
		}
		*/

		}

		// Token: 0x06001FDE RID: 8158 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001FDE")]
		[Address(RVA = "0x7143", Offset = "0x7143", VA = "0x7143")]
		private void TabSelectedEventHandler(RewardsTab tab)
		{
		/* --- GHIDRA: TabSelectedEventHandler ---
		void Gameplay_SmallGames_Controller_DailyRewardsViewMediator__TabSelectedEventHandler
		               (int param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  
		  if (DAT_ram_00a582bc == '\0') {
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    DAT_ram_00a582bc = '\x01';
		  }
		  uVar2 = *(undefined4 *)(param1 + 0x1c);
		  if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		    func_ii_306000(UnityEngine_Object_TypeInfo);
		  }
		  iVar1 = func_ii_3812(uVar2,param2,0);
		  if (iVar1 == 0) {
		    uVar2 = *(undefined4 *)(param1 + 0x1c);
		    if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		      func_ii_306000(UnityEngine_Object_TypeInfo);
		    }
		    iVar1 = UnityEngine_TextCore_Text_TextElement__get_textAsset(uVar2,0,0);
		    if (iVar1 != 0) {
		      iVar1 = *(int *)(param1 + 0x1c);
		      if (DAT_ram_00a5829f == '\0') {
		        Mono_Security_ASN1__get_Item
		                  (&Method_UI_MonoBehaviourWithStates_RewardsTab_State__set_CurrentState__);
		        DAT_ram_00a5829f = '\x01';
		      }
		      if (*(char *)(iVar1 + 0x48) != '\0') {
		        *(undefined1 *)(iVar1 + 0x48) = 0;
		        Gameplay_Boss_View_CaptainTab_BossTeamView__set_TeamInfoData
		                  (iVar1,0,Method_UI_MonoBehaviourWithStates_RewardsTab_State__set_CurrentState__);
		      }
		    }
		    *(int *)(param1 + 0x1c) = param2;
		    if (DAT_ram_00a5829f == '\0') {
		      Mono_Security_ASN1__get_Item
		                (&Method_UI_MonoBehaviourWithStates_RewardsTab_State__set_CurrentState__);
		      DAT_ram_00a5829f = '\x01';
		    }
		    if (*(char *)(param2 + 0x48) == '\0') {
		      *(undefined1 *)(param2 + 0x48) = 1;
		      Gameplay_Boss_View_CaptainTab_BossTeamView__set_TeamInfoData
		                (param2,2,Method_UI_MonoBehaviourWithStates_RewardsTab_State__set_CurrentState__);
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x06001FDF RID: 8159 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001FDF")]
		[Address(RVA = "0x7144", Offset = "0x7144", VA = "0x7144")]
		private void SelectTab(RewardsTab tab)
		{
		/* --- GHIDRA: SelectTab ---
		void Gameplay_SmallGames_Controller_DailyRewardsViewMediator__SelectTab
		               (int *param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  int *piVar3;
		  undefined4 uVar4;
		  int iVar5;
		  
		  if (DAT_ram_00a582bd == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_SmallGamesModel__SmallGamesEvents__SmallGamesController__DailyRewardsWindow__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_6097);
		    DAT_ram_00a582bd = '\x01';
		  }
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  Gameplay_SmallGames_View_DailyRewards_DailyRewardsWindow__DrawPending(uVar1,param1);
		  iVar2 = (*(int *)(*(int *)(*(int *)(param1[2] + 0x14) + 8) + 0xc) + -1) * 4;
		  piVar3 = *(int **)(iVar2 + param1[6] + 0x10);
		  if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_GameLocalization_TypeInfo);
		  }
		  uVar1 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_6097,1,0,1,0,0,0,0);
		  uVar4 = 4;
		  if (*(char *)(*(int *)(*(int *)(param1[2] + 0x14) + 8) + 0x28) == '\0') {
		    uVar4 = 1;
		  }
		  iVar5 = *piVar3;
		  (**(code **)((ulonglong)*(uint *)(iVar5 + 0xe8) * 4))
		            (piVar3,*(undefined4 *)(iVar2 + *(int *)(*(int *)(param1[2] + 0x14) + 0xc) + 0x10),uVar1
		             ,uVar4,*(undefined4 *)(iVar5 + 0xec));
		  Gameplay_SmallGames_Controller_DailyRewardsViewMediator__Init(param1,param1);
		  return;
		}
		*/

		}

		// Token: 0x06001FE0 RID: 8160 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001FE0")]
		[Address(RVA = "0x7145", Offset = "0x7145", VA = "0x7145")]
		private void DailyBonusTakenEventHandler()
		{
		/* --- GHIDRA: DailyBonusTakenEventHandler ---
		void Gameplay_SmallGames_Controller_DailyRewardsViewMediator__DailyBonusTakenEventHandler
		               (int *param1,undefined4 param2)
		
		{
		  char cVar1;
		  undefined4 uVar2;
		  int iVar3;
		  int iVar4;
		  int iVar5;
		  int param3;
		  int param2_00;
		  int iVar6;
		  int iVar7;
		  int *piVar8;
		  undefined4 uVar9;
		  
		  if (DAT_ram_00a582be == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_SmallGamesModel__SmallGamesEvents__SmallGamesController__DailyRewardsWindow__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&Gameplay_SmallGames_View_DailyRewards_DoubleRewardView_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_MonoBehaviourWithStates_SingleRewardView_State__set_CurrentState__);
		    DAT_ram_00a582be = '\x01';
		  }
		  iVar4 = *(int *)(*(int *)(param1[2] + 0x14) + 0xc);
		  uVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar3 = Gameplay_SmallGames_View_DailyRewards_DailyRewardsWindow__get_AccountsButton
		                    (uVar2,*(undefined4 *)(iVar4 + 0xc),0);
		  param1[6] = iVar3;
		  iVar5 = *(int *)(*(int *)(param1[2] + 0x14) + 8);
		  param3 = *(int *)(iVar5 + 0xc);
		  param2_00 = *(int *)(iVar3 + 0xc);
		  iVar6 = param2_00 + -1;
		  iVar7 = 0;
		  if (0 < iVar6) {
		    do {
		      cVar1 = *(char *)(*(int *)(*(int *)(param1[2] + 0x14) + 8) + 0x28);
		      piVar8 = *(int **)(iVar3 + iVar7 * 4 + 0x10);
		      iVar3 = *(int *)(iVar7 * 4 + iVar4 + 0x10);
		      iVar5 = iVar7 + 1;
		      uVar2 = Gameplay_SmallGames_Controller_DailyRewardsViewMediator__SetReceivedState
		                        (iVar7,iVar5,param3,iVar5);
		      uVar9 = 4;
		      if (cVar1 == '\0') {
		        uVar9 = 1;
		      }
		      if (*(char *)(iVar3 + 0x14) == '\0') {
		        uVar9 = 3;
		      }
		      iVar7 = *piVar8;
		      (**(code **)((ulonglong)*(uint *)(iVar7 + 0xe8) * 4))
		                (piVar8,iVar3,uVar2,uVar9,*(undefined4 *)(iVar7 + 0xec));
		      iVar3 = param1[6];
		      param2_00 = *(int *)(iVar3 + 0xc);
		      iVar6 = param2_00 + -1;
		      iVar7 = iVar5;
		    } while (iVar5 < iVar6);
		    iVar5 = *(int *)(*(int *)(param1[2] + 0x14) + 8);
		  }
		  iVar7 = *(int *)(iVar4 + iVar6 * 4 + 0x10);
		  cVar1 = *(char *)(iVar5 + 0x28);
		  piVar8 = *(int **)(iVar6 * 4 + iVar3 + 0x10);
		  if (piVar8 != (int *)0x0) {
		    if (((uint)*(byte *)(*piVar8 + 0xb8) <
		         (uint)*(byte *)(Gameplay_SmallGames_View_DailyRewards_DoubleRewardView_TypeInfo + 0xb8)) ||
		       (*(int *)(*(int *)(*piVar8 + 100) +
		                 (uint)*(byte *)(Gameplay_SmallGames_View_DailyRewards_DoubleRewardView_TypeInfo +
		                                0xb8) * 4 + -4) !=
		        Gameplay_SmallGames_View_DailyRewards_DoubleRewardView_TypeInfo)) {
		      System_Activator__CreateInstance
		                (piVar8,Gameplay_SmallGames_View_DailyRewards_DoubleRewardView_TypeInfo);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  uVar2 = Gameplay_SmallGames_Controller_DailyRewardsViewMediator__SetReceivedState
		                    (piVar8,param2_00,param3,piVar8);
		  uVar9 = 4;
		  if (cVar1 == '\0') {
		    uVar9 = 1;
		  }
		  if (*(char *)(iVar7 + 0x14) == '\0') {
		    uVar9 = 3;
		  }
		  (**(code **)((ulonglong)*(uint *)(*piVar8 + 0xe8) * 4))
		            (piVar8,iVar7,uVar2,uVar9,*(undefined4 *)(*piVar8 + 0xec));
		  if (*(int *)(*(int *)(*(int *)(param1[2] + 0x14) + 8) + 0x18) == 0) {
		    Gameplay_Boss_View_CaptainTab_BossTeamView__set_TeamInfoData
		              (*(undefined4 *)(param1[6] + param3 * 4 + 0xc),2,
		               Method_UI_MonoBehaviourWithStates_SingleRewardView_State__set_CurrentState__);
		    iVar7 = *param1;
		    uVar2 = (**(code **)((ulonglong)*(uint *)(iVar7 + 0x158) * 4))
		                      (param1,*(undefined4 *)(iVar7 + 0x15c));
		    Gameplay_SmallGames_View_DailyRewards_DailyRewardsWindow__Init(uVar2,iVar7);
		    Gameplay_SmallGames_Controller_DailyRewardsViewMediator__Init(param1,iVar7);
		    return;
		  }
		  iVar7 = *param1;
		  uVar2 = (**(code **)((ulonglong)*(uint *)(iVar7 + 0x158) * 4))
		                    (param1,*(undefined4 *)(iVar7 + 0x15c));
		  Gameplay_SmallGames_View_DailyRewards_DailyRewardsWindow__DrawPending(uVar2,iVar7);
		  Gameplay_SmallGames_Controller_DailyRewardsViewMediator__Init(param1,iVar7);
		  return;
		}
		*/

		}

		// Token: 0x06001FE1 RID: 8161 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001FE1")]
		[Address(RVA = "0x7146", Offset = "0x7146", VA = "0x7146")]
		private void Init()
		{
		/* --- GHIDRA: Init ---
		void Gameplay_SmallGames_Controller_DailyRewardsViewMediator__Init(int *param1,undefined4 param2)
		
		{
		  char cVar1;
		  char cVar2;
		  int iVar3;
		  undefined4 uVar4;
		  int *piVar5;
		  undefined4 *puVar6;
		  
		  if (DAT_ram_00a582bf == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_SmallGamesModel__SmallGamesEvents__SmallGamesController__DailyRewardsWindow__get_Model__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Linq_Enumerable_Last_ProtoRegisterVisitAns_Types_DailyRewards___);
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_6092);
		    Mono_Security_ASN1__get_Item(&StringLiteral_6093);
		    Mono_Security_ASN1__get_Item(&StringLiteral_6091);
		    Mono_Security_ASN1__get_Item(&StringLiteral_6090);
		    DAT_ram_00a582bf = '\x01';
		  }
		  iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar4 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (*(undefined4 *)(iVar3 + 0x68),0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar4,(uint)(*(char *)(*(int *)(*(int *)(param1[2] + 0x14) + 8) + 0x28) == '\0'),0);
		  iVar3 = System_Linq_Enumerable__IntersectIterator___Il2CppFullySharedGenericType_
		                    (*(undefined4 *)(*(int *)(param1[2] + 0x14) + 0xc),
		                     Method_System_Linq_Enumerable_Last_ProtoRegisterVisitAns_Types_DailyRewards___)
		  ;
		  cVar1 = *(char *)(iVar3 + 0x14);
		  cVar2 = *(char *)(*(int *)(*(int *)(param1[2] + 0x14) + 8) + 0x28);
		  iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  piVar5 = *(int **)(iVar3 + 0x5c);
		  if (cVar1 == '\0') {
		    puVar6 = (undefined4 *)&StringLiteral_6090;
		    if (cVar2 == '\0') {
		      puVar6 = &StringLiteral_6091;
		    }
		  }
		  else {
		    puVar6 = (undefined4 *)&StringLiteral_6093;
		    if (cVar2 == '\0') {
		      puVar6 = &StringLiteral_6092;
		    }
		  }
		  if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_GameLocalization_TypeInfo);
		  }
		  uVar4 = Core_Extensions_Dict_CultDicExt__GetTitle(*puVar6,1,0,1,0,0,0,0);
		  iVar3 = *piVar5;
		  (**(code **)((ulonglong)*(uint *)(iVar3 + 0x2d0) * 4))
		            (piVar5,uVar4,*(undefined4 *)(iVar3 + 0x2d4));
		  return;
		}
		*/

		}

		// Token: 0x06001FE2 RID: 8162 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001FE2")]
		[Address(RVA = "0x7147", Offset = "0x7147", VA = "0x7147")]
		private void ValidateAdditionalRewardInfo()
		{
		/* --- GHIDRA: ValidateAdditionalRewardInfo ---
		void Gameplay_SmallGames_Controller_DailyRewardsViewMediator__ValidateAdditionalRewardInfo
		               (undefined4 param1,undefined4 *param2,int *param3,int param4,undefined4 *param5,
		               int param6,undefined4 param7)
		
		{
		  undefined4 uVar1;
		  undefined4 uVar2;
		  
		  uVar1 = Gameplay_SmallGames_Controller_DailyRewardsViewMediator__SetReceivedState
		                    (param4,*param5,*param2,param4);
		  uVar2 = 4;
		  if (param6 == 0) {
		    uVar2 = 1;
		  }
		  if (*(char *)(param4 + 0x14) == '\0') {
		    uVar2 = 3;
		  }
		  (**(code **)((ulonglong)*(uint *)(*param3 + 0xe8) * 4))
		            (param3,param4,uVar1,uVar2,*(undefined4 *)(*param3 + 0xec));
		  return;
		}
		*/

		}

		// Token: 0x06001FE3 RID: 8163 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001FE3")]
		[Address(RVA = "0x7148", Offset = "0x7148", VA = "0x7148")]
		private void PopulatePanel(in uint dayNumber, SingleRewardView panel, ProtoRegisterVisitAns.Types.DailyRewards data, in int panelNumber, bool canTakeAdditional)
		{
		/* --- GHIDRA: PopulatePanel ---
		void Gameplay_SmallGames_Controller_DailyRewardsViewMediator__PopulatePanel
		               (undefined4 param1,undefined4 param2,int *param3,undefined4 param4,undefined4 param5)
		
		{
		  (**(code **)((ulonglong)*(uint *)(*param3 + 0xe8) * 4))
		            (param3,param4,param2,3,*(undefined4 *)(*param3 + 0xec));
		  return;
		}
		*/

		}

		// Token: 0x06001FE4 RID: 8164 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001FE4")]
		[Address(RVA = "0x7149", Offset = "0x7149", VA = "0x7149")]
		private void SetUnreceivedState(string title, SingleRewardView panel, ProtoRegisterVisitAns.Types.DailyRewards data)
		{
		/* --- GHIDRA: SetUnreceivedState ---
		void Gameplay_SmallGames_Controller_DailyRewardsViewMediator__SetUnreceivedState
		               (undefined4 param1,undefined4 param2,undefined4 param3,int *param4,int param5,
		               undefined4 param6)
		
		{
		  undefined4 uVar1;
		  
		  uVar1 = 4;
		  if (param5 == 0) {
		    uVar1 = 1;
		  }
		  (**(code **)((ulonglong)*(uint *)(*param4 + 0xe8) * 4))
		            (param4,param2,param3,uVar1,*(undefined4 *)(*param4 + 0xec));
		  return;
		}
		*/

		}

		// Token: 0x06001FE5 RID: 8165 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001FE5")]
		[Address(RVA = "0x714A", Offset = "0x714A", VA = "0x714A")]
		private void SetReceivedState(ProtoRegisterVisitAns.Types.DailyRewards data, string title, SingleRewardView panel, bool additionalTaken)
		{
		/* --- GHIDRA: SetReceivedState ---
		undefined4
		Gameplay_SmallGames_Controller_DailyRewardsViewMediator__SetReceivedState
		          (undefined4 param1,int param2,uint param3,undefined4 param4)
		
		{
		  undefined4 uVar1;
		  undefined4 param1_00;
		  undefined4 param3_00;
		  int local_4;
		  
		  local_4 = param2;
		  if (DAT_ram_00a582c0 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__string__Add__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__string___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_Dictionary_string__string__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_6098);
		    Mono_Security_ASN1__get_Item(&StringLiteral_6097);
		    Mono_Security_ASN1__get_Item(&StringLiteral_22536);
		    Mono_Security_ASN1__get_Item(&StringLiteral_6094);
		    DAT_ram_00a582c0 = '\x01';
		  }
		  if ((longlong)param2 == (ulonglong)param3) {
		    if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_GameLocalization_TypeInfo);
		    }
		    uVar1 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_6097,1,0,1,0,0,0,0);
		  }
		  else if ((ulonglong)(param3 + 1) == (longlong)param2) {
		    if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_GameLocalization_TypeInfo);
		    }
		    uVar1 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_6098,1,0,1,0,0,0,0);
		  }
		  else {
		    if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_GameLocalization_TypeInfo);
		    }
		    uVar1 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_6094,1,0,1,0,0,0,0);
		    param1_00 = unnamed_function_1417
		                          (System_Collections_Generic_Dictionary_string__string__TypeInfo);
		    System_Collections_Generic_Dictionary_object__StyleComplexSelector_PseudoStateData___set_Item
		              (param1_00,Method_System_Collections_Generic_Dictionary_string__string___ctor__);
		    param3_00 = func_ii_4443(&local_4,0);
		    System_Reflection_FieldInfo__get_IsStatic
		              (param1_00,StringLiteral_22536,param3_00,
		               Method_System_Collections_Generic_Dictionary_string__string__Add__);
		    uVar1 = Core_GameLocalization__GetTranslation(uVar1,param1_00,0);
		  }
		  return uVar1;
		}
		*/

		}

		// Token: 0x06001FE6 RID: 8166 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6001FE6")]
		[Address(RVA = "0x714B", Offset = "0x714B", VA = "0x714B")]
		private string DetermineTitle(int panelNumber, uint dayNumber)
		{
		/* --- GHIDRA: DetermineTitle ---
		void Gameplay_SmallGames_Controller_DailyRewardsViewMediator__DetermineTitle
		               (int *param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  
		  param1_00 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x15c));
		  Gameplay_SmallGames_View_DailyRewards_DailyRewardsWindow__Init(param1_00,param1);
		  return;
		}
		*/

			return null;
		}

		// Token: 0x06001FE7 RID: 8167 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001FE7")]
		[Address(RVA = "0x714C", Offset = "0x714C", VA = "0x714C")]
		private void DrawPendingWindow()
		{
		/* --- GHIDRA: DrawPendingWindow ---
		void Gameplay_SmallGames_Controller_DailyRewardsViewMediator__DrawPendingWindow
		               (int *param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  
		  param1_00 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x15c));
		  Gameplay_SmallGames_View_DailyRewards_DailyRewardsWindow__DrawPending(param1_00,param1);
		  return;
		}
		*/

		}

		// Token: 0x06001FE8 RID: 8168 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001FE8")]
		[Address(RVA = "0x714D", Offset = "0x714D", VA = "0x714D")]
		private void DrawReceivedWindow()
		{
		/* --- GHIDRA: DrawReceivedWindow ---
		void Gameplay_SmallGames_Controller_DailyRewardsViewMediator__DrawReceivedWindow
		               (int param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a582c1 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_MVC_AbstractController_SmallGamesModel__SmallGamesEvents__Dispose__);
		    DAT_ram_00a582c1 = '\x01';
		  }
		  MVC_AbstractController_object__object____ctor
		            (param1,Method_MVC_AbstractController_SmallGamesModel__SmallGamesEvents__Dispose__);
		  *(undefined4 *)(param1 + 0x18) = 0;
		  return;
		}
		*/

		}

		// Token: 0x0400118A RID: 4490
		[Token(Token = "0x400118A")]
		private const string LOCALIZATION_TODAY = "DAILY_REWARDS/TODAY";

		// Token: 0x0400118B RID: 4491
		[Token(Token = "0x400118B")]
		private const string LOCALIZATION_TOMORROW = "DAILY_REWARDS/TOMORROW";

		// Token: 0x0400118C RID: 4492
		[Token(Token = "0x400118C")]
		private const string LOCALIZATION_DAY_NUMBER = "DAILY_REWARDS/DAY_NUMBER";

		// Token: 0x0400118D RID: 4493
		[Token(Token = "0x400118D")]
		[FieldOffset(Offset = "0x18")]
		private SingleRewardView[] _rewardsPanels;

		// Token: 0x0400118E RID: 4494
		[Token(Token = "0x400118E")]
		[FieldOffset(Offset = "0x1C")]
		private RewardsTab _selectedTab;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_View ---
		void Gameplay_SmallGames_Controller_DailyRewardsViewMediator__set_View
		               (undefined4 param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 param1_00;
		  int *param1_01;
		  int iVar3;
		  
		  if (DAT_ram_00a582b9 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a582b9 = '\x01';
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
		        goto code_r0x80ec89aa;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_01,Core_Gameplay_IGame_TypeInfo,0x1e);
		code_r0x80ec89aa:
		  param1_00 = (**(code **)((ulonglong)*puVar2 * 4))(param1_01,puVar2[1]);
		  Core_Gameplay_Managers_GameActivityRouting_GameFeatureRouterManager__ShowDiscountsWindow
		            (param1_00,0);
		  return;
		}
		*/


		/* --- GHIDRA: set_Events ---
		void Gameplay_SmallGames_Controller_DailyRewardsViewMediator__set_Events
		               (undefined4 param1,undefined4 param2)
		
		{
		  Gameplay_SmallGames_Controller_DailyRewardsViewMediator__DailyBonusTakenEventHandler
		            (param1,param1);
		  return;
		}
		*/

}
