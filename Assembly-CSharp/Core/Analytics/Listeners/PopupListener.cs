using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Core.Events.Scopes;
using Gameplay.Bank.Controller;
using Il2CppDummyDll;

namespace Core.Analytics.Listeners
{
	// Token: 0x020012DA RID: 4826
	[Token(Token = "0x20012DA")]
	public class PopupListener : AbstractAnalyticsListener
	{
		// Token: 0x1700173E RID: 5950
		// (get) Token: 0x060072C5 RID: 29381 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700173E")]
		protected override string Theme
		{
			[Token(Token = "0x60072C5")]
			[Address(RVA = "0xBCCE", Offset = "0xBCCE", VA = "0xBCCE", Slot = "5")]
			get
			{
				return null;
			}
		}

		// Token: 0x060072C6 RID: 29382 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60072C6")]
		[Address(RVA = "0xBCCF", Offset = "0xBCCF", VA = "0xBCCF", Slot = "10")]
		public override void Init()
		{
		}

		// Token: 0x060072C7 RID: 29383 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60072C7")]
		[Address(RVA = "0xBCD0", Offset = "0xBCD0", VA = "0xBCD0")]
		private void HandleMilestoneSelectedEvent(GdEventsScope.Args args)
		{
		}

		// Token: 0x060072C8 RID: 29384 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60072C8")]
		[Address(RVA = "0xBCD1", Offset = "0xBCD1", VA = "0xBCD1")]
		private void BankTabChangedEvent(UiScope.BankTabChangedArgs args)
		{
		}

		// Token: 0x060072C9 RID: 29385 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60072C9")]
		[Address(RVA = "0xBCD2", Offset = "0xBCD2", VA = "0xBCD2")]
		private void OfferSelectionChangedEvent(UiScope.OfferSelectionChangedArgs args)
		{
		}

		// Token: 0x060072CA RID: 29386 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60072CA")]
		[Address(RVA = "0xBCD3", Offset = "0xBCD3", VA = "0xBCD3", Slot = "11")]
		protected override void Deinit()
		{
		}

		// Token: 0x060072CB RID: 29387 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60072CB")]
		[Address(RVA = "0xBCD4", Offset = "0xBCD4", VA = "0xBCD4")]
		private void WindowClosedEvent(UiScope.WindowClosedEventArgs args)
		{
		}

		// Token: 0x060072CC RID: 29388 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60072CC")]
		[Address(RVA = "0xBCD5", Offset = "0xBCD5", VA = "0xBCD5")]
		private void WindowOpenedEvent(UiScope.WindowOpenedEventArgs args)
		{
		}

		// Token: 0x060072CD RID: 29389 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60072CD")]
		[Address(RVA = "0xBCD6", Offset = "0xBCD6", VA = "0xBCD6")]
		private void SendDlgOfferEvent(UiScope.WindowOpenedEventArgs openArgs, UiScope.WindowClosedEventArgs closeArgs, long deltaTimeMs)
		{
		}

		// Token: 0x060072CE RID: 29390 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60072CE")]
		[Address(RVA = "0xBCD7", Offset = "0xBCD7", VA = "0xBCD7")]
		private void SendDlgEndlessOptionEvent(UiScope.WindowOpenedEventArgs openArgs, UiScope.WindowClosedEventArgs closeArgs, long deltaTimeMs)
		{
		}

		// Token: 0x060072CF RID: 29391 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60072CF")]
		[Address(RVA = "0xBCD8", Offset = "0xBCD8", VA = "0xBCD8")]
		private void SendDlgBankEvent(UiScope.WindowOpenedEventArgs openArgs, string exit, string type, long deltaTimeMs)
		{
		}

		// Token: 0x060072D0 RID: 29392 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60072D0")]
		[Address(RVA = "0xBCD9", Offset = "0xBCD9", VA = "0xBCD9")]
		private void SendMilestoneSelected(UiScope.WindowOpenedEventArgs openArgs, UiScope.WindowClosedEventArgs closeArgs, long deltaTimeMs)
		{
		}

		// Token: 0x060072D1 RID: 29393 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60072D1")]
		[Address(RVA = "0xBCDA", Offset = "0xBCDA", VA = "0xBCDA")]
		public PopupListener()
		{
		}

		// Token: 0x04003C1A RID: 15386
		[Token(Token = "0x4003C1A")]
		public const string THEME = "popup";

		// Token: 0x04003C1B RID: 15387
		[Token(Token = "0x4003C1B")]
		private const string DLG_ENDLESS_OPTION = "dlg_endless_option";

		// Token: 0x04003C1C RID: 15388
		[Token(Token = "0x4003C1C")]
		private const string DLG_OFFER = "dlg_offer";

		// Token: 0x04003C1D RID: 15389
		[Token(Token = "0x4003C1D")]
		private const string DLG_BANK = "dlg_bank";

		// Token: 0x04003C1E RID: 15390
		[Token(Token = "0x4003C1E")]
		private const string DLG_MILESTONE_SELECTED = "dlg_milestone_selected";

		// Token: 0x04003C1F RID: 15391
		[Token(Token = "0x4003C1F")]
		[FieldOffset(Offset = "0x10")]
		private uint _selectedOffer;

		// Token: 0x04003C20 RID: 15392
		[Token(Token = "0x4003C20")]
		[FieldOffset(Offset = "0x14")]
		private BankTabType _bankTabType;

		// Token: 0x04003C21 RID: 15393
		[Token(Token = "0x4003C21")]
		[FieldOffset(Offset = "0x18")]
		private uint? _milestoneNumber;

		// Token: 0x04003C22 RID: 15394
		[Token(Token = "0x4003C22")]
		[FieldOffset(Offset = "0x20")]
		[TupleElementNames(new string[]
		{
			"openArgs",
			"timestamp"
		})]
		private readonly Dictionary<string, ValueTuple<UiScope.WindowOpenedEventArgs, DateTime>> _openedWindows;
	}
}
