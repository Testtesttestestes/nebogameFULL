using System;
using System.Collections.Generic;
using Core.Events.Scopes;
using Gameplay.Boss.Model;
using Il2CppDummyDll;

namespace Core.Analytics.Listeners
{
	// Token: 0x020012C6 RID: 4806
	[Token(Token = "0x20012C6")]
	public class BossAnalyticsListener : AbstractAnalyticsListener
	{
		// Token: 0x1700172A RID: 5930
		// (get) Token: 0x06007237 RID: 29239 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700172A")]
		protected override string Theme
		{
			[Token(Token = "0x6007237")]
			[Address(RVA = "0xBC40", Offset = "0xBC40", VA = "0xBC40", Slot = "5")]
			get
			{
				return null;
			}
		}

		// Token: 0x06007238 RID: 29240 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007238")]
		[Address(RVA = "0xBC41", Offset = "0xBC41", VA = "0xBC41", Slot = "10")]
		public override void Init()
		{
		}

		// Token: 0x06007239 RID: 29241 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007239")]
		[Address(RVA = "0xBC42", Offset = "0xBC42", VA = "0xBC42", Slot = "11")]
		protected override void Deinit()
		{
		}

		// Token: 0x0600723A RID: 29242 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600723A")]
		[Address(RVA = "0xBC43", Offset = "0xBC43", VA = "0xBC43")]
		private void AcceptInviteEvent(BossScope.InviteEventArgs e)
		{
		}

		// Token: 0x0600723B RID: 29243 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600723B")]
		[Address(RVA = "0xBC44", Offset = "0xBC44", VA = "0xBC44")]
		private void AppendBaseBossProperties(Dictionary<string, object> properties, BossInstanceModel model)
		{
		}

		// Token: 0x0600723C RID: 29244 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600723C")]
		[Address(RVA = "0xBC45", Offset = "0xBC45", VA = "0xBC45")]
		private void MinionKickedEvent(BossScope.MinionEventArgs e)
		{
		}

		// Token: 0x0600723D RID: 29245 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600723D")]
		[Address(RVA = "0xBC46", Offset = "0xBC46", VA = "0xBC46")]
		private void MinionAttackEvent(BossScope.MinionEventArgs e)
		{
		}

		// Token: 0x0600723E RID: 29246 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600723E")]
		[Address(RVA = "0xBC47", Offset = "0xBC47", VA = "0xBC47")]
		private void AttackBossEvent(BossScope.AttackBossEventArgs e)
		{
		}

		// Token: 0x0600723F RID: 29247 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600723F")]
		[Address(RVA = "0xBC48", Offset = "0xBC48", VA = "0xBC48")]
		public BossAnalyticsListener()
		{
		}

		// Token: 0x04003BDC RID: 15324
		[Token(Token = "0x4003BDC")]
		private const string ATTACK_BOSS = "boss_attack";

		// Token: 0x04003BDD RID: 15325
		[Token(Token = "0x4003BDD")]
		private const string MINION_ATTACK = "minion_attack";

		// Token: 0x04003BDE RID: 15326
		[Token(Token = "0x4003BDE")]
		private const string MINION_PAYOFF = "minion_payoff";

		// Token: 0x04003BDF RID: 15327
		[Token(Token = "0x4003BDF")]
		private const string ACCEPT_INVITE = "accept_invite";
	}
}
