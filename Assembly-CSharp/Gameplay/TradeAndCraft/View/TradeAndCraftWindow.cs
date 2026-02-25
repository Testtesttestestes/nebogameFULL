using System;
using Gameplay.TradeAndCraft.Controller;
using Gameplay.TradeAndCraft.Events;
using Gameplay.TradeAndCraft.Model;
using Il2CppDummyDll;
using UI.Windows;
using UI.Windows.Buildings;
using UnityEngine;
using UnityEngine.UI;

namespace Gameplay.TradeAndCraft.View
{
	// Token: 0x02000498 RID: 1176
	[Token(Token = "0x2000498")]
	public class TradeAndCraftWindow : ClosableBaseWindow<TradeAndCraftWindow.TradeAndCraftWindowArgs>
	{
		// Token: 0x170004DD RID: 1245
		// (get) Token: 0x06001BCF RID: 7119 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170004DD")]
		public override string WindowId
		{
			[Token(Token = "0x6001BCF")]
			[Address(RVA = "0x6D4E", Offset = "0x6D4E", VA = "0x6D4E", Slot = "14")]
			get
			{
				return null;
			}
		}

		// Token: 0x170004DE RID: 1246
		// (get) Token: 0x06001BD0 RID: 7120 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170004DE")]
		public Button AuchanButton
		{
			[Token(Token = "0x6001BD0")]
			[Address(RVA = "0x6D4F", Offset = "0x6D4F", VA = "0x6D4F")]
			get
			{
				return null;
			}
		}

		// Token: 0x170004DF RID: 1247
		// (get) Token: 0x06001BD1 RID: 7121 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170004DF")]
		public Button CraftButton
		{
			[Token(Token = "0x6001BD1")]
			[Address(RVA = "0x6D50", Offset = "0x6D50", VA = "0x6D50")]
			get
			{
				return null;
			}
		}

		// Token: 0x170004E0 RID: 1248
		// (get) Token: 0x06001BD2 RID: 7122 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170004E0")]
		public Button ManufactureButton
		{
			[Token(Token = "0x6001BD2")]
			[Address(RVA = "0x6D51", Offset = "0x6D51", VA = "0x6D51")]
			get
			{
				return null;
			}
		}

		// Token: 0x170004E1 RID: 1249
		// (get) Token: 0x06001BD3 RID: 7123 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170004E1")]
		public Button AccountsButton
		{
			[Token(Token = "0x6001BD3")]
			[Address(RVA = "0x6D52", Offset = "0x6D52", VA = "0x6D52")]
			get
			{
				return null;
			}
		}

		// Token: 0x170004E2 RID: 1250
		// (get) Token: 0x06001BD4 RID: 7124 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170004E2")]
		public Button MarketButton
		{
			[Token(Token = "0x6001BD4")]
			[Address(RVA = "0x6D53", Offset = "0x6D53", VA = "0x6D53")]
			get
			{
				return null;
			}
		}

		// Token: 0x170004E3 RID: 1251
		// (get) Token: 0x06001BD5 RID: 7125 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170004E3")]
		public BaseBuildingItemView MyShop
		{
			[Token(Token = "0x6001BD5")]
			[Address(RVA = "0x6D54", Offset = "0x6D54", VA = "0x6D54")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001BD6 RID: 7126 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001BD6")]
		[Address(RVA = "0x6D55", Offset = "0x6D55", VA = "0x6D55")]
		private void OnDestroy()
		{
		}

		// Token: 0x06001BD7 RID: 7127 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001BD7")]
		[Address(RVA = "0x6D56", Offset = "0x6D56", VA = "0x6D56", Slot = "22")]
		protected override void OnShow(TradeAndCraftWindow.TradeAndCraftWindowArgs args)
		{
		}

		// Token: 0x06001BD8 RID: 7128 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001BD8")]
		[Address(RVA = "0x6D57", Offset = "0x6D57", VA = "0x6D57")]
		private void SetupMVC()
		{
		}

		// Token: 0x06001BD9 RID: 7129 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001BD9")]
		[Address(RVA = "0x6D58", Offset = "0x6D58", VA = "0x6D58")]
		private void DestroyMVC()
		{
		}

		// Token: 0x06001BDA RID: 7130 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001BDA")]
		[Address(RVA = "0x6D59", Offset = "0x6D59", VA = "0x6D59")]
		public TradeAndCraftWindow()
		{
		}

		// Token: 0x04000F05 RID: 3845
		[Token(Token = "0x4000F05")]
		public const string WINDOW_ID = "Prefabs/UI/Windows/TradeAndCraft/TradeAndCraftWindow";

		// Token: 0x04000F06 RID: 3846
		[Token(Token = "0x4000F06")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private Button _auchanButton;

		// Token: 0x04000F07 RID: 3847
		[Token(Token = "0x4000F07")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Button _craftButton;

		// Token: 0x04000F08 RID: 3848
		[Token(Token = "0x4000F08")]
		[FieldOffset(Offset = "0x44")]
		[SerializeField]
		private Button _manufactureButton;

		// Token: 0x04000F09 RID: 3849
		[Token(Token = "0x4000F09")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Button _accountsButton;

		// Token: 0x04000F0A RID: 3850
		[Token(Token = "0x4000F0A")]
		[FieldOffset(Offset = "0x4C")]
		[SerializeField]
		private Button _marketButton;

		// Token: 0x04000F0B RID: 3851
		[Token(Token = "0x4000F0B")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private BaseBuildingItemView _myShop;

		// Token: 0x04000F0C RID: 3852
		[Token(Token = "0x4000F0C")]
		[FieldOffset(Offset = "0x54")]
		private TradeAndCraftModel _model;

		// Token: 0x04000F0D RID: 3853
		[Token(Token = "0x4000F0D")]
		[FieldOffset(Offset = "0x58")]
		private TradeAndCraftEvents _events;

		// Token: 0x04000F0E RID: 3854
		[Token(Token = "0x4000F0E")]
		[FieldOffset(Offset = "0x5C")]
		private TradeAndCraftController _controller;

		// Token: 0x04000F0F RID: 3855
		[Token(Token = "0x4000F0F")]
		[FieldOffset(Offset = "0x60")]
		private TradeAndCraftViewMediator _mediator;

		// Token: 0x04000F10 RID: 3856
		[Token(Token = "0x4000F10")]
		[FieldOffset(Offset = "0x64")]
		private bool _mvcSetUp;

		// Token: 0x02000499 RID: 1177
		[Token(Token = "0x2000499")]
		public class TradeAndCraftWindowArgs : BaseWindowArgs
		{
			// Token: 0x06001BDB RID: 7131 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001BDB")]
			[Address(RVA = "0x6D5A", Offset = "0x6D5A", VA = "0x6D5A")]
			public TradeAndCraftWindowArgs()
			{
			}
		}
	}
}
