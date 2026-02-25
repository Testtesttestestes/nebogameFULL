using System;
using System.Collections.Generic;
using Gameplay.Bank.View;
using Gameplay.Fresco.Events;
using Gameplay.Fresco.Model;
using Gameplay.Fresco.View;
using Il2CppDummyDll;
using MVC;
using Protocol.Fresco;
using UI;

namespace Gameplay.Fresco.Controller
{
	// Token: 0x0200080F RID: 2063
	[Token(Token = "0x200080F")]
	public class FrescoEditViewMediator : AbstractCozyViewMediator<FrescoModel, Gameplay.Fresco.Events.FrescoEvents, FrescoController, FrescoEditView>
	{
		// Token: 0x06003089 RID: 12425 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003089")]
		[Address(RVA = "0x80EE", Offset = "0x80EE", VA = "0x80EE")]
		public FrescoEditViewMediator(FrescoModel model, Gameplay.Fresco.Events.FrescoEvents events, FrescoController controller)
		{
		}

		// Token: 0x0600308A RID: 12426 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600308A")]
		[Address(RVA = "0x80EF", Offset = "0x80EF", VA = "0x80EF", Slot = "21")]
		protected override void ResetEvents(Gameplay.Fresco.Events.FrescoEvents events)
		{
		}

		// Token: 0x0600308B RID: 12427 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600308B")]
		[Address(RVA = "0x80F0", Offset = "0x80F0", VA = "0x80F0", Slot = "22")]
		protected override void SetupEvents(Gameplay.Fresco.Events.FrescoEvents events)
		{
		}

		// Token: 0x0600308C RID: 12428 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600308C")]
		[Address(RVA = "0x80F1", Offset = "0x80F1", VA = "0x80F1", Slot = "23")]
		protected override void ResetView(FrescoEditView view)
		{
		}

		// Token: 0x0600308D RID: 12429 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600308D")]
		[Address(RVA = "0x80F2", Offset = "0x80F2", VA = "0x80F2", Slot = "24")]
		protected override void SetupView(FrescoEditView view)
		{
		}

		// Token: 0x0600308E RID: 12430 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600308E")]
		[Address(RVA = "0x80F3", Offset = "0x80F3", VA = "0x80F3")]
		private void InitView()
		{
		}

		// Token: 0x0600308F RID: 12431 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600308F")]
		[Address(RVA = "0x80F4", Offset = "0x80F4", VA = "0x80F4")]
		private void SetupDarkBG()
		{
		}

		// Token: 0x06003090 RID: 12432 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003090")]
		[Address(RVA = "0x80F5", Offset = "0x80F5", VA = "0x80F5")]
		private void CheckRequirements()
		{
		}

		// Token: 0x06003091 RID: 12433 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003091")]
		[Address(RVA = "0x80F6", Offset = "0x80F6", VA = "0x80F6")]
		private void SetBankOptions()
		{
		}

		// Token: 0x06003092 RID: 12434 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003092")]
		[Address(RVA = "0x80F7", Offset = "0x80F7", VA = "0x80F7")]
		private void ClearSelection()
		{
		}

		// Token: 0x06003093 RID: 12435 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003093")]
		[Address(RVA = "0x80F8", Offset = "0x80F8", VA = "0x80F8")]
		private void FrescoFieldOnChangeSelected(List<uint> selectedCells)
		{
		}

		// Token: 0x06003094 RID: 12436 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003094")]
		[Address(RVA = "0x80F9", Offset = "0x80F9", VA = "0x80F9")]
		private void UpdateState()
		{
		}

		// Token: 0x06003095 RID: 12437 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003095")]
		[Address(RVA = "0x80FA", Offset = "0x80FA", VA = "0x80FA")]
		private void UpdateUniversalFragmentsCounters()
		{
		}

		// Token: 0x06003096 RID: 12438 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003096")]
		[Address(RVA = "0x80FB", Offset = "0x80FB", VA = "0x80FB")]
		private void UniversalFragmentsCountChangedHandler(uint count)
		{
		}

		// Token: 0x06003097 RID: 12439 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003097")]
		[Address(RVA = "0x80FC", Offset = "0x80FC", VA = "0x80FC")]
		private void BalanceChangedHandler()
		{
		}

