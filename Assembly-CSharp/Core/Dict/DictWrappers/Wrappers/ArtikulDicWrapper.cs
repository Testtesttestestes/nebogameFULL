using System;
using Core.Dict.DictWrappers.Base;
using Il2CppDummyDll;
using Protocol.Dic;

namespace Core.Dict.DictWrappers.Wrappers
{
	// Token: 0x02001098 RID: 4248
	[Token(Token = "0x2001098")]
	public class ArtikulDicWrapper : AbstractDictWrapper<ArtikulDic, uint>
	{
		// Token: 0x060062D3 RID: 25299 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60062D3")]
		[Address(RVA = "0xAEF2", Offset = "0xAEF2", VA = "0xAEF2", Slot = "7")]
		protected override ArtikulDic GetData(Dictionaries dictionaries)
		{
		/* --- GHIDRA: GetData ---
		void Core_Dict_DictWrappers_Wrappers_ArtikulDicWrapper__GetData(undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a60746 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Dict_DictWrappers_Base_AbstractDictWrapper_ArtikulDic__uint___ctor__);
		    DAT_ram_00a60746 = '\x01';
		  }
		  return;
		}
		*/

			return null;
		}

		// Token: 0x060062D4 RID: 25300 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60062D4")]
		[Address(RVA = "0xAEF3", Offset = "0xAEF3", VA = "0xAEF3")]
		public ArtikulDicWrapper()
		{
		/* --- GHIDRA: .ctor ---
		undefined4
		Core_Dict_DictWrappers_Wrappers_ArtikulDicWrapper___ctor
		          (int param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a60747 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Dict_DictWrappers_Base_AbstractDictWrapper_MedalDic__uint__get_Id__);
		    DAT_ram_00a60747 = '\x01';
		  }
		  uVar1 = Core_Gameplay_Managers_Requirements_RequirementsInfoProvider___c__DisplayClass17_0___ctor
		                    (param2,*(undefined4 *)(param1 + 0xc),0);
		  return uVar1;
		}
		*/

		}
	}
}
