using System;
using Il2CppDummyDll;

namespace Gameplay.GameEvents.Model.Tags
{
	// Token: 0x020007B4 RID: 1972
	[Token(Token = "0x20007B4")]
	public class TimestampTag_2 : AbstractTag
	{
		// Token: 0x17000910 RID: 2320
		// (get) Token: 0x06002EA4 RID: 11940 RVA: 0x00009540 File Offset: 0x00007740
		[Token(Token = "0x17000910")]
		public long Timestamp
		{
			[Token(Token = "0x6002EA4")]
			[Address(RVA = "0x7F1F", Offset = "0x7F1F", VA = "0x7F1F")]
			get
			{
				return 0L;
			}
		}

		// Token: 0x06002EA5 RID: 11941 RVA: 0x00009558 File Offset: 0x00007758
		[Token(Token = "0x6002EA5")]
		[Address(RVA = "0x7F20", Offset = "0x7F20", VA = "0x7F20", Slot = "7")]
		public override bool TryGetValue(string tagName, GameEventData evtData, out string value, AbstractTag.TagViewHandler viewHandler)
		{
			return default(bool);
		}

		// Token: 0x06002EA6 RID: 11942 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002EA6")]
		[Address(RVA = "0x7F21", Offset = "0x7F21", VA = "0x7F21")]
		public TimestampTag_2()
		{
		}

		// Token: 0x0400198D RID: 6541
		[Token(Token = "0x400198D")]
		public const string TIMESTAMP = "timestamp";

		// Token: 0x0400198E RID: 6542
		[Token(Token = "0x400198E")]
		public const string TIMESTAMP_REL = "timestamp_rel";
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_Timestamp ---
		int Gameplay_GameEvents_Model_Tags_TimestampTag_2__get_Timestamp
		              (int *param1,undefined4 param2,undefined4 param3,undefined4 *param4,undefined4 param5,
		              undefined4 param6)
		
		{
		  undefined4 in_register_20000004;
		  undefined4 in_register_20000014;
		  undefined4 uVar1;
		  int iVar2;
		  int iVar3;
		  float fVar4;
		  longlong lVar5;
		  undefined8 local_30;
		  undefined8 local_28;
		  undefined8 local_20;
		  undefined8 local_18;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a574e6 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_DateTimeOffset_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Utils_TimeUtils_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_22542);
		    Mono_Security_ASN1__get_Item(&StringLiteral_27728);
		    Mono_Security_ASN1__get_Item(&StringLiteral_27730);
		    DAT_ram_00a574e6 = '\x01';
		  }
		  local_8 = 0;
		  local_10 = 0;
		  if (DAT_ram_00a574cb == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_11610);
		    DAT_ram_00a574cb = '\x01';
		  }
		  if (DAT_ram_00a574ca == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_string__Contains__);
		    DAT_ram_00a574ca = '\x01';
		  }
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xf0) * 4))
		                    (CONCAT44(in_register_20000004,param1),
		                     CONCAT44(in_register_20000014,*(undefined4 *)(*param1 + 0xf4)));
		  iVar2 = Google_Protobuf_Collections_RepeatedField_object___Clear
		                    (uVar1,param2,
		                     Method_Google_Protobuf_Collections_RepeatedField_string__Contains__);
		  if (iVar2 == 0) {
		    *param4 = 0;
		  }
		  else {
		    uVar1 = Mono_Security_X509_X509Crl_X509CrlEntry___ctor(StringLiteral_11610,param2,0);
		    *param4 = uVar1;
		    iVar3 = System_Collections_CollectionBase___ctor(param2,StringLiteral_27728,0);
		    if (iVar3 == 0) {
		      iVar3 = System_Collections_CollectionBase___ctor(param2,StringLiteral_27730,0);
		      if (iVar3 != 0) {
		        if (ABS(*(double *)(param1[5] + 0x10)) < 9.223372036854776e+18) {
		          lVar5 = (longlong)*(double *)(param1[5] + 0x10);
		        }
		        else {
		          lVar5 = -0x8000000000000000;
		        }
		        if (*(int *)(Utils_TimeUtils_TypeInfo + 0x74) == 0) {
		          func_ii_306000(Utils_TimeUtils_TypeInfo);
		        }
		        fVar4 = func_ii_7331(lVar5,0);
		        lVar5 = Utils_TimeUtils__Format(0);
		        uVar1 = Utils_TimeUtils__DateFormat((double)(fVar4 - (float)lVar5),0);
		        *param4 = uVar1;
		      }
		    }
		    else {
		      if (ABS(*(double *)(param1[5] + 0x10)) < 9.223372036854776e+18) {
		        lVar5 = (longlong)*(double *)(param1[5] + 0x10);
		      }
		      else {
		        lVar5 = -0x8000000000000000;
		      }
		      if (*(int *)(System_DateTimeOffset_TypeInfo + 0x74) == 0) {
		        func_ii_306000(System_DateTimeOffset_TypeInfo);
		      }
		      System_DateTimeOffset__FromUnixTimeSeconds(&local_20,lVar5,0);
		      local_8 = local_18;
		      local_10 = local_20;
		      System_DateTimeOffset__ParseExact(&local_30,&local_10,0);
		      local_8 = local_28;
		      local_10 = local_30;
		      if (DAT_ram_00a63c4b == '\0') {
		        Mono_Security_ASN1__get_Item(&Localization_Culture_Culture_TypeInfo);
		        DAT_ram_00a63c4b = '\x01';
		      }
		      uVar1 = Gameplay_FeedbackForm_Model_Controll_FeedbackFormController__GetBase64ZipContent
		                        (*(undefined4 *)(*(int *)(Localization_Culture_Culture_TypeInfo + 0x5c) + 4)
		                         ,0);
		      uVar1 = System_DateTimeOffset__ToString(&local_10,StringLiteral_22542,uVar1,0);
		      *param4 = uVar1;
		    }
		  }
		  return iVar2;
		}
		*/

}
