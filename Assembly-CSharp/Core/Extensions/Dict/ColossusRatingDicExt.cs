using System;
using Il2CppDummyDll;
using Protocol.Dic;

namespace Core.Extensions.Dict
{
	// Token: 0x02000F39 RID: 3897
	[Token(Token = "0x2000F39")]
	public static class ColossusRatingDicExt
	{
		// Token: 0x06005DD7 RID: 24023 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005DD7")]
		[Address(RVA = "0xAA40", Offset = "0xAA40", VA = "0xAA40")]
		public static string GetTitle(this ColossusRatingDic dic)
		{
		/* --- GHIDRA: GetTitle ---
		undefined4 Core_Extensions_Dict_ColossusRatingDicExt__GetTitle(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  int iVar2;
		  int iVar3;
		  
		  iVar3 = *(int *)(param1 + 0x24);
		  iVar1 = 0;
		  if (DAT_ram_00a5acf5 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_ContentStringMessage__get_Count__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_ContentStringMessage__get_Item__);
		    DAT_ram_00a5acf5 = '\x01';
		  }
		  if (0 < *(int *)(iVar3 + 0xc)) {
		    do {
		      iVar2 = Google_Protobuf_Collections_RepeatedField_Int32Enum___get_IsReadOnly
		                        (iVar3,iVar1,
		                         Method_Google_Protobuf_Collections_RepeatedField_ContentStringMessage__get_Item__
		                        );
		      if (*(int *)(iVar2 + 0xc) == 0x99) {
		        if (*(int *)(iVar2 + 0x10) != 0) {
		          return *(int *)(iVar2 + 0x10);
		        }
		        break;
		      }
		      iVar1 = iVar1 + 1;
		    } while (iVar1 < *(int *)(iVar3 + 0xc));
		  }
		  iVar3 = *(int *)(param1 + 0x24);
		  iVar1 = 0;
		  if (DAT_ram_00a5acf5 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_ContentStringMessage__get_Count__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_ContentStringMessage__get_Item__);
		    DAT_ram_00a5acf5 = '\x01';
		  }
		  if (0 < *(int *)(iVar3 + 0xc)) {
		    do {
		      iVar2 = Google_Protobuf_Collections_RepeatedField_Int32Enum___get_IsReadOnly
		                        (iVar3,iVar1,
		                         Method_Google_Protobuf_Collections_RepeatedField_ContentStringMessage__get_Item__
		                        );
		      if (*(int *)(iVar2 + 0xc) == 0x97) {
		        if (*(int *)(iVar2 + 0x10) != 0) {
		          return *(int *)(iVar2 + 0x10);
		        }
		        break;
		      }
		      iVar1 = iVar1 + 1;
		    } while (iVar1 < *(int *)(iVar3 + 0xc));
		  }
		  iVar3 = *(int *)(param1 + 0x24);
		  iVar1 = 0;
		  if (DAT_ram_00a5acf5 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_ContentStringMessage__get_Count__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_ContentStringMessage__get_Item__);
		    DAT_ram_00a5acf5 = '\x01';
		  }
		  if (0 < *(int *)(iVar3 + 0xc)) {
		    do {
		      iVar2 = Google_Protobuf_Collections_RepeatedField_Int32Enum___get_IsReadOnly
		                        (iVar3,iVar1,
		                         Method_Google_Protobuf_Collections_RepeatedField_ContentStringMessage__get_Item__
		                        );
		      if (*(int *)(iVar2 + 0xc) == 0x95) {
		        return *(undefined4 *)(iVar2 + 0x10);
		      }
		      iVar1 = iVar1 + 1;
		    } while (iVar1 < *(int *)(iVar3 + 0xc));
		  }
		  return 0;
		}
		*/

			return null;
		}

