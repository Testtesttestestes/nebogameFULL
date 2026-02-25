using System;
using Il2CppDummyDll;

namespace Gameplay.Bank.Model
{
	// Token: 0x02000C5C RID: 3164
	[Token(Token = "0x2000C5C")]
	public interface IOptionValidator
	{
		// Token: 0x06004D49 RID: 19785
		[Token(Token = "0x6004D49")]
		bool IsOptionValid(BankOptionData bankOptionData);
	}
}
