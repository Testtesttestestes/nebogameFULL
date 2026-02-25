using System;
using Gameplay.Clans.Office.Events;
using Gameplay.Clans.Office.Model;
using Gameplay.Clans.Office.View.ClanResumesTab;
using Il2CppDummyDll;
using MVC;
using MVC.Interfaces;
using Protocol.Rating;
using UI.Elements.Filters.GenericFilter;

namespace Gameplay.Clans.Office.Controller
{
	// Token: 0x02000A6F RID: 2671
	[Token(Token = "0x2000A6F")]
	public class ClanResumesViewMediator : AbstractViewMediator<ClanResumesModel, ClanResumesEvents, ClanResumesController, ClanResumesView>, IHideableMediator
	{
		// Token: 0x06003F75 RID: 16245 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003F75")]
		[Address(RVA = "0x8E30", Offset = "0x8E30", VA = "0x8E30")]
		public ClanResumesViewMediator(ClanResumesModel model, ClanResumesEvents events, ClanResumesController controller)
		{
		}

		// Token: 0x17000CA3 RID: 3235
		// (set) Token: 0x06003F76 RID: 16246 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000CA3")]
		public override ClanResumesView View
		{
			[Token(Token = "0x6003F76")]
			[Address(RVA = "0x8E31", Offset = "0x8E31", VA = "0x8E31", Slot = "20")]
			set
			{
			}
		}

		// Token: 0x06003F77 RID: 16247 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003F77")]
		[Address(RVA = "0x8E32", Offset = "0x8E32", VA = "0x8E32")]
		private void Init()
		{
		}

		// Token: 0x06003F78 RID: 16248 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003F78")]
		[Address(RVA = "0x8E33", Offset = "0x8E33", VA = "0x8E33")]
		private void InitEventHandler()
		{
		}

		// Token: 0x06003F79 RID: 16249 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003F79")]
		[Address(RVA = "0x8E34", Offset = "0x8E34", VA = "0x8E34")]
		private void AddVacancyButtonClickedEventHandler()
		{
		}

		// Token: 0x06003F7A RID: 16250 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003F7A")]
		[Address(RVA = "0x8E35", Offset = "0x8E35", VA = "0x8E35")]
		private void DeclineButtonClickedEventHandler()
		{
		}

		// Token: 0x06003F7B RID: 16251 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003F7B")]
		[Address(RVA = "0x8E36", Offset = "0x8E36", VA = "0x8E36")]
		private void AcceptButtonClickedEventHandler()
		{
		}

		// Token: 0x06003F7C RID: 16252 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003F7C")]
		[Address(RVA = "0x8E37", Offset = "0x8E37", VA = "0x8E37")]
		private void OpenClanToggleChangedEventHandler(bool enable)
		{
		}

		// Token: 0x06003F7D RID: 16253 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003F7D")]
		[Address(RVA = "0x8E38", Offset = "0x8E38", VA = "0x8E38")]
		private void SelectSubFilter(SubFilterListElement element)
		{
		}

		// Token: 0x06003F7E RID: 16254 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003F7E")]
		[Address(RVA = "0x8E39", Offset = "0x8E39", VA = "0x8E39")]
		private void SubFilterClickedEventHandler(SubFilterListElement element)
		{
		}

		// Token: 0x06003F7F RID: 16255 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003F7F")]
		[Address(RVA = "0x8E3A", Offset = "0x8E3A", VA = "0x8E3A")]
		private void FilterSelectedEventHandler(object data)
		{
		}

		// Token: 0x06003F80 RID: 16256 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003F80")]
		[Address(RVA = "0x8E3B", Offset = "0x8E3B", VA = "0x8E3B")]
		private void MoreItemsAfterNeededEventHandler()
		{
		}

		// Token: 0x06003F81 RID: 16257 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003F81")]
		[Address(RVA = "0x8E3C", Offset = "0x8E3C", VA = "0x8E3C")]
		private void RequestResumes(ulong lastUserId, ulong lastUserRating)
		{
		}

