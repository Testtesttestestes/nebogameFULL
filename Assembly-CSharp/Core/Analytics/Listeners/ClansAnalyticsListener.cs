using System;
using System.Collections.Generic;
using Core.Events.Scopes;
using Il2CppDummyDll;

namespace Core.Analytics.Listeners
{
	// Token: 0x020012C8 RID: 4808
	[Token(Token = "0x20012C8")]
	public class ClansAnalyticsListener : AbstractAnalyticsListener
	{
		// Token: 0x1700172C RID: 5932
		// (get) Token: 0x06007245 RID: 29253 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700172C")]
		protected override string Theme
		{
			[Token(Token = "0x6007245")]
			[Address(RVA = "0xBC4E", Offset = "0xBC4E", VA = "0xBC4E", Slot = "5")]
			get
			{
				return null;
			}
		}

		// Token: 0x06007246 RID: 29254 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007246")]
		[Address(RVA = "0xBC4F", Offset = "0xBC4F", VA = "0xBC4F", Slot = "10")]
		public override void Init()
		{
		}

		// Token: 0x06007247 RID: 29255 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007247")]
		[Address(RVA = "0xBC50", Offset = "0xBC50", VA = "0xBC50", Slot = "11")]
		protected override void Deinit()
		{
		}

		// Token: 0x06007248 RID: 29256 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007248")]
		[Address(RVA = "0xBC51", Offset = "0xBC51", VA = "0xBC51")]
		private void CreateClanEventHandler(ClansScope.CreateClanEventArgs args)
		{
		}

		// Token: 0x06007249 RID: 29257 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007249")]
		[Address(RVA = "0xBC52", Offset = "0xBC52", VA = "0xBC52")]
		private void JoinRequestEventHandler(ClansScope.ClansEventArgs args)
		{
		}

		// Token: 0x0600724A RID: 29258 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600724A")]
		[Address(RVA = "0xBC53", Offset = "0xBC53", VA = "0xBC53")]
		private void ConfirmJoinClanEventHandler(UserScope.BaseUserEventArgs args)
		{
		}

		// Token: 0x0600724B RID: 29259 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600724B")]
		[Address(RVA = "0xBC54", Offset = "0xBC54", VA = "0xBC54")]
		private void AddMoneyToClanEventHandler(ClansScope.ClansEventArgs args)
		{
		}

		// Token: 0x0600724C RID: 29260 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600724C")]
		[Address(RVA = "0xBC55", Offset = "0xBC55", VA = "0xBC55")]
		private void StartClanBuildEventHandler(ClansScope.ClanBuildingEventArgs args)
		{
		}

		// Token: 0x0600724D RID: 29261 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600724D")]
		[Address(RVA = "0xBC56", Offset = "0xBC56", VA = "0xBC56")]
		private void BuyClanSlotEventHandler(ClansScope.ClanIsleEventArgs args)
		{
		}

		// Token: 0x0600724E RID: 29262 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600724E")]
		[Address(RVA = "0xBC57", Offset = "0xBC57", VA = "0xBC57")]
		private void StartLearnSpellEventHandler(ClansScope.ClanSpellEventArgs args)
		{
		}

		// Token: 0x0600724F RID: 29263 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600724F")]
		[Address(RVA = "0xBC58", Offset = "0xBC58", VA = "0xBC58")]
		private void UseSpellEventHandler(ClansScope.ClanSpellEventArgs args)
		{
		}

		// Token: 0x06007250 RID: 29264 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007250")]
		[Address(RVA = "0xBC59", Offset = "0xBC59", VA = "0xBC59")]
		private void WarDeclaredEventHandler(ClansScope.ClanWarsDeclarationEventArgs args)
		{
		}

		// Token: 0x06007251 RID: 29265 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007251")]
		[Address(RVA = "0xBC5A", Offset = "0xBC5A", VA = "0xBC5A")]
		private void WarPrepareSpeedupEventHandler(ClansScope.ClanWarsEventArgs args)
		{
		}

		// Token: 0x06007252 RID: 29266 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007252")]
		[Address(RVA = "0xBC5B", Offset = "0xBC5B", VA = "0xBC5B")]
		private void WarPrepareCancelSpeedupEventHandler(ClansScope.ClanWarsEventArgs args)
		{
		}

		// Token: 0x06007253 RID: 29267 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007253")]
		[Address(RVA = "0xBC5C", Offset = "0xBC5C", VA = "0xBC5C")]
		private void WarPayoffEventHandler(ClansScope.ClanWarsEventArgs args)
		{
		}

		// Token: 0x06007254 RID: 29268 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007254")]
		[Address(RVA = "0xBC5D", Offset = "0xBC5D", VA = "0xBC5D")]
		private void TakeGolemOutEventHandler()
		{
		}

