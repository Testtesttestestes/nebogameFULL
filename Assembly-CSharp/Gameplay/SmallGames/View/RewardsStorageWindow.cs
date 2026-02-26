using System;
using Gameplay.SmallGames.Controller;
using Il2CppDummyDll;
using TMPro;
using UI.Tabs;
using UI.Windows;
using UnityEngine;
using UnityEngine.UI;

namespace Gameplay.SmallGames.View
{
	// Token: 0x02000519 RID: 1305
	[Token(Token = "0x2000519")]
	public class RewardsStorageWindow : ClosableBaseWindow<RewardsStorageWindow.RewardsStorageWindowArgs>
	{
		// Token: 0x170005A4 RID: 1444
		// (get) Token: 0x06001F0F RID: 7951 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170005A4")]
		public override string WindowId
		{
			[Token(Token = "0x6001F0F")]
			[Address(RVA = "0x7076", Offset = "0x7076", VA = "0x7076", Slot = "14")]
			get
			{
				return null;
			}
		}

		// Token: 0x170005A5 RID: 1445
		// (get) Token: 0x06001F10 RID: 7952 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170005A5")]
		public Button TakeAllDropButton
		{
			[Token(Token = "0x6001F10")]
			[Address(RVA = "0x7077", Offset = "0x7077", VA = "0x7077")]
			get
			{
				return null;
			}
		}

		// Token: 0x170005A6 RID: 1446
		// (get) Token: 0x06001F11 RID: 7953 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170005A6")]
		public Button SellAllDropButton
		{
			[Token(Token = "0x6001F11")]
			[Address(RVA = "0x7078", Offset = "0x7078", VA = "0x7078")]
			get
			{
				return null;
			}
		}

		// Token: 0x170005A7 RID: 1447
		// (get) Token: 0x06001F12 RID: 7954 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170005A7")]
		public Button InChestButton
		{
			[Token(Token = "0x6001F12")]
			[Address(RVA = "0x7079", Offset = "0x7079", VA = "0x7079")]
			get
			{
				return null;
			}
		}

		// Token: 0x170005A8 RID: 1448
		// (get) Token: 0x06001F13 RID: 7955 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170005A8")]
		public Toggle SortToggle
		{
			[Token(Token = "0x6001F13")]
			[Address(RVA = "0x707A", Offset = "0x707A", VA = "0x707A")]
			get
			{
				return null;
			}
		}

		// Token: 0x170005A9 RID: 1449
		// (get) Token: 0x06001F14 RID: 7956 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170005A9")]
		public RewardStorageOSAView ScrollView
		{
			[Token(Token = "0x6001F14")]
			[Address(RVA = "0x707B", Offset = "0x707B", VA = "0x707B")]
			get
			{
				return null;
			}
		}

