using System;
using Core.Dict.DictWrappers.Base;
using Core.Dict.DictWrappers.Wrappers;
using Il2CppDummyDll;

namespace Core.Dict.DictWrappers.Storages
{
	// Token: 0x0200109D RID: 4253
	[Token(Token = "0x200109D")]
	public class ArtikulDicWrapperStorage : AbstractDictWrapperStorage<ArtikulDicWrapper, uint>
	{
		// Token: 0x060062DF RID: 25311 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60062DF")]
		[Address(RVA = "0xAEFE", Offset = "0xAEFE", VA = "0xAEFE")]
		public ArtikulDicWrapperStorage(IDictProvider dictProvider)
		{
		/* --- GHIDRA: .ctor ---
		void Core_Dict_DictWrappers_Storages_ArtikulDicWrapperStorage___ctor
		               (undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  if (DAT_ram_00a6074d == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Dict_DictWrappers_Base_AbstractDictWrapperStorage_MedalDicWrapper__uint___ctor__
		              );
		    DAT_ram_00a6074d = '\x01';
		  }
		  Core_Dict_DictWrappers_Base_AbstractDictWrapperStorage_object__object___UpdateWrappers
		            (param1,param2,
		             Method_Core_Dict_DictWrappers_Base_AbstractDictWrapperStorage_MedalDicWrapper__uint___ctor__
		            );
		  return;
		}
		*/

		}
	}
}
