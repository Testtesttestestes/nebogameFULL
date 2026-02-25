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
		}

		// Token: 0x06004EEB RID: 20203 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004EEB")]
		[Address(RVA = "0x9D13", Offset = "0x9D13", VA = "0x9D13", Slot = "19")]
		protected override void OnClose()
		{
		}

		// Token: 0x06004EEC RID: 20204 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004EEC")]
		[Address(RVA = "0x9D14", Offset = "0x9D14", VA = "0x9D14", Slot = "30")]
		protected virtual void CreateTabs()
		{
		}

		// Token: 0x06004EED RID: 20205 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004EED")]
		[Address(RVA = "0x9D15", Offset = "0x9D15", VA = "0x9D15", Slot = "31")]
		protected virtual void CreateViewMediator()
		{
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
}
