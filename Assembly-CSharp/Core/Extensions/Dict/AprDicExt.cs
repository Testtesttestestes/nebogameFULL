using System;
using Il2CppDummyDll;
using Protocol.Dic;

namespace Core.Extensions.Dict
{
	// Token: 0x02000F1B RID: 3867
	[Token(Token = "0x2000F1B")]
	public static class AprDicExt
	{
		// Token: 0x06005D5F RID: 23903 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005D5F")]
		[Address(RVA = "0xA9CF", Offset = "0xA9CF", VA = "0xA9CF")]
		public static string GetImageIsleAssetId(this AprDic aprDic)
		{
		/* --- GHIDRA: GetImageIsleAssetId ---
		undefined4 Core_Extensions_Dict_AprDicExt__GetImageIsleAssetId(int param1,undefined4 param2)
		
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
		                             ), *(int *)(iVar1 + 0xc) != 2) {
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

		// Token: 0x06005D60 RID: 23904 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005D60")]
		[Address(RVA = "0xA9D0", Offset = "0xA9D0", VA = "0xA9D0")]
		public static string GetImageInfoAssetId(this AprDic aprDic)
		{
		/* --- GHIDRA: GetImageInfoAssetId ---
		undefined4 Core_Extensions_Dict_AprDicExt__GetImageInfoAssetId(int param1,undefined4 param2)
		
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
		                             ), *(int *)(iVar1 + 0xc) != 0xc) {
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

		// Token: 0x06005D61 RID: 23905 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005D61")]
		[Address(RVA = "0x4897", Offset = "0x4897", VA = "0x4897")]
		public static string GetImageListAssetId(this AprDic aprDic)
		{
		/* --- GHIDRA: GetImageListAssetId ---
		void Core_Extensions_Dict_AprDicExt__GetImageListAssetId(int param1,undefined4 param2,int param3)
		
		{
		  *(undefined4 *)(param1 + 0x14) = 0;
		  AssetContent_Loaders_AbstractGameGraphicLoader_object__object___OnDestroy
		            (param1,param2,*(undefined4 *)(*(int *)(*(int *)(param3 + 0x10) + 0x60) + 4));
		  return;
		}
		*/

			return null;
		}

