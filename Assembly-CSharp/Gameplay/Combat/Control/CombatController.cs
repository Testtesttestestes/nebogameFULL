using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Gameplay.Combat.Events;
using Gameplay.Combat.Model;
using Gameplay.Combat.Model.FieldChange;
using Gameplay.Combat.Model.SkillsChange;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Il2CppDummyDll;
using MVC;
using Protocol.Combat;
using Protocol.Common;
using ServicesNamespace;
using Utils;

namespace Gameplay.Combat.Control
{
	// Token: 0x020009B5 RID: 2485
	[Token(Token = "0x20009B5")]
	public class CombatController<TModel, TEvents> : AbstractController<TModel, TEvents> where TModel : CombatModel where TEvents : Gameplay.Combat.Events.CombatEvents
	{
		// Token: 0x17000BC1 RID: 3009
		// (get) Token: 0x06003B5F RID: 15199 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000BC1")]
		protected ICombatService CombatService
		{
			[Token(Token = "0x6003B5F")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x06003B60 RID: 15200 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003B60")]
		protected CombatController(ICombatService service, TModel model, TEvents events)
		{
		}

		// Token: 0x06003B61 RID: 15201 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003B61")]
		public override void Dispose()
		{
		}

		// Token: 0x06003B62 RID: 15202 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003B62")]
		public void PauseConv()
		{
		}

		// Token: 0x06003B63 RID: 15203 RVA: 0x0000BF70 File Offset: 0x0000A170
		[Token(Token = "0x6003B63")]
		public bool TryPlayConv(bool force)
		{
			return default(bool);
		}

		// Token: 0x06003B64 RID: 15204 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003B64")]
		protected void SwitchTurn(ulong userId)
		{
		}

		// Token: 0x06003B65 RID: 15205 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6003B65")]
		private CombatPlayer HandleEffects(ProtoEffectsChangedEvt msg)
		{
			return null;
		}

		// Token: 0x06003B66 RID: 15206 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6003B66")]
		protected virtual List<CombatSpellData> HandleCoolDowns(RepeatedField<SpellCoolDown> items)
		{
			return null;
		}

		// Token: 0x06003B67 RID: 15207 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003B67")]
		protected void AddFieldChange(params IFieldChange[] changes)
		{
		}

		// Token: 0x06003B68 RID: 15208 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003B68")]
		protected void SetSkillsChanges(params ISkillsChange[] changes)
		{
		}

		// Token: 0x06003B69 RID: 15209 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003B69")]
		protected override void HandleRun()
		{
		}

		// Token: 0x06003B6A RID: 15210 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003B6A")]
		protected override void HandleStop()
		{
		}

		// Token: 0x06003B6B RID: 15211 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003B6B")]
		protected virtual void HandleRewardsGot()
		{
		}

		// Token: 0x06003B6C RID: 15212 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003B6C")]
		protected virtual void HandleSetDrop(GameOverData data)
		{
		}

		// Token: 0x06003B6D RID: 15213 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003B6D")]
		protected void ValidateInit()
		{
		}

		// Token: 0x06003B6E RID: 15214 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003B6E")]
		protected virtual void AddCombatServiceEventsHandlers()
		{
		}

		// Token: 0x06003B6F RID: 15215 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003B6F")]
		protected virtual void RemoveCombatServiceEventsHandlers()
		{
		}

		// Token: 0x06003B70 RID: 15216 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003B70")]
		private void CompleteQueueCallback()
		{
		}

		// Token: 0x06003B71 RID: 15217 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003B71")]
		private void ExecuteConvItemCallback(IConveyorItem item)
		{
		}

		// Token: 0x06003B72 RID: 15218 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003B72")]
		private void PrepareField()
		{
		}

		// Token: 0x06003B73 RID: 15219 RVA: 0x0000BF88 File Offset: 0x0000A188
		[Token(Token = "0x6003B73")]
		protected bool TryAppendGameOverToCombatEvents()
		{
			return default(bool);
		}

		// Token: 0x06003B74 RID: 15220 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003B74")]
		protected void StartAwaitJumpToCombatEvent()
		{
		}

		// Token: 0x06003B75 RID: 15221 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003B75")]
		private void StopAwaitJumpToCombatEvent()
		{
		}

		// Token: 0x06003B76 RID: 15222 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003B76")]
		protected virtual void HandleAwait(BackTime backTime)
		{
		}

		// Token: 0x06003B77 RID: 15223 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003B77")]
		protected void PrepareView()
		{
		}

		// Token: 0x06003B78 RID: 15224 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003B78")]
		protected void SetJoinToCombatInfo(JoinToCombatInfo value)
		{
		}

		// Token: 0x06003B79 RID: 15225 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003B79")]
		protected virtual void HandleJoinToCombatInfoChanged()
		{
		}

		// Token: 0x06003B7A RID: 15226 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003B7A")]
		protected virtual void HandleGameOver(ProtoCombatCompleteEvt msg)
		{
		}

		// Token: 0x06003B7B RID: 15227 RVA: 0x0000BFA0 File Offset: 0x0000A1A0
		[Token(Token = "0x6003B7B")]
		protected virtual bool TryHandleJoinError(ProtoJoinToCombatAns msg)
		{
			return default(bool);
		}

		// Token: 0x06003B7C RID: 15228 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003B7C")]
		private void RequestJoinToCombat()
		{
		}

		// Token: 0x06003B7D RID: 15229 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003B7D")]
		private void RequestSwap(int fromX, int fromY, int toX, int toY)
		{
		}

		// Token: 0x06003B7E RID: 15230 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003B7E")]
		private void RequestUserSpell(SpellTarget spellTarget)
		{
		}

		// Token: 0x06003B7F RID: 15231 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003B7F")]
		private void HandlePlayerActionUseSpell(OpToken<IMessage, object> op)
		{
		}

		// Token: 0x06003B80 RID: 15232 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003B80")]
		private void HandlePlayerActionServiceRequest(OpToken<IMessage, object> op)
		{
		}

		// Token: 0x06003B81 RID: 15233 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003B81")]
		private void HandleJoinToCombatServiceRequest(OpToken<IMessage, object> op)
		{
		}

		// Token: 0x06003B82 RID: 15234 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003B82")]
		private void HandleJumToCombatServiceEvent(ProtoJumpToCombatEvt msg)
		{
		}

		// Token: 0x06003B83 RID: 15235 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003B83")]
		private void HandleCombatTerminatedServiceEvent(ProtoCombatTerminatedEvt msg)
		{
		}

		// Token: 0x06003B84 RID: 15236 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003B84")]
		private void HandleCooldownChangedServiceEvent(ProtoSpellCoolDownChangedEvt msg)
		{
		}

		// Token: 0x06003B85 RID: 15237 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003B85")]
		private void HandleEffectsChangedServiceEvent(ProtoEffectsChangedEvt msg)
		{
		}

		// Token: 0x06003B86 RID: 15238 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003B86")]
		private void HandleSpellAppliedServiceEvent(ProtoSpellAppliedEvt msg)
		{
		}

		// Token: 0x06003B87 RID: 15239 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003B87")]
		private void HandleSkillsChangedServiceEvent(ProtoSkillsChangedEvt msg)
		{
		}

		// Token: 0x06003B88 RID: 15240 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003B88")]
		public void HandleUserResurrected(ProtoSkillsChangedEvt msg)
		{
		}

		// Token: 0x06003B89 RID: 15241 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003B89")]
		protected virtual void HandleShowHintServiceEvent(ProtoShowHintEvt msg)
		{
		}

		// Token: 0x06003B8A RID: 15242 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003B8A")]
		private void HandleCombatEventsServiceEvent(ProtoCombatEventsEvt msg)
		{
		}

		// Token: 0x06003B8B RID: 15243 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003B8B")]
		private void HandlePlayersActionServiceEvent(ProtoPlayerActionEvt msg)
		{
		}

		// Token: 0x06003B8C RID: 15244 RVA: 0x0000BFB8 File Offset: 0x0000A1B8
		[Token(Token = "0x6003B8C")]
		protected virtual bool IsOtherPlayer(ProtoPlayerActionEvt msg)
		{
			return default(bool);
		}

		// Token: 0x06003B8D RID: 15245 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003B8D")]
		private void HandleFieldChangedServiceEvent(ProtoFieldChangedEvt msg)
		{
		}

		// Token: 0x06003B8E RID: 15246 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003B8E")]
		private void HandleCombatCompleteServiceEvent(ProtoCombatCompleteEvt msg)
		{
		}

		// Token: 0x06003B8F RID: 15247 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003B8F")]
		protected virtual void HandleGameOverInfoChanged(GameOverData gameOverData)
		{
		}

		// Token: 0x06003B90 RID: 15248 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003B90")]
		private void HandleSwitchTurnServiceEvent(ProtoSwitchTurnEvt msg)
		{
		}

		// Token: 0x06003B91 RID: 15249 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003B91")]
		private void HandleOnUserBalanceChangedEvent(ResourceSet balance, ResourceSet delta)
		{
		}

		// Token: 0x06003B92 RID: 15250 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003B92")]
		protected virtual void HandleChatServiceEvent(ProtoChatEvt msg)
		{
		}

		// Token: 0x06003B93 RID: 15251 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003B93")]
		private void HandleAntiqEffectTriggeredEvent(ProtoAntiqEffectTriggeredEvt msg)
		{
		}

		// Token: 0x06003B94 RID: 15252 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003B94")]
		public virtual void NotifyShowViewProcessComplete()
		{
		}

		// Token: 0x06003B95 RID: 15253 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003B95")]
		public void NotifyAllAnimationComplete()
		{
		}

		// Token: 0x06003B96 RID: 15254 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003B96")]
		public void NotifyTurnTimeout()
		{
		}

		// Token: 0x06003B97 RID: 15255 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003B97")]
		public void Swap(int fromX, int fromY, int toX, int toY)
		{
		}

		// Token: 0x06003B98 RID: 15256 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003B98")]
		public void SpellCalled(SpellTarget spellTarget)
		{
		}

		// Token: 0x06003B99 RID: 15257 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003B99")]
		public void SelectSpell(CombatSpellData spell)
		{
		}

		// Token: 0x06003B9A RID: 15258 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003B9A")]
		[CompilerGenerated]
		private void <HandleSpellAppliedServiceEvent>g__Handler|42_0(CombatSpellData spell, CombatPlayer combatPlayer, ProtoSpellAppliedEvt protoSpellAppliedEvt)
		{
		}

		// Token: 0x040020C4 RID: 8388
		[Token(Token = "0x40020C4")]
		[FieldOffset(Offset = "0x0")]
		private Conveyor _conveyor;
	}
}
