using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Gameplay.Market.Controller.Filters;
using Gameplay.Market.Events;
using Gameplay.Market.Model;
using Gameplay.Market.Model.Data;
using Gameplay.Market.View;
using Il2CppDummyDll;
using JetBrains.Annotations;
using MVC;
using UI.Filters;

namespace Gameplay.Market.Controller
{
	// Token: 0x02000635 RID: 1589
	[Token(Token = "0x2000635")]
	public class MarketViewMediator : AbstractViewMediator<MarketModel, MarketEvents, MarketController, MarketWindow>
	{
		// Token: 0x17000739 RID: 1849
		// (get) Token: 0x06002684 RID: 9860 RVA: 0x00007668 File Offset: 0x00005868
		[Token(Token = "0x17000739")]
		private MarketLotData.DataType CurrentTab
		{
			[Token(Token = "0x6002684")]
			[Address(RVA = "0x77BD", Offset = "0x77BD", VA = "0x77BD")]
			get
			{
				return MarketLotData.DataType.USER;
			}
		}

		// Token: 0x06002685 RID: 9861 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002685")]
		[Address(RVA = "0x77BE", Offset = "0x77BE", VA = "0x77BE")]
		public MarketViewMediator(MarketModel model, MarketEvents events, MarketController controller)
		{
		}

		// Token: 0x06002686 RID: 9862 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002686")]
		[Address(RVA = "0x77BF", Offset = "0x77BF", VA = "0x77BF")]
		private void MarketLotsChangedEventHandler()
		{
		}

		// Token: 0x1700073A RID: 1850
		// (set) Token: 0x06002687 RID: 9863 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700073A")]
		public override MarketWindow View
		{
			[Token(Token = "0x6002687")]
			[Address(RVA = "0x77C0", Offset = "0x77C0", VA = "0x77C0", Slot = "20")]
			set
			{
			}
		}

		// Token: 0x1700073B RID: 1851
		// (set) Token: 0x06002688 RID: 9864 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700073B")]
		public override MarketEvents Events
		{
			[Token(Token = "0x6002688")]
			[Address(RVA = "0x77C1", Offset = "0x77C1", VA = "0x77C1", Slot = "16")]
			set
			{
			}
		}

		// Token: 0x06002689 RID: 9865 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002689")]
		[Address(RVA = "0x77C2", Offset = "0x77C2", VA = "0x77C2")]
		private void MarketArtifactsRequestedEventHandler()
		{
		}

		// Token: 0x0600268A RID: 9866 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600268A")]
		[Address(RVA = "0x77C3", Offset = "0x77C3", VA = "0x77C3")]
		private void InitialSelect()
		{
		}

		// Token: 0x0600268B RID: 9867 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600268B")]
		[Address(RVA = "0x77C4", Offset = "0x77C4", VA = "0x77C4")]
		private void ExtraArtifactsRequestedEventHandler()
		{
		}

		// Token: 0x0600268C RID: 9868 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600268C")]
		[Address(RVA = "0x77C5", Offset = "0x77C5", VA = "0x77C5")]
		private void ArtifactsListChangedEventHandler(IEnumerable<MarketLotListElement.MarketLotListElementArgs> added, IEnumerable<MarketLotListElement.MarketLotListElementArgs> removed)
		{
		}

		// Token: 0x0600268D RID: 9869 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600268D")]
		[Address(RVA = "0x77C6", Offset = "0x77C6", VA = "0x77C6")]
		private void ResetView()
		{
		}

		// Token: 0x0600268E RID: 9870 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600268E")]
		[Address(RVA = "0x77C7", Offset = "0x77C7", VA = "0x77C7")]
		private void SetupView()
		{
		}

		// Token: 0x0600268F RID: 9871 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600268F")]
		[Address(RVA = "0x77C8", Offset = "0x77C8", VA = "0x77C8")]
		private void GetOtherArtifacts()
		{
		}

