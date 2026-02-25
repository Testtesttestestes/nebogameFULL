using System;
using System.Collections.Generic;
using Core.Events.Scopes;
using Il2CppDummyDll;

namespace Core.Analytics.Listeners
{
	// Token: 0x020012CB RID: 4811
	[Token(Token = "0x20012CB")]
	public class CombatAnalyticsListener : AbstractAnalyticsListener
	{
		// Token: 0x1700172E RID: 5934
		// (get) Token: 0x06007260 RID: 29280 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700172E")]
		protected override string Theme
		{
			[Token(Token = "0x6007260")]
			[Address(RVA = "0xBC69", Offset = "0xBC69", VA = "0xBC69", Slot = "5")]
			get
			{
				return null;
			}
		}

		// Token: 0x06007261 RID: 29281 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007261")]
		[Address(RVA = "0xBC6A", Offset = "0xBC6A", VA = "0xBC6A", Slot = "10")]
		public override void Init()
		{
		}

		// Token: 0x06007262 RID: 29282 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007262")]
		[Address(RVA = "0xBC6B", Offset = "0xBC6B", VA = "0xBC6B", Slot = "11")]
		protected override void Deinit()
		{
		}

		// Token: 0x06007263 RID: 29283 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007263")]
		[Address(RVA = "0xBC6C", Offset = "0xBC6C", VA = "0xBC6C")]
		private void CombatFinishedEvent(CombatScope.CombatFinishedEventArgs e)
		{
		}

		// Token: 0x06007264 RID: 29284 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007264")]
		[Address(RVA = "0xBC6D", Offset = "0xBC6D", VA = "0xBC6D")]
		private void CombatStartedEvent(CombatScope.CombatEventArgs e)
		{
		}

		// Token: 0x06007265 RID: 29285 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6007265")]
		[Address(RVA = "0xBC6E", Offset = "0xBC6E", VA = "0xBC6E")]
		private Dictionary<string, object> GetCombatCommonProperties(CombatScope.CombatEventArgs e)
		{
			return null;
		}

		// Token: 0x06007266 RID: 29286 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007266")]
		[Address(RVA = "0xBC6F", Offset = "0xBC6F", VA = "0xBC6F")]
		private void AttackMonsterEvent(CombatScope.AttackMonsterEventArgs e)
		{
		}

		// Token: 0x06007267 RID: 29287 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007267")]
		[Address(RVA = "0xBC70", Offset = "0xBC70", VA = "0xBC70")]
		private void KickMonsterEvent(CombatScope.KickMonsterEventArgs e)
		{
		}

		// Token: 0x06007268 RID: 29288 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007268")]
		[Address(RVA = "0xBC71", Offset = "0xBC71", VA = "0xBC71")]
		public CombatAnalyticsListener()
		{
		}

		// Token: 0x04003BF7 RID: 15351
		[Token(Token = "0x4003BF7")]
		public const string THEME = "combat";

		// Token: 0x04003BF8 RID: 15352
		[Token(Token = "0x4003BF8")]
		private const string ATTACK_MONSTER = "attack_monster";

		// Token: 0x04003BF9 RID: 15353
		[Token(Token = "0x4003BF9")]
		private const string KICK_MONSTER = "kick_monster";

		// Token: 0x04003BFA RID: 15354
		[Token(Token = "0x4003BFA")]
		public const string COMBAT_STARTED = "combat_started";

		// Token: 0x04003BFB RID: 15355
		[Token(Token = "0x4003BFB")]
		public const string COMBAT_FINISHED = "combat_finished";
	}
}
