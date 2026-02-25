using System;
using Core.Net.Factories;
using Il2CppDummyDll;

namespace Core.Net.Connection
{
	// Token: 0x02000EA3 RID: 3747
	[Token(Token = "0x2000EA3")]
	public interface IProtocolMessageFactoriesRepository
	{
		// Token: 0x06005B0C RID: 23308
		[Token(Token = "0x6005B0C")]
		bool TryGetFactory(int serviceId, uint id, out IProtocolMessageFactory factory);
	}
}
