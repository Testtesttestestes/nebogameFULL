using System;
using Gameplay.TradeAndCraft.Events;
using Gameplay.TradeAndCraft.Model;
using Gameplay.TradeAndCraft.View;
using Il2CppDummyDll;
using MVC;

namespace Gameplay.TradeAndCraft.Controller
{
	// Token: 0x0200049E RID: 1182
	[Token(Token = "0x200049E")]
	public class CraftOptionsViewMediator : AbstractViewMediator<TradeAndCraftModel, TradeAndCraftEvents, TradeAndCraftController, CraftOptionsWindow>
	{
		// Token: 0x06001BE9 RID: 7145 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001BE9")]
		[Address(RVA = "0x6D68", Offset = "0x6D68", VA = "0x6D68")]
		public CraftOptionsViewMediator(TradeAndCraftModel model, TradeAndCraftEvents events, TradeAndCraftController controller)
		{
		}

		// Token: 0x170004E9 RID: 1257
		// (set) Token: 0x06001BEA RID: 7146 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170004E9")]
		public override CraftOptionsWindow View
		{
			[Token(Token = "0x6001BEA")]
			[Address(RVA = "0x6D69", Offset = "0x6D69", VA = "0x6D69", Slot = "20")]
			set
			{
			}
		}

		// Token: 0x06001BEB RID: 7147 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001BEB")]
		[Address(RVA = "0x6D6A", Offset = "0x6D6A", VA = "0x6D6A")]
		private void CraftButtonClickedEventHandler()
		{
		}

		// Token: 0x06001BEC RID: 7148 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001BEC")]
		[Address(RVA = "0x6D6B", Offset = "0x6D6B", VA = "0x6D6B")]
		private void ManufactureButtonClickedEventHandler()
		{
		}

		// Token: 0x06001BED RID: 7149 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001BED")]
		[Address(RVA = "0x6D6C", Offset = "0x6D6C", VA = "0x6D6C")]
		private void AccountsButtonClickedEventHandler()
		{
		}
	}
}
