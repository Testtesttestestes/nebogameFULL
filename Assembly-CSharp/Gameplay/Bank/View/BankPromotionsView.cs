using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Gameplay.Bank.Controller;
using Il2CppDummyDll;
using Protocol.Dic;
using UnityEngine;

namespace Gameplay.Bank.View
{
	// Token: 0x02000C48 RID: 3144
	[Token(Token = "0x2000C48")]
	public class BankPromotionsView : MonoBehaviour
	{
		// Token: 0x140001DE RID: 478
		// (add) Token: 0x06004CAC RID: 19628 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06004CAD RID: 19629 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140001DE")]
		public event Action<PromotionsDic> ShowInfoEvent
		{
			[Token(Token = "0x6004CAC")]
			[Address(RVA = "0x9AED", Offset = "0x9AED", VA = "0x9AED")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6004CAD")]
			[Address(RVA = "0x9AEE", Offset = "0x9AEE", VA = "0x9AEE")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x06004CAE RID: 19630 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004CAE")]
		[Address(RVA = "0x9AEF", Offset = "0x9AEF", VA = "0x9AEF")]
		private void Start()
		{
		}

		// Token: 0x06004CAF RID: 19631 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004CAF")]
		[Address(RVA = "0x9AF0", Offset = "0x9AF0", VA = "0x9AF0")]
		private void OnDestroy()
		{
		}

		// Token: 0x06004CB0 RID: 19632 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004CB0")]
		[Address(RVA = "0x9AF1", Offset = "0x9AF1", VA = "0x9AF1")]
		public void ShowPromotions(List<PromotionsDic> promotions)
		{
		}

		// Token: 0x06004CB1 RID: 19633 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004CB1")]
		[Address(RVA = "0x9AF2", Offset = "0x9AF2", VA = "0x9AF2")]
		private void PromotionViewOnInfoButtonClickedEvent(PromotionsDic data)
		{
		}

		// Token: 0x06004CB2 RID: 19634 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004CB2")]
		[Address(RVA = "0x9AF3", Offset = "0x9AF3", VA = "0x9AF3")]
		public BankPromotionsView()
		{
		}

		// Token: 0x040029DC RID: 10716
		[Token(Token = "0x40029DC")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private BankGalleryView _bankGallery;

		// Token: 0x040029DD RID: 10717
		[Token(Token = "0x40029DD")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private BankPromotionView _promotionPrefab;

		// Token: 0x040029DE RID: 10718
		[Token(Token = "0x40029DE")]
		[FieldOffset(Offset = "0x18")]
		private BankPromotionsViewMediator _mediator;

		// Token: 0x040029E0 RID: 10720
		[Token(Token = "0x40029E0")]
		[FieldOffset(Offset = "0x20")]
		private List<BankPromotionView> _promotions;
	}
}
