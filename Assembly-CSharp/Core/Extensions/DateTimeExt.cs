using System;
using System.Globalization;
using Il2CppDummyDll;

namespace Core.Extensions
{
	// Token: 0x02000F05 RID: 3845
	[Token(Token = "0x2000F05")]
	public static class DateTimeExt
	{
		// Token: 0x06005D21 RID: 23841 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005D21")]
		[Address(RVA = "0xA9A7", Offset = "0xA9A7", VA = "0xA9A7")]
		public static CultureInfo GetDefaultCultureForDate()
		{
		/* --- GHIDRA: GetDefaultCultureForDate ---
		undefined4
		Core_Extensions_DateTimeExt__GetDefaultCultureForDate
		          (undefined8 param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int param1_00;
		  undefined8 local_8;
		  
		  local_8 = param1;
		  if (DAT_ram_00a5acd6 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_DateTime_TypeInfo);
		    DAT_ram_00a5acd6 = '\x01';
		  }
		  if (DAT_ram_00a5acd5 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Globalization_CultureInfo_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Extensions_DateTimeExt_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_22897);
		    DAT_ram_00a5acd5 = '\x01';
		  }
		  param1_00 = **(int **)(Core_Extensions_DateTimeExt_TypeInfo + 0x5c);
		  if (param1_00 == 0) {
		    param1_00 = unnamed_function_1417(System_Globalization_CultureInfo_TypeInfo);
		    func_ii_3041(param1_00,StringLiteral_22897,0);
		    **(int **)(Core_Extensions_DateTimeExt_TypeInfo + 0x5c) = param1_00;
		  }
		  if (*(int *)(System_DateTime_TypeInfo + 0x74) == 0) {
		    func_ii_306000(System_DateTime_TypeInfo);
		  }
		  uVar1 = System_DateTime__ToString(&local_8,param2,param1_00,0);
		  return uVar1;
		}
		*/

			return null;
		}

		// Token: 0x06005D22 RID: 23842 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005D22")]
		[Address(RVA = "0xA9A8", Offset = "0xA9A8", VA = "0xA9A8")]
		public static string ToGregorianCalenderTimeString(this DateTime date, string format)
		{
		/* --- GHIDRA: ToGregorianCalenderTimeString ---
		undefined4 Core_Extensions_DateTimeExt__ToGregorianCalenderTimeString(int param1,undefined4 param2)
		
		{
		  int param2_00;
		  int iVar1;
		  int param1_00;
		  
		  param1_00 = *(int *)(param1 + 0x10);
		  param2_00 = 0;
		  if (DAT_ram_00a5acf5 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_ContentStringMessage__get_Count__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_ContentStringMessage__get_Item__);
		    DAT_ram_00a5acf5 = '\x01';
		  }
		  if (0 < *(int *)(param1_00 + 0xc)) {
		    do {
		      iVar1 = Google_Protobuf_Collections_RepeatedField_Int32Enum___get_IsReadOnly
		                        (param1_00,param2_00,
		                         Method_Google_Protobuf_Collections_RepeatedField_ContentStringMessage__get_Item__
		                        );
		      if (*(int *)(iVar1 + 0xc) == 0x44) {
		        return *(undefined4 *)(iVar1 + 0x10);
		      }
		      param2_00 = param2_00 + 1;
		    } while (param2_00 < *(int *)(param1_00 + 0xc));
		  }
		  return 0;
		}
		*/

		/* --- GHIDRA: ToGregorianCalenderTimeString ---
		undefined4 Core_Extensions_DateTimeExt__ToGregorianCalenderTimeString(int param1,undefined4 param2)
		
		{
		  int param2_00;
		  int iVar1;
		  int param1_00;
		  
		  param1_00 = *(int *)(param1 + 0x10);
		  param2_00 = 0;
		  if (DAT_ram_00a5acf5 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_ContentStringMessage__get_Count__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_ContentStringMessage__get_Item__);
		    DAT_ram_00a5acf5 = '\x01';
		  }
		  if (0 < *(int *)(param1_00 + 0xc)) {
		    do {
		      iVar1 = Google_Protobuf_Collections_RepeatedField_Int32Enum___get_IsReadOnly
		                        (param1_00,param2_00,
		                         Method_Google_Protobuf_Collections_RepeatedField_ContentStringMessage__get_Item__
		                        );
		      if (*(int *)(iVar1 + 0xc) == 0x44) {
		        return *(undefined4 *)(iVar1 + 0x10);
		      }
		      param2_00 = param2_00 + 1;
		    } while (param2_00 < *(int *)(param1_00 + 0xc));
		  }
		  return 0;
		}
		*/

			return null;
		}

		// Token: 0x06005D23 RID: 23843 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005D23")]
		[Address(RVA = "0xA9A9", Offset = "0xA9A9", VA = "0xA9A9")]
		public static string ToGregorianCalenderTimeString(this DateTime date)
		{
			return null;
		}

		// Token: 0x040032D6 RID: 13014
		[Token(Token = "0x40032D6")]
		[FieldOffset(Offset = "0x0")]
		private static CultureInfo _cachedCulture;
	}
}
