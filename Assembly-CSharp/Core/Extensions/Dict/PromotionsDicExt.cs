using System;
using Il2CppDummyDll;
using Protocol.Dic;

namespace Core.Extensions.Dict
{
	// Token: 0x02000F93 RID: 3987
	[Token(Token = "0x2000F93")]
	public static class PromotionsDicExt
	{
		// Token: 0x06005F98 RID: 24472 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005F98")]
		[Address(RVA = "0xABD6", Offset = "0xABD6", VA = "0xABD6")]
		public static string GetEventBannerListAssetId(this PromotionsDic dict)
		{
		/* --- GHIDRA: GetEventBannerListAssetId ---
		undefined4
		Core_Extensions_Dict_PromotionsDicExt__GetEventBannerListAssetId(int param1,undefined4 param2)
		
		{
		  int param2_00;
		  int iVar1;
		  int param1_00;
		  undefined4 uVar2;
		  
		  param1_00 = *(int *)(param1 + 0x1c);
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
		                             ), *(int *)(iVar1 + 0xc) != 0xcc) {
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

		// Token: 0x06005F99 RID: 24473 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005F99")]
		[Address(RVA = "0xABD7", Offset = "0xABD7", VA = "0xABD7")]
		public static string GetEventBannerEventAssetId(this PromotionsDic dict)
		{
		/* --- GHIDRA: GetEventBannerEventAssetId ---
		undefined4
		Core_Extensions_Dict_PromotionsDicExt__GetEventBannerEventAssetId(int param1,undefined4 param2)
		
		{
		  int param2_00;
		  int iVar1;
		  int param1_00;
		  undefined4 uVar2;
		  
		  param1_00 = *(int *)(param1 + 0x1c);
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
		                             ), *(int *)(iVar1 + 0xc) != 99) {
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

		// Token: 0x06005F9A RID: 24474 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005F9A")]
		[Address(RVA = "0xABD8", Offset = "0xABD8", VA = "0xABD8")]
		public static string GetInfoWindowImageAssetId(this PromotionsDic dict)
		{
		/* --- GHIDRA: GetInfoWindowImageAssetId ---
		undefined4
		Core_Extensions_Dict_PromotionsDicExt__GetInfoWindowImageAssetId(int param1,undefined4 param2)
		
		{
		  int param2_00;
		  int iVar1;
		  int param1_00;
		  
		  param1_00 = *(int *)(param1 + 0x20);
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
		      if (*(int *)(iVar1 + 0xc) == 0x55) {
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

		// Token: 0x06005F9B RID: 24475 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005F9B")]
		[Address(RVA = "0x1EFD", Offset = "0x1EFD", VA = "0x1EFD")]
		public static string GetWideBannerAssetId(this PromotionsDic dict)
		{
		/* --- GHIDRA: GetWideBannerAssetId ---
		undefined4 Core_Extensions_Dict_PromotionsDicExt__GetWideBannerAssetId(int param1,undefined4 param2)
		
		{
		  int param2_00;
		  int iVar1;
		  int param1_00;
		  
		  param1_00 = *(int *)(param1 + 0x20);
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
		      if (*(int *)(iVar1 + 0xc) == 0x54) {
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

		// Token: 0x06005F9C RID: 24476 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005F9C")]
		[Address(RVA = "0x1EFE", Offset = "0x1EFE", VA = "0x1EFE")]
		public static string GetBannerText(this PromotionsDic dict)
		{
		/* --- GHIDRA: GetBannerText ---
		int * Core_Extensions_Dict_PromotionsDicExt__GetBannerText(int *param1)
		
		{
		  if (*param1 == 0) {
		    return param1;
		  }
		  System_Data_DataSet__ValidateLocaleConstraint(*param1);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

			return null;
		}

		// Token: 0x06005F9D RID: 24477 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005F9D")]
		[Address(RVA = "0xABD9", Offset = "0xABD9", VA = "0xABD9")]
		public static string GetDescription(this PromotionsDic dict)
		{
		/* --- GHIDRA: GetDescription ---
		int Core_Extensions_Dict_PromotionsDicExt__GetDescription(int param1,undefined4 param2)
		
		{
		  int param1_00;
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a5ad8e == '\0') {
		    Mono_Security_ASN1__get_Item(&Protocol_Common_ClanShortInfo_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Common_UserInfo_TypeInfo);
		    DAT_ram_00a5ad8e = '\x01';
		  }
		  param1_00 = unnamed_function_1417(Protocol_Common_UserInfo_TypeInfo);
		  Protocol_Common_UserInfo__pb__Google_Protobuf_IMessage_get_Descriptor(param1_00,0);
		  *(undefined4 *)(param1_00 + 0x1c) = *(undefined4 *)(param1 + 0x1c);
		  uVar1 = unnamed_function_1417(Protocol_Common_ClanShortInfo_TypeInfo);
		  Protocol_Common_ClanShortInfo__pb__Google_Protobuf_IMessage_get_Descriptor(uVar1,0);
		  *(undefined4 *)(param1_00 + 0x40) = uVar1;
		  *(undefined4 *)(param1_00 + 0x24) = *(undefined4 *)(param1 + 0x24);
		  uVar1 = *(undefined4 *)(param1 + 0x3c);
		  *(undefined4 *)(param1_00 + 0x30) = 0;
		  *(undefined4 *)(param1_00 + 0x2c) = uVar1;
		  *(undefined4 *)(param1_00 + 0x20) = *(undefined4 *)(param1 + 0x20);
		  Protocol_Common_UserInfo__get_Nick(param1_00,*(undefined4 *)(param1 + 0x18),0);
		  *(undefined4 *)(param1_00 + 0x28) = *(undefined4 *)(param1 + 0x38);
		  *(undefined8 *)(param1_00 + 0x10) = *(undefined8 *)(param1 + 0x10);
		  return param1_00;
		}
		*/

			return null;
		}
	}
}
