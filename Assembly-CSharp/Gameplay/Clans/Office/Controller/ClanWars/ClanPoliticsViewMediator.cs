using System;
using Core.MVC.Interfaces;
using Gameplay.Clans.Office.Events;
using Gameplay.Clans.Office.Model;
using Gameplay.Clans.Office.View.ClanWarsTab.ClanPoliticsTab;
using Il2CppDummyDll;
using MVC;
using MVC.Interfaces;
using Protocol.Common;
using UI.Elements.Filters.GenericFilter;

namespace Gameplay.Clans.Office.Controller.ClanWars
{
	// Token: 0x02000A80 RID: 2688
	[Token(Token = "0x2000A80")]
	public class ClanPoliticsViewMediator : AbstractViewMediator<ClanWarsOfficeModel, ClanWarsOfficeEvents, ClanWarsOfficeController, ClanPoliticsView>, IHideableMediator
	{
		// Token: 0x0600401F RID: 16415 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600401F")]
		[Address(RVA = "0x8ED9", Offset = "0x8ED9", VA = "0x8ED9")]
		public ClanPoliticsViewMediator(ClanWarsOfficeModel model, ClanWarsOfficeEvents events, ClanWarsOfficeController controller)
		{
		}

		// Token: 0x17000CAF RID: 3247
		// (set) Token: 0x06004020 RID: 16416 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000CAF")]
		public override ClanPoliticsView View
		{
			[Token(Token = "0x6004020")]
			[Address(RVA = "0x8EDA", Offset = "0x8EDA", VA = "0x8EDA", Slot = "20")]
			set
			{
			}
		}

		// Token: 0x06004021 RID: 16417 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004021")]
		[Address(RVA = "0x8EDB", Offset = "0x8EDB", VA = "0x8EDB")]
		private void ResetView()
		{
		}

		// Token: 0x06004022 RID: 16418 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004022")]
		[Address(RVA = "0x8EDC", Offset = "0x8EDC", VA = "0x8EDC")]
		private void SetupView()
		{
		}

		// Token: 0x06004023 RID: 16419 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004023")]
		[Address(RVA = "0x8EDD", Offset = "0x8EDD", VA = "0x8EDD")]
		private void MyZigguratButtonClickedEventHandler()
		{
		}

		// Token: 0x06004024 RID: 16420 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004024")]
		[Address(RVA = "0x8EDE", Offset = "0x8EDE", VA = "0x8EDE")]
		private void ZigguratButtonClickedEventHandler()
		{
		}

		// Token: 0x06004025 RID: 16421 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004025")]
		[Address(RVA = "0x8EDF", Offset = "0x8EDF", VA = "0x8EDF")]
		private void UpdateOSARequestBounds()
		{
		}

		// Token: 0x06004026 RID: 16422 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004026")]
		[Address(RVA = "0x8EE0", Offset = "0x8EE0", VA = "0x8EE0")]
		private void MoreItemsAfterNeededEventHandler()
		{
		}

		// Token: 0x06004027 RID: 16423 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004027")]
		[Address(RVA = "0x8EE1", Offset = "0x8EE1", VA = "0x8EE1")]
		private void FilterSelectedEventHandler(object data)
		{
		}

		// Token: 0x06004028 RID: 16424 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004028")]
		[Address(RVA = "0x8EE2", Offset = "0x8EE2", VA = "0x8EE2")]
		private void FakeRequestCurrentWar()
		{
		}

		// Token: 0x06004029 RID: 16425 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004029")]
		[Address(RVA = "0x8EE3", Offset = "0x8EE3", VA = "0x8EE3")]
		private void SearchButtonClickedEventHandler()
		{
		}

		// Token: 0x0600402A RID: 16426 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600402A")]
		[Address(RVA = "0x8EE4", Offset = "0x8EE4", VA = "0x8EE4")]
		private void RequestPolitics(ClanInfo lastClanInfo)
		{
		}

		// Token: 0x0600402B RID: 16427 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600402B")]
		[Address(RVA = "0x8EE5", Offset = "0x8EE5", VA = "0x8EE5")]
		private void SubFilterClickedEventHandler(SubFilterListElement element)
		{
		}

		// Token: 0x0600402C RID: 16428 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600402C")]
		[Address(RVA = "0x8EE6", Offset = "0x8EE6", VA = "0x8EE6")]
		private void RequestFirstPolitics()
		{
		}

