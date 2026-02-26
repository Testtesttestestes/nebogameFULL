using System;
using Il2CppDummyDll;
using Protocol.Common;
using Protocol.Rating;

namespace Core.Extensions
{
	// Token: 0x02000F01 RID: 3841
	[Token(Token = "0x2000F01")]
	public static class ClanInfoExt
	{
		// Token: 0x06005D16 RID: 23830 RVA: 0x00010BD8 File Offset: 0x0000EDD8
		[Token(Token = "0x6005D16")]
		[Address(RVA = "0xA99C", Offset = "0xA99C", VA = "0xA99C")]
		public static long GetClanRating(this ClanInfo clan, ClanRatingTypes ratingType)
		{
		/* --- GHIDRA: GetClanRating ---
		undefined4 Core_Extensions_ClanInfoExt__GetClanRating(int param1,undefined4 param2)
		
		{
		  undefined8 uVar1;
		  
		  if (DAT_ram_00a5accf == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_Google_Protobuf_Collections_RepeatedField_long__get_Item__)
		    ;
		    DAT_ram_00a5accf = '\x01';
		  }
		  uVar1 = func_ii_7271(*(undefined4 *)(param1 + 0x24),3,
		                       Method_Google_Protobuf_Collections_RepeatedField_long__get_Item__);
		  return (int)uVar1;
		}
		*/

			return 0L;
		}

		// Token: 0x06005D17 RID: 23831 RVA: 0x00010BF0 File Offset: 0x0000EDF0
		[Token(Token = "0x6005D17")]
		[Address(RVA = "0xA99D", Offset = "0xA99D", VA = "0xA99D")]
		public static uint GetHonorRating(this ClanInfo clan)
		{
		/* --- GHIDRA: GetHonorRating ---
		undefined4 Core_Extensions_ClanInfoExt__GetHonorRating(int param1,undefined4 param2)
		
		{
		  undefined8 uVar1;
		  undefined4 param1_00;
		  undefined4 *puVar2;
		  int param1_01;
		  undefined4 param2_00;
		  
		  if (DAT_ram_00a5acd0 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_Sum_uint___);
		    Mono_Security_ASN1__get_Item(&System_Func_uint__long__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Extensions_ClanInfoExt___c__GetTotalMembersNum_b__2_0__);
		    Mono_Security_ASN1__get_Item(&Core_Extensions_ClanInfoExt___c_TypeInfo);
		    DAT_ram_00a5acd0 = '\x01';
		  }
		  param1_00 = *(undefined4 *)(param1 + 0x38);
		  if (*(int *)(Core_Extensions_ClanInfoExt___c_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Extensions_ClanInfoExt___c_TypeInfo);
		  }
		  puVar2 = *(undefined4 **)(Core_Extensions_ClanInfoExt___c_TypeInfo + 0x5c);
		  param1_01 = puVar2[1];
		  if (param1_01 == 0) {
		    if (*(int *)(Core_Extensions_ClanInfoExt___c_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Extensions_ClanInfoExt___c_TypeInfo);
		      puVar2 = *(undefined4 **)(Core_Extensions_ClanInfoExt___c_TypeInfo + 0x5c);
		    }
		    param2_00 = *puVar2;
		    param1_01 = unnamed_function_1417(System_Func_uint__long__TypeInfo);
		    System_Func_uint__Int32Enum___Invoke
		              (param1_01,param2_00,
		               Method_Core_Extensions_ClanInfoExt___c__GetTotalMembersNum_b__2_0__,0);
		    *(int *)(*(int *)(Core_Extensions_ClanInfoExt___c_TypeInfo + 0x5c) + 4) = param1_01;
		  }
		  uVar1 = System_Linq_Enumerable__Sum_object_
		                    (param1_00,param1_01,Method_System_Linq_Enumerable_Sum_uint___);
		  return (int)uVar1;
		}
		*/

			return 0U;
		}

		// Token: 0x06005D18 RID: 23832 RVA: 0x00010C08 File Offset: 0x0000EE08
		[Token(Token = "0x6005D18")]
		[Address(RVA = "0xA99E", Offset = "0xA99E", VA = "0xA99E")]
		public static int GetTotalMembersNum(this ClanInfo clan)
		{
		/* --- GHIDRA: GetTotalMembersNum ---
		undefined4 Core_Extensions_ClanInfoExt__GetTotalMembersNum(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a5acd1 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_Google_Protobuf_Collections_RepeatedField_uint__get_Item__)
		    ;
		    DAT_ram_00a5acd1 = '\x01';
		  }
		  uVar1 = Google_Protobuf_Collections_RepeatedField_Int32Enum___get_IsReadOnly
		                    (*(undefined4 *)(param1 + 0x38),2,
		                     Method_Google_Protobuf_Collections_RepeatedField_uint__get_Item__);
		  return uVar1;
		}
		*/

			return 0;
		}

		// Token: 0x06005D19 RID: 23833 RVA: 0x00010C20 File Offset: 0x0000EE20
		[Token(Token = "0x6005D19")]
		[Address(RVA = "0xA99F", Offset = "0xA99F", VA = "0xA99F")]
		public static int GetLegendMembersNum(this ClanInfo clan)
		{
		/* --- GHIDRA: GetLegendMembersNum ---
		undefined4 Core_Extensions_ClanInfoExt__GetLegendMembersNum(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a5acd2 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_Google_Protobuf_Collections_RepeatedField_uint__get_Item__)
		    ;
		    DAT_ram_00a5acd2 = '\x01';
		  }
		  uVar1 = Google_Protobuf_Collections_RepeatedField_Int32Enum___get_IsReadOnly
		                    (*(undefined4 *)(param1 + 0x38),1,
		                     Method_Google_Protobuf_Collections_RepeatedField_uint__get_Item__);
		  return uVar1;
		}
		*/

			return 0;
		}

		// Token: 0x06005D1A RID: 23834 RVA: 0x00010C38 File Offset: 0x0000EE38
		[Token(Token = "0x6005D1A")]
		[Address(RVA = "0xA9A0", Offset = "0xA9A0", VA = "0xA9A0")]
		public static int GetGeneralMembersNum(this ClanInfo clan)
		{
		/* --- GHIDRA: GetGeneralMembersNum ---
		void Core_Extensions_ClanInfoExt__GetGeneralMembersNum(undefined4 param1)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a5acd3 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Extensions_ClanInfoExt___c_TypeInfo);
		    DAT_ram_00a5acd3 = '\x01';
		  }
		  uVar1 = unnamed_function_1417(Core_Extensions_ClanInfoExt___c_TypeInfo);
		  **(undefined4 **)(Core_Extensions_ClanInfoExt___c_TypeInfo + 0x5c) = uVar1;
		  return;
		}
		*/

			return 0;
		}
	}
}
