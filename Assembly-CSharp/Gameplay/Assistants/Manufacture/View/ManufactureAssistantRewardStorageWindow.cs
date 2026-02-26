using System;
using System.Runtime.CompilerServices;
using Gameplay.Assistants.Manufacture.Control;
using Gameplay.SmallGames.View;
using Il2CppDummyDll;
using UI.Tabs;
using UI.Windows;
using UnityEngine;
using UnityEngine.UI;

namespace Gameplay.Assistants.Manufacture.View
{
	// Token: 0x02000CAB RID: 3243
	[Token(Token = "0x2000CAB")]
	public class ManufactureAssistantRewardStorageWindow : ClosableBaseWindow<ManufactureAssistantRewardStorageWindow.ManufactureAssistantRewardStorageWindowArgs>
	{
		// Token: 0x17000FFE RID: 4094
		// (get) Token: 0x06004EE4 RID: 20196 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000FFE")]
		public override string WindowId
		{
			[Token(Token = "0x6004EE4")]
			[Address(RVA = "0x9D0C", Offset = "0x9D0C", VA = "0x9D0C", Slot = "14")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000FFF RID: 4095
		// (get) Token: 0x06004EE5 RID: 20197 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000FFF")]
		public Button TakeAllDropButton
		{
			[Token(Token = "0x6004EE5")]
			[Address(RVA = "0x9D0D", Offset = "0x9D0D", VA = "0x9D0D")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001000 RID: 4096
		// (get) Token: 0x06004EE6 RID: 20198 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17001000")]
		public Button SellAllDropButton
		{
			[Token(Token = "0x6004EE6")]
			[Address(RVA = "0x9D0E", Offset = "0x9D0E", VA = "0x9D0E")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001001 RID: 4097
		// (get) Token: 0x06004EE7 RID: 20199 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17001001")]
		public Button InChestButton
		{
			[Token(Token = "0x6004EE7")]
			[Address(RVA = "0x9D0F", Offset = "0x9D0F", VA = "0x9D0F")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001002 RID: 4098
		// (get) Token: 0x06004EE8 RID: 20200 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17001002")]
		public Toggle SortToggle
		{
			[Token(Token = "0x6004EE8")]
			[Address(RVA = "0x9D10", Offset = "0x9D10", VA = "0x9D10")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001003 RID: 4099
		// (get) Token: 0x06004EE9 RID: 20201 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17001003")]
		public RewardStorageOSAView ScrollView
		{
			[Token(Token = "0x6004EE9")]
			[Address(RVA = "0x9D11", Offset = "0x9D11", VA = "0x9D11")]
			get
			{
				return null;
			}
		}

		// Token: 0x06004EEA RID: 20202 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004EEA")]
		[Address(RVA = "0x9D12", Offset = "0x9D12", VA = "0x9D12", Slot = "22")]
		protected override void OnShow(ManufactureAssistantRewardStorageWindow.ManufactureAssistantRewardStorageWindowArgs args)
		{
		/* --- GHIDRA: OnShow ---
		void Gameplay_Assistants_Manufacture_View_ManufactureAssistantRewardStorageWindow__OnShow
		               (int param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  if (DAT_ram_00a5897d == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_ClosableBaseWindow_ManufactureAssistantRewardStorageWindow_ManufactureAssistantRewardStorageWindowArgs__OnClose__
		              );
		    DAT_ram_00a5897d = '\x01';
		  }
		  UI_Windows_ClosableBaseWindow_object___OnClickBack
		            (param1,
		             Method_UI_Windows_ClosableBaseWindow_ManufactureAssistantRewardStorageWindow_ManufactureAssistantRewardStorageWindowArgs__OnClose__
		            );
		  iVar1 = **(int **)(param1 + 0x54);
		  (**(code **)((ulonglong)*(uint *)(iVar1 + 0x130) * 4))
		            (*(int **)(param1 + 0x54),*(undefined4 *)(iVar1 + 0x134));
		  *(undefined4 *)(param1 + 0x54) = 0;
		  return;
		}
		*/

		}

		// Token: 0x06004EEB RID: 20203 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004EEB")]
		[Address(RVA = "0x9D13", Offset = "0x9D13", VA = "0x9D13", Slot = "19")]
		protected override void OnClose()
		{
		/* --- GHIDRA: OnClose ---
		void Gameplay_Assistants_Manufacture_View_ManufactureAssistantRewardStorageWindow__OnClose
		               (int param1,undefined4 param2)
		
		{
		  int param1_00;
		  undefined4 uVar1;
		  int *param2_00;
		  int iVar2;
		  
		  if (DAT_ram_00a5897e == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item(&UI_Tabs_TabBarItemData___TypeInfo);
		    Mono_Security_ASN1__get_Item(&UI_Tabs_TabBarItemData_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_2698);
		    DAT_ram_00a5897e = '\x01';
		  }
		  param1_00 = unnamed_function_1417(UI_Tabs_TabBarItemData_TypeInfo);
		  if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_GameLocalization_TypeInfo);
		  }
		  uVar1 = func_ii_7508(StringLiteral_2698,1,0,1,0,0,0,0);
		  *(undefined4 *)(param1_00 + 0x10) = uVar1;
		  uVar1 = *(undefined4 *)(param1 + 0x3c);
		  param2_00 = (int *)Mono_Security_ASN1Convert__ToOid(UI_Tabs_TabBarItemData___TypeInfo,1);
		  iVar2 = func_ii_1082(param1_00,*(undefined4 *)(*param2_00 + 0x20));
		  if (iVar2 == 0) {
		    uVar1 = func_ii_1083();
		    func_ii_1050(uVar1,0);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  param2_00[4] = param1_00;
		  UI_Tabs_TabBar__HandleSelected(uVar1,param2_00,0);
		  Gameplay_GameEvents_Model_GameEventData__get_ContainsArtifactRewards
		            (*(undefined4 *)(param1 + 0x3c),0,0,0);
		  return;
		}
		*/

		}

		// Token: 0x06004EEC RID: 20204 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004EEC")]
		[Address(RVA = "0x9D14", Offset = "0x9D14", VA = "0x9D14", Slot = "30")]
		protected virtual void CreateTabs()
		{
		/* --- GHIDRA: CreateTabs ---
		void Gameplay_Assistants_Manufacture_View_ManufactureAssistantRewardStorageWindow__CreateTabs
		               (int param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 param2_00;
		  undefined4 param3;
		  int *param1_00;
		  undefined4 param4;
		  int iVar2;
		  
		  if (DAT_ram_00a5897f == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_BaseWindow_ManufactureAssistantRewardStorageWindow_ManufactureAssistantRewardStorageWindowArgs__get_WindowArgs__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Gameplay_Assistants_Manufacture_Control_ManufactureAssistRewardsStorageViewMediator_TypeInfo
		              );
		    DAT_ram_00a5897f = '\x01';
		  }
		  iVar1 = func_ii_8093(param1,
		                       Method_UI_Windows_BaseWindow_ManufactureAssistantRewardStorageWindow_ManufactureAssistantRewardStorageWindowArgs__get_WindowArgs__
		                      );
		  iVar2 = **(int **)(iVar1 + 0x18);
		  param2_00 = (**(code **)((ulonglong)*(uint *)(iVar2 + 0x100) * 4))
		                        (*(int **)(iVar1 + 0x18),*(undefined4 *)(iVar2 + 0x104));
		  iVar1 = func_ii_8093(param1,
		                       Method_UI_Windows_BaseWindow_ManufactureAssistantRewardStorageWindow_ManufactureAssistantRewardStorageWindowArgs__get_WindowArgs__
		                      );
		  iVar2 = **(int **)(iVar1 + 0x18);
		  param3 = (**(code **)((ulonglong)*(uint *)(iVar2 + 0x110) * 4))
		                     (*(int **)(iVar1 + 0x18),*(undefined4 *)(iVar2 + 0x114));
		  iVar1 = func_ii_8093(param1,
		                       Method_UI_Windows_BaseWindow_ManufactureAssistantRewardStorageWindow_ManufactureAssistantRewardStorageWindowArgs__get_WindowArgs__
		                      );
		  param4 = *(undefined4 *)(iVar1 + 0x18);
		  param1_00 = (int *)unnamed_function_1417
		                               (
		                               Gameplay_Assistants_Manufacture_Control_ManufactureAssistRewardsStorageViewMediator_TypeInfo
		                               );
		  if (DAT_ram_00a5899c == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_ManufactureAssistModel__ManufactureAssistantEvents__ManufactureAssistController__ManufactureAssistantRewardStorageWindow___ctor__
		              );
		    DAT_ram_00a5899c = '\x01';
		  }
		  Gameplay_Combat_TeamCombat_View_AbstractTeamCombatView_object___get_HideInstantElements
		            (param1_00,param2_00,param3,param4,
		             Method_MVC_AbstractViewMediator_ManufactureAssistModel__ManufactureAssistantEvents__ManufactureAssistController__ManufactureAssistantRewardStorageWindow___ctor__
		            );
		  *(int **)(param1 + 0x54) = param1_00;
		  (**(code **)((ulonglong)*(uint *)(*param1_00 + 0x160) * 4))
		            (param1_00,param1,*(undefined4 *)(*param1_00 + 0x164));
		  return;
		}
		*/

		}

		// Token: 0x06004EED RID: 20205 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004EED")]
		[Address(RVA = "0x9D15", Offset = "0x9D15", VA = "0x9D15", Slot = "31")]
		protected virtual void CreateViewMediator()
		{
		/* --- GHIDRA: CreateViewMediator ---
		void Gameplay_Assistants_Manufacture_View_ManufactureAssistantRewardStorageWindow__CreateViewMediator
		               (undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a58980 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_ClosableBaseWindow_ManufactureAssistantRewardStorageWindow_ManufactureAssistantRewardStorageWindowArgs___ctor__
		              );
		    DAT_ram_00a58980 = '\x01';
		  }
		  UI_MonoBehaviourWithStates_ClientStateChangedDelegate___Il2CppFullySharedGenericStructType___Invoke
		            (param1,
		             Method_UI_Windows_ClosableBaseWindow_ManufactureAssistantRewardStorageWindow_ManufactureAssistantRewardStorageWindowArgs___ctor__
		            );
		  return;
		}
		*/

		}

		// Token: 0x06004EEE RID: 20206 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004EEE")]
		[Address(RVA = "0x9D16", Offset = "0x9D16", VA = "0x9D16")]
		public ManufactureAssistantRewardStorageWindow()
		{
		}

		// Token: 0x04002B07 RID: 11015
		[Token(Token = "0x4002B07")]
		public const string WINDOW_ID = "Prefabs/UI/Windows/Assistants/Manufacture/ManufactureAssistantRewardStorageWindow";

		// Token: 0x04002B08 RID: 11016
		[Token(Token = "0x4002B08")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private TabBar _tabBar;

		// Token: 0x04002B09 RID: 11017
		[Token(Token = "0x4002B09")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private RewardStorageOSAView _scrollView;

		// Token: 0x04002B0A RID: 11018
		[Token(Token = "0x4002B0A")]
		[FieldOffset(Offset = "0x44")]
		[SerializeField]
		private Button _takeAllDropButton;

		// Token: 0x04002B0B RID: 11019
		[Token(Token = "0x4002B0B")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Button _sellAllDropButton;

		// Token: 0x04002B0C RID: 11020
		[Token(Token = "0x4002B0C")]
		[FieldOffset(Offset = "0x4C")]
		[SerializeField]
		private Button _inChestButton;

		// Token: 0x04002B0D RID: 11021
		[Token(Token = "0x4002B0D")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Toggle _sortToggle;

		// Token: 0x04002B0E RID: 11022
		[Token(Token = "0x4002B0E")]
		[FieldOffset(Offset = "0x54")]
		private ManufactureAssistRewardsStorageViewMediator _mediator;

		// Token: 0x02000CAC RID: 3244
		[Token(Token = "0x2000CAC")]
		public class ManufactureAssistantRewardStorageWindowArgs : BaseWindowArgs
		{
			// Token: 0x17001004 RID: 4100
			// (get) Token: 0x06004EEF RID: 20207 RVA: 0x00002052 File Offset: 0x00000252
			// (set) Token: 0x06004EF0 RID: 20208 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17001004")]
			public ManufactureAssistController Contoroller
			{
				[Token(Token = "0x6004EEF")]
				[Address(RVA = "0x9D17", Offset = "0x9D17", VA = "0x9D17")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x6004EF0")]
				[Address(RVA = "0x9D18", Offset = "0x9D18", VA = "0x9D18")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x06004EF1 RID: 20209 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6004EF1")]
			[Address(RVA = "0x9D19", Offset = "0x9D19", VA = "0x9D19")]
			public ManufactureAssistantRewardStorageWindowArgs()
			{
			}
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_ScrollView ---
		void Gameplay_Assistants_Manufacture_View_ManufactureAssistantRewardStorageWindow__get_ScrollView
		               (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  if (DAT_ram_00a5897c == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_ClosableBaseWindow_ManufactureAssistantRewardStorageWindow_ManufactureAssistantRewardStorageWindowArgs__OnShow__
		              );
		    DAT_ram_00a5897c = '\x01';
		  }
		  func_ii_7769(param1,param2,
		               Method_UI_Windows_ClosableBaseWindow_ManufactureAssistantRewardStorageWindow_ManufactureAssistantRewardStorageWindowArgs__OnShow__
		              );
		  (**(code **)((ulonglong)*(uint *)(*param1 + 0x1b0) * 4))(param1,*(undefined4 *)(*param1 + 0x1b4));
		  (**(code **)((ulonglong)*(uint *)(*param1 + 0x1b8) * 4))(param1,*(undefined4 *)(*param1 + 0x1bc));
		  return;
		}
		*/

}
