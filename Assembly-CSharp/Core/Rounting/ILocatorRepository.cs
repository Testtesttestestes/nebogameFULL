using System;
using Il2CppDummyDll;

namespace Core.Rounting
{
	// Token: 0x02000E7D RID: 3709
	[Token(Token = "0x2000E7D")]
	public interface ILocatorRepository : IDisposable
	{
		// Token: 0x06005A51 RID: 23121
		[Token(Token = "0x6005A51")]
		bool TryGetLocator(Uri uri, out ILocator locator);
	}
}
