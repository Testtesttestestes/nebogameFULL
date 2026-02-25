using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Core.Gameplay.Managers.Ad.Providers;
using Gameplay.Bank.Model;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using Utils.Cache;

namespace Gameplay.Bank.View
{
	// Token: 0x02000C40 RID: 3136
	[Token(Token = "0x2000C40")]
	public class BankOptionsListView : MonoBehaviour
	{
		// Token: 0x140001DB RID: 475
		// (add) Token: 0x06004C7A RID: 19578 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06004C7B RID: 19579 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140001DB")]
		public event Action<IBankOptionView> BuyButtonClickedEvent
		{
			[Token(Token = "0x6004C7A")]
			[Address(RVA = "0x9ABB", Offset = "0x9ABB", VA = "0x9ABB")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6004C7B")]
			[Address(RVA = "0x9ABC", Offset = "0x9ABC", VA = "0x9ABC")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x140001DC RID: 476
		// (add) Token: 0x06004C7C RID: 19580 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06004C7D RID: 19581 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140001DC")]
		public event Action<BankOptionView> FaqButtonClickedEvent
		{
			[Token(Token = "0x6004C7C")]
			[Address(RVA = "0x9ABD", Offset = "0x9ABD", VA = "0x9ABD")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6004C7D")]
			[Address(RVA = "0x9ABE", Offset = "0x9ABE", VA = "0x9ABE")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x06004C7E RID: 19582 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004C7E")]
		[Address(RVA = "0x9ABF", Offset = "0x9ABF", VA = "0x9ABF")]
		private void Awake()
		{
		}

		// Token: 0x06004C7F RID: 19583 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004C7F")]
		[Address(RVA = "0x9AC0", Offset = "0x9AC0", VA = "0x9AC0")]
		private void OnReleaseBankOptionView(BankOptionView pooledObject)
		{
		}

		// Token: 0x06004C80 RID: 19584 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004C80")]
		[Address(RVA = "0x9AC1", Offset = "0x9AC1", VA = "0x9AC1")]
		public void Init(IOptionValidator optionValidator, IAdPlacementManagerProvider provider)
		{
		}

		// Token: 0x17000F6B RID: 3947
		// (get) Token: 0x06004C81 RID: 19585 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06004C82 RID: 19586 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000F6B")]
		public IList<BankOptionData> Data
		{
			[Token(Token = "0x6004C81")]
			[Address(RVA = "0x9AC2", Offset = "0x9AC2", VA = "0x9AC2")]
			get
			{
				return null;
			}
			[Token(Token = "0x6004C82")]
			[Address(RVA = "0x9AC3", Offset = "0x9AC3", VA = "0x9AC3")]
			set
			{
			}
		}

		// Token: 0x17000F6C RID: 3948
		// (get) Token: 0x06004C83 RID: 19587 RVA: 0x0000E100 File Offset: 0x0000C300
		// (set) Token: 0x06004C84 RID: 19588 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000F6C")]
		public Vector2 ScrollPosition
		{
			[Token(Token = "0x6004C83")]
			[Address(RVA = "0x9AC4", Offset = "0x9AC4", VA = "0x9AC4")]
			get
			{
				return default(Vector2);
			}
			[Token(Token = "0x6004C84")]
			[Address(RVA = "0x9AC5", Offset = "0x9AC5", VA = "0x9AC5")]
			private set
			{
			}
		}

		// Token: 0x06004C85 RID: 19589 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004C85")]
		[Address(RVA = "0x9AC6", Offset = "0x9AC6", VA = "0x9AC6")]
		public void SetScrollPosition(Vector2 position)
		{
		}

		// Token: 0x06004C86 RID: 19590 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004C86")]
		[Address(RVA = "0x9AC7", Offset = "0x9AC7", VA = "0x9AC7")]
		private void ViewOnFaqButtonClickEvent(BankOptionView target)
		{
		}

		// Token: 0x06004C87 RID: 19591 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004C87")]
		[Address(RVA = "0x9AC8", Offset = "0x9AC8", VA = "0x9AC8")]
		private void ViewOnBuyButtonClickEvent(IBankOptionView target)
		{
		}

		// Token: 0x06004C88 RID: 19592 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004C88")]
		[Address(RVA = "0x9AC9", Offset = "0x9AC9", VA = "0x9AC9")]
		private void OnDestroy()
		{
		}

		// Token: 0x06004C89 RID: 19593 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004C89")]
		[Address(RVA = "0x9ACA", Offset = "0x9ACA", VA = "0x9ACA")]
		public BankOptionsListView()
		{
		}

		// Token: 0x040029BE RID: 10686
		[Token(Token = "0x40029BE")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private Transform _container;

		// Token: 0x040029BF RID: 10687
		[Token(Token = "0x40029BF")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private ScrollRect _scrollRect;

		// Token: 0x040029C0 RID: 10688
		[Token(Token = "0x40029C0")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private BankOptionView _bankOptionViewPrefab;

		// Token: 0x040029C1 RID: 10689
		[Token(Token = "0x40029C1")]
		[FieldOffset(Offset = "0x1C")]
		private IList<BankOptionData> _data;

		// Token: 0x040029C2 RID: 10690
		[Token(Token = "0x40029C2")]
		[FieldOffset(Offset = "0x20")]
		private IOptionValidator _optionValidator;

		// Token: 0x040029C3 RID: 10691
		[Token(Token = "0x40029C3")]
		[FieldOffset(Offset = "0x24")]
		private IAdPlacementManagerProvider _placementManagerProvider;

		// Token: 0x040029C4 RID: 10692
		[Token(Token = "0x40029C4")]
		[FieldOffset(Offset = "0x28")]
		private GameObjectPool<BankOptionView> _bankOptionViewPool;

		// Token: 0x040029C5 RID: 10693
		[Token(Token = "0x40029C5")]
		[FieldOffset(Offset = "0x2C")]
		private List<BankOptionView> _currentViews;
	}
}
