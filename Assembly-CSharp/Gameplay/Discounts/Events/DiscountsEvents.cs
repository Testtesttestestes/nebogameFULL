using System;
using Il2CppDummyDll;
using MVC;

namespace Gameplay.Discounts.Events
{
	// Token: 0x020008A4 RID: 2212
	[Token(Token = "0x20008A4")]
	public class DiscountsEvents : AbstractMVCEvents
	{
		// Token: 0x060033FA RID: 13306 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60033FA")]
		[Address(RVA = "0x8427", Offset = "0x8427", VA = "0x8427")]
		public DiscountsEvents()
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Discounts_Events_DiscountsEvents___ctor
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a57cc2 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_MVC_AbstractController_DiscountsModel__DiscountsEvents___ctor__);
		    Mono_Security_ASN1__get_Item(&Method_Core_Net_ServiceFactory_GetService_ServicesService___);
		    Mono_Security_ASN1__get_Item(&Core_Net_ServiceFactory_TypeInfo);
		    DAT_ram_00a57cc2 = '\x01';
		  }
		  Gameplay_Combat_AbstractCombat_object__object__object__object__object___set_User
		            (param1,param2,param3,
		             Method_MVC_AbstractController_DiscountsModel__DiscountsEvents___ctor__);
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

		// Token: 0x04001C49 RID: 7241
		[Token(Token = "0x4001C49")]
		[FieldOffset(Offset = "0x14")]
		public Action DiscountsRequestedEvent;
	}
}
