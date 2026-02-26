using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Protocol.Dic;

namespace Core.Extensions.Dict
{
	// Token: 0x02000F8C RID: 3980
	[Token(Token = "0x2000F8C")]
	public static class PortalDicExt
	{
		// Token: 0x06005F7F RID: 24447 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005F7F")]
		[Address(RVA = "0xABC0", Offset = "0xABC0", VA = "0xABC0")]
		public static string GetMessage(this PortalDic dict, PortalDic.Types.ContentString type)
		{
		/* --- GHIDRA: GetMessage ---
		undefined4 Core_Extensions_Dict_PortalDicExt__GetMessage(int param1,int param2,undefined4 param3)
		
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
		                             ), *(int *)(iVar1 + 0xc) != param2) {
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

		// Token: 0x06005F80 RID: 24448 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005F80")]
		[Address(RVA = "0xABC1", Offset = "0xABC1", VA = "0xABC1")]
		public static string GetAssetId(this PortalDic dict, PortalDic.Types.ContentResource idx)
		{
		/* --- GHIDRA: GetAssetId ---
		undefined4 Core_Extensions_Dict_PortalDicExt__GetAssetId(int param1,undefined4 param2)
		
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
		                             ), *(int *)(iVar1 + 0xc) != 0xd3) {
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

		// Token: 0x06005F81 RID: 24449 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005F81")]
		[Address(RVA = "0xABC2", Offset = "0xABC2", VA = "0xABC2")]
		public static string GetCurrencyIcon32(this PortalDic dic)
		{
		/* --- GHIDRA: GetCurrencyIcon32 ---
		undefined4 Core_Extensions_Dict_PortalDicExt__GetCurrencyIcon32(int param1,undefined4 param2)
		
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
		                             ), *(int *)(iVar1 + 0xc) != 0xd4) {
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

		// Token: 0x06005F82 RID: 24450 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005F82")]
		[Address(RVA = "0xABC3", Offset = "0xABC3", VA = "0xABC3")]
		public static string GetCurrencyIcon64(this PortalDic dic)
		{
		/* --- GHIDRA: GetCurrencyIcon64 ---
		undefined4 Core_Extensions_Dict_PortalDicExt__GetCurrencyIcon64(int param1,undefined4 param2)
		
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
		                             ), *(int *)(iVar1 + 0xc) != 0xda) {
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

		// Token: 0x06005F83 RID: 24451 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005F83")]
		[Address(RVA = "0x1BE8", Offset = "0x1BE8", VA = "0x1BE8")]
		public static string GetCurrencyIcon60x66(this PortalDic dic)
		{
		/* --- GHIDRA: GetCurrencyIcon60x66 ---
		void Core_Extensions_Dict_PortalDicExt__GetCurrencyIcon60x66
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a63bed == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_AssetContent_Loaders_AbstractGameGraphicLoader_RawImage__Texture2D__set_AssetId__
		              );
		    DAT_ram_00a63bed = '\x01';
		  }
		  if (DAT_ram_00a63bf0 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Component_GetComponent_GameRawImageLoader___);
		    DAT_ram_00a63bf0 = '\x01';
		  }
		  if (*(int *)(param1 + 0x98) == 0) {
		    param1_00 = func_ii_5677(param1,Method_UnityEngine_Component_GetComponent_GameRawImageLoader___)
		    ;
		    *(undefined4 *)(param1 + 0x98) = param1_00;
		  }
		  else {
		    param1_00 = *(undefined4 *)(param1 + 0x98);
		  }
		  Core_Extensions_Dict_CultDicExt__GetIcon64AssetId
		            (param1_00,param2,
		             Method_AssetContent_Loaders_AbstractGameGraphicLoader_RawImage__Texture2D__set_AssetId__
		            );
		  return;
		}
		*/

			return null;
		}

