using System;
using Google.Protobuf;
using Il2CppDummyDll;

namespace Core.Net.Factories
{
	// Token: 0x02000EA1 RID: 3745
	[Token(Token = "0x2000EA1")]
	public interface IProtocolMessageFactory
	{
		// Token: 0x17001288 RID: 4744
		// (get) Token: 0x06005B05 RID: 23301
		[Token(Token = "0x17001288")]
		int ServiceId { [Token(Token = "0x6005B05")] get; }

		// Token: 0x17001289 RID: 4745
		// (get) Token: 0x06005B06 RID: 23302
		[Token(Token = "0x17001289")]
		int Id { [Token(Token = "0x6005B06")] get; }

		// Token: 0x06005B07 RID: 23303
		[Token(Token = "0x6005B07")]
		IMessage CreateMessage();
	}
}
