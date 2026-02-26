using System;
using Il2CppDummyDll;
using MVC;

namespace Gameplay.Gifts.Events
{
	// Token: 0x02000719 RID: 1817
	[Token(Token = "0x2000719")]
	public class GiftsEvents : AbstractMVCEvents
	{
		// Token: 0x06002B7B RID: 11131 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002B7B")]
		[Address(RVA = "0x7C12", Offset = "0x7C12", VA = "0x7C12")]
		public GiftsEvents()
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Gifts_Events_GiftsEvents___ctor
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a5a251 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_MVC_AbstractController_GiftsModel__GiftsEvents___ctor__);
		    Mono_Security_ASN1__get_Item(&Method_Core_Net_ServiceFactory_GetService_SocialService___);
		    Mono_Security_ASN1__get_Item(&Core_Net_ServiceFactory_TypeInfo);
		    DAT_ram_00a5a251 = '\x01';
		  }
		  Gameplay_Combat_AbstractCombat_object__object__object__object__object___set_User
		            (param1,param2,param3,Method_MVC_AbstractController_GiftsModel__GiftsEvents___ctor__);
		  if (*(int *)(Core_Net_ServiceFactory_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Net_ServiceFactory_TypeInfo);
		  }
		  uVar1 = Core_Gameplay_Managers_LoggedManager__RequestLogin
		                    (Method_Core_Net_ServiceFactory_GetService_SocialService___);
		  *(undefined4 *)(param1 + 0x18) = uVar1;
		  return;
		}
		*/

		}

		// Token: 0x040017CE RID: 6094
		[Token(Token = "0x40017CE")]
		[FieldOffset(Offset = "0x14")]
		public Action GiftSentEvent;

		// Token: 0x040017CF RID: 6095
		[Token(Token = "0x40017CF")]
		[FieldOffset(Offset = "0x18")]
		public Action GiftsStatusRequestedEvent;
	}
}
