using System;
using Gameplay.SpecialOffers.Events;
using Gameplay.SpecialOffers.Model;
using Il2CppDummyDll;
using MVC;

namespace Gameplay.SpecialOffers.Controller
{
	// Token: 0x0200050B RID: 1291
	[Token(Token = "0x200050B")]
	public abstract class OptionsOfferControllerBase<M, E> : AbstractController<M, E> where M : OptionsOfferModel where E : OptionsOfferEvents
	{
		// Token: 0x06001EC1 RID: 7873 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001EC1")]
		public OptionsOfferControllerBase(M model, E events)
		{
		}
	}
}