		// Token: 0x06005D62 RID: 23906 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005D62")]
		[Address(RVA = "0xA9D1", Offset = "0xA9D1", VA = "0xA9D1")]
		public static string GetAnimationAssetId(this AprDic aprDic)
		{
		/* --- GHIDRA: GetAnimationAssetId ---
		undefined4 Core_Extensions_Dict_AprDicExt__GetAnimationAssetId(int param1,undefined4 param2)
		
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
		                             ), *(int *)(iVar1 + 0xc) != 0xaf) {
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

		// Token: 0x06005D63 RID: 23907 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005D63")]
		[Address(RVA = "0xA9D2", Offset = "0xA9D2", VA = "0xA9D2")]
		public static string GetAttackAssetId(this AprDic aprDic)
		{
		/* --- GHIDRA: GetAttackAssetId ---
		int Core_Extensions_Dict_AprDicExt__GetAttackAssetId(int param1,undefined4 param2)
		
		{
		  int param2_00;
		  int iVar1;
		  int iVar2;
		  
		  iVar2 = *(int *)(param1 + 0x58);
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
		      if (*(int *)(iVar1 + 0xc) == 0x1c) {
		        param2_00 = *(int *)(iVar1 + 0x10);
		        goto code_r0x812cee67;
		      }
		      param2_00 = param2_00 + 1;
		    } while (param2_00 < *(int *)(iVar2 + 0xc));
		    param2_00 = 0;
		  }
		code_r0x812cee67:
		  iVar2 = func_ii_4769(param2_00,0);
		  if (iVar2 != 0) {
		    iVar2 = *(int *)(param1 + 0x58);
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
		                               ), *(int *)(iVar1 + 0xc) != 3) {
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

		// Token: 0x06005D64 RID: 23908 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005D64")]
		[Address(RVA = "0xA9D3", Offset = "0xA9D3", VA = "0xA9D3")]
		public static string Get128AssetId(this AprDic aprDic)
		{
		/* --- GHIDRA: Get128AssetId ---
		int Core_Extensions_Dict_AprDicExt__Get128AssetId(int param1,undefined4 param2)
		
		{
		  int param2_00;
		  int iVar1;
		  int iVar2;
		  
		  iVar2 = *(int *)(param1 + 0x58);
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
		      if (*(int *)(iVar1 + 0xc) == 0x1b) {
		        param2_00 = *(int *)(iVar1 + 0x10);
		        goto code_r0x812cefe6;
		      }
		      param2_00 = param2_00 + 1;
		    } while (param2_00 < *(int *)(iVar2 + 0xc));
		    param2_00 = 0;
		  }
		code_r0x812cefe6:
		  iVar2 = func_ii_4769(param2_00,0);
		  if (iVar2 != 0) {
		    iVar2 = *(int *)(param1 + 0x58);
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
		                               ), *(int *)(iVar1 + 0xc) != 4) {
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

		// Token: 0x06005D65 RID: 23909 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005D65")]
		[Address(RVA = "0xA9D4", Offset = "0xA9D4", VA = "0xA9D4")]
		public static string Get256AssetId(this AprDic aprDic)
		{
		/* --- GHIDRA: Get256AssetId ---
		int Core_Extensions_Dict_AprDicExt__Get256AssetId(int param1,undefined4 param2)
		
		{
		  int param2_00;
		  int iVar1;
		  int iVar2;
		  
		  iVar2 = *(int *)(param1 + 0x58);
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
		      if (*(int *)(iVar1 + 0xc) == 0x56) {
		        param2_00 = *(int *)(iVar1 + 0x10);
		        goto code_r0x812cf2e5;
		      }
		      param2_00 = param2_00 + 1;
		    } while (param2_00 < *(int *)(iVar2 + 0xc));
		    param2_00 = 0;
		  }
		code_r0x812cf2e5:
		  iVar2 = func_ii_4769(param2_00,0);
		  if (iVar2 != 0) {
		    iVar2 = *(int *)(param1 + 0x58);
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
		                               ), *(int *)(iVar1 + 0xc) != 2) {
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

		// Token: 0x06005D66 RID: 23910 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005D66")]
		[Address(RVA = "0x1B4F", Offset = "0x1B4F", VA = "0x1B4F")]
		public static string Get1024AssetId(this AprDic aprDic)
		{
		/* --- GHIDRA: Get1024AssetId ---
		void Core_Extensions_Dict_AprDicExt__Get1024AssetId(int param1,undefined4 param2,undefined4 param3)
		
		{
		  uint uVar1;
		  int iVar2;
		  uint *puVar3;
		  undefined4 uVar4;
		  undefined4 uVar5;
		  int *param1_00;
		  int *piVar6;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a63bd5 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_AssetContent_Loaders_AbstractGameGraphicLoader_RawImage__Texture2D__set_AssetId__
		              );
		    Mono_Security_ASN1__get_Item(&Core_IGameAssetContent_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a63bd5 = '\x01';
		  }
		  iVar2 = System_Collections_CollectionBase___ctor(*(undefined4 *)(param1 + 0x1c),param2,0);
		  if (iVar2 == 0) {
		    Core_Extensions_Dict_CultDicExt__GetIcon64AssetId
		              (*(undefined4 *)(param1 + 0x14),0,
		               Method_AssetContent_Loaders_AbstractGameGraphicLoader_RawImage__Texture2D__set_AssetId__
		              );
		    UnityEngine_Transform__SetParent(*(undefined4 *)(param1 + 0x18),0,param2);
		    *(undefined4 *)(param1 + 0x20) = 0;
		    *(undefined4 *)(param1 + 0x1c) = param2;
		    iVar2 = Newtonsoft_Json_Serialization_JsonSerializerInternalReader__ShouldDeserialize(param2,0);
		    if (iVar2 != 0) {
		      return;
		    }
		    if (DAT_ram_00a6456f == '\0') {
		      Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		      DAT_ram_00a6456f = '\x01';
		    }
		    uVar1 = 0;
		    param1_00 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		    iVar2 = *param1_00;
		    if (*(ushort *)(iVar2 + 0xb6) != 0) {
		      do {
		        if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8)) {
		          puVar3 = (uint *)(*(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8 + 4) * 8 + iVar2 + 0x178);
		          goto code_r0x82368987;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		    }
		    puVar3 = (uint *)func_ii_1080(param1_00,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x82368987:
		    piVar6 = (int *)(param1 + 0x18);
		    uVar4 = (**(code **)((ulonglong)*puVar3 * 4))(param1_00,puVar3[1]);
		    iVar2 = Core_Gameplay_Managers_DictManager__CheckSupportedService
		                      (uVar4,*(undefined4 *)(param1 + 0x1c),0);
		    *(int *)(param1 + 0x20) = iVar2;
		    if (*(int *)(iVar2 + 0x10) == 1) {
		      piVar6 = (int *)(param1 + 0x14);
		    }
		    else if (*(int *)(iVar2 + 0x10) != 2) goto code_r0x82368a60;
		    piVar6 = (int *)*piVar6;
		    if (piVar6 == (int *)0x0) {
		code_r0x82368a60:
		      uVar4 = unnamed_function_2232(&string___TypeInfo);
		      iVar2 = Mono_Security_ASN1Convert__ToOid(uVar4,6);
		      uVar4 = unnamed_function_2232(&StringLiteral_8419);
		      *(undefined4 *)(iVar2 + 0x10) = uVar4;
		      local_4 = *(undefined4 *)(*(int *)(param1 + 0x20) + 0x10);
		      uVar4 = func_ii_1081(DAT_ram_00a66958,&local_4);
		      uVar5 = unnamed_function_2232(&StringLiteral_19965);
		      uVar4 = func_ii_4419(uVar5,uVar4,0);
		      *(undefined4 *)(iVar2 + 0x14) = uVar4;
		      uVar4 = unnamed_function_2232(&StringLiteral_23245);
		      *(undefined4 *)(iVar2 + 0x18) = uVar4;
		      *(undefined4 *)(iVar2 + 0x1c) = *(undefined4 *)(*(int *)(param1 + 0x20) + 0xc);
		      uVar4 = unnamed_function_2232(&StringLiteral_278);
		      *(undefined4 *)(iVar2 + 0x20) = uVar4;
		      *(undefined4 *)(iVar2 + 0x24) = *(undefined4 *)(*(int *)(param1 + 0x20) + 0x14);
		      uVar4 = System_Single__ToString(iVar2,0);
		      uVar5 = unnamed_function_2232(&System_Exception_TypeInfo);
		      uVar5 = unnamed_function_1417(uVar5);
		      System_String__Concat(uVar5,uVar4,0);
		      uVar4 = unnamed_function_2232(&Method_AssetContent_GameAssetViewRawImage_set_AssetId__);
		      func_ii_1050(uVar5,uVar4);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    uVar1 = 0;
		    uVar4 = *(undefined4 *)(param1 + 0x1c);
		    iVar2 = *piVar6;
		    if (*(ushort *)(iVar2 + 0xb6) != 0) {
		      do {
		        if (Core_IGameAssetContent_TypeInfo == *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8)) {
		          puVar3 = (uint *)(*(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8 + 4) * 8 + iVar2 + 200);
		          goto code_r0x82368a49;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		    }
		    puVar3 = (uint *)func_ii_1080(piVar6,Core_IGameAssetContent_TypeInfo,1);
		code_r0x82368a49:
		    (**(code **)((ulonglong)*puVar3 * 4))(piVar6,uVar4,puVar3[1]);
		  }
		  return;
		}
		*/

			return null;
		}