		// Token: 0x06005DD8 RID: 24024 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005DD8")]
		[Address(RVA = "0xAA41", Offset = "0xAA41", VA = "0xAA41")]
		public static string GetDescription(this ColossusRatingDic dic)
		{
		/* --- GHIDRA: GetDescription ---
		int Core_Extensions_Dict_ColossusRatingDicExt__GetDescription(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  int iVar2;
		  int iVar3;
		  
		  iVar3 = *(int *)(param1 + 0x20);
		  iVar1 = 0;
		  if (DAT_ram_00a5acf4 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_ContentResourceAsset__get_Count__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_ContentResourceAsset__get_Item__);
		    DAT_ram_00a5acf4 = '\x01';
		  }
		  if (0 < *(int *)(iVar3 + 0xc)) {
		    do {
		      iVar2 = Google_Protobuf_Collections_RepeatedField_Int32Enum___get_IsReadOnly
		                        (iVar3,iVar1,
		                         Method_Google_Protobuf_Collections_RepeatedField_ContentResourceAsset__get_Item__
		                        );
		      if (*(int *)(iVar2 + 0xc) == 0x9a) {
		        if (*(int *)(iVar2 + 0x10) != 0) {
		          return *(int *)(iVar2 + 0x10);
		        }
		        break;
		      }
		      iVar1 = iVar1 + 1;
		    } while (iVar1 < *(int *)(iVar3 + 0xc));
		  }
		  iVar3 = *(int *)(param1 + 0x20);
		  iVar1 = 0;
		  if (DAT_ram_00a5acf4 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_ContentResourceAsset__get_Count__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_ContentResourceAsset__get_Item__);
		    DAT_ram_00a5acf4 = '\x01';
		  }
		  if (0 < *(int *)(iVar3 + 0xc)) {
		    do {
		      iVar2 = Google_Protobuf_Collections_RepeatedField_Int32Enum___get_IsReadOnly
		                        (iVar3,iVar1,
		                         Method_Google_Protobuf_Collections_RepeatedField_ContentResourceAsset__get_Item__
		                        );
		      if (*(int *)(iVar2 + 0xc) == 0x99) {
		        if (*(int *)(iVar2 + 0x10) != 0) {
		          return *(int *)(iVar2 + 0x10);
		        }
		        break;
		      }
		      iVar1 = iVar1 + 1;
		    } while (iVar1 < *(int *)(iVar3 + 0xc));
		  }
		  iVar3 = *(int *)(param1 + 0x20);
		  iVar1 = 0;
		  if (DAT_ram_00a5acf4 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_ContentResourceAsset__get_Count__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_ContentResourceAsset__get_Item__);
		    DAT_ram_00a5acf4 = '\x01';
		  }
		  if (0 < *(int *)(iVar3 + 0xc)) {
		    while (iVar2 = Google_Protobuf_Collections_RepeatedField_Int32Enum___get_IsReadOnly
		                             (iVar3,iVar1,
		                              Method_Google_Protobuf_Collections_RepeatedField_ContentResourceAsset__get_Item__
		                             ), *(int *)(iVar2 + 0xc) != 0x96) {
		      iVar1 = iVar1 + 1;
		      if (*(int *)(iVar3 + 0xc) <= iVar1) {
		        return 0;
		      }
		    }
		    iVar1 = *(int *)(iVar2 + 0x10);
		  }
		  return iVar1;
		}
		*/

			return null;
		}

		// Token: 0x06005DD9 RID: 24025 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005DD9")]
		[Address(RVA = "0xAA42", Offset = "0xAA42", VA = "0xAA42")]
		public static string GetIcon(this ColossusRatingDic dic)
		{
			return null;
		}

		// Token: 0x06005DDA RID: 24026 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005DDA")]
		[Address(RVA = "0xAA43", Offset = "0xAA43", VA = "0xAA43")]
		public static string GetClanRatingTitle(this ColossusRatingDic dic)
		{
			return null;
		}

		// Token: 0x06005DDB RID: 24027 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005DDB")]
		[Address(RVA = "0xAA44", Offset = "0xAA44", VA = "0xAA44")]
		public static string GetHeroesRatingTitle(this ColossusRatingDic dic)
		{
			return null;
		}

