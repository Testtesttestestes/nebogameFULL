using System;
using Il2CppDummyDll;
using Protocol.Dic;

namespace Core.Extensions.Dict
{
	// Token: 0x02000F85 RID: 3973
	[Token(Token = "0x2000F85")]
	public static class NotFoundInDictsUtil
	{
		// Token: 0x06005F6D RID: 24429 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005F6D")]
		[Address(RVA = "0xABAF", Offset = "0xABAF", VA = "0xABAF")]
		public static ArtikulDic CreateNotFoundArtikulDic(uint id, string imgURl)
		{
		/* --- GHIDRA: CreateNotFoundArtikulDic ---
		int Core_Extensions_Dict_NotFoundInDictsUtil__CreateNotFoundArtikulDic
		              (undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  int param1_00;
		  undefined4 uVar1;
		  undefined4 local_4;
		  
		  local_4 = param1;
		  if (DAT_ram_00a5ad81 == '\0') {
		    Mono_Security_ASN1__get_Item(&Protocol_Dic_ArtikulTypeDic_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_11652);
		    Mono_Security_ASN1__get_Item(&StringLiteral_1145);
		    DAT_ram_00a5ad81 = '\x01';
		  }
		  param1_00 = unnamed_function_1417(Protocol_Dic_ArtikulTypeDic_TypeInfo);
		  Protocol_Dic_ArtikulTypeDic__pb__Google_Protobuf_IMessage_get_Descriptor(param1_00,0);
		  *(undefined4 *)(param1_00 + 0xc) = param1;
		  uVar1 = Protocol_Combat_ProtoPlayerActionEvt___ctor(&local_4,0);
		  uVar1 = UnityEngine_AndroidJavaObject__FromJavaArray_Nullable_int__
		                    (StringLiteral_11652,uVar1,StringLiteral_1145,0);
		  Protocol_Dic_ArtikulTypeDic__get_Title(param1_00,uVar1,0);
		  Protocol_Dic_ArtikulTypeDic__get_IconUrl(param1_00,param2,0);
		  return param1_00;
		}
		*/

			return null;
		}

		// Token: 0x06005F6E RID: 24430 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005F6E")]
		[Address(RVA = "0xABB0", Offset = "0xABB0", VA = "0xABB0")]
		public static ArtikulTypeDic CreateNotFoundArtikulTypeDic(uint id, string imgURl)
		{
		/* --- GHIDRA: CreateNotFoundArtikulTypeDic ---
		int Core_Extensions_Dict_NotFoundInDictsUtil__CreateNotFoundArtikulTypeDic
		              (undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  int param1_00;
		  undefined4 uVar1;
		  undefined4 local_4;
		  
		  local_4 = param1;
		  if (DAT_ram_00a5ad82 == '\0') {
		    Mono_Security_ASN1__get_Item(&Protocol_Dic_ItemQualityDic_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_11653);
		    Mono_Security_ASN1__get_Item(&StringLiteral_1145);
		    DAT_ram_00a5ad82 = '\x01';
		  }
		  param1_00 = unnamed_function_1417(Protocol_Dic_ItemQualityDic_TypeInfo);
		  Protocol_Dic_ItemQualityDic__pb__Google_Protobuf_IMessage_get_Descriptor(param1_00,0);
		  *(undefined4 *)(param1_00 + 0xc) = param1;
		  uVar1 = Protocol_Combat_ProtoPlayerActionEvt___ctor(&local_4,0);
		  uVar1 = UnityEngine_AndroidJavaObject__FromJavaArray_Nullable_int__
		                    (StringLiteral_11653,uVar1,StringLiteral_1145,0);
		  Protocol_Dic_ItemQualityDic__get_Title(param1_00,uVar1,0);
		  return param1_00;
		}
		*/

			return null;
		}

		// Token: 0x06005F6F RID: 24431 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005F6F")]
		[Address(RVA = "0xABB1", Offset = "0xABB1", VA = "0xABB1")]
		public static ItemQualityDic CreateNotFoundItemQualityDic(uint id, string imgURl)
		{
		/* --- GHIDRA: CreateNotFoundItemQualityDic ---
		int Core_Extensions_Dict_NotFoundInDictsUtil__CreateNotFoundItemQualityDic
		              (undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  int param1_00;
		  undefined4 uVar1;
		  undefined4 local_4;
		  
		  local_4 = param1;
		  if (DAT_ram_00a5ad83 == '\0') {
		    Mono_Security_ASN1__get_Item(&Protocol_Dic_AprDic_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_11650);
		    Mono_Security_ASN1__get_Item(&StringLiteral_1145);
		    DAT_ram_00a5ad83 = '\x01';
		  }
		  param1_00 = unnamed_function_1417(Protocol_Dic_AprDic_TypeInfo);
		  Protocol_Dic_AprDic__pb__Google_Protobuf_IMessage_get_Descriptor(param1_00,0);
		  *(undefined4 *)(param1_00 + 0xc) = param1;
		  uVar1 = Protocol_Combat_ProtoPlayerActionEvt___ctor(&local_4,0);
		  uVar1 = UnityEngine_AndroidJavaObject__FromJavaArray_Nullable_int__
		                    (StringLiteral_11650,uVar1,StringLiteral_1145,0);
		  Protocol_Dic_AprDic__get_Title(param1_00,uVar1,0);
		  return param1_00;
		}
		*/

			return null;
		}

		// Token: 0x06005F70 RID: 24432 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005F70")]
		[Address(RVA = "0xABB2", Offset = "0xABB2", VA = "0xABB2")]
		public static AprDic CreateNotFoundAprDic(uint id, string imgURL)
		{
		/* --- GHIDRA: CreateNotFoundAprDic ---
		void Core_Extensions_Dict_NotFoundInDictsUtil__CreateNotFoundAprDic(undefined4 param1)
		
		{
		  if (DAT_ram_00a5ad84 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Extensions_Dict_NotFoundInDictsUtil_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_11315);
		    DAT_ram_00a5ad84 = '\x01';
		  }
		  **(undefined4 **)(Core_Extensions_Dict_NotFoundInDictsUtil_TypeInfo + 0x5c) = StringLiteral_11315;
		  return;
		}
		*/

			return null;
		}

		// Token: 0x04003328 RID: 13096
		[Token(Token = "0x4003328")]
		[FieldOffset(Offset = "0x0")]
		public static string NOT_FOUND_ENTITY;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: .cctor ---
		undefined4 Core_Extensions_Dict_NotFoundInDictsUtil___cctor(int param1,undefined4 param2)
		
		{
		  int param2_00;
		  int iVar1;
		  int param1_00;
		  
		  param1_00 = *(int *)(param1 + 0x14);
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
		      if (*(int *)(iVar1 + 0xc) == 0x8e) {
		        return *(undefined4 *)(iVar1 + 0x10);
		      }
		      param2_00 = param2_00 + 1;
		    } while (param2_00 < *(int *)(param1_00 + 0xc));
		  }
		  return 0;
		}
		*/

}
