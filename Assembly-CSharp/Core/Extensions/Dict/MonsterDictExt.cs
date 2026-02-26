using System;
using Il2CppDummyDll;
using Protocol.Dic;

namespace Core.Extensions.Dict
{
	// Token: 0x02000F83 RID: 3971
	[Token(Token = "0x2000F83")]
	public static class MonsterDictExt
	{
		// Token: 0x06005F63 RID: 24419 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005F63")]
		[Address(RVA = "0x1B51", Offset = "0x1B51", VA = "0x1B51")]
		public static string GetTitle(this MonsterDic dic)
		{
		/* --- GHIDRA: GetTitle ---
		void Core_Extensions_Dict_MonsterDictExt__GetTitle(int param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  
		  iVar1 = **(int **)(param1 + 0x10);
		  (**(code **)((ulonglong)*(uint *)(iVar1 + 0x2d0) * 4))
		            (*(int **)(param1 + 0x10),param2,*(undefined4 *)(iVar1 + 0x2d4));
		  return;
		}
		*/

			return null;
		}

		// Token: 0x06005F64 RID: 24420 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005F64")]
		[Address(RVA = "0x1B56", Offset = "0x1B56", VA = "0x1B56")]
		public static string GetDescription(this MonsterDic dic)
		{
		/* --- GHIDRA: GetDescription ---
		void Core_Extensions_Dict_MonsterDictExt__GetDescription
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  
		  iVar1 = **(int **)(param1 + 0x34);
		  (**(code **)((ulonglong)*(uint *)(iVar1 + 0x2d0) * 4))
		            (*(int **)(param1 + 0x34),param2,*(undefined4 *)(iVar1 + 0x2d4));
		  return;
		}
		*/

			return null;
		}

		// Token: 0x06005F65 RID: 24421 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005F65")]
		[Address(RVA = "0xABA7", Offset = "0xABA7", VA = "0xABA7")]
		public static string GetGameEventLibraryDescription(this MonsterDic dic)
		{
		/* --- GHIDRA: GetGameEventLibraryDescription ---
		undefined4
		Core_Extensions_Dict_MonsterDictExt__GetGameEventLibraryDescription(int param1,undefined4 param2)
		
		{
		  int param2_00;
		  int iVar1;
		  int param1_00;
		  undefined4 uVar2;
		  
		  param1_00 = *(int *)(param1 + 0x10);
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
		                             ), *(int *)(iVar1 + 0xc) != 0xcf) {
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
