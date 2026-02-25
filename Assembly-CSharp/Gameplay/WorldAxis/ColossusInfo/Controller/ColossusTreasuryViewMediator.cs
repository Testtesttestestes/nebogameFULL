using System;
using System.Collections.Generic;
using Gameplay.Inventory.View.Chest;
using Gameplay.WorldAxis.ColossusInfo.Events;
using Gameplay.WorldAxis.ColossusInfo.Model;
using Gameplay.WorldAxis.ColossusInfo.View;
using Il2CppDummyDll;
using MVC;
using MVC.Interfaces;
using Protocol.Common;

namespace Gameplay.WorldAxis.ColossusInfo.Controller
{
	// Token: 0x0200032E RID: 814
	[Token(Token = "0x200032E")]
	public class ColossusTreasuryViewMediator : AbstractViewMediator<ColossusTreasuryModel, ColossusTreasuryEvents, ColossusTreasuryController, ColossusTreasuryView>, IHideableMediator
	{
		// Token: 0x060012A8 RID: 4776 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60012A8")]
		[Address(RVA = "0x64A2", Offset = "0x64A2", VA = "0x64A2")]
		public ColossusTreasuryViewMediator(ColossusTreasuryModel model, ColossusTreasuryEvents events, ColossusTreasuryController controller)
		{
		}

		// Token: 0x170002E7 RID: 743
		// (set) Token: 0x060012A9 RID: 4777 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002E7")]
		public override ColossusTreasuryView View
		{
			[Token(Token = "0x60012A9")]
			[Address(RVA = "0x64A3", Offset = "0x64A3", VA = "0x64A3", Slot = "20")]
			set
			{
			}
		}

		// Token: 0x170002E8 RID: 744
		// (set) Token: 0x060012AA RID: 4778 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002E8")]
		public override ColossusTreasuryEvents Events
		{
			[Token(Token = "0x60012AA")]
			[Address(RVA = "0x64A4", Offset = "0x64A4", VA = "0x64A4", Slot = "16")]
			set
			{
			}
		}

		// Token: 0x060012AB RID: 4779 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60012AB")]
		[Address(RVA = "0x64A5", Offset = "0x64A5", VA = "0x64A5")]
		private void ResetView()
		{
		}

		// Token: 0x060012AC RID: 4780 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60012AC")]
		[Address(RVA = "0x64A6", Offset = "0x64A6", VA = "0x64A6")]
		private void SetupView()
		{
		}

		// Token: 0x060012AD RID: 4781 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60012AD")]
		[Address(RVA = "0x64A7", Offset = "0x64A7", VA = "0x64A7")]
		private void ToTreasuryButtonClickedEventHandler()
		{
		}

		// Token: 0x060012AE RID: 4782 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60012AE")]
		[Address(RVA = "0x64A8", Offset = "0x64A8", VA = "0x64A8")]
		private void UpdateInventoryView()
		{
		}

		// Token: 0x060012AF RID: 4783 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60012AF")]
		[Address(RVA = "0x64A9", Offset = "0x64A9", VA = "0x64A9")]
		private void CreateClanButtonClickedEventHandler()
		{
		}

		// Token: 0x060012B0 RID: 4784 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60012B0")]
		[Address(RVA = "0x64AA", Offset = "0x64AA", VA = "0x64AA")]
		private void BuyButtonClickedEventHandler()
		{
		}

		// Token: 0x060012B1 RID: 4785 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60012B1")]
		[Address(RVA = "0x64AB", Offset = "0x64AB", VA = "0x64AB")]
		private void UpdateBalance()
		{
		}

		// Token: 0x060012B2 RID: 4786 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60012B2")]
		[Address(RVA = "0x64AC", Offset = "0x64AC", VA = "0x64AC")]
		private void InventoryChangedEventHandler()
		{
		}

		// Token: 0x060012B3 RID: 4787 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60012B3")]
		[Address(RVA = "0x64AD", Offset = "0x64AD", VA = "0x64AD")]
		private void TreasuryOptionsRequestedEventHandler()
		{
		}

		// Token: 0x060012B4 RID: 4788 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60012B4")]
		[Address(RVA = "0x64AE", Offset = "0x64AE", VA = "0x64AE")]
		private void ClanBalanceChangedEventHandler(ResourceSet balance, ResourceSet delta)
		{
		}

		// Token: 0x060012B5 RID: 4789 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60012B5")]
		[Address(RVA = "0x64AF", Offset = "0x64AF", VA = "0x64AF")]
		private void InjectCallback()
		{
		}

		// Token: 0x060012B6 RID: 4790 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60012B6")]
		[Address(RVA = "0x64B0", Offset = "0x64B0", VA = "0x64B0")]
		private void ListElementClickedEventHandler(TreasuryOptionListElement element)
		{
		}

		// Token: 0x060012B7 RID: 4791 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60012B7")]
		[Address(RVA = "0x64B1", Offset = "0x64B1", VA = "0x64B1")]
		private void Select(TreasuryOptionListElement.TreasuryOptionListElementArgs args)
		{
		}

		// Token: 0x060012B8 RID: 4792 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60012B8")]
		[Address(RVA = "0x64B2", Offset = "0x64B2", VA = "0x64B2")]
		private List<ArtifactCategoryData> GetArtikulTypeGroupedData()
		{
			return null;
		}

		// Token: 0x060012B9 RID: 4793 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60012B9")]
		[Address(RVA = "0x64B3", Offset = "0x64B3", VA = "0x64B3", Slot = "21")]
		public void Hide()
		{
		}

		// Token: 0x04000A1B RID: 2587
		[Token(Token = "0x4000A1B")]
		[FieldOffset(Offset = "0x18")]
		private TreasuryOptionListElement.TreasuryOptionListElementArgs _selectedArgs;
	}
}