		// Token: 0x06005DDC RID: 24028 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005DDC")]
		[Address(RVA = "0xAA45", Offset = "0xAA45", VA = "0xAA45")]
		public static string GolossusBattleHistoryScoreTitle(this ColossusRatingDic dic)
		{
		/* --- GHIDRA: GolossusBattleHistoryScoreTitle ---
		undefined4
		Core_Extensions_Dict_ColossusRatingDicExt__GolossusBattleHistoryScoreTitle
		          (int param1,undefined4 param2)
		
		{
		  int param2_00;
		  int iVar1;
		  int param1_00;
		  
		  param1_00 = *(int *)(param1 + 0x24);
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
		      if (*(int *)(iVar1 + 0xc) == 0x99) {
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

		// Token: 0x06005DDD RID: 24029 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005DDD")]
		[Address(RVA = "0xAA46", Offset = "0xAA46", VA = "0xAA46")]
		public static string GetClanRatingDescription(this ColossusRatingDic dic)
		{
		/* --- GHIDRA: GetClanRatingDescription ---
		undefined4
		Core_Extensions_Dict_ColossusRatingDicExt__GetClanRatingDescription(int param1,undefined4 param2)
		
		{
		  int param2_00;
		  int iVar1;
		  int param1_00;
		  
		  param1_00 = *(int *)(param1 + 0x24);
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
		      if (*(int *)(iVar1 + 0xc) == 0x97) {
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

		// Token: 0x06005DDE RID: 24030 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005DDE")]
		[Address(RVA = "0xAA47", Offset = "0xAA47", VA = "0xAA47")]
		public static string GetHeroesRatingDescription(this ColossusRatingDic dic)
		{
		/* --- GHIDRA: GetHeroesRatingDescription ---
		undefined4
		Core_Extensions_Dict_ColossusRatingDicExt__GetHeroesRatingDescription(int param1,undefined4 param2)
		
		{
		  int param2_00;
		  int iVar1;
		  int param1_00;
		  
		  param1_00 = *(int *)(param1 + 0x24);
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
		      if (*(int *)(iVar1 + 0xc) == 0x95) {
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

		// Token: 0x06005DDF RID: 24031 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005DDF")]
		[Address(RVA = "0xAA48", Offset = "0xAA48", VA = "0xAA48")]
		public static string GolossusBattleHistoryScoreDescription(this ColossusRatingDic dic)
		{
		/* --- GHIDRA: GolossusBattleHistoryScoreDescription ---
		undefined4
		Core_Extensions_Dict_ColossusRatingDicExt__GolossusBattleHistoryScoreDescription
		          (int param1,undefined4 param2)
		
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
		                             ), *(int *)(iVar1 + 0xc) != 0x9a) {
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

		// Token: 0x06005DE0 RID: 24032 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005DE0")]
		[Address(RVA = "0xAA49", Offset = "0xAA49", VA = "0xAA49")]
		public static string GetClanRatingIcon(this ColossusRatingDic dic)
		{
		/* --- GHIDRA: GetClanRatingIcon ---
		undefined4
		Core_Extensions_Dict_ColossusRatingDicExt__GetClanRatingIcon(int param1,undefined4 param2)
		
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
		                             ), *(int *)(iVar1 + 0xc) != 0x99) {
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

		// Token: 0x06005DE1 RID: 24033 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005DE1")]
		[Address(RVA = "0xAA4A", Offset = "0xAA4A", VA = "0xAA4A")]
		public static string GetHeroesRatingIcon(this ColossusRatingDic dic)
		{
		/* --- GHIDRA: GetHeroesRatingIcon ---
		undefined4
		Core_Extensions_Dict_ColossusRatingDicExt__GetHeroesRatingIcon(int param1,undefined4 param2)
		
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
		                             ), *(int *)(iVar1 + 0xc) != 0x96) {
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

		// Token: 0x06005DE2 RID: 24034 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005DE2")]
		[Address(RVA = "0xAA4B", Offset = "0xAA4B", VA = "0xAA4B")]
		public static string GolossusBattleHistoryScoreIcon(this ColossusRatingDic dic)
		{
		/* --- GHIDRA: GolossusBattleHistoryScoreIcon ---
		undefined4
		Core_Extensions_Dict_ColossusRatingDicExt__GolossusBattleHistoryScoreIcon
		          (int param1,undefined4 param2)
		
		{
		  int param2_00;
		  int iVar1;
		  undefined4 param1_00;
		  int iVar2;
		  
		  param1_00 = *(undefined4 *)(param1 + 0x10);
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
		  while (iVar2 != 0x33) {
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
	}
}
