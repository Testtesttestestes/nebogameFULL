using System;
using Il2CppDummyDll;
using Protocol.Dic;

namespace Core.Extensions.Dict
{
	// Token: 0x02000F67 RID: 3943
	[Token(Token = "0x2000F67")]
	public static class DuelUserStateFlagsExt
	{
		// Token: 0x06005F1D RID: 24349 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005F1D")]
		[Address(RVA = "0xAB69", Offset = "0xAB69", VA = "0xAB69")]
		public static string GetDescription(this DuelUserStateFlags dic)
		{
		/* --- GHIDRA: GetDescription ---
		undefined4
		Core_Extensions_Dict_DuelUserStateFlagsExt__GetDescription(int param1,int param2,undefined4 param3)
		
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
	}
}
