using System;
using Gameplay.Combat.Control;
using Gameplay.Combat.View;
using Gameplay.ThemeDuelCombat.Model;
using Gameplay.ThemeDuelCombat.View;
using Il2CppDummyDll;
using Protocol.Combat;
using Utils;

namespace Gameplay.ThemeDuelCombat.Control
{
	// Token: 0x020004DA RID: 1242
	[Token(Token = "0x20004DA")]
	public class ThemeDuelCombatViewMediator : AbstractOneOnOneCombatViewMediator<ThemeDuelCombatModel, ThemeDuelCombatEvents, ThemeDuelCombatController, ThemeDuelCombatView>
	{
		// Token: 0x06001D95 RID: 7573 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D95")]
		[Address(RVA = "0x6F14", Offset = "0x6F14", VA = "0x6F14")]
		public ThemeDuelCombatViewMediator(ThemeDuelCombatModel model, ThemeDuelCombatEvents events, ThemeDuelCombatController controller)
		{
		}

		// Token: 0x06001D96 RID: 7574 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D96")]
		[Address(RVA = "0x6F15", Offset = "0x6F15", VA = "0x6F15", Slot = "37")]
		protected override void HandleGameOver()
		{
		}

		// Token: 0x06001D97 RID: 7575 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D97")]
		[Address(RVA = "0x6F16", Offset = "0x6F16", VA = "0x6F16", Slot = "29")]
		protected override void AddGameProcessEventsHandlers()
		{
		}

		// Token: 0x06001D98 RID: 7576 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D98")]
		[Address(RVA = "0x6F17", Offset = "0x6F17", VA = "0x6F17", Slot = "30")]
		protected override void RemoveGameProcessEventsHandlers()
		{
		}

		// Token: 0x06001D99 RID: 7577 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D99")]
		[Address(RVA = "0x1D0B", Offset = "0x1D0B", VA = "0x1D0B")]
		private void HandleThemeScoreChangedEvent(ProtoThemeScoreChangedEvt msg)
		{
		}

		// Token: 0x06001D9A RID: 7578 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D9A")]
		[Address(RVA = "0x6F18", Offset = "0x6F18", VA = "0x6F18")]
		private void HandleRunNextCombatAvailEvent(bool value)
		{
		}

		// Token: 0x06001D9B RID: 7579 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D9B")]
		[Address(RVA = "0x6F19", Offset = "0x6F19", VA = "0x6F19", Slot = "23")]
		protected override void HandleInitEvent()
		{
		}

		// Token: 0x06001D9C RID: 7580 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D9C")]
		[Address(RVA = "0x6F1A", Offset = "0x6F1A", VA = "0x6F1A", Slot = "32")]
		protected override void HandleResetView()
		{
		}

		// Token: 0x06001D9D RID: 7581 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D9D")]
		[Address(RVA = "0x6F1B", Offset = "0x6F1B", VA = "0x6F1B", Slot = "31")]
		protected override void HandleSetupView()
		{
		}

		// Token: 0x06001D9E RID: 7582 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D9E")]
		[Address(RVA = "0x6F1C", Offset = "0x6F1C", VA = "0x6F1C")]
		private void HandleTdShopButtonClickEvent()
		{
		}

		// Token: 0x06001D9F RID: 7583 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6001D9F")]
		[Address(RVA = "0x6F1D", Offset = "0x6F1D", VA = "0x6F1D", Slot = "33")]
		protected override CombatWaitingWindowMono ShowAwaitCombatWindow(BackTime backTime)
		{
			return null;
		}

		// Token: 0x06001DA0 RID: 7584 RVA: 0x00006348 File Offset: 0x00004548
		[Token(Token = "0x6001DA0")]
		[Address(RVA = "0x6F1E", Offset = "0x6F1E", VA = "0x6F1E", Slot = "22")]
		protected override bool HandleGameOverWindowCloseRequestEvent(CombatGameOverView view)
		{
			return default(bool);
		}

		// Token: 0x06001DA1 RID: 7585 RVA: 0x00006360 File Offset: 0x00004560
		[Token(Token = "0x6001DA1")]
		[Address(RVA = "0x6F1F", Offset = "0x6F1F", VA = "0x6F1F", Slot = "21")]
		protected override bool HandleGameOverWindowNextCombatRequestEvent(CombatGameOverView gameOverView)
		{
			return default(bool);
		}
	}
}
