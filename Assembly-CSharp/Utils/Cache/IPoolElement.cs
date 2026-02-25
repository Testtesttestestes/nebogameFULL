using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Utils.Cache
{
	// Token: 0x02000075 RID: 117
	[Token(Token = "0x2000075")]
	public interface IPoolElement<T> where T : Component, new()
	{
		// Token: 0x17000080 RID: 128
		// (get) Token: 0x06000360 RID: 864
		// (set) Token: 0x06000361 RID: 865
		[Token(Token = "0x17000080")]
		ObjectPool<T> Pool { [Token(Token = "0x6000360")] get; [Token(Token = "0x6000361")] set; }

		// Token: 0x06000362 RID: 866
		[Token(Token = "0x6000362")]
		void Release();
	}
}
