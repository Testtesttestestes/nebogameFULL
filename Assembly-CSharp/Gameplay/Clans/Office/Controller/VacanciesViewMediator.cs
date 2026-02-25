using System;
using Gameplay.Clans.Office.Events;
using Gameplay.Clans.Office.Model;
using Gameplay.Clans.Office.View;
using Gameplay.Clans.Office.View.VacanciesTab;
using Il2CppDummyDll;
using MVC;
using MVC.Interfaces;
using Protocol.Dic;
using Protocol.Rating;
using UI.Elements.RatingElements.SubRatings;
using UI.Windows;

namespace Gameplay.Clans.Office.Controller
{
	// Token: 0x02000A7E RID: 2686
	[Token(Token = "0x2000A7E")]
	public class VacanciesViewMediator : AbstractViewMediator<ClanOfficeModel, ClanOfficeEvents, ClanOfficeController, VacanciesView>, IHideableMediator
	{
		// Token: 0x06003FFA RID: 16378 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003FFA")]
		[Address(RVA = "0x8EB4", Offset = "0x8EB4", VA = "0x8EB4")]
		public VacanciesViewMediator(ClanOfficeModel model, ClanOfficeEvents events, ClanOfficeController controller)
		{
		}

		// Token: 0x17000CAD RID: 3245
		// (set) Token: 0x06003FFB RID: 16379 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000CAD")]
		public override VacanciesView View
		{
			[Token(Token = "0x6003FFB")]
			[Address(RVA = "0x8EB5", Offset = "0x8EB5", VA = "0x8EB5", Slot = "20")]
			set
			{
			}
		}

		// Token: 0x06003FFC RID: 16380 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003FFC")]
		[Address(RVA = "0x8EB6", Offset = "0x8EB6", VA = "0x8EB6")]
		private void ResetView()
		{
		}

		// Token: 0x06003FFD RID: 16381 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003FFD")]
		[Address(RVA = "0x8EB7", Offset = "0x8EB7", VA = "0x8EB7")]
		private void SetupView()
		{
		}

		// Token: 0x06003FFE RID: 16382 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003FFE")]
		[Address(RVA = "0x8EB8", Offset = "0x8EB8", VA = "0x8EB8")]
		private void WithdrawButtonClickedEventHandler()
		{
		}

		// Token: 0x06003FFF RID: 16383 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003FFF")]
		[Address(RVA = "0x8EB9", Offset = "0x8EB9", VA = "0x8EB9")]
		private void RequestButtonClickedEventHandler()
		{
		}

		// Token: 0x06004000 RID: 16384 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004000")]
		[Address(RVA = "0x8EBA", Offset = "0x8EBA", VA = "0x8EBA")]
		private void ClanInfoButtonClickedEventHandler()
		{
		}

		// Token: 0x06004001 RID: 16385 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004001")]
		[Address(RVA = "0x8EBB", Offset = "0x8EBB", VA = "0x8EBB")]
		private void InfoButtonClickedEventHandler()
		{
		}

		// Token: 0x06004002 RID: 16386 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004002")]
		[Address(RVA = "0x8EBC", Offset = "0x8EBC", VA = "0x8EBC")]
		private void ResetButtonClickedEventHandler()
		{
		}

		// Token: 0x06004003 RID: 16387 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004003")]
		[Address(RVA = "0x8EBD", Offset = "0x8EBD", VA = "0x8EBD")]
		private void SearchButtonClickedEventHandler()
		{
		}

		// Token: 0x06004004 RID: 16388 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004004")]
		[Address(RVA = "0x8EBE", Offset = "0x8EBE", VA = "0x8EBE")]
		private void InputChangedEventHandler(string str)
		{
		}

		// Token: 0x06004005 RID: 16389 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004005")]
		[Address(RVA = "0x8EBF", Offset = "0x8EBF", VA = "0x8EBF")]
		private void AvailableFilterChangedEventHandler()
		{
		}

		// Token: 0x06004006 RID: 16390 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004006")]
		[Address(RVA = "0x8EC0", Offset = "0x8EC0", VA = "0x8EC0")]
		private void FilterSelectedEventHandler(object obj)
		{
		}

		// Token: 0x06004007 RID: 16391 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004007")]
		[Address(RVA = "0x8EC1", Offset = "0x8EC1", VA = "0x8EC1")]
		private void SubRatingSelectedEventHandler(SubRatingListElementArgs subRating)
		{
		}

		// Token: 0x06004008 RID: 16392 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004008")]
		[Address(RVA = "0x8EC2", Offset = "0x8EC2", VA = "0x8EC2")]
		private void MoreItemsBeforeNeededEventHandler()
		{
		}

		// Token: 0x06004009 RID: 16393 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004009")]
		[Address(RVA = "0x8EC3", Offset = "0x8EC3", VA = "0x8EC3")]
		private void MoreItemsAfterNeededEventHandler()
		{
		}

