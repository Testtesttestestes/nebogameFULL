using System;
using Core.Dict.DictWrappers.Base;
using Core.Dict.DictWrappers.Wrappers;
using Il2CppDummyDll;

namespace Core.Dict.DictWrappers.Storages
{
	// Token: 0x0200109E RID: 4254
	[Token(Token = "0x200109E")]
	public class MedalsDicWrapperStorage : AbstractDictWrapperStorage<MedalDicWrapper, uint>
	{
		// Token: 0x060062E0 RID: 25312 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60062E0")]
		[Address(RVA = "0xAEFF", Offset = "0xAEFF", VA = "0xAEFF")]
		public MedalsDicWrapperStorage(IDictProvider dictProvider)
		{
		/* --- GHIDRA: .ctor ---
		void Core_Dict_DictWrappers_Storages_MedalsDicWrapperStorage___ctor
		               (undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  if (DAT_ram_00a6074e == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Dict_DictWrappers_Base_AbstractDictWrapperStorage_UserBuildingLevelDicWrapper__UserBuildingLevelDicWrapper_UserBuildingLevelDicWrapperId___ctor__
		              );
		    DAT_ram_00a6074e = '\x01';
		  }
		  UI_AbstractDataRenderer___Il2CppFullySharedGenericType___set_Data
		            (param1,param2,
		             Method_Core_Dict_DictWrappers_Base_AbstractDictWrapperStorage_UserBuildingLevelDicWrapper__UserBuildingLevelDicWrapper_UserBuildingLevelDicWrapperId___ctor__
		            );
		  return;
		}
		*/

		}
	}
}