		// Token: 0x0600402D RID: 16429 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600402D")]
		[Address(RVA = "0x8EE7", Offset = "0x8EE7", VA = "0x8EE7")]
		private void SelectFilter(SubFilterListElement element)
		{
		}

		// Token: 0x17000CB0 RID: 3248
		// (set) Token: 0x0600402E RID: 16430 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000CB0")]
		public override ClanWarsOfficeEvents Events
		{
			[Token(Token = "0x600402E")]
			[Address(RVA = "0x8EE8", Offset = "0x8EE8", VA = "0x8EE8", Slot = "16")]
			set
			{
			}
		}

		// Token: 0x0600402F RID: 16431 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600402F")]
		[Address(RVA = "0x8EE9", Offset = "0x8EE9", VA = "0x8EE9")]
		private void WarStateChangedEventHandler()
		{
		}

		// Token: 0x06004030 RID: 16432 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004030")]
		[Address(RVA = "0x8EEA", Offset = "0x8EEA", VA = "0x8EEA")]
		private void UpdateWarState()
		{
		}

		// Token: 0x06004031 RID: 16433 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004031")]
		[Address(RVA = "0x8EEB", Offset = "0x8EEB", VA = "0x8EEB")]
		private void CheckForWarState()
		{
		}

		// Token: 0x06004032 RID: 16434 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004032")]
		[Address(RVA = "0x8EEC", Offset = "0x8EEC", VA = "0x8EEC")]
		private void PoliticsAddedEventHandler()
		{
		}

		// Token: 0x06004033 RID: 16435 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004033")]
		[Address(RVA = "0x8EED", Offset = "0x8EED", VA = "0x8EED")]
		private void FirstPoliticsRequestedEventHandler()
		{
		}

		// Token: 0x06004034 RID: 16436 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004034")]
		[Address(RVA = "0x8EEE", Offset = "0x8EEE", VA = "0x8EEE")]
		private void ListElementClickedEventHandler(ClanPolicyListElement element)
		{
		}

		// Token: 0x06004035 RID: 16437 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004035")]
		[Address(RVA = "0x8EEF", Offset = "0x8EEF", VA = "0x8EEF")]
		private void SelectArgs(ClanPolicyListElement.ClanPolicyListElementArgs args)
		{
		}

		// Token: 0x06004036 RID: 16438 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004036")]
		[Address(RVA = "0x8EF0", Offset = "0x8EF0", VA = "0x8EF0")]
		private void InjectCallback()
		{
		}

		// Token: 0x06004037 RID: 16439 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004037")]
		[Address(RVA = "0x8EF1", Offset = "0x8EF1", VA = "0x8EF1", Slot = "21")]
		public void Hide()
		{
		}

		// Token: 0x06004038 RID: 16440 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004038")]
		[Address(RVA = "0x8EF2", Offset = "0x8EF2", VA = "0x8EF2", Slot = "14")]
		public override void Dispose()
		{
		}

		// Token: 0x040023C9 RID: 9161
		[Token(Token = "0x40023C9")]
		public const uint LINES_COUNT = 100U;

		// Token: 0x040023CA RID: 9162
		[Token(Token = "0x40023CA")]
		[FieldOffset(Offset = "0x18")]
		private IViewMediator<ClanWarStatusView> _currentMediator;

		// Token: 0x040023CB RID: 9163
		[Token(Token = "0x40023CB")]
		[FieldOffset(Offset = "0x1C")]
		private string _searchInput;

		// Token: 0x040023CC RID: 9164
		[Token(Token = "0x40023CC")]
		[FieldOffset(Offset = "0x20")]
		private SubFilterListElement _selectedFilter;

		// Token: 0x040023CD RID: 9165
		[Token(Token = "0x40023CD")]
		[FieldOffset(Offset = "0x24")]
		private uint _leagueId;

		// Token: 0x040023CE RID: 9166
		[Token(Token = "0x40023CE")]
		[FieldOffset(Offset = "0x28")]
		private ClanPolicyListElement.ClanPolicyListElementArgs _selectedArgs;

		// Token: 0x040023CF RID: 9167
		[Token(Token = "0x40023CF")]
		[FieldOffset(Offset = "0x2C")]
		private ClanWarsOfficeModel.ClanPolicyFilter _policyFilter;
	}
}
