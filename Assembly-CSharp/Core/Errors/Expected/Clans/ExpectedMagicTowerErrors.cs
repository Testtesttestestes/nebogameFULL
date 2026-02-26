using System;
using Il2CppDummyDll;

namespace Core.Errors.Expected.Clans
{
	// Token: 0x02001086 RID: 4230
	[Token(Token = "0x2001086")]
	public class ExpectedMagicTowerErrors : ExpectedDefaultError
	{
		// Token: 0x060062A0 RID: 25248 RVA: 0x000128A0 File Offset: 0x00010AA0
		[Token(Token = "0x60062A0")]
		[Address(RVA = "0xAEC6", Offset = "0xAEC6", VA = "0xAEC6", Slot = "4")]
		public override bool Handle(int errorCode)
		{
			return default(bool);
		}

		// Token: 0x060062A1 RID: 25249 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60062A1")]
		[Address(RVA = "0xAEC7", Offset = "0xAEC7", VA = "0xAEC7")]
		public ExpectedMagicTowerErrors()
		{
		/* --- GHIDRA: .ctor ---
		uint Core_Errors_Expected_Clans_ExpectedMagicTowerErrors___ctor
		               (int param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int param2_00;
		  float fVar2;
		  uint uVar3;
		  undefined4 uVar4;
		  int *param1_00;
		  undefined8 local_8;
		  
		  uVar1 = 0;
		  if (DAT_ram_00a60733 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Core_Errors_Expected_Clans_ExpectedPutJoinRequestErrors_ExpectedPutJoinRequestErrorsArgs_TypeInfo
		              );
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_KeyValuePair_string__string____TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_KeyValuePair_string__string___ctor__);
		    Mono_Security_ASN1__get_Item(&Utils_TimeUtils_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_4279);
		    Mono_Security_ASN1__get_Item(&StringLiteral_4283);
		    Mono_Security_ASN1__get_Item(&StringLiteral_4281);
		    Mono_Security_ASN1__get_Item(&StringLiteral_4311);
		    Mono_Security_ASN1__get_Item(&StringLiteral_4282);
		    Mono_Security_ASN1__get_Item(&StringLiteral_21969);
		    Mono_Security_ASN1__get_Item(&StringLiteral_4280);
		    DAT_ram_00a60733 = '\x01';
		  }
		  if (param2 == -0x16) {
		    if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_GameLocalization_TypeInfo);
		    }
		    uVar1 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_4282,1,0,1,0,0,0,0);
		  }
		  else if (param2 == -0x15) {
		    if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_GameLocalization_TypeInfo);
		    }
		    uVar1 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_4283,1,0,1,0,0,0,0);
		  }
		  else if (((((((param2 != -0x14) && (param2 != -0x13)) && (param2 != -0x12)) &&
		             ((param2 != -0x11 && (param2 != -0x10)))) &&
		            ((param2 != -0xf && ((param2 != -0xe && (param2 != -0xd)))))) && (param2 != -0xc)) &&
		          ((((param2 != -0xb && (param2 != -10)) && (param2 != -9)) &&
		           (((param2 != -8 && (param2 != -7)) && (param2 != -6)))))) {
		    if (param2 == -5) {
		      param1_00 = *(int **)(param1 + 8);
		      if (param1_00 != (int *)0x0) {
		        if (((uint)*(byte *)(*param1_00 + 0xb8) <
		             (uint)*(byte *)(
		                            Core_Errors_Expected_Clans_ExpectedPutJoinRequestErrors_ExpectedPutJoinRequestErrorsArgs_TypeInfo
		                            + 0xb8)) ||
		           (*(int *)(*(int *)(*param1_00 + 100) +
		                     (uint)*(byte *)(
		                                    Core_Errors_Expected_Clans_ExpectedPutJoinRequestErrors_ExpectedPutJoinRequestErrorsArgs_TypeInfo
		                                    + 0xb8) * 4 + -4) !=
		            Core_Errors_Expected_Clans_ExpectedPutJoinRequestErrors_ExpectedPutJoinRequestErrorsArgs_TypeInfo
		           )) {
		          System_Activator__CreateInstance
		                    (param1_00,
		                     Core_Errors_Expected_Clans_ExpectedPutJoinRequestErrors_ExpectedPutJoinRequestErrorsArgs_TypeInfo
		                    );
		          do {
		            halt_trap();
		          } while( true );
		        }
		      }
		      if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		        func_ii_306000(Core_GameLocalization_TypeInfo);
		      }
		      uVar1 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_4281,1,0,1,0,0,0,0);
		      param2_00 = Mono_Security_ASN1Convert__ToOid
		                            (System_Collections_Generic_KeyValuePair_string__string____TypeInfo,1);
		      uVar3 = param1_00[2];
		      if (*(int *)(Utils_TimeUtils_TypeInfo + 0x74) == 0) {
		        func_ii_306000(Utils_TimeUtils_TypeInfo);
		      }
		      fVar2 = func_ii_7331((ulonglong)uVar3,0);
		      uVar4 = Utils_TimeUtils__DateFormat((double)fVar2,0);
		      local_8 = 0;
		      System_Text_Formatting_StringView__get_IsEmpty
		                (&local_8,StringLiteral_21969,uVar4,
		                 Method_System_Collections_Generic_KeyValuePair_string__string___ctor__);
		      *(undefined8 *)(param2_00 + 0x10) = local_8;
		      uVar1 = Gameplay_Clans_Office_View_ClanWarsTab_ClanWarsRewardsTab_ClanWarsRewardsView__GetPlacesText
		                        (uVar1,param2_00,0);
		    }
		    else if (param2 == -4) {
		      if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		        func_ii_306000(Core_GameLocalization_TypeInfo);
		      }
		      uVar1 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_4279,1,0,1,0,0,0,0);
		    }
		    else if (param2 == -3) {
		      if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		        func_ii_306000(Core_GameLocalization_TypeInfo);
		      }
		      uVar1 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_4280,1,0,1,0,0,0,0);
		    }
		  }
		  uVar3 = func_ii_4769(uVar1,0);
		  if (uVar3 == 0) {
		    if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_GameLocalization_TypeInfo);
		    }
		    uVar4 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_4311,1,0,1,0,0,0,0);
		    UI_Windows_DialogWindow__Show(uVar4,uVar1,0);
		  }
		  return uVar3 ^ 1;
		}
		*/

		}
	}
}