		// Token: 0x0600400A RID: 16394 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600400A")]
		[Address(RVA = "0x8EC4", Offset = "0x8EC4", VA = "0x8EC4")]
		private void ClanListElementClickedEventHandler(ClanInRatingListElement element)
		{
		}

		// Token: 0x17000CAE RID: 3246
		// (set) Token: 0x0600400B RID: 16395 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000CAE")]
		public override ClanOfficeEvents Events
		{
			[Token(Token = "0x600400B")]
			[Address(RVA = "0x8EC5", Offset = "0x8EC5", VA = "0x8EC5", Slot = "16")]
			set
			{
			}
		}

		// Token: 0x0600400C RID: 16396 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600400C")]
		[Address(RVA = "0x8EC6", Offset = "0x8EC6", VA = "0x8EC6")]
		private void JoinRequestCancelledEventHandler()
		{
		}

		// Token: 0x0600400D RID: 16397 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600400D")]
		[Address(RVA = "0x8EC7", Offset = "0x8EC7", VA = "0x8EC7")]
		private void JoinRequestSentEventHandler()
		{
		}

		// Token: 0x0600400E RID: 16398 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600400E")]
		[Address(RVA = "0x8EC8", Offset = "0x8EC8", VA = "0x8EC8")]
		private void FirstVacanciesRequestedEventHandler(uint pageNumber)
		{
		}

		// Token: 0x0600400F RID: 16399 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600400F")]
		[Address(RVA = "0x8EC9", Offset = "0x8EC9", VA = "0x8EC9")]
		private void AdditionalVacanciesRequestedEventHandler(uint pageNumber)
		{
		}

		// Token: 0x06004010 RID: 16400 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004010")]
		[Address(RVA = "0x8ECA", Offset = "0x8ECA", VA = "0x8ECA")]
		private void RequestInjectCallbackEventHandler(uint pageNumber)
		{
		}

		// Token: 0x06004011 RID: 16401 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004011")]
		[Address(RVA = "0x8ECB", Offset = "0x8ECB", VA = "0x8ECB")]
		private void ClanPageRemovedEventHandler(int count, bool fromEnd)
		{
		}

		// Token: 0x06004012 RID: 16402 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004012")]
		[Address(RVA = "0x8ECC", Offset = "0x8ECC", VA = "0x8ECC")]
		private void UpdateRequestedClanView()
		{
		}

		// Token: 0x06004013 RID: 16403 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004013")]
		[Address(RVA = "0x8ECD", Offset = "0x8ECD", VA = "0x8ECD")]
		private void ValidateSearchButton()
		{
		}

		// Token: 0x06004014 RID: 16404 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004014")]
		[Address(RVA = "0x8ECE", Offset = "0x8ECE", VA = "0x8ECE")]
		private void RequestFirstClanVacancies()
		{
		}

		// Token: 0x06004015 RID: 16405 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004015")]
		[Address(RVA = "0x8ECF", Offset = "0x8ECF", VA = "0x8ECF")]
		private void UpdateOSARequestBounds()
		{
		}

		// Token: 0x06004016 RID: 16406 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004016")]
		[Address(RVA = "0x8ED0", Offset = "0x8ED0", VA = "0x8ED0")]
		private void SelectArgs(ClanInRatingListElement.ClanInRatingListElementArgs args)
		{
		}

		// Token: 0x06004017 RID: 16407 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004017")]
		[Address(RVA = "0x8ED1", Offset = "0x8ED1", VA = "0x8ED1")]
		private void UpdateInfoBoxState()
		{
		}

		// Token: 0x06004018 RID: 16408 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6004018")]
		[Address(RVA = "0x8ED2", Offset = "0x8ED2", VA = "0x8ED2")]
		private DialogWindow ShowClanRatingInfoWindow(ClanRatingKindDic dic)
		{
			return null;
		}

		// Token: 0x06004019 RID: 16409 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004019")]
		[Address(RVA = "0x8ED3", Offset = "0x8ED3", VA = "0x8ED3", Slot = "21")]
		public void Hide()
		{
		}

		// Token: 0x040023C5 RID: 9157
		[Token(Token = "0x40023C5")]
		[FieldOffset(Offset = "0x18")]
		private ClanInRatingListElement.ClanInRatingListElementArgs _selectedArgs;

		// Token: 0x040023C6 RID: 9158
		[Token(Token = "0x40023C6")]
		[FieldOffset(Offset = "0x1C")]
		private ClanRatingTypes _ratingType;

		// Token: 0x040023C7 RID: 9159
		[Token(Token = "0x40023C7")]
		[FieldOffset(Offset = "0x20")]
		private RatingPeriods _ratingPeriod;

		// Token: 0x040023C8 RID: 9160
		[Token(Token = "0x40023C8")]
		[FieldOffset(Offset = "0x24")]
		private string _searchValue;
	}
}
