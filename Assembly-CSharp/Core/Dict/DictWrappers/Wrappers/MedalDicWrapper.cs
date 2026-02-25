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
			return null;
		}

		// Token: 0x060062D6 RID: 25302 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60062D6")]
		[Address(RVA = "0xAEF5", Offset = "0xAEF5", VA = "0xAEF5")]
		public MedalDicWrapper()
		{
		}
	}
}