		// Token: 0x06003F82 RID: 16258 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003F82")]
		[Address(RVA = "0x8E3D", Offset = "0x8E3D", VA = "0x8E3D")]
		private void RequestFirstResumes()
		{
		}

		// Token: 0x06003F83 RID: 16259 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003F83")]
		[Address(RVA = "0x8E3E", Offset = "0x8E3E", VA = "0x8E3E")]
		private void UpdateAddVacancyPrice()
		{
		}

		// Token: 0x17000CA4 RID: 3236
		// (set) Token: 0x06003F84 RID: 16260 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000CA4")]
		public override ClanResumesEvents Events
		{
			[Token(Token = "0x6003F84")]
			[Address(RVA = "0x8E3F", Offset = "0x8E3F", VA = "0x8E3F", Slot = "16")]
			set
			{
			}
		}

		// Token: 0x06003F85 RID: 16261 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003F85")]
		[Address(RVA = "0x8E40", Offset = "0x8E40", VA = "0x8E40")]
		private void ResumeRemovedEventHandler(ulong userId)
		{
		}

		// Token: 0x06003F86 RID: 16262 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003F86")]
		[Address(RVA = "0x8E41", Offset = "0x8E41", VA = "0x8E41")]
		private void VacancyAddedEventHandler()
		{
		}

		// Token: 0x06003F87 RID: 16263 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003F87")]
		[Address(RVA = "0x8E42", Offset = "0x8E42", VA = "0x8E42")]
		private void ClanStateFlagsChangedEventHandler()
		{
		}

		// Token: 0x06003F88 RID: 16264 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003F88")]
		[Address(RVA = "0x8E43", Offset = "0x8E43", VA = "0x8E43")]
		private void ResumesAddedEventHandler()
		{
		}

		// Token: 0x06003F89 RID: 16265 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003F89")]
		[Address(RVA = "0x8E44", Offset = "0x8E44", VA = "0x8E44")]
		private void FirstResumesRequestedEventHandler()
		{
		}

		// Token: 0x06003F8A RID: 16266 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003F8A")]
		[Address(RVA = "0x8E45", Offset = "0x8E45", VA = "0x8E45")]
		private void UpdateOSARequestBounds()
		{
		}

		// Token: 0x06003F8B RID: 16267 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003F8B")]
		[Address(RVA = "0x8E46", Offset = "0x8E46", VA = "0x8E46")]
		private void InjectCallback()
		{
		}

		// Token: 0x06003F8C RID: 16268 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003F8C")]
		[Address(RVA = "0x8E47", Offset = "0x8E47", VA = "0x8E47")]
		private void ListElementClickedEventHandler(UserInRatingListElement element)
		{
		}

		// Token: 0x06003F8D RID: 16269 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003F8D")]
		[Address(RVA = "0x8E48", Offset = "0x8E48", VA = "0x8E48")]
		private void SelectArgs(UserInRatingListElement.UserInRatingListElementArgs args)
		{
		}

		// Token: 0x06003F8E RID: 16270 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003F8E")]
		[Address(RVA = "0x8E49", Offset = "0x8E49", VA = "0x8E49", Slot = "21")]
		public void Hide()
		{
		}

		// Token: 0x040023A1 RID: 9121
		[Token(Token = "0x40023A1")]
		[FieldOffset(Offset = "0x18")]
		private UserInRatingListElement.UserInRatingListElementArgs _selectedArgs;

		// Token: 0x040023A2 RID: 9122
		[Token(Token = "0x40023A2")]
		[FieldOffset(Offset = "0x1C")]
		private SubFilterListElement _selectedFilter;

		// Token: 0x040023A3 RID: 9123
		[Token(Token = "0x40023A3")]
		[FieldOffset(Offset = "0x20")]
		private RatingPeriods _ratingPeriod;

		// Token: 0x040023A4 RID: 9124
		[Token(Token = "0x40023A4")]
		[FieldOffset(Offset = "0x24")]
		private UserRatingTypes _ratingType;
	}
}
