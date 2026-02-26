using System;
using Il2CppDummyDll;
using Protocol.Dic;

namespace Core.Extensions.Dict
{
	// Token: 0x02000F25 RID: 3877
	[Token(Token = "0x2000F25")]
	public static class BaseOptionExt
	{
		// Token: 0x06005D97 RID: 23959 RVA: 0x00010DD0 File Offset: 0x0000EFD0
		[Token(Token = "0x6005D97")]
		[Address(RVA = "0xAA01", Offset = "0xAA01", VA = "0xAA01")]
		public static double GetExternalPrice(this BaseOption baseOption, uint currencyId)
		{
		/* --- GHIDRA: GetExternalPrice ---
		undefined4 Core_Extensions_Dict_BaseOptionExt__GetExternalPrice(int param1,undefined4 param2)
		
		{
		  int param2_00;
		  int iVar1;
		  int param1_00;
		  
		  param1_00 = *(int *)(param1 + 0x2c);
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
		      if (*(int *)(iVar1 + 0xc) == 0x1a) {
		        return *(undefined4 *)(iVar1 + 0x10);
		      }
		      param2_00 = param2_00 + 1;
		    } while (param2_00 < *(int *)(param1_00 + 0xc));
		  }
		  return 0;
		}
		*/

			return 0.0;
		}
	}
}
