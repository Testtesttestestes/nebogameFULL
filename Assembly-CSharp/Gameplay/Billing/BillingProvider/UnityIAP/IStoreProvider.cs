using System;
using Il2CppDummyDll;
using UnityEngine.Purchasing;

namespace Gameplay.Billing.BillingProvider.UnityIAP
{
	// Token: 0x02000C07 RID: 3079
	[Token(Token = "0x2000C07")]
	public interface IStoreProvider
	{
		// Token: 0x17000F41 RID: 3905
		// (get) Token: 0x06004B6B RID: 19307
		[Token(Token = "0x17000F41")]
		IStoreController Controller { [Token(Token = "0x6004B6B")] get; }

		// Token: 0x17000F42 RID: 3906
		// (get) Token: 0x06004B6C RID: 19308
		[Token(Token = "0x17000F42")]
		IExtensionProvider Extensions { [Token(Token = "0x6004B6C")] get; }
	}
}
