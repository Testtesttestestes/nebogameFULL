using System;
using Il2CppDummyDll;
using Protocol.Common;
using Protocol.Main;

namespace Core.Extensions.Dict
{
	// Token: 0x02000F94 RID: 3988
	[Token(Token = "0x2000F94")]
	public static class ProtoCastExt
	{
		// Token: 0x06005F9E RID: 24478 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005F9E")]
		[Address(RVA = "0xABDA", Offset = "0xABDA", VA = "0xABDA")]
		public static UserInfo ToUserInfo(this ProtoGetUserInfoAns protoGetUserInfoAns)
		{
		/* --- GHIDRA: ToUserInfo ---
		int Core_Extensions_Dict_ProtoCastExt__ToUserInfo(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  if (DAT_ram_00a5a32a == '\0') {
		    Mono_Security_ASN1__get_Item(&Protocol_Main_ProtoSkillsChangedEvt_TypeInfo);
		    DAT_ram_00a5a32a = '\x01';
		  }
		  iVar1 = unnamed_function_1417(Protocol_Main_ProtoSkillsChangedEvt_TypeInfo);
		  *(undefined4 *)(iVar1 + 0xc) = *(undefined4 *)(param1 + 0xc);
		  *(undefined4 *)(iVar1 + 0x14) = *(undefined4 *)(param1 + 0x14);
		  *(undefined4 *)(iVar1 + 0x10) = *(undefined4 *)(param1 + 0x10);
		  return iVar1;
		}
		*/

			return null;
		}
	}
}
