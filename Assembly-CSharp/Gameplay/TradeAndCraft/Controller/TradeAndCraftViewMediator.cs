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
	// Token: 0x020004A0 RID: 1184
	[Token(Token = "0x20004A0")]
	public class TradeAndCraftViewMediator : AbstractViewMediator<TradeAndCraftModel, TradeAndCraftEvents, TradeAndCraftController, TradeAndCraftWindow>
	{
		// Token: 0x06001BEF RID: 7151 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001BEF")]
		[Address(RVA = "0x6D6E", Offset = "0x6D6E", VA = "0x6D6E")]
		public TradeAndCraftViewMediator(TradeAndCraftModel model, TradeAndCraftEvents events, TradeAndCraftController controller)
		{
		}

		// Token: 0x170004EA RID: 1258
		// (set) Token: 0x06001BF0 RID: 7152 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170004EA")]
		public override TradeAndCraftWindow View
		{
			[Token(Token = "0x6001BF0")]
			[Address(RVA = "0x6D6F", Offset = "0x6D6F", VA = "0x6D6F", Slot = "20")]
			set
			{
			}
		}

		// Token: 0x06001BF1 RID: 7153 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001BF1")]
		[Address(RVA = "0x6D70", Offset = "0x6D70", VA = "0x6D70")]
		private void Init()
		{
		}

		// Token: 0x06001BF2 RID: 7154 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001BF2")]
		[Address(RVA = "0x6D71", Offset = "0x6D71", VA = "0x6D71")]
		private void AuchanButtonClickedEventHandler()
		{
		}

		// Token: 0x06001BF3 RID: 7155 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001BF3")]
		[Address(RVA = "0x6D72", Offset = "0x6D72", VA = "0x6D72")]
		private void CraftButtonClickedEventHandler()
		{
		}

		// Token: 0x06001BF4 RID: 7156 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001BF4")]
		[Address(RVA = "0x6D73", Offset = "0x6D73", VA = "0x6D73")]
		private void ManufactureButtonClickedEventHandler()
		{
		}

		// Token: 0x06001BF5 RID: 7157 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001BF5")]
		[Address(RVA = "0x6D74", Offset = "0x6D74", VA = "0x6D74")]
		private void AccountsButtonClickedEventHandler()
		{
		}

		// Token: 0x06001BF6 RID: 7158 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001BF6")]
		[Address(RVA = "0x6D75", Offset = "0x6D75", VA = "0x6D75")]
		private void MarketButtonClickedEventHandler()
		{
		}

		// Token: 0x06001BF7 RID: 7159 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001BF7")]
		[Address(RVA = "0x6D76", Offset = "0x6D76", VA = "0x6D76")]
		private void MyShopButtonClickedEventHandler(BaseBuildingData data)
		{
		}

		// Token: 0x04000F1C RID: 3868
		[Token(Token = "0x4000F1C")]
		[FieldOffset(Offset = "0x18")]
		private UserIsle _myIsle;
	}
}
