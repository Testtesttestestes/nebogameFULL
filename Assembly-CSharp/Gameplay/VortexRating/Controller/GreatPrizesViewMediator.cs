using System;
using Gameplay.VortexRating.Events;
using Gameplay.VortexRating.Model;
using Gameplay.VortexRating.View.GreatPrizesTab;
using Il2CppDummyDll;
using MVC;
using MVC.Interfaces;

namespace Gameplay.VortexRating.Controller
{
	// Token: 0x0200039B RID: 923
	[Token(Token = "0x200039B")]
	public class GreatPrizesViewMediator : AbstractViewMediator<VortexRatingModel, VortexRatingEvents, VortexRatingController, GreatPrizesView>, IHideableMediator
	{
		// Token: 0x06001578 RID: 5496 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001578")]
		[Address(RVA = "0x673A", Offset = "0x673A", VA = "0x673A")]
		public GreatPrizesViewMediator(VortexRatingModel model, VortexRatingEvents events, VortexRatingController controller)
		{
		}

		// Token: 0x1700038E RID: 910
		// (get) Token: 0x06001579 RID: 5497 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600157A RID: 5498 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700038E")]
		private PrizeListElement[] ListElements
		{
			[Token(Token = "0x6001579")]
			[Address(RVA = "0x673B", Offset = "0x673B", VA = "0x673B")]
			get
			{
				return null;
			}
			[Token(Token = "0x600157A")]
			[Address(RVA = "0x673C", Offset = "0x673C", VA = "0x673C")]
			set
			{
			}
		}

		// Token: 0x1700038F RID: 911
		// (set) Token: 0x0600157B RID: 5499 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700038F")]
		public override GreatPrizesView View
		{
			[Token(Token = "0x600157B")]
			[Address(RVA = "0x673D", Offset = "0x673D", VA = "0x673D", Slot = "20")]
			set
			{
			}
		}

		// Token: 0x0600157C RID: 5500 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600157C")]
		[Address(RVA = "0x673E", Offset = "0x673E", VA = "0x673E")]
		private void Init()
		{
		}

		// Token: 0x0600157D RID: 5501 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600157D")]
		[Address(RVA = "0x673F", Offset = "0x673F", VA = "0x673F")]
		private void FilterSelectedEventHandler(object obj)
		{
		}

		// Token: 0x0600157E RID: 5502 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600157E")]
		[Address(RVA = "0x6740", Offset = "0x6740", VA = "0x6740")]
		private void PrizeListElementClickedEventHandler(PrizeListElement element)
		{
		}

		// Token: 0x0600157F RID: 5503 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600157F")]
		[Address(RVA = "0x6741", Offset = "0x6741", VA = "0x6741")]
		private void SelectElement(PrizeListElement element)
		{
		}

		// Token: 0x06001580 RID: 5504 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001580")]
		[Address(RVA = "0x6742", Offset = "0x6742", VA = "0x6742")]
		private void InVortexButtonClickedEventHandler()
		{
		}

		// Token: 0x06001581 RID: 5505 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001581")]
		[Address(RVA = "0x6743", Offset = "0x6743", VA = "0x6743", Slot = "21")]
		public void Hide()
		{
		}

		// Token: 0x04000B6C RID: 2924
		[Token(Token = "0x4000B6C")]
		[FieldOffset(Offset = "0x18")]
		private PrizeListElement _selectedElement;

		// Token: 0x04000B6D RID: 2925
		[Token(Token = "0x4000B6D")]
		[FieldOffset(Offset = "0x1C")]
		private PrizeListElement[] _listElements;
	}
}
