using System;
using System.Runtime.CompilerServices;
using Gameplay.EndlessPaymentOptionsList.Model;
using Il2CppDummyDll;
using MVC;

namespace Gameplay.EndlessPaymentOptionsList
{
	// Token: 0x0200082E RID: 2094
	[Token(Token = "0x200082E")]
	public class EndlessPaymentOptionsListEvents : AbstractMVCEvents
	{
		// Token: 0x170009B2 RID: 2482
		// (get) Token: 0x0600314F RID: 12623 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06003150 RID: 12624 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170009B2")]
		public Action<CardData, CardData> BuySuccessEvent
		{
			[Token(Token = "0x600314F")]
			[Address(RVA = "0x81A7", Offset = "0x81A7", VA = "0x81A7")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6003150")]
			[Address(RVA = "0x81A8", Offset = "0x81A8", VA = "0x81A8")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06003151 RID: 12625 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003151")]
		[Address(RVA = "0x81A9", Offset = "0x81A9", VA = "0x81A9")]
		public EndlessPaymentOptionsListEvents()
		{
		}

		// Token: 0x04001AE9 RID: 6889
		[Token(Token = "0x4001AE9")]
		[FieldOffset(Offset = "0x14")]
		public Action OptionsChangedEvent;

		// Token: 0x04001AEA RID: 6890
		[Token(Token = "0x4001AEA")]
		[FieldOffset(Offset = "0x18")]
		public Action OptionsListTimeOutEvent;

		// Token: 0x04001AEB RID: 6891
		[Token(Token = "0x4001AEB")]
		[FieldOffset(Offset = "0x1C")]
		public Action EndlessPaymentOptionsReceivedEvent;

		// Token: 0x04001AEC RID: 6892
		[Token(Token = "0x4001AEC")]
		[FieldOffset(Offset = "0x20")]
		public Action DiscountWindowShownEvent;
	}
}
