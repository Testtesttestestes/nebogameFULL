using System;
using System.Runtime.CompilerServices;
using Gameplay.Clans.Buildings.Golem.Model;
using Gameplay.Clans.ClanWars;
using Gameplay.Clans.ClanWars.Controller;
using Gameplay.Clans.ClanWars.Events;
using Gameplay.Clans.ClanWars.Model;
using Il2CppDummyDll;
using Protocol.ClanWar;
using Protocol.Common;
using Protocol.Dic;
using UI.Windows;

namespace Core.Gameplay.Managers
{
	// Token: 0x02001148 RID: 4424
	[Token(Token = "0x2001148")]
	public class ClanWarsManager : IGameManager, IBaseManager, IClanWars
	{
		// Token: 0x17001555 RID: 5461
		// (get) Token: 0x0600681B RID: 26651 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17001555")]
		public string Name
		{
			[Token(Token = "0x600681B")]
			[Address(RVA = "0xB347", Offset = "0xB347", VA = "0xB347", Slot = "10")]
			get
			{
				return null;
			}
		}

		// Token: 0x1400026C RID: 620
		// (add) Token: 0x0600681C RID: 26652 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600681D RID: 26653 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1400026C")]
		public event Action<IBaseManager> InitCompleteEvent
		{
			[Token(Token = "0x600681C")]
			[Address(RVA = "0xB348", Offset = "0xB348", VA = "0xB348", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600681D")]
			[Address(RVA = "0xB349", Offset = "0xB349", VA = "0xB349", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x1400026D RID: 621
		// (add) Token: 0x0600681E RID: 26654 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600681F RID: 26655 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1400026D")]
		public event Action<IBaseManager> DeinitCompleteEvent
		{
			[Token(Token = "0x600681E")]
			[Address(RVA = "0xB34A", Offset = "0xB34A", VA = "0xB34A", Slot = "6")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600681F")]
			[Address(RVA = "0xB34B", Offset = "0xB34B", VA = "0xB34B", Slot = "7")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x17001556 RID: 5462
		// (get) Token: 0x06006820 RID: 26656 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06006821 RID: 26657 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001556")]
		public ClanWarsModel Model
		{
			[Token(Token = "0x6006820")]
			[Address(RVA = "0xB34C", Offset = "0xB34C", VA = "0xB34C")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6006821")]
			[Address(RVA = "0xB34D", Offset = "0xB34D", VA = "0xB34D")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17001557 RID: 5463
		// (get) Token: 0x06006822 RID: 26658 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06006823 RID: 26659 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001557")]
		public ClanWarsEvents Events
		{
			[Token(Token = "0x6006822")]
			[Address(RVA = "0xB34E", Offset = "0xB34E", VA = "0xB34E")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6006823")]
			[Address(RVA = "0xB34F", Offset = "0xB34F", VA = "0xB34F")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17001558 RID: 5464
		// (get) Token: 0x06006824 RID: 26660 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06006825 RID: 26661 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001558")]
		public ClanWarsController Controller
		{
			[Token(Token = "0x6006824")]
			[Address(RVA = "0xB350", Offset = "0xB350", VA = "0xB350")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6006825")]
			[Address(RVA = "0xB351", Offset = "0xB351", VA = "0xB351")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17001559 RID: 5465
		// (get) Token: 0x06006826 RID: 26662 RVA: 0x00013890 File Offset: 0x00011A90
		[Token(Token = "0x17001559")]
		public bool WarsDisabled
		{
			[Token(Token = "0x6006826")]
			[Address(RVA = "0xB352", Offset = "0xB352", VA = "0xB352")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700155A RID: 5466
		// (get) Token: 0x06006827 RID: 26663 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700155A")]
		public SeasonLeagueDic CurrentSeasonLeagueDic
		{
			[Token(Token = "0x6006827")]
			[Address(RVA = "0xB353", Offset = "0xB353", VA = "0xB353")]
			get
			{
				return null;
			}
		}

		// Token: 0x06006828 RID: 26664 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006828")]
		[Address(RVA = "0xB354", Offset = "0xB354", VA = "0xB354", Slot = "9")]
		public void Deinit()
		{
		/* --- GHIDRA: Deinit ---
		void Core_Gameplay_Managers_ClanWarsManager__Deinit(int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 uVar3;
		  undefined4 uVar4;
		  int *piVar5;
		  int iVar6;
		  undefined4 param2_00;
		  int iVar7;
		  
		  if (DAT_ram_00a5a9d3 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Clans_ClanWars_Controller_ClanWarsController_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Clans_ClanWars_Events_ClanWarsEvents_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Gameplay_Managers_ClanWarsManager_HandleControllerInitEvent__);
		    Mono_Security_ASN1__get_Item(&Gameplay_Clans_ClanWars_Model_ClanWarsModel_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a5a9d3 = '\x01';
		  }
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  uVar1 = 0;
		  piVar5 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar6 = *piVar5;
		  if (*(ushort *)(iVar6 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8 + 4) * 8 + iVar6 + 0x140);
		        goto code_r0x812a4873;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar5,Core_Gameplay_IGame_TypeInfo,0x10);
		code_r0x812a4873:
		  uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(piVar5,puVar2[1]);
		  uVar3 = func_ii_7112(uVar3,0);
		  uVar4 = unnamed_function_1417(Gameplay_Clans_ClanWars_Model_ClanWarsModel_TypeInfo);
		  Gameplay_Clans_ClanWars_Model_ClanWarsModel__get_CanAccelerate(uVar4,uVar3,0);
		  *(undefined4 *)(param1 + 0x10) = uVar4;
		  uVar3 = unnamed_function_1417(Gameplay_Clans_ClanWars_Events_ClanWarsEvents_TypeInfo);
		  *(undefined4 *)(param1 + 0x14) = uVar3;
		  param2_00 = *(undefined4 *)(param1 + 0x10);
		  uVar4 = unnamed_function_1417(Gameplay_Clans_ClanWars_Controller_ClanWarsController_TypeInfo);
		  Gameplay_Clans_ClanWars_Events_ClanWarsEvents___ctor(uVar4,param2_00,uVar3,0);
		  *(undefined4 *)(param1 + 0x18) = uVar4;
		  iVar7 = *(int *)(param1 + 0x14);
		  uVar4 = *(undefined4 *)(iVar7 + 8);
		  uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar3,param1,Method_Core_Gameplay_Managers_ClanWarsManager_HandleControllerInitEvent__,
		             0);
		  piVar5 = (int *)UnityEngine_UI_Image__set_sprite(uVar4,uVar3,0);
		  iVar6 = System_Action_TypeInfo;
		  if (piVar5 == (int *)0x0) {
		    *(undefined4 *)(iVar7 + 8) = 0;
		  }
		  else if ((System_Action_TypeInfo != *piVar5) || (*(int **)(iVar7 + 8) = piVar5, *piVar5 != iVar6))
		  {
		    System_Activator__CreateInstance(piVar5,iVar6);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  MVC_AbstractController__Dispose(*(undefined4 *)(param1 + 0x18),0);
		  return;
		}
		*/

		}

		// Token: 0x06006829 RID: 26665 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006829")]
		[Address(RVA = "0xB355", Offset = "0xB355", VA = "0xB355", Slot = "8")]
		public void Init()
		{
		/* --- GHIDRA: Init ---
		void Core_Gameplay_Managers_ClanWarsManager__Init(int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  int *param1_01;
		  int iVar1;
		  undefined4 param1_02;
		  int iVar2;
		  
		  if (DAT_ram_00a5a9d4 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Gameplay_Managers_ClanWarsManager_HandleControllerInitEvent__);
		    DAT_ram_00a5a9d4 = '\x01';
		  }
		  iVar1 = *(int *)(param1 + 0x14);
		  param1_02 = *(undefined4 *)(iVar1 + 8);
		  param1_00 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (param1_00,param1,
		             Method_Core_Gameplay_Managers_ClanWarsManager_HandleControllerInitEvent__,0);
		  param1_01 = (int *)func_ii_7048(param1_02,param1_00,0);
		  iVar2 = System_Action_TypeInfo;
		  if (param1_01 == (int *)0x0) {
		    *(undefined4 *)(iVar1 + 8) = 0;
		  }
		  else if ((System_Action_TypeInfo != *param1_01) ||
		          (*(int **)(iVar1 + 8) = param1_01, *param1_01 != iVar2)) {
		    System_Activator__CreateInstance(param1_01,iVar2);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  iVar2 = *(int *)(param1 + 8);
		  if (iVar2 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar2 + 0xc) * 4))
		              (*(undefined4 *)(iVar2 + 0x20),param1,*(undefined4 *)(iVar2 + 0x14));
		  }
		  return;
		}
		*/

		}

		// Token: 0x0600682A RID: 26666 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600682A")]
		[Address(RVA = "0xB356", Offset = "0xB356", VA = "0xB356")]
		private void HandleControllerInitEvent()
		{
		/* --- GHIDRA: HandleControllerInitEvent ---
		undefined4
		Core_Gameplay_Managers_ClanWarsManager__HandleControllerInitEvent(int param1,undefined4 param2)
		
		{
		  return *(undefined4 *)(*(int *)(*(int *)(param1 + 0x10) + 0x14) + 0x40);
		}
		*/

		}

		// Token: 0x0600682B RID: 26667 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600682B")]
		[Address(RVA = "0xB357", Offset = "0xB357", VA = "0xB357")]
		public ResourceSet GetPayOffCost()
		{
		/* --- GHIDRA: GetPayOffCost ---
		undefined4
		Core_Gameplay_Managers_ClanWarsManager__GetPayOffCost
		          (int param1,undefined4 param2,float param3,undefined4 param4)
		
		{
		  uint uVar1;
		  undefined4 uVar2;
		  int iVar3;
		  float fVar4;
		  
		  if (DAT_ram_00a5a9d5 == '\0') {
		    Mono_Security_ASN1__get_Item(&Utils_TimeUtils_TypeInfo);
		    DAT_ram_00a5a9d5 = '\x01';
		  }
		  uVar2 = Gameplay_Clans_Combat_Control_ClanCombatViewMediator___HandleGameOver_b__6_0
		                    (*(undefined4 *)(param1 + 0x10),0);
		  iVar3 = Core_Extensions_Dict_DictExt__GetPointPointsForMonsterDic(uVar2,3,param2,0);
		  uVar2 = Protocol_Common_ResourceSet___ctor(*(undefined4 *)(iVar3 + 0x24),0);
		  uVar1 = *(uint *)(iVar3 + 0x20);
		  if (*(int *)(Utils_TimeUtils_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Utils_TimeUtils_TypeInfo);
		  }
		  fVar4 = func_ii_7331((ulonglong)uVar1,0);
		  fVar4 = UnityEngine_Camera__set_orthographicSize(param3,fVar4,0);
		  uVar2 = Core_Extensions_Dict_ResourceSetExt__Round(uVar2,(double)fVar4,0);
		  uVar2 = Core_Extensions_Dict_ResourceSetExt__Floor(uVar2,0);
		  return uVar2;
		}
		*/

			return null;
		}

		// Token: 0x0600682C RID: 26668 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600682C")]
		[Address(RVA = "0xB358", Offset = "0xB358", VA = "0xB358")]
		public ResourceSet GetGolemRestorePriceByLevel(uint level, float leftTimer)
		{
		/* --- GHIDRA: GetGolemRestorePriceByLevel ---
		void Core_Gameplay_Managers_ClanWarsManager__GetGolemRestorePriceByLevel
		               (int param1,int param2,undefined4 param3)
		
		{
		  int param1_00;
		  undefined4 uVar1;
		  undefined4 param4;
		  undefined4 param3_00;
		  undefined4 param2_00;
		  
		  if (DAT_ram_00a5a9d6 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Dict_DictWrappers_Base_AbstractDictWrapper_AprDic__uint__get_Data__);
		    Mono_Security_ASN1__get_Item(&Method_UI_Windows_PopupController_Show_WarStatusWindow___);
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_Clans_Buildings_Golem_Controller_WarStatusViewMasterMediator_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_Clans_Buildings_Golem_View_WarStatusWindow_WarStatusWindowArgs_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_12594);
		    DAT_ram_00a5a9d6 = '\x01';
		  }
		  param1_00 = unnamed_function_1417
		                        (
		                        Gameplay_Clans_Buildings_Golem_View_WarStatusWindow_WarStatusWindowArgs_TypeInfo
		                        );
		  Gameplay_AccountLinker_View_SelectUserWindow___ctor(param1_00,0);
		  uVar1 = UI_Wiki_WikiUriRouter__SetData
		                    (*(undefined4 *)(*(int *)(*(int *)(param2 + 0x1c) + 0x38) + 0x10),0);
		  *(undefined4 *)(param1_00 + 0x18) = uVar1;
		  param4 = *(undefined4 *)(param1 + 0x18);
		  param3_00 = *(undefined4 *)(param1 + 0x14);
		  param2_00 = *(undefined4 *)(param1 + 0x10);
		  uVar1 = unnamed_function_1417
		                    (Gameplay_Clans_Buildings_Golem_Controller_WarStatusViewMasterMediator_TypeInfo)
		  ;
		  Gameplay_Clans_Buildings_Golem_Controller_TruceStatusViewMediator__ValidateShieldButton
		            (uVar1,param2_00,param3_00,param4,param2,0);
		  *(undefined4 *)(param1_00 + 0x1c) = uVar1;
		  uVar1 = System_Uri___ctor(0);
		  uVar1 = System_Globalization_TimeSpanFormat_FormatLiterals__get_Start(uVar1,0);
		  Gameplay_Antiq_View_GroupReviewWindow_WindowArgs___ctor
		            (uVar1,StringLiteral_12594,param1_00,
		             Method_UI_Windows_PopupController_Show_WarStatusWindow___);
		  return;
		}
		*/

			return null;
		}

		// Token: 0x0600682D RID: 26669 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600682D")]
		[Address(RVA = "0xB359", Offset = "0xB359", VA = "0xB359")]
		public void OpenWarStatusWindow(GolemModel golemModel)
		{
		/* --- GHIDRA: OpenWarStatusWindow ---
		undefined4
		Core_Gameplay_Managers_ClanWarsManager__OpenWarStatusWindow
		          (int param1,undefined8 param2,undefined4 param3,undefined4 param4,undefined4 param5,
		          undefined4 param6)
		
		{
		  int iVar1;
		  float fVar2;
		  undefined4 uVar3;
		  undefined4 uVar4;
		  undefined4 param1_00;
		  undefined4 uVar5;
		  undefined4 param4_00;
		  int iVar6;
		  int iVar7;
		  int iVar8;
		  int param1_01;
		  uint uVar9;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a5a9d7 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_ButtonCallbackDelegate_DialogWindow_DialogWindowArgs__TypeInfo
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_DialogWindow_DialogWindowArgs___ctor__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_DialogWindow_DialogWindowArgs__set_Callback__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_DialogWindow_DialogWindowArgs__TypeInfo
		              );
		    Mono_Security_ASN1__get_Item(&UI_Windows_DialogWindow_DialogWindowArgs_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs___ctor__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs__TypeInfo
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__string__Add__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__string___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_Dictionary_string__string__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs___Add__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Gameplay_Managers_ClanWarsManager___c__DisplayClass30_0__ShowDeclareWarDialogWindow_b__0__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Core_Gameplay_Managers_ClanWarsManager___c__DisplayClass30_0_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_4107);
		    Mono_Security_ASN1__get_Item(&StringLiteral_28710);
		    Mono_Security_ASN1__get_Item(&StringLiteral_2556);
		    Mono_Security_ASN1__get_Item(&StringLiteral_4219);
		    Mono_Security_ASN1__get_Item(&StringLiteral_26465);
		    Mono_Security_ASN1__get_Item(&StringLiteral_4260);
		    Mono_Security_ASN1__get_Item(&StringLiteral_4218);
		    Mono_Security_ASN1__get_Item(&StringLiteral_4231);
		    Mono_Security_ASN1__get_Item(&StringLiteral_3631);
		    Mono_Security_ASN1__get_Item(&StringLiteral_3656);
		    Mono_Security_ASN1__get_Item(&StringLiteral_21976);
		    DAT_ram_00a5a9d7 = '\x01';
		  }
		  iVar1 = unnamed_function_1417
		                    (Core_Gameplay_Managers_ClanWarsManager___c__DisplayClass30_0_TypeInfo);
		  *(undefined4 *)(iVar1 + 0x1c) = param5;
		  *(undefined4 *)(iVar1 + 0x18) = param3;
		  *(undefined8 *)(iVar1 + 0x10) = param2;
		  *(int *)(iVar1 + 8) = param1;
		  iVar8 = *(int *)(*(int *)(param1 + 0x10) + 0x1c);
		  if ((iVar8 == 0) || (fVar2 = func_ii_7103(iVar8,0), fVar2 <= 0.0)) {
		    if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_GameLocalization_TypeInfo);
		    }
		    uVar3 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_4260,1,0,1,0,0,0,0);
		    uVar4 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_4231,1,0,1,0,0,0,0);
		    uVar3 = UI_Windows_DialogWindow__Show(uVar3,uVar4,0);
		  }
		  else {
		    iVar8 = Gameplay_Clans_ClanWars_Model_ClanWarsModel__set_CurrentSeasonId
		                      (*(undefined4 *)(param1 + 0x10),0);
		    uVar3 = *(undefined4 *)(iVar8 + 0x18);
		    iVar8 = unnamed_function_1417(UI_Windows_DialogWindow_DialogWindowArgs_TypeInfo);
		    func_ii_8625(iVar8,0);
		    if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_GameLocalization_TypeInfo);
		    }
		    uVar4 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_4219,1,0,1,0,0,0,0);
		    *(undefined4 *)(iVar8 + 0x18) = uVar4;
		    uVar4 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_4218,1,0,1,0,0,0,0);
		    param1_00 = unnamed_function_1417
		                          (System_Collections_Generic_Dictionary_string__string__TypeInfo);
		    System_Collections_Generic_Dictionary_object__StyleComplexSelector_PseudoStateData___set_Item
		              (param1_00,Method_System_Collections_Generic_Dictionary_string__string___ctor__);
		    uVar5 = Core_Extensions_Dict_ResourceSetExt__ToLocaleString
		                      (*(undefined4 *)(iVar1 + 0x18),NAN,0,StringLiteral_2556,0,0,0);
		    System_Reflection_FieldInfo__get_IsStatic
		              (param1_00,StringLiteral_21976,uVar5,
		               Method_System_Collections_Generic_Dictionary_string__string__Add__);
		    uVar3 = Core_Extensions_Dict_ResourceSetExt__ToLocaleString
		                      (uVar3,NAN,0,StringLiteral_2556,0,0,0);
		    uVar5 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_3656,1,0,1,0,0,0,0);
		    local_4 = param4;
		    param4_00 = func_ii_1081(DAT_ram_00a66954,&local_4);
		    uVar3 = func_ii_8529(StringLiteral_28710,uVar3,uVar5,param4_00,0);
		    System_Reflection_FieldInfo__get_IsStatic
		              (param1_00,StringLiteral_26465,uVar3,
		               Method_System_Collections_Generic_Dictionary_string__string__Add__);
		    uVar3 = Core_GameLocalization__GetTranslation(uVar4,param1_00,0);
		    *(undefined4 *)(iVar8 + 0x1c) = uVar3;
		    param1_01 = *(int *)(iVar8 + 0x24);
		    iVar6 = unnamed_function_1417
		                      (
		                      UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs__TypeInfo
		                      );
		    UI_Windows_DialogWindow_DialogWindowArgs___ctor
		              (iVar6,
		               Method_UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs___ctor__
		              );
		    uVar3 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_3631,1,0,1,0,0,0,0);
		    *(undefined4 *)(iVar6 + 8) = uVar3;
		    iVar7 = unnamed_function_1417
		                      (
		                      UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_DialogWindow_DialogWindowArgs__TypeInfo
		                      );
		    uVar3 = unnamed_function_1417
		                      (
		                      UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_ButtonCallbackDelegate_DialogWindow_DialogWindowArgs__TypeInfo
		                      );
		    UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_object____ctor
		              (uVar3,iVar1,
		               Method_Core_Gameplay_Managers_ClanWarsManager___c__DisplayClass30_0__ShowDeclareWarDialogWindow_b__0__
		               ,0);
		    *(undefined4 *)(iVar7 + 8) = uVar3;
		    *(undefined4 *)(iVar6 + 0xc) = 2;
		    *(int *)(iVar6 + 0x14) = iVar7;
		    iVar1 = 
		    Method_System_Collections_Generic_List_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs___Add__
		    ;
		    *(int *)(param1_01 + 0x10) = *(int *)(param1_01 + 0x10) + 1;
		    uVar9 = *(uint *)(param1_01 + 0xc);
		    if (uVar9 < *(uint *)(*(int *)(param1_01 + 8) + 0xc)) {
		      *(uint *)(param1_01 + 0xc) = uVar9 + 1;
		      *(int *)(*(int *)(param1_01 + 8) + uVar9 * 4 + 0x10) = iVar6;
		    }
		    else {
		      System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		                (param1_01,iVar6,*(undefined4 *)(*(int *)(*(int *)(iVar1 + 0x10) + 0x60) + 0x38));
		    }
		    iVar7 = *(int *)(iVar8 + 0x24);
		    iVar6 = unnamed_function_1417
		                      (
		                      UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs__TypeInfo
		                      );
		    UI_Windows_DialogWindow_DialogWindowArgs___ctor
		              (iVar6,
		               Method_UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs___ctor__
		              );
		    uVar3 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_4107,1,0,1,0,0,0,0);
		    *(undefined4 *)(iVar6 + 8) = uVar3;
		    iVar1 = 
		    Method_System_Collections_Generic_List_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs___Add__
		    ;
		    *(int *)(iVar7 + 0x10) = *(int *)(iVar7 + 0x10) + 1;
		    uVar9 = *(uint *)(iVar7 + 0xc);
		    if (uVar9 < *(uint *)(*(int *)(iVar7 + 8) + 0xc)) {
		      *(uint *)(iVar7 + 0xc) = uVar9 + 1;
		      *(int *)(*(int *)(iVar7 + 8) + uVar9 * 4 + 0x10) = iVar6;
		    }
		    else {
		      System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		                (iVar7,iVar6,*(undefined4 *)(*(int *)(*(int *)(iVar1 + 0x10) + 0x60) + 0x38));
		    }
		    uVar3 = UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_ButtonCallbackDelegate_object____ctor
		                      (iVar8,0);
		  }
		  return uVar3;
		}
		*/

		}

		// Token: 0x0600682E RID: 26670 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600682E")]
		[Address(RVA = "0xB35A", Offset = "0xB35A", VA = "0xB35A")]
		public DialogWindow ShowDeclareWarDialogWindow(ulong clanId, ResourceSet cost, int ratingPoints, string clanName)
		{
		/* --- GHIDRA: ShowDeclareWarDialogWindow ---
		undefined4
		Core_Gameplay_Managers_ClanWarsManager__ShowDeclareWarDialogWindow
		          (int param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  
		  uVar1 = Gameplay_Clans_ClanWars_Model_ClanWarsModel___ctor
		                    (*(undefined4 *)(param1 + 0x10),param2,0);
		  return uVar1;
		}
		*/

		/* --- GHIDRA: ShowDeclareWarDialogWindow ---
		undefined4
		Core_Gameplay_Managers_ClanWarsManager__ShowDeclareWarDialogWindow
		          (int param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  
		  uVar1 = Gameplay_Clans_ClanWars_Model_ClanWarsModel___ctor
		                    (*(undefined4 *)(param1 + 0x10),param2,0);
		  return uVar1;
		}
		*/

			return null;
		}

		// Token: 0x0600682F RID: 26671 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600682F")]
		[Address(RVA = "0xB35B", Offset = "0xB35B", VA = "0xB35B")]
		public DialogWindow ShowDeclareWarDialogWindow(ProtoGetWarsHistoryAns.Types.WarHistoryRecord record)
		{
			return null;
		}

		// Token: 0x06006830 RID: 26672 RVA: 0x000138A8 File Offset: 0x00011AA8
		[Token(Token = "0x6006830")]
		[Address(RVA = "0xB35C", Offset = "0xB35C", VA = "0xB35C", Slot = "11")]
		public bool TryGetActiveWar(out ProtoGetActiveWarInfoAns.Types.ActiveWarInfo activeWar)
		{
		/* --- GHIDRA: TryGetActiveWar ---
		void Core_Gameplay_Managers_ClanWarsManager__TryGetActiveWar(int param1,undefined4 param2)
		
		{
		  Gameplay_Clans_ClanWars_Controller_ClanWarsController__SeasonStartedEventHandler
		            (*(undefined4 *)(param1 + 0x18),0);
		  return;
		}
		*/

			return default(bool);
		}

		// Token: 0x06006831 RID: 26673 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006831")]
		[Address(RVA = "0xB35D", Offset = "0xB35D", VA = "0xB35D", Slot = "12")]
		public void RequestUpdateActiveWar()
		{
		}

		// Token: 0x06006832 RID: 26674 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006832")]
		[Address(RVA = "0xB35E", Offset = "0xB35E", VA = "0xB35E")]
		public ClanWarsManager()
		{
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_Name ---
		void Core_Gameplay_Managers_ClanWarsManager__get_Name
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a5a9ce == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IBaseManager__TypeInfo);
		    DAT_ram_00a5a9ce = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 8);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,param2,0);
		    param2_00 = System_Action_IBaseManager__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_IBaseManager__TypeInfo), iVar2 == 0)) break;
		    iVar2 = func_ii_4329(param1 + 8,iVar2,param1_00);
		    bVar1 = iVar2 == param1_00;
		    param1_00 = iVar2;
		    if (bVar1) {
		      return;
		    }
		  }
		  System_Activator__CreateInstance(param1_01,param2_00);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/


		/* --- GHIDRA: add_InitCompleteEvent ---
		void Core_Gameplay_Managers_ClanWarsManager__add_InitCompleteEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a5a9cf == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IBaseManager__TypeInfo);
		    DAT_ram_00a5a9cf = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 8);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_Action_IBaseManager__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_IBaseManager__TypeInfo), iVar2 == 0)) break;
		    iVar2 = func_ii_4329(param1 + 8,iVar2,param1_00);
		    bVar1 = iVar2 == param1_00;
		    param1_00 = iVar2;
		    if (bVar1) {
		      return;
		    }
		  }
		  System_Activator__CreateInstance(param1_01,param2_00);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/


		/* --- GHIDRA: remove_InitCompleteEvent ---
		void Core_Gameplay_Managers_ClanWarsManager__remove_InitCompleteEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a5a9d0 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IBaseManager__TypeInfo);
		    DAT_ram_00a5a9d0 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0xc);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,param2,0);
		    param2_00 = System_Action_IBaseManager__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_IBaseManager__TypeInfo), iVar2 == 0)) break;
		    iVar2 = func_ii_4329(param1 + 0xc,iVar2,param1_00);
		    bVar1 = iVar2 == param1_00;
		    param1_00 = iVar2;
		    if (bVar1) {
		      return;
		    }
		  }
		  System_Activator__CreateInstance(param1_01,param2_00);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/


		/* --- GHIDRA: add_DeinitCompleteEvent ---
		void Core_Gameplay_Managers_ClanWarsManager__add_DeinitCompleteEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a5a9d1 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IBaseManager__TypeInfo);
		    DAT_ram_00a5a9d1 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0xc);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_Action_IBaseManager__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_IBaseManager__TypeInfo), iVar2 == 0)) break;
		    iVar2 = func_ii_4329(param1 + 0xc,iVar2,param1_00);
		    bVar1 = iVar2 == param1_00;
		    param1_00 = iVar2;
		    if (bVar1) {
		      return;
		    }
		  }
		  System_Activator__CreateInstance(param1_01,param2_00);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/


		/* --- GHIDRA: set_Controller ---
		undefined4 Core_Gameplay_Managers_ClanWarsManager__set_Controller(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a5a9d2 == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_28325);
		    DAT_ram_00a5a9d2 = '\x01';
		  }
		  uVar1 = Gameplay_Clans_Combat_Control_ClanCombatViewMediator___HandleGameOver_b__6_0
		                    (*(undefined4 *)(param1 + 0x10),0);
		  uVar1 = Core_Extensions_Dict_DictExt__GetLongParameter(uVar1,StringLiteral_28325,0);
		  return uVar1;
		}
		*/


		/* --- GHIDRA: get_WarsDisabled ---
		undefined4 Core_Gameplay_Managers_ClanWarsManager__get_WarsDisabled(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  
		  uVar1 = Gameplay_Clans_ClanWars_Model_ClanWarsModel__set_CurrentSeasonId
		                    (*(undefined4 *)(param1 + 0x10),0);
		  return uVar1;
		}
		*/

}
