using System;
using Gameplay.Clans.Office.Events.ClanWars;
using Gameplay.Clans.Office.Model.ClanWars;
using Gameplay.Clans.Office.View.ClanWarsTab.ClanWarsHistoryTab;
using Il2CppDummyDll;
using MVC;
using MVC.Interfaces;

namespace Gameplay.Clans.Office.Controller.ClanWars
{
	// Token: 0x02000A83 RID: 2691
	[Token(Token = "0x2000A83")]
	public class ClanWarsHistoryViewMediator : AbstractViewMediator<ClanWarsHistoryModel, ClanWarsHistoryEvents, ClanWarsHistoryController, ClanWarsHistoryView>, IHideableMediator
	{
		// Token: 0x06004044 RID: 16452 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004044")]
		[Address(RVA = "0x8EFE", Offset = "0x8EFE", VA = "0x8EFE")]
		public ClanWarsHistoryViewMediator(ClanWarsHistoryModel model, ClanWarsHistoryEvents events, ClanWarsHistoryController controller)
		{
		}

		// Token: 0x17000CB1 RID: 3249
		// (set) Token: 0x06004045 RID: 16453 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000CB1")]
		public override ClanWarsHistoryView View
		{
			[Token(Token = "0x6004045")]
			[Address(RVA = "0x8EFF", Offset = "0x8EFF", VA = "0x8EFF", Slot = "20")]
			set
			{
			}
		}

		// Token: 0x06004046 RID: 16454 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004046")]
		[Address(RVA = "0x8F00", Offset = "0x8F00", VA = "0x8F00")]
		private void Init()
		{
		}

		// Token: 0x06004047 RID: 16455 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004047")]
		[Address(RVA = "0x8F01", Offset = "0x8F01", VA = "0x8F01")]
		private void MoreItemsAfterNeededEventHandler()
		{
		}

		// Token: 0x06004048 RID: 16456 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004048")]
		[Address(RVA = "0x8F02", Offset = "0x8F02", VA = "0x8F02")]
		private void WarButtonClickedEventHandler()
		{
		}

		// Token: 0x06004049 RID: 16457 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004049")]
		[Address(RVA = "0x8F03", Offset = "0x8F03", VA = "0x8F03")]
		private void MembersButtonClickedEventHandler()
		{
		}

		// Token: 0x0600404A RID: 16458 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600404A")]
		[Address(RVA = "0x8F04", Offset = "0x8F04", VA = "0x8F04")]
		private void InfoButtonClickedEventHandler()
		{
		}

		// Token: 0x17000CB2 RID: 3250
		// (set) Token: 0x0600404B RID: 16459 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000CB2")]
		public override ClanWarsHistoryEvents Events
		{
			[Token(Token = "0x600404B")]
			[Address(RVA = "0x8F05", Offset = "0x8F05", VA = "0x8F05", Slot = "16")]
			set
			{
			}
		}

		// Token: 0x0600404C RID: 16460 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600404C")]
		[Address(RVA = "0x8F06", Offset = "0x8F06", VA = "0x8F06")]
		private void ClanWarDeclaredEventHandler()
		{
		}

		// Token: 0x0600404D RID: 16461 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600404D")]
		[Address(RVA = "0x8F07", Offset = "0x8F07", VA = "0x8F07")]
		private void FirstHistoryRequestedEventHandler()
		{
		}

		// Token: 0x0600404E RID: 16462 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600404E")]
		[Address(RVA = "0x8F08", Offset = "0x8F08", VA = "0x8F08")]
		private void HistoryRequestedEventHandler()
		{
		}

		// Token: 0x0600404F RID: 16463 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600404F")]
		[Address(RVA = "0x8F09", Offset = "0x8F09", VA = "0x8F09")]
		private void UpdateOSARequestBounds()
		{
		}

		// Token: 0x06004050 RID: 16464 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004050")]
		[Address(RVA = "0x8F0A", Offset = "0x8F0A", VA = "0x8F0A")]
		private void InjectCallback()
		{
		}

		// Token: 0x06004051 RID: 16465 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004051")]
		[Address(RVA = "0x8F0B", Offset = "0x8F0B", VA = "0x8F0B")]
		private void ListElementClickedEventHandler(ClanWarHistoryListElement element)
		{
		}

		// Token: 0x06004052 RID: 16466 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004052")]
		[Address(RVA = "0x8F0C", Offset = "0x8F0C", VA = "0x8F0C")]
		private void SelectArgs(ClanWarHistoryListElement.ClanWarHistoryListElementArgs args)
		{
		}

		// Token: 0x06004053 RID: 16467 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004053")]
		[Address(RVA = "0x8F0D", Offset = "0x8F0D", VA = "0x8F0D")]
		private void ValidateWarButton()
		{
		}

		// Token: 0x06004054 RID: 16468 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004054")]
		[Address(RVA = "0x8F0E", Offset = "0x8F0E", VA = "0x8F0E", Slot = "21")]
		public void Hide()
		{
		}

		// Token: 0x040023D3 RID: 9171
		[Token(Token = "0x40023D3")]
		public const uint LINES_COUNT = 100U;

		// Token: 0x040023D4 RID: 9172
		[Token(Token = "0x40023D4")]
		[FieldOffset(Offset = "0x18")]
		private ClanWarHistoryListElement.ClanWarHistoryListElementArgs _selectedArgs;
	}
}
