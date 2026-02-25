using System;
using Il2CppDummyDll;

namespace Core.Application.Update.Common
{
	// Token: 0x0200123B RID: 4667
	[Token(Token = "0x200123B")]
	public interface IAppUpdateOperation
	{
		// Token: 0x06006EC1 RID: 28353
		[Token(Token = "0x6006EC1")]
		void Run();

		// Token: 0x06006EC2 RID: 28354
		[Token(Token = "0x6006EC2")]
		void Stop();
	}
}
