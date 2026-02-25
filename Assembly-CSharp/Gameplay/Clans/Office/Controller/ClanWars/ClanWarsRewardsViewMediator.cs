using System;
using Gameplay.Clans.Office.Events;
using Gameplay.Clans.Office.Model;
using Gameplay.Clans.Office.View.ClanWarsTab.ClanWarsRewardsTab;
using Il2CppDummyDll;
using MVC;
using MVC.Interfaces;
using UI.Elements.Filters.GenericFilter;

namespace Gameplay.Clans.Office.Controller.ClanWars
{
	// Token: 0x02000A86 RID: 2694
	[Token(Token = "0x2000A86")]
	public class ClanWarsRewardsViewMediator : AbstractViewMediator<ClanWarsOfficeModel, ClanWarsOfficeEvents, ClanWarsOfficeController, ClanWarsRewardsView>, IHideableMediator
	{
		// Token: 0x06004071 RID: 16497 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004071")]
		[Address(RVA = "0x8F2B", Offset = "0x8F2B", VA = "0x8F2B")]
		public ClanWarsRewardsViewMediator(ClanWarsOfficeModel model, ClanWarsOfficeEvents events, ClanWarsOfficeController controller)
		{
		}

		// Token: 0x17000CB7 RID: 3255
		// (set) Token: 0x06004072 RID: 16498 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000CB7")]
		public override ClanWarsRewardsView View
		{
			[Token(Token = "0x6004072")]
			[Address(RVA = "0x8F2C", Offset = "0x8F2C", VA = "0x8F2C", Slot = "20")]
			set
			{
			}
		}

		// Token: 0x17000CB8 RID: 3256
		// (set) Token: 0x06004073 RID: 16499 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000CB8")]
		public override ClanWarsOfficeEvents Events
		{
			[Token(Token = "0x6004073")]
			[Address(RVA = "0x8F2D", Offset = "0x8F2D", VA = "0x8F2D", Slot = "16")]
			set
			{
			}
		}

		// Token: 0x06004074 RID: 16500 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004074")]
		[Address(RVA = "0x8F2E", Offset = "0x8F2E", VA = "0x8F2E")]
		private void UpdateCurrentSeasonInfo()
		{
		}

		// Token: 0x06004075 RID: 16501 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004075")]
		[Address(RVA = "0x8F2F", Offset = "0x8F2F", VA = "0x8F2F")]
		private void Init()
		{
		}

		// Token: 0x06004076 RID: 16502 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004076")]
		[Address(RVA = "0x8F30", Offset = "0x8F30", VA = "0x8F30")]
		private void FilterViewClickedEventHandler(SubFilterListElement element)
		{
		}

		// Token: 0x06004077 RID: 16503 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004077")]
		[Address(RVA = "0x8F31", Offset = "0x8F31", VA = "0x8F31")]
		private void SelectFilter(SubFilterListElement element)
		{
		}

		// Token: 0x06004078 RID: 16504 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004078")]
		[Address(RVA = "0x8F32", Offset = "0x8F32", VA = "0x8F32")]
		private void FilterListElementClickedEventHandler(FilterListElement element)
		{
		}

		// Token: 0x06004079 RID: 16505 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004079")]
		[Address(RVA = "0x8F33", Offset = "0x8F33", VA = "0x8F33")]
		private void SelectListElement(FilterListElement element)
		{
		}

		// Token: 0x0600407A RID: 16506 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600407A")]
		[Address(RVA = "0x8F34", Offset = "0x8F34", VA = "0x8F34", Slot = "21")]
		public void Hide()
		{
		}

		// Token: 0x040023DF RID: 9183
		[Token(Token = "0x40023DF")]
		[FieldOffset(Offset = "0x18")]
		private SubFilterListElement _selectedFilter;

		// Token: 0x040023E0 RID: 9184
		[Token(Token = "0x40023E0")]
		[FieldOffset(Offset = "0x1C")]
		private FilterListElement _selectedElement;
	}
}
