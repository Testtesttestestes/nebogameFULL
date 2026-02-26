using System;
using Il2CppDummyDll;
using Protocol.Common;
using Protocol.Dic;

namespace Core.Extensions.Dict
{
	// Token: 0x02000F1A RID: 3866
	[Token(Token = "0x2000F1A")]
	public static class AnnouncementsDictExt
	{
		// Token: 0x06005D59 RID: 23897 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005D59")]
		[Address(RVA = "0xA9C9", Offset = "0xA9C9", VA = "0xA9C9")]
		public static string GetTitle(this AnnouncementsDic dict)
		{
		/* --- GHIDRA: GetTitle ---
		undefined4 Core_Extensions_Dict_AnnouncementsDictExt__GetTitle(int param1,undefined4 param2)
		
		{
		  int param2_00;
		  int iVar1;
		  int param1_00;
		  
		  param1_00 = *(int *)(param1 + 0x28);
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
		      if (*(int *)(iVar1 + 0xc) == 199) {
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

		// Token: 0x06005D5A RID: 23898 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005D5A")]
		[Address(RVA = "0xA9CA", Offset = "0xA9CA", VA = "0xA9CA")]
		public static string GetDescription(this AnnouncementsDic dict)
		{
		/* --- GHIDRA: GetDescription ---
		undefined4 Core_Extensions_Dict_AnnouncementsDictExt__GetDescription(int param1,undefined4 param2)
		
		{
		  int param2_00;
		  int iVar1;
		  int param1_00;
		  
		  param1_00 = *(int *)(param1 + 0x28);
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
		      if (*(int *)(iVar1 + 0xc) == 200) {
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

		// Token: 0x06005D5B RID: 23899 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005D5B")]
		[Address(RVA = "0xA9CB", Offset = "0xA9CB", VA = "0xA9CB")]
		public static string GetActivityBtnLabel(this AnnouncementsDic dict)
		{
		/* --- GHIDRA: GetActivityBtnLabel ---
		undefined4
		Core_Extensions_Dict_AnnouncementsDictExt__GetActivityBtnLabel
		          (int param1,int param2,undefined4 param3)
		
		{
		  int param2_00;
		  int iVar1;
		  int param1_00;
		  
		  param1_00 = *(int *)(param1 + 0x24);
		  param2_00 = 0;
		  if (DAT_ram_00a5acf4 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_ContentResourceAsset__get_Count__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_ContentResourceAsset__get_Item__);
		    DAT_ram_00a5acf4 = '\x01';
		  }
		  if (0 < *(int *)(param1_00 + 0xc)) {
		    do {
		      iVar1 = Google_Protobuf_Collections_RepeatedField_Int32Enum___get_IsReadOnly
		                        (param1_00,param2_00,
		                         Method_Google_Protobuf_Collections_RepeatedField_ContentResourceAsset__get_Item__
		                        );
		      if (*(int *)(iVar1 + 0xc) == param2) {
		        return iVar1;
		      }
		      param2_00 = param2_00 + 1;
		    } while (param2_00 < *(int *)(param1_00 + 0xc));
		  }
		  return 0;
		}
		*/

			return null;
		}

		// Token: 0x06005D5C RID: 23900 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005D5C")]
		[Address(RVA = "0xA9CC", Offset = "0xA9CC", VA = "0xA9CC")]
		public static ContentResourceAsset GetAsset(this AnnouncementsDic dict, AnnouncementsDic.Types.ContentResource id)
		{
		/* --- GHIDRA: GetAsset ---
		undefined4 Core_Extensions_Dict_AnnouncementsDictExt__GetAsset(int param1,undefined4 param2)
		
		{
		  int param2_00;
		  int iVar1;
		  undefined4 param1_00;
		  int iVar2;
		  
		  param1_00 = *(undefined4 *)(param1 + 0x24);
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
		  while (iVar2 != 0xde) {
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

		// Token: 0x06005D5D RID: 23901 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005D5D")]
		[Address(RVA = "0xA9CD", Offset = "0xA9CD", VA = "0xA9CD")]
		public static string GetBackgroundAssetId(this AnnouncementsDic dict)
		{
		/* --- GHIDRA: GetBackgroundAssetId ---
		undefined4
		Core_Extensions_Dict_AnnouncementsDictExt__GetBackgroundAssetId(int param1,undefined4 param2)
		
		{
		  int param2_00;
		  int iVar1;
		  undefined4 param1_00;
		  int iVar2;
		  
		  param1_00 = *(undefined4 *)(param1 + 0x24);
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
		  while (iVar2 != 0xdf) {
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

		// Token: 0x06005D5E RID: 23902 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005D5E")]
		[Address(RVA = "0xA9CE", Offset = "0xA9CE", VA = "0xA9CE")]
		public static string GetImgAssetId(this AnnouncementsDic dict)
		{
		/* --- GHIDRA: GetImgAssetId ---
		undefined4 Core_Extensions_Dict_AnnouncementsDictExt__GetImgAssetId(int param1,undefined4 param2)
		
		{
		  int param2_00;
		  int iVar1;
		  int param1_00;
		  undefined4 uVar2;
		  
		  param1_00 = *(int *)(param1 + 0x58);
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
		                             ), *(int *)(iVar1 + 0xc) != 3) {
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
