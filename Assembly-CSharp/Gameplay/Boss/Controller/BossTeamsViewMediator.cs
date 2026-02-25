using System;
using System.Collections.Generic;
using Gameplay.Boss.Events;
using Gameplay.Boss.Model;
using Gameplay.Boss.View.TeamsTab;
using Il2CppDummyDll;

namespace Gameplay.Boss.Controller
{
	// Token: 0x02000BB9 RID: 3001
	[Token(Token = "0x2000BB9")]
	public class BossTeamsViewMediator : AbstractBossWindowViewMediator<BossTeamsView>
	{
		// Token: 0x0600499F RID: 18847 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600499F")]
		[Address(RVA = "0x9811", Offset = "0x9811", VA = "0x9811")]
		public BossTeamsViewMediator(BossInstanceModel model, BossInstanceEvents events, BossInstanceController controller)
		{
		}

		// Token: 0x060049A0 RID: 18848 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60049A0")]
		[Address(RVA = "0x9812", Offset = "0x9812", VA = "0x9812", Slot = "21")]
		protected override void ResetEvents(BossInstanceEvents events)
		{
		}

		// Token: 0x060049A1 RID: 18849 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60049A1")]
		[Address(RVA = "0x9813", Offset = "0x9813", VA = "0x9813", Slot = "22")]
		protected override void SetupEvents(BossInstanceEvents events)
		{
		}

		// Token: 0x060049A2 RID: 18850 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60049A2")]
		[Address(RVA = "0x9814", Offset = "0x9814", VA = "0x9814", Slot = "23")]
		protected override void ResetView(BossTeamsView view)
		{
		}

		// Token: 0x060049A3 RID: 18851 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60049A3")]
		[Address(RVA = "0x9815", Offset = "0x9815", VA = "0x9815", Slot = "24")]
		protected override void SetupView(BossTeamsView view)
		{
		}

		// Token: 0x060049A4 RID: 18852 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60049A4")]
		[Address(RVA = "0x9816", Offset = "0x9816", VA = "0x9816")]
		private void ListAdapterOnClickEvent(TeamRewardData teamRewardData)
		{
		}

		// Token: 0x060049A5 RID: 18853 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60049A5")]
		[Address(RVA = "0x9817", Offset = "0x9817", VA = "0x9817")]
		private void CaptainTeamsReceivedEvent(ulong captainId, List<TeamRewardData> teams)
		{
		}

		// Token: 0x04002810 RID: 10256
		[Token(Token = "0x4002810")]
		[FieldOffset(Offset = "0x18")]
		private readonly List<TeamRewardData> _teamsRewardData;

		// Token: 0x04002811 RID: 10257
		[Token(Token = "0x4002811")]
		[FieldOffset(Offset = "0x1C")]
		private readonly List<ulong> _teamIdsWithAssistants;
	}
}