		// Token: 0x170005AA RID: 1450
		// (get) Token: 0x06001F15 RID: 7957 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170005AA")]
		public TextMeshProUGUI BottomAnnotation
		{
			[Token(Token = "0x6001F15")]
			[Address(RVA = "0x707C", Offset = "0x707C", VA = "0x707C")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001F16 RID: 7958 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F16")]
		[Address(RVA = "0x707D", Offset = "0x707D", VA = "0x707D")]
		public RewardsStorageWindow()
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_SmallGames_View_RewardsStorageWindow___ctor(int param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  int *piVar3;
		  int iVar4;
		  undefined4 param3_00;
		  undefined4 param4;
		  
		  if (DAT_ram_00a58667 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_ClosableBaseWindow_RewardsStorageWindow_RewardsStorageWindowArgs__OnShow__
		              );
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_SmallGames_Controller_SmallGamesRewardsStorageViewMediator_TypeInfo);
		    Mono_Security_ASN1__get_Item(&UI_Tabs_TabBarItemData___TypeInfo);
		    Mono_Security_ASN1__get_Item(&UI_Tabs_TabBarItemData_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_13848);
		    DAT_ram_00a58667 = '\x01';
		  }
		  func_ii_7769(param1,param2,
		               Method_UI_Windows_ClosableBaseWindow_RewardsStorageWindow_RewardsStorageWindowArgs__OnShow__
		              );
		  iVar1 = unnamed_function_1417(UI_Tabs_TabBarItemData_TypeInfo);
		  if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_GameLocalization_TypeInfo);
		  }
		  uVar2 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_13848,1,0,1,0,0,0,0);
		  *(undefined4 *)(iVar1 + 0x10) = uVar2;
		  uVar2 = *(undefined4 *)(param1 + 0x3c);
		  piVar3 = (int *)Mono_Security_ASN1Convert__ToOid(UI_Tabs_TabBarItemData___TypeInfo,1);
		  iVar4 = func_ii_1082(iVar1,*(undefined4 *)(*piVar3 + 0x20));
		  if (iVar4 == 0) {
		    uVar2 = func_ii_1083();
		    func_ii_1050(uVar2,0);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  piVar3[4] = iVar1;
		  UI_Tabs_TabBar__HandleSelected(uVar2,piVar3,0);
		  Gameplay_GameEvents_Model_GameEventData__get_ContainsArtifactRewards
		            (*(undefined4 *)(param1 + 0x3c),0,0,0);
		  iVar1 = **(int **)(param2 + 0x18);
		  uVar2 = (**(code **)((ulonglong)*(uint *)(iVar1 + 0x100) * 4))
		                    (*(int **)(param2 + 0x18),*(undefined4 *)(iVar1 + 0x104));
		  iVar1 = **(int **)(param2 + 0x18);
		  param3_00 = (**(code **)((ulonglong)*(uint *)(iVar1 + 0x110) * 4))
		                        (*(int **)(param2 + 0x18),*(undefined4 *)(iVar1 + 0x114));
		  param4 = *(undefined4 *)(param2 + 0x18);
		  piVar3 = (int *)unnamed_function_1417
		                            (
		                            Gameplay_SmallGames_Controller_SmallGamesRewardsStorageViewMediator_TypeInfo
		                            );
		  Gameplay_SmallGames_Controller_SmallGamesEnterPointViewMediator__NextFreeSpinRoutine_d__9__System_Collections_IEnumerator_get_Current
		            (piVar3,uVar2,param3_00,param4,0);
		  (**(code **)((ulonglong)*(uint *)(*piVar3 + 0x160) * 4))
		            (piVar3,param1,*(undefined4 *)(*piVar3 + 0x164));
		  *(int **)(param1 + 0x58) = piVar3;
		  return;
		}
		*/

		}

		// Token: 0x06001F17 RID: 7959 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F17")]
		[Address(RVA = "0x707E", Offset = "0x707E", VA = "0x707E", Slot = "22")]
		protected override void OnShow(RewardsStorageWindow.RewardsStorageWindowArgs args)
		{
		/* --- GHIDRA: OnShow ---
		void Gameplay_SmallGames_View_RewardsStorageWindow__OnShow(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  if (DAT_ram_00a58668 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_ClosableBaseWindow_RewardsStorageWindow_RewardsStorageWindowArgs__OnClose__
		              );
		    DAT_ram_00a58668 = '\x01';
		  }
		  UI_Windows_ClosableBaseWindow_object___OnClickBack
		            (param1,
		             Method_UI_Windows_ClosableBaseWindow_RewardsStorageWindow_RewardsStorageWindowArgs__OnClose__
		            );
		  iVar1 = **(int **)(param1 + 0x58);
		  (**(code **)((ulonglong)*(uint *)(iVar1 + 0x130) * 4))
		            (*(int **)(param1 + 0x58),*(undefined4 *)(iVar1 + 0x134));
		  *(undefined4 *)(param1 + 0x58) = 0;
		  return;
		}
		*/

		}

		// Token: 0x06001F18 RID: 7960 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F18")]
		[Address(RVA = "0x707F", Offset = "0x707F", VA = "0x707F", Slot = "19")]
		protected override void OnClose()
		{
		}

		// Token: 0x040010D1 RID: 4305
		[Token(Token = "0x40010D1")]
		public const string WINDOW_ID = "Prefabs/UI/Windows/SmallGames/RewardsStorageWindow";

		// Token: 0x040010D2 RID: 4306
		[Token(Token = "0x40010D2")]
		private const string LOCALIZATION_STORAGE_BOX = "SMALL_GAMES/STORAGE_BOX";

		// Token: 0x040010D3 RID: 4307
		[Token(Token = "0x40010D3")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private TabBar _tabBar;

		// Token: 0x040010D4 RID: 4308
		[Token(Token = "0x40010D4")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private RewardStorageOSAView _scrollView;

		// Token: 0x040010D5 RID: 4309
		[Token(Token = "0x40010D5")]
		[FieldOffset(Offset = "0x44")]
		[SerializeField]
		private Button _takeAllDropButton;

		// Token: 0x040010D6 RID: 4310
		[Token(Token = "0x40010D6")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Button _sellAllDropButton;

		// Token: 0x040010D7 RID: 4311
		[Token(Token = "0x40010D7")]
		[FieldOffset(Offset = "0x4C")]
		[SerializeField]
		private Button _inChestButton;

		// Token: 0x040010D8 RID: 4312
		[Token(Token = "0x40010D8")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Toggle _sortToggle;

		// Token: 0x040010D9 RID: 4313
		[Token(Token = "0x40010D9")]
		[FieldOffset(Offset = "0x54")]
		[SerializeField]
		private TextMeshProUGUI _bottomAnnotation;

		// Token: 0x040010DA RID: 4314
		[Token(Token = "0x40010DA")]
		[FieldOffset(Offset = "0x58")]
		private SmallGamesRewardsStorageViewMediator _mediator;

		// Token: 0x0200051A RID: 1306
		[Token(Token = "0x200051A")]
		public class RewardsStorageWindowArgs : BaseWindowArgs
		{
			// Token: 0x06001F19 RID: 7961 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001F19")]
			[Address(RVA = "0x7080", Offset = "0x7080", VA = "0x7080")]
			public RewardsStorageWindowArgs()
			{
			}

			// Token: 0x040010DB RID: 4315
			[Token(Token = "0x40010DB")]
			[FieldOffset(Offset = "0x18")]
			public SmallGamesController Controller;
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_BottomAnnotation ---
		void Gameplay_SmallGames_View_RewardsStorageWindow__get_BottomAnnotation
		               (undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a58666 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_ClosableBaseWindow_RewardsStorageWindow_RewardsStorageWindowArgs___ctor__
		              );
		    DAT_ram_00a58666 = '\x01';
		  }
		  UI_MonoBehaviourWithStates_ClientStateChangedDelegate___Il2CppFullySharedGenericStructType___Invoke
		            (param1,
		             Method_UI_Windows_ClosableBaseWindow_RewardsStorageWindow_RewardsStorageWindowArgs___ctor__
		            );
		  return;
		}
		*/

}
