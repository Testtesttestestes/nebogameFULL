using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;
using Gameplay.Combat.Events;
using Gameplay.Combat.Model;
using Gameplay.Combat.Model.FieldChange;
using Gameplay.Combat.View;
using Gameplay.Combat.View.Animations;
using Gameplay.Combat.View.GameField;
using Google.Protobuf.Collections;
using Il2CppDummyDll;
using MVC;
using Protocol.Combat;
using UI;
using Utils;
using Utils.Timers;

namespace Gameplay.Combat.Control
{
	// Token: 0x020009AF RID: 2479
	[Token(Token = "0x20009AF")]
	public abstract class AbstractCombatViewMediator<TModel, TEvents, TController, TView> : AbstractViewMediator<TModel, TEvents, TController, TView> where TModel : CombatModel where TEvents : Gameplay.Combat.Events.CombatEvents where TController : CombatController<TModel, TEvents> where TView : AbstractCombatView
	{
		// Token: 0x06003B1A RID: 15130 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003B1A")]
		public override void Dispose()
		{
		}

		// Token: 0x06003B1B RID: 15131 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003B1B")]
		protected AbstractCombatViewMediator(TModel model, TEvents events, TController controller)
		{
		}

		// Token: 0x17000BBF RID: 3007
		// (set) Token: 0x06003B1C RID: 15132 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000BBF")]
		public override TEvents Events
		{
			[Token(Token = "0x6003B1C")]
			set
			{
			}
		}

		// Token: 0x17000BC0 RID: 3008
		// (set) Token: 0x06003B1D RID: 15133 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000BC0")]
		public override TView View
		{
			[Token(Token = "0x6003B1D")]
			set
			{
			}
		}

		// Token: 0x06003B1E RID: 15134 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003B1E")]
		private void HandleSwapEvent(StoneMono from, StoneMono to)
		{
		}

		// Token: 0x06003B1F RID: 15135 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003B1F")]
		private void HandleOnSpellClickEvent(CombatSpellData spell)
		{
		}

		// Token: 0x06003B20 RID: 15136 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003B20")]
		private void HandleTurnStateTimeOutEvent()
		{
		}

		// Token: 0x06003B21 RID: 15137 RVA: 0x0000BF10 File Offset: 0x0000A110
		[Token(Token = "0x6003B21")]
		protected virtual bool HandleGameOverWindowNextCombatRequestEvent(CombatGameOverView gameOverView)
		{
			return default(bool);
		}

		// Token: 0x06003B22 RID: 15138 RVA: 0x0000BF28 File Offset: 0x0000A128
		[Token(Token = "0x6003B22")]
		protected virtual bool HandleGameOverWindowCloseRequestEvent(CombatGameOverView view)
		{
			return default(bool);
		}

		// Token: 0x06003B23 RID: 15139 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003B23")]
		private void HandleAnimQueueCompleteEvent()
		{
		}

		// Token: 0x06003B24 RID: 15140 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003B24")]
		private void HandleOnPointerUpOnSpellFieldFigure()
		{
		}

		// Token: 0x06003B25 RID: 15141 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003B25")]
		protected virtual void HandleInitEvent()
		{
		}

		// Token: 0x06003B26 RID: 15142 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003B26")]
		protected virtual void HandleRequestViewEvent()
		{
		}

		// Token: 0x06003B27 RID: 15143 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003B27")]
		private void HandleStartAwaitCombatEvent(BackTime value)
		{
		}

		// Token: 0x06003B28 RID: 15144 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003B28")]
		private void HandleFinishAwaitCombatEvent(CombatModel model)
		{
		}

		// Token: 0x06003B29 RID: 15145 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003B29")]
		private void HandleCombatTerminatedEvent(ProtoCombatTerminatedEvt msg)
		{
		}

		// Token: 0x06003B2A RID: 15146 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003B2A")]
		private void HandleSpellUsedEvent(CombatSpellData spellData)
		{
		}

		// Token: 0x06003B2B RID: 15147 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003B2B")]
		protected virtual void HandleSpellAppliedEvent(CombatPlayer owner, CombatSpellData spell, List<CombatPlayer> targetPlayers)
		{
		}

		// Token: 0x06003B2C RID: 15148 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003B2C")]
		private void HandleCooldownChangedEvent(List<CombatSpellData> spells)
		{
		}

		// Token: 0x06003B2D RID: 15149 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003B2D")]
		private void HandleSelectedSpellChangedEvent(CombatSpellData fromSpell, CombatSpellData toSpell)
		{
		}

		// Token: 0x06003B2E RID: 15150 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003B2E")]
		private void HandleCombatEventsEvent(CombatFieldChangesConvItem fieldChangesConvItem)
		{
		}

		// Token: 0x06003B2F RID: 15151 RVA: 0x0000BF40 File Offset: 0x0000A140
		[Token(Token = "0x6003B2F")]
		private bool TryRunStoneDestroyVfx(IFieldChange fieldChange, List<StoneMono> toDestroy)
		{
			return default(bool);
		}

		// Token: 0x06003B30 RID: 15152 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003B30")]
		private void HandleCombatGameEventsFinishEvent()
		{
		}

		// Token: 0x06003B31 RID: 15153 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003B31")]
		private void HandleSkillWorkedEvent(ProtoCombatEventsEvt msg)
		{
		}

