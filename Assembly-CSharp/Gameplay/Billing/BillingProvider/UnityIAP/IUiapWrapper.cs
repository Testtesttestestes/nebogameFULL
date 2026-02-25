using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine.Purchasing;
using UnityEngine.Purchasing.Extension;

namespace Gameplay.Billing.BillingProvider.UnityIAP
{
	// Token: 0x02000C0C RID: 3084
	[Token(Token = "0x2000C0C")]
	public interface IUiapWrapper
	{
		// Token: 0x140001CE RID: 462
		// (add) Token: 0x06004B80 RID: 19328
		// (remove) Token: 0x06004B81 RID: 19329
		[Token(Token = "0x140001CE")]
		event Func<PurchaseEventArgs, PurchaseProcessingResult> ProcessPurchaseEvent;

		// Token: 0x140001CF RID: 463
		// (add) Token: 0x06004B82 RID: 19330
		// (remove) Token: 0x06004B83 RID: 19331
		[Token(Token = "0x140001CF")]
		event Action<IStoreController, IExtensionProvider> InitEvent;

		// Token: 0x140001D0 RID: 464
		// (add) Token: 0x06004B84 RID: 19332
		// (remove) Token: 0x06004B85 RID: 19333
		[Token(Token = "0x140001D0")]
		event Action<InitializationFailureData> InitFailedEvent;

		// Token: 0x140001D1 RID: 465
		// (add) Token: 0x06004B86 RID: 19334
		// (remove) Token: 0x06004B87 RID: 19335
		[Token(Token = "0x140001D1")]
		event Action<Product, PurchaseFailureDescription> PurchaseFailedEvent;

		// Token: 0x06004B88 RID: 19336
		[Token(Token = "0x6004B88")]
		void Validate(IEnumerable<ProductDefinition> productDefinitions);
	}
}
