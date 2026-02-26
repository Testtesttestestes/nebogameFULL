using System;
using Il2CppDummyDll;
using Protocol.Dic;

namespace Core.Extensions.Dict
{
	// Token: 0x02000F2E RID: 3886
	[Token(Token = "0x2000F2E")]
	public static class ClanBuildingViewDicExt
	{
		// Token: 0x06005DA5 RID: 23973 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005DA5")]
		[Address(RVA = "0xAA0E", Offset = "0xAA0E", VA = "0xAA0E")]
		public static string GetImageAssetId(this ClanBuildingViewDic cultDict)
		{
		/* --- GHIDRA: GetImageAssetId ---
		undefined4
		Core_Extensions_Dict_ClanBuildingViewDicExt__GetImageAssetId(int param1,undefined4 param2)
		
		{
		  int param2_00;
		  int iVar1;
		  int param1_00;
		  undefined4 uVar2;
		  
		  param1_00 = *(int *)(param1 + 0x30);
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
		                             ), *(int *)(iVar1 + 0xc) != 0xd) {
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

		// Token: 0x06005DA6 RID: 23974 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005DA6")]
		[Address(RVA = "0xAA0F", Offset = "0xAA0F", VA = "0xAA0F")]
		public static string GetAnimationAssetId(this ClanBuildingViewDic cultDict)
		{
		/* --- GHIDRA: GetAnimationAssetId ---
		undefined4
		Core_Extensions_Dict_ClanBuildingViewDicExt__GetAnimationAssetId(int param1,undefined4 param2)
		
		{
		  int param2_00;
		  int iVar1;
		  int param1_00;
		  undefined4 uVar2;
		  
		  param1_00 = *(int *)(param1 + 0x30);
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
		                             ), *(int *)(iVar1 + 0xc) != 0x8f) {
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

		// Token: 0x06005DA7 RID: 23975 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005DA7")]
		[Address(RVA = "0xAA10", Offset = "0xAA10", VA = "0xAA10")]
		public static string GetMiniatureAssetId(this ClanBuildingViewDic cultDict)
		{
		/* --- GHIDRA: GetMiniatureAssetId ---
		int Core_Extensions_Dict_ClanBuildingViewDicExt__GetMiniatureAssetId(int param1,undefined4 param2)
		
		{
		  int param2_00;
		  int iVar1;
		  int iVar2;
		  
		  iVar2 = *(int *)(param1 + 0x30);
		  param2_00 = 0;
		  if (DAT_ram_00a5acf4 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_ContentResourceAsset__get_Count__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_ContentResourceAsset__get_Item__);
		    DAT_ram_00a5acf4 = '\x01';
		  }
		  if (0 < *(int *)(iVar2 + 0xc)) {
		    do {
		      iVar1 = Google_Protobuf_Collections_RepeatedField_Int32Enum___get_IsReadOnly
		                        (iVar2,param2_00,
		                         Method_Google_Protobuf_Collections_RepeatedField_ContentResourceAsset__get_Item__
		                        );
		      if (*(int *)(iVar1 + 0xc) == 0xd) {
		        param2_00 = *(int *)(iVar1 + 0x10);
		        goto code_r0x812d126b;
		      }
		      param2_00 = param2_00 + 1;
		    } while (param2_00 < *(int *)(iVar2 + 0xc));
		    param2_00 = 0;
		  }
		code_r0x812d126b:
		  iVar2 = func_ii_4769(param2_00,0);
		  if (iVar2 != 0) {
		    iVar2 = *(int *)(param1 + 0x30);
		    if (DAT_ram_00a5acf4 == '\0') {
		      Mono_Security_ASN1__get_Item
		                (&Method_Google_Protobuf_Collections_RepeatedField_ContentResourceAsset__get_Count__
		                );
		      Mono_Security_ASN1__get_Item
		                (&Method_Google_Protobuf_Collections_RepeatedField_ContentResourceAsset__get_Item__)
		      ;
		      DAT_ram_00a5acf4 = '\x01';
		    }
		    param2_00 = 0;
		    if (0 < *(int *)(iVar2 + 0xc)) {
		      while (iVar1 = Google_Protobuf_Collections_RepeatedField_Int32Enum___get_IsReadOnly
		                               (iVar2,param2_00,
		                                Method_Google_Protobuf_Collections_RepeatedField_ContentResourceAsset__get_Item__
		                               ), *(int *)(iVar1 + 0xc) != 0xe) {
		        param2_00 = param2_00 + 1;
		        if (*(int *)(iVar2 + 0xc) <= param2_00) {
		          return 0;
		        }
		      }
		      param2_00 = *(int *)(iVar1 + 0x10);
		    }
		  }
		  return param2_00;
		}
		*/

			return null;
		}

		// Token: 0x06005DA8 RID: 23976 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005DA8")]
		[Address(RVA = "0xAA11", Offset = "0xAA11", VA = "0xAA11")]
		public static string GetIsleViewAssetId(this ClanBuildingViewDic clanBuildingViewsDic)
		{
		/* --- GHIDRA: GetIsleViewAssetId ---
		undefined4
		Core_Extensions_Dict_ClanBuildingViewDicExt__GetIsleViewAssetId(int param1,undefined4 param2)
		
		{
		  int param2_00;
		  int iVar1;
		  int param1_00;
		  undefined4 uVar2;
		  
		  param1_00 = *(int *)(param1 + 0x4c);
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
		                             ), *(int *)(iVar1 + 0xc) != 0x6d) {
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
	}
}
