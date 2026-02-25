using System;
using Il2CppDummyDll;

namespace Core
{
	// Token: 0x02000E5A RID: 3674
	[Token(Token = "0x2000E5A")]
	public interface IAsyncLoadableContent
	{
		// Token: 0x1700124D RID: 4685
		// (get) Token: 0x060059EB RID: 23019
		[Token(Token = "0x1700124D")]
		bool IsReady { [Token(Token = "0x60059EB")] get; }

		// Token: 0x1400021E RID: 542
		// (add) Token: 0x060059EC RID: 23020
		// (remove) Token: 0x060059ED RID: 23021
		[Token(Token = "0x1400021E")]
		event Action<IAsyncLoadableContent> ReadyEvent;
	}
}
