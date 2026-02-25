using System;
using Gameplay.Competition.Events;
using Gameplay.Competition.Model;
using Gameplay.Competition.View.Sections;
using Gameplay.VortexRating.View.GreatPrizesTab;
using Il2CppDummyDll;
using MVC;

namespace Gameplay.Competition.Control.Sections
{
	// Token: 0x0200090E RID: 2318
	[Token(Token = "0x200090E")]
	public class RewardsViewMediator : AbstractCozyViewMediator<RewardsModel, RewardsEvents, RewardsController, RewardsView>
	{
		// Token: 0x0600367C RID: 13948 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600367C")]
		[Address(RVA = "0x8689", Offset = "0x8689", VA = "0x8689")]
		public RewardsViewMediator(RewardsView view, RewardsModel model, RewardsEvents events, RewardsController controller)
		{
		}

		// Token: 0x17000ABE RID: 2750
		// (get) Token: 0x0600367D RID: 13949 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600367E RID: 13950 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000ABE")]
		private PrizeListElement[] ListElements
		{
			[Token(Token = "0x600367D")]
			[Address(RVA = "0x868A", Offset = "0x868A", VA = "0x868A")]
			get
			{
				return null;
			}
			[Token(Token = "0x600367E")]
			[Address(RVA = "0x868B", Offset = "0x868B", VA = "0x868B")]
			set
			{
			}
		}

		// Token: 0x0600367F RID: 13951 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600367F")]
		[Address(RVA = "0x868C", Offset = "0x868C", VA = "0x868C", Slot = "21")]
		protected override void ResetEvents(RewardsEvents events)
		{
		}

		// Token: 0x06003680 RID: 13952 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003680")]
		[Address(RVA = "0x868D", Offset = "0x868D", VA = "0x868D", Slot = "22")]
		protected override void SetupEvents(RewardsEvents events)
		{
		}

		// Token: 0x06003681 RID: 13953 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003681")]
		[Address(RVA = "0x868E", Offset = "0x868E", VA = "0x868E", Slot = "23")]
		protected override void ResetView(RewardsView view)
		{
		}

		// Token: 0x06003682 RID: 13954 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003682")]
		[Address(RVA = "0x868F", Offset = "0x868F", VA = "0x868F", Slot = "24")]
		protected override void SetupView(RewardsView view)
		{
		}

		// Token: 0x06003683 RID: 13955 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003683")]
		[Address(RVA = "0x8690", Offset = "0x8690", VA = "0x8690")]
		private void PrizeListElementClickedEventHandler(PrizeListElement element)
		{
		}

		// Token: 0x06003684 RID: 13956 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003684")]
		[Address(RVA = "0x8691", Offset = "0x8691", VA = "0x8691")]
		private void SelectElement(PrizeListElement element)
		{
		}

		// Token: 0x04001DE0 RID: 7648
		[Token(Token = "0x4001DE0")]
		[FieldOffset(Offset = "0x18")]
		private PrizeListElement _selectedElement;

		// Token: 0x04001DE1 RID: 7649
		[Token(Token = "0x4001DE1")]
		[FieldOffset(Offset = "0x1C")]
		private PrizeListElement[] _listElements;
	}
}
