using System;
using Gameplay.Isles.User;
using Gameplay.TradeAndCraft.Events;
using Gameplay.TradeAndCraft.Model;
using Gameplay.TradeAndCraft.View;
using Gameplay.World.Model;
using Il2CppDummyDll;
using MVC;

namespace Gameplay.TradeAndCraft.Controller
{
	// Token: 0x020004A1 RID: 1185
	[Token(Token = "0x20004A1")]
	public class TradeOptionsViewMediator : AbstractViewMediator<TradeAndCraftModel, TradeAndCraftEvents, TradeAndCraftController, TradeOptionsWindow>
	{
		// Token: 0x06001BF8 RID: 7160 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001BF8")]
		[Address(RVA = "0x6D77", Offset = "0x6D77", VA = "0x6D77")]
		public TradeOptionsViewMediator(TradeAndCraftModel model, TradeAndCraftEvents events, TradeAndCraftController controller)
		{
		}

		// Token: 0x170004EB RID: 1259
		// (set) Token: 0x06001BF9 RID: 7161 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170004EB")]
		public override TradeOptionsWindow View
		{
			[Token(Token = "0x6001BF9")]
			[Address(RVA = "0x6D78", Offset = "0x6D78", VA = "0x6D78", Slot = "20")]
			set
			{
			}
		}

		// Token: 0x06001BFA RID: 7162 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001BFA")]
		[Address(RVA = "0x6D79", Offset = "0x6D79", VA = "0x6D79")]
		private void Init()
		{
		}

		// Token: 0x06001BFB RID: 7163 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001BFB")]
		[Address(RVA = "0x6D7A", Offset = "0x6D7A", VA = "0x6D7A")]
		private void AuchanButtonClickedEventHandler()
		{
		}

		// Token: 0x06001BFC RID: 7164 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001BFC")]
		[Address(RVA = "0x6D7B", Offset = "0x6D7B", VA = "0x6D7B")]
		private void AccountsButtonClickedEventHandler()
		{
		}

		// Token: 0x06001BFD RID: 7165 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001BFD")]
		[Address(RVA = "0x6D7C", Offset = "0x6D7C", VA = "0x6D7C")]
		private void MarketButtonClickedEventHandler()
		{
		}

		// Token: 0x06001BFE RID: 7166 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001BFE")]
		[Address(RVA = "0x6D7D", Offset = "0x6D7D", VA = "0x6D7D")]
		private void MyShopButtonClickedEventHandler(BaseBuildingData data)
		{
		}

		// Token: 0x04000F1D RID: 3869
		[Token(Token = "0x4000F1D")]
		[FieldOffset(Offset = "0x18")]
		private UserIsle _myIsle;
	}
}
