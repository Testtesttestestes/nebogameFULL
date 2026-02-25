using System;
using Il2CppDummyDll;
using Protocol.Dic;

namespace Core.Dict.DictWrappers.Base
{
	// Token: 0x020010A3 RID: 4259
	[Token(Token = "0x20010A3")]
	public interface IManagedDictWrapper<TId>
	{
		// Token: 0x060062FB RID: 25339
		[Token(Token = "0x60062FB")]
		void UpdateData(Dictionaries dictionaries);

		// Token: 0x170013BA RID: 5050
		// (set) Token: 0x060062FC RID: 25340
		[Token(Token = "0x170013BA")]
		TId Id { [Token(Token = "0x60062FC")] set; }
	}
}
