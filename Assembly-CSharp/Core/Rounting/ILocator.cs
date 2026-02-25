using System;
using Il2CppDummyDll;

namespace Core.Rounting
{
	// Token: 0x02000E7C RID: 3708
	[Token(Token = "0x2000E7C")]
	public interface ILocator : IDisposable
	{
		// Token: 0x17001266 RID: 4710
		// (get) Token: 0x06005A4E RID: 23118
		[Token(Token = "0x17001266")]
		string[] Schemes { [Token(Token = "0x6005A4E")] get; }

		// Token: 0x17001267 RID: 4711
		// (get) Token: 0x06005A4F RID: 23119
		[Token(Token = "0x17001267")]
		string Host { [Token(Token = "0x6005A4F")] get; }

		// Token: 0x06005A50 RID: 23120
		[Token(Token = "0x6005A50")]
		bool TryExecute(Uri uri);
	}
}
