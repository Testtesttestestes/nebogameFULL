using System;
using Il2CppDummyDll;
using Protocol.Dic;

namespace Core.Extensions.Dict
{
	// Token: 0x02000F73 RID: 3955
	[Token(Token = "0x2000F73")]
	public static class GameActivityDicExt
	{
		// Token: 0x06005F3B RID: 24379 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005F3B")]
		[Address(RVA = "0xAB86", Offset = "0xAB86", VA = "0xAB86")]
		public static string GetTextOnWidget(this GameActivityDic dict)
		{
		/* --- GHIDRA: GetTextOnWidget ---
		undefined4 Core_Extensions_Dict_GameActivityDicExt__GetTextOnWidget(int param1,undefined4 param2)
		
		{
		  int param2_00;
		  int iVar1;
		  undefined4 param1_00;
		  int iVar2;
		  
		  param1_00 = *(undefined4 *)(param1 + 0x14);
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
		  while (iVar2 != 0xab) {
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

		// Token: 0x06005F3C RID: 24380 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005F3C")]
		[Address(RVA = "0xAB87", Offset = "0xAB87", VA = "0xAB87")]
		public static string GetWidgetImageAssetId(this GameActivityDic dict)
		{
		/* --- GHIDRA: GetWidgetImageAssetId ---
		undefined4
		Core_Extensions_Dict_GameActivityDicExt__GetWidgetImageAssetId(int param1,undefined4 param2)
		
		{
		  int param2_00;
		  int iVar1;
		  int param1_00;
		  
		  param1_00 = *(int *)(param1 + 0x3c);
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
		      if (*(int *)(iVar1 + 0xc) == 0xa6) {
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
