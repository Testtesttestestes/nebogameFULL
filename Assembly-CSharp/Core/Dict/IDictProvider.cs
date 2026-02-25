using System;
using Core.Dict.DictWrappers.Base;
using Il2CppDummyDll;
using Protocol.Dic;

namespace Core.Dict
{
	// Token: 0x02001095 RID: 4245
	[Token(Token = "0x2001095")]
	public interface IDictProvider
	{
		// Token: 0x1400022E RID: 558
		// (add) Token: 0x060062BF RID: 25279
		// (remove) Token: 0x060062C0 RID: 25280
		[Token(Token = "0x1400022E")]
		event Action ChangedEvent;

		// Token: 0x170013A9 RID: 5033
		// (get) Token: 0x060062C1 RID: 25281
		[Token(Token = "0x170013A9")]
		Dictionaries D { [Token(Token = "0x60062C1")] get; }

		// Token: 0x170013AA RID: 5034
		// (get) Token: 0x060062C2 RID: 25282
		[Token(Token = "0x170013AA")]
		DictWrappersStorage WrappersStorage { [Token(Token = "0x60062C2")] get; }
	}
}
