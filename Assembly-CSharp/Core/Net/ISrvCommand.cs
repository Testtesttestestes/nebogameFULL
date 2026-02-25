using System;
using Core.Net.Factories;
using Il2CppDummyDll;

namespace Core.Net
{
	// Token: 0x02000E89 RID: 3721
	[Token(Token = "0x2000E89")]
	public interface ISrvCommand : IDisposable
	{
		// Token: 0x17001271 RID: 4721
		// (get) Token: 0x06005A83 RID: 23171
		[Token(Token = "0x17001271")]
		uint CommandIndex { [Token(Token = "0x6005A83")] get; }

		// Token: 0x17001272 RID: 4722
		// (get) Token: 0x06005A84 RID: 23172
		[Token(Token = "0x17001272")]
		long CreateTimestamp { [Token(Token = "0x6005A84")] get; }

		// Token: 0x17001273 RID: 4723
		// (get) Token: 0x06005A85 RID: 23173
		[Token(Token = "0x17001273")]
		long SerializeTimestamp { [Token(Token = "0x6005A85")] get; }

		// Token: 0x17001274 RID: 4724
		// (get) Token: 0x06005A86 RID: 23174
		[Token(Token = "0x17001274")]
		IProtocolMessageFactory MessageFactory { [Token(Token = "0x6005A86")] get; }

		// Token: 0x06005A87 RID: 23175
		[Token(Token = "0x6005A87")]
		string ToString();
	}
}
