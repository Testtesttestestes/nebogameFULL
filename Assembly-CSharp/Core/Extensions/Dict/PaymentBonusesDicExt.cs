using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Protocol.Dic;

namespace Core.Extensions.Dict
{
	// Token: 0x02000F8B RID: 3979
	[Token(Token = "0x2000F8B")]
	public static class PaymentBonusesDicExt
	{
		// Token: 0x06005F7A RID: 24442 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005F7A")]
		[Address(RVA = "0xABBB", Offset = "0xABBB", VA = "0xABBB")]
		public static string GetAnimationAssetId(this PaymentBonusesDic dic)
		{
		/* --- GHIDRA: GetAnimationAssetId ---
		undefined4
		Core_Extensions_Dict_PaymentBonusesDicExt__GetAnimationAssetId(int param1,undefined4 param2)
		
		{
		  int param2_00;
		  int iVar1;
		  int param1_00;
		  undefined4 uVar2;
		  
		  param1_00 = *(int *)(param1 + 0x28);
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
		                             ), *(int *)(iVar1 + 0xc) != 0x57) {
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

		// Token: 0x06005F7B RID: 24443 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005F7B")]
		[Address(RVA = "0xABBC", Offset = "0xABBC", VA = "0xABBC")]
		public static string GetBannerAssetId(this PaymentBonusesDic dic)
		{
		/* --- GHIDRA: GetBannerAssetId ---
		undefined4 Core_Extensions_Dict_PaymentBonusesDicExt__GetBannerAssetId(int param1,undefined4 param2)
		
		{
		  int param2_00;
		  int iVar1;
		  int param1_00;
		  
		  param1_00 = *(int *)(param1 + 0x2c);
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
		      if (*(int *)(iVar1 + 0xc) == 0x38) {
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

		// Token: 0x06005F7C RID: 24444 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005F7C")]
		[Address(RVA = "0xABBD", Offset = "0xABBD", VA = "0xABBD")]
		public static string GetDescription(this PaymentBonusesDic dic)
		{
		/* --- GHIDRA: GetDescription ---
		int Core_Extensions_Dict_PaymentBonusesDicExt__GetDescription
		              (int param1,int *param2,undefined4 param3)
		
		{
		  int iVar1;
		  int iVar2;
		  int iVar3;
		  int iVar4;
		  undefined4 uVar5;
		  undefined8 local_28;
		  undefined8 local_20;
		  undefined8 local_18;
		  undefined8 local_10;
		  float8 local_8;
		  
		  if (DAT_ram_00a5ad85 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Globalization_CultureInfo_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_ToList_Money___);
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_KeyValuePair_string__string____TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_KeyValuePair_string__string___ctor__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_Money__get_Count__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_Money__get_Item__);
		    Mono_Security_ASN1__get_Item(&Core_Money_Money_MoneyType_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Money_Money_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_21395);
		    Mono_Security_ASN1__get_Item(&StringLiteral_26430);
		    Mono_Security_ASN1__get_Item(&StringLiteral_21396);
		    Mono_Security_ASN1__get_Item(&StringLiteral_26429);
		    Mono_Security_ASN1__get_Item(&StringLiteral_12336);
		    DAT_ram_00a5ad85 = '\x01';
		  }
		  uVar5 = *(undefined4 *)(param1 + 0x10);
		  if (*(int *)(Core_Money_Money_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Money_Money_TypeInfo);
		  }
		  uVar5 = Core_Money_Money__op_Explicit(uVar5,0);
		  iVar1 = Core_Money_Money__op_Multiply(uVar5,0);
		  if (iVar1 == 0) {
		    iVar1 = System_Linq_Enumerable__Select_object__object_
		                      (uVar5,Method_System_Linq_Enumerable_ToList_Money___);
		    if (*(int *)(iVar1 + 0xc) == 1) {
		      iVar2 = Mono_Security_ASN1Convert__ToOid
		                        (System_Collections_Generic_KeyValuePair_string__string____TypeInfo,2);
		      iVar3 = System_Linq_Enumerable__ToList_object_
		                        (iVar1,0,Method_System_Collections_Generic_List_Money__get_Item__);
		      local_8 = *(float8 *)(iVar3 + 0x10);
		      if (*(int *)(System_Globalization_CultureInfo_TypeInfo + 0x74) == 0) {
		        func_ii_306000(System_Globalization_CultureInfo_TypeInfo);
		      }
		      uVar5 = System_Xml_Schema_SchemaCollectionCompiler__GetAnySchemaType(0);
		      uVar5 = System_Double__GetHashCode(&local_8,uVar5,0);
		      local_10 = 0;
		      System_Text_Formatting_StringView__get_IsEmpty
		                (&local_10,StringLiteral_21395,uVar5,
		                 Method_System_Collections_Generic_KeyValuePair_string__string___ctor__);
		      *(undefined8 *)(iVar2 + 0x10) = local_10;
		      iVar1 = System_Linq_Enumerable__ToList_object_
		                        (iVar1,0,Method_System_Collections_Generic_List_Money__get_Item__);
		      uVar5 = *(undefined4 *)(iVar1 + 8);
		      if (*(int *)(Core_Money_Money_MoneyType_TypeInfo + 0x74) == 0) {
		        func_ii_306000(Core_Money_Money_MoneyType_TypeInfo);
		      }
		      iVar3 = 0;
		      uVar5 = func_ii_7278(uVar5,0);
		      uVar5 = Core_Extensions_Dict_ResourcesDicExt__GetUnlimitToolTipText(uVar5,0);
		      local_18 = 0;
		      System_Text_Formatting_StringView__get_IsEmpty
		                (&local_18,StringLiteral_26429,uVar5,
		                 Method_System_Collections_Generic_KeyValuePair_string__string___ctor__);
		      *(undefined8 *)(iVar2 + 0x18) = local_18;
		      *param2 = iVar2;
		      iVar1 = *(int *)(param1 + 0x2c);
		      if (DAT_ram_00a5acf5 == '\0') {
		        Mono_Security_ASN1__get_Item
		                  (&
		                   Method_Google_Protobuf_Collections_RepeatedField_ContentStringMessage__get_Count__
		                  );
		        Mono_Security_ASN1__get_Item
		                  (&
		                   Method_Google_Protobuf_Collections_RepeatedField_ContentStringMessage__get_Item__
		                  );
		        DAT_ram_00a5acf5 = '\x01';
		      }
		      if (0 < *(int *)(iVar1 + 0xc)) {
		        do {
		          iVar2 = Google_Protobuf_Collections_RepeatedField_Int32Enum___get_IsReadOnly
		                            (iVar1,iVar3,
		                             Method_Google_Protobuf_Collections_RepeatedField_ContentStringMessage__get_Item__
		                            );
		          if (*(int *)(iVar2 + 0xc) == 0x70) {
		            return *(undefined4 *)(iVar2 + 0x10);
		          }
		          iVar3 = iVar3 + 1;
		        } while (iVar3 < *(int *)(iVar1 + 0xc));
		        iVar3 = 0;
		      }
		    }
		    else if (*(int *)(iVar1 + 0xc) == 2) {
		      iVar2 = Mono_Security_ASN1Convert__ToOid
		                        (System_Collections_Generic_KeyValuePair_string__string____TypeInfo,4);
		      iVar3 = System_Linq_Enumerable__ToList_object_
		                        (iVar1,0,Method_System_Collections_Generic_List_Money__get_Item__);
		      local_8 = *(float8 *)(iVar3 + 0x10);
		      if (*(int *)(System_Globalization_CultureInfo_TypeInfo + 0x74) == 0) {
		        func_ii_306000(System_Globalization_CultureInfo_TypeInfo);
		      }
		      uVar5 = System_Xml_Schema_SchemaCollectionCompiler__GetAnySchemaType(0);
		      uVar5 = System_Double__GetHashCode(&local_8,uVar5,0);
		      local_10 = 0;
		      System_Text_Formatting_StringView__get_IsEmpty
		                (&local_10,StringLiteral_21395,uVar5,
		                 Method_System_Collections_Generic_KeyValuePair_string__string___ctor__);
		      *(undefined8 *)(iVar2 + 0x10) = local_10;
		      iVar3 = System_Linq_Enumerable__ToList_object_
		                        (iVar1,0,Method_System_Collections_Generic_List_Money__get_Item__);
		      uVar5 = *(undefined4 *)(iVar3 + 8);
		      if (*(int *)(Core_Money_Money_MoneyType_TypeInfo + 0x74) == 0) {
		        func_ii_306000(Core_Money_Money_MoneyType_TypeInfo);
		      }
		      iVar3 = 0;
		      uVar5 = func_ii_7278(uVar5,0);
		      uVar5 = Core_Extensions_Dict_ResourcesDicExt__GetUnlimitToolTipText(uVar5,0);
		      local_18 = 0;
		      System_Text_Formatting_StringView__get_IsEmpty
		                (&local_18,StringLiteral_26429,uVar5,
		                 Method_System_Collections_Generic_KeyValuePair_string__string___ctor__);
		      *(undefined8 *)(iVar2 + 0x18) = local_18;
		      iVar4 = System_Linq_Enumerable__ToList_object_
		                        (iVar1,1,Method_System_Collections_Generic_List_Money__get_Item__);
		      local_8 = *(float8 *)(iVar4 + 0x10);
		      uVar5 = System_Xml_Schema_SchemaCollectionCompiler__GetAnySchemaType(0);
		      uVar5 = System_Double__GetHashCode(&local_8,uVar5,0);
		      local_20 = 0;
		      System_Text_Formatting_StringView__get_IsEmpty
		                (&local_20,StringLiteral_21396,uVar5,
		                 Method_System_Collections_Generic_KeyValuePair_string__string___ctor__);
		      *(undefined8 *)(iVar2 + 0x20) = local_20;
		      iVar1 = System_Linq_Enumerable__ToList_object_
		                        (iVar1,1,Method_System_Collections_Generic_List_Money__get_Item__);
		      uVar5 = func_ii_7278(*(undefined4 *)(iVar1 + 8),0);
		      uVar5 = Core_Extensions_Dict_ResourcesDicExt__GetUnlimitToolTipText(uVar5,0);
		      local_28 = 0;
		      System_Text_Formatting_StringView__get_IsEmpty
		                (&local_28,StringLiteral_26430,uVar5,
		                 Method_System_Collections_Generic_KeyValuePair_string__string___ctor__);
		      *(undefined8 *)(iVar2 + 0x28) = local_28;
		      *param2 = iVar2;
		      iVar1 = *(int *)(param1 + 0x2c);
		      if (DAT_ram_00a5acf5 == '\0') {
		        Mono_Security_ASN1__get_Item
		                  (&
		                   Method_Google_Protobuf_Collections_RepeatedField_ContentStringMessage__get_Count__
		                  );
		        Mono_Security_ASN1__get_Item
		                  (&
		                   Method_Google_Protobuf_Collections_RepeatedField_ContentStringMessage__get_Item__
		                  );
		        DAT_ram_00a5acf5 = '\x01';
		      }
		      if (0 < *(int *)(iVar1 + 0xc)) {
		        do {
		          iVar2 = Google_Protobuf_Collections_RepeatedField_Int32Enum___get_IsReadOnly
		                            (iVar1,iVar3,
		                             Method_Google_Protobuf_Collections_RepeatedField_ContentStringMessage__get_Item__
		                            );
		          if (*(int *)(iVar2 + 0xc) == 0x71) {
		            return *(undefined4 *)(iVar2 + 0x10);
		          }
		          iVar3 = iVar3 + 1;
		        } while (iVar3 < *(int *)(iVar1 + 0xc));
		        iVar3 = 0;
		      }
		    }
		    else {
		      iVar1 = Mono_Security_ASN1Convert__ToOid
		                        (System_Collections_Generic_KeyValuePair_string__string____TypeInfo,0);
		      *param2 = iVar1;
		      iVar3 = StringLiteral_12336;
		    }
		  }
		  else {
		    iVar1 = Mono_Security_ASN1Convert__ToOid
		                      (System_Collections_Generic_KeyValuePair_string__string____TypeInfo,0);
		    *param2 = iVar1;
		    iVar1 = *(int *)(param1 + 0x2c);
		    if (DAT_ram_00a5acf5 == '\0') {
		      Mono_Security_ASN1__get_Item
		                (&Method_Google_Protobuf_Collections_RepeatedField_ContentStringMessage__get_Count__
		                );
		      Mono_Security_ASN1__get_Item
		                (&Method_Google_Protobuf_Collections_RepeatedField_ContentStringMessage__get_Item__)
		      ;
		      DAT_ram_00a5acf5 = '\x01';
		    }
		    iVar3 = 0;
		    if (0 < *(int *)(iVar1 + 0xc)) {
		      do {
		        iVar2 = Google_Protobuf_Collections_RepeatedField_Int32Enum___get_IsReadOnly
		                          (iVar1,iVar3,
		                           Method_Google_Protobuf_Collections_RepeatedField_ContentStringMessage__get_Item__
		                          );
		        if (*(int *)(iVar2 + 0xc) == 0x6f) {
		          return *(undefined4 *)(iVar2 + 0x10);
		        }
		        iVar3 = iVar3 + 1;
		      } while (iVar3 < *(int *)(iVar1 + 0xc));
		      iVar3 = 0;
		    }
		  }
		  return iVar3;
		}
		*/

			return null;
		}