		// Token: 0x06003B32 RID: 15154 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003B32")]
		private void AppendAnimation(string animationAssetId, CombatAnimationContentDecorator contentDecorator)
		{
		}

		// Token: 0x06003B33 RID: 15155 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003B33")]
		private void HandleAntiqEffectTriggeredEvent(RepeatedField<ProtoAntiqEffectTriggeredEvt.Types.EffectResult> effects)
		{
		}

		// Token: 0x06003B34 RID: 15156 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003B34")]
		protected virtual void HandleOtherPlayerTriggersChangedEvent(ulong userId)
		{
		}

		// Token: 0x06003B35 RID: 15157 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003B35")]
		private void HandleAnimExecuteEvent(CombatAnimation.IContent content)
		{
		}

		// Token: 0x06003B36 RID: 15158 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003B36")]
		private void HandleUserBalanceChangedEvent(CombatPlayer player)
		{
		}

		// Token: 0x06003B37 RID: 15159 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003B37")]
		protected virtual void HandleUserSkillsChangedEvent(IList<CombatPlayer> players)
		{
		}

		// Token: 0x06003B38 RID: 15160 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003B38")]
		private void HandleEffectsChangedEvent(IList<CombatPlayer> players)
		{
		}

		// Token: 0x06003B39 RID: 15161 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003B39")]
		private void HandleSwitchTurnEvent(TurnStates state)
		{
		}

		// Token: 0x06003B3A RID: 15162 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003B3A")]
		private void HandleSwapStonesErrorEvent(int fromX, int fromY, int toX, int toY)
		{
		}

		// Token: 0x06003B3B RID: 15163 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003B3B")]
		protected void DefineStonesSkins()
		{
		}

		// Token: 0x06003B3C RID: 15164 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003B3C")]
		protected virtual void HandleTerminate(TerminateReason reason)
		{
		}

		// Token: 0x06003B3D RID: 15165 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003B3D")]
		private void RunShowCombatViewProcess()
		{
		}

		// Token: 0x06003B3E RID: 15166 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003B3E")]
		private void CloseAwaitCombatWindow()
		{
		}

		// Token: 0x06003B3F RID: 15167 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003B3F")]
		protected virtual void AddGameProcessEventsHandlers()
		{
		}

		// Token: 0x06003B40 RID: 15168 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003B40")]
		protected virtual void RemoveGameProcessEventsHandlers()
		{
		}

		// Token: 0x06003B41 RID: 15169 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003B41")]
		protected virtual void HandleSetupView()
		{
		}

		// Token: 0x06003B42 RID: 15170 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003B42")]
		protected virtual void HandleResetView()
		{
		}

		// Token: 0x06003B43 RID: 15171 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6003B43")]
		protected virtual CombatWaitingWindowMono ShowAwaitCombatWindow(BackTime backTime)
		{
			return null;
		}

		// Token: 0x06003B44 RID: 15172 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003B44")]
		protected virtual void HandleFieldInteraction()
		{
		}

		// Token: 0x06003B45 RID: 15173 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003B45")]
		protected virtual void ValidateUserBalance(CombatPlayer player)
		{
		}

		// Token: 0x06003B46 RID: 15174 RVA: 0x0000BF58 File Offset: 0x0000A158
		[Token(Token = "0x6003B46")]
		protected bool CheckArtifactsInDrop()
		{
			return default(bool);
		}

		// Token: 0x06003B47 RID: 15175 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003B47")]
		protected virtual void HandleSelectedSpell(CombatSpellData spell)
		{
		}

		// Token: 0x06003B48 RID: 15176 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003B48")]
		protected virtual void HandleGameOver()
		{
		}

		// Token: 0x06003B49 RID: 15177 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003B49")]
		protected virtual void ChestButtonClickedEvent(IndexButtonBasic btn)
		{
		}

		// Token: 0x06003B4A RID: 15178 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003B4A")]
		[CompilerGenerated]
		private void <TryRunStoneDestroyVfx>g__Run|30_0(CombatAnimation.IContent content)
		{
		}

		// Token: 0x040020AD RID: 8365
		[Token(Token = "0x40020AD")]
		[FieldOffset(Offset = "0x0")]
		protected CombatWaitingWindowMono _combatWaitingWindow;

		// Token: 0x040020AE RID: 8366
		[Token(Token = "0x40020AE")]
		[FieldOffset(Offset = "0x0")]
		protected CombatGameOverView _combatGameOverWindow;

		// Token: 0x040020AF RID: 8367
		[Token(Token = "0x40020AF")]
		[FieldOffset(Offset = "0x0")]
		protected ICombatAnimation _spellsAnimation;

		// Token: 0x040020B0 RID: 8368
		[Token(Token = "0x40020B0")]
		[FieldOffset(Offset = "0x0")]
		protected ICombatAnimation _combatEventsAnimation;

		// Token: 0x040020B1 RID: 8369
		[Token(Token = "0x40020B1")]
		[FieldOffset(Offset = "0x0")]
		protected CombatAnimationCounter _animationCounter;

		// Token: 0x040020B2 RID: 8370
		[Token(Token = "0x40020B2")]
		[FieldOffset(Offset = "0x0")]
		protected readonly CancellationTokenSource _cancellationTokenSource;

		// Token: 0x040020B3 RID: 8371
		[Token(Token = "0x40020B3")]
		[FieldOffset(Offset = "0x0")]
		private DelayedCall _delayedCall;
	}
}
