using System;
using Il2CppDummyDll;

namespace Core.Errors.Expected
{
	// Token: 0x02001068 RID: 4200
	[Token(Token = "0x2001068")]
	public class ExpectedPayoffBanErrors : ExpectedDefaultError
	{
		// Token: 0x06006264 RID: 25188 RVA: 0x00012660 File Offset: 0x00010860
		[Token(Token = "0x6006264")]
		[Address(RVA = "0xAE8A", Offset = "0xAE8A", VA = "0xAE8A", Slot = "4")]
		public override bool Handle(int errorCode)
		{
			return default(bool);
		}

		// Token: 0x06006265 RID: 25189 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006265")]
		[Address(RVA = "0xAE8B", Offset = "0xAE8B", VA = "0xAE8B")]
		public ExpectedPayoffBanErrors()
		{
		/* --- GHIDRA: .ctor ---
		undefined4
		Core_Errors_Expected_ExpectedPayoffBanErrors___ctor(int param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  undefined4 uVar2;
		  int *param1_00;
		  
		  if (DAT_ram_00a5a389 == '\0') {
		    Mono_Security_ASN1__get_Item(&OKG_Logs_Debug_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Portals_Controller_PortalsTotalizatorController_TypeInfo)
		    ;
		    Mono_Security_ASN1__get_Item(&StringLiteral_6926);
		    DAT_ram_00a5a389 = '\x01';
		  }
		  param1_00 = *(int **)(param1 + 8);
		  if (param1_00 != (int *)0x0) {
		    if (((uint)*(byte *)(*param1_00 + 0xb8) <
		         (uint)*(byte *)(Gameplay_Portals_Controller_PortalsTotalizatorController_TypeInfo + 0xb8))
		       || (*(int *)(*(int *)(*param1_00 + 100) +
		                    (uint)*(byte *)(
		                                   Gameplay_Portals_Controller_PortalsTotalizatorController_TypeInfo
		                                   + 0xb8) * 4 + -4) !=
		           Gameplay_Portals_Controller_PortalsTotalizatorController_TypeInfo)) {
		      System_Activator__CreateInstance
		                (param1_00,Gameplay_Portals_Controller_PortalsTotalizatorController_TypeInfo);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  if (param2 == -2) {
		    if (param1_00 != (int *)0x0) {
		      Gameplay_Portals_Controller_PortalsTotalizatorController__BetRestrictedHandler(param1_00,0);
		      return 1;
		    }
		    uVar1 = 1;
		  }
		  else if (param2 == -1) {
		    if (param1_00 != (int *)0x0) {
		      Gameplay_Portals_Controller_PortalsTotalizatorController___ctor(param1_00,0);
		      return 1;
		    }
		    uVar1 = 1;
		  }
		  else {
		    if (param2 == -0xff) {
		      if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		        func_ii_306000(Core_GameLocalization_TypeInfo);
		      }
		      uVar1 = func_ii_7508(StringLiteral_6926,1,0,1,0,0,0,0);
		      uVar2 = System_Uri___ctor(0);
		      uVar2 = System_Globalization_TimeSpanFormat_FormatLiterals__get_DayHourSep(uVar2,0);
		      Core_Application_App__get_ToastController(uVar2,2,uVar1,0);
		      if (*(int *)(OKG_Logs_Debug_TypeInfo + 0x74) == 0) {
		        func_ii_306000(OKG_Logs_Debug_TypeInfo);
		      }
		      func_ii_7830(uVar1,0);
		      return 1;
		    }
		    uVar1 = Core_Errors_Expected_ExpectedEndlessOptionsBillingErrors___c___Handle_b__0_0
		                      (param1_00,param2,param1_00);
		  }
		  return uVar1;
		}
		*/

		}
	}
}