		// Token: 0x06002690 RID: 9872 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002690")]
		[Address(RVA = "0x77C9", Offset = "0x77C9", VA = "0x77C9")]
		private void GetOtherOptionsArtifacts()
		{
		}

		// Token: 0x06002691 RID: 9873 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002691")]
		[Address(RVA = "0x77CA", Offset = "0x77CA", VA = "0x77CA")]
		private void GetSimilarArtifacts()
		{
		}

		// Token: 0x06002692 RID: 9874 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002692")]
		[Address(RVA = "0x77CB", Offset = "0x77CB", VA = "0x77CB")]
		private void GetOptionsLots()
		{
		}

		// Token: 0x06002693 RID: 9875 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002693")]
		[Address(RVA = "0x77CC", Offset = "0x77CC", VA = "0x77CC")]
		private void FiltersViewChangedEventHandler()
		{
		}

		// Token: 0x06002694 RID: 9876 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002694")]
		[Address(RVA = "0x77CD", Offset = "0x77CD", VA = "0x77CD")]
		private void SetFiltersData()
		{
		}

		// Token: 0x06002695 RID: 9877 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6002695")]
		[Address(RVA = "0x77CE", Offset = "0x77CE", VA = "0x77CE")]
		private List<MarketLotListElement.MarketLotListElementArgs> FilterLots(in IList<MarketLotListElement.MarketLotListElementArgs> rawData)
		{
			return null;
		}

		// Token: 0x06002696 RID: 9878 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002696")]
		[Address(RVA = "0x77CF", Offset = "0x77CF", VA = "0x77CF")]
		private void BuyButtonClickedEventHandler()
		{
		}

		// Token: 0x06002697 RID: 9879 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002697")]
		[Address(RVA = "0x77D0", Offset = "0x77D0", VA = "0x77D0")]
		private void TabChangedEventHandler()
		{
		}

		// Token: 0x06002698 RID: 9880 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002698")]
		[Address(RVA = "0x77D1", Offset = "0x77D1", VA = "0x77D1")]
		private void ExtraTabChangedEventHandler()
		{
		}

		// Token: 0x06002699 RID: 9881 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002699")]
		[Address(RVA = "0x77D2", Offset = "0x77D2", VA = "0x77D2")]
		private void UpdateExtraArtifacts()
		{
		}

		// Token: 0x0600269A RID: 9882 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600269A")]
		[Address(RVA = "0x77D3", Offset = "0x77D3", VA = "0x77D3")]
		private void ForceUpdateExtraArtifacts()
		{
		}

		// Token: 0x0600269B RID: 9883 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600269B")]
		[Address(RVA = "0x77D4", Offset = "0x77D4", VA = "0x77D4")]
		private void HandleScroll()
		{
		}

		// Token: 0x0600269C RID: 9884 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600269C")]
		[Address(RVA = "0x77D5", Offset = "0x77D5", VA = "0x77D5")]
		private void HandleExtraScroll()
		{
		}

		// Token: 0x0600269D RID: 9885 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600269D")]
		[Address(RVA = "0x77D6", Offset = "0x77D6", VA = "0x77D6")]
		private void DrawCurrentTab(IEnumerable<MarketLotListElement.MarketLotListElementArgs> added, IEnumerable<MarketLotListElement.MarketLotListElementArgs> removed)
		{
		}

		// Token: 0x0600269E RID: 9886 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600269E")]
		[Address(RVA = "0x77D7", Offset = "0x77D7", VA = "0x77D7")]
		private void DrawCurrentTab()
		{
		}

		// Token: 0x0600269F RID: 9887 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600269F")]
		[Address(RVA = "0x77D8", Offset = "0x77D8", VA = "0x77D8")]
		private void DrawUserLots([CanBeNull] IEnumerable<MarketLotListElement.MarketLotListElementArgs> added, [CanBeNull] IEnumerable<MarketLotListElement.MarketLotListElementArgs> removed)
		{
		}