		// Token: 0x06003098 RID: 12440 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003098")]
		[Address(RVA = "0x80FD", Offset = "0x80FD", VA = "0x80FD")]
		private void FrescoesUpdatedHandler()
		{
		}

		// Token: 0x06003099 RID: 12441 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003099")]
		[Address(RVA = "0x80FE", Offset = "0x80FE", VA = "0x80FE")]
		private void FrescoUpdatedHandler(Fresco fresco)
		{
		}

		// Token: 0x0600309A RID: 12442 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600309A")]
		[Address(RVA = "0x80FF", Offset = "0x80FF", VA = "0x80FF")]
		private void InstallUniversalButtonClickHandler()
		{
		}

		// Token: 0x0600309B RID: 12443 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600309B")]
		[Address(RVA = "0x8100", Offset = "0x8100", VA = "0x8100")]
		private void SetUniversalFragmentInstallationState()
		{
		}

		// Token: 0x0600309C RID: 12444 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600309C")]
		[Address(RVA = "0x8101", Offset = "0x8101", VA = "0x8101")]
		private void CompleteFrescoButtonClickHandler()
		{
		}

		// Token: 0x0600309D RID: 12445 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600309D")]
		[Address(RVA = "0x8102", Offset = "0x8102", VA = "0x8102")]
		private void AcceptButtonClickHandler()
		{
		}

		// Token: 0x0600309E RID: 12446 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600309E")]
		[Address(RVA = "0x8103", Offset = "0x8103", VA = "0x8103")]
		private void AdditionalRequirementsButtonClickHandler()
		{
		}

		// Token: 0x0600309F RID: 12447 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600309F")]
		[Address(RVA = "0x8104", Offset = "0x8104", VA = "0x8104")]
		private void BuyUniversalFragmentButtonClickHandler()
		{
		}

		// Token: 0x060030A0 RID: 12448 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60030A0")]
		[Address(RVA = "0x8105", Offset = "0x8105", VA = "0x8105")]
		private void CloseTopButtonClickHandler()
		{
		}

		// Token: 0x060030A1 RID: 12449 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60030A1")]
		[Address(RVA = "0x8106", Offset = "0x8106", VA = "0x8106")]
		private void CollectRewardButtonClickHandler()
		{
		}

		// Token: 0x060030A2 RID: 12450 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60030A2")]
		[Address(RVA = "0x8107", Offset = "0x8107", VA = "0x8107")]
		private void InstallAllButtonClickHandler()
		{
		}

		// Token: 0x060030A3 RID: 12451 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60030A3")]
		[Address(RVA = "0x8108", Offset = "0x8108", VA = "0x8108")]
		private void InstallAllUniversalButtonClickHandler()
		{
		}

		// Token: 0x060030A4 RID: 12452 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60030A4")]
		[Address(RVA = "0x8109", Offset = "0x8109", VA = "0x8109")]
		private void InstallAndContinueButtonClickHandler()
		{
		}

		// Token: 0x060030A5 RID: 12453 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60030A5")]
		[Address(RVA = "0x810A", Offset = "0x810A", VA = "0x810A")]
		private void LeftButtonClickHandler()
		{
		}

		// Token: 0x060030A6 RID: 12454 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60030A6")]
		[Address(RVA = "0x810B", Offset = "0x810B", VA = "0x810B")]
		private void RightButtonClickHandler()
		{
		}

		// Token: 0x060030A7 RID: 12455 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60030A7")]
		[Address(RVA = "0x810C", Offset = "0x810C", VA = "0x810C")]
		private void SetKeyObject()
		{
		}

		// Token: 0x060030A8 RID: 12456 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60030A8")]
		[Address(RVA = "0x810D", Offset = "0x810D", VA = "0x810D")]
		private void InBankButtonClickedEventHandler(IndexButtonBasic _)
		{
		}

		// Token: 0x060030A9 RID: 12457 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60030A9")]
		[Address(RVA = "0x810E", Offset = "0x810E", VA = "0x810E")]
		private void BankOptionsListViewOnBuyButtonClickedEvent(IBankOptionView bankOptionView)
		{
		}
	}
}
