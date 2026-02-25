using System;
using Gameplay.Battles.Events;
using Gameplay.Battles.Model;
using Gameplay.Battles.View;
using Il2CppDummyDll;
using MVC;
using Protocol.Dic;

namespace Gameplay.Battles.Controller
{
	// Token: 0x02000C31 RID: 3121
	[Token(Token = "0x2000C31")]
	public class BattlesViewMediator : AbstractViewMediator<BattlesModel, BattlesEvents, BattlesController, BattlesWindow>
	{
		// Token: 0x06004C18 RID: 19480 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004C18")]
		[Address(RVA = "0x9A5C", Offset = "0x9A5C", VA = "0x9A5C")]
		public BattlesViewMediator(BattlesModel model, BattlesEvents events, BattlesController controller)
		{
		}

		// Token: 0x06004C19 RID: 19481 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004C19")]
		[Address(RVA = "0x9A5D", Offset = "0x9A5D", VA = "0x9A5D")]
		private void BossTotalNotificationNumChangedEvent()
		{
		}

		// Token: 0x06004C1A RID: 19482 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004C1A")]
		[Address(RVA = "0x9A5E", Offset = "0x9A5E", VA = "0x9A5E", Slot = "14")]
		public override void Dispose()
		{
		}

		// Token: 0x17000F57 RID: 3927
		// (set) Token: 0x06004C1B RID: 19483 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000F57")]
		public override BattlesWindow View
		{
			[Token(Token = "0x6004C1B")]
			[Address(RVA = "0x9A5F", Offset = "0x9A5F", VA = "0x9A5F", Slot = "20")]
			set
			{
			}
		}

		// Token: 0x06004C1C RID: 19484 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004C1C")]
		[Address(RVA = "0x9A60", Offset = "0x9A60", VA = "0x9A60")]
		private void ListenEventDuelState()
		{
		}

		// Token: 0x06004C1D RID: 19485 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004C1D")]
		[Address(RVA = "0x9A61", Offset = "0x9A61", VA = "0x9A61")]
		private void UnlistenEventDuelState()
		{
		}

		// Token: 0x06004C1E RID: 19486 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004C1E")]
		[Address(RVA = "0x9A62", Offset = "0x9A62", VA = "0x9A62")]
		private void OnCurrentThemeDuelChanged(ThemeDuelDic td)
		{
		}

		// Token: 0x06004C1F RID: 19487 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004C1F")]
		[Address(RVA = "0x9A63", Offset = "0x9A63", VA = "0x9A63")]
		private void ResetView()
		{
		}

		// Token: 0x06004C20 RID: 19488 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004C20")]
		[Address(RVA = "0x9A64", Offset = "0x9A64", VA = "0x9A64")]
		private void SetupView()
		{
		}

		// Token: 0x06004C21 RID: 19489 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004C21")]
		[Address(RVA = "0x9A65", Offset = "0x9A65", VA = "0x9A65")]
		private void HandleUserLevelChanged()
		{
		}

		// Token: 0x06004C22 RID: 19490 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004C22")]
		[Address(RVA = "0x9A66", Offset = "0x9A66", VA = "0x9A66")]
		private void ValidateLocks()
		{
		}

		// Token: 0x06004C23 RID: 19491 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004C23")]
		[Address(RVA = "0x9A67", Offset = "0x9A67", VA = "0x9A67")]
		private void BtnEventClickHandler(BattlesWndButton btn)
		{
		}
	}
}
