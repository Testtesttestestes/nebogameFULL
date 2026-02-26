using System;
using Il2CppDummyDll;

namespace Core.Errors.Expected
{
	// Token: 0x02001066 RID: 4198
	[Token(Token = "0x2001066")]
	public class ExpectedKickMonsterErrors : ExpectedDefaultError
	{
		// Token: 0x06006260 RID: 25184 RVA: 0x00012630 File Offset: 0x00010830
		[Token(Token = "0x6006260")]
		[Address(RVA = "0xAE86", Offset = "0xAE86", VA = "0xAE86", Slot = "4")]
		public override bool Handle(int errorCode)
		{
			return default(bool);
		}

		// Token: 0x06006261 RID: 25185 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006261")]
		[Address(RVA = "0xAE87", Offset = "0xAE87", VA = "0xAE87")]
		public ExpectedKickMonsterErrors()
		{
		/* --- GHIDRA: .ctor ---
		undefined4
		Core_Errors_Expected_ExpectedKickMonsterErrors___ctor
		          (undefined4 param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  undefined4 uVar2;
		  
		  if (DAT_ram_00a5a387 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_4481);
		    Mono_Security_ASN1__get_Item(&StringLiteral_4478);
		    Mono_Security_ASN1__get_Item(&StringLiteral_4484);
		    DAT_ram_00a5a387 = '\x01';
		  }
		  if (param2 == -3) {
		    return 1;
		  }
		  if (param2 == -2) {
		    uVar1 = System_Uri___ctor(0);
		    uVar1 = System_Globalization_TimeSpanFormat_FormatLiterals__get_DayHourSep(uVar1,0);
		    if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_GameLocalization_TypeInfo);
		    }
		    uVar2 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_4484,1,0,1,0,0,0,0);
		    Core_Application_App__get_ToastController(uVar1,2,uVar2,0);
		    return 1;
		  }
		  if (param2 != -1) {
		    if (param2 == -1000) {
		      uVar1 = System_Uri___ctor(0);
		      uVar1 = System_Globalization_TimeSpanFormat_FormatLiterals__get_DayHourSep(uVar1,0);
		      if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		        func_ii_306000(Core_GameLocalization_TypeInfo);
		      }
		      uVar2 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_4478,1,0,1,0,0,0,0);
		      Core_Application_App__get_ToastController(uVar1,2,uVar2,0);
		      uVar1 = 1;
		    }
		    else {
		      uVar1 = 0;
		    }
		    return uVar1;
		  }
		  uVar1 = System_Uri___ctor(0);
		  uVar1 = System_Globalization_TimeSpanFormat_FormatLiterals__get_DayHourSep(uVar1,0);
		  if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_GameLocalization_TypeInfo);
		  }
		  uVar2 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_4481,1,0,1,0,0,0,0);
		  Core_Application_App__get_ToastController(uVar1,2,uVar2,0);
		  return 1;
		}
		*/

		}
	}
}
