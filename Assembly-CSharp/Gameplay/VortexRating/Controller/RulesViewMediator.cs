using System;
using Gameplay.VortexRating.Events;
using Gameplay.VortexRating.Model;
using Gameplay.VortexRating.View.RulesTab;
using Il2CppDummyDll;
using MVC;
using MVC.Interfaces;

namespace Gameplay.VortexRating.Controller
{
	// Token: 0x0200039E RID: 926
	[Token(Token = "0x200039E")]
	public class RulesViewMediator : AbstractViewMediator<VortexRatingModel, VortexRatingEvents, VortexRatingController, RulesView>, IHideableMediator
	{
		// Token: 0x06001587 RID: 5511 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001587")]
		[Address(RVA = "0x6749", Offset = "0x6749", VA = "0x6749")]
		public RulesViewMediator(VortexRatingModel model, VortexRatingEvents events, VortexRatingController controller)
		{
		}

		// Token: 0x17000390 RID: 912
		// (set) Token: 0x06001588 RID: 5512 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000390")]
		public override RulesView View
		{
			[Token(Token = "0x6001588")]
			[Address(RVA = "0x674A", Offset = "0x674A", VA = "0x674A", Slot = "20")]
			set
			{
			}
		}

		// Token: 0x06001589 RID: 5513 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001589")]
		[Address(RVA = "0x674B", Offset = "0x674B", VA = "0x674B", Slot = "21")]
		public void Hide()
		{
		}
	}
}
