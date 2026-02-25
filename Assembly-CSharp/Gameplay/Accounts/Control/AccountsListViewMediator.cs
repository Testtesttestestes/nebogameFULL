using System;
using System.Collections.Generic;
using Gameplay.Accounts.Model;
using Gameplay.Accounts.Model.Data;
using Gameplay.Accounts.View;
using Il2CppDummyDll;
using MVC;
using Protocol.Dic;
using UnityEngine.EventSystems;

namespace Gameplay.Accounts.Control
{
	// Token: 0x02000DE9 RID: 3561
	[Token(Token = "0x2000DE9")]
	public class AccountsListViewMediator : AbstractCozyViewMediator<AccountsModel, AccountsEvents, AccountsController, AccountsListView>
	{
		// Token: 0x060056EC RID: 22252 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60056EC")]
		[Address(RVA = "0xA469", Offset = "0xA469", VA = "0xA469")]
		public AccountsListViewMediator(AccountsListView view, AccountsModel model, AccountsEvents events, AccountsController controller)
		{
		}

		// Token: 0x060056ED RID: 22253 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60056ED")]
		[Address(RVA = "0xA46A", Offset = "0xA46A", VA = "0xA46A", Slot = "21")]
		protected override void ResetEvents(AccountsEvents events)
		{
		}

		// Token: 0x060056EE RID: 22254 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60056EE")]
		[Address(RVA = "0xA46B", Offset = "0xA46B", VA = "0xA46B", Slot = "22")]
		protected override void SetupEvents(AccountsEvents events)
		{
		}

		// Token: 0x060056EF RID: 22255 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60056EF")]
		[Address(RVA = "0xA46C", Offset = "0xA46C", VA = "0xA46C", Slot = "23")]
		protected override void ResetView(AccountsListView view)
		{
		}

		// Token: 0x060056F0 RID: 22256 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60056F0")]
		[Address(RVA = "0xA46D", Offset = "0xA46D", VA = "0xA46D", Slot = "24")]
		protected override void SetupView(AccountsListView view)
		{
		}

		// Token: 0x060056F1 RID: 22257 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60056F1")]
		[Address(RVA = "0xA46E", Offset = "0xA46E", VA = "0xA46E")]
		private void HandleAccountChangedEvent(IAccountDataDecorator account)
		{
		}

		// Token: 0x060056F2 RID: 22258 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60056F2")]
		[Address(RVA = "0xA46F", Offset = "0xA46F", VA = "0xA46F")]
		private void HandlePromotionUpdateCompleteEvent()
		{
		}

		// Token: 0x060056F3 RID: 22259 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60056F3")]
		[Address(RVA = "0xA470", Offset = "0xA470", VA = "0xA470")]
		private void AccountStickerChangedEvent(IList<IAccountDataDecorator> list)
		{
		}

		// Token: 0x060056F4 RID: 22260 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60056F4")]
		[Address(RVA = "0xA471", Offset = "0xA471", VA = "0xA471")]
		private void HandleItemClickEvent(IAccountDataDecorator account)
		{
		}

		// Token: 0x060056F5 RID: 22261 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60056F5")]
		[Address(RVA = "0xA472", Offset = "0xA472", VA = "0xA472")]
		private void HandlePromotionInfoButtonClickedEvent(PromotionsDic promotionsDic)
		{
		}

		// Token: 0x060056F6 RID: 22262 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60056F6")]
		[Address(RVA = "0xA473", Offset = "0xA473", VA = "0xA473")]
		private void HandlePromotionClickEvent(PointerEventData obj)
		{
		}
	}
}
