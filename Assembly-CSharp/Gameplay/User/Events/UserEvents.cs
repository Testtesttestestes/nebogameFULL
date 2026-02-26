using System;
using Il2CppDummyDll;
using MVC;

namespace Gameplay.User.Events
{
	// Token: 0x02000421 RID: 1057
	[Token(Token = "0x2000421")]
	public class UserEvents : AbstractMVCEvents
	{
		// Token: 0x06001900 RID: 6400 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001900")]
		[Address(RVA = "0x6A9F", Offset = "0x6A9F", VA = "0x6A9F")]
		public UserEvents()
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_User_Events_UserEvents___ctor
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a59953 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_MVC_AbstractController_UserModel__UserEvents___ctor__);
		    Mono_Security_ASN1__get_Item(&Method_Core_Net_ServiceFactory_GetService_ClansService___);
		    Mono_Security_ASN1__get_Item(&Method_Core_Net_ServiceFactory_GetService_MainService___);
		    Mono_Security_ASN1__get_Item(&Method_Core_Net_ServiceFactory_GetService_WorldService___);
		    Mono_Security_ASN1__get_Item(&Core_Net_ServiceFactory_TypeInfo);
		    DAT_ram_00a59953 = '\x01';
		  }
		  Gameplay_Combat_AbstractCombat_object__object__object__object__object___set_User
		            (param1,param2,param3,Method_MVC_AbstractController_UserModel__UserEvents___ctor__);
		  if (*(int *)(Core_Net_ServiceFactory_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Net_ServiceFactory_TypeInfo);
		  }
		  uVar1 = Core_Gameplay_Managers_LoggedManager__RequestLogin
		                    (Method_Core_Net_ServiceFactory_GetService_MainService___);
		  *(undefined4 *)(param1 + 0x18) = uVar1;
		  uVar1 = Core_Gameplay_Managers_LoggedManager__RequestLogin
		                    (Method_Core_Net_ServiceFactory_GetService_WorldService___);
		  *(undefined4 *)(param1 + 0x1c) = uVar1;
		  uVar1 = Core_Gameplay_Managers_LoggedManager__RequestLogin
		                    (Method_Core_Net_ServiceFactory_GetService_ClansService___);
		  *(undefined4 *)(param1 + 0x20) = uVar1;
		  return;
		}
		*/

		}

		// Token: 0x04000D39 RID: 3385
		[Token(Token = "0x4000D39")]
		[FieldOffset(Offset = "0x14")]
		public Action UserInfoUpdateCompleteEvent;

		// Token: 0x04000D3A RID: 3386
		[Token(Token = "0x4000D3A")]
		[FieldOffset(Offset = "0x18")]
		public Action BuyTreeLicenceSuccessEvent;

		// Token: 0x04000D3B RID: 3387
		[Token(Token = "0x4000D3B")]
		[FieldOffset(Offset = "0x1C")]
		public Action EnergyRegenStatusChangedEvent;
	}
}
