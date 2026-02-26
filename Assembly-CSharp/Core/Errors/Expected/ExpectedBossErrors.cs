using System;
using Il2CppDummyDll;

namespace Core.Errors.Expected
{
	// Token: 0x02001045 RID: 4165
	[Token(Token = "0x2001045")]
	public class ExpectedBossErrors : ExpectedDefaultError
	{
		// Token: 0x0600620C RID: 25100 RVA: 0x00012378 File Offset: 0x00010578
		[Token(Token = "0x600620C")]
		[Address(RVA = "0xAE37", Offset = "0xAE37", VA = "0xAE37", Slot = "4")]
		public override bool Handle(int errorCode)
		{
			return default(bool);
		}

		// Token: 0x0600620D RID: 25101 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600620D")]
		[Address(RVA = "0xAE38", Offset = "0xAE38", VA = "0xAE38")]
		public ExpectedBossErrors()
		{
		/* --- GHIDRA: .ctor ---
		undefined4
		Core_Errors_Expected_ExpectedBossErrors___ctor(undefined4 param1,int param2,undefined4 param3)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  int param2_00;
		  undefined4 param3_00;
		  undefined4 uVar3;
		  undefined4 uVar4;
		  int *piVar5;
		  int iVar6;
		  undefined8 local_10;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a5a362 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_KeyValuePair_string__string____TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_KeyValuePair_string__string___ctor__);
		    Mono_Security_ASN1__get_Item(&StringLiteral_3715);
		    Mono_Security_ASN1__get_Item(&StringLiteral_3711);
		    Mono_Security_ASN1__get_Item(&StringLiteral_3717);
		    Mono_Security_ASN1__get_Item(&StringLiteral_3716);
		    Mono_Security_ASN1__get_Item(&StringLiteral_3712);
		    Mono_Security_ASN1__get_Item(&StringLiteral_22670);
		    DAT_ram_00a5a362 = '\x01';
		  }
		  if (param2 == -10) {
		    uVar3 = System_Uri___ctor(0);
		    uVar3 = System_Globalization_TimeSpanFormat_FormatLiterals__get_DayHourSep(uVar3,0);
		    if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_GameLocalization_TypeInfo);
		    }
		    uVar4 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_3716,1,0,1,0,0,0,0);
		    Core_Application_App__get_ToastController(uVar3,2,uVar4,0);
		    return 1;
		  }
		  if (((param2 != -9) && (param2 != -8)) && (param2 != -7)) {
		    if (param2 == -6) {
		      if (DAT_ram_00a6456f == '\0') {
		        Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		        DAT_ram_00a6456f = '\x01';
		      }
		      piVar5 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		      iVar6 = *piVar5;
		      if (*(ushort *)(iVar6 + 0xb6) != 0) {
		        uVar1 = 0;
		        do {
		          if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8)) {
		            puVar2 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8 + 4) * 8 + iVar6 + 0x178);
		            goto code_r0x8120bdef;
		          }
		          uVar1 = uVar1 + 1;
		        } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		      }
		      puVar2 = (uint *)func_ii_1080(piVar5,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x8120bdef:
		      uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(piVar5,puVar2[1]);
		      uVar3 = Newtonsoft_Json_Converters_XmlDocumentTypeWrapper__get_System(uVar3,0);
		      if (DAT_ram_00a6456f == '\0') {
		        Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		        DAT_ram_00a6456f = '\x01';
		      }
		      piVar5 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		      iVar6 = *piVar5;
		      if (*(ushort *)(iVar6 + 0xb6) != 0) {
		        uVar1 = 0;
		        do {
		          if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8)) {
		            puVar2 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8 + 4) * 8 + iVar6 + 0x140);
		            goto code_r0x8120bea1;
		          }
		          uVar1 = uVar1 + 1;
		        } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		      }
		      puVar2 = (uint *)func_ii_1080(piVar5,Core_Gameplay_IGame_TypeInfo,0x10);
		code_r0x8120bea1:
		      uVar4 = (**(code **)((ulonglong)*puVar2 * 4))(piVar5,puVar2[1]);
		      uVar4 = func_ii_7112(uVar4,0);
		      uVar4 = Core_Data_UserData__set_LevelDic(uVar4,0);
		      iVar6 = Core_Extensions_Dict_DictExt__GetSeasonLeagueRewardsSorted(uVar3,uVar4,0);
		      uVar3 = System_Uri___ctor(0);
		      uVar3 = System_Globalization_TimeSpanFormat_FormatLiterals__get_DayHourSep(uVar3,0);
		      if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		        func_ii_306000(Core_GameLocalization_TypeInfo);
		      }
		      uVar4 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_3717,1,0,1,0,0,0,0);
		      param2_00 = Mono_Security_ASN1Convert__ToOid
		                            (System_Collections_Generic_KeyValuePair_string__string____TypeInfo,1);
		      local_4 = *(undefined4 *)(iVar6 + 0x10);
		      param3_00 = Protocol_Combat_ProtoPlayerActionEvt___ctor(&local_4,0);
		      local_10 = 0;
		      System_Text_Formatting_StringView__get_IsEmpty
		                (&local_10,StringLiteral_22670,param3_00,
		                 Method_System_Collections_Generic_KeyValuePair_string__string___ctor__);
		      *(undefined8 *)(param2_00 + 0x10) = local_10;
		      uVar4 = Gameplay_Clans_Office_View_ClanWarsTab_ClanWarsRewardsTab_ClanWarsRewardsView__GetPlacesText
		                        (uVar4,param2_00,0);
		      Core_Application_App__get_ToastController(uVar3,2,uVar4,0);
		      return 1;
		    }
		    if (param2 == -5) {
		      uVar3 = System_Uri___ctor(0);
		      uVar3 = System_Globalization_TimeSpanFormat_FormatLiterals__get_DayHourSep(uVar3,0);
		      if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		        func_ii_306000(Core_GameLocalization_TypeInfo);
		      }
		      uVar4 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_3712,1,0,1,0,0,0,0);
		      Core_Application_App__get_ToastController(uVar3,2,uVar4,0);
		      return 1;
		    }
		    if (param2 == -4) {
		      uVar3 = System_Uri___ctor(0);
		      uVar3 = System_Globalization_TimeSpanFormat_FormatLiterals__get_DayHourSep(uVar3,0);
		      if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		        func_ii_306000(Core_GameLocalization_TypeInfo);
		      }
		      uVar4 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_3715,1,0,1,0,0,0,0);
		      Core_Application_App__get_ToastController(uVar3,2,uVar4,0);
		      return 1;
		    }
		    if ((param2 != -3) && (param2 == -2)) {
		      uVar3 = System_Uri___ctor(0);
		      uVar3 = System_Globalization_TimeSpanFormat_FormatLiterals__get_DayHourSep(uVar3,0);
		      if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		        func_ii_306000(Core_GameLocalization_TypeInfo);
		      }
		      uVar4 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_3711,1,0,1,0,0,0,0);
		      Core_Application_App__get_ToastController(uVar3,2,uVar4,0);
		      return 1;
		    }
		  }
		  uVar3 = Core_Errors_Expected_ExpectedEndlessOptionsBillingErrors___c___Handle_b__0_0
		                    (param2,param2,param2);
		  return uVar3;
		}
		*/

		}
	}
}
