using System;
using Il2CppDummyDll;
using Protocol.Dic;

namespace Core.Extensions.Dict
{
	// Token: 0x02000F9E RID: 3998
	[Token(Token = "0x2000F9E")]
	public static class RewardDicExt
	{
		// Token: 0x06005FD5 RID: 24533 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005FD5")]
		[Address(RVA = "0xAC0C", Offset = "0xAC0C", VA = "0xAC0C")]
		public static string GetIconAssetId(this RewardDic dic)
		{
		/* --- GHIDRA: GetIconAssetId ---
		int Core_Extensions_Dict_RewardDicExt__GetIconAssetId(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  uint uVar2;
		  
		  if (DAT_ram_00a5a341 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_Google_Protobuf_Collections_RepeatedField_uint__get_Item__)
		    ;
		    DAT_ram_00a5a341 = '\x01';
		  }
		  iVar1 = Utils_MoneyUtils__Create(0.0,0.0,0.0,NAN,NAN,0);
		  uVar2 = Google_Protobuf_Collections_RepeatedField_Int32Enum___get_IsReadOnly
		                    (*(undefined4 *)(param1 + 0x10),0,
		                     Method_Google_Protobuf_Collections_RepeatedField_uint__get_Item__);
		  *(double *)(iVar1 + 0x10) = (double)uVar2;
		  uVar2 = Google_Protobuf_Collections_RepeatedField_Int32Enum___get_IsReadOnly
		                    (*(undefined4 *)(param1 + 0x10),1,
		                     Method_Google_Protobuf_Collections_RepeatedField_uint__get_Item__);
		  *(double *)(iVar1 + 0x18) = (double)uVar2;
		  uVar2 = Google_Protobuf_Collections_RepeatedField_Int32Enum___get_IsReadOnly
		                    (*(undefined4 *)(param1 + 0x10),2,
		                     Method_Google_Protobuf_Collections_RepeatedField_uint__get_Item__);
		  *(double *)(iVar1 + 0x20) = (double)uVar2;
		  uVar2 = Google_Protobuf_Collections_RepeatedField_Int32Enum___get_IsReadOnly
		                    (*(undefined4 *)(param1 + 0x10),3,
		                     Method_Google_Protobuf_Collections_RepeatedField_uint__get_Item__);
		  *(double *)(iVar1 + 0x28) = (double)uVar2;
		  uVar2 = Google_Protobuf_Collections_RepeatedField_Int32Enum___get_IsReadOnly
		                    (*(undefined4 *)(param1 + 0x10),4,
		                     Method_Google_Protobuf_Collections_RepeatedField_uint__get_Item__);
		  *(double *)(iVar1 + 0x30) = (double)uVar2;
		  return iVar1;
		}
		*/

			return null;
		}
	}
}
