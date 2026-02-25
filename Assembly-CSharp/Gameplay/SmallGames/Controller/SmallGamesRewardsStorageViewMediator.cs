using System;
using Core.Data;
using Gameplay.SmallGames.Events;
using Gameplay.SmallGames.Model;
using Gameplay.SmallGames.View;
using Il2CppDummyDll;
using MVC;
using Protocol.Main;

namespace Gameplay.SmallGames.Controller
{
	// Token: 0x0200053D RID: 1341
	[Token(Token = "0x200053D")]
	public class SmallGamesRewardsStorageViewMediator : AbstractViewMediator<SmallGamesModel, SmallGamesEvents, SmallGamesController, RewardsStorageWindow>
	{
		// Token: 0x0600201A RID: 8218 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600201A")]
		[Address(RVA = "0x717F", Offset = "0x717F", VA = "0x717F")]
		public SmallGamesRewardsStorageViewMediator(SmallGamesModel model, SmallGamesEvents events, SmallGamesController controller)
		{
		}

		// Token: 0x170005E0 RID: 1504
		// (set) Token: 0x0600201B RID: 8219 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170005E0")]
		public override RewardsStorageWindow View
		{
			[Token(Token = "0x600201B")]
			[Address(RVA = "0x7180", Offset = "0x7180", VA = "0x7180", Slot = "20")]
			set
			{
			}
		}

		// Token: 0x0600201C RID: 8220 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600201C")]
		[Address(RVA = "0x7181", Offset = "0x7181", VA = "0x7181")]
		private void Init()
		{
		}

		// Token: 0x170005E1 RID: 1505
		// (set) Token: 0x0600201D RID: 8221 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170005E1")]
		public override SmallGamesEvents Events
		{
			[Token(Token = "0x600201D")]
			[Address(RVA = "0x7182", Offset = "0x7182", VA = "0x7182", Slot = "16")]
			set
			{
			}
		}

		// Token: 0x0600201E RID: 8222 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600201E")]
		[Address(RVA = "0x7183", Offset = "0x7183", VA = "0x7183")]
		private void ArtifactDropRemoveEventHandler(DropTypes _, ArtifactData artifact)
		{
		}

		// Token: 0x0600201F RID: 8223 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600201F")]
		[Address(RVA = "0x7184", Offset = "0x7184", VA = "0x7184")]
		private void LastDropRequestedEventHandler()
		{
		}

		// Token: 0x06002020 RID: 8224 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002020")]
		[Address(RVA = "0x7185", Offset = "0x7185", VA = "0x7185")]
		private void TakeAllDropCallback()
		{
		}

		// Token: 0x06002021 RID: 8225 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002021")]
		[Address(RVA = "0x7186", Offset = "0x7186", VA = "0x7186")]
		private void SellAllDropCallback()
		{
		}

		// Token: 0x06002022 RID: 8226 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002022")]
		[Address(RVA = "0x7187", Offset = "0x7187", VA = "0x7187")]
		private void InChestButtonClickEventHandler()
		{
		}

		// Token: 0x06002023 RID: 8227 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002023")]
		[Address(RVA = "0x7188", Offset = "0x7188", VA = "0x7188")]
		private void RenderItems(bool sort)
		{
		}
	}
}