		// Token: 0x06005F84 RID: 24452 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005F84")]
		[Address(RVA = "0xABC4", Offset = "0xABC4", VA = "0xABC4")]
		public static string GetRewardIcon(this PortalDic dic)
		{
		/* --- GHIDRA: GetRewardIcon ---
		undefined4 Core_Extensions_Dict_PortalDicExt__GetRewardIcon(int param1,undefined4 param2)
		
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
		                             ), *(int *)(iVar1 + 0xc) != 0xd9) {
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

		// Token: 0x06005F85 RID: 24453 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005F85")]
		[Address(RVA = "0xABC5", Offset = "0xABC5", VA = "0xABC5")]
		public static string GetPopupDecor(this PortalDic dic)
		{
		/* --- GHIDRA: GetPopupDecor ---
		undefined4
		Core_Extensions_Dict_PortalDicExt__GetPopupDecor(int param1,undefined4 param2,undefined4 param3)
		
		{
		  int param2_00;
		  undefined4 uVar1;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a5ad87 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_FirstOrDefault_PortalDic___);
		    Mono_Security_ASN1__get_Item(&System_Func_PortalDic__bool__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Extensions_Dict_PortalDicExt___c__DisplayClass7_0__GetPortalDic_b__0__);
		    Mono_Security_ASN1__get_Item(&Core_Extensions_Dict_PortalDicExt___c__DisplayClass7_0_TypeInfo);
		    DAT_ram_00a5ad87 = '\x01';
		  }
		  param2_00 = unnamed_function_1417(Core_Extensions_Dict_PortalDicExt___c__DisplayClass7_0_TypeInfo)
		  ;
		  *(undefined4 *)(param2_00 + 8) = param2;
		  param1_00 = *(undefined4 *)(param1 + 0x2f8);
		  uVar1 = unnamed_function_1417(System_Func_PortalDic__bool__TypeInfo);
		  System_Collections_Generic_Dictionary_uint__object___GetEnumerator
		            (uVar1,param2_00,
		             Method_Core_Extensions_Dict_PortalDicExt___c__DisplayClass7_0__GetPortalDic_b__0__,0);
		  uVar1 = System_Func_object__bool____ctor
		                    (param1_00,uVar1,Method_System_Linq_Enumerable_FirstOrDefault_PortalDic___);
		  return uVar1;
		}
		*/

			return null;
		}

		// Token: 0x06005F86 RID: 24454 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005F86")]
		[Address(RVA = "0xABC6", Offset = "0xABC6", VA = "0xABC6")]
		public static PortalDic GetPortalDic(this Dictionaries dict, uint portalId)
		{
		/* --- GHIDRA: GetPortalDic ---
		undefined4
		Core_Extensions_Dict_PortalDicExt__GetPortalDic
		          (int param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  int param2_00;
		  undefined4 uVar1;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a5ad88 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_FirstOrDefault_PortalStageDic___);
		    Mono_Security_ASN1__get_Item(&System_Func_PortalStageDic__bool__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Extensions_Dict_PortalDicExt___c__DisplayClass8_0__GetPortalStageDic_b__0__
		              );
		    Mono_Security_ASN1__get_Item(&Core_Extensions_Dict_PortalDicExt___c__DisplayClass8_0_TypeInfo);
		    DAT_ram_00a5ad88 = '\x01';
		  }
		  param2_00 = unnamed_function_1417(Core_Extensions_Dict_PortalDicExt___c__DisplayClass8_0_TypeInfo)
		  ;
		  *(undefined4 *)(param2_00 + 0xc) = param2;
		  *(undefined4 *)(param2_00 + 8) = param3;
		  param1_00 = *(undefined4 *)(param1 + 0x2fc);
		  uVar1 = unnamed_function_1417(System_Func_PortalStageDic__bool__TypeInfo);
		  System_Collections_Generic_Dictionary_uint__object___GetEnumerator
		            (uVar1,param2_00,
		             Method_Core_Extensions_Dict_PortalDicExt___c__DisplayClass8_0__GetPortalStageDic_b__0__
		             ,0);
		  uVar1 = System_Func_object__bool____ctor
		                    (param1_00,uVar1,Method_System_Linq_Enumerable_FirstOrDefault_PortalStageDic___)
		  ;
		  return uVar1;
		}
		*/

			return null;
		}

