using System;
using Gameplay.SpecialOffers.Events;
using Gameplay.SpecialOffers.Model;
using Il2CppDummyDll;

namespace Gameplay.SpecialOffers.Controller
{
	// Token: 0x02000509 RID: 1289
	[Token(Token = "0x2000509")]
	public class OptionsOfferController : OptionsOfferControllerBase<OptionsOfferModel, OptionsOfferEvents>
	{
		// Token: 0x06001EBC RID: 7868 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001EBC")]
		[Address(RVA = "0x702F", Offset = "0x702F", VA = "0x702F")]
		public OptionsOfferController(OptionsOfferModel model, OptionsOfferEvents events)
		{
		}

		// Token: 0x06001EBD RID: 7869 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001EBD")]
		[Address(RVA = "0x7030", Offset = "0x7030", VA = "0x7030", Slot = "7")]
		protected override void HandleRun()
		{
		}
	}
}
