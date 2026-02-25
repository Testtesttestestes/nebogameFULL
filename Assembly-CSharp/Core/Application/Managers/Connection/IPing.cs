using System;
using Google.Protobuf;
using Il2CppDummyDll;
using Utils;

namespace Core.Application.Managers.Connection
{
	// Token: 0x02001269 RID: 4713
	[Token(Token = "0x2001269")]
	public interface IPing
	{
		// Token: 0x06006FD1 RID: 28625
		[Token(Token = "0x6006FD1")]
		bool TrySend(out uint index, out OpToken<IMessage, object> token);
	}
}