		// Token: 0x060026A0 RID: 9888 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60026A0")]
		[Address(RVA = "0x77D9", Offset = "0x77D9", VA = "0x77D9")]
		private void MarketLotButtonClickedEventHandler(MarketLotListElement element)
		{
		}

		// Token: 0x060026A1 RID: 9889 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60026A1")]
		[Address(RVA = "0x77DA", Offset = "0x77DA", VA = "0x77DA")]
		private void SelectMarketLotListElement(MarketLotListElement.MarketLotListElementArgs args)
		{
		}

		// Token: 0x060026A2 RID: 9890 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60026A2")]
		[Address(RVA = "0x77DB", Offset = "0x77DB", VA = "0x77DB")]
		private void UpdateMarketLotInfo(MarketLotData data)
		{
		}

		// Token: 0x060026A3 RID: 9891 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60026A3")]
		[Address(RVA = "0x77DC", Offset = "0x77DC", VA = "0x77DC")]
		private void SelectFirstLot()
		{
		}

		// Token: 0x060026A5 RID: 9893 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60026A5")]
		[Address(RVA = "0x77DE", Offset = "0x77DE", VA = "0x77DE")]
		[CompilerGenerated]
		internal static void <BuyButtonClickedEventHandler>g__HandleBuyMarketOption|30_0(MarketOptionData data)
		{
		}

		// Token: 0x060026A6 RID: 9894 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60026A6")]
		[Address(RVA = "0x77DF", Offset = "0x77DF", VA = "0x77DF")]
		[CompilerGenerated]
		private void <BuyButtonClickedEventHandler>g__HandleBuyUserLot|30_1(UserMarketLotData data)
		{
		}

		// Token: 0x060026A7 RID: 9895 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60026A7")]
		[Address(RVA = "0x77E0", Offset = "0x77E0", VA = "0x77E0")]
		[CompilerGenerated]
		private void <DrawCurrentTab>g__DrawOptions|38_0()
		{
		}

		// Token: 0x04001514 RID: 5396
		[Token(Token = "0x4001514")]
		[FieldOffset(Offset = "0x18")]
		private MarketLotListElement.MarketLotListElementArgs _selectedArgs;

		// Token: 0x04001515 RID: 5397
		[Token(Token = "0x4001515")]
		[FieldOffset(Offset = "0x1C")]
		private IList<MarketLotListElement.MarketLotListElementArgs> _extraArtifacts;

		// Token: 0x04001516 RID: 5398
		[Token(Token = "0x4001516")]
		[FieldOffset(Offset = "0x20")]
		private List<MarketLotListElement.MarketLotListElementArgs> _filteredArgs;

		// Token: 0x04001517 RID: 5399
		[Token(Token = "0x4001517")]
		[FieldOffset(Offset = "0x24")]
		private List<MarketLotListElement.MarketLotListElementArgs> _filteredOptions;

		// Token: 0x04001518 RID: 5400
		[Token(Token = "0x4001518")]
		[FieldOffset(Offset = "0x28")]
		private readonly Dictionary<FilterInfo.FilterType, IMarketFilter> _filters;

		// Token: 0x04001519 RID: 5401
		[Token(Token = "0x4001519")]
		[FieldOffset(Offset = "0x2C")]
		private readonly IMarketFilter _subFilter;

		// Token: 0x0400151A RID: 5402
		[Token(Token = "0x400151A")]
		[FieldOffset(Offset = "0x30")]
		private readonly Action[] _extraLotsOptionsRequests;

		// Token: 0x0400151B RID: 5403
		[Token(Token = "0x400151B")]
		[FieldOffset(Offset = "0x34")]
		private readonly Action[] _extraLotsUsersRequests;

		// Token: 0x0400151C RID: 5404
		[Token(Token = "0x400151C")]
		[FieldOffset(Offset = "0x38")]
		private bool _isMasterElement;
	}
}
