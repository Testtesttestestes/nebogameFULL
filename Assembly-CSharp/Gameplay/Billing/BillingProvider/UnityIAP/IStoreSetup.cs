using System;
using Il2CppDummyDll;
using UnityEngine.Purchasing;

namespace Gameplay.Billing.BillingProvider.UnityIAP
{
	// Token: 0x02000C08 RID: 3080
	[Token(Token = "0x2000C08")]
	public interface IStoreSetup
	{
		// Token: 0x06004B6D RID: 19309
		[Token(Token = "0x6004B6D")]
		void SetController(IStoreController value);

		// Token: 0x06004B6E RID: 19310
		[Token(Token = "0x6004B6E")]
		void SetExtension(IExtensionProvider value);
	}
}
