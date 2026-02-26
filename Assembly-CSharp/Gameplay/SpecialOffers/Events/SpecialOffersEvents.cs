using System;
using Il2CppDummyDll;

namespace Gameplay.SpecialOffers.Events
{
	// Token: 0x02000508 RID: 1288
	[Token(Token = "0x2000508")]
	public class SpecialOffersEvents : OptionsOfferEvents
	{
		// Token: 0x06001EBB RID: 7867 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001EBB")]
		[Address(RVA = "0x702E", Offset = "0x702E", VA = "0x702E")]
		public SpecialOffersEvents()
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_SpecialOffers_Events_SpecialOffersEvents___ctor
		               (undefined4 param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  if (DAT_ram_00a5863b == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_SpecialOffers_Controller_OptionsOfferControllerBase_OptionsOfferModel__OptionsOfferEvents___ctor__
		              );
		    DAT_ram_00a5863b = '\x01';
		  }
		  UI_Windows_Buildings_BaseIsleBuildingWindowArgs___Il2CppFullySharedGenericType____ctor
		            (param1,param2,param3,
		             Method_Gameplay_SpecialOffers_Controller_OptionsOfferControllerBase_OptionsOfferModel__OptionsOfferEvents___ctor__
		            );
		  return;
		}
		*/

		}

		// Token: 0x040010B0 RID: 4272
		[Token(Token = "0x40010B0")]
		[FieldOffset(Offset = "0x14")]
		public Action SpecialOffersRequestedEvent;

		// Token: 0x040010B1 RID: 4273
		[Token(Token = "0x40010B1")]
		[FieldOffset(Offset = "0x18")]
		public Action UnseenOptionsCountChangedEvent;

		// Token: 0x040010B2 RID: 4274
		[Token(Token = "0x40010B2")]
		[FieldOffset(Offset = "0x1C")]
		public Action UserTriggersChangedEvent;

		// Token: 0x040010B3 RID: 4275
		[Token(Token = "0x40010B3")]
		[FieldOffset(Offset = "0x20")]
		public Action NeedValidateEntryPointEvent;
	}
}
