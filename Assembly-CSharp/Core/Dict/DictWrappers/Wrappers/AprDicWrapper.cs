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
			return null;
		}

		// Token: 0x060062D2 RID: 25298 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60062D2")]
		[Address(RVA = "0xAEF1", Offset = "0xAEF1", VA = "0xAEF1")]
		public AprDicWrapper()
		{
		}
	}
}
