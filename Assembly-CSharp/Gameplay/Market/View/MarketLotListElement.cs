using System;
using System.Runtime.CompilerServices;
using AssetContent;
using Gameplay.Inventory.View;
using Gameplay.Market.Model.Data;
using Il2CppDummyDll;
using TMPro;
using UI.Elements.GenericList;
using UnityEngine;

namespace Gameplay.Market.View
{
	// Token: 0x0200061C RID: 1564
	[Token(Token = "0x200061C")]
	public class MarketLotListElement : GenericListElement<MarketLotListElement.MarketLotListElementArgs>
	{
		// Token: 0x17000720 RID: 1824
		// (get) Token: 0x060025F1 RID: 9713 RVA: 0x000073C8 File Offset: 0x000055C8
		[Token(Token = "0x17000720")]
		public bool IsMasterElement
		{
			[Token(Token = "0x60025F1")]
			[Address(RVA = "0x772F", Offset = "0x772F", VA = "0x772F")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000721 RID: 1825
		// (get) Token: 0x060025F2 RID: 9714 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060025F3 RID: 9715 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000721")]
		public MarketLotListElement.MarketLotListElementArgs Data
		{
			[Token(Token = "0x60025F2")]
			[Address(RVA = "0x7730", Offset = "0x7730", VA = "0x7730")]
			get
			{
				return null;
			}
			[Token(Token = "0x60025F3")]
			[Address(RVA = "0x7731", Offset = "0x7731", VA = "0x7731")]
			set
			{
			}
		}

		// Token: 0x060025F4 RID: 9716 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60025F4")]
		[Address(RVA = "0x7732", Offset = "0x7732", VA = "0x7732")]
		private void Awake()
		{
		}

		// Token: 0x060025F5 RID: 9717 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60025F5")]
		[Address(RVA = "0x7733", Offset = "0x7733", VA = "0x7733")]
		private void OnDestroy()
		{
		}

		// Token: 0x060025F6 RID: 9718 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60025F6")]
		[Address(RVA = "0x7734", Offset = "0x7734", VA = "0x7734", Slot = "5")]
		protected override void RegisterEvents()
		{
		}

		// Token: 0x060025F7 RID: 9719 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60025F7")]
		[Address(RVA = "0x7735", Offset = "0x7735", VA = "0x7735", Slot = "4")]
		protected override void OnInit(MarketLotListElement.MarketLotListElementArgs args)
		{
		}

		// Token: 0x060025F8 RID: 9720 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60025F8")]
		[Address(RVA = "0x7736", Offset = "0x7736", VA = "0x7736")]
		private void CallElementClickedEvent(MarketLotListElement.MarketLotListElementArgs args)
		{
		}

		// Token: 0x060025F9 RID: 9721 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60025F9")]
		[Address(RVA = "0x7737", Offset = "0x7737", VA = "0x7737")]
		private void ApplyArgs()
		{
		}

		// Token: 0x060025FA RID: 9722 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60025FA")]
		[Address(RVA = "0x7738", Offset = "0x7738", VA = "0x7738")]
		private void SelectChangedEventHandler(bool select)
		{
		}

		// Token: 0x060025FB RID: 9723 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60025FB")]
		[Address(RVA = "0x7739", Offset = "0x7739", VA = "0x7739")]
		private void Select(bool isSelected)
		{
		}

		// Token: 0x060025FC RID: 9724 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60025FC")]
		[Address(RVA = "0x773A", Offset = "0x773A", VA = "0x773A")]
		public MarketLotListElement()
		{
		}

		// Token: 0x040014B5 RID: 5301
		[Token(Token = "0x40014B5")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _selectedImage;

		// Token: 0x040014B6 RID: 5302
		[Token(Token = "0x40014B6")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private ArtikulView _artikulView;

		// Token: 0x040014B7 RID: 5303
		[Token(Token = "0x40014B7")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private TextMeshProUGUI _title;

		// Token: 0x040014B8 RID: 5304
		[Token(Token = "0x40014B8")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private MarketLotPriceView _priceView;

		// Token: 0x040014B9 RID: 5305
		[Token(Token = "0x40014B9")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameImage _ribbonIcon;

		// Token: 0x040014BA RID: 5306
		[Token(Token = "0x40014BA")]
		[FieldOffset(Offset = "0x34")]
		[Tooltip("Такие же элементы дублируются в другом списке, нам нужно их различать")]
		[SerializeField]
		private bool _isMasterElement;

		// Token: 0x0200061D RID: 1565
		[Token(Token = "0x200061D")]
		public class MarketLotListElementArgs : GenericListElementArgs
		{
			// Token: 0x060025FD RID: 9725 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60025FD")]
			[Address(RVA = "0x773B", Offset = "0x773B", VA = "0x773B")]
			public MarketLotListElementArgs(MarketLotData data)
			{
			}

			// Token: 0x14000150 RID: 336
			// (add) Token: 0x060025FE RID: 9726 RVA: 0x00002050 File Offset: 0x00000250
			// (remove) Token: 0x060025FF RID: 9727 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x14000150")]
			public event Action<bool> SelectChangedEvent
			{
				[Token(Token = "0x60025FE")]
				[Address(RVA = "0x773C", Offset = "0x773C", VA = "0x773C")]
				[CompilerGenerated]
				add
				{
				}
				[Token(Token = "0x60025FF")]
				[Address(RVA = "0x773D", Offset = "0x773D", VA = "0x773D")]
				[CompilerGenerated]
				remove
				{
				}
			}

			// Token: 0x17000722 RID: 1826
			// (get) Token: 0x06002600 RID: 9728 RVA: 0x000073E0 File Offset: 0x000055E0
			// (set) Token: 0x06002601 RID: 9729 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000722")]
			public bool Selected
			{
				[Token(Token = "0x6002600")]
				[Address(RVA = "0x773E", Offset = "0x773E", VA = "0x773E")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x6002601")]
				[Address(RVA = "0x773F", Offset = "0x773F", VA = "0x773F")]
				set
				{
				}
			}

			// Token: 0x040014BB RID: 5307
			[Token(Token = "0x40014BB")]
			[FieldOffset(Offset = "0xC")]
			public readonly MarketLotData MarketLotData;

			// Token: 0x040014BC RID: 5308
			[Token(Token = "0x40014BC")]
			[FieldOffset(Offset = "0x10")]
			private bool _selected;

			// Token: 0x040014BD RID: 5309
			[Token(Token = "0x40014BD")]
			[FieldOffset(Offset = "0x14")]
			public Action<MarketLotListElement> MarketLotButtonClickedEvent;
		}
	}
}
