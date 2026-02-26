using System;
using Core.Dict.DictWrappers.Base;
using Il2CppDummyDll;
using Protocol.Dic;

namespace Core.Dict.DictWrappers.Wrappers
{
	// Token: 0x02001097 RID: 4247
	[Token(Token = "0x2001097")]
	public class AprDicWrapper : AbstractDictWrapper<AprDic, uint>
	{
		// Token: 0x060062D1 RID: 25297 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60062D1")]
		[Address(RVA = "0xAEF0", Offset = "0xAEF0", VA = "0xAEF0", Slot = "7")]
		protected override AprDic GetData(Dictionaries dictionaries)
		{
		/* --- GHIDRA: GetData ---
		void Core_Dict_DictWrappers_Wrappers_AprDicWrapper__GetData(undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a60744 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Dict_DictWrappers_Base_AbstractDictWrapper_AprDic__uint___ctor__);
		    DAT_ram_00a60744 = '\x01';
		  }
		  return;
		}
		*/

			return null;
		}

		// Token: 0x060062D2 RID: 25298 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60062D2")]
		[Address(RVA = "0xAEF1", Offset = "0xAEF1", VA = "0xAEF1")]
		public AprDicWrapper()
		{
		/* --- GHIDRA: .ctor ---
		undefined4
		Core_Dict_DictWrappers_Wrappers_AprDicWrapper___ctor(int param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a60745 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Dict_DictWrappers_Base_AbstractDictWrapper_ArtikulDic__uint__get_Id__);
		    DAT_ram_00a60745 = '\x01';
		  }
		  uVar1 = Gameplay_Inventory_Model_InventoryBaseModel__GetCount
		                    (param2,*(undefined4 *)(param1 + 0xc),0);
		  return uVar1;
		}
		*/

		}
	}
}
