using System;
using System.Collections.Generic;
using Gameplay.Combat.Control;
using Gameplay.Combat.Model;
using Gameplay.Combat.View;
using Gameplay.VortexCombat.Model;
using Gameplay.VortexCombat.View;
using Il2CppDummyDll;
using Protocol.Combat;
using UnityEngine.EventSystems;
using Utils;

namespace Gameplay.VortexCombat.Control
{
	// Token: 0x020003B9 RID: 953
	[Token(Token = "0x20003B9")]
	public class VortexCombatViewMediator : AbstractCombatViewMediator<VortexCombatModel, VortexCombatEvents, VortexCombatController, VortexCombatView>
	{
		// Token: 0x06001651 RID: 5713 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001651")]
		[Address(RVA = "0x6812", Offset = "0x6812", VA = "0x6812")]
		public VortexCombatViewMediator(VortexCombatModel model, VortexCombatEvents events, VortexCombatController controller)
		{
		}

		// Token: 0x170003BA RID: 954
		// (set) Token: 0x06001652 RID: 5714 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003BA")]
		public override VortexCombatEvents Events
		{
			[Token(Token = "0x6001652")]
			[Address(RVA = "0x6813", Offset = "0x6813", VA = "0x6813", Slot = "16")]
			set
			{
			}
		}

		// Token: 0x06001653 RID: 5715 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001653")]
		[Address(RVA = "0x6814", Offset = "0x6814", VA = "0x6814")]
		private void HandleSwitchTurnEvent(TurnStates obj)
		{
		}

		// Token: 0x06001654 RID: 5716 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001654")]
		[Address(RVA = "0x6815", Offset = "0x6815", VA = "0x6815", Slot = "23")]
		protected override void HandleInitEvent()
		{
		}

		// Token: 0x06001655 RID: 5717 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001655")]
		[Address(RVA = "0x6816", Offset = "0x6816", VA = "0x6816", Slot = "27")]
		protected override void HandleUserSkillsChangedEvent(IList<CombatPlayer> players)
		{
		}

		// Token: 0x06001656 RID: 5718 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001656")]
		[Address(RVA = "0x6817", Offset = "0x6817", VA = "0x6817", Slot = "32")]
		protected override void HandleResetView()
		{
		}

		// Token: 0x06001657 RID: 5719 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001657")]
		[Address(RVA = "0x6818", Offset = "0x6818", VA = "0x6818", Slot = "31")]
		protected override void HandleSetupView()
		{
		}

		// Token: 0x06001658 RID: 5720 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001658")]
		[Address(RVA = "0x6819", Offset = "0x6819", VA = "0x6819", Slot = "36")]
		protected override void HandleSelectedSpell(CombatSpellData spell)
		{
		}

		// Token: 0x06001659 RID: 5721 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001659")]
		[Address(RVA = "0x681A", Offset = "0x681A", VA = "0x681A")]
		private void StopListenPLayersClick(List<CombatPlayer> players)
		{
		}

		// Token: 0x0600165A RID: 5722 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600165A")]
		[Address(RVA = "0x681B", Offset = "0x681B", VA = "0x681B")]
		private void StartListenPlayersClick(List<CombatPlayer> players)
		{
		}

		// Token: 0x0600165B RID: 5723 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600165B")]
		[Address(RVA = "0x681C", Offset = "0x681C", VA = "0x681C")]
		private void HandleClickOnPLayer(PointerEventData data)
		{
		}

		// Token: 0x0600165C RID: 5724 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600165C")]
		[Address(RVA = "0x681D", Offset = "0x681D", VA = "0x681D")]
		private void HandleClickShowHideSkillsNumbersButtonEvent(bool value)
		{
		}

		// Token: 0x0600165D RID: 5725 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600165D")]
		[Address(RVA = "0x681E", Offset = "0x681E", VA = "0x681E", Slot = "33")]
		protected override CombatWaitingWindowMono ShowAwaitCombatWindow(BackTime backTime)
		{
			return null;
		}

		// Token: 0x0600165E RID: 5726 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600165E")]
		[Address(RVA = "0x681F", Offset = "0x681F", VA = "0x681F", Slot = "37")]
		protected override void HandleGameOver()
		{
		}

		// Token: 0x0600165F RID: 5727 RVA: 0x00005460 File Offset: 0x00003660
		[Token(Token = "0x600165F")]
		[Address(RVA = "0x6820", Offset = "0x6820", VA = "0x6820", Slot = "21")]
		protected override bool HandleGameOverWindowNextCombatRequestEvent(CombatGameOverView gameOverView)
		{
			return default(bool);
		}

		// Token: 0x06001660 RID: 5728 RVA: 0x00005478 File Offset: 0x00003678
		[Token(Token = "0x6001660")]
		[Address(RVA = "0x6821", Offset = "0x6821", VA = "0x6821", Slot = "22")]
		protected override bool HandleGameOverWindowCloseRequestEvent(CombatGameOverView view)
		{
			return default(bool);
		}

		// Token: 0x06001661 RID: 5729 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001661")]
		[Address(RVA = "0x6822", Offset = "0x6822", VA = "0x6822", Slot = "25")]
		protected override void HandleSpellAppliedEvent(CombatPlayer owner, CombatSpellData spell, List<CombatPlayer> targetPlayers)
		{
		}

		// Token: 0x06001662 RID: 5730 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001662")]
		[Address(RVA = "0x6823", Offset = "0x6823", VA = "0x6823", Slot = "28")]
		protected override void HandleTerminate(TerminateReason reason)
		{
		}
	}
}