		// Token: 0x06005D67 RID: 23911 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005D67")]
		[Address(RVA = "0xA9D5", Offset = "0xA9D5", VA = "0xA9D5")]
		public static string Get1024CombatAssetId(this AprDic aprDic)
		{
		/* --- GHIDRA: Get1024CombatAssetId ---
		undefined4 Core_Extensions_Dict_AprDicExt__Get1024CombatAssetId(int param1,undefined4 param2)
		
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
		                             ), *(int *)(iVar1 + 0xc) != 0x1c) {
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

		// Token: 0x06005D68 RID: 23912 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005D68")]
		[Address(RVA = "0xA9D6", Offset = "0xA9D6", VA = "0xA9D6")]
		public static string GetUiAnimation128AssetId(this AprDic aprDic)
		{
		/* --- GHIDRA: GetUiAnimation128AssetId ---
		undefined4 Core_Extensions_Dict_AprDicExt__GetUiAnimation128AssetId(int param1,undefined4 param2)
		
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
		                             ), *(int *)(iVar1 + 0xc) != 0x1b) {
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

		// Token: 0x06005D69 RID: 23913 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005D69")]
		[Address(RVA = "0xA9D7", Offset = "0xA9D7", VA = "0xA9D7")]
		public static string GetUiAnimation256AssetId(this AprDic aprDic)
		{
		/* --- GHIDRA: GetUiAnimation256AssetId ---
		undefined4 Core_Extensions_Dict_AprDicExt__GetUiAnimation256AssetId(int param1,undefined4 param2)
		
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
		                             ), *(int *)(iVar1 + 0xc) != 0x1d) {
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

		// Token: 0x06005D6A RID: 23914 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005D6A")]
		[Address(RVA = "0xA9D8", Offset = "0xA9D8", VA = "0xA9D8")]
		public static string GetUiAnimation1024AssetId(this AprDic aprDic)
		{
		/* --- GHIDRA: GetUiAnimation1024AssetId ---
		undefined4 Core_Extensions_Dict_AprDicExt__GetUiAnimation1024AssetId(int param1,undefined4 param2)
		
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
		                             ), *(int *)(iVar1 + 0xc) != 0x56) {
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

		// Token: 0x06005D6B RID: 23915 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005D6B")]
		[Address(RVA = "0xA9D9", Offset = "0xA9D9", VA = "0xA9D9")]
		public static string GetAnimation1024AssetId(this AprDic aprDic)
		{
		/* --- GHIDRA: GetAnimation1024AssetId ---
		undefined4 Core_Extensions_Dict_AprDicExt__GetAnimation1024AssetId(int param1,undefined4 param2)
		
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
		                             ), *(int *)(iVar1 + 0xc) != 0x68) {
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

		// Token: 0x06005D6C RID: 23916 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005D6C")]
		[Address(RVA = "0xA9DA", Offset = "0xA9DA", VA = "0xA9DA")]
		public static string GetTutorialGuideAssetId(this AprDic aprDic)
		{
		/* --- GHIDRA: GetTutorialGuideAssetId ---
		undefined4 Core_Extensions_Dict_AprDicExt__GetTutorialGuideAssetId(int param1,undefined4 param2)
		
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
		                             ), *(int *)(iVar1 + 0xc) != 0xb9) {
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

		// Token: 0x06005D6D RID: 23917 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005D6D")]
		[Address(RVA = "0xA9DB", Offset = "0xA9DB", VA = "0xA9DB")]
		public static string GetAvatarOnMonsterIsle(this AprDic aprDic)
		{
			return null;
		}

		// Token: 0x06005D6E RID: 23918 RVA: 0x00010D88 File Offset: 0x0000EF88
		[Token(Token = "0x6005D6E")]
		[Address(RVA = "0xA9DC", Offset = "0xA9DC", VA = "0xA9DC")]
		public static bool IsSpecial(this AprDic aprDic)
		{
		/* --- GHIDRA: IsSpecial ---
		uint Core_Extensions_Dict_AprDicExt__IsSpecial(int param1,undefined4 param2)
		
		{
		  return (uint)(*(longlong *)(param1 + 0x18) != 0);
		}
		*/

			return default(bool);
		}

