using System;
using Il2CppDummyDll;

namespace Core.Cache
{
	// Token: 0x020010FF RID: 4351
	[Token(Token = "0x20010FF")]
	public interface ICache<in TKey, out TData> : IDisposable
	{
		// Token: 0x170014A0 RID: 5280
		// (get) Token: 0x060065A1 RID: 26017
		[Token(Token = "0x170014A0")]
		float Ttl { [Token(Token = "0x60065A1")] get; }

		// Token: 0x060065A2 RID: 26018
		[Token(Token = "0x60065A2")]
		long GetData(CacheResultCallback<TData> resultCallback, params TKey[] keys);

		// Token: 0x060065A3 RID: 26019
		[Token(Token = "0x60065A3")]
		int Reset(params TKey[] keys);

		// Token: 0x060065A4 RID: 26020
		[Token(Token = "0x60065A4")]
		bool Cancel(long index);
	}
}
