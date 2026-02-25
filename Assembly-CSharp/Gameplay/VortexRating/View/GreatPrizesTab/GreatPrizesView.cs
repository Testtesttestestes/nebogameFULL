using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Protocol.Dic;
using UI.Elements.Buttons;
using UI.Rewards;
using UnityEngine;

namespace Gameplay.VortexRating.View.GreatPrizesTab
{
	// Token: 0x0200038F RID: 911
	[Token(Token = "0x200038F")]
	public class GreatPrizesView : MonoBehaviour
	{
		// Token: 0x1700037B RID: 891
		// (get) Token: 0x0600152E RID: 5422 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700037B")]
		public RewardsRender RewardsView
		{
			[Token(Token = "0x600152E")]
			[Address(RVA = "0x66F0", Offset = "0x66F0", VA = "0x66F0")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700037C RID: 892
		// (get) Token: 0x0600152F RID: 5423 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700037C")]
		public GenericListFilter FilterView
		{
			[Token(Token = "0x600152F")]
			[Address(RVA = "0x66F1", Offset = "0x66F1", VA = "0x66F1")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700037D RID: 893
		// (get) Token: 0x06001530 RID: 5424 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700037D")]
		public ButtonWithCost InVortexButton
		{
			[Token(Token = "0x6001530")]
			[Address(RVA = "0x66F2", Offset = "0x66F2", VA = "0x66F2")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001531 RID: 5425 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6001531")]
		[Address(RVA = "0x66F3", Offset = "0x66F3", VA = "0x66F3")]
		public PrizeListElement[] Init(IList<RatingPrizeDic> prizes, string period)
		{
			return null;
		}

		// Token: 0x06001532 RID: 5426 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001532")]
		[Address(RVA = "0x66F4", Offset = "0x66F4", VA = "0x66F4")]
		public GreatPrizesView()
		{
		}

		// Token: 0x04000B40 RID: 2880
		[Token(Token = "0x4000B40")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private PrizeListElement _prizeListElementPrefab;

		// Token: 0x04000B41 RID: 2881
		[Token(Token = "0x4000B41")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private RectTransform _content;

		// Token: 0x04000B42 RID: 2882
		[Token(Token = "0x4000B42")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private RewardsRender _rewardsView;

		// Token: 0x04000B43 RID: 2883
		[Token(Token = "0x4000B43")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private GenericListFilter _filterView;

		// Token: 0x04000B44 RID: 2884
		[Token(Token = "0x4000B44")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private ButtonWithCost _inVortexButton;
	}
}
