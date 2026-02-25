using System;
using Gameplay.Bank.Model;
using Gameplay.Competition.Events;
using Gameplay.Competition.Model;
using Il2CppDummyDll;
using MVC;

namespace Gameplay.Competition.Control.Sections
{
	// Token: 0x0200090F RID: 2319
	[Token(Token = "0x200090F")]
	public class ShopController : AbstractController<ShopModel, ShopEvents>
	{
		// Token: 0x06003685 RID: 13957 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003685")]
		[Address(RVA = "0x8692", Offset = "0x8692", VA = "0x8692")]
		public ShopController(ShopModel model, ShopEvents events)
		{
		}

		// Token: 0x06003686 RID: 13958 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003686")]
		[Address(RVA = "0x8693", Offset = "0x8693", VA = "0x8693", Slot = "7")]
		protected override void HandleRun()
		{
		}

		// Token: 0x06003687 RID: 13959 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003687")]
		[Address(RVA = "0x8694", Offset = "0x8694", VA = "0x8694")]
		public void Buy(BankOptionData option)
		{
		}
	}
}
