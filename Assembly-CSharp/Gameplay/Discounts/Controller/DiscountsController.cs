using System;
using Gameplay.Discounts.Events;
using Gameplay.Discounts.Model;
using Google.Protobuf;
using Il2CppDummyDll;
using MVC;
using ServicesNamespace;
using Utils;

namespace Gameplay.Discounts.Controller
{
	// Token: 0x020008A5 RID: 2213
	[Token(Token = "0x20008A5")]
	public class DiscountsController : AbstractController<DiscountsModel, DiscountsEvents>
	{
		// Token: 0x060033FB RID: 13307 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60033FB")]
		[Address(RVA = "0x8428", Offset = "0x8428", VA = "0x8428")]
		public DiscountsController(DiscountsModel model, DiscountsEvents events)
		{
		}

		// Token: 0x060033FC RID: 13308 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60033FC")]
		[Address(RVA = "0x8429", Offset = "0x8429", VA = "0x8429", Slot = "7")]
		protected override void HandleRun()
		{
		}

		// Token: 0x060033FD RID: 13309 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60033FD")]
		[Address(RVA = "0x842A", Offset = "0x842A", VA = "0x842A", Slot = "6")]
		protected override void HandleStop()
		{
		}

		// Token: 0x060033FE RID: 13310 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60033FE")]
		[Address(RVA = "0x842B", Offset = "0x842B", VA = "0x842B")]
		private void HandleDictChanged()
		{
		}

		// Token: 0x060033FF RID: 13311 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60033FF")]
		[Address(RVA = "0x842C", Offset = "0x842C", VA = "0x842C")]
		public void GetDiscounts()
		{
		}

		// Token: 0x06003400 RID: 13312 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003400")]
		[Address(RVA = "0x842D", Offset = "0x842D", VA = "0x842D")]
		private void GetDiscountsResultHandler(OpToken<IMessage, object> op)
		{
		}

		// Token: 0x04001C4A RID: 7242
		[Token(Token = "0x4001C4A")]
		[FieldOffset(Offset = "0x18")]
		private ServicesService _service;
	}
}
