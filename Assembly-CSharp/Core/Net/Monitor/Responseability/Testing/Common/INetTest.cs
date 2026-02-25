using System;
using Il2CppDummyDll;

namespace Core.Net.Monitor.Responseability.Testing.Common
{
	// Token: 0x02000E9B RID: 3739
	[Token(Token = "0x2000E9B")]
	public interface INetTest : IDisposable
	{
		// Token: 0x17001286 RID: 4742
		// (get) Token: 0x06005AF2 RID: 23282
		[Token(Token = "0x17001286")]
		long Index { [Token(Token = "0x6005AF2")] get; }

		// Token: 0x06005AF3 RID: 23283
		[Token(Token = "0x6005AF3")]
		bool IsComplete();

		// Token: 0x06005AF4 RID: 23284
		[Token(Token = "0x6005AF4")]
		ResponseAbilityStatus GetStatus();
	}
}
