using System;
using Il2CppDummyDll;

namespace Core.Errors.Expected
{
	// Token: 0x02001070 RID: 4208
	[Token(Token = "0x2001070")]
	public class ExpectedSetEmailErrors : ExpectedDefaultError
	{
		// Token: 0x06006276 RID: 25206 RVA: 0x00012708 File Offset: 0x00010908
		[Token(Token = "0x6006276")]
		[Address(RVA = "0xAE9C", Offset = "0xAE9C", VA = "0xAE9C", Slot = "4")]
		public override bool Handle(int errorCode)
		{
			return default(bool);
		}

		// Token: 0x06006277 RID: 25207 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006277")]
		[Address(RVA = "0xAE9D", Offset = "0xAE9D", VA = "0xAE9D")]
		public ExpectedSetEmailErrors()
		{
		/* --- GHIDRA: .ctor ---
		undefined4
		Core_Errors_Expected_ExpectedSetEmailErrors___ctor(int param1,int param2,undefined4 param3)
		
		{
		  char cVar1;
		  uint uVar2;
		  undefined4 uVar3;
		  char *pcVar4;
		  uint *puVar5;
		  undefined4 uVar6;
		  undefined4 param3_00;
		  int *piVar7;
		  int iVar8;
		  
		  if (DAT_ram_00a5a390 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Core_Errors_Expected_ExpectedStackableChangesErrors_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Inventory_Controller_InventoryBaseController_InventoryModel__InventoryEvents__ShowNotAvailableSlotsWindow__
		              );
		    Mono_Security_ASN1__get_Item(&StringLiteral_7858);
		    Mono_Security_ASN1__get_Item(&StringLiteral_13899);
		    Mono_Security_ASN1__get_Item(&StringLiteral_13898);
		    Mono_Security_ASN1__get_Item(&StringLiteral_13896);
		    Mono_Security_ASN1__get_Item(&StringLiteral_13897);
		    Mono_Security_ASN1__get_Item(&StringLiteral_13895);
		    DAT_ram_00a5a390 = '\x01';
		  }
		  piVar7 = *(int **)(param1 + 8);
		  if (piVar7 == (int *)0x0) {
		    System_Collections_Generic_Comparer_ValueTuple_int__Int32Enum__object____get_Default();
		    do {
		      halt_trap();
		    } while( true );
		  }
		  if (*(int *)(*piVar7 + 0x20) !=
		      *(int *)(Core_Errors_Expected_ExpectedStackableChangesErrors_Action_TypeInfo + 0x20)) {
		    System_Activator__CreateInstance
		              (piVar7,Core_Errors_Expected_ExpectedStackableChangesErrors_Action_TypeInfo);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  uVar3 = 0;
		  pcVar4 = (char *)func_ii_15774(piVar7);
		  if (param2 == -0x1e) {
		    uVar3 = System_Uri___ctor(0);
		    uVar3 = System_Globalization_TimeSpanFormat_FormatLiterals__get_DayHourSep(uVar3,0);
		    if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_GameLocalization_TypeInfo);
		    }
		    uVar6 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_13897,1,0,1,0,0,0,0);
		    Core_Application_App__get_ToastController(uVar3,2,uVar6,0);
		    return 1;
		  }
		  if ((((((((param2 != -0x1d) && (param2 != -0x1c)) && (param2 != -0x1b)) &&
		         (((param2 != -0x1a && (param2 != -0x19)) &&
		          ((param2 != -0x18 && ((param2 != -0x17 && (param2 != -0x16)))))))) && (param2 != -0x15))
		       && (((((param2 != -0x14 && (param2 != -0x13)) && (param2 != -0x12)) &&
		            ((param2 != -0x11 && (param2 != -0x10)))) &&
		           ((param2 != -0xf && ((param2 != -0xe && (param2 != -0xd)))))))) &&
		      ((param2 != -0xc && (((param2 != -0xb && (param2 != -10)) && (param2 != -9)))))) &&
		     (((param2 != -8 && (param2 != -7)) && ((param2 != -6 && (param2 != -5)))))) {
		    if (param2 == -4) {
		      if (DAT_ram_00a6456f == '\0') {
		        Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		        DAT_ram_00a6456f = '\x01';
		      }
		      piVar7 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		      iVar8 = *piVar7;
		      if (*(ushort *)(iVar8 + 0xb6) != 0) {
		        uVar2 = 0;
		        do {
		          if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar8 + 0x58) + uVar2 * 8)) {
		            puVar5 = (uint *)(*(int *)(*(int *)(iVar8 + 0x58) + uVar2 * 8 + 4) * 8 + iVar8 + 0x120);
		            goto code_r0x81210c65;
		          }
		          uVar2 = uVar2 + 1;
		        } while (*(ushort *)(iVar8 + 0xb6) != uVar2);
		      }
		      puVar5 = (uint *)func_ii_1080(piVar7,Core_Gameplay_IGame_TypeInfo,0xc);
		code_r0x81210c65:
		      iVar8 = (**(code **)((ulonglong)*puVar5 * 4))(piVar7,puVar5[1]);
		      Gameplay_Inventory_Controller_InventoryBaseController_object__object___ParseSlotChanges
		                (*(undefined4 *)(iVar8 + 0x14),1,
		                 Method_Gameplay_Inventory_Controller_InventoryBaseController_InventoryModel__InventoryEvents__ShowNotAvailableSlotsWindow__
		                );
		      return 1;
		    }
		    if (param2 == -3) {
		      uVar3 = System_Uri___ctor(0);
		      uVar3 = System_Globalization_TimeSpanFormat_FormatLiterals__get_DayHourSep(uVar3,0);
		      if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		        func_ii_306000(Core_GameLocalization_TypeInfo);
		      }
		      uVar6 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_13898,1,0,1,0,0,0,0);
		      Core_Application_App__get_ToastController(uVar3,2,uVar6,0);
		      return 1;
		    }
		    if (param2 == -2) {
		      cVar1 = *pcVar4;
		      uVar3 = System_Uri___ctor(0);
		      uVar3 = System_Globalization_TimeSpanFormat_FormatLiterals__get_DayHourSep(uVar3,0);
		      if (cVar1 == '\x01') {
		        if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		          func_ii_306000(Core_GameLocalization_TypeInfo);
		        }
		        uVar6 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_13895,1,0,1,0,0,0,0);
		        Core_Application_App__get_ToastController(uVar3,2,uVar6,0);
		        return 1;
		      }
		      if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		        func_ii_306000(Core_GameLocalization_TypeInfo);
		      }
		      uVar6 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_13896,1,0,1,0,0,0,0);
		      Core_Application_App__get_ToastController(uVar3,2,uVar6,0);
		      return 1;
		    }
		    if (param2 == -1) {
		      uVar3 = System_Uri___ctor(0);
		      uVar3 = System_Globalization_TimeSpanFormat_FormatLiterals__get_DayHourSep(uVar3,0);
		      if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		        func_ii_306000(Core_GameLocalization_TypeInfo);
		      }
		      uVar6 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_7858,1,0,1,0,0,0,0);
		      Core_Application_App__get_ToastController(uVar3,2,uVar6,0);
		      return 1;
		    }
		    if (param2 == -1000) {
		      uVar3 = System_Uri___ctor(0);
		      uVar6 = System_Globalization_TimeSpanFormat_FormatLiterals__get_DayHourSep(uVar3,0);
		      if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		        func_ii_306000(Core_GameLocalization_TypeInfo);
		      }
		      uVar3 = 1;
		      param3_00 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_13899,1,0,1,0,0,0,0);
		      Core_Application_App__get_ToastController(uVar6,2,param3_00,0);
		    }
		    else if (param2 == -10000) {
		      uVar3 = System_Uri___ctor(0);
		      uVar3 = System_Globalization_TimeSpanFormat_FormatLiterals__get_DayHourSep(uVar3,0);
		      if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		        func_ii_306000(Core_GameLocalization_TypeInfo);
		      }
		      uVar6 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_13899,1,0,1,0,0,0,0);
		      Core_Application_App__get_ToastController(uVar3,2,uVar6,0);
		      return 1;
		    }
		  }
		  return uVar3;
		}
		*/

		}

		// Token: 0x02001071 RID: 4209
		[Token(Token = "0x2001071")]
		public enum EmailPasswordErrorCodes
		{
			// Token: 0x040034EC RID: 13548
			[Token(Token = "0x40034EC")]
			EMAIL_INVALID = -201,
			// Token: 0x040034ED RID: 13549
			[Token(Token = "0x40034ED")]
			PASS_TO_LONG = -202,
			// Token: 0x040034EE RID: 13550
			[Token(Token = "0x40034EE")]
			EMAIL_EXIST = -203,
			// Token: 0x040034EF RID: 13551
			[Token(Token = "0x40034EF")]
			PASS_LEN_INVALID = -2001,
			// Token: 0x040034F0 RID: 13552
			[Token(Token = "0x40034F0")]
			EMAIL_ERROR = -2100
		}
	}
}
