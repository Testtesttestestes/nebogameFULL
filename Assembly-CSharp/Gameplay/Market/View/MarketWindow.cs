using System;
using System.Collections.Generic;
using Gameplay.Market.Controller;
using Gameplay.Market.Events;
using Gameplay.Market.Model;
using Il2CppDummyDll;
using UI.Filters;
using UI.Tabs;
using UI.Windows;
using UnityEngine;
using UnityEngine.UI;

namespace Gameplay.Market.View
{
	// Token: 0x0200061F RID: 1567
	[Token(Token = "0x200061F")]
	public class MarketWindow : ClosableBaseWindow<MarketWindow.MarketWindowArgs>
	{
		// Token: 0x17000723 RID: 1827
		// (get) Token: 0x06002604 RID: 9732 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000723")]
		public override string WindowId
		{
			[Token(Token = "0x6002604")]
			[Address(RVA = "0x7742", Offset = "0x7742", VA = "0x7742", Slot = "14")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000724 RID: 1828
		// (get) Token: 0x06002605 RID: 9733 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000724")]
		public MarketLotInfoView InfoView
		{
			[Token(Token = "0x6002605")]
			[Address(RVA = "0x7743", Offset = "0x7743", VA = "0x7743")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000725 RID: 1829
		// (get) Token: 0x06002606 RID: 9734 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000725")]
		public BlueTabBar TabBar
		{
			[Token(Token = "0x6002606")]
			[Address(RVA = "0x7744", Offset = "0x7744", VA = "0x7744")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000726 RID: 1830
		// (get) Token: 0x06002607 RID: 9735 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000726")]
		public MarketLotDataOSAView OSAView
		{
			[Token(Token = "0x6002607")]
			[Address(RVA = "0x7745", Offset = "0x7745", VA = "0x7745")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000727 RID: 1831
		// (get) Token: 0x06002608 RID: 9736 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000727")]
		public MarketLotDataOSAView ExtraOSAView
		{
			[Token(Token = "0x6002608")]
			[Address(RVA = "0x7746", Offset = "0x7746", VA = "0x7746")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000728 RID: 1832
		// (get) Token: 0x06002609 RID: 9737 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000728")]
		public FiltersView FiltersView
		{
			[Token(Token = "0x6002609")]
			[Address(RVA = "0x7747", Offset = "0x7747", VA = "0x7747")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000729 RID: 1833
		// (get) Token: 0x0600260A RID: 9738 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000729")]
		public MetaFiltersView MetaFiltersView
		{
			[Token(Token = "0x600260A")]
			[Address(RVA = "0x7748", Offset = "0x7748", VA = "0x7748")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700072A RID: 1834
		// (get) Token: 0x0600260B RID: 9739 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700072A")]
		public SubFiltersDropdown SubFiltersView
		{
			[Token(Token = "0x600260B")]
			[Address(RVA = "0x7749", Offset = "0x7749", VA = "0x7749")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700072B RID: 1835
		// (get) Token: 0x0600260C RID: 9740 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700072B")]
		public TabBar ExtraTabs
		{
			[Token(Token = "0x600260C")]
			[Address(RVA = "0x774A", Offset = "0x774A", VA = "0x774A")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600260D RID: 9741 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600260D")]
		[Address(RVA = "0x774B", Offset = "0x774B", VA = "0x774B")]
		public void Init()
		{
		}

		// Token: 0x0600260E RID: 9742 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600260E")]
		[Address(RVA = "0x774C", Offset = "0x774C", VA = "0x774C")]
		public void SetMarketLots(List<MarketLotListElement.MarketLotListElementArgs> items, IEnumerable<MarketLotListElement.MarketLotListElementArgs> added, IEnumerable<MarketLotListElement.MarketLotListElementArgs> removed)
		{
		}

		// Token: 0x0600260F RID: 9743 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600260F")]
		[Address(RVA = "0x774D", Offset = "0x774D", VA = "0x774D")]
		public void SetMarketLots(IList<MarketLotListElement.MarketLotListElementArgs> items)
		{
		}

		// Token: 0x06002610 RID: 9744 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002610")]
		[Address(RVA = "0x774E", Offset = "0x774E", VA = "0x774E")]
		public void UpdateExtraMarketLots(IList<MarketLotListElement.MarketLotListElementArgs> items)
		{
		}

		// Token: 0x06002611 RID: 9745 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002611")]
		[Address(RVA = "0x774F", Offset = "0x774F", VA = "0x774F", Slot = "22")]
		protected override void OnShow(MarketWindow.MarketWindowArgs args)
		{
		}

		// Token: 0x06002612 RID: 9746 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002612")]
		[Address(RVA = "0x7750", Offset = "0x7750", VA = "0x7750", Slot = "19")]
		protected override void OnClose()
		{
		}

		// Token: 0x06002613 RID: 9747 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002613")]
		[Address(RVA = "0x7751", Offset = "0x7751", VA = "0x7751")]
		private void RightArrowClickedEventHandler()
		{
		}

		// Token: 0x06002614 RID: 9748 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002614")]
		[Address(RVA = "0x7752", Offset = "0x7752", VA = "0x7752")]
		private void LeftArrowClickedEventHandler()
		{
		}

		// Token: 0x06002615 RID: 9749 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002615")]
		[Address(RVA = "0x7753", Offset = "0x7753", VA = "0x7753")]
		private void SetupMVC()
		{
		}

		// Token: 0x06002616 RID: 9750 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002616")]
		[Address(RVA = "0x7754", Offset = "0x7754", VA = "0x7754")]
		private void DestroyMVC()
		{
		}

		// Token: 0x06002617 RID: 9751 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002617")]
		[Address(RVA = "0x7755", Offset = "0x7755", VA = "0x7755")]
		private void TestRemove(int startIndex, int count = 1)
		{
		}

		// Token: 0x06002618 RID: 9752 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002618")]
		[Address(RVA = "0x7756", Offset = "0x7756", VA = "0x7756")]
		public MarketWindow()
		{
		}

		// Token: 0x040014C2 RID: 5314
		[Token(Token = "0x40014C2")]
		public const string WINDOW_ID = "Prefabs/UI/Windows/Market/MarketWindow";

		// Token: 0x040014C3 RID: 5315
		[Token(Token = "0x40014C3")]
		public const int SCROLL_BY_AMOUNT = 5;

		// Token: 0x040014C4 RID: 5316
		[Token(Token = "0x40014C4")]
		public const float SCROLL_DURATION = 0.3f;

		// Token: 0x040014C5 RID: 5317
		[Token(Token = "0x40014C5")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private MarketLotDataOSAView _oSAView;

		// Token: 0x040014C6 RID: 5318
		[Token(Token = "0x40014C6")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private MarketLotDataOSAView _extraOSAView;

		// Token: 0x040014C7 RID: 5319
		[Token(Token = "0x40014C7")]
		[FieldOffset(Offset = "0x44")]
		[SerializeField]
		private MarketLotInfoView _infoView;

		// Token: 0x040014C8 RID: 5320
		[Token(Token = "0x40014C8")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private BlueTabBar _tabBar;

		// Token: 0x040014C9 RID: 5321
		[Token(Token = "0x40014C9")]
		[FieldOffset(Offset = "0x4C")]
		[SerializeField]
		private FiltersView _filtersView;

		// Token: 0x040014CA RID: 5322
		[Token(Token = "0x40014CA")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private MetaFiltersView _metaFiltersView;

		// Token: 0x040014CB RID: 5323
		[Token(Token = "0x40014CB")]
		[FieldOffset(Offset = "0x54")]
		[SerializeField]
		private SubFiltersDropdown _subFiltersView;

		// Token: 0x040014CC RID: 5324
		[Token(Token = "0x40014CC")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private TabBar _extraTabs;

		// Token: 0x040014CD RID: 5325
		[Token(Token = "0x40014CD")]
		[FieldOffset(Offset = "0x5C")]
		[SerializeField]
		private GameObject[] _enableOnInit;

		// Token: 0x040014CE RID: 5326
		[Token(Token = "0x40014CE")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Button _leftArrow;

		// Token: 0x040014CF RID: 5327
		[Token(Token = "0x40014CF")]
		[FieldOffset(Offset = "0x64")]
		[SerializeField]
		private Button _rightArrow;

		// Token: 0x040014D0 RID: 5328
		[Token(Token = "0x40014D0")]
		[FieldOffset(Offset = "0x68")]
		private MarketModel _model;

		// Token: 0x040014D1 RID: 5329
		[Token(Token = "0x40014D1")]
		[FieldOffset(Offset = "0x6C")]
		private MarketEvents _events;

		// Token: 0x040014D2 RID: 5330
		[Token(Token = "0x40014D2")]
		[FieldOffset(Offset = "0x70")]
		private MarketController _controller;

		// Token: 0x040014D3 RID: 5331
		[Token(Token = "0x40014D3")]
		[FieldOffset(Offset = "0x74")]
		private MarketViewMediator _mediator;

		// Token: 0x040014D4 RID: 5332
		[Token(Token = "0x40014D4")]
		[FieldOffset(Offset = "0x78")]
		private bool _mvcSetUp;

		// Token: 0x02000620 RID: 1568
		[Token(Token = "0x2000620")]
		public class MarketWindowArgs : BaseWindowArgs
		{
			// Token: 0x06002619 RID: 9753 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6002619")]
			[Address(RVA = "0x7757", Offset = "0x7757", VA = "0x7757")]
			public MarketWindowArgs()
			{
			}

			// Token: 0x040014D5 RID: 5333
			[Token(Token = "0x40014D5")]
			[FieldOffset(Offset = "0x18")]
			public uint ArtikulId;
		}
	}
}
