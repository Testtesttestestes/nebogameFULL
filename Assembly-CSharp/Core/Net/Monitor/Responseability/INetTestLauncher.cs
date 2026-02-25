using System;
using Core.Net.Monitor.Responseability.Testing.Common;
using Il2CppDummyDll;

namespace Core.Net.Monitor.Responseability
{
	// Token: 0x02000E96 RID: 3734
	[Token(Token = "0x2000E96")]
	public interface INetTestLauncher
	{
		// Token: 0x06005ACC RID: 23244
		[Token(Token = "0x6005ACC")]
		bool TryCreateTest(out INetTest test);
	}
}
