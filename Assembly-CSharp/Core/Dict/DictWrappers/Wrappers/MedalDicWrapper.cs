using System;
using Core.Dict.DictWrappers.Base;
using Il2CppDummyDll;
using Protocol.Dic;

namespace Core.Dict.DictWrappers.Wrappers
{
	// Token: 0x02001099 RID: 4249
	[Token(Token = "0x2001099")]
	public class MedalDicWrapper : AbstractDictWrapper<MedalDic, uint>
	{
		// Token: 0x060062D5 RID: 25301 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60062D5")]
		[Address(RVA = "0xAEF4", Offset = "0xAEF4", VA = "0xAEF4", Slot = "7")]
		protected override MedalDic GetData(Dictionaries dictionaries)
		{
		/* --- GHIDRA: GetData ---
		void Core_Dict_DictWrappers_Wrappers_MedalDicWrapper__GetData(undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a60748 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Dict_DictWrappers_Base_AbstractDictWrapper_MedalDic__uint___ctor__);
		    DAT_ram_00a60748 = '\x01';
		  }
		  return;
		}
		*/

			return null;
		}

		// Token: 0x060062D6 RID: 25302 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60062D6")]
		[Address(RVA = "0xAEF5", Offset = "0xAEF5", VA = "0xAEF5")]
		public MedalDicWrapper()
		{
		/* --- GHIDRA: .ctor ---
		undefined4
		Core_Dict_DictWrappers_Wrappers_MedalDicWrapper___ctor
		          (int param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a60749 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Dict_DictWrappers_Base_AbstractDictWrapper_UserBuildingLevelDic__UserBuildingLevelDicWrapper_UserBuildingLevelDicWrapperId__get_Id__
		              );
		    DAT_ram_00a60749 = '\x01';
		  }
		  uVar1 = Core_Extensions_Dict_DictExt__GetUserBuildingViewsDic
		                    (param2,*(undefined4 *)(*(int *)(param1 + 0xc) + 8),
		                     *(undefined4 *)(*(int *)(param1 + 0xc) + 0xc),0);
		  return uVar1;
		}
		*/

		}
	}
}
