using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine.Purchasing;
using UnityEngine.Purchasing.Extension;

namespace Gameplay.Billing.BillingProvider.UnityIAP
{
	// Token: 0x02000C0D RID: 3085
	[Token(Token = "0x2000C0D")]
	public class UiapWrapperGoogle : IDetailedStoreListener, IStoreListener, IUiapWrapper
	{
		// Token: 0x140001D2 RID: 466
		// (add) Token: 0x06004B89 RID: 19337 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06004B8A RID: 19338 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140001D2")]
		public event Func<PurchaseEventArgs, PurchaseProcessingResult> ProcessPurchaseEvent
		{
			[Token(Token = "0x6004B89")]
			[Address(RVA = "0x99CF", Offset = "0x99CF", VA = "0x99CF", Slot = "10")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6004B8A")]
			[Address(RVA = "0x99D0", Offset = "0x99D0", VA = "0x99D0", Slot = "11")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x140001D3 RID: 467
		// (add) Token: 0x06004B8B RID: 19339 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06004B8C RID: 19340 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140001D3")]
		public event Action<IStoreController, IExtensionProvider> InitEvent
		{
			[Token(Token = "0x6004B8B")]
			[Address(RVA = "0x99D1", Offset = "0x99D1", VA = "0x99D1", Slot = "12")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6004B8C")]
			[Address(RVA = "0x99D2", Offset = "0x99D2", VA = "0x99D2", Slot = "13")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x140001D4 RID: 468
		// (add) Token: 0x06004B8D RID: 19341 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06004B8E RID: 19342 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140001D4")]
		public event Action<InitializationFailureData> InitFailedEvent
		{
			[Token(Token = "0x6004B8D")]
			[Address(RVA = "0x99D3", Offset = "0x99D3", VA = "0x99D3", Slot = "14")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6004B8E")]
			[Address(RVA = "0x99D4", Offset = "0x99D4", VA = "0x99D4", Slot = "15")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x140001D5 RID: 469
		// (add) Token: 0x06004B8F RID: 19343 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06004B90 RID: 19344 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140001D5")]
		public event Action<Product, PurchaseFailureDescription> PurchaseFailedEvent
		{
			[Token(Token = "0x6004B8F")]
			[Address(RVA = "0x99D5", Offset = "0x99D5", VA = "0x99D5", Slot = "16")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6004B90")]
			[Address(RVA = "0x99D6", Offset = "0x99D6", VA = "0x99D6", Slot = "17")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x140001D6 RID: 470
		// (add) Token: 0x06004B91 RID: 19345 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06004B92 RID: 19346 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140001D6")]
		public event Action<Product> DeferredPurchaseEvent
		{
			[Token(Token = "0x6004B91")]
			[Address(RVA = "0x99D7", Offset = "0x99D7", VA = "0x99D7")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6004B92")]
			[Address(RVA = "0x99D8", Offset = "0x99D8", VA = "0x99D8")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x140001D7 RID: 471
		// (add) Token: 0x06004B93 RID: 19347 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06004B94 RID: 19348 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140001D7")]
		public event Action DisconnectAtInitializeEvent
		{
			[Token(Token = "0x6004B93")]
			[Address(RVA = "0x99D9", Offset = "0x99D9", VA = "0x99D9")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6004B94")]
			[Address(RVA = "0x99DA", Offset = "0x99DA", VA = "0x99DA")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x06004B95 RID: 19349 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004B95")]
		[Address(RVA = "0x99DB", Offset = "0x99DB", VA = "0x99DB", Slot = "18")]
		public void Validate(IEnumerable<ProductDefinition> productDefinitions)
		{
		}

		// Token: 0x06004B96 RID: 19350 RVA: 0x0000DF38 File Offset: 0x0000C138
		[Token(Token = "0x6004B96")]
		[Address(RVA = "0x99DC", Offset = "0x99DC", VA = "0x99DC")]
		private bool TryInit(IEnumerable<ProductDefinition> productDefinitions)
		{
			return default(bool);
		}

		// Token: 0x06004B97 RID: 19351 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004B97")]
		[Address(RVA = "0x99DD", Offset = "0x99DD", VA = "0x99DD")]
		private void HandleQueryProductDetailsFailedListener(int value)
		{
		}

		// Token: 0x06004B98 RID: 19352 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004B98")]
		[Address(RVA = "0x99DE", Offset = "0x99DE", VA = "0x99DE")]
		private void HandleServiceDisconnect()
		{
		}

		// Token: 0x06004B99 RID: 19353 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004B99")]
		[Address(RVA = "0x99DF", Offset = "0x99DF", VA = "0x99DF")]
		private void OnPurchaseDeferred(Product product)
		{
		}

		// Token: 0x06004B9A RID: 19354 RVA: 0x0000DF50 File Offset: 0x0000C150
		[Token(Token = "0x6004B9A")]
		[Address(RVA = "0x99E0", Offset = "0x99E0", VA = "0x99E0", Slot = "7")]
		private PurchaseProcessingResult ProcessPurchase(PurchaseEventArgs purchaseEvent)
		{
			return PurchaseProcessingResult.Complete;
		}

		// Token: 0x06004B9B RID: 19355 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004B9B")]
		[Address(RVA = "0x99E1", Offset = "0x99E1", VA = "0x99E1", Slot = "8")]
		private void OnPurchaseFailed(Product product, PurchaseFailureReason failureReason)
		{
		}

		// Token: 0x06004B9C RID: 19356 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004B9C")]
		[Address(RVA = "0x99E2", Offset = "0x99E2", VA = "0x99E2", Slot = "4")]
		private void OnPurchaseFailed(Product product, PurchaseFailureDescription failureDescription)
		{
		}

		// Token: 0x06004B9D RID: 19357 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004B9D")]
		[Address(RVA = "0x99E3", Offset = "0x99E3", VA = "0x99E3", Slot = "6")]
		private void OnInitializeFailed(InitializationFailureReason error, string message)
		{
		}

		// Token: 0x06004B9E RID: 19358 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004B9E")]
		[Address(RVA = "0x99E4", Offset = "0x99E4", VA = "0x99E4", Slot = "5")]
		private void OnInitializeFailed(InitializationFailureReason error)
		{
		}

		// Token: 0x06004B9F RID: 19359 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004B9F")]
		[Address(RVA = "0x99E5", Offset = "0x99E5", VA = "0x99E5", Slot = "9")]
		private void OnInitialized(IStoreController controller, IExtensionProvider extensions)
		{
		}

		// Token: 0x06004BA0 RID: 19360 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004BA0")]
		[Address(RVA = "0x99E6", Offset = "0x99E6", VA = "0x99E6")]
		public UiapWrapperGoogle()
		{
		}

		// Token: 0x0400290A RID: 10506
		[Token(Token = "0x400290A")]
		[FieldOffset(Offset = "0x20")]
		private readonly Queue<Action> _events;

		// Token: 0x0400290B RID: 10507
		[Token(Token = "0x400290B")]
		[FieldOffset(Offset = "0x24")]
		private bool _isInit;

		// Token: 0x0400290C RID: 10508
		[Token(Token = "0x400290C")]
		[FieldOffset(Offset = "0x25")]
		private bool _isInitProcess;

		// Token: 0x0400290D RID: 10509
		[Token(Token = "0x400290D")]
		[FieldOffset(Offset = "0x28")]
		private IStoreController _controller;

		// Token: 0x0400290E RID: 10510
		[Token(Token = "0x400290E")]
		[FieldOffset(Offset = "0x2C")]
		private IExtensionProvider _extensions;

		// Token: 0x0400290F RID: 10511
		[Token(Token = "0x400290F")]
		[FieldOffset(Offset = "0x30")]
		private int _initCount;
	}
}
