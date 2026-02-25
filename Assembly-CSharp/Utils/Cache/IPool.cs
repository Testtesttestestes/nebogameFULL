using System;
using Il2CppDummyDll;

namespace Utils.Cache
{
	// Token: 0x02000074 RID: 116
	[Token(Token = "0x2000074")]
	public interface IPool<out T> : IDisposable
	{
		// Token: 0x0600035E RID: 862
		[Token(Token = "0x600035E")]
		T Get();

		// Token: 0x0600035F RID: 863
		[Token(Token = "0x600035F")]
		void Warm(int count);
	}
}
