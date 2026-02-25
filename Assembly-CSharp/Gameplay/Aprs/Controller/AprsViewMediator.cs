using System;
using System.Collections.Generic;
using Gameplay.Aprs.Controller.Filters;
using Gameplay.Aprs.Events;
using Gameplay.Aprs.Model;
using Gameplay.Aprs.Model.Tabs;
using Gameplay.Aprs.View;
using Il2CppDummyDll;
using MVC;
using UI.Filters;
using UI.Tabs;

namespace Gameplay.Aprs.Controller
{
	// Token: 0x02000D73 RID: 3443
	[Token(Token = "0x2000D73")]
	public class AprsViewMediator : AbstractViewMediator<AprsModel, AprsEvents, AprsController, AprsWindow>
	{
		// Token: 0x06005463 RID: 21603 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005463")]
		[Address(RVA = "0xA219", Offset = "0xA219", VA = "0xA219")]
		public AprsViewMediator(AprsModel model, AprsEvents events, AprsController controller)
		{
		}

		// Token: 0x17001128 RID: 4392
		// (set) Token: 0x06005464 RID: 21604 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001128")]
		public override AprsEvents Events
		{
			[Token(Token = "0x6005464")]
			[Address(RVA = "0xA21A", Offset = "0xA21A", VA = "0xA21A", Slot = "16")]
			set
			{
			}
		}

		// Token: 0x06005465 RID: 21605 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005465")]
		[Address(RVA = "0xA21B", Offset = "0xA21B", VA = "0xA21B")]
		private void OwnerChangedEvent()
		{
		}

		// Token: 0x06005466 RID: 21606 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005466")]
		[Address(RVA = "0xA21C", Offset = "0xA21C", VA = "0xA21C")]
		private void AprChangedEvent(AprData aprData, uint medalId)
		{
		}

		// Token: 0x17001129 RID: 4393
		// (set) Token: 0x06005467 RID: 21607 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001129")]
		public override AprsWindow View
		{
			[Token(Token = "0x6005467")]
			[Address(RVA = "0xA21D", Offset = "0xA21D", VA = "0xA21D", Slot = "20")]
			set
			{
			}
		}

		// Token: 0x06005468 RID: 21608 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005468")]
		[Address(RVA = "0xA21E", Offset = "0xA21E", VA = "0xA21E")]
		private void FiltersViewOnChangedEvent()
		{
		}

		// Token: 0x06005469 RID: 21609 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005469")]
		[Address(RVA = "0xA21F", Offset = "0xA21F", VA = "0xA21F")]
		private void SetFiltersData()
		{
		}

		// Token: 0x0600546A RID: 21610 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600546A")]
		[Address(RVA = "0xA220", Offset = "0xA220", VA = "0xA220")]
		private void ViewOnAprClickEvent(AprData aprData)
		{
		}

		// Token: 0x0600546B RID: 21611 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600546B")]
		[Address(RVA = "0xA221", Offset = "0xA221", VA = "0xA221")]
		private void InitEventHandler()
		{
		}

		// Token: 0x0600546C RID: 21612 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600546C")]
		[Address(RVA = "0xA222", Offset = "0xA222", VA = "0xA222")]
		private List<TabBarItemData<AprsTabBarItemData>> GetCurrentTabs()
		{
			return null;
		}

		// Token: 0x0600546D RID: 21613 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600546D")]
		[Address(RVA = "0xA223", Offset = "0xA223", VA = "0xA223")]
		private void SelectDefaultTab()
		{
		}

		// Token: 0x0600546E RID: 21614 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600546E")]
		[Address(RVA = "0xA224", Offset = "0xA224", VA = "0xA224")]
		private void TabBarOnChangeEvent()
		{
		}

		// Token: 0x0600546F RID: 21615 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600546F")]
		[Address(RVA = "0xA225", Offset = "0xA225", VA = "0xA225")]
		private void RedrawCurrentTab()
		{
		}

		// Token: 0x06005470 RID: 21616 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005470")]
		[Address(RVA = "0xA226", Offset = "0xA226", VA = "0xA226")]
		private List<AprData> FilterAprs(List<AprData> aprs, out int achievedCount, out int totalCount)
		{
			return null;
		}

		// Token: 0x06005471 RID: 21617 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005471")]
		[Address(RVA = "0xA227", Offset = "0xA227", VA = "0xA227", Slot = "14")]
		public override void Dispose()
		{
		}

		// Token: 0x04002DAD RID: 11693
		[Token(Token = "0x4002DAD")]
		[FieldOffset(Offset = "0x18")]
		private Dictionary<FilterInfo.FilterType, IAprFilter> _filters;

		// Token: 0x04002DAE RID: 11694
		[Token(Token = "0x4002DAE")]
		[FieldOffset(Offset = "0x1C")]
		private Predicate<AprData> _customFilter;
	}
}
