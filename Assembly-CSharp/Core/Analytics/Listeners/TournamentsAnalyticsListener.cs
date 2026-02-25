using System;
using Core.Events;
using Core.Events.Scopes;
using Il2CppDummyDll;

namespace Core.Analytics.Listeners
{
	// Token: 0x020012E3 RID: 4835
	[Token(Token = "0x20012E3")]
	public class TournamentsAnalyticsListener : AbstractAnalyticsListener
	{
		// Token: 0x17001745 RID: 5957
		// (get) Token: 0x06007303 RID: 29443 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17001745")]
		protected override string Theme
		{
			[Token(Token = "0x6007303")]
			[Address(RVA = "0xBD0C", Offset = "0xBD0C", VA = "0xBD0C", Slot = "5")]
			get
			{
				return null;
			}
		}

		// Token: 0x06007304 RID: 29444 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007304")]
		[Address(RVA = "0xBD0D", Offset = "0xBD0D", VA = "0xBD0D", Slot = "10")]
		public override void Init()
		{
		}

		// Token: 0x06007305 RID: 29445 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007305")]
		[Address(RVA = "0xBD0E", Offset = "0xBD0E", VA = "0xBD0E", Slot = "11")]
		protected override void Deinit()
		{
		}

		// Token: 0x06007306 RID: 29446 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007306")]
		[Address(RVA = "0xBD0F", Offset = "0xBD0F", VA = "0xBD0F")]
		private void LeaveTournamentEvent(BaseEventBusEventArgs e)
		{
		}

		// Token: 0x06007307 RID: 29447 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007307")]
		[Address(RVA = "0xBD10", Offset = "0xBD10", VA = "0xBD10")]
		private void FinalCombatCompleteEvent(TournamentsScope.FinalCombatCompleteEventArgs e)
		{
		}

		// Token: 0x06007308 RID: 29448 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007308")]
		[Address(RVA = "0xBD11", Offset = "0xBD11", VA = "0xBD11")]
		private void AddBetEvent(TournamentsScope.AddBetEventArgs e)
		{
		}

		// Token: 0x06007309 RID: 29449 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007309")]
		[Address(RVA = "0xBD12", Offset = "0xBD12", VA = "0xBD12")]
		public TournamentsAnalyticsListener()
		{
		}

		// Token: 0x04003C38 RID: 15416
		[Token(Token = "0x4003C38")]
		private const string ADD_BET = "add_bet";

		// Token: 0x04003C39 RID: 15417
		[Token(Token = "0x4003C39")]
		private const string FINAL_COMBAT_COMPLETE = "final_combat_complete";

		// Token: 0x04003C3A RID: 15418
		[Token(Token = "0x4003C3A")]
		private const string LEAVE_TOURNAMENT = "leave";
	}
}
