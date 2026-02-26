using System;
using Il2CppDummyDll;
using Protocol.Dic;

namespace Core.Extensions.Dict
{
	// Token: 0x02000F18 RID: 3864
	[Token(Token = "0x2000F18")]
	public static class AccountOptionsDicExt
	{
		// Token: 0x06005D56 RID: 23894 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005D56")]
		[Address(RVA = "0x1D39", Offset = "0x1D39", VA = "0x1D39")]
		public static string GetTitle(this AccountOptionsDic dic)
		{
		/* --- GHIDRA: GetTitle ---
		undefined4 Core_Extensions_Dict_AccountOptionsDicExt__GetTitle(int param1,undefined4 param2)
		
		{
		  if (2147483648.0 <= ABS(*(double *)(param1 + 0x20))) {
		    return 0x80000000;
		  }
		  return (int)*(double *)(param1 + 0x20);
		}
		*/

			return null;
		}

		// Token: 0x06005D57 RID: 23895 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005D57")]
		[Address(RVA = "0xA9C7", Offset = "0xA9C7", VA = "0xA9C7")]
		public static string GetBankBgAssetId(this AccountOptionsDic dic)
		{
		/* --- GHIDRA: GetBankBgAssetId ---
		undefined4 Core_Extensions_Dict_AccountOptionsDicExt__GetBankBgAssetId(int param1,undefined4 param2)
		
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
		      if (*(int *)(iVar1 + 0xc) == 0xad) {
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
	}
}
