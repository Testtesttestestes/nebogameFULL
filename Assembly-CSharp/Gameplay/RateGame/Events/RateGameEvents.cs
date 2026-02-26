using System;
using Il2CppDummyDll;
using MVC;

namespace Gameplay.RateGame.Events
{
	// Token: 0x020005A9 RID: 1449
	[Token(Token = "0x20005A9")]
	public class RateGameEvents : AbstractMVCEvents
	{
		// Token: 0x060022CC RID: 8908 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60022CC")]
		[Address(RVA = "0x7423", Offset = "0x7423", VA = "0x7423")]
		public RateGameEvents()
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_RateGame_Events_RateGameEvents___ctor
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a580ca == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_MVC_AbstractController_RateGameModel__RateGameEvents___ctor__);
		    Mono_Security_ASN1__get_Item(&Method_Core_Net_ServiceFactory_GetService_SocialService___);
		    Mono_Security_ASN1__get_Item(&Core_Net_ServiceFactory_TypeInfo);
		    DAT_ram_00a580ca = '\x01';
		  }
		  Gameplay_Combat_AbstractCombat_object__object__object__object__object___set_User
		            (param1,param2,param3,
		             Method_MVC_AbstractController_RateGameModel__RateGameEvents___ctor__);
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

		// Token: 0x04001303 RID: 4867
		[Token(Token = "0x4001303")]
		[FieldOffset(Offset = "0x14")]
		public Action<uint> RateGameEvent;
	}
}