		// Token: 0x06005F87 RID: 24455 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005F87")]
		[Address(RVA = "0xABC7", Offset = "0xABC7", VA = "0xABC7")]
		public static PortalStageDic GetPortalStageDic(this Dictionaries dict, uint portalStageId, uint portalId)
		{
		/* --- GHIDRA: GetPortalStageDic ---
		undefined4
		Core_Extensions_Dict_PortalDicExt__GetPortalStageDic(int param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 uVar3;
		  undefined4 *puVar4;
		  
		  if (DAT_ram_00a5ad8b == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Comparison_PortalStageDic__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_ToList_PortalStageDic___);
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_Where_PortalStageDic___);
		    Mono_Security_ASN1__get_Item(&System_Func_PortalStageDic__bool__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_PortalStageDic__Sort__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Extensions_Dict_PortalDicExt___c__GetPortalStages_b__11_1__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Extensions_Dict_PortalDicExt___c__DisplayClass11_0__GetPortalStages_b__0__
		              );
		    Mono_Security_ASN1__get_Item(&Core_Extensions_Dict_PortalDicExt___c__DisplayClass11_0_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Extensions_Dict_PortalDicExt___c_TypeInfo);
		    DAT_ram_00a5ad8b = '\x01';
		  }
		  iVar1 = unnamed_function_1417(Core_Extensions_Dict_PortalDicExt___c__DisplayClass11_0_TypeInfo);
		  *(undefined4 *)(iVar1 + 8) = param2;
		  uVar3 = *(undefined4 *)(param1 + 0x2fc);
		  uVar2 = unnamed_function_1417(System_Func_PortalStageDic__bool__TypeInfo);
		  System_Collections_Generic_Dictionary_uint__object___GetEnumerator
		            (uVar2,iVar1,
		             Method_Core_Extensions_Dict_PortalDicExt___c__DisplayClass11_0__GetPortalStages_b__0__,
		             0);
		  uVar2 = System_Linq_Enumerable__Where_PlayerLoopSystem_
		                    (uVar3,uVar2,Method_System_Linq_Enumerable_Where_PortalStageDic___);
		  uVar2 = System_Linq_Enumerable__Select_object__object_
		                    (uVar2,Method_System_Linq_Enumerable_ToList_PortalStageDic___);
		  if (*(int *)(Core_Extensions_Dict_PortalDicExt___c_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Extensions_Dict_PortalDicExt___c_TypeInfo);
		  }
		  puVar4 = *(undefined4 **)(Core_Extensions_Dict_PortalDicExt___c_TypeInfo + 0x5c);
		  iVar1 = puVar4[1];
		  if (iVar1 == 0) {
		    if (*(int *)(Core_Extensions_Dict_PortalDicExt___c_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Extensions_Dict_PortalDicExt___c_TypeInfo);
		      puVar4 = *(undefined4 **)(Core_Extensions_Dict_PortalDicExt___c_TypeInfo + 0x5c);
		    }
		    uVar3 = *puVar4;
		    iVar1 = unnamed_function_1417(System_Comparison_PortalStageDic__TypeInfo);
		    System_Collections_Generic_Comparer_object___get_Default
		              (iVar1,uVar3,Method_Core_Extensions_Dict_PortalDicExt___c__GetPortalStages_b__11_1__,0
		              );
		    *(int *)(*(int *)(Core_Extensions_Dict_PortalDicExt___c_TypeInfo + 0x5c) + 4) = iVar1;
		  }
		  Google_Protobuf_Collections_RepeatedField_uint___Contains
		            (uVar2,iVar1,Method_System_Collections_Generic_List_PortalStageDic__Sort__);
		  return uVar2;
		}
		*/

		/* --- GHIDRA: GetPortalStageDic ---
		undefined4
		Core_Extensions_Dict_PortalDicExt__GetPortalStageDic(int param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 uVar3;
		  undefined4 *puVar4;
		  
		  if (DAT_ram_00a5ad8b == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Comparison_PortalStageDic__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_ToList_PortalStageDic___);
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_Where_PortalStageDic___);
		    Mono_Security_ASN1__get_Item(&System_Func_PortalStageDic__bool__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_PortalStageDic__Sort__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Extensions_Dict_PortalDicExt___c__GetPortalStages_b__11_1__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Extensions_Dict_PortalDicExt___c__DisplayClass11_0__GetPortalStages_b__0__
		              );
		    Mono_Security_ASN1__get_Item(&Core_Extensions_Dict_PortalDicExt___c__DisplayClass11_0_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Extensions_Dict_PortalDicExt___c_TypeInfo);
		    DAT_ram_00a5ad8b = '\x01';
		  }
		  iVar1 = unnamed_function_1417(Core_Extensions_Dict_PortalDicExt___c__DisplayClass11_0_TypeInfo);
		  *(undefined4 *)(iVar1 + 8) = param2;
		  uVar3 = *(undefined4 *)(param1 + 0x2fc);
		  uVar2 = unnamed_function_1417(System_Func_PortalStageDic__bool__TypeInfo);
		  System_Collections_Generic_Dictionary_uint__object___GetEnumerator
		            (uVar2,iVar1,
		             Method_Core_Extensions_Dict_PortalDicExt___c__DisplayClass11_0__GetPortalStages_b__0__,
		             0);
		  uVar2 = System_Linq_Enumerable__Where_PlayerLoopSystem_
		                    (uVar3,uVar2,Method_System_Linq_Enumerable_Where_PortalStageDic___);
		  uVar2 = System_Linq_Enumerable__Select_object__object_
		                    (uVar2,Method_System_Linq_Enumerable_ToList_PortalStageDic___);
		  if (*(int *)(Core_Extensions_Dict_PortalDicExt___c_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Extensions_Dict_PortalDicExt___c_TypeInfo);
		  }
		  puVar4 = *(undefined4 **)(Core_Extensions_Dict_PortalDicExt___c_TypeInfo + 0x5c);
		  iVar1 = puVar4[1];
		  if (iVar1 == 0) {
		    if (*(int *)(Core_Extensions_Dict_PortalDicExt___c_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Extensions_Dict_PortalDicExt___c_TypeInfo);
		      puVar4 = *(undefined4 **)(Core_Extensions_Dict_PortalDicExt___c_TypeInfo + 0x5c);
		    }
		    uVar3 = *puVar4;
		    iVar1 = unnamed_function_1417(System_Comparison_PortalStageDic__TypeInfo);
		    System_Collections_Generic_Comparer_object___get_Default
		              (iVar1,uVar3,Method_Core_Extensions_Dict_PortalDicExt___c__GetPortalStages_b__11_1__,0
		              );
		    *(int *)(*(int *)(Core_Extensions_Dict_PortalDicExt___c_TypeInfo + 0x5c) + 4) = iVar1;
		  }
		  Google_Protobuf_Collections_RepeatedField_uint___Contains
		            (uVar2,iVar1,Method_System_Collections_Generic_List_PortalStageDic__Sort__);
		  return uVar2;
		}
		*/

			return null;
		}

