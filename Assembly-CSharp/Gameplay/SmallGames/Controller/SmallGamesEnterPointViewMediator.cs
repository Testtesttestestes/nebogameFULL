using System;
using System.Collections;
using Gameplay.SmallGames.Events;
using Gameplay.SmallGames.Model;
using Gameplay.SmallGames.View;
using Gameplay.UserInterface.View;
using Il2CppDummyDll;
using MVC;
using UI;
using UnityEngine;

namespace Gameplay.SmallGames.Controller
{
	// Token: 0x0200053B RID: 1339
	[Token(Token = "0x200053B")]
	public class SmallGamesEnterPointViewMediator : AbstractViewMediator<SmallGamesModel, SmallGamesEvents, SmallGamesController, UserInterfaceView>
	{
		// Token: 0x06002004 RID: 8196 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002004")]
		[Address(RVA = "0x7169", Offset = "0x7169", VA = "0x7169")]
		public SmallGamesEnterPointViewMediator(SmallGamesModel model, SmallGamesEvents events, SmallGamesController controller)
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_SmallGames_Controller_SmallGamesEnterPointViewMediator___ctor
		               (int *param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  
		  if (DAT_ram_00a582d9 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_SmallGamesModel__SmallGamesEvents__SmallGamesController__UserInterfaceView__set_View__
		              );
		    DAT_ram_00a582d9 = '\x01';
		  }
		  if (param1[7] != 0) {
		    func_ii_7950(param1[7],0);
		    param1[7] = 0;
		  }
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar2 = Cysharp_Threading_Tasks_CancellationTokenExtensions___cctor(uVar1,0);
		  if (iVar2 != 0) {
		    Gameplay_SmallGames_Controller_SmallGamesEnterPointViewMediator__SmallGamesButtonClickedEventHandler
		              (param1,param1);
		  }
		  param1[5] = param2;
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar2 = Cysharp_Threading_Tasks_CancellationTokenExtensions___cctor(uVar1,0);
		  if (iVar2 != 0) {
		    Gameplay_SmallGames_Controller_SmallGamesEnterPointViewMediator__ResetView(param1,param1);
		  }
		  return;
		}
		*/

		}

		// Token: 0x170005DC RID: 1500
		// (set) Token: 0x06002005 RID: 8197 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170005DC")]
		public override UserInterfaceView View
		{
			[Token(Token = "0x6002005")]
			[Address(RVA = "0x716A", Offset = "0x716A", VA = "0x716A", Slot = "20")]
			set
			{
			}
		}

		// Token: 0x170005DD RID: 1501
		// (get) Token: 0x06002006 RID: 8198 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06002007 RID: 8199 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170005DD")]
		public override SmallGamesEvents Events
		{
			[Token(Token = "0x6002006")]
			[Address(RVA = "0x716B", Offset = "0x716B", VA = "0x716B", Slot = "15")]
			get
			{
				return null;
			}
			[Token(Token = "0x6002007")]
			[Address(RVA = "0x716C", Offset = "0x716C", VA = "0x716C", Slot = "16")]
			set
			{
			}
		}

		// Token: 0x06002008 RID: 8200 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002008")]
		[Address(RVA = "0x716D", Offset = "0x716D", VA = "0x716D")]
		private void FreeAttemptsRequestedEventHandler()
		{
		/* --- GHIDRA: FreeAttemptsRequestedEventHandler ---
		int Gameplay_SmallGames_Controller_SmallGamesEnterPointViewMediator__FreeAttemptsRequestedEventHandler
		              (undefined4 param1,float param2,undefined4 param3)
		
		{
		  int iVar1;
		  
		  if (DAT_ram_00a582dd == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Gameplay_SmallGames_Controller_SmallGamesEnterPointViewMediator__NextFreeSpinRoutine_d__9_TypeInfo
		              );
		    DAT_ram_00a582dd = '\x01';
		  }
		  iVar1 = unnamed_function_1417
		                    (
		                    Gameplay_SmallGames_Controller_SmallGamesEnterPointViewMediator__NextFreeSpinRoutine_d__9_TypeInfo
		                    );
		  *(undefined4 *)(iVar1 + 0x14) = param1;
		  *(undefined4 *)(iVar1 + 8) = 0;
		  *(float *)(iVar1 + 0x10) = param2;
		  return iVar1;
		}
		*/

		}

		// Token: 0x06002009 RID: 8201 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6002009")]
		[Address(RVA = "0x716E", Offset = "0x716E", VA = "0x716E")]
		private IEnumerator NextFreeSpinRoutine(float backtime)
		{
		/* --- GHIDRA: NextFreeSpinRoutine ---
		void Gameplay_SmallGames_Controller_SmallGamesEnterPointViewMediator__NextFreeSpinRoutine
		               (undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  Gameplay_SmallGames_Controller_SmallGamesEnterPointViewMediator__ShowSmallGames(0);
		  return;
		}
		*/

			return null;
		}

		// Token: 0x0600200A RID: 8202 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600200A")]
		[Address(RVA = "0x716F", Offset = "0x716F", VA = "0x716F")]
		private void DailyRewardsButtonClickedEventHandler(IndexButtonBasic btn)
		{
		/* --- GHIDRA: DailyRewardsButtonClickedEventHandler ---
		void Gameplay_SmallGames_Controller_SmallGamesEnterPointViewMediator__DailyRewardsButtonClickedEventHandler
		               (undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  Gameplay_SmallGames_Controller_SmallGamesEnterPointViewMediator__HandleDailyRewardsStatusChangedEvent
		            (0,0);
		  return;
		}
		*/

		}

		// Token: 0x0600200B RID: 8203 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600200B")]
		[Address(RVA = "0x7170", Offset = "0x7170", VA = "0x7170")]
		private void SmallGamesButtonClickedEventHandler(IndexButtonBasic indexButton)
		{
		/* --- GHIDRA: SmallGamesButtonClickedEventHandler ---
		void Gameplay_SmallGames_Controller_SmallGamesEnterPointViewMediator__SmallGamesButtonClickedEventHandler
		               (int *param1,undefined4 param2)
		
		{
		  bool bVar1;
		  int param1_00;
		  int iVar2;
		  undefined4 uVar3;
		  int *param1_01;
		  int iVar4;
		  undefined4 uVar5;
		  
		  if (DAT_ram_00a582de == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_SmallGamesModel__SmallGamesEvents__SmallGamesController__UserInterfaceView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_IndexButtonBasic__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_SmallGames_Controller_SmallGamesEnterPointViewMediator_DailyRewardsButtonClickedEventHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_SmallGames_Controller_SmallGamesEnterPointViewMediator_HandleDailyRewardsStatusChangedEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_SmallGames_Controller_SmallGamesEnterPointViewMediator_SmallGamesButtonClickedEventHandler__
		              );
		    DAT_ram_00a582de = '\x01';
		  }
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar5 = *(undefined4 *)(*(int *)(iVar2 + 0x14) + 0x3c);
		  uVar3 = unnamed_function_1417(System_Action_IndexButtonBasic__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar3,param1,
		             Method_Gameplay_SmallGames_Controller_SmallGamesEnterPointViewMediator_SmallGamesButtonClickedEventHandler__
		             ,0);
		  UI_IndexButtonBasic__add_ClickEvent(uVar5,uVar3,0);
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar5 = *(undefined4 *)(*(int *)(iVar2 + 0x14) + 0x18);
		  uVar3 = unnamed_function_1417(System_Action_IndexButtonBasic__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar3,param1,
		             Method_Gameplay_SmallGames_Controller_SmallGamesEnterPointViewMediator_DailyRewardsButtonClickedEventHandler__
		             ,0);
		  UI_IndexButtonBasic__get_CanvasGroup(uVar5,uVar3,0);
		  iVar2 = *(int *)(param1[2] + 0x14);
		  uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar3,param1,
		             Method_Gameplay_SmallGames_Controller_SmallGamesEnterPointViewMediator_HandleDailyRewardsStatusChangedEvent__
		             ,0);
		  if (DAT_ram_00a582b5 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    DAT_ram_00a582b5 = '\x01';
		  }
		  param1_00 = *(int *)(iVar2 + 0x10);
		  while ((param1_01 = (int *)func_ii_7048(param1_00,uVar3,0), param1_01 == (int *)0x0 ||
		         (System_Action_TypeInfo == *param1_01))) {
		    iVar4 = func_ii_4329(iVar2 + 0x10,param1_01,param1_00);
		    bVar1 = iVar4 == param1_00;
		    param1_00 = iVar4;
		    if (bVar1) {
		      return;
		    }
		  }
		  System_Activator__CreateInstance(param1_01,System_Action_TypeInfo);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x0600200C RID: 8204 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600200C")]
		[Address(RVA = "0x7171", Offset = "0x7171", VA = "0x7171")]
		private void ResetView()
		{
		/* --- GHIDRA: ResetView ---
		void Gameplay_SmallGames_Controller_SmallGamesEnterPointViewMediator__ResetView
		               (int *param1,undefined4 param2)
		
		{
		  bool bVar1;
		  int param1_00;
		  int iVar2;
		  undefined4 uVar3;
		  int *param1_01;
		  int iVar4;
		  undefined4 uVar5;
		  
		  if (DAT_ram_00a582df == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_SmallGamesModel__SmallGamesEvents__SmallGamesController__UserInterfaceView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_IndexButtonBasic__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_SmallGames_Controller_SmallGamesEnterPointViewMediator_DailyRewardsButtonClickedEventHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_SmallGames_Controller_SmallGamesEnterPointViewMediator_HandleDailyRewardsStatusChangedEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_SmallGames_Controller_SmallGamesEnterPointViewMediator_SmallGamesButtonClickedEventHandler__
		              );
		    DAT_ram_00a582df = '\x01';
		  }
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar5 = *(undefined4 *)(*(int *)(iVar2 + 0x14) + 0x3c);
		  uVar3 = unnamed_function_1417(System_Action_IndexButtonBasic__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar3,param1,
		             Method_Gameplay_SmallGames_Controller_SmallGamesEnterPointViewMediator_SmallGamesButtonClickedEventHandler__
		             ,0);
		  UI_IndexButtonBasic__get_CanvasGroup(uVar5,uVar3,0);
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar5 = *(undefined4 *)(*(int *)(iVar2 + 0x14) + 0x18);
		  uVar3 = unnamed_function_1417(System_Action_IndexButtonBasic__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar3,param1,
		             Method_Gameplay_SmallGames_Controller_SmallGamesEnterPointViewMediator_DailyRewardsButtonClickedEventHandler__
		             ,0);
		  UI_IndexButtonBasic__get_CanvasGroup(uVar5,uVar3,0);
		  iVar2 = *(int *)(param1[2] + 0x14);
		  uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar3,param1,
		             Method_Gameplay_SmallGames_Controller_SmallGamesEnterPointViewMediator_HandleDailyRewardsStatusChangedEvent__
		             ,0);
		  if (DAT_ram_00a582b4 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    DAT_ram_00a582b4 = '\x01';
		  }
		  param1_00 = *(int *)(iVar2 + 0x10);
		  while ((param1_01 = (int *)UnityEngine_UI_Image__set_sprite(param1_00,uVar3,0),
		         param1_01 == (int *)0x0 || (System_Action_TypeInfo == *param1_01))) {
		    iVar4 = func_ii_4329(iVar2 + 0x10,param1_01,param1_00);
		    bVar1 = iVar4 == param1_00;
		    param1_00 = iVar4;
		    if (bVar1) {
		      iVar2 = *param1;
		      uVar3 = (**(code **)((ulonglong)*(uint *)(iVar2 + 0x148) * 4))
		                        (param1,*(undefined4 *)(iVar2 + 0x14c));
		      Gameplay_SmallGames_Controller_SmallGamesController__ValidateInit(uVar3,iVar2);
		      Gameplay_SmallGames_Controller_SmallGamesEnterPointViewMediator__set_Events(param1,iVar2);
		      if (DAT_ram_00a582e0 == '\0') {
		        Mono_Security_ASN1__get_Item
		                  (&
		                   Method_MVC_AbstractViewMediator_SmallGamesModel__SmallGamesEvents__SmallGamesController__UserInterfaceView__get_Model__
		                  );
		        DAT_ram_00a582e0 = '\x01';
		      }
		      iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x15c));
		      System_Collections_Generic_Dictionary_int__object___get_Count
		                (*(undefined4 *)(*(int *)(*(int *)(iVar2 + 0x14) + 0x18) + 0x14),
		                 (uint)(*(int *)(*(int *)(*(int *)(param1[2] + 0x14) + 8) + 0x18) == 0),0);
		      return;
		    }
		  }
		  System_Activator__CreateInstance(param1_01,System_Action_TypeInfo);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x0600200D RID: 8205 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600200D")]
		[Address(RVA = "0x7172", Offset = "0x7172", VA = "0x7172")]
		private void SetupView()
		{
		/* --- GHIDRA: SetupView ---
		void Gameplay_SmallGames_Controller_SmallGamesEnterPointViewMediator__SetupView
		               (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  if (iVar1 != 0) {
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    System_Collections_Generic_Dictionary_int__object___get_Count
		              (*(undefined4 *)(*(int *)(*(int *)(iVar1 + 0x14) + 0x3c) + 0x14),param2,0);
		  }
		  return;
		}
		*/

		}

		// Token: 0x0600200E RID: 8206 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600200E")]
		[Address(RVA = "0x7173", Offset = "0x7173", VA = "0x7173")]
		private void HandleFreeAttemptsCountChangedEvent(int count)
		{
		/* --- GHIDRA: HandleFreeAttemptsCountChangedEvent ---
		void Gameplay_SmallGames_Controller_SmallGamesEnterPointViewMediator__HandleFreeAttemptsCountChangedEvent
		               (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  if (DAT_ram_00a582e0 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_SmallGamesModel__SmallGamesEvents__SmallGamesController__UserInterfaceView__get_Model__
		              );
		    DAT_ram_00a582e0 = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  System_Collections_Generic_Dictionary_int__object___get_Count
		            (*(undefined4 *)(*(int *)(*(int *)(iVar1 + 0x14) + 0x18) + 0x14),
		             (uint)(*(int *)(*(int *)(*(int *)(param1[2] + 0x14) + 8) + 0x18) == 0),0);
		  return;
		}
		*/

		}

		// Token: 0x0600200F RID: 8207 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600200F")]
		[Address(RVA = "0x7174", Offset = "0x7174", VA = "0x7174")]
		private void HandleDailyRewardsStatusChangedEvent()
		{
		/* --- GHIDRA: HandleDailyRewardsStatusChangedEvent ---
		void Gameplay_SmallGames_Controller_SmallGamesEnterPointViewMediator__HandleDailyRewardsStatusChangedEvent
		               (undefined4 param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 param1_00;
		  int *param1_01;
		  int iVar3;
		  
		  if (DAT_ram_00a582e1 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a582e1 = '\x01';
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
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + iVar3 + 0x1b8);
		        goto code_r0x80ecb517;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_01,Core_Gameplay_IGame_TypeInfo,0x1f);
		code_r0x80ecb517:
		  param1_00 = (**(code **)((ulonglong)*puVar2 * 4))(param1_01,puVar2[1]);
		  Core_Gameplay_Managers_SmallGamesManager__Deinit(param1_00,0,0);
		  return;
		}
		*/

		}

		// Token: 0x06002010 RID: 8208 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002010")]
		[Address(RVA = "0x7175", Offset = "0x7175", VA = "0x7175")]
		private void ShowSmallGames()
		{
		/* --- GHIDRA: ShowSmallGames ---
		void Gameplay_SmallGames_Controller_SmallGamesEnterPointViewMediator__ShowSmallGames
		               (undefined4 param1)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 param1_00;
		  int *param1_01;
		  int iVar3;
		  
		  if (DAT_ram_00a582e2 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a582e2 = '\x01';
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
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + iVar3 + 0x1b8);
		        goto code_r0x80ecb436;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_01,Core_Gameplay_IGame_TypeInfo,0x1f);
		code_r0x80ecb436:
		  param1_00 = (**(code **)((ulonglong)*puVar2 * 4))(param1_01,puVar2[1]);
		  Core_Gameplay_Managers_SmallGamesManager__ShowSmallGamesWindow(param1_00,0);
		  return;
		}
		*/

		}

		// Token: 0x06002011 RID: 8209 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002011")]
		[Address(RVA = "0x7176", Offset = "0x7176", VA = "0x7176")]
		private static void ShowDailyRewards()
		{
		/* --- GHIDRA: ShowDailyRewards ---
		void Gameplay_SmallGames_Controller_SmallGamesEnterPointViewMediator__ShowDailyRewards
		               (int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  undefined4 param1_01;
		  
		  if (DAT_ram_00a582e3 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_SmallGames_Controller_SmallGamesEnterPointViewMediator_SmallGamesWindowOnCloseEventHandler__
		              );
		    DAT_ram_00a582e3 = '\x01';
		  }
		  param1_01 = *(undefined4 *)(param1 + 0x18);
		  param1_00 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (param1_00,param1,
		             Method_Gameplay_SmallGames_Controller_SmallGamesEnterPointViewMediator_SmallGamesWindowOnCloseEventHandler__
		             ,0);
		  UI_Windows_BaseWindow__add_onClose(param1_01,param1_00,0);
		  *(undefined4 *)(param1 + 0x18) = 0;
		  return;
		}
		*/

		}

		// Token: 0x06002012 RID: 8210 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002012")]
		[Address(RVA = "0x7177", Offset = "0x7177", VA = "0x7177")]
		private void SmallGamesWindowOnCloseEventHandler()
		{
		/* --- GHIDRA: SmallGamesWindowOnCloseEventHandler ---
		void Gameplay_SmallGames_Controller_SmallGamesEnterPointViewMediator__SmallGamesWindowOnCloseEventHandler
		               (int param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a582e4 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_SmallGamesModel__SmallGamesEvents__SmallGamesController__UserInterfaceView__Dispose__
		              );
		    DAT_ram_00a582e4 = '\x01';
		  }
		  if (*(int *)(param1 + 0x1c) != 0) {
		    func_ii_7950(*(int *)(param1 + 0x1c),0);
		    *(undefined4 *)(param1 + 0x1c) = 0;
		  }
		  MVC_AbstractViewMediator_object__object__object__object___Core_MVC_Interfaces_IViewMediator_set_View
		            (param1,
		             Method_MVC_AbstractViewMediator_SmallGamesModel__SmallGamesEvents__SmallGamesController__UserInterfaceView__Dispose__
		            );
		  return;
		}
		*/

		}

		// Token: 0x06002013 RID: 8211 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002013")]
		[Address(RVA = "0x7178", Offset = "0x7178", VA = "0x7178", Slot = "14")]
		public override void Dispose()
		{
		}

		// Token: 0x04001190 RID: 4496
		[Token(Token = "0x4001190")]
		[FieldOffset(Offset = "0x18")]
		private SmallGamesWindow _smallGamesWindow;

		// Token: 0x04001191 RID: 4497
		[Token(Token = "0x4001191")]
		[FieldOffset(Offset = "0x1C")]
		private Coroutine _nextFreeSpinRoutine;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_View ---
		undefined4
		Gameplay_SmallGames_Controller_SmallGamesEnterPointViewMediator__set_View
		          (int param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a582da == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_SmallGamesModel__SmallGamesEvents__SmallGamesController__UserInterfaceView__get_Events__
		              );
		    DAT_ram_00a582da = '\x01';
		  }
		  return *(undefined4 *)(param1 + 0xc);
		}
		*/


		/* --- GHIDRA: get_Events ---
		void Gameplay_SmallGames_Controller_SmallGamesEnterPointViewMediator__get_Events
		               (int *param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  int iVar2;
		  undefined4 uVar3;
		  int *piVar4;
		  int iVar5;
		  undefined4 uVar6;
		  
		  if (DAT_ram_00a582db == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_SmallGamesModel__SmallGamesEvents__SmallGamesController__UserInterfaceView__set_Events__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_int__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_SmallGames_Controller_SmallGamesEnterPointViewMediator_FreeAttemptsRequestedEventHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_SmallGames_Controller_SmallGamesEnterPointViewMediator_HandleFreeAttemptsCountChangedEvent__
		              );
		    DAT_ram_00a582db = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x13c));
		  if (iVar1 != 0) {
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar6 = *(undefined4 *)(iVar2 + 0x24);
		    uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar3,param1,
		               Method_Gameplay_SmallGames_Controller_SmallGamesEnterPointViewMediator_FreeAttemptsRequestedEventHandler__
		               ,0);
		    piVar4 = (int *)func_ii_7048(uVar6,uVar3,0);
		    iVar1 = System_Action_TypeInfo;
		    if (piVar4 == (int *)0x0) {
		      *(undefined4 *)(iVar2 + 0x24) = 0;
		    }
		    else if ((System_Action_TypeInfo != *piVar4) ||
		            (*(int **)(iVar2 + 0x24) = piVar4, *piVar4 != iVar1)) {
		      System_Activator__CreateInstance(piVar4,iVar1);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar6 = *(undefined4 *)(iVar1 + 0x38);
		    uVar3 = unnamed_function_1417(System_Action_int__TypeInfo);
		    System_Action_short___Invoke
		              (uVar3,param1,
		               Method_Gameplay_SmallGames_Controller_SmallGamesEnterPointViewMediator_HandleFreeAttemptsCountChangedEvent__
		               ,0);
		    iVar2 = func_ii_7048(uVar6,uVar3,0);
		    uVar3 = System_Action_int__TypeInfo;
		    if (iVar2 == 0) {
		      *(undefined4 *)(iVar1 + 0x38) = 0;
		    }
		    else {
		      iVar5 = func_ii_1082(iVar2,System_Action_int__TypeInfo);
		      if (iVar5 == 0) {
		        System_Activator__CreateInstance(iVar2,uVar3);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      *(int *)(iVar1 + 0x38) = iVar5;
		      uVar3 = System_Action_int__TypeInfo;
		      iVar1 = func_ii_1082(iVar2,System_Action_int__TypeInfo);
		      if (iVar1 == 0) {
		        System_Activator__CreateInstance(iVar2,uVar3);
		        do {
		          halt_trap();
		        } while( true );
		      }
		    }
		  }
		  param1[3] = param2;
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x13c));
		  if (iVar1 != 0) {
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar6 = *(undefined4 *)(iVar2 + 0x24);
		    uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar3,param1,
		               Method_Gameplay_SmallGames_Controller_SmallGamesEnterPointViewMediator_FreeAttemptsRequestedEventHandler__
		               ,0);
		    piVar4 = (int *)UnityEngine_UI_Image__set_sprite(uVar6,uVar3,0);
		    iVar1 = System_Action_TypeInfo;
		    if (piVar4 == (int *)0x0) {
		      *(undefined4 *)(iVar2 + 0x24) = 0;
		    }
		    else if ((System_Action_TypeInfo != *piVar4) ||
		            (*(int **)(iVar2 + 0x24) = piVar4, *piVar4 != iVar1)) {
		      System_Activator__CreateInstance(piVar4,iVar1);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar6 = *(undefined4 *)(iVar1 + 0x38);
		    uVar3 = unnamed_function_1417(System_Action_int__TypeInfo);
		    System_Action_short___Invoke
		              (uVar3,param1,
		               Method_Gameplay_SmallGames_Controller_SmallGamesEnterPointViewMediator_HandleFreeAttemptsCountChangedEvent__
		               ,0);
		    iVar2 = UnityEngine_UI_Image__set_sprite(uVar6,uVar3,0);
		    uVar3 = System_Action_int__TypeInfo;
		    if (iVar2 == 0) {
		      *(undefined4 *)(iVar1 + 0x38) = 0;
		      return;
		    }
		    iVar5 = func_ii_1082(iVar2,System_Action_int__TypeInfo);
		    if (iVar5 == 0) {
		      System_Activator__CreateInstance(iVar2,uVar3);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    *(int *)(iVar1 + 0x38) = iVar5;
		    uVar3 = System_Action_int__TypeInfo;
		    iVar1 = func_ii_1082(iVar2,System_Action_int__TypeInfo);
		    if (iVar1 == 0) {
		      System_Activator__CreateInstance(iVar2,uVar3);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  return;
		}
		*/


		/* --- GHIDRA: set_Events ---
		void Gameplay_SmallGames_Controller_SmallGamesEnterPointViewMediator__set_Events
		               (int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  undefined4 param1_00;
		  float fVar2;
		  float fVar3;
		  int iVar4;
		  
		  if (DAT_ram_00a582dc == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_SmallGamesModel__SmallGamesEvents__SmallGamesController__UserInterfaceView__get_Model__
		              );
		    DAT_ram_00a582dc = '\x01';
		  }
		  if (*(int *)(param1 + 0x1c) != 0) {
		    func_ii_7950(*(int *)(param1 + 0x1c),0);
		    *(undefined4 *)(param1 + 0x1c) = 0;
		  }
		  iVar4 = *(int *)(param1 + 8);
		  if (DAT_ram_00a582ac == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_SlotMachineType__BackTime__get_Item__);
		    DAT_ram_00a582ac = '\x01';
		  }
		  uVar1 = GAFInternal_Reader_GAFReader__OpenTag
		                    (*(undefined4 *)(iVar4 + 0x34),1,
		                     Method_System_Collections_Generic_Dictionary_SlotMachineType__BackTime__get_Item__
		                    );
		  iVar4 = *(int *)(param1 + 8);
		  if (DAT_ram_00a582ac == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_SlotMachineType__BackTime__get_Item__);
		    DAT_ram_00a582ac = '\x01';
		  }
		  param1_00 = GAFInternal_Reader_GAFReader__OpenTag
		                        (*(undefined4 *)(iVar4 + 0x34),2,
		                         Method_System_Collections_Generic_Dictionary_SlotMachineType__BackTime__get_Item__
		                        );
		  fVar2 = func_ii_7103(uVar1,0);
		  fVar3 = func_ii_7103(param1_00,0);
		  if (fVar2 <= fVar3) {
		    param1_00 = uVar1;
		  }
		  fVar2 = func_ii_7103(param1_00,0);
		  if (0.0 < fVar2) {
		    fVar2 = func_ii_7103(param1_00,0);
		    if (DAT_ram_00a582dd == '\0') {
		      Mono_Security_ASN1__get_Item
		                (&
		                 Gameplay_SmallGames_Controller_SmallGamesEnterPointViewMediator__NextFreeSpinRoutine_d__9_TypeInfo
		                );
		      DAT_ram_00a582dd = '\x01';
		    }
		    iVar4 = unnamed_function_1417
		                      (
		                      Gameplay_SmallGames_Controller_SmallGamesEnterPointViewMediator__NextFreeSpinRoutine_d__9_TypeInfo
		                      );
		    *(int *)(iVar4 + 0x14) = param1;
		    *(undefined4 *)(iVar4 + 8) = 0;
		    *(float *)(iVar4 + 0x10) = fVar2;
		    uVar1 = Utils_CoroutineSource__GetMono(iVar4,0);
		    *(undefined4 *)(param1 + 0x1c) = uVar1;
		  }
		  return;
		}
		*/

}
