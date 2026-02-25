using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Core.Data;
using Gameplay.Competition.Model;
using Gameplay.Inventory.View;
using Il2CppDummyDll;
using Protocol;
using UI;
using UI.Price;
using UI.ToolTip;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using Utils;

namespace Gameplay.Competition.View.Sections.Shop
{
	// Token: 0x020008E2 RID: 2274
	[Token(Token = "0x20008E2")]
	[DisallowMultipleComponent]
	public class CompetitionShopItemView : AbstractDataRenderer<ShopItemData>, IPointerEnterHandler, IEventSystemHandler, IToolTipDataProvider, IPointerClickHandler, IArtifactView
	{
		// Token: 0x17000A91 RID: 2705
		// (get) Token: 0x0600357D RID: 13693 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600357E RID: 13694 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000A91")]
		public IActionInfo Info
		{
			[Token(Token = "0x600357D")]
			[Address(RVA = "0x858B", Offset = "0x858B", VA = "0x858B", Slot = "29")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600357E")]
			[Address(RVA = "0x858C", Offset = "0x858C", VA = "0x858C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000A92 RID: 2706
		// (get) Token: 0x0600357F RID: 13695 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06003580 RID: 13696 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000A92")]
		public BackTime Backtime
		{
			[Token(Token = "0x600357F")]
			[Address(RVA = "0x858D", Offset = "0x858D", VA = "0x858D", Slot = "30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6003580")]
			[Address(RVA = "0x858E", Offset = "0x858E", VA = "0x858E")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000A93 RID: 2707
		// (get) Token: 0x06003581 RID: 13697 RVA: 0x0000AD70 File Offset: 0x00008F70
		[Token(Token = "0x17000A93")]
		public bool OnlyMarketAccount
		{
			[Token(Token = "0x6003581")]
			[Address(RVA = "0x858F", Offset = "0x858F", VA = "0x858F", Slot = "31")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000A94 RID: 2708
		// (get) Token: 0x06003582 RID: 13698 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000A94")]
		public ArtifactData ArtifactData
		{
			[Token(Token = "0x6003582")]
			[Address(RVA = "0x8590", Offset = "0x8590", VA = "0x8590", Slot = "25")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000A95 RID: 2709
		// (get) Token: 0x06003583 RID: 13699 RVA: 0x0000AD88 File Offset: 0x00008F88
		// (set) Token: 0x06003584 RID: 13700 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000A95")]
		public ArtifactView.ArtifactViewArgs Args
		{
			[Token(Token = "0x6003583")]
			[Address(RVA = "0x8591", Offset = "0x8591", VA = "0x8591", Slot = "26")]
			[CompilerGenerated]
			get
			{
				return default(ArtifactView.ArtifactViewArgs);
			}
			[Token(Token = "0x6003584")]
			[Address(RVA = "0x8592", Offset = "0x8592", VA = "0x8592", Slot = "27")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000A96 RID: 2710
		// (get) Token: 0x06003585 RID: 13701 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000A96")]
		public GameObject GameObject
		{
			[Token(Token = "0x6003585")]
			[Address(RVA = "0x8593", Offset = "0x8593", VA = "0x8593", Slot = "28")]
			get
			{
				return null;
			}
		}

		// Token: 0x06003586 RID: 13702 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003586")]
		[Address(RVA = "0x8594", Offset = "0x8594", VA = "0x8594", Slot = "19")]
		protected override void HandleDataChanged()
		{
		}

		// Token: 0x06003587 RID: 13703 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003587")]
		[Address(RVA = "0x8595", Offset = "0x8595", VA = "0x8595", Slot = "20")]
		public void OnPointerEnter(PointerEventData eventData)
		{
		}

		// Token: 0x06003588 RID: 13704 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6003588")]
		[Address(RVA = "0x8596", Offset = "0x8596", VA = "0x8596", Slot = "21")]
		public BaseToolTipData GetData()
		{
			return null;
		}

		// Token: 0x17000A97 RID: 2711
		// (get) Token: 0x06003589 RID: 13705 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000A97")]
		public Image Marker
		{
			[Token(Token = "0x6003589")]
			[Address(RVA = "0x8597", Offset = "0x8597", VA = "0x8597")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600358A RID: 13706 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600358A")]
		[Address(RVA = "0x8598", Offset = "0x8598", VA = "0x8598", Slot = "22")]
		public void OnPointerClick(PointerEventData eventData)
		{
		}

		// Token: 0x0600358B RID: 13707 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600358B")]
		[Address(RVA = "0x8599", Offset = "0x8599", VA = "0x8599", Slot = "17")]
		protected override void StartListenEvents(ShopItemData data)
		{
		}

		// Token: 0x0600358C RID: 13708 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600358C")]
		[Address(RVA = "0x859A", Offset = "0x859A", VA = "0x859A", Slot = "18")]
		protected override void StopListenEvents(ShopItemData data)
		{
		}

		// Token: 0x0600358D RID: 13709 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600358D")]
		[Address(RVA = "0x859B", Offset = "0x859B", VA = "0x859B")]
		private void UserBalanceUpdatedHandler(OwnerRating from, OwnerRating to)
		{
		}

		// Token: 0x17000A98 RID: 2712
		// (get) Token: 0x0600358F RID: 13711 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600358E RID: 13710 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000A98")]
		public IList<Sprite> MarkerSprites
		{
			[Token(Token = "0x600358F")]
			[Address(RVA = "0x859D", Offset = "0x859D", VA = "0x859D")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x600358E")]
			[Address(RVA = "0x859C", Offset = "0x859C", VA = "0x859C")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06003590 RID: 13712 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003590")]
		[Address(RVA = "0x859E", Offset = "0x859E", VA = "0x859E", Slot = "16")]
		protected override void OnDataInvalidated()
		{
		}

		// Token: 0x06003591 RID: 13713 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003591")]
		[Address(RVA = "0x859F", Offset = "0x859F", VA = "0x859F")]
		public CompetitionShopItemView()
		{
		}

		// Token: 0x04001D42 RID: 7490
		[Token(Token = "0x4001D42")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private ArtikulView _artikulView;

		// Token: 0x04001D43 RID: 7491
		[Token(Token = "0x4001D43")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private PriceItemRenderer _price;

		// Token: 0x04001D44 RID: 7492
		[Token(Token = "0x4001D44")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private Image _marker;
	}
}
