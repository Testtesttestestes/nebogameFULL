using System;
using Il2CppDummyDll;

namespace Core.GameTime
{
	// Token: 0x02000EC8 RID: 3784
	[Token(Token = "0x2000EC8")]
	public interface ICurrentTimeProvider : IDisposable
	{
		// Token: 0x06005C2C RID: 23596
		[Token(Token = "0x6005C2C")]
		ulong GetUnixTimeMilliseconds();
	}
}