		// Token: 0x06007255 RID: 29269 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007255")]
		[Address(RVA = "0xBC5E", Offset = "0xBC5E", VA = "0xBC5E")]
		private void LeaveClanEventHandler(ClansScope.BaseClansEventArgs args)
		{
		}

		// Token: 0x06007256 RID: 29270 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007256")]
		[Address(RVA = "0xBC5F", Offset = "0xBC5F", VA = "0xBC5F")]
		private void DissolveClanEventHandler(ClansScope.BaseClansEventArgs args)
		{
		}

		// Token: 0x06007257 RID: 29271 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007257")]
		[Address(RVA = "0xBC60", Offset = "0xBC60", VA = "0xBC60")]
		private void ClanCombatStartedEventHandler(ClansScope.ClanCombatEventArgs args)
		{
		}

		// Token: 0x06007258 RID: 29272 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007258")]
		[Address(RVA = "0xBC61", Offset = "0xBC61", VA = "0xBC61")]
		private void ClanCombatFinishedEventHandler(ClansScope.ClanCombatFinishEventArgs args)
		{
		}

		// Token: 0x06007259 RID: 29273 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6007259")]
		[Address(RVA = "0xBC62", Offset = "0xBC62", VA = "0xBC62")]
		private Dictionary<string, object> PopulateClanWarProperties(ClansScope.ClanWarsEventArgs args)
		{
			return null;
		}

		// Token: 0x0600725A RID: 29274 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600725A")]
		[Address(RVA = "0xBC63", Offset = "0xBC63", VA = "0xBC63")]
		public ClansAnalyticsListener()
		{
		}

		// Token: 0x04003BE1 RID: 15329
		[Token(Token = "0x4003BE1")]
		private const string CREATE_CLAN = "create_clan";

		// Token: 0x04003BE2 RID: 15330
		[Token(Token = "0x4003BE2")]
		private const string JOIN_REQUEST_CLAN = "join_request_clan";

		// Token: 0x04003BE3 RID: 15331
		[Token(Token = "0x4003BE3")]
		private const string CONFIRM_JOIN_CLAN = "confirm_join_clan";

		// Token: 0x04003BE4 RID: 15332
		[Token(Token = "0x4003BE4")]
		private const string ADD_MONEY_TO_CLAN = "add_money_to_clan";

		// Token: 0x04003BE5 RID: 15333
		[Token(Token = "0x4003BE5")]
		private const string START_CLAN_BUILD = "start_clan_build";

		// Token: 0x04003BE6 RID: 15334
		[Token(Token = "0x4003BE6")]
		private const string BUY_CLAN_SLOT = "buy_clan_slot";

		// Token: 0x04003BE7 RID: 15335
		[Token(Token = "0x4003BE7")]
		private const string START_CLAN_LEARN = "start_clan_learn";

		// Token: 0x04003BE8 RID: 15336
		[Token(Token = "0x4003BE8")]
		private const string USE_CLAN_SPELL = "use_clan_spell";

		// Token: 0x04003BE9 RID: 15337
		[Token(Token = "0x4003BE9")]
		private const string WAR_DECLARATION = "war_declaration";

		// Token: 0x04003BEA RID: 15338
		[Token(Token = "0x4003BEA")]
		private const string WAR_PREPARE_SPEEDUP = "war_prepare_speedup";

		// Token: 0x04003BEB RID: 15339
		[Token(Token = "0x4003BEB")]
		private const string WAR_PREPARE_CANCEL_SPEEDUP = "war_prepare_cancel_speedup";

		// Token: 0x04003BEC RID: 15340
		[Token(Token = "0x4003BEC")]
		private const string WAR_PAY_OFF = "war_pay_off";

		// Token: 0x04003BED RID: 15341
		[Token(Token = "0x4003BED")]
		private const string TAKE_GOLEM_OUT = "take_golem_out";

		// Token: 0x04003BEE RID: 15342
		[Token(Token = "0x4003BEE")]
		private const string LEAVE_CLAN = "leave_clan";

		// Token: 0x04003BEF RID: 15343
		[Token(Token = "0x4003BEF")]
		private const string DISSOLVE_CLAN = "dissolve_clan";

		// Token: 0x04003BF0 RID: 15344
		[Token(Token = "0x4003BF0")]
		private const string CLAN_COMBAT_STARTED = "clan_combat_started";

		// Token: 0x04003BF1 RID: 15345
		[Token(Token = "0x4003BF1")]
		private const string CLAN_COMBAT_FINISHED = "clan_combat_finished";

		// Token: 0x020012C9 RID: 4809
		[Token(Token = "0x20012C9")]
		private enum CombatResult : byte
		{
			// Token: 0x04003BF3 RID: 15347
			[Token(Token = "0x4003BF3")]
			@true,
			// Token: 0x04003BF4 RID: 15348
			[Token(Token = "0x4003BF4")]
			@false,
			// Token: 0x04003BF5 RID: 15349
			[Token(Token = "0x4003BF5")]
			draw
		}
	}
}