		// Token: 0x06005D6F RID: 23919 RVA: 0x00010DA0 File Offset: 0x0000EFA0
		[Token(Token = "0x6005D6F")]
		[Address(RVA = "0xA9DD", Offset = "0xA9DD", VA = "0xA9DD")]
		public static bool IsIndividual(this AprDic aprDic)
		{
		/* --- GHIDRA: IsIndividual ---
		uint Core_Extensions_Dict_AprDicExt__IsIndividual(int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  
		  if (*(char *)(param1 + 0x20) == '\0') {
		    uVar1 = (uint)(*(longlong *)(param1 + 0x18) != 0);
		  }
		  else {
		    uVar1 = 1;
		  }
		  return uVar1;
		}
		*/

			return default(bool);
		}

		// Token: 0x06005D70 RID: 23920 RVA: 0x00010DB8 File Offset: 0x0000EFB8
		[Token(Token = "0x6005D70")]
		[Address(RVA = "0xA9DE", Offset = "0xA9DE", VA = "0xA9DE")]
		public static bool IsSpecialOrIndividual(this AprDic aprDic)
		{
			return default(bool);
		}

		// Token: 0x06005D71 RID: 23921 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005D71")]
		[Address(RVA = "0xA9DF", Offset = "0xA9DF", VA = "0xA9DF")]
		public static string Get256х128ImageAssetId(this AprDic aprDic)
		{
		/* --- GHIDRA: Get256х128ImageAssetId ---
		undefined4 Core_Extensions_Dict_AprDicExt__Get256х128ImageAssetId(int param1,undefined4 param2)
		
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
		                             ), *(int *)(iVar1 + 0xc) != 0x66) {
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

		// Token: 0x06005D72 RID: 23922 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005D72")]
		[Address(RVA = "0xA9E0", Offset = "0xA9E0", VA = "0xA9E0")]
		public static string Get256x128AssetId(this AprDic aprDic)
		{
		/* --- GHIDRA: Get256x128AssetId ---
		undefined4 Core_Extensions_Dict_AprDicExt__Get256x128AssetId(int param1,undefined4 param2)
		
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
		      if (*(int *)(iVar1 + 0xc) == 0x84) {
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