		// Token: 0x06005F88 RID: 24456 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005F88")]
		[Address(RVA = "0xABC8", Offset = "0xABC8", VA = "0xABC8")]
		public static PortalStageDic GetPrevPortalStageDic(this Dictionaries dict, uint portalStageId, uint portalId)
		{
		/* --- GHIDRA: GetPrevPortalStageDic ---
		undefined4
		Core_Extensions_Dict_PortalDicExt__GetPrevPortalStageDic
		          (undefined4 param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a5ad8a == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_PortalStageDic__get_Item__)
		    ;
		    DAT_ram_00a5ad8a = '\x01';
		  }
		  uVar1 = Core_Extensions_Dict_PortalDicExt__GetPortalStageDic(param1,param2,param3);
		  uVar1 = System_Linq_Enumerable__ToList_object_
		                    (uVar1,param3,Method_System_Collections_Generic_List_PortalStageDic__get_Item__)
		  ;
		  return uVar1;
		}
		*/

			return null;
		}

		// Token: 0x06005F89 RID: 24457 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005F89")]
		[Address(RVA = "0xABC9", Offset = "0xABC9", VA = "0xABC9")]
		public static PortalStageDic GetPortalStageDic(this Dictionaries dict, uint portalId, int index)
		{
			return null;
		}

		// Token: 0x06005F8A RID: 24458 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005F8A")]
		[Address(RVA = "0xABCA", Offset = "0xABCA", VA = "0xABCA")]
		public static List<PortalStageDic> GetPortalStages(this Dictionaries dict, uint portalId)
		{
		/* --- GHIDRA: GetPortalStages ---
		void Core_Extensions_Dict_PortalDicExt__GetPortalStages(undefined4 param1)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a5ad8d == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Extensions_Dict_PortalDicExt___c_TypeInfo);
		    DAT_ram_00a5ad8d = '\x01';
		  }
		  uVar1 = unnamed_function_1417(Core_Extensions_Dict_PortalDicExt___c_TypeInfo);
		  **(undefined4 **)(Core_Extensions_Dict_PortalDicExt___c_TypeInfo + 0x5c) = uVar1;
		  return;
		}
		*/

			return null;
		}

		// Token: 0x06005F8B RID: 24459 RVA: 0x00011748 File Offset: 0x0000F948
		[Token(Token = "0x6005F8B")]
		[Address(RVA = "0x1C98", Offset = "0x1C98", VA = "0x1C98")]
		public static int GetPortalStageIndex(this Dictionaries dict, uint portalStageId, uint portalId)
		{
		/* --- GHIDRA: GetPortalStageIndex ---
		int * Core_Extensions_Dict_PortalDicExt__GetPortalStageIndex(int *param1)
		
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

			return 0;
		}
	}
}
