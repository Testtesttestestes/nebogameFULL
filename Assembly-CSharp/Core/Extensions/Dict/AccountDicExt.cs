using System;
using Il2CppDummyDll;
using Protocol.Dic;

namespace Core.Extensions.Dict
{
	// Token: 0x02000F17 RID: 3863
	[Token(Token = "0x2000F17")]
	public static class AccountDicExt
	{
		// Token: 0x06005D4C RID: 23884 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005D4C")]
		[Address(RVA = "0x1D56", Offset = "0x1D56", VA = "0x1D56")]
		public static string GetTitle(this AccountDic dict)
		{
			return null;
		}

		// Token: 0x06005D4D RID: 23885 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005D4D")]
		[Address(RVA = "0xA9BF", Offset = "0xA9BF", VA = "0xA9BF")]
		public static string GetTitleInList(this AccountDic dict)
		{
		/* --- GHIDRA: GetTitleInList ---
		undefined4 Core_Extensions_Dict_AccountDicExt__GetTitleInList(int param1,undefined4 param2)
		
		{
		  int param2_00;
		  int iVar1;
		  int param1_00;
		  
		  param1_00 = *(int *)(param1 + 0x34);
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
		      if (*(int *)(iVar1 + 0xc) == 0x69) {
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

		// Token: 0x06005D4E RID: 23886 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005D4E")]
		[Address(RVA = "0xA9C0", Offset = "0xA9C0", VA = "0xA9C0")]
		public static string GetTitleInBanner(this AccountDic dict)
		{
		/* --- GHIDRA: GetTitleInBanner ---
		undefined4 Core_Extensions_Dict_AccountDicExt__GetTitleInBanner(int param1,undefined4 param2)
		
		{
		  int param2_00;
		  int iVar1;
		  int param1_00;
		  
		  param1_00 = *(int *)(param1 + 0x34);
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
		      if (*(int *)(iVar1 + 0xc) == 0x5d) {
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

		// Token: 0x06005D4F RID: 23887 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005D4F")]
		[Address(RVA = "0xA9C1", Offset = "0xA9C1", VA = "0xA9C1")]
		public static string GetDescription(this AccountDic dict)
		{
		/* --- GHIDRA: GetDescription ---
		undefined4 Core_Extensions_Dict_AccountDicExt__GetDescription(int param1,undefined4 param2)
		
		{
		  int param2_00;
		  int iVar1;
		  int param1_00;
		  
		  param1_00 = *(int *)(param1 + 0x34);
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
		      if (*(int *)(iVar1 + 0xc) == 0x68) {
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

		// Token: 0x06005D50 RID: 23888 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005D50")]
		[Address(RVA = "0xA9C2", Offset = "0xA9C2", VA = "0xA9C2")]
		public static string GetDescriptionInBanner(this AccountDic dict)
		{
		/* --- GHIDRA: GetDescriptionInBanner ---
		undefined4 Core_Extensions_Dict_AccountDicExt__GetDescriptionInBanner(int param1,undefined4 param2)
		
		{
		  int param2_00;
		  int iVar1;
		  int param1_00;
		  
		  param1_00 = *(int *)(param1 + 0x34);
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
		      if (*(int *)(iVar1 + 0xc) == 0x67) {
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

		// Token: 0x06005D51 RID: 23889 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005D51")]
		[Address(RVA = "0xA9C3", Offset = "0xA9C3", VA = "0xA9C3")]
		public static string GetClarificationDescription(this AccountDic dict)
		{
		/* --- GHIDRA: GetClarificationDescription ---
		undefined4
		Core_Extensions_Dict_AccountDicExt__GetClarificationDescription(int param1,undefined4 param2)
		
		{
		  int param2_00;
		  int iVar1;
		  undefined4 param1_00;
		  int iVar2;
		  
		  param1_00 = *(undefined4 *)(param1 + 0x30);
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
		  while (iVar2 != 0x6e) {
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

		// Token: 0x06005D52 RID: 23890 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005D52")]
		[Address(RVA = "0xA9C4", Offset = "0xA9C4", VA = "0xA9C4")]
		public static string GetImageListItemAssetId(this AccountDic dict)
		{
		/* --- GHIDRA: GetImageListItemAssetId ---
		undefined4
		Core_Extensions_Dict_AccountDicExt__GetImageListItemAssetId(int param1,int param2,undefined4 param3)
		
		{
		  int param2_00;
		  int iVar1;
		  undefined4 param1_00;
		  int iVar2;
		  
		  param1_00 = *(undefined4 *)(param1 + 0x30);
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
		  while (param2 != iVar2) {
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

		// Token: 0x06005D53 RID: 23891 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005D53")]
		[Address(RVA = "0xA9C5", Offset = "0xA9C5", VA = "0xA9C5")]
		public static string GetContentResourceAssetId(this AccountDic dict, AccountDic.Types.ContentResource id)
		{
		/* --- GHIDRA: GetContentResourceAssetId ---
		undefined4
		Core_Extensions_Dict_AccountDicExt__GetContentResourceAssetId(int param1,undefined4 param2)
		
		{
		  int param2_00;
		  int iVar1;
		  undefined4 param1_00;
		  int iVar2;
		  
		  param1_00 = *(undefined4 *)(param1 + 0x30);
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
		  while (iVar2 != 0x71) {
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

		// Token: 0x06005D54 RID: 23892 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005D54")]
		[Address(RVA = "0xA9C6", Offset = "0xA9C6", VA = "0xA9C6")]
		public static string GetFullImageAssetId(this AccountDic dict)
		{
		/* --- GHIDRA: GetFullImageAssetId ---
		undefined4 Core_Extensions_Dict_AccountDicExt__GetFullImageAssetId(int param1,undefined4 param2)
		
		{
		  int param2_00;
		  int iVar1;
		  int param1_00;
		  undefined4 uVar2;
		  
		  param1_00 = *(int *)(param1 + 0x20);
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
		                             ), *(int *)(iVar1 + 0xc) != 0x7d) {
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

		// Token: 0x06005D55 RID: 23893 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005D55")]
		[Address(RVA = "0x1E06", Offset = "0x1E06", VA = "0x1E06")]
		public static string GetIsleMarkerAnimationAssetId(this AccountDic dict)
		{
		/* --- GHIDRA: GetIsleMarkerAnimationAssetId ---
		undefined4
		Core_Extensions_Dict_AccountDicExt__GetIsleMarkerAnimationAssetId
		          (int param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 uVar3;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a58d22 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_string__GameAssetViewSpriteRenderer__Add__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_string__GameAssetViewSpriteRenderer__TryGetValue__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_UnityEngine_Object_Instantiate_GameAssetViewSpriteRenderer___);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    DAT_ram_00a58d22 = '\x01';
		  }
		  local_4 = 0;
		  iVar1 = Spine_Unity_AttachmentTools_AttachmentRegionExtensions__GetRegion
		                    (*(undefined4 *)(param1 + 0x28),param2,&local_4,
		                     Method_System_Collections_Generic_Dictionary_string__GameAssetViewSpriteRenderer__TryGetValue__
		                    );
		  if (iVar1 == 0) {
		    uVar3 = *(undefined4 *)(param1 + 0x24);
		    uVar2 = System_Collections_Generic_SortedDictionary_Enumerator_object__object___get_Current
		                      (param1,0);
		    if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		      func_ii_306000(UnityEngine_Object_TypeInfo);
		    }
		    local_4 = func_ii_6805(uVar3,uVar2,
		                           Method_UnityEngine_Object_Instantiate_GameAssetViewSpriteRenderer___);
		    func_ii_7665(local_4,*(undefined4 *)(param1 + 0x18),0);
		    uVar2 = local_4;
		    uVar3 = func_ii_4075(param1,0);
		    CloudsFly_BaseWorldObjectRenderer__get_SortingOrderWithDelta(uVar2,uVar3,0);
		    uVar2 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                      (local_4,0);
		    Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		              (uVar2,0,0);
		    System_Reflection_FieldInfo__get_IsStatic
		              (*(undefined4 *)(param1 + 0x28),param2,local_4,
		               Method_System_Collections_Generic_Dictionary_string__GameAssetViewSpriteRenderer__Add__
		              );
		  }
		  AssetContent_GameAssetViewSpriteRenderer__get_AssetId(local_4,param2,0);
		  return local_4;
		}
		*/

			return null;
		}
	}
}
