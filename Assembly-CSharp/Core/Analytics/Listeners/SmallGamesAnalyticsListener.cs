using System;
using Core.Events;
using Core.Events.Scopes;
using Il2CppDummyDll;

namespace Core.Analytics.Listeners
{
	// Token: 0x020012DF RID: 4831
	[Token(Token = "0x20012DF")]
	public class SmallGamesAnalyticsListener : AbstractAnalyticsListener
	{
		// Token: 0x17001743 RID: 5955
		// (get) Token: 0x060072EF RID: 29423 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17001743")]
		protected override string Theme
		{
			[Token(Token = "0x60072EF")]
			[Address(RVA = "0xBCF8", Offset = "0xBCF8", VA = "0xBCF8", Slot = "5")]
			get
			{
				return null;
			}
		}

		// Token: 0x060072F0 RID: 29424 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60072F0")]
		[Address(RVA = "0xBCF9", Offset = "0xBCF9", VA = "0xBCF9", Slot = "10")]
		public override void Init()
		{
		}

		// Token: 0x060072F1 RID: 29425 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60072F1")]
		[Address(RVA = "0xBCFA", Offset = "0xBCFA", VA = "0xBCFA", Slot = "11")]
		protected override void Deinit()
		{
		}

		// Token: 0x060072F2 RID: 29426 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60072F2")]
		[Address(RVA = "0xBCFB", Offset = "0xBCFB", VA = "0xBCFB")]
		private void SlotMachineSpinEvent(SmallGamesScope.SlotMachineSpinEventArgs e)
		{
		}

		// Token: 0x060072F3 RID: 29427 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60072F3")]
		[Address(RVA = "0xBCFC", Offset = "0xBCFC", VA = "0xBCFC")]
		private void DailyBonusTakenEvent(BaseEventBusEventArgs e)
		{
		}

		// Token: 0x060072F4 RID: 29428 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60072F4")]
		[Address(RVA = "0xBCFD", Offset = "0xBCFD", VA = "0xBCFD")]
		public SmallGamesAnalyticsListener()
		{
		}

		// Token: 0x04003C2D RID: 15405
		[Token(Token = "0x4003C2D")]
		private const string DAILY_BONUS_TAKEN = "daily_bonus_taken";

		// Token: 0x04003C2E RID: 15406
		[Token(Token = "0x4003C2E")]
		private const string SLOTMACHINE_SPIN = "slotmachine_spin";
	}
}
