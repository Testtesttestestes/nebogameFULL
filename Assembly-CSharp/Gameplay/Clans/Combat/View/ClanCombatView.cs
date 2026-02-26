using System;
using Gameplay.Clans.Combat.Model;
using Gameplay.Clans.Combat.View.Players;
using Gameplay.Combat.Model;
using Gameplay.Combat.TeamCombat.View;
using Gameplay.Combat.View;
using Gameplay.Combat.View.Players;
using Gameplay.Combat.View.Spells;
using Il2CppDummyDll;
using UI;
using UnityEngine;
using UnityEngine.UI;

namespace Gameplay.Clans.Combat.View
{
	// Token: 0x02000A94 RID: 2708
	[Token(Token = "0x2000A94")]
	public class ClanCombatView : AbstractTeamCombatView<ClanCombatPlayer>
	{
		// Token: 0x17000CCD RID: 3277
		// (get) Token: 0x060040F6 RID: 16630 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000CCD")]
		public Button ExitFromViewModeButton
		{
			[Token(Token = "0x60040F6")]
			[Address(RVA = "0x8FAD", Offset = "0x8FAD", VA = "0x8FAD")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000CCE RID: 3278
		// (get) Token: 0x060040F7 RID: 16631 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000CCE")]
		public Button StartButton
		{
			[Token(Token = "0x60040F7")]
			[Address(RVA = "0x8FAE", Offset = "0x8FAE", VA = "0x8FAE")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000CCF RID: 3279
		// (get) Token: 0x060040F8 RID: 16632 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000CCF")]
		public BacktimeViewUGUI BacktimeView
		{
			[Token(Token = "0x60040F8")]
			[Address(RVA = "0x8FAF", Offset = "0x8FAF", VA = "0x8FAF")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000CD0 RID: 3280
		// (get) Token: 0x060040F9 RID: 16633 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000CD0")]
		public PlayersList LeftPlayers
		{
			[Token(Token = "0x60040F9")]
			[Address(RVA = "0x8FB0", Offset = "0x8FB0", VA = "0x8FB0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000CD1 RID: 3281
		// (get) Token: 0x060040FA RID: 16634 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000CD1")]
		public PlayersList RightPlayers
		{
			[Token(Token = "0x60040FA")]
			[Address(RVA = "0x8FB1", Offset = "0x8FB1", VA = "0x8FB1")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000CD2 RID: 3282
		// (get) Token: 0x060040FB RID: 16635 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000CD2")]
		public ICombatSpellDisplay ElixirDisplay
		{
			[Token(Token = "0x60040FB")]
			[Address(RVA = "0x8FB2", Offset = "0x8FB2", VA = "0x8FB2")]
			get
			{
				return null;
			}
		}

		// Token: 0x060040FC RID: 16636 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60040FC")]
		[Address(RVA = "0x8FB3", Offset = "0x8FB3", VA = "0x8FB3", Slot = "5")]
		protected override void OnDestroy()
		{
		/* --- GHIDRA: OnDestroy ---
		void Gameplay_Clans_Combat_View_ClanCombatView__OnDestroy(int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  int iVar1;
		  
		  if (DAT_ram_00a5776d == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Clans_Combat_View_ClanCombatView_FormatBacktimeCallback__);
		    Mono_Security_ASN1__get_Item(&UI_AbstractBacktimeView_FormatCallback_TypeInfo);
		    DAT_ram_00a5776d = '\x01';
		  }
		  iVar1 = *(int *)(param1 + 100);
		  param1_00 = unnamed_function_1417(UI_AbstractBacktimeView_FormatCallback_TypeInfo);
		  UI_AbstractBacktimeView___ctor
		            (param1_00,param1,
		             Method_Gameplay_Clans_Combat_View_ClanCombatView_FormatBacktimeCallback__,0);
		  *(undefined4 *)(iVar1 + 0x14) = param1_00;
		  return;
		}
		*/

		}

		// Token: 0x060040FD RID: 16637 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60040FD")]
		[Address(RVA = "0x8FB4", Offset = "0x8FB4", VA = "0x8FB4")]
		private void Awake()
		{
		/* --- GHIDRA: Awake ---
		void Gameplay_Clans_Combat_View_ClanCombatView__Awake(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  int *piVar2;
		  
		  if (DAT_ram_00a5776e == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Clans_Combat_View_ClanCombatView_HandlePlayerListInitialize__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Com_TheFallenGames_OSA_Core_OSA_BaseParamsWithPrefab__PlayerViewsHolder__get_IsInitialized__
		              );
		    DAT_ram_00a5776e = '\x01';
		  }
		  piVar2 = *(int **)(param1 + 0x4c);
		  if ((char)piVar2[0x14] == '\0') {
		    uVar1 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar1,param1,
		               Method_Gameplay_Clans_Combat_View_ClanCombatView_HandlePlayerListInitialize__,0);
		    (**(code **)((ulonglong)*(uint *)(*piVar2 + 0x298) * 4))
		              (piVar2,uVar1,*(undefined4 *)(*piVar2 + 0x29c));
		  }
		  else {
		    Gameplay_Clans_Combat_View_ClanCombatView__FormatBacktimeCallback(param1,param1);
		  }
		  piVar2 = *(int **)(param1 + 0x50);
		  if ((char)piVar2[0x14] == '\0') {
		    uVar1 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar1,param1,
		               Method_Gameplay_Clans_Combat_View_ClanCombatView_HandlePlayerListInitialize__,0);
		    (**(code **)((ulonglong)*(uint *)(*piVar2 + 0x298) * 4))
		              (piVar2,uVar1,*(undefined4 *)(*piVar2 + 0x29c));
		  }
		  else {
		    Gameplay_Clans_Combat_View_ClanCombatView__FormatBacktimeCallback(param1,param1);
		  }
		  return;
		}
		*/

		}

		// Token: 0x060040FE RID: 16638 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60040FE")]
		[Address(RVA = "0x8FB5", Offset = "0x8FB5", VA = "0x8FB5", Slot = "6")]
		protected override void Start()
		{
		/* --- GHIDRA: Start ---
		undefined4
		Gameplay_Clans_Combat_View_ClanCombatView__Start(int *param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  
		  if (DAT_ram_00a5776f == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_CombatPlayer__InsertOneAtEnd__
		              );
		    DAT_ram_00a5776f = '\x01';
		  }
		  iVar2 = 0x4c;
		  if (*(int *)(*(int *)(param2 + 8) + 0x14) != *(int *)(param2 + 0x54)) {
		    iVar2 = 0x50;
		  }
		  Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_object___InsertOne
		            (*(undefined4 *)(*(int *)((int)param1 + iVar2) + 0xa8),param2,0,
		             Method_Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_CombatPlayer__InsertOneAtEnd__
		            );
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x108) * 4))
		                    (param1,param2,*(undefined4 *)(*param1 + 0x10c));
		  return uVar1;
		}
		*/

		}

		// Token: 0x060040FF RID: 16639 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60040FF")]
		[Address(RVA = "0x8FB6", Offset = "0x8FB6", VA = "0x8FB6", Slot = "13")]
		protected override ICombatPLayerView CreatePlayerView(ClanCombatPlayer player)
		{
		/* --- GHIDRA: CreatePlayerView ---
		undefined4
		Gameplay_Clans_Combat_View_ClanCombatView__CreatePlayerView
		          (int param1,undefined4 param2,int *param3,undefined4 param4)
		
		{
		  undefined4 param4_00;
		  undefined4 param1_00;
		  int *piVar1;
		  int iVar2;
		  
		  if (DAT_ram_00a57770 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_Combat_View_CombatGameOverView_CombatGameOverViewArgs_TypeInfo);
		    DAT_ram_00a57770 = '\x01';
		  }
		  piVar1 = *(int **)(param1 + 0x28);
		  iVar2 = param3[2];
		  param4_00 = (**(code **)((ulonglong)*(uint *)(*param3 + 0x120) * 4))
		                        (param3,*(undefined4 *)(*param3 + 0x124));
		  param1_00 = unnamed_function_1417
		                        (Gameplay_Combat_View_CombatGameOverView_CombatGameOverViewArgs_TypeInfo);
		  UnityEngine_Purchasing_PurchasingManager___c__DisplayClass27_0___OnAllPurchasesRetrieved_b__0
		            (param1_00,iVar2,param2,param4_00,0);
		  iVar2 = *piVar1;
		  (**(code **)((ulonglong)*(uint *)(iVar2 + 0xe8) * 4))
		            (piVar1,param1_00,*(undefined4 *)(iVar2 + 0xec));
		  return *(undefined4 *)(param1 + 0x28);
		}
		*/

			return null;
		}

		// Token: 0x06004100 RID: 16640 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6004100")]
		[Address(RVA = "0x8FB7", Offset = "0x8FB7", VA = "0x8FB7", Slot = "8")]
		protected override CombatGameOverView ShowGameOverView(Gameplay.Combat.Model.GameOverData gameOver, CombatModel model)
		{
		/* --- GHIDRA: ShowGameOverView ---
		undefined4
		Gameplay_Clans_Combat_View_ClanCombatView__ShowGameOverView
		          (undefined4 param1,float param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  longlong param2_00;
		  undefined8 local_20;
		  undefined8 local_18;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a57771 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_DateTimeOffset_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_8655);
		    DAT_ram_00a57771 = '\x01';
		  }
		  if (*(int *)(System_DateTimeOffset_TypeInfo + 0x74) == 0) {
		    func_ii_306000(System_DateTimeOffset_TypeInfo);
		  }
		  if (ABS(param2) < 9.223372e+18) {
		    param2_00 = (longlong)param2;
		  }
		  else {
		    param2_00 = -0x8000000000000000;
		  }
		  System_DateTimeOffset__Equals(&local_20,param2_00,0);
		  local_8 = local_18;
		  local_10 = local_20;
		  uVar1 = System_DateTimeOffset__ToString(&local_10,StringLiteral_8655,0);
		  return uVar1;
		}
		*/

			return null;
		}

		// Token: 0x06004101 RID: 16641 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6004101")]
		[Address(RVA = "0x8FB8", Offset = "0x8FB8", VA = "0x8FB8")]
		private string FormatBacktimeCallback(float value)
		{
		/* --- GHIDRA: FormatBacktimeCallback ---
		void Gameplay_Clans_Combat_View_ClanCombatView__FormatBacktimeCallback(int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  undefined4 uVar2;
		  uint *puVar3;
		  int iVar4;
		  int *piVar5;
		  int iVar6;
		  int local_4;
		  
		  if (DAT_ram_00a57772 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Clans_Combat_View_ClanCombatView_HandlePlayerListInitialize__);
		    Mono_Security_ASN1__get_Item(&Gameplay_Combat_ICombat_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Combat_IManageCombat_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Com_TheFallenGames_OSA_Core_OSA_BaseParamsWithPrefab__PlayerViewsHolder__get_IsInitialized__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_DefaultNamespace_SceneAppManager_TryGetSceneArgs_ICombat___);
		    DAT_ram_00a57772 = '\x01';
		  }
		  local_4 = 0;
		  piVar5 = *(int **)(param1 + 0x4c);
		  if (((char)piVar5[0x14] != '\0') && (*(char *)(*(int *)(param1 + 0x50) + 0x50) != '\0')) {
		    uVar2 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar2,param1,
		               Method_Gameplay_Clans_Combat_View_ClanCombatView_HandlePlayerListInitialize__,0);
		    (**(code **)((ulonglong)*(uint *)(*piVar5 + 0x2a0) * 4))
		              (piVar5,uVar2,*(undefined4 *)(*piVar5 + 0x2a4));
		    piVar5 = *(int **)(param1 + 0x50);
		    uVar2 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar2,param1,
		               Method_Gameplay_Clans_Combat_View_ClanCombatView_HandlePlayerListInitialize__,0);
		    iVar6 = *piVar5;
		    (**(code **)((ulonglong)*(uint *)(iVar6 + 0x2a0) * 4))
		              (piVar5,uVar2,*(undefined4 *)(iVar6 + 0x2a4));
		    uVar2 = UI_Windows_PopupController__get_OpenedWindowsCount(0);
		    iVar6 = DefaultNamespace_SceneAppManager__LoadScene___Il2CppFullySharedGenericType_
		                      (uVar2,0xc,&local_4,
		                       Method_DefaultNamespace_SceneAppManager_TryGetSceneArgs_ICombat___);
		    if (iVar6 != 0) {
		      piVar5 = *(int **)(local_4 + 0xc);
		      iVar6 = *piVar5;
		      if (*(ushort *)(iVar6 + 0xb6) != 0) {
		        uVar1 = 0;
		        do {
		          if (Gameplay_Combat_ICombat_TypeInfo == *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8)) {
		            puVar3 = (uint *)(iVar6 + *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		            goto code_r0x80dd6f3e;
		          }
		          uVar1 = uVar1 + 1;
		        } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		      }
		      puVar3 = (uint *)func_ii_1080(piVar5,Gameplay_Combat_ICombat_TypeInfo,0);
		code_r0x80dd6f3e:
		      iVar4 = (**(code **)((ulonglong)*puVar3 * 4))(piVar5,puVar3[1]);
		      iVar6 = Gameplay_Combat_IManageCombat_TypeInfo;
		      if (iVar4 != 0) {
		        piVar5 = (int *)0x0;
		        iVar4 = *(int *)(local_4 + 0xc);
		        if ((iVar4 != 0) &&
		           (piVar5 = (int *)func_ii_1082(iVar4,Gameplay_Combat_IManageCombat_TypeInfo),
		           piVar5 == (int *)0x0)) {
		          System_Activator__CreateInstance(iVar4,iVar6);
		          do {
		            halt_trap();
		          } while( true );
		        }
		        iVar4 = *piVar5;
		        if (*(ushort *)(iVar4 + 0xb6) != 0) {
		          uVar1 = 0;
		          do {
		            if (iVar6 == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		              puVar3 = (uint *)(iVar4 + *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0)
		              ;
		              goto code_r0x80dd6fe0;
		            }
		            uVar1 = uVar1 + 1;
		          } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		        }
		        puVar3 = (uint *)func_ii_1080(piVar5,iVar6,0);
		code_r0x80dd6fe0:
		        (**(code **)((ulonglong)*puVar3 * 4))(piVar5,param1,puVar3[1]);
		      }
		    }
		  }
		  return;
		}
		*/

			return null;
		}

		// Token: 0x06004102 RID: 16642 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004102")]
		[Address(RVA = "0x8FB9", Offset = "0x8FB9", VA = "0x8FB9")]
		private void HandlePlayerListInitialize()
		{
		/* --- GHIDRA: HandlePlayerListInitialize ---
		undefined4
		Gameplay_Clans_Combat_View_ClanCombatView__HandlePlayerListInitialize
		          (int param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int param1_00;
		  int iVar2;
		  
		  if (DAT_ram_00a57773 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_CombatPlayer__IndexOf__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Com_TheFallenGames_OSA_Core_OSA_BaseParamsWithPrefab__PlayerViewsHolder__GetItemViewsHolderIfVisible__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_CombatPlayer__get_List__)
		    ;
		    DAT_ram_00a57773 = '\x01';
		  }
		  iVar2 = 0x4c;
		  if (*(int *)(*(int *)(param2 + 8) + 0x14) != *(int *)(param2 + 0x54)) {
		    iVar2 = 0x50;
		  }
		  param1_00 = *(int *)(param1 + iVar2);
		  iVar2 = UnityEngine_UIElements_RadioButtonGroup__GetAllRadioButtons
		                    (*(undefined4 *)(*(int *)(param1_00 + 0xa8) + 0xc),param2,
		                     Method_System_Collections_Generic_List_CombatPlayer__IndexOf__);
		  if ((iVar2 != -1) &&
		     (iVar2 = Com_TheFallenGames_OSA_Core_OSA_object__object___GetItemViewsHolder
		                        (param1_00,iVar2,
		                         Method_Com_TheFallenGames_OSA_Core_OSA_BaseParamsWithPrefab__PlayerViewsHolder__GetItemViewsHolderIfVisible__
		                        ), iVar2 != 0)) {
		    return *(undefined4 *)(iVar2 + 0x1c);
		  }
		  uVar1 = Gameplay_Combat_View_AbstractCombatView__GetSpell(param1,param2,0);
		  return uVar1;
		}
		*/

		}

		// Token: 0x06004103 RID: 16643 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6004103")]
		[Address(RVA = "0x8FBA", Offset = "0x8FBA", VA = "0x8FBA", Slot = "9")]
		public override ICombatPLayerView GetPlayer(CombatPlayer player)
		{
		/* --- GHIDRA: GetPlayer ---
		undefined4
		Gameplay_Clans_Combat_View_ClanCombatView__GetPlayer(int param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  
		  uVar1 = Gameplay_Combat_View_AbstractCombatView__AddSpell
		                    (param1,param2,*(undefined4 *)(param1 + 0x48),0);
		  return uVar1;
		}
		*/

			return null;
		}

		// Token: 0x06004104 RID: 16644 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6004104")]
		[Address(RVA = "0x8FBB", Offset = "0x8FBB", VA = "0x8FBB")]
		public CombatSpellButton AddElixir(CombatSpellData spell)
		{
		/* --- GHIDRA: AddElixir ---
		undefined4
		Gameplay_Clans_Combat_View_ClanCombatView__AddElixir(int param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  
		  iVar1 = 0x4c;
		  if (*(int *)(*(int *)(param2 + 8) + 0x14) != *(int *)(param2 + 0x54)) {
		    iVar1 = 0x50;
		  }
		  return *(undefined4 *)(param1 + iVar1);
		}
		*/

			return null;
		}

		// Token: 0x06004105 RID: 16645 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6004105")]
		[Address(RVA = "0x8FBC", Offset = "0x8FBC", VA = "0x8FBC")]
		public PlayersList GetPlayerList(CombatPlayer player)
		{
		/* --- GHIDRA: GetPlayerList ---
		undefined4
		Gameplay_Clans_Combat_View_ClanCombatView__GetPlayerList(int param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  
		  iVar1 = 0x54;
		  if (*(int *)(param2 + 0x54) != *(int *)(*(int *)(param2 + 8) + 0x14)) {
		    iVar1 = 0x58;
		  }
		  return *(undefined4 *)(param1 + iVar1);
		}
		*/

			return null;
		}

		// Token: 0x06004106 RID: 16646 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6004106")]
		[Address(RVA = "0x8FBD", Offset = "0x8FBD", VA = "0x8FBD")]
		public ClanTitle GetClanTitle(CombatPlayer player)
		{
		/* --- GHIDRA: GetClanTitle ---
		undefined4
		Gameplay_Clans_Combat_View_ClanCombatView__GetClanTitle(int param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  
		  iVar1 = 0x5c;
		  if (*(int *)(param2 + 0x54) != *(int *)(*(int *)(param2 + 8) + 0x14)) {
		    iVar1 = 0x60;
		  }
		  return *(undefined4 *)(param1 + iVar1);
		}
		*/

			return null;
		}

		// Token: 0x06004107 RID: 16647 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6004107")]
		[Address(RVA = "0x8FBE", Offset = "0x8FBE", VA = "0x8FBE")]
		public ICombatPLayerView GetPlayerSideInfo(CombatPlayer player)
		{
		/* --- GHIDRA: GetPlayerSideInfo ---
		void Gameplay_Clans_Combat_View_ClanCombatView__GetPlayerSideInfo
		               (int param1,int param2,undefined4 param3)
		
		{
		  undefined4 param2_00;
		  int iVar1;
		  
		  if (DAT_ram_00a57774 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_CombatPlayer__IndexOf__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_CombatPlayer__RemoveOne__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_CombatPlayer__get_List__)
		    ;
		    DAT_ram_00a57774 = '\x01';
		  }
		  iVar1 = 0x4c;
		  if (*(int *)(*(int *)(param2 + 8) + 0x14) != *(int *)(param2 + 0x54)) {
		    iVar1 = 0x50;
		  }
		  iVar1 = *(int *)(param1 + iVar1);
		  param2_00 = UnityEngine_UIElements_RadioButtonGroup__GetAllRadioButtons
		                        (*(undefined4 *)(*(int *)(iVar1 + 0xa8) + 0xc),param2,
		                         Method_System_Collections_Generic_List_CombatPlayer__IndexOf__);
		  Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_object___RemoveItemsFromStart
		            (*(undefined4 *)(iVar1 + 0xa8),param2_00,0,
		             Method_Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_CombatPlayer__RemoveOne__);
		  return;
		}
		*/

			return null;
		}

		// Token: 0x06004108 RID: 16648 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004108")]
		[Address(RVA = "0x8FBF", Offset = "0x8FBF", VA = "0x8FBF", Slot = "14")]
		public override void RemovePlayer(ClanCombatPlayer player)
		{
		/* --- GHIDRA: RemovePlayer ---
		void Gameplay_Clans_Combat_View_ClanCombatView__RemovePlayer(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  Gameplay_Combat_View_AbstractCombatView__RemoveSpellEventHandlers(param1,0);
		  iVar1 = **(int **)(param1 + 0x48);
		  (**(code **)((ulonglong)*(uint *)(iVar1 + 0x120) * 4))
		            (*(int **)(param1 + 0x48),*(undefined4 *)(iVar1 + 0x124));
		  return;
		}
		*/

		}

		// Token: 0x06004109 RID: 16649 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004109")]
		[Address(RVA = "0x8FC0", Offset = "0x8FC0", VA = "0x8FC0", Slot = "7")]
		public override void ResetSpells()
		{
		/* --- GHIDRA: ResetSpells ---
		void Gameplay_Clans_Combat_View_ClanCombatView__ResetSpells(undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a57775 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Combat_TeamCombat_View_AbstractTeamCombatView_ClanCombatPlayer___ctor__
		              );
		    DAT_ram_00a57775 = '\x01';
		  }
		  HuaweiMobileServices_Base_AbstractTask___Il2CppFullySharedGenericType___get_Successful
		            (param1,
		             Method_Gameplay_Combat_TeamCombat_View_AbstractTeamCombatView_ClanCombatPlayer___ctor__
		            );
		  return;
		}
		*/

		}

		// Token: 0x0600410A RID: 16650 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600410A")]
		[Address(RVA = "0x8FC1", Offset = "0x8FC1", VA = "0x8FC1")]
		public ClanCombatView()
		{
		}

		// Token: 0x04002411 RID: 9233
		[Token(Token = "0x4002411")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private AbstractCombatSpellsDisplay _elixirs;

		// Token: 0x04002412 RID: 9234
		[Token(Token = "0x4002412")]
		[FieldOffset(Offset = "0x4C")]
		[SerializeField]
		private PlayersList _leftPlayers;

		// Token: 0x04002413 RID: 9235
		[Token(Token = "0x4002413")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private PlayersList _rightPlayers;

		// Token: 0x04002414 RID: 9236
		[Token(Token = "0x4002414")]
		[FieldOffset(Offset = "0x54")]
		[SerializeField]
		private ClanTitle _leftClanTitle;

		// Token: 0x04002415 RID: 9237
		[Token(Token = "0x4002415")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private ClanTitle _rightClanTitle;

		// Token: 0x04002416 RID: 9238
		[Token(Token = "0x4002416")]
		[FieldOffset(Offset = "0x5C")]
		[SerializeField]
		private ClanCombatPlayerInfo _leftInfo;

		// Token: 0x04002417 RID: 9239
		[Token(Token = "0x4002417")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private ClanCombatPlayerInfo _rightInfo;

		// Token: 0x04002418 RID: 9240
		[Token(Token = "0x4002418")]
		[FieldOffset(Offset = "0x64")]
		[SerializeField]
		private BacktimeViewUGUI _backtimeView;

		// Token: 0x04002419 RID: 9241
		[Token(Token = "0x4002419")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Button _startButton;

		// Token: 0x0400241A RID: 9242
		[Token(Token = "0x400241A")]
		[FieldOffset(Offset = "0x6C")]
		[SerializeField]
		private Button _exitFromViewModeButton;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_ElixirDisplay ---
		void Gameplay_Clans_Combat_View_ClanCombatView__get_ElixirDisplay(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  int *piVar2;
		  int iVar3;
		  
		  if (DAT_ram_00a5776c == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Clans_Combat_View_ClanCombatView_HandlePlayerListInitialize__);
		    DAT_ram_00a5776c = '\x01';
		  }
		  piVar2 = *(int **)(param1 + 0x4c);
		  uVar1 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar1,param1,
		             Method_Gameplay_Clans_Combat_View_ClanCombatView_HandlePlayerListInitialize__,0);
		  iVar3 = *piVar2;
		  (**(code **)((ulonglong)*(uint *)(iVar3 + 0x2a0) * 4))
		            (piVar2,uVar1,*(undefined4 *)(iVar3 + 0x2a4));
		  piVar2 = *(int **)(param1 + 0x50);
		  uVar1 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar1,param1,
		             Method_Gameplay_Clans_Combat_View_ClanCombatView_HandlePlayerListInitialize__,0);
		  iVar3 = *piVar2;
		  (**(code **)((ulonglong)*(uint *)(iVar3 + 0x2a0) * 4))
		            (piVar2,uVar1,*(undefined4 *)(iVar3 + 0x2a4));
		  *(undefined4 *)(*(int *)(param1 + 100) + 0x14) = 0;
		  Gameplay_Combat_View_AbstractCombatView__remove_OnSpellClick(param1,0);
		  return;
		}
		*/

}
