using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Gameplay.Accounts.Model.Data;
using Gameplay.Bank.View;
using Il2CppDummyDll;
using UnityEngine;
using Utils;

namespace Gameplay.Accounts.View
{
	// Token: 0x02000DCA RID: 3530
	[Token(Token = "0x2000DCA")]
	public class AccountsListView : MonoBehaviour
	{
		// Token: 0x1700117E RID: 4478
		// (get) Token: 0x06005617 RID: 22039 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700117E")]
		public BankPromotionView PromotionView
		{
			[Token(Token = "0x6005617")]
			[Address(RVA = "0xA3B6", Offset = "0xA3B6", VA = "0xA3B6")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700117F RID: 4479
		// (get) Token: 0x06005618 RID: 22040 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700117F")]
		public MonoPointerClickHandler PromotionClickHandler
		{
			[Token(Token = "0x6005618")]
			[Address(RVA = "0xA3B7", Offset = "0xA3B7", VA = "0xA3B7")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001180 RID: 4480
		// (get) Token: 0x06005619 RID: 22041 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17001180")]
		public List<AccountsListItemView> ItemViews
		{
			[Token(Token = "0x6005619")]
			[Address(RVA = "0xA3B8", Offset = "0xA3B8", VA = "0xA3B8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x14000204 RID: 516
		// (add) Token: 0x0600561A RID: 22042 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600561B RID: 22043 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000204")]
		public event Action<IAccountDataDecorator> ClickOnItem
		{
			[Token(Token = "0x600561A")]
			[Address(RVA = "0xA3B9", Offset = "0xA3B9", VA = "0xA3B9")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600561B")]
			[Address(RVA = "0xA3BA", Offset = "0xA3BA", VA = "0xA3BA")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x0600561C RID: 22044 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600561C")]
		[Address(RVA = "0xA3BB", Offset = "0xA3BB", VA = "0xA3BB")]
		private void OnDestroy()
		{
		}

		// Token: 0x0600561D RID: 22045 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600561D")]
		[Address(RVA = "0xA3BC", Offset = "0xA3BC", VA = "0xA3BC")]
		public void SetItems(IEnumerable<IAccountDataDecorator> items)
		{
		}

		// Token: 0x0600561E RID: 22046 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600561E")]
		[Address(RVA = "0xA3BD", Offset = "0xA3BD", VA = "0xA3BD")]
		private void HandleItemSelectEvent(IAccountDataDecorator accountDataDecorator)
		{
		}

		// Token: 0x17001181 RID: 4481
		// (get) Token: 0x0600561F RID: 22047 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17001181")]
		public Dictionary<Type, AccountsListItemView> MapOfListItemPrefabs
		{
			[Token(Token = "0x600561F")]
			[Address(RVA = "0x1D31", Offset = "0x1D31", VA = "0x1D31")]
			get
			{
				return null;
			}
		}

		// Token: 0x06005620 RID: 22048 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005620")]
		[Address(RVA = "0xA3BE", Offset = "0xA3BE", VA = "0xA3BE")]
		public AccountsListItemView GetListITemPrefab(IAccountDataDecorator account)
		{
			return null;
		}

		// Token: 0x06005621 RID: 22049 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005621")]
		[Address(RVA = "0xA3BF", Offset = "0xA3BF", VA = "0xA3BF")]
		public AccountsListView()
		{
		}

		// Token: 0x04002EB0 RID: 11952
		[Token(Token = "0x4002EB0")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private AccountsListItemView _defaultListItemPrefab;

		// Token: 0x04002EB1 RID: 11953
		[Token(Token = "0x4002EB1")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private AccountsListItemView _clanListItemPrefab;

		// Token: 0x04002EB2 RID: 11954
		[Token(Token = "0x4002EB2")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Transform _itemsContainer;

		// Token: 0x04002EB3 RID: 11955
		[Token(Token = "0x4002EB3")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private BankPromotionView _promotion;

		// Token: 0x04002EB4 RID: 11956
		[Token(Token = "0x4002EB4")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private MonoPointerClickHandler _promotionClickHandler;

		// Token: 0x04002EB7 RID: 11959
		[Token(Token = "0x4002EB7")]
		[FieldOffset(Offset = "0x2C")]
		private Dictionary<Type, AccountsListItemView> _mapOfListItemPrefabs;
	}
}
