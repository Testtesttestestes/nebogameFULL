using System;
using System.Collections.Generic;
using Core.Data;
using Gameplay.Medals.Controller.Filters;
using Gameplay.Medals.Events;
using Gameplay.Medals.Model;
using Gameplay.Medals.View;
using Il2CppDummyDll;
using MVC;
using UI.Filters;
using UI.Tabs;

namespace Gameplay.Medals.Controller
{
	// Token: 0x0200060D RID: 1549
	[Token(Token = "0x200060D")]
	public class MedalsViewMediator : AbstractViewMediator<MedalsModel, MedalsEvents, MedalsController, MedalsWindow>
	{
		// Token: 0x0600259F RID: 9631 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600259F")]
		[Address(RVA = "0x76E0", Offset = "0x76E0", VA = "0x76E0")]
		public MedalsViewMediator(MedalsModel model, MedalsEvents events, MedalsController controller)
		{
		}

		// Token: 0x17000712 RID: 1810
		// (set) Token: 0x060025A0 RID: 9632 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000712")]
		public override MedalsWindow View
		{
			[Token(Token = "0x60025A0")]
			[Address(RVA = "0x76E1", Offset = "0x76E1", VA = "0x76E1", Slot = "20")]
			set
			{
			}
		}

		// Token: 0x060025A1 RID: 9633 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60025A1")]
		[Address(RVA = "0x76E2", Offset = "0x76E2", VA = "0x76E2")]
		private void FiltersViewOnChangedEvent()
		{
		}

		// Token: 0x060025A2 RID: 9634 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60025A2")]
		[Address(RVA = "0x76E3", Offset = "0x76E3", VA = "0x76E3")]
		private void SetFiltersData()
		{
		}

		// Token: 0x060025A3 RID: 9635 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60025A3")]
		[Address(RVA = "0x76E4", Offset = "0x76E4", VA = "0x76E4")]
		private void SelectDefaultTab()
		{
		}

		// Token: 0x060025A4 RID: 9636 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60025A4")]
		[Address(RVA = "0x76E5", Offset = "0x76E5", VA = "0x76E5")]
		private void TabBarOnChangeEvent()
		{
		}

		// Token: 0x060025A5 RID: 9637 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60025A5")]
		[Address(RVA = "0x76E6", Offset = "0x76E6", VA = "0x76E6")]
		private void RedrawCurrentTab()
		{
		}

		// Token: 0x060025A6 RID: 9638 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60025A6")]
		[Address(RVA = "0x76E7", Offset = "0x76E7", VA = "0x76E7")]
		private void PreparePaymentCategoryFilter()
		{
		}

		// Token: 0x060025A7 RID: 9639 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60025A7")]
		[Address(RVA = "0x76E8", Offset = "0x76E8", VA = "0x76E8")]
		private Dictionary<uint, List<MedalData>> FilterMedals(Dictionary<uint, List<MedalData>> rawData, out int achievedCount, out int totalCount)
		{
			return null;
		}

		// Token: 0x060025A8 RID: 9640 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60025A8")]
		[Address(RVA = "0x76E9", Offset = "0x76E9", VA = "0x76E9")]
		private List<TabBarItemData> GetCurrentTabs()
		{
			return null;
		}

		// Token: 0x060025A9 RID: 9641 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60025A9")]
		[Address(RVA = "0x76EA", Offset = "0x76EA", VA = "0x76EA")]
		private void MedalViewClickCallback(MedalView view)
		{
		}

		// Token: 0x17000713 RID: 1811
		// (set) Token: 0x060025AA RID: 9642 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000713")]
		public override MedalsEvents Events
		{
			[Token(Token = "0x60025AA")]
			[Address(RVA = "0x76EB", Offset = "0x76EB", VA = "0x76EB", Slot = "16")]
			set
			{
			}
		}

		// Token: 0x060025AB RID: 9643 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60025AB")]
		[Address(RVA = "0x76EC", Offset = "0x76EC", VA = "0x76EC")]
		private void MedalChangedEventHandler(MedalData medalData, uint medalId)
		{
		}

		// Token: 0x060025AC RID: 9644 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60025AC")]
		[Address(RVA = "0x76ED", Offset = "0x76ED", VA = "0x76ED")]
		private void MedalRemovedEventHandler(uint medalId)
		{
		}

		// Token: 0x060025AD RID: 9645 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60025AD")]
		[Address(RVA = "0x76EE", Offset = "0x76EE", VA = "0x76EE")]
		private void InitEventHandler()
		{
		}

		// Token: 0x060025AE RID: 9646 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60025AE")]
		[Address(RVA = "0x76EF", Offset = "0x76EF", VA = "0x76EF", Slot = "14")]
		public override void Dispose()
		{
		}

		// Token: 0x04001493 RID: 5267
		[Token(Token = "0x4001493")]
		[FieldOffset(Offset = "0x18")]
		private Dictionary<FilterInfo.FilterType, IMedalFilter> _filters;

		// Token: 0x04001494 RID: 5268
		[Token(Token = "0x4001494")]
		[FieldOffset(Offset = "0x1C")]
		private bool _saleEnabled;

		// Token: 0x04001495 RID: 5269
		[Token(Token = "0x4001495")]
		[FieldOffset(Offset = "0x20")]
		private PaymentCategoryFilter _paymentCategoryFilter;

		// Token: 0x04001496 RID: 5270
		[Token(Token = "0x4001496")]
		[FieldOffset(Offset = "0x24")]
		private Predicate<MedalData> _customFilter;
	}
}
