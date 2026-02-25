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
	// Token: 0x0200049A RID: 1178
	[Token(Token = "0x200049A")]
	public class TradeOptionsWindow : ClosableBaseWindow<TradeOptionsWindow.TradeOptionsWindowArgs>
	{
		// Token: 0x170004E4 RID: 1252
		// (get) Token: 0x06001BDC RID: 7132 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170004E4")]
		public override string WindowId
		{
			[Token(Token = "0x6001BDC")]
			[Address(RVA = "0x6D5B", Offset = "0x6D5B", VA = "0x6D5B", Slot = "14")]
			get
			{
				return null;
			}
		}

		// Token: 0x170004E5 RID: 1253
		// (get) Token: 0x06001BDD RID: 7133 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170004E5")]
		public Button AuchanButton
		{
			[Token(Token = "0x6001BDD")]
			[Address(RVA = "0x6D5C", Offset = "0x6D5C", VA = "0x6D5C")]
			get
			{
				return null;
			}
		}

		// Token: 0x170004E6 RID: 1254
		// (get) Token: 0x06001BDE RID: 7134 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170004E6")]
		public Button AccountsButton
		{
			[Token(Token = "0x6001BDE")]
			[Address(RVA = "0x6D5D", Offset = "0x6D5D", VA = "0x6D5D")]
			get
			{
				return null;
			}
		}

		// Token: 0x170004E7 RID: 1255
		// (get) Token: 0x06001BDF RID: 7135 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170004E7")]
		public Button MarketButton
		{
			[Token(Token = "0x6001BDF")]
			[Address(RVA = "0x6D5E", Offset = "0x6D5E", VA = "0x6D5E")]
			get
			{
				return null;
			}
		}

		// Token: 0x170004E8 RID: 1256
		// (get) Token: 0x06001BE0 RID: 7136 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170004E8")]
		public BaseBuildingItemView MyShop
		{
			[Token(Token = "0x6001BE0")]
			[Address(RVA = "0x6D5F", Offset = "0x6D5F", VA = "0x6D5F")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001BE1 RID: 7137 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001BE1")]
		[Address(RVA = "0x6D60", Offset = "0x6D60", VA = "0x6D60")]
		private void OnDestroy()
		{
		}

		// Token: 0x06001BE2 RID: 7138 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001BE2")]
		[Address(RVA = "0x6D61", Offset = "0x6D61", VA = "0x6D61", Slot = "22")]
		protected override void OnShow(TradeOptionsWindow.TradeOptionsWindowArgs args)
		{
		}

		// Token: 0x06001BE3 RID: 7139 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001BE3")]
		[Address(RVA = "0x6D62", Offset = "0x6D62", VA = "0x6D62")]
		private void SetupMVC()
		{
		}

		// Token: 0x06001BE4 RID: 7140 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001BE4")]
		[Address(RVA = "0x6D63", Offset = "0x6D63", VA = "0x6D63")]
		private void DestroyMVC()
		{
		}

		// Token: 0x06001BE5 RID: 7141 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001BE5")]
		[Address(RVA = "0x6D64", Offset = "0x6D64", VA = "0x6D64")]
		public TradeOptionsWindow()
		{
		}

		// Token: 0x04000F11 RID: 3857
		[Token(Token = "0x4000F11")]
		public const string WINDOW_ID = "Prefabs/UI/Windows/TradeAndCraft/TradeOptionsWindow";

		// Token: 0x04000F12 RID: 3858
		[Token(Token = "0x4000F12")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private Button _auchanButton;

		// Token: 0x04000F13 RID: 3859
		[Token(Token = "0x4000F13")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Button _accountsButton;

		// Token: 0x04000F14 RID: 3860
		[Token(Token = "0x4000F14")]
		[FieldOffset(Offset = "0x44")]
		[SerializeField]
		private Button _marketButton;

		// Token: 0x04000F15 RID: 3861
		[Token(Token = "0x4000F15")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private BaseBuildingItemView _myShop;

		// Token: 0x04000F16 RID: 3862
		[Token(Token = "0x4000F16")]
		[FieldOffset(Offset = "0x4C")]
		private TradeAndCraftModel _model;

		// Token: 0x04000F17 RID: 3863
		[Token(Token = "0x4000F17")]
		[FieldOffset(Offset = "0x50")]
		private TradeAndCraftEvents _events;

		// Token: 0x04000F18 RID: 3864
		[Token(Token = "0x4000F18")]
		[FieldOffset(Offset = "0x54")]
		private TradeAndCraftController _controller;

		// Token: 0x04000F19 RID: 3865
		[Token(Token = "0x4000F19")]
		[FieldOffset(Offset = "0x58")]
		private TradeOptionsViewMediator _mediator;

		// Token: 0x04000F1A RID: 3866
		[Token(Token = "0x4000F1A")]
		[FieldOffset(Offset = "0x5C")]
		private bool _mvcSetUp;

		// Token: 0x0200049B RID: 1179
		[Token(Token = "0x200049B")]
		public class TradeOptionsWindowArgs : BaseWindowArgs
		{
			// Token: 0x06001BE6 RID: 7142 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001BE6")]
			[Address(RVA = "0x6D65", Offset = "0x6D65", VA = "0x6D65")]
			public TradeOptionsWindowArgs()
			{
			}
		}
	}
}
