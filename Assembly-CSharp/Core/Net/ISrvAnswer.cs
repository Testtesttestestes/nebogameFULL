using System;
using Google.Protobuf;
using Il2CppDummyDll;

namespace Core.Net
{
	// Token: 0x02000E88 RID: 3720
	[Token(Token = "0x2000E88")]
	public interface ISrvAnswer
	{
		// Token: 0x1700126E RID: 4718
		// (get) Token: 0x06005A80 RID: 23168
		[Token(Token = "0x1700126E")]
		uint CmdIndex { [Token(Token = "0x6005A80")] get; }

		// Token: 0x1700126F RID: 4719
		// (get) Token: 0x06005A81 RID: 23169
		[Token(Token = "0x1700126F")]
		IMessage Message { [Token(Token = "0x6005A81")] get; }

		// Token: 0x17001270 RID: 4720
		// (get) Token: 0x06005A82 RID: 23170
		[Token(Token = "0x17001270")]
		long Latency { [Token(Token = "0x6005A82")] get; }
	}
}
