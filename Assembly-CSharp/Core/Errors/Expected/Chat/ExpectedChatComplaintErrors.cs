using System;
using Il2CppDummyDll;

namespace Core.Errors.Expected.Chat
{
	// Token: 0x0200108A RID: 4234
	[Token(Token = "0x200108A")]
	public class ExpectedChatComplaintErrors : ExpectedDefaultError
	{
		// Token: 0x060062A7 RID: 25255 RVA: 0x000128E8 File Offset: 0x00010AE8
		[Token(Token = "0x60062A7")]
		[Address(RVA = "0xAECD", Offset = "0xAECD", VA = "0xAECD", Slot = "4")]
		public override bool Handle(int errorCode)
		{
			return default(bool);
		}

		// Token: 0x060062A8 RID: 25256 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60062A8")]
		[Address(RVA = "0xAECE", Offset = "0xAECE", VA = "0xAECE")]
		public ExpectedChatComplaintErrors()
		{
		/* --- GHIDRA: .ctor ---
		uint Core_Errors_Expected_Chat_ExpectedChatComplaintErrors___ctor
		               (int param1,uint param2,undefined4 param3)
		
		{
		  int param3_00;
		  int param2_00;
		  undefined4 uVar1;
		  undefined4 uVar2;
		  int *param1_00;
		  uint uVar3;
		  undefined8 local_10;
		  float4 local_4;
		  
		  if (DAT_ram_00a60736 == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Chat_Model_Data_ChatRoomData_TypeInfo);
		    Mono_Security_ASN1__get_Item(&OKG_Logs_Debug_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_KeyValuePair_string__string____TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_KeyValuePair_string__string___ctor__);
		    Mono_Security_ASN1__get_Item(&Utils_TimeUtils_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_4181);
		    Mono_Security_ASN1__get_Item(&StringLiteral_24649);
		    Mono_Security_ASN1__get_Item(&StringLiteral_5);
		    Mono_Security_ASN1__get_Item(&StringLiteral_5345);
		    Mono_Security_ASN1__get_Item(&StringLiteral_4182);
		    DAT_ram_00a60736 = '\x01';
		  }
		  if (param2 == 0xffffffa6) {
		    uVar1 = System_Uri___ctor(0);
		    uVar1 = System_Globalization_TimeSpanFormat_FormatLiterals__get_DayHourSep(uVar1,0);
		    if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_GameLocalization_TypeInfo);
		    }
		    uVar2 = func_ii_7508(StringLiteral_4181,1,0,1,0,0,0,0);
		    Core_Application_App__get_ToastController(uVar1,4,uVar2,0);
		    uVar3 = 1;
		  }
		  else if (param2 == 0xffffffce) {
		    param1_00 = *(int **)(param1 + 8);
		    if (param1_00 != (int *)0x0) {
		      if (((uint)*(byte *)(*param1_00 + 0xb8) <
		           (uint)*(byte *)(Gameplay_Chat_Model_Data_ChatRoomData_TypeInfo + 0xb8)) ||
		         (*(int *)(*(int *)(*param1_00 + 100) +
		                   (uint)*(byte *)(Gameplay_Chat_Model_Data_ChatRoomData_TypeInfo + 0xb8) * 4 + -4)
		          != Gameplay_Chat_Model_Data_ChatRoomData_TypeInfo)) {
		        System_Activator__CreateInstance(param1_00,Gameplay_Chat_Model_Data_ChatRoomData_TypeInfo);
		        do {
		          halt_trap();
		        } while( true );
		      }
		    }
		    uVar3 = *(uint *)(param1_00[7] + 0x14);
		    if (*(int *)(Utils_TimeUtils_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Utils_TimeUtils_TypeInfo);
		    }
		    local_4 = (float4)func_ii_7331((ulonglong)uVar3,0);
		    param3_00 = System_Collections_Generic_List_float___GetEnumerator(&local_4,0);
		    if (param3_00 == 0) {
		      param3_00 = StringLiteral_5;
		    }
		    uVar1 = System_Uri___ctor(0);
		    uVar1 = System_Globalization_TimeSpanFormat_FormatLiterals__get_DayHourSep(uVar1,0);
		    if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_GameLocalization_TypeInfo);
		    }
		    uVar2 = func_ii_7508(StringLiteral_4182,1,0,1,0,0,0,0);
		    param2_00 = Mono_Security_ASN1Convert__ToOid
		                          (System_Collections_Generic_KeyValuePair_string__string____TypeInfo,1);
		    local_10 = 0;
		    System_Text_Formatting_StringView__get_IsEmpty
		              (&local_10,StringLiteral_24649,param3_00,
		               Method_System_Collections_Generic_KeyValuePair_string__string___ctor__);
		    *(undefined8 *)(param2_00 + 0x10) = local_10;
		    uVar2 = Gameplay_Clans_Office_View_ClanWarsTab_ClanWarsRewardsTab_ClanWarsRewardsView__GetPlacesText
		                      (uVar2,param2_00,0);
		    Core_Application_App__get_ToastController(uVar1,4,uVar2,0);
		    uVar3 = 1;
		  }
		  else {
		    local_10 = CONCAT44(local_10._4_4_,param2);
		    uVar1 = func_ii_1081(DAT_ram_00a66954,&local_10);
		    uVar1 = func_ii_4419(StringLiteral_5345,uVar1,0);
		    if (*(int *)(OKG_Logs_Debug_TypeInfo + 0x74) == 0) {
		      func_ii_306000(OKG_Logs_Debug_TypeInfo);
		    }
		    func_ii_7109(uVar1,0);
		    uVar3 = param2 >> 0x1f;
		  }
		  return uVar3;
		}
		*/

		}
	}
}
