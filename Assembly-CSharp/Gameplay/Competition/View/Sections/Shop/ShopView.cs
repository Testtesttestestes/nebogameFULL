using System;
using System.Runtime.CompilerServices;
using Core.MVC.Interfaces;
using Gameplay.Bank.Model;
using Gameplay.Bank.View;
using Gameplay.Competition.Control.Sections;
using Gameplay.Competition.Events;
using Gameplay.Competition.Model;
using Il2CppDummyDll;
using MVC;
using UnityEngine;

namespace Gameplay.Competition.View.Sections.Shop
{
	// Token: 0x020008E5 RID: 2277
	[Token(Token = "0x20008E5")]
	[AddComponentMenu("Competition/View/Sections/ShopView")]
	public class ShopView : BaseSectionView<ShopController>
	{
		// Token: 0x14000171 RID: 369
		// (add) Token: 0x060035A6 RID: 13734 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060035A7 RID: 13735 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000171")]
		public event Action<BankOptionData> BuyEvent
		{
			[Token(Token = "0x60035A6")]
			[Address(RVA = "0x85B4", Offset = "0x85B4", VA = "0x85B4")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60035A7")]
			[Address(RVA = "0x85B5", Offset = "0x85B5", VA = "0x85B5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x17000AA3 RID: 2723
		// (get) Token: 0x060035A8 RID: 13736 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000AA3")]
		public BankOptionsListView BankOptionsListView
		{
			[Token(Token = "0x60035A8")]
			[Address(RVA = "0x85B6", Offset = "0x85B6", VA = "0x85B6")]
			get
			{
				return null;
			}
		}

		// Token: 0x060035A9 RID: 13737 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60035A9")]
		[Address(RVA = "0x85B7", Offset = "0x85B7", VA = "0x85B7", Slot = "6")]
		protected override void CreateController(CompetitionModel model, CompetitionEvents events, out ShopController controller)
		{
		}

		// Token: 0x060035AA RID: 13738 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60035AA")]
		[Address(RVA = "0x85B8", Offset = "0x85B8", VA = "0x85B8", Slot = "7")]
		protected override void CreateMediator(ShopController controller, out IViewMediator mediator)
		{
		}

		// Token: 0x060035AB RID: 13739 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60035AB")]
		[Address(RVA = "0x85B9", Offset = "0x85B9", VA = "0x85B9", Slot = "8")]
		protected override void RunController(ShopController controller, out AbstractMVCEvents events)
		{
		}

		// Token: 0x060035AC RID: 13740 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60035AC")]
		[Address(RVA = "0x85BA", Offset = "0x85BA", VA = "0x85BA")]
		public ShopView()
		{
		}

		// Token: 0x04001D5A RID: 7514
		[Token(Token = "0x4001D5A")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private BankOptionsListView _bankOptionsListView;
	}
}
