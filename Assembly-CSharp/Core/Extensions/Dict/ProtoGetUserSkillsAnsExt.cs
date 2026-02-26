using System;
using Il2CppDummyDll;
using Protocol.Main;

namespace Core.Extensions.Dict
{
	// Token: 0x02000F95 RID: 3989
	[Token(Token = "0x2000F95")]
	public static class ProtoGetUserSkillsAnsExt
	{
		// Token: 0x06005F9F RID: 24479 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005F9F")]
		[Address(RVA = "0xABDB", Offset = "0xABDB", VA = "0xABDB")]
		public static ProtoSkillsChangedEvt ToSkillChangedEvt(this ProtoGetUserSkillsAns data)
		{
		/* --- GHIDRA: ToSkillChangedEvt ---
		undefined4
		Core_Extensions_Dict_ProtoGetUserSkillsAnsExt__ToSkillChangedEvt(int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  int iVar1;
		  
		  param1_00 = 0;
		  iVar1 = Core_Extensions_Dict_DictExt__GetApr(*(undefined4 *)(param1 + 0x20),0xa9,0);
		  if (iVar1 != 0) {
		    param1_00 = *(undefined4 *)(iVar1 + 0x10);
		  }
		  iVar1 = Newtonsoft_Json_Serialization_JsonSerializerInternalReader__ShouldDeserialize(param1_00,0)
		  ;
		  if (iVar1 != 0) {
		    param1_00 = 0;
		    iVar1 = Core_Extensions_Dict_DictExt__GetApr(*(undefined4 *)(param1 + 0x20),0xaa,0);
		    if (iVar1 != 0) {
		      param1_00 = *(undefined4 *)(iVar1 + 0x10);
		    }
		  }
		  return param1_00;
		}
		*/

			return null;
		}
	}
}
