using System;
using Il2CppDummyDll;

namespace Core.Cache
{
	// Token: 0x020010FC RID: 4348
	// (Invoke) Token: 0x0600658E RID: 25998
	[Token(Token = "0x20010FC")]
	public delegate void CacheResultCallback<in TData>(long operationIndex, params TData[] data);
}
