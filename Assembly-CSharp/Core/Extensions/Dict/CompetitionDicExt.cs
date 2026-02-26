using System;
using Il2CppDummyDll;
using Protocol.Dic;

namespace Core.Extensions.Dict
{
	// Token: 0x02000F3B RID: 3899
	[Token(Token = "0x2000F3B")]
	public static class CompetitionDicExt
	{
		// Token: 0x06005DE7 RID: 24039 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005DE7")]
		[Address(RVA = "0xAA50", Offset = "0xAA50", VA = "0xAA50")]
		public static string GetTitle(this CompetitionDic dict)
		{
		/* --- GHIDRA: GetTitle ---
		undefined4 Core_Extensions_Dict_CompetitionDicExt__GetTitle(int param1,undefined4 param2)
		
		{
		  int param2_00;
		  int iVar1;
		  undefined4 param1_00;
		  int iVar2;
		  
		  param1_00 = *(undefined4 *)(param1 + 0x18);
		  param2_00 = 0;
		  if (DAT_ram_00a5acf4 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_ContentResourceAsset__get_Count__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_ContentResourceAsset__get_Item__);
		    DAT_ram_00a5acf4 = '\x01';
		  }
		  iVar1 = Google_Protobuf_Collections_RepeatedField_Int32Enum___get_IsReadOnly
		                    (param1_00,0,
		                     Method_Google_Protobuf_Collections_RepeatedField_ContentResourceAsset__get_Item__
		                    );
		  iVar2 = *(int *)(iVar1 + 0xc);
		  while (iVar2 != 0xe1) {
		    param2_00 = param2_00 + 1;
		    iVar1 = Google_Protobuf_Collections_RepeatedField_Int32Enum___get_IsReadOnly
		                      (param1_00,param2_00,
		                       Method_Google_Protobuf_Collections_RepeatedField_ContentResourceAsset__get_Item__
		                      );
		    iVar2 = *(int *)(iVar1 + 0xc);
		  }
		  return *(undefined4 *)(iVar1 + 0x10);
		}
		*/

			return null;
		}

		// Token: 0x06005DE8 RID: 24040 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005DE8")]
		[Address(RVA = "0xAA51", Offset = "0xAA51", VA = "0xAA51")]
		public static string GetIcon(this CompetitionDic dict)
		{
		/* --- GHIDRA: GetIcon ---
		undefined4 Core_Extensions_Dict_CompetitionDicExt__GetIcon(int param1,undefined4 param2)
		
		{
		  int param2_00;
		  int iVar1;
		  int param1_00;
		  
		  param1_00 = *(int *)(param1 + 0x18);
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
		      if (*(int *)(iVar1 + 0xc) == 0xcb) {
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