		// Token: 0x06005F7D RID: 24445 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005F7D")]
		[Address(RVA = "0xABBE", Offset = "0xABBE", VA = "0xABBE")]
		public static string GetToolTipText(this PaymentBonusesDic dic, out KeyValuePair<string, string>[] props)
		{
		/* --- GHIDRA: GetToolTipText ---
		undefined4
		Core_Extensions_Dict_PaymentBonusesDicExt__GetToolTipText(int param1,int *param2,undefined4 param3)
		
		{
		  int iVar1;
		  int iVar2;
		  int iVar3;
		  undefined4 uVar4;
		  undefined8 local_28;
		  undefined8 local_20;
		  undefined8 local_18;
		  undefined8 local_10;
		  float8 local_8;
		  
		  if (DAT_ram_00a5ad86 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Globalization_CultureInfo_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_ToList_Money___);
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_KeyValuePair_string__string____TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_KeyValuePair_string__string___ctor__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_Money__get_Count__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_Money__get_Item__);
		    Mono_Security_ASN1__get_Item(&Core_Money_Money_MoneyType_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Money_Money_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_3538);
		    Mono_Security_ASN1__get_Item(&StringLiteral_21395);
		    Mono_Security_ASN1__get_Item(&StringLiteral_26430);
		    Mono_Security_ASN1__get_Item(&StringLiteral_21396);
		    Mono_Security_ASN1__get_Item(&StringLiteral_26429);
		    Mono_Security_ASN1__get_Item(&StringLiteral_3537);
		    Mono_Security_ASN1__get_Item(&StringLiteral_12336);
		    Mono_Security_ASN1__get_Item(&StringLiteral_3536);
		    DAT_ram_00a5ad86 = '\x01';
		  }
		  uVar4 = *(undefined4 *)(param1 + 0x10);
		  if (*(int *)(Core_Money_Money_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Money_Money_TypeInfo);
		  }
		  uVar4 = Core_Money_Money__op_Explicit(uVar4,0);
		  iVar1 = Core_Money_Money__op_Multiply(uVar4,0);
		  if (iVar1 == 0) {
		    iVar1 = System_Linq_Enumerable__Select_object__object_
		                      (uVar4,Method_System_Linq_Enumerable_ToList_Money___);
		    if (*(int *)(iVar1 + 0xc) == 1) {
		      iVar2 = Mono_Security_ASN1Convert__ToOid
		                        (System_Collections_Generic_KeyValuePair_string__string____TypeInfo,2);
		      iVar3 = System_Linq_Enumerable__ToList_object_
		                        (iVar1,0,Method_System_Collections_Generic_List_Money__get_Item__);
		      local_8 = *(float8 *)(iVar3 + 0x10);
		      if (*(int *)(System_Globalization_CultureInfo_TypeInfo + 0x74) == 0) {
		        func_ii_306000(System_Globalization_CultureInfo_TypeInfo);
		      }
		      uVar4 = System_Xml_Schema_SchemaCollectionCompiler__GetAnySchemaType(0);
		      uVar4 = System_Double__GetHashCode(&local_8,uVar4,0);
		      local_10 = 0;
		      System_Text_Formatting_StringView__get_IsEmpty
		                (&local_10,StringLiteral_21395,uVar4,
		                 Method_System_Collections_Generic_KeyValuePair_string__string___ctor__);
		      *(undefined8 *)(iVar2 + 0x10) = local_10;
		      iVar1 = System_Linq_Enumerable__ToList_object_
		                        (iVar1,0,Method_System_Collections_Generic_List_Money__get_Item__);
		      uVar4 = *(undefined4 *)(iVar1 + 8);
		      if (*(int *)(Core_Money_Money_MoneyType_TypeInfo + 0x74) == 0) {
		        func_ii_306000(Core_Money_Money_MoneyType_TypeInfo);
		      }
		      uVar4 = func_ii_7278(uVar4,0);
		      uVar4 = Core_Extensions_Dict_ResourcesDicExt__GetUnlimitToolTipText(uVar4,0);
		      local_18 = 0;
		      System_Text_Formatting_StringView__get_IsEmpty
		                (&local_18,StringLiteral_26429,uVar4,
		                 Method_System_Collections_Generic_KeyValuePair_string__string___ctor__);
		      *(undefined8 *)(iVar2 + 0x18) = local_18;
		      *param2 = iVar2;
		      uVar4 = StringLiteral_3537;
		    }
		    else if (*(int *)(iVar1 + 0xc) == 2) {
		      iVar2 = Mono_Security_ASN1Convert__ToOid
		                        (System_Collections_Generic_KeyValuePair_string__string____TypeInfo,4);
		      iVar3 = System_Linq_Enumerable__ToList_object_
		                        (iVar1,0,Method_System_Collections_Generic_List_Money__get_Item__);
		      local_8 = *(float8 *)(iVar3 + 0x10);
		      if (*(int *)(System_Globalization_CultureInfo_TypeInfo + 0x74) == 0) {
		        func_ii_306000(System_Globalization_CultureInfo_TypeInfo);
		      }
		      uVar4 = System_Xml_Schema_SchemaCollectionCompiler__GetAnySchemaType(0);
		      uVar4 = System_Double__GetHashCode(&local_8,uVar4,0);
		      local_10 = 0;
		      System_Text_Formatting_StringView__get_IsEmpty
		                (&local_10,StringLiteral_21395,uVar4,
		                 Method_System_Collections_Generic_KeyValuePair_string__string___ctor__);
		      *(undefined8 *)(iVar2 + 0x10) = local_10;
		      iVar3 = System_Linq_Enumerable__ToList_object_
		                        (iVar1,0,Method_System_Collections_Generic_List_Money__get_Item__);
		      uVar4 = *(undefined4 *)(iVar3 + 8);
		      if (*(int *)(Core_Money_Money_MoneyType_TypeInfo + 0x74) == 0) {
		        func_ii_306000(Core_Money_Money_MoneyType_TypeInfo);
		      }
		      uVar4 = func_ii_7278(uVar4,0);
		      uVar4 = Core_Extensions_Dict_ResourcesDicExt__GetUnlimitToolTipText(uVar4,0);
		      local_18 = 0;
		      System_Text_Formatting_StringView__get_IsEmpty
		                (&local_18,StringLiteral_26429,uVar4,
		                 Method_System_Collections_Generic_KeyValuePair_string__string___ctor__);
		      *(undefined8 *)(iVar2 + 0x18) = local_18;
		      iVar3 = System_Linq_Enumerable__ToList_object_
		                        (iVar1,1,Method_System_Collections_Generic_List_Money__get_Item__);
		      local_8 = *(float8 *)(iVar3 + 0x10);
		      uVar4 = System_Xml_Schema_SchemaCollectionCompiler__GetAnySchemaType(0);
		      uVar4 = System_Double__GetHashCode(&local_8,uVar4,0);
		      local_20 = 0;
		      System_Text_Formatting_StringView__get_IsEmpty
		                (&local_20,StringLiteral_21396,uVar4,
		                 Method_System_Collections_Generic_KeyValuePair_string__string___ctor__);
		      *(undefined8 *)(iVar2 + 0x20) = local_20;
		      iVar1 = System_Linq_Enumerable__ToList_object_
		                        (iVar1,1,Method_System_Collections_Generic_List_Money__get_Item__);
		      uVar4 = func_ii_7278(*(undefined4 *)(iVar1 + 8),0);
		      uVar4 = Core_Extensions_Dict_ResourcesDicExt__GetUnlimitToolTipText(uVar4,0);
		      local_28 = 0;
		      System_Text_Formatting_StringView__get_IsEmpty
		                (&local_28,StringLiteral_26430,uVar4,
		                 Method_System_Collections_Generic_KeyValuePair_string__string___ctor__);
		      *(undefined8 *)(iVar2 + 0x28) = local_28;
		      *param2 = iVar2;
		      uVar4 = StringLiteral_3538;
		    }
		    else {
		      iVar1 = Mono_Security_ASN1Convert__ToOid
		                        (System_Collections_Generic_KeyValuePair_string__string____TypeInfo,0);
		      *param2 = iVar1;
		      uVar4 = StringLiteral_12336;
		    }
		  }
		  else {
		    iVar1 = Mono_Security_ASN1Convert__ToOid
		                      (System_Collections_Generic_KeyValuePair_string__string____TypeInfo,0);
		    *param2 = iVar1;
		    uVar4 = StringLiteral_3536;
		  }
		  return uVar4;
		}
		*/

			return null;
		}

		// Token: 0x06005F7E RID: 24446 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005F7E")]
		[Address(RVA = "0xABBF", Offset = "0xABBF", VA = "0xABBF")]
		public static string GetLocaleKeyForBank(this PaymentBonusesDic dic, out KeyValuePair<string, string>[] props)
		{
		/* --- GHIDRA: GetLocaleKeyForBank ---
		undefined4
		Core_Extensions_Dict_PaymentBonusesDicExt__GetLocaleKeyForBank
		          (int param1,int param2,undefined4 param3)
		
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
		      if (param2 == *(int *)(iVar1 + 0xc)) {
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
