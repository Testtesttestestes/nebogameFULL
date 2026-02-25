using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Core.Data;
using Gameplay.Accounts.View.Banners;
using Gameplay.Isles.User;
using Gameplay.Shop;
using Il2CppDummyDll;
using TMPro;
using UI.Elements;
using UnityEngine;

namespace UI.Windows.Buildings.ShopWindow
{
	// Token: 0x020002B8 RID: 696
	[Token(Token = "0x20002B8")]
	public class ShopWindow : BaseBuildingWindow<ShopWindow.ShopWindowArgs>
	{
		// Token: 0x17000264 RID: 612
		// (get) Token: 0x0600105B RID: 4187 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000264")]
		public override string WindowId
		{
			[Token(Token = "0x600105B")]
			[Address(RVA = "0x6259", Offset = "0x6259", VA = "0x6259", Slot = "14")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000265 RID: 613
		// (get) Token: 0x0600105C RID: 4188 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000265")]
		public List<ShopItem> Items
		{
			[Token(Token = "0x600105C")]
			[Address(RVA = "0x625A", Offset = "0x625A", VA = "0x625A")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x17000266 RID: 614
		// (get) Token: 0x0600105D RID: 4189 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000266")]
		public List<ShopItem> GoldItems
		{
			[Token(Token = "0x600105D")]
			[Address(RVA = "0x625B", Offset = "0x625B", VA = "0x625B")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x14000102 RID: 258
		// (add) Token: 0x0600105E RID: 4190 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600105F RID: 4191 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000102")]
		public event Action<int, ShopItem> SelectSlotEvent
		{
			[Token(Token = "0x600105E")]
			[Address(RVA = "0x625C", Offset = "0x625C", VA = "0x625C")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600105F")]
			[Address(RVA = "0x625D", Offset = "0x625D", VA = "0x625D")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x06001060 RID: 4192 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001060")]
		[Address(RVA = "0x625E", Offset = "0x625E", VA = "0x625E", Slot = "22")]
		protected override void OnShow(ShopWindow.ShopWindowArgs args)
		{
		}

		// Token: 0x06001061 RID: 4193 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001061")]
		[Address(RVA = "0x625F", Offset = "0x625F", VA = "0x625F", Slot = "19")]
		protected override void OnClose()
		{
		}

		// Token: 0x06001062 RID: 4194 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001062")]
		[Address(RVA = "0x6260", Offset = "0x6260", VA = "0x6260")]
		private void OnShopItemClick(ShopItem item)
		{
		}

		// Token: 0x06001063 RID: 4195 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001063")]
		[Address(RVA = "0x6261", Offset = "0x6261", VA = "0x6261")]
		public void Init(int normalSlotsCount, int nebomarketSlotsCount)
		{
		}

		// Token: 0x06001064 RID: 4196 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001064")]
		[Address(RVA = "0x6262", Offset = "0x6262", VA = "0x6262")]
		public void UpdateCommonItems(UserData loggedUser, IEnumerable<ShopArtifactDataDecorator> commonItems)
		{
		}

		// Token: 0x06001065 RID: 4197 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001065")]
		[Address(RVA = "0x6263", Offset = "0x6263", VA = "0x6263")]
		public void UpdateGoldItems(UserData loggedUser, IEnumerable<ShopArtifactDataDecorator> goldItems, bool hasTradeAccount)
		{
		}

		// Token: 0x06001066 RID: 4198 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001066")]
		[Address(RVA = "0x1DC2", Offset = "0x1DC2", VA = "0x1DC2")]
		private void HandleDataDecorator(UserData loggedUser, ShopArtifactDataDecorator item, ShopItem shopItem, SlotStates defaultState)
		{
		}

		// Token: 0x06001067 RID: 4199 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001067")]
		[Address(RVA = "0x6264", Offset = "0x6264", VA = "0x6264")]
		public void SetShopTip(string text)
		{
		}

		// Token: 0x06001068 RID: 4200 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001068")]
		[Address(RVA = "0x6265", Offset = "0x6265", VA = "0x6265")]
		public void SetItemsTip(string text)
		{
		}

		// Token: 0x06001069 RID: 4201 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001069")]
		[Address(RVA = "0x6266", Offset = "0x6266", VA = "0x6266")]
		public void SetLeftPanelActive(bool active)
		{
		}

		// Token: 0x0600106A RID: 4202 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600106A")]
		[Address(RVA = "0x6267", Offset = "0x6267", VA = "0x6267")]
		private void SetupMVC(UserData owner)
		{
		}

		// Token: 0x0600106B RID: 4203 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600106B")]
		[Address(RVA = "0x6268", Offset = "0x6268", VA = "0x6268")]
		private void SetupMyShop()
		{
		}

		// Token: 0x0600106C RID: 4204 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600106C")]
		[Address(RVA = "0x6269", Offset = "0x6269", VA = "0x6269")]
		private void SetupOtherShop(UserData owner)
		{
		}

		// Token: 0x0600106D RID: 4205 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600106D")]
		[Address(RVA = "0x626A", Offset = "0x626A", VA = "0x626A")]
		private void DestroyMVC()
		{
		}

		// Token: 0x0600106E RID: 4206 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600106E")]
		[Address(RVA = "0x626B", Offset = "0x626B", VA = "0x626B")]
		public ShopWindow()
		{
		}

		// Token: 0x0600106F RID: 4207 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600106F")]
		[Address(RVA = "0x626C", Offset = "0x626C", VA = "0x626C")]
		[CompilerGenerated]
		private ShopItem <Init>g__SpawnShopItemInstance|25_0()
		{
			return null;
		}

		// Token: 0x0400085D RID: 2141
		[Token(Token = "0x400085D")]
		public const string WINDOW_ID = "Prefabs/UI/Windows/ShopPopupWindow";

		// Token: 0x0400085E RID: 2142
		[Token(Token = "0x400085E")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private TextMeshProUGUI _shopTip;

		// Token: 0x0400085F RID: 2143
		[Token(Token = "0x400085F")]
		[FieldOffset(Offset = "0x44")]
		[SerializeField]
		private TextMeshProUGUI _itemsTip;

		// Token: 0x04000860 RID: 2144
		[Token(Token = "0x4000860")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private RectTransform _shopTable;

		// Token: 0x04000861 RID: 2145
		[Token(Token = "0x4000861")]
		[FieldOffset(Offset = "0x4C")]
		[SerializeField]
		private ShopItem _shopItemPrefab;

		// Token: 0x04000862 RID: 2146
		[Token(Token = "0x4000862")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private RectTransform _leftPanel;

		// Token: 0x04000863 RID: 2147
		[Token(Token = "0x4000863")]
		[FieldOffset(Offset = "0x54")]
		[SerializeField]
		private TradeAccountBannerView _tradeAccount;

		// Token: 0x04000867 RID: 2151
		[Token(Token = "0x4000867")]
		[FieldOffset(Offset = "0x64")]
		private ShopViewMediator _mediator;

		// Token: 0x04000868 RID: 2152
		[Token(Token = "0x4000868")]
		[FieldOffset(Offset = "0x68")]
		private ShopController _controller;

		// Token: 0x04000869 RID: 2153
		[Token(Token = "0x4000869")]
		[FieldOffset(Offset = "0x6C")]
		private ShopEvents _events;

		// Token: 0x0400086A RID: 2154
		[Token(Token = "0x400086A")]
		[FieldOffset(Offset = "0x70")]
		private ShopModel _model;

		// Token: 0x020002B9 RID: 697
		[Token(Token = "0x20002B9")]
		public class ShopWindowArgs : BaseBuildingWindowArgs
		{
			// Token: 0x06001070 RID: 4208 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001070")]
			[Address(RVA = "0x626D", Offset = "0x626D", VA = "0x626D")]
			public ShopWindowArgs(UserIsle isle, uint buildingTypeId)
			{
			}
		}
	}
}
