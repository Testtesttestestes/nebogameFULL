using System;
using Gameplay.WorldAxis.ColossusInfo.Events;
using Gameplay.WorldAxis.ColossusInfo.Model;
using Gameplay.WorldAxis.ColossusInfo.View;
using Google.Protobuf;
using Il2CppDummyDll;
using MVC;
using Protocol.Common;
using ServicesNamespace;
using Utils;

namespace Gameplay.WorldAxis.ColossusInfo.Controller
{
	// Token: 0x02000330 RID: 816
	[Token(Token = "0x2000330")]
	public class ColossusTreasuryController : AbstractController<ColossusTreasuryModel, ColossusTreasuryEvents>
	{
		// Token: 0x060012BD RID: 4797 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60012BD")]
		[Address(RVA = "0x64B7", Offset = "0x64B7", VA = "0x64B7")]
		public ColossusTreasuryController(ColossusTreasuryModel model, ColossusTreasuryEvents events)
		{
		}

		// Token: 0x060012BE RID: 4798 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60012BE")]
		[Address(RVA = "0x64B8", Offset = "0x64B8", VA = "0x64B8")]
		public void GetTreasuryOptions()
		{
		}

		// Token: 0x060012BF RID: 4799 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60012BF")]
		[Address(RVA = "0x64B9", Offset = "0x64B9", VA = "0x64B9")]
		private void GetTreasuryOptionsResultHandler(OpToken<IMessage, object> op)
		{
		}

		// Token: 0x060012C0 RID: 4800 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60012C0")]
		[Address(RVA = "0x64BA", Offset = "0x64BA", VA = "0x64BA")]
		public void BuyTreasuryOption(TreasuryOptionListElement.TreasuryOptionListElementArgs args)
		{
		}

		// Token: 0x060012C1 RID: 4801 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60012C1")]
		[Address(RVA = "0x64BB", Offset = "0x64BB", VA = "0x64BB")]
		private void ServiceBuyTreasuryItem(TreasuryOptionListElement.TreasuryOptionListElementArgs args)
		{
		}

		// Token: 0x060012C2 RID: 4802 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60012C2")]
		[Address(RVA = "0x64BC", Offset = "0x64BC", VA = "0x64BC")]
		private void BuyTreasuryOptionResultHandler(OpToken<IMessage, object> op)
		{
		}

		// Token: 0x060012C3 RID: 4803 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60012C3")]
		[Address(RVA = "0x64BD", Offset = "0x64BD", VA = "0x64BD", Slot = "6")]
		protected override void HandleStop()
		{
		}

		// Token: 0x060012C4 RID: 4804 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60012C4")]
		[Address(RVA = "0x64BE", Offset = "0x64BE", VA = "0x64BE", Slot = "7")]
		protected override void HandleRun()
		{
		}

		// Token: 0x060012C5 RID: 4805 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60012C5")]
		[Address(RVA = "0x64BF", Offset = "0x64BF", VA = "0x64BF")]
		private void TreasuryBalanceChangedEventHandler(ResourceSet balance, ResourceSet delta)
		{
		}

		// Token: 0x04000A1E RID: 2590
		[Token(Token = "0x4000A1E")]
		[FieldOffset(Offset = "0x18")]
		private ColossusService _service;
	}
}
