using System;
using Gameplay.Competition.Events;
using Gameplay.Competition.Model;
using Il2CppDummyDll;
using MVC;

namespace Gameplay.Competition.Control.Sections
{
	// Token: 0x0200090D RID: 2317
	[Token(Token = "0x200090D")]
	public class RewardsController : AbstractController<RewardsModel, RewardsEvents>
	{
		// Token: 0x0600367A RID: 13946 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600367A")]
		[Address(RVA = "0x8687", Offset = "0x8687", VA = "0x8687")]
		public RewardsController(RewardsModel model, RewardsEvents events)
		{
		}

		// Token: 0x0600367B RID: 13947 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600367B")]
		[Address(RVA = "0x8688", Offset = "0x8688", VA = "0x8688", Slot = "7")]
		protected override void HandleRun()
		{
		}
	}
}
