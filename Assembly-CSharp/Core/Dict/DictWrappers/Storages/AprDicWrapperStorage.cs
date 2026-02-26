using System;
using Core.Dict.DictWrappers.Base;
using Core.Dict.DictWrappers.Wrappers;
using Il2CppDummyDll;

namespace Core.Dict.DictWrappers.Storages
{
	// Token: 0x0200109C RID: 4252
	[Token(Token = "0x200109C")]
	public class AprDicWrapperStorage : AbstractDictWrapperStorage<AprDicWrapper, uint>
	{
		// Token: 0x060062DE RID: 25310 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60062DE")]
		[Address(RVA = "0xAEFD", Offset = "0xAEFD", VA = "0xAEFD")]
		public AprDicWrapperStorage(IDictProvider dictProvider)
		{
		/* --- GHIDRA: .ctor ---
		void Core_Dict_DictWrappers_Storages_AprDicWrapperStorage___ctor
		               (undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  if (DAT_ram_00a6074c == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Dict_DictWrappers_Base_AbstractDictWrapperStorage_ArtikulDicWrapper__uint___ctor__
		              );
		    DAT_ram_00a6074c = '\x01';
		  }
		  Core_Dict_DictWrappers_Base_AbstractDictWrapperStorage_object__object___UpdateWrappers
		            (param1,param2,
		             Method_Core_Dict_DictWrappers_Base_AbstractDictWrapperStorage_ArtikulDicWrapper__uint___ctor__
		            );
		  return;
		}
		*/

		}
	}
}
