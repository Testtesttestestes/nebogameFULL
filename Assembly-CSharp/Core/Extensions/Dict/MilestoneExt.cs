using System;
using Il2CppDummyDll;
using Protocol.Dic;

namespace Core.Extensions.Dict
{
	// Token: 0x02000F81 RID: 3969
	[Token(Token = "0x2000F81")]
	public static class MilestoneExt
	{
		// Token: 0x06005F5E RID: 24414 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005F5E")]
		[Address(RVA = "0x1AA9", Offset = "0x1AA9", VA = "0x1AA9")]
		public static string GetTitle(this GameEventDic.Types.Milestone dict)
		{
		/* --- GHIDRA: GetTitle ---
		uint Core_Extensions_Dict_MilestoneExt__GetTitle(int *param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint uVar2;
		  uint uVar3;
		  int iVar4;
		  int iVar5;
		  uint uVar6;
		  
		  iVar5 = *param1;
		  if (param1[2] != *(int *)(iVar5 + 0x1c)) {
		    System_ThrowHelper__ThrowNotSupportedException(0);
		    iVar5 = *param1;
		  }
		  uVar2 = param1[1];
		  uVar6 = *(uint *)(iVar5 + 0x10);
		  uVar3 = uVar2;
		  if (uVar2 <= uVar6) {
		    uVar3 = uVar6;
		  }
		  do {
		    uVar1 = uVar2;
		    if (uVar1 == uVar3) {
		      param1[3] = 0;
		      param1[1] = uVar6 + 1;
		      return (uint)(uVar1 < uVar6);
		    }
		    iVar4 = *(int *)(iVar5 + 0xc);
		    param1[1] = uVar1 + 1;
		    iVar4 = iVar4 + 0x10;
		    uVar2 = uVar1 + 1;
		  } while (*(int *)(iVar4 + uVar1 * 0x18) < 0);
		  param1[3] = *(int *)(iVar4 + uVar1 * 0x18 + 0x10);
		  return (uint)(uVar1 < uVar6);
		}
		*/

			return null;
		}

		// Token: 0x06005F5F RID: 24415 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005F5F")]
		[Address(RVA = "0xABA3", Offset = "0xABA3", VA = "0xABA3")]
		public static string GetDescription(this GameEventDic.Types.Milestone dict)
		{
		/* --- GHIDRA: GetDescription ---
		undefined4 Core_Extensions_Dict_MilestoneExt__GetDescription(int param1,undefined4 param2)
		
		{
		  int param2_00;
		  int iVar1;
		  int param1_00;
		  
		  param1_00 = *(int *)(param1 + 0x30);
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
		      if (*(int *)(iVar1 + 0xc) == 0xa9) {
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

		// Token: 0x06005F60 RID: 24416 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005F60")]
		[Address(RVA = "0xABA4", Offset = "0xABA4", VA = "0xABA4")]
		public static string GetDescriptionInList(this GameEventDic.Types.Milestone dict)
		{
		/* --- GHIDRA: GetDescriptionInList ---
		undefined4 Core_Extensions_Dict_MilestoneExt__GetDescriptionInList(int param1,undefined4 param2)
		
		{
		  int param2_00;
		  int iVar1;
		  int param1_00;
		  
		  param1_00 = *(int *)(param1 + 0x30);
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
		      if (*(int *)(iVar1 + 0xc) == 0x75) {
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
