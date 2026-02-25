using System;
using Il2CppDummyDll;

namespace Core.Rounting
{
	// Token: 0x02000E7F RID: 3711
	[Token(Token = "0x2000E7F")]
	public interface IPathNodeFactoryRepository : IDisposable
	{
		// Token: 0x06005A54 RID: 23124
		[Token(Token = "0x6005A54")]
		bool TryGetFactory(string name, out IPathNodeFactory factory);
	}
}
