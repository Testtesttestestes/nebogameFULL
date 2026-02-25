using System;
using System.Collections.Generic;
using Gameplay.VortexRating.View.GreatPrizesTab;
using Gameplay.WorldAxis.Office.Events;
using Gameplay.WorldAxis.Office.Model;
using Gameplay.WorldAxis.Office.View.Rewards;
using Il2CppDummyDll;
using MVC;
using MVC.Interfaces;
using Protocol.Dic;

namespace Gameplay.WorldAxis.Office.Controller
{
	// Token: 0x020002E1 RID: 737
	[Token(Token = "0x20002E1")]
	public class SeasonRewardsViewMediator : AbstractViewMediator<SeasonRewardsModel, WorldAxisOfficeEvents, WorldAxisOfficeController, SeasonRewardsView>, IHideableMediator
	{
		// Token: 0x0600116E RID: 4462 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600116E")]
		[Address(RVA = "0x636B", Offset = "0x636B", VA = "0x636B")]
		public SeasonRewardsViewMediator(SeasonRewardsModel model, WorldAxisOfficeEvents events, WorldAxisOfficeController controller)
		{
		}

		// Token: 0x17000292 RID: 658
		// (get) Token: 0x0600116F RID: 4463 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06001170 RID: 4464 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000292")]
		private PrizeListElement[] ListElements
		{
			[Token(Token = "0x600116F")]
			[Address(RVA = "0x636C", Offset = "0x636C", VA = "0x636C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001170")]
			[Address(RVA = "0x636D", Offset = "0x636D", VA = "0x636D")]
			set
			{
			}
		}

		// Token: 0x17000293 RID: 659
		// (set) Token: 0x06001171 RID: 4465 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000293")]
		public override SeasonRewardsView View
		{
			[Token(Token = "0x6001171")]
			[Address(RVA = "0x636E", Offset = "0x636E", VA = "0x636E", Slot = "20")]
			set
			{
			}
		}

		// Token: 0x06001172 RID: 4466 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001172")]
		[Address(RVA = "0x636F", Offset = "0x636F", VA = "0x636F")]
		private void Init()
		{
		}

		// Token: 0x06001173 RID: 4467 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001173")]
		[Address(RVA = "0x6370", Offset = "0x6370", VA = "0x6370")]
		private void TabBarChangedEventHandler()
		{
		}

		// Token: 0x06001174 RID: 4468 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001174")]
		[Address(RVA = "0x6371", Offset = "0x6371", VA = "0x6371")]
		private void PeriodFilterSelectedEventHandler(object obj)
		{
		}

		// Token: 0x06001175 RID: 4469 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001175")]
		[Address(RVA = "0x6372", Offset = "0x6372", VA = "0x6372")]
		private void RenderElements(IList<RatingPrizeDic> prizes, string period)
		{
		}

		// Token: 0x06001176 RID: 4470 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001176")]
		[Address(RVA = "0x6373", Offset = "0x6373", VA = "0x6373")]
		private void RenderClanElements(IList<RatingPrizeDic> prizes, string period)
		{
		}

		// Token: 0x06001177 RID: 4471 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001177")]
		[Address(RVA = "0x6374", Offset = "0x6374", VA = "0x6374")]
		private void PrizeListElementClickedEventHandler(PrizeListElement element)
		{
		}

		// Token: 0x06001178 RID: 4472 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001178")]
		[Address(RVA = "0x6375", Offset = "0x6375", VA = "0x6375")]
		private void SelectElement(PrizeListElement element)
		{
		}

		// Token: 0x06001179 RID: 4473 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001179")]
		[Address(RVA = "0x6376", Offset = "0x6376", VA = "0x6376", Slot = "21")]
		public void Hide()
		{
		}

		// Token: 0x040008FD RID: 2301
		[Token(Token = "0x40008FD")]
		[FieldOffset(Offset = "0x18")]
		private PrizeListElement _selectedElement;

		// Token: 0x040008FE RID: 2302
		[Token(Token = "0x40008FE")]
		[FieldOffset(Offset = "0x1C")]
		private PrizeListElement[] _listElements;
	}
}
