using System;
using Gameplay.SpecialOffers.Events;
using Gameplay.SpecialOffers.Model;
using Gameplay.SpecialOffers.View;
using Il2CppDummyDll;

namespace Gameplay.SpecialOffers.Controller
{
	// Token: 0x0200050C RID: 1292
	[Token(Token = "0x200050C")]
	public class OptionsOfferViewMediator : OptionsOfferViewMediatorBase<OptionsOfferModel, OptionsOfferEvents, OptionsOfferController, OptionsOfferWindow>
	{
		// Token: 0x06001EC2 RID: 7874 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001EC2")]
		[Address(RVA = "0x7034", Offset = "0x7034", VA = "0x7034")]
		public OptionsOfferViewMediator(OptionsOfferModel model, OptionsOfferEvents events, OptionsOfferController controller)
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_SpecialOffers_Controller_OptionsOfferViewMediator___ctor
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a5863f == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_SpecialOffers_Controller_OptionsOfferControllerBase_SpecialOffersModel__SpecialOffersEvents___ctor__
		              );
		    Mono_Security_ASN1__get_Item(&Method_Core_Net_ServiceFactory_GetService_ServicesService___);
		    Mono_Security_ASN1__get_Item(&Core_Net_ServiceFactory_TypeInfo);
		    DAT_ram_00a5863f = '\x01';
		  }
		  UI_Windows_Buildings_BaseIsleBuildingWindowArgs___Il2CppFullySharedGenericType____ctor
		            (param1,param2,param3,
		             Method_Gameplay_SpecialOffers_Controller_OptionsOfferControllerBase_SpecialOffersModel__SpecialOffersEvents___ctor__
		            );
		  if (*(int *)(Core_Net_ServiceFactory_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Net_ServiceFactory_TypeInfo);
		  }
		  uVar1 = Core_Gameplay_Managers_LoggedManager__RequestLogin
		                    (Method_Core_Net_ServiceFactory_GetService_ServicesService___);
		  *(undefined4 *)(param1 + 0x18) = uVar1;
		  return;
		}
		*/

		}
	}
}
