using System;
using System.Collections.Generic;
using Gameplay.Clans.Combat.Model;
using Gameplay.Clans.Combat.View;
using Gameplay.Combat.Control;
using Gameplay.Combat.Model;
using Gameplay.Combat.View;
using Il2CppDummyDll;

namespace Gameplay.Clans.Combat.Control
{
	// Token: 0x02000AA4 RID: 2724
	[Token(Token = "0x2000AA4")]
	public class ClanCombatViewMediator : AbstractCombatViewMediator<ClanCombatModel, ClanCombatEvents, ClanCombatController, ClanCombatView>
	{
		// Token: 0x06004195 RID: 16789 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004195")]
		[Address(RVA = "0x904C", Offset = "0x904C", VA = "0x904C")]
		public ClanCombatViewMediator(ClanCombatModel model, ClanCombatEvents events, ClanCombatController controller)
		{
		}

		// Token: 0x06004196 RID: 16790 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004196")]
		[Address(RVA = "0x904D", Offset = "0x904D", VA = "0x904D", Slot = "31")]
		protected override void HandleSetupView()
		{
		}

		// Token: 0x06004197 RID: 16791 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004197")]
		[Address(RVA = "0x904E", Offset = "0x904E", VA = "0x904E", Slot = "32")]
		protected override void HandleResetView()
		{
		}

		// Token: 0x06004198 RID: 16792 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004198")]
		[Address(RVA = "0x904F", Offset = "0x904F", VA = "0x904F", Slot = "23")]
		protected override void HandleInitEvent()
		{
		}

		// Token: 0x06004199 RID: 16793 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004199")]
		[Address(RVA = "0x9050", Offset = "0x9050", VA = "0x9050", Slot = "29")]
		protected override void AddGameProcessEventsHandlers()
		{
		}

		// Token: 0x0600419A RID: 16794 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600419A")]
		[Address(RVA = "0x9051", Offset = "0x9051", VA = "0x9051", Slot = "30")]
		protected override void RemoveGameProcessEventsHandlers()
		{
		}

		// Token: 0x0600419B RID: 16795 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600419B")]
		[Address(RVA = "0x9052", Offset = "0x9052", VA = "0x9052", Slot = "37")]
		protected override void HandleGameOver()
		{
		}

		// Token: 0x0600419C RID: 16796 RVA: 0x0000C9C0 File Offset: 0x0000ABC0
		[Token(Token = "0x600419C")]
		[Address(RVA = "0x9053", Offset = "0x9053", VA = "0x9053", Slot = "22")]
		protected override bool HandleGameOverWindowCloseRequestEvent(CombatGameOverView view)
		{
			return default(bool);
		}

		// Token: 0x0600419D RID: 16797 RVA: 0x0000C9D8 File Offset: 0x0000ABD8
		[Token(Token = "0x600419D")]
		[Address(RVA = "0x9054", Offset = "0x9054", VA = "0x9054", Slot = "21")]
		protected override bool HandleGameOverWindowNextCombatRequestEvent(CombatGameOverView view)
		{
			return default(bool);
		}

		// Token: 0x0600419E RID: 16798 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600419E")]
		[Address(RVA = "0x9055", Offset = "0x9055", VA = "0x9055")]
		private void HandleExitFromViewMoveClickEvent()
		{
		}

		// Token: 0x0600419F RID: 16799 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600419F")]
		[Address(RVA = "0x9056", Offset = "0x9056", VA = "0x9056")]
		private void HandleStartCombatClickEvent()
		{
		}

		// Token: 0x060041A0 RID: 16800 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60041A0")]
		[Address(RVA = "0x9057", Offset = "0x9057", VA = "0x9057")]
		private void HandleChatEvent(CombatPlayer arg1, string arg2)
		{
		}

		// Token: 0x060041A1 RID: 16801 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60041A1")]
		[Address(RVA = "0x9058", Offset = "0x9058", VA = "0x9058")]
		private void HandleJointEvent()
		{
		}

		// Token: 0x060041A2 RID: 16802 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60041A2")]
		[Address(RVA = "0x9059", Offset = "0x9059", VA = "0x9059", Slot = "27")]
		protected override void HandleUserSkillsChangedEvent(IList<CombatPlayer> players)
		{
		}

		// Token: 0x060041A3 RID: 16803 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60041A3")]
		[Address(RVA = "0x905A", Offset = "0x905A", VA = "0x905A")]
		private void HandleEffectsChangedEvent(IList<CombatPlayer> players)
		{
		}

		// Token: 0x060041A4 RID: 16804 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60041A4")]
		[Address(RVA = "0x905B", Offset = "0x905B", VA = "0x905B")]
		private void HandlePlayerRemovedEvent(CombatPlayer player)
		{
		}

		// Token: 0x060041A5 RID: 16805 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60041A5")]
		[Address(RVA = "0x1B21", Offset = "0x1B21", VA = "0x1B21")]
		private void HandlePlayerAddedEvent(CombatPlayer player)
		{
		}

		// Token: 0x060041A6 RID: 16806 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60041A6")]
		[Address(RVA = "0x905C", Offset = "0x905C", VA = "0x905C")]
		private void HandlePlayersMovedEvent(List<CombatPlayer> players)
		{
		}

		// Token: 0x060041A7 RID: 16807 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60041A7")]
		[Address(RVA = "0x905D", Offset = "0x905D", VA = "0x905D")]
		private void ShowCurrentPlayersInfo()
		{
		}

		// Token: 0x060041A8 RID: 16808 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60041A8")]
		[Address(RVA = "0x905E", Offset = "0x905E", VA = "0x905E")]
		private void SetSpellElixirs(CombatPlayer player)
		{
		}

		// Token: 0x060041A9 RID: 16809 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60041A9")]
		[Address(RVA = "0x905F", Offset = "0x905F", VA = "0x905F")]
		private void ValidateViewMode()
		{
		}
	}
}
