using System;
using Il2CppDummyDll;
using Protocol.Dic;

namespace Core.Extensions.Dict
{
	// Token: 0x02000F88 RID: 3976
	[Token(Token = "0x2000F88")]
	public static class OptionStickerDicExt
	{
		// Token: 0x06005F74 RID: 24436 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005F74")]
		[Address(RVA = "0xABB6", Offset = "0xABB6", VA = "0xABB6")]
		public static string GetBadgeAssetId(this OptionStickerDic dic)
		{
		/* --- GHIDRA: GetBadgeAssetId ---
		undefined4 Core_Extensions_Dict_OptionStickerDicExt__GetBadgeAssetId(int param1,undefined4 param2)
		
		{
		  int param2_00;
		  int iVar1;
		  int param1_00;
		  undefined4 uVar2;
		  
		  param1_00 = *(int *)(param1 + 0x18);
		  param2_00 = 0;
		  if (DAT_ram_00a5acf4 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_ContentResourceAsset__get_Count__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_ContentResourceAsset__get_Item__);
		    DAT_ram_00a5acf4 = '\x01';
		  }
		  if (*(int *)(param1_00 + 0xc) < 1) {
		    uVar2 = 0;
		  }
		  else {
		    while (iVar1 = Google_Protobuf_Collections_RepeatedField_Int32Enum___get_IsReadOnly
		                             (param1_00,param2_00,
		                              Method_Google_Protobuf_Collections_RepeatedField_ContentResourceAsset__get_Item__
		                             ), *(int *)(iVar1 + 0xc) != 0x7b) {
		      param2_00 = param2_00 + 1;
		      if (*(int *)(param1_00 + 0xc) <= param2_00) {
		        return 0;
		      }
		    }
		    uVar2 = *(undefined4 *)(iVar1 + 0x10);
		  }
		  return uVar2;
		}
		*/

			return null;
		}

		// Token: 0x06005F75 RID: 24437 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005F75")]
		[Address(RVA = "0x1D3C", Offset = "0x1D3C", VA = "0x1D3C")]
		public static string GetSaleRibbon256AssetId(this OptionStickerDic dic)
		{
			return null;
		}

		// Token: 0x06005F76 RID: 24438 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005F76")]
		[Address(RVA = "0xABB7", Offset = "0xABB7", VA = "0xABB7")]
		public static string GetMarketRibbonAssetId(this OptionStickerDic dic)
		{
		/* --- GHIDRA: GetMarketRibbonAssetId ---
		undefined4
		Core_Extensions_Dict_OptionStickerDicExt__GetMarketRibbonAssetId(int param1,undefined4 param2)
		
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
		      if (*(int *)(iVar1 + 0xc) == 0xaf) {
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
