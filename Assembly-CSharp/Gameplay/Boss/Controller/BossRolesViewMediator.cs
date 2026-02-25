using System;
using Gameplay.Boss.Events;
using Gameplay.Boss.Model;
using Gameplay.Boss.View.RolesTab;
using Il2CppDummyDll;

namespace Gameplay.Boss.Controller
{
	// Token: 0x02000BB3 RID: 2995
	[Token(Token = "0x2000BB3")]
	public class BossRolesViewMediator : AbstractBossWindowViewMediator<BossRolesView>
	{
		// Token: 0x06004977 RID: 18807 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004977")]
		[Address(RVA = "0x97E9", Offset = "0x97E9", VA = "0x97E9")]
		public BossRolesViewMediator(BossInstanceModel model, BossInstanceEvents events, BossInstanceController controller)
		{
		}

		// Token: 0x06004978 RID: 18808 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004978")]
		[Address(RVA = "0x97EA", Offset = "0x97EA", VA = "0x97EA", Slot = "21")]
		protected override void ResetEvents(BossInstanceEvents events)
		{
		}

		// Token: 0x06004979 RID: 18809 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004979")]
		[Address(RVA = "0x97EB", Offset = "0x97EB", VA = "0x97EB", Slot = "22")]
		protected override void SetupEvents(BossInstanceEvents events)
		{
		}

		// Token: 0x0600497A RID: 18810 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600497A")]
		[Address(RVA = "0x97EC", Offset = "0x97EC", VA = "0x97EC", Slot = "23")]
		protected override void ResetView(BossRolesView view)
		{
		}

		// Token: 0x0600497B RID: 18811 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600497B")]
		[Address(RVA = "0x97ED", Offset = "0x97ED", VA = "0x97ED", Slot = "24")]
		protected override void SetupView(BossRolesView view)
		{
		}

		// Token: 0x0600497C RID: 18812 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600497C")]
		[Address(RVA = "0x97EE", Offset = "0x97EE", VA = "0x97EE")]
		private void ViewOnSelectedEvent(BossInfo.BossCultSpellData cultSpell)
		{
		}
	}
}
