using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine.Purchasing;

namespace Gameplay.Billing.BillingProvider.UnityIAP
{
	// Token: 0x02000C0A RID: 3082
	[Token(Token = "0x2000C0A")]
	public class StoreProvider : IStoreProvider, IStoreSetup
	{
		// Token: 0x17000F43 RID: 3907
		// (get) Token: 0x06004B71 RID: 19313 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06004B72 RID: 19314 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000F43")]
		public IStoreController Controller
		{
			[Token(Token = "0x6004B71")]
			[Address(RVA = "0x99C0", Offset = "0x99C0", VA = "0x99C0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6004B72")]
			[Address(RVA = "0x99C1", Offset = "0x99C1", VA = "0x99C1")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000F44 RID: 3908
		// (get) Token: 0x06004B73 RID: 19315 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06004B74 RID: 19316 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000F44")]
		public IExtensionProvider Extensions
		{
			[Token(Token = "0x6004B73")]
			[Address(RVA = "0x99C2", Offset = "0x99C2", VA = "0x99C2", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6004B74")]
			[Address(RVA = "0x99C3", Offset = "0x99C3", VA = "0x99C3")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06004B75 RID: 19317 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004B75")]
		[Address(RVA = "0x99C4", Offset = "0x99C4", VA = "0x99C4", Slot = "6")]
		public void SetController(IStoreController value)
		{
		}

		// Token: 0x06004B76 RID: 19318 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004B76")]
		[Address(RVA = "0x99C5", Offset = "0x99C5", VA = "0x99C5", Slot = "7")]
		public void SetExtension(IExtensionProvider value)
		{
		}

		// Token: 0x06004B77 RID: 19319 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004B77")]
		[Address(RVA = "0x99C6", Offset = "0x99C6", VA = "0x99C6")]
		public StoreProvider()
		{
		}
	}
}
